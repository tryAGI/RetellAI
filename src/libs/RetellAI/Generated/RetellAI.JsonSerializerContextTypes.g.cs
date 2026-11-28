
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
        public global::RetellAI.AsrModel? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AsrProviderModeRouting? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PaginatedResponseBase? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertFilter? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AgentFilter>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentFilter? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, object>? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EnumFilter? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterDisconnectionReason>? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertFilterDisconnectionReason? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.DisconnectionReason>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DisconnectionReason? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CustomFieldFilter>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CustomFieldFilter? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.StringFilter, object>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StringFilter? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterStatusCode>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertFilterStatusCode? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AlertFilterStatusCodeValueItem>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertFilterStatusCodeValueItem? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AlertFilterErrorCodeItem>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertFilterErrorCodeItem? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertIncidentResponse? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertIncidentResponseThresholdType? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type31 { get; set; }
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
        public global::RetellAI.AgentRootTagUpdate? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRootResponse? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::RetellAI.AgentRootTagState>? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAgentRootRequest? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAgentRootRequestTags? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.AgentRootTagUpdate, object>? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentOverrideRequest? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequest? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellLlmOverride? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowOverride? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactMemoryConfig? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ResponseEngine? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestVoiceModel? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AgentRequestExpressiveEmotionTag>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestExpressiveEmotionTag? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestAmbientSound? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.Language?, global::System.Collections.Generic.IList<global::RetellAI.Language>>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Language? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Language>? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AgentRequestWebhookEvent>? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestWebhookEvent? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestDataStorageSetting? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AgentRequestPronunciationDictionaryItem>? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestPronunciationDictionaryItem? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestPronunciationDictionaryItemAlphabet? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestVoicemailOption? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailAction? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestIvrOption? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallScreeningOption? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.PostCallAnalysisData>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PostCallAnalysisData? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestSttMode? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestCustomSttConfig? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestVocabSpecialization? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestUserDtmfOptions? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentRequestDenoisingMode? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PIIConfig? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GuardrailConfig? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoiceHandbookConfig? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.PreSessionTool>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PreSessionTool? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.PostSessionTool>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PostSessionTool? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentVersionSummary? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentResponse? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentResponseVariant1? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentResponseVariant3? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentListFilter? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.StringFilter, global::RetellAI.AgentListFilterChannel>? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentListFilterChannel? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentListFilterChannelOp? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentListFilterChannelValue? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BooleanFilter? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentListItemResponse? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentListItemResponseChannel? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentSwapNode? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeBase? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentSwapNodeVariant2? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentSwapNodeVariant2Type? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PostCallAnalysisSetting? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentSwapWebhookSetting? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferFailedEdge? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeInstruction? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentSwapTool? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentSwapToolType? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentSwapToolExecutionMessageType? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AnalysisData? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StringAnalysisData? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EnumAnalysisData? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BooleanAnalysisData? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NumberAnalysisData? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallPresetAnalysisData? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PostChatAnalysisData? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatPresetAnalysisData? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AverageMetric? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BatchCallResponse? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallTimeWindow? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BatchCallTask? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BooleanAnalysisDataType? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BranchNode? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BranchNodeVariant2? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BranchNodeVariant2Type? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.NodeEdge>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeEdge? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ElseEdge? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.NodeFinetuneTransitionExample>? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeFinetuneTransitionExample? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BreakdownMetric? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Breakdown>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Breakdown? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::RetellAI.Breakdown>>? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BridgeTransferNode? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BridgeTransferNodeVariant2? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BridgeTransferNodeVariant2Type? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BridgeTransferTool? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BridgeTransferToolType? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BridgeTransferToolExecutionMessageType? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallAnalysis? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallAnalysisUserSentiment? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallLatency? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallQA? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.InterruptionAnalysis? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SentimentAnalysis? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TranscriptionErrorAnalysis? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RAGAnalysis? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallMetricAnalysis? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallAccuracyAnalysis? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionAnalysis? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.HallucinationAnalysis? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.MetricResult>? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MetricResult? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<bool>? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.TimeWindow>? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TimeWindow? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.DayOfWeek>? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DayOfWeek? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CancelTransferNode? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CancelTransferNodeVariant2? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CancelTransferNodeVariant2Type? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CancelTransferTool? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CancelTransferToolType? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CancelTransferToolExecutionMessageType? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChCallQA? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PreviewCallQA? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PreviewCallQAVariant2? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatAgentRequest? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ChatAgentRequestWebhookEvent>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatAgentRequestWebhookEvent? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatAgentRequestDataStorageSetting? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.PostChatAnalysisData>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatHandbookConfig? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatAgentResponse? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatAgentResponseVariant1? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatAgentResponseVariant3? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatAnalysis? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatAnalysisUserSentiment? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatResponse? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatResponseChatStatus? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatResponseChatType? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<string, double?, bool?>? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.MessageOrToolCall>? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MessageOrToolCall? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatResponseChatCost? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ProductCost>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ProductCost? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3ChatResponse? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3ListChatsRequest? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilter? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3ListChatsRequestSortOrder? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortAgent? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortAggregatedResult? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortAggregatedResultGroupBy? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CohortAggregatedResultTopQuestion>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortAggregatedResultTopQuestion? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortFilter? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.AllOf<global::RetellAI.NumberFilter, global::RetellAI.CohortFilterStartTimestampVariant1>?, global::RetellAI.RangeFilter>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.NumberFilter, global::RetellAI.CohortFilterStartTimestampVariant1>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NumberFilter? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortFilterStartTimestampVariant1? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortFilterStartTimestampVariant1Op? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RangeFilter? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CohortFilterDisconnectionReason>? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortFilterDisconnectionReason? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DateRange? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortFilterCallDurationFilter? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortFilterCallDurationFilterOp? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Cohort? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ScoringCriteria? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortSuccessfulCriteria? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortSuccessfulCriteriaType? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortSuccessfulCriteriaOp? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortEvaluationMode? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ComponentNode? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeBaseCommon? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ComponentNodeVariant2? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ComponentNodeVariant2Type? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ComponentNodeVariant2ComponentType? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowComponentResponse? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowComponentRequest? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowComponentResponseVariant2? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Asset? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Note? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NoteDisplayPosition? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NoteSize? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowComponent? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.NodeTool>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTool? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Mcp>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Mcp? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ConversationFlowNode>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowNode? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowComponentBeginTagDisplayPosition? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Note>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationNode? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SubagentNode? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndNode? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FunctionNode? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CodeNode? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalateChatNode? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferCallNode? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PressDigitNode? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsNode? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ExtractDynamicVariablesNode? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MCPNode? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentOverrideConfig? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentOverrideConfigSttMode? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentOverrideConfigCustomSttConfig? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ModelConfig? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KBConfig? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowOverrideStartSpeaker? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowResponse? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlow? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowResponseVariant2? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowVariant2? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CreateConversationFlowComponentRequest>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationFlowVariant2BeginTagDisplayPosition? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationNodeVariant3? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationNodeVariant3Type? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SkipResponseEdge? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlwaysEdge? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.NodeFinetuneConversationExample>? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeFinetuneConversationExample? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SubagentNodeVariant3? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SubagentNodeVariant3Type? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeInstructionPrompt? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Tool>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Tool? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CpsConfig? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowRequest? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateOrganizationRequest? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateOrganizationRequestNew? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateOrganizationRequestOld? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateCreditTopupInvoiceRequest? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateCreditTopupInvoiceResponse? Type290 { get; set; }
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
        public global::RetellAI.AppTool? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppToolType? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ToolParameter>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OutputSelection? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppToolExecutionMessageType? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OutputSelectionVariant1? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OutputSelectionVariant1Mode? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OutputSelectionVariant2? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OutputSelectionVariant2Mode? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool>? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PreSessionToolVariant2? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool, global::RetellAI.SendSMSTool>? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SendSMSTool? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PostSessionToolVariant2? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EquationCondition? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DTMFUtterance? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DTMFUtteranceRole? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsUtterance? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsUtteranceRole? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.SmsMultimediaItem>? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsMultimediaItem? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.InjectedUtterance? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.InjectedUtteranceRole? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StringFilterType? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StringFilterOp? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NumberFilterType? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NumberFilterOp? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BooleanFilterType? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BooleanFilterOp? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RangeFilterType? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RangeFilterOp? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EnumFilterType? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EnumFilterOp? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PresentFilter? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PresentFilterType? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PresentFilterOp? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ValueFilter? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CustomFieldFilterVariant2? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallFilter? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilter? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.StringFilter, global::RetellAI.EnumFilter>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterCallStatus>? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterCallStatus? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CallFilterCallStatusValueItem>? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterCallStatusValueItem? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDisconnectionReason>? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterDisconnectionReason? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterCallType>? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterCallType? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CallFilterCallTypeValueItem>? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterCallTypeValueItem? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDirection>? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterDirection? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CallFilterDirectionValueItem>? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterDirectionValueItem? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterUserSentiment>? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterUserSentiment? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CallFilterUserSentimentValueItem>? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterUserSentimentValueItem? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDataStorageSetting>? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterDataStorageSetting? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CallFilterDataStorageSettingValueItem>? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilterDataStorageSettingValueItem? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ToolCallFilter>? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StoredCallFilter? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StoredCallFilterVariant2? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterChatType>? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterChatType? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ChatFilterChatTypeValueItem>? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterChatTypeValueItem? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterDirection>? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterDirection? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ChatFilterDirectionValueItem>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterDirectionValueItem? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterDataStorageSetting>? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterDataStorageSetting? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ChatFilterDataStorageSettingValueItem>? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterDataStorageSettingValueItem? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterChatStatus>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterChatStatus? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ChatFilterChatStatusValueItem>? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterChatStatusValueItem? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterDisconnectionReason>? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterDisconnectionReason? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterUserSentiment>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterUserSentiment? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ChatFilterUserSentimentValueItem>? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatFilterUserSentimentValueItem? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactFilter? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.StringFilter, global::RetellAI.PresentFilter>? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactsRequest? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactsRequestSortOrder? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Duration? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ElseEdgeVariant2? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ElseEdgeVariant2TransitionCondition? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ElseEdgeVariant2TransitionConditionType? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ElseEdgeVariant2TransitionConditionPrompt? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndCallTool? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndCallToolType? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndCallToolExecutionMessageType? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndNodeVariant2? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndNodeVariant2Type? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EnumAnalysisDataType? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EquationConditionType? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Equation>? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Equation? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EquationConditionOperator? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EquationPromptCondition? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EquationPromptConditionType? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EquationPromptConditionOperator? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PromptCondition? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EquationOperator? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ExtractDynamicVariableTool? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ExtractDynamicVariableToolType? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AnalysisData>? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ExtractDynamicVariablesNodeVariant2? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ExtractDynamicVariablesNodeVariant2Type? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FinetuneExampleUtterance? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FinetuneExampleUtteranceVariant1? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FinetuneExampleUtteranceVariant1Role? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FinetuneExampleUtteranceVariant2? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FinetuneExampleUtteranceVariant2Role? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FinetuneExampleUtteranceVariant3? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FinetuneExampleUtteranceVariant3Role? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FunctionNodeVariant2? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FunctionNodeVariant2Type? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.FunctionNodeVariant2ToolType? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CodeNodeVariant2? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CodeNodeVariant2Type? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GlobalNodeFinetuneTransitionExample? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.FinetuneExampleUtterance>? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GlobalNodeSetting? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<string, global::RetellAI.PromptCondition, global::RetellAI.EquationCondition, global::RetellAI.EquationPromptCondition>? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.GlobalNodeFinetuneTransitionExample>? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.UtteranceHallucination>? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceHallucination? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Duration>? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseAddSourcesRequest? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.KnowledgeBaseAddSourcesRequestKnowledgeBaseText>? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseAddSourcesRequestKnowledgeBaseText? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseRequest? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.KnowledgeBaseRequestKnowledgeBaseText>? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseRequestKnowledgeBaseText? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseResponse? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseResponseRemainingIngestionQuota? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseEffectiveIngestionLimits? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseResponseStatus? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.OneOf<global::RetellAI.KnowledgeBaseSourceDocument, global::RetellAI.KnowledgeBaseSourceText, global::RetellAI.KnowledgeBaseSourceUrl>>? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.KnowledgeBaseSourceDocument, global::RetellAI.KnowledgeBaseSourceText, global::RetellAI.KnowledgeBaseSourceUrl>? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseSourceDocument? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseSourceText? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseSourceUrl? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseSourceDocumentType? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseSourceTextType? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseSourceUrlType? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MCPNodeVariant2? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MCPNodeVariant2Type? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MCPToolDefinition? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MCPTool? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MCPToolType? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MCPToolExecutionMessageType? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Message? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallInvocationMessage? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallResultMessage? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionMessage? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StateTransitionMessage? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.InjectedMessage? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsMessage? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatMessageInput? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MessageBase? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallInvocationMessageBase? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallResultMessageBase? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionMessageBase? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StateTransitionMessageBase? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.InjectedMessageBase? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsMessageBase? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MessageBaseCustomerDefinedMetadata? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.MessageBaseRole? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.InjectedMessageBaseRole? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsMessageBaseRole? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.PerformanceMetricCriteria, global::RetellAI.CustomMetricCriteria>? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PerformanceMetricCriteria? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<double?, bool?, string>? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.UtteranceTranscriptionError>? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceTranscriptionError? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Wer? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.UtteranceTranscriptionErrorMieDetail>? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceTranscriptionErrorMieDetail? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ModelChoiceCascading? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackupModelChoiceVariant2? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ModelChoiceCascadingType? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ModelChoiceS2S? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ModelChoiceS2SType? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ModelChoice? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ServiceTier? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextModelRef? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackupModelRef? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.S2SModelRef? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NullableBackupModelRef? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CascadingModelConfig? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.S2SModelConfig? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DuplexModelConfig? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CascadingModelConfigType? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.S2SModelConfigType? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DuplexModelRef? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DuplexModelRefModel? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DuplexModelConfigType? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeModelConfig? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NullableNodeModelConfig? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NaturalnessIssue? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeBaseVariant2? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeBaseCommonDisplayPosition? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.PromptCondition, global::RetellAI.EquationCondition>? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeInstructionPromptType? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeInstructionStaticText? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeInstructionStaticTextType? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsInstructionTemplate? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsInstructionTemplateType? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsInstructionTemplateTemplate? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.CustomTool, global::RetellAI.AppTool>? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeToolVariant2? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.NodeTransitionAnalysisDetail>? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionAnalysisDetail? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionMessageBaseRole? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionMessageBaseTransitionType? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionUtterance? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionUtteranceRole? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeTransitionUtteranceTransitionType? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NumberAnalysisDataType? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PresetAnalysisData? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PresetAnalysisDataType? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PresetAnalysisDataName? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallPresetAnalysisDataType? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallPresetAnalysisDataName? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatPresetAnalysisDataType? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChatPresetAnalysisDataName? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Organization? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.OrganizationWebhookUrl>? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OrganizationWebhookUrl? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OrganizationCpsConfig? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AutoCreditReloadConfig? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorOverageConfig? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OrganizationResponse? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OrganizationResponseVariant2? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OrganizationResponseVariant2EnterprisePlanStatus? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PIIConfigMode? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.PIIConfigCategorie>? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PIIConfigCategorie? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.GuardrailConfigOutputTopic>? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GuardrailConfigOutputTopic? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.GuardrailConfigInputTopic>? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GuardrailConfigInputTopic? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.HandbookEntryConfig? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.HandbookPrompts? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.LegacyBooleanOrHandbookEntryConfig? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PerformanceMetricCriteriaOp? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberSpamStatus? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilter? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterSpamStatus>? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterSpamStatus? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.PhoneNumberSpamStatus>? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.BooleanFilter, global::RetellAI.PhoneNumberListFilterSms>? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterSms? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterSmsValue? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.BooleanFilter, global::RetellAI.PhoneNumberListFilterVerifiedNumber>? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterVerifiedNumber? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterVerifiedNumberValue? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.BooleanFilter, global::RetellAI.PhoneNumberListFilterBrandedCall>? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterBrandedCall? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterBrandedCallValue? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterPhoneNumberType>? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterPhoneNumberType? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.PhoneNumberListFilterPhoneNumberTypeValueItem>? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterPhoneNumberTypeValueItem? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AllOf<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterInboundAgent>>? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterInboundAgent>? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterInboundAgent? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterInboundAgentTags>? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterInboundAgentTags? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AllOf<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterOutboundAgent>>? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterOutboundAgent>? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterOutboundAgent? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterOutboundAgentTags>? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberListFilterOutboundAgentTags? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberResponse? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberResponsePhoneNumberType? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberResponseSpamStatus? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AgentWeight>? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PhoneNumberResponseSipOutboundTrunkConfig? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PressDigitNodeVariant2? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PressDigitNodeVariant2Type? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PressDigitTool? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PressDigitToolType? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PromptConditionType? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.QaViewFilter? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.QaViewFilterDisconnectionReason>? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.QaViewFilterDisconnectionReason? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<bool?, global::RetellAI.BooleanFilter>? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.QaViewFilterScoreRange? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.QaViewFilterScoreRangeType? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.QaViewFilterScoreRangeOp? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortQaListArgs? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortQaListArgsSortKey? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CohortQaListArgsOrder? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RAGAccuracy? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.RAGAccuracyMissedChunk>? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RAGAccuracyMissedChunk? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.RAGAccuracy>? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ResponseEngineConversationFlow? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ResponseEngineConversationFlowType? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ResponseEngineCustomLm? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ResponseEngineCustomLmType? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ResponseEngineRetellLm? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ResponseEngineRetellLmType? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellResponseEngine? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellLLMResponse? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellLLMResponseVariant1? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellLlmRequest? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellLLMResponseVariant3? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellLlmOverrideStartSpeaker? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RetellLlmRequestVariant2? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.State>? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.State? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ScoringCriteriaCustomCondition>? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ScoringCriteriaCustomCondition? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.PerformanceMetricCriteria>? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SendSMSToolType? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SendSMSToolExecutionMessageType? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsContent? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AnyOf<global::RetellAI.SmsSender?, object>? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSender? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AnyOf<global::RetellAI.SmsDestination?, object>? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsDestination? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSenderSenderCurrentNumber? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSenderSenderCurrentNumberType? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSenderSenderRetellLongCode? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSenderSenderRetellLongCodeType? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsDestinationDestinationCustomerNumber? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsDestinationDestinationCustomerNumberType? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsDestinationDestinationPhoneNumber? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsDestinationDestinationPhoneNumberType? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.OneOf<global::RetellAI.SentimentAnalysisDetailVariant1, global::RetellAI.SentimentAnalysisDetailVariant2>>? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.SentimentAnalysisDetailVariant1, global::RetellAI.SentimentAnalysisDetailVariant2>? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SentimentAnalysisDetailVariant1? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SentimentAnalysisDetailVariant1Sentiment? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SentimentAnalysisDetailVariant2? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SentimentAnalysisDetailVariant2Sentiment? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SkipResponseEdgeVariant2? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SkipResponseEdgeVariant2TransitionCondition? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SkipResponseEdgeVariant2TransitionConditionType? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SkipResponseEdgeVariant2TransitionConditionPrompt? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlwaysEdgeVariant2? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlwaysEdgeVariant2TransitionCondition? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlwaysEdgeVariant2TransitionConditionType? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlwaysEdgeVariant2TransitionConditionPrompt? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsContentInferred? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsContentInferredType? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsContentPredefined? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsContentPredefinedType? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsContentTemplate? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsContentTemplateType? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsContentTemplateTemplate? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsFailedEdge? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsFailedEdgeVariant2? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsFailedEdgeVariant2TransitionCondition? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsFailedEdgeVariant2TransitionConditionType? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsFailedEdgeVariant2TransitionConditionPrompt? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsNodeVariant2? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsNodeVariant2Type? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.NodeInstruction?, global::RetellAI.SmsInstructionTemplate>? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSuccessEdge? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSuccessEdgeVariant2? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSuccessEdgeVariant2TransitionCondition? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionType? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionPrompt? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StateEdge? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StateTransitionMessageBaseRole? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.StateEdge>? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StringAnalysisDataType? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseBatchJob? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseBatchJobStatus? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseDefinitionInput? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ToolMock>? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolMock? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseDefinition? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseDefinitionVariant2? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseDefinitionVariant2Type? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseJob? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseJobStatus? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolMockInputMatchRule? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolMockInputMatchRuleVariant1? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolMockInputMatchRuleVariant1Type? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolMockInputMatchRuleVariant2? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolMockInputMatchRuleVariant2Type? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AllOf<global::RetellAI.TextUtterance, global::RetellAI.TestCaseInputTranscriptItem2>>? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.TextUtterance, global::RetellAI.TestCaseInputTranscriptItem2>? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextUtterance? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseInputTranscriptItem2? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseInputTranscriptItemRole? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseCallerInstructions? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseCallerInstructionsVariant1? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseCallerInstructionsVariant1Type? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseCallerInstructionsVariant2? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseCallerInstructionsVariant2Type? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseEvalCriterion? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseEvalCriterionVariant1? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseEvalCriterionVariant1Type? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseEvalCriterionVariant2? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseEvalCriterionVariant2Type? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCasePaidPerformanceMetric? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextTestCasePerformanceMetrics? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextTestCasePerformanceMetricsCustomToolError? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextTestCasePerformanceMetricsAgentHallucination? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextTestCasePerformanceMetricsNodeTransitionInaccuracy? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextTestCasePerformanceMetricsRagAccuracy? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextTestCasePerformanceMetricsToolCallInaccuracy? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AudioTestCasePerformanceMetrics? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AudioTestCasePerformanceMetricsVariant2? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AudioTestCasePerformanceMetricsVariant2ToolLatency? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AudioTestCasePerformanceMetricsVariant2Latency? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AudioTestCasePerformanceMetricsVariant2Interruption? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AudioTestCasePerformanceMetricsVariant2TalkRatio? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AudioTestCasePerformanceMetricsVariant2Transcription? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseAsrAudioSource? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseAsrAudioSourceVariant1? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseAsrAudioSourceVariant1Type? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseAsrAudioSourceVariant2? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseAsrAudioSourceVariant2Type? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseDefinitionV3Base? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationTestCaseDefinitionV3Base? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationTestCaseDefinitionV3BaseVariant2? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.TestCaseEvalCriterion>? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.TestCasePaidPerformanceMetric>? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextTestCaseDefinitionV3Fields? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextTestCaseDefinitionV3Input? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextTestCaseDefinitionV3InputVariant2? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextTestCaseDefinitionV3InputVariant2Type? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AudioTestCaseDefinitionV3Fields? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditions? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoise? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AudioTestCaseDefinitionV3Input? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AudioTestCaseDefinitionV3InputVariant2? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AudioTestCaseDefinitionV3InputVariant2Type? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AsrGroundTruthUtterance? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AsrGroundTruthUtteranceVariant2? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AsrGroundTruthUtteranceVariant2Role? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AsrTestCaseDefinitionV3Fields? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AsrTestCaseDefinitionV3FieldsVariant2? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AsrGroundTruthUtterance>? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AsrTestCaseDefinitionV3Input? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AsrTestCaseDefinitionV3InputVariant2? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AsrTestCaseDefinitionV3InputVariant2Type? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseDefinitionV3Input? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.TextTestCaseDefinitionV3Input?, global::RetellAI.AudioTestCaseDefinitionV3Input?, global::RetellAI.AsrTestCaseDefinitionV3Input?>? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseDefinitionV3InputVariant2? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseDefinitionV3Metadata? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseDefinitionV3? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseJobV3Base? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseJobV3BaseStatus? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationTestCaseJobV3Base? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationTestCaseJobV3BaseVariant2? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResult>? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResult? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatus? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextTestCaseJobV3? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextTestCaseJobV3Variant2? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextTestCaseJobV3Variant2Type? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AudioTestCaseJobV3? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AudioTestCaseJobV3Variant2? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AudioTestCaseJobV3Variant2Type? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AsrTestCaseJobV3? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AsrTestCaseJobV3Variant2? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AsrTestCaseJobV3Variant2Type? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseJobV3? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseBatchJobV3? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.TestCaseBatchJobV3TestCase>? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseBatchJobV3TestCase? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseBatchJobV3Status? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseBatchJobV3AiSummary? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.TestCaseBatchJobV3AiSummaryFailureCase>? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseBatchJobV3AiSummaryFailureCase? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.UtteranceToolCallAccuracy>? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceToolCallAccuracy? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallInvocationMessageBaseRole? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallInvocationUtterance? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallInvocationUtteranceRole? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallInvocationUtteranceMetadata? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackupModelUsed? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallResultMessageBaseRole? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallResultUtterance? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolCallResultUtteranceRole? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ToolParameterType? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalateChatTool? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferCallTool? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalationDestination? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalationDestinationType? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalationDestinationDestination? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalationDestinationDestinationMethod? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalateChatToolType? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalationFailedEdge? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalationFailedEdgeVariant2? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalationFailedEdgeVariant2TransitionCondition? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalationFailedEdgeVariant2TransitionConditionType? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalationFailedEdgeVariant2TransitionConditionPrompt? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalateChatNodeVariant2? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalateChatNodeVariant2Type? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferCallNodeVariant2? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferCallNodeVariant2Type? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferDestination? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOption? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferCallToolType? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferCallToolExecutionMessageType? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferDestinationInferred? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferDestinationInferredType? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferDestinationPredefined? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferDestinationPredefinedType? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferFailedEdgeVariant2? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferFailedEdgeVariant2TransitionCondition? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferFailedEdgeVariant2TransitionConditionType? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferFailedEdgeVariant2TransitionConditionPrompt? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionAgenticWarmTransfer? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionAgenticWarmTransferType? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionAgenticWarmTransferOnHoldMusic? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.WarmTransferPrompt, global::RetellAI.WarmTransferStaticMessage>? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.WarmTransferPrompt? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.WarmTransferStaticMessage? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionAgenticWarmTransferAgenticTransferConfig? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionAgenticWarmTransferAgenticTransferConfigTransferAgent? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeout? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionColdTransfer? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionColdTransferType? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionColdTransferColdTransferMode? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionColdTransferOnHoldMusic? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionWarmTransfer? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionWarmTransferType? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TransferOptionWarmTransferOnHoldMusic? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SpendBudgetCustomAlertRequest? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateSpendBudgetRequest? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateSpendBudgetRequestVariant1? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateSpendBudgetRequestVariant2? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.SpendBudgetCustomAlertRequest>? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UserFormRequest? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceHallucinationHallucinationType? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.NaturalnessIssue>? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceOrToolCall? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Utterance? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackupModelUsedReason? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextUtteranceRole? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceVariant2? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceVariant2Metadata? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.UtteranceVariant2Word>? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UtteranceVariant2Word? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2CallBase? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2CallBaseCallStatus? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2CallBaseDataStorageSetting? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Utterance>? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.UtteranceOrToolCall>? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2CallBaseLatency? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2CallBaseCallCost? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2CallBaseLlmTokenUsage? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2CallResponse? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2WebCallResponse? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2PhoneCallResponse? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallTransport? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.IceServer? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<string, global::System.Collections.Generic.IList<string>>? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponse? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.IceServer>? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CallResponse? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3WebCallResponse? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3PhoneCallResponse? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CreateWebCallResponse? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CreateWebCallResponseTransport? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CallBase? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CallBaseCallStatus? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CallBaseDataStorageSetting? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CallBaseLatency? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CallBaseCallCost? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3CallBaseLlmTokenUsage? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3PhoneCallResponseVariant1? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3PhoneCallResponseVariant1CallType? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3PhoneCallResponseVariant1Direction? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3PhoneCallResponseVariant1TelephonyIdentifier? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3WebCallResponseVariant1? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3WebCallResponseVariant1CallType? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3ListCallsRequest? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V3ListCallsRequestSortOrder? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2PhoneCallResponseVariant1? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2PhoneCallResponseVariant1CallType? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2PhoneCallResponseVariant1Direction? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2PhoneCallResponseVariant1TelephonyIdentifier? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2WebCallResponseVariant1? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2WebCallResponseVariant1CallType? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoiceResponse? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoiceResponseProvider? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoiceResponseGender? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionBridgeTransfer? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionBridgeTransferType? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionHangup? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionHangupType? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionPrompt? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionPromptType? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionStaticText? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionStaticTextType? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.IvrActionHangup? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.IvrActionHangupType? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.IvrAction? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.WarmTransferPromptType? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.WarmTransferStaticMessageType? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorOverageConfigVariant1? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorOverageConfigVariant1Mode? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorOverageConfigVariant2? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorOverageConfigVariant2Mode? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorOverageConfigVariant3? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorOverageConfigVariant3Mode? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTag? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormOption? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormItemBase? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormFieldBase? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormFieldBaseVariant2? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextBlock? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextBlockVariant2? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextBlockVariant2Kind? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormChoiceField? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormChoiceFieldVariant2? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormChoiceFieldVariant2Kind? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ConductorFormOption>? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormChoiceFieldVariant2DefaultValue? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormSelectField? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormSelectFieldVariant2? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormSelectFieldVariant2Kind? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextField? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextFieldVariant2? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextFieldVariant2Kind? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextFieldVariant2Format? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextareaField? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextareaFieldVariant2? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextareaFieldVariant2Kind? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormNumberField? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormNumberFieldVariant2? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormNumberFieldVariant2Kind? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormSwitchField? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormSwitchFieldVariant2? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormSwitchFieldVariant2Kind? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTimeField? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTimeFieldVariant2? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTimeFieldVariant2Kind? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTimeValue? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormDateRangeField? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormDateRangeFieldVariant2? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormDateRangeFieldVariant2Kind? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormDateRangeValue? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormFileField? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormFileFieldVariant2? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormFileFieldVariant2Kind? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ConductorFormFileFieldVariant2AcceptItem>? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormFileFieldVariant2AcceptItem? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormField? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormItem? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormStep? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::RetellAI.ConductorFormItem>>? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ConductorFormItem>? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorForm? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ConductorFormStep>? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactTag? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.Contact? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ContactTag>? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactListResponse? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactListResponseVariant2? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.Contact>? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactConversation? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactCall? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactChat? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactCallType? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactCallDirection? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactCallSentiment? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactChatType? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactChatDirection? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactChatSentiment? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactConversationListResponse? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactConversationListResponseVariant2? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ContactConversation>? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppType? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppConnectionStatus? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OAuthConfigRequest? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OAuthConfigRequestType? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ApiKeyAuthConfigRequest? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ApiKeyAuthConfigRequestType? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BasicAuthConfigRequest? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BasicAuthConfigRequestType? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AuthConfigRequest? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OAuthConfigResponse? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OAuthConfigResponseType? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ApiKeyAuthConfigResponse? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ApiKeyAuthConfigResponseType? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AccessTokenAuthConfigResponse? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AccessTokenAuthConfigResponseType? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BasicAuthConfigResponse? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BasicAuthConfigResponseType? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RefreshTokenAuthConfigResponse? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RefreshTokenAuthConfigResponseType? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppAuthConfigResponse? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CRMSyncMapping? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppCRMConfig? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CRMSyncMapping>? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppResponse? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppResponseTenantType? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppUsageResponse? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentAppUsage? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseAppUsage? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertRuleAppUsage? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentAppUsageType? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseAppUsageType? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AlertRuleAppUsageType? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppToolTemplate? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AppTemplate? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AppToolTemplate>? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CRMCustomFieldSchema? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CRMCustomFieldSchemaType? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CRMAnalysisDataMapping? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CRMAnalysisDataMappingUpdateMode? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CRMConfig? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CRMCustomFieldSchema>? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.CRMAnalysisDataMapping>? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.JobStatus? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.JobStatusStatus? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.JobStatusTriggeredBy? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartGroupType? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DashboardSource? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartGroupItem? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartGroupItemVariant1? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartGroupItemVariant1Type? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartGroupItemVariant2? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartGroupItemVariant2Type? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItem? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemKeywordSource? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemKeywordSourceSource? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemKeywordSourceSourceType? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemKeywordSourceMeasurement? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemKeywordSourceMeasurementType? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemNumericSource? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemNumericSourceSource? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemNumericSourceSourceType? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemNumericSourceMeasurement? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemNumericSourceMeasurementType? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomFieldSource? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomFieldSourceSource? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomFieldSourceSourceType? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomFieldSourceSourceCast? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomFieldSourceMeasurement? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomFieldSourceMeasurementType? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemConcurrencySource? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemConcurrencySourceSource? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemConcurrencySourceSourceType? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemConcurrencySourceMeasurement? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemConcurrencySourceMeasurementType? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomToolSource? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomToolSourceSource? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomToolSourceSourceType? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomToolSourceMeasurement? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartShowItemCustomToolSourceMeasurementType? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRange? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant1? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant1Type? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant1Window? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant1WindowUnit? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant2? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant2Type? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant3? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant3Type? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant3Unit? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant4? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant4Type? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant5? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartTimeRangeVariant5Type? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartGridSize? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartConfig? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartConfigType? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ChartShowItem>? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ChartGroupItem>? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AnyOf<global::RetellAI.StoredCallFilter?, global::RetellAI.ChatFilter>? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartConfigUnit? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartDefinition? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartConfigWithId? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartsMap? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartUpdate? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartUpdateVariant2? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartUpdateVariant2Size? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChartUpdatesMap? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.ChartUpdate?, object>? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DashboardUpdateRequest? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.AgentRequest, global::RetellAI.CreateAgentRequest2>? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentRequest2? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchCallRequest? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.BatchCallTask>? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchTestRequest? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.TestCaseDefinitionInput, object>? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.ChatAgentRequest, object>? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionRequest? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ChatMessageInput>? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionRequest? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatRequest? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAssetRequest? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneNumberRequest? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneNumberRequestNumberProvider? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneNumberRequestCountryCode? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateSmsChatRequest? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.RecordChatMessageRequestVariant1, global::RetellAI.RecordChatMessageRequestVariant2>? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RecordChatMessageRequestVariant1? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RecordChatMessageRequestVariant1Role? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RecordChatMessageRequestVariant2? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RecordChatMessageRequestVariant2Role? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RecordChatMessageRequestVariant2Metadata? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CloneVoiceRequest? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CloneVoiceRequestVoiceProvider? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddCommunityVoiceRequest? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddCommunityVoiceRequestVoiceProvider? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceRequest? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceRequestVoiceProvider? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ImportPhoneNumberRequest? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsRequest? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchPhoneNumbersRequest? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatMetadataRequest? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatMetadataRequestDataStorageSetting? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdatePhoneNumberRequest? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneCallRequest? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateWebCallRequest? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallRequest? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RegisterPhoneCallRequest? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RegisterPhoneCallRequestDirection? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCallMetadataRequest? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCallMetadataRequestDataStorageSetting? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallRequest? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallRequestFieldsToOverride? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallRequestFieldsToOverrideDataStorageSetting? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallRequestCallControl? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactRequest? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UploadContactImportFileRequest? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactImportRequest? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateContactRequest? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAppRequest? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAppRequest? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppToolSchemaRequest? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCrmConfigRequest? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AllOf<global::RetellAI.ContactTag, global::RetellAI.UpdateCrmConfigRequestContactTag>>? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.ContactTag, global::RetellAI.UpdateCrmConfigRequestContactTag>? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCrmConfigRequestContactTag? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackfillContactAnalysisDataRequest? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackfillContactAnalysisDataRequestBackfillCallFilter? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestCaseDefinitionsType? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListBatchTestsType? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsSortOrder? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsSortOrder? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowComponentsSortOrder? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsSortOrder? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListPhoneNumbersSortOrder? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchPhoneNumbersSortOrder? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMSortOrder? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsSortOrder? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppsSortOrder? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppUsagesSortOrder? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddKnowledgeBaseSourcesResponse? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddKnowledgeBaseSourcesResponseStatus? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentResponse? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentResponseStatus? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchCallResponse? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchCallResponseStatus? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchTestResponse? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateBatchTestResponseStatus? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateTestCaseDefinitionResponse? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateTestCaseDefinitionResponseStatus? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteTestCaseDefinitionResponse? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteTestCaseDefinitionResponseStatus? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestCaseDefinitionResponse? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestCaseDefinitionResponseStatus? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListTestCaseDefinitionsResponse2>? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestCaseDefinitionsResponse2? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.TestCaseDefinition>? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestCaseDefinitionsResponse3? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestCaseDefinitionsResponseStatus? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestCaseDefinitionsResponse4? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestCaseDefinitionsResponse5? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestCaseDefinitionsResponse6? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateTestCaseDefinitionResponse? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateTestCaseDefinitionResponseStatus? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetBatchTestResponse? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetBatchTestResponseStatus? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListBatchTestsResponse2>? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListBatchTestsResponse2? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.TestCaseBatchJob>? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListBatchTestsResponse3? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListBatchTestsResponseStatus? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListBatchTestsResponse4? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListBatchTestsResponse5? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListBatchTestsResponse6? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestRunResponse? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetTestRunResponseStatus? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListTestRunsResponse2>? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponse2? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.TestCaseJob>? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponse3? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponseStatus? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponse4? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponse5? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponse6? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListTestRunsResponse7? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatAgentResponse? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatAgentResponseStatus? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponse? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponse2? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponseStatus? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponse3? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponse4? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponse5? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponse6? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentPlaygroundCompletionResponse7? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponse? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponse2? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponseStatus? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponse3? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponse4? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponse5? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponse6? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatCompletionResponse7? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatResponse? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateChatResponseStatus? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowComponentResponse? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowComponentResponseStatus? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowResponse? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateConversationFlowResponseStatus? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAssetResponse? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAssetResponseStatus? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateKnowledgeBaseResponse? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateKnowledgeBaseResponseStatus? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneNumberResponse? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneNumberResponseStatus? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateRetellLLMResponse? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateRetellLLMResponseStatus? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateSmsChatResponse? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateSmsChatResponseStatus? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentResponse? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentResponseStatus? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteChatResponse? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteChatResponseStatus? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteChatAgentResponse? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteChatAgentResponseStatus? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowComponentResponse? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowComponentResponseStatus? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowResponse? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteConversationFlowResponseStatus? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteKnowledgeBaseSourceResponse? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteKnowledgeBaseResponse? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteKnowledgeBaseResponseStatus? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeletePhoneNumberResponse? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeletePhoneNumberResponseStatus? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteRetellLLMResponse? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteRetellLLMResponseStatus? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndChatResponse? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EndChatResponseStatus? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAgentVersionsResponse2>? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponse2? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AgentVersionSummary>? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponse3? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponseStatus? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponse4? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponse5? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponse6? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponse7? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentVersionsResponse8? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAgentResponse? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAgentResponseStatus? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetHandbookPresetsResponse? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetHandbookPresetsResponseStatus? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatAgentResponse? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatAgentResponseStatus? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RecordChatMessageResponse? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RecordChatMessageResponse2? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RecordChatMessageResponseStatus? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RecordChatMessageResponse3? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RecordChatMessageResponse4? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatResponse? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetChatResponseStatus? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConcurrencyResponse? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConcurrencyResponse2? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConcurrencyResponseStatus? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConcurrencyResponse3? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetApiKeyInfoResponse? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetApiKeyInfoResponse2? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetApiKeyInfoResponseStatus? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetApiKeyInfoResponse3? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowComponentResponse? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowComponentResponseStatus? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowResponse? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetConversationFlowResponseStatus? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetKnowledgeBaseResponse? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetKnowledgeBaseResponseStatus? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.MCPToolDefinition>? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetMCPToolsResponse? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetMCPToolsResponseStatus? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetPhoneNumberResponse? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetPhoneNumberResponseStatus? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetRetellLLMResponse? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetRetellLLMResponseStatus? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetVoiceResponse? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetVoiceResponseStatus? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CloneVoiceResponse? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CloneVoiceResponseStatus? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddCommunityVoiceResponse? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AddCommunityVoiceResponseStatus? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceResponse? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.SearchCommunityVoiceResponseVoice>? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceResponseVoice? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceResponse2? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceResponseStatus? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceResponse3? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceResponse4? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchCommunityVoiceResponse5? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ImportPhoneNumberResponse? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ImportPhoneNumberResponseStatus? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAgentsResponse2>? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsResponse2? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AgentListItemResponse>? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsResponse3? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsResponseStatus? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsResponse4? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsResponse5? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAgentsResponse6? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListChatsResponse2>? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListChatsResponse2? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.V3ChatResponse>? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListChatsResponse3? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListChatsResponseStatus? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListChatsResponse4? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListChatsResponse5? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListChatsResponse6? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowComponentsResponse2>? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowComponentsResponse2? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ConversationFlowComponentResponse>? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowComponentsResponse3? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowComponentsResponseStatus? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowComponentsResponse4? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowComponentsResponse5? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowComponentsResponse6? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowsResponse2>? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponse2? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ConversationFlowResponse>? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponse3? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponseStatus? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponse4? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponse5? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponse6? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListConversationFlowsResponse7? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.KnowledgeBaseResponse>? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListKnowledgeBasesResponse? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListKnowledgeBasesResponseStatus? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListPhoneNumbersResponse2>? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListPhoneNumbersResponse2? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.PhoneNumberResponse>? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListPhoneNumbersResponse3? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListPhoneNumbersResponseStatus? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListPhoneNumbersResponse4? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.SearchPhoneNumbersResponse2>? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchPhoneNumbersResponse2? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchPhoneNumbersResponse3? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchPhoneNumbersResponseStatus? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchPhoneNumbersResponse4? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchPhoneNumbersResponse5? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SearchPhoneNumbersResponse6? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListRetellLLMResponse2>? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponse2? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.RetellLLMResponse>? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponse3? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponseStatus? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponse4? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponse5? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponse6? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListRetellLLMResponse7? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.VoiceResponse>? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListVoicesResponse? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListVoicesResponseStatus? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.AgentResponse?, global::RetellAI.ChatAgentResponse?>? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentVersionResponse2? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentVersionResponseStatus? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentVersionResponse3? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentVersionResponse4? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentVersionResponse5? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAgentVersionResponse6? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PublishAgentVersionResponse? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PublishAgentVersionResponseStatus? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentVersionResponse? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAgentVersionResponseStatus? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAgentRootResponse? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAgentRootResponseStatus? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAgentRootResponse? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAgentRootResponseStatus? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RefreshKnowledgeBaseResponse? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RefreshKnowledgeBaseResponseStatus? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunCallAnalysisResponse? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunCallAnalysisResponseStatus? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunChatAnalysisResponse? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RerunChatAnalysisResponseStatus? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAgentResponse? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAgentResponseStatus? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RepairAgentResponse2? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RepairAgentResponseStatus? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RepairAgentResponse3? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RepairAgentResponse4? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RepairAgentResponse5? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RepairAgentResponse6? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatAgentResponse? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatAgentResponseStatus? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatMetadataResponse? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateChatMetadataResponseStatus? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowComponentResponse? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowComponentResponseStatus? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowResponse? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateConversationFlowResponseStatus? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdatePhoneNumberResponse? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdatePhoneNumberResponseStatus? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateRetellLLMResponse? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateRetellLLMResponseStatus? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneCallResponse? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreatePhoneCallResponseStatus? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateWebCallResponse? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateWebCallResponseStatus? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteCallResponse? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteCallResponseStatus? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCallResponse? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCallResponseStatus? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponse2? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponseStatus? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponse3? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponse4? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponse5? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListenLiveCallResponse6? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponse? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponse2? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponseStatus? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponse3? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponse4? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponse5? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponse6? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TakeOverLiveCallResponse7? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListCallsResponse2>? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListCallsResponse2? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.V3CallResponse>? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListCallsResponse3? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListCallsResponseStatus? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListCallsResponse4? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListCallsResponse5? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListCallsResponse6? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListExportRequestsResponse2>? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponse2? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.ListExportRequestsResponseItem>? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponseItem? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponseItemChannel? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponseItemStatus? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponse3? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponseStatus? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponse4? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponse5? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListExportRequestsResponse6? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RegisterPhoneCallResponse? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RegisterPhoneCallResponseStatus? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCallMetadataResponse? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCallMetadataResponseStatus? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponse? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponse2? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponseStatus? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponse3? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponse4? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponse5? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateLiveCallResponse6? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StopCallResponse? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StopCallResponseStatus? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactResponse? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactResponseStatus? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UploadContactImportFileResponse? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UploadContactImportFileResponse2? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UploadContactImportFileResponseStatus? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UploadContactImportFileResponse3? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UploadContactImportFileResponse4? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UploadContactImportFileResponse5? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactImportResponse? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateContactImportResponseStatus? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactImportResponse? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactImportResponseStatus? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactResponse? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactResponseStatus? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactByPhoneResponse? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetContactByPhoneResponseStatus? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateContactResponse? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateContactResponseStatus? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteContactResponse? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteContactResponseStatus? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactsResponse? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactsResponseStatus? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactConversationsResponse? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListContactConversationsResponseStatus? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAppResponse? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CreateAppResponseStatus? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppResponse? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppResponseStatus? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAppResponse? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateAppResponseStatus? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAppResponse? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.DeleteAppResponseStatus? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppsResponse2>? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppsResponse2? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AppResponse>? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppsResponse3? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppsResponseStatus? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppsResponse4? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppsResponse5? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppUsagesResponse2>? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppUsagesResponse2? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AppUsageResponse>? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppUsagesResponse3? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppUsagesResponseStatus? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppUsagesResponse4? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppUsagesResponse5? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppUsagesResponse6? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestAppAuthResponse? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestAppAuthResponse2? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestAppAuthResponseStatus? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestAppAuthResponse3? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestAppAuthResponse4? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestAppAuthResponse5? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppTemplatesResponse2>? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppTemplatesResponse2? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::RetellAI.AppTemplate>? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppTemplatesResponse3? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppTemplatesResponseStatus? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppTemplatesResponse4? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ListAppTemplatesResponse5? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppToolSchemaResponse? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppToolSchemaResponse2? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppToolSchemaResponseStatus? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppToolSchemaResponse3? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppToolSchemaResponse4? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetAppToolSchemaResponse5? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmConfigResponse? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmConfigResponseStatus? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCrmConfigResponse? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.UpdateCrmConfigResponseStatus? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RunSyncJobResponse? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.RunSyncJobResponseStatus? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetSyncJobStatusResponse? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetSyncJobStatusResponseStatus? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackfillContactAnalysisDataResponse? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackfillContactAnalysisDataResponseStatus? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetBackfillContactJobStatusResponse? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetBackfillContactJobStatusResponseStatus? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponse? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponse2? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponseStatus? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponse3? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponse4? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponse5? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponse6? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.GetCrmSchemaResponse7? Type1569 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AgentFilter>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.DisconnectionReason>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CustomFieldFilter>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AlertFilterStatusCodeValueItem>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AlertFilterErrorCodeItem>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.UtteranceNaturalnessIssues>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AgentRequestExpressiveEmotionTag>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.Language?, global::System.Collections.Generic.List<global::RetellAI.Language>>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.Language>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AgentRequestWebhookEvent>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AgentRequestPronunciationDictionaryItem>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.PostCallAnalysisData>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.PreSessionTool>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.PostSessionTool>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.NodeEdge>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.NodeFinetuneTransitionExample>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.Breakdown>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::RetellAI.Breakdown>>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.MetricResult>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<bool>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.TimeWindow>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.DayOfWeek>? ListType22 { get; set; }
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
        public global::System.Collections.Generic.List<global::RetellAI.ToolParameter>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.SmsMultimediaItem>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CallFilterCallStatusValueItem>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CallFilterCallTypeValueItem>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CallFilterDirectionValueItem>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CallFilterUserSentimentValueItem>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CallFilterDataStorageSettingValueItem>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ToolCallFilter>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ChatFilterChatTypeValueItem>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ChatFilterDirectionValueItem>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ChatFilterDataStorageSettingValueItem>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ChatFilterChatStatusValueItem>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ChatFilterUserSentimentValueItem>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.Equation>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AnalysisData>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.FinetuneExampleUtterance>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.GlobalNodeFinetuneTransitionExample>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.UtteranceHallucination>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.Duration>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.KnowledgeBaseAddSourcesRequestKnowledgeBaseText>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.KnowledgeBaseRequestKnowledgeBaseText>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.OneOf<global::RetellAI.KnowledgeBaseSourceDocument, global::RetellAI.KnowledgeBaseSourceText, global::RetellAI.KnowledgeBaseSourceUrl>>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.UtteranceTranscriptionError>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.UtteranceTranscriptionErrorMieDetail>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.NodeTransitionAnalysisDetail>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.OrganizationWebhookUrl>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.PIIConfigCategorie>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.GuardrailConfigOutputTopic>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.GuardrailConfigInputTopic>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.PhoneNumberSpamStatus>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.PhoneNumberListFilterPhoneNumberTypeValueItem>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AllOf<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterInboundAgent>>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AllOf<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterOutboundAgent>>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AgentWeight>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.RAGAccuracyMissedChunk>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.RAGAccuracy>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.State>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ScoringCriteriaCustomCondition>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.PerformanceMetricCriteria>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.OneOf<global::RetellAI.SentimentAnalysisDetailVariant1, global::RetellAI.SentimentAnalysisDetailVariant2>>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.StateEdge>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ToolMock>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AllOf<global::RetellAI.TextUtterance, global::RetellAI.TestCaseInputTranscriptItem2>>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.TestCaseEvalCriterion>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.TestCasePaidPerformanceMetric>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AsrGroundTruthUtterance>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResult>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.TestCaseBatchJobV3TestCase>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.TestCaseBatchJobV3AiSummaryFailureCase>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.UtteranceToolCallAccuracy>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.SpendBudgetCustomAlertRequest>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.NaturalnessIssue>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.UtteranceVariant2Word>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.Utterance>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.UtteranceOrToolCall>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<string, global::System.Collections.Generic.List<string>>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.IceServer>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ConductorFormOption>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ConductorFormFileFieldVariant2AcceptItem>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::RetellAI.ConductorFormItem>>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ConductorFormItem>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ConductorFormStep>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ContactTag>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.Contact>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ContactConversation>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CRMSyncMapping>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AppToolTemplate>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CRMCustomFieldSchema>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.CRMAnalysisDataMapping>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<long>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ChartShowItem>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ChartGroupItem>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.BatchCallTask>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ChatMessageInput>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AllOf<global::RetellAI.ContactTag, global::RetellAI.UpdateCrmConfigRequestContactTag>>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.TestCaseDefinition>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.TestCaseBatchJob>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.TestCaseJob>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AgentVersionSummary>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.MCPToolDefinition>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.SearchCommunityVoiceResponseVoice>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AgentListItemResponse>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.V3ChatResponse>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ConversationFlowComponentResponse>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ConversationFlowResponse>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.KnowledgeBaseResponse>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.PhoneNumberResponse>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.RetellLLMResponse>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.VoiceResponse>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.V3CallResponse>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.ListExportRequestsResponseItem>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AppResponse>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AppUsageResponse>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::RetellAI.AppTemplate>? ListType130 { get; set; }
    }
}