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
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.MessageBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MessageBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

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
        public bool TryPickToolCallInvocationBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ToolCallInvocationMessageBase? value)
        {
            value = ToolCallInvocationBase;
            return IsToolCallInvocationBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallInvocationMessageBase PickToolCallInvocationBase() => IsToolCallInvocationBase
            ? ToolCallInvocationBase!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolCallInvocationBase' but the value was {ToString()}.");

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
        public bool TryPickToolCallResultBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ToolCallResultMessageBase? value)
        {
            value = ToolCallResultBase;
            return IsToolCallResultBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallResultMessageBase PickToolCallResultBase() => IsToolCallResultBase
            ? ToolCallResultBase!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolCallResultBase' but the value was {ToString()}.");

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
        public bool TryPickNodeTransitionBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.NodeTransitionMessageBase? value)
        {
            value = NodeTransitionBase;
            return IsNodeTransitionBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionMessageBase PickNodeTransitionBase() => IsNodeTransitionBase
            ? NodeTransitionBase!
            : throw new global::System.InvalidOperationException($"Expected union variant 'NodeTransitionBase' but the value was {ToString()}.");

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
        public bool TryPickStateTransitionBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.StateTransitionMessageBase? value)
        {
            value = StateTransitionBase;
            return IsStateTransitionBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StateTransitionMessageBase PickStateTransitionBase() => IsStateTransitionBase
            ? StateTransitionBase!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StateTransitionBase' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.InjectedMessageBase? InjectedBase { get; init; }
#else
        public global::RetellAI.InjectedMessageBase? InjectedBase { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InjectedBase))]
#endif
        public bool IsInjectedBase => InjectedBase != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInjectedBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.InjectedMessageBase? value)
        {
            value = InjectedBase;
            return IsInjectedBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.InjectedMessageBase PickInjectedBase() => IsInjectedBase
            ? InjectedBase!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InjectedBase' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.SmsMessageBase? SmsBase { get; init; }
#else
        public global::RetellAI.SmsMessageBase? SmsBase { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SmsBase))]
