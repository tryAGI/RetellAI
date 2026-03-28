#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
SPEC_URL=$(curl -s https://raw.githubusercontent.com/RetellAI/retell-python-sdk/main/.stats.yml | grep 'openapi_spec_url' | awk '{print $2}' | tr -d '"')
curl -sL "$SPEC_URL" -o openapi.yaml

# Fix 1: Comparator enum dedup — remove symbol duplicates (>, <, >=, <=) since text
#         versions (gt, ge, lt, le) already exist in AlertRule*/AlertIncident schemas.
# Fix 2: Equation operator rename — replace symbols (==, !=, >, >=, <, <=) with
#         descriptive names (eq, ne, gt, ge, lt, le) in Equation schema.
# Fix 3: EquationCondition operator rename — replace || and && with or and and.
python3 -c "
import yaml, sys

with open('openapi.yaml', 'r') as f:
    spec = yaml.safe_load(f)

schemas = spec.get('components', {}).get('schemas', {})

# Fix comparator enums - remove symbol duplicates since gt/ge/lt/le exist
for name in ['AlertRuleResponse', 'AlertRuleRequest', 'AlertIncidentResponse']:
    if name in schemas:
        props = schemas[name].get('properties', {})
        if 'comparator' in props:
            enums = props['comparator'].get('enum', [])
            # Remove symbol versions, keep text versions
            props['comparator']['enum'] = [e for e in enums if e not in ['>', '<', '>=', '<=']]

# Fix Equation operator
if 'Equation' in schemas:
    props = schemas['Equation'].get('properties', {})
    if 'operator' in props:
        old = props['operator'].get('enum', [])
        mapping = {'==': 'eq', '!=': 'ne', '>': 'gt', '>=': 'ge', '<': 'lt', '<=': 'le'}
        props['operator']['enum'] = [mapping.get(e, e) for e in old]

# Fix EquationCondition operator
if 'EquationCondition' in schemas:
    props = schemas['EquationCondition'].get('properties', {})
    if 'operator' in props:
        old = props['operator'].get('enum', [])
        mapping = {'||': 'or', '&&': 'and'}
        props['operator']['enum'] = [mapping.get(e, e) for e in old]

with open('openapi.yaml', 'w') as f:
    yaml.dump(spec, f, default_flow_style=False, allow_unicode=True, sort_keys=False, width=200)
"

autosdk generate openapi.yaml \
  --namespace RetellAI \
  --clientClassName RetellAiClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
