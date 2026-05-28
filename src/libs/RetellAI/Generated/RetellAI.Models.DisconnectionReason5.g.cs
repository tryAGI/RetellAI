
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum DisconnectionReason5
    {
        /// <summary>
        /// 
        /// </summary>
        AgentHangup,
        /// <summary>
        /// 
        /// </summary>
        CallTransfer,
        /// <summary>
        /// 
        /// </summary>
        ConcurrencyLimitReached,
        /// <summary>
        /// 
        /// </summary>
        DialBusy,
        /// <summary>
        /// 
        /// </summary>
        DialFailed,
        /// <summary>
        /// 
        /// </summary>
        DialNoAnswer,
        /// <summary>
        /// 
        /// </summary>
        ErrorAsr,
        /// <summary>
        /// 
        /// </summary>
        ErrorLlmWebsocketCorruptPayload,
        /// <summary>
        /// 
        /// </summary>
        ErrorLlmWebsocketLostConnection,
        /// <summary>
        /// 
        /// </summary>
        ErrorLlmWebsocketOpen,
        /// <summary>
        /// 
        /// </summary>
        ErrorLlmWebsocketRuntime,
        /// <summary>
        /// 
        /// </summary>
        ErrorNoAudioReceived,
        /// <summary>
        /// 
        /// </summary>
        ErrorRetell,
        /// <summary>
        /// 
        /// </summary>
        ErrorUnknown,
        /// <summary>
        /// 
        /// </summary>
        ErrorUserNotJoined,
        /// <summary>
        /// 
        /// </summary>
        Inactivity,
        /// <summary>
        /// 
        /// </summary>
        InvalidDestination,
        /// <summary>
        /// 
        /// </summary>
        IvrReached,
        /// <summary>
        /// 
        /// </summary>
        ManualStopped,
        /// <summary>
        /// 
        /// </summary>
        MarkedAsSpam,
        /// <summary>
        /// 
        /// </summary>
        MaxDurationReached,
        /// <summary>
        /// 
        /// </summary>
        NoConcurrencyFallback,
        /// <summary>
        /// 
        /// </summary>
        NoValidPayment,
        /// <summary>
        /// 
        /// </summary>
        RegisteredCallTimeout,
        /// <summary>
        /// 
        /// </summary>
        ScamDetected,
        /// <summary>
        /// 
        /// </summary>
        SipRoutingError,
        /// <summary>
        /// 
        /// </summary>
        TelephonyProviderPermissionDenied,
        /// <summary>
        /// 
        /// </summary>
        TelephonyProviderUnavailable,
        /// <summary>
        /// 
        /// </summary>
        TransferBridged,
        /// <summary>
        /// 
        /// </summary>
        TransferCancelled,
        /// <summary>
        /// 
        /// </summary>
        UserDeclined,
        /// <summary>
        /// 
        /// </summary>
        UserHangup,
        /// <summary>
        /// 
        /// </summary>
        VoicemailReached,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DisconnectionReason5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DisconnectionReason5 value)
        {
            return value switch
            {
                DisconnectionReason5.AgentHangup => "agent_hangup",
                DisconnectionReason5.CallTransfer => "call_transfer",
                DisconnectionReason5.ConcurrencyLimitReached => "concurrency_limit_reached",
                DisconnectionReason5.DialBusy => "dial_busy",
                DisconnectionReason5.DialFailed => "dial_failed",
                DisconnectionReason5.DialNoAnswer => "dial_no_answer",
                DisconnectionReason5.ErrorAsr => "error_asr",
                DisconnectionReason5.ErrorLlmWebsocketCorruptPayload => "error_llm_websocket_corrupt_payload",
                DisconnectionReason5.ErrorLlmWebsocketLostConnection => "error_llm_websocket_lost_connection",
                DisconnectionReason5.ErrorLlmWebsocketOpen => "error_llm_websocket_open",
                DisconnectionReason5.ErrorLlmWebsocketRuntime => "error_llm_websocket_runtime",
                DisconnectionReason5.ErrorNoAudioReceived => "error_no_audio_received",
                DisconnectionReason5.ErrorRetell => "error_retell",
                DisconnectionReason5.ErrorUnknown => "error_unknown",
                DisconnectionReason5.ErrorUserNotJoined => "error_user_not_joined",
                DisconnectionReason5.Inactivity => "inactivity",
                DisconnectionReason5.InvalidDestination => "invalid_destination",
                DisconnectionReason5.IvrReached => "ivr_reached",
                DisconnectionReason5.ManualStopped => "manual_stopped",
                DisconnectionReason5.MarkedAsSpam => "marked_as_spam",
                DisconnectionReason5.MaxDurationReached => "max_duration_reached",
                DisconnectionReason5.NoConcurrencyFallback => "no_concurrency_fallback",
                DisconnectionReason5.NoValidPayment => "no_valid_payment",
                DisconnectionReason5.RegisteredCallTimeout => "registered_call_timeout",
                DisconnectionReason5.ScamDetected => "scam_detected",
                DisconnectionReason5.SipRoutingError => "sip_routing_error",
                DisconnectionReason5.TelephonyProviderPermissionDenied => "telephony_provider_permission_denied",
                DisconnectionReason5.TelephonyProviderUnavailable => "telephony_provider_unavailable",
                DisconnectionReason5.TransferBridged => "transfer_bridged",
                DisconnectionReason5.TransferCancelled => "transfer_cancelled",
                DisconnectionReason5.UserDeclined => "user_declined",
                DisconnectionReason5.UserHangup => "user_hangup",
                DisconnectionReason5.VoicemailReached => "voicemail_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DisconnectionReason5? ToEnum(string value)
        {
            return value switch
            {
                "agent_hangup" => DisconnectionReason5.AgentHangup,
                "call_transfer" => DisconnectionReason5.CallTransfer,
                "concurrency_limit_reached" => DisconnectionReason5.ConcurrencyLimitReached,
                "dial_busy" => DisconnectionReason5.DialBusy,
                "dial_failed" => DisconnectionReason5.DialFailed,
                "dial_no_answer" => DisconnectionReason5.DialNoAnswer,
                "error_asr" => DisconnectionReason5.ErrorAsr,
                "error_llm_websocket_corrupt_payload" => DisconnectionReason5.ErrorLlmWebsocketCorruptPayload,
                "error_llm_websocket_lost_connection" => DisconnectionReason5.ErrorLlmWebsocketLostConnection,
                "error_llm_websocket_open" => DisconnectionReason5.ErrorLlmWebsocketOpen,
                "error_llm_websocket_runtime" => DisconnectionReason5.ErrorLlmWebsocketRuntime,
                "error_no_audio_received" => DisconnectionReason5.ErrorNoAudioReceived,
                "error_retell" => DisconnectionReason5.ErrorRetell,
                "error_unknown" => DisconnectionReason5.ErrorUnknown,
                "error_user_not_joined" => DisconnectionReason5.ErrorUserNotJoined,
                "inactivity" => DisconnectionReason5.Inactivity,
                "invalid_destination" => DisconnectionReason5.InvalidDestination,
                "ivr_reached" => DisconnectionReason5.IvrReached,
                "manual_stopped" => DisconnectionReason5.ManualStopped,
                "marked_as_spam" => DisconnectionReason5.MarkedAsSpam,
                "max_duration_reached" => DisconnectionReason5.MaxDurationReached,
                "no_concurrency_fallback" => DisconnectionReason5.NoConcurrencyFallback,
                "no_valid_payment" => DisconnectionReason5.NoValidPayment,
                "registered_call_timeout" => DisconnectionReason5.RegisteredCallTimeout,
                "scam_detected" => DisconnectionReason5.ScamDetected,
                "sip_routing_error" => DisconnectionReason5.SipRoutingError,
                "telephony_provider_permission_denied" => DisconnectionReason5.TelephonyProviderPermissionDenied,
                "telephony_provider_unavailable" => DisconnectionReason5.TelephonyProviderUnavailable,
                "transfer_bridged" => DisconnectionReason5.TransferBridged,
                "transfer_cancelled" => DisconnectionReason5.TransferCancelled,
                "user_declined" => DisconnectionReason5.UserDeclined,
                "user_hangup" => DisconnectionReason5.UserHangup,
                "voicemail_reached" => DisconnectionReason5.VoicemailReached,
                _ => null,
            };
        }
    }
}