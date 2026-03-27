#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Response engine for test cases. Custom LLM is not supported.
    /// </summary>
    public readonly partial struct RetellResponseEngine : global::System.IEquatable<RetellResponseEngine>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ResponseEngineRetellLm? Lm { get; init; }
#else
        public global::RetellAI.ResponseEngineRetellLm? Lm { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Lm))]
#endif
        public bool IsLm => Lm != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ResponseEngineConversationFlow? ConversationFlow { get; init; }
#else
        public global::RetellAI.ResponseEngineConversationFlow? ConversationFlow { get; }
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
        public static implicit operator RetellResponseEngine(global::RetellAI.ResponseEngineRetellLm value) => new RetellResponseEngine((global::RetellAI.ResponseEngineRetellLm?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ResponseEngineRetellLm?(RetellResponseEngine @this) => @this.Lm;

        /// <summary>
        /// 
        /// </summary>
        public RetellResponseEngine(global::RetellAI.ResponseEngineRetellLm? value)
        {
            Lm = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RetellResponseEngine(global::RetellAI.ResponseEngineConversationFlow value) => new RetellResponseEngine((global::RetellAI.ResponseEngineConversationFlow?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ResponseEngineConversationFlow?(RetellResponseEngine @this) => @this.ConversationFlow;

        /// <summary>
        /// 
        /// </summary>
        public RetellResponseEngine(global::RetellAI.ResponseEngineConversationFlow? value)
        {
            ConversationFlow = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RetellResponseEngine(
            global::RetellAI.ResponseEngineRetellLm? lm,
            global::RetellAI.ResponseEngineConversationFlow? conversationFlow
            )
        {
            Lm = lm;
            ConversationFlow = conversationFlow;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConversationFlow as object ??
            Lm as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Lm?.ToString() ??
            ConversationFlow?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLm && !IsConversationFlow || !IsLm && IsConversationFlow;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ResponseEngineRetellLm?, TResult>? lm = null,
            global::System.Func<global::RetellAI.ResponseEngineConversationFlow?, TResult>? conversationFlow = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLm && lm != null)
            {
                return lm(Lm!);
            }
            else if (IsConversationFlow && conversationFlow != null)
            {
                return conversationFlow(ConversationFlow!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ResponseEngineRetellLm?>? lm = null,
            global::System.Action<global::RetellAI.ResponseEngineConversationFlow?>? conversationFlow = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLm)
            {
                lm?.Invoke(Lm!);
            }
            else if (IsConversationFlow)
            {
                conversationFlow?.Invoke(ConversationFlow!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Lm,
                typeof(global::RetellAI.ResponseEngineRetellLm),
                ConversationFlow,
                typeof(global::RetellAI.ResponseEngineConversationFlow),
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
        public bool Equals(RetellResponseEngine other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ResponseEngineRetellLm?>.Default.Equals(Lm, other.Lm) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ResponseEngineConversationFlow?>.Default.Equals(ConversationFlow, other.ConversationFlow) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RetellResponseEngine obj1, RetellResponseEngine obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RetellResponseEngine>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RetellResponseEngine obj1, RetellResponseEngine obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RetellResponseEngine o && Equals(o);
        }
    }
}