#endif
        public bool IsSmsBase => SmsBase != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSmsBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.SmsMessageBase? value)
        {
            value = SmsBase;
            return IsSmsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsMessageBase PickSmsBase() => IsSmsBase
            ? SmsBase!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SmsBase' but the value was {ToString()}.");
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
        public static ChatMessageInput FromBase(global::RetellAI.MessageBase? value) => new ChatMessageInput(value);

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
        public static ChatMessageInput FromToolCallInvocationBase(global::RetellAI.ToolCallInvocationMessageBase? value) => new ChatMessageInput(value);

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
        public static ChatMessageInput FromToolCallResultBase(global::RetellAI.ToolCallResultMessageBase? value) => new ChatMessageInput(value);

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
        public static ChatMessageInput FromNodeTransitionBase(global::RetellAI.NodeTransitionMessageBase? value) => new ChatMessageInput(value);

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
        public static ChatMessageInput FromStateTransitionBase(global::RetellAI.StateTransitionMessageBase? value) => new ChatMessageInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatMessageInput(global::RetellAI.InjectedMessageBase value) => new ChatMessageInput((global::RetellAI.InjectedMessageBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.InjectedMessageBase?(ChatMessageInput @this) => @this.InjectedBase;

        /// <summary>
        ///
        /// </summary>
        public ChatMessageInput(global::RetellAI.InjectedMessageBase? value)
        {
            InjectedBase = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatMessageInput FromInjectedBase(global::RetellAI.InjectedMessageBase? value) => new ChatMessageInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatMessageInput(global::RetellAI.SmsMessageBase value) => new ChatMessageInput((global::RetellAI.SmsMessageBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.SmsMessageBase?(ChatMessageInput @this) => @this.SmsBase;

        /// <summary>
        ///
        /// </summary>
        public ChatMessageInput(global::RetellAI.SmsMessageBase? value)
        {
            SmsBase = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatMessageInput FromSmsBase(global::RetellAI.SmsMessageBase? value) => new ChatMessageInput(value);

        /// <summary>
        ///
        /// </summary>
        public ChatMessageInput(
            global::RetellAI.MessageBase? @base,
            global::RetellAI.ToolCallInvocationMessageBase? toolCallInvocationBase,
            global::RetellAI.ToolCallResultMessageBase? toolCallResultBase,
            global::RetellAI.NodeTransitionMessageBase? nodeTransitionBase,
            global::RetellAI.StateTransitionMessageBase? stateTransitionBase,
            global::RetellAI.InjectedMessageBase? injectedBase,
            global::RetellAI.SmsMessageBase? smsBase
            )
        {
            Base = @base;
            ToolCallInvocationBase = toolCallInvocationBase;
            ToolCallResultBase = toolCallResultBase;
            NodeTransitionBase = nodeTransitionBase;
            StateTransitionBase = stateTransitionBase;
            InjectedBase = injectedBase;
            SmsBase = smsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SmsBase as object ??
            InjectedBase as object ??
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
            StateTransitionBase?.ToString() ??
            InjectedBase?.ToString() ??
            SmsBase?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && !IsToolCallInvocationBase && !IsToolCallResultBase && !IsNodeTransitionBase && !IsStateTransitionBase && !IsInjectedBase && !IsSmsBase || !IsBase && IsToolCallInvocationBase && !IsToolCallResultBase && !IsNodeTransitionBase && !IsStateTransitionBase && !IsInjectedBase && !IsSmsBase || !IsBase && !IsToolCallInvocationBase && IsToolCallResultBase && !IsNodeTransitionBase && !IsStateTransitionBase && !IsInjectedBase && !IsSmsBase || !IsBase && !IsToolCallInvocationBase && !IsToolCallResultBase && IsNodeTransitionBase && !IsStateTransitionBase && !IsInjectedBase && !IsSmsBase || !IsBase && !IsToolCallInvocationBase && !IsToolCallResultBase && !IsNodeTransitionBase && IsStateTransitionBase && !IsInjectedBase && !IsSmsBase || !IsBase && !IsToolCallInvocationBase && !IsToolCallResultBase && !IsNodeTransitionBase && !IsStateTransitionBase && IsInjectedBase && !IsSmsBase || !IsBase && !IsToolCallInvocationBase && !IsToolCallResultBase && !IsNodeTransitionBase && !IsStateTransitionBase && !IsInjectedBase && IsSmsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.MessageBase, TResult>? @base = null,
            global::System.Func<global::RetellAI.ToolCallInvocationMessageBase, TResult>? toolCallInvocationBase = null,
            global::System.Func<global::RetellAI.ToolCallResultMessageBase, TResult>? toolCallResultBase = null,
            global::System.Func<global::RetellAI.NodeTransitionMessageBase, TResult>? nodeTransitionBase = null,
            global::System.Func<global::RetellAI.StateTransitionMessageBase, TResult>? stateTransitionBase = null,
            global::System.Func<global::RetellAI.InjectedMessageBase, TResult>? injectedBase = null,
            global::System.Func<global::RetellAI.SmsMessageBase, TResult>? smsBase = null,
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
            else if (IsInjectedBase && injectedBase != null)
            {
                return injectedBase(InjectedBase!);
            }
            else if (IsSmsBase && smsBase != null)
            {
                return smsBase(SmsBase!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.MessageBase>? @base = null,

            global::System.Action<global::RetellAI.ToolCallInvocationMessageBase>? toolCallInvocationBase = null,

            global::System.Action<global::RetellAI.ToolCallResultMessageBase>? toolCallResultBase = null,

            global::System.Action<global::RetellAI.NodeTransitionMessageBase>? nodeTransitionBase = null,

            global::System.Action<global::RetellAI.StateTransitionMessageBase>? stateTransitionBase = null,

            global::System.Action<global::RetellAI.InjectedMessageBase>? injectedBase = null,

            global::System.Action<global::RetellAI.SmsMessageBase>? smsBase = null,
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
            else if (IsInjectedBase)
            {
                injectedBase?.Invoke(InjectedBase!);
            }
            else if (IsSmsBase)
            {
                smsBase?.Invoke(SmsBase!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.MessageBase>? @base = null,
            global::System.Action<global::RetellAI.ToolCallInvocationMessageBase>? toolCallInvocationBase = null,
            global::System.Action<global::RetellAI.ToolCallResultMessageBase>? toolCallResultBase = null,
            global::System.Action<global::RetellAI.NodeTransitionMessageBase>? nodeTransitionBase = null,
            global::System.Action<global::RetellAI.StateTransitionMessageBase>? stateTransitionBase = null,
            global::System.Action<global::RetellAI.InjectedMessageBase>? injectedBase = null,
            global::System.Action<global::RetellAI.SmsMessageBase>? smsBase = null,
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
            else if (IsInjectedBase)
            {
                injectedBase?.Invoke(InjectedBase!);
            }
            else if (IsSmsBase)
            {
                smsBase?.Invoke(SmsBase!);
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
                InjectedBase,
                typeof(global::RetellAI.InjectedMessageBase),
                SmsBase,
                typeof(global::RetellAI.SmsMessageBase),
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
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.StateTransitionMessageBase?>.Default.Equals(StateTransitionBase, other.StateTransitionBase) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.InjectedMessageBase?>.Default.Equals(InjectedBase, other.InjectedBase) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.SmsMessageBase?>.Default.Equals(SmsBase, other.SmsBase)
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
