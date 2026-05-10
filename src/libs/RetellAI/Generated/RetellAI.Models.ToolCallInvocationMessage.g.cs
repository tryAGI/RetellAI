#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolCallInvocationMessage : global::System.IEquatable<ToolCallInvocationMessage>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ToolCallInvocationMessageBase? Base { get; init; }
#else
        public global::RetellAI.ToolCallInvocationMessageBase? Base { get; }
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
            out global::RetellAI.ToolCallInvocationMessageBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.ToolCallInvocationMessageBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ToolCallInvocationMessageVariant2 { get; init; }
#else
        public object? ToolCallInvocationMessageVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallInvocationMessageVariant2))]
#endif
        public bool IsToolCallInvocationMessageVariant2 => ToolCallInvocationMessageVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickToolCallInvocationMessageVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = ToolCallInvocationMessageVariant2;
            return IsToolCallInvocationMessageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickToolCallInvocationMessageVariant2() => IsToolCallInvocationMessageVariant2
            ? ToolCallInvocationMessageVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolCallInvocationMessageVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolCallInvocationMessage(global::RetellAI.ToolCallInvocationMessageBase value) => new ToolCallInvocationMessage((global::RetellAI.ToolCallInvocationMessageBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ToolCallInvocationMessageBase?(ToolCallInvocationMessage @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallInvocationMessage(global::RetellAI.ToolCallInvocationMessageBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolCallInvocationMessage FromBase(global::RetellAI.ToolCallInvocationMessageBase? value) => new ToolCallInvocationMessage(value);

        /// <summary>
        /// 
        /// </summary>
        public ToolCallInvocationMessage(
            global::RetellAI.ToolCallInvocationMessageBase? @base,
            object? toolCallInvocationMessageVariant2
            )
        {
            Base = @base;
            ToolCallInvocationMessageVariant2 = toolCallInvocationMessageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolCallInvocationMessageVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ToolCallInvocationMessageVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsToolCallInvocationMessageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ToolCallInvocationMessageBase, TResult>? @base = null,
            global::System.Func<object, TResult>? toolCallInvocationMessageVariant2 = null,
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
            else if (IsToolCallInvocationMessageVariant2 && toolCallInvocationMessageVariant2 != null)
            {
                return toolCallInvocationMessageVariant2(ToolCallInvocationMessageVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ToolCallInvocationMessageBase>? @base = null,

            global::System.Action<object>? toolCallInvocationMessageVariant2 = null,
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
            else if (IsToolCallInvocationMessageVariant2)
            {
                toolCallInvocationMessageVariant2?.Invoke(ToolCallInvocationMessageVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ToolCallInvocationMessageBase>? @base = null,
            global::System.Action<object>? toolCallInvocationMessageVariant2 = null,
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
            else if (IsToolCallInvocationMessageVariant2)
            {
                toolCallInvocationMessageVariant2?.Invoke(ToolCallInvocationMessageVariant2!);
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
                typeof(global::RetellAI.ToolCallInvocationMessageBase),
                ToolCallInvocationMessageVariant2,
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
        public bool Equals(ToolCallInvocationMessage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ToolCallInvocationMessageBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ToolCallInvocationMessageVariant2, other.ToolCallInvocationMessageVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolCallInvocationMessage obj1, ToolCallInvocationMessage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolCallInvocationMessage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolCallInvocationMessage obj1, ToolCallInvocationMessage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolCallInvocationMessage o && Equals(o);
        }
    }
}
