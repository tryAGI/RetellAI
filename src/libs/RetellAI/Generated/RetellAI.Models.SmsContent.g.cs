#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SmsContent : global::System.IEquatable<SmsContent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.SmsContentPredefined? Predefined { get; init; }
#else
        public global::RetellAI.SmsContentPredefined? Predefined { get; }
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
        public global::RetellAI.SmsContentInferred? Inferred { get; init; }
#else
        public global::RetellAI.SmsContentInferred? Inferred { get; }
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
        public static implicit operator SmsContent(global::RetellAI.SmsContentPredefined value) => new SmsContent((global::RetellAI.SmsContentPredefined?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.SmsContentPredefined?(SmsContent @this) => @this.Predefined;

        /// <summary>
        /// 
        /// </summary>
        public SmsContent(global::RetellAI.SmsContentPredefined? value)
        {
            Predefined = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SmsContent(global::RetellAI.SmsContentInferred value) => new SmsContent((global::RetellAI.SmsContentInferred?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.SmsContentInferred?(SmsContent @this) => @this.Inferred;

        /// <summary>
        /// 
        /// </summary>
        public SmsContent(global::RetellAI.SmsContentInferred? value)
        {
            Inferred = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SmsContent(
            global::RetellAI.SmsContentPredefined? predefined,
            global::RetellAI.SmsContentInferred? inferred
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
            global::System.Func<global::RetellAI.SmsContentPredefined?, TResult>? predefined = null,
            global::System.Func<global::RetellAI.SmsContentInferred?, TResult>? inferred = null,
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
            global::System.Action<global::RetellAI.SmsContentPredefined?>? predefined = null,
            global::System.Action<global::RetellAI.SmsContentInferred?>? inferred = null,
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
                typeof(global::RetellAI.SmsContentPredefined),
                Inferred,
                typeof(global::RetellAI.SmsContentInferred),
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
        public bool Equals(SmsContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.SmsContentPredefined?>.Default.Equals(Predefined, other.Predefined) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.SmsContentInferred?>.Default.Equals(Inferred, other.Inferred) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SmsContent obj1, SmsContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SmsContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SmsContent obj1, SmsContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SmsContent o && Equals(o);
        }
    }
}
