#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContactConversation : global::System.IEquatable<ContactConversation>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ContactCall? Call { get; init; }
#else
        public global::RetellAI.ContactCall? Call { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Call))]
#endif
        public bool IsCall => Call != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ContactCall? value)
        {
            value = Call;
            return IsCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.ContactCall PickCall() => IsCall
            ? Call!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Call' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ContactChat? Chat { get; init; }
#else
        public global::RetellAI.ContactChat? Chat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Chat))]
#endif
        public bool IsChat => Chat != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChat(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ContactChat? value)
        {
            value = Chat;
            return IsChat;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.ContactChat PickChat() => IsChat
            ? Chat!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Chat' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContactConversation(global::RetellAI.ContactCall value) => new ContactConversation((global::RetellAI.ContactCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ContactCall?(ContactConversation @this) => @this.Call;

        /// <summary>
        /// 
        /// </summary>
        public ContactConversation(global::RetellAI.ContactCall? value)
        {
            Call = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContactConversation FromCall(global::RetellAI.ContactCall? value) => new ContactConversation(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContactConversation(global::RetellAI.ContactChat value) => new ContactConversation((global::RetellAI.ContactChat?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ContactChat?(ContactConversation @this) => @this.Chat;

        /// <summary>
        /// 
        /// </summary>
        public ContactConversation(global::RetellAI.ContactChat? value)
        {
            Chat = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContactConversation FromChat(global::RetellAI.ContactChat? value) => new ContactConversation(value);

        /// <summary>
        /// 
        /// </summary>
        public ContactConversation(
            global::RetellAI.ContactCall? call,
            global::RetellAI.ContactChat? chat
            )
        {
            Call = call;
            Chat = chat;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Chat as object ??
            Call as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Call?.ToString() ??
            Chat?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCall && !IsChat || !IsCall && IsChat;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ContactCall, TResult>? call = null,
            global::System.Func<global::RetellAI.ContactChat, TResult>? chat = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCall && call != null)
            {
                return call(Call!);
            }
            else if (IsChat && chat != null)
            {
                return chat(Chat!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ContactCall>? call = null,

            global::System.Action<global::RetellAI.ContactChat>? chat = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCall)
            {
                call?.Invoke(Call!);
            }
            else if (IsChat)
            {
                chat?.Invoke(Chat!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ContactCall>? call = null,
            global::System.Action<global::RetellAI.ContactChat>? chat = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCall)
            {
                call?.Invoke(Call!);
            }
            else if (IsChat)
            {
                chat?.Invoke(Chat!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Call,
                typeof(global::RetellAI.ContactCall),
                Chat,
                typeof(global::RetellAI.ContactChat),
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
        public bool Equals(ContactConversation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ContactCall?>.Default.Equals(Call, other.Call) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ContactChat?>.Default.Equals(Chat, other.Chat) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContactConversation obj1, ContactConversation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContactConversation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContactConversation obj1, ContactConversation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContactConversation o && Equals(o);
        }
    }
}
