#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ChartTimeRange : global::System.IEquatable<ChartTimeRange>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ChartTimeRangeVariant1? ChartTimeRangeVariant1 { get; init; }
#else
        public global::RetellAI.ChartTimeRangeVariant1? ChartTimeRangeVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChartTimeRangeVariant1))]
#endif
        public bool IsChartTimeRangeVariant1 => ChartTimeRangeVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChartTimeRangeVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ChartTimeRangeVariant1? value)
        {
            value = ChartTimeRangeVariant1;
            return IsChartTimeRangeVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant1 PickChartTimeRangeVariant1() => IsChartTimeRangeVariant1
            ? ChartTimeRangeVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChartTimeRangeVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ChartTimeRangeVariant2? ChartTimeRangeVariant2 { get; init; }
#else
        public global::RetellAI.ChartTimeRangeVariant2? ChartTimeRangeVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChartTimeRangeVariant2))]
#endif
        public bool IsChartTimeRangeVariant2 => ChartTimeRangeVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChartTimeRangeVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ChartTimeRangeVariant2? value)
        {
            value = ChartTimeRangeVariant2;
            return IsChartTimeRangeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant2 PickChartTimeRangeVariant2() => IsChartTimeRangeVariant2
            ? ChartTimeRangeVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChartTimeRangeVariant2' but the value was {ToString()}.");

        /// <summary>
        /// The current day, week, month or year so far, resolved per request in the request's timezone. Weeks start Monday.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ChartTimeRangeVariant3? ChartTimeRangeVariant3 { get; init; }
#else
        public global::RetellAI.ChartTimeRangeVariant3? ChartTimeRangeVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChartTimeRangeVariant3))]
#endif
        public bool IsChartTimeRangeVariant3 => ChartTimeRangeVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChartTimeRangeVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ChartTimeRangeVariant3? value)
        {
            value = ChartTimeRangeVariant3;
            return IsChartTimeRangeVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant3 PickChartTimeRangeVariant3() => IsChartTimeRangeVariant3
            ? ChartTimeRangeVariant3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChartTimeRangeVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ChartTimeRangeVariant4? ChartTimeRangeVariant4 { get; init; }
#else
        public global::RetellAI.ChartTimeRangeVariant4? ChartTimeRangeVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChartTimeRangeVariant4))]
#endif
        public bool IsChartTimeRangeVariant4 => ChartTimeRangeVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChartTimeRangeVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ChartTimeRangeVariant4? value)
        {
            value = ChartTimeRangeVariant4;
            return IsChartTimeRangeVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant4 PickChartTimeRangeVariant4() => IsChartTimeRangeVariant4
            ? ChartTimeRangeVariant4!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChartTimeRangeVariant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ChartTimeRangeVariant5? ChartTimeRangeVariant5 { get; init; }
#else
        public global::RetellAI.ChartTimeRangeVariant5? ChartTimeRangeVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChartTimeRangeVariant5))]
