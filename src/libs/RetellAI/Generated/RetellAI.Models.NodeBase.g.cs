#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct NodeBase : global::System.IEquatable<NodeBase>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.NodeBaseCommon? Common { get; init; }
#else
        public global::RetellAI.NodeBaseCommon? Common { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Common))]
#endif
        public bool IsCommon => Common != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.NodeBaseVariant2? NodeBaseVariant2 { get; init; }
#else
        public global::RetellAI.NodeBaseVariant2? NodeBaseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeBaseVariant2))]
#endif
        public bool IsNodeBaseVariant2 => NodeBaseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeBase(global::RetellAI.NodeBaseCommon value) => new NodeBase((global::RetellAI.NodeBaseCommon?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.NodeBaseCommon?(NodeBase @this) => @this.Common;

        /// <summary>
        /// 
        /// </summary>
        public NodeBase(global::RetellAI.NodeBaseCommon? value)
        {
            Common = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeBase(global::RetellAI.NodeBaseVariant2 value) => new NodeBase((global::RetellAI.NodeBaseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.NodeBaseVariant2?(NodeBase @this) => @this.NodeBaseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public NodeBase(global::RetellAI.NodeBaseVariant2? value)
        {
            NodeBaseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public NodeBase(
            global::RetellAI.NodeBaseCommon? common,
            global::RetellAI.NodeBaseVariant2? nodeBaseVariant2
            )
        {
            Common = common;
            NodeBaseVariant2 = nodeBaseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            NodeBaseVariant2 as object ??
            Common as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Common?.ToString() ??
            NodeBaseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCommon && IsNodeBaseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.NodeBaseCommon?, TResult>? common = null,
            global::System.Func<global::RetellAI.NodeBaseVariant2?, TResult>? nodeBaseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCommon && common != null)
            {
                return common(Common!);
            }
            else if (IsNodeBaseVariant2 && nodeBaseVariant2 != null)
            {
                return nodeBaseVariant2(NodeBaseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.NodeBaseCommon?>? common = null,
            global::System.Action<global::RetellAI.NodeBaseVariant2?>? nodeBaseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCommon)
            {
                common?.Invoke(Common!);
            }
            else if (IsNodeBaseVariant2)
            {
                nodeBaseVariant2?.Invoke(NodeBaseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Common,
                typeof(global::RetellAI.NodeBaseCommon),
                NodeBaseVariant2,
                typeof(global::RetellAI.NodeBaseVariant2),
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
        public bool Equals(NodeBase other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.NodeBaseCommon?>.Default.Equals(Common, other.Common) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.NodeBaseVariant2?>.Default.Equals(NodeBaseVariant2, other.NodeBaseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(NodeBase obj1, NodeBase obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NodeBase>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(NodeBase obj1, NodeBase obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NodeBase o && Equals(o);
        }
    }
}
