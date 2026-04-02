#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateConversationFlowComponentRequest : global::System.IEquatable<CreateConversationFlowComponentRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConversationFlowComponent? ConversationFlowComponent { get; init; }
#else
        public global::RetellAI.ConversationFlowComponent? ConversationFlowComponent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationFlowComponent))]
#endif
        public bool IsConversationFlowComponent => ConversationFlowComponent != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? CreateConversationFlowComponentRequestVariant2 { get; init; }
#else
        public object? CreateConversationFlowComponentRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateConversationFlowComponentRequestVariant2))]
#endif
        public bool IsCreateConversationFlowComponentRequestVariant2 => CreateConversationFlowComponentRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateConversationFlowComponentRequest(global::RetellAI.ConversationFlowComponent value) => new CreateConversationFlowComponentRequest((global::RetellAI.ConversationFlowComponent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ConversationFlowComponent?(CreateConversationFlowComponentRequest @this) => @this.ConversationFlowComponent;

        /// <summary>
        /// 
        /// </summary>
        public CreateConversationFlowComponentRequest(global::RetellAI.ConversationFlowComponent? value)
        {
            ConversationFlowComponent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateConversationFlowComponentRequest(
            global::RetellAI.ConversationFlowComponent? conversationFlowComponent,
            object? createConversationFlowComponentRequestVariant2
            )
        {
            ConversationFlowComponent = conversationFlowComponent;
            CreateConversationFlowComponentRequestVariant2 = createConversationFlowComponentRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateConversationFlowComponentRequestVariant2 as object ??
            ConversationFlowComponent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ConversationFlowComponent?.ToString() ??
            CreateConversationFlowComponentRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConversationFlowComponent && IsCreateConversationFlowComponentRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ConversationFlowComponent?, TResult>? conversationFlowComponent = null,
            global::System.Func<object?, TResult>? createConversationFlowComponentRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationFlowComponent && conversationFlowComponent != null)
            {
                return conversationFlowComponent(ConversationFlowComponent!);
            }
            else if (IsCreateConversationFlowComponentRequestVariant2 && createConversationFlowComponentRequestVariant2 != null)
            {
                return createConversationFlowComponentRequestVariant2(CreateConversationFlowComponentRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ConversationFlowComponent?>? conversationFlowComponent = null,
            global::System.Action<object?>? createConversationFlowComponentRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationFlowComponent)
            {
                conversationFlowComponent?.Invoke(ConversationFlowComponent!);
            }
            else if (IsCreateConversationFlowComponentRequestVariant2)
            {
                createConversationFlowComponentRequestVariant2?.Invoke(CreateConversationFlowComponentRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ConversationFlowComponent,
                typeof(global::RetellAI.ConversationFlowComponent),
                CreateConversationFlowComponentRequestVariant2,
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
        public bool Equals(CreateConversationFlowComponentRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConversationFlowComponent?>.Default.Equals(ConversationFlowComponent, other.ConversationFlowComponent) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(CreateConversationFlowComponentRequestVariant2, other.CreateConversationFlowComponentRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateConversationFlowComponentRequest obj1, CreateConversationFlowComponentRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateConversationFlowComponentRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateConversationFlowComponentRequest obj1, CreateConversationFlowComponentRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateConversationFlowComponentRequest o && Equals(o);
        }
    }
}
