#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Utterance : global::System.IEquatable<Utterance>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TextUtterance? Text { get; init; }
#else
        public global::RetellAI.TextUtterance? Text { get; }
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
            out global::RetellAI.TextUtterance? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextUtterance PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.UtteranceVariant2? UtteranceVariant2 { get; init; }
#else
        public global::RetellAI.UtteranceVariant2? UtteranceVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UtteranceVariant2))]
#endif
        public bool IsUtteranceVariant2 => UtteranceVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUtteranceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.UtteranceVariant2? value)
        {
            value = UtteranceVariant2;
            return IsUtteranceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceVariant2 PickUtteranceVariant2() => UtteranceVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UtteranceVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Utterance(global::RetellAI.TextUtterance value) => new Utterance((global::RetellAI.TextUtterance?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.TextUtterance?(Utterance @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public Utterance(global::RetellAI.TextUtterance? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Utterance FromText(global::RetellAI.TextUtterance? value) => new Utterance(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Utterance(global::RetellAI.UtteranceVariant2 value) => new Utterance((global::RetellAI.UtteranceVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.UtteranceVariant2?(Utterance @this) => @this.UtteranceVariant2;

        /// <summary>
        ///
        /// </summary>
        public Utterance(global::RetellAI.UtteranceVariant2? value)
        {
            UtteranceVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Utterance FromUtteranceVariant2(global::RetellAI.UtteranceVariant2? value) => new Utterance(value);

        /// <summary>
        ///
        /// </summary>
        public Utterance(
            global::RetellAI.TextUtterance? text,
            global::RetellAI.UtteranceVariant2? utteranceVariant2
            )
        {
            Text = text;
            UtteranceVariant2 = utteranceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            UtteranceVariant2 as object ??
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            UtteranceVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && IsUtteranceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.TextUtterance, TResult>? text = null,
            global::System.Func<global::RetellAI.UtteranceVariant2, TResult>? utteranceVariant2 = null,
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
            else if (UtteranceVariant2 is { } __value1 && utteranceVariant2 != null)
            {
                return utteranceVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.TextUtterance>? text = null,

            global::System.Action<global::RetellAI.UtteranceVariant2>? utteranceVariant2 = null,
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
            else if (UtteranceVariant2 is { } __value1)
            {
                utteranceVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.TextUtterance>? text = null,
            global::System.Action<global::RetellAI.UtteranceVariant2>? utteranceVariant2 = null,
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
            else if (UtteranceVariant2 is { } __value1)
            {
                utteranceVariant2?.Invoke(__value1);
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
                typeof(global::RetellAI.TextUtterance),
                UtteranceVariant2,
                typeof(global::RetellAI.UtteranceVariant2),
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
        public bool Equals(Utterance other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TextUtterance?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.UtteranceVariant2?>.Default.Equals(UtteranceVariant2, other.UtteranceVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Utterance obj1, Utterance obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Utterance>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Utterance obj1, Utterance obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Utterance o && Equals(o);
        }
    }
}
