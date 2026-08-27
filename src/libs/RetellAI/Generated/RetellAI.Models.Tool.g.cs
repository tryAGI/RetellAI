#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Tool : global::System.IEquatable<Tool>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.EndCallTool? EndCall { get; init; }
#else
        public global::RetellAI.EndCallTool? EndCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EndCall))]
#endif
        public bool IsEndCall => EndCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEndCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.EndCallTool? value)
        {
            value = EndCall;
            return IsEndCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndCallTool PickEndCall() => IsEndCall
            ? EndCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EndCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TransferCallTool? TransferCall { get; init; }
#else
        public global::RetellAI.TransferCallTool? TransferCall { get; }
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
            out global::RetellAI.TransferCallTool? value)
        {
            value = TransferCall;
            return IsTransferCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferCallTool PickTransferCall() => IsTransferCall
            ? TransferCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TransferCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.CheckAvailabilityCalTool? CheckAvailabilityCal { get; init; }
#else
        public global::RetellAI.CheckAvailabilityCalTool? CheckAvailabilityCal { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CheckAvailabilityCal))]
#endif
        public bool IsCheckAvailabilityCal => CheckAvailabilityCal != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCheckAvailabilityCal(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.CheckAvailabilityCalTool? value)
        {
            value = CheckAvailabilityCal;
            return IsCheckAvailabilityCal;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CheckAvailabilityCalTool PickCheckAvailabilityCal() => IsCheckAvailabilityCal
            ? CheckAvailabilityCal!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CheckAvailabilityCal' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.BookAppointmentCalTool? BookAppointmentCal { get; init; }
#else
        public global::RetellAI.BookAppointmentCalTool? BookAppointmentCal { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BookAppointmentCal))]
#endif
        public bool IsBookAppointmentCal => BookAppointmentCal != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBookAppointmentCal(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.BookAppointmentCalTool? value)
        {
            value = BookAppointmentCal;
            return IsBookAppointmentCal;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BookAppointmentCalTool PickBookAppointmentCal() => IsBookAppointmentCal
            ? BookAppointmentCal!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BookAppointmentCal' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.AgentSwapTool? AgentSwap { get; init; }
#else
        public global::RetellAI.AgentSwapTool? AgentSwap { get; }
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
            out global::RetellAI.AgentSwapTool? value)
        {
            value = AgentSwap;
            return IsAgentSwap;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentSwapTool PickAgentSwap() => IsAgentSwap
            ? AgentSwap!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSwap' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.PressDigitTool? PressDigit { get; init; }
#else
        public global::RetellAI.PressDigitTool? PressDigit { get; }
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
            out global::RetellAI.PressDigitTool? value)
        {
            value = PressDigit;
            return IsPressDigit;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PressDigitTool PickPressDigit() => IsPressDigit
            ? PressDigit!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PressDigit' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.SendSMSTool? SendSM { get; init; }
#else
        public global::RetellAI.SendSMSTool? SendSM { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SendSM))]
