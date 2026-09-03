#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Metric to calculate. `source` selects a value, `measurement` chooses its aggregation, and `source.group` adds a chart-wide breakdown shared by every metric.
    /// </summary>
    public readonly partial struct ChartShowItem : global::System.IEquatable<ChartShowItem>
    {
        /// <summary>
        /// `call_id` counts calls; `chat_id` counts chats. For a disconnection reason breakdown, use `call_id` for calls or `chat_id` for chats and set `group: disconnection_reason`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ChartShowItemKeywordSource? KeywordSource { get; init; }
#else
        public global::RetellAI.ChartShowItemKeywordSource? KeywordSource { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KeywordSource))]
#endif
        public bool IsKeywordSource => KeywordSource != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKeywordSource(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ChartShowItemKeywordSource? value)
        {
            value = KeywordSource;
            return IsKeywordSource;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemKeywordSource PickKeywordSource() => IsKeywordSource
            ? KeywordSource!
            : throw new global::System.InvalidOperationException($"Expected union variant 'KeywordSource' but the value was {ToString()}.");

        /// <summary>
        /// Built-in metric. `e2e_latency_p50`, `call_successful`, `call_picked_up`, `call_transferred`, and `in_voicemail` are call-only; `chat_successful` is chat-only; `duration_ms` and `combined_cost` support both.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ChartShowItemNumericSource? NumericSource { get; init; }
#else
        public global::RetellAI.ChartShowItemNumericSource? NumericSource { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NumericSource))]
#endif
        public bool IsNumericSource => NumericSource != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNumericSource(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ChartShowItemNumericSource? value)
        {
            value = NumericSource;
            return IsNumericSource;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemNumericSource PickNumericSource() => IsNumericSource
            ? NumericSource!
            : throw new global::System.InvalidOperationException($"Expected union variant 'NumericSource' but the value was {ToString()}.");

        /// <summary>
        /// Aggregate one custom analysis or custom attribute field.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ChartShowItemCustomFieldSource? CustomFieldSource { get; init; }
#else
        public global::RetellAI.ChartShowItemCustomFieldSource? CustomFieldSource { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomFieldSource))]
#endif
        public bool IsCustomFieldSource => CustomFieldSource != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustomFieldSource(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ChartShowItemCustomFieldSource? value)
        {
            value = CustomFieldSource;
            return IsCustomFieldSource;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomFieldSource PickCustomFieldSource() => IsCustomFieldSource
            ? CustomFieldSource!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomFieldSource' but the value was {ToString()}.");

        /// <summary>
        /// Maximum concurrent calls per time bucket; call-only. Use `line`, `bar`, or `column`. Record filters and categorical groups do not apply.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ChartShowItemConcurrencySource? ConcurrencySource { get; init; }
#else
        public global::RetellAI.ChartShowItemConcurrencySource? ConcurrencySource { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConcurrencySource))]
#endif
        public bool IsConcurrencySource => ConcurrencySource != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConcurrencySource(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ChartShowItemConcurrencySource? value)
        {
            value = ConcurrencySource;
            return IsConcurrencySource;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemConcurrencySource PickConcurrencySource() => IsConcurrencySource
            ? ConcurrencySource!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConcurrencySource' but the value was {ToString()}.");

        /// <summary>
        /// Custom tool-call metrics; call-only. `custom_tool_latency` is the average of each call's recorded custom-tool latencies, then averaged across those calls, in milliseconds. `custom_tool_success_rate` is successful invocations divided by all invocations.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ChartShowItemCustomToolSource? CustomToolSource { get; init; }
#else
        public global::RetellAI.ChartShowItemCustomToolSource? CustomToolSource { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolSource))]
