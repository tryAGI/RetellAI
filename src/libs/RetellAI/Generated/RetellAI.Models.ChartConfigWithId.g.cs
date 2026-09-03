#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ChartConfigWithId : global::System.IEquatable<ChartConfigWithId>
    {
        /// <summary>
        /// Chart query and rendering settings. The call or chat dataset is supplied separately in `target.source`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ChartConfig? ChartConfig { get; init; }
#else
        public global::RetellAI.ChartConfig? ChartConfig { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChartConfig))]
#endif
        public bool IsChartConfig => ChartConfig != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChartConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ChartConfig? value)
        {
            value = ChartConfig;
            return IsChartConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartConfig PickChartConfig() => IsChartConfig
            ? ChartConfig!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChartConfig' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ChartConfigWithIdVariant2 { get; init; }
#else
        public object? ChartConfigWithIdVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChartConfigWithIdVariant2))]
#endif
        public bool IsChartConfigWithIdVariant2 => ChartConfigWithIdVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChartConfigWithIdVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = ChartConfigWithIdVariant2;
            return IsChartConfigWithIdVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickChartConfigWithIdVariant2() => IsChartConfigWithIdVariant2
            ? ChartConfigWithIdVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChartConfigWithIdVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChartConfigWithId(global::RetellAI.ChartConfig value) => new ChartConfigWithId((global::RetellAI.ChartConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ChartConfig?(ChartConfigWithId @this) => @this.ChartConfig;

        /// <summary>
        ///
        /// </summary>
        public ChartConfigWithId(global::RetellAI.ChartConfig? value)
        {
            ChartConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChartConfigWithId FromChartConfig(global::RetellAI.ChartConfig? value) => new ChartConfigWithId(value);

        /// <summary>
        ///
        /// </summary>
        public ChartConfigWithId(
            global::RetellAI.ChartConfig? chartConfig,
            object? chartConfigWithIdVariant2
            )
        {
            ChartConfig = chartConfig;
            ChartConfigWithIdVariant2 = chartConfigWithIdVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ChartConfigWithIdVariant2 as object ??
            ChartConfig as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ChartConfig?.ToString() ??
            ChartConfigWithIdVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsChartConfig && IsChartConfigWithIdVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ChartConfig, TResult>? chartConfig = null,
            global::System.Func<object, TResult>? chartConfigWithIdVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChartConfig && chartConfig != null)
            {
                return chartConfig(ChartConfig!);
            }
            else if (IsChartConfigWithIdVariant2 && chartConfigWithIdVariant2 != null)
            {
                return chartConfigWithIdVariant2(ChartConfigWithIdVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ChartConfig>? chartConfig = null,

            global::System.Action<object>? chartConfigWithIdVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChartConfig)
            {
                chartConfig?.Invoke(ChartConfig!);
            }
            else if (IsChartConfigWithIdVariant2)
            {
                chartConfigWithIdVariant2?.Invoke(ChartConfigWithIdVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ChartConfig>? chartConfig = null,
            global::System.Action<object>? chartConfigWithIdVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChartConfig)
            {
                chartConfig?.Invoke(ChartConfig!);
            }
            else if (IsChartConfigWithIdVariant2)
            {
                chartConfigWithIdVariant2?.Invoke(ChartConfigWithIdVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChartConfig,
                typeof(global::RetellAI.ChartConfig),
                ChartConfigWithIdVariant2,
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
        public bool Equals(ChartConfigWithId other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ChartConfig?>.Default.Equals(ChartConfig, other.ChartConfig) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ChartConfigWithIdVariant2, other.ChartConfigWithIdVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ChartConfigWithId obj1, ChartConfigWithId obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChartConfigWithId>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChartConfigWithId obj1, ChartConfigWithId obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChartConfigWithId o && Equals(o);
        }
    }
}
