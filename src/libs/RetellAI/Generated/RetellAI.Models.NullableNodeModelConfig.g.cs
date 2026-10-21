#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct NullableNodeModelConfig : global::System.IEquatable<NullableNodeModelConfig>
    {
        /// <summary>
        /// Model override for this node. Only cascading flows use it.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.NodeModelConfig? NodeModelConfig { get; init; }
#else
        public global::RetellAI.NodeModelConfig? NodeModelConfig { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeModelConfig))]
#endif
        public bool IsNodeModelConfig => NodeModelConfig != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNodeModelConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.NodeModelConfig? value)
        {
            value = NodeModelConfig;
            return IsNodeModelConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeModelConfig PickNodeModelConfig() => NodeModelConfig is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NodeModelConfig' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? NullableNodeModelConfigVariant2 { get; init; }
#else
        public object? NullableNodeModelConfigVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NullableNodeModelConfigVariant2))]
#endif
        public bool IsNullableNodeModelConfigVariant2 => NullableNodeModelConfigVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNullableNodeModelConfigVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = NullableNodeModelConfigVariant2;
            return IsNullableNodeModelConfigVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickNullableNodeModelConfigVariant2() => NullableNodeModelConfigVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NullableNodeModelConfigVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator NullableNodeModelConfig(global::RetellAI.NodeModelConfig value) => new NullableNodeModelConfig((global::RetellAI.NodeModelConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.NodeModelConfig?(NullableNodeModelConfig @this) => @this.NodeModelConfig;

        /// <summary>
        ///
        /// </summary>
        public NullableNodeModelConfig(global::RetellAI.NodeModelConfig? value)
        {
            NodeModelConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NullableNodeModelConfig FromNodeModelConfig(global::RetellAI.NodeModelConfig? value) => new NullableNodeModelConfig(value);

        /// <summary>
        ///
        /// </summary>
        public NullableNodeModelConfig(
            global::RetellAI.NodeModelConfig? nodeModelConfig,
            object? nullableNodeModelConfigVariant2
            )
        {
            NodeModelConfig = nodeModelConfig;
            NullableNodeModelConfigVariant2 = nullableNodeModelConfigVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            NullableNodeModelConfigVariant2 as object ??
            NodeModelConfig as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            NodeModelConfig?.ToString() ??
            NullableNodeModelConfigVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsNodeModelConfig && !IsNullableNodeModelConfigVariant2 || !IsNodeModelConfig && IsNullableNodeModelConfigVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.NodeModelConfig, TResult>? nodeModelConfig = null,
            global::System.Func<object, TResult>? nullableNodeModelConfigVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (NodeModelConfig is { } __value0 && nodeModelConfig != null)
            {
                return nodeModelConfig(__value0);
            }
            else if (NullableNodeModelConfigVariant2 is { } __value1 && nullableNodeModelConfigVariant2 != null)
            {
                return nullableNodeModelConfigVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.NodeModelConfig>? nodeModelConfig = null,

            global::System.Action<object>? nullableNodeModelConfigVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (NodeModelConfig is { } __value0)
            {
                nodeModelConfig?.Invoke(__value0);
            }
            else if (NullableNodeModelConfigVariant2 is { } __value1)
            {
                nullableNodeModelConfigVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.NodeModelConfig>? nodeModelConfig = null,
            global::System.Action<object>? nullableNodeModelConfigVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (NodeModelConfig is { } __value0)
            {
                nodeModelConfig?.Invoke(__value0);
            }
            else if (NullableNodeModelConfigVariant2 is { } __value1)
            {
                nullableNodeModelConfigVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                NodeModelConfig,
                typeof(global::RetellAI.NodeModelConfig),
                NullableNodeModelConfigVariant2,
                typeof(object),
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
        public bool Equals(NullableNodeModelConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.NodeModelConfig?>.Default.Equals(NodeModelConfig, other.NodeModelConfig) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(NullableNodeModelConfigVariant2, other.NullableNodeModelConfigVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(NullableNodeModelConfig obj1, NullableNodeModelConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NullableNodeModelConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(NullableNodeModelConfig obj1, NullableNodeModelConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NullableNodeModelConfig o && Equals(o);
        }
    }
}
