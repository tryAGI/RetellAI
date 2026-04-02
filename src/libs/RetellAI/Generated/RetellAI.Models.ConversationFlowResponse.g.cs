#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ConversationFlowResponse : global::System.IEquatable<ConversationFlowResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConversationFlow? ConversationFlow { get; init; }
#else
        public global::RetellAI.ConversationFlow? ConversationFlow { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationFlow))]
#endif
        public bool IsConversationFlow => ConversationFlow != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConversationFlowResponseVariant2? ConversationFlowResponseVariant2 { get; init; }
#else
        public global::RetellAI.ConversationFlowResponseVariant2? ConversationFlowResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationFlowResponseVariant2))]
#endif
        public bool IsConversationFlowResponseVariant2 => ConversationFlowResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowResponse(global::RetellAI.ConversationFlow value) => new ConversationFlowResponse((global::RetellAI.ConversationFlow?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ConversationFlow?(ConversationFlowResponse @this) => @this.ConversationFlow;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowResponse(global::RetellAI.ConversationFlow? value)
        {
            ConversationFlow = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowResponse(global::RetellAI.ConversationFlowResponseVariant2 value) => new ConversationFlowResponse((global::RetellAI.ConversationFlowResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ConversationFlowResponseVariant2?(ConversationFlowResponse @this) => @this.ConversationFlowResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowResponse(global::RetellAI.ConversationFlowResponseVariant2? value)
        {
            ConversationFlowResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowResponse(
            global::RetellAI.ConversationFlow? conversationFlow,
            global::RetellAI.ConversationFlowResponseVariant2? conversationFlowResponseVariant2
            )
        {
            ConversationFlow = conversationFlow;
            ConversationFlowResponseVariant2 = conversationFlowResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConversationFlowResponseVariant2 as object ??
            ConversationFlow as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ConversationFlow?.ToString() ??
            ConversationFlowResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConversationFlow && IsConversationFlowResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ConversationFlow?, TResult>? conversationFlow = null,
            global::System.Func<global::RetellAI.ConversationFlowResponseVariant2?, TResult>? conversationFlowResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationFlow && conversationFlow != null)
            {
                return conversationFlow(ConversationFlow!);
            }
            else if (IsConversationFlowResponseVariant2 && conversationFlowResponseVariant2 != null)
            {
                return conversationFlowResponseVariant2(ConversationFlowResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ConversationFlow?>? conversationFlow = null,
            global::System.Action<global::RetellAI.ConversationFlowResponseVariant2?>? conversationFlowResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationFlow)
            {
                conversationFlow?.Invoke(ConversationFlow!);
            }
            else if (IsConversationFlowResponseVariant2)
            {
                conversationFlowResponseVariant2?.Invoke(ConversationFlowResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ConversationFlow,
                typeof(global::RetellAI.ConversationFlow),
                ConversationFlowResponseVariant2,
                typeof(global::RetellAI.ConversationFlowResponseVariant2),
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
        public bool Equals(ConversationFlowResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConversationFlow?>.Default.Equals(ConversationFlow, other.ConversationFlow) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConversationFlowResponseVariant2?>.Default.Equals(ConversationFlowResponseVariant2, other.ConversationFlowResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ConversationFlowResponse obj1, ConversationFlowResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConversationFlowResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ConversationFlowResponse obj1, ConversationFlowResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConversationFlowResponse o && Equals(o);
        }
    }
}
