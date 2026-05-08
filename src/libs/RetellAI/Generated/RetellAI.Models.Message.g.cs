#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Message : global::System.IEquatable<Message>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.MessageBase? Base { get; init; }
#else
        public global::RetellAI.MessageBase? Base { get; }
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
            out global::RetellAI.MessageBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? MessageVariant2 { get; init; }
#else
        public object? MessageVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageVariant2))]
#endif
        public bool IsMessageVariant2 => MessageVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMessageVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = MessageVariant2;
            return IsMessageVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Message(global::RetellAI.MessageBase value) => new Message((global::RetellAI.MessageBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.MessageBase?(Message @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public Message(global::RetellAI.MessageBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Message(
            global::RetellAI.MessageBase? @base,
            object? messageVariant2
            )
        {
            Base = @base;
            MessageVariant2 = messageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessageVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            MessageVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsMessageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.MessageBase, TResult>? @base = null,
            global::System.Func<object, TResult>? messageVariant2 = null,
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
            else if (IsMessageVariant2 && messageVariant2 != null)
            {
                return messageVariant2(MessageVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.MessageBase>? @base = null,

            global::System.Action<object>? messageVariant2 = null,
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
            else if (IsMessageVariant2)
            {
                messageVariant2?.Invoke(MessageVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.MessageBase>? @base = null,
            global::System.Action<object>? messageVariant2 = null,
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
            else if (IsMessageVariant2)
            {
                messageVariant2?.Invoke(MessageVariant2!);
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
                typeof(global::RetellAI.MessageBase),
                MessageVariant2,
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
        public bool Equals(Message other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.MessageBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(MessageVariant2, other.MessageVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Message obj1, Message obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Message>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Message obj1, Message obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Message o && Equals(o);
        }
    }
}
