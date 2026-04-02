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
            global::System.Func<global::RetellAI.EndCallTool?, TResult>? endCall = null,
            global::System.Func<global::RetellAI.TransferCallTool?, TResult>? transferCall = null,
            global::System.Func<global::RetellAI.CheckAvailabilityCalTool?, TResult>? checkAvailabilityCal = null,
            global::System.Func<global::RetellAI.BookAppointmentCalTool?, TResult>? bookAppointmentCal = null,
            global::System.Func<global::RetellAI.AgentSwapTool?, TResult>? agentSwap = null,
            global::System.Func<global::RetellAI.PressDigitTool?, TResult>? pressDigit = null,
            global::System.Func<global::RetellAI.SendSMSTool?, TResult>? sendSM = null,
            global::System.Func<global::RetellAI.CustomTool?, TResult>? custom = null,
            global::System.Func<global::RetellAI.CodeTool?, TResult>? code = null,
            global::System.Func<global::RetellAI.ExtractDynamicVariableTool?, TResult>? extractDynamicVariable = null,
            global::System.Func<global::RetellAI.BridgeTransferTool?, TResult>? bridgeTransfer = null,
            global::System.Func<global::RetellAI.CancelTransferTool?, TResult>? cancelTransfer = null,
            global::System.Func<global::RetellAI.MCPTool?, TResult>? mcp = null,
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
            global::System.Action<global::RetellAI.EndCallTool?>? endCall = null,
            global::System.Action<global::RetellAI.TransferCallTool?>? transferCall = null,
            global::System.Action<global::RetellAI.CheckAvailabilityCalTool?>? checkAvailabilityCal = null,
            global::System.Action<global::RetellAI.BookAppointmentCalTool?>? bookAppointmentCal = null,
            global::System.Action<global::RetellAI.AgentSwapTool?>? agentSwap = null,
            global::System.Action<global::RetellAI.PressDigitTool?>? pressDigit = null,
            global::System.Action<global::RetellAI.SendSMSTool?>? sendSM = null,
            global::System.Action<global::RetellAI.CustomTool?>? custom = null,
            global::System.Action<global::RetellAI.CodeTool?>? code = null,
            global::System.Action<global::RetellAI.ExtractDynamicVariableTool?>? extractDynamicVariable = null,
            global::System.Action<global::RetellAI.BridgeTransferTool?>? bridgeTransfer = null,
            global::System.Action<global::RetellAI.CancelTransferTool?>? cancelTransfer = null,
            global::System.Action<global::RetellAI.MCPTool?>? mcp = null,
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
