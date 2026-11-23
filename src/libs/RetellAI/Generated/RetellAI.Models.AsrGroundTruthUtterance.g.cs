#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AsrGroundTruthUtterance : global::System.IEquatable<AsrGroundTruthUtterance>
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
        public global::RetellAI.AsrGroundTruthUtteranceVariant2? AsrGroundTruthUtteranceVariant2 { get; init; }
#else
        public global::RetellAI.AsrGroundTruthUtteranceVariant2? AsrGroundTruthUtteranceVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AsrGroundTruthUtteranceVariant2))]
#endif
        public bool IsAsrGroundTruthUtteranceVariant2 => AsrGroundTruthUtteranceVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAsrGroundTruthUtteranceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.AsrGroundTruthUtteranceVariant2? value)
        {
            value = AsrGroundTruthUtteranceVariant2;
            return IsAsrGroundTruthUtteranceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AsrGroundTruthUtteranceVariant2 PickAsrGroundTruthUtteranceVariant2() => AsrGroundTruthUtteranceVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AsrGroundTruthUtteranceVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AsrGroundTruthUtterance(global::RetellAI.TextUtterance value) => new AsrGroundTruthUtterance((global::RetellAI.TextUtterance?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.TextUtterance?(AsrGroundTruthUtterance @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public AsrGroundTruthUtterance(global::RetellAI.TextUtterance? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AsrGroundTruthUtterance FromText(global::RetellAI.TextUtterance? value) => new AsrGroundTruthUtterance(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AsrGroundTruthUtterance(global::RetellAI.AsrGroundTruthUtteranceVariant2 value) => new AsrGroundTruthUtterance((global::RetellAI.AsrGroundTruthUtteranceVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.AsrGroundTruthUtteranceVariant2?(AsrGroundTruthUtterance @this) => @this.AsrGroundTruthUtteranceVariant2;

        /// <summary>
        ///
        /// </summary>
        public AsrGroundTruthUtterance(global::RetellAI.AsrGroundTruthUtteranceVariant2? value)
        {
            AsrGroundTruthUtteranceVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AsrGroundTruthUtterance FromAsrGroundTruthUtteranceVariant2(global::RetellAI.AsrGroundTruthUtteranceVariant2? value) => new AsrGroundTruthUtterance(value);

        /// <summary>
        ///
        /// </summary>
        public AsrGroundTruthUtterance(
            global::RetellAI.TextUtterance? text,
            global::RetellAI.AsrGroundTruthUtteranceVariant2? asrGroundTruthUtteranceVariant2
            )
        {
            Text = text;
            AsrGroundTruthUtteranceVariant2 = asrGroundTruthUtteranceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AsrGroundTruthUtteranceVariant2 as object ??
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            AsrGroundTruthUtteranceVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && IsAsrGroundTruthUtteranceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.TextUtterance, TResult>? text = null,
            global::System.Func<global::RetellAI.AsrGroundTruthUtteranceVariant2, TResult>? asrGroundTruthUtteranceVariant2 = null,
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
            else if (AsrGroundTruthUtteranceVariant2 is { } __value1 && asrGroundTruthUtteranceVariant2 != null)
            {
                return asrGroundTruthUtteranceVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.TextUtterance>? text = null,

            global::System.Action<global::RetellAI.AsrGroundTruthUtteranceVariant2>? asrGroundTruthUtteranceVariant2 = null,
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
            else if (AsrGroundTruthUtteranceVariant2 is { } __value1)
            {
                asrGroundTruthUtteranceVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.TextUtterance>? text = null,
            global::System.Action<global::RetellAI.AsrGroundTruthUtteranceVariant2>? asrGroundTruthUtteranceVariant2 = null,
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
            else if (AsrGroundTruthUtteranceVariant2 is { } __value1)
            {
                asrGroundTruthUtteranceVariant2?.Invoke(__value1);
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
                AsrGroundTruthUtteranceVariant2,
                typeof(global::RetellAI.AsrGroundTruthUtteranceVariant2),
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
        public bool Equals(AsrGroundTruthUtterance other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TextUtterance?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AsrGroundTruthUtteranceVariant2?>.Default.Equals(AsrGroundTruthUtteranceVariant2, other.AsrGroundTruthUtteranceVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AsrGroundTruthUtterance obj1, AsrGroundTruthUtterance obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AsrGroundTruthUtterance>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AsrGroundTruthUtterance obj1, AsrGroundTruthUtterance obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AsrGroundTruthUtterance o && Equals(o);
        }
    }
}
