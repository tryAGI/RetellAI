
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertMetricType? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AsrProvider? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AsrProviderModeRouting? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AsrProviderModeRoutingSplitItem>? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AsrProviderModeRoutingSplitItem? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PaginatedResponseBase? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertFilter? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AgentFilter>? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentFilter? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, object>? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EnumFilter? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterDisconnectionReason>? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertFilterDisconnectionReason? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.DisconnectionReason5>? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DisconnectionReason5? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CustomFieldFilter>? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CustomFieldFilter? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.StringFilter, object>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StringFilter? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterStatusCode>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertFilterStatusCode? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AlertFilterStatusCodeValueItem>? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertFilterStatusCodeValueItem? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AlertFilterErrorCodeItem>? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertFilterErrorCodeItem? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertIncidentResponse? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertIncidentResponseThresholdType? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertIncidentResponseComparator? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertIncidentResponseFrequency? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertIncidentResponseWindow? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertRuleRequest? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertRuleRequestThresholdType? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertRuleRequestComparator? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertRuleRequestFrequency? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertRuleRequestWindow? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertRuleResponse? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertRuleResponseThresholdType? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertRuleResponseComparator? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertRuleResponseFrequency? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertRuleResponseWindow? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentNaturalnessAnalysis? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.UtteranceNaturalnessIssues>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceNaturalnessIssues? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentWeight? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentVersionReference? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentVersionRequest? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PublishAgentVersionRequest? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRootTagState? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentOverrideRequest? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequest? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellLlmOverride? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowOverride? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ResponseEngine? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestVoiceModel? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestVoiceEmotion? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AgentRequestExpressiveEmotionTag>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestExpressiveEmotionTag? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestAmbientSound? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.Language3?, global::System.Collections.Generic.IList<global::RetellAI.Language3>, global::RetellAI.AgentRequestLanguage?>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Language3? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Language3>? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestLanguage? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AgentRequestWebhookEvent>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestWebhookEvent? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestDataStorageSetting? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AgentRequestPronunciationDictionaryItem>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestPronunciationDictionaryItem? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestPronunciationDictionaryItemAlphabet? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestVoicemailOption? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailAction? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestIvrOption? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallScreeningOption? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.PostCallAnalysisData>? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PostCallAnalysisData? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestSttMode? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestCustomSttConfig? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestVocabSpecialization? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestUserDtmfOptions? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestDenoisingMode? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PIIConfig? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GuardrailConfig? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoiceHandbookConfig? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentVersionSummary? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentResponse? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentResponseVariant1? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentResponseVariant3? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentListFilter? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.StringFilter, global::RetellAI.AgentListFilterChannel>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentListFilterChannel? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentListFilterChannelOp? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentListFilterChannelValue? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentListItemResponse? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentListItemResponseChannel? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::RetellAI.AgentRootTagState>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentSwapNode? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeBase? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentSwapNodeVariant2? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentSwapNodeVariant2Type? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PostCallAnalysisSetting? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentSwapWebhookSetting? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferFailedEdge? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeInstruction? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentSwapTool? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentSwapToolType? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentSwapToolExecutionMessageType? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AnalysisData? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StringAnalysisData? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EnumAnalysisData? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BooleanAnalysisData? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NumberAnalysisData? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallPresetAnalysisData? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PostChatAnalysisData? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatPresetAnalysisData? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AverageMetric? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BatchCallResponse? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallTimeWindow? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BatchCallTask? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BookAppointmentCalTool? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BookAppointmentCalToolType? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<double?, string>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BooleanAnalysisDataType? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BranchNode? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BranchNodeVariant2? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BranchNodeVariant2Type? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.NodeEdge>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeEdge? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ElseEdge? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.NodeFinetuneTransitionExample>? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeFinetuneTransitionExample? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BreakdownMetric? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Breakdown>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Breakdown? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::RetellAI.Breakdown>>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BridgeTransferNode? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BridgeTransferNodeVariant2? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BridgeTransferNodeVariant2Type? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BridgeTransferTool? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BridgeTransferToolType? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BridgeTransferToolExecutionMessageType? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallAnalysis? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallAnalysisUserSentiment? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallLatency? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallQA? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.InterruptionAnalysis? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SentimentAnalysis? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TranscriptionErrorAnalysis? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RAGAnalysis? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallMetricAnalysis? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallAccuracyAnalysis? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionAnalysis? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.HallucinationAnalysis? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.MetricResult>? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MetricResult? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<bool>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.TimeWindow>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TimeWindow? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.DayOfWeek>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DayOfWeek? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CancelTransferNode? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CancelTransferNodeVariant2? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CancelTransferNodeVariant2Type? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CancelTransferTool? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CancelTransferToolType? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CancelTransferToolExecutionMessageType? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChCallQA? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PreviewCallQA? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PreviewCallQAVariant2? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatAgentRequest? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.Language3?, global::System.Collections.Generic.IList<global::RetellAI.Language3>, global::RetellAI.ChatAgentRequestLanguage?>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatAgentRequestLanguage? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ChatAgentRequestWebhookEvent>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatAgentRequestWebhookEvent? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatAgentRequestDataStorageSetting? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.PostChatAnalysisData>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatHandbookConfig? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatAgentResponse? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatAgentResponseVariant1? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatAgentResponseVariant3? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatAnalysis? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatAnalysisUserSentiment? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatResponse? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatResponseChatStatus? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatResponseChatType? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<string, double?, bool?>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.MessageOrToolCall>? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MessageOrToolCall? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatResponseChatCost? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ProductCost>? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ProductCost? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3ChatResponse? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3ListChatsRequest? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilter? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3ListChatsRequestSortOrder? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CheckAvailabilityCalTool? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CheckAvailabilityCalToolType? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortAgent? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortAggregatedResult? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortAggregatedResultGroupBy? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CohortAggregatedResultTopQuestion>? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortAggregatedResultTopQuestion? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortFilter? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.AllOf<global::RetellAI.NumberFilter, global::RetellAI.CohortFilterStartTimestampVariant1>?, global::RetellAI.RangeFilter>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.NumberFilter, global::RetellAI.CohortFilterStartTimestampVariant1>? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NumberFilter? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortFilterStartTimestampVariant1? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortFilterStartTimestampVariant1Op? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RangeFilter? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CohortFilterDisconnectionReason>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortFilterDisconnectionReason? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DateRange? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortFilterCallDurationFilter? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortFilterCallDurationFilterOp? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Cohort? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ScoringCriteria? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortSuccessfulCriteria? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortSuccessfulCriteriaType? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortSuccessfulCriteriaOp? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortEvaluationMode? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ComponentNode? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeBaseCommon? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ComponentNodeVariant2? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ComponentNodeVariant2Type? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ComponentNodeVariant2ComponentType? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowComponentResponse? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowComponentRequest? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowComponentResponseVariant2? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Asset? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Note? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NoteDisplayPosition? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NoteSize? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowComponent? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.NodeTool>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTool? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Mcp>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Mcp? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ConversationFlowNode>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowNode? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowComponentBeginTagDisplayPosition? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Note>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationNode? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SubagentNode? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndNode? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FunctionNode? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CodeNode? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferCallNode? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PressDigitNode? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsNode? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ExtractDynamicVariablesNode? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MCPNode? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentOverrideConfig? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentOverrideConfigSttMode? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentOverrideConfigCustomSttConfig? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KBConfig? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowOverrideStartSpeaker? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowResponse? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlow? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowResponseVariant2? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowVariant2? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CreateConversationFlowComponentRequest>? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowVariant2BeginTagDisplayPosition? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationNodeVariant3? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationNodeVariant3Type? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SkipResponseEdge? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlwaysEdge? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.NodeFinetuneConversationExample>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeFinetuneConversationExample? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SubagentNodeVariant3? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SubagentNodeVariant3Type? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeInstructionPrompt? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Tool>? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Tool? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CpsConfig? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowRequest? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateOrganizationRequest? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateOrganizationRequestNew? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateOrganizationRequestOld? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateCreditTopupInvoiceRequest? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateCreditTopupInvoiceResponse? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateCreditTopupInvoicePendingResponse? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateCreditTopupInvoicePendingResponsePaymentStatus? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OptInCreditBasedRequest? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OptInCreditBasedResponse? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CustomMetricCriteria? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CustomTool? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CustomToolType? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CustomToolMethod? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolParameter? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CustomToolExecutionMessageType? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CustomToolParameterType? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CodeTool? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CodeToolType? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CodeToolExecutionMessageType? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DTMFUtterance? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DTMFUtteranceRole? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsUtterance? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsUtteranceRole? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.SmsMultimediaItem>? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsMultimediaItem? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.InjectedUtterance? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.InjectedUtteranceRole? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StringFilterType? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StringFilterOp? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NumberFilterType? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NumberFilterOp? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BooleanFilter? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BooleanFilterType? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BooleanFilterOp? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RangeFilterType? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RangeFilterOp? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EnumFilterType? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EnumFilterOp? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PresentFilter? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PresentFilterType? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PresentFilterOp? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ValueFilter? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CustomFieldFilterVariant2? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallFilter? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilter? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.StringFilter, global::RetellAI.EnumFilter>? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterCallStatus>? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterCallStatus? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CallFilterCallStatusValueItem>? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterCallStatusValueItem? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDisconnectionReason>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterDisconnectionReason? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterCallType>? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterCallType? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CallFilterCallTypeValueItem>? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterCallTypeValueItem? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDirection>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterDirection? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CallFilterDirectionValueItem>? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterDirectionValueItem? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterUserSentiment>? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterUserSentiment? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CallFilterUserSentimentValueItem>? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterUserSentimentValueItem? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDataStorageSetting>? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterDataStorageSetting? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CallFilterDataStorageSettingValueItem>? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterDataStorageSettingValueItem? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ToolCallFilter>? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StoredCallFilter? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StoredCallFilterVariant2? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterChatStatus>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterChatStatus? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ChatFilterChatStatusValueItem>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterChatStatusValueItem? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterDisconnectionReason>? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterDisconnectionReason? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterUserSentiment>? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterUserSentiment? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ChatFilterUserSentimentValueItem>? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterUserSentimentValueItem? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactFilter? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.StringFilter, global::RetellAI.PresentFilter>? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactsRequest? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactsRequestSortOrder? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Duration? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ElseEdgeVariant2? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ElseEdgeVariant2TransitionCondition? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ElseEdgeVariant2TransitionConditionType? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ElseEdgeVariant2TransitionConditionPrompt? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndCallTool? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndCallToolType? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndCallToolExecutionMessageType? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndNodeVariant2? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndNodeVariant2Type? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EnumAnalysisDataType? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EquationCondition? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EquationConditionType? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Equation>? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Equation? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EquationConditionOperator? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EquationOperator? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ExtractDynamicVariableTool? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ExtractDynamicVariableToolType? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AnalysisData>? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ExtractDynamicVariablesNodeVariant2? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ExtractDynamicVariablesNodeVariant2Type? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FinetuneExampleUtterance? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FinetuneExampleUtteranceVariant1? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FinetuneExampleUtteranceVariant1Role? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FinetuneExampleUtteranceVariant2? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FinetuneExampleUtteranceVariant2Role? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FinetuneExampleUtteranceVariant3? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FinetuneExampleUtteranceVariant3Role? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FunctionNodeVariant2? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FunctionNodeVariant2Type? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FunctionNodeVariant2ToolType? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CodeNodeVariant2? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CodeNodeVariant2Type? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GlobalNodeFinetuneTransitionExample? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.FinetuneExampleUtterance>? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GlobalNodeSetting? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.GlobalNodeFinetuneTransitionExample>? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.UtteranceHallucination>? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceHallucination? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Duration>? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseAddSourcesRequest? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.KnowledgeBaseAddSourcesRequestKnowledgeBaseText>? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseAddSourcesRequestKnowledgeBaseText? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseRequest? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.KnowledgeBaseRequestKnowledgeBaseText>? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseRequestKnowledgeBaseText? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseResponse? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseResponseStatus? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.OneOf<global::RetellAI.KnowledgeBaseSourceDocument, global::RetellAI.KnowledgeBaseSourceText, global::RetellAI.KnowledgeBaseSourceUrl>>? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.KnowledgeBaseSourceDocument, global::RetellAI.KnowledgeBaseSourceText, global::RetellAI.KnowledgeBaseSourceUrl>? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseSourceDocument? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseSourceText? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseSourceUrl? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseSourceDocumentType? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseSourceTextType? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseSourceUrlType? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MCPNodeVariant2? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MCPNodeVariant2Type? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MCPToolDefinition? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MCPTool? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MCPToolType? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MCPToolExecutionMessageType? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Message? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallInvocationMessage? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallResultMessage? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionMessage? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StateTransitionMessage? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.InjectedMessage? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsMessage? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatMessageInput? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MessageBase? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallInvocationMessageBase? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallResultMessageBase? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionMessageBase? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StateTransitionMessageBase? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.InjectedMessageBase? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsMessageBase? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MessageBaseRole? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.InjectedMessageBaseRole? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsMessageBaseRole? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.PerformanceMetricCriteria, global::RetellAI.CustomMetricCriteria>? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PerformanceMetricCriteria? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<double?, bool?, string>? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.UtteranceTranscriptionError>? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceTranscriptionError? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Wer? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.UtteranceTranscriptionErrorMieDetail>? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceTranscriptionErrorMieDetail? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ModelChoiceCascading? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ModelChoiceCascadingType? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ModelChoice? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NaturalnessIssue? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeBaseVariant2? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeBaseCommonDisplayPosition? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.PromptCondition, global::RetellAI.EquationCondition>? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PromptCondition? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeInstructionPromptType? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeInstructionStaticText? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeInstructionStaticTextType? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsInstructionTemplate? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsInstructionTemplateType? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsInstructionTemplateTemplate? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.CustomTool, global::RetellAI.CheckAvailabilityCalTool, global::RetellAI.BookAppointmentCalTool>? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeToolVariant2? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.NodeTransitionAnalysisDetail>? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionAnalysisDetail? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionMessageBaseRole? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionMessageBaseTransitionType? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionUtterance? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionUtteranceRole? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionUtteranceTransitionType? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NumberAnalysisDataType? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PresetAnalysisData? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PresetAnalysisDataType? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PresetAnalysisDataName? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallPresetAnalysisDataType? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallPresetAnalysisDataName? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatPresetAnalysisDataType? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatPresetAnalysisDataName? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Organization? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.OrganizationWebhookUrl>? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OrganizationWebhookUrl? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OrganizationCpsConfig? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AutoCreditReloadConfig? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorOverageConfig? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OrganizationResponse? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OrganizationResponseVariant2? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OrganizationResponseVariant2EnterprisePlanStatus? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PIIConfigMode? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.PIIConfigCategorie>? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PIIConfigCategorie? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.GuardrailConfigOutputTopic>? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GuardrailConfigOutputTopic? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.GuardrailConfigInputTopic>? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GuardrailConfigInputTopic? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PerformanceMetricCriteriaOp? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberResponse? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberResponsePhoneNumberType? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AgentWeight>? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberResponseSipOutboundTrunkConfig? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PressDigitNodeVariant2? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PressDigitNodeVariant2Type? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PressDigitTool? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PressDigitToolType? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PromptConditionType? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.QaViewFilter? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.QaViewFilterDisconnectionReason>? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.QaViewFilterDisconnectionReason? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<bool?, global::RetellAI.BooleanFilter>? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.QaViewFilterScoreRange? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.QaViewFilterScoreRangeType? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.QaViewFilterScoreRangeOp? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortQaListArgs? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortQaListArgsSortKey? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortQaListArgsOrder? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RAGAccuracy? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.RAGAccuracyMissedChunk>? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RAGAccuracyMissedChunk? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.RAGAccuracy>? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ResponseEngineConversationFlow? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ResponseEngineConversationFlowType? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ResponseEngineCustomLm? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ResponseEngineCustomLmType? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ResponseEngineRetellLm? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ResponseEngineRetellLmType? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellResponseEngine? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellLLMResponse? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellLLMResponseVariant1? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellLlmRequest? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellLLMResponseVariant3? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellLlmOverrideS2sModel? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellLlmOverrideStartSpeaker? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellLlmRequestVariant2? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.State>? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.State? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ScoringCriteriaCustomCondition>? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ScoringCriteriaCustomCondition? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.PerformanceMetricCriteria>? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SendSMSTool? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SendSMSToolType? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SendSMSToolExecutionMessageType? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsContent? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSender? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSenderVariant1? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSenderVariant1Type? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSenderVariant2? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSenderVariant2Type? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsDestination? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsDestinationVariant1? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsDestinationVariant1Type? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsDestinationVariant2? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsDestinationVariant2Type? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.OneOf<global::RetellAI.SentimentAnalysisDetailVariant1, global::RetellAI.SentimentAnalysisDetailVariant2>>? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.SentimentAnalysisDetailVariant1, global::RetellAI.SentimentAnalysisDetailVariant2>? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SentimentAnalysisDetailVariant1? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SentimentAnalysisDetailVariant1Sentiment? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SentimentAnalysisDetailVariant2? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SentimentAnalysisDetailVariant2Sentiment? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SkipResponseEdgeVariant2? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SkipResponseEdgeVariant2TransitionCondition? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SkipResponseEdgeVariant2TransitionConditionType? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SkipResponseEdgeVariant2TransitionConditionPrompt? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlwaysEdgeVariant2? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlwaysEdgeVariant2TransitionCondition? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlwaysEdgeVariant2TransitionConditionType? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlwaysEdgeVariant2TransitionConditionPrompt? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsContentInferred? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsContentInferredType? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsContentPredefined? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsContentPredefinedType? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsContentTemplate? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsContentTemplateType? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsContentTemplateTemplate? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsFailedEdge? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsFailedEdgeVariant2? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsFailedEdgeVariant2TransitionCondition? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsFailedEdgeVariant2TransitionConditionType? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsFailedEdgeVariant2TransitionConditionPrompt? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsNodeVariant2? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsNodeVariant2Type? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.NodeInstruction?, global::RetellAI.SmsInstructionTemplate>? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSuccessEdge? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSuccessEdgeVariant2? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSuccessEdgeVariant2TransitionCondition? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionType? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionPrompt? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StateEdge? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StateTransitionMessageBaseRole? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.StateEdge>? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StringAnalysisDataType? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseBatchJob? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseBatchJobStatus? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseDefinitionInput? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ToolMock>? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolMock? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseDefinition? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseDefinitionVariant2? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseDefinitionVariant2Type? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseJob? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseJobStatus? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolMockInputMatchRule? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolMockInputMatchRuleVariant1? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolMockInputMatchRuleVariant1Type? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolMockInputMatchRuleVariant2? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolMockInputMatchRuleVariant2Type? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.UtteranceToolCallAccuracy>? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceToolCallAccuracy? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallInvocationMessageBaseRole? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallInvocationUtterance? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallInvocationUtteranceRole? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallResultMessageBaseRole? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallResultUtterance? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallResultUtteranceRole? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolParameterType? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferCallTool? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferCallNodeVariant2? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferCallNodeVariant2Type? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferDestination? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOption? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferCallToolType? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferCallToolExecutionMessageType? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferDestinationInferred? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferDestinationInferredType? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferDestinationPredefined? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferDestinationPredefinedType? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferFailedEdgeVariant2? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferFailedEdgeVariant2TransitionCondition? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferFailedEdgeVariant2TransitionConditionType? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferFailedEdgeVariant2TransitionConditionPrompt? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionAgenticWarmTransfer? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionAgenticWarmTransferType? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionAgenticWarmTransferOnHoldMusic? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.WarmTransferPrompt, global::RetellAI.WarmTransferStaticMessage>? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.WarmTransferPrompt? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.WarmTransferStaticMessage? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionAgenticWarmTransferAgenticTransferConfig? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionAgenticWarmTransferAgenticTransferConfigTransferAgent? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeout? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionColdTransfer? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionColdTransferType? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionColdTransferColdTransferMode? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionWarmTransfer? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionWarmTransferType? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionWarmTransferOnHoldMusic? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateOrganizationRequest? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateOrganizationRequestAutoCreditReloadConfig? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SpendBudgetCustomAlertRequest? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateSpendBudgetRequest? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateSpendBudgetRequestVariant1? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateSpendBudgetRequestVariant2? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.SpendBudgetCustomAlertRequest>? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UserFormRequest? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceHallucinationHallucinationType? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.NaturalnessIssue>? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceOrToolCall? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Utterance? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceRole? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.UtteranceWord>? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceWord? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2CallBase? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2CallBaseCallStatus? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2CallBaseDataStorageSetting? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Utterance>? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.UtteranceOrToolCall>? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2CallBaseLatency? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2CallBaseCallCost? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2CallBaseLlmTokenUsage? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2CallResponse? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2WebCallResponse? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2PhoneCallResponse? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallTransport? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.IceServer? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<string, global::System.Collections.Generic.IList<string>>? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponse? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.IceServer>? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CallResponse? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3WebCallResponse? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3PhoneCallResponse? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CreateWebCallResponse? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CreateWebCallResponseTransport? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CallBase? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CallBaseCallStatus? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CallBaseDataStorageSetting? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CallBaseLatency? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CallBaseCallCost? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CallBaseLlmTokenUsage? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3PhoneCallResponseVariant1? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3PhoneCallResponseVariant1CallType? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3PhoneCallResponseVariant1Direction? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3PhoneCallResponseVariant1TelephonyIdentifier? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3WebCallResponseVariant1? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3WebCallResponseVariant1CallType? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3ListCallsRequest? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3ListCallsRequestSortOrder? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2PhoneCallResponseVariant1? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2PhoneCallResponseVariant1CallType? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2PhoneCallResponseVariant1Direction? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2PhoneCallResponseVariant1TelephonyIdentifier? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2WebCallResponseVariant1? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2WebCallResponseVariant1CallType? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoiceResponse? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoiceResponseProvider? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoiceResponseGender? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionBridgeTransfer? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionBridgeTransferType? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionHangup? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionHangupType? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionPrompt? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionPromptType? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionStaticText? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionStaticTextType? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.IvrActionHangup? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.IvrActionHangupType? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.IvrAction? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.WarmTransferPromptType? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.WarmTransferStaticMessageType? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorOverageConfigVariant1? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorOverageConfigVariant1Mode? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorOverageConfigVariant2? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorOverageConfigVariant2Mode? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorOverageConfigVariant3? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorOverageConfigVariant3Mode? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Contact? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactListResponse? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactListResponseVariant2? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Contact>? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactConversation? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactCall? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactChat? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactCallType? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactCallDirection? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactCallSentiment? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactChatType? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactChatDirection? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactChatSentiment? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactConversationListResponse? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactConversationListResponseVariant2? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ContactConversation>? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppType? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppConnectionStatus? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OAuthConfigRequest? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OAuthConfigRequestType? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ApiKeyAuthConfigRequest? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ApiKeyAuthConfigRequestType? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BasicAuthConfigRequest? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BasicAuthConfigRequestType? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AuthConfigRequest? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OAuthConfigResponse? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OAuthConfigResponseType? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ApiKeyAuthConfigResponse? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ApiKeyAuthConfigResponseType? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AccessTokenAuthConfigResponse? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AccessTokenAuthConfigResponseType? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BasicAuthConfigResponse? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BasicAuthConfigResponseType? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RefreshTokenAuthConfigResponse? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RefreshTokenAuthConfigResponseType? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppAuthConfigResponse? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CRMSyncMapping? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppCRMConfig? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CRMSyncMapping>? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppResponse? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppResponseTenantType? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppUsageResponse? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentAppUsage? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseAppUsage? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentAppUsageType? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseAppUsageType? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CRMCustomFieldSchema? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CRMCustomFieldSchemaType? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CRMAnalysisDataMapping? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CRMAnalysisDataMappingUpdateMode? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CRMConfig? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CRMCustomFieldSchema>? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CRMAnalysisDataMapping>? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.JobStatus? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.JobStatusStatus? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.JobStatusTriggeredBy? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartGroupType? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DashboardSource? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartGroupItem? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartGroupItemVariant1? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartGroupItemVariant1Type? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartGroupItemVariant2? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartGroupItemVariant2Type? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItem? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemKeywordSource? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemKeywordSourceSource? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemKeywordSourceSourceType? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemKeywordSourceMeasurement? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemKeywordSourceMeasurementType? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemNumericSource? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemNumericSourceSource? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemNumericSourceSourceType? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemNumericSourceMeasurement? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemNumericSourceMeasurementType? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomFieldSource? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomFieldSourceSource? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomFieldSourceSourceType? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomFieldSourceSourceCast? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomFieldSourceMeasurement? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomFieldSourceMeasurementType? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemConcurrencySource? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemConcurrencySourceSource? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemConcurrencySourceSourceType? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemConcurrencySourceMeasurement? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemConcurrencySourceMeasurementType? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomToolSource? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomToolSourceSource? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomToolSourceSourceType? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomToolSourceMeasurement? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomToolSourceMeasurementType? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRange? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant1? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant1Type? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant1Window? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant1WindowUnit? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant2? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant2Type? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant3? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant3Type? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant3Unit? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant4? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant4Type? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant5? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant5Type? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartConfig? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartConfigType? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartConfigSize? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ChartShowItem>? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ChartGroupItem>? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AnyOf<global::RetellAI.StoredCallFilter?, global::RetellAI.ChatFilter>? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartConfigUnit? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartDefinition? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartConfigWithId? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartsMap? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartUpdate? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartUpdateVariant2? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartUpdateVariant2Size? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartUpdatesMap? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.ChartUpdate?, object>? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DashboardUpdateRequest? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.AgentRequest, object>? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchCallRequest? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.BatchCallTask>? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchTestRequest? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.TestCaseDefinitionInput, object>? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.ChatAgentRequest, object>? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionRequest? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ChatMessageInput>? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionRequest? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatRequest? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAssetRequest? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneNumberRequest? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneNumberRequestNumberProvider? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneNumberRequestCountryCode? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateSmsChatRequest? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CloneVoiceRequest? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CloneVoiceRequestVoiceProvider? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddCommunityVoiceRequest? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddCommunityVoiceRequestVoiceProvider? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceRequest? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceRequestVoiceProvider? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ImportPhoneNumberRequest? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsRequest? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatMetadataRequest? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatMetadataRequestDataStorageSetting? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdatePhoneNumberRequest? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneCallRequest? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateCreateWebCallRequest? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateWebCallRequest? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallRequest? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RegisterPhoneCallRequest? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RegisterPhoneCallRequestDirection? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCallMetadataRequest? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCallMetadataRequestDataStorageSetting? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallRequest? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallRequestFieldsToOverride? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallRequestFieldsToOverrideDataStorageSetting? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallRequestCallControl? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactRequest? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UploadContactImportFileRequest? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactImportRequest? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateContactRequest? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAppRequest? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAppRequest? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCrmConfigRequest? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackfillContactAnalysisDataRequest? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackfillContactAnalysisDataRequestBackfillCallFilter? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestCaseDefinitionsType? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListBatchTestsType? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsSortOrder? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsSortOrder? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowComponentsSortOrder? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsSortOrder? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListPhoneNumbersSortOrder? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMSortOrder? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsSortOrder? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppsSortOrder? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppUsagesSortOrder? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddKnowledgeBaseSourcesResponse? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddKnowledgeBaseSourcesResponseStatus? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddKnowledgeBaseSourcesResponse2? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddKnowledgeBaseSourcesResponseStatus2? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddKnowledgeBaseSourcesResponse3? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddKnowledgeBaseSourcesResponseStatus3? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddKnowledgeBaseSourcesResponse4? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddKnowledgeBaseSourcesResponseStatus4? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddKnowledgeBaseSourcesResponse5? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddKnowledgeBaseSourcesResponseStatus5? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentResponse? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentResponseStatus? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentResponse2? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentResponseStatus2? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentResponse3? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentResponseStatus3? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentResponse4? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentResponseStatus4? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchCallResponse? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchCallResponseStatus? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchCallResponse2? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchCallResponseStatus2? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchCallResponse3? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchCallResponseStatus3? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchCallResponse4? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchCallResponseStatus4? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchTestResponse? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchTestResponseStatus? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchTestResponse2? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchTestResponseStatus2? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchTestResponse3? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchTestResponseStatus3? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchTestResponse4? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchTestResponseStatus4? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchTestResponse5? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchTestResponseStatus5? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateTestCaseDefinitionResponse? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateTestCaseDefinitionResponseStatus? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateTestCaseDefinitionResponse2? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateTestCaseDefinitionResponseStatus2? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateTestCaseDefinitionResponse3? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateTestCaseDefinitionResponseStatus3? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateTestCaseDefinitionResponse4? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateTestCaseDefinitionResponseStatus4? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateTestCaseDefinitionResponse5? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateTestCaseDefinitionResponseStatus5? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteTestCaseDefinitionResponse? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteTestCaseDefinitionResponseStatus? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteTestCaseDefinitionResponse2? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteTestCaseDefinitionResponseStatus2? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteTestCaseDefinitionResponse3? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteTestCaseDefinitionResponseStatus3? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteTestCaseDefinitionResponse4? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteTestCaseDefinitionResponseStatus4? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteTestCaseDefinitionResponse5? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteTestCaseDefinitionResponseStatus5? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestCaseDefinitionResponse? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestCaseDefinitionResponseStatus? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestCaseDefinitionResponse2? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestCaseDefinitionResponseStatus2? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestCaseDefinitionResponse3? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestCaseDefinitionResponseStatus3? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestCaseDefinitionResponse4? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestCaseDefinitionResponseStatus4? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestCaseDefinitionResponse5? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestCaseDefinitionResponseStatus5? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListTestCaseDefinitionsResponse2>? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestCaseDefinitionsResponse2? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.TestCaseDefinition>? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestCaseDefinitionsResponse3? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestCaseDefinitionsResponseStatus? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestCaseDefinitionsResponse4? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestCaseDefinitionsResponseStatus2? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestCaseDefinitionsResponse5? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestCaseDefinitionsResponseStatus3? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestCaseDefinitionsResponse6? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestCaseDefinitionsResponseStatus4? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateTestCaseDefinitionResponse? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateTestCaseDefinitionResponseStatus? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateTestCaseDefinitionResponse2? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateTestCaseDefinitionResponseStatus2? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateTestCaseDefinitionResponse3? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateTestCaseDefinitionResponseStatus3? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateTestCaseDefinitionResponse4? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateTestCaseDefinitionResponseStatus4? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateTestCaseDefinitionResponse5? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateTestCaseDefinitionResponseStatus5? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetBatchTestResponse? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetBatchTestResponseStatus? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetBatchTestResponse2? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetBatchTestResponseStatus2? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetBatchTestResponse3? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetBatchTestResponseStatus3? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetBatchTestResponse4? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetBatchTestResponseStatus4? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetBatchTestResponse5? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetBatchTestResponseStatus5? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListBatchTestsResponse2>? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListBatchTestsResponse2? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.TestCaseBatchJob>? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListBatchTestsResponse3? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListBatchTestsResponseStatus? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListBatchTestsResponse4? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListBatchTestsResponseStatus2? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListBatchTestsResponse5? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListBatchTestsResponseStatus3? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListBatchTestsResponse6? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListBatchTestsResponseStatus4? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestRunResponse? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestRunResponseStatus? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestRunResponse2? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestRunResponseStatus2? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestRunResponse3? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestRunResponseStatus3? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestRunResponse4? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestRunResponseStatus4? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestRunResponse5? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestRunResponseStatus5? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListTestRunsResponse2>? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponse2? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.TestCaseJob>? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponse3? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponseStatus? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponse4? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponseStatus2? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponse5? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponseStatus3? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponse6? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponseStatus4? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponse7? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponseStatus5? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatAgentResponse? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatAgentResponseStatus? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatAgentResponse2? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatAgentResponseStatus2? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatAgentResponse3? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatAgentResponseStatus3? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatAgentResponse4? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatAgentResponseStatus4? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponse? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponse2? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponseStatus? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponse3? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponseStatus2? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponse4? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponseStatus3? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponse5? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponseStatus4? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponse6? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponseStatus5? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponse7? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponseStatus6? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponse? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponse2? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponseStatus? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponse3? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponseStatus2? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponse4? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponseStatus3? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponse5? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponseStatus4? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponse6? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponseStatus5? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponse7? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponseStatus6? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatResponse? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatResponseStatus? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatResponse2? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatResponseStatus2? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatResponse3? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatResponseStatus3? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatResponse4? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatResponseStatus4? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatResponse5? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatResponseStatus5? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatResponse6? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatResponseStatus6? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowComponentResponse? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowComponentResponseStatus? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowComponentResponse2? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowComponentResponseStatus2? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowComponentResponse3? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowComponentResponseStatus3? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowComponentResponse4? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowComponentResponseStatus4? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowComponentResponse5? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowComponentResponseStatus5? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowResponse? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowResponseStatus? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowResponse2? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowResponseStatus2? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowResponse3? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowResponseStatus3? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowResponse4? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowResponseStatus4? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowResponse5? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowResponseStatus5? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAssetResponse? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAssetResponseStatus? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAssetResponse2? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAssetResponseStatus2? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAssetResponse3? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAssetResponseStatus3? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAssetResponse4? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAssetResponseStatus4? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateKnowledgeBaseResponse? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateKnowledgeBaseResponseStatus? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateKnowledgeBaseResponse2? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateKnowledgeBaseResponseStatus2? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateKnowledgeBaseResponse3? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateKnowledgeBaseResponseStatus3? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateKnowledgeBaseResponse4? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateKnowledgeBaseResponseStatus4? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateKnowledgeBaseResponse5? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateKnowledgeBaseResponseStatus5? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneNumberResponse? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneNumberResponseStatus? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneNumberResponse2? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneNumberResponseStatus2? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneNumberResponse3? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneNumberResponseStatus3? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateRetellLLMResponse? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateRetellLLMResponseStatus? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateRetellLLMResponse2? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateRetellLLMResponseStatus2? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateRetellLLMResponse3? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateRetellLLMResponseStatus3? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateSmsChatResponse? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateSmsChatResponseStatus? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateSmsChatResponse2? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateSmsChatResponseStatus2? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateSmsChatResponse3? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateSmsChatResponseStatus3? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateSmsChatResponse4? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateSmsChatResponseStatus4? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateSmsChatResponse5? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateSmsChatResponseStatus5? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateSmsChatResponse6? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateSmsChatResponseStatus6? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentResponse? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentResponseStatus? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentResponse2? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentResponseStatus2? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentResponse3? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentResponseStatus3? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentResponse4? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentResponseStatus4? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteChatResponse? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteChatResponseStatus? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteChatResponse2? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteChatResponseStatus2? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteChatResponse3? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteChatResponseStatus3? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteChatResponse4? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteChatResponseStatus4? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteChatAgentResponse? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteChatAgentResponseStatus? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteChatAgentResponse2? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteChatAgentResponseStatus2? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteChatAgentResponse3? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteChatAgentResponseStatus3? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteChatAgentResponse4? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteChatAgentResponseStatus4? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowComponentResponse? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowComponentResponseStatus? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowComponentResponse2? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowComponentResponseStatus2? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowComponentResponse3? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowComponentResponseStatus3? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowComponentResponse4? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowComponentResponseStatus4? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowResponse? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowResponseStatus? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowResponse2? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowResponseStatus2? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowResponse3? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowResponseStatus3? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowResponse4? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowResponseStatus4? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowResponse5? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowResponseStatus5? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteKnowledgeBaseSourceResponse? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteKnowledgeBaseSourceResponse2? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus2? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteKnowledgeBaseSourceResponse3? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus3? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteKnowledgeBaseSourceResponse4? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus4? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteKnowledgeBaseResponse? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteKnowledgeBaseResponseStatus? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteKnowledgeBaseResponse2? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteKnowledgeBaseResponseStatus2? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteKnowledgeBaseResponse3? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteKnowledgeBaseResponseStatus3? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteKnowledgeBaseResponse4? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteKnowledgeBaseResponseStatus4? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeletePhoneNumberResponse? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeletePhoneNumberResponseStatus? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeletePhoneNumberResponse2? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeletePhoneNumberResponseStatus2? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeletePhoneNumberResponse3? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeletePhoneNumberResponseStatus3? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteRetellLLMResponse? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteRetellLLMResponseStatus? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteRetellLLMResponse2? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteRetellLLMResponseStatus2? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteRetellLLMResponse3? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteRetellLLMResponseStatus3? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteRetellLLMResponse4? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteRetellLLMResponseStatus4? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndChatResponse? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndChatResponseStatus? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndChatResponse2? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndChatResponseStatus2? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndChatResponse3? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndChatResponseStatus3? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndChatResponse4? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndChatResponseStatus4? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAgentVersionsResponse2>? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponse2? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AgentVersionSummary>? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponse3? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponseStatus? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponse4? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponseStatus2? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponse5? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponseStatus3? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponse6? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponseStatus4? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponse7? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponseStatus5? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponse8? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponseStatus6? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AgentResponse>? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAgentVersionsResponse? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAgentVersionsResponseStatus? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAgentVersionsResponse2? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAgentVersionsResponseStatus2? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAgentVersionsResponse3? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAgentVersionsResponseStatus3? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAgentVersionsResponse4? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAgentVersionsResponseStatus4? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAgentResponse? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAgentResponseStatus? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAgentResponse2? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAgentResponseStatus2? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAgentResponse3? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAgentResponseStatus3? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAgentResponse4? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAgentResponseStatus4? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ChatAgentResponse>? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatAgentVersionsResponse? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatAgentVersionsResponseStatus? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatAgentVersionsResponse2? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatAgentVersionsResponseStatus2? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatAgentVersionsResponse3? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatAgentVersionsResponseStatus3? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatAgentResponse? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatAgentResponseStatus? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatAgentResponse2? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatAgentResponseStatus2? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatAgentResponse3? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatAgentResponseStatus3? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatAgentResponse4? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatAgentResponseStatus4? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatResponse? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatResponseStatus? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatResponse2? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatResponseStatus2? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatResponse3? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatResponseStatus3? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatResponse4? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatResponseStatus4? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConcurrencyResponse? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConcurrencyResponse2? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConcurrencyResponseStatus? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConcurrencyResponse3? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConcurrencyResponseStatus2? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetApiKeyInfoResponse? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetApiKeyInfoResponse2? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetApiKeyInfoResponseStatus? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetApiKeyInfoResponse3? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetApiKeyInfoResponseStatus2? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowComponentResponse? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowComponentResponseStatus? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowComponentResponse2? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowComponentResponseStatus2? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowComponentResponse3? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowComponentResponseStatus3? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowComponentResponse4? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowComponentResponseStatus4? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowResponse? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowResponseStatus? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowResponse2? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowResponseStatus2? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowResponse3? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowResponseStatus3? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowResponse4? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowResponseStatus4? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowResponse5? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowResponseStatus5? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetKnowledgeBaseResponse? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetKnowledgeBaseResponseStatus? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetKnowledgeBaseResponse2? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetKnowledgeBaseResponseStatus2? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetKnowledgeBaseResponse3? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetKnowledgeBaseResponseStatus3? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetKnowledgeBaseResponse4? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetKnowledgeBaseResponseStatus4? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.MCPToolDefinition>? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetMCPToolsResponse? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetMCPToolsResponseStatus? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetMCPToolsResponse2? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetMCPToolsResponseStatus2? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetMCPToolsResponse3? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetMCPToolsResponseStatus3? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetMCPToolsResponse4? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetMCPToolsResponseStatus4? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetPhoneNumberResponse? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetPhoneNumberResponseStatus? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetPhoneNumberResponse2? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetPhoneNumberResponseStatus2? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetPhoneNumberResponse3? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetPhoneNumberResponseStatus3? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetPhoneNumberResponse4? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetPhoneNumberResponseStatus4? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetRetellLLMResponse? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetRetellLLMResponseStatus? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetRetellLLMResponse2? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetRetellLLMResponseStatus2? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetRetellLLMResponse3? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetRetellLLMResponseStatus3? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetRetellLLMResponse4? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetRetellLLMResponseStatus4? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetVoiceResponse? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetVoiceResponseStatus? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetVoiceResponse2? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetVoiceResponseStatus2? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetVoiceResponse3? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetVoiceResponseStatus3? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetVoiceResponse4? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetVoiceResponseStatus4? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CloneVoiceResponse? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CloneVoiceResponseStatus? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CloneVoiceResponse2? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CloneVoiceResponseStatus2? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CloneVoiceResponse3? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CloneVoiceResponseStatus3? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CloneVoiceResponse4? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CloneVoiceResponseStatus4? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CloneVoiceResponse5? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CloneVoiceResponseStatus5? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddCommunityVoiceResponse? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddCommunityVoiceResponseStatus? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddCommunityVoiceResponse2? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddCommunityVoiceResponseStatus2? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddCommunityVoiceResponse3? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddCommunityVoiceResponseStatus3? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddCommunityVoiceResponse4? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddCommunityVoiceResponseStatus4? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceResponse? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.SearchCommunityVoiceResponseVoice>? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceResponseVoice? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceResponse2? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceResponseStatus? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceResponse3? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceResponseStatus2? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceResponse4? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceResponseStatus3? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceResponse5? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceResponseStatus4? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ImportPhoneNumberResponse? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ImportPhoneNumberResponseStatus? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ImportPhoneNumberResponse2? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ImportPhoneNumberResponseStatus2? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ImportPhoneNumberResponse3? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ImportPhoneNumberResponseStatus3? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAgentsResponse2>? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsResponse2? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AgentListItemResponse>? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsResponse3? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsResponseStatus? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsResponse4? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsResponseStatus2? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsResponse5? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsResponseStatus3? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsResponse6? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsResponseStatus4? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListChatsResponse2>? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListChatsResponse2? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.V3ChatResponse>? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListChatsResponse3? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListChatsResponseStatus? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListChatsResponse4? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListChatsResponseStatus2? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListChatsResponse5? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListChatsResponseStatus3? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListChatsResponse6? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListChatsResponseStatus4? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowComponentsResponse2>? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowComponentsResponse2? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ConversationFlowComponentResponse>? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowComponentsResponse3? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowComponentsResponseStatus? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowComponentsResponse4? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowComponentsResponseStatus2? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowComponentsResponse5? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowComponentsResponseStatus3? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowComponentsResponse6? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowComponentsResponseStatus4? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowsResponse2>? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponse2? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ConversationFlowResponse>? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponse3? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponseStatus? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponse4? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponseStatus2? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponse5? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponseStatus3? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponse6? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponseStatus4? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponse7? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponseStatus5? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.KnowledgeBaseResponse>? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListKnowledgeBasesResponse? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListKnowledgeBasesResponseStatus? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListKnowledgeBasesResponse2? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListKnowledgeBasesResponseStatus2? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListKnowledgeBasesResponse3? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListKnowledgeBasesResponseStatus3? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListPhoneNumbersResponse2>? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListPhoneNumbersResponse2? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.PhoneNumberResponse>? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListPhoneNumbersResponse3? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListPhoneNumbersResponseStatus? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListPhoneNumbersResponse4? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListPhoneNumbersResponseStatus2? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListRetellLLMResponse2>? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponse2? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.RetellLLMResponse>? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponse3? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponseStatus? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponse4? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponseStatus2? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponse5? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponseStatus3? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponse6? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponseStatus4? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponse7? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponseStatus5? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.VoiceResponse>? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListVoicesResponse? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListVoicesResponseStatus? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListVoicesResponse2? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListVoicesResponseStatus2? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.AgentResponse?, global::RetellAI.ChatAgentResponse?>? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentVersionResponse2? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentVersionResponseStatus? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentVersionResponse3? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentVersionResponseStatus2? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentVersionResponse4? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentVersionResponseStatus3? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentVersionResponse5? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentVersionResponseStatus4? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentVersionResponse6? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentVersionResponseStatus5? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PublishAgentVersionResponse? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PublishAgentVersionResponseStatus? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PublishAgentVersionResponse2? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PublishAgentVersionResponseStatus2? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PublishAgentVersionResponse3? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PublishAgentVersionResponseStatus3? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PublishAgentVersionResponse4? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PublishAgentVersionResponseStatus4? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PublishAgentVersionResponse5? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PublishAgentVersionResponseStatus5? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentVersionResponse? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentVersionResponseStatus? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentVersionResponse2? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentVersionResponseStatus2? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentVersionResponse3? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentVersionResponseStatus3? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentVersionResponse4? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentVersionResponseStatus4? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentVersionResponse5? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentVersionResponseStatus5? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunCallAnalysisResponse? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunCallAnalysisResponseStatus? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunCallAnalysisResponse2? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunCallAnalysisResponseStatus2? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunCallAnalysisResponse3? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunCallAnalysisResponseStatus3? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunCallAnalysisResponse4? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunCallAnalysisResponseStatus4? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunCallAnalysisResponse5? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunCallAnalysisResponseStatus5? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunCallAnalysisResponse6? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunCallAnalysisResponseStatus6? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunCallAnalysisResponse7? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunCallAnalysisResponseStatus7? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunChatAnalysisResponse? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunChatAnalysisResponseStatus? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunChatAnalysisResponse2? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunChatAnalysisResponseStatus2? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunChatAnalysisResponse3? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunChatAnalysisResponseStatus3? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunChatAnalysisResponse4? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunChatAnalysisResponseStatus4? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunChatAnalysisResponse5? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunChatAnalysisResponseStatus5? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunChatAnalysisResponse6? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunChatAnalysisResponseStatus6? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunChatAnalysisResponse7? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunChatAnalysisResponseStatus7? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAgentResponse? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAgentResponseStatus? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAgentResponse2? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAgentResponseStatus2? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAgentResponse3? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAgentResponseStatus3? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAgentResponse4? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAgentResponseStatus4? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAgentResponse5? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAgentResponseStatus5? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RepairAgentResponse2? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RepairAgentResponseStatus? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RepairAgentResponse3? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RepairAgentResponseStatus2? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RepairAgentResponse4? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RepairAgentResponseStatus3? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RepairAgentResponse5? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RepairAgentResponseStatus4? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RepairAgentResponse6? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RepairAgentResponseStatus5? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatAgentResponse? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatAgentResponseStatus? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatAgentResponse2? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatAgentResponseStatus2? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatAgentResponse3? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatAgentResponseStatus3? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatAgentResponse4? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatAgentResponseStatus4? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatAgentResponse5? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatAgentResponseStatus5? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatMetadataResponse? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatMetadataResponseStatus? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatMetadataResponse2? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatMetadataResponseStatus2? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatMetadataResponse3? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatMetadataResponseStatus3? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatMetadataResponse4? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatMetadataResponseStatus4? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowComponentResponse? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowComponentResponseStatus? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowComponentResponse2? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowComponentResponseStatus2? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowComponentResponse3? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowComponentResponseStatus3? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowComponentResponse4? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowComponentResponseStatus4? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowComponentResponse5? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowComponentResponseStatus5? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowComponentResponse6? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowComponentResponseStatus6? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowResponse? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowResponseStatus? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowResponse2? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowResponseStatus2? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowResponse3? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowResponseStatus3? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowResponse4? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowResponseStatus4? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowResponse5? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowResponseStatus5? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowResponse6? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowResponseStatus6? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdatePhoneNumberResponse? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdatePhoneNumberResponseStatus? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdatePhoneNumberResponse2? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdatePhoneNumberResponseStatus2? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdatePhoneNumberResponse3? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdatePhoneNumberResponseStatus3? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdatePhoneNumberResponse4? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdatePhoneNumberResponseStatus4? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateRetellLLMResponse? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateRetellLLMResponseStatus? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateRetellLLMResponse2? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateRetellLLMResponseStatus2? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateRetellLLMResponse3? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateRetellLLMResponseStatus3? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateRetellLLMResponse4? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateRetellLLMResponseStatus4? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateRetellLLMResponse5? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateRetellLLMResponseStatus5? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneCallResponse? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneCallResponseStatus? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneCallResponse2? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneCallResponseStatus2? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneCallResponse3? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneCallResponseStatus3? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneCallResponse4? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneCallResponseStatus4? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneCallResponse5? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneCallResponseStatus5? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneCallResponse6? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneCallResponseStatus6? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateCreateWebCallResponse? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateCreateWebCallResponseStatus? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateCreateWebCallResponse2? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateCreateWebCallResponseStatus2? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateCreateWebCallResponse3? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateCreateWebCallResponseStatus3? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateCreateWebCallResponse4? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateCreateWebCallResponseStatus4? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateCreateWebCallResponse5? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateCreateWebCallResponseStatus5? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateCreateWebCallResponse6? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateCreateWebCallResponseStatus6? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateWebCallResponse? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateWebCallResponseStatus? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateWebCallResponse2? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateWebCallResponseStatus2? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateWebCallResponse3? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateWebCallResponseStatus3? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateWebCallResponse4? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateWebCallResponseStatus4? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateWebCallResponse5? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateWebCallResponseStatus5? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateWebCallResponse6? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateWebCallResponseStatus6? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteCallResponse? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteCallResponseStatus? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteCallResponse2? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteCallResponseStatus2? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteCallResponse3? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteCallResponseStatus3? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteCallResponse4? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteCallResponseStatus4? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCallResponse? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCallResponseStatus? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCallResponse2? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCallResponseStatus2? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCallResponse3? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCallResponseStatus3? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCallResponse4? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCallResponseStatus4? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponse2? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponseStatus? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponse3? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponseStatus2? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponse4? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponseStatus3? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponse5? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponseStatus4? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponse6? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponseStatus5? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponse? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponse2? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponseStatus? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponse3? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponseStatus2? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponse4? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponseStatus3? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponse5? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponseStatus4? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponse6? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponseStatus5? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListCallsResponse2>? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListCallsResponse2? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.V3CallResponse>? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListCallsResponse3? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListCallsResponseStatus? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListCallsResponse4? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListCallsResponseStatus2? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListCallsResponse5? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListCallsResponseStatus3? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListCallsResponse6? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListCallsResponseStatus4? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListExportRequestsResponse2>? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponse2? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ListExportRequestsResponseItem>? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponseItem? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponseItemChannel? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponseItemStatus? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponse3? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponseStatus? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponse4? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponseStatus2? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponse5? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponseStatus3? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponse6? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponseStatus4? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RegisterPhoneCallResponse? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RegisterPhoneCallResponseStatus? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RegisterPhoneCallResponse2? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RegisterPhoneCallResponseStatus2? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RegisterPhoneCallResponse3? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RegisterPhoneCallResponseStatus3? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RegisterPhoneCallResponse4? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RegisterPhoneCallResponseStatus4? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RegisterPhoneCallResponse5? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RegisterPhoneCallResponseStatus5? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RegisterPhoneCallResponse6? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RegisterPhoneCallResponseStatus6? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCallMetadataResponse? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCallMetadataResponseStatus? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCallMetadataResponse2? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCallMetadataResponseStatus2? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCallMetadataResponse3? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCallMetadataResponseStatus3? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCallMetadataResponse4? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCallMetadataResponseStatus4? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponse? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponse2? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponseStatus? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponse3? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponseStatus2? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponse4? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponseStatus3? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponse5? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponseStatus4? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponse6? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponseStatus5? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StopCallResponse? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StopCallResponseStatus? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StopCallResponse2? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StopCallResponseStatus2? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StopCallResponse3? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StopCallResponseStatus3? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StopCallResponse4? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StopCallResponseStatus4? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactResponse? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactResponseStatus? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactResponse2? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactResponseStatus2? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactResponse3? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactResponseStatus3? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactResponse4? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactResponseStatus4? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UploadContactImportFileResponse? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UploadContactImportFileResponse2? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UploadContactImportFileResponseStatus? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UploadContactImportFileResponse3? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UploadContactImportFileResponseStatus2? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UploadContactImportFileResponse4? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UploadContactImportFileResponseStatus3? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UploadContactImportFileResponse5? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UploadContactImportFileResponseStatus4? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactImportResponse? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactImportResponseStatus? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactImportResponse2? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactImportResponseStatus2? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactImportResponse3? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactImportResponseStatus3? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactImportResponse4? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactImportResponseStatus4? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactImportResponse5? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactImportResponseStatus5? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactImportResponse? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactImportResponseStatus? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactImportResponse2? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactImportResponseStatus2? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactImportResponse3? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactImportResponseStatus3? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactResponse? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactResponseStatus? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactResponse2? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactResponseStatus2? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactResponse3? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactResponseStatus3? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactResponse4? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactResponseStatus4? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactByPhoneResponse? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactByPhoneResponseStatus? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactByPhoneResponse2? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactByPhoneResponseStatus2? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactByPhoneResponse3? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactByPhoneResponseStatus3? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactByPhoneResponse4? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactByPhoneResponseStatus4? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactByPhoneResponse5? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactByPhoneResponseStatus5? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateContactResponse? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateContactResponseStatus? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateContactResponse2? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateContactResponseStatus2? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateContactResponse3? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateContactResponseStatus3? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateContactResponse4? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateContactResponseStatus4? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateContactResponse5? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateContactResponseStatus5? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteContactResponse? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteContactResponseStatus? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteContactResponse2? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteContactResponseStatus2? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteContactResponse3? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteContactResponseStatus3? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteContactResponse4? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteContactResponseStatus4? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteContactResponse5? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteContactResponseStatus5? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactsResponse? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactsResponseStatus? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactsResponse2? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactsResponseStatus2? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactsResponse3? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactsResponseStatus3? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactsResponse4? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactsResponseStatus4? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactConversationsResponse? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactConversationsResponseStatus? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactConversationsResponse2? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactConversationsResponseStatus2? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactConversationsResponse3? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactConversationsResponseStatus3? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactConversationsResponse4? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactConversationsResponseStatus4? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAppResponse? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAppResponseStatus? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAppResponse2? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAppResponseStatus2? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAppResponse3? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAppResponseStatus3? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAppResponse4? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAppResponseStatus4? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppResponse? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppResponseStatus? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppResponse2? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppResponseStatus2? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppResponse3? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppResponseStatus3? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppResponse4? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppResponseStatus4? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAppResponse? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAppResponseStatus? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAppResponse2? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAppResponseStatus2? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAppResponse3? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAppResponseStatus3? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAppResponse4? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAppResponseStatus4? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAppResponse5? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAppResponseStatus5? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAppResponse? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAppResponseStatus? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAppResponse2? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAppResponseStatus2? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAppResponse3? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAppResponseStatus3? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAppResponse4? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAppResponseStatus4? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAppResponse5? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAppResponseStatus5? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppsResponse2>? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppsResponse2? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AppResponse>? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppsResponse3? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppsResponseStatus? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppsResponse4? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppsResponseStatus2? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppsResponse5? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppsResponseStatus3? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppUsagesResponse2>? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppUsagesResponse2? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AppUsageResponse>? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppUsagesResponse3? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppUsagesResponseStatus? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppUsagesResponse4? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppUsagesResponseStatus2? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppUsagesResponse5? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppUsagesResponseStatus3? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppUsagesResponse6? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppUsagesResponseStatus4? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestAppAuthResponse? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestAppAuthResponse2? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestAppAuthResponseStatus? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestAppAuthResponse3? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestAppAuthResponseStatus2? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestAppAuthResponse4? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestAppAuthResponseStatus3? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestAppAuthResponse5? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestAppAuthResponseStatus4? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmConfigResponse? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmConfigResponseStatus? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmConfigResponse2? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmConfigResponseStatus2? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmConfigResponse3? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmConfigResponseStatus3? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCrmConfigResponse? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCrmConfigResponseStatus? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCrmConfigResponse2? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCrmConfigResponseStatus2? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCrmConfigResponse3? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCrmConfigResponseStatus3? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCrmConfigResponse4? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCrmConfigResponseStatus4? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCrmConfigResponse5? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCrmConfigResponseStatus5? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RunSyncJobResponse? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RunSyncJobResponseStatus? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RunSyncJobResponse2? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RunSyncJobResponseStatus2? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RunSyncJobResponse3? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RunSyncJobResponseStatus3? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RunSyncJobResponse4? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RunSyncJobResponseStatus4? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetSyncJobStatusResponse? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetSyncJobStatusResponseStatus? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetSyncJobStatusResponse2? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetSyncJobStatusResponseStatus2? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetSyncJobStatusResponse3? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetSyncJobStatusResponseStatus3? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackfillContactAnalysisDataResponse? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackfillContactAnalysisDataResponseStatus? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackfillContactAnalysisDataResponse2? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackfillContactAnalysisDataResponseStatus2? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackfillContactAnalysisDataResponse3? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackfillContactAnalysisDataResponseStatus3? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackfillContactAnalysisDataResponse4? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackfillContactAnalysisDataResponseStatus4? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetBackfillContactJobStatusResponse? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetBackfillContactJobStatusResponseStatus? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetBackfillContactJobStatusResponse2? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetBackfillContactJobStatusResponseStatus2? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetBackfillContactJobStatusResponse3? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetBackfillContactJobStatusResponseStatus3? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponse? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponse2? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponseStatus? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponse3? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponseStatus2? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponse4? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponseStatus3? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponse5? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponseStatus4? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponse6? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponseStatus5? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponse7? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponseStatus6? Type1953 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AsrProviderModeRoutingSplitItem>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AgentFilter>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.DisconnectionReason5>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CustomFieldFilter>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AlertFilterStatusCodeValueItem>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AlertFilterErrorCodeItem>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.UtteranceNaturalnessIssues>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AgentRequestExpressiveEmotionTag>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.Language3?, global::System.Collections.Generic.List<global::RetellAI.Language3>, global::RetellAI.AgentRequestLanguage?>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.Language3>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AgentRequestWebhookEvent>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AgentRequestPronunciationDictionaryItem>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.PostCallAnalysisData>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.NodeEdge>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.NodeFinetuneTransitionExample>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.Breakdown>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::RetellAI.Breakdown>>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.MetricResult>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<bool>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.TimeWindow>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.DayOfWeek>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.Language3?, global::System.Collections.Generic.List<global::RetellAI.Language3>, global::RetellAI.ChatAgentRequestLanguage?>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ChatAgentRequestWebhookEvent>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.PostChatAnalysisData>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.MessageOrToolCall>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ProductCost>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CohortAggregatedResultTopQuestion>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.NodeTool>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.Mcp>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ConversationFlowNode>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.Note>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CreateConversationFlowComponentRequest>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.NodeFinetuneConversationExample>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.Tool>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.SmsMultimediaItem>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CallFilterCallStatusValueItem>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CallFilterCallTypeValueItem>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CallFilterDirectionValueItem>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CallFilterUserSentimentValueItem>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CallFilterDataStorageSettingValueItem>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ToolCallFilter>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ChatFilterChatStatusValueItem>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ChatFilterUserSentimentValueItem>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.Equation>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AnalysisData>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.FinetuneExampleUtterance>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.GlobalNodeFinetuneTransitionExample>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.UtteranceHallucination>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.Duration>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.KnowledgeBaseAddSourcesRequestKnowledgeBaseText>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.KnowledgeBaseRequestKnowledgeBaseText>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.OneOf<global::RetellAI.KnowledgeBaseSourceDocument, global::RetellAI.KnowledgeBaseSourceText, global::RetellAI.KnowledgeBaseSourceUrl>>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.UtteranceTranscriptionError>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.UtteranceTranscriptionErrorMieDetail>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.NodeTransitionAnalysisDetail>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.OrganizationWebhookUrl>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.PIIConfigCategorie>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.GuardrailConfigOutputTopic>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.GuardrailConfigInputTopic>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AgentWeight>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.RAGAccuracyMissedChunk>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.RAGAccuracy>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.State>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ScoringCriteriaCustomCondition>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.PerformanceMetricCriteria>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.OneOf<global::RetellAI.SentimentAnalysisDetailVariant1, global::RetellAI.SentimentAnalysisDetailVariant2>>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.StateEdge>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ToolMock>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.UtteranceToolCallAccuracy>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.SpendBudgetCustomAlertRequest>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.NaturalnessIssue>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.UtteranceWord>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.Utterance>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.UtteranceOrToolCall>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<string, global::System.Collections.Generic.List<string>>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.IceServer>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.Contact>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ContactConversation>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CRMSyncMapping>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CRMCustomFieldSchema>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CRMAnalysisDataMapping>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<long>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ChartShowItem>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ChartGroupItem>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.BatchCallTask>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ChatMessageInput>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.TestCaseDefinition>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.TestCaseBatchJob>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.TestCaseJob>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AgentVersionSummary>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AgentResponse>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ChatAgentResponse>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.MCPToolDefinition>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.SearchCommunityVoiceResponseVoice>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AgentListItemResponse>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.V3ChatResponse>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ConversationFlowComponentResponse>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ConversationFlowResponse>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.KnowledgeBaseResponse>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.PhoneNumberResponse>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.RetellLLMResponse>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.VoiceResponse>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.V3CallResponse>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ListExportRequestsResponseItem>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AppResponse>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AppUsageResponse>? ListType108 { get; set; }
    }
}