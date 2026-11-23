#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AudioTestCaseDefinitionV3Input : global::System.IEquatable<AudioTestCaseDefinitionV3Input>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.AudioTestCaseDefinitionV3Fields? Fields { get; init; }
#else
        public global::RetellAI.AudioTestCaseDefinitionV3Fields? Fields { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Fields))]
#endif
        public bool IsFields => Fields != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFields(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.AudioTestCaseDefinitionV3Fields? value)
        {
            value = Fields;
            return IsFields;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AudioTestCaseDefinitionV3Fields PickFields() => Fields is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Fields' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.AudioTestCaseDefinitionV3InputVariant2? AudioTestCaseDefinitionV3InputVariant2 { get; init; }
#else
        public global::RetellAI.AudioTestCaseDefinitionV3InputVariant2? AudioTestCaseDefinitionV3InputVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioTestCaseDefinitionV3InputVariant2))]
#endif
        public bool IsAudioTestCaseDefinitionV3InputVariant2 => AudioTestCaseDefinitionV3InputVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAudioTestCaseDefinitionV3InputVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.AudioTestCaseDefinitionV3InputVariant2? value)
        {
            value = AudioTestCaseDefinitionV3InputVariant2;
            return IsAudioTestCaseDefinitionV3InputVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AudioTestCaseDefinitionV3InputVariant2 PickAudioTestCaseDefinitionV3InputVariant2() => AudioTestCaseDefinitionV3InputVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AudioTestCaseDefinitionV3InputVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AudioTestCaseDefinitionV3Input(global::RetellAI.AudioTestCaseDefinitionV3Fields value) => new AudioTestCaseDefinitionV3Input((global::RetellAI.AudioTestCaseDefinitionV3Fields?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.AudioTestCaseDefinitionV3Fields?(AudioTestCaseDefinitionV3Input @this) => @this.Fields;

        /// <summary>
        ///
        /// </summary>
        public AudioTestCaseDefinitionV3Input(global::RetellAI.AudioTestCaseDefinitionV3Fields? value)
        {
            Fields = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AudioTestCaseDefinitionV3Input FromFields(global::RetellAI.AudioTestCaseDefinitionV3Fields? value) => new AudioTestCaseDefinitionV3Input(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AudioTestCaseDefinitionV3Input(global::RetellAI.AudioTestCaseDefinitionV3InputVariant2 value) => new AudioTestCaseDefinitionV3Input((global::RetellAI.AudioTestCaseDefinitionV3InputVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.AudioTestCaseDefinitionV3InputVariant2?(AudioTestCaseDefinitionV3Input @this) => @this.AudioTestCaseDefinitionV3InputVariant2;

        /// <summary>
        ///
        /// </summary>
        public AudioTestCaseDefinitionV3Input(global::RetellAI.AudioTestCaseDefinitionV3InputVariant2? value)
        {
            AudioTestCaseDefinitionV3InputVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AudioTestCaseDefinitionV3Input FromAudioTestCaseDefinitionV3InputVariant2(global::RetellAI.AudioTestCaseDefinitionV3InputVariant2? value) => new AudioTestCaseDefinitionV3Input(value);

        /// <summary>
        ///
        /// </summary>
        public AudioTestCaseDefinitionV3Input(
            global::RetellAI.AudioTestCaseDefinitionV3Fields? fields,
            global::RetellAI.AudioTestCaseDefinitionV3InputVariant2? audioTestCaseDefinitionV3InputVariant2
            )
        {
            Fields = fields;
            AudioTestCaseDefinitionV3InputVariant2 = audioTestCaseDefinitionV3InputVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AudioTestCaseDefinitionV3InputVariant2 as object ??
            Fields as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Fields?.ToString() ??
            AudioTestCaseDefinitionV3InputVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFields && IsAudioTestCaseDefinitionV3InputVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.AudioTestCaseDefinitionV3Fields?, TResult>? fields = null,
            global::System.Func<global::RetellAI.AudioTestCaseDefinitionV3InputVariant2, TResult>? audioTestCaseDefinitionV3InputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Fields is { } __value0 && fields != null)
            {
                return fields(__value0);
            }
            else if (AudioTestCaseDefinitionV3InputVariant2 is { } __value1 && audioTestCaseDefinitionV3InputVariant2 != null)
            {
                return audioTestCaseDefinitionV3InputVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.AudioTestCaseDefinitionV3Fields?>? fields = null,

            global::System.Action<global::RetellAI.AudioTestCaseDefinitionV3InputVariant2>? audioTestCaseDefinitionV3InputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Fields is { } __value0)
            {
                fields?.Invoke(__value0);
            }
            else if (AudioTestCaseDefinitionV3InputVariant2 is { } __value1)
            {
                audioTestCaseDefinitionV3InputVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.AudioTestCaseDefinitionV3Fields?>? fields = null,
            global::System.Action<global::RetellAI.AudioTestCaseDefinitionV3InputVariant2>? audioTestCaseDefinitionV3InputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Fields is { } __value0)
            {
                fields?.Invoke(__value0);
            }
            else if (AudioTestCaseDefinitionV3InputVariant2 is { } __value1)
            {
                audioTestCaseDefinitionV3InputVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Fields,
                typeof(global::RetellAI.AudioTestCaseDefinitionV3Fields),
                AudioTestCaseDefinitionV3InputVariant2,
                typeof(global::RetellAI.AudioTestCaseDefinitionV3InputVariant2),
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
        public bool Equals(AudioTestCaseDefinitionV3Input other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AudioTestCaseDefinitionV3Fields?>.Default.Equals(Fields, other.Fields) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AudioTestCaseDefinitionV3InputVariant2?>.Default.Equals(AudioTestCaseDefinitionV3InputVariant2, other.AudioTestCaseDefinitionV3InputVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AudioTestCaseDefinitionV3Input obj1, AudioTestCaseDefinitionV3Input obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AudioTestCaseDefinitionV3Input>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AudioTestCaseDefinitionV3Input obj1, AudioTestCaseDefinitionV3Input obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AudioTestCaseDefinitionV3Input o && Equals(o);
        }
    }
}
