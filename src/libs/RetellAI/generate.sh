#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: resolved from RetellAI/retell-python-sdk/.stats.yml (Stainless-hosted)

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
SPEC_URL=$(curl --fail --silent --show-error -L https://raw.githubusercontent.com/RetellAI/retell-python-sdk/main/.stats.yml | grep 'openapi_spec_url' | awk '{print $2}' | tr -d '"')
curl --fail --silent --show-error -L "$SPEC_URL" -o openapi.yaml

# Fix 1: Comparator enum dedup — remove symbol duplicates (>, <, >=, <=) since text
#         versions (gt, ge, lt, le) already exist in AlertRule*/AlertIncident schemas.
#         AutoSDK generates Gt/Gt2 disambiguation which is confusing; removing duplicates is cleaner.
# Fix 2: EquationCondition operator rename — replace || and && with or and and.
#         AutoSDK generates x__/x__2 for these which is unusable.
# Note: Equation operator symbols (==, !=, >, etc.) no longer need fixing —
#       AutoSDK dev.154+ generates clean names (Eq, Neq, Gt, etc.) natively.
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
