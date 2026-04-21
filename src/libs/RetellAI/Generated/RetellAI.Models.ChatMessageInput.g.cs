#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Same shape as chat completion messages. message_id and created_timestamp are optional — server generates them if omitted.
    /// </summary>
    public readonly partial struct ChatMessageInput : global::System.IEquatable<ChatMessageInput>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.MessageBase? Base { get; init; }
#else
        public global::RetellAI.MessageBase? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ToolCallInvocationMessageBase? ToolCallInvocationBase { get; init; }
#else
        public global::RetellAI.ToolCallInvocationMessageBase? ToolCallInvocationBase { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallInvocationBase))]
#endif
        public bool IsToolCallInvocationBase => ToolCallInvocationBase != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ToolCallResultMessageBase? ToolCallResultBase { get; init; }
#else
        public global::RetellAI.ToolCallResultMessageBase? ToolCallResultBase { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallResultBase))]
#endif
        public bool IsToolCallResultBase => ToolCallResultBase != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.NodeTransitionMessageBase? NodeTransitionBase { get; init; }
#else
        public global::RetellAI.NodeTransitionMessageBase? NodeTransitionBase { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeTransitionBase))]
#endif
        public bool IsNodeTransitionBase => NodeTransitionBase != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.StateTransitionMessageBase? StateTransitionBase { get; init; }
#else
        public global::RetellAI.StateTransitionMessageBase? StateTransitionBase { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StateTransitionBase))]
