#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ConversationFlow : global::System.IEquatable<ConversationFlow>
    {
        /// <summary>
        /// Override properties for conversation flow configuration in agent override requests.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConversationFlowOverride? Override { get; init; }
#else
        public global::RetellAI.ConversationFlowOverride? Override { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Override))]
#endif
        public bool IsOverride => Override != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConversationFlowVariant2? ConversationFlowVariant2 { get; init; }
#else
        public global::RetellAI.ConversationFlowVariant2? ConversationFlowVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationFlowVariant2))]
#endif
        public bool IsConversationFlowVariant2 => ConversationFlowVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlow(global::RetellAI.ConversationFlowOverride value) => new ConversationFlow((global::RetellAI.ConversationFlowOverride?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ConversationFlowOverride?(ConversationFlow @this) => @this.Override;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlow(global::RetellAI.ConversationFlowOverride? value)
        {
            Override = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlow(global::RetellAI.ConversationFlowVariant2 value) => new ConversationFlow((global::RetellAI.ConversationFlowVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ConversationFlowVariant2?(ConversationFlow @this) => @this.ConversationFlowVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlow(global::RetellAI.ConversationFlowVariant2? value)
        {
            ConversationFlowVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlow(
            global::RetellAI.ConversationFlowOverride? @override,
            global::RetellAI.ConversationFlowVariant2? conversationFlowVariant2
            )
        {
            Override = @override;
            ConversationFlowVariant2 = conversationFlowVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConversationFlowVariant2 as object ??
            Override as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Override?.ToString() ??
            ConversationFlowVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOverride && IsConversationFlowVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ConversationFlowOverride?, TResult>? @override = null,
            global::System.Func<global::RetellAI.ConversationFlowVariant2?, TResult>? conversationFlowVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOverride && @override != null)
            {
                return @override(Override!);
            }
            else if (IsConversationFlowVariant2 && conversationFlowVariant2 != null)
            {
                return conversationFlowVariant2(ConversationFlowVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ConversationFlowOverride?>? @override = null,
            global::System.Action<global::RetellAI.ConversationFlowVariant2?>? conversationFlowVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOverride)
            {
                @override?.Invoke(Override!);
            }
            else if (IsConversationFlowVariant2)
            {
                conversationFlowVariant2?.Invoke(ConversationFlowVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Override,
                typeof(global::RetellAI.ConversationFlowOverride),
                ConversationFlowVariant2,
                typeof(global::RetellAI.ConversationFlowVariant2),
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
        public bool Equals(ConversationFlow other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConversationFlowOverride?>.Default.Equals(Override, other.Override) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConversationFlowVariant2?>.Default.Equals(ConversationFlowVariant2, other.ConversationFlowVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ConversationFlow obj1, ConversationFlow obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConversationFlow>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ConversationFlow obj1, ConversationFlow obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConversationFlow o && Equals(o);
        }
    }
}
