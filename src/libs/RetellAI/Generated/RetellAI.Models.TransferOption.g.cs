#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TransferOption : global::System.IEquatable<TransferOption>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TransferOptionColdTransfer? ColdTransfer { get; init; }
#else
        public global::RetellAI.TransferOptionColdTransfer? ColdTransfer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ColdTransfer))]
#endif
        public bool IsColdTransfer => ColdTransfer != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TransferOptionWarmTransfer? WarmTransfer { get; init; }
#else
        public global::RetellAI.TransferOptionWarmTransfer? WarmTransfer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WarmTransfer))]
#endif
        public bool IsWarmTransfer => WarmTransfer != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TransferOptionAgenticWarmTransfer? AgenticWarmTransfer { get; init; }
#else
        public global::RetellAI.TransferOptionAgenticWarmTransfer? AgenticWarmTransfer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgenticWarmTransfer))]
#endif
        public bool IsAgenticWarmTransfer => AgenticWarmTransfer != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransferOption(global::RetellAI.TransferOptionColdTransfer value) => new TransferOption((global::RetellAI.TransferOptionColdTransfer?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.TransferOptionColdTransfer?(TransferOption @this) => @this.ColdTransfer;

        /// <summary>
        /// 
        /// </summary>
        public TransferOption(global::RetellAI.TransferOptionColdTransfer? value)
        {
            ColdTransfer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransferOption(global::RetellAI.TransferOptionWarmTransfer value) => new TransferOption((global::RetellAI.TransferOptionWarmTransfer?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.TransferOptionWarmTransfer?(TransferOption @this) => @this.WarmTransfer;

        /// <summary>
        /// 
        /// </summary>
        public TransferOption(global::RetellAI.TransferOptionWarmTransfer? value)
        {
            WarmTransfer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransferOption(global::RetellAI.TransferOptionAgenticWarmTransfer value) => new TransferOption((global::RetellAI.TransferOptionAgenticWarmTransfer?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.TransferOptionAgenticWarmTransfer?(TransferOption @this) => @this.AgenticWarmTransfer;

        /// <summary>
        /// 
        /// </summary>
        public TransferOption(global::RetellAI.TransferOptionAgenticWarmTransfer? value)
        {
            AgenticWarmTransfer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TransferOption(
            global::RetellAI.TransferOptionColdTransfer? coldTransfer,
            global::RetellAI.TransferOptionWarmTransfer? warmTransfer,
            global::RetellAI.TransferOptionAgenticWarmTransfer? agenticWarmTransfer
            )
        {
            ColdTransfer = coldTransfer;
            WarmTransfer = warmTransfer;
            AgenticWarmTransfer = agenticWarmTransfer;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AgenticWarmTransfer as object ??
            WarmTransfer as object ??
            ColdTransfer as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ColdTransfer?.ToString() ??
            WarmTransfer?.ToString() ??
            AgenticWarmTransfer?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsColdTransfer && !IsWarmTransfer && !IsAgenticWarmTransfer || !IsColdTransfer && IsWarmTransfer && !IsAgenticWarmTransfer || !IsColdTransfer && !IsWarmTransfer && IsAgenticWarmTransfer;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.TransferOptionColdTransfer?, TResult>? coldTransfer = null,
            global::System.Func<global::RetellAI.TransferOptionWarmTransfer?, TResult>? warmTransfer = null,
            global::System.Func<global::RetellAI.TransferOptionAgenticWarmTransfer?, TResult>? agenticWarmTransfer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsColdTransfer && coldTransfer != null)
            {
                return coldTransfer(ColdTransfer!);
            }
            else if (IsWarmTransfer && warmTransfer != null)
            {
                return warmTransfer(WarmTransfer!);
            }
            else if (IsAgenticWarmTransfer && agenticWarmTransfer != null)
            {
                return agenticWarmTransfer(AgenticWarmTransfer!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.TransferOptionColdTransfer?>? coldTransfer = null,
            global::System.Action<global::RetellAI.TransferOptionWarmTransfer?>? warmTransfer = null,
            global::System.Action<global::RetellAI.TransferOptionAgenticWarmTransfer?>? agenticWarmTransfer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsColdTransfer)
            {
                coldTransfer?.Invoke(ColdTransfer!);
            }
            else if (IsWarmTransfer)
            {
                warmTransfer?.Invoke(WarmTransfer!);
            }
            else if (IsAgenticWarmTransfer)
            {
                agenticWarmTransfer?.Invoke(AgenticWarmTransfer!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ColdTransfer,
                typeof(global::RetellAI.TransferOptionColdTransfer),
                WarmTransfer,
                typeof(global::RetellAI.TransferOptionWarmTransfer),
                AgenticWarmTransfer,
                typeof(global::RetellAI.TransferOptionAgenticWarmTransfer),
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
        public bool Equals(TransferOption other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TransferOptionColdTransfer?>.Default.Equals(ColdTransfer, other.ColdTransfer) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TransferOptionWarmTransfer?>.Default.Equals(WarmTransfer, other.WarmTransfer) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TransferOptionAgenticWarmTransfer?>.Default.Equals(AgenticWarmTransfer, other.AgenticWarmTransfer) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TransferOption obj1, TransferOption obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TransferOption>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TransferOption obj1, TransferOption obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TransferOption o && Equals(o);
        }
    }
}
