#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateConversationFlowRequest : global::System.IEquatable<CreateConversationFlowRequest>
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
        public object? CreateConversationFlowRequestVariant2 { get; init; }
#else
        public object? CreateConversationFlowRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateConversationFlowRequestVariant2))]
#endif
        public bool IsCreateConversationFlowRequestVariant2 => CreateConversationFlowRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateConversationFlowRequest(global::RetellAI.ConversationFlow value) => new CreateConversationFlowRequest((global::RetellAI.ConversationFlow?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ConversationFlow?(CreateConversationFlowRequest @this) => @this.ConversationFlow;

        /// <summary>
        /// 
        /// </summary>
        public CreateConversationFlowRequest(global::RetellAI.ConversationFlow? value)
        {
            ConversationFlow = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateConversationFlowRequest(
            global::RetellAI.ConversationFlow? conversationFlow,
            object? createConversationFlowRequestVariant2
            )
        {
            ConversationFlow = conversationFlow;
            CreateConversationFlowRequestVariant2 = createConversationFlowRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateConversationFlowRequestVariant2 as object ??
            ConversationFlow as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ConversationFlow?.ToString() ??
            CreateConversationFlowRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConversationFlow && IsCreateConversationFlowRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ConversationFlow?, TResult>? conversationFlow = null,
            global::System.Func<object?, TResult>? createConversationFlowRequestVariant2 = null,
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
            else if (IsCreateConversationFlowRequestVariant2 && createConversationFlowRequestVariant2 != null)
            {
                return createConversationFlowRequestVariant2(CreateConversationFlowRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ConversationFlow?>? conversationFlow = null,
            global::System.Action<object?>? createConversationFlowRequestVariant2 = null,
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
            else if (IsCreateConversationFlowRequestVariant2)
            {
                createConversationFlowRequestVariant2?.Invoke(CreateConversationFlowRequestVariant2!);
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
                CreateConversationFlowRequestVariant2,
                typeof(object),
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
        public bool Equals(CreateConversationFlowRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConversationFlow?>.Default.Equals(ConversationFlow, other.ConversationFlow) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(CreateConversationFlowRequestVariant2, other.CreateConversationFlowRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateConversationFlowRequest obj1, CreateConversationFlowRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateConversationFlowRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateConversationFlowRequest obj1, CreateConversationFlowRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateConversationFlowRequest o && Equals(o);
        }
    }
}
