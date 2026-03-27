#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TransferDestination : global::System.IEquatable<TransferDestination>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TransferDestinationPredefined? Predefined { get; init; }
#else
        public global::RetellAI.TransferDestinationPredefined? Predefined { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Predefined))]
#endif
        public bool IsPredefined => Predefined != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TransferDestinationInferred? Inferred { get; init; }
#else
        public global::RetellAI.TransferDestinationInferred? Inferred { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Inferred))]
#endif
        public bool IsInferred => Inferred != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransferDestination(global::RetellAI.TransferDestinationPredefined value) => new TransferDestination((global::RetellAI.TransferDestinationPredefined?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.TransferDestinationPredefined?(TransferDestination @this) => @this.Predefined;

        /// <summary>
        /// 
        /// </summary>
        public TransferDestination(global::RetellAI.TransferDestinationPredefined? value)
        {
            Predefined = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransferDestination(global::RetellAI.TransferDestinationInferred value) => new TransferDestination((global::RetellAI.TransferDestinationInferred?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.TransferDestinationInferred?(TransferDestination @this) => @this.Inferred;

        /// <summary>
        /// 
        /// </summary>
        public TransferDestination(global::RetellAI.TransferDestinationInferred? value)
        {
            Inferred = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TransferDestination(
            global::RetellAI.TransferDestinationPredefined? predefined,
            global::RetellAI.TransferDestinationInferred? inferred
            )
        {
            Predefined = predefined;
            Inferred = inferred;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Inferred as object ??
            Predefined as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Predefined?.ToString() ??
            Inferred?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPredefined && !IsInferred || !IsPredefined && IsInferred;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.TransferDestinationPredefined?, TResult>? predefined = null,
            global::System.Func<global::RetellAI.TransferDestinationInferred?, TResult>? inferred = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPredefined && predefined != null)
            {
                return predefined(Predefined!);
            }
            else if (IsInferred && inferred != null)
            {
                return inferred(Inferred!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.TransferDestinationPredefined?>? predefined = null,
            global::System.Action<global::RetellAI.TransferDestinationInferred?>? inferred = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPredefined)
            {
                predefined?.Invoke(Predefined!);
            }
            else if (IsInferred)
            {
                inferred?.Invoke(Inferred!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Predefined,
                typeof(global::RetellAI.TransferDestinationPredefined),
                Inferred,
                typeof(global::RetellAI.TransferDestinationInferred),
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
        public bool Equals(TransferDestination other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TransferDestinationPredefined?>.Default.Equals(Predefined, other.Predefined) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TransferDestinationInferred?>.Default.Equals(Inferred, other.Inferred) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TransferDestination obj1, TransferDestination obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TransferDestination>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TransferDestination obj1, TransferDestination obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TransferDestination o && Equals(o);
        }
    }
}
