#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessageOrToolCall : global::System.IEquatable<MessageOrToolCall>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.Message? Message { get; init; }
#else
        public global::RetellAI.Message? Message { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message))]
#endif
        public bool IsMessage => Message != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.Message? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.Message PickMessage() => IsMessage
            ? Message!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ToolCallInvocationMessage? Invocation { get; init; }
#else
        public global::RetellAI.ToolCallInvocationMessage? Invocation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Invocation))]
#endif
        public bool IsInvocation => Invocation != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInvocation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ToolCallInvocationMessage? value)
        {
            value = Invocation;
            return IsInvocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.ToolCallInvocationMessage PickInvocation() => IsInvocation
            ? Invocation!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Invocation' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ToolCallResultMessage? Result { get; init; }
#else
        public global::RetellAI.ToolCallResultMessage? Result { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Result))]
#endif
        public bool IsResult => Result != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ToolCallResultMessage? value)
        {
            value = Result;
            return IsResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.ToolCallResultMessage PickResult() => IsResult
            ? Result!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Result' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.NodeTransitionMessage? NodeTransition { get; init; }
#else
        public global::RetellAI.NodeTransitionMessage? NodeTransition { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeTransition))]
#endif
        public bool IsNodeTransition => NodeTransition != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickNodeTransition(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.NodeTransitionMessage? value)
        {
            value = NodeTransition;
            return IsNodeTransition;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.NodeTransitionMessage PickNodeTransition() => IsNodeTransition
            ? NodeTransition!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NodeTransition' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.StateTransitionMessage? StateTransition { get; init; }
#else
        public global::RetellAI.StateTransitionMessage? StateTransition { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StateTransition))]
#endif
        public bool IsStateTransition => StateTransition != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStateTransition(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.StateTransitionMessage? value)
        {
            value = StateTransition;
            return IsStateTransition;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.StateTransitionMessage PickStateTransition() => IsStateTransition
            ? StateTransition!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StateTransition' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.InjectedMessage? Injected { get; init; }
#else
        public global::RetellAI.InjectedMessage? Injected { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Injected))]
#endif
        public bool IsInjected => Injected != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInjected(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.InjectedMessage? value)
        {
            value = Injected;
            return IsInjected;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.InjectedMessage PickInjected() => IsInjected
            ? Injected!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Injected' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.SmsMessage? Sms { get; init; }
#else
        public global::RetellAI.SmsMessage? Sms { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sms))]