#endif
        public bool IsChartTimeRangeVariant5 => ChartTimeRangeVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChartTimeRangeVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ChartTimeRangeVariant5? value)
        {
            value = ChartTimeRangeVariant5;
            return IsChartTimeRangeVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant5 PickChartTimeRangeVariant5() => IsChartTimeRangeVariant5
            ? ChartTimeRangeVariant5!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChartTimeRangeVariant5' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChartTimeRange(global::RetellAI.ChartTimeRangeVariant1 value) => new ChartTimeRange((global::RetellAI.ChartTimeRangeVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ChartTimeRangeVariant1?(ChartTimeRange @this) => @this.ChartTimeRangeVariant1;

        /// <summary>
        ///
        /// </summary>
        public ChartTimeRange(global::RetellAI.ChartTimeRangeVariant1? value)
        {
            ChartTimeRangeVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChartTimeRange FromChartTimeRangeVariant1(global::RetellAI.ChartTimeRangeVariant1? value) => new ChartTimeRange(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChartTimeRange(global::RetellAI.ChartTimeRangeVariant2 value) => new ChartTimeRange((global::RetellAI.ChartTimeRangeVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ChartTimeRangeVariant2?(ChartTimeRange @this) => @this.ChartTimeRangeVariant2;

        /// <summary>
        ///
        /// </summary>
        public ChartTimeRange(global::RetellAI.ChartTimeRangeVariant2? value)
        {
            ChartTimeRangeVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChartTimeRange FromChartTimeRangeVariant2(global::RetellAI.ChartTimeRangeVariant2? value) => new ChartTimeRange(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChartTimeRange(global::RetellAI.ChartTimeRangeVariant3 value) => new ChartTimeRange((global::RetellAI.ChartTimeRangeVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ChartTimeRangeVariant3?(ChartTimeRange @this) => @this.ChartTimeRangeVariant3;

        /// <summary>
        ///
        /// </summary>
        public ChartTimeRange(global::RetellAI.ChartTimeRangeVariant3? value)
        {
            ChartTimeRangeVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChartTimeRange FromChartTimeRangeVariant3(global::RetellAI.ChartTimeRangeVariant3? value) => new ChartTimeRange(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChartTimeRange(global::RetellAI.ChartTimeRangeVariant4 value) => new ChartTimeRange((global::RetellAI.ChartTimeRangeVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ChartTimeRangeVariant4?(ChartTimeRange @this) => @this.ChartTimeRangeVariant4;

        /// <summary>
        ///
        /// </summary>
        public ChartTimeRange(global::RetellAI.ChartTimeRangeVariant4? value)
        {
            ChartTimeRangeVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChartTimeRange FromChartTimeRangeVariant4(global::RetellAI.ChartTimeRangeVariant4? value) => new ChartTimeRange(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChartTimeRange(global::RetellAI.ChartTimeRangeVariant5 value) => new ChartTimeRange((global::RetellAI.ChartTimeRangeVariant5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ChartTimeRangeVariant5?(ChartTimeRange @this) => @this.ChartTimeRangeVariant5;

        /// <summary>
        ///
        /// </summary>
        public ChartTimeRange(global::RetellAI.ChartTimeRangeVariant5? value)
        {
            ChartTimeRangeVariant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChartTimeRange FromChartTimeRangeVariant5(global::RetellAI.ChartTimeRangeVariant5? value) => new ChartTimeRange(value);

        /// <summary>
        ///
        /// </summary>
        public ChartTimeRange(
            global::RetellAI.ChartTimeRangeVariant1? chartTimeRangeVariant1,
            global::RetellAI.ChartTimeRangeVariant2? chartTimeRangeVariant2,
            global::RetellAI.ChartTimeRangeVariant3? chartTimeRangeVariant3,
            global::RetellAI.ChartTimeRangeVariant4? chartTimeRangeVariant4,
            global::RetellAI.ChartTimeRangeVariant5? chartTimeRangeVariant5
            )
        {
            ChartTimeRangeVariant1 = chartTimeRangeVariant1;
            ChartTimeRangeVariant2 = chartTimeRangeVariant2;
            ChartTimeRangeVariant3 = chartTimeRangeVariant3;
            ChartTimeRangeVariant4 = chartTimeRangeVariant4;
            ChartTimeRangeVariant5 = chartTimeRangeVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ChartTimeRangeVariant5 as object ??
            ChartTimeRangeVariant4 as object ??
            ChartTimeRangeVariant3 as object ??
            ChartTimeRangeVariant2 as object ??
            ChartTimeRangeVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ChartTimeRangeVariant1?.ToString() ??
            ChartTimeRangeVariant2?.ToString() ??
            ChartTimeRangeVariant3?.ToString() ??
            ChartTimeRangeVariant4?.ToString() ??
            ChartTimeRangeVariant5?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsChartTimeRangeVariant1 && !IsChartTimeRangeVariant2 && !IsChartTimeRangeVariant3 && !IsChartTimeRangeVariant4 && !IsChartTimeRangeVariant5 || !IsChartTimeRangeVariant1 && IsChartTimeRangeVariant2 && !IsChartTimeRangeVariant3 && !IsChartTimeRangeVariant4 && !IsChartTimeRangeVariant5 || !IsChartTimeRangeVariant1 && !IsChartTimeRangeVariant2 && IsChartTimeRangeVariant3 && !IsChartTimeRangeVariant4 && !IsChartTimeRangeVariant5 || !IsChartTimeRangeVariant1 && !IsChartTimeRangeVariant2 && !IsChartTimeRangeVariant3 && IsChartTimeRangeVariant4 && !IsChartTimeRangeVariant5 || !IsChartTimeRangeVariant1 && !IsChartTimeRangeVariant2 && !IsChartTimeRangeVariant3 && !IsChartTimeRangeVariant4 && IsChartTimeRangeVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ChartTimeRangeVariant1, TResult>? chartTimeRangeVariant1 = null,
            global::System.Func<global::RetellAI.ChartTimeRangeVariant2, TResult>? chartTimeRangeVariant2 = null,
            global::System.Func<global::RetellAI.ChartTimeRangeVariant3, TResult>? chartTimeRangeVariant3 = null,
            global::System.Func<global::RetellAI.ChartTimeRangeVariant4, TResult>? chartTimeRangeVariant4 = null,
            global::System.Func<global::RetellAI.ChartTimeRangeVariant5, TResult>? chartTimeRangeVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChartTimeRangeVariant1 && chartTimeRangeVariant1 != null)
            {
                return chartTimeRangeVariant1(ChartTimeRangeVariant1!);
            }
            else if (IsChartTimeRangeVariant2 && chartTimeRangeVariant2 != null)
            {
                return chartTimeRangeVariant2(ChartTimeRangeVariant2!);
            }
            else if (IsChartTimeRangeVariant3 && chartTimeRangeVariant3 != null)
            {
                return chartTimeRangeVariant3(ChartTimeRangeVariant3!);
            }
            else if (IsChartTimeRangeVariant4 && chartTimeRangeVariant4 != null)
            {
                return chartTimeRangeVariant4(ChartTimeRangeVariant4!);
            }
            else if (IsChartTimeRangeVariant5 && chartTimeRangeVariant5 != null)
            {
                return chartTimeRangeVariant5(ChartTimeRangeVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ChartTimeRangeVariant1>? chartTimeRangeVariant1 = null,

            global::System.Action<global::RetellAI.ChartTimeRangeVariant2>? chartTimeRangeVariant2 = null,

            global::System.Action<global::RetellAI.ChartTimeRangeVariant3>? chartTimeRangeVariant3 = null,

            global::System.Action<global::RetellAI.ChartTimeRangeVariant4>? chartTimeRangeVariant4 = null,

            global::System.Action<global::RetellAI.ChartTimeRangeVariant5>? chartTimeRangeVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChartTimeRangeVariant1)
            {
                chartTimeRangeVariant1?.Invoke(ChartTimeRangeVariant1!);
            }
            else if (IsChartTimeRangeVariant2)
            {
                chartTimeRangeVariant2?.Invoke(ChartTimeRangeVariant2!);
            }
            else if (IsChartTimeRangeVariant3)
            {
                chartTimeRangeVariant3?.Invoke(ChartTimeRangeVariant3!);
            }
            else if (IsChartTimeRangeVariant4)
            {
                chartTimeRangeVariant4?.Invoke(ChartTimeRangeVariant4!);
            }
            else if (IsChartTimeRangeVariant5)
            {
                chartTimeRangeVariant5?.Invoke(ChartTimeRangeVariant5!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ChartTimeRangeVariant1>? chartTimeRangeVariant1 = null,
            global::System.Action<global::RetellAI.ChartTimeRangeVariant2>? chartTimeRangeVariant2 = null,
            global::System.Action<global::RetellAI.ChartTimeRangeVariant3>? chartTimeRangeVariant3 = null,
            global::System.Action<global::RetellAI.ChartTimeRangeVariant4>? chartTimeRangeVariant4 = null,
            global::System.Action<global::RetellAI.ChartTimeRangeVariant5>? chartTimeRangeVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChartTimeRangeVariant1)
            {
                chartTimeRangeVariant1?.Invoke(ChartTimeRangeVariant1!);
            }
            else if (IsChartTimeRangeVariant2)
            {
                chartTimeRangeVariant2?.Invoke(ChartTimeRangeVariant2!);
            }
            else if (IsChartTimeRangeVariant3)
            {
                chartTimeRangeVariant3?.Invoke(ChartTimeRangeVariant3!);
            }
            else if (IsChartTimeRangeVariant4)
            {
                chartTimeRangeVariant4?.Invoke(ChartTimeRangeVariant4!);
            }
            else if (IsChartTimeRangeVariant5)
            {
                chartTimeRangeVariant5?.Invoke(ChartTimeRangeVariant5!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChartTimeRangeVariant1,
                typeof(global::RetellAI.ChartTimeRangeVariant1),
                ChartTimeRangeVariant2,
                typeof(global::RetellAI.ChartTimeRangeVariant2),
                ChartTimeRangeVariant3,
                typeof(global::RetellAI.ChartTimeRangeVariant3),
                ChartTimeRangeVariant4,
                typeof(global::RetellAI.ChartTimeRangeVariant4),
                ChartTimeRangeVariant5,
                typeof(global::RetellAI.ChartTimeRangeVariant5),
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
        public bool Equals(ChartTimeRange other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ChartTimeRangeVariant1?>.Default.Equals(ChartTimeRangeVariant1, other.ChartTimeRangeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ChartTimeRangeVariant2?>.Default.Equals(ChartTimeRangeVariant2, other.ChartTimeRangeVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ChartTimeRangeVariant3?>.Default.Equals(ChartTimeRangeVariant3, other.ChartTimeRangeVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ChartTimeRangeVariant4?>.Default.Equals(ChartTimeRangeVariant4, other.ChartTimeRangeVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ChartTimeRangeVariant5?>.Default.Equals(ChartTimeRangeVariant5, other.ChartTimeRangeVariant5)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ChartTimeRange obj1, ChartTimeRange obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChartTimeRange>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChartTimeRange obj1, ChartTimeRange obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChartTimeRange o && Equals(o);
        }
    }
}
