#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SubagentNode : global::System.IEquatable<SubagentNode>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.NodeBase? Base { get; init; }
#else
        public global::RetellAI.NodeBase? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.AgentOverrideConfig? AgentOverrideConfig { get; init; }
#else
        public global::RetellAI.AgentOverrideConfig? AgentOverrideConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentOverrideConfig))]
#endif
        public bool IsAgentOverrideConfig => AgentOverrideConfig != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.SubagentNodeVariant3? SubagentNodeVariant3 { get; init; }
#else
        public global::RetellAI.SubagentNodeVariant3? SubagentNodeVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubagentNodeVariant3))]
#endif
        public bool IsSubagentNodeVariant3 => SubagentNodeVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SubagentNode(global::RetellAI.NodeBase value) => new SubagentNode((global::RetellAI.NodeBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.NodeBase?(SubagentNode @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public SubagentNode(global::RetellAI.NodeBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SubagentNode(global::RetellAI.AgentOverrideConfig value) => new SubagentNode((global::RetellAI.AgentOverrideConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.AgentOverrideConfig?(SubagentNode @this) => @this.AgentOverrideConfig;

        /// <summary>
        /// 
        /// </summary>
        public SubagentNode(global::RetellAI.AgentOverrideConfig? value)
        {
            AgentOverrideConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SubagentNode(global::RetellAI.SubagentNodeVariant3 value) => new SubagentNode((global::RetellAI.SubagentNodeVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.SubagentNodeVariant3?(SubagentNode @this) => @this.SubagentNodeVariant3;

        /// <summary>
        /// 
        /// </summary>
        public SubagentNode(global::RetellAI.SubagentNodeVariant3? value)
        {
            SubagentNodeVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SubagentNode(
            global::RetellAI.NodeBase? @base,
            global::RetellAI.AgentOverrideConfig? agentOverrideConfig,
            global::RetellAI.SubagentNodeVariant3? subagentNodeVariant3
            )
        {
            Base = @base;
            AgentOverrideConfig = agentOverrideConfig;
            SubagentNodeVariant3 = subagentNodeVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SubagentNodeVariant3 as object ??
            AgentOverrideConfig as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            AgentOverrideConfig?.ToString() ??
            SubagentNodeVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsAgentOverrideConfig && IsSubagentNodeVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.NodeBase?, TResult>? @base = null,
            global::System.Func<global::RetellAI.AgentOverrideConfig?, TResult>? agentOverrideConfig = null,
            global::System.Func<global::RetellAI.SubagentNodeVariant3?, TResult>? subagentNodeVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsAgentOverrideConfig && agentOverrideConfig != null)
            {
                return agentOverrideConfig(AgentOverrideConfig!);
            }
            else if (IsSubagentNodeVariant3 && subagentNodeVariant3 != null)
            {
                return subagentNodeVariant3(SubagentNodeVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.NodeBase?>? @base = null,
            global::System.Action<global::RetellAI.AgentOverrideConfig?>? agentOverrideConfig = null,
            global::System.Action<global::RetellAI.SubagentNodeVariant3?>? subagentNodeVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsAgentOverrideConfig)
            {
                agentOverrideConfig?.Invoke(AgentOverrideConfig!);
            }
            else if (IsSubagentNodeVariant3)
            {
                subagentNodeVariant3?.Invoke(SubagentNodeVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::RetellAI.NodeBase),
                AgentOverrideConfig,
                typeof(global::RetellAI.AgentOverrideConfig),
                SubagentNodeVariant3,
                typeof(global::RetellAI.SubagentNodeVariant3),
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
        public bool Equals(SubagentNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.NodeBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AgentOverrideConfig?>.Default.Equals(AgentOverrideConfig, other.AgentOverrideConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.SubagentNodeVariant3?>.Default.Equals(SubagentNodeVariant3, other.SubagentNodeVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SubagentNode obj1, SubagentNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SubagentNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SubagentNode obj1, SubagentNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SubagentNode o && Equals(o);
        }
    }
}
