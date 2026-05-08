#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Agent version reference. Supports a numeric version (for example 3) or a tag/environment name (for example "prod"). When a tag is provided, resolution uses that exact tag assignment (including its dynamic variables). If the tag exists but is currently unassigned, it resolves to latest. When a numeric version (or latest) is provided, resolution applies dynamic variables from the preferred tag for that resolved version (most recently assigned), if any.
    /// </summary>
    public readonly partial struct AgentVersionReference : global::System.IEquatable<AgentVersionReference>
    {
        /// <summary>
        /// Example: 1
        /// </summary>
#if NET6_0_OR_GREATER
        public int? AgentVersionReferenceVariant1 { get; init; }
#else
        public int? AgentVersionReferenceVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentVersionReferenceVariant1))]
#endif
        public bool IsAgentVersionReferenceVariant1 => AgentVersionReferenceVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentVersionReferenceVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out int? value)
        {
            value = AgentVersionReferenceVariant1;
            return IsAgentVersionReferenceVariant1;
        }

        /// <summary>
        /// Example: prod
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AgentVersionReferenceVariant2 { get; init; }
#else
        public string? AgentVersionReferenceVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentVersionReferenceVariant2))]
#endif
        public bool IsAgentVersionReferenceVariant2 => AgentVersionReferenceVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentVersionReferenceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = AgentVersionReferenceVariant2;
            return IsAgentVersionReferenceVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentVersionReference(int value) => new AgentVersionReference((int?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator int?(AgentVersionReference @this) => @this.AgentVersionReferenceVariant1;

        /// <summary>
        /// 
        /// </summary>
        public AgentVersionReference(int? value)
        {
            AgentVersionReferenceVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentVersionReference(string value) => new AgentVersionReference((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(AgentVersionReference @this) => @this.AgentVersionReferenceVariant2;

        /// <summary>
        /// 
        /// </summary>
        public AgentVersionReference(string? value)
        {
            AgentVersionReferenceVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentVersionReference(
            int? agentVersionReferenceVariant1,
            string? agentVersionReferenceVariant2
            )
        {
            AgentVersionReferenceVariant1 = agentVersionReferenceVariant1;
            AgentVersionReferenceVariant2 = agentVersionReferenceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AgentVersionReferenceVariant2 as object ??
            AgentVersionReferenceVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentVersionReferenceVariant1?.ToString() ??
            AgentVersionReferenceVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentVersionReferenceVariant1 && !IsAgentVersionReferenceVariant2 || !IsAgentVersionReferenceVariant1 && IsAgentVersionReferenceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<int?, TResult>? agentVersionReferenceVariant1 = null,
            global::System.Func<string, TResult>? agentVersionReferenceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentVersionReferenceVariant1 && agentVersionReferenceVariant1 != null)
            {
                return agentVersionReferenceVariant1(AgentVersionReferenceVariant1!);
            }
            else if (IsAgentVersionReferenceVariant2 && agentVersionReferenceVariant2 != null)
            {
                return agentVersionReferenceVariant2(AgentVersionReferenceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<int?>? agentVersionReferenceVariant1 = null,

            global::System.Action<string>? agentVersionReferenceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentVersionReferenceVariant1)
            {
                agentVersionReferenceVariant1?.Invoke(AgentVersionReferenceVariant1!);
            }
            else if (IsAgentVersionReferenceVariant2)
            {
                agentVersionReferenceVariant2?.Invoke(AgentVersionReferenceVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<int?>? agentVersionReferenceVariant1 = null,
            global::System.Action<string>? agentVersionReferenceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentVersionReferenceVariant1)
            {
                agentVersionReferenceVariant1?.Invoke(AgentVersionReferenceVariant1!);
            }
            else if (IsAgentVersionReferenceVariant2)
            {
                agentVersionReferenceVariant2?.Invoke(AgentVersionReferenceVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AgentVersionReferenceVariant1,
                typeof(int),
                AgentVersionReferenceVariant2,
                typeof(string),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(AgentVersionReference other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(AgentVersionReferenceVariant1, other.AgentVersionReferenceVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AgentVersionReferenceVariant2, other.AgentVersionReferenceVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentVersionReference obj1, AgentVersionReference obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentVersionReference>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentVersionReference obj1, AgentVersionReference obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentVersionReference o && Equals(o);
        }
    }
}
