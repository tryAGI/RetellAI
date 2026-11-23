#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AudioTestCasePerformanceMetrics : global::System.IEquatable<AudioTestCasePerformanceMetrics>
    {
        /// <summary>
        /// Performance metrics measured during the run. Paid metrics are only present when listed in the test case's `enabled_performance_metrics`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TextTestCasePerformanceMetrics? Text { get; init; }
#else
        public global::RetellAI.TextTestCasePerformanceMetrics? Text { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.TextTestCasePerformanceMetrics? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextTestCasePerformanceMetrics PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.AudioTestCasePerformanceMetricsVariant2? AudioTestCasePerformanceMetricsVariant2 { get; init; }
#else
        public global::RetellAI.AudioTestCasePerformanceMetricsVariant2? AudioTestCasePerformanceMetricsVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioTestCasePerformanceMetricsVariant2))]
#endif
        public bool IsAudioTestCasePerformanceMetricsVariant2 => AudioTestCasePerformanceMetricsVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAudioTestCasePerformanceMetricsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.AudioTestCasePerformanceMetricsVariant2? value)
        {
            value = AudioTestCasePerformanceMetricsVariant2;
            return IsAudioTestCasePerformanceMetricsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AudioTestCasePerformanceMetricsVariant2 PickAudioTestCasePerformanceMetricsVariant2() => AudioTestCasePerformanceMetricsVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AudioTestCasePerformanceMetricsVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AudioTestCasePerformanceMetrics(global::RetellAI.TextTestCasePerformanceMetrics value) => new AudioTestCasePerformanceMetrics((global::RetellAI.TextTestCasePerformanceMetrics?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.TextTestCasePerformanceMetrics?(AudioTestCasePerformanceMetrics @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public AudioTestCasePerformanceMetrics(global::RetellAI.TextTestCasePerformanceMetrics? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AudioTestCasePerformanceMetrics FromText(global::RetellAI.TextTestCasePerformanceMetrics? value) => new AudioTestCasePerformanceMetrics(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AudioTestCasePerformanceMetrics(global::RetellAI.AudioTestCasePerformanceMetricsVariant2 value) => new AudioTestCasePerformanceMetrics((global::RetellAI.AudioTestCasePerformanceMetricsVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.AudioTestCasePerformanceMetricsVariant2?(AudioTestCasePerformanceMetrics @this) => @this.AudioTestCasePerformanceMetricsVariant2;

        /// <summary>
        ///
        /// </summary>
        public AudioTestCasePerformanceMetrics(global::RetellAI.AudioTestCasePerformanceMetricsVariant2? value)
        {
            AudioTestCasePerformanceMetricsVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AudioTestCasePerformanceMetrics FromAudioTestCasePerformanceMetricsVariant2(global::RetellAI.AudioTestCasePerformanceMetricsVariant2? value) => new AudioTestCasePerformanceMetrics(value);

        /// <summary>
        ///
        /// </summary>
        public AudioTestCasePerformanceMetrics(
            global::RetellAI.TextTestCasePerformanceMetrics? text,
            global::RetellAI.AudioTestCasePerformanceMetricsVariant2? audioTestCasePerformanceMetricsVariant2
            )
        {
            Text = text;
            AudioTestCasePerformanceMetricsVariant2 = audioTestCasePerformanceMetricsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AudioTestCasePerformanceMetricsVariant2 as object ??
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            AudioTestCasePerformanceMetricsVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && IsAudioTestCasePerformanceMetricsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.TextTestCasePerformanceMetrics, TResult>? text = null,
            global::System.Func<global::RetellAI.AudioTestCasePerformanceMetricsVariant2, TResult>? audioTestCasePerformanceMetricsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0 && text != null)
            {
                return text(__value0);
            }
            else if (AudioTestCasePerformanceMetricsVariant2 is { } __value1 && audioTestCasePerformanceMetricsVariant2 != null)
            {
                return audioTestCasePerformanceMetricsVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.TextTestCasePerformanceMetrics>? text = null,

            global::System.Action<global::RetellAI.AudioTestCasePerformanceMetricsVariant2>? audioTestCasePerformanceMetricsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (AudioTestCasePerformanceMetricsVariant2 is { } __value1)
            {
                audioTestCasePerformanceMetricsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.TextTestCasePerformanceMetrics>? text = null,
            global::System.Action<global::RetellAI.AudioTestCasePerformanceMetricsVariant2>? audioTestCasePerformanceMetricsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (AudioTestCasePerformanceMetricsVariant2 is { } __value1)
            {
                audioTestCasePerformanceMetricsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::RetellAI.TextTestCasePerformanceMetrics),
                AudioTestCasePerformanceMetricsVariant2,
                typeof(global::RetellAI.AudioTestCasePerformanceMetricsVariant2),
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
        public bool Equals(AudioTestCasePerformanceMetrics other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TextTestCasePerformanceMetrics?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AudioTestCasePerformanceMetricsVariant2?>.Default.Equals(AudioTestCasePerformanceMetricsVariant2, other.AudioTestCasePerformanceMetricsVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AudioTestCasePerformanceMetrics obj1, AudioTestCasePerformanceMetrics obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AudioTestCasePerformanceMetrics>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AudioTestCasePerformanceMetrics obj1, AudioTestCasePerformanceMetrics obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AudioTestCasePerformanceMetrics o && Equals(o);
        }
    }
}