#endif
        public bool IsStateTransitionBase => StateTransitionBase != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageInput(global::RetellAI.MessageBase value) => new ChatMessageInput((global::RetellAI.MessageBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.MessageBase?(ChatMessageInput @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageInput(global::RetellAI.MessageBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageInput(global::RetellAI.ToolCallInvocationMessageBase value) => new ChatMessageInput((global::RetellAI.ToolCallInvocationMessageBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ToolCallInvocationMessageBase?(ChatMessageInput @this) => @this.ToolCallInvocationBase;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageInput(global::RetellAI.ToolCallInvocationMessageBase? value)
        {
            ToolCallInvocationBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageInput(global::RetellAI.ToolCallResultMessageBase value) => new ChatMessageInput((global::RetellAI.ToolCallResultMessageBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ToolCallResultMessageBase?(ChatMessageInput @this) => @this.ToolCallResultBase;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageInput(global::RetellAI.ToolCallResultMessageBase? value)
        {
            ToolCallResultBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageInput(global::RetellAI.NodeTransitionMessageBase value) => new ChatMessageInput((global::RetellAI.NodeTransitionMessageBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.NodeTransitionMessageBase?(ChatMessageInput @this) => @this.NodeTransitionBase;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageInput(global::RetellAI.NodeTransitionMessageBase? value)
        {
            NodeTransitionBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageInput(global::RetellAI.StateTransitionMessageBase value) => new ChatMessageInput((global::RetellAI.StateTransitionMessageBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.StateTransitionMessageBase?(ChatMessageInput @this) => @this.StateTransitionBase;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageInput(global::RetellAI.StateTransitionMessageBase? value)
        {
            StateTransitionBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageInput(
            global::RetellAI.MessageBase? @base,
            global::RetellAI.ToolCallInvocationMessageBase? toolCallInvocationBase,
            global::RetellAI.ToolCallResultMessageBase? toolCallResultBase,
            global::RetellAI.NodeTransitionMessageBase? nodeTransitionBase,
            global::RetellAI.StateTransitionMessageBase? stateTransitionBase
            )
        {
            Base = @base;
            ToolCallInvocationBase = toolCallInvocationBase;
            ToolCallResultBase = toolCallResultBase;
            NodeTransitionBase = nodeTransitionBase;
            StateTransitionBase = stateTransitionBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StateTransitionBase as object ??
            NodeTransitionBase as object ??
            ToolCallResultBase as object ??
            ToolCallInvocationBase as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ToolCallInvocationBase?.ToString() ??
            ToolCallResultBase?.ToString() ??
            NodeTransitionBase?.ToString() ??
            StateTransitionBase?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && !IsToolCallInvocationBase && !IsToolCallResultBase && !IsNodeTransitionBase && !IsStateTransitionBase || !IsBase && IsToolCallInvocationBase && !IsToolCallResultBase && !IsNodeTransitionBase && !IsStateTransitionBase || !IsBase && !IsToolCallInvocationBase && IsToolCallResultBase && !IsNodeTransitionBase && !IsStateTransitionBase || !IsBase && !IsToolCallInvocationBase && !IsToolCallResultBase && IsNodeTransitionBase && !IsStateTransitionBase || !IsBase && !IsToolCallInvocationBase && !IsToolCallResultBase && !IsNodeTransitionBase && IsStateTransitionBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.MessageBase?, TResult>? @base = null,
            global::System.Func<global::RetellAI.ToolCallInvocationMessageBase?, TResult>? toolCallInvocationBase = null,
            global::System.Func<global::RetellAI.ToolCallResultMessageBase?, TResult>? toolCallResultBase = null,
            global::System.Func<global::RetellAI.NodeTransitionMessageBase?, TResult>? nodeTransitionBase = null,
            global::System.Func<global::RetellAI.StateTransitionMessageBase?, TResult>? stateTransitionBase = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsToolCallInvocationBase && toolCallInvocationBase != null)
            {
                return toolCallInvocationBase(ToolCallInvocationBase!);
            }
            else if (IsToolCallResultBase && toolCallResultBase != null)
            {
                return toolCallResultBase(ToolCallResultBase!);
            }
            else if (IsNodeTransitionBase && nodeTransitionBase != null)
            {
                return nodeTransitionBase(NodeTransitionBase!);
            }
            else if (IsStateTransitionBase && stateTransitionBase != null)
            {
                return stateTransitionBase(StateTransitionBase!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.MessageBase?>? @base = null,
            global::System.Action<global::RetellAI.ToolCallInvocationMessageBase?>? toolCallInvocationBase = null,
            global::System.Action<global::RetellAI.ToolCallResultMessageBase?>? toolCallResultBase = null,
            global::System.Action<global::RetellAI.NodeTransitionMessageBase?>? nodeTransitionBase = null,
            global::System.Action<global::RetellAI.StateTransitionMessageBase?>? stateTransitionBase = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsToolCallInvocationBase)
            {
                toolCallInvocationBase?.Invoke(ToolCallInvocationBase!);
            }
            else if (IsToolCallResultBase)
            {
                toolCallResultBase?.Invoke(ToolCallResultBase!);
            }
            else if (IsNodeTransitionBase)
            {
                nodeTransitionBase?.Invoke(NodeTransitionBase!);
            }
            else if (IsStateTransitionBase)
            {
                stateTransitionBase?.Invoke(StateTransitionBase!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::RetellAI.MessageBase),
                ToolCallInvocationBase,
                typeof(global::RetellAI.ToolCallInvocationMessageBase),
                ToolCallResultBase,
                typeof(global::RetellAI.ToolCallResultMessageBase),
                NodeTransitionBase,
                typeof(global::RetellAI.NodeTransitionMessageBase),
                StateTransitionBase,
                typeof(global::RetellAI.StateTransitionMessageBase),
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
        public bool Equals(ChatMessageInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.MessageBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ToolCallInvocationMessageBase?>.Default.Equals(ToolCallInvocationBase, other.ToolCallInvocationBase) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ToolCallResultMessageBase?>.Default.Equals(ToolCallResultBase, other.ToolCallResultBase) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.NodeTransitionMessageBase?>.Default.Equals(NodeTransitionBase, other.NodeTransitionBase) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.StateTransitionMessageBase?>.Default.Equals(StateTransitionBase, other.StateTransitionBase) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatMessageInput obj1, ChatMessageInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatMessageInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatMessageInput obj1, ChatMessageInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatMessageInput o && Equals(o);
        }
    }
}
