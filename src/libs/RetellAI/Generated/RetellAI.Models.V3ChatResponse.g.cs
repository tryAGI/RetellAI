#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct V3ChatResponse : global::System.IEquatable<V3ChatResponse>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ChatResponse? ChatResponse { get; init; }
#else
        public global::RetellAI.ChatResponse? ChatResponse { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatResponse))]
#endif
        public bool IsChatResponse => ChatResponse != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChatResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ChatResponse? value)
        {
            value = ChatResponse;
            return IsChatResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatResponse PickChatResponse() => IsChatResponse
            ? ChatResponse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatResponse' but the value was {ToString()}.");

        /// <summary>
        /// V3 list chats response. Transcript fields are intentionally omitted.
        /// </summary>
#if NET6_0_OR_GREATER
        public object? V3ChatResponseVariant2 { get; init; }
#else
        public object? V3ChatResponseVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V3ChatResponseVariant2))]
#endif
        public bool IsV3ChatResponseVariant2 => V3ChatResponseVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickV3ChatResponseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = V3ChatResponseVariant2;
            return IsV3ChatResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickV3ChatResponseVariant2() => IsV3ChatResponseVariant2
            ? V3ChatResponseVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'V3ChatResponseVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator V3ChatResponse(global::RetellAI.ChatResponse value) => new V3ChatResponse((global::RetellAI.ChatResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ChatResponse?(V3ChatResponse @this) => @this.ChatResponse;

        /// <summary>
        ///
        /// </summary>
        public V3ChatResponse(global::RetellAI.ChatResponse? value)
        {
            ChatResponse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static V3ChatResponse FromChatResponse(global::RetellAI.ChatResponse? value) => new V3ChatResponse(value);

        /// <summary>
        ///
        /// </summary>
        public V3ChatResponse(
            global::RetellAI.ChatResponse? chatResponse,
            object? v3ChatResponseVariant2
            )
        {
            ChatResponse = chatResponse;
            V3ChatResponseVariant2 = v3ChatResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            V3ChatResponseVariant2 as object ??
            ChatResponse as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ChatResponse?.ToString() ??
            V3ChatResponseVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsChatResponse && IsV3ChatResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ChatResponse, TResult>? chatResponse = null,
            global::System.Func<object, TResult>? v3ChatResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatResponse && chatResponse != null)
            {
                return chatResponse(ChatResponse!);
            }
            else if (IsV3ChatResponseVariant2 && v3ChatResponseVariant2 != null)
            {
                return v3ChatResponseVariant2(V3ChatResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ChatResponse>? chatResponse = null,

            global::System.Action<object>? v3ChatResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatResponse)
            {
                chatResponse?.Invoke(ChatResponse!);
            }
            else if (IsV3ChatResponseVariant2)
            {
                v3ChatResponseVariant2?.Invoke(V3ChatResponseVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ChatResponse>? chatResponse = null,
            global::System.Action<object>? v3ChatResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatResponse)
            {
                chatResponse?.Invoke(ChatResponse!);
            }
            else if (IsV3ChatResponseVariant2)
            {
                v3ChatResponseVariant2?.Invoke(V3ChatResponseVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatResponse,
                typeof(global::RetellAI.ChatResponse),
                V3ChatResponseVariant2,
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
        public bool Equals(V3ChatResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ChatResponse?>.Default.Equals(ChatResponse, other.ChatResponse) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(V3ChatResponseVariant2, other.V3ChatResponseVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(V3ChatResponse obj1, V3ChatResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V3ChatResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(V3ChatResponse obj1, V3ChatResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V3ChatResponse o && Equals(o);
        }
    }
}
