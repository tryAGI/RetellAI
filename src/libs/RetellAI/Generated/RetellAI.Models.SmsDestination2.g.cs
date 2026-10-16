#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct SmsDestination2 : global::System.IEquatable<SmsDestination2>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.SmsDestinationDestinationCustomerNumber? DestinationCustomerNumber { get; init; }
#else
        public global::RetellAI.SmsDestinationDestinationCustomerNumber? DestinationCustomerNumber { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DestinationCustomerNumber))]
#endif
        public bool IsDestinationCustomerNumber => DestinationCustomerNumber != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDestinationCustomerNumber(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.SmsDestinationDestinationCustomerNumber? value)
        {
            value = DestinationCustomerNumber;
            return IsDestinationCustomerNumber;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsDestinationDestinationCustomerNumber PickDestinationCustomerNumber() => DestinationCustomerNumber is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DestinationCustomerNumber' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.SmsDestinationDestinationPhoneNumber? DestinationPhoneNumber { get; init; }
#else
        public global::RetellAI.SmsDestinationDestinationPhoneNumber? DestinationPhoneNumber { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DestinationPhoneNumber))]
#endif
        public bool IsDestinationPhoneNumber => DestinationPhoneNumber != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDestinationPhoneNumber(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.SmsDestinationDestinationPhoneNumber? value)
        {
            value = DestinationPhoneNumber;
            return IsDestinationPhoneNumber;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsDestinationDestinationPhoneNumber PickDestinationPhoneNumber() => DestinationPhoneNumber is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DestinationPhoneNumber' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SmsDestination2(global::RetellAI.SmsDestinationDestinationCustomerNumber value) => new SmsDestination2((global::RetellAI.SmsDestinationDestinationCustomerNumber?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.SmsDestinationDestinationCustomerNumber?(SmsDestination2 @this) => @this.DestinationCustomerNumber;

        /// <summary>
        ///
        /// </summary>
        public SmsDestination2(global::RetellAI.SmsDestinationDestinationCustomerNumber? value)
        {
            DestinationCustomerNumber = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SmsDestination2 FromDestinationCustomerNumber(global::RetellAI.SmsDestinationDestinationCustomerNumber? value) => new SmsDestination2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SmsDestination2(global::RetellAI.SmsDestinationDestinationPhoneNumber value) => new SmsDestination2((global::RetellAI.SmsDestinationDestinationPhoneNumber?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.SmsDestinationDestinationPhoneNumber?(SmsDestination2 @this) => @this.DestinationPhoneNumber;

        /// <summary>
        ///
        /// </summary>
        public SmsDestination2(global::RetellAI.SmsDestinationDestinationPhoneNumber? value)
        {
            DestinationPhoneNumber = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SmsDestination2 FromDestinationPhoneNumber(global::RetellAI.SmsDestinationDestinationPhoneNumber? value) => new SmsDestination2(value);

        /// <summary>
        ///
        /// </summary>
        public SmsDestination2(
            global::RetellAI.SmsDestinationDestinationCustomerNumber? destinationCustomerNumber,
            global::RetellAI.SmsDestinationDestinationPhoneNumber? destinationPhoneNumber
            )
        {
            DestinationCustomerNumber = destinationCustomerNumber;
            DestinationPhoneNumber = destinationPhoneNumber;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            DestinationPhoneNumber as object ??
            DestinationCustomerNumber as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            DestinationCustomerNumber?.ToString() ??
            DestinationPhoneNumber?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDestinationCustomerNumber && !IsDestinationPhoneNumber || !IsDestinationCustomerNumber && IsDestinationPhoneNumber;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.SmsDestinationDestinationCustomerNumber, TResult>? destinationCustomerNumber = null,
            global::System.Func<global::RetellAI.SmsDestinationDestinationPhoneNumber, TResult>? destinationPhoneNumber = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (DestinationCustomerNumber is { } __value0 && destinationCustomerNumber != null)
            {
                return destinationCustomerNumber(__value0);
            }
            else if (DestinationPhoneNumber is { } __value1 && destinationPhoneNumber != null)
            {
                return destinationPhoneNumber(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.SmsDestinationDestinationCustomerNumber>? destinationCustomerNumber = null,

            global::System.Action<global::RetellAI.SmsDestinationDestinationPhoneNumber>? destinationPhoneNumber = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (DestinationCustomerNumber is { } __value0)
            {
                destinationCustomerNumber?.Invoke(__value0);
            }
            else if (DestinationPhoneNumber is { } __value1)
            {
                destinationPhoneNumber?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.SmsDestinationDestinationCustomerNumber>? destinationCustomerNumber = null,
            global::System.Action<global::RetellAI.SmsDestinationDestinationPhoneNumber>? destinationPhoneNumber = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (DestinationCustomerNumber is { } __value0)
            {
                destinationCustomerNumber?.Invoke(__value0);
            }
            else if (DestinationPhoneNumber is { } __value1)
            {
                destinationPhoneNumber?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DestinationCustomerNumber,
                typeof(global::RetellAI.SmsDestinationDestinationCustomerNumber),
                DestinationPhoneNumber,
                typeof(global::RetellAI.SmsDestinationDestinationPhoneNumber),
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
        public bool Equals(SmsDestination2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.SmsDestinationDestinationCustomerNumber?>.Default.Equals(DestinationCustomerNumber, other.DestinationCustomerNumber) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.SmsDestinationDestinationPhoneNumber?>.Default.Equals(DestinationPhoneNumber, other.DestinationPhoneNumber)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SmsDestination2 obj1, SmsDestination2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SmsDestination2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SmsDestination2 obj1, SmsDestination2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SmsDestination2 o && Equals(o);
        }
    }
}
