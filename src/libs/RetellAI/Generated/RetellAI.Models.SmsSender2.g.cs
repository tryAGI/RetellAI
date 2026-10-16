#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct SmsSender2 : global::System.IEquatable<SmsSender2>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.SmsSenderSenderCurrentNumber? SenderCurrentNumber { get; init; }
#else
        public global::RetellAI.SmsSenderSenderCurrentNumber? SenderCurrentNumber { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SenderCurrentNumber))]
#endif
        public bool IsSenderCurrentNumber => SenderCurrentNumber != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSenderCurrentNumber(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.SmsSenderSenderCurrentNumber? value)
        {
            value = SenderCurrentNumber;
            return IsSenderCurrentNumber;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSenderSenderCurrentNumber PickSenderCurrentNumber() => SenderCurrentNumber is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SenderCurrentNumber' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.SmsSenderSenderRetellLongCode? SenderRetellLongCode { get; init; }
#else
        public global::RetellAI.SmsSenderSenderRetellLongCode? SenderRetellLongCode { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SenderRetellLongCode))]
#endif
        public bool IsSenderRetellLongCode => SenderRetellLongCode != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSenderRetellLongCode(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.SmsSenderSenderRetellLongCode? value)
        {
            value = SenderRetellLongCode;
            return IsSenderRetellLongCode;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSenderSenderRetellLongCode PickSenderRetellLongCode() => SenderRetellLongCode is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SenderRetellLongCode' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SmsSender2(global::RetellAI.SmsSenderSenderCurrentNumber value) => new SmsSender2((global::RetellAI.SmsSenderSenderCurrentNumber?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.SmsSenderSenderCurrentNumber?(SmsSender2 @this) => @this.SenderCurrentNumber;

        /// <summary>
        ///
        /// </summary>
        public SmsSender2(global::RetellAI.SmsSenderSenderCurrentNumber? value)
        {
            SenderCurrentNumber = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SmsSender2 FromSenderCurrentNumber(global::RetellAI.SmsSenderSenderCurrentNumber? value) => new SmsSender2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SmsSender2(global::RetellAI.SmsSenderSenderRetellLongCode value) => new SmsSender2((global::RetellAI.SmsSenderSenderRetellLongCode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.SmsSenderSenderRetellLongCode?(SmsSender2 @this) => @this.SenderRetellLongCode;

        /// <summary>
        ///
        /// </summary>
        public SmsSender2(global::RetellAI.SmsSenderSenderRetellLongCode? value)
        {
            SenderRetellLongCode = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SmsSender2 FromSenderRetellLongCode(global::RetellAI.SmsSenderSenderRetellLongCode? value) => new SmsSender2(value);

        /// <summary>
        ///
        /// </summary>
        public SmsSender2(
            global::RetellAI.SmsSenderSenderCurrentNumber? senderCurrentNumber,
            global::RetellAI.SmsSenderSenderRetellLongCode? senderRetellLongCode
            )
        {
            SenderCurrentNumber = senderCurrentNumber;
            SenderRetellLongCode = senderRetellLongCode;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SenderRetellLongCode as object ??
            SenderCurrentNumber as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SenderCurrentNumber?.ToString() ??
            SenderRetellLongCode?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSenderCurrentNumber && !IsSenderRetellLongCode || !IsSenderCurrentNumber && IsSenderRetellLongCode;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.SmsSenderSenderCurrentNumber, TResult>? senderCurrentNumber = null,
            global::System.Func<global::RetellAI.SmsSenderSenderRetellLongCode, TResult>? senderRetellLongCode = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SenderCurrentNumber is { } __value0 && senderCurrentNumber != null)
            {
                return senderCurrentNumber(__value0);
            }
            else if (SenderRetellLongCode is { } __value1 && senderRetellLongCode != null)
            {
                return senderRetellLongCode(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.SmsSenderSenderCurrentNumber>? senderCurrentNumber = null,

            global::System.Action<global::RetellAI.SmsSenderSenderRetellLongCode>? senderRetellLongCode = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SenderCurrentNumber is { } __value0)
            {
                senderCurrentNumber?.Invoke(__value0);
            }
            else if (SenderRetellLongCode is { } __value1)
            {
                senderRetellLongCode?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.SmsSenderSenderCurrentNumber>? senderCurrentNumber = null,
            global::System.Action<global::RetellAI.SmsSenderSenderRetellLongCode>? senderRetellLongCode = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SenderCurrentNumber is { } __value0)
            {
                senderCurrentNumber?.Invoke(__value0);
            }
            else if (SenderRetellLongCode is { } __value1)
            {
                senderRetellLongCode?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SenderCurrentNumber,
                typeof(global::RetellAI.SmsSenderSenderCurrentNumber),
                SenderRetellLongCode,
                typeof(global::RetellAI.SmsSenderSenderRetellLongCode),
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
        public bool Equals(SmsSender2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.SmsSenderSenderCurrentNumber?>.Default.Equals(SenderCurrentNumber, other.SenderCurrentNumber) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.SmsSenderSenderRetellLongCode?>.Default.Equals(SenderRetellLongCode, other.SenderRetellLongCode)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SmsSender2 obj1, SmsSender2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SmsSender2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SmsSender2 obj1, SmsSender2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SmsSender2 o && Equals(o);
        }
    }
}
