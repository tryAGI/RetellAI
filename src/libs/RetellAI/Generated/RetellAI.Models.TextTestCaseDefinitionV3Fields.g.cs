#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct TextTestCaseDefinitionV3Fields : global::System.IEquatable<TextTestCaseDefinitionV3Fields>
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
        public static implicit operator TextTestCaseDefinitionV3Fields(global::RetellAI.ConversationTestCaseDefinitionV3Base value) => new TextTestCaseDefinitionV3Fields((global::RetellAI.ConversationTestCaseDefinitionV3Base?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConversationTestCaseDefinitionV3Base?(TextTestCaseDefinitionV3Fields @this) => @this.ConversationBase;

        /// <summary>
        ///
        /// </summary>
        public TextTestCaseDefinitionV3Fields(global::RetellAI.ConversationTestCaseDefinitionV3Base? value)
        {
            ConversationBase = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TextTestCaseDefinitionV3Fields FromConversationBase(global::RetellAI.ConversationTestCaseDefinitionV3Base? value) => new TextTestCaseDefinitionV3Fields(value);

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ConversationBase as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ConversationBase?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsConversationBase;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ConversationTestCaseDefinitionV3Base?, TResult>? conversationBase = null,
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

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ConversationTestCaseDefinitionV3Base?>? conversationBase = null,
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
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ConversationTestCaseDefinitionV3Base?>? conversationBase = null,
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
        public bool Equals(TextTestCaseDefinitionV3Fields other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConversationTestCaseDefinitionV3Base?>.Default.Equals(ConversationBase, other.ConversationBase)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TextTestCaseDefinitionV3Fields obj1, TextTestCaseDefinitionV3Fields obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TextTestCaseDefinitionV3Fields>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TextTestCaseDefinitionV3Fields obj1, TextTestCaseDefinitionV3Fields obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextTestCaseDefinitionV3Fields o && Equals(o);
        }
    }
}
