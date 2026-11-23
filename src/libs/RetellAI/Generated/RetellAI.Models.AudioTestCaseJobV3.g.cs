#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AudioTestCaseJobV3 : global::System.IEquatable<AudioTestCaseJobV3>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConversationTestCaseJobV3Base? ConversationBase { get; init; }
#else
        public global::RetellAI.ConversationTestCaseJobV3Base? ConversationBase { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationBase))]
#endif
        public bool IsConversationBase => ConversationBase != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConversationBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConversationTestCaseJobV3Base? value)
        {
            value = ConversationBase;
            return IsConversationBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationTestCaseJobV3Base PickConversationBase() => ConversationBase is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationBase' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.AudioTestCaseJobV3Variant2? AudioTestCaseJobV3Variant2 { get; init; }
#else
        public global::RetellAI.AudioTestCaseJobV3Variant2? AudioTestCaseJobV3Variant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioTestCaseJobV3Variant2))]
#endif
        public bool IsAudioTestCaseJobV3Variant2 => AudioTestCaseJobV3Variant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAudioTestCaseJobV3Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.AudioTestCaseJobV3Variant2? value)
        {
            value = AudioTestCaseJobV3Variant2;
            return IsAudioTestCaseJobV3Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AudioTestCaseJobV3Variant2 PickAudioTestCaseJobV3Variant2() => AudioTestCaseJobV3Variant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AudioTestCaseJobV3Variant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AudioTestCaseJobV3(global::RetellAI.ConversationTestCaseJobV3Base value) => new AudioTestCaseJobV3((global::RetellAI.ConversationTestCaseJobV3Base?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConversationTestCaseJobV3Base?(AudioTestCaseJobV3 @this) => @this.ConversationBase;

        /// <summary>
        ///
        /// </summary>
        public AudioTestCaseJobV3(global::RetellAI.ConversationTestCaseJobV3Base? value)
        {
            ConversationBase = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AudioTestCaseJobV3 FromConversationBase(global::RetellAI.ConversationTestCaseJobV3Base? value) => new AudioTestCaseJobV3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AudioTestCaseJobV3(global::RetellAI.AudioTestCaseJobV3Variant2 value) => new AudioTestCaseJobV3((global::RetellAI.AudioTestCaseJobV3Variant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.AudioTestCaseJobV3Variant2?(AudioTestCaseJobV3 @this) => @this.AudioTestCaseJobV3Variant2;

        /// <summary>
        ///
        /// </summary>
        public AudioTestCaseJobV3(global::RetellAI.AudioTestCaseJobV3Variant2? value)
        {
            AudioTestCaseJobV3Variant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AudioTestCaseJobV3 FromAudioTestCaseJobV3Variant2(global::RetellAI.AudioTestCaseJobV3Variant2? value) => new AudioTestCaseJobV3(value);

        /// <summary>
        ///
        /// </summary>
        public AudioTestCaseJobV3(
            global::RetellAI.ConversationTestCaseJobV3Base? conversationBase,
            global::RetellAI.AudioTestCaseJobV3Variant2? audioTestCaseJobV3Variant2
            )
        {
            ConversationBase = conversationBase;
            AudioTestCaseJobV3Variant2 = audioTestCaseJobV3Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AudioTestCaseJobV3Variant2 as object ??
            ConversationBase as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ConversationBase?.ToString() ??
            AudioTestCaseJobV3Variant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsConversationBase && IsAudioTestCaseJobV3Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ConversationTestCaseJobV3Base?, TResult>? conversationBase = null,
            global::System.Func<global::RetellAI.AudioTestCaseJobV3Variant2, TResult>? audioTestCaseJobV3Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ConversationBase is { } __value0 && conversationBase != null)
            {
                return conversationBase(__value0);
            }
            else if (AudioTestCaseJobV3Variant2 is { } __value1 && audioTestCaseJobV3Variant2 != null)
            {
                return audioTestCaseJobV3Variant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ConversationTestCaseJobV3Base?>? conversationBase = null,

            global::System.Action<global::RetellAI.AudioTestCaseJobV3Variant2>? audioTestCaseJobV3Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ConversationBase is { } __value0)
            {
                conversationBase?.Invoke(__value0);
            }
            else if (AudioTestCaseJobV3Variant2 is { } __value1)
            {
                audioTestCaseJobV3Variant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ConversationTestCaseJobV3Base?>? conversationBase = null,
            global::System.Action<global::RetellAI.AudioTestCaseJobV3Variant2>? audioTestCaseJobV3Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ConversationBase is { } __value0)
            {
                conversationBase?.Invoke(__value0);
            }
            else if (AudioTestCaseJobV3Variant2 is { } __value1)
            {
                audioTestCaseJobV3Variant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ConversationBase,
                typeof(global::RetellAI.ConversationTestCaseJobV3Base),
                AudioTestCaseJobV3Variant2,
                typeof(global::RetellAI.AudioTestCaseJobV3Variant2),
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
        public bool Equals(AudioTestCaseJobV3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConversationTestCaseJobV3Base?>.Default.Equals(ConversationBase, other.ConversationBase) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AudioTestCaseJobV3Variant2?>.Default.Equals(AudioTestCaseJobV3Variant2, other.AudioTestCaseJobV3Variant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AudioTestCaseJobV3 obj1, AudioTestCaseJobV3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AudioTestCaseJobV3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AudioTestCaseJobV3 obj1, AudioTestCaseJobV3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AudioTestCaseJobV3 o && Equals(o);
        }
    }
}
