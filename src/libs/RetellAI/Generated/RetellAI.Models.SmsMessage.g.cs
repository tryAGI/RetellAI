#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SmsMessage : global::System.IEquatable<SmsMessage>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.SmsMessageBase? Base { get; init; }
#else
        public global::RetellAI.SmsMessageBase? Base { get; }
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
            out global::RetellAI.SmsMessageBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.SmsMessageBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? SmsMessageVariant2 { get; init; }
#else
        public object? SmsMessageVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SmsMessageVariant2))]
#endif
        public bool IsSmsMessageVariant2 => SmsMessageVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSmsMessageVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = SmsMessageVariant2;
            return IsSmsMessageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickSmsMessageVariant2() => IsSmsMessageVariant2
            ? SmsMessageVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SmsMessageVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SmsMessage(global::RetellAI.SmsMessageBase value) => new SmsMessage((global::RetellAI.SmsMessageBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.SmsMessageBase?(SmsMessage @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public SmsMessage(global::RetellAI.SmsMessageBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SmsMessage FromBase(global::RetellAI.SmsMessageBase? value) => new SmsMessage(value);

        /// <summary>
        /// 
        /// </summary>
        public SmsMessage(
            global::RetellAI.SmsMessageBase? @base,
            object? smsMessageVariant2
            )
        {
            Base = @base;
            SmsMessageVariant2 = smsMessageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SmsMessageVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            SmsMessageVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsSmsMessageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.SmsMessageBase, TResult>? @base = null,
            global::System.Func<object, TResult>? smsMessageVariant2 = null,
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
            else if (IsSmsMessageVariant2 && smsMessageVariant2 != null)
            {
                return smsMessageVariant2(SmsMessageVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.SmsMessageBase>? @base = null,

            global::System.Action<object>? smsMessageVariant2 = null,
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
            else if (IsSmsMessageVariant2)
            {
                smsMessageVariant2?.Invoke(SmsMessageVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.SmsMessageBase>? @base = null,
            global::System.Action<object>? smsMessageVariant2 = null,
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
            else if (IsSmsMessageVariant2)
            {
                smsMessageVariant2?.Invoke(SmsMessageVariant2!);
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
                typeof(global::RetellAI.SmsMessageBase),
                SmsMessageVariant2,
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
        public bool Equals(SmsMessage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.SmsMessageBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(SmsMessageVariant2, other.SmsMessageVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SmsMessage obj1, SmsMessage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SmsMessage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SmsMessage obj1, SmsMessage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SmsMessage o && Equals(o);
        }
    }
}
