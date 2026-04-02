#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FinetuneExampleUtterance : global::System.IEquatable<FinetuneExampleUtterance>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.FinetuneExampleUtteranceVariant1? FinetuneExampleUtteranceVariant1 { get; init; }
#else
        public global::RetellAI.FinetuneExampleUtteranceVariant1? FinetuneExampleUtteranceVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FinetuneExampleUtteranceVariant1))]
#endif
        public bool IsFinetuneExampleUtteranceVariant1 => FinetuneExampleUtteranceVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.FinetuneExampleUtteranceVariant2? FinetuneExampleUtteranceVariant2 { get; init; }
#else
        public global::RetellAI.FinetuneExampleUtteranceVariant2? FinetuneExampleUtteranceVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FinetuneExampleUtteranceVariant2))]
#endif
        public bool IsFinetuneExampleUtteranceVariant2 => FinetuneExampleUtteranceVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.FinetuneExampleUtteranceVariant3? FinetuneExampleUtteranceVariant3 { get; init; }
#else
        public global::RetellAI.FinetuneExampleUtteranceVariant3? FinetuneExampleUtteranceVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FinetuneExampleUtteranceVariant3))]
#endif
        public bool IsFinetuneExampleUtteranceVariant3 => FinetuneExampleUtteranceVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FinetuneExampleUtterance(global::RetellAI.FinetuneExampleUtteranceVariant1 value) => new FinetuneExampleUtterance((global::RetellAI.FinetuneExampleUtteranceVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.FinetuneExampleUtteranceVariant1?(FinetuneExampleUtterance @this) => @this.FinetuneExampleUtteranceVariant1;

        /// <summary>
        /// 
        /// </summary>
        public FinetuneExampleUtterance(global::RetellAI.FinetuneExampleUtteranceVariant1? value)
        {
            FinetuneExampleUtteranceVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FinetuneExampleUtterance(global::RetellAI.FinetuneExampleUtteranceVariant2 value) => new FinetuneExampleUtterance((global::RetellAI.FinetuneExampleUtteranceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.FinetuneExampleUtteranceVariant2?(FinetuneExampleUtterance @this) => @this.FinetuneExampleUtteranceVariant2;

        /// <summary>
        /// 
        /// </summary>
        public FinetuneExampleUtterance(global::RetellAI.FinetuneExampleUtteranceVariant2? value)
        {
            FinetuneExampleUtteranceVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FinetuneExampleUtterance(global::RetellAI.FinetuneExampleUtteranceVariant3 value) => new FinetuneExampleUtterance((global::RetellAI.FinetuneExampleUtteranceVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.FinetuneExampleUtteranceVariant3?(FinetuneExampleUtterance @this) => @this.FinetuneExampleUtteranceVariant3;

        /// <summary>
        /// 
        /// </summary>
        public FinetuneExampleUtterance(global::RetellAI.FinetuneExampleUtteranceVariant3? value)
        {
            FinetuneExampleUtteranceVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FinetuneExampleUtterance(
            global::RetellAI.FinetuneExampleUtteranceVariant1? finetuneExampleUtteranceVariant1,
            global::RetellAI.FinetuneExampleUtteranceVariant2? finetuneExampleUtteranceVariant2,
            global::RetellAI.FinetuneExampleUtteranceVariant3? finetuneExampleUtteranceVariant3
            )
        {
            FinetuneExampleUtteranceVariant1 = finetuneExampleUtteranceVariant1;
            FinetuneExampleUtteranceVariant2 = finetuneExampleUtteranceVariant2;
            FinetuneExampleUtteranceVariant3 = finetuneExampleUtteranceVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FinetuneExampleUtteranceVariant3 as object ??
            FinetuneExampleUtteranceVariant2 as object ??
            FinetuneExampleUtteranceVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FinetuneExampleUtteranceVariant1?.ToString() ??
            FinetuneExampleUtteranceVariant2?.ToString() ??
            FinetuneExampleUtteranceVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFinetuneExampleUtteranceVariant1 && !IsFinetuneExampleUtteranceVariant2 && !IsFinetuneExampleUtteranceVariant3 || !IsFinetuneExampleUtteranceVariant1 && IsFinetuneExampleUtteranceVariant2 && !IsFinetuneExampleUtteranceVariant3 || !IsFinetuneExampleUtteranceVariant1 && !IsFinetuneExampleUtteranceVariant2 && IsFinetuneExampleUtteranceVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.FinetuneExampleUtteranceVariant1?, TResult>? finetuneExampleUtteranceVariant1 = null,
            global::System.Func<global::RetellAI.FinetuneExampleUtteranceVariant2?, TResult>? finetuneExampleUtteranceVariant2 = null,
            global::System.Func<global::RetellAI.FinetuneExampleUtteranceVariant3?, TResult>? finetuneExampleUtteranceVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFinetuneExampleUtteranceVariant1 && finetuneExampleUtteranceVariant1 != null)
            {
                return finetuneExampleUtteranceVariant1(FinetuneExampleUtteranceVariant1!);
            }
            else if (IsFinetuneExampleUtteranceVariant2 && finetuneExampleUtteranceVariant2 != null)
            {
                return finetuneExampleUtteranceVariant2(FinetuneExampleUtteranceVariant2!);
            }
            else if (IsFinetuneExampleUtteranceVariant3 && finetuneExampleUtteranceVariant3 != null)
            {
                return finetuneExampleUtteranceVariant3(FinetuneExampleUtteranceVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.FinetuneExampleUtteranceVariant1?>? finetuneExampleUtteranceVariant1 = null,
            global::System.Action<global::RetellAI.FinetuneExampleUtteranceVariant2?>? finetuneExampleUtteranceVariant2 = null,
            global::System.Action<global::RetellAI.FinetuneExampleUtteranceVariant3?>? finetuneExampleUtteranceVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFinetuneExampleUtteranceVariant1)
            {
                finetuneExampleUtteranceVariant1?.Invoke(FinetuneExampleUtteranceVariant1!);
            }
            else if (IsFinetuneExampleUtteranceVariant2)
            {
                finetuneExampleUtteranceVariant2?.Invoke(FinetuneExampleUtteranceVariant2!);
            }
            else if (IsFinetuneExampleUtteranceVariant3)
            {
                finetuneExampleUtteranceVariant3?.Invoke(FinetuneExampleUtteranceVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FinetuneExampleUtteranceVariant1,
                typeof(global::RetellAI.FinetuneExampleUtteranceVariant1),
                FinetuneExampleUtteranceVariant2,
                typeof(global::RetellAI.FinetuneExampleUtteranceVariant2),
                FinetuneExampleUtteranceVariant3,
                typeof(global::RetellAI.FinetuneExampleUtteranceVariant3),
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
        public bool Equals(FinetuneExampleUtterance other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.FinetuneExampleUtteranceVariant1?>.Default.Equals(FinetuneExampleUtteranceVariant1, other.FinetuneExampleUtteranceVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.FinetuneExampleUtteranceVariant2?>.Default.Equals(FinetuneExampleUtteranceVariant2, other.FinetuneExampleUtteranceVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.FinetuneExampleUtteranceVariant3?>.Default.Equals(FinetuneExampleUtteranceVariant3, other.FinetuneExampleUtteranceVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FinetuneExampleUtterance obj1, FinetuneExampleUtterance obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FinetuneExampleUtterance>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FinetuneExampleUtterance obj1, FinetuneExampleUtterance obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FinetuneExampleUtterance o && Equals(o);
        }
    }
}
