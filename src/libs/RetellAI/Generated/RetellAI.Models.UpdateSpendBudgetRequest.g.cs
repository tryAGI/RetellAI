#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UpdateSpendBudgetRequest : global::System.IEquatable<UpdateSpendBudgetRequest>
    {
        /// <summary>
        /// Disable spend budget.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.UpdateSpendBudgetRequestVariant1? UpdateSpendBudgetRequestVariant1 { get; init; }
#else
        public global::RetellAI.UpdateSpendBudgetRequestVariant1? UpdateSpendBudgetRequestVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateSpendBudgetRequestVariant1))]
#endif
        public bool IsUpdateSpendBudgetRequestVariant1 => UpdateSpendBudgetRequestVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUpdateSpendBudgetRequestVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.UpdateSpendBudgetRequestVariant1? value)
        {
            value = UpdateSpendBudgetRequestVariant1;
            return IsUpdateSpendBudgetRequestVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.UpdateSpendBudgetRequestVariant1 PickUpdateSpendBudgetRequestVariant1() => IsUpdateSpendBudgetRequestVariant1
            ? UpdateSpendBudgetRequestVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UpdateSpendBudgetRequestVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Enable spend budget (monthly cap required).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.UpdateSpendBudgetRequestVariant2? UpdateSpendBudgetRequestVariant2 { get; init; }
#else
        public global::RetellAI.UpdateSpendBudgetRequestVariant2? UpdateSpendBudgetRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateSpendBudgetRequestVariant2))]
#endif
        public bool IsUpdateSpendBudgetRequestVariant2 => UpdateSpendBudgetRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUpdateSpendBudgetRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.UpdateSpendBudgetRequestVariant2? value)
        {
            value = UpdateSpendBudgetRequestVariant2;
            return IsUpdateSpendBudgetRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.UpdateSpendBudgetRequestVariant2 PickUpdateSpendBudgetRequestVariant2() => IsUpdateSpendBudgetRequestVariant2
            ? UpdateSpendBudgetRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UpdateSpendBudgetRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateSpendBudgetRequest(global::RetellAI.UpdateSpendBudgetRequestVariant1 value) => new UpdateSpendBudgetRequest((global::RetellAI.UpdateSpendBudgetRequestVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.UpdateSpendBudgetRequestVariant1?(UpdateSpendBudgetRequest @this) => @this.UpdateSpendBudgetRequestVariant1;

        /// <summary>
        /// 
        /// </summary>
        public UpdateSpendBudgetRequest(global::RetellAI.UpdateSpendBudgetRequestVariant1? value)
        {
            UpdateSpendBudgetRequestVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdateSpendBudgetRequest FromUpdateSpendBudgetRequestVariant1(global::RetellAI.UpdateSpendBudgetRequestVariant1? value) => new UpdateSpendBudgetRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateSpendBudgetRequest(global::RetellAI.UpdateSpendBudgetRequestVariant2 value) => new UpdateSpendBudgetRequest((global::RetellAI.UpdateSpendBudgetRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.UpdateSpendBudgetRequestVariant2?(UpdateSpendBudgetRequest @this) => @this.UpdateSpendBudgetRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public UpdateSpendBudgetRequest(global::RetellAI.UpdateSpendBudgetRequestVariant2? value)
        {
            UpdateSpendBudgetRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdateSpendBudgetRequest FromUpdateSpendBudgetRequestVariant2(global::RetellAI.UpdateSpendBudgetRequestVariant2? value) => new UpdateSpendBudgetRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public UpdateSpendBudgetRequest(
            global::RetellAI.UpdateSpendBudgetRequestVariant1? updateSpendBudgetRequestVariant1,
            global::RetellAI.UpdateSpendBudgetRequestVariant2? updateSpendBudgetRequestVariant2
            )
        {
            UpdateSpendBudgetRequestVariant1 = updateSpendBudgetRequestVariant1;
            UpdateSpendBudgetRequestVariant2 = updateSpendBudgetRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UpdateSpendBudgetRequestVariant2 as object ??
            UpdateSpendBudgetRequestVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UpdateSpendBudgetRequestVariant1?.ToString() ??
            UpdateSpendBudgetRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUpdateSpendBudgetRequestVariant1 && !IsUpdateSpendBudgetRequestVariant2 || !IsUpdateSpendBudgetRequestVariant1 && IsUpdateSpendBudgetRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.UpdateSpendBudgetRequestVariant1, TResult>? updateSpendBudgetRequestVariant1 = null,
            global::System.Func<global::RetellAI.UpdateSpendBudgetRequestVariant2, TResult>? updateSpendBudgetRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUpdateSpendBudgetRequestVariant1 && updateSpendBudgetRequestVariant1 != null)
            {
                return updateSpendBudgetRequestVariant1(UpdateSpendBudgetRequestVariant1!);
            }
            else if (IsUpdateSpendBudgetRequestVariant2 && updateSpendBudgetRequestVariant2 != null)
            {
                return updateSpendBudgetRequestVariant2(UpdateSpendBudgetRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.UpdateSpendBudgetRequestVariant1>? updateSpendBudgetRequestVariant1 = null,

            global::System.Action<global::RetellAI.UpdateSpendBudgetRequestVariant2>? updateSpendBudgetRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUpdateSpendBudgetRequestVariant1)
            {
                updateSpendBudgetRequestVariant1?.Invoke(UpdateSpendBudgetRequestVariant1!);
            }
            else if (IsUpdateSpendBudgetRequestVariant2)
            {
                updateSpendBudgetRequestVariant2?.Invoke(UpdateSpendBudgetRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.UpdateSpendBudgetRequestVariant1>? updateSpendBudgetRequestVariant1 = null,
            global::System.Action<global::RetellAI.UpdateSpendBudgetRequestVariant2>? updateSpendBudgetRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUpdateSpendBudgetRequestVariant1)
            {
                updateSpendBudgetRequestVariant1?.Invoke(UpdateSpendBudgetRequestVariant1!);
            }
            else if (IsUpdateSpendBudgetRequestVariant2)
            {
                updateSpendBudgetRequestVariant2?.Invoke(UpdateSpendBudgetRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UpdateSpendBudgetRequestVariant1,
                typeof(global::RetellAI.UpdateSpendBudgetRequestVariant1),
                UpdateSpendBudgetRequestVariant2,
                typeof(global::RetellAI.UpdateSpendBudgetRequestVariant2),
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
        public bool Equals(UpdateSpendBudgetRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.UpdateSpendBudgetRequestVariant1?>.Default.Equals(UpdateSpendBudgetRequestVariant1, other.UpdateSpendBudgetRequestVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.UpdateSpendBudgetRequestVariant2?>.Default.Equals(UpdateSpendBudgetRequestVariant2, other.UpdateSpendBudgetRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateSpendBudgetRequest obj1, UpdateSpendBudgetRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateSpendBudgetRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateSpendBudgetRequest obj1, UpdateSpendBudgetRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateSpendBudgetRequest o && Equals(o);
        }
    }
}
