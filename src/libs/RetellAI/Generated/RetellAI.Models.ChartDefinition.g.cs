#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Chart configuration used in `target.chart`; `chart_id` must be omitted.
    /// </summary>
    public readonly partial struct ChartDefinition : global::System.IEquatable<ChartDefinition>
    {
        /// <summary>
        /// Chart query and rendering settings. The call or chat dataset is supplied separately in `target.source`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ChartConfig? Config { get; init; }
#else
        public global::RetellAI.ChartConfig? Config { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Config))]
#endif
        public bool IsConfig => Config != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ChartConfig? value)
        {
            value = Config;
            return IsConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartConfig PickConfig() => IsConfig
            ? Config!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Config' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ChartDefinitionVariant2 { get; init; }
#else
        public object? ChartDefinitionVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChartDefinitionVariant2))]
#endif
        public bool IsChartDefinitionVariant2 => ChartDefinitionVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChartDefinitionVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = ChartDefinitionVariant2;
            return IsChartDefinitionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickChartDefinitionVariant2() => IsChartDefinitionVariant2
            ? ChartDefinitionVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChartDefinitionVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChartDefinition(global::RetellAI.ChartConfig value) => new ChartDefinition((global::RetellAI.ChartConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ChartConfig?(ChartDefinition @this) => @this.Config;

        /// <summary>
        ///
        /// </summary>
        public ChartDefinition(global::RetellAI.ChartConfig? value)
        {
            Config = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChartDefinition FromConfig(global::RetellAI.ChartConfig? value) => new ChartDefinition(value);

        /// <summary>
        ///
        /// </summary>
        public ChartDefinition(
            global::RetellAI.ChartConfig? config,
            object? chartDefinitionVariant2
            )
        {
            Config = config;
            ChartDefinitionVariant2 = chartDefinitionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ChartDefinitionVariant2 as object ??
            Config as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Config?.ToString() ??
            ChartDefinitionVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsConfig && IsChartDefinitionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ChartConfig, TResult>? config = null,
            global::System.Func<object, TResult>? chartDefinitionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConfig && config != null)
            {
                return config(Config!);
            }
            else if (IsChartDefinitionVariant2 && chartDefinitionVariant2 != null)
            {
                return chartDefinitionVariant2(ChartDefinitionVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ChartConfig>? config = null,

            global::System.Action<object>? chartDefinitionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConfig)
            {
                config?.Invoke(Config!);
            }
            else if (IsChartDefinitionVariant2)
            {
                chartDefinitionVariant2?.Invoke(ChartDefinitionVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ChartConfig>? config = null,
            global::System.Action<object>? chartDefinitionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConfig)
            {
                config?.Invoke(Config!);
            }
            else if (IsChartDefinitionVariant2)
            {
                chartDefinitionVariant2?.Invoke(ChartDefinitionVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Config,
                typeof(global::RetellAI.ChartConfig),
                ChartDefinitionVariant2,
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
        public bool Equals(ChartDefinition other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ChartConfig?>.Default.Equals(Config, other.Config) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ChartDefinitionVariant2, other.ChartDefinitionVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ChartDefinition obj1, ChartDefinition obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChartDefinition>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChartDefinition obj1, ChartDefinition obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChartDefinition o && Equals(o);
        }
    }
}