#endif
        public bool IsCustomToolSource => CustomToolSource != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustomToolSource(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ChartShowItemCustomToolSource? value)
        {
            value = CustomToolSource;
            return IsCustomToolSource;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomToolSource PickCustomToolSource() => IsCustomToolSource
            ? CustomToolSource!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolSource' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChartShowItem(global::RetellAI.ChartShowItemKeywordSource value) => new ChartShowItem((global::RetellAI.ChartShowItemKeywordSource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ChartShowItemKeywordSource?(ChartShowItem @this) => @this.KeywordSource;

        /// <summary>
        ///
        /// </summary>
        public ChartShowItem(global::RetellAI.ChartShowItemKeywordSource? value)
        {
            KeywordSource = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChartShowItem FromKeywordSource(global::RetellAI.ChartShowItemKeywordSource? value) => new ChartShowItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChartShowItem(global::RetellAI.ChartShowItemNumericSource value) => new ChartShowItem((global::RetellAI.ChartShowItemNumericSource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ChartShowItemNumericSource?(ChartShowItem @this) => @this.NumericSource;

        /// <summary>
        ///
        /// </summary>
        public ChartShowItem(global::RetellAI.ChartShowItemNumericSource? value)
        {
            NumericSource = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChartShowItem FromNumericSource(global::RetellAI.ChartShowItemNumericSource? value) => new ChartShowItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChartShowItem(global::RetellAI.ChartShowItemCustomFieldSource value) => new ChartShowItem((global::RetellAI.ChartShowItemCustomFieldSource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ChartShowItemCustomFieldSource?(ChartShowItem @this) => @this.CustomFieldSource;

        /// <summary>
        ///
        /// </summary>
        public ChartShowItem(global::RetellAI.ChartShowItemCustomFieldSource? value)
        {
            CustomFieldSource = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChartShowItem FromCustomFieldSource(global::RetellAI.ChartShowItemCustomFieldSource? value) => new ChartShowItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChartShowItem(global::RetellAI.ChartShowItemConcurrencySource value) => new ChartShowItem((global::RetellAI.ChartShowItemConcurrencySource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ChartShowItemConcurrencySource?(ChartShowItem @this) => @this.ConcurrencySource;

        /// <summary>
        ///
        /// </summary>
        public ChartShowItem(global::RetellAI.ChartShowItemConcurrencySource? value)
        {
            ConcurrencySource = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChartShowItem FromConcurrencySource(global::RetellAI.ChartShowItemConcurrencySource? value) => new ChartShowItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChartShowItem(global::RetellAI.ChartShowItemCustomToolSource value) => new ChartShowItem((global::RetellAI.ChartShowItemCustomToolSource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ChartShowItemCustomToolSource?(ChartShowItem @this) => @this.CustomToolSource;

        /// <summary>
        ///
        /// </summary>
        public ChartShowItem(global::RetellAI.ChartShowItemCustomToolSource? value)
        {
            CustomToolSource = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChartShowItem FromCustomToolSource(global::RetellAI.ChartShowItemCustomToolSource? value) => new ChartShowItem(value);

        /// <summary>
        ///
        /// </summary>
        public ChartShowItem(
            global::RetellAI.ChartShowItemKeywordSource? keywordSource,
            global::RetellAI.ChartShowItemNumericSource? numericSource,
            global::RetellAI.ChartShowItemCustomFieldSource? customFieldSource,
            global::RetellAI.ChartShowItemConcurrencySource? concurrencySource,
            global::RetellAI.ChartShowItemCustomToolSource? customToolSource
            )
        {
            KeywordSource = keywordSource;
            NumericSource = numericSource;
            CustomFieldSource = customFieldSource;
            ConcurrencySource = concurrencySource;
            CustomToolSource = customToolSource;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CustomToolSource as object ??
            ConcurrencySource as object ??
            CustomFieldSource as object ??
            NumericSource as object ??
            KeywordSource as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            KeywordSource?.ToString() ??
            NumericSource?.ToString() ??
            CustomFieldSource?.ToString() ??
            ConcurrencySource?.ToString() ??
            CustomToolSource?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsKeywordSource && !IsNumericSource && !IsCustomFieldSource && !IsConcurrencySource && !IsCustomToolSource || !IsKeywordSource && IsNumericSource && !IsCustomFieldSource && !IsConcurrencySource && !IsCustomToolSource || !IsKeywordSource && !IsNumericSource && IsCustomFieldSource && !IsConcurrencySource && !IsCustomToolSource || !IsKeywordSource && !IsNumericSource && !IsCustomFieldSource && IsConcurrencySource && !IsCustomToolSource || !IsKeywordSource && !IsNumericSource && !IsCustomFieldSource && !IsConcurrencySource && IsCustomToolSource;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ChartShowItemKeywordSource, TResult>? keywordSource = null,
            global::System.Func<global::RetellAI.ChartShowItemNumericSource, TResult>? numericSource = null,
            global::System.Func<global::RetellAI.ChartShowItemCustomFieldSource, TResult>? customFieldSource = null,
            global::System.Func<global::RetellAI.ChartShowItemConcurrencySource, TResult>? concurrencySource = null,
            global::System.Func<global::RetellAI.ChartShowItemCustomToolSource, TResult>? customToolSource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsKeywordSource && keywordSource != null)
            {
                return keywordSource(KeywordSource!);
            }
            else if (IsNumericSource && numericSource != null)
            {
                return numericSource(NumericSource!);
            }
            else if (IsCustomFieldSource && customFieldSource != null)
            {
                return customFieldSource(CustomFieldSource!);
            }
            else if (IsConcurrencySource && concurrencySource != null)
            {
                return concurrencySource(ConcurrencySource!);
            }
            else if (IsCustomToolSource && customToolSource != null)
            {
                return customToolSource(CustomToolSource!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ChartShowItemKeywordSource>? keywordSource = null,

            global::System.Action<global::RetellAI.ChartShowItemNumericSource>? numericSource = null,

            global::System.Action<global::RetellAI.ChartShowItemCustomFieldSource>? customFieldSource = null,

            global::System.Action<global::RetellAI.ChartShowItemConcurrencySource>? concurrencySource = null,

            global::System.Action<global::RetellAI.ChartShowItemCustomToolSource>? customToolSource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsKeywordSource)
            {
                keywordSource?.Invoke(KeywordSource!);
            }
            else if (IsNumericSource)
            {
                numericSource?.Invoke(NumericSource!);
            }
            else if (IsCustomFieldSource)
            {
                customFieldSource?.Invoke(CustomFieldSource!);
            }
            else if (IsConcurrencySource)
            {
                concurrencySource?.Invoke(ConcurrencySource!);
            }
            else if (IsCustomToolSource)
            {
                customToolSource?.Invoke(CustomToolSource!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ChartShowItemKeywordSource>? keywordSource = null,
            global::System.Action<global::RetellAI.ChartShowItemNumericSource>? numericSource = null,
            global::System.Action<global::RetellAI.ChartShowItemCustomFieldSource>? customFieldSource = null,
            global::System.Action<global::RetellAI.ChartShowItemConcurrencySource>? concurrencySource = null,
            global::System.Action<global::RetellAI.ChartShowItemCustomToolSource>? customToolSource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsKeywordSource)
            {
                keywordSource?.Invoke(KeywordSource!);
            }
            else if (IsNumericSource)
            {
                numericSource?.Invoke(NumericSource!);
            }
            else if (IsCustomFieldSource)
            {
                customFieldSource?.Invoke(CustomFieldSource!);
            }
            else if (IsConcurrencySource)
            {
                concurrencySource?.Invoke(ConcurrencySource!);
            }
            else if (IsCustomToolSource)
            {
                customToolSource?.Invoke(CustomToolSource!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                KeywordSource,
                typeof(global::RetellAI.ChartShowItemKeywordSource),
                NumericSource,
                typeof(global::RetellAI.ChartShowItemNumericSource),
                CustomFieldSource,
                typeof(global::RetellAI.ChartShowItemCustomFieldSource),
                ConcurrencySource,
                typeof(global::RetellAI.ChartShowItemConcurrencySource),
                CustomToolSource,
                typeof(global::RetellAI.ChartShowItemCustomToolSource),
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
        public bool Equals(ChartShowItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ChartShowItemKeywordSource?>.Default.Equals(KeywordSource, other.KeywordSource) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ChartShowItemNumericSource?>.Default.Equals(NumericSource, other.NumericSource) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ChartShowItemCustomFieldSource?>.Default.Equals(CustomFieldSource, other.CustomFieldSource) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ChartShowItemConcurrencySource?>.Default.Equals(ConcurrencySource, other.ConcurrencySource) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ChartShowItemCustomToolSource?>.Default.Equals(CustomToolSource, other.CustomToolSource)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ChartShowItem obj1, ChartShowItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChartShowItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChartShowItem obj1, ChartShowItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChartShowItem o && Equals(o);
        }
    }
}
