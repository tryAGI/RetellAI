#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct TextTestCaseJobV3 : global::System.IEquatable<TextTestCaseJobV3>
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
        public global::RetellAI.TextTestCaseJobV3Variant2? TextTestCaseJobV3Variant2 { get; init; }
#else
        public global::RetellAI.TextTestCaseJobV3Variant2? TextTestCaseJobV3Variant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextTestCaseJobV3Variant2))]
#endif
        public bool IsTextTestCaseJobV3Variant2 => TextTestCaseJobV3Variant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextTestCaseJobV3Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.TextTestCaseJobV3Variant2? value)
        {
            value = TextTestCaseJobV3Variant2;
            return IsTextTestCaseJobV3Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextTestCaseJobV3Variant2 PickTextTestCaseJobV3Variant2() => TextTestCaseJobV3Variant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextTestCaseJobV3Variant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TextTestCaseJobV3(global::RetellAI.ConversationTestCaseJobV3Base value) => new TextTestCaseJobV3((global::RetellAI.ConversationTestCaseJobV3Base?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConversationTestCaseJobV3Base?(TextTestCaseJobV3 @this) => @this.ConversationBase;

        /// <summary>
        ///
        /// </summary>
        public TextTestCaseJobV3(global::RetellAI.ConversationTestCaseJobV3Base? value)
        {
            ConversationBase = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TextTestCaseJobV3 FromConversationBase(global::RetellAI.ConversationTestCaseJobV3Base? value) => new TextTestCaseJobV3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TextTestCaseJobV3(global::RetellAI.TextTestCaseJobV3Variant2 value) => new TextTestCaseJobV3((global::RetellAI.TextTestCaseJobV3Variant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.TextTestCaseJobV3Variant2?(TextTestCaseJobV3 @this) => @this.TextTestCaseJobV3Variant2;

        /// <summary>
        ///
        /// </summary>
        public TextTestCaseJobV3(global::RetellAI.TextTestCaseJobV3Variant2? value)
        {
            TextTestCaseJobV3Variant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TextTestCaseJobV3 FromTextTestCaseJobV3Variant2(global::RetellAI.TextTestCaseJobV3Variant2? value) => new TextTestCaseJobV3(value);

        /// <summary>
        ///
        /// </summary>
        public TextTestCaseJobV3(
            global::RetellAI.ConversationTestCaseJobV3Base? conversationBase,
            global::RetellAI.TextTestCaseJobV3Variant2? textTestCaseJobV3Variant2
            )
        {
            ConversationBase = conversationBase;
            TextTestCaseJobV3Variant2 = textTestCaseJobV3Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TextTestCaseJobV3Variant2 as object ??
            ConversationBase as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ConversationBase?.ToString() ??
            TextTestCaseJobV3Variant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsConversationBase && IsTextTestCaseJobV3Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ConversationTestCaseJobV3Base?, TResult>? conversationBase = null,
            global::System.Func<global::RetellAI.TextTestCaseJobV3Variant2, TResult>? textTestCaseJobV3Variant2 = null,
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
            else if (TextTestCaseJobV3Variant2 is { } __value1 && textTestCaseJobV3Variant2 != null)
            {
                return textTestCaseJobV3Variant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ConversationTestCaseJobV3Base?>? conversationBase = null,

            global::System.Action<global::RetellAI.TextTestCaseJobV3Variant2>? textTestCaseJobV3Variant2 = null,
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
            else if (TextTestCaseJobV3Variant2 is { } __value1)
            {
                textTestCaseJobV3Variant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ConversationTestCaseJobV3Base?>? conversationBase = null,
            global::System.Action<global::RetellAI.TextTestCaseJobV3Variant2>? textTestCaseJobV3Variant2 = null,
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
            else if (TextTestCaseJobV3Variant2 is { } __value1)
            {
                textTestCaseJobV3Variant2?.Invoke(__value1);
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
                TextTestCaseJobV3Variant2,
                typeof(global::RetellAI.TextTestCaseJobV3Variant2),
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
        public bool Equals(TextTestCaseJobV3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConversationTestCaseJobV3Base?>.Default.Equals(ConversationBase, other.ConversationBase) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TextTestCaseJobV3Variant2?>.Default.Equals(TextTestCaseJobV3Variant2, other.TextTestCaseJobV3Variant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TextTestCaseJobV3 obj1, TextTestCaseJobV3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TextTestCaseJobV3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TextTestCaseJobV3 obj1, TextTestCaseJobV3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextTestCaseJobV3 o && Equals(o);
        }
    }
}
