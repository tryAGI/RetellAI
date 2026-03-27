#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponseEngine : global::System.IEquatable<ResponseEngine>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ResponseEngineRetellLm? RetellLm { get; init; }
#else
        public global::RetellAI.ResponseEngineRetellLm? RetellLm { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RetellLm))]
#endif
        public bool IsRetellLm => RetellLm != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ResponseEngineCustomLm? CustomLm { get; init; }
#else
        public global::RetellAI.ResponseEngineCustomLm? CustomLm { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomLm))]
#endif
        public bool IsCustomLm => CustomLm != null;

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
        public static implicit operator ResponseEngine(global::RetellAI.ResponseEngineRetellLm value) => new ResponseEngine((global::RetellAI.ResponseEngineRetellLm?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ResponseEngineRetellLm?(ResponseEngine @this) => @this.RetellLm;

        /// <summary>
        /// 
        /// </summary>
        public ResponseEngine(global::RetellAI.ResponseEngineRetellLm? value)
        {
            RetellLm = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseEngine(global::RetellAI.ResponseEngineCustomLm value) => new ResponseEngine((global::RetellAI.ResponseEngineCustomLm?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ResponseEngineCustomLm?(ResponseEngine @this) => @this.CustomLm;

        /// <summary>
        /// 
        /// </summary>
        public ResponseEngine(global::RetellAI.ResponseEngineCustomLm? value)
        {
            CustomLm = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseEngine(global::RetellAI.ResponseEngineConversationFlow value) => new ResponseEngine((global::RetellAI.ResponseEngineConversationFlow?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ResponseEngineConversationFlow?(ResponseEngine @this) => @this.ConversationFlow;

        /// <summary>
        /// 
        /// </summary>
        public ResponseEngine(global::RetellAI.ResponseEngineConversationFlow? value)
        {
            ConversationFlow = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponseEngine(
            global::RetellAI.ResponseEngineRetellLm? retellLm,
            global::RetellAI.ResponseEngineCustomLm? customLm,
            global::RetellAI.ResponseEngineConversationFlow? conversationFlow
            )
        {
            RetellLm = retellLm;
            CustomLm = customLm;
            ConversationFlow = conversationFlow;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConversationFlow as object ??
            CustomLm as object ??
            RetellLm as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RetellLm?.ToString() ??
            CustomLm?.ToString() ??
            ConversationFlow?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRetellLm && !IsCustomLm && !IsConversationFlow || !IsRetellLm && IsCustomLm && !IsConversationFlow || !IsRetellLm && !IsCustomLm && IsConversationFlow;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ResponseEngineRetellLm?, TResult>? retellLm = null,
            global::System.Func<global::RetellAI.ResponseEngineCustomLm?, TResult>? customLm = null,
            global::System.Func<global::RetellAI.ResponseEngineConversationFlow?, TResult>? conversationFlow = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRetellLm && retellLm != null)
            {
                return retellLm(RetellLm!);
            }
            else if (IsCustomLm && customLm != null)
            {
                return customLm(CustomLm!);
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
            global::System.Action<global::RetellAI.ResponseEngineRetellLm?>? retellLm = null,
            global::System.Action<global::RetellAI.ResponseEngineCustomLm?>? customLm = null,
            global::System.Action<global::RetellAI.ResponseEngineConversationFlow?>? conversationFlow = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRetellLm)
            {
                retellLm?.Invoke(RetellLm!);
            }
            else if (IsCustomLm)
            {
                customLm?.Invoke(CustomLm!);
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
                RetellLm,
                typeof(global::RetellAI.ResponseEngineRetellLm),
                CustomLm,
                typeof(global::RetellAI.ResponseEngineCustomLm),
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
        public bool Equals(ResponseEngine other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ResponseEngineRetellLm?>.Default.Equals(RetellLm, other.RetellLm) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ResponseEngineCustomLm?>.Default.Equals(CustomLm, other.CustomLm) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ResponseEngineConversationFlow?>.Default.Equals(ConversationFlow, other.ConversationFlow) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponseEngine obj1, ResponseEngine obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseEngine>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponseEngine obj1, ResponseEngine obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseEngine o && Equals(o);
        }
    }
}
