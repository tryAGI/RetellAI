#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ChartGroupItem : global::System.IEquatable<ChartGroupItem>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ChartGroupItemVariant1? ChartGroupItemVariant1 { get; init; }
#else
        public global::RetellAI.ChartGroupItemVariant1? ChartGroupItemVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChartGroupItemVariant1))]
#endif
        public bool IsChartGroupItemVariant1 => ChartGroupItemVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChartGroupItemVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ChartGroupItemVariant1? value)
        {
            value = ChartGroupItemVariant1;
            return IsChartGroupItemVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartGroupItemVariant1 PickChartGroupItemVariant1() => IsChartGroupItemVariant1
            ? ChartGroupItemVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChartGroupItemVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ChartGroupItemVariant2? ChartGroupItemVariant2 { get; init; }
#else
        public global::RetellAI.ChartGroupItemVariant2? ChartGroupItemVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChartGroupItemVariant2))]
#endif
        public bool IsChartGroupItemVariant2 => ChartGroupItemVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChartGroupItemVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ChartGroupItemVariant2? value)
        {
            value = ChartGroupItemVariant2;
            return IsChartGroupItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartGroupItemVariant2 PickChartGroupItemVariant2() => IsChartGroupItemVariant2
            ? ChartGroupItemVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChartGroupItemVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChartGroupItem(global::RetellAI.ChartGroupItemVariant1 value) => new ChartGroupItem((global::RetellAI.ChartGroupItemVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ChartGroupItemVariant1?(ChartGroupItem @this) => @this.ChartGroupItemVariant1;

        /// <summary>
        ///
        /// </summary>
        public ChartGroupItem(global::RetellAI.ChartGroupItemVariant1? value)
        {
            ChartGroupItemVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChartGroupItem FromChartGroupItemVariant1(global::RetellAI.ChartGroupItemVariant1? value) => new ChartGroupItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChartGroupItem(global::RetellAI.ChartGroupItemVariant2 value) => new ChartGroupItem((global::RetellAI.ChartGroupItemVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ChartGroupItemVariant2?(ChartGroupItem @this) => @this.ChartGroupItemVariant2;

        /// <summary>
        ///
        /// </summary>
        public ChartGroupItem(global::RetellAI.ChartGroupItemVariant2? value)
        {
            ChartGroupItemVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChartGroupItem FromChartGroupItemVariant2(global::RetellAI.ChartGroupItemVariant2? value) => new ChartGroupItem(value);

        /// <summary>
        ///
        /// </summary>
        public ChartGroupItem(
            global::RetellAI.ChartGroupItemVariant1? chartGroupItemVariant1,
            global::RetellAI.ChartGroupItemVariant2? chartGroupItemVariant2
            )
        {
            ChartGroupItemVariant1 = chartGroupItemVariant1;
            ChartGroupItemVariant2 = chartGroupItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ChartGroupItemVariant2 as object ??
            ChartGroupItemVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ChartGroupItemVariant1?.ToString() ??
            ChartGroupItemVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsChartGroupItemVariant1 && !IsChartGroupItemVariant2 || !IsChartGroupItemVariant1 && IsChartGroupItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ChartGroupItemVariant1, TResult>? chartGroupItemVariant1 = null,
            global::System.Func<global::RetellAI.ChartGroupItemVariant2, TResult>? chartGroupItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChartGroupItemVariant1 && chartGroupItemVariant1 != null)
            {
                return chartGroupItemVariant1(ChartGroupItemVariant1!);
            }
            else if (IsChartGroupItemVariant2 && chartGroupItemVariant2 != null)
            {
                return chartGroupItemVariant2(ChartGroupItemVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ChartGroupItemVariant1>? chartGroupItemVariant1 = null,

            global::System.Action<global::RetellAI.ChartGroupItemVariant2>? chartGroupItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChartGroupItemVariant1)
            {
                chartGroupItemVariant1?.Invoke(ChartGroupItemVariant1!);
            }
            else if (IsChartGroupItemVariant2)
            {
                chartGroupItemVariant2?.Invoke(ChartGroupItemVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ChartGroupItemVariant1>? chartGroupItemVariant1 = null,
            global::System.Action<global::RetellAI.ChartGroupItemVariant2>? chartGroupItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChartGroupItemVariant1)
            {
                chartGroupItemVariant1?.Invoke(ChartGroupItemVariant1!);
            }
            else if (IsChartGroupItemVariant2)
            {
                chartGroupItemVariant2?.Invoke(ChartGroupItemVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChartGroupItemVariant1,
                typeof(global::RetellAI.ChartGroupItemVariant1),
                ChartGroupItemVariant2,
                typeof(global::RetellAI.ChartGroupItemVariant2),
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
        public bool Equals(ChartGroupItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ChartGroupItemVariant1?>.Default.Equals(ChartGroupItemVariant1, other.ChartGroupItemVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ChartGroupItemVariant2?>.Default.Equals(ChartGroupItemVariant2, other.ChartGroupItemVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ChartGroupItem obj1, ChartGroupItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChartGroupItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChartGroupItem obj1, ChartGroupItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChartGroupItem o && Equals(o);
        }
    }
}
