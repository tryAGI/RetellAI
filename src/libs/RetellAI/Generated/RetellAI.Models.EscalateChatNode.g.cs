#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct EscalateChatNode : global::System.IEquatable<EscalateChatNode>
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
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.NodeBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeBase PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.EscalateChatNodeVariant2? EscalateChatNodeVariant2 { get; init; }
#else
        public global::RetellAI.EscalateChatNodeVariant2? EscalateChatNodeVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EscalateChatNodeVariant2))]
#endif
        public bool IsEscalateChatNodeVariant2 => EscalateChatNodeVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEscalateChatNodeVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.EscalateChatNodeVariant2? value)
        {
            value = EscalateChatNodeVariant2;
            return IsEscalateChatNodeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalateChatNodeVariant2 PickEscalateChatNodeVariant2() => EscalateChatNodeVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'EscalateChatNodeVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EscalateChatNode(global::RetellAI.NodeBase value) => new EscalateChatNode((global::RetellAI.NodeBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.NodeBase?(EscalateChatNode @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public EscalateChatNode(global::RetellAI.NodeBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EscalateChatNode FromBase(global::RetellAI.NodeBase? value) => new EscalateChatNode(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EscalateChatNode(global::RetellAI.EscalateChatNodeVariant2 value) => new EscalateChatNode((global::RetellAI.EscalateChatNodeVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.EscalateChatNodeVariant2?(EscalateChatNode @this) => @this.EscalateChatNodeVariant2;

        /// <summary>
        ///
        /// </summary>
        public EscalateChatNode(global::RetellAI.EscalateChatNodeVariant2? value)
        {
            EscalateChatNodeVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EscalateChatNode FromEscalateChatNodeVariant2(global::RetellAI.EscalateChatNodeVariant2? value) => new EscalateChatNode(value);

        /// <summary>
        ///
        /// </summary>
        public EscalateChatNode(
            global::RetellAI.NodeBase? @base,
            global::RetellAI.EscalateChatNodeVariant2? escalateChatNodeVariant2
            )
        {
            Base = @base;
            EscalateChatNodeVariant2 = escalateChatNodeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            EscalateChatNodeVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            EscalateChatNodeVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsEscalateChatNodeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.NodeBase?, TResult>? @base = null,
            global::System.Func<global::RetellAI.EscalateChatNodeVariant2, TResult>? escalateChatNodeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0 && @base != null)
            {
                return @base(__value0);
            }
            else if (EscalateChatNodeVariant2 is { } __value1 && escalateChatNodeVariant2 != null)
            {
                return escalateChatNodeVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.NodeBase?>? @base = null,

            global::System.Action<global::RetellAI.EscalateChatNodeVariant2>? escalateChatNodeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (EscalateChatNodeVariant2 is { } __value1)
            {
                escalateChatNodeVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.NodeBase?>? @base = null,
            global::System.Action<global::RetellAI.EscalateChatNodeVariant2>? escalateChatNodeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (EscalateChatNodeVariant2 is { } __value1)
            {
                escalateChatNodeVariant2?.Invoke(__value1);
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
                EscalateChatNodeVariant2,
                typeof(global::RetellAI.EscalateChatNodeVariant2),
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
        public bool Equals(EscalateChatNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.NodeBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.EscalateChatNodeVariant2?>.Default.Equals(EscalateChatNodeVariant2, other.EscalateChatNodeVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EscalateChatNode obj1, EscalateChatNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EscalateChatNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EscalateChatNode obj1, EscalateChatNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EscalateChatNode o && Equals(o);
        }
    }
}