#endif
        public bool IsSendSM => SendSM != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSendSM(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.SendSMSTool? value)
        {
            value = SendSM;
            return IsSendSM;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SendSMSTool PickSendSM() => IsSendSM
            ? SendSM!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SendSM' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.CustomTool? Custom { get; init; }
#else
        public global::RetellAI.CustomTool? Custom { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustom(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.CustomTool? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CustomTool PickCustom() => IsCustom
            ? Custom!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.CodeTool? Code { get; init; }
#else
        public global::RetellAI.CodeTool? Code { get; }
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
            out global::RetellAI.CodeTool? value)
        {
            value = Code;
            return IsCode;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CodeTool PickCode() => IsCode
            ? Code!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Code' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ExtractDynamicVariableTool? ExtractDynamicVariable { get; init; }
#else
        public global::RetellAI.ExtractDynamicVariableTool? ExtractDynamicVariable { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExtractDynamicVariable))]
#endif
        public bool IsExtractDynamicVariable => ExtractDynamicVariable != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickExtractDynamicVariable(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ExtractDynamicVariableTool? value)
        {
            value = ExtractDynamicVariable;
            return IsExtractDynamicVariable;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ExtractDynamicVariableTool PickExtractDynamicVariable() => IsExtractDynamicVariable
            ? ExtractDynamicVariable!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ExtractDynamicVariable' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.BridgeTransferTool? BridgeTransfer { get; init; }
#else
        public global::RetellAI.BridgeTransferTool? BridgeTransfer { get; }
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
            out global::RetellAI.BridgeTransferTool? value)
        {
            value = BridgeTransfer;
            return IsBridgeTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BridgeTransferTool PickBridgeTransfer() => IsBridgeTransfer
            ? BridgeTransfer!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BridgeTransfer' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.CancelTransferTool? CancelTransfer { get; init; }
#else
        public global::RetellAI.CancelTransferTool? CancelTransfer { get; }
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
            out global::RetellAI.CancelTransferTool? value)
        {
            value = CancelTransfer;
            return IsCancelTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CancelTransferTool PickCancelTransfer() => IsCancelTransfer
            ? CancelTransfer!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CancelTransfer' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.MCPTool? Mcp { get; init; }
#else
        public global::RetellAI.MCPTool? Mcp { get; }
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
            out global::RetellAI.MCPTool? value)
        {
            value = Mcp;
            return IsMcp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MCPTool PickMcp() => IsMcp
            ? Mcp!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Mcp' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::RetellAI.EndCallTool value) => new Tool((global::RetellAI.EndCallTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.EndCallTool?(Tool @this) => @this.EndCall;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::RetellAI.EndCallTool? value)
        {
            EndCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromEndCall(global::RetellAI.EndCallTool? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::RetellAI.TransferCallTool value) => new Tool((global::RetellAI.TransferCallTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.TransferCallTool?(Tool @this) => @this.TransferCall;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::RetellAI.TransferCallTool? value)
        {
            TransferCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromTransferCall(global::RetellAI.TransferCallTool? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::RetellAI.CheckAvailabilityCalTool value) => new Tool((global::RetellAI.CheckAvailabilityCalTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.CheckAvailabilityCalTool?(Tool @this) => @this.CheckAvailabilityCal;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::RetellAI.CheckAvailabilityCalTool? value)
        {
            CheckAvailabilityCal = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromCheckAvailabilityCal(global::RetellAI.CheckAvailabilityCalTool? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::RetellAI.BookAppointmentCalTool value) => new Tool((global::RetellAI.BookAppointmentCalTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.BookAppointmentCalTool?(Tool @this) => @this.BookAppointmentCal;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::RetellAI.BookAppointmentCalTool? value)
        {
            BookAppointmentCal = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromBookAppointmentCal(global::RetellAI.BookAppointmentCalTool? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::RetellAI.AgentSwapTool value) => new Tool((global::RetellAI.AgentSwapTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.AgentSwapTool?(Tool @this) => @this.AgentSwap;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::RetellAI.AgentSwapTool? value)
        {
            AgentSwap = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromAgentSwap(global::RetellAI.AgentSwapTool? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::RetellAI.PressDigitTool value) => new Tool((global::RetellAI.PressDigitTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.PressDigitTool?(Tool @this) => @this.PressDigit;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::RetellAI.PressDigitTool? value)
        {
            PressDigit = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromPressDigit(global::RetellAI.PressDigitTool? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::RetellAI.SendSMSTool value) => new Tool((global::RetellAI.SendSMSTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.SendSMSTool?(Tool @this) => @this.SendSM;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::RetellAI.SendSMSTool? value)
        {
            SendSM = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromSendSM(global::RetellAI.SendSMSTool? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::RetellAI.CustomTool value) => new Tool((global::RetellAI.CustomTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.CustomTool?(Tool @this) => @this.Custom;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::RetellAI.CustomTool? value)
        {
            Custom = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromCustom(global::RetellAI.CustomTool? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::RetellAI.CodeTool value) => new Tool((global::RetellAI.CodeTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.CodeTool?(Tool @this) => @this.Code;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::RetellAI.CodeTool? value)
        {
            Code = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromCode(global::RetellAI.CodeTool? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::RetellAI.ExtractDynamicVariableTool value) => new Tool((global::RetellAI.ExtractDynamicVariableTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ExtractDynamicVariableTool?(Tool @this) => @this.ExtractDynamicVariable;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::RetellAI.ExtractDynamicVariableTool? value)
        {
            ExtractDynamicVariable = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromExtractDynamicVariable(global::RetellAI.ExtractDynamicVariableTool? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::RetellAI.BridgeTransferTool value) => new Tool((global::RetellAI.BridgeTransferTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.BridgeTransferTool?(Tool @this) => @this.BridgeTransfer;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::RetellAI.BridgeTransferTool? value)
        {
            BridgeTransfer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromBridgeTransfer(global::RetellAI.BridgeTransferTool? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::RetellAI.CancelTransferTool value) => new Tool((global::RetellAI.CancelTransferTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.CancelTransferTool?(Tool @this) => @this.CancelTransfer;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::RetellAI.CancelTransferTool? value)
        {
            CancelTransfer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromCancelTransfer(global::RetellAI.CancelTransferTool? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::RetellAI.MCPTool value) => new Tool((global::RetellAI.MCPTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.MCPTool?(Tool @this) => @this.Mcp;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::RetellAI.MCPTool? value)
        {
            Mcp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromMcp(global::RetellAI.MCPTool? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public Tool(
            global::RetellAI.EndCallTool? endCall,
            global::RetellAI.TransferCallTool? transferCall,
            global::RetellAI.CheckAvailabilityCalTool? checkAvailabilityCal,
            global::RetellAI.BookAppointmentCalTool? bookAppointmentCal,
            global::RetellAI.AgentSwapTool? agentSwap,
            global::RetellAI.PressDigitTool? pressDigit,
            global::RetellAI.SendSMSTool? sendSM,
            global::RetellAI.CustomTool? custom,
            global::RetellAI.CodeTool? code,
            global::RetellAI.ExtractDynamicVariableTool? extractDynamicVariable,
            global::RetellAI.BridgeTransferTool? bridgeTransfer,
            global::RetellAI.CancelTransferTool? cancelTransfer,
            global::RetellAI.MCPTool? mcp
            )
        {
            EndCall = endCall;
            TransferCall = transferCall;
            CheckAvailabilityCal = checkAvailabilityCal;
            BookAppointmentCal = bookAppointmentCal;
            AgentSwap = agentSwap;
            PressDigit = pressDigit;
            SendSM = sendSM;
            Custom = custom;
            Code = code;
            ExtractDynamicVariable = extractDynamicVariable;
            BridgeTransfer = bridgeTransfer;
            CancelTransfer = cancelTransfer;
            Mcp = mcp;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Mcp as object ??
            CancelTransfer as object ??
            BridgeTransfer as object ??
            ExtractDynamicVariable as object ??
            Code as object ??
            Custom as object ??
            SendSM as object ??
            PressDigit as object ??
            AgentSwap as object ??
            BookAppointmentCal as object ??
            CheckAvailabilityCal as object ??
            TransferCall as object ??
            EndCall as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            EndCall?.ToString() ??
            TransferCall?.ToString() ??
            CheckAvailabilityCal?.ToString() ??
            BookAppointmentCal?.ToString() ??
            AgentSwap?.ToString() ??
            PressDigit?.ToString() ??
            SendSM?.ToString() ??
            Custom?.ToString() ??
            Code?.ToString() ??
            ExtractDynamicVariable?.ToString() ??
            BridgeTransfer?.ToString() ??
            CancelTransfer?.ToString() ??
            Mcp?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEndCall && !IsTransferCall && !IsCheckAvailabilityCal && !IsBookAppointmentCal && !IsAgentSwap && !IsPressDigit && !IsSendSM && !IsCustom && !IsCode && !IsExtractDynamicVariable && !IsBridgeTransfer && !IsCancelTransfer && !IsMcp || !IsEndCall && IsTransferCall && !IsCheckAvailabilityCal && !IsBookAppointmentCal && !IsAgentSwap && !IsPressDigit && !IsSendSM && !IsCustom && !IsCode && !IsExtractDynamicVariable && !IsBridgeTransfer && !IsCancelTransfer && !IsMcp || !IsEndCall && !IsTransferCall && IsCheckAvailabilityCal && !IsBookAppointmentCal && !IsAgentSwap && !IsPressDigit && !IsSendSM && !IsCustom && !IsCode && !IsExtractDynamicVariable && !IsBridgeTransfer && !IsCancelTransfer && !IsMcp || !IsEndCall && !IsTransferCall && !IsCheckAvailabilityCal && IsBookAppointmentCal && !IsAgentSwap && !IsPressDigit && !IsSendSM && !IsCustom && !IsCode && !IsExtractDynamicVariable && !IsBridgeTransfer && !IsCancelTransfer && !IsMcp || !IsEndCall && !IsTransferCall && !IsCheckAvailabilityCal && !IsBookAppointmentCal && IsAgentSwap && !IsPressDigit && !IsSendSM && !IsCustom && !IsCode && !IsExtractDynamicVariable && !IsBridgeTransfer && !IsCancelTransfer && !IsMcp || !IsEndCall && !IsTransferCall && !IsCheckAvailabilityCal && !IsBookAppointmentCal && !IsAgentSwap && IsPressDigit && !IsSendSM && !IsCustom && !IsCode && !IsExtractDynamicVariable && !IsBridgeTransfer && !IsCancelTransfer && !IsMcp || !IsEndCall && !IsTransferCall && !IsCheckAvailabilityCal && !IsBookAppointmentCal && !IsAgentSwap && !IsPressDigit && IsSendSM && !IsCustom && !IsCode && !IsExtractDynamicVariable && !IsBridgeTransfer && !IsCancelTransfer && !IsMcp || !IsEndCall && !IsTransferCall && !IsCheckAvailabilityCal && !IsBookAppointmentCal && !IsAgentSwap && !IsPressDigit && !IsSendSM && IsCustom && !IsCode && !IsExtractDynamicVariable && !IsBridgeTransfer && !IsCancelTransfer && !IsMcp || !IsEndCall && !IsTransferCall && !IsCheckAvailabilityCal && !IsBookAppointmentCal && !IsAgentSwap && !IsPressDigit && !IsSendSM && !IsCustom && IsCode && !IsExtractDynamicVariable && !IsBridgeTransfer && !IsCancelTransfer && !IsMcp || !IsEndCall && !IsTransferCall && !IsCheckAvailabilityCal && !IsBookAppointmentCal && !IsAgentSwap && !IsPressDigit && !IsSendSM && !IsCustom && !IsCode && IsExtractDynamicVariable && !IsBridgeTransfer && !IsCancelTransfer && !IsMcp || !IsEndCall && !IsTransferCall && !IsCheckAvailabilityCal && !IsBookAppointmentCal && !IsAgentSwap && !IsPressDigit && !IsSendSM && !IsCustom && !IsCode && !IsExtractDynamicVariable && IsBridgeTransfer && !IsCancelTransfer && !IsMcp || !IsEndCall && !IsTransferCall && !IsCheckAvailabilityCal && !IsBookAppointmentCal && !IsAgentSwap && !IsPressDigit && !IsSendSM && !IsCustom && !IsCode && !IsExtractDynamicVariable && !IsBridgeTransfer && IsCancelTransfer && !IsMcp || !IsEndCall && !IsTransferCall && !IsCheckAvailabilityCal && !IsBookAppointmentCal && !IsAgentSwap && !IsPressDigit && !IsSendSM && !IsCustom && !IsCode && !IsExtractDynamicVariable && !IsBridgeTransfer && !IsCancelTransfer && IsMcp;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.EndCallTool, TResult>? endCall = null,
            global::System.Func<global::RetellAI.TransferCallTool, TResult>? transferCall = null,
            global::System.Func<global::RetellAI.CheckAvailabilityCalTool, TResult>? checkAvailabilityCal = null,
            global::System.Func<global::RetellAI.BookAppointmentCalTool, TResult>? bookAppointmentCal = null,
            global::System.Func<global::RetellAI.AgentSwapTool, TResult>? agentSwap = null,
            global::System.Func<global::RetellAI.PressDigitTool, TResult>? pressDigit = null,
            global::System.Func<global::RetellAI.SendSMSTool, TResult>? sendSM = null,
            global::System.Func<global::RetellAI.CustomTool, TResult>? custom = null,
            global::System.Func<global::RetellAI.CodeTool, TResult>? code = null,
            global::System.Func<global::RetellAI.ExtractDynamicVariableTool, TResult>? extractDynamicVariable = null,
            global::System.Func<global::RetellAI.BridgeTransferTool, TResult>? bridgeTransfer = null,
            global::System.Func<global::RetellAI.CancelTransferTool, TResult>? cancelTransfer = null,
            global::System.Func<global::RetellAI.MCPTool, TResult>? mcp = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEndCall && endCall != null)
            {
                return endCall(EndCall!);
            }
            else if (IsTransferCall && transferCall != null)
            {
                return transferCall(TransferCall!);
            }
            else if (IsCheckAvailabilityCal && checkAvailabilityCal != null)
            {
                return checkAvailabilityCal(CheckAvailabilityCal!);
            }
            else if (IsBookAppointmentCal && bookAppointmentCal != null)
            {
                return bookAppointmentCal(BookAppointmentCal!);
            }
            else if (IsAgentSwap && agentSwap != null)
            {
                return agentSwap(AgentSwap!);
            }
            else if (IsPressDigit && pressDigit != null)
            {
                return pressDigit(PressDigit!);
            }
            else if (IsSendSM && sendSM != null)
            {
                return sendSM(SendSM!);
            }
            else if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }
            else if (IsCode && code != null)
            {
                return code(Code!);
            }
            else if (IsExtractDynamicVariable && extractDynamicVariable != null)
            {
                return extractDynamicVariable(ExtractDynamicVariable!);
            }
            else if (IsBridgeTransfer && bridgeTransfer != null)
            {
                return bridgeTransfer(BridgeTransfer!);
            }
            else if (IsCancelTransfer && cancelTransfer != null)
            {
                return cancelTransfer(CancelTransfer!);
            }
            else if (IsMcp && mcp != null)
            {
                return mcp(Mcp!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.EndCallTool>? endCall = null,

            global::System.Action<global::RetellAI.TransferCallTool>? transferCall = null,

            global::System.Action<global::RetellAI.CheckAvailabilityCalTool>? checkAvailabilityCal = null,

            global::System.Action<global::RetellAI.BookAppointmentCalTool>? bookAppointmentCal = null,

            global::System.Action<global::RetellAI.AgentSwapTool>? agentSwap = null,

            global::System.Action<global::RetellAI.PressDigitTool>? pressDigit = null,

            global::System.Action<global::RetellAI.SendSMSTool>? sendSM = null,

            global::System.Action<global::RetellAI.CustomTool>? custom = null,

            global::System.Action<global::RetellAI.CodeTool>? code = null,

            global::System.Action<global::RetellAI.ExtractDynamicVariableTool>? extractDynamicVariable = null,

            global::System.Action<global::RetellAI.BridgeTransferTool>? bridgeTransfer = null,

            global::System.Action<global::RetellAI.CancelTransferTool>? cancelTransfer = null,

            global::System.Action<global::RetellAI.MCPTool>? mcp = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEndCall)
            {
                endCall?.Invoke(EndCall!);
            }
            else if (IsTransferCall)
            {
                transferCall?.Invoke(TransferCall!);
            }
            else if (IsCheckAvailabilityCal)
            {
                checkAvailabilityCal?.Invoke(CheckAvailabilityCal!);
            }
            else if (IsBookAppointmentCal)
            {
                bookAppointmentCal?.Invoke(BookAppointmentCal!);
            }
            else if (IsAgentSwap)
            {
                agentSwap?.Invoke(AgentSwap!);
            }
            else if (IsPressDigit)
            {
                pressDigit?.Invoke(PressDigit!);
            }
            else if (IsSendSM)
            {
                sendSM?.Invoke(SendSM!);
            }
            else if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
            else if (IsCode)
            {
                code?.Invoke(Code!);
            }
            else if (IsExtractDynamicVariable)
            {
                extractDynamicVariable?.Invoke(ExtractDynamicVariable!);
            }
            else if (IsBridgeTransfer)
            {
                bridgeTransfer?.Invoke(BridgeTransfer!);
            }
            else if (IsCancelTransfer)
            {
                cancelTransfer?.Invoke(CancelTransfer!);
            }
            else if (IsMcp)
            {
                mcp?.Invoke(Mcp!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.EndCallTool>? endCall = null,
            global::System.Action<global::RetellAI.TransferCallTool>? transferCall = null,
            global::System.Action<global::RetellAI.CheckAvailabilityCalTool>? checkAvailabilityCal = null,
            global::System.Action<global::RetellAI.BookAppointmentCalTool>? bookAppointmentCal = null,
            global::System.Action<global::RetellAI.AgentSwapTool>? agentSwap = null,
            global::System.Action<global::RetellAI.PressDigitTool>? pressDigit = null,
            global::System.Action<global::RetellAI.SendSMSTool>? sendSM = null,
            global::System.Action<global::RetellAI.CustomTool>? custom = null,
            global::System.Action<global::RetellAI.CodeTool>? code = null,
            global::System.Action<global::RetellAI.ExtractDynamicVariableTool>? extractDynamicVariable = null,
            global::System.Action<global::RetellAI.BridgeTransferTool>? bridgeTransfer = null,
            global::System.Action<global::RetellAI.CancelTransferTool>? cancelTransfer = null,
            global::System.Action<global::RetellAI.MCPTool>? mcp = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEndCall)
            {
                endCall?.Invoke(EndCall!);
            }
            else if (IsTransferCall)
            {
                transferCall?.Invoke(TransferCall!);
            }
            else if (IsCheckAvailabilityCal)
            {
                checkAvailabilityCal?.Invoke(CheckAvailabilityCal!);
            }
            else if (IsBookAppointmentCal)
            {
                bookAppointmentCal?.Invoke(BookAppointmentCal!);
            }
            else if (IsAgentSwap)
            {
                agentSwap?.Invoke(AgentSwap!);
            }
            else if (IsPressDigit)
            {
                pressDigit?.Invoke(PressDigit!);
            }
            else if (IsSendSM)
            {
                sendSM?.Invoke(SendSM!);
            }
            else if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
            else if (IsCode)
            {
                code?.Invoke(Code!);
            }
            else if (IsExtractDynamicVariable)
            {
                extractDynamicVariable?.Invoke(ExtractDynamicVariable!);
            }
            else if (IsBridgeTransfer)
            {
                bridgeTransfer?.Invoke(BridgeTransfer!);
            }
            else if (IsCancelTransfer)
            {
                cancelTransfer?.Invoke(CancelTransfer!);
            }
            else if (IsMcp)
            {
                mcp?.Invoke(Mcp!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EndCall,
                typeof(global::RetellAI.EndCallTool),
                TransferCall,
                typeof(global::RetellAI.TransferCallTool),
                CheckAvailabilityCal,
                typeof(global::RetellAI.CheckAvailabilityCalTool),
                BookAppointmentCal,
                typeof(global::RetellAI.BookAppointmentCalTool),
                AgentSwap,
                typeof(global::RetellAI.AgentSwapTool),
                PressDigit,
                typeof(global::RetellAI.PressDigitTool),
                SendSM,
                typeof(global::RetellAI.SendSMSTool),
                Custom,
                typeof(global::RetellAI.CustomTool),
                Code,
                typeof(global::RetellAI.CodeTool),
                ExtractDynamicVariable,
                typeof(global::RetellAI.ExtractDynamicVariableTool),
                BridgeTransfer,
                typeof(global::RetellAI.BridgeTransferTool),
                CancelTransfer,
                typeof(global::RetellAI.CancelTransferTool),
                Mcp,
                typeof(global::RetellAI.MCPTool),
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
        public bool Equals(Tool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.EndCallTool?>.Default.Equals(EndCall, other.EndCall) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TransferCallTool?>.Default.Equals(TransferCall, other.TransferCall) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.CheckAvailabilityCalTool?>.Default.Equals(CheckAvailabilityCal, other.CheckAvailabilityCal) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.BookAppointmentCalTool?>.Default.Equals(BookAppointmentCal, other.BookAppointmentCal) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AgentSwapTool?>.Default.Equals(AgentSwap, other.AgentSwap) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.PressDigitTool?>.Default.Equals(PressDigit, other.PressDigit) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.SendSMSTool?>.Default.Equals(SendSM, other.SendSM) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.CustomTool?>.Default.Equals(Custom, other.Custom) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.CodeTool?>.Default.Equals(Code, other.Code) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ExtractDynamicVariableTool?>.Default.Equals(ExtractDynamicVariable, other.ExtractDynamicVariable) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.BridgeTransferTool?>.Default.Equals(BridgeTransfer, other.BridgeTransfer) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.CancelTransferTool?>.Default.Equals(CancelTransfer, other.CancelTransfer) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.MCPTool?>.Default.Equals(Mcp, other.Mcp)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Tool obj1, Tool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Tool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Tool obj1, Tool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Tool o && Equals(o);
        }
    }
}
