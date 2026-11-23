#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AudioTestCaseDefinitionV3Fields : global::System.IEquatable<AudioTestCaseDefinitionV3Fields>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConversationTestCaseDefinitionV3Base? ConversationBase { get; init; }
#else
        public global::RetellAI.ConversationTestCaseDefinitionV3Base? ConversationBase { get; }
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
            out global::RetellAI.ConversationTestCaseDefinitionV3Base? value)
        {
            value = ConversationBase;
            return IsConversationBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationTestCaseDefinitionV3Base PickConversationBase() => ConversationBase is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationBase' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2? AudioTestCaseDefinitionV3FieldsVariant2 { get; init; }
#else
        public global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2? AudioTestCaseDefinitionV3FieldsVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioTestCaseDefinitionV3FieldsVariant2))]
#endif
        public bool IsAudioTestCaseDefinitionV3FieldsVariant2 => AudioTestCaseDefinitionV3FieldsVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAudioTestCaseDefinitionV3FieldsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2? value)
        {
            value = AudioTestCaseDefinitionV3FieldsVariant2;
            return IsAudioTestCaseDefinitionV3FieldsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2 PickAudioTestCaseDefinitionV3FieldsVariant2() => AudioTestCaseDefinitionV3FieldsVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AudioTestCaseDefinitionV3FieldsVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AudioTestCaseDefinitionV3Fields(global::RetellAI.ConversationTestCaseDefinitionV3Base value) => new AudioTestCaseDefinitionV3Fields((global::RetellAI.ConversationTestCaseDefinitionV3Base?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConversationTestCaseDefinitionV3Base?(AudioTestCaseDefinitionV3Fields @this) => @this.ConversationBase;

        /// <summary>
        ///
        /// </summary>
        public AudioTestCaseDefinitionV3Fields(global::RetellAI.ConversationTestCaseDefinitionV3Base? value)
        {
            ConversationBase = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AudioTestCaseDefinitionV3Fields FromConversationBase(global::RetellAI.ConversationTestCaseDefinitionV3Base? value) => new AudioTestCaseDefinitionV3Fields(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AudioTestCaseDefinitionV3Fields(global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2 value) => new AudioTestCaseDefinitionV3Fields((global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2?(AudioTestCaseDefinitionV3Fields @this) => @this.AudioTestCaseDefinitionV3FieldsVariant2;

        /// <summary>
        ///
        /// </summary>
        public AudioTestCaseDefinitionV3Fields(global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2? value)
        {
            AudioTestCaseDefinitionV3FieldsVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AudioTestCaseDefinitionV3Fields FromAudioTestCaseDefinitionV3FieldsVariant2(global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2? value) => new AudioTestCaseDefinitionV3Fields(value);

        /// <summary>
        ///
        /// </summary>
        public AudioTestCaseDefinitionV3Fields(
            global::RetellAI.ConversationTestCaseDefinitionV3Base? conversationBase,
            global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2? audioTestCaseDefinitionV3FieldsVariant2
            )
        {
            ConversationBase = conversationBase;
            AudioTestCaseDefinitionV3FieldsVariant2 = audioTestCaseDefinitionV3FieldsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AudioTestCaseDefinitionV3FieldsVariant2 as object ??
            ConversationBase as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ConversationBase?.ToString() ??
            AudioTestCaseDefinitionV3FieldsVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsConversationBase && IsAudioTestCaseDefinitionV3FieldsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ConversationTestCaseDefinitionV3Base?, TResult>? conversationBase = null,
            global::System.Func<global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2, TResult>? audioTestCaseDefinitionV3FieldsVariant2 = null,
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
            else if (AudioTestCaseDefinitionV3FieldsVariant2 is { } __value1 && audioTestCaseDefinitionV3FieldsVariant2 != null)
            {
                return audioTestCaseDefinitionV3FieldsVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ConversationTestCaseDefinitionV3Base?>? conversationBase = null,

            global::System.Action<global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2>? audioTestCaseDefinitionV3FieldsVariant2 = null,
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
            else if (AudioTestCaseDefinitionV3FieldsVariant2 is { } __value1)
            {
                audioTestCaseDefinitionV3FieldsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ConversationTestCaseDefinitionV3Base?>? conversationBase = null,
            global::System.Action<global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2>? audioTestCaseDefinitionV3FieldsVariant2 = null,
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
            else if (AudioTestCaseDefinitionV3FieldsVariant2 is { } __value1)
            {
                audioTestCaseDefinitionV3FieldsVariant2?.Invoke(__value1);
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
                typeof(global::RetellAI.ConversationTestCaseDefinitionV3Base),
                AudioTestCaseDefinitionV3FieldsVariant2,
                typeof(global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2),
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
        public bool Equals(AudioTestCaseDefinitionV3Fields other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConversationTestCaseDefinitionV3Base?>.Default.Equals(ConversationBase, other.ConversationBase) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2?>.Default.Equals(AudioTestCaseDefinitionV3FieldsVariant2, other.AudioTestCaseDefinitionV3FieldsVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AudioTestCaseDefinitionV3Fields obj1, AudioTestCaseDefinitionV3Fields obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AudioTestCaseDefinitionV3Fields>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AudioTestCaseDefinitionV3Fields obj1, AudioTestCaseDefinitionV3Fields obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AudioTestCaseDefinitionV3Fields o && Equals(o);
        }
    }
}
