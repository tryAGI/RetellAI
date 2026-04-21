#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolCallResultMessage : global::System.IEquatable<ToolCallResultMessage>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ToolCallResultMessageBase? Base { get; init; }
#else
        public global::RetellAI.ToolCallResultMessageBase? Base { get; }
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
        public object? ToolCallResultMessageVariant2 { get; init; }
#else
        public object? ToolCallResultMessageVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallResultMessageVariant2))]
#endif
        public bool IsToolCallResultMessageVariant2 => ToolCallResultMessageVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolCallResultMessage(global::RetellAI.ToolCallResultMessageBase value) => new ToolCallResultMessage((global::RetellAI.ToolCallResultMessageBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ToolCallResultMessageBase?(ToolCallResultMessage @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallResultMessage(global::RetellAI.ToolCallResultMessageBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolCallResultMessage(
            global::RetellAI.ToolCallResultMessageBase? @base,
            object? toolCallResultMessageVariant2
            )
        {
            Base = @base;
            ToolCallResultMessageVariant2 = toolCallResultMessageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolCallResultMessageVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ToolCallResultMessageVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsToolCallResultMessageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ToolCallResultMessageBase?, TResult>? @base = null,
            global::System.Func<object?, TResult>? toolCallResultMessageVariant2 = null,
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
            else if (IsToolCallResultMessageVariant2 && toolCallResultMessageVariant2 != null)
            {
                return toolCallResultMessageVariant2(ToolCallResultMessageVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ToolCallResultMessageBase?>? @base = null,
            global::System.Action<object?>? toolCallResultMessageVariant2 = null,
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
            else if (IsToolCallResultMessageVariant2)
            {
                toolCallResultMessageVariant2?.Invoke(ToolCallResultMessageVariant2!);
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
                typeof(global::RetellAI.ToolCallResultMessageBase),
                ToolCallResultMessageVariant2,
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
        public bool Equals(ToolCallResultMessage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ToolCallResultMessageBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ToolCallResultMessageVariant2, other.ToolCallResultMessageVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolCallResultMessage obj1, ToolCallResultMessage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolCallResultMessage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolCallResultMessage obj1, ToolCallResultMessage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolCallResultMessage o && Equals(o);
        }
    }
}
