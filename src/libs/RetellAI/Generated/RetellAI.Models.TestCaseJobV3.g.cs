#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct TestCaseJobV3 : global::System.IEquatable<TestCaseJobV3>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TextTestCaseJobV3? Text { get; init; }
#else
        public global::RetellAI.TextTestCaseJobV3? Text { get; }
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
            out global::RetellAI.TextTestCaseJobV3? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextTestCaseJobV3 PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.AudioTestCaseJobV3? Audio { get; init; }
#else
        public global::RetellAI.AudioTestCaseJobV3? Audio { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Audio))]
#endif
        public bool IsAudio => Audio != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAudio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.AudioTestCaseJobV3? value)
        {
            value = Audio;
            return IsAudio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AudioTestCaseJobV3 PickAudio() => Audio is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Audio' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.AsrTestCaseJobV3? Asr { get; init; }
#else
        public global::RetellAI.AsrTestCaseJobV3? Asr { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Asr))]
#endif
        public bool IsAsr => Asr != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAsr(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.AsrTestCaseJobV3? value)
        {
            value = Asr;
            return IsAsr;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AsrTestCaseJobV3 PickAsr() => Asr is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Asr' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TestCaseJobV3(global::RetellAI.TextTestCaseJobV3 value) => new TestCaseJobV3((global::RetellAI.TextTestCaseJobV3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.TextTestCaseJobV3?(TestCaseJobV3 @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public TestCaseJobV3(global::RetellAI.TextTestCaseJobV3? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TestCaseJobV3 FromText(global::RetellAI.TextTestCaseJobV3? value) => new TestCaseJobV3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TestCaseJobV3(global::RetellAI.AudioTestCaseJobV3 value) => new TestCaseJobV3((global::RetellAI.AudioTestCaseJobV3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.AudioTestCaseJobV3?(TestCaseJobV3 @this) => @this.Audio;

        /// <summary>
        ///
        /// </summary>
        public TestCaseJobV3(global::RetellAI.AudioTestCaseJobV3? value)
        {
            Audio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TestCaseJobV3 FromAudio(global::RetellAI.AudioTestCaseJobV3? value) => new TestCaseJobV3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TestCaseJobV3(global::RetellAI.AsrTestCaseJobV3 value) => new TestCaseJobV3((global::RetellAI.AsrTestCaseJobV3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.AsrTestCaseJobV3?(TestCaseJobV3 @this) => @this.Asr;

        /// <summary>
        ///
        /// </summary>
        public TestCaseJobV3(global::RetellAI.AsrTestCaseJobV3? value)
        {
            Asr = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TestCaseJobV3 FromAsr(global::RetellAI.AsrTestCaseJobV3? value) => new TestCaseJobV3(value);

        /// <summary>
        ///
        /// </summary>
        public TestCaseJobV3(
            global::RetellAI.TextTestCaseJobV3? text,
            global::RetellAI.AudioTestCaseJobV3? audio,
            global::RetellAI.AsrTestCaseJobV3? asr
            )
        {
            Text = text;
            Audio = audio;
            Asr = asr;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Asr as object ??
            Audio as object ??
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Audio?.ToString() ??
            Asr?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsAudio && !IsAsr || !IsText && IsAudio && !IsAsr || !IsText && !IsAudio && IsAsr;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.TextTestCaseJobV3?, TResult>? text = null,
            global::System.Func<global::RetellAI.AudioTestCaseJobV3?, TResult>? audio = null,
            global::System.Func<global::RetellAI.AsrTestCaseJobV3?, TResult>? asr = null,
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
            else if (Audio is { } __value1 && audio != null)
            {
                return audio(__value1);
            }
            else if (Asr is { } __value2 && asr != null)
            {
                return asr(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.TextTestCaseJobV3?>? text = null,

            global::System.Action<global::RetellAI.AudioTestCaseJobV3?>? audio = null,

            global::System.Action<global::RetellAI.AsrTestCaseJobV3?>? asr = null,
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
            else if (Audio is { } __value1)
            {
                audio?.Invoke(__value1);
            }
            else if (Asr is { } __value2)
            {
                asr?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.TextTestCaseJobV3?>? text = null,
            global::System.Action<global::RetellAI.AudioTestCaseJobV3?>? audio = null,
            global::System.Action<global::RetellAI.AsrTestCaseJobV3?>? asr = null,
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
            else if (Audio is { } __value1)
            {
                audio?.Invoke(__value1);
            }
            else if (Asr is { } __value2)
            {
                asr?.Invoke(__value2);
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
                typeof(global::RetellAI.TextTestCaseJobV3),
                Audio,
                typeof(global::RetellAI.AudioTestCaseJobV3),
                Asr,
                typeof(global::RetellAI.AsrTestCaseJobV3),
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
        public bool Equals(TestCaseJobV3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TextTestCaseJobV3?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AudioTestCaseJobV3?>.Default.Equals(Audio, other.Audio) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AsrTestCaseJobV3?>.Default.Equals(Asr, other.Asr)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TestCaseJobV3 obj1, TestCaseJobV3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TestCaseJobV3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TestCaseJobV3 obj1, TestCaseJobV3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TestCaseJobV3 o && Equals(o);
        }
    }
}
