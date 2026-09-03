#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ChartUpdate : global::System.IEquatable<ChartUpdate>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ChartConfigWithId? ConfigWithId { get; init; }
#else
        public global::RetellAI.ChartConfigWithId? ConfigWithId { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConfigWithId))]
#endif
        public bool IsConfigWithId => ConfigWithId != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConfigWithId(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ChartConfigWithId? value)
        {
            value = ConfigWithId;
            return IsConfigWithId;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartConfigWithId PickConfigWithId() => IsConfigWithId
            ? ConfigWithId!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConfigWithId' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ChartUpdateVariant2? ChartUpdateVariant2 { get; init; }
#else
        public global::RetellAI.ChartUpdateVariant2? ChartUpdateVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChartUpdateVariant2))]
#endif
        public bool IsChartUpdateVariant2 => ChartUpdateVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChartUpdateVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ChartUpdateVariant2? value)
        {
            value = ChartUpdateVariant2;
            return IsChartUpdateVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartUpdateVariant2 PickChartUpdateVariant2() => IsChartUpdateVariant2
            ? ChartUpdateVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChartUpdateVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChartUpdate(global::RetellAI.ChartConfigWithId value) => new ChartUpdate((global::RetellAI.ChartConfigWithId?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ChartConfigWithId?(ChartUpdate @this) => @this.ConfigWithId;

        /// <summary>
        ///
        /// </summary>
        public ChartUpdate(global::RetellAI.ChartConfigWithId? value)
        {
            ConfigWithId = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChartUpdate FromConfigWithId(global::RetellAI.ChartConfigWithId? value) => new ChartUpdate(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChartUpdate(global::RetellAI.ChartUpdateVariant2 value) => new ChartUpdate((global::RetellAI.ChartUpdateVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ChartUpdateVariant2?(ChartUpdate @this) => @this.ChartUpdateVariant2;

        /// <summary>
        ///
        /// </summary>
        public ChartUpdate(global::RetellAI.ChartUpdateVariant2? value)
        {
            ChartUpdateVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChartUpdate FromChartUpdateVariant2(global::RetellAI.ChartUpdateVariant2? value) => new ChartUpdate(value);

        /// <summary>
        ///
        /// </summary>
        public ChartUpdate(
            global::RetellAI.ChartConfigWithId? configWithId,
            global::RetellAI.ChartUpdateVariant2? chartUpdateVariant2
            )
        {
            ConfigWithId = configWithId;
            ChartUpdateVariant2 = chartUpdateVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ChartUpdateVariant2 as object ??
            ConfigWithId as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ConfigWithId?.ToString() ??
            ChartUpdateVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsConfigWithId && IsChartUpdateVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ChartConfigWithId?, TResult>? configWithId = null,
            global::System.Func<global::RetellAI.ChartUpdateVariant2, TResult>? chartUpdateVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConfigWithId && configWithId != null)
            {
                return configWithId(ConfigWithId!);
            }
            else if (IsChartUpdateVariant2 && chartUpdateVariant2 != null)
            {
                return chartUpdateVariant2(ChartUpdateVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ChartConfigWithId?>? configWithId = null,

            global::System.Action<global::RetellAI.ChartUpdateVariant2>? chartUpdateVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConfigWithId)
            {
                configWithId?.Invoke(ConfigWithId!);
            }
            else if (IsChartUpdateVariant2)
            {
                chartUpdateVariant2?.Invoke(ChartUpdateVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ChartConfigWithId?>? configWithId = null,
            global::System.Action<global::RetellAI.ChartUpdateVariant2>? chartUpdateVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConfigWithId)
            {
                configWithId?.Invoke(ConfigWithId!);
            }
            else if (IsChartUpdateVariant2)
            {
                chartUpdateVariant2?.Invoke(ChartUpdateVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ConfigWithId,
                typeof(global::RetellAI.ChartConfigWithId),
                ChartUpdateVariant2,
                typeof(global::RetellAI.ChartUpdateVariant2),
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
        public bool Equals(ChartUpdate other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ChartConfigWithId?>.Default.Equals(ConfigWithId, other.ConfigWithId) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ChartUpdateVariant2?>.Default.Equals(ChartUpdateVariant2, other.ChartUpdateVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ChartUpdate obj1, ChartUpdate obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChartUpdate>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChartUpdate obj1, ChartUpdate obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChartUpdate o && Equals(o);
        }
    }
}