#endif
        public bool IsSms => Sms != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSms(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.SmsMessage? value)
        {
            value = Sms;
            return IsSms;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.SmsMessage PickSms() => IsSms
            ? Sms!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sms' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageOrToolCall(global::RetellAI.Message value) => new MessageOrToolCall((global::RetellAI.Message?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.Message?(MessageOrToolCall @this) => @this.Message;

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(global::RetellAI.Message? value)
        {
            Message = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessageOrToolCall FromMessage(global::RetellAI.Message? value) => new MessageOrToolCall(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageOrToolCall(global::RetellAI.ToolCallInvocationMessage value) => new MessageOrToolCall((global::RetellAI.ToolCallInvocationMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ToolCallInvocationMessage?(MessageOrToolCall @this) => @this.Invocation;

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(global::RetellAI.ToolCallInvocationMessage? value)
        {
            Invocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessageOrToolCall FromInvocation(global::RetellAI.ToolCallInvocationMessage? value) => new MessageOrToolCall(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageOrToolCall(global::RetellAI.ToolCallResultMessage value) => new MessageOrToolCall((global::RetellAI.ToolCallResultMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ToolCallResultMessage?(MessageOrToolCall @this) => @this.Result;

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(global::RetellAI.ToolCallResultMessage? value)
        {
            Result = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessageOrToolCall FromResult(global::RetellAI.ToolCallResultMessage? value) => new MessageOrToolCall(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageOrToolCall(global::RetellAI.NodeTransitionMessage value) => new MessageOrToolCall((global::RetellAI.NodeTransitionMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.NodeTransitionMessage?(MessageOrToolCall @this) => @this.NodeTransition;

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(global::RetellAI.NodeTransitionMessage? value)
        {
            NodeTransition = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessageOrToolCall FromNodeTransition(global::RetellAI.NodeTransitionMessage? value) => new MessageOrToolCall(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageOrToolCall(global::RetellAI.StateTransitionMessage value) => new MessageOrToolCall((global::RetellAI.StateTransitionMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.StateTransitionMessage?(MessageOrToolCall @this) => @this.StateTransition;

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(global::RetellAI.StateTransitionMessage? value)
        {
            StateTransition = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessageOrToolCall FromStateTransition(global::RetellAI.StateTransitionMessage? value) => new MessageOrToolCall(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageOrToolCall(global::RetellAI.InjectedMessage value) => new MessageOrToolCall((global::RetellAI.InjectedMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.InjectedMessage?(MessageOrToolCall @this) => @this.Injected;

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(global::RetellAI.InjectedMessage? value)
        {
            Injected = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessageOrToolCall FromInjected(global::RetellAI.InjectedMessage? value) => new MessageOrToolCall(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageOrToolCall(global::RetellAI.SmsMessage value) => new MessageOrToolCall((global::RetellAI.SmsMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.SmsMessage?(MessageOrToolCall @this) => @this.Sms;

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(global::RetellAI.SmsMessage? value)
        {
            Sms = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessageOrToolCall FromSms(global::RetellAI.SmsMessage? value) => new MessageOrToolCall(value);

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(
            global::RetellAI.Message? message,
            global::RetellAI.ToolCallInvocationMessage? invocation,
            global::RetellAI.ToolCallResultMessage? result,
            global::RetellAI.NodeTransitionMessage? nodeTransition,
            global::RetellAI.StateTransitionMessage? stateTransition,
            global::RetellAI.InjectedMessage? injected,
            global::RetellAI.SmsMessage? sms
            )
        {
            Message = message;
            Invocation = invocation;
            Result = result;
            NodeTransition = nodeTransition;
            StateTransition = stateTransition;
            Injected = injected;
            Sms = sms;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Sms as object ??
            Injected as object ??
            StateTransition as object ??
            NodeTransition as object ??
            Result as object ??
            Invocation as object ??
            Message as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Message?.ToString() ??
            Invocation?.ToString() ??
            Result?.ToString() ??
            NodeTransition?.ToString() ??
            StateTransition?.ToString() ??
            Injected?.ToString() ??
            Sms?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessage && !IsInvocation && !IsResult && !IsNodeTransition && !IsStateTransition && !IsInjected && !IsSms || !IsMessage && IsInvocation && !IsResult && !IsNodeTransition && !IsStateTransition && !IsInjected && !IsSms || !IsMessage && !IsInvocation && IsResult && !IsNodeTransition && !IsStateTransition && !IsInjected && !IsSms || !IsMessage && !IsInvocation && !IsResult && IsNodeTransition && !IsStateTransition && !IsInjected && !IsSms || !IsMessage && !IsInvocation && !IsResult && !IsNodeTransition && IsStateTransition && !IsInjected && !IsSms || !IsMessage && !IsInvocation && !IsResult && !IsNodeTransition && !IsStateTransition && IsInjected && !IsSms || !IsMessage && !IsInvocation && !IsResult && !IsNodeTransition && !IsStateTransition && !IsInjected && IsSms;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.Message?, TResult>? message = null,
            global::System.Func<global::RetellAI.ToolCallInvocationMessage?, TResult>? invocation = null,
            global::System.Func<global::RetellAI.ToolCallResultMessage?, TResult>? result = null,
            global::System.Func<global::RetellAI.NodeTransitionMessage?, TResult>? nodeTransition = null,
            global::System.Func<global::RetellAI.StateTransitionMessage?, TResult>? stateTransition = null,
            global::System.Func<global::RetellAI.InjectedMessage?, TResult>? injected = null,
            global::System.Func<global::RetellAI.SmsMessage?, TResult>? sms = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage && message != null)
            {
                return message(Message!);
            }
            else if (IsInvocation && invocation != null)
            {
                return invocation(Invocation!);
            }
            else if (IsResult && result != null)
            {
                return result(Result!);
            }
            else if (IsNodeTransition && nodeTransition != null)
            {
                return nodeTransition(NodeTransition!);
            }
            else if (IsStateTransition && stateTransition != null)
            {
                return stateTransition(StateTransition!);
            }
            else if (IsInjected && injected != null)
            {
                return injected(Injected!);
            }
            else if (IsSms && sms != null)
            {
                return sms(Sms!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.Message?>? message = null,

            global::System.Action<global::RetellAI.ToolCallInvocationMessage?>? invocation = null,

            global::System.Action<global::RetellAI.ToolCallResultMessage?>? result = null,

            global::System.Action<global::RetellAI.NodeTransitionMessage?>? nodeTransition = null,

            global::System.Action<global::RetellAI.StateTransitionMessage?>? stateTransition = null,

            global::System.Action<global::RetellAI.InjectedMessage?>? injected = null,

            global::System.Action<global::RetellAI.SmsMessage?>? sms = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsInvocation)
            {
                invocation?.Invoke(Invocation!);
            }
            else if (IsResult)
            {
                result?.Invoke(Result!);
            }
            else if (IsNodeTransition)
            {
                nodeTransition?.Invoke(NodeTransition!);
            }
            else if (IsStateTransition)
            {
                stateTransition?.Invoke(StateTransition!);
            }
            else if (IsInjected)
            {
                injected?.Invoke(Injected!);
            }
            else if (IsSms)
            {
                sms?.Invoke(Sms!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.Message?>? message = null,
            global::System.Action<global::RetellAI.ToolCallInvocationMessage?>? invocation = null,
            global::System.Action<global::RetellAI.ToolCallResultMessage?>? result = null,
            global::System.Action<global::RetellAI.NodeTransitionMessage?>? nodeTransition = null,
            global::System.Action<global::RetellAI.StateTransitionMessage?>? stateTransition = null,
            global::System.Action<global::RetellAI.InjectedMessage?>? injected = null,
            global::System.Action<global::RetellAI.SmsMessage?>? sms = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsInvocation)
            {
                invocation?.Invoke(Invocation!);
            }
            else if (IsResult)
            {
                result?.Invoke(Result!);
            }
            else if (IsNodeTransition)
            {
                nodeTransition?.Invoke(NodeTransition!);
            }
            else if (IsStateTransition)
            {
                stateTransition?.Invoke(StateTransition!);
            }
            else if (IsInjected)
            {
                injected?.Invoke(Injected!);
            }
            else if (IsSms)
            {
                sms?.Invoke(Sms!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Message,
                typeof(global::RetellAI.Message),
                Invocation,
                typeof(global::RetellAI.ToolCallInvocationMessage),
                Result,
                typeof(global::RetellAI.ToolCallResultMessage),
                NodeTransition,
                typeof(global::RetellAI.NodeTransitionMessage),
                StateTransition,
                typeof(global::RetellAI.StateTransitionMessage),
                Injected,
                typeof(global::RetellAI.InjectedMessage),
                Sms,
                typeof(global::RetellAI.SmsMessage),
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
        public bool Equals(MessageOrToolCall other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.Message?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ToolCallInvocationMessage?>.Default.Equals(Invocation, other.Invocation) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ToolCallResultMessage?>.Default.Equals(Result, other.Result) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.NodeTransitionMessage?>.Default.Equals(NodeTransition, other.NodeTransition) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.StateTransitionMessage?>.Default.Equals(StateTransition, other.StateTransition) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.InjectedMessage?>.Default.Equals(Injected, other.Injected) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.SmsMessage?>.Default.Equals(Sms, other.Sms) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessageOrToolCall obj1, MessageOrToolCall obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessageOrToolCall>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessageOrToolCall obj1, MessageOrToolCall obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessageOrToolCall o && Equals(o);
        }
    }
}
