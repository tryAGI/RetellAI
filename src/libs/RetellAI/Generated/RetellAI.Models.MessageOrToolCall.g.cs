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
        public MessageOrToolCall(
            global::RetellAI.Message? message,
            global::RetellAI.ToolCallInvocationMessage? invocation,
            global::RetellAI.ToolCallResultMessage? result,
            global::RetellAI.NodeTransitionMessage? nodeTransition,
            global::RetellAI.StateTransitionMessage? stateTransition
            )
        {
            Message = message;
            Invocation = invocation;
            Result = result;
            NodeTransition = nodeTransition;
            StateTransition = stateTransition;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            StateTransition?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessage && !IsInvocation && !IsResult && !IsNodeTransition && !IsStateTransition || !IsMessage && IsInvocation && !IsResult && !IsNodeTransition && !IsStateTransition || !IsMessage && !IsInvocation && IsResult && !IsNodeTransition && !IsStateTransition || !IsMessage && !IsInvocation && !IsResult && IsNodeTransition && !IsStateTransition || !IsMessage && !IsInvocation && !IsResult && !IsNodeTransition && IsStateTransition;
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
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.StateTransitionMessage?>.Default.Equals(StateTransition, other.StateTransition) 
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
