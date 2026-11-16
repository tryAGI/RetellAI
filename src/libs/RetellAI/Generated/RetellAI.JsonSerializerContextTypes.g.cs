
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
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PrivacyScope? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertMetricType? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AsrProvider? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AsrProviderModeRouting? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AsrProviderModeRoutingSplitItem>? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AsrProviderModeRoutingSplitItem? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PaginatedResponseBase? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertFilter? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AgentFilter>? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentFilter? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, object>? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EnumFilter? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterDisconnectionReason>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertFilterDisconnectionReason? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.DisconnectionReason>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DisconnectionReason? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CustomFieldFilter>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CustomFieldFilter? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.StringFilter, object>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StringFilter? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterStatusCode>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertFilterStatusCode? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AlertFilterStatusCodeValueItem>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertFilterStatusCodeValueItem? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AlertFilterErrorCodeItem>? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertFilterErrorCodeItem? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertIncidentResponse? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertIncidentResponseThresholdType? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertIncidentResponseComparator? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertIncidentResponseFrequency? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertIncidentResponseWindow? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertRuleRequest? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertRuleRequestThresholdType? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertRuleRequestComparator? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertRuleRequestFrequency? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertRuleRequestWindow? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertRuleResponse? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertRuleResponseThresholdType? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertRuleResponseComparator? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertRuleResponseFrequency? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertRuleResponseWindow? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentNaturalnessAnalysis? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.UtteranceNaturalnessIssues>? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceNaturalnessIssues? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentWeight? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentVersionReference? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentVersionRequest? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PublishAgentVersionRequest? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRootTagState? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentOverrideRequest? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequest? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellLlmOverride? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowOverride? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactMemoryConfig? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ResponseEngine? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestVoiceModel? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AgentRequestExpressiveEmotionTag>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestExpressiveEmotionTag? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestAmbientSound? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.Language?, global::System.Collections.Generic.IList<global::RetellAI.Language>>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Language? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Language>? Type68 { get; set; }
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
        public global::System.Collections.Generic.IList<global::RetellAI.PreSessionTool>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PreSessionTool? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.PostSessionTool>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PostSessionTool? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentVersionSummary? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentResponse? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentResponseVariant1? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentResponseVariant3? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentListFilter? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.StringFilter, global::RetellAI.AgentListFilterChannel>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentListFilterChannel? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentListFilterChannelOp? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentListFilterChannelValue? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BooleanFilter? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentListItemResponse? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentListItemResponseChannel? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::RetellAI.AgentRootTagState>? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentSwapNode? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeBase? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentSwapNodeVariant2? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentSwapNodeVariant2Type? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PostCallAnalysisSetting? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentSwapWebhookSetting? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferFailedEdge? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeInstruction? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentSwapTool? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentSwapToolType? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentSwapToolExecutionMessageType? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AnalysisData? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StringAnalysisData? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EnumAnalysisData? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BooleanAnalysisData? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NumberAnalysisData? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallPresetAnalysisData? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PostChatAnalysisData? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatPresetAnalysisData? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AverageMetric? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BatchCallResponse? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallTimeWindow? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BatchCallTask? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BooleanAnalysisDataType? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BranchNode? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BranchNodeVariant2? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BranchNodeVariant2Type? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.NodeEdge>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeEdge? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ElseEdge? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.NodeFinetuneTransitionExample>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeFinetuneTransitionExample? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BreakdownMetric? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Breakdown>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Breakdown? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::RetellAI.Breakdown>>? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BridgeTransferNode? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BridgeTransferNodeVariant2? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BridgeTransferNodeVariant2Type? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BridgeTransferTool? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BridgeTransferToolType? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BridgeTransferToolExecutionMessageType? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallAnalysis? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallAnalysisUserSentiment? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallLatency? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallQA? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.InterruptionAnalysis? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SentimentAnalysis? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TranscriptionErrorAnalysis? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RAGAnalysis? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallMetricAnalysis? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallAccuracyAnalysis? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionAnalysis? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.HallucinationAnalysis? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.MetricResult>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MetricResult? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<bool>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.TimeWindow>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TimeWindow? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.DayOfWeek>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DayOfWeek? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CancelTransferNode? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CancelTransferNodeVariant2? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CancelTransferNodeVariant2Type? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CancelTransferTool? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CancelTransferToolType? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CancelTransferToolExecutionMessageType? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChCallQA? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PreviewCallQA? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PreviewCallQAVariant2? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatAgentRequest? Type177 { get; set; }
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
        public global::RetellAI.CohortAgent? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortAggregatedResult? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortAggregatedResultGroupBy? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CohortAggregatedResultTopQuestion>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortAggregatedResultTopQuestion? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortFilter? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.AllOf<global::RetellAI.NumberFilter, global::RetellAI.CohortFilterStartTimestampVariant1>?, global::RetellAI.RangeFilter>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.NumberFilter, global::RetellAI.CohortFilterStartTimestampVariant1>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NumberFilter? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortFilterStartTimestampVariant1? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortFilterStartTimestampVariant1Op? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RangeFilter? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CohortFilterDisconnectionReason>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortFilterDisconnectionReason? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DateRange? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortFilterCallDurationFilter? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortFilterCallDurationFilterOp? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Cohort? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ScoringCriteria? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortSuccessfulCriteria? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortSuccessfulCriteriaType? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortSuccessfulCriteriaOp? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortEvaluationMode? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ComponentNode? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeBaseCommon? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ComponentNodeVariant2? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ComponentNodeVariant2Type? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ComponentNodeVariant2ComponentType? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowComponentResponse? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowComponentRequest? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowComponentResponseVariant2? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Asset? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Note? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NoteDisplayPosition? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NoteSize? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowComponent? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.NodeTool>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTool? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Mcp>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Mcp? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ConversationFlowNode>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowNode? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowComponentBeginTagDisplayPosition? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Note>? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationNode? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SubagentNode? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndNode? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FunctionNode? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CodeNode? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalateChatNode? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferCallNode? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PressDigitNode? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsNode? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ExtractDynamicVariablesNode? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MCPNode? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentOverrideConfig? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentOverrideConfigSttMode? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentOverrideConfigCustomSttConfig? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ModelConfig? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ModelChoice? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KBConfig? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowOverrideStartSpeaker? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowResponse? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlow? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowResponseVariant2? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowVariant2? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CreateConversationFlowComponentRequest>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowVariant2BeginTagDisplayPosition? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationNodeVariant3? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationNodeVariant3Type? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SkipResponseEdge? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlwaysEdge? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.NodeFinetuneConversationExample>? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeFinetuneConversationExample? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SubagentNodeVariant3? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SubagentNodeVariant3Type? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeInstructionPrompt? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Tool>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Tool? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CpsConfig? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowRequest? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateOrganizationRequest? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateOrganizationRequestNew? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateOrganizationRequestOld? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateCreditTopupInvoiceRequest? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateCreditTopupInvoiceResponse? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CustomMetricCriteria? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CustomTool? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CustomToolType? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CustomToolMethod? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolParameter? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CustomToolExecutionMessageType? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CustomToolParameterType? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CodeTool? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CodeToolType? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CodeToolExecutionMessageType? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppTool? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppToolType? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ToolParameter>? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OutputSelection? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppToolExecutionMessageType? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OutputSelectionVariant1? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OutputSelectionVariant1Mode? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OutputSelectionVariant2? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OutputSelectionVariant2Mode? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PreSessionToolVariant2? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool, global::RetellAI.SendSMSTool>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SendSMSTool? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PostSessionToolVariant2? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EquationCondition? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DTMFUtterance? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DTMFUtteranceRole? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsUtterance? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsUtteranceRole? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.SmsMultimediaItem>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsMultimediaItem? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.InjectedUtterance? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.InjectedUtteranceRole? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StringFilterType? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StringFilterOp? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NumberFilterType? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NumberFilterOp? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BooleanFilterType? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BooleanFilterOp? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RangeFilterType? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RangeFilterOp? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EnumFilterType? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EnumFilterOp? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PresentFilter? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PresentFilterType? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PresentFilterOp? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ValueFilter? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CustomFieldFilterVariant2? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallFilter? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilter? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.StringFilter, global::RetellAI.EnumFilter>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterCallStatus>? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterCallStatus? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CallFilterCallStatusValueItem>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterCallStatusValueItem? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDisconnectionReason>? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterDisconnectionReason? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterCallType>? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterCallType? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CallFilterCallTypeValueItem>? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterCallTypeValueItem? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDirection>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterDirection? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CallFilterDirectionValueItem>? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterDirectionValueItem? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterUserSentiment>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterUserSentiment? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CallFilterUserSentimentValueItem>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterUserSentimentValueItem? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDataStorageSetting>? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterDataStorageSetting? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CallFilterDataStorageSettingValueItem>? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterDataStorageSettingValueItem? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ToolCallFilter>? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StoredCallFilter? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StoredCallFilterVariant2? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterChatType>? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterChatType? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ChatFilterChatTypeValueItem>? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterChatTypeValueItem? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterDirection>? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterDirection? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ChatFilterDirectionValueItem>? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterDirectionValueItem? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterDataStorageSetting>? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterDataStorageSetting? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ChatFilterDataStorageSettingValueItem>? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterDataStorageSettingValueItem? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterChatStatus>? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterChatStatus? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ChatFilterChatStatusValueItem>? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterChatStatusValueItem? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterDisconnectionReason>? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterDisconnectionReason? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterUserSentiment>? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterUserSentiment? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ChatFilterUserSentimentValueItem>? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterUserSentimentValueItem? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactFilter? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.StringFilter, global::RetellAI.PresentFilter>? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactsRequest? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactsRequestSortOrder? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Duration? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ElseEdgeVariant2? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ElseEdgeVariant2TransitionCondition? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ElseEdgeVariant2TransitionConditionType? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ElseEdgeVariant2TransitionConditionPrompt? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndCallTool? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndCallToolType? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndCallToolExecutionMessageType? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndNodeVariant2? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndNodeVariant2Type? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EnumAnalysisDataType? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EquationConditionType? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Equation>? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Equation? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EquationConditionOperator? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EquationPromptCondition? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EquationPromptConditionType? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EquationPromptConditionOperator? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PromptCondition? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EquationOperator? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ExtractDynamicVariableTool? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ExtractDynamicVariableToolType? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AnalysisData>? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ExtractDynamicVariablesNodeVariant2? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ExtractDynamicVariablesNodeVariant2Type? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FinetuneExampleUtterance? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FinetuneExampleUtteranceVariant1? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FinetuneExampleUtteranceVariant1Role? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FinetuneExampleUtteranceVariant2? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FinetuneExampleUtteranceVariant2Role? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FinetuneExampleUtteranceVariant3? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FinetuneExampleUtteranceVariant3Role? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FunctionNodeVariant2? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FunctionNodeVariant2Type? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FunctionNodeVariant2ToolType? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CodeNodeVariant2? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CodeNodeVariant2Type? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GlobalNodeFinetuneTransitionExample? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.FinetuneExampleUtterance>? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GlobalNodeSetting? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<string, global::RetellAI.PromptCondition, global::RetellAI.EquationCondition, global::RetellAI.EquationPromptCondition>? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.GlobalNodeFinetuneTransitionExample>? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.UtteranceHallucination>? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceHallucination? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Duration>? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseAddSourcesRequest? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.KnowledgeBaseAddSourcesRequestKnowledgeBaseText>? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseAddSourcesRequestKnowledgeBaseText? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseRequest? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.KnowledgeBaseRequestKnowledgeBaseText>? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseRequestKnowledgeBaseText? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseResponse? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseResponseRemainingIngestionQuota? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseEffectiveIngestionLimits? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseResponseStatus? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.OneOf<global::RetellAI.KnowledgeBaseSourceDocument, global::RetellAI.KnowledgeBaseSourceText, global::RetellAI.KnowledgeBaseSourceUrl>>? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.KnowledgeBaseSourceDocument, global::RetellAI.KnowledgeBaseSourceText, global::RetellAI.KnowledgeBaseSourceUrl>? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseSourceDocument? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseSourceText? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseSourceUrl? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseSourceDocumentType? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseSourceTextType? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseSourceUrlType? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MCPNodeVariant2? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MCPNodeVariant2Type? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MCPToolDefinition? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MCPTool? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MCPToolType? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MCPToolExecutionMessageType? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Message? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallInvocationMessage? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallResultMessage? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionMessage? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StateTransitionMessage? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.InjectedMessage? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsMessage? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatMessageInput? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MessageBase? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallInvocationMessageBase? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallResultMessageBase? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionMessageBase? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StateTransitionMessageBase? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.InjectedMessageBase? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsMessageBase? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MessageBaseCustomerDefinedMetadata? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MessageBaseRole? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.InjectedMessageBaseRole? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsMessageBaseRole? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.PerformanceMetricCriteria, global::RetellAI.CustomMetricCriteria>? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PerformanceMetricCriteria? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<double?, bool?, string>? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.UtteranceTranscriptionError>? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceTranscriptionError? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Wer? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.UtteranceTranscriptionErrorMieDetail>? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceTranscriptionErrorMieDetail? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ModelChoiceCascading? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackupModelChoiceVariant2? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ModelChoiceCascadingType? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ModelChoiceS2S? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ModelChoiceS2SType? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ServiceTier? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextModelRef? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackupModelRef? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.S2SModelRef? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NullableBackupModelRef? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CascadingModelConfig? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.S2SModelConfig? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DuplexModelConfig? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CascadingModelConfigType? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.S2SModelConfigType? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DuplexModelRef? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DuplexModelRefModel? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DuplexModelConfigType? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeModelConfig? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NullableNodeModelConfig? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NaturalnessIssue? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeBaseVariant2? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeBaseCommonDisplayPosition? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.PromptCondition, global::RetellAI.EquationCondition>? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeInstructionPromptType? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeInstructionStaticText? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeInstructionStaticTextType? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsInstructionTemplate? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsInstructionTemplateType? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsInstructionTemplateTemplate? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.CustomTool, global::RetellAI.AppTool>? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeToolVariant2? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.NodeTransitionAnalysisDetail>? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionAnalysisDetail? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionMessageBaseRole? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionMessageBaseTransitionType? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionUtterance? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionUtteranceRole? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionUtteranceTransitionType? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NumberAnalysisDataType? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PresetAnalysisData? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PresetAnalysisDataType? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PresetAnalysisDataName? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallPresetAnalysisDataType? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallPresetAnalysisDataName? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatPresetAnalysisDataType? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatPresetAnalysisDataName? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Organization? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.OrganizationWebhookUrl>? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OrganizationWebhookUrl? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OrganizationCpsConfig? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AutoCreditReloadConfig? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorOverageConfig? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OrganizationResponse? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OrganizationResponseVariant2? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OrganizationResponseVariant2EnterprisePlanStatus? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PIIConfigMode? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.PIIConfigCategorie>? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PIIConfigCategorie? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.GuardrailConfigOutputTopic>? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GuardrailConfigOutputTopic? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.GuardrailConfigInputTopic>? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GuardrailConfigInputTopic? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PerformanceMetricCriteriaOp? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberSpamStatus? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilter? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterSpamStatus>? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterSpamStatus? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.PhoneNumberSpamStatus>? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.BooleanFilter, global::RetellAI.PhoneNumberListFilterSms>? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterSms? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterSmsValue? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.BooleanFilter, global::RetellAI.PhoneNumberListFilterVerifiedNumber>? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterVerifiedNumber? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterVerifiedNumberValue? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.BooleanFilter, global::RetellAI.PhoneNumberListFilterBrandedCall>? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterBrandedCall? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterBrandedCallValue? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterPhoneNumberType>? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterPhoneNumberType? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.PhoneNumberListFilterPhoneNumberTypeValueItem>? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterPhoneNumberTypeValueItem? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AllOf<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterInboundAgent>>? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterInboundAgent>? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterInboundAgent? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterInboundAgentTags>? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterInboundAgentTags? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AllOf<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterOutboundAgent>>? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterOutboundAgent>? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterOutboundAgent? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterOutboundAgentTags>? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterOutboundAgentTags? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberResponse? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberResponsePhoneNumberType? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberResponseSpamStatus? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AgentWeight>? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberResponseSipOutboundTrunkConfig? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PressDigitNodeVariant2? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PressDigitNodeVariant2Type? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PressDigitTool? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PressDigitToolType? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PromptConditionType? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.QaViewFilter? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.QaViewFilterDisconnectionReason>? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.QaViewFilterDisconnectionReason? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<bool?, global::RetellAI.BooleanFilter>? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.QaViewFilterScoreRange? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.QaViewFilterScoreRangeType? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.QaViewFilterScoreRangeOp? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortQaListArgs? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortQaListArgsSortKey? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortQaListArgsOrder? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RAGAccuracy? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.RAGAccuracyMissedChunk>? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RAGAccuracyMissedChunk? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.RAGAccuracy>? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ResponseEngineConversationFlow? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ResponseEngineConversationFlowType? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ResponseEngineCustomLm? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ResponseEngineCustomLmType? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ResponseEngineRetellLm? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ResponseEngineRetellLmType? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellResponseEngine? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellLLMResponse? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellLLMResponseVariant1? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellLlmRequest? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellLLMResponseVariant3? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellLlmOverrideStartSpeaker? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellLlmRequestVariant2? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.State>? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.State? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ScoringCriteriaCustomCondition>? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ScoringCriteriaCustomCondition? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.PerformanceMetricCriteria>? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SendSMSToolType? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SendSMSToolExecutionMessageType? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsContent? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AnyOf<global::RetellAI.SmsSender?, object>? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSender? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AnyOf<global::RetellAI.SmsDestination?, object>? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsDestination? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSenderSenderCurrentNumber? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSenderSenderCurrentNumberType? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSenderSenderRetellLongCode? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSenderSenderRetellLongCodeType? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsDestinationDestinationCustomerNumber? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsDestinationDestinationCustomerNumberType? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsDestinationDestinationPhoneNumber? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsDestinationDestinationPhoneNumberType? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.OneOf<global::RetellAI.SentimentAnalysisDetailVariant1, global::RetellAI.SentimentAnalysisDetailVariant2>>? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.SentimentAnalysisDetailVariant1, global::RetellAI.SentimentAnalysisDetailVariant2>? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SentimentAnalysisDetailVariant1? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SentimentAnalysisDetailVariant1Sentiment? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SentimentAnalysisDetailVariant2? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SentimentAnalysisDetailVariant2Sentiment? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SkipResponseEdgeVariant2? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SkipResponseEdgeVariant2TransitionCondition? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SkipResponseEdgeVariant2TransitionConditionType? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SkipResponseEdgeVariant2TransitionConditionPrompt? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlwaysEdgeVariant2? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlwaysEdgeVariant2TransitionCondition? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlwaysEdgeVariant2TransitionConditionType? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlwaysEdgeVariant2TransitionConditionPrompt? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsContentInferred? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsContentInferredType? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsContentPredefined? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsContentPredefinedType? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsContentTemplate? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsContentTemplateType? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsContentTemplateTemplate? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsFailedEdge? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsFailedEdgeVariant2? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsFailedEdgeVariant2TransitionCondition? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsFailedEdgeVariant2TransitionConditionType? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsFailedEdgeVariant2TransitionConditionPrompt? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsNodeVariant2? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsNodeVariant2Type? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.NodeInstruction?, global::RetellAI.SmsInstructionTemplate>? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSuccessEdge? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSuccessEdgeVariant2? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSuccessEdgeVariant2TransitionCondition? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionType? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionPrompt? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StateEdge? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StateTransitionMessageBaseRole? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.StateEdge>? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StringAnalysisDataType? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseBatchJob? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseBatchJobStatus? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseDefinitionInput? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ToolMock>? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolMock? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseDefinition? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseDefinitionVariant2? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseDefinitionVariant2Type? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseJob? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseJobStatus? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolMockInputMatchRule? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolMockInputMatchRuleVariant1? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolMockInputMatchRuleVariant1Type? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolMockInputMatchRuleVariant2? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolMockInputMatchRuleVariant2Type? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.UtteranceToolCallAccuracy>? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceToolCallAccuracy? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallInvocationMessageBaseRole? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallInvocationUtterance? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallInvocationUtteranceRole? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallInvocationUtteranceMetadata? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackupModelUsed? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallResultMessageBaseRole? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallResultUtterance? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallResultUtteranceRole? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolParameterType? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalateChatTool? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferCallTool? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalationDestination? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalationDestinationType? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalationDestinationDestination? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalationDestinationDestinationMethod? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalateChatToolType? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalationFailedEdge? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalationFailedEdgeVariant2? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalationFailedEdgeVariant2TransitionCondition? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalationFailedEdgeVariant2TransitionConditionType? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalationFailedEdgeVariant2TransitionConditionPrompt? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalateChatNodeVariant2? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalateChatNodeVariant2Type? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferCallNodeVariant2? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferCallNodeVariant2Type? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferDestination? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOption? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferCallToolType? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferCallToolExecutionMessageType? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferDestinationInferred? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferDestinationInferredType? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferDestinationPredefined? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferDestinationPredefinedType? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferFailedEdgeVariant2? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferFailedEdgeVariant2TransitionCondition? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferFailedEdgeVariant2TransitionConditionType? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferFailedEdgeVariant2TransitionConditionPrompt? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionAgenticWarmTransfer? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionAgenticWarmTransferType? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionAgenticWarmTransferOnHoldMusic? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.WarmTransferPrompt, global::RetellAI.WarmTransferStaticMessage>? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.WarmTransferPrompt? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.WarmTransferStaticMessage? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionAgenticWarmTransferAgenticTransferConfig? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionAgenticWarmTransferAgenticTransferConfigTransferAgent? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeout? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionColdTransfer? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionColdTransferType? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionColdTransferColdTransferMode? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionColdTransferOnHoldMusic? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionWarmTransfer? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionWarmTransferType? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionWarmTransferOnHoldMusic? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SpendBudgetCustomAlertRequest? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateSpendBudgetRequest? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateSpendBudgetRequestVariant1? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateSpendBudgetRequestVariant2? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.SpendBudgetCustomAlertRequest>? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UserFormRequest? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceHallucinationHallucinationType? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.NaturalnessIssue>? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceOrToolCall? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Utterance? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackupModelUsedReason? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextUtterance? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextUtteranceRole? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceVariant2? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceVariant2Metadata? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.UtteranceVariant2Word>? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceVariant2Word? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2CallBase? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2CallBaseCallStatus? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2CallBaseDataStorageSetting? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Utterance>? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.UtteranceOrToolCall>? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2CallBaseLatency? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2CallBaseCallCost? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2CallBaseLlmTokenUsage? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2CallResponse? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2WebCallResponse? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2PhoneCallResponse? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallTransport? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.IceServer? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<string, global::System.Collections.Generic.IList<string>>? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponse? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.IceServer>? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CallResponse? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3WebCallResponse? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3PhoneCallResponse? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CreateWebCallResponse? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CreateWebCallResponseTransport? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CallBase? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CallBaseCallStatus? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CallBaseDataStorageSetting? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CallBaseLatency? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CallBaseCallCost? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CallBaseLlmTokenUsage? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3PhoneCallResponseVariant1? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3PhoneCallResponseVariant1CallType? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3PhoneCallResponseVariant1Direction? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3PhoneCallResponseVariant1TelephonyIdentifier? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3WebCallResponseVariant1? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3WebCallResponseVariant1CallType? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3ListCallsRequest? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3ListCallsRequestSortOrder? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2PhoneCallResponseVariant1? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2PhoneCallResponseVariant1CallType? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2PhoneCallResponseVariant1Direction? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2PhoneCallResponseVariant1TelephonyIdentifier? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2WebCallResponseVariant1? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2WebCallResponseVariant1CallType? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoiceResponse? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoiceResponseProvider? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoiceResponseGender? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionBridgeTransfer? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionBridgeTransferType? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionHangup? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionHangupType? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionPrompt? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionPromptType? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionStaticText? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionStaticTextType? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.IvrActionHangup? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.IvrActionHangupType? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.IvrAction? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.WarmTransferPromptType? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.WarmTransferStaticMessageType? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorOverageConfigVariant1? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorOverageConfigVariant1Mode? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorOverageConfigVariant2? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorOverageConfigVariant2Mode? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorOverageConfigVariant3? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorOverageConfigVariant3Mode? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTag? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormOption? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormItemBase? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormFieldBase? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormFieldBaseVariant2? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextBlock? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextBlockVariant2? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextBlockVariant2Kind? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormChoiceField? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormChoiceFieldVariant2? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormChoiceFieldVariant2Kind? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ConductorFormOption>? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormChoiceFieldVariant2DefaultValue? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormSelectField? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormSelectFieldVariant2? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormSelectFieldVariant2Kind? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextField? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextFieldVariant2? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextFieldVariant2Kind? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextFieldVariant2Format? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextareaField? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextareaFieldVariant2? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextareaFieldVariant2Kind? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormNumberField? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormNumberFieldVariant2? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormNumberFieldVariant2Kind? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormSwitchField? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormSwitchFieldVariant2? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormSwitchFieldVariant2Kind? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTimeField? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTimeFieldVariant2? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTimeFieldVariant2Kind? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTimeValue? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormDateRangeField? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormDateRangeFieldVariant2? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormDateRangeFieldVariant2Kind? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormDateRangeValue? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormFileField? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormFileFieldVariant2? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormFileFieldVariant2Kind? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ConductorFormFileFieldVariant2AcceptItem>? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormFileFieldVariant2AcceptItem? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormField? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormItem? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormStep? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::RetellAI.ConductorFormItem>>? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ConductorFormItem>? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorForm? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ConductorFormStep>? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactTag? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Contact? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ContactTag>? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactListResponse? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactListResponseVariant2? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Contact>? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactConversation? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactCall? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactChat? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactCallType? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactCallDirection? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactCallSentiment? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactChatType? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactChatDirection? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactChatSentiment? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactConversationListResponse? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactConversationListResponseVariant2? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ContactConversation>? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppType? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppConnectionStatus? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OAuthConfigRequest? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OAuthConfigRequestType? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ApiKeyAuthConfigRequest? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ApiKeyAuthConfigRequestType? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BasicAuthConfigRequest? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BasicAuthConfigRequestType? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AuthConfigRequest? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OAuthConfigResponse? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OAuthConfigResponseType? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ApiKeyAuthConfigResponse? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ApiKeyAuthConfigResponseType? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AccessTokenAuthConfigResponse? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AccessTokenAuthConfigResponseType? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BasicAuthConfigResponse? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BasicAuthConfigResponseType? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RefreshTokenAuthConfigResponse? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RefreshTokenAuthConfigResponseType? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppAuthConfigResponse? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CRMSyncMapping? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppCRMConfig? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CRMSyncMapping>? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppResponse? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppResponseTenantType? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppUsageResponse? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentAppUsage? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseAppUsage? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertRuleAppUsage? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentAppUsageType? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseAppUsageType? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertRuleAppUsageType? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppToolTemplate? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppTemplate? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AppToolTemplate>? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CRMCustomFieldSchema? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CRMCustomFieldSchemaType? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CRMAnalysisDataMapping? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CRMAnalysisDataMappingUpdateMode? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CRMConfig? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CRMCustomFieldSchema>? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CRMAnalysisDataMapping>? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.JobStatus? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.JobStatusStatus? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.JobStatusTriggeredBy? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartGroupType? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DashboardSource? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartGroupItem? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartGroupItemVariant1? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartGroupItemVariant1Type? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartGroupItemVariant2? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartGroupItemVariant2Type? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItem? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemKeywordSource? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemKeywordSourceSource? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemKeywordSourceSourceType? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemKeywordSourceMeasurement? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemKeywordSourceMeasurementType? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemNumericSource? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemNumericSourceSource? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemNumericSourceSourceType? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemNumericSourceMeasurement? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemNumericSourceMeasurementType? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomFieldSource? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomFieldSourceSource? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomFieldSourceSourceType? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomFieldSourceSourceCast? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomFieldSourceMeasurement? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomFieldSourceMeasurementType? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemConcurrencySource? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemConcurrencySourceSource? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemConcurrencySourceSourceType? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemConcurrencySourceMeasurement? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemConcurrencySourceMeasurementType? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomToolSource? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomToolSourceSource? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomToolSourceSourceType? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomToolSourceMeasurement? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomToolSourceMeasurementType? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRange? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant1? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant1Type? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant1Window? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant1WindowUnit? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant2? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant2Type? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant3? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant3Type? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant3Unit? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant4? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant4Type? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant5? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant5Type? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartGridSize? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartConfig? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartConfigType? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ChartShowItem>? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ChartGroupItem>? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AnyOf<global::RetellAI.StoredCallFilter?, global::RetellAI.ChatFilter>? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartConfigUnit? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartDefinition? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartConfigWithId? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartsMap? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartUpdate? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartUpdateVariant2? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartUpdateVariant2Size? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartUpdatesMap? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.ChartUpdate?, object>? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DashboardUpdateRequest? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.AgentRequest, global::RetellAI.CreateAgentRequest2>? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentRequest2? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchCallRequest? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.BatchCallTask>? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchTestRequest? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.TestCaseDefinitionInput, object>? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.ChatAgentRequest, object>? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionRequest? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ChatMessageInput>? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionRequest? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatRequest? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAssetRequest? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneNumberRequest? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneNumberRequestNumberProvider? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneNumberRequestCountryCode? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateSmsChatRequest? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.RecordChatMessageRequestVariant1, global::RetellAI.RecordChatMessageRequestVariant2>? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RecordChatMessageRequestVariant1? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RecordChatMessageRequestVariant1Role? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RecordChatMessageRequestVariant2? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RecordChatMessageRequestVariant2Role? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RecordChatMessageRequestVariant2Metadata? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CloneVoiceRequest? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CloneVoiceRequestVoiceProvider? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddCommunityVoiceRequest? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddCommunityVoiceRequestVoiceProvider? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceRequest? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceRequestVoiceProvider? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ImportPhoneNumberRequest? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsRequest? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchPhoneNumbersRequest? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatMetadataRequest? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatMetadataRequestDataStorageSetting? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdatePhoneNumberRequest? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneCallRequest? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateWebCallRequest? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallRequest? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RegisterPhoneCallRequest? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RegisterPhoneCallRequestDirection? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCallMetadataRequest? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCallMetadataRequestDataStorageSetting? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallRequest? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallRequestFieldsToOverride? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallRequestFieldsToOverrideDataStorageSetting? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallRequestCallControl? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactRequest? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UploadContactImportFileRequest? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactImportRequest? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateContactRequest? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAppRequest? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAppRequest? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppToolSchemaRequest? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCrmConfigRequest? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AllOf<global::RetellAI.ContactTag, global::RetellAI.UpdateCrmConfigRequestContactTag>>? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.ContactTag, global::RetellAI.UpdateCrmConfigRequestContactTag>? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCrmConfigRequestContactTag? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackfillContactAnalysisDataRequest? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackfillContactAnalysisDataRequestBackfillCallFilter? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestCaseDefinitionsType? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListBatchTestsType? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsSortOrder? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsSortOrder? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowComponentsSortOrder? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsSortOrder? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListPhoneNumbersSortOrder? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchPhoneNumbersSortOrder? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMSortOrder? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsSortOrder? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppsSortOrder? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppUsagesSortOrder? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddKnowledgeBaseSourcesResponse? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddKnowledgeBaseSourcesResponseStatus? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentResponse? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentResponseStatus? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchCallResponse? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchCallResponseStatus? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchTestResponse? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchTestResponseStatus? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateTestCaseDefinitionResponse? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateTestCaseDefinitionResponseStatus? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteTestCaseDefinitionResponse? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteTestCaseDefinitionResponseStatus? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestCaseDefinitionResponse? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestCaseDefinitionResponseStatus? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListTestCaseDefinitionsResponse2>? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestCaseDefinitionsResponse2? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.TestCaseDefinition>? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestCaseDefinitionsResponse3? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestCaseDefinitionsResponseStatus? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestCaseDefinitionsResponse4? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestCaseDefinitionsResponse5? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestCaseDefinitionsResponse6? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateTestCaseDefinitionResponse? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateTestCaseDefinitionResponseStatus? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetBatchTestResponse? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetBatchTestResponseStatus? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListBatchTestsResponse2>? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListBatchTestsResponse2? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.TestCaseBatchJob>? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListBatchTestsResponse3? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListBatchTestsResponseStatus? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListBatchTestsResponse4? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListBatchTestsResponse5? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListBatchTestsResponse6? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestRunResponse? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestRunResponseStatus? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListTestRunsResponse2>? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponse2? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.TestCaseJob>? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponse3? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponseStatus? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponse4? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponse5? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponse6? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponse7? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatAgentResponse? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatAgentResponseStatus? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponse? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponse2? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponseStatus? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponse3? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponse4? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponse5? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponse6? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponse7? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponse? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponse2? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponseStatus? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponse3? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponse4? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponse5? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponse6? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponse7? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatResponse? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatResponseStatus? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowComponentResponse? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowComponentResponseStatus? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowResponse? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowResponseStatus? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAssetResponse? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAssetResponseStatus? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateKnowledgeBaseResponse? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateKnowledgeBaseResponseStatus? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneNumberResponse? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneNumberResponseStatus? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateRetellLLMResponse? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateRetellLLMResponseStatus? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateSmsChatResponse? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateSmsChatResponseStatus? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentResponse? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentResponseStatus? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteChatResponse? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteChatResponseStatus? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteChatAgentResponse? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteChatAgentResponseStatus? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowComponentResponse? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowComponentResponseStatus? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowResponse? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowResponseStatus? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteKnowledgeBaseSourceResponse? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteKnowledgeBaseResponse? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteKnowledgeBaseResponseStatus? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeletePhoneNumberResponse? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeletePhoneNumberResponseStatus? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteRetellLLMResponse? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteRetellLLMResponseStatus? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndChatResponse? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndChatResponseStatus? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAgentVersionsResponse2>? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponse2? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AgentVersionSummary>? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponse3? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponseStatus? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponse4? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponse5? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponse6? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponse7? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponse8? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAgentResponse? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAgentResponseStatus? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatAgentResponse? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatAgentResponseStatus? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RecordChatMessageResponse? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RecordChatMessageResponse2? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RecordChatMessageResponseStatus? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RecordChatMessageResponse3? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RecordChatMessageResponse4? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatResponse? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatResponseStatus? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConcurrencyResponse? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConcurrencyResponse2? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConcurrencyResponseStatus? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConcurrencyResponse3? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetApiKeyInfoResponse? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetApiKeyInfoResponse2? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetApiKeyInfoResponseStatus? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetApiKeyInfoResponse3? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowComponentResponse? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowComponentResponseStatus? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowResponse? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowResponseStatus? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetKnowledgeBaseResponse? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetKnowledgeBaseResponseStatus? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.MCPToolDefinition>? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetMCPToolsResponse? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetMCPToolsResponseStatus? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetPhoneNumberResponse? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetPhoneNumberResponseStatus? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetRetellLLMResponse? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetRetellLLMResponseStatus? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetVoiceResponse? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetVoiceResponseStatus? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CloneVoiceResponse? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CloneVoiceResponseStatus? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddCommunityVoiceResponse? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddCommunityVoiceResponseStatus? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceResponse? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.SearchCommunityVoiceResponseVoice>? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceResponseVoice? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceResponse2? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceResponseStatus? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceResponse3? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceResponse4? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceResponse5? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ImportPhoneNumberResponse? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ImportPhoneNumberResponseStatus? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAgentsResponse2>? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsResponse2? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AgentListItemResponse>? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsResponse3? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsResponseStatus? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsResponse4? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsResponse5? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsResponse6? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListChatsResponse2>? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListChatsResponse2? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.V3ChatResponse>? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListChatsResponse3? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListChatsResponseStatus? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListChatsResponse4? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListChatsResponse5? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListChatsResponse6? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowComponentsResponse2>? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowComponentsResponse2? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ConversationFlowComponentResponse>? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowComponentsResponse3? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowComponentsResponseStatus? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowComponentsResponse4? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowComponentsResponse5? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowComponentsResponse6? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowsResponse2>? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponse2? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ConversationFlowResponse>? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponse3? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponseStatus? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponse4? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponse5? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponse6? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponse7? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.KnowledgeBaseResponse>? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListKnowledgeBasesResponse? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListKnowledgeBasesResponseStatus? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListPhoneNumbersResponse2>? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListPhoneNumbersResponse2? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.PhoneNumberResponse>? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListPhoneNumbersResponse3? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListPhoneNumbersResponseStatus? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListPhoneNumbersResponse4? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.SearchPhoneNumbersResponse2>? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchPhoneNumbersResponse2? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchPhoneNumbersResponse3? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchPhoneNumbersResponseStatus? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchPhoneNumbersResponse4? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchPhoneNumbersResponse5? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchPhoneNumbersResponse6? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListRetellLLMResponse2>? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponse2? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.RetellLLMResponse>? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponse3? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponseStatus? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponse4? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponse5? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponse6? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponse7? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.VoiceResponse>? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListVoicesResponse? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListVoicesResponseStatus? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.AgentResponse?, global::RetellAI.ChatAgentResponse?>? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentVersionResponse2? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentVersionResponseStatus? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentVersionResponse3? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentVersionResponse4? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentVersionResponse5? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentVersionResponse6? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PublishAgentVersionResponse? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PublishAgentVersionResponseStatus? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentVersionResponse? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentVersionResponseStatus? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RefreshKnowledgeBaseResponse? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RefreshKnowledgeBaseResponseStatus? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunCallAnalysisResponse? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunCallAnalysisResponseStatus? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunChatAnalysisResponse? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunChatAnalysisResponseStatus? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAgentResponse? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAgentResponseStatus? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RepairAgentResponse2? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RepairAgentResponseStatus? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RepairAgentResponse3? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RepairAgentResponse4? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RepairAgentResponse5? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RepairAgentResponse6? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatAgentResponse? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatAgentResponseStatus? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatMetadataResponse? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatMetadataResponseStatus? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowComponentResponse? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowComponentResponseStatus? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowResponse? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowResponseStatus? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdatePhoneNumberResponse? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdatePhoneNumberResponseStatus? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateRetellLLMResponse? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateRetellLLMResponseStatus? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneCallResponse? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneCallResponseStatus? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateWebCallResponse? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateWebCallResponseStatus? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteCallResponse? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteCallResponseStatus? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCallResponse? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCallResponseStatus? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponse2? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponseStatus? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponse3? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponse4? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponse5? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponse6? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponse? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponse2? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponseStatus? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponse3? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponse4? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponse5? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponse6? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponse7? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListCallsResponse2>? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListCallsResponse2? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.V3CallResponse>? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListCallsResponse3? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListCallsResponseStatus? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListCallsResponse4? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListCallsResponse5? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListCallsResponse6? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListExportRequestsResponse2>? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponse2? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ListExportRequestsResponseItem>? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponseItem? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponseItemChannel? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponseItemStatus? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponse3? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponseStatus? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponse4? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponse5? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponse6? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RegisterPhoneCallResponse? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RegisterPhoneCallResponseStatus? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCallMetadataResponse? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCallMetadataResponseStatus? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponse? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponse2? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponseStatus? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponse3? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponse4? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponse5? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponse6? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StopCallResponse? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StopCallResponseStatus? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactResponse? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactResponseStatus? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UploadContactImportFileResponse? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UploadContactImportFileResponse2? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UploadContactImportFileResponseStatus? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UploadContactImportFileResponse3? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UploadContactImportFileResponse4? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UploadContactImportFileResponse5? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactImportResponse? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactImportResponseStatus? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactImportResponse? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactImportResponseStatus? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactResponse? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactResponseStatus? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactByPhoneResponse? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactByPhoneResponseStatus? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateContactResponse? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateContactResponseStatus? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteContactResponse? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteContactResponseStatus? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactsResponse? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactsResponseStatus? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactConversationsResponse? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactConversationsResponseStatus? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAppResponse? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAppResponseStatus? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppResponse? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppResponseStatus? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAppResponse? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAppResponseStatus? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAppResponse? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAppResponseStatus? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppsResponse2>? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppsResponse2? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AppResponse>? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppsResponse3? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppsResponseStatus? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppsResponse4? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppsResponse5? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppUsagesResponse2>? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppUsagesResponse2? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AppUsageResponse>? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppUsagesResponse3? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppUsagesResponseStatus? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppUsagesResponse4? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppUsagesResponse5? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppUsagesResponse6? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestAppAuthResponse? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestAppAuthResponse2? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestAppAuthResponseStatus? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestAppAuthResponse3? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestAppAuthResponse4? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestAppAuthResponse5? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppTemplatesResponse2>? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppTemplatesResponse2? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AppTemplate>? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppTemplatesResponse3? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppTemplatesResponseStatus? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppTemplatesResponse4? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppTemplatesResponse5? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppToolSchemaResponse? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppToolSchemaResponse2? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppToolSchemaResponseStatus? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppToolSchemaResponse3? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppToolSchemaResponse4? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppToolSchemaResponse5? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmConfigResponse? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmConfigResponseStatus? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCrmConfigResponse? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCrmConfigResponseStatus? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RunSyncJobResponse? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RunSyncJobResponseStatus? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetSyncJobStatusResponse? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetSyncJobStatusResponseStatus? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackfillContactAnalysisDataResponse? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackfillContactAnalysisDataResponseStatus? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetBackfillContactJobStatusResponse? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetBackfillContactJobStatusResponseStatus? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponse? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponse2? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponseStatus? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponse3? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponse4? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponse5? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponse6? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponse7? Type1468 { get; set; }

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
        public global::System.Collections.Generic.List<global::RetellAI.DisconnectionReason>? ListType2 { get; set; }
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
        public global::RetellAI.OneOf<global::RetellAI.Language?, global::System.Collections.Generic.List<global::RetellAI.Language>>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.Language>? ListType10 { get; set; }
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
        public global::System.Collections.Generic.List<global::RetellAI.PreSessionTool>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.PostSessionTool>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.NodeEdge>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.NodeFinetuneTransitionExample>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.Breakdown>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::RetellAI.Breakdown>>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.MetricResult>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<bool>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.TimeWindow>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.DayOfWeek>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ChatAgentRequestWebhookEvent>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.PostChatAnalysisData>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.MessageOrToolCall>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ProductCost>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CohortAggregatedResultTopQuestion>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.NodeTool>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.Mcp>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ConversationFlowNode>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.Note>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CreateConversationFlowComponentRequest>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.NodeFinetuneConversationExample>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.Tool>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ToolParameter>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.SmsMultimediaItem>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CallFilterCallStatusValueItem>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CallFilterCallTypeValueItem>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CallFilterDirectionValueItem>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CallFilterUserSentimentValueItem>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CallFilterDataStorageSettingValueItem>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ToolCallFilter>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ChatFilterChatTypeValueItem>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ChatFilterDirectionValueItem>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ChatFilterDataStorageSettingValueItem>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ChatFilterChatStatusValueItem>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ChatFilterUserSentimentValueItem>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.Equation>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AnalysisData>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.FinetuneExampleUtterance>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.GlobalNodeFinetuneTransitionExample>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.UtteranceHallucination>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.Duration>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.KnowledgeBaseAddSourcesRequestKnowledgeBaseText>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.KnowledgeBaseRequestKnowledgeBaseText>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.OneOf<global::RetellAI.KnowledgeBaseSourceDocument, global::RetellAI.KnowledgeBaseSourceText, global::RetellAI.KnowledgeBaseSourceUrl>>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.UtteranceTranscriptionError>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.UtteranceTranscriptionErrorMieDetail>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.NodeTransitionAnalysisDetail>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.OrganizationWebhookUrl>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.PIIConfigCategorie>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.GuardrailConfigOutputTopic>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.GuardrailConfigInputTopic>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.PhoneNumberSpamStatus>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.PhoneNumberListFilterPhoneNumberTypeValueItem>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AllOf<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterInboundAgent>>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AllOf<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterOutboundAgent>>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AgentWeight>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.RAGAccuracyMissedChunk>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.RAGAccuracy>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.State>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ScoringCriteriaCustomCondition>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.PerformanceMetricCriteria>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.OneOf<global::RetellAI.SentimentAnalysisDetailVariant1, global::RetellAI.SentimentAnalysisDetailVariant2>>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.StateEdge>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ToolMock>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.UtteranceToolCallAccuracy>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.SpendBudgetCustomAlertRequest>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.NaturalnessIssue>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.UtteranceVariant2Word>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.Utterance>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.UtteranceOrToolCall>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<string, global::System.Collections.Generic.List<string>>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.IceServer>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ConductorFormOption>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ConductorFormFileFieldVariant2AcceptItem>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::RetellAI.ConductorFormItem>>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ConductorFormItem>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ConductorFormStep>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ContactTag>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.Contact>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ContactConversation>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CRMSyncMapping>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AppToolTemplate>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CRMCustomFieldSchema>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CRMAnalysisDataMapping>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<long>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ChartShowItem>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ChartGroupItem>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.BatchCallTask>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ChatMessageInput>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AllOf<global::RetellAI.ContactTag, global::RetellAI.UpdateCrmConfigRequestContactTag>>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.TestCaseDefinition>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.TestCaseBatchJob>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.TestCaseJob>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AgentVersionSummary>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.MCPToolDefinition>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.SearchCommunityVoiceResponseVoice>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AgentListItemResponse>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.V3ChatResponse>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ConversationFlowComponentResponse>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ConversationFlowResponse>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.KnowledgeBaseResponse>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.PhoneNumberResponse>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.RetellLLMResponse>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.VoiceResponse>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.V3CallResponse>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ListExportRequestsResponseItem>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AppResponse>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AppUsageResponse>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AppTemplate>? ListType124 { get; set; }
    }
}