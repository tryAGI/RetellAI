#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ConversationFlowNode : global::System.IEquatable<ConversationFlowNode>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConversationNode? ConversationNode { get; init; }
#else
        public global::RetellAI.ConversationNode? ConversationNode { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationNode))]
#endif
        public bool IsConversationNode => ConversationNode != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConversationNode(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConversationNode? value)
        {
            value = ConversationNode;
            return IsConversationNode;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationNode PickConversationNode() => ConversationNode is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationNode' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.SubagentNode? Subagent { get; init; }
#else
        public global::RetellAI.SubagentNode? Subagent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Subagent))]
#endif
        public bool IsSubagent => Subagent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubagent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.SubagentNode? value)
        {
            value = Subagent;
            return IsSubagent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SubagentNode PickSubagent() => Subagent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Subagent' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.EndNode? End { get; init; }
#else
        public global::RetellAI.EndNode? End { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(End))]
#endif
        public bool IsEnd => End != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEnd(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.EndNode? value)
        {
            value = End;
            return IsEnd;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndNode PickEnd() => End is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'End' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.FunctionNode? Function { get; init; }
#else
        public global::RetellAI.FunctionNode? Function { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.FunctionNode? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FunctionNode PickFunction() => Function is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.CodeNode? Code { get; init; }
#else
        public global::RetellAI.CodeNode? Code { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Code))]
#endif
        public bool IsCode => Code != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCode(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.CodeNode? value)
        {
            value = Code;
            return IsCode;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CodeNode PickCode() => Code is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Code' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TransferCallNode? TransferCall { get; init; }
#else
        public global::RetellAI.TransferCallNode? TransferCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransferCall))]
#endif
        public bool IsTransferCall => TransferCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTransferCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.TransferCallNode? value)
        {
            value = TransferCall;
            return IsTransferCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferCallNode PickTransferCall() => TransferCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TransferCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.PressDigitNode? PressDigit { get; init; }
#else
        public global::RetellAI.PressDigitNode? PressDigit { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PressDigit))]
#endif
        public bool IsPressDigit => PressDigit != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPressDigit(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.PressDigitNode? value)
        {
            value = PressDigit;
            return IsPressDigit;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PressDigitNode PickPressDigit() => PressDigit is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PressDigit' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.BranchNode? Branch { get; init; }
#else
        public global::RetellAI.BranchNode? Branch { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Branch))]
#endif
        public bool IsBranch => Branch != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBranch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.BranchNode? value)
        {
            value = Branch;
            return IsBranch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BranchNode PickBranch() => Branch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Branch' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.SmsNode? Sms { get; init; }
#else
        public global::RetellAI.SmsNode? Sms { get; }
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
            out global::RetellAI.SmsNode? value)
        {
            value = Sms;
            return IsSms;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsNode PickSms() => Sms is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sms' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ExtractDynamicVariablesNode? ExtractDynamicVariables { get; init; }
#else
        public global::RetellAI.ExtractDynamicVariablesNode? ExtractDynamicVariables { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExtractDynamicVariables))]
#endif
        public bool IsExtractDynamicVariables => ExtractDynamicVariables != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickExtractDynamicVariables(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ExtractDynamicVariablesNode? value)
        {
            value = ExtractDynamicVariables;
            return IsExtractDynamicVariables;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ExtractDynamicVariablesNode PickExtractDynamicVariables() => ExtractDynamicVariables is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ExtractDynamicVariables' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.AgentSwapNode? AgentSwap { get; init; }
#else
        public global::RetellAI.AgentSwapNode? AgentSwap { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSwap))]
#endif
        public bool IsAgentSwap => AgentSwap != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSwap(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.AgentSwapNode? value)
        {
            value = AgentSwap;
            return IsAgentSwap;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentSwapNode PickAgentSwap() => AgentSwap is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSwap' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.MCPNode? Mcp { get; init; }
#else
        public global::RetellAI.MCPNode? Mcp { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mcp))]
#endif
        public bool IsMcp => Mcp != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMcp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.MCPNode? value)
        {
            value = Mcp;
            return IsMcp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MCPNode PickMcp() => Mcp is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Mcp' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ComponentNode? Component { get; init; }
#else
        public global::RetellAI.ComponentNode? Component { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Component))]
#endif
        public bool IsComponent => Component != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComponent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ComponentNode? value)
        {
            value = Component;
            return IsComponent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ComponentNode PickComponent() => Component is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Component' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.BridgeTransferNode? BridgeTransfer { get; init; }
#else
        public global::RetellAI.BridgeTransferNode? BridgeTransfer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BridgeTransfer))]
#endif
        public bool IsBridgeTransfer => BridgeTransfer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBridgeTransfer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.BridgeTransferNode? value)
        {
            value = BridgeTransfer;
            return IsBridgeTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BridgeTransferNode PickBridgeTransfer() => BridgeTransfer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BridgeTransfer' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.CancelTransferNode? CancelTransfer { get; init; }
#else
        public global::RetellAI.CancelTransferNode? CancelTransfer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CancelTransfer))]
#endif
        public bool IsCancelTransfer => CancelTransfer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCancelTransfer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.CancelTransferNode? value)
        {
            value = CancelTransfer;
            return IsCancelTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CancelTransferNode PickCancelTransfer() => CancelTransfer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CancelTransfer' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConversationFlowNode(global::RetellAI.ConversationNode value) => new ConversationFlowNode((global::RetellAI.ConversationNode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConversationNode?(ConversationFlowNode @this) => @this.ConversationNode;

        /// <summary>
        ///
        /// </summary>
        public ConversationFlowNode(global::RetellAI.ConversationNode? value)
        {
            ConversationNode = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConversationFlowNode FromConversationNode(global::RetellAI.ConversationNode? value) => new ConversationFlowNode(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConversationFlowNode(global::RetellAI.SubagentNode value) => new ConversationFlowNode((global::RetellAI.SubagentNode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.SubagentNode?(ConversationFlowNode @this) => @this.Subagent;

        /// <summary>
        ///
        /// </summary>
        public ConversationFlowNode(global::RetellAI.SubagentNode? value)
        {
            Subagent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConversationFlowNode FromSubagent(global::RetellAI.SubagentNode? value) => new ConversationFlowNode(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConversationFlowNode(global::RetellAI.EndNode value) => new ConversationFlowNode((global::RetellAI.EndNode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.EndNode?(ConversationFlowNode @this) => @this.End;

        /// <summary>
        ///
        /// </summary>
        public ConversationFlowNode(global::RetellAI.EndNode? value)
        {
            End = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConversationFlowNode FromEnd(global::RetellAI.EndNode? value) => new ConversationFlowNode(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConversationFlowNode(global::RetellAI.FunctionNode value) => new ConversationFlowNode((global::RetellAI.FunctionNode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.FunctionNode?(ConversationFlowNode @this) => @this.Function;

        /// <summary>
        ///
        /// </summary>
        public ConversationFlowNode(global::RetellAI.FunctionNode? value)
        {
            Function = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConversationFlowNode FromFunction(global::RetellAI.FunctionNode? value) => new ConversationFlowNode(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConversationFlowNode(global::RetellAI.CodeNode value) => new ConversationFlowNode((global::RetellAI.CodeNode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.CodeNode?(ConversationFlowNode @this) => @this.Code;

        /// <summary>
        ///
        /// </summary>
        public ConversationFlowNode(global::RetellAI.CodeNode? value)
        {
            Code = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConversationFlowNode FromCode(global::RetellAI.CodeNode? value) => new ConversationFlowNode(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConversationFlowNode(global::RetellAI.TransferCallNode value) => new ConversationFlowNode((global::RetellAI.TransferCallNode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.TransferCallNode?(ConversationFlowNode @this) => @this.TransferCall;

        /// <summary>
        ///
        /// </summary>
        public ConversationFlowNode(global::RetellAI.TransferCallNode? value)
        {
            TransferCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConversationFlowNode FromTransferCall(global::RetellAI.TransferCallNode? value) => new ConversationFlowNode(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConversationFlowNode(global::RetellAI.PressDigitNode value) => new ConversationFlowNode((global::RetellAI.PressDigitNode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.PressDigitNode?(ConversationFlowNode @this) => @this.PressDigit;

        /// <summary>
        ///
        /// </summary>
        public ConversationFlowNode(global::RetellAI.PressDigitNode? value)
        {
            PressDigit = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConversationFlowNode FromPressDigit(global::RetellAI.PressDigitNode? value) => new ConversationFlowNode(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConversationFlowNode(global::RetellAI.BranchNode value) => new ConversationFlowNode((global::RetellAI.BranchNode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.BranchNode?(ConversationFlowNode @this) => @this.Branch;

        /// <summary>
        ///
        /// </summary>
        public ConversationFlowNode(global::RetellAI.BranchNode? value)
        {
            Branch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConversationFlowNode FromBranch(global::RetellAI.BranchNode? value) => new ConversationFlowNode(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConversationFlowNode(global::RetellAI.SmsNode value) => new ConversationFlowNode((global::RetellAI.SmsNode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.SmsNode?(ConversationFlowNode @this) => @this.Sms;

        /// <summary>
        ///
        /// </summary>
        public ConversationFlowNode(global::RetellAI.SmsNode? value)
        {
            Sms = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConversationFlowNode FromSms(global::RetellAI.SmsNode? value) => new ConversationFlowNode(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConversationFlowNode(global::RetellAI.ExtractDynamicVariablesNode value) => new ConversationFlowNode((global::RetellAI.ExtractDynamicVariablesNode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ExtractDynamicVariablesNode?(ConversationFlowNode @this) => @this.ExtractDynamicVariables;

        /// <summary>
        ///
        /// </summary>
        public ConversationFlowNode(global::RetellAI.ExtractDynamicVariablesNode? value)
        {
            ExtractDynamicVariables = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConversationFlowNode FromExtractDynamicVariables(global::RetellAI.ExtractDynamicVariablesNode? value) => new ConversationFlowNode(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConversationFlowNode(global::RetellAI.AgentSwapNode value) => new ConversationFlowNode((global::RetellAI.AgentSwapNode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.AgentSwapNode?(ConversationFlowNode @this) => @this.AgentSwap;

        /// <summary>
        ///
        /// </summary>
        public ConversationFlowNode(global::RetellAI.AgentSwapNode? value)
        {
            AgentSwap = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConversationFlowNode FromAgentSwap(global::RetellAI.AgentSwapNode? value) => new ConversationFlowNode(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConversationFlowNode(global::RetellAI.MCPNode value) => new ConversationFlowNode((global::RetellAI.MCPNode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.MCPNode?(ConversationFlowNode @this) => @this.Mcp;

        /// <summary>
        ///
        /// </summary>
        public ConversationFlowNode(global::RetellAI.MCPNode? value)
        {
            Mcp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConversationFlowNode FromMcp(global::RetellAI.MCPNode? value) => new ConversationFlowNode(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConversationFlowNode(global::RetellAI.ComponentNode value) => new ConversationFlowNode((global::RetellAI.ComponentNode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ComponentNode?(ConversationFlowNode @this) => @this.Component;

        /// <summary>
        ///
        /// </summary>
        public ConversationFlowNode(global::RetellAI.ComponentNode? value)
        {
            Component = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConversationFlowNode FromComponent(global::RetellAI.ComponentNode? value) => new ConversationFlowNode(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConversationFlowNode(global::RetellAI.BridgeTransferNode value) => new ConversationFlowNode((global::RetellAI.BridgeTransferNode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.BridgeTransferNode?(ConversationFlowNode @this) => @this.BridgeTransfer;

        /// <summary>
        ///
        /// </summary>
        public ConversationFlowNode(global::RetellAI.BridgeTransferNode? value)
        {
            BridgeTransfer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConversationFlowNode FromBridgeTransfer(global::RetellAI.BridgeTransferNode? value) => new ConversationFlowNode(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConversationFlowNode(global::RetellAI.CancelTransferNode value) => new ConversationFlowNode((global::RetellAI.CancelTransferNode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.CancelTransferNode?(ConversationFlowNode @this) => @this.CancelTransfer;

        /// <summary>
        ///
        /// </summary>
        public ConversationFlowNode(global::RetellAI.CancelTransferNode? value)
        {
            CancelTransfer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConversationFlowNode FromCancelTransfer(global::RetellAI.CancelTransferNode? value) => new ConversationFlowNode(value);

        /// <summary>
        ///
        /// </summary>
        public ConversationFlowNode(
            global::RetellAI.ConversationNode? conversationNode,
            global::RetellAI.SubagentNode? subagent,
            global::RetellAI.EndNode? end,
            global::RetellAI.FunctionNode? function,
            global::RetellAI.CodeNode? code,
            global::RetellAI.TransferCallNode? transferCall,
            global::RetellAI.PressDigitNode? pressDigit,
            global::RetellAI.BranchNode? branch,
            global::RetellAI.SmsNode? sms,
            global::RetellAI.ExtractDynamicVariablesNode? extractDynamicVariables,
            global::RetellAI.AgentSwapNode? agentSwap,
            global::RetellAI.MCPNode? mcp,
            global::RetellAI.ComponentNode? component,
            global::RetellAI.BridgeTransferNode? bridgeTransfer,
            global::RetellAI.CancelTransferNode? cancelTransfer
            )
        {
            ConversationNode = conversationNode;
            Subagent = subagent;
            End = end;
            Function = function;
            Code = code;
            TransferCall = transferCall;
            PressDigit = pressDigit;
            Branch = branch;
            Sms = sms;
            ExtractDynamicVariables = extractDynamicVariables;
            AgentSwap = agentSwap;
            Mcp = mcp;
            Component = component;
            BridgeTransfer = bridgeTransfer;
            CancelTransfer = cancelTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CancelTransfer as object ??
            BridgeTransfer as object ??
            Component as object ??
            Mcp as object ??
            AgentSwap as object ??
            ExtractDynamicVariables as object ??
            Sms as object ??
            Branch as object ??
            PressDigit as object ??
            TransferCall as object ??
            Code as object ??
            Function as object ??
            End as object ??
            Subagent as object ??
            ConversationNode as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ConversationNode?.ToString() ??
            Subagent?.ToString() ??
            End?.ToString() ??
            Function?.ToString() ??
            Code?.ToString() ??
            TransferCall?.ToString() ??
            PressDigit?.ToString() ??
            Branch?.ToString() ??
            Sms?.ToString() ??
            ExtractDynamicVariables?.ToString() ??
            AgentSwap?.ToString() ??
            Mcp?.ToString() ??
            Component?.ToString() ??
            BridgeTransfer?.ToString() ??
            CancelTransfer?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsConversationNode && !IsSubagent && !IsEnd && !IsFunction && !IsCode && !IsTransferCall && !IsPressDigit && !IsBranch && !IsSms && !IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && !IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && IsSubagent && !IsEnd && !IsFunction && !IsCode && !IsTransferCall && !IsPressDigit && !IsBranch && !IsSms && !IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && !IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsSubagent && IsEnd && !IsFunction && !IsCode && !IsTransferCall && !IsPressDigit && !IsBranch && !IsSms && !IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && !IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsSubagent && !IsEnd && IsFunction && !IsCode && !IsTransferCall && !IsPressDigit && !IsBranch && !IsSms && !IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && !IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsSubagent && !IsEnd && !IsFunction && IsCode && !IsTransferCall && !IsPressDigit && !IsBranch && !IsSms && !IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && !IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsSubagent && !IsEnd && !IsFunction && !IsCode && IsTransferCall && !IsPressDigit && !IsBranch && !IsSms && !IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && !IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsSubagent && !IsEnd && !IsFunction && !IsCode && !IsTransferCall && IsPressDigit && !IsBranch && !IsSms && !IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && !IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsSubagent && !IsEnd && !IsFunction && !IsCode && !IsTransferCall && !IsPressDigit && IsBranch && !IsSms && !IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && !IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsSubagent && !IsEnd && !IsFunction && !IsCode && !IsTransferCall && !IsPressDigit && !IsBranch && IsSms && !IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && !IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsSubagent && !IsEnd && !IsFunction && !IsCode && !IsTransferCall && !IsPressDigit && !IsBranch && !IsSms && IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && !IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsSubagent && !IsEnd && !IsFunction && !IsCode && !IsTransferCall && !IsPressDigit && !IsBranch && !IsSms && !IsExtractDynamicVariables && IsAgentSwap && !IsMcp && !IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsSubagent && !IsEnd && !IsFunction && !IsCode && !IsTransferCall && !IsPressDigit && !IsBranch && !IsSms && !IsExtractDynamicVariables && !IsAgentSwap && IsMcp && !IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsSubagent && !IsEnd && !IsFunction && !IsCode && !IsTransferCall && !IsPressDigit && !IsBranch && !IsSms && !IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsSubagent && !IsEnd && !IsFunction && !IsCode && !IsTransferCall && !IsPressDigit && !IsBranch && !IsSms && !IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && !IsComponent && IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsSubagent && !IsEnd && !IsFunction && !IsCode && !IsTransferCall && !IsPressDigit && !IsBranch && !IsSms && !IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && !IsComponent && !IsBridgeTransfer && IsCancelTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ConversationNode?, TResult>? conversationNode = null,
            global::System.Func<global::RetellAI.SubagentNode?, TResult>? subagent = null,
            global::System.Func<global::RetellAI.EndNode?, TResult>? end = null,
            global::System.Func<global::RetellAI.FunctionNode?, TResult>? function = null,
            global::System.Func<global::RetellAI.CodeNode?, TResult>? code = null,
            global::System.Func<global::RetellAI.TransferCallNode?, TResult>? transferCall = null,
            global::System.Func<global::RetellAI.PressDigitNode?, TResult>? pressDigit = null,
            global::System.Func<global::RetellAI.BranchNode?, TResult>? branch = null,
            global::System.Func<global::RetellAI.SmsNode?, TResult>? sms = null,
            global::System.Func<global::RetellAI.ExtractDynamicVariablesNode?, TResult>? extractDynamicVariables = null,
            global::System.Func<global::RetellAI.AgentSwapNode?, TResult>? agentSwap = null,
            global::System.Func<global::RetellAI.MCPNode?, TResult>? mcp = null,
            global::System.Func<global::RetellAI.ComponentNode?, TResult>? component = null,
            global::System.Func<global::RetellAI.BridgeTransferNode?, TResult>? bridgeTransfer = null,
            global::System.Func<global::RetellAI.CancelTransferNode?, TResult>? cancelTransfer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ConversationNode is { } __value0 && conversationNode != null)
            {
                return conversationNode(__value0);
            }
            else if (Subagent is { } __value1 && subagent != null)
            {
                return subagent(__value1);
            }
            else if (End is { } __value2 && end != null)
            {
                return end(__value2);
            }
            else if (Function is { } __value3 && function != null)
            {
                return function(__value3);
            }
            else if (Code is { } __value4 && code != null)
            {
                return code(__value4);
            }
            else if (TransferCall is { } __value5 && transferCall != null)
            {
                return transferCall(__value5);
            }
            else if (PressDigit is { } __value6 && pressDigit != null)
            {
                return pressDigit(__value6);
            }
            else if (Branch is { } __value7 && branch != null)
            {
                return branch(__value7);
            }
            else if (Sms is { } __value8 && sms != null)
            {
                return sms(__value8);
            }
            else if (ExtractDynamicVariables is { } __value9 && extractDynamicVariables != null)
            {
                return extractDynamicVariables(__value9);
            }
            else if (AgentSwap is { } __value10 && agentSwap != null)
            {
                return agentSwap(__value10);
            }
            else if (Mcp is { } __value11 && mcp != null)
            {
                return mcp(__value11);
            }
            else if (Component is { } __value12 && component != null)
            {
                return component(__value12);
            }
            else if (BridgeTransfer is { } __value13 && bridgeTransfer != null)
            {
                return bridgeTransfer(__value13);
            }
            else if (CancelTransfer is { } __value14 && cancelTransfer != null)
            {
                return cancelTransfer(__value14);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ConversationNode?>? conversationNode = null,

            global::System.Action<global::RetellAI.SubagentNode?>? subagent = null,

            global::System.Action<global::RetellAI.EndNode?>? end = null,

            global::System.Action<global::RetellAI.FunctionNode?>? function = null,

            global::System.Action<global::RetellAI.CodeNode?>? code = null,

            global::System.Action<global::RetellAI.TransferCallNode?>? transferCall = null,

            global::System.Action<global::RetellAI.PressDigitNode?>? pressDigit = null,

            global::System.Action<global::RetellAI.BranchNode?>? branch = null,

            global::System.Action<global::RetellAI.SmsNode?>? sms = null,

            global::System.Action<global::RetellAI.ExtractDynamicVariablesNode?>? extractDynamicVariables = null,

            global::System.Action<global::RetellAI.AgentSwapNode?>? agentSwap = null,

            global::System.Action<global::RetellAI.MCPNode?>? mcp = null,

            global::System.Action<global::RetellAI.ComponentNode?>? component = null,

            global::System.Action<global::RetellAI.BridgeTransferNode?>? bridgeTransfer = null,

            global::System.Action<global::RetellAI.CancelTransferNode?>? cancelTransfer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ConversationNode is { } __value0)
            {
                conversationNode?.Invoke(__value0);
            }
            else if (Subagent is { } __value1)
            {
                subagent?.Invoke(__value1);
            }
            else if (End is { } __value2)
            {
                end?.Invoke(__value2);
            }
            else if (Function is { } __value3)
            {
                function?.Invoke(__value3);
            }
            else if (Code is { } __value4)
            {
                code?.Invoke(__value4);
            }
            else if (TransferCall is { } __value5)
            {
                transferCall?.Invoke(__value5);
            }
            else if (PressDigit is { } __value6)
            {
                pressDigit?.Invoke(__value6);
            }
            else if (Branch is { } __value7)
            {
                branch?.Invoke(__value7);
            }
            else if (Sms is { } __value8)
            {
                sms?.Invoke(__value8);
            }
            else if (ExtractDynamicVariables is { } __value9)
            {
                extractDynamicVariables?.Invoke(__value9);
            }
            else if (AgentSwap is { } __value10)
            {
                agentSwap?.Invoke(__value10);
            }
            else if (Mcp is { } __value11)
            {
                mcp?.Invoke(__value11);
            }
            else if (Component is { } __value12)
            {
                component?.Invoke(__value12);
            }
            else if (BridgeTransfer is { } __value13)
            {
                bridgeTransfer?.Invoke(__value13);
            }
            else if (CancelTransfer is { } __value14)
            {
                cancelTransfer?.Invoke(__value14);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ConversationNode?>? conversationNode = null,
            global::System.Action<global::RetellAI.SubagentNode?>? subagent = null,
            global::System.Action<global::RetellAI.EndNode?>? end = null,
            global::System.Action<global::RetellAI.FunctionNode?>? function = null,
            global::System.Action<global::RetellAI.CodeNode?>? code = null,
            global::System.Action<global::RetellAI.TransferCallNode?>? transferCall = null,
            global::System.Action<global::RetellAI.PressDigitNode?>? pressDigit = null,
            global::System.Action<global::RetellAI.BranchNode?>? branch = null,
            global::System.Action<global::RetellAI.SmsNode?>? sms = null,
            global::System.Action<global::RetellAI.ExtractDynamicVariablesNode?>? extractDynamicVariables = null,
            global::System.Action<global::RetellAI.AgentSwapNode?>? agentSwap = null,
            global::System.Action<global::RetellAI.MCPNode?>? mcp = null,
            global::System.Action<global::RetellAI.ComponentNode?>? component = null,
            global::System.Action<global::RetellAI.BridgeTransferNode?>? bridgeTransfer = null,
            global::System.Action<global::RetellAI.CancelTransferNode?>? cancelTransfer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ConversationNode is { } __value0)
            {
                conversationNode?.Invoke(__value0);
            }
            else if (Subagent is { } __value1)
            {
                subagent?.Invoke(__value1);
            }
            else if (End is { } __value2)
            {
                end?.Invoke(__value2);
            }
            else if (Function is { } __value3)
            {
                function?.Invoke(__value3);
            }
            else if (Code is { } __value4)
            {
                code?.Invoke(__value4);
            }
            else if (TransferCall is { } __value5)
            {
                transferCall?.Invoke(__value5);
            }
            else if (PressDigit is { } __value6)
            {
                pressDigit?.Invoke(__value6);
            }
            else if (Branch is { } __value7)
            {
                branch?.Invoke(__value7);
            }
            else if (Sms is { } __value8)
            {
                sms?.Invoke(__value8);
            }
            else if (ExtractDynamicVariables is { } __value9)
            {
                extractDynamicVariables?.Invoke(__value9);
            }
            else if (AgentSwap is { } __value10)
            {
                agentSwap?.Invoke(__value10);
            }
            else if (Mcp is { } __value11)
            {
                mcp?.Invoke(__value11);
            }
            else if (Component is { } __value12)
            {
                component?.Invoke(__value12);
            }
            else if (BridgeTransfer is { } __value13)
            {
                bridgeTransfer?.Invoke(__value13);
            }
            else if (CancelTransfer is { } __value14)
            {
                cancelTransfer?.Invoke(__value14);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ConversationNode,
                typeof(global::RetellAI.ConversationNode),
                Subagent,
                typeof(global::RetellAI.SubagentNode),
                End,
                typeof(global::RetellAI.EndNode),
                Function,
                typeof(global::RetellAI.FunctionNode),
                Code,
                typeof(global::RetellAI.CodeNode),
                TransferCall,
                typeof(global::RetellAI.TransferCallNode),
                PressDigit,
                typeof(global::RetellAI.PressDigitNode),
                Branch,
                typeof(global::RetellAI.BranchNode),
                Sms,
                typeof(global::RetellAI.SmsNode),
                ExtractDynamicVariables,
                typeof(global::RetellAI.ExtractDynamicVariablesNode),
                AgentSwap,
                typeof(global::RetellAI.AgentSwapNode),
                Mcp,
                typeof(global::RetellAI.MCPNode),
                Component,
                typeof(global::RetellAI.ComponentNode),
                BridgeTransfer,
                typeof(global::RetellAI.BridgeTransferNode),
                CancelTransfer,
                typeof(global::RetellAI.CancelTransferNode),
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
        public bool Equals(ConversationFlowNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConversationNode?>.Default.Equals(ConversationNode, other.ConversationNode) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.SubagentNode?>.Default.Equals(Subagent, other.Subagent) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.EndNode?>.Default.Equals(End, other.End) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.FunctionNode?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.CodeNode?>.Default.Equals(Code, other.Code) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TransferCallNode?>.Default.Equals(TransferCall, other.TransferCall) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.PressDigitNode?>.Default.Equals(PressDigit, other.PressDigit) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.BranchNode?>.Default.Equals(Branch, other.Branch) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.SmsNode?>.Default.Equals(Sms, other.Sms) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ExtractDynamicVariablesNode?>.Default.Equals(ExtractDynamicVariables, other.ExtractDynamicVariables) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AgentSwapNode?>.Default.Equals(AgentSwap, other.AgentSwap) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.MCPNode?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ComponentNode?>.Default.Equals(Component, other.Component) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.BridgeTransferNode?>.Default.Equals(BridgeTransfer, other.BridgeTransfer) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.CancelTransferNode?>.Default.Equals(CancelTransfer, other.CancelTransfer)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ConversationFlowNode obj1, ConversationFlowNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConversationFlowNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ConversationFlowNode obj1, ConversationFlowNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConversationFlowNode o && Equals(o);
        }
    }
}
