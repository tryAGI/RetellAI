
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableLLMModel), TypeInfoPropertyName = "NullableLLMModel_RetellAI_NullableLLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.LLMModel?), TypeInfoPropertyName = "NullableLLMModel_RetellAI_LLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertMetricType), TypeInfoPropertyName = "AlertMetricType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AsrProvider), TypeInfoPropertyName = "AsrProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AsrProviderModeRouting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AsrProviderModeRoutingSplitItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AsrProviderModeRoutingSplitItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PaginatedResponseBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AgentFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, object>), TypeInfoPropertyName = "AllOfEnumFilterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EnumFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterDisconnectionReason>), TypeInfoPropertyName = "AllOfEnumFilterAlertFilterDisconnectionReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertFilterDisconnectionReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.DisconnectionReason5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DisconnectionReason5), TypeInfoPropertyName = "DisconnectionReason52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.CustomFieldFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomFieldFilter), TypeInfoPropertyName = "CustomFieldFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.StringFilter, object>), TypeInfoPropertyName = "AllOfStringFilterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StringFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterStatusCode>), TypeInfoPropertyName = "AllOfEnumFilterAlertFilterStatusCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertFilterStatusCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AlertFilterStatusCodeValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertFilterStatusCodeValueItem), TypeInfoPropertyName = "AlertFilterStatusCodeValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AlertFilterErrorCodeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertFilterErrorCodeItem), TypeInfoPropertyName = "AlertFilterErrorCodeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertIncidentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertIncidentResponseThresholdType), TypeInfoPropertyName = "AlertIncidentResponseThresholdType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertIncidentResponseComparator), TypeInfoPropertyName = "AlertIncidentResponseComparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertIncidentResponseFrequency), TypeInfoPropertyName = "AlertIncidentResponseFrequency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertIncidentResponseWindow), TypeInfoPropertyName = "AlertIncidentResponseWindow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleRequestThresholdType), TypeInfoPropertyName = "AlertRuleRequestThresholdType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleRequestComparator), TypeInfoPropertyName = "AlertRuleRequestComparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleRequestFrequency), TypeInfoPropertyName = "AlertRuleRequestFrequency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleRequestWindow), TypeInfoPropertyName = "AlertRuleRequestWindow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleResponseThresholdType), TypeInfoPropertyName = "AlertRuleResponseThresholdType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleResponseComparator), TypeInfoPropertyName = "AlertRuleResponseComparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleResponseFrequency), TypeInfoPropertyName = "AlertRuleResponseFrequency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleResponseWindow), TypeInfoPropertyName = "AlertRuleResponseWindow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentNaturalnessAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.UtteranceNaturalnessIssues>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceNaturalnessIssues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentWeight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentVersionReference), TypeInfoPropertyName = "AgentVersionReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRootTagState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentOverrideRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLlmOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ResponseEngine), TypeInfoPropertyName = "ResponseEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestVoiceModel), TypeInfoPropertyName = "AgentRequestVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestVoiceEmotion), TypeInfoPropertyName = "AgentRequestVoiceEmotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AgentRequestExpressiveEmotionTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestExpressiveEmotionTag), TypeInfoPropertyName = "AgentRequestExpressiveEmotionTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestAmbientSound), TypeInfoPropertyName = "AgentRequestAmbientSound2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.Language3?, global::System.Collections.Generic.IList<global::RetellAI.Language3>, global::RetellAI.AgentRequestLanguage?>), TypeInfoPropertyName = "OneOfLanguage3IListLanguage3AgentRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Language3), TypeInfoPropertyName = "Language32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.Language3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestLanguage), TypeInfoPropertyName = "AgentRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AgentRequestWebhookEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestWebhookEvent), TypeInfoPropertyName = "AgentRequestWebhookEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestDataStorageSetting), TypeInfoPropertyName = "AgentRequestDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AgentRequestPronunciationDictionaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestPronunciationDictionaryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestPronunciationDictionaryItemAlphabet), TypeInfoPropertyName = "AgentRequestPronunciationDictionaryItemAlphabet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestVoicemailOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoicemailAction), TypeInfoPropertyName = "VoicemailAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestIvrOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallScreeningOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.PostCallAnalysisData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PostCallAnalysisData), TypeInfoPropertyName = "PostCallAnalysisData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestSttMode), TypeInfoPropertyName = "AgentRequestSttMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestCustomSttConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestVocabSpecialization), TypeInfoPropertyName = "AgentRequestVocabSpecialization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestUserDtmfOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestDenoisingMode), TypeInfoPropertyName = "AgentRequestDenoisingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PIIConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GuardrailConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoiceHandbookConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentVersionSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentResponse), TypeInfoPropertyName = "AgentResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentListFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.StringFilter, global::RetellAI.AgentListFilterChannel>), TypeInfoPropertyName = "AllOfStringFilterAgentListFilterChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentListFilterChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentListFilterChannelOp), TypeInfoPropertyName = "AgentListFilterChannelOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentListFilterChannelValue), TypeInfoPropertyName = "AgentListFilterChannelValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentListItemResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentListItemResponseChannel), TypeInfoPropertyName = "AgentListItemResponseChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::RetellAI.AgentRootTagState>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentSwapNode), TypeInfoPropertyName = "AgentSwapNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeBase), TypeInfoPropertyName = "NodeBase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentSwapNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentSwapNodeVariant2Type), TypeInfoPropertyName = "AgentSwapNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PostCallAnalysisSetting), TypeInfoPropertyName = "PostCallAnalysisSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentSwapWebhookSetting), TypeInfoPropertyName = "AgentSwapWebhookSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferFailedEdge), TypeInfoPropertyName = "TransferFailedEdge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeInstruction), TypeInfoPropertyName = "NodeInstruction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentSwapTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentSwapToolType), TypeInfoPropertyName = "AgentSwapToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentSwapToolExecutionMessageType), TypeInfoPropertyName = "AgentSwapToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AnalysisData), TypeInfoPropertyName = "AnalysisData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StringAnalysisData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EnumAnalysisData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BooleanAnalysisData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NumberAnalysisData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallPresetAnalysisData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PostChatAnalysisData), TypeInfoPropertyName = "PostChatAnalysisData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatPresetAnalysisData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AverageMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BatchCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallTimeWindow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BatchCallTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BookAppointmentCalTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BookAppointmentCalToolType), TypeInfoPropertyName = "BookAppointmentCalToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<double?, string>), TypeInfoPropertyName = "OneOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BooleanAnalysisDataType), TypeInfoPropertyName = "BooleanAnalysisDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BranchNode), TypeInfoPropertyName = "BranchNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BranchNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BranchNodeVariant2Type), TypeInfoPropertyName = "BranchNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.NodeEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeEdge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ElseEdge), TypeInfoPropertyName = "ElseEdge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.NodeFinetuneTransitionExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeFinetuneTransitionExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BreakdownMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.Breakdown>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Breakdown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::RetellAI.Breakdown>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BridgeTransferNode), TypeInfoPropertyName = "BridgeTransferNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BridgeTransferNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BridgeTransferNodeVariant2Type), TypeInfoPropertyName = "BridgeTransferNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BridgeTransferTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BridgeTransferToolType), TypeInfoPropertyName = "BridgeTransferToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BridgeTransferToolExecutionMessageType), TypeInfoPropertyName = "BridgeTransferToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallAnalysisUserSentiment), TypeInfoPropertyName = "CallAnalysisUserSentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallLatency))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallQA))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.InterruptionAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SentimentAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TranscriptionErrorAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RAGAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallMetricAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallAccuracyAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.HallucinationAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.MetricResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MetricResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.TimeWindow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TimeWindow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.DayOfWeek>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DayOfWeek), TypeInfoPropertyName = "DayOfWeek2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CancelTransferNode), TypeInfoPropertyName = "CancelTransferNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CancelTransferNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CancelTransferNodeVariant2Type), TypeInfoPropertyName = "CancelTransferNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CancelTransferTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CancelTransferToolType), TypeInfoPropertyName = "CancelTransferToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CancelTransferToolExecutionMessageType), TypeInfoPropertyName = "CancelTransferToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChCallQA))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PreviewCallQA), TypeInfoPropertyName = "PreviewCallQA2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PreviewCallQAVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.Language3?, global::System.Collections.Generic.IList<global::RetellAI.Language3>, global::RetellAI.ChatAgentRequestLanguage?>), TypeInfoPropertyName = "OneOfLanguage3IListLanguage3ChatAgentRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatAgentRequestLanguage), TypeInfoPropertyName = "ChatAgentRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ChatAgentRequestWebhookEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatAgentRequestWebhookEvent), TypeInfoPropertyName = "ChatAgentRequestWebhookEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatAgentRequestDataStorageSetting), TypeInfoPropertyName = "ChatAgentRequestDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.PostChatAnalysisData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatHandbookConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatAgentResponse), TypeInfoPropertyName = "ChatAgentResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatAgentResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatAgentResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatAnalysisUserSentiment), TypeInfoPropertyName = "ChatAnalysisUserSentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatResponseChatStatus), TypeInfoPropertyName = "ChatResponseChatStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatResponseChatType), TypeInfoPropertyName = "ChatResponseChatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<string, double?, bool?>), TypeInfoPropertyName = "OneOfStringDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.MessageOrToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MessageOrToolCall), TypeInfoPropertyName = "MessageOrToolCall2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatResponseChatCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ProductCost>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ProductCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3ChatResponse), TypeInfoPropertyName = "V3ChatResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3ListChatsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3ListChatsRequestSortOrder), TypeInfoPropertyName = "V3ListChatsRequestSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CheckAvailabilityCalTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CheckAvailabilityCalToolType), TypeInfoPropertyName = "CheckAvailabilityCalToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortAggregatedResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortAggregatedResultGroupBy), TypeInfoPropertyName = "CohortAggregatedResultGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.CohortAggregatedResultTopQuestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortAggregatedResultTopQuestion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.AllOf<global::RetellAI.NumberFilter, global::RetellAI.CohortFilterStartTimestampVariant1>?, global::RetellAI.RangeFilter>), TypeInfoPropertyName = "OneOfAllOfNumberFilterCohortFilterStartTimestampVariant1RangeFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.NumberFilter, global::RetellAI.CohortFilterStartTimestampVariant1>), TypeInfoPropertyName = "AllOfNumberFilterCohortFilterStartTimestampVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NumberFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortFilterStartTimestampVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortFilterStartTimestampVariant1Op), TypeInfoPropertyName = "CohortFilterStartTimestampVariant1Op2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RangeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CohortFilterDisconnectionReason>), TypeInfoPropertyName = "AllOfEnumFilterCohortFilterDisconnectionReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortFilterDisconnectionReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>), TypeInfoPropertyName = "OneOfNumberFilterRangeFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DateRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortFilterCallDurationFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortFilterCallDurationFilterOp), TypeInfoPropertyName = "CohortFilterCallDurationFilterOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Cohort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ScoringCriteria))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortSuccessfulCriteria))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortSuccessfulCriteriaType), TypeInfoPropertyName = "CohortSuccessfulCriteriaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortSuccessfulCriteriaOp), TypeInfoPropertyName = "CohortSuccessfulCriteriaOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortEvaluationMode), TypeInfoPropertyName = "CohortEvaluationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ComponentNode), TypeInfoPropertyName = "ComponentNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeBaseCommon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ComponentNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ComponentNodeVariant2Type), TypeInfoPropertyName = "ComponentNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ComponentNodeVariant2ComponentType), TypeInfoPropertyName = "ComponentNodeVariant2ComponentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowComponentResponse), TypeInfoPropertyName = "ConversationFlowComponentResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentRequest), TypeInfoPropertyName = "CreateConversationFlowComponentRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowComponentResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Asset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Note))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NoteDisplayPosition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NoteSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowComponent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.NodeTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTool), TypeInfoPropertyName = "NodeTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.Mcp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Mcp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ConversationFlowNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowNode), TypeInfoPropertyName = "ConversationFlowNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowComponentBeginTagDisplayPosition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.Note>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationNode), TypeInfoPropertyName = "ConversationNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SubagentNode), TypeInfoPropertyName = "SubagentNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndNode), TypeInfoPropertyName = "EndNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FunctionNode), TypeInfoPropertyName = "FunctionNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CodeNode), TypeInfoPropertyName = "CodeNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferCallNode), TypeInfoPropertyName = "TransferCallNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PressDigitNode), TypeInfoPropertyName = "PressDigitNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsNode), TypeInfoPropertyName = "SmsNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ExtractDynamicVariablesNode), TypeInfoPropertyName = "ExtractDynamicVariablesNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MCPNode), TypeInfoPropertyName = "MCPNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentOverrideConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KBConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowOverrideStartSpeaker), TypeInfoPropertyName = "ConversationFlowOverrideStartSpeaker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowResponse), TypeInfoPropertyName = "ConversationFlowResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlow), TypeInfoPropertyName = "ConversationFlow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.CreateConversationFlowComponentRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowVariant2BeginTagDisplayPosition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationNodeVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationNodeVariant3Type), TypeInfoPropertyName = "ConversationNodeVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SkipResponseEdge), TypeInfoPropertyName = "SkipResponseEdge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlwaysEdge), TypeInfoPropertyName = "AlwaysEdge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.NodeFinetuneConversationExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeFinetuneConversationExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SubagentNodeVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SubagentNodeVariant3Type), TypeInfoPropertyName = "SubagentNodeVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeInstructionPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Tool), TypeInfoPropertyName = "Tool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CpsConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowRequest), TypeInfoPropertyName = "CreateConversationFlowRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateOrganizationRequest), TypeInfoPropertyName = "CreateOrganizationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateOrganizationRequestNew))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateOrganizationRequestOld))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateCreditTopupInvoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateCreditTopupInvoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OptInBillingV2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OptInBillingV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomMetricCriteria))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomToolType), TypeInfoPropertyName = "CustomToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomToolMethod), TypeInfoPropertyName = "CustomToolMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomToolExecutionMessageType), TypeInfoPropertyName = "CustomToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomToolParameterType), TypeInfoPropertyName = "CustomToolParameterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CodeTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CodeToolType), TypeInfoPropertyName = "CodeToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CodeToolExecutionMessageType), TypeInfoPropertyName = "CodeToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DTMFUtterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DTMFUtteranceRole), TypeInfoPropertyName = "DTMFUtteranceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsUtterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsUtteranceRole), TypeInfoPropertyName = "SmsUtteranceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.SmsMultimediaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsMultimediaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.InjectedUtterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.InjectedUtteranceRole), TypeInfoPropertyName = "InjectedUtteranceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StringFilterType), TypeInfoPropertyName = "StringFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StringFilterOp), TypeInfoPropertyName = "StringFilterOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NumberFilterType), TypeInfoPropertyName = "NumberFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NumberFilterOp), TypeInfoPropertyName = "NumberFilterOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BooleanFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BooleanFilterType), TypeInfoPropertyName = "BooleanFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BooleanFilterOp), TypeInfoPropertyName = "BooleanFilterOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RangeFilterType), TypeInfoPropertyName = "RangeFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RangeFilterOp), TypeInfoPropertyName = "RangeFilterOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EnumFilterType), TypeInfoPropertyName = "EnumFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EnumFilterOp), TypeInfoPropertyName = "EnumFilterOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PresentFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PresentFilterType), TypeInfoPropertyName = "PresentFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PresentFilterOp), TypeInfoPropertyName = "PresentFilterOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ValueFilter), TypeInfoPropertyName = "ValueFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomFieldFilterVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.StringFilter, global::RetellAI.EnumFilter>), TypeInfoPropertyName = "OneOfStringFilterEnumFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterCallStatus>), TypeInfoPropertyName = "AllOfEnumFilterCallFilterCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterCallStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.CallFilterCallStatusValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterCallStatusValueItem), TypeInfoPropertyName = "CallFilterCallStatusValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDisconnectionReason>), TypeInfoPropertyName = "AllOfEnumFilterCallFilterDisconnectionReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterDisconnectionReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterCallType>), TypeInfoPropertyName = "AllOfEnumFilterCallFilterCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.CallFilterCallTypeValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterCallTypeValueItem), TypeInfoPropertyName = "CallFilterCallTypeValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDirection>), TypeInfoPropertyName = "AllOfEnumFilterCallFilterDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterDirection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.CallFilterDirectionValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterDirectionValueItem), TypeInfoPropertyName = "CallFilterDirectionValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterUserSentiment>), TypeInfoPropertyName = "AllOfEnumFilterCallFilterUserSentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterUserSentiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.CallFilterUserSentimentValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterUserSentimentValueItem), TypeInfoPropertyName = "CallFilterUserSentimentValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDataStorageSetting>), TypeInfoPropertyName = "AllOfEnumFilterCallFilterDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterDataStorageSetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.CallFilterDataStorageSettingValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterDataStorageSettingValueItem), TypeInfoPropertyName = "CallFilterDataStorageSettingValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ToolCallFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StoredCallFilter), TypeInfoPropertyName = "StoredCallFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StoredCallFilterVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterChatStatus>), TypeInfoPropertyName = "AllOfEnumFilterChatFilterChatStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatFilterChatStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ChatFilterChatStatusValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatFilterChatStatusValueItem), TypeInfoPropertyName = "ChatFilterChatStatusValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterDisconnectionReason>), TypeInfoPropertyName = "AllOfEnumFilterChatFilterDisconnectionReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatFilterDisconnectionReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterUserSentiment>), TypeInfoPropertyName = "AllOfEnumFilterChatFilterUserSentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatFilterUserSentiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ChatFilterUserSentimentValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatFilterUserSentimentValueItem), TypeInfoPropertyName = "ChatFilterUserSentimentValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.StringFilter, global::RetellAI.PresentFilter>), TypeInfoPropertyName = "OneOfStringFilterPresentFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactsRequestSortOrder), TypeInfoPropertyName = "ListContactsRequestSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Duration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ElseEdgeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ElseEdgeVariant2TransitionCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ElseEdgeVariant2TransitionConditionType), TypeInfoPropertyName = "ElseEdgeVariant2TransitionConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ElseEdgeVariant2TransitionConditionPrompt), TypeInfoPropertyName = "ElseEdgeVariant2TransitionConditionPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndCallTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndCallToolType), TypeInfoPropertyName = "EndCallToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndCallToolExecutionMessageType), TypeInfoPropertyName = "EndCallToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndNodeVariant2Type), TypeInfoPropertyName = "EndNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EnumAnalysisDataType), TypeInfoPropertyName = "EnumAnalysisDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EquationCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EquationConditionType), TypeInfoPropertyName = "EquationConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.Equation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Equation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EquationConditionOperator), TypeInfoPropertyName = "EquationConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EquationOperator), TypeInfoPropertyName = "EquationOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ExtractDynamicVariableTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ExtractDynamicVariableToolType), TypeInfoPropertyName = "ExtractDynamicVariableToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AnalysisData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ExtractDynamicVariablesNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ExtractDynamicVariablesNodeVariant2Type), TypeInfoPropertyName = "ExtractDynamicVariablesNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FinetuneExampleUtterance), TypeInfoPropertyName = "FinetuneExampleUtterance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FinetuneExampleUtteranceVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FinetuneExampleUtteranceVariant1Role), TypeInfoPropertyName = "FinetuneExampleUtteranceVariant1Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FinetuneExampleUtteranceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FinetuneExampleUtteranceVariant2Role), TypeInfoPropertyName = "FinetuneExampleUtteranceVariant2Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FinetuneExampleUtteranceVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FinetuneExampleUtteranceVariant3Role), TypeInfoPropertyName = "FinetuneExampleUtteranceVariant3Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FunctionNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FunctionNodeVariant2Type), TypeInfoPropertyName = "FunctionNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FunctionNodeVariant2ToolType), TypeInfoPropertyName = "FunctionNodeVariant2ToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CodeNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CodeNodeVariant2Type), TypeInfoPropertyName = "CodeNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GlobalNodeFinetuneTransitionExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.FinetuneExampleUtterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GlobalNodeSetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.GlobalNodeFinetuneTransitionExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.UtteranceHallucination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceHallucination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.Duration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseAddSourcesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.KnowledgeBaseAddSourcesRequestKnowledgeBaseText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseAddSourcesRequestKnowledgeBaseText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.KnowledgeBaseRequestKnowledgeBaseText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseRequestKnowledgeBaseText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseResponseStatus), TypeInfoPropertyName = "KnowledgeBaseResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.OneOf<global::RetellAI.KnowledgeBaseSourceDocument, global::RetellAI.KnowledgeBaseSourceText, global::RetellAI.KnowledgeBaseSourceUrl>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.KnowledgeBaseSourceDocument, global::RetellAI.KnowledgeBaseSourceText, global::RetellAI.KnowledgeBaseSourceUrl>), TypeInfoPropertyName = "OneOfKnowledgeBaseSourceDocumentKnowledgeBaseSourceTextKnowledgeBaseSourceUrl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseSourceDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseSourceText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseSourceUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseSourceDocumentType), TypeInfoPropertyName = "KnowledgeBaseSourceDocumentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseSourceTextType), TypeInfoPropertyName = "KnowledgeBaseSourceTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseSourceUrlType), TypeInfoPropertyName = "KnowledgeBaseSourceUrlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.LLMModel), TypeInfoPropertyName = "LLMModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MCPNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MCPNodeVariant2Type), TypeInfoPropertyName = "MCPNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MCPToolDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MCPTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MCPToolType), TypeInfoPropertyName = "MCPToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MCPToolExecutionMessageType), TypeInfoPropertyName = "MCPToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Message), TypeInfoPropertyName = "Message2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallInvocationMessage), TypeInfoPropertyName = "ToolCallInvocationMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallResultMessage), TypeInfoPropertyName = "ToolCallResultMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionMessage), TypeInfoPropertyName = "NodeTransitionMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StateTransitionMessage), TypeInfoPropertyName = "StateTransitionMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.InjectedMessage), TypeInfoPropertyName = "InjectedMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsMessage), TypeInfoPropertyName = "SmsMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatMessageInput), TypeInfoPropertyName = "ChatMessageInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MessageBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallInvocationMessageBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallResultMessageBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionMessageBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StateTransitionMessageBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.InjectedMessageBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsMessageBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MessageBaseRole), TypeInfoPropertyName = "MessageBaseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.InjectedMessageBaseRole), TypeInfoPropertyName = "InjectedMessageBaseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsMessageBaseRole), TypeInfoPropertyName = "SmsMessageBaseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.PerformanceMetricCriteria, global::RetellAI.CustomMetricCriteria>), TypeInfoPropertyName = "OneOfPerformanceMetricCriteriaCustomMetricCriteria2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PerformanceMetricCriteria))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<double?, bool?, string>), TypeInfoPropertyName = "OneOfDoubleBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.UtteranceTranscriptionError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceTranscriptionError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Wer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.UtteranceTranscriptionErrorMieDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceTranscriptionErrorMieDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ModelChoiceCascading))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ModelChoiceCascadingType), TypeInfoPropertyName = "ModelChoiceCascadingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ModelChoice), TypeInfoPropertyName = "ModelChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NaturalnessIssue), TypeInfoPropertyName = "NaturalnessIssue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeBaseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeBaseCommonDisplayPosition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.PromptCondition, global::RetellAI.EquationCondition>), TypeInfoPropertyName = "OneOfPromptConditionEquationCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PromptCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeInstructionPromptType), TypeInfoPropertyName = "NodeInstructionPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeInstructionStaticText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeInstructionStaticTextType), TypeInfoPropertyName = "NodeInstructionStaticTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsInstructionTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsInstructionTemplateType), TypeInfoPropertyName = "SmsInstructionTemplateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsInstructionTemplateTemplate), TypeInfoPropertyName = "SmsInstructionTemplateTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.CustomTool, global::RetellAI.CheckAvailabilityCalTool, global::RetellAI.BookAppointmentCalTool>), TypeInfoPropertyName = "OneOfCustomToolCheckAvailabilityCalToolBookAppointmentCalTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeToolVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.NodeTransitionAnalysisDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionAnalysisDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionMessageBaseRole), TypeInfoPropertyName = "NodeTransitionMessageBaseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionMessageBaseTransitionType), TypeInfoPropertyName = "NodeTransitionMessageBaseTransitionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionUtterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionUtteranceRole), TypeInfoPropertyName = "NodeTransitionUtteranceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionUtteranceTransitionType), TypeInfoPropertyName = "NodeTransitionUtteranceTransitionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NumberAnalysisDataType), TypeInfoPropertyName = "NumberAnalysisDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PresetAnalysisData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PresetAnalysisDataType), TypeInfoPropertyName = "PresetAnalysisDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PresetAnalysisDataName), TypeInfoPropertyName = "PresetAnalysisDataName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallPresetAnalysisDataType), TypeInfoPropertyName = "CallPresetAnalysisDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallPresetAnalysisDataName), TypeInfoPropertyName = "CallPresetAnalysisDataName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatPresetAnalysisDataType), TypeInfoPropertyName = "ChatPresetAnalysisDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatPresetAnalysisDataName), TypeInfoPropertyName = "ChatPresetAnalysisDataName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Organization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.OrganizationWebhookUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OrganizationWebhookUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OrganizationCpsConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AutoCreditReloadConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorOverageConfig), TypeInfoPropertyName = "ConductorOverageConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OrganizationResponse), TypeInfoPropertyName = "OrganizationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OrganizationResponseVariant2))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableLLMModel), TypeInfoPropertyName = "NullableLLMModel_RetellAI_NullableLLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.LLMModel?), TypeInfoPropertyName = "NullableLLMModel_RetellAI_LLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OrganizationResponseVariant2EnterprisePlanStatus), TypeInfoPropertyName = "OrganizationResponseVariant2EnterprisePlanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PIIConfigMode), TypeInfoPropertyName = "PIIConfigMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.PIIConfigCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PIIConfigCategorie), TypeInfoPropertyName = "PIIConfigCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.GuardrailConfigOutputTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GuardrailConfigOutputTopic), TypeInfoPropertyName = "GuardrailConfigOutputTopic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.GuardrailConfigInputTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GuardrailConfigInputTopic), TypeInfoPropertyName = "GuardrailConfigInputTopic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PerformanceMetricCriteriaOp), TypeInfoPropertyName = "PerformanceMetricCriteriaOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberResponsePhoneNumberType), TypeInfoPropertyName = "PhoneNumberResponsePhoneNumberType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AgentWeight>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberResponseSipOutboundTrunkConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PressDigitNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PressDigitNodeVariant2Type), TypeInfoPropertyName = "PressDigitNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PressDigitTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PressDigitToolType), TypeInfoPropertyName = "PressDigitToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PromptConditionType), TypeInfoPropertyName = "PromptConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.QaViewFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.QaViewFilterDisconnectionReason>), TypeInfoPropertyName = "AllOfEnumFilterQaViewFilterDisconnectionReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.QaViewFilterDisconnectionReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<bool?, global::RetellAI.BooleanFilter>), TypeInfoPropertyName = "OneOfBooleanBooleanFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.QaViewFilterScoreRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.QaViewFilterScoreRangeType), TypeInfoPropertyName = "QaViewFilterScoreRangeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.QaViewFilterScoreRangeOp), TypeInfoPropertyName = "QaViewFilterScoreRangeOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortQaListArgs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortQaListArgsSortKey), TypeInfoPropertyName = "CohortQaListArgsSortKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortQaListArgsOrder), TypeInfoPropertyName = "CohortQaListArgsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RAGAccuracy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.RAGAccuracyMissedChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RAGAccuracyMissedChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.RAGAccuracy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ResponseEngineConversationFlow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ResponseEngineConversationFlowType), TypeInfoPropertyName = "ResponseEngineConversationFlowType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ResponseEngineCustomLm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ResponseEngineCustomLmType), TypeInfoPropertyName = "ResponseEngineCustomLmType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ResponseEngineRetellLm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ResponseEngineRetellLmType), TypeInfoPropertyName = "ResponseEngineRetellLmType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellResponseEngine), TypeInfoPropertyName = "RetellResponseEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLLMResponse), TypeInfoPropertyName = "RetellLLMResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLLMResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLlmRequest), TypeInfoPropertyName = "RetellLlmRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLLMResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLlmOverrideS2sModel), TypeInfoPropertyName = "RetellLlmOverrideS2sModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLlmOverrideStartSpeaker), TypeInfoPropertyName = "RetellLlmOverrideStartSpeaker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLlmRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.State>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.State))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ScoringCriteriaCustomCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ScoringCriteriaCustomCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.PerformanceMetricCriteria>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SendSMSTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SendSMSToolType), TypeInfoPropertyName = "SendSMSToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SendSMSToolExecutionMessageType), TypeInfoPropertyName = "SendSMSToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsContent), TypeInfoPropertyName = "SmsContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSender), TypeInfoPropertyName = "SmsSender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSenderVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSenderVariant1Type), TypeInfoPropertyName = "SmsSenderVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSenderVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSenderVariant2Type), TypeInfoPropertyName = "SmsSenderVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsDestination), TypeInfoPropertyName = "SmsDestination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsDestinationVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsDestinationVariant1Type), TypeInfoPropertyName = "SmsDestinationVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsDestinationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsDestinationVariant2Type), TypeInfoPropertyName = "SmsDestinationVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.OneOf<global::RetellAI.SentimentAnalysisDetailVariant1, global::RetellAI.SentimentAnalysisDetailVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.SentimentAnalysisDetailVariant1, global::RetellAI.SentimentAnalysisDetailVariant2>), TypeInfoPropertyName = "OneOfSentimentAnalysisDetailVariant1SentimentAnalysisDetailVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SentimentAnalysisDetailVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SentimentAnalysisDetailVariant1Sentiment), TypeInfoPropertyName = "SentimentAnalysisDetailVariant1Sentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SentimentAnalysisDetailVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SentimentAnalysisDetailVariant2Sentiment), TypeInfoPropertyName = "SentimentAnalysisDetailVariant2Sentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SkipResponseEdgeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SkipResponseEdgeVariant2TransitionCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SkipResponseEdgeVariant2TransitionConditionType), TypeInfoPropertyName = "SkipResponseEdgeVariant2TransitionConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SkipResponseEdgeVariant2TransitionConditionPrompt), TypeInfoPropertyName = "SkipResponseEdgeVariant2TransitionConditionPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlwaysEdgeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlwaysEdgeVariant2TransitionCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlwaysEdgeVariant2TransitionConditionType), TypeInfoPropertyName = "AlwaysEdgeVariant2TransitionConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlwaysEdgeVariant2TransitionConditionPrompt), TypeInfoPropertyName = "AlwaysEdgeVariant2TransitionConditionPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsContentInferred))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsContentInferredType), TypeInfoPropertyName = "SmsContentInferredType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsContentPredefined))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsContentPredefinedType), TypeInfoPropertyName = "SmsContentPredefinedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsContentTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsContentTemplateType), TypeInfoPropertyName = "SmsContentTemplateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsContentTemplateTemplate), TypeInfoPropertyName = "SmsContentTemplateTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsFailedEdge), TypeInfoPropertyName = "SmsFailedEdge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsFailedEdgeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsFailedEdgeVariant2TransitionCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsFailedEdgeVariant2TransitionConditionType), TypeInfoPropertyName = "SmsFailedEdgeVariant2TransitionConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsFailedEdgeVariant2TransitionConditionPrompt), TypeInfoPropertyName = "SmsFailedEdgeVariant2TransitionConditionPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsNodeVariant2Type), TypeInfoPropertyName = "SmsNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.NodeInstruction?, global::RetellAI.SmsInstructionTemplate>), TypeInfoPropertyName = "OneOfNodeInstructionSmsInstructionTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSuccessEdge), TypeInfoPropertyName = "SmsSuccessEdge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSuccessEdgeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSuccessEdgeVariant2TransitionCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionType), TypeInfoPropertyName = "SmsSuccessEdgeVariant2TransitionConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionPrompt), TypeInfoPropertyName = "SmsSuccessEdgeVariant2TransitionConditionPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StateEdge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StateTransitionMessageBaseRole), TypeInfoPropertyName = "StateTransitionMessageBaseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.StateEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StringAnalysisDataType), TypeInfoPropertyName = "StringAnalysisDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseBatchJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseBatchJobStatus), TypeInfoPropertyName = "TestCaseBatchJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseDefinitionInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ToolMock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolMock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseDefinition), TypeInfoPropertyName = "TestCaseDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseDefinitionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseDefinitionVariant2Type), TypeInfoPropertyName = "TestCaseDefinitionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseJobStatus), TypeInfoPropertyName = "TestCaseJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolMockInputMatchRule), TypeInfoPropertyName = "ToolMockInputMatchRule2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolMockInputMatchRuleVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolMockInputMatchRuleVariant1Type), TypeInfoPropertyName = "ToolMockInputMatchRuleVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolMockInputMatchRuleVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolMockInputMatchRuleVariant2Type), TypeInfoPropertyName = "ToolMockInputMatchRuleVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.UtteranceToolCallAccuracy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceToolCallAccuracy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallInvocationMessageBaseRole), TypeInfoPropertyName = "ToolCallInvocationMessageBaseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallInvocationUtterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallInvocationUtteranceRole), TypeInfoPropertyName = "ToolCallInvocationUtteranceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallResultMessageBaseRole), TypeInfoPropertyName = "ToolCallResultMessageBaseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallResultUtterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallResultUtteranceRole), TypeInfoPropertyName = "ToolCallResultUtteranceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolParameterType), TypeInfoPropertyName = "ToolParameterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferCallTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferCallNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferCallNodeVariant2Type), TypeInfoPropertyName = "TransferCallNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferDestination), TypeInfoPropertyName = "TransferDestination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOption), TypeInfoPropertyName = "TransferOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferCallToolType), TypeInfoPropertyName = "TransferCallToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferCallToolExecutionMessageType), TypeInfoPropertyName = "TransferCallToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferDestinationInferred))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferDestinationInferredType), TypeInfoPropertyName = "TransferDestinationInferredType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferDestinationPredefined))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferDestinationPredefinedType), TypeInfoPropertyName = "TransferDestinationPredefinedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferFailedEdgeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferFailedEdgeVariant2TransitionCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferFailedEdgeVariant2TransitionConditionType), TypeInfoPropertyName = "TransferFailedEdgeVariant2TransitionConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferFailedEdgeVariant2TransitionConditionPrompt), TypeInfoPropertyName = "TransferFailedEdgeVariant2TransitionConditionPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionAgenticWarmTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionAgenticWarmTransferType), TypeInfoPropertyName = "TransferOptionAgenticWarmTransferType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionAgenticWarmTransferOnHoldMusic), TypeInfoPropertyName = "TransferOptionAgenticWarmTransferOnHoldMusic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.WarmTransferPrompt, global::RetellAI.WarmTransferStaticMessage>), TypeInfoPropertyName = "OneOfWarmTransferPromptWarmTransferStaticMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.WarmTransferPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.WarmTransferStaticMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionAgenticWarmTransferAgenticTransferConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionAgenticWarmTransferAgenticTransferConfigTransferAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeout), TypeInfoPropertyName = "TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeout2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionColdTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionColdTransferType), TypeInfoPropertyName = "TransferOptionColdTransferType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionColdTransferColdTransferMode), TypeInfoPropertyName = "TransferOptionColdTransferColdTransferMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionWarmTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionWarmTransferType), TypeInfoPropertyName = "TransferOptionWarmTransferType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionWarmTransferOnHoldMusic), TypeInfoPropertyName = "TransferOptionWarmTransferOnHoldMusic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateOrganizationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateOrganizationRequestAutoCreditReloadConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SpendBudgetCustomAlertRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateSpendBudgetRequest), TypeInfoPropertyName = "UpdateSpendBudgetRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateSpendBudgetRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateSpendBudgetRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.SpendBudgetCustomAlertRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UserFormRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceHallucinationHallucinationType), TypeInfoPropertyName = "UtteranceHallucinationHallucinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.NaturalnessIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceOrToolCall), TypeInfoPropertyName = "UtteranceOrToolCall2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Utterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceRole), TypeInfoPropertyName = "UtteranceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.UtteranceWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2CallBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2CallBaseCallStatus), TypeInfoPropertyName = "V2CallBaseCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2CallBaseDataStorageSetting), TypeInfoPropertyName = "V2CallBaseDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.Utterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.UtteranceOrToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2CallBaseLatency))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2CallBaseCallCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2CallBaseLlmTokenUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2CallResponse), TypeInfoPropertyName = "V2CallResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2WebCallResponse), TypeInfoPropertyName = "V2WebCallResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2PhoneCallResponse), TypeInfoPropertyName = "V2PhoneCallResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3CallResponse), TypeInfoPropertyName = "V3CallResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3WebCallResponse), TypeInfoPropertyName = "V3WebCallResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3PhoneCallResponse), TypeInfoPropertyName = "V3PhoneCallResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3CallBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3CallBaseCallStatus), TypeInfoPropertyName = "V3CallBaseCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3CallBaseDataStorageSetting), TypeInfoPropertyName = "V3CallBaseDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3CallBaseLatency))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3CallBaseCallCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3CallBaseLlmTokenUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3PhoneCallResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3PhoneCallResponseVariant1CallType), TypeInfoPropertyName = "V3PhoneCallResponseVariant1CallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3PhoneCallResponseVariant1Direction), TypeInfoPropertyName = "V3PhoneCallResponseVariant1Direction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3PhoneCallResponseVariant1TelephonyIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3WebCallResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3WebCallResponseVariant1CallType), TypeInfoPropertyName = "V3WebCallResponseVariant1CallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3ListCallsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3ListCallsRequestSortOrder), TypeInfoPropertyName = "V3ListCallsRequestSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2PhoneCallResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2PhoneCallResponseVariant1CallType), TypeInfoPropertyName = "V2PhoneCallResponseVariant1CallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2PhoneCallResponseVariant1Direction), TypeInfoPropertyName = "V2PhoneCallResponseVariant1Direction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2PhoneCallResponseVariant1TelephonyIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2WebCallResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2WebCallResponseVariant1CallType), TypeInfoPropertyName = "V2WebCallResponseVariant1CallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoiceResponseProvider), TypeInfoPropertyName = "VoiceResponseProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoiceResponseGender), TypeInfoPropertyName = "VoiceResponseGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoicemailActionBridgeTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoicemailActionBridgeTransferType), TypeInfoPropertyName = "VoicemailActionBridgeTransferType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoicemailActionHangup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoicemailActionHangupType), TypeInfoPropertyName = "VoicemailActionHangupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoicemailActionPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoicemailActionPromptType), TypeInfoPropertyName = "VoicemailActionPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoicemailActionStaticText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoicemailActionStaticTextType), TypeInfoPropertyName = "VoicemailActionStaticTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.IvrActionHangup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.IvrActionHangupType), TypeInfoPropertyName = "IvrActionHangupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.IvrAction), TypeInfoPropertyName = "IvrAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.WarmTransferPromptType), TypeInfoPropertyName = "WarmTransferPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.WarmTransferStaticMessageType), TypeInfoPropertyName = "WarmTransferStaticMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorOverageConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorOverageConfigVariant1Mode), TypeInfoPropertyName = "ConductorOverageConfigVariant1Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorOverageConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorOverageConfigVariant2Mode), TypeInfoPropertyName = "ConductorOverageConfigVariant2Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorOverageConfigVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorOverageConfigVariant3Mode), TypeInfoPropertyName = "ConductorOverageConfigVariant3Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Contact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.Contact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactConversation), TypeInfoPropertyName = "ContactConversation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactChat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactCallType), TypeInfoPropertyName = "ContactCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactCallDirection), TypeInfoPropertyName = "ContactCallDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactCallSentiment), TypeInfoPropertyName = "ContactCallSentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactChatType), TypeInfoPropertyName = "ContactChatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactChatDirection), TypeInfoPropertyName = "ContactChatDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactChatSentiment), TypeInfoPropertyName = "ContactChatSentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactConversationListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ContactConversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppType), TypeInfoPropertyName = "AppType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppConnectionStatus), TypeInfoPropertyName = "AppConnectionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OAuthConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OAuthConfigRequestType), TypeInfoPropertyName = "OAuthConfigRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ApiKeyAuthConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ApiKeyAuthConfigRequestType), TypeInfoPropertyName = "ApiKeyAuthConfigRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AccessTokenAuthConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AccessTokenAuthConfigRequestType), TypeInfoPropertyName = "AccessTokenAuthConfigRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BasicAuthConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BasicAuthConfigRequestType), TypeInfoPropertyName = "BasicAuthConfigRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RefreshTokenAuthConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RefreshTokenAuthConfigRequestType), TypeInfoPropertyName = "RefreshTokenAuthConfigRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AuthConfigRequest), TypeInfoPropertyName = "AuthConfigRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OAuthConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OAuthConfigResponseType), TypeInfoPropertyName = "OAuthConfigResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ApiKeyAuthConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ApiKeyAuthConfigResponseType), TypeInfoPropertyName = "ApiKeyAuthConfigResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AccessTokenAuthConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AccessTokenAuthConfigResponseType), TypeInfoPropertyName = "AccessTokenAuthConfigResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BasicAuthConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BasicAuthConfigResponseType), TypeInfoPropertyName = "BasicAuthConfigResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RefreshTokenAuthConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RefreshTokenAuthConfigResponseType), TypeInfoPropertyName = "RefreshTokenAuthConfigResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppAuthConfigResponse), TypeInfoPropertyName = "AppAuthConfigResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CRMSyncMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppCRMConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.CRMSyncMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppUsageResponse), TypeInfoPropertyName = "AppUsageResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentAppUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseAppUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentAppUsageType), TypeInfoPropertyName = "AgentAppUsageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseAppUsageType), TypeInfoPropertyName = "KnowledgeBaseAppUsageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CRMCustomFieldSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CRMCustomFieldSchemaType), TypeInfoPropertyName = "CRMCustomFieldSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CRMAnalysisDataMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CRMAnalysisDataMappingUpdateMode), TypeInfoPropertyName = "CRMAnalysisDataMappingUpdateMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CRMConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.CRMCustomFieldSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.CRMAnalysisDataMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.JobStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.JobStatusStatus), TypeInfoPropertyName = "JobStatusStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.JobStatusTriggeredBy), TypeInfoPropertyName = "JobStatusTriggeredBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DashboardSource), TypeInfoPropertyName = "DashboardSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartGroupItem), TypeInfoPropertyName = "ChartGroupItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartGroupItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartGroupItemVariant1Type), TypeInfoPropertyName = "ChartGroupItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartGroupItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartGroupItemVariant2Type), TypeInfoPropertyName = "ChartGroupItemVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.AgentRequest, object>), TypeInfoPropertyName = "AllOfAgentRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.BatchCallTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.TestCaseDefinitionInput, object>), TypeInfoPropertyName = "AllOfTestCaseDefinitionInputObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.ChatAgentRequest, object>), TypeInfoPropertyName = "AllOfChatAgentRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ChatMessageInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberRequestNumberProvider), TypeInfoPropertyName = "CreatePhoneNumberRequestNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberRequestCountryCode), TypeInfoPropertyName = "CreatePhoneNumberRequestCountryCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceRequestVoiceProvider), TypeInfoPropertyName = "CloneVoiceRequestVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceRequestVoiceProvider), TypeInfoPropertyName = "AddCommunityVoiceRequestVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceRequestVoiceProvider), TypeInfoPropertyName = "SearchCommunityVoiceRequestVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ImportPhoneNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataRequestDataStorageSetting), TypeInfoPropertyName = "UpdateChatMetadataRequestDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallRequestDirection), TypeInfoPropertyName = "RegisterPhoneCallRequestDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataRequestDataStorageSetting), TypeInfoPropertyName = "UpdateCallMetadataRequestDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallRequestFieldsToOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallRequestFieldsToOverrideDataStorageSetting), TypeInfoPropertyName = "UpdateLiveCallRequestFieldsToOverrideDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallRequestCallControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateContactRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateContactRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAppRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAppRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCrmConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackfillContactAnalysisDataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackfillContactAnalysisDataRequestBackfillCallFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsType), TypeInfoPropertyName = "ListTestCaseDefinitionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsType), TypeInfoPropertyName = "ListBatchTestsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsSortOrder), TypeInfoPropertyName = "ListAgentVersionsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsSortOrder), TypeInfoPropertyName = "ListAgentsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsSortOrder), TypeInfoPropertyName = "ListConversationFlowComponentsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsSortOrder), TypeInfoPropertyName = "ListConversationFlowsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersSortOrder), TypeInfoPropertyName = "ListPhoneNumbersSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMSortOrder), TypeInfoPropertyName = "ListRetellLLMSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsSortOrder), TypeInfoPropertyName = "ListExportRequestsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppsSortOrder), TypeInfoPropertyName = "ListAppsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppUsagesSortOrder), TypeInfoPropertyName = "ListAppUsagesSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus), TypeInfoPropertyName = "AddKnowledgeBaseSourcesResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus2), TypeInfoPropertyName = "AddKnowledgeBaseSourcesResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus3), TypeInfoPropertyName = "AddKnowledgeBaseSourcesResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus4), TypeInfoPropertyName = "AddKnowledgeBaseSourcesResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus5), TypeInfoPropertyName = "AddKnowledgeBaseSourcesResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentResponseStatus), TypeInfoPropertyName = "CreateAgentResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentResponseStatus2), TypeInfoPropertyName = "CreateAgentResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentResponseStatus3), TypeInfoPropertyName = "CreateAgentResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentResponseStatus4), TypeInfoPropertyName = "CreateAgentResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallResponseStatus), TypeInfoPropertyName = "CreateBatchCallResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallResponseStatus2), TypeInfoPropertyName = "CreateBatchCallResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallResponseStatus3), TypeInfoPropertyName = "CreateBatchCallResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallResponseStatus4), TypeInfoPropertyName = "CreateBatchCallResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponseStatus), TypeInfoPropertyName = "CreateBatchTestResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponseStatus2), TypeInfoPropertyName = "CreateBatchTestResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponseStatus3), TypeInfoPropertyName = "CreateBatchTestResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponseStatus4), TypeInfoPropertyName = "CreateBatchTestResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponseStatus5), TypeInfoPropertyName = "CreateBatchTestResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus), TypeInfoPropertyName = "CreateTestCaseDefinitionResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus2), TypeInfoPropertyName = "CreateTestCaseDefinitionResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus3), TypeInfoPropertyName = "CreateTestCaseDefinitionResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus4), TypeInfoPropertyName = "CreateTestCaseDefinitionResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus5), TypeInfoPropertyName = "CreateTestCaseDefinitionResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus), TypeInfoPropertyName = "DeleteTestCaseDefinitionResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus2), TypeInfoPropertyName = "DeleteTestCaseDefinitionResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus3), TypeInfoPropertyName = "DeleteTestCaseDefinitionResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus4), TypeInfoPropertyName = "DeleteTestCaseDefinitionResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus5), TypeInfoPropertyName = "DeleteTestCaseDefinitionResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus), TypeInfoPropertyName = "GetTestCaseDefinitionResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus2), TypeInfoPropertyName = "GetTestCaseDefinitionResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus3), TypeInfoPropertyName = "GetTestCaseDefinitionResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus4), TypeInfoPropertyName = "GetTestCaseDefinitionResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus5), TypeInfoPropertyName = "GetTestCaseDefinitionResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListTestCaseDefinitionsResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListTestCaseDefinitionsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.TestCaseDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus), TypeInfoPropertyName = "ListTestCaseDefinitionsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus2), TypeInfoPropertyName = "ListTestCaseDefinitionsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus3), TypeInfoPropertyName = "ListTestCaseDefinitionsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus4), TypeInfoPropertyName = "ListTestCaseDefinitionsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus), TypeInfoPropertyName = "UpdateTestCaseDefinitionResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus2), TypeInfoPropertyName = "UpdateTestCaseDefinitionResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus3), TypeInfoPropertyName = "UpdateTestCaseDefinitionResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus4), TypeInfoPropertyName = "UpdateTestCaseDefinitionResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus5), TypeInfoPropertyName = "UpdateTestCaseDefinitionResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponseStatus), TypeInfoPropertyName = "GetBatchTestResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponseStatus2), TypeInfoPropertyName = "GetBatchTestResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponseStatus3), TypeInfoPropertyName = "GetBatchTestResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponseStatus4), TypeInfoPropertyName = "GetBatchTestResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponseStatus5), TypeInfoPropertyName = "GetBatchTestResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListBatchTestsResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListBatchTestsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.TestCaseBatchJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponseStatus), TypeInfoPropertyName = "ListBatchTestsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponseStatus2), TypeInfoPropertyName = "ListBatchTestsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponseStatus3), TypeInfoPropertyName = "ListBatchTestsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponseStatus4), TypeInfoPropertyName = "ListBatchTestsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponseStatus), TypeInfoPropertyName = "GetTestRunResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponseStatus2), TypeInfoPropertyName = "GetTestRunResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponseStatus3), TypeInfoPropertyName = "GetTestRunResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponseStatus4), TypeInfoPropertyName = "GetTestRunResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponseStatus5), TypeInfoPropertyName = "GetTestRunResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListTestRunsResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListTestRunsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.TestCaseJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponseStatus), TypeInfoPropertyName = "ListTestRunsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponseStatus2), TypeInfoPropertyName = "ListTestRunsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponseStatus3), TypeInfoPropertyName = "ListTestRunsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponseStatus4), TypeInfoPropertyName = "ListTestRunsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponseStatus5), TypeInfoPropertyName = "ListTestRunsResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatAgentResponseStatus), TypeInfoPropertyName = "CreateChatAgentResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatAgentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatAgentResponseStatus2), TypeInfoPropertyName = "CreateChatAgentResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatAgentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatAgentResponseStatus3), TypeInfoPropertyName = "CreateChatAgentResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatAgentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatAgentResponseStatus4), TypeInfoPropertyName = "CreateChatAgentResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus), TypeInfoPropertyName = "AgentPlaygroundCompletionResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus2), TypeInfoPropertyName = "AgentPlaygroundCompletionResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus3), TypeInfoPropertyName = "AgentPlaygroundCompletionResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus4), TypeInfoPropertyName = "AgentPlaygroundCompletionResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus5), TypeInfoPropertyName = "AgentPlaygroundCompletionResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus6), TypeInfoPropertyName = "AgentPlaygroundCompletionResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponse2))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableLLMModel), TypeInfoPropertyName = "NullableLLMModel_RetellAI_NullableLLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.LLMModel?), TypeInfoPropertyName = "NullableLLMModel_RetellAI_LLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponseStatus), TypeInfoPropertyName = "CreateChatCompletionResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponseStatus2), TypeInfoPropertyName = "CreateChatCompletionResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponseStatus3), TypeInfoPropertyName = "CreateChatCompletionResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponseStatus4), TypeInfoPropertyName = "CreateChatCompletionResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponseStatus5), TypeInfoPropertyName = "CreateChatCompletionResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponseStatus6), TypeInfoPropertyName = "CreateChatCompletionResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponseStatus), TypeInfoPropertyName = "CreateChatResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponseStatus2), TypeInfoPropertyName = "CreateChatResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponseStatus3), TypeInfoPropertyName = "CreateChatResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponseStatus4), TypeInfoPropertyName = "CreateChatResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponseStatus5), TypeInfoPropertyName = "CreateChatResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponseStatus6), TypeInfoPropertyName = "CreateChatResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus), TypeInfoPropertyName = "CreateConversationFlowComponentResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus2), TypeInfoPropertyName = "CreateConversationFlowComponentResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus3), TypeInfoPropertyName = "CreateConversationFlowComponentResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus4), TypeInfoPropertyName = "CreateConversationFlowComponentResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus5), TypeInfoPropertyName = "CreateConversationFlowComponentResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponseStatus), TypeInfoPropertyName = "CreateConversationFlowResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponseStatus2), TypeInfoPropertyName = "CreateConversationFlowResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponseStatus3), TypeInfoPropertyName = "CreateConversationFlowResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponseStatus4), TypeInfoPropertyName = "CreateConversationFlowResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponseStatus5), TypeInfoPropertyName = "CreateConversationFlowResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus), TypeInfoPropertyName = "CreateKnowledgeBaseResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus2), TypeInfoPropertyName = "CreateKnowledgeBaseResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus3), TypeInfoPropertyName = "CreateKnowledgeBaseResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus4), TypeInfoPropertyName = "CreateKnowledgeBaseResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus5), TypeInfoPropertyName = "CreateKnowledgeBaseResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberResponseStatus), TypeInfoPropertyName = "CreatePhoneNumberResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberResponseStatus2), TypeInfoPropertyName = "CreatePhoneNumberResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberResponseStatus3), TypeInfoPropertyName = "CreatePhoneNumberResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateRetellLLMResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateRetellLLMResponseStatus), TypeInfoPropertyName = "CreateRetellLLMResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateRetellLLMResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateRetellLLMResponseStatus2), TypeInfoPropertyName = "CreateRetellLLMResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateRetellLLMResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateRetellLLMResponseStatus3), TypeInfoPropertyName = "CreateRetellLLMResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponseStatus), TypeInfoPropertyName = "CreateSmsChatResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponseStatus2), TypeInfoPropertyName = "CreateSmsChatResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponseStatus3), TypeInfoPropertyName = "CreateSmsChatResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponseStatus4), TypeInfoPropertyName = "CreateSmsChatResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponseStatus5), TypeInfoPropertyName = "CreateSmsChatResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponseStatus6), TypeInfoPropertyName = "CreateSmsChatResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentResponseStatus), TypeInfoPropertyName = "DeleteAgentResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentResponseStatus2), TypeInfoPropertyName = "DeleteAgentResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentResponseStatus3), TypeInfoPropertyName = "DeleteAgentResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentResponseStatus4), TypeInfoPropertyName = "DeleteAgentResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatResponseStatus), TypeInfoPropertyName = "DeleteChatResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatResponseStatus2), TypeInfoPropertyName = "DeleteChatResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatResponseStatus3), TypeInfoPropertyName = "DeleteChatResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatResponseStatus4), TypeInfoPropertyName = "DeleteChatResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatAgentResponseStatus), TypeInfoPropertyName = "DeleteChatAgentResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatAgentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatAgentResponseStatus2), TypeInfoPropertyName = "DeleteChatAgentResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatAgentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatAgentResponseStatus3), TypeInfoPropertyName = "DeleteChatAgentResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatAgentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatAgentResponseStatus4), TypeInfoPropertyName = "DeleteChatAgentResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowComponentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus), TypeInfoPropertyName = "DeleteConversationFlowComponentResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowComponentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus2), TypeInfoPropertyName = "DeleteConversationFlowComponentResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowComponentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus3), TypeInfoPropertyName = "DeleteConversationFlowComponentResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowComponentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus4), TypeInfoPropertyName = "DeleteConversationFlowComponentResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponseStatus), TypeInfoPropertyName = "DeleteConversationFlowResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponseStatus2), TypeInfoPropertyName = "DeleteConversationFlowResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponseStatus3), TypeInfoPropertyName = "DeleteConversationFlowResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponseStatus4), TypeInfoPropertyName = "DeleteConversationFlowResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponseStatus5), TypeInfoPropertyName = "DeleteConversationFlowResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus), TypeInfoPropertyName = "DeleteKnowledgeBaseSourceResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus2), TypeInfoPropertyName = "DeleteKnowledgeBaseSourceResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus3), TypeInfoPropertyName = "DeleteKnowledgeBaseSourceResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus4), TypeInfoPropertyName = "DeleteKnowledgeBaseSourceResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus), TypeInfoPropertyName = "DeleteKnowledgeBaseResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus2), TypeInfoPropertyName = "DeleteKnowledgeBaseResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus3), TypeInfoPropertyName = "DeleteKnowledgeBaseResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus4), TypeInfoPropertyName = "DeleteKnowledgeBaseResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeletePhoneNumberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeletePhoneNumberResponseStatus), TypeInfoPropertyName = "DeletePhoneNumberResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeletePhoneNumberResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeletePhoneNumberResponseStatus2), TypeInfoPropertyName = "DeletePhoneNumberResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeletePhoneNumberResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeletePhoneNumberResponseStatus3), TypeInfoPropertyName = "DeletePhoneNumberResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteRetellLLMResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteRetellLLMResponseStatus), TypeInfoPropertyName = "DeleteRetellLLMResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteRetellLLMResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteRetellLLMResponseStatus2), TypeInfoPropertyName = "DeleteRetellLLMResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteRetellLLMResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteRetellLLMResponseStatus3), TypeInfoPropertyName = "DeleteRetellLLMResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteRetellLLMResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteRetellLLMResponseStatus4), TypeInfoPropertyName = "DeleteRetellLLMResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndChatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndChatResponseStatus), TypeInfoPropertyName = "EndChatResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndChatResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndChatResponseStatus2), TypeInfoPropertyName = "EndChatResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndChatResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndChatResponseStatus3), TypeInfoPropertyName = "EndChatResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndChatResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndChatResponseStatus4), TypeInfoPropertyName = "EndChatResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAgentVersionsResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListAgentVersionsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AgentVersionSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponseStatus), TypeInfoPropertyName = "ListAgentVersionsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponseStatus2), TypeInfoPropertyName = "ListAgentVersionsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponseStatus3), TypeInfoPropertyName = "ListAgentVersionsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponseStatus4), TypeInfoPropertyName = "ListAgentVersionsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponseStatus5), TypeInfoPropertyName = "ListAgentVersionsResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponseStatus6), TypeInfoPropertyName = "ListAgentVersionsResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AgentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentVersionsResponseStatus), TypeInfoPropertyName = "GetAgentVersionsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentVersionsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentVersionsResponseStatus2), TypeInfoPropertyName = "GetAgentVersionsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentVersionsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentVersionsResponseStatus3), TypeInfoPropertyName = "GetAgentVersionsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentVersionsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentVersionsResponseStatus4), TypeInfoPropertyName = "GetAgentVersionsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentResponseStatus), TypeInfoPropertyName = "GetAgentResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentResponseStatus2), TypeInfoPropertyName = "GetAgentResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentResponseStatus3), TypeInfoPropertyName = "GetAgentResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentResponseStatus4), TypeInfoPropertyName = "GetAgentResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ChatAgentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentVersionsResponseStatus), TypeInfoPropertyName = "GetChatAgentVersionsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentVersionsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentVersionsResponseStatus2), TypeInfoPropertyName = "GetChatAgentVersionsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentVersionsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentVersionsResponseStatus3), TypeInfoPropertyName = "GetChatAgentVersionsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentResponseStatus), TypeInfoPropertyName = "GetChatAgentResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentResponseStatus2), TypeInfoPropertyName = "GetChatAgentResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentResponseStatus3), TypeInfoPropertyName = "GetChatAgentResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentResponseStatus4), TypeInfoPropertyName = "GetChatAgentResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatResponseStatus), TypeInfoPropertyName = "GetChatResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatResponseStatus2), TypeInfoPropertyName = "GetChatResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatResponseStatus3), TypeInfoPropertyName = "GetChatResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatResponseStatus4), TypeInfoPropertyName = "GetChatResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConcurrencyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConcurrencyResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConcurrencyResponseStatus), TypeInfoPropertyName = "GetConcurrencyResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConcurrencyResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConcurrencyResponseStatus2), TypeInfoPropertyName = "GetConcurrencyResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetApiKeyInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetApiKeyInfoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetApiKeyInfoResponseStatus), TypeInfoPropertyName = "GetApiKeyInfoResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetApiKeyInfoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetApiKeyInfoResponseStatus2), TypeInfoPropertyName = "GetApiKeyInfoResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowComponentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowComponentResponseStatus), TypeInfoPropertyName = "GetConversationFlowComponentResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowComponentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowComponentResponseStatus2), TypeInfoPropertyName = "GetConversationFlowComponentResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowComponentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowComponentResponseStatus3), TypeInfoPropertyName = "GetConversationFlowComponentResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowComponentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowComponentResponseStatus4), TypeInfoPropertyName = "GetConversationFlowComponentResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponseStatus), TypeInfoPropertyName = "GetConversationFlowResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponseStatus2), TypeInfoPropertyName = "GetConversationFlowResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponseStatus3), TypeInfoPropertyName = "GetConversationFlowResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponseStatus4), TypeInfoPropertyName = "GetConversationFlowResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponseStatus5), TypeInfoPropertyName = "GetConversationFlowResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetKnowledgeBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetKnowledgeBaseResponseStatus), TypeInfoPropertyName = "GetKnowledgeBaseResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetKnowledgeBaseResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetKnowledgeBaseResponseStatus2), TypeInfoPropertyName = "GetKnowledgeBaseResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetKnowledgeBaseResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetKnowledgeBaseResponseStatus3), TypeInfoPropertyName = "GetKnowledgeBaseResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetKnowledgeBaseResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetKnowledgeBaseResponseStatus4), TypeInfoPropertyName = "GetKnowledgeBaseResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.MCPToolDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetMCPToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetMCPToolsResponseStatus), TypeInfoPropertyName = "GetMCPToolsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetMCPToolsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetMCPToolsResponseStatus2), TypeInfoPropertyName = "GetMCPToolsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetMCPToolsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetMCPToolsResponseStatus3), TypeInfoPropertyName = "GetMCPToolsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetMCPToolsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetMCPToolsResponseStatus4), TypeInfoPropertyName = "GetMCPToolsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetPhoneNumberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetPhoneNumberResponseStatus), TypeInfoPropertyName = "GetPhoneNumberResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetPhoneNumberResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetPhoneNumberResponseStatus2), TypeInfoPropertyName = "GetPhoneNumberResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetPhoneNumberResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetPhoneNumberResponseStatus3), TypeInfoPropertyName = "GetPhoneNumberResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetPhoneNumberResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetPhoneNumberResponseStatus4), TypeInfoPropertyName = "GetPhoneNumberResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetRetellLLMResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetRetellLLMResponseStatus), TypeInfoPropertyName = "GetRetellLLMResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetRetellLLMResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetRetellLLMResponseStatus2), TypeInfoPropertyName = "GetRetellLLMResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetRetellLLMResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetRetellLLMResponseStatus3), TypeInfoPropertyName = "GetRetellLLMResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetRetellLLMResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetRetellLLMResponseStatus4), TypeInfoPropertyName = "GetRetellLLMResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetVoiceResponseStatus), TypeInfoPropertyName = "GetVoiceResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetVoiceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetVoiceResponseStatus2), TypeInfoPropertyName = "GetVoiceResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetVoiceResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetVoiceResponseStatus3), TypeInfoPropertyName = "GetVoiceResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetVoiceResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetVoiceResponseStatus4), TypeInfoPropertyName = "GetVoiceResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponseStatus), TypeInfoPropertyName = "CloneVoiceResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponseStatus2), TypeInfoPropertyName = "CloneVoiceResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponseStatus3), TypeInfoPropertyName = "CloneVoiceResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponseStatus4), TypeInfoPropertyName = "CloneVoiceResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponseStatus5), TypeInfoPropertyName = "CloneVoiceResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceResponseStatus), TypeInfoPropertyName = "AddCommunityVoiceResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceResponseStatus2), TypeInfoPropertyName = "AddCommunityVoiceResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceResponseStatus3), TypeInfoPropertyName = "AddCommunityVoiceResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceResponseStatus4), TypeInfoPropertyName = "AddCommunityVoiceResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.SearchCommunityVoiceResponseVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponseVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponseStatus), TypeInfoPropertyName = "SearchCommunityVoiceResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponseStatus2), TypeInfoPropertyName = "SearchCommunityVoiceResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponseStatus3), TypeInfoPropertyName = "SearchCommunityVoiceResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponseStatus4), TypeInfoPropertyName = "SearchCommunityVoiceResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ImportPhoneNumberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ImportPhoneNumberResponseStatus), TypeInfoPropertyName = "ImportPhoneNumberResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ImportPhoneNumberResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ImportPhoneNumberResponseStatus2), TypeInfoPropertyName = "ImportPhoneNumberResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ImportPhoneNumberResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ImportPhoneNumberResponseStatus3), TypeInfoPropertyName = "ImportPhoneNumberResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAgentsResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListAgentsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AgentListItemResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponseStatus), TypeInfoPropertyName = "ListAgentsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponseStatus2), TypeInfoPropertyName = "ListAgentsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponseStatus3), TypeInfoPropertyName = "ListAgentsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponseStatus4), TypeInfoPropertyName = "ListAgentsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListChatsResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListChatsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.V3ChatResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsResponseStatus), TypeInfoPropertyName = "ListChatsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsResponseStatus2), TypeInfoPropertyName = "ListChatsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsResponseStatus3), TypeInfoPropertyName = "ListChatsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsResponseStatus4), TypeInfoPropertyName = "ListChatsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowComponentsResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListConversationFlowComponentsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ConversationFlowComponentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus), TypeInfoPropertyName = "ListConversationFlowComponentsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus2), TypeInfoPropertyName = "ListConversationFlowComponentsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus3), TypeInfoPropertyName = "ListConversationFlowComponentsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus4), TypeInfoPropertyName = "ListConversationFlowComponentsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowsResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListConversationFlowsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ConversationFlowResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponseStatus), TypeInfoPropertyName = "ListConversationFlowsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponseStatus2), TypeInfoPropertyName = "ListConversationFlowsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponseStatus3), TypeInfoPropertyName = "ListConversationFlowsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponseStatus4), TypeInfoPropertyName = "ListConversationFlowsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponseStatus5), TypeInfoPropertyName = "ListConversationFlowsResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.KnowledgeBaseResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListKnowledgeBasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListKnowledgeBasesResponseStatus), TypeInfoPropertyName = "ListKnowledgeBasesResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListKnowledgeBasesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListKnowledgeBasesResponseStatus2), TypeInfoPropertyName = "ListKnowledgeBasesResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListKnowledgeBasesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListKnowledgeBasesResponseStatus3), TypeInfoPropertyName = "ListKnowledgeBasesResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListPhoneNumbersResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListPhoneNumbersResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.PhoneNumberResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersResponseStatus), TypeInfoPropertyName = "ListPhoneNumbersResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersResponseStatus2), TypeInfoPropertyName = "ListPhoneNumbersResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListRetellLLMResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListRetellLLMResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.RetellLLMResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponseStatus), TypeInfoPropertyName = "ListRetellLLMResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponseStatus2), TypeInfoPropertyName = "ListRetellLLMResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponseStatus3), TypeInfoPropertyName = "ListRetellLLMResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponseStatus4), TypeInfoPropertyName = "ListRetellLLMResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponseStatus5), TypeInfoPropertyName = "ListRetellLLMResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.VoiceResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListVoicesResponseStatus), TypeInfoPropertyName = "ListVoicesResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListVoicesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListVoicesResponseStatus2), TypeInfoPropertyName = "ListVoicesResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.AgentResponse?, global::RetellAI.ChatAgentResponse?>), TypeInfoPropertyName = "OneOfAgentResponseChatAgentResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentVersionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentVersionResponseStatus), TypeInfoPropertyName = "CreateAgentVersionResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentVersionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentVersionResponseStatus2), TypeInfoPropertyName = "CreateAgentVersionResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentVersionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentVersionResponseStatus3), TypeInfoPropertyName = "CreateAgentVersionResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentVersionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentVersionResponseStatus4), TypeInfoPropertyName = "CreateAgentVersionResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentVersionResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentVersionResponseStatus5), TypeInfoPropertyName = "CreateAgentVersionResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentVersionResponseStatus), TypeInfoPropertyName = "PublishAgentVersionResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentVersionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentVersionResponseStatus2), TypeInfoPropertyName = "PublishAgentVersionResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentVersionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentVersionResponseStatus3), TypeInfoPropertyName = "PublishAgentVersionResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentVersionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentVersionResponseStatus4), TypeInfoPropertyName = "PublishAgentVersionResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentVersionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentVersionResponseStatus5), TypeInfoPropertyName = "PublishAgentVersionResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentVersionResponseStatus), TypeInfoPropertyName = "DeleteAgentVersionResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentVersionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentVersionResponseStatus2), TypeInfoPropertyName = "DeleteAgentVersionResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentVersionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentVersionResponseStatus3), TypeInfoPropertyName = "DeleteAgentVersionResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentVersionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentVersionResponseStatus4), TypeInfoPropertyName = "DeleteAgentVersionResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentVersionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentVersionResponseStatus5), TypeInfoPropertyName = "DeleteAgentVersionResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunCallAnalysisResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunCallAnalysisResponseStatus), TypeInfoPropertyName = "RerunCallAnalysisResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunCallAnalysisResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunCallAnalysisResponseStatus2), TypeInfoPropertyName = "RerunCallAnalysisResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunCallAnalysisResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunCallAnalysisResponseStatus3), TypeInfoPropertyName = "RerunCallAnalysisResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunCallAnalysisResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunCallAnalysisResponseStatus4), TypeInfoPropertyName = "RerunCallAnalysisResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunCallAnalysisResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunCallAnalysisResponseStatus5), TypeInfoPropertyName = "RerunCallAnalysisResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunCallAnalysisResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunCallAnalysisResponseStatus6), TypeInfoPropertyName = "RerunCallAnalysisResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunCallAnalysisResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunCallAnalysisResponseStatus7), TypeInfoPropertyName = "RerunCallAnalysisResponseStatus72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunChatAnalysisResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunChatAnalysisResponseStatus), TypeInfoPropertyName = "RerunChatAnalysisResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunChatAnalysisResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunChatAnalysisResponseStatus2), TypeInfoPropertyName = "RerunChatAnalysisResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunChatAnalysisResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunChatAnalysisResponseStatus3), TypeInfoPropertyName = "RerunChatAnalysisResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunChatAnalysisResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunChatAnalysisResponseStatus4), TypeInfoPropertyName = "RerunChatAnalysisResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunChatAnalysisResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunChatAnalysisResponseStatus5), TypeInfoPropertyName = "RerunChatAnalysisResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunChatAnalysisResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunChatAnalysisResponseStatus6), TypeInfoPropertyName = "RerunChatAnalysisResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunChatAnalysisResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunChatAnalysisResponseStatus7), TypeInfoPropertyName = "RerunChatAnalysisResponseStatus72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponseStatus), TypeInfoPropertyName = "UpdateAgentResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponseStatus2), TypeInfoPropertyName = "UpdateAgentResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponseStatus3), TypeInfoPropertyName = "UpdateAgentResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponseStatus4), TypeInfoPropertyName = "UpdateAgentResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponseStatus5), TypeInfoPropertyName = "UpdateAgentResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponseStatus), TypeInfoPropertyName = "UpdateChatAgentResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponseStatus2), TypeInfoPropertyName = "UpdateChatAgentResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponseStatus3), TypeInfoPropertyName = "UpdateChatAgentResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponseStatus4), TypeInfoPropertyName = "UpdateChatAgentResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponseStatus5), TypeInfoPropertyName = "UpdateChatAgentResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataResponseStatus), TypeInfoPropertyName = "UpdateChatMetadataResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataResponseStatus2), TypeInfoPropertyName = "UpdateChatMetadataResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataResponseStatus3), TypeInfoPropertyName = "UpdateChatMetadataResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataResponseStatus4), TypeInfoPropertyName = "UpdateChatMetadataResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus), TypeInfoPropertyName = "UpdateConversationFlowComponentResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus2), TypeInfoPropertyName = "UpdateConversationFlowComponentResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus3), TypeInfoPropertyName = "UpdateConversationFlowComponentResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus4), TypeInfoPropertyName = "UpdateConversationFlowComponentResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus5), TypeInfoPropertyName = "UpdateConversationFlowComponentResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus6), TypeInfoPropertyName = "UpdateConversationFlowComponentResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponseStatus), TypeInfoPropertyName = "UpdateConversationFlowResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponseStatus2), TypeInfoPropertyName = "UpdateConversationFlowResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponse3))]
    internal sealed partial class SourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableLLMModel), TypeInfoPropertyName = "NullableLLMModel_RetellAI_NullableLLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.LLMModel?), TypeInfoPropertyName = "NullableLLMModel_RetellAI_LLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponseStatus3), TypeInfoPropertyName = "UpdateConversationFlowResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponseStatus4), TypeInfoPropertyName = "UpdateConversationFlowResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponseStatus5), TypeInfoPropertyName = "UpdateConversationFlowResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponseStatus6), TypeInfoPropertyName = "UpdateConversationFlowResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberResponseStatus), TypeInfoPropertyName = "UpdatePhoneNumberResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberResponseStatus2), TypeInfoPropertyName = "UpdatePhoneNumberResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberResponseStatus3), TypeInfoPropertyName = "UpdatePhoneNumberResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberResponseStatus4), TypeInfoPropertyName = "UpdatePhoneNumberResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponseStatus), TypeInfoPropertyName = "UpdateRetellLLMResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponseStatus2), TypeInfoPropertyName = "UpdateRetellLLMResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponseStatus3), TypeInfoPropertyName = "UpdateRetellLLMResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponseStatus4), TypeInfoPropertyName = "UpdateRetellLLMResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponseStatus5), TypeInfoPropertyName = "UpdateRetellLLMResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponseStatus), TypeInfoPropertyName = "CreatePhoneCallResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponseStatus2), TypeInfoPropertyName = "CreatePhoneCallResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponseStatus3), TypeInfoPropertyName = "CreatePhoneCallResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponseStatus4), TypeInfoPropertyName = "CreatePhoneCallResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponseStatus5), TypeInfoPropertyName = "CreatePhoneCallResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponseStatus6), TypeInfoPropertyName = "CreatePhoneCallResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponseStatus), TypeInfoPropertyName = "CreateWebCallResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponseStatus2), TypeInfoPropertyName = "CreateWebCallResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponseStatus3), TypeInfoPropertyName = "CreateWebCallResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponseStatus4), TypeInfoPropertyName = "CreateWebCallResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponseStatus5), TypeInfoPropertyName = "CreateWebCallResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponseStatus6), TypeInfoPropertyName = "CreateWebCallResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteCallResponseStatus), TypeInfoPropertyName = "DeleteCallResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteCallResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteCallResponseStatus2), TypeInfoPropertyName = "DeleteCallResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteCallResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteCallResponseStatus3), TypeInfoPropertyName = "DeleteCallResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteCallResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteCallResponseStatus4), TypeInfoPropertyName = "DeleteCallResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCallResponseStatus), TypeInfoPropertyName = "GetCallResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCallResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCallResponseStatus2), TypeInfoPropertyName = "GetCallResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCallResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCallResponseStatus3), TypeInfoPropertyName = "GetCallResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCallResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCallResponseStatus4), TypeInfoPropertyName = "GetCallResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListCallsResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListCallsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.V3CallResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponseStatus), TypeInfoPropertyName = "ListCallsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponseStatus2), TypeInfoPropertyName = "ListCallsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponseStatus3), TypeInfoPropertyName = "ListCallsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponseStatus4), TypeInfoPropertyName = "ListCallsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListExportRequestsResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListExportRequestsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ListExportRequestsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponseItemChannel), TypeInfoPropertyName = "ListExportRequestsResponseItemChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponseItemStatus), TypeInfoPropertyName = "ListExportRequestsResponseItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponseStatus), TypeInfoPropertyName = "ListExportRequestsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponseStatus2), TypeInfoPropertyName = "ListExportRequestsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponseStatus3), TypeInfoPropertyName = "ListExportRequestsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponseStatus4), TypeInfoPropertyName = "ListExportRequestsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponseStatus), TypeInfoPropertyName = "RegisterPhoneCallResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponseStatus2), TypeInfoPropertyName = "RegisterPhoneCallResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponseStatus3), TypeInfoPropertyName = "RegisterPhoneCallResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponseStatus4), TypeInfoPropertyName = "RegisterPhoneCallResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponseStatus5), TypeInfoPropertyName = "RegisterPhoneCallResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponseStatus6), TypeInfoPropertyName = "RegisterPhoneCallResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponseStatus), TypeInfoPropertyName = "UpdateCallMetadataResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponseStatus2), TypeInfoPropertyName = "UpdateCallMetadataResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponseStatus3), TypeInfoPropertyName = "UpdateCallMetadataResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponseStatus4), TypeInfoPropertyName = "UpdateCallMetadataResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallResponseStatus), TypeInfoPropertyName = "UpdateLiveCallResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallResponseStatus2), TypeInfoPropertyName = "UpdateLiveCallResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallResponseStatus3), TypeInfoPropertyName = "UpdateLiveCallResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallResponseStatus4), TypeInfoPropertyName = "UpdateLiveCallResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallResponseStatus5), TypeInfoPropertyName = "UpdateLiveCallResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StopCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StopCallResponseStatus), TypeInfoPropertyName = "StopCallResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StopCallResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StopCallResponseStatus2), TypeInfoPropertyName = "StopCallResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StopCallResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StopCallResponseStatus3), TypeInfoPropertyName = "StopCallResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StopCallResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StopCallResponseStatus4), TypeInfoPropertyName = "StopCallResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateContactResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateContactResponseStatus), TypeInfoPropertyName = "CreateContactResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateContactResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateContactResponseStatus2), TypeInfoPropertyName = "CreateContactResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateContactResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateContactResponseStatus3), TypeInfoPropertyName = "CreateContactResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateContactResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateContactResponseStatus4), TypeInfoPropertyName = "CreateContactResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactResponseStatus), TypeInfoPropertyName = "GetContactResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactResponseStatus2), TypeInfoPropertyName = "GetContactResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactResponseStatus3), TypeInfoPropertyName = "GetContactResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactResponseStatus4), TypeInfoPropertyName = "GetContactResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactByPhoneResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactByPhoneResponseStatus), TypeInfoPropertyName = "GetContactByPhoneResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactByPhoneResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactByPhoneResponseStatus2), TypeInfoPropertyName = "GetContactByPhoneResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactByPhoneResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactByPhoneResponseStatus3), TypeInfoPropertyName = "GetContactByPhoneResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactByPhoneResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactByPhoneResponseStatus4), TypeInfoPropertyName = "GetContactByPhoneResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactByPhoneResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactByPhoneResponseStatus5), TypeInfoPropertyName = "GetContactByPhoneResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateContactResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateContactResponseStatus), TypeInfoPropertyName = "UpdateContactResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateContactResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateContactResponseStatus2), TypeInfoPropertyName = "UpdateContactResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateContactResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateContactResponseStatus3), TypeInfoPropertyName = "UpdateContactResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateContactResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateContactResponseStatus4), TypeInfoPropertyName = "UpdateContactResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateContactResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateContactResponseStatus5), TypeInfoPropertyName = "UpdateContactResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteContactResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteContactResponseStatus), TypeInfoPropertyName = "DeleteContactResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteContactResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteContactResponseStatus2), TypeInfoPropertyName = "DeleteContactResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteContactResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteContactResponseStatus3), TypeInfoPropertyName = "DeleteContactResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteContactResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteContactResponseStatus4), TypeInfoPropertyName = "DeleteContactResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteContactResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteContactResponseStatus5), TypeInfoPropertyName = "DeleteContactResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactsResponseStatus), TypeInfoPropertyName = "ListContactsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactsResponseStatus2), TypeInfoPropertyName = "ListContactsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactsResponseStatus3), TypeInfoPropertyName = "ListContactsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactsResponseStatus4), TypeInfoPropertyName = "ListContactsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactConversationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactConversationsResponseStatus), TypeInfoPropertyName = "ListContactConversationsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactConversationsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactConversationsResponseStatus2), TypeInfoPropertyName = "ListContactConversationsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactConversationsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactConversationsResponseStatus3), TypeInfoPropertyName = "ListContactConversationsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactConversationsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactConversationsResponseStatus4), TypeInfoPropertyName = "ListContactConversationsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAppResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAppResponseStatus), TypeInfoPropertyName = "CreateAppResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAppResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAppResponseStatus2), TypeInfoPropertyName = "CreateAppResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAppResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAppResponseStatus3), TypeInfoPropertyName = "CreateAppResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAppResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAppResponseStatus4), TypeInfoPropertyName = "CreateAppResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAppResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAppResponseStatus), TypeInfoPropertyName = "GetAppResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAppResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAppResponseStatus2), TypeInfoPropertyName = "GetAppResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAppResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAppResponseStatus3), TypeInfoPropertyName = "GetAppResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAppResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAppResponseStatus4), TypeInfoPropertyName = "GetAppResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAppResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAppResponseStatus), TypeInfoPropertyName = "UpdateAppResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAppResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAppResponseStatus2), TypeInfoPropertyName = "UpdateAppResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAppResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAppResponseStatus3), TypeInfoPropertyName = "UpdateAppResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAppResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAppResponseStatus4), TypeInfoPropertyName = "UpdateAppResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAppResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAppResponseStatus5), TypeInfoPropertyName = "UpdateAppResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAppResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAppResponseStatus), TypeInfoPropertyName = "DeleteAppResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAppResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAppResponseStatus2), TypeInfoPropertyName = "DeleteAppResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAppResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAppResponseStatus3), TypeInfoPropertyName = "DeleteAppResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAppResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAppResponseStatus4), TypeInfoPropertyName = "DeleteAppResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAppResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAppResponseStatus5), TypeInfoPropertyName = "DeleteAppResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppsResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListAppsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AppResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppsResponseStatus), TypeInfoPropertyName = "ListAppsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppsResponseStatus2), TypeInfoPropertyName = "ListAppsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppsResponseStatus3), TypeInfoPropertyName = "ListAppsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppUsagesResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListAppUsagesResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppUsagesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AppUsageResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppUsagesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppUsagesResponseStatus), TypeInfoPropertyName = "ListAppUsagesResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppUsagesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppUsagesResponseStatus2), TypeInfoPropertyName = "ListAppUsagesResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppUsagesResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppUsagesResponseStatus3), TypeInfoPropertyName = "ListAppUsagesResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppUsagesResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppUsagesResponseStatus4), TypeInfoPropertyName = "ListAppUsagesResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestAppAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestAppAuthResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestAppAuthResponseStatus), TypeInfoPropertyName = "TestAppAuthResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestAppAuthResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestAppAuthResponseStatus2), TypeInfoPropertyName = "TestAppAuthResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestAppAuthResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestAppAuthResponseStatus3), TypeInfoPropertyName = "TestAppAuthResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestAppAuthResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestAppAuthResponseStatus4), TypeInfoPropertyName = "TestAppAuthResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmConfigResponseStatus), TypeInfoPropertyName = "GetCrmConfigResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmConfigResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmConfigResponseStatus2), TypeInfoPropertyName = "GetCrmConfigResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmConfigResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmConfigResponseStatus3), TypeInfoPropertyName = "GetCrmConfigResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCrmConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCrmConfigResponseStatus), TypeInfoPropertyName = "UpdateCrmConfigResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCrmConfigResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCrmConfigResponseStatus2), TypeInfoPropertyName = "UpdateCrmConfigResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCrmConfigResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCrmConfigResponseStatus3), TypeInfoPropertyName = "UpdateCrmConfigResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCrmConfigResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCrmConfigResponseStatus4), TypeInfoPropertyName = "UpdateCrmConfigResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCrmConfigResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCrmConfigResponseStatus5), TypeInfoPropertyName = "UpdateCrmConfigResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RunSyncJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RunSyncJobResponseStatus), TypeInfoPropertyName = "RunSyncJobResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RunSyncJobResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RunSyncJobResponseStatus2), TypeInfoPropertyName = "RunSyncJobResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RunSyncJobResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RunSyncJobResponseStatus3), TypeInfoPropertyName = "RunSyncJobResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RunSyncJobResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RunSyncJobResponseStatus4), TypeInfoPropertyName = "RunSyncJobResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetSyncJobStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetSyncJobStatusResponseStatus), TypeInfoPropertyName = "GetSyncJobStatusResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetSyncJobStatusResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetSyncJobStatusResponseStatus2), TypeInfoPropertyName = "GetSyncJobStatusResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetSyncJobStatusResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetSyncJobStatusResponseStatus3), TypeInfoPropertyName = "GetSyncJobStatusResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackfillContactAnalysisDataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus), TypeInfoPropertyName = "BackfillContactAnalysisDataResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackfillContactAnalysisDataResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus2), TypeInfoPropertyName = "BackfillContactAnalysisDataResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackfillContactAnalysisDataResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus3), TypeInfoPropertyName = "BackfillContactAnalysisDataResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackfillContactAnalysisDataResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus4), TypeInfoPropertyName = "BackfillContactAnalysisDataResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBackfillContactJobStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBackfillContactJobStatusResponseStatus), TypeInfoPropertyName = "GetBackfillContactJobStatusResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBackfillContactJobStatusResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBackfillContactJobStatusResponseStatus2), TypeInfoPropertyName = "GetBackfillContactJobStatusResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBackfillContactJobStatusResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBackfillContactJobStatusResponseStatus3), TypeInfoPropertyName = "GetBackfillContactJobStatusResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponseStatus), TypeInfoPropertyName = "GetCrmSchemaResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponseStatus2), TypeInfoPropertyName = "GetCrmSchemaResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponseStatus3), TypeInfoPropertyName = "GetCrmSchemaResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponseStatus4), TypeInfoPropertyName = "GetCrmSchemaResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponseStatus5), TypeInfoPropertyName = "GetCrmSchemaResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponseStatus6), TypeInfoPropertyName = "GetCrmSchemaResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertMetricType?), TypeInfoPropertyName = "NullableAlertMetricType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AsrProvider?), TypeInfoPropertyName = "NullableAsrProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, object>?), TypeInfoPropertyName = "NullableAllOfEnumFilterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterDisconnectionReason>?), TypeInfoPropertyName = "NullableAllOfEnumFilterAlertFilterDisconnectionReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DisconnectionReason5?), TypeInfoPropertyName = "NullableDisconnectionReason52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomFieldFilter?), TypeInfoPropertyName = "NullableCustomFieldFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.StringFilter, object>?), TypeInfoPropertyName = "NullableAllOfStringFilterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterStatusCode>?), TypeInfoPropertyName = "NullableAllOfEnumFilterAlertFilterStatusCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertFilterStatusCodeValueItem?), TypeInfoPropertyName = "NullableAlertFilterStatusCodeValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertFilterErrorCodeItem?), TypeInfoPropertyName = "NullableAlertFilterErrorCodeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertIncidentResponseThresholdType?), TypeInfoPropertyName = "NullableAlertIncidentResponseThresholdType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertIncidentResponseComparator?), TypeInfoPropertyName = "NullableAlertIncidentResponseComparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertIncidentResponseFrequency?), TypeInfoPropertyName = "NullableAlertIncidentResponseFrequency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertIncidentResponseWindow?), TypeInfoPropertyName = "NullableAlertIncidentResponseWindow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleRequestThresholdType?), TypeInfoPropertyName = "NullableAlertRuleRequestThresholdType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleRequestComparator?), TypeInfoPropertyName = "NullableAlertRuleRequestComparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleRequestFrequency?), TypeInfoPropertyName = "NullableAlertRuleRequestFrequency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleRequestWindow?), TypeInfoPropertyName = "NullableAlertRuleRequestWindow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleResponseThresholdType?), TypeInfoPropertyName = "NullableAlertRuleResponseThresholdType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleResponseComparator?), TypeInfoPropertyName = "NullableAlertRuleResponseComparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleResponseFrequency?), TypeInfoPropertyName = "NullableAlertRuleResponseFrequency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleResponseWindow?), TypeInfoPropertyName = "NullableAlertRuleResponseWindow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentVersionReference?), TypeInfoPropertyName = "NullableAgentVersionReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ResponseEngine?), TypeInfoPropertyName = "NullableResponseEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestVoiceModel?), TypeInfoPropertyName = "NullableAgentRequestVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestVoiceEmotion?), TypeInfoPropertyName = "NullableAgentRequestVoiceEmotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestExpressiveEmotionTag?), TypeInfoPropertyName = "NullableAgentRequestExpressiveEmotionTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestAmbientSound?), TypeInfoPropertyName = "NullableAgentRequestAmbientSound2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.Language3?, global::System.Collections.Generic.IList<global::RetellAI.Language3>, global::RetellAI.AgentRequestLanguage?>?), TypeInfoPropertyName = "NullableOneOfLanguage3IListLanguage3AgentRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Language3?), TypeInfoPropertyName = "NullableLanguage32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestLanguage?), TypeInfoPropertyName = "NullableAgentRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestWebhookEvent?), TypeInfoPropertyName = "NullableAgentRequestWebhookEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestDataStorageSetting?), TypeInfoPropertyName = "NullableAgentRequestDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestPronunciationDictionaryItemAlphabet?), TypeInfoPropertyName = "NullableAgentRequestPronunciationDictionaryItemAlphabet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoicemailAction?), TypeInfoPropertyName = "NullableVoicemailAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PostCallAnalysisData?), TypeInfoPropertyName = "NullablePostCallAnalysisData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableLLMModel?), TypeInfoPropertyName = "NullableNullableLLMModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestSttMode?), TypeInfoPropertyName = "NullableAgentRequestSttMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestVocabSpecialization?), TypeInfoPropertyName = "NullableAgentRequestVocabSpecialization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestDenoisingMode?), TypeInfoPropertyName = "NullableAgentRequestDenoisingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentResponse?), TypeInfoPropertyName = "NullableAgentResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.StringFilter, global::RetellAI.AgentListFilterChannel>?), TypeInfoPropertyName = "NullableAllOfStringFilterAgentListFilterChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentListFilterChannelOp?), TypeInfoPropertyName = "NullableAgentListFilterChannelOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentListFilterChannelValue?), TypeInfoPropertyName = "NullableAgentListFilterChannelValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentListItemResponseChannel?), TypeInfoPropertyName = "NullableAgentListItemResponseChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentSwapNode?), TypeInfoPropertyName = "NullableAgentSwapNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeBase?), TypeInfoPropertyName = "NullableNodeBase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentSwapNodeVariant2Type?), TypeInfoPropertyName = "NullableAgentSwapNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PostCallAnalysisSetting?), TypeInfoPropertyName = "NullablePostCallAnalysisSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentSwapWebhookSetting?), TypeInfoPropertyName = "NullableAgentSwapWebhookSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferFailedEdge?), TypeInfoPropertyName = "NullableTransferFailedEdge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeInstruction?), TypeInfoPropertyName = "NullableNodeInstruction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentSwapToolType?), TypeInfoPropertyName = "NullableAgentSwapToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentSwapToolExecutionMessageType?), TypeInfoPropertyName = "NullableAgentSwapToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AnalysisData?), TypeInfoPropertyName = "NullableAnalysisData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PostChatAnalysisData?), TypeInfoPropertyName = "NullablePostChatAnalysisData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BookAppointmentCalToolType?), TypeInfoPropertyName = "NullableBookAppointmentCalToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<double?, string>?), TypeInfoPropertyName = "NullableOneOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BooleanAnalysisDataType?), TypeInfoPropertyName = "NullableBooleanAnalysisDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BranchNode?), TypeInfoPropertyName = "NullableBranchNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BranchNodeVariant2Type?), TypeInfoPropertyName = "NullableBranchNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ElseEdge?), TypeInfoPropertyName = "NullableElseEdge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BridgeTransferNode?), TypeInfoPropertyName = "NullableBridgeTransferNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BridgeTransferNodeVariant2Type?), TypeInfoPropertyName = "NullableBridgeTransferNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BridgeTransferToolType?), TypeInfoPropertyName = "NullableBridgeTransferToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BridgeTransferToolExecutionMessageType?), TypeInfoPropertyName = "NullableBridgeTransferToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallAnalysisUserSentiment?), TypeInfoPropertyName = "NullableCallAnalysisUserSentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DayOfWeek?), TypeInfoPropertyName = "NullableDayOfWeek2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CancelTransferNode?), TypeInfoPropertyName = "NullableCancelTransferNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CancelTransferNodeVariant2Type?), TypeInfoPropertyName = "NullableCancelTransferNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CancelTransferToolType?), TypeInfoPropertyName = "NullableCancelTransferToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CancelTransferToolExecutionMessageType?), TypeInfoPropertyName = "NullableCancelTransferToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PreviewCallQA?), TypeInfoPropertyName = "NullablePreviewCallQA2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.Language3?, global::System.Collections.Generic.IList<global::RetellAI.Language3>, global::RetellAI.ChatAgentRequestLanguage?>?), TypeInfoPropertyName = "NullableOneOfLanguage3IListLanguage3ChatAgentRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatAgentRequestLanguage?), TypeInfoPropertyName = "NullableChatAgentRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatAgentRequestWebhookEvent?), TypeInfoPropertyName = "NullableChatAgentRequestWebhookEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatAgentRequestDataStorageSetting?), TypeInfoPropertyName = "NullableChatAgentRequestDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatAgentResponse?), TypeInfoPropertyName = "NullableChatAgentResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatAnalysisUserSentiment?), TypeInfoPropertyName = "NullableChatAnalysisUserSentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatResponseChatStatus?), TypeInfoPropertyName = "NullableChatResponseChatStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatResponseChatType?), TypeInfoPropertyName = "NullableChatResponseChatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<string, double?, bool?>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MessageOrToolCall?), TypeInfoPropertyName = "NullableMessageOrToolCall2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3ChatResponse?), TypeInfoPropertyName = "NullableV3ChatResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3ListChatsRequestSortOrder?), TypeInfoPropertyName = "NullableV3ListChatsRequestSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CheckAvailabilityCalToolType?), TypeInfoPropertyName = "NullableCheckAvailabilityCalToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortAggregatedResultGroupBy?), TypeInfoPropertyName = "NullableCohortAggregatedResultGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.AllOf<global::RetellAI.NumberFilter, global::RetellAI.CohortFilterStartTimestampVariant1>?, global::RetellAI.RangeFilter>?), TypeInfoPropertyName = "NullableOneOfAllOfNumberFilterCohortFilterStartTimestampVariant1RangeFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.NumberFilter, global::RetellAI.CohortFilterStartTimestampVariant1>?), TypeInfoPropertyName = "NullableAllOfNumberFilterCohortFilterStartTimestampVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortFilterStartTimestampVariant1Op?), TypeInfoPropertyName = "NullableCohortFilterStartTimestampVariant1Op2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CohortFilterDisconnectionReason>?), TypeInfoPropertyName = "NullableAllOfEnumFilterCohortFilterDisconnectionReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>?), TypeInfoPropertyName = "NullableOneOfNumberFilterRangeFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortFilterCallDurationFilterOp?), TypeInfoPropertyName = "NullableCohortFilterCallDurationFilterOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortSuccessfulCriteriaType?), TypeInfoPropertyName = "NullableCohortSuccessfulCriteriaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortSuccessfulCriteriaOp?), TypeInfoPropertyName = "NullableCohortSuccessfulCriteriaOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortEvaluationMode?), TypeInfoPropertyName = "NullableCohortEvaluationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ComponentNode?), TypeInfoPropertyName = "NullableComponentNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ComponentNodeVariant2Type?), TypeInfoPropertyName = "NullableComponentNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ComponentNodeVariant2ComponentType?), TypeInfoPropertyName = "NullableComponentNodeVariant2ComponentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowComponentResponse?), TypeInfoPropertyName = "NullableConversationFlowComponentResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentRequest?), TypeInfoPropertyName = "NullableCreateConversationFlowComponentRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTool?), TypeInfoPropertyName = "NullableNodeTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowNode?), TypeInfoPropertyName = "NullableConversationFlowNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationNode?), TypeInfoPropertyName = "NullableConversationNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SubagentNode?), TypeInfoPropertyName = "NullableSubagentNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndNode?), TypeInfoPropertyName = "NullableEndNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FunctionNode?), TypeInfoPropertyName = "NullableFunctionNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CodeNode?), TypeInfoPropertyName = "NullableCodeNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferCallNode?), TypeInfoPropertyName = "NullableTransferCallNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PressDigitNode?), TypeInfoPropertyName = "NullablePressDigitNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsNode?), TypeInfoPropertyName = "NullableSmsNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ExtractDynamicVariablesNode?), TypeInfoPropertyName = "NullableExtractDynamicVariablesNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MCPNode?), TypeInfoPropertyName = "NullableMCPNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowOverrideStartSpeaker?), TypeInfoPropertyName = "NullableConversationFlowOverrideStartSpeaker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowResponse?), TypeInfoPropertyName = "NullableConversationFlowResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlow?), TypeInfoPropertyName = "NullableConversationFlow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationNodeVariant3Type?), TypeInfoPropertyName = "NullableConversationNodeVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SkipResponseEdge?), TypeInfoPropertyName = "NullableSkipResponseEdge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlwaysEdge?), TypeInfoPropertyName = "NullableAlwaysEdge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SubagentNodeVariant3Type?), TypeInfoPropertyName = "NullableSubagentNodeVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Tool?), TypeInfoPropertyName = "NullableTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowRequest?), TypeInfoPropertyName = "NullableCreateConversationFlowRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateOrganizationRequest?), TypeInfoPropertyName = "NullableCreateOrganizationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomToolType?), TypeInfoPropertyName = "NullableCustomToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomToolMethod?), TypeInfoPropertyName = "NullableCustomToolMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomToolExecutionMessageType?), TypeInfoPropertyName = "NullableCustomToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomToolParameterType?), TypeInfoPropertyName = "NullableCustomToolParameterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CodeToolType?), TypeInfoPropertyName = "NullableCodeToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CodeToolExecutionMessageType?), TypeInfoPropertyName = "NullableCodeToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DTMFUtteranceRole?), TypeInfoPropertyName = "NullableDTMFUtteranceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsUtteranceRole?), TypeInfoPropertyName = "NullableSmsUtteranceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.InjectedUtteranceRole?), TypeInfoPropertyName = "NullableInjectedUtteranceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StringFilterType?), TypeInfoPropertyName = "NullableStringFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StringFilterOp?), TypeInfoPropertyName = "NullableStringFilterOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NumberFilterType?), TypeInfoPropertyName = "NullableNumberFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NumberFilterOp?), TypeInfoPropertyName = "NullableNumberFilterOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BooleanFilterType?), TypeInfoPropertyName = "NullableBooleanFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BooleanFilterOp?), TypeInfoPropertyName = "NullableBooleanFilterOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RangeFilterType?), TypeInfoPropertyName = "NullableRangeFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RangeFilterOp?), TypeInfoPropertyName = "NullableRangeFilterOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EnumFilterType?), TypeInfoPropertyName = "NullableEnumFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EnumFilterOp?), TypeInfoPropertyName = "NullableEnumFilterOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PresentFilterType?), TypeInfoPropertyName = "NullablePresentFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PresentFilterOp?), TypeInfoPropertyName = "NullablePresentFilterOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ValueFilter?), TypeInfoPropertyName = "NullableValueFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.StringFilter, global::RetellAI.EnumFilter>?), TypeInfoPropertyName = "NullableOneOfStringFilterEnumFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterCallStatus>?), TypeInfoPropertyName = "NullableAllOfEnumFilterCallFilterCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterCallStatusValueItem?), TypeInfoPropertyName = "NullableCallFilterCallStatusValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDisconnectionReason>?), TypeInfoPropertyName = "NullableAllOfEnumFilterCallFilterDisconnectionReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterCallType>?), TypeInfoPropertyName = "NullableAllOfEnumFilterCallFilterCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterCallTypeValueItem?), TypeInfoPropertyName = "NullableCallFilterCallTypeValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDirection>?), TypeInfoPropertyName = "NullableAllOfEnumFilterCallFilterDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterDirectionValueItem?), TypeInfoPropertyName = "NullableCallFilterDirectionValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterUserSentiment>?), TypeInfoPropertyName = "NullableAllOfEnumFilterCallFilterUserSentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterUserSentimentValueItem?), TypeInfoPropertyName = "NullableCallFilterUserSentimentValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDataStorageSetting>?), TypeInfoPropertyName = "NullableAllOfEnumFilterCallFilterDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterDataStorageSettingValueItem?), TypeInfoPropertyName = "NullableCallFilterDataStorageSettingValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StoredCallFilter?), TypeInfoPropertyName = "NullableStoredCallFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterChatStatus>?), TypeInfoPropertyName = "NullableAllOfEnumFilterChatFilterChatStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatFilterChatStatusValueItem?), TypeInfoPropertyName = "NullableChatFilterChatStatusValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterDisconnectionReason>?), TypeInfoPropertyName = "NullableAllOfEnumFilterChatFilterDisconnectionReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterUserSentiment>?), TypeInfoPropertyName = "NullableAllOfEnumFilterChatFilterUserSentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatFilterUserSentimentValueItem?), TypeInfoPropertyName = "NullableChatFilterUserSentimentValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.StringFilter, global::RetellAI.PresentFilter>?), TypeInfoPropertyName = "NullableOneOfStringFilterPresentFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactsRequestSortOrder?), TypeInfoPropertyName = "NullableListContactsRequestSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ElseEdgeVariant2TransitionConditionType?), TypeInfoPropertyName = "NullableElseEdgeVariant2TransitionConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ElseEdgeVariant2TransitionConditionPrompt?), TypeInfoPropertyName = "NullableElseEdgeVariant2TransitionConditionPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndCallToolType?), TypeInfoPropertyName = "NullableEndCallToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndCallToolExecutionMessageType?), TypeInfoPropertyName = "NullableEndCallToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndNodeVariant2Type?), TypeInfoPropertyName = "NullableEndNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EnumAnalysisDataType?), TypeInfoPropertyName = "NullableEnumAnalysisDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EquationConditionType?), TypeInfoPropertyName = "NullableEquationConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EquationConditionOperator?), TypeInfoPropertyName = "NullableEquationConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EquationOperator?), TypeInfoPropertyName = "NullableEquationOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ExtractDynamicVariableToolType?), TypeInfoPropertyName = "NullableExtractDynamicVariableToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ExtractDynamicVariablesNodeVariant2Type?), TypeInfoPropertyName = "NullableExtractDynamicVariablesNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FinetuneExampleUtterance?), TypeInfoPropertyName = "NullableFinetuneExampleUtterance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FinetuneExampleUtteranceVariant1Role?), TypeInfoPropertyName = "NullableFinetuneExampleUtteranceVariant1Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FinetuneExampleUtteranceVariant2Role?), TypeInfoPropertyName = "NullableFinetuneExampleUtteranceVariant2Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FinetuneExampleUtteranceVariant3Role?), TypeInfoPropertyName = "NullableFinetuneExampleUtteranceVariant3Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FunctionNodeVariant2Type?), TypeInfoPropertyName = "NullableFunctionNodeVariant2Type2")]
    internal sealed partial class SourceGenerationContextChunk3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableLLMModel), TypeInfoPropertyName = "NullableLLMModel_RetellAI_NullableLLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.LLMModel?), TypeInfoPropertyName = "NullableLLMModel_RetellAI_LLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FunctionNodeVariant2ToolType?), TypeInfoPropertyName = "NullableFunctionNodeVariant2ToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CodeNodeVariant2Type?), TypeInfoPropertyName = "NullableCodeNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseResponseStatus?), TypeInfoPropertyName = "NullableKnowledgeBaseResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.KnowledgeBaseSourceDocument, global::RetellAI.KnowledgeBaseSourceText, global::RetellAI.KnowledgeBaseSourceUrl>?), TypeInfoPropertyName = "NullableOneOfKnowledgeBaseSourceDocumentKnowledgeBaseSourceTextKnowledgeBaseSourceUrl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseSourceDocumentType?), TypeInfoPropertyName = "NullableKnowledgeBaseSourceDocumentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseSourceTextType?), TypeInfoPropertyName = "NullableKnowledgeBaseSourceTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseSourceUrlType?), TypeInfoPropertyName = "NullableKnowledgeBaseSourceUrlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MCPNodeVariant2Type?), TypeInfoPropertyName = "NullableMCPNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MCPToolType?), TypeInfoPropertyName = "NullableMCPToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MCPToolExecutionMessageType?), TypeInfoPropertyName = "NullableMCPToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Message?), TypeInfoPropertyName = "NullableMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallInvocationMessage?), TypeInfoPropertyName = "NullableToolCallInvocationMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallResultMessage?), TypeInfoPropertyName = "NullableToolCallResultMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionMessage?), TypeInfoPropertyName = "NullableNodeTransitionMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StateTransitionMessage?), TypeInfoPropertyName = "NullableStateTransitionMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.InjectedMessage?), TypeInfoPropertyName = "NullableInjectedMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsMessage?), TypeInfoPropertyName = "NullableSmsMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatMessageInput?), TypeInfoPropertyName = "NullableChatMessageInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MessageBaseRole?), TypeInfoPropertyName = "NullableMessageBaseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.InjectedMessageBaseRole?), TypeInfoPropertyName = "NullableInjectedMessageBaseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsMessageBaseRole?), TypeInfoPropertyName = "NullableSmsMessageBaseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.PerformanceMetricCriteria, global::RetellAI.CustomMetricCriteria>?), TypeInfoPropertyName = "NullableOneOfPerformanceMetricCriteriaCustomMetricCriteria2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<double?, bool?, string>?), TypeInfoPropertyName = "NullableOneOfDoubleBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ModelChoiceCascadingType?), TypeInfoPropertyName = "NullableModelChoiceCascadingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ModelChoice?), TypeInfoPropertyName = "NullableModelChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NaturalnessIssue?), TypeInfoPropertyName = "NullableNaturalnessIssue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.PromptCondition, global::RetellAI.EquationCondition>?), TypeInfoPropertyName = "NullableOneOfPromptConditionEquationCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeInstructionPromptType?), TypeInfoPropertyName = "NullableNodeInstructionPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeInstructionStaticTextType?), TypeInfoPropertyName = "NullableNodeInstructionStaticTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsInstructionTemplateType?), TypeInfoPropertyName = "NullableSmsInstructionTemplateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsInstructionTemplateTemplate?), TypeInfoPropertyName = "NullableSmsInstructionTemplateTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.CustomTool, global::RetellAI.CheckAvailabilityCalTool, global::RetellAI.BookAppointmentCalTool>?), TypeInfoPropertyName = "NullableOneOfCustomToolCheckAvailabilityCalToolBookAppointmentCalTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionMessageBaseRole?), TypeInfoPropertyName = "NullableNodeTransitionMessageBaseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionMessageBaseTransitionType?), TypeInfoPropertyName = "NullableNodeTransitionMessageBaseTransitionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionUtteranceRole?), TypeInfoPropertyName = "NullableNodeTransitionUtteranceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionUtteranceTransitionType?), TypeInfoPropertyName = "NullableNodeTransitionUtteranceTransitionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NumberAnalysisDataType?), TypeInfoPropertyName = "NullableNumberAnalysisDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PresetAnalysisDataType?), TypeInfoPropertyName = "NullablePresetAnalysisDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PresetAnalysisDataName?), TypeInfoPropertyName = "NullablePresetAnalysisDataName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallPresetAnalysisDataType?), TypeInfoPropertyName = "NullableCallPresetAnalysisDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallPresetAnalysisDataName?), TypeInfoPropertyName = "NullableCallPresetAnalysisDataName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatPresetAnalysisDataType?), TypeInfoPropertyName = "NullableChatPresetAnalysisDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatPresetAnalysisDataName?), TypeInfoPropertyName = "NullableChatPresetAnalysisDataName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorOverageConfig?), TypeInfoPropertyName = "NullableConductorOverageConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OrganizationResponse?), TypeInfoPropertyName = "NullableOrganizationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OrganizationResponseVariant2EnterprisePlanStatus?), TypeInfoPropertyName = "NullableOrganizationResponseVariant2EnterprisePlanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PIIConfigMode?), TypeInfoPropertyName = "NullablePIIConfigMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PIIConfigCategorie?), TypeInfoPropertyName = "NullablePIIConfigCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GuardrailConfigOutputTopic?), TypeInfoPropertyName = "NullableGuardrailConfigOutputTopic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GuardrailConfigInputTopic?), TypeInfoPropertyName = "NullableGuardrailConfigInputTopic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PerformanceMetricCriteriaOp?), TypeInfoPropertyName = "NullablePerformanceMetricCriteriaOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberResponsePhoneNumberType?), TypeInfoPropertyName = "NullablePhoneNumberResponsePhoneNumberType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PressDigitNodeVariant2Type?), TypeInfoPropertyName = "NullablePressDigitNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PressDigitToolType?), TypeInfoPropertyName = "NullablePressDigitToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PromptConditionType?), TypeInfoPropertyName = "NullablePromptConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.QaViewFilterDisconnectionReason>?), TypeInfoPropertyName = "NullableAllOfEnumFilterQaViewFilterDisconnectionReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<bool?, global::RetellAI.BooleanFilter>?), TypeInfoPropertyName = "NullableOneOfBooleanBooleanFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.QaViewFilterScoreRangeType?), TypeInfoPropertyName = "NullableQaViewFilterScoreRangeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.QaViewFilterScoreRangeOp?), TypeInfoPropertyName = "NullableQaViewFilterScoreRangeOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortQaListArgsSortKey?), TypeInfoPropertyName = "NullableCohortQaListArgsSortKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortQaListArgsOrder?), TypeInfoPropertyName = "NullableCohortQaListArgsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ResponseEngineConversationFlowType?), TypeInfoPropertyName = "NullableResponseEngineConversationFlowType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ResponseEngineCustomLmType?), TypeInfoPropertyName = "NullableResponseEngineCustomLmType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ResponseEngineRetellLmType?), TypeInfoPropertyName = "NullableResponseEngineRetellLmType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellResponseEngine?), TypeInfoPropertyName = "NullableRetellResponseEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLLMResponse?), TypeInfoPropertyName = "NullableRetellLLMResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLlmRequest?), TypeInfoPropertyName = "NullableRetellLlmRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLlmOverrideS2sModel?), TypeInfoPropertyName = "NullableRetellLlmOverrideS2sModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLlmOverrideStartSpeaker?), TypeInfoPropertyName = "NullableRetellLlmOverrideStartSpeaker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SendSMSToolType?), TypeInfoPropertyName = "NullableSendSMSToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SendSMSToolExecutionMessageType?), TypeInfoPropertyName = "NullableSendSMSToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsContent?), TypeInfoPropertyName = "NullableSmsContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSender?), TypeInfoPropertyName = "NullableSmsSender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSenderVariant1Type?), TypeInfoPropertyName = "NullableSmsSenderVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSenderVariant2Type?), TypeInfoPropertyName = "NullableSmsSenderVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsDestination?), TypeInfoPropertyName = "NullableSmsDestination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsDestinationVariant1Type?), TypeInfoPropertyName = "NullableSmsDestinationVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsDestinationVariant2Type?), TypeInfoPropertyName = "NullableSmsDestinationVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.SentimentAnalysisDetailVariant1, global::RetellAI.SentimentAnalysisDetailVariant2>?), TypeInfoPropertyName = "NullableOneOfSentimentAnalysisDetailVariant1SentimentAnalysisDetailVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SentimentAnalysisDetailVariant1Sentiment?), TypeInfoPropertyName = "NullableSentimentAnalysisDetailVariant1Sentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SentimentAnalysisDetailVariant2Sentiment?), TypeInfoPropertyName = "NullableSentimentAnalysisDetailVariant2Sentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SkipResponseEdgeVariant2TransitionConditionType?), TypeInfoPropertyName = "NullableSkipResponseEdgeVariant2TransitionConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SkipResponseEdgeVariant2TransitionConditionPrompt?), TypeInfoPropertyName = "NullableSkipResponseEdgeVariant2TransitionConditionPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlwaysEdgeVariant2TransitionConditionType?), TypeInfoPropertyName = "NullableAlwaysEdgeVariant2TransitionConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlwaysEdgeVariant2TransitionConditionPrompt?), TypeInfoPropertyName = "NullableAlwaysEdgeVariant2TransitionConditionPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsContentInferredType?), TypeInfoPropertyName = "NullableSmsContentInferredType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsContentPredefinedType?), TypeInfoPropertyName = "NullableSmsContentPredefinedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsContentTemplateType?), TypeInfoPropertyName = "NullableSmsContentTemplateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsContentTemplateTemplate?), TypeInfoPropertyName = "NullableSmsContentTemplateTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsFailedEdge?), TypeInfoPropertyName = "NullableSmsFailedEdge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsFailedEdgeVariant2TransitionConditionType?), TypeInfoPropertyName = "NullableSmsFailedEdgeVariant2TransitionConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsFailedEdgeVariant2TransitionConditionPrompt?), TypeInfoPropertyName = "NullableSmsFailedEdgeVariant2TransitionConditionPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsNodeVariant2Type?), TypeInfoPropertyName = "NullableSmsNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.NodeInstruction?, global::RetellAI.SmsInstructionTemplate>?), TypeInfoPropertyName = "NullableOneOfNodeInstructionSmsInstructionTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSuccessEdge?), TypeInfoPropertyName = "NullableSmsSuccessEdge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionType?), TypeInfoPropertyName = "NullableSmsSuccessEdgeVariant2TransitionConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionPrompt?), TypeInfoPropertyName = "NullableSmsSuccessEdgeVariant2TransitionConditionPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StateTransitionMessageBaseRole?), TypeInfoPropertyName = "NullableStateTransitionMessageBaseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StringAnalysisDataType?), TypeInfoPropertyName = "NullableStringAnalysisDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseBatchJobStatus?), TypeInfoPropertyName = "NullableTestCaseBatchJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseDefinition?), TypeInfoPropertyName = "NullableTestCaseDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseDefinitionVariant2Type?), TypeInfoPropertyName = "NullableTestCaseDefinitionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseJobStatus?), TypeInfoPropertyName = "NullableTestCaseJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolMockInputMatchRule?), TypeInfoPropertyName = "NullableToolMockInputMatchRule2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolMockInputMatchRuleVariant1Type?), TypeInfoPropertyName = "NullableToolMockInputMatchRuleVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolMockInputMatchRuleVariant2Type?), TypeInfoPropertyName = "NullableToolMockInputMatchRuleVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallInvocationMessageBaseRole?), TypeInfoPropertyName = "NullableToolCallInvocationMessageBaseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallInvocationUtteranceRole?), TypeInfoPropertyName = "NullableToolCallInvocationUtteranceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallResultMessageBaseRole?), TypeInfoPropertyName = "NullableToolCallResultMessageBaseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallResultUtteranceRole?), TypeInfoPropertyName = "NullableToolCallResultUtteranceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolParameterType?), TypeInfoPropertyName = "NullableToolParameterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferCallNodeVariant2Type?), TypeInfoPropertyName = "NullableTransferCallNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferDestination?), TypeInfoPropertyName = "NullableTransferDestination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOption?), TypeInfoPropertyName = "NullableTransferOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferCallToolType?), TypeInfoPropertyName = "NullableTransferCallToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferCallToolExecutionMessageType?), TypeInfoPropertyName = "NullableTransferCallToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferDestinationInferredType?), TypeInfoPropertyName = "NullableTransferDestinationInferredType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferDestinationPredefinedType?), TypeInfoPropertyName = "NullableTransferDestinationPredefinedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferFailedEdgeVariant2TransitionConditionType?), TypeInfoPropertyName = "NullableTransferFailedEdgeVariant2TransitionConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferFailedEdgeVariant2TransitionConditionPrompt?), TypeInfoPropertyName = "NullableTransferFailedEdgeVariant2TransitionConditionPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionAgenticWarmTransferType?), TypeInfoPropertyName = "NullableTransferOptionAgenticWarmTransferType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionAgenticWarmTransferOnHoldMusic?), TypeInfoPropertyName = "NullableTransferOptionAgenticWarmTransferOnHoldMusic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.WarmTransferPrompt, global::RetellAI.WarmTransferStaticMessage>?), TypeInfoPropertyName = "NullableOneOfWarmTransferPromptWarmTransferStaticMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeout?), TypeInfoPropertyName = "NullableTransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeout2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionColdTransferType?), TypeInfoPropertyName = "NullableTransferOptionColdTransferType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionColdTransferColdTransferMode?), TypeInfoPropertyName = "NullableTransferOptionColdTransferColdTransferMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionWarmTransferType?), TypeInfoPropertyName = "NullableTransferOptionWarmTransferType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionWarmTransferOnHoldMusic?), TypeInfoPropertyName = "NullableTransferOptionWarmTransferOnHoldMusic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateSpendBudgetRequest?), TypeInfoPropertyName = "NullableUpdateSpendBudgetRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceHallucinationHallucinationType?), TypeInfoPropertyName = "NullableUtteranceHallucinationHallucinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceOrToolCall?), TypeInfoPropertyName = "NullableUtteranceOrToolCall2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceRole?), TypeInfoPropertyName = "NullableUtteranceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2CallBaseCallStatus?), TypeInfoPropertyName = "NullableV2CallBaseCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2CallBaseDataStorageSetting?), TypeInfoPropertyName = "NullableV2CallBaseDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2CallResponse?), TypeInfoPropertyName = "NullableV2CallResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2WebCallResponse?), TypeInfoPropertyName = "NullableV2WebCallResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2PhoneCallResponse?), TypeInfoPropertyName = "NullableV2PhoneCallResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3CallResponse?), TypeInfoPropertyName = "NullableV3CallResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3WebCallResponse?), TypeInfoPropertyName = "NullableV3WebCallResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3PhoneCallResponse?), TypeInfoPropertyName = "NullableV3PhoneCallResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3CallBaseCallStatus?), TypeInfoPropertyName = "NullableV3CallBaseCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3CallBaseDataStorageSetting?), TypeInfoPropertyName = "NullableV3CallBaseDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3PhoneCallResponseVariant1CallType?), TypeInfoPropertyName = "NullableV3PhoneCallResponseVariant1CallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3PhoneCallResponseVariant1Direction?), TypeInfoPropertyName = "NullableV3PhoneCallResponseVariant1Direction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3WebCallResponseVariant1CallType?), TypeInfoPropertyName = "NullableV3WebCallResponseVariant1CallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3ListCallsRequestSortOrder?), TypeInfoPropertyName = "NullableV3ListCallsRequestSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2PhoneCallResponseVariant1CallType?), TypeInfoPropertyName = "NullableV2PhoneCallResponseVariant1CallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2PhoneCallResponseVariant1Direction?), TypeInfoPropertyName = "NullableV2PhoneCallResponseVariant1Direction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2WebCallResponseVariant1CallType?), TypeInfoPropertyName = "NullableV2WebCallResponseVariant1CallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoiceResponseProvider?), TypeInfoPropertyName = "NullableVoiceResponseProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoiceResponseGender?), TypeInfoPropertyName = "NullableVoiceResponseGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoicemailActionBridgeTransferType?), TypeInfoPropertyName = "NullableVoicemailActionBridgeTransferType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoicemailActionHangupType?), TypeInfoPropertyName = "NullableVoicemailActionHangupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoicemailActionPromptType?), TypeInfoPropertyName = "NullableVoicemailActionPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoicemailActionStaticTextType?), TypeInfoPropertyName = "NullableVoicemailActionStaticTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.IvrActionHangupType?), TypeInfoPropertyName = "NullableIvrActionHangupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.IvrAction?), TypeInfoPropertyName = "NullableIvrAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.WarmTransferPromptType?), TypeInfoPropertyName = "NullableWarmTransferPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.WarmTransferStaticMessageType?), TypeInfoPropertyName = "NullableWarmTransferStaticMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorOverageConfigVariant1Mode?), TypeInfoPropertyName = "NullableConductorOverageConfigVariant1Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorOverageConfigVariant2Mode?), TypeInfoPropertyName = "NullableConductorOverageConfigVariant2Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorOverageConfigVariant3Mode?), TypeInfoPropertyName = "NullableConductorOverageConfigVariant3Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactConversation?), TypeInfoPropertyName = "NullableContactConversation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactCallType?), TypeInfoPropertyName = "NullableContactCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactCallDirection?), TypeInfoPropertyName = "NullableContactCallDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactCallSentiment?), TypeInfoPropertyName = "NullableContactCallSentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactChatType?), TypeInfoPropertyName = "NullableContactChatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactChatDirection?), TypeInfoPropertyName = "NullableContactChatDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactChatSentiment?), TypeInfoPropertyName = "NullableContactChatSentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppType?), TypeInfoPropertyName = "NullableAppType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppConnectionStatus?), TypeInfoPropertyName = "NullableAppConnectionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OAuthConfigRequestType?), TypeInfoPropertyName = "NullableOAuthConfigRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ApiKeyAuthConfigRequestType?), TypeInfoPropertyName = "NullableApiKeyAuthConfigRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AccessTokenAuthConfigRequestType?), TypeInfoPropertyName = "NullableAccessTokenAuthConfigRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BasicAuthConfigRequestType?), TypeInfoPropertyName = "NullableBasicAuthConfigRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RefreshTokenAuthConfigRequestType?), TypeInfoPropertyName = "NullableRefreshTokenAuthConfigRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AuthConfigRequest?), TypeInfoPropertyName = "NullableAuthConfigRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OAuthConfigResponseType?), TypeInfoPropertyName = "NullableOAuthConfigResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ApiKeyAuthConfigResponseType?), TypeInfoPropertyName = "NullableApiKeyAuthConfigResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AccessTokenAuthConfigResponseType?), TypeInfoPropertyName = "NullableAccessTokenAuthConfigResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BasicAuthConfigResponseType?), TypeInfoPropertyName = "NullableBasicAuthConfigResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RefreshTokenAuthConfigResponseType?), TypeInfoPropertyName = "NullableRefreshTokenAuthConfigResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppAuthConfigResponse?), TypeInfoPropertyName = "NullableAppAuthConfigResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppUsageResponse?), TypeInfoPropertyName = "NullableAppUsageResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentAppUsageType?), TypeInfoPropertyName = "NullableAgentAppUsageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseAppUsageType?), TypeInfoPropertyName = "NullableKnowledgeBaseAppUsageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CRMCustomFieldSchemaType?), TypeInfoPropertyName = "NullableCRMCustomFieldSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CRMAnalysisDataMappingUpdateMode?), TypeInfoPropertyName = "NullableCRMAnalysisDataMappingUpdateMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.JobStatusStatus?), TypeInfoPropertyName = "NullableJobStatusStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.JobStatusTriggeredBy?), TypeInfoPropertyName = "NullableJobStatusTriggeredBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DashboardSource?), TypeInfoPropertyName = "NullableDashboardSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartGroupItem?), TypeInfoPropertyName = "NullableChartGroupItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartGroupItemVariant1Type?), TypeInfoPropertyName = "NullableChartGroupItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartGroupItemVariant2Type?), TypeInfoPropertyName = "NullableChartGroupItemVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.AgentRequest, object>?), TypeInfoPropertyName = "NullableAllOfAgentRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.TestCaseDefinitionInput, object>?), TypeInfoPropertyName = "NullableAllOfTestCaseDefinitionInputObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.ChatAgentRequest, object>?), TypeInfoPropertyName = "NullableAllOfChatAgentRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberRequestNumberProvider?), TypeInfoPropertyName = "NullableCreatePhoneNumberRequestNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberRequestCountryCode?), TypeInfoPropertyName = "NullableCreatePhoneNumberRequestCountryCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceRequestVoiceProvider?), TypeInfoPropertyName = "NullableCloneVoiceRequestVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceRequestVoiceProvider?), TypeInfoPropertyName = "NullableAddCommunityVoiceRequestVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceRequestVoiceProvider?), TypeInfoPropertyName = "NullableSearchCommunityVoiceRequestVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataRequestDataStorageSetting?), TypeInfoPropertyName = "NullableUpdateChatMetadataRequestDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallRequestDirection?), TypeInfoPropertyName = "NullableRegisterPhoneCallRequestDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataRequestDataStorageSetting?), TypeInfoPropertyName = "NullableUpdateCallMetadataRequestDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallRequestFieldsToOverrideDataStorageSetting?), TypeInfoPropertyName = "NullableUpdateLiveCallRequestFieldsToOverrideDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsType?), TypeInfoPropertyName = "NullableListTestCaseDefinitionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsType?), TypeInfoPropertyName = "NullableListBatchTestsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsSortOrder?), TypeInfoPropertyName = "NullableListAgentVersionsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsSortOrder?), TypeInfoPropertyName = "NullableListAgentsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsSortOrder?), TypeInfoPropertyName = "NullableListConversationFlowComponentsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsSortOrder?), TypeInfoPropertyName = "NullableListConversationFlowsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersSortOrder?), TypeInfoPropertyName = "NullableListPhoneNumbersSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMSortOrder?), TypeInfoPropertyName = "NullableListRetellLLMSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsSortOrder?), TypeInfoPropertyName = "NullableListExportRequestsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppsSortOrder?), TypeInfoPropertyName = "NullableListAppsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppUsagesSortOrder?), TypeInfoPropertyName = "NullableListAppUsagesSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus?), TypeInfoPropertyName = "NullableAddKnowledgeBaseSourcesResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus2?), TypeInfoPropertyName = "NullableAddKnowledgeBaseSourcesResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus3?), TypeInfoPropertyName = "NullableAddKnowledgeBaseSourcesResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus4?), TypeInfoPropertyName = "NullableAddKnowledgeBaseSourcesResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus5?), TypeInfoPropertyName = "NullableAddKnowledgeBaseSourcesResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentResponseStatus?), TypeInfoPropertyName = "NullableCreateAgentResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentResponseStatus2?), TypeInfoPropertyName = "NullableCreateAgentResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentResponseStatus3?), TypeInfoPropertyName = "NullableCreateAgentResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentResponseStatus4?), TypeInfoPropertyName = "NullableCreateAgentResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallResponseStatus?), TypeInfoPropertyName = "NullableCreateBatchCallResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallResponseStatus2?), TypeInfoPropertyName = "NullableCreateBatchCallResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallResponseStatus3?), TypeInfoPropertyName = "NullableCreateBatchCallResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallResponseStatus4?), TypeInfoPropertyName = "NullableCreateBatchCallResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponseStatus?), TypeInfoPropertyName = "NullableCreateBatchTestResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponseStatus2?), TypeInfoPropertyName = "NullableCreateBatchTestResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponseStatus3?), TypeInfoPropertyName = "NullableCreateBatchTestResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponseStatus4?), TypeInfoPropertyName = "NullableCreateBatchTestResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponseStatus5?), TypeInfoPropertyName = "NullableCreateBatchTestResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus?), TypeInfoPropertyName = "NullableCreateTestCaseDefinitionResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus2?), TypeInfoPropertyName = "NullableCreateTestCaseDefinitionResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus3?), TypeInfoPropertyName = "NullableCreateTestCaseDefinitionResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus4?), TypeInfoPropertyName = "NullableCreateTestCaseDefinitionResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus5?), TypeInfoPropertyName = "NullableCreateTestCaseDefinitionResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus?), TypeInfoPropertyName = "NullableDeleteTestCaseDefinitionResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus2?), TypeInfoPropertyName = "NullableDeleteTestCaseDefinitionResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus3?), TypeInfoPropertyName = "NullableDeleteTestCaseDefinitionResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus4?), TypeInfoPropertyName = "NullableDeleteTestCaseDefinitionResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus5?), TypeInfoPropertyName = "NullableDeleteTestCaseDefinitionResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus?), TypeInfoPropertyName = "NullableGetTestCaseDefinitionResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus2?), TypeInfoPropertyName = "NullableGetTestCaseDefinitionResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus3?), TypeInfoPropertyName = "NullableGetTestCaseDefinitionResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus4?), TypeInfoPropertyName = "NullableGetTestCaseDefinitionResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus5?), TypeInfoPropertyName = "NullableGetTestCaseDefinitionResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListTestCaseDefinitionsResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListTestCaseDefinitionsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus?), TypeInfoPropertyName = "NullableListTestCaseDefinitionsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus2?), TypeInfoPropertyName = "NullableListTestCaseDefinitionsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus3?), TypeInfoPropertyName = "NullableListTestCaseDefinitionsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus4?), TypeInfoPropertyName = "NullableListTestCaseDefinitionsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus?), TypeInfoPropertyName = "NullableUpdateTestCaseDefinitionResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus2?), TypeInfoPropertyName = "NullableUpdateTestCaseDefinitionResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus3?), TypeInfoPropertyName = "NullableUpdateTestCaseDefinitionResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus4?), TypeInfoPropertyName = "NullableUpdateTestCaseDefinitionResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus5?), TypeInfoPropertyName = "NullableUpdateTestCaseDefinitionResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponseStatus?), TypeInfoPropertyName = "NullableGetBatchTestResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponseStatus2?), TypeInfoPropertyName = "NullableGetBatchTestResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponseStatus3?), TypeInfoPropertyName = "NullableGetBatchTestResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponseStatus4?), TypeInfoPropertyName = "NullableGetBatchTestResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponseStatus5?), TypeInfoPropertyName = "NullableGetBatchTestResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListBatchTestsResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListBatchTestsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponseStatus?), TypeInfoPropertyName = "NullableListBatchTestsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponseStatus2?), TypeInfoPropertyName = "NullableListBatchTestsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponseStatus3?), TypeInfoPropertyName = "NullableListBatchTestsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponseStatus4?), TypeInfoPropertyName = "NullableListBatchTestsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponseStatus?), TypeInfoPropertyName = "NullableGetTestRunResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponseStatus2?), TypeInfoPropertyName = "NullableGetTestRunResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponseStatus3?), TypeInfoPropertyName = "NullableGetTestRunResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponseStatus4?), TypeInfoPropertyName = "NullableGetTestRunResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponseStatus5?), TypeInfoPropertyName = "NullableGetTestRunResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListTestRunsResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListTestRunsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponseStatus?), TypeInfoPropertyName = "NullableListTestRunsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponseStatus2?), TypeInfoPropertyName = "NullableListTestRunsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponseStatus3?), TypeInfoPropertyName = "NullableListTestRunsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponseStatus4?), TypeInfoPropertyName = "NullableListTestRunsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponseStatus5?), TypeInfoPropertyName = "NullableListTestRunsResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatAgentResponseStatus?), TypeInfoPropertyName = "NullableCreateChatAgentResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatAgentResponseStatus2?), TypeInfoPropertyName = "NullableCreateChatAgentResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatAgentResponseStatus3?), TypeInfoPropertyName = "NullableCreateChatAgentResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatAgentResponseStatus4?), TypeInfoPropertyName = "NullableCreateChatAgentResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus?), TypeInfoPropertyName = "NullableAgentPlaygroundCompletionResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus2?), TypeInfoPropertyName = "NullableAgentPlaygroundCompletionResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus3?), TypeInfoPropertyName = "NullableAgentPlaygroundCompletionResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus4?), TypeInfoPropertyName = "NullableAgentPlaygroundCompletionResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus5?), TypeInfoPropertyName = "NullableAgentPlaygroundCompletionResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus6?), TypeInfoPropertyName = "NullableAgentPlaygroundCompletionResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponseStatus?), TypeInfoPropertyName = "NullableCreateChatCompletionResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponseStatus2?), TypeInfoPropertyName = "NullableCreateChatCompletionResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponseStatus3?), TypeInfoPropertyName = "NullableCreateChatCompletionResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponseStatus4?), TypeInfoPropertyName = "NullableCreateChatCompletionResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponseStatus5?), TypeInfoPropertyName = "NullableCreateChatCompletionResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponseStatus6?), TypeInfoPropertyName = "NullableCreateChatCompletionResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponseStatus?), TypeInfoPropertyName = "NullableCreateChatResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponseStatus2?), TypeInfoPropertyName = "NullableCreateChatResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponseStatus3?), TypeInfoPropertyName = "NullableCreateChatResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponseStatus4?), TypeInfoPropertyName = "NullableCreateChatResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponseStatus5?), TypeInfoPropertyName = "NullableCreateChatResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponseStatus6?), TypeInfoPropertyName = "NullableCreateChatResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus?), TypeInfoPropertyName = "NullableCreateConversationFlowComponentResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus2?), TypeInfoPropertyName = "NullableCreateConversationFlowComponentResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus3?), TypeInfoPropertyName = "NullableCreateConversationFlowComponentResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus4?), TypeInfoPropertyName = "NullableCreateConversationFlowComponentResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus5?), TypeInfoPropertyName = "NullableCreateConversationFlowComponentResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponseStatus?), TypeInfoPropertyName = "NullableCreateConversationFlowResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponseStatus2?), TypeInfoPropertyName = "NullableCreateConversationFlowResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponseStatus3?), TypeInfoPropertyName = "NullableCreateConversationFlowResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponseStatus4?), TypeInfoPropertyName = "NullableCreateConversationFlowResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponseStatus5?), TypeInfoPropertyName = "NullableCreateConversationFlowResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus?), TypeInfoPropertyName = "NullableCreateKnowledgeBaseResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus2?), TypeInfoPropertyName = "NullableCreateKnowledgeBaseResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus3?), TypeInfoPropertyName = "NullableCreateKnowledgeBaseResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus4?), TypeInfoPropertyName = "NullableCreateKnowledgeBaseResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus5?), TypeInfoPropertyName = "NullableCreateKnowledgeBaseResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberResponseStatus?), TypeInfoPropertyName = "NullableCreatePhoneNumberResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberResponseStatus2?), TypeInfoPropertyName = "NullableCreatePhoneNumberResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberResponseStatus3?), TypeInfoPropertyName = "NullableCreatePhoneNumberResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateRetellLLMResponseStatus?), TypeInfoPropertyName = "NullableCreateRetellLLMResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateRetellLLMResponseStatus2?), TypeInfoPropertyName = "NullableCreateRetellLLMResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateRetellLLMResponseStatus3?), TypeInfoPropertyName = "NullableCreateRetellLLMResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponseStatus?), TypeInfoPropertyName = "NullableCreateSmsChatResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponseStatus2?), TypeInfoPropertyName = "NullableCreateSmsChatResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponseStatus3?), TypeInfoPropertyName = "NullableCreateSmsChatResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponseStatus4?), TypeInfoPropertyName = "NullableCreateSmsChatResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponseStatus5?), TypeInfoPropertyName = "NullableCreateSmsChatResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponseStatus6?), TypeInfoPropertyName = "NullableCreateSmsChatResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentResponseStatus?), TypeInfoPropertyName = "NullableDeleteAgentResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentResponseStatus2?), TypeInfoPropertyName = "NullableDeleteAgentResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentResponseStatus3?), TypeInfoPropertyName = "NullableDeleteAgentResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentResponseStatus4?), TypeInfoPropertyName = "NullableDeleteAgentResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatResponseStatus?), TypeInfoPropertyName = "NullableDeleteChatResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatResponseStatus2?), TypeInfoPropertyName = "NullableDeleteChatResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatResponseStatus3?), TypeInfoPropertyName = "NullableDeleteChatResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatResponseStatus4?), TypeInfoPropertyName = "NullableDeleteChatResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatAgentResponseStatus?), TypeInfoPropertyName = "NullableDeleteChatAgentResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatAgentResponseStatus2?), TypeInfoPropertyName = "NullableDeleteChatAgentResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatAgentResponseStatus3?), TypeInfoPropertyName = "NullableDeleteChatAgentResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatAgentResponseStatus4?), TypeInfoPropertyName = "NullableDeleteChatAgentResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus?), TypeInfoPropertyName = "NullableDeleteConversationFlowComponentResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus2?), TypeInfoPropertyName = "NullableDeleteConversationFlowComponentResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus3?), TypeInfoPropertyName = "NullableDeleteConversationFlowComponentResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus4?), TypeInfoPropertyName = "NullableDeleteConversationFlowComponentResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponseStatus?), TypeInfoPropertyName = "NullableDeleteConversationFlowResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponseStatus2?), TypeInfoPropertyName = "NullableDeleteConversationFlowResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponseStatus3?), TypeInfoPropertyName = "NullableDeleteConversationFlowResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponseStatus4?), TypeInfoPropertyName = "NullableDeleteConversationFlowResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponseStatus5?), TypeInfoPropertyName = "NullableDeleteConversationFlowResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus?), TypeInfoPropertyName = "NullableDeleteKnowledgeBaseSourceResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus2?), TypeInfoPropertyName = "NullableDeleteKnowledgeBaseSourceResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus3?), TypeInfoPropertyName = "NullableDeleteKnowledgeBaseSourceResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus4?), TypeInfoPropertyName = "NullableDeleteKnowledgeBaseSourceResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus?), TypeInfoPropertyName = "NullableDeleteKnowledgeBaseResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus2?), TypeInfoPropertyName = "NullableDeleteKnowledgeBaseResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus3?), TypeInfoPropertyName = "NullableDeleteKnowledgeBaseResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus4?), TypeInfoPropertyName = "NullableDeleteKnowledgeBaseResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeletePhoneNumberResponseStatus?), TypeInfoPropertyName = "NullableDeletePhoneNumberResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeletePhoneNumberResponseStatus2?), TypeInfoPropertyName = "NullableDeletePhoneNumberResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeletePhoneNumberResponseStatus3?), TypeInfoPropertyName = "NullableDeletePhoneNumberResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteRetellLLMResponseStatus?), TypeInfoPropertyName = "NullableDeleteRetellLLMResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteRetellLLMResponseStatus2?), TypeInfoPropertyName = "NullableDeleteRetellLLMResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteRetellLLMResponseStatus3?), TypeInfoPropertyName = "NullableDeleteRetellLLMResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteRetellLLMResponseStatus4?), TypeInfoPropertyName = "NullableDeleteRetellLLMResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndChatResponseStatus?), TypeInfoPropertyName = "NullableEndChatResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndChatResponseStatus2?), TypeInfoPropertyName = "NullableEndChatResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndChatResponseStatus3?), TypeInfoPropertyName = "NullableEndChatResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndChatResponseStatus4?), TypeInfoPropertyName = "NullableEndChatResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAgentVersionsResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListAgentVersionsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponseStatus?), TypeInfoPropertyName = "NullableListAgentVersionsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponseStatus2?), TypeInfoPropertyName = "NullableListAgentVersionsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponseStatus3?), TypeInfoPropertyName = "NullableListAgentVersionsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponseStatus4?), TypeInfoPropertyName = "NullableListAgentVersionsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponseStatus5?), TypeInfoPropertyName = "NullableListAgentVersionsResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponseStatus6?), TypeInfoPropertyName = "NullableListAgentVersionsResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentVersionsResponseStatus?), TypeInfoPropertyName = "NullableGetAgentVersionsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentVersionsResponseStatus2?), TypeInfoPropertyName = "NullableGetAgentVersionsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentVersionsResponseStatus3?), TypeInfoPropertyName = "NullableGetAgentVersionsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentVersionsResponseStatus4?), TypeInfoPropertyName = "NullableGetAgentVersionsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentResponseStatus?), TypeInfoPropertyName = "NullableGetAgentResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentResponseStatus2?), TypeInfoPropertyName = "NullableGetAgentResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentResponseStatus3?), TypeInfoPropertyName = "NullableGetAgentResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentResponseStatus4?), TypeInfoPropertyName = "NullableGetAgentResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentVersionsResponseStatus?), TypeInfoPropertyName = "NullableGetChatAgentVersionsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentVersionsResponseStatus2?), TypeInfoPropertyName = "NullableGetChatAgentVersionsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentVersionsResponseStatus3?), TypeInfoPropertyName = "NullableGetChatAgentVersionsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentResponseStatus?), TypeInfoPropertyName = "NullableGetChatAgentResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentResponseStatus2?), TypeInfoPropertyName = "NullableGetChatAgentResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentResponseStatus3?), TypeInfoPropertyName = "NullableGetChatAgentResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentResponseStatus4?), TypeInfoPropertyName = "NullableGetChatAgentResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatResponseStatus?), TypeInfoPropertyName = "NullableGetChatResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatResponseStatus2?), TypeInfoPropertyName = "NullableGetChatResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatResponseStatus3?), TypeInfoPropertyName = "NullableGetChatResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatResponseStatus4?), TypeInfoPropertyName = "NullableGetChatResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConcurrencyResponseStatus?), TypeInfoPropertyName = "NullableGetConcurrencyResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConcurrencyResponseStatus2?), TypeInfoPropertyName = "NullableGetConcurrencyResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetApiKeyInfoResponseStatus?), TypeInfoPropertyName = "NullableGetApiKeyInfoResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetApiKeyInfoResponseStatus2?), TypeInfoPropertyName = "NullableGetApiKeyInfoResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowComponentResponseStatus?), TypeInfoPropertyName = "NullableGetConversationFlowComponentResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowComponentResponseStatus2?), TypeInfoPropertyName = "NullableGetConversationFlowComponentResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowComponentResponseStatus3?), TypeInfoPropertyName = "NullableGetConversationFlowComponentResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowComponentResponseStatus4?), TypeInfoPropertyName = "NullableGetConversationFlowComponentResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponseStatus?), TypeInfoPropertyName = "NullableGetConversationFlowResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponseStatus2?), TypeInfoPropertyName = "NullableGetConversationFlowResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponseStatus3?), TypeInfoPropertyName = "NullableGetConversationFlowResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponseStatus4?), TypeInfoPropertyName = "NullableGetConversationFlowResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponseStatus5?), TypeInfoPropertyName = "NullableGetConversationFlowResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetKnowledgeBaseResponseStatus?), TypeInfoPropertyName = "NullableGetKnowledgeBaseResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetKnowledgeBaseResponseStatus2?), TypeInfoPropertyName = "NullableGetKnowledgeBaseResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetKnowledgeBaseResponseStatus3?), TypeInfoPropertyName = "NullableGetKnowledgeBaseResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetKnowledgeBaseResponseStatus4?), TypeInfoPropertyName = "NullableGetKnowledgeBaseResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetMCPToolsResponseStatus?), TypeInfoPropertyName = "NullableGetMCPToolsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetMCPToolsResponseStatus2?), TypeInfoPropertyName = "NullableGetMCPToolsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetMCPToolsResponseStatus3?), TypeInfoPropertyName = "NullableGetMCPToolsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetMCPToolsResponseStatus4?), TypeInfoPropertyName = "NullableGetMCPToolsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetPhoneNumberResponseStatus?), TypeInfoPropertyName = "NullableGetPhoneNumberResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetPhoneNumberResponseStatus2?), TypeInfoPropertyName = "NullableGetPhoneNumberResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetPhoneNumberResponseStatus3?), TypeInfoPropertyName = "NullableGetPhoneNumberResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetPhoneNumberResponseStatus4?), TypeInfoPropertyName = "NullableGetPhoneNumberResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetRetellLLMResponseStatus?), TypeInfoPropertyName = "NullableGetRetellLLMResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetRetellLLMResponseStatus2?), TypeInfoPropertyName = "NullableGetRetellLLMResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetRetellLLMResponseStatus3?), TypeInfoPropertyName = "NullableGetRetellLLMResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetRetellLLMResponseStatus4?), TypeInfoPropertyName = "NullableGetRetellLLMResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetVoiceResponseStatus?), TypeInfoPropertyName = "NullableGetVoiceResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetVoiceResponseStatus2?), TypeInfoPropertyName = "NullableGetVoiceResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetVoiceResponseStatus3?), TypeInfoPropertyName = "NullableGetVoiceResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetVoiceResponseStatus4?), TypeInfoPropertyName = "NullableGetVoiceResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponseStatus?), TypeInfoPropertyName = "NullableCloneVoiceResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponseStatus2?), TypeInfoPropertyName = "NullableCloneVoiceResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponseStatus3?), TypeInfoPropertyName = "NullableCloneVoiceResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponseStatus4?), TypeInfoPropertyName = "NullableCloneVoiceResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponseStatus5?), TypeInfoPropertyName = "NullableCloneVoiceResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceResponseStatus?), TypeInfoPropertyName = "NullableAddCommunityVoiceResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceResponseStatus2?), TypeInfoPropertyName = "NullableAddCommunityVoiceResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceResponseStatus3?), TypeInfoPropertyName = "NullableAddCommunityVoiceResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceResponseStatus4?), TypeInfoPropertyName = "NullableAddCommunityVoiceResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponseStatus?), TypeInfoPropertyName = "NullableSearchCommunityVoiceResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponseStatus2?), TypeInfoPropertyName = "NullableSearchCommunityVoiceResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponseStatus3?), TypeInfoPropertyName = "NullableSearchCommunityVoiceResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponseStatus4?), TypeInfoPropertyName = "NullableSearchCommunityVoiceResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ImportPhoneNumberResponseStatus?), TypeInfoPropertyName = "NullableImportPhoneNumberResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ImportPhoneNumberResponseStatus2?), TypeInfoPropertyName = "NullableImportPhoneNumberResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ImportPhoneNumberResponseStatus3?), TypeInfoPropertyName = "NullableImportPhoneNumberResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAgentsResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListAgentsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponseStatus?), TypeInfoPropertyName = "NullableListAgentsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponseStatus2?), TypeInfoPropertyName = "NullableListAgentsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponseStatus3?), TypeInfoPropertyName = "NullableListAgentsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponseStatus4?), TypeInfoPropertyName = "NullableListAgentsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListChatsResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListChatsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsResponseStatus?), TypeInfoPropertyName = "NullableListChatsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsResponseStatus2?), TypeInfoPropertyName = "NullableListChatsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsResponseStatus3?), TypeInfoPropertyName = "NullableListChatsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsResponseStatus4?), TypeInfoPropertyName = "NullableListChatsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowComponentsResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListConversationFlowComponentsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus?), TypeInfoPropertyName = "NullableListConversationFlowComponentsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus2?), TypeInfoPropertyName = "NullableListConversationFlowComponentsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus3?), TypeInfoPropertyName = "NullableListConversationFlowComponentsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus4?), TypeInfoPropertyName = "NullableListConversationFlowComponentsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowsResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListConversationFlowsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponseStatus?), TypeInfoPropertyName = "NullableListConversationFlowsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponseStatus2?), TypeInfoPropertyName = "NullableListConversationFlowsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponseStatus3?), TypeInfoPropertyName = "NullableListConversationFlowsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponseStatus4?), TypeInfoPropertyName = "NullableListConversationFlowsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponseStatus5?), TypeInfoPropertyName = "NullableListConversationFlowsResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListKnowledgeBasesResponseStatus?), TypeInfoPropertyName = "NullableListKnowledgeBasesResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListKnowledgeBasesResponseStatus2?), TypeInfoPropertyName = "NullableListKnowledgeBasesResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListKnowledgeBasesResponseStatus3?), TypeInfoPropertyName = "NullableListKnowledgeBasesResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListPhoneNumbersResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListPhoneNumbersResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersResponseStatus?), TypeInfoPropertyName = "NullableListPhoneNumbersResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersResponseStatus2?), TypeInfoPropertyName = "NullableListPhoneNumbersResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListRetellLLMResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListRetellLLMResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponseStatus?), TypeInfoPropertyName = "NullableListRetellLLMResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponseStatus2?), TypeInfoPropertyName = "NullableListRetellLLMResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponseStatus3?), TypeInfoPropertyName = "NullableListRetellLLMResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponseStatus4?), TypeInfoPropertyName = "NullableListRetellLLMResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponseStatus5?), TypeInfoPropertyName = "NullableListRetellLLMResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListVoicesResponseStatus?), TypeInfoPropertyName = "NullableListVoicesResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListVoicesResponseStatus2?), TypeInfoPropertyName = "NullableListVoicesResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.AgentResponse?, global::RetellAI.ChatAgentResponse?>?), TypeInfoPropertyName = "NullableOneOfAgentResponseChatAgentResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentVersionResponseStatus?), TypeInfoPropertyName = "NullableCreateAgentVersionResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentVersionResponseStatus2?), TypeInfoPropertyName = "NullableCreateAgentVersionResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentVersionResponseStatus3?), TypeInfoPropertyName = "NullableCreateAgentVersionResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentVersionResponseStatus4?), TypeInfoPropertyName = "NullableCreateAgentVersionResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentVersionResponseStatus5?), TypeInfoPropertyName = "NullableCreateAgentVersionResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentVersionResponseStatus?), TypeInfoPropertyName = "NullablePublishAgentVersionResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentVersionResponseStatus2?), TypeInfoPropertyName = "NullablePublishAgentVersionResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentVersionResponseStatus3?), TypeInfoPropertyName = "NullablePublishAgentVersionResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentVersionResponseStatus4?), TypeInfoPropertyName = "NullablePublishAgentVersionResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentVersionResponseStatus5?), TypeInfoPropertyName = "NullablePublishAgentVersionResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentVersionResponseStatus?), TypeInfoPropertyName = "NullableDeleteAgentVersionResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentVersionResponseStatus2?), TypeInfoPropertyName = "NullableDeleteAgentVersionResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentVersionResponseStatus3?), TypeInfoPropertyName = "NullableDeleteAgentVersionResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentVersionResponseStatus4?), TypeInfoPropertyName = "NullableDeleteAgentVersionResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentVersionResponseStatus5?), TypeInfoPropertyName = "NullableDeleteAgentVersionResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunCallAnalysisResponseStatus?), TypeInfoPropertyName = "NullableRerunCallAnalysisResponseStatus2_3")]
    internal sealed partial class SourceGenerationContextChunk4 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableLLMModel), TypeInfoPropertyName = "NullableLLMModel_RetellAI_NullableLLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.LLMModel?), TypeInfoPropertyName = "NullableLLMModel_RetellAI_LLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunCallAnalysisResponseStatus2?), TypeInfoPropertyName = "NullableRerunCallAnalysisResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunCallAnalysisResponseStatus3?), TypeInfoPropertyName = "NullableRerunCallAnalysisResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunCallAnalysisResponseStatus4?), TypeInfoPropertyName = "NullableRerunCallAnalysisResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunCallAnalysisResponseStatus5?), TypeInfoPropertyName = "NullableRerunCallAnalysisResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunCallAnalysisResponseStatus6?), TypeInfoPropertyName = "NullableRerunCallAnalysisResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunCallAnalysisResponseStatus7?), TypeInfoPropertyName = "NullableRerunCallAnalysisResponseStatus72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunChatAnalysisResponseStatus?), TypeInfoPropertyName = "NullableRerunChatAnalysisResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunChatAnalysisResponseStatus2?), TypeInfoPropertyName = "NullableRerunChatAnalysisResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunChatAnalysisResponseStatus3?), TypeInfoPropertyName = "NullableRerunChatAnalysisResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunChatAnalysisResponseStatus4?), TypeInfoPropertyName = "NullableRerunChatAnalysisResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunChatAnalysisResponseStatus5?), TypeInfoPropertyName = "NullableRerunChatAnalysisResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunChatAnalysisResponseStatus6?), TypeInfoPropertyName = "NullableRerunChatAnalysisResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunChatAnalysisResponseStatus7?), TypeInfoPropertyName = "NullableRerunChatAnalysisResponseStatus72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponseStatus?), TypeInfoPropertyName = "NullableUpdateAgentResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponseStatus2?), TypeInfoPropertyName = "NullableUpdateAgentResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponseStatus3?), TypeInfoPropertyName = "NullableUpdateAgentResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponseStatus4?), TypeInfoPropertyName = "NullableUpdateAgentResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponseStatus5?), TypeInfoPropertyName = "NullableUpdateAgentResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponseStatus?), TypeInfoPropertyName = "NullableUpdateChatAgentResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponseStatus2?), TypeInfoPropertyName = "NullableUpdateChatAgentResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponseStatus3?), TypeInfoPropertyName = "NullableUpdateChatAgentResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponseStatus4?), TypeInfoPropertyName = "NullableUpdateChatAgentResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponseStatus5?), TypeInfoPropertyName = "NullableUpdateChatAgentResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataResponseStatus?), TypeInfoPropertyName = "NullableUpdateChatMetadataResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataResponseStatus2?), TypeInfoPropertyName = "NullableUpdateChatMetadataResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataResponseStatus3?), TypeInfoPropertyName = "NullableUpdateChatMetadataResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataResponseStatus4?), TypeInfoPropertyName = "NullableUpdateChatMetadataResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus?), TypeInfoPropertyName = "NullableUpdateConversationFlowComponentResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus2?), TypeInfoPropertyName = "NullableUpdateConversationFlowComponentResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus3?), TypeInfoPropertyName = "NullableUpdateConversationFlowComponentResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus4?), TypeInfoPropertyName = "NullableUpdateConversationFlowComponentResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus5?), TypeInfoPropertyName = "NullableUpdateConversationFlowComponentResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus6?), TypeInfoPropertyName = "NullableUpdateConversationFlowComponentResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponseStatus?), TypeInfoPropertyName = "NullableUpdateConversationFlowResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponseStatus2?), TypeInfoPropertyName = "NullableUpdateConversationFlowResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponseStatus3?), TypeInfoPropertyName = "NullableUpdateConversationFlowResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponseStatus4?), TypeInfoPropertyName = "NullableUpdateConversationFlowResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponseStatus5?), TypeInfoPropertyName = "NullableUpdateConversationFlowResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponseStatus6?), TypeInfoPropertyName = "NullableUpdateConversationFlowResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberResponseStatus?), TypeInfoPropertyName = "NullableUpdatePhoneNumberResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberResponseStatus2?), TypeInfoPropertyName = "NullableUpdatePhoneNumberResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberResponseStatus3?), TypeInfoPropertyName = "NullableUpdatePhoneNumberResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberResponseStatus4?), TypeInfoPropertyName = "NullableUpdatePhoneNumberResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponseStatus?), TypeInfoPropertyName = "NullableUpdateRetellLLMResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponseStatus2?), TypeInfoPropertyName = "NullableUpdateRetellLLMResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponseStatus3?), TypeInfoPropertyName = "NullableUpdateRetellLLMResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponseStatus4?), TypeInfoPropertyName = "NullableUpdateRetellLLMResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponseStatus5?), TypeInfoPropertyName = "NullableUpdateRetellLLMResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponseStatus?), TypeInfoPropertyName = "NullableCreatePhoneCallResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponseStatus2?), TypeInfoPropertyName = "NullableCreatePhoneCallResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponseStatus3?), TypeInfoPropertyName = "NullableCreatePhoneCallResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponseStatus4?), TypeInfoPropertyName = "NullableCreatePhoneCallResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponseStatus5?), TypeInfoPropertyName = "NullableCreatePhoneCallResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponseStatus6?), TypeInfoPropertyName = "NullableCreatePhoneCallResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponseStatus?), TypeInfoPropertyName = "NullableCreateWebCallResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponseStatus2?), TypeInfoPropertyName = "NullableCreateWebCallResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponseStatus3?), TypeInfoPropertyName = "NullableCreateWebCallResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponseStatus4?), TypeInfoPropertyName = "NullableCreateWebCallResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponseStatus5?), TypeInfoPropertyName = "NullableCreateWebCallResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponseStatus6?), TypeInfoPropertyName = "NullableCreateWebCallResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteCallResponseStatus?), TypeInfoPropertyName = "NullableDeleteCallResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteCallResponseStatus2?), TypeInfoPropertyName = "NullableDeleteCallResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteCallResponseStatus3?), TypeInfoPropertyName = "NullableDeleteCallResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteCallResponseStatus4?), TypeInfoPropertyName = "NullableDeleteCallResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCallResponseStatus?), TypeInfoPropertyName = "NullableGetCallResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCallResponseStatus2?), TypeInfoPropertyName = "NullableGetCallResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCallResponseStatus3?), TypeInfoPropertyName = "NullableGetCallResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCallResponseStatus4?), TypeInfoPropertyName = "NullableGetCallResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListCallsResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListCallsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponseStatus?), TypeInfoPropertyName = "NullableListCallsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponseStatus2?), TypeInfoPropertyName = "NullableListCallsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponseStatus3?), TypeInfoPropertyName = "NullableListCallsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponseStatus4?), TypeInfoPropertyName = "NullableListCallsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListExportRequestsResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListExportRequestsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponseItemChannel?), TypeInfoPropertyName = "NullableListExportRequestsResponseItemChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponseItemStatus?), TypeInfoPropertyName = "NullableListExportRequestsResponseItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponseStatus?), TypeInfoPropertyName = "NullableListExportRequestsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponseStatus2?), TypeInfoPropertyName = "NullableListExportRequestsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponseStatus3?), TypeInfoPropertyName = "NullableListExportRequestsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponseStatus4?), TypeInfoPropertyName = "NullableListExportRequestsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponseStatus?), TypeInfoPropertyName = "NullableRegisterPhoneCallResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponseStatus2?), TypeInfoPropertyName = "NullableRegisterPhoneCallResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponseStatus3?), TypeInfoPropertyName = "NullableRegisterPhoneCallResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponseStatus4?), TypeInfoPropertyName = "NullableRegisterPhoneCallResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponseStatus5?), TypeInfoPropertyName = "NullableRegisterPhoneCallResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponseStatus6?), TypeInfoPropertyName = "NullableRegisterPhoneCallResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponseStatus?), TypeInfoPropertyName = "NullableUpdateCallMetadataResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponseStatus2?), TypeInfoPropertyName = "NullableUpdateCallMetadataResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponseStatus3?), TypeInfoPropertyName = "NullableUpdateCallMetadataResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponseStatus4?), TypeInfoPropertyName = "NullableUpdateCallMetadataResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallResponseStatus?), TypeInfoPropertyName = "NullableUpdateLiveCallResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallResponseStatus2?), TypeInfoPropertyName = "NullableUpdateLiveCallResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallResponseStatus3?), TypeInfoPropertyName = "NullableUpdateLiveCallResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallResponseStatus4?), TypeInfoPropertyName = "NullableUpdateLiveCallResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallResponseStatus5?), TypeInfoPropertyName = "NullableUpdateLiveCallResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StopCallResponseStatus?), TypeInfoPropertyName = "NullableStopCallResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StopCallResponseStatus2?), TypeInfoPropertyName = "NullableStopCallResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StopCallResponseStatus3?), TypeInfoPropertyName = "NullableStopCallResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StopCallResponseStatus4?), TypeInfoPropertyName = "NullableStopCallResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateContactResponseStatus?), TypeInfoPropertyName = "NullableCreateContactResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateContactResponseStatus2?), TypeInfoPropertyName = "NullableCreateContactResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateContactResponseStatus3?), TypeInfoPropertyName = "NullableCreateContactResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateContactResponseStatus4?), TypeInfoPropertyName = "NullableCreateContactResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactResponseStatus?), TypeInfoPropertyName = "NullableGetContactResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactResponseStatus2?), TypeInfoPropertyName = "NullableGetContactResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactResponseStatus3?), TypeInfoPropertyName = "NullableGetContactResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactResponseStatus4?), TypeInfoPropertyName = "NullableGetContactResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactByPhoneResponseStatus?), TypeInfoPropertyName = "NullableGetContactByPhoneResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactByPhoneResponseStatus2?), TypeInfoPropertyName = "NullableGetContactByPhoneResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactByPhoneResponseStatus3?), TypeInfoPropertyName = "NullableGetContactByPhoneResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactByPhoneResponseStatus4?), TypeInfoPropertyName = "NullableGetContactByPhoneResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactByPhoneResponseStatus5?), TypeInfoPropertyName = "NullableGetContactByPhoneResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateContactResponseStatus?), TypeInfoPropertyName = "NullableUpdateContactResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateContactResponseStatus2?), TypeInfoPropertyName = "NullableUpdateContactResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateContactResponseStatus3?), TypeInfoPropertyName = "NullableUpdateContactResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateContactResponseStatus4?), TypeInfoPropertyName = "NullableUpdateContactResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateContactResponseStatus5?), TypeInfoPropertyName = "NullableUpdateContactResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteContactResponseStatus?), TypeInfoPropertyName = "NullableDeleteContactResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteContactResponseStatus2?), TypeInfoPropertyName = "NullableDeleteContactResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteContactResponseStatus3?), TypeInfoPropertyName = "NullableDeleteContactResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteContactResponseStatus4?), TypeInfoPropertyName = "NullableDeleteContactResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteContactResponseStatus5?), TypeInfoPropertyName = "NullableDeleteContactResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactsResponseStatus?), TypeInfoPropertyName = "NullableListContactsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactsResponseStatus2?), TypeInfoPropertyName = "NullableListContactsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactsResponseStatus3?), TypeInfoPropertyName = "NullableListContactsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactsResponseStatus4?), TypeInfoPropertyName = "NullableListContactsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactConversationsResponseStatus?), TypeInfoPropertyName = "NullableListContactConversationsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactConversationsResponseStatus2?), TypeInfoPropertyName = "NullableListContactConversationsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactConversationsResponseStatus3?), TypeInfoPropertyName = "NullableListContactConversationsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactConversationsResponseStatus4?), TypeInfoPropertyName = "NullableListContactConversationsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAppResponseStatus?), TypeInfoPropertyName = "NullableCreateAppResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAppResponseStatus2?), TypeInfoPropertyName = "NullableCreateAppResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAppResponseStatus3?), TypeInfoPropertyName = "NullableCreateAppResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAppResponseStatus4?), TypeInfoPropertyName = "NullableCreateAppResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAppResponseStatus?), TypeInfoPropertyName = "NullableGetAppResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAppResponseStatus2?), TypeInfoPropertyName = "NullableGetAppResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAppResponseStatus3?), TypeInfoPropertyName = "NullableGetAppResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAppResponseStatus4?), TypeInfoPropertyName = "NullableGetAppResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAppResponseStatus?), TypeInfoPropertyName = "NullableUpdateAppResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAppResponseStatus2?), TypeInfoPropertyName = "NullableUpdateAppResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAppResponseStatus3?), TypeInfoPropertyName = "NullableUpdateAppResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAppResponseStatus4?), TypeInfoPropertyName = "NullableUpdateAppResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAppResponseStatus5?), TypeInfoPropertyName = "NullableUpdateAppResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAppResponseStatus?), TypeInfoPropertyName = "NullableDeleteAppResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAppResponseStatus2?), TypeInfoPropertyName = "NullableDeleteAppResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAppResponseStatus3?), TypeInfoPropertyName = "NullableDeleteAppResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAppResponseStatus4?), TypeInfoPropertyName = "NullableDeleteAppResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAppResponseStatus5?), TypeInfoPropertyName = "NullableDeleteAppResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppsResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListAppsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppsResponseStatus?), TypeInfoPropertyName = "NullableListAppsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppsResponseStatus2?), TypeInfoPropertyName = "NullableListAppsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppsResponseStatus3?), TypeInfoPropertyName = "NullableListAppsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppUsagesResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListAppUsagesResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppUsagesResponseStatus?), TypeInfoPropertyName = "NullableListAppUsagesResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppUsagesResponseStatus2?), TypeInfoPropertyName = "NullableListAppUsagesResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppUsagesResponseStatus3?), TypeInfoPropertyName = "NullableListAppUsagesResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppUsagesResponseStatus4?), TypeInfoPropertyName = "NullableListAppUsagesResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestAppAuthResponseStatus?), TypeInfoPropertyName = "NullableTestAppAuthResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestAppAuthResponseStatus2?), TypeInfoPropertyName = "NullableTestAppAuthResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestAppAuthResponseStatus3?), TypeInfoPropertyName = "NullableTestAppAuthResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestAppAuthResponseStatus4?), TypeInfoPropertyName = "NullableTestAppAuthResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmConfigResponseStatus?), TypeInfoPropertyName = "NullableGetCrmConfigResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmConfigResponseStatus2?), TypeInfoPropertyName = "NullableGetCrmConfigResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmConfigResponseStatus3?), TypeInfoPropertyName = "NullableGetCrmConfigResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCrmConfigResponseStatus?), TypeInfoPropertyName = "NullableUpdateCrmConfigResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCrmConfigResponseStatus2?), TypeInfoPropertyName = "NullableUpdateCrmConfigResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCrmConfigResponseStatus3?), TypeInfoPropertyName = "NullableUpdateCrmConfigResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCrmConfigResponseStatus4?), TypeInfoPropertyName = "NullableUpdateCrmConfigResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCrmConfigResponseStatus5?), TypeInfoPropertyName = "NullableUpdateCrmConfigResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RunSyncJobResponseStatus?), TypeInfoPropertyName = "NullableRunSyncJobResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RunSyncJobResponseStatus2?), TypeInfoPropertyName = "NullableRunSyncJobResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RunSyncJobResponseStatus3?), TypeInfoPropertyName = "NullableRunSyncJobResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RunSyncJobResponseStatus4?), TypeInfoPropertyName = "NullableRunSyncJobResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetSyncJobStatusResponseStatus?), TypeInfoPropertyName = "NullableGetSyncJobStatusResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetSyncJobStatusResponseStatus2?), TypeInfoPropertyName = "NullableGetSyncJobStatusResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetSyncJobStatusResponseStatus3?), TypeInfoPropertyName = "NullableGetSyncJobStatusResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus?), TypeInfoPropertyName = "NullableBackfillContactAnalysisDataResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus2?), TypeInfoPropertyName = "NullableBackfillContactAnalysisDataResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus3?), TypeInfoPropertyName = "NullableBackfillContactAnalysisDataResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus4?), TypeInfoPropertyName = "NullableBackfillContactAnalysisDataResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBackfillContactJobStatusResponseStatus?), TypeInfoPropertyName = "NullableGetBackfillContactJobStatusResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBackfillContactJobStatusResponseStatus2?), TypeInfoPropertyName = "NullableGetBackfillContactJobStatusResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBackfillContactJobStatusResponseStatus3?), TypeInfoPropertyName = "NullableGetBackfillContactJobStatusResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponseStatus?), TypeInfoPropertyName = "NullableGetCrmSchemaResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponseStatus2?), TypeInfoPropertyName = "NullableGetCrmSchemaResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponseStatus3?), TypeInfoPropertyName = "NullableGetCrmSchemaResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponseStatus4?), TypeInfoPropertyName = "NullableGetCrmSchemaResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponseStatus5?), TypeInfoPropertyName = "NullableGetCrmSchemaResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponseStatus6?), TypeInfoPropertyName = "NullableGetCrmSchemaResponseStatus62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AsrProviderModeRoutingSplitItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AgentFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.DisconnectionReason5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CustomFieldFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AlertFilterStatusCodeValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AlertFilterErrorCodeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.UtteranceNaturalnessIssues>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AgentRequestExpressiveEmotionTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.Language3?, global::System.Collections.Generic.List<global::RetellAI.Language3>, global::RetellAI.AgentRequestLanguage?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.Language3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AgentRequestWebhookEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AgentRequestPronunciationDictionaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.PostCallAnalysisData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.NodeEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.NodeFinetuneTransitionExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.Breakdown>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::RetellAI.Breakdown>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.MetricResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.TimeWindow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.DayOfWeek>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.Language3?, global::System.Collections.Generic.List<global::RetellAI.Language3>, global::RetellAI.ChatAgentRequestLanguage?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ChatAgentRequestWebhookEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.PostChatAnalysisData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.MessageOrToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ProductCost>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CohortAggregatedResultTopQuestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.NodeTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.Mcp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ConversationFlowNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.Note>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CreateConversationFlowComponentRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.NodeFinetuneConversationExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.SmsMultimediaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CallFilterCallStatusValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CallFilterCallTypeValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CallFilterDirectionValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CallFilterUserSentimentValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CallFilterDataStorageSettingValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ToolCallFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ChatFilterChatStatusValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ChatFilterUserSentimentValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.Equation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AnalysisData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.FinetuneExampleUtterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.GlobalNodeFinetuneTransitionExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.UtteranceHallucination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.Duration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.KnowledgeBaseAddSourcesRequestKnowledgeBaseText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.KnowledgeBaseRequestKnowledgeBaseText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.OneOf<global::RetellAI.KnowledgeBaseSourceDocument, global::RetellAI.KnowledgeBaseSourceText, global::RetellAI.KnowledgeBaseSourceUrl>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.UtteranceTranscriptionError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.UtteranceTranscriptionErrorMieDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.NodeTransitionAnalysisDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.OrganizationWebhookUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.PIIConfigCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.GuardrailConfigOutputTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.GuardrailConfigInputTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AgentWeight>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.RAGAccuracyMissedChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.RAGAccuracy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.State>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ScoringCriteriaCustomCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.PerformanceMetricCriteria>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.OneOf<global::RetellAI.SentimentAnalysisDetailVariant1, global::RetellAI.SentimentAnalysisDetailVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.StateEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ToolMock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.UtteranceToolCallAccuracy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.SpendBudgetCustomAlertRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.NaturalnessIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.UtteranceWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.Utterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.UtteranceOrToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.Contact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ContactConversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CRMSyncMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CRMCustomFieldSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CRMAnalysisDataMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.BatchCallTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ChatMessageInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.TestCaseDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.TestCaseBatchJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.TestCaseJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AgentVersionSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AgentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ChatAgentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.MCPToolDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.SearchCommunityVoiceResponseVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AgentListItemResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.V3ChatResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ConversationFlowComponentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ConversationFlowResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.KnowledgeBaseResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.PhoneNumberResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.RetellLLMResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.VoiceResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.V3CallResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ListExportRequestsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AppResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AppUsageResponse>))]
    internal sealed partial class SourceGenerationContextChunk5 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        /// 
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentVersionReferenceJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentSwapNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AnalysisDataJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PostCallAnalysisDataJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PostChatAnalysisDataJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.BranchNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.BridgeTransferNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CancelTransferNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PreviewCallQAJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ChatAgentResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V3ChatResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ComponentNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConversationFlowComponentResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConversationFlowNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConversationFlowResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConversationFlowJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConversationNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SubagentNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateConversationFlowComponentRequestJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateConversationFlowRequestJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateOrganizationRequestJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ValueFilterJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CustomFieldFilterJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.StoredCallFilterJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ElseEdgeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EndNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ExtractDynamicVariablesNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.FinetuneExampleUtteranceJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.FunctionNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CodeNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.MCPNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.MessageOrToolCallJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ChatMessageInputJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.MessageJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.InjectedMessageJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsMessageJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ModelChoiceJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NodeBaseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NodeInstructionJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NodeToolJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NodeTransitionMessageJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.OrganizationResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PressDigitNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ResponseEngineJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RetellResponseEngineJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RetellLLMResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RetellLlmRequestJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsSenderJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsDestinationJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SkipResponseEdgeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlwaysEdgeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsContentJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsFailedEdgeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsSuccessEdgeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.StateTransitionMessageJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TestCaseDefinitionJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ToolMockInputMatchRuleJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ToolCallInvocationMessageJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ToolCallResultMessageJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ToolJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferCallNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferDestinationJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferFailedEdgeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferOptionJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateSpendBudgetRequestJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UtteranceOrToolCallJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V2CallResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V3CallResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V3PhoneCallResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V3WebCallResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V2PhoneCallResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V2WebCallResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.VoicemailActionJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.IvrActionJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConductorOverageConfigJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ContactConversationJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AuthConfigRequestJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AppAuthConfigResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AppUsageResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ChartGroupItemJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, object>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterDisconnectionReason>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.StringFilter, object>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterStatusCode>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.Language3?, global::System.Collections.Generic.IList<global::RetellAI.Language3>, global::RetellAI.AgentRequestLanguage?>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.StringFilter, global::RetellAI.AgentListFilterChannel>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.Language3?, global::System.Collections.Generic.IList<global::RetellAI.Language3>, global::RetellAI.ChatAgentRequestLanguage?>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.AllOf<global::RetellAI.NumberFilter, global::RetellAI.CohortFilterStartTimestampVariant1>?, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.CohortFilterStartTimestampVariant1>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.CohortFilterDisconnectionReason>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, object>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, object>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.StringFilter, global::RetellAI.EnumFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.CallFilterCallStatus>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDisconnectionReason>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.CallFilterCallType>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDirection>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.CallFilterUserSentiment>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDataStorageSetting>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, object>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterChatStatus>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterDisconnectionReason>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterUserSentiment>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.StringFilter, global::RetellAI.PresentFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.KnowledgeBaseSourceDocument, global::RetellAI.KnowledgeBaseSourceText, global::RetellAI.KnowledgeBaseSourceUrl>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.PerformanceMetricCriteria, global::RetellAI.CustomMetricCriteria>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<double?, bool?, string>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.PromptCondition, global::RetellAI.EquationCondition>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.CustomTool, global::RetellAI.CheckAvailabilityCalTool, global::RetellAI.BookAppointmentCalTool>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.StringFilter, global::RetellAI.EnumFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.QaViewFilterDisconnectionReason>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, object>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<bool?, global::RetellAI.BooleanFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<bool?, global::RetellAI.BooleanFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.SentimentAnalysisDetailVariant1, global::RetellAI.SentimentAnalysisDetailVariant2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NodeInstruction?, global::RetellAI.SmsInstructionTemplate>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.WarmTransferPrompt, global::RetellAI.WarmTransferStaticMessage>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.WarmTransferPrompt, global::RetellAI.WarmTransferStaticMessage>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.WarmTransferPrompt, global::RetellAI.WarmTransferStaticMessage>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.AgentRequest, object>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.TestCaseDefinitionInput, object>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.ChatAgentRequest, object>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListTestCaseDefinitionsResponse2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListBatchTestsResponse2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListTestRunsResponse2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAgentVersionsResponse2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAgentsResponse2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListChatsResponse2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowComponentsResponse2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowsResponse2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListPhoneNumbersResponse2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListRetellLLMResponse2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.AgentResponse?, global::RetellAI.ChatAgentResponse?>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListCallsResponse2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListExportRequestsResponse2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppsResponse2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppUsagesResponse2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.UnixTimestampJsonConverter());

            options.Converters.Add(new LazyEnumJsonConverterFactory());

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::RetellAI.AlertMetricType)

                    || typeToConvert == typeof(global::RetellAI.AlertMetricType?)

                    || typeToConvert == typeof(global::RetellAI.AsrProvider)

                    || typeToConvert == typeof(global::RetellAI.AsrProvider?)

                    || typeToConvert == typeof(global::RetellAI.AlertFilterStatusCodeValueItem)

                    || typeToConvert == typeof(global::RetellAI.AlertFilterStatusCodeValueItem?)

                    || typeToConvert == typeof(global::RetellAI.AlertFilterErrorCodeItem)

                    || typeToConvert == typeof(global::RetellAI.AlertFilterErrorCodeItem?)

                    || typeToConvert == typeof(global::RetellAI.AlertIncidentResponseThresholdType)

                    || typeToConvert == typeof(global::RetellAI.AlertIncidentResponseThresholdType?)

                    || typeToConvert == typeof(global::RetellAI.AlertIncidentResponseComparator)

                    || typeToConvert == typeof(global::RetellAI.AlertIncidentResponseComparator?)

                    || typeToConvert == typeof(global::RetellAI.AlertIncidentResponseFrequency)

                    || typeToConvert == typeof(global::RetellAI.AlertIncidentResponseFrequency?)

                    || typeToConvert == typeof(global::RetellAI.AlertIncidentResponseWindow)

                    || typeToConvert == typeof(global::RetellAI.AlertIncidentResponseWindow?)

                    || typeToConvert == typeof(global::RetellAI.AlertRuleRequestThresholdType)

                    || typeToConvert == typeof(global::RetellAI.AlertRuleRequestThresholdType?)

                    || typeToConvert == typeof(global::RetellAI.AlertRuleRequestComparator)

                    || typeToConvert == typeof(global::RetellAI.AlertRuleRequestComparator?)

                    || typeToConvert == typeof(global::RetellAI.AlertRuleRequestFrequency)

                    || typeToConvert == typeof(global::RetellAI.AlertRuleRequestFrequency?)

                    || typeToConvert == typeof(global::RetellAI.AlertRuleRequestWindow)

                    || typeToConvert == typeof(global::RetellAI.AlertRuleRequestWindow?)

                    || typeToConvert == typeof(global::RetellAI.AlertRuleResponseThresholdType)

                    || typeToConvert == typeof(global::RetellAI.AlertRuleResponseThresholdType?)

                    || typeToConvert == typeof(global::RetellAI.AlertRuleResponseComparator)

                    || typeToConvert == typeof(global::RetellAI.AlertRuleResponseComparator?)

                    || typeToConvert == typeof(global::RetellAI.AlertRuleResponseFrequency)

                    || typeToConvert == typeof(global::RetellAI.AlertRuleResponseFrequency?)

                    || typeToConvert == typeof(global::RetellAI.AlertRuleResponseWindow)

                    || typeToConvert == typeof(global::RetellAI.AlertRuleResponseWindow?)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestVoiceModel)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestVoiceModel?)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestVoiceEmotion)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestVoiceEmotion?)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestExpressiveEmotionTag)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestExpressiveEmotionTag?)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestAmbientSound)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestAmbientSound?)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestLanguage)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestLanguage?)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestWebhookEvent)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestWebhookEvent?)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestDataStorageSetting)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestDataStorageSetting?)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestPronunciationDictionaryItemAlphabet)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestPronunciationDictionaryItemAlphabet?)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestSttMode)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestSttMode?)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestVocabSpecialization)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestVocabSpecialization?)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestDenoisingMode)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestDenoisingMode?)

                    || typeToConvert == typeof(global::RetellAI.AgentListFilterChannelOp)

                    || typeToConvert == typeof(global::RetellAI.AgentListFilterChannelOp?)

                    || typeToConvert == typeof(global::RetellAI.AgentListFilterChannelValue)

                    || typeToConvert == typeof(global::RetellAI.AgentListFilterChannelValue?)

                    || typeToConvert == typeof(global::RetellAI.AgentListItemResponseChannel)

                    || typeToConvert == typeof(global::RetellAI.AgentListItemResponseChannel?)

                    || typeToConvert == typeof(global::RetellAI.AgentSwapNodeVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.AgentSwapNodeVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.AgentSwapToolType)

                    || typeToConvert == typeof(global::RetellAI.AgentSwapToolType?)

                    || typeToConvert == typeof(global::RetellAI.AgentSwapToolExecutionMessageType)

                    || typeToConvert == typeof(global::RetellAI.AgentSwapToolExecutionMessageType?)

                    || typeToConvert == typeof(global::RetellAI.AgentSwapWebhookSetting)

                    || typeToConvert == typeof(global::RetellAI.AgentSwapWebhookSetting?)

                    || typeToConvert == typeof(global::RetellAI.BookAppointmentCalToolType)

                    || typeToConvert == typeof(global::RetellAI.BookAppointmentCalToolType?)

                    || typeToConvert == typeof(global::RetellAI.BooleanAnalysisDataType)

                    || typeToConvert == typeof(global::RetellAI.BooleanAnalysisDataType?)

                    || typeToConvert == typeof(global::RetellAI.BranchNodeVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.BranchNodeVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.BridgeTransferNodeVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.BridgeTransferNodeVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.BridgeTransferToolType)

                    || typeToConvert == typeof(global::RetellAI.BridgeTransferToolType?)

                    || typeToConvert == typeof(global::RetellAI.BridgeTransferToolExecutionMessageType)

                    || typeToConvert == typeof(global::RetellAI.BridgeTransferToolExecutionMessageType?)

                    || typeToConvert == typeof(global::RetellAI.CallAnalysisUserSentiment)

                    || typeToConvert == typeof(global::RetellAI.CallAnalysisUserSentiment?)

                    || typeToConvert == typeof(global::RetellAI.CancelTransferNodeVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.CancelTransferNodeVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.CancelTransferToolType)

                    || typeToConvert == typeof(global::RetellAI.CancelTransferToolType?)

                    || typeToConvert == typeof(global::RetellAI.CancelTransferToolExecutionMessageType)

                    || typeToConvert == typeof(global::RetellAI.CancelTransferToolExecutionMessageType?)

                    || typeToConvert == typeof(global::RetellAI.ChatAgentRequestLanguage)

                    || typeToConvert == typeof(global::RetellAI.ChatAgentRequestLanguage?)

                    || typeToConvert == typeof(global::RetellAI.ChatAgentRequestWebhookEvent)

                    || typeToConvert == typeof(global::RetellAI.ChatAgentRequestWebhookEvent?)

                    || typeToConvert == typeof(global::RetellAI.ChatAgentRequestDataStorageSetting)

                    || typeToConvert == typeof(global::RetellAI.ChatAgentRequestDataStorageSetting?)

                    || typeToConvert == typeof(global::RetellAI.ChatAnalysisUserSentiment)

                    || typeToConvert == typeof(global::RetellAI.ChatAnalysisUserSentiment?)

                    || typeToConvert == typeof(global::RetellAI.ChatResponseChatStatus)

                    || typeToConvert == typeof(global::RetellAI.ChatResponseChatStatus?)

                    || typeToConvert == typeof(global::RetellAI.ChatResponseChatType)

                    || typeToConvert == typeof(global::RetellAI.ChatResponseChatType?)

                    || typeToConvert == typeof(global::RetellAI.V3ListChatsRequestSortOrder)

                    || typeToConvert == typeof(global::RetellAI.V3ListChatsRequestSortOrder?)

                    || typeToConvert == typeof(global::RetellAI.CheckAvailabilityCalToolType)

                    || typeToConvert == typeof(global::RetellAI.CheckAvailabilityCalToolType?)

                    || typeToConvert == typeof(global::RetellAI.CohortAggregatedResultGroupBy)

                    || typeToConvert == typeof(global::RetellAI.CohortAggregatedResultGroupBy?)

                    || typeToConvert == typeof(global::RetellAI.CohortFilterStartTimestampVariant1Op)

                    || typeToConvert == typeof(global::RetellAI.CohortFilterStartTimestampVariant1Op?)

                    || typeToConvert == typeof(global::RetellAI.CohortFilterCallDurationFilterOp)

                    || typeToConvert == typeof(global::RetellAI.CohortFilterCallDurationFilterOp?)

                    || typeToConvert == typeof(global::RetellAI.CohortSuccessfulCriteriaType)

                    || typeToConvert == typeof(global::RetellAI.CohortSuccessfulCriteriaType?)

                    || typeToConvert == typeof(global::RetellAI.CohortSuccessfulCriteriaOp)

                    || typeToConvert == typeof(global::RetellAI.CohortSuccessfulCriteriaOp?)

                    || typeToConvert == typeof(global::RetellAI.CohortEvaluationMode)

                    || typeToConvert == typeof(global::RetellAI.CohortEvaluationMode?)

                    || typeToConvert == typeof(global::RetellAI.ComponentNodeVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.ComponentNodeVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.ComponentNodeVariant2ComponentType)

                    || typeToConvert == typeof(global::RetellAI.ComponentNodeVariant2ComponentType?)

                    || typeToConvert == typeof(global::RetellAI.ConversationFlowOverrideStartSpeaker)

                    || typeToConvert == typeof(global::RetellAI.ConversationFlowOverrideStartSpeaker?)

                    || typeToConvert == typeof(global::RetellAI.ConversationNodeVariant3Type)

                    || typeToConvert == typeof(global::RetellAI.ConversationNodeVariant3Type?)

                    || typeToConvert == typeof(global::RetellAI.SubagentNodeVariant3Type)

                    || typeToConvert == typeof(global::RetellAI.SubagentNodeVariant3Type?)

                    || typeToConvert == typeof(global::RetellAI.CustomToolType)

                    || typeToConvert == typeof(global::RetellAI.CustomToolType?)

                    || typeToConvert == typeof(global::RetellAI.CustomToolMethod)

                    || typeToConvert == typeof(global::RetellAI.CustomToolMethod?)

                    || typeToConvert == typeof(global::RetellAI.CustomToolExecutionMessageType)

                    || typeToConvert == typeof(global::RetellAI.CustomToolExecutionMessageType?)

                    || typeToConvert == typeof(global::RetellAI.CustomToolParameterType)

                    || typeToConvert == typeof(global::RetellAI.CustomToolParameterType?)

                    || typeToConvert == typeof(global::RetellAI.CodeToolType)

                    || typeToConvert == typeof(global::RetellAI.CodeToolType?)

                    || typeToConvert == typeof(global::RetellAI.CodeToolExecutionMessageType)

                    || typeToConvert == typeof(global::RetellAI.CodeToolExecutionMessageType?)

                    || typeToConvert == typeof(global::RetellAI.DTMFUtteranceRole)

                    || typeToConvert == typeof(global::RetellAI.DTMFUtteranceRole?)

                    || typeToConvert == typeof(global::RetellAI.SmsUtteranceRole)

                    || typeToConvert == typeof(global::RetellAI.SmsUtteranceRole?)

                    || typeToConvert == typeof(global::RetellAI.InjectedUtteranceRole)

                    || typeToConvert == typeof(global::RetellAI.InjectedUtteranceRole?)

                    || typeToConvert == typeof(global::RetellAI.StringFilterType)

                    || typeToConvert == typeof(global::RetellAI.StringFilterType?)

                    || typeToConvert == typeof(global::RetellAI.StringFilterOp)

                    || typeToConvert == typeof(global::RetellAI.StringFilterOp?)

                    || typeToConvert == typeof(global::RetellAI.NumberFilterType)

                    || typeToConvert == typeof(global::RetellAI.NumberFilterType?)

                    || typeToConvert == typeof(global::RetellAI.NumberFilterOp)

                    || typeToConvert == typeof(global::RetellAI.NumberFilterOp?)

                    || typeToConvert == typeof(global::RetellAI.BooleanFilterType)

                    || typeToConvert == typeof(global::RetellAI.BooleanFilterType?)

                    || typeToConvert == typeof(global::RetellAI.BooleanFilterOp)

                    || typeToConvert == typeof(global::RetellAI.BooleanFilterOp?)

                    || typeToConvert == typeof(global::RetellAI.RangeFilterType)

                    || typeToConvert == typeof(global::RetellAI.RangeFilterType?)

                    || typeToConvert == typeof(global::RetellAI.RangeFilterOp)

                    || typeToConvert == typeof(global::RetellAI.RangeFilterOp?)

                    || typeToConvert == typeof(global::RetellAI.EnumFilterType)

                    || typeToConvert == typeof(global::RetellAI.EnumFilterType?)

                    || typeToConvert == typeof(global::RetellAI.EnumFilterOp)

                    || typeToConvert == typeof(global::RetellAI.EnumFilterOp?)

                    || typeToConvert == typeof(global::RetellAI.PresentFilterType)

                    || typeToConvert == typeof(global::RetellAI.PresentFilterType?)

                    || typeToConvert == typeof(global::RetellAI.PresentFilterOp)

                    || typeToConvert == typeof(global::RetellAI.PresentFilterOp?)

                    || typeToConvert == typeof(global::RetellAI.CallFilterCallStatusValueItem)

                    || typeToConvert == typeof(global::RetellAI.CallFilterCallStatusValueItem?)

                    || typeToConvert == typeof(global::RetellAI.CallFilterCallTypeValueItem)

                    || typeToConvert == typeof(global::RetellAI.CallFilterCallTypeValueItem?)

                    || typeToConvert == typeof(global::RetellAI.CallFilterDirectionValueItem)

                    || typeToConvert == typeof(global::RetellAI.CallFilterDirectionValueItem?)

                    || typeToConvert == typeof(global::RetellAI.CallFilterUserSentimentValueItem)

                    || typeToConvert == typeof(global::RetellAI.CallFilterUserSentimentValueItem?)

                    || typeToConvert == typeof(global::RetellAI.CallFilterDataStorageSettingValueItem)

                    || typeToConvert == typeof(global::RetellAI.CallFilterDataStorageSettingValueItem?)

                    || typeToConvert == typeof(global::RetellAI.ChatFilterChatStatusValueItem)

                    || typeToConvert == typeof(global::RetellAI.ChatFilterChatStatusValueItem?)

                    || typeToConvert == typeof(global::RetellAI.ChatFilterUserSentimentValueItem)

                    || typeToConvert == typeof(global::RetellAI.ChatFilterUserSentimentValueItem?)

                    || typeToConvert == typeof(global::RetellAI.ListContactsRequestSortOrder)

                    || typeToConvert == typeof(global::RetellAI.ListContactsRequestSortOrder?)

                    || typeToConvert == typeof(global::RetellAI.DayOfWeek)

                    || typeToConvert == typeof(global::RetellAI.DayOfWeek?)

                    || typeToConvert == typeof(global::RetellAI.DisconnectionReason5)

                    || typeToConvert == typeof(global::RetellAI.DisconnectionReason5?)

                    || typeToConvert == typeof(global::RetellAI.ElseEdgeVariant2TransitionConditionType)

                    || typeToConvert == typeof(global::RetellAI.ElseEdgeVariant2TransitionConditionType?)

                    || typeToConvert == typeof(global::RetellAI.ElseEdgeVariant2TransitionConditionPrompt)

                    || typeToConvert == typeof(global::RetellAI.ElseEdgeVariant2TransitionConditionPrompt?)

                    || typeToConvert == typeof(global::RetellAI.EndCallToolType)

                    || typeToConvert == typeof(global::RetellAI.EndCallToolType?)

                    || typeToConvert == typeof(global::RetellAI.EndCallToolExecutionMessageType)

                    || typeToConvert == typeof(global::RetellAI.EndCallToolExecutionMessageType?)

                    || typeToConvert == typeof(global::RetellAI.EndNodeVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.EndNodeVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.EnumAnalysisDataType)

                    || typeToConvert == typeof(global::RetellAI.EnumAnalysisDataType?)

                    || typeToConvert == typeof(global::RetellAI.EquationConditionType)

                    || typeToConvert == typeof(global::RetellAI.EquationConditionType?)

                    || typeToConvert == typeof(global::RetellAI.EquationConditionOperator)

                    || typeToConvert == typeof(global::RetellAI.EquationConditionOperator?)

                    || typeToConvert == typeof(global::RetellAI.EquationOperator)

                    || typeToConvert == typeof(global::RetellAI.EquationOperator?)

                    || typeToConvert == typeof(global::RetellAI.ExtractDynamicVariableToolType)

                    || typeToConvert == typeof(global::RetellAI.ExtractDynamicVariableToolType?)

                    || typeToConvert == typeof(global::RetellAI.ExtractDynamicVariablesNodeVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.ExtractDynamicVariablesNodeVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.FinetuneExampleUtteranceVariant1Role)

                    || typeToConvert == typeof(global::RetellAI.FinetuneExampleUtteranceVariant1Role?)

                    || typeToConvert == typeof(global::RetellAI.FinetuneExampleUtteranceVariant2Role)

                    || typeToConvert == typeof(global::RetellAI.FinetuneExampleUtteranceVariant2Role?)

                    || typeToConvert == typeof(global::RetellAI.FinetuneExampleUtteranceVariant3Role)

                    || typeToConvert == typeof(global::RetellAI.FinetuneExampleUtteranceVariant3Role?)

                    || typeToConvert == typeof(global::RetellAI.FunctionNodeVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.FunctionNodeVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.FunctionNodeVariant2ToolType)

                    || typeToConvert == typeof(global::RetellAI.FunctionNodeVariant2ToolType?)

                    || typeToConvert == typeof(global::RetellAI.CodeNodeVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.CodeNodeVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.KnowledgeBaseResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.KnowledgeBaseResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.KnowledgeBaseSourceDocumentType)

                    || typeToConvert == typeof(global::RetellAI.KnowledgeBaseSourceDocumentType?)

                    || typeToConvert == typeof(global::RetellAI.KnowledgeBaseSourceTextType)

                    || typeToConvert == typeof(global::RetellAI.KnowledgeBaseSourceTextType?)

                    || typeToConvert == typeof(global::RetellAI.KnowledgeBaseSourceUrlType)

                    || typeToConvert == typeof(global::RetellAI.KnowledgeBaseSourceUrlType?)

                    || typeToConvert == typeof(global::RetellAI.Language3)

                    || typeToConvert == typeof(global::RetellAI.Language3?)

                    || typeToConvert == typeof(global::RetellAI.LLMModel)

                    || typeToConvert == typeof(global::RetellAI.LLMModel?)

                    || typeToConvert == typeof(global::RetellAI.MCPNodeVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.MCPNodeVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.MCPToolType)

                    || typeToConvert == typeof(global::RetellAI.MCPToolType?)

                    || typeToConvert == typeof(global::RetellAI.MCPToolExecutionMessageType)

                    || typeToConvert == typeof(global::RetellAI.MCPToolExecutionMessageType?)

                    || typeToConvert == typeof(global::RetellAI.MessageBaseRole)

                    || typeToConvert == typeof(global::RetellAI.MessageBaseRole?)

                    || typeToConvert == typeof(global::RetellAI.InjectedMessageBaseRole)

                    || typeToConvert == typeof(global::RetellAI.InjectedMessageBaseRole?)

                    || typeToConvert == typeof(global::RetellAI.SmsMessageBaseRole)

                    || typeToConvert == typeof(global::RetellAI.SmsMessageBaseRole?)

                    || typeToConvert == typeof(global::RetellAI.ModelChoiceCascadingType)

                    || typeToConvert == typeof(global::RetellAI.ModelChoiceCascadingType?)

                    || typeToConvert == typeof(global::RetellAI.NaturalnessIssue)

                    || typeToConvert == typeof(global::RetellAI.NaturalnessIssue?)

                    || typeToConvert == typeof(global::RetellAI.NodeInstructionPromptType)

                    || typeToConvert == typeof(global::RetellAI.NodeInstructionPromptType?)

                    || typeToConvert == typeof(global::RetellAI.NodeInstructionStaticTextType)

                    || typeToConvert == typeof(global::RetellAI.NodeInstructionStaticTextType?)

                    || typeToConvert == typeof(global::RetellAI.SmsInstructionTemplateType)

                    || typeToConvert == typeof(global::RetellAI.SmsInstructionTemplateType?)

                    || typeToConvert == typeof(global::RetellAI.SmsInstructionTemplateTemplate)

                    || typeToConvert == typeof(global::RetellAI.SmsInstructionTemplateTemplate?)

                    || typeToConvert == typeof(global::RetellAI.NodeTransitionMessageBaseRole)

                    || typeToConvert == typeof(global::RetellAI.NodeTransitionMessageBaseRole?)

                    || typeToConvert == typeof(global::RetellAI.NodeTransitionMessageBaseTransitionType)

                    || typeToConvert == typeof(global::RetellAI.NodeTransitionMessageBaseTransitionType?)

                    || typeToConvert == typeof(global::RetellAI.NodeTransitionUtteranceRole)

                    || typeToConvert == typeof(global::RetellAI.NodeTransitionUtteranceRole?)

                    || typeToConvert == typeof(global::RetellAI.NodeTransitionUtteranceTransitionType)

                    || typeToConvert == typeof(global::RetellAI.NodeTransitionUtteranceTransitionType?)

                    || typeToConvert == typeof(global::RetellAI.NullableLLMModel)

                    || typeToConvert == typeof(global::RetellAI.NullableLLMModel?)

                    || typeToConvert == typeof(global::RetellAI.NumberAnalysisDataType)

                    || typeToConvert == typeof(global::RetellAI.NumberAnalysisDataType?)

                    || typeToConvert == typeof(global::RetellAI.PresetAnalysisDataType)

                    || typeToConvert == typeof(global::RetellAI.PresetAnalysisDataType?)

                    || typeToConvert == typeof(global::RetellAI.PresetAnalysisDataName)

                    || typeToConvert == typeof(global::RetellAI.PresetAnalysisDataName?)

                    || typeToConvert == typeof(global::RetellAI.CallPresetAnalysisDataType)

                    || typeToConvert == typeof(global::RetellAI.CallPresetAnalysisDataType?)

                    || typeToConvert == typeof(global::RetellAI.CallPresetAnalysisDataName)

                    || typeToConvert == typeof(global::RetellAI.CallPresetAnalysisDataName?)

                    || typeToConvert == typeof(global::RetellAI.ChatPresetAnalysisDataType)

                    || typeToConvert == typeof(global::RetellAI.ChatPresetAnalysisDataType?)

                    || typeToConvert == typeof(global::RetellAI.ChatPresetAnalysisDataName)

                    || typeToConvert == typeof(global::RetellAI.ChatPresetAnalysisDataName?)

                    || typeToConvert == typeof(global::RetellAI.OrganizationResponseVariant2EnterprisePlanStatus)

                    || typeToConvert == typeof(global::RetellAI.OrganizationResponseVariant2EnterprisePlanStatus?)

                    || typeToConvert == typeof(global::RetellAI.PIIConfigMode)

                    || typeToConvert == typeof(global::RetellAI.PIIConfigMode?)

                    || typeToConvert == typeof(global::RetellAI.PIIConfigCategorie)

                    || typeToConvert == typeof(global::RetellAI.PIIConfigCategorie?)

                    || typeToConvert == typeof(global::RetellAI.GuardrailConfigOutputTopic)

                    || typeToConvert == typeof(global::RetellAI.GuardrailConfigOutputTopic?)

                    || typeToConvert == typeof(global::RetellAI.GuardrailConfigInputTopic)

                    || typeToConvert == typeof(global::RetellAI.GuardrailConfigInputTopic?)

                    || typeToConvert == typeof(global::RetellAI.PerformanceMetricCriteriaOp)

                    || typeToConvert == typeof(global::RetellAI.PerformanceMetricCriteriaOp?)

                    || typeToConvert == typeof(global::RetellAI.PhoneNumberResponsePhoneNumberType)

                    || typeToConvert == typeof(global::RetellAI.PhoneNumberResponsePhoneNumberType?)

                    || typeToConvert == typeof(global::RetellAI.PostCallAnalysisSetting)

                    || typeToConvert == typeof(global::RetellAI.PostCallAnalysisSetting?)

                    || typeToConvert == typeof(global::RetellAI.PressDigitNodeVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.PressDigitNodeVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.PressDigitToolType)

                    || typeToConvert == typeof(global::RetellAI.PressDigitToolType?)

                    || typeToConvert == typeof(global::RetellAI.PromptConditionType)

                    || typeToConvert == typeof(global::RetellAI.PromptConditionType?)

                    || typeToConvert == typeof(global::RetellAI.QaViewFilterScoreRangeType)

                    || typeToConvert == typeof(global::RetellAI.QaViewFilterScoreRangeType?)

                    || typeToConvert == typeof(global::RetellAI.QaViewFilterScoreRangeOp)

                    || typeToConvert == typeof(global::RetellAI.QaViewFilterScoreRangeOp?)

                    || typeToConvert == typeof(global::RetellAI.CohortQaListArgsSortKey)

                    || typeToConvert == typeof(global::RetellAI.CohortQaListArgsSortKey?)

                    || typeToConvert == typeof(global::RetellAI.CohortQaListArgsOrder)

                    || typeToConvert == typeof(global::RetellAI.CohortQaListArgsOrder?)

                    || typeToConvert == typeof(global::RetellAI.ResponseEngineConversationFlowType)

                    || typeToConvert == typeof(global::RetellAI.ResponseEngineConversationFlowType?)

                    || typeToConvert == typeof(global::RetellAI.ResponseEngineCustomLmType)

                    || typeToConvert == typeof(global::RetellAI.ResponseEngineCustomLmType?)

                    || typeToConvert == typeof(global::RetellAI.ResponseEngineRetellLmType)

                    || typeToConvert == typeof(global::RetellAI.ResponseEngineRetellLmType?)

                    || typeToConvert == typeof(global::RetellAI.RetellLlmOverrideS2sModel)

                    || typeToConvert == typeof(global::RetellAI.RetellLlmOverrideS2sModel?)

                    || typeToConvert == typeof(global::RetellAI.RetellLlmOverrideStartSpeaker)

                    || typeToConvert == typeof(global::RetellAI.RetellLlmOverrideStartSpeaker?)

                    || typeToConvert == typeof(global::RetellAI.SendSMSToolType)

                    || typeToConvert == typeof(global::RetellAI.SendSMSToolType?)

                    || typeToConvert == typeof(global::RetellAI.SendSMSToolExecutionMessageType)

                    || typeToConvert == typeof(global::RetellAI.SendSMSToolExecutionMessageType?)

                    || typeToConvert == typeof(global::RetellAI.SmsSenderVariant1Type)

                    || typeToConvert == typeof(global::RetellAI.SmsSenderVariant1Type?)

                    || typeToConvert == typeof(global::RetellAI.SmsSenderVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.SmsSenderVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.SmsDestinationVariant1Type)

                    || typeToConvert == typeof(global::RetellAI.SmsDestinationVariant1Type?)

                    || typeToConvert == typeof(global::RetellAI.SmsDestinationVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.SmsDestinationVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.SentimentAnalysisDetailVariant1Sentiment)

                    || typeToConvert == typeof(global::RetellAI.SentimentAnalysisDetailVariant1Sentiment?)

                    || typeToConvert == typeof(global::RetellAI.SentimentAnalysisDetailVariant2Sentiment)

                    || typeToConvert == typeof(global::RetellAI.SentimentAnalysisDetailVariant2Sentiment?)

                    || typeToConvert == typeof(global::RetellAI.SkipResponseEdgeVariant2TransitionConditionType)

                    || typeToConvert == typeof(global::RetellAI.SkipResponseEdgeVariant2TransitionConditionType?)

                    || typeToConvert == typeof(global::RetellAI.SkipResponseEdgeVariant2TransitionConditionPrompt)

                    || typeToConvert == typeof(global::RetellAI.SkipResponseEdgeVariant2TransitionConditionPrompt?)

                    || typeToConvert == typeof(global::RetellAI.AlwaysEdgeVariant2TransitionConditionType)

                    || typeToConvert == typeof(global::RetellAI.AlwaysEdgeVariant2TransitionConditionType?)

                    || typeToConvert == typeof(global::RetellAI.AlwaysEdgeVariant2TransitionConditionPrompt)

                    || typeToConvert == typeof(global::RetellAI.AlwaysEdgeVariant2TransitionConditionPrompt?)

                    || typeToConvert == typeof(global::RetellAI.SmsContentInferredType)

                    || typeToConvert == typeof(global::RetellAI.SmsContentInferredType?)

                    || typeToConvert == typeof(global::RetellAI.SmsContentPredefinedType)

                    || typeToConvert == typeof(global::RetellAI.SmsContentPredefinedType?)

                    || typeToConvert == typeof(global::RetellAI.SmsContentTemplateType)

                    || typeToConvert == typeof(global::RetellAI.SmsContentTemplateType?)

                    || typeToConvert == typeof(global::RetellAI.SmsContentTemplateTemplate)

                    || typeToConvert == typeof(global::RetellAI.SmsContentTemplateTemplate?)

                    || typeToConvert == typeof(global::RetellAI.SmsFailedEdgeVariant2TransitionConditionType)

                    || typeToConvert == typeof(global::RetellAI.SmsFailedEdgeVariant2TransitionConditionType?)

                    || typeToConvert == typeof(global::RetellAI.SmsFailedEdgeVariant2TransitionConditionPrompt)

                    || typeToConvert == typeof(global::RetellAI.SmsFailedEdgeVariant2TransitionConditionPrompt?)

                    || typeToConvert == typeof(global::RetellAI.SmsNodeVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.SmsNodeVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionType)

                    || typeToConvert == typeof(global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionType?)

                    || typeToConvert == typeof(global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionPrompt)

                    || typeToConvert == typeof(global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionPrompt?)

                    || typeToConvert == typeof(global::RetellAI.StateTransitionMessageBaseRole)

                    || typeToConvert == typeof(global::RetellAI.StateTransitionMessageBaseRole?)

                    || typeToConvert == typeof(global::RetellAI.StringAnalysisDataType)

                    || typeToConvert == typeof(global::RetellAI.StringAnalysisDataType?)

                    || typeToConvert == typeof(global::RetellAI.TestCaseBatchJobStatus)

                    || typeToConvert == typeof(global::RetellAI.TestCaseBatchJobStatus?)

                    || typeToConvert == typeof(global::RetellAI.TestCaseDefinitionVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.TestCaseDefinitionVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.TestCaseJobStatus)

                    || typeToConvert == typeof(global::RetellAI.TestCaseJobStatus?)

                    || typeToConvert == typeof(global::RetellAI.ToolMockInputMatchRuleVariant1Type)

                    || typeToConvert == typeof(global::RetellAI.ToolMockInputMatchRuleVariant1Type?)

                    || typeToConvert == typeof(global::RetellAI.ToolMockInputMatchRuleVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.ToolMockInputMatchRuleVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.ToolCallInvocationMessageBaseRole)

                    || typeToConvert == typeof(global::RetellAI.ToolCallInvocationMessageBaseRole?)

                    || typeToConvert == typeof(global::RetellAI.ToolCallInvocationUtteranceRole)

                    || typeToConvert == typeof(global::RetellAI.ToolCallInvocationUtteranceRole?)

                    || typeToConvert == typeof(global::RetellAI.ToolCallResultMessageBaseRole)

                    || typeToConvert == typeof(global::RetellAI.ToolCallResultMessageBaseRole?)

                    || typeToConvert == typeof(global::RetellAI.ToolCallResultUtteranceRole)

                    || typeToConvert == typeof(global::RetellAI.ToolCallResultUtteranceRole?)

                    || typeToConvert == typeof(global::RetellAI.ToolParameterType)

                    || typeToConvert == typeof(global::RetellAI.ToolParameterType?)

                    || typeToConvert == typeof(global::RetellAI.TransferCallNodeVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.TransferCallNodeVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.TransferCallToolType)

                    || typeToConvert == typeof(global::RetellAI.TransferCallToolType?)

                    || typeToConvert == typeof(global::RetellAI.TransferCallToolExecutionMessageType)

                    || typeToConvert == typeof(global::RetellAI.TransferCallToolExecutionMessageType?)

                    || typeToConvert == typeof(global::RetellAI.TransferDestinationInferredType)

                    || typeToConvert == typeof(global::RetellAI.TransferDestinationInferredType?)

                    || typeToConvert == typeof(global::RetellAI.TransferDestinationPredefinedType)

                    || typeToConvert == typeof(global::RetellAI.TransferDestinationPredefinedType?)

                    || typeToConvert == typeof(global::RetellAI.TransferFailedEdgeVariant2TransitionConditionType)

                    || typeToConvert == typeof(global::RetellAI.TransferFailedEdgeVariant2TransitionConditionType?)

                    || typeToConvert == typeof(global::RetellAI.TransferFailedEdgeVariant2TransitionConditionPrompt)

                    || typeToConvert == typeof(global::RetellAI.TransferFailedEdgeVariant2TransitionConditionPrompt?)

                    || typeToConvert == typeof(global::RetellAI.TransferOptionAgenticWarmTransferType)

                    || typeToConvert == typeof(global::RetellAI.TransferOptionAgenticWarmTransferType?)

                    || typeToConvert == typeof(global::RetellAI.TransferOptionAgenticWarmTransferOnHoldMusic)

                    || typeToConvert == typeof(global::RetellAI.TransferOptionAgenticWarmTransferOnHoldMusic?)

                    || typeToConvert == typeof(global::RetellAI.TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeout)

                    || typeToConvert == typeof(global::RetellAI.TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeout?)

                    || typeToConvert == typeof(global::RetellAI.TransferOptionColdTransferType)

                    || typeToConvert == typeof(global::RetellAI.TransferOptionColdTransferType?)

                    || typeToConvert == typeof(global::RetellAI.TransferOptionColdTransferColdTransferMode)

                    || typeToConvert == typeof(global::RetellAI.TransferOptionColdTransferColdTransferMode?)

                    || typeToConvert == typeof(global::RetellAI.TransferOptionWarmTransferType)

                    || typeToConvert == typeof(global::RetellAI.TransferOptionWarmTransferType?)

                    || typeToConvert == typeof(global::RetellAI.TransferOptionWarmTransferOnHoldMusic)

                    || typeToConvert == typeof(global::RetellAI.TransferOptionWarmTransferOnHoldMusic?)

                    || typeToConvert == typeof(global::RetellAI.UtteranceHallucinationHallucinationType)

                    || typeToConvert == typeof(global::RetellAI.UtteranceHallucinationHallucinationType?)

                    || typeToConvert == typeof(global::RetellAI.UtteranceRole)

                    || typeToConvert == typeof(global::RetellAI.UtteranceRole?)

                    || typeToConvert == typeof(global::RetellAI.V2CallBaseCallStatus)

                    || typeToConvert == typeof(global::RetellAI.V2CallBaseCallStatus?)

                    || typeToConvert == typeof(global::RetellAI.V2CallBaseDataStorageSetting)

                    || typeToConvert == typeof(global::RetellAI.V2CallBaseDataStorageSetting?)

                    || typeToConvert == typeof(global::RetellAI.V3CallBaseCallStatus)

                    || typeToConvert == typeof(global::RetellAI.V3CallBaseCallStatus?)

                    || typeToConvert == typeof(global::RetellAI.V3CallBaseDataStorageSetting)

                    || typeToConvert == typeof(global::RetellAI.V3CallBaseDataStorageSetting?)

                    || typeToConvert == typeof(global::RetellAI.V3PhoneCallResponseVariant1CallType)

                    || typeToConvert == typeof(global::RetellAI.V3PhoneCallResponseVariant1CallType?)

                    || typeToConvert == typeof(global::RetellAI.V3PhoneCallResponseVariant1Direction)

                    || typeToConvert == typeof(global::RetellAI.V3PhoneCallResponseVariant1Direction?)

                    || typeToConvert == typeof(global::RetellAI.V3WebCallResponseVariant1CallType)

                    || typeToConvert == typeof(global::RetellAI.V3WebCallResponseVariant1CallType?)

                    || typeToConvert == typeof(global::RetellAI.V3ListCallsRequestSortOrder)

                    || typeToConvert == typeof(global::RetellAI.V3ListCallsRequestSortOrder?)

                    || typeToConvert == typeof(global::RetellAI.V2PhoneCallResponseVariant1CallType)

                    || typeToConvert == typeof(global::RetellAI.V2PhoneCallResponseVariant1CallType?)

                    || typeToConvert == typeof(global::RetellAI.V2PhoneCallResponseVariant1Direction)

                    || typeToConvert == typeof(global::RetellAI.V2PhoneCallResponseVariant1Direction?)

                    || typeToConvert == typeof(global::RetellAI.V2WebCallResponseVariant1CallType)

                    || typeToConvert == typeof(global::RetellAI.V2WebCallResponseVariant1CallType?)

                    || typeToConvert == typeof(global::RetellAI.VoiceResponseProvider)

                    || typeToConvert == typeof(global::RetellAI.VoiceResponseProvider?)

                    || typeToConvert == typeof(global::RetellAI.VoiceResponseGender)

                    || typeToConvert == typeof(global::RetellAI.VoiceResponseGender?)

                    || typeToConvert == typeof(global::RetellAI.VoicemailActionBridgeTransferType)

                    || typeToConvert == typeof(global::RetellAI.VoicemailActionBridgeTransferType?)

                    || typeToConvert == typeof(global::RetellAI.VoicemailActionHangupType)

                    || typeToConvert == typeof(global::RetellAI.VoicemailActionHangupType?)

                    || typeToConvert == typeof(global::RetellAI.VoicemailActionPromptType)

                    || typeToConvert == typeof(global::RetellAI.VoicemailActionPromptType?)

                    || typeToConvert == typeof(global::RetellAI.VoicemailActionStaticTextType)

                    || typeToConvert == typeof(global::RetellAI.VoicemailActionStaticTextType?)

                    || typeToConvert == typeof(global::RetellAI.IvrActionHangupType)

                    || typeToConvert == typeof(global::RetellAI.IvrActionHangupType?)

                    || typeToConvert == typeof(global::RetellAI.WarmTransferPromptType)

                    || typeToConvert == typeof(global::RetellAI.WarmTransferPromptType?)

                    || typeToConvert == typeof(global::RetellAI.WarmTransferStaticMessageType)

                    || typeToConvert == typeof(global::RetellAI.WarmTransferStaticMessageType?)

                    || typeToConvert == typeof(global::RetellAI.ConductorOverageConfigVariant1Mode)

                    || typeToConvert == typeof(global::RetellAI.ConductorOverageConfigVariant1Mode?)

                    || typeToConvert == typeof(global::RetellAI.ConductorOverageConfigVariant2Mode)

                    || typeToConvert == typeof(global::RetellAI.ConductorOverageConfigVariant2Mode?)

                    || typeToConvert == typeof(global::RetellAI.ConductorOverageConfigVariant3Mode)

                    || typeToConvert == typeof(global::RetellAI.ConductorOverageConfigVariant3Mode?)

                    || typeToConvert == typeof(global::RetellAI.ContactCallType)

                    || typeToConvert == typeof(global::RetellAI.ContactCallType?)

                    || typeToConvert == typeof(global::RetellAI.ContactCallDirection)

                    || typeToConvert == typeof(global::RetellAI.ContactCallDirection?)

                    || typeToConvert == typeof(global::RetellAI.ContactCallSentiment)

                    || typeToConvert == typeof(global::RetellAI.ContactCallSentiment?)

                    || typeToConvert == typeof(global::RetellAI.ContactChatType)

                    || typeToConvert == typeof(global::RetellAI.ContactChatType?)

                    || typeToConvert == typeof(global::RetellAI.ContactChatDirection)

                    || typeToConvert == typeof(global::RetellAI.ContactChatDirection?)

                    || typeToConvert == typeof(global::RetellAI.ContactChatSentiment)

                    || typeToConvert == typeof(global::RetellAI.ContactChatSentiment?)

                    || typeToConvert == typeof(global::RetellAI.AppType)

                    || typeToConvert == typeof(global::RetellAI.AppType?)

                    || typeToConvert == typeof(global::RetellAI.AppConnectionStatus)

                    || typeToConvert == typeof(global::RetellAI.AppConnectionStatus?)

                    || typeToConvert == typeof(global::RetellAI.OAuthConfigRequestType)

                    || typeToConvert == typeof(global::RetellAI.OAuthConfigRequestType?)

                    || typeToConvert == typeof(global::RetellAI.ApiKeyAuthConfigRequestType)

                    || typeToConvert == typeof(global::RetellAI.ApiKeyAuthConfigRequestType?)

                    || typeToConvert == typeof(global::RetellAI.AccessTokenAuthConfigRequestType)

                    || typeToConvert == typeof(global::RetellAI.AccessTokenAuthConfigRequestType?)

                    || typeToConvert == typeof(global::RetellAI.BasicAuthConfigRequestType)

                    || typeToConvert == typeof(global::RetellAI.BasicAuthConfigRequestType?)

                    || typeToConvert == typeof(global::RetellAI.RefreshTokenAuthConfigRequestType)

                    || typeToConvert == typeof(global::RetellAI.RefreshTokenAuthConfigRequestType?)

                    || typeToConvert == typeof(global::RetellAI.OAuthConfigResponseType)

                    || typeToConvert == typeof(global::RetellAI.OAuthConfigResponseType?)

                    || typeToConvert == typeof(global::RetellAI.ApiKeyAuthConfigResponseType)

                    || typeToConvert == typeof(global::RetellAI.ApiKeyAuthConfigResponseType?)

                    || typeToConvert == typeof(global::RetellAI.AccessTokenAuthConfigResponseType)

                    || typeToConvert == typeof(global::RetellAI.AccessTokenAuthConfigResponseType?)

                    || typeToConvert == typeof(global::RetellAI.BasicAuthConfigResponseType)

                    || typeToConvert == typeof(global::RetellAI.BasicAuthConfigResponseType?)

                    || typeToConvert == typeof(global::RetellAI.RefreshTokenAuthConfigResponseType)

                    || typeToConvert == typeof(global::RetellAI.RefreshTokenAuthConfigResponseType?)

                    || typeToConvert == typeof(global::RetellAI.AgentAppUsageType)

                    || typeToConvert == typeof(global::RetellAI.AgentAppUsageType?)

                    || typeToConvert == typeof(global::RetellAI.KnowledgeBaseAppUsageType)

                    || typeToConvert == typeof(global::RetellAI.KnowledgeBaseAppUsageType?)

                    || typeToConvert == typeof(global::RetellAI.CRMCustomFieldSchemaType)

                    || typeToConvert == typeof(global::RetellAI.CRMCustomFieldSchemaType?)

                    || typeToConvert == typeof(global::RetellAI.CRMAnalysisDataMappingUpdateMode)

                    || typeToConvert == typeof(global::RetellAI.CRMAnalysisDataMappingUpdateMode?)

                    || typeToConvert == typeof(global::RetellAI.JobStatusStatus)

                    || typeToConvert == typeof(global::RetellAI.JobStatusStatus?)

                    || typeToConvert == typeof(global::RetellAI.JobStatusTriggeredBy)

                    || typeToConvert == typeof(global::RetellAI.JobStatusTriggeredBy?)

                    || typeToConvert == typeof(global::RetellAI.DashboardSource)

                    || typeToConvert == typeof(global::RetellAI.DashboardSource?)

                    || typeToConvert == typeof(global::RetellAI.ChartGroupItemVariant1Type)

                    || typeToConvert == typeof(global::RetellAI.ChartGroupItemVariant1Type?)

                    || typeToConvert == typeof(global::RetellAI.ChartGroupItemVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.ChartGroupItemVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneNumberRequestNumberProvider)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneNumberRequestNumberProvider?)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneNumberRequestCountryCode)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneNumberRequestCountryCode?)

                    || typeToConvert == typeof(global::RetellAI.CloneVoiceRequestVoiceProvider)

                    || typeToConvert == typeof(global::RetellAI.CloneVoiceRequestVoiceProvider?)

                    || typeToConvert == typeof(global::RetellAI.AddCommunityVoiceRequestVoiceProvider)

                    || typeToConvert == typeof(global::RetellAI.AddCommunityVoiceRequestVoiceProvider?)

                    || typeToConvert == typeof(global::RetellAI.SearchCommunityVoiceRequestVoiceProvider)

                    || typeToConvert == typeof(global::RetellAI.SearchCommunityVoiceRequestVoiceProvider?)

                    || typeToConvert == typeof(global::RetellAI.UpdateChatMetadataRequestDataStorageSetting)

                    || typeToConvert == typeof(global::RetellAI.UpdateChatMetadataRequestDataStorageSetting?)

                    || typeToConvert == typeof(global::RetellAI.RegisterPhoneCallRequestDirection)

                    || typeToConvert == typeof(global::RetellAI.RegisterPhoneCallRequestDirection?)

                    || typeToConvert == typeof(global::RetellAI.UpdateCallMetadataRequestDataStorageSetting)

                    || typeToConvert == typeof(global::RetellAI.UpdateCallMetadataRequestDataStorageSetting?)

                    || typeToConvert == typeof(global::RetellAI.UpdateLiveCallRequestFieldsToOverrideDataStorageSetting)

                    || typeToConvert == typeof(global::RetellAI.UpdateLiveCallRequestFieldsToOverrideDataStorageSetting?)

                    || typeToConvert == typeof(global::RetellAI.ListTestCaseDefinitionsType)

                    || typeToConvert == typeof(global::RetellAI.ListTestCaseDefinitionsType?)

                    || typeToConvert == typeof(global::RetellAI.ListBatchTestsType)

                    || typeToConvert == typeof(global::RetellAI.ListBatchTestsType?)

                    || typeToConvert == typeof(global::RetellAI.ListAgentVersionsSortOrder)

                    || typeToConvert == typeof(global::RetellAI.ListAgentVersionsSortOrder?)

                    || typeToConvert == typeof(global::RetellAI.ListAgentsSortOrder)

                    || typeToConvert == typeof(global::RetellAI.ListAgentsSortOrder?)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowComponentsSortOrder)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowComponentsSortOrder?)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowsSortOrder)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowsSortOrder?)

                    || typeToConvert == typeof(global::RetellAI.ListPhoneNumbersSortOrder)

                    || typeToConvert == typeof(global::RetellAI.ListPhoneNumbersSortOrder?)

                    || typeToConvert == typeof(global::RetellAI.ListRetellLLMSortOrder)

                    || typeToConvert == typeof(global::RetellAI.ListRetellLLMSortOrder?)

                    || typeToConvert == typeof(global::RetellAI.ListExportRequestsSortOrder)

                    || typeToConvert == typeof(global::RetellAI.ListExportRequestsSortOrder?)

                    || typeToConvert == typeof(global::RetellAI.ListAppsSortOrder)

                    || typeToConvert == typeof(global::RetellAI.ListAppsSortOrder?)

                    || typeToConvert == typeof(global::RetellAI.ListAppUsagesSortOrder)

                    || typeToConvert == typeof(global::RetellAI.ListAppUsagesSortOrder?)

                    || typeToConvert == typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.CreateAgentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateAgentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateAgentResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.CreateAgentResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.CreateAgentResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.CreateAgentResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.CreateAgentResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.CreateAgentResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.CreateBatchCallResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateBatchCallResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateBatchCallResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.CreateBatchCallResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.CreateBatchCallResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.CreateBatchCallResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.CreateBatchCallResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.CreateBatchCallResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.CreateBatchTestResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateBatchTestResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateBatchTestResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.CreateBatchTestResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.CreateBatchTestResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.CreateBatchTestResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.CreateBatchTestResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.CreateBatchTestResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.CreateBatchTestResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.CreateBatchTestResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.GetBatchTestResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetBatchTestResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetBatchTestResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetBatchTestResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetBatchTestResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.GetBatchTestResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.GetBatchTestResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.GetBatchTestResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.GetBatchTestResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.GetBatchTestResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.ListBatchTestsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListBatchTestsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListBatchTestsResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.ListBatchTestsResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.ListBatchTestsResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.ListBatchTestsResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.ListBatchTestsResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.ListBatchTestsResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.GetTestRunResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetTestRunResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetTestRunResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetTestRunResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetTestRunResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.GetTestRunResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.GetTestRunResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.GetTestRunResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.GetTestRunResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.GetTestRunResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.ListTestRunsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListTestRunsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListTestRunsResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.ListTestRunsResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.ListTestRunsResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.ListTestRunsResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.ListTestRunsResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.ListTestRunsResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.ListTestRunsResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.ListTestRunsResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.CreateChatAgentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateChatAgentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateChatAgentResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.CreateChatAgentResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.CreateChatAgentResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.CreateChatAgentResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.CreateChatAgentResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.CreateChatAgentResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus6)

                    || typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus6?)

                    || typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus6)

                    || typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus6?)

                    || typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus6)

                    || typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus6?)

                    || typeToConvert == typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.CreateConversationFlowResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateConversationFlowResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateConversationFlowResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.CreateConversationFlowResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.CreateConversationFlowResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.CreateConversationFlowResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.CreateConversationFlowResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.CreateConversationFlowResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.CreateConversationFlowResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.CreateConversationFlowResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneNumberResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneNumberResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneNumberResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneNumberResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneNumberResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneNumberResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.CreateRetellLLMResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateRetellLLMResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateRetellLLMResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.CreateRetellLLMResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.CreateRetellLLMResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.CreateRetellLLMResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus6)

                    || typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus6?)

                    || typeToConvert == typeof(global::RetellAI.DeleteAgentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteAgentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteAgentResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.DeleteAgentResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.DeleteAgentResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.DeleteAgentResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.DeleteAgentResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.DeleteAgentResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.DeleteChatResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteChatResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteChatResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.DeleteChatResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.DeleteChatResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.DeleteChatResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.DeleteChatResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.DeleteChatResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.DeleteChatAgentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteChatAgentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteChatAgentResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.DeleteChatAgentResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.DeleteChatAgentResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.DeleteChatAgentResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.DeleteChatAgentResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.DeleteChatAgentResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.DeleteConversationFlowResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteConversationFlowResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteConversationFlowResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.DeleteConversationFlowResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.DeleteConversationFlowResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.DeleteConversationFlowResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.DeleteConversationFlowResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.DeleteConversationFlowResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.DeleteConversationFlowResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.DeleteConversationFlowResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.DeletePhoneNumberResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeletePhoneNumberResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeletePhoneNumberResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.DeletePhoneNumberResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.DeletePhoneNumberResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.DeletePhoneNumberResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.DeleteRetellLLMResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteRetellLLMResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteRetellLLMResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.DeleteRetellLLMResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.DeleteRetellLLMResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.DeleteRetellLLMResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.DeleteRetellLLMResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.DeleteRetellLLMResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.EndChatResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.EndChatResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.EndChatResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.EndChatResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.EndChatResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.EndChatResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.EndChatResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.EndChatResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus6)

                    || typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus6?)

                    || typeToConvert == typeof(global::RetellAI.GetAgentVersionsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetAgentVersionsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetAgentVersionsResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetAgentVersionsResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetAgentVersionsResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.GetAgentVersionsResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.GetAgentVersionsResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.GetAgentVersionsResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.GetAgentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetAgentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetAgentResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetAgentResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetAgentResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.GetAgentResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.GetAgentResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.GetAgentResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.GetChatAgentVersionsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetChatAgentVersionsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetChatAgentVersionsResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetChatAgentVersionsResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetChatAgentVersionsResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.GetChatAgentVersionsResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.GetChatAgentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetChatAgentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetChatAgentResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetChatAgentResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetChatAgentResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.GetChatAgentResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.GetChatAgentResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.GetChatAgentResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.GetChatResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetChatResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetChatResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetChatResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetChatResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.GetChatResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.GetChatResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.GetChatResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.GetConcurrencyResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetConcurrencyResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetConcurrencyResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetConcurrencyResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetApiKeyInfoResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetApiKeyInfoResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetApiKeyInfoResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetApiKeyInfoResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetConversationFlowComponentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetConversationFlowComponentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetConversationFlowComponentResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetConversationFlowComponentResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetConversationFlowComponentResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.GetConversationFlowComponentResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.GetConversationFlowComponentResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.GetConversationFlowComponentResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.GetConversationFlowResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetConversationFlowResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetConversationFlowResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetConversationFlowResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetConversationFlowResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.GetConversationFlowResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.GetConversationFlowResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.GetConversationFlowResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.GetConversationFlowResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.GetConversationFlowResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.GetKnowledgeBaseResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetKnowledgeBaseResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetKnowledgeBaseResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetKnowledgeBaseResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetKnowledgeBaseResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.GetKnowledgeBaseResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.GetKnowledgeBaseResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.GetKnowledgeBaseResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.GetMCPToolsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetMCPToolsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetMCPToolsResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetMCPToolsResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetMCPToolsResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.GetMCPToolsResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.GetMCPToolsResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.GetMCPToolsResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.GetPhoneNumberResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetPhoneNumberResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetPhoneNumberResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetPhoneNumberResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetPhoneNumberResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.GetPhoneNumberResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.GetPhoneNumberResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.GetPhoneNumberResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.GetRetellLLMResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetRetellLLMResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetRetellLLMResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetRetellLLMResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetRetellLLMResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.GetRetellLLMResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.GetRetellLLMResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.GetRetellLLMResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.GetVoiceResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetVoiceResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetVoiceResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetVoiceResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetVoiceResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.GetVoiceResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.GetVoiceResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.GetVoiceResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.CloneVoiceResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CloneVoiceResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CloneVoiceResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.CloneVoiceResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.CloneVoiceResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.CloneVoiceResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.CloneVoiceResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.CloneVoiceResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.CloneVoiceResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.CloneVoiceResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.AddCommunityVoiceResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.AddCommunityVoiceResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.AddCommunityVoiceResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.AddCommunityVoiceResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.AddCommunityVoiceResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.AddCommunityVoiceResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.AddCommunityVoiceResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.AddCommunityVoiceResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.SearchCommunityVoiceResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.SearchCommunityVoiceResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.SearchCommunityVoiceResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.SearchCommunityVoiceResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.SearchCommunityVoiceResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.SearchCommunityVoiceResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.SearchCommunityVoiceResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.SearchCommunityVoiceResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.ImportPhoneNumberResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ImportPhoneNumberResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ImportPhoneNumberResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.ImportPhoneNumberResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.ImportPhoneNumberResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.ImportPhoneNumberResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.ListAgentsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListAgentsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListAgentsResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.ListAgentsResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.ListAgentsResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.ListAgentsResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.ListAgentsResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.ListAgentsResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.ListChatsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListChatsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListChatsResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.ListChatsResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.ListChatsResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.ListChatsResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.ListChatsResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.ListChatsResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowsResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowsResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowsResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowsResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowsResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowsResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowsResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowsResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.ListKnowledgeBasesResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListKnowledgeBasesResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListKnowledgeBasesResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.ListKnowledgeBasesResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.ListKnowledgeBasesResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.ListKnowledgeBasesResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.ListPhoneNumbersResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListPhoneNumbersResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListPhoneNumbersResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.ListPhoneNumbersResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.ListRetellLLMResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListRetellLLMResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListRetellLLMResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.ListRetellLLMResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.ListRetellLLMResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.ListRetellLLMResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.ListRetellLLMResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.ListRetellLLMResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.ListRetellLLMResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.ListRetellLLMResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.ListVoicesResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListVoicesResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListVoicesResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.ListVoicesResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.CreateAgentVersionResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateAgentVersionResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateAgentVersionResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.CreateAgentVersionResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.CreateAgentVersionResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.CreateAgentVersionResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.CreateAgentVersionResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.CreateAgentVersionResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.CreateAgentVersionResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.CreateAgentVersionResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.PublishAgentVersionResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.PublishAgentVersionResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.PublishAgentVersionResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.PublishAgentVersionResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.PublishAgentVersionResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.PublishAgentVersionResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.PublishAgentVersionResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.PublishAgentVersionResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.PublishAgentVersionResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.PublishAgentVersionResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.DeleteAgentVersionResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteAgentVersionResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteAgentVersionResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.DeleteAgentVersionResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.DeleteAgentVersionResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.DeleteAgentVersionResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.DeleteAgentVersionResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.DeleteAgentVersionResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.DeleteAgentVersionResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.DeleteAgentVersionResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus6)

                    || typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus6?)

                    || typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus7)

                    || typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus7?)

                    || typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus6)

                    || typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus6?)

                    || typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus7)

                    || typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus7?)

                    || typeToConvert == typeof(global::RetellAI.UpdateAgentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateAgentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateAgentResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.UpdateAgentResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.UpdateAgentResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.UpdateAgentResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.UpdateAgentResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.UpdateAgentResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.UpdateAgentResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.UpdateAgentResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.UpdateChatAgentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateChatAgentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateChatAgentResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.UpdateChatAgentResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.UpdateChatAgentResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.UpdateChatAgentResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.UpdateChatAgentResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.UpdateChatAgentResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.UpdateChatAgentResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.UpdateChatAgentResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.UpdateChatMetadataResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateChatMetadataResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateChatMetadataResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.UpdateChatMetadataResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.UpdateChatMetadataResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.UpdateChatMetadataResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.UpdateChatMetadataResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.UpdateChatMetadataResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus6)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus6?)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus6)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus6?)

                    || typeToConvert == typeof(global::RetellAI.UpdatePhoneNumberResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdatePhoneNumberResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdatePhoneNumberResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.UpdatePhoneNumberResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.UpdatePhoneNumberResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.UpdatePhoneNumberResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.UpdatePhoneNumberResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.UpdatePhoneNumberResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.UpdateRetellLLMResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateRetellLLMResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateRetellLLMResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.UpdateRetellLLMResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.UpdateRetellLLMResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.UpdateRetellLLMResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.UpdateRetellLLMResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.UpdateRetellLLMResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.UpdateRetellLLMResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.UpdateRetellLLMResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus6)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus6?)

                    || typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus6)

                    || typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus6?)

                    || typeToConvert == typeof(global::RetellAI.DeleteCallResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteCallResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteCallResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.DeleteCallResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.DeleteCallResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.DeleteCallResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.DeleteCallResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.DeleteCallResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.GetCallResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetCallResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetCallResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetCallResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetCallResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.GetCallResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.GetCallResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.GetCallResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.ListCallsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListCallsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListCallsResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.ListCallsResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.ListCallsResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.ListCallsResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.ListCallsResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.ListCallsResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseItemChannel)

                    || typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseItemChannel?)

                    || typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseItemStatus)

                    || typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseItemStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus6)

                    || typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus6?)

                    || typeToConvert == typeof(global::RetellAI.UpdateCallMetadataResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateCallMetadataResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateCallMetadataResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.UpdateCallMetadataResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.UpdateCallMetadataResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.UpdateCallMetadataResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.UpdateCallMetadataResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.UpdateCallMetadataResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.UpdateLiveCallResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateLiveCallResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateLiveCallResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.UpdateLiveCallResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.UpdateLiveCallResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.UpdateLiveCallResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.UpdateLiveCallResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.UpdateLiveCallResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.UpdateLiveCallResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.UpdateLiveCallResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.StopCallResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.StopCallResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.StopCallResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.StopCallResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.StopCallResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.StopCallResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.StopCallResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.StopCallResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.CreateContactResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateContactResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateContactResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.CreateContactResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.CreateContactResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.CreateContactResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.CreateContactResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.CreateContactResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.GetContactResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetContactResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetContactResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetContactResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetContactResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.GetContactResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.GetContactResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.GetContactResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.GetContactByPhoneResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetContactByPhoneResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetContactByPhoneResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetContactByPhoneResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetContactByPhoneResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.GetContactByPhoneResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.GetContactByPhoneResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.GetContactByPhoneResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.GetContactByPhoneResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.GetContactByPhoneResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.UpdateContactResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateContactResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateContactResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.UpdateContactResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.UpdateContactResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.UpdateContactResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.UpdateContactResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.UpdateContactResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.UpdateContactResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.UpdateContactResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.DeleteContactResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteContactResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteContactResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.DeleteContactResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.DeleteContactResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.DeleteContactResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.DeleteContactResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.DeleteContactResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.DeleteContactResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.DeleteContactResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.ListContactsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListContactsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListContactsResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.ListContactsResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.ListContactsResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.ListContactsResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.ListContactsResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.ListContactsResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.ListContactConversationsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListContactConversationsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListContactConversationsResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.ListContactConversationsResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.ListContactConversationsResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.ListContactConversationsResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.ListContactConversationsResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.ListContactConversationsResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.CreateAppResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateAppResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateAppResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.CreateAppResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.CreateAppResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.CreateAppResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.CreateAppResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.CreateAppResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.GetAppResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetAppResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetAppResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetAppResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetAppResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.GetAppResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.GetAppResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.GetAppResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.UpdateAppResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateAppResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateAppResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.UpdateAppResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.UpdateAppResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.UpdateAppResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.UpdateAppResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.UpdateAppResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.UpdateAppResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.UpdateAppResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.DeleteAppResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteAppResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteAppResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.DeleteAppResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.DeleteAppResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.DeleteAppResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.DeleteAppResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.DeleteAppResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.DeleteAppResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.DeleteAppResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.ListAppsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListAppsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListAppsResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.ListAppsResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.ListAppsResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.ListAppsResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.ListAppUsagesResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListAppUsagesResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListAppUsagesResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.ListAppUsagesResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.ListAppUsagesResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.ListAppUsagesResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.ListAppUsagesResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.ListAppUsagesResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.TestAppAuthResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.TestAppAuthResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.TestAppAuthResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.TestAppAuthResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.TestAppAuthResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.TestAppAuthResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.TestAppAuthResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.TestAppAuthResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.GetCrmConfigResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetCrmConfigResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetCrmConfigResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetCrmConfigResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetCrmConfigResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.GetCrmConfigResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.UpdateCrmConfigResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateCrmConfigResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateCrmConfigResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.UpdateCrmConfigResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.UpdateCrmConfigResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.UpdateCrmConfigResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.UpdateCrmConfigResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.UpdateCrmConfigResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.UpdateCrmConfigResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.UpdateCrmConfigResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.RunSyncJobResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.RunSyncJobResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.RunSyncJobResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.RunSyncJobResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.RunSyncJobResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.RunSyncJobResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.RunSyncJobResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.RunSyncJobResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.GetSyncJobStatusResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetSyncJobStatusResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetSyncJobStatusResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetSyncJobStatusResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetSyncJobStatusResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.GetSyncJobStatusResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.GetBackfillContactJobStatusResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetBackfillContactJobStatusResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetBackfillContactJobStatusResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetBackfillContactJobStatusResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetBackfillContactJobStatusResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.GetBackfillContactJobStatusResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus2)

                    || typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus2?)

                    || typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus3)

                    || typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus3?)

                    || typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus4)

                    || typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus4?)

                    || typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus5)

                    || typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus5?)

                    || typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus6)

                    || typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus6?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::RetellAI.AlertMetricType))
                {
                    return new global::RetellAI.JsonConverters.AlertMetricTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertMetricType?))
                {
                    return new global::RetellAI.JsonConverters.AlertMetricTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AsrProvider))
                {
                    return new global::RetellAI.JsonConverters.AsrProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AsrProvider?))
                {
                    return new global::RetellAI.JsonConverters.AsrProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertFilterStatusCodeValueItem))
                {
                    return new global::RetellAI.JsonConverters.AlertFilterStatusCodeValueItemJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertFilterStatusCodeValueItem?))
                {
                    return new global::RetellAI.JsonConverters.AlertFilterStatusCodeValueItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertFilterErrorCodeItem))
                {
                    return new global::RetellAI.JsonConverters.AlertFilterErrorCodeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertFilterErrorCodeItem?))
                {
                    return new global::RetellAI.JsonConverters.AlertFilterErrorCodeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertIncidentResponseThresholdType))
                {
                    return new global::RetellAI.JsonConverters.AlertIncidentResponseThresholdTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertIncidentResponseThresholdType?))
                {
                    return new global::RetellAI.JsonConverters.AlertIncidentResponseThresholdTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertIncidentResponseComparator))
                {
                    return new global::RetellAI.JsonConverters.AlertIncidentResponseComparatorJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertIncidentResponseComparator?))
                {
                    return new global::RetellAI.JsonConverters.AlertIncidentResponseComparatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertIncidentResponseFrequency))
                {
                    return new global::RetellAI.JsonConverters.AlertIncidentResponseFrequencyJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertIncidentResponseFrequency?))
                {
                    return new global::RetellAI.JsonConverters.AlertIncidentResponseFrequencyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertIncidentResponseWindow))
                {
                    return new global::RetellAI.JsonConverters.AlertIncidentResponseWindowJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertIncidentResponseWindow?))
                {
                    return new global::RetellAI.JsonConverters.AlertIncidentResponseWindowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertRuleRequestThresholdType))
                {
                    return new global::RetellAI.JsonConverters.AlertRuleRequestThresholdTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertRuleRequestThresholdType?))
                {
                    return new global::RetellAI.JsonConverters.AlertRuleRequestThresholdTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertRuleRequestComparator))
                {
                    return new global::RetellAI.JsonConverters.AlertRuleRequestComparatorJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertRuleRequestComparator?))
                {
                    return new global::RetellAI.JsonConverters.AlertRuleRequestComparatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertRuleRequestFrequency))
                {
                    return new global::RetellAI.JsonConverters.AlertRuleRequestFrequencyJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertRuleRequestFrequency?))
                {
                    return new global::RetellAI.JsonConverters.AlertRuleRequestFrequencyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertRuleRequestWindow))
                {
                    return new global::RetellAI.JsonConverters.AlertRuleRequestWindowJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertRuleRequestWindow?))
                {
                    return new global::RetellAI.JsonConverters.AlertRuleRequestWindowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertRuleResponseThresholdType))
                {
                    return new global::RetellAI.JsonConverters.AlertRuleResponseThresholdTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertRuleResponseThresholdType?))
                {
                    return new global::RetellAI.JsonConverters.AlertRuleResponseThresholdTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertRuleResponseComparator))
                {
                    return new global::RetellAI.JsonConverters.AlertRuleResponseComparatorJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertRuleResponseComparator?))
                {
                    return new global::RetellAI.JsonConverters.AlertRuleResponseComparatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertRuleResponseFrequency))
                {
                    return new global::RetellAI.JsonConverters.AlertRuleResponseFrequencyJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertRuleResponseFrequency?))
                {
                    return new global::RetellAI.JsonConverters.AlertRuleResponseFrequencyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertRuleResponseWindow))
                {
                    return new global::RetellAI.JsonConverters.AlertRuleResponseWindowJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertRuleResponseWindow?))
                {
                    return new global::RetellAI.JsonConverters.AlertRuleResponseWindowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentRequestVoiceModel))
                {
                    return new global::RetellAI.JsonConverters.AgentRequestVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentRequestVoiceModel?))
                {
                    return new global::RetellAI.JsonConverters.AgentRequestVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentRequestVoiceEmotion))
                {
                    return new global::RetellAI.JsonConverters.AgentRequestVoiceEmotionJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentRequestVoiceEmotion?))
                {
                    return new global::RetellAI.JsonConverters.AgentRequestVoiceEmotionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentRequestExpressiveEmotionTag))
                {
                    return new global::RetellAI.JsonConverters.AgentRequestExpressiveEmotionTagJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentRequestExpressiveEmotionTag?))
                {
                    return new global::RetellAI.JsonConverters.AgentRequestExpressiveEmotionTagNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentRequestAmbientSound))
                {
                    return new global::RetellAI.JsonConverters.AgentRequestAmbientSoundJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentRequestAmbientSound?))
                {
                    return new global::RetellAI.JsonConverters.AgentRequestAmbientSoundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentRequestLanguage))
                {
                    return new global::RetellAI.JsonConverters.AgentRequestLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentRequestLanguage?))
                {
                    return new global::RetellAI.JsonConverters.AgentRequestLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentRequestWebhookEvent))
                {
                    return new global::RetellAI.JsonConverters.AgentRequestWebhookEventJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentRequestWebhookEvent?))
                {
                    return new global::RetellAI.JsonConverters.AgentRequestWebhookEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentRequestDataStorageSetting))
                {
                    return new global::RetellAI.JsonConverters.AgentRequestDataStorageSettingJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentRequestDataStorageSetting?))
                {
                    return new global::RetellAI.JsonConverters.AgentRequestDataStorageSettingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentRequestPronunciationDictionaryItemAlphabet))
                {
                    return new global::RetellAI.JsonConverters.AgentRequestPronunciationDictionaryItemAlphabetJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentRequestPronunciationDictionaryItemAlphabet?))
                {
                    return new global::RetellAI.JsonConverters.AgentRequestPronunciationDictionaryItemAlphabetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentRequestSttMode))
                {
                    return new global::RetellAI.JsonConverters.AgentRequestSttModeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentRequestSttMode?))
                {
                    return new global::RetellAI.JsonConverters.AgentRequestSttModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentRequestVocabSpecialization))
                {
                    return new global::RetellAI.JsonConverters.AgentRequestVocabSpecializationJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentRequestVocabSpecialization?))
                {
                    return new global::RetellAI.JsonConverters.AgentRequestVocabSpecializationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentRequestDenoisingMode))
                {
                    return new global::RetellAI.JsonConverters.AgentRequestDenoisingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentRequestDenoisingMode?))
                {
                    return new global::RetellAI.JsonConverters.AgentRequestDenoisingModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentListFilterChannelOp))
                {
                    return new global::RetellAI.JsonConverters.AgentListFilterChannelOpJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentListFilterChannelOp?))
                {
                    return new global::RetellAI.JsonConverters.AgentListFilterChannelOpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentListFilterChannelValue))
                {
                    return new global::RetellAI.JsonConverters.AgentListFilterChannelValueJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentListFilterChannelValue?))
                {
                    return new global::RetellAI.JsonConverters.AgentListFilterChannelValueNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentListItemResponseChannel))
                {
                    return new global::RetellAI.JsonConverters.AgentListItemResponseChannelJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentListItemResponseChannel?))
                {
                    return new global::RetellAI.JsonConverters.AgentListItemResponseChannelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentSwapNodeVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.AgentSwapNodeVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentSwapNodeVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.AgentSwapNodeVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentSwapToolType))
                {
                    return new global::RetellAI.JsonConverters.AgentSwapToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentSwapToolType?))
                {
                    return new global::RetellAI.JsonConverters.AgentSwapToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentSwapToolExecutionMessageType))
                {
                    return new global::RetellAI.JsonConverters.AgentSwapToolExecutionMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentSwapToolExecutionMessageType?))
                {
                    return new global::RetellAI.JsonConverters.AgentSwapToolExecutionMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentSwapWebhookSetting))
                {
                    return new global::RetellAI.JsonConverters.AgentSwapWebhookSettingJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentSwapWebhookSetting?))
                {
                    return new global::RetellAI.JsonConverters.AgentSwapWebhookSettingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BookAppointmentCalToolType))
                {
                    return new global::RetellAI.JsonConverters.BookAppointmentCalToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BookAppointmentCalToolType?))
                {
                    return new global::RetellAI.JsonConverters.BookAppointmentCalToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BooleanAnalysisDataType))
                {
                    return new global::RetellAI.JsonConverters.BooleanAnalysisDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BooleanAnalysisDataType?))
                {
                    return new global::RetellAI.JsonConverters.BooleanAnalysisDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BranchNodeVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.BranchNodeVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BranchNodeVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.BranchNodeVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BridgeTransferNodeVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.BridgeTransferNodeVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BridgeTransferNodeVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.BridgeTransferNodeVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BridgeTransferToolType))
                {
                    return new global::RetellAI.JsonConverters.BridgeTransferToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BridgeTransferToolType?))
                {
                    return new global::RetellAI.JsonConverters.BridgeTransferToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BridgeTransferToolExecutionMessageType))
                {
                    return new global::RetellAI.JsonConverters.BridgeTransferToolExecutionMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BridgeTransferToolExecutionMessageType?))
                {
                    return new global::RetellAI.JsonConverters.BridgeTransferToolExecutionMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CallAnalysisUserSentiment))
                {
                    return new global::RetellAI.JsonConverters.CallAnalysisUserSentimentJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CallAnalysisUserSentiment?))
                {
                    return new global::RetellAI.JsonConverters.CallAnalysisUserSentimentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CancelTransferNodeVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.CancelTransferNodeVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CancelTransferNodeVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.CancelTransferNodeVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CancelTransferToolType))
                {
                    return new global::RetellAI.JsonConverters.CancelTransferToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CancelTransferToolType?))
                {
                    return new global::RetellAI.JsonConverters.CancelTransferToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CancelTransferToolExecutionMessageType))
                {
                    return new global::RetellAI.JsonConverters.CancelTransferToolExecutionMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CancelTransferToolExecutionMessageType?))
                {
                    return new global::RetellAI.JsonConverters.CancelTransferToolExecutionMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatAgentRequestLanguage))
                {
                    return new global::RetellAI.JsonConverters.ChatAgentRequestLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatAgentRequestLanguage?))
                {
                    return new global::RetellAI.JsonConverters.ChatAgentRequestLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatAgentRequestWebhookEvent))
                {
                    return new global::RetellAI.JsonConverters.ChatAgentRequestWebhookEventJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatAgentRequestWebhookEvent?))
                {
                    return new global::RetellAI.JsonConverters.ChatAgentRequestWebhookEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatAgentRequestDataStorageSetting))
                {
                    return new global::RetellAI.JsonConverters.ChatAgentRequestDataStorageSettingJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatAgentRequestDataStorageSetting?))
                {
                    return new global::RetellAI.JsonConverters.ChatAgentRequestDataStorageSettingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatAnalysisUserSentiment))
                {
                    return new global::RetellAI.JsonConverters.ChatAnalysisUserSentimentJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatAnalysisUserSentiment?))
                {
                    return new global::RetellAI.JsonConverters.ChatAnalysisUserSentimentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatResponseChatStatus))
                {
                    return new global::RetellAI.JsonConverters.ChatResponseChatStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatResponseChatStatus?))
                {
                    return new global::RetellAI.JsonConverters.ChatResponseChatStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatResponseChatType))
                {
                    return new global::RetellAI.JsonConverters.ChatResponseChatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatResponseChatType?))
                {
                    return new global::RetellAI.JsonConverters.ChatResponseChatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V3ListChatsRequestSortOrder))
                {
                    return new global::RetellAI.JsonConverters.V3ListChatsRequestSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V3ListChatsRequestSortOrder?))
                {
                    return new global::RetellAI.JsonConverters.V3ListChatsRequestSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CheckAvailabilityCalToolType))
                {
                    return new global::RetellAI.JsonConverters.CheckAvailabilityCalToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CheckAvailabilityCalToolType?))
                {
                    return new global::RetellAI.JsonConverters.CheckAvailabilityCalToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CohortAggregatedResultGroupBy))
                {
                    return new global::RetellAI.JsonConverters.CohortAggregatedResultGroupByJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CohortAggregatedResultGroupBy?))
                {
                    return new global::RetellAI.JsonConverters.CohortAggregatedResultGroupByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CohortFilterStartTimestampVariant1Op))
                {
                    return new global::RetellAI.JsonConverters.CohortFilterStartTimestampVariant1OpJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CohortFilterStartTimestampVariant1Op?))
                {
                    return new global::RetellAI.JsonConverters.CohortFilterStartTimestampVariant1OpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CohortFilterCallDurationFilterOp))
                {
                    return new global::RetellAI.JsonConverters.CohortFilterCallDurationFilterOpJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CohortFilterCallDurationFilterOp?))
                {
                    return new global::RetellAI.JsonConverters.CohortFilterCallDurationFilterOpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CohortSuccessfulCriteriaType))
                {
                    return new global::RetellAI.JsonConverters.CohortSuccessfulCriteriaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CohortSuccessfulCriteriaType?))
                {
                    return new global::RetellAI.JsonConverters.CohortSuccessfulCriteriaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CohortSuccessfulCriteriaOp))
                {
                    return new global::RetellAI.JsonConverters.CohortSuccessfulCriteriaOpJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CohortSuccessfulCriteriaOp?))
                {
                    return new global::RetellAI.JsonConverters.CohortSuccessfulCriteriaOpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CohortEvaluationMode))
                {
                    return new global::RetellAI.JsonConverters.CohortEvaluationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CohortEvaluationMode?))
                {
                    return new global::RetellAI.JsonConverters.CohortEvaluationModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ComponentNodeVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.ComponentNodeVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ComponentNodeVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.ComponentNodeVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ComponentNodeVariant2ComponentType))
                {
                    return new global::RetellAI.JsonConverters.ComponentNodeVariant2ComponentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ComponentNodeVariant2ComponentType?))
                {
                    return new global::RetellAI.JsonConverters.ComponentNodeVariant2ComponentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConversationFlowOverrideStartSpeaker))
                {
                    return new global::RetellAI.JsonConverters.ConversationFlowOverrideStartSpeakerJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConversationFlowOverrideStartSpeaker?))
                {
                    return new global::RetellAI.JsonConverters.ConversationFlowOverrideStartSpeakerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConversationNodeVariant3Type))
                {
                    return new global::RetellAI.JsonConverters.ConversationNodeVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConversationNodeVariant3Type?))
                {
                    return new global::RetellAI.JsonConverters.ConversationNodeVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SubagentNodeVariant3Type))
                {
                    return new global::RetellAI.JsonConverters.SubagentNodeVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SubagentNodeVariant3Type?))
                {
                    return new global::RetellAI.JsonConverters.SubagentNodeVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CustomToolType))
                {
                    return new global::RetellAI.JsonConverters.CustomToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CustomToolType?))
                {
                    return new global::RetellAI.JsonConverters.CustomToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CustomToolMethod))
                {
                    return new global::RetellAI.JsonConverters.CustomToolMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CustomToolMethod?))
                {
                    return new global::RetellAI.JsonConverters.CustomToolMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CustomToolExecutionMessageType))
                {
                    return new global::RetellAI.JsonConverters.CustomToolExecutionMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CustomToolExecutionMessageType?))
                {
                    return new global::RetellAI.JsonConverters.CustomToolExecutionMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CustomToolParameterType))
                {
                    return new global::RetellAI.JsonConverters.CustomToolParameterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CustomToolParameterType?))
                {
                    return new global::RetellAI.JsonConverters.CustomToolParameterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CodeToolType))
                {
                    return new global::RetellAI.JsonConverters.CodeToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CodeToolType?))
                {
                    return new global::RetellAI.JsonConverters.CodeToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CodeToolExecutionMessageType))
                {
                    return new global::RetellAI.JsonConverters.CodeToolExecutionMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CodeToolExecutionMessageType?))
                {
                    return new global::RetellAI.JsonConverters.CodeToolExecutionMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DTMFUtteranceRole))
                {
                    return new global::RetellAI.JsonConverters.DTMFUtteranceRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DTMFUtteranceRole?))
                {
                    return new global::RetellAI.JsonConverters.DTMFUtteranceRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsUtteranceRole))
                {
                    return new global::RetellAI.JsonConverters.SmsUtteranceRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsUtteranceRole?))
                {
                    return new global::RetellAI.JsonConverters.SmsUtteranceRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.InjectedUtteranceRole))
                {
                    return new global::RetellAI.JsonConverters.InjectedUtteranceRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.InjectedUtteranceRole?))
                {
                    return new global::RetellAI.JsonConverters.InjectedUtteranceRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.StringFilterType))
                {
                    return new global::RetellAI.JsonConverters.StringFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.StringFilterType?))
                {
                    return new global::RetellAI.JsonConverters.StringFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.StringFilterOp))
                {
                    return new global::RetellAI.JsonConverters.StringFilterOpJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.StringFilterOp?))
                {
                    return new global::RetellAI.JsonConverters.StringFilterOpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.NumberFilterType))
                {
                    return new global::RetellAI.JsonConverters.NumberFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.NumberFilterType?))
                {
                    return new global::RetellAI.JsonConverters.NumberFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.NumberFilterOp))
                {
                    return new global::RetellAI.JsonConverters.NumberFilterOpJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.NumberFilterOp?))
                {
                    return new global::RetellAI.JsonConverters.NumberFilterOpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BooleanFilterType))
                {
                    return new global::RetellAI.JsonConverters.BooleanFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BooleanFilterType?))
                {
                    return new global::RetellAI.JsonConverters.BooleanFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BooleanFilterOp))
                {
                    return new global::RetellAI.JsonConverters.BooleanFilterOpJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BooleanFilterOp?))
                {
                    return new global::RetellAI.JsonConverters.BooleanFilterOpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RangeFilterType))
                {
                    return new global::RetellAI.JsonConverters.RangeFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RangeFilterType?))
                {
                    return new global::RetellAI.JsonConverters.RangeFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RangeFilterOp))
                {
                    return new global::RetellAI.JsonConverters.RangeFilterOpJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RangeFilterOp?))
                {
                    return new global::RetellAI.JsonConverters.RangeFilterOpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EnumFilterType))
                {
                    return new global::RetellAI.JsonConverters.EnumFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EnumFilterType?))
                {
                    return new global::RetellAI.JsonConverters.EnumFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EnumFilterOp))
                {
                    return new global::RetellAI.JsonConverters.EnumFilterOpJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EnumFilterOp?))
                {
                    return new global::RetellAI.JsonConverters.EnumFilterOpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PresentFilterType))
                {
                    return new global::RetellAI.JsonConverters.PresentFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PresentFilterType?))
                {
                    return new global::RetellAI.JsonConverters.PresentFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PresentFilterOp))
                {
                    return new global::RetellAI.JsonConverters.PresentFilterOpJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PresentFilterOp?))
                {
                    return new global::RetellAI.JsonConverters.PresentFilterOpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CallFilterCallStatusValueItem))
                {
                    return new global::RetellAI.JsonConverters.CallFilterCallStatusValueItemJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CallFilterCallStatusValueItem?))
                {
                    return new global::RetellAI.JsonConverters.CallFilterCallStatusValueItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CallFilterCallTypeValueItem))
                {
                    return new global::RetellAI.JsonConverters.CallFilterCallTypeValueItemJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CallFilterCallTypeValueItem?))
                {
                    return new global::RetellAI.JsonConverters.CallFilterCallTypeValueItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CallFilterDirectionValueItem))
                {
                    return new global::RetellAI.JsonConverters.CallFilterDirectionValueItemJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CallFilterDirectionValueItem?))
                {
                    return new global::RetellAI.JsonConverters.CallFilterDirectionValueItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CallFilterUserSentimentValueItem))
                {
                    return new global::RetellAI.JsonConverters.CallFilterUserSentimentValueItemJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CallFilterUserSentimentValueItem?))
                {
                    return new global::RetellAI.JsonConverters.CallFilterUserSentimentValueItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CallFilterDataStorageSettingValueItem))
                {
                    return new global::RetellAI.JsonConverters.CallFilterDataStorageSettingValueItemJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CallFilterDataStorageSettingValueItem?))
                {
                    return new global::RetellAI.JsonConverters.CallFilterDataStorageSettingValueItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatFilterChatStatusValueItem))
                {
                    return new global::RetellAI.JsonConverters.ChatFilterChatStatusValueItemJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatFilterChatStatusValueItem?))
                {
                    return new global::RetellAI.JsonConverters.ChatFilterChatStatusValueItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatFilterUserSentimentValueItem))
                {
                    return new global::RetellAI.JsonConverters.ChatFilterUserSentimentValueItemJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatFilterUserSentimentValueItem?))
                {
                    return new global::RetellAI.JsonConverters.ChatFilterUserSentimentValueItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListContactsRequestSortOrder))
                {
                    return new global::RetellAI.JsonConverters.ListContactsRequestSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListContactsRequestSortOrder?))
                {
                    return new global::RetellAI.JsonConverters.ListContactsRequestSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DayOfWeek))
                {
                    return new global::RetellAI.JsonConverters.DayOfWeekJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DayOfWeek?))
                {
                    return new global::RetellAI.JsonConverters.DayOfWeekNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DisconnectionReason5))
                {
                    return new global::RetellAI.JsonConverters.DisconnectionReason5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DisconnectionReason5?))
                {
                    return new global::RetellAI.JsonConverters.DisconnectionReason5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ElseEdgeVariant2TransitionConditionType))
                {
                    return new global::RetellAI.JsonConverters.ElseEdgeVariant2TransitionConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ElseEdgeVariant2TransitionConditionType?))
                {
                    return new global::RetellAI.JsonConverters.ElseEdgeVariant2TransitionConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ElseEdgeVariant2TransitionConditionPrompt))
                {
                    return new global::RetellAI.JsonConverters.ElseEdgeVariant2TransitionConditionPromptJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ElseEdgeVariant2TransitionConditionPrompt?))
                {
                    return new global::RetellAI.JsonConverters.ElseEdgeVariant2TransitionConditionPromptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EndCallToolType))
                {
                    return new global::RetellAI.JsonConverters.EndCallToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EndCallToolType?))
                {
                    return new global::RetellAI.JsonConverters.EndCallToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EndCallToolExecutionMessageType))
                {
                    return new global::RetellAI.JsonConverters.EndCallToolExecutionMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EndCallToolExecutionMessageType?))
                {
                    return new global::RetellAI.JsonConverters.EndCallToolExecutionMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EndNodeVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.EndNodeVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EndNodeVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.EndNodeVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EnumAnalysisDataType))
                {
                    return new global::RetellAI.JsonConverters.EnumAnalysisDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EnumAnalysisDataType?))
                {
                    return new global::RetellAI.JsonConverters.EnumAnalysisDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EquationConditionType))
                {
                    return new global::RetellAI.JsonConverters.EquationConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EquationConditionType?))
                {
                    return new global::RetellAI.JsonConverters.EquationConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EquationConditionOperator))
                {
                    return new global::RetellAI.JsonConverters.EquationConditionOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EquationConditionOperator?))
                {
                    return new global::RetellAI.JsonConverters.EquationConditionOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EquationOperator))
                {
                    return new global::RetellAI.JsonConverters.EquationOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EquationOperator?))
                {
                    return new global::RetellAI.JsonConverters.EquationOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ExtractDynamicVariableToolType))
                {
                    return new global::RetellAI.JsonConverters.ExtractDynamicVariableToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ExtractDynamicVariableToolType?))
                {
                    return new global::RetellAI.JsonConverters.ExtractDynamicVariableToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ExtractDynamicVariablesNodeVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.ExtractDynamicVariablesNodeVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ExtractDynamicVariablesNodeVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.ExtractDynamicVariablesNodeVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.FinetuneExampleUtteranceVariant1Role))
                {
                    return new global::RetellAI.JsonConverters.FinetuneExampleUtteranceVariant1RoleJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.FinetuneExampleUtteranceVariant1Role?))
                {
                    return new global::RetellAI.JsonConverters.FinetuneExampleUtteranceVariant1RoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.FinetuneExampleUtteranceVariant2Role))
                {
                    return new global::RetellAI.JsonConverters.FinetuneExampleUtteranceVariant2RoleJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.FinetuneExampleUtteranceVariant2Role?))
                {
                    return new global::RetellAI.JsonConverters.FinetuneExampleUtteranceVariant2RoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.FinetuneExampleUtteranceVariant3Role))
                {
                    return new global::RetellAI.JsonConverters.FinetuneExampleUtteranceVariant3RoleJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.FinetuneExampleUtteranceVariant3Role?))
                {
                    return new global::RetellAI.JsonConverters.FinetuneExampleUtteranceVariant3RoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.FunctionNodeVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.FunctionNodeVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.FunctionNodeVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.FunctionNodeVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.FunctionNodeVariant2ToolType))
                {
                    return new global::RetellAI.JsonConverters.FunctionNodeVariant2ToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.FunctionNodeVariant2ToolType?))
                {
                    return new global::RetellAI.JsonConverters.FunctionNodeVariant2ToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CodeNodeVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.CodeNodeVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CodeNodeVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.CodeNodeVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.KnowledgeBaseResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.KnowledgeBaseResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.KnowledgeBaseResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.KnowledgeBaseResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.KnowledgeBaseSourceDocumentType))
                {
                    return new global::RetellAI.JsonConverters.KnowledgeBaseSourceDocumentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.KnowledgeBaseSourceDocumentType?))
                {
                    return new global::RetellAI.JsonConverters.KnowledgeBaseSourceDocumentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.KnowledgeBaseSourceTextType))
                {
                    return new global::RetellAI.JsonConverters.KnowledgeBaseSourceTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.KnowledgeBaseSourceTextType?))
                {
                    return new global::RetellAI.JsonConverters.KnowledgeBaseSourceTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.KnowledgeBaseSourceUrlType))
                {
                    return new global::RetellAI.JsonConverters.KnowledgeBaseSourceUrlTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.KnowledgeBaseSourceUrlType?))
                {
                    return new global::RetellAI.JsonConverters.KnowledgeBaseSourceUrlTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.Language3))
                {
                    return new global::RetellAI.JsonConverters.Language3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.Language3?))
                {
                    return new global::RetellAI.JsonConverters.Language3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.LLMModel))
                {
                    return new global::RetellAI.JsonConverters.LLMModelJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.LLMModel?))
                {
                    return new global::RetellAI.JsonConverters.LLMModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.MCPNodeVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.MCPNodeVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.MCPNodeVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.MCPNodeVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.MCPToolType))
                {
                    return new global::RetellAI.JsonConverters.MCPToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.MCPToolType?))
                {
                    return new global::RetellAI.JsonConverters.MCPToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.MCPToolExecutionMessageType))
                {
                    return new global::RetellAI.JsonConverters.MCPToolExecutionMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.MCPToolExecutionMessageType?))
                {
                    return new global::RetellAI.JsonConverters.MCPToolExecutionMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.MessageBaseRole))
                {
                    return new global::RetellAI.JsonConverters.MessageBaseRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.MessageBaseRole?))
                {
                    return new global::RetellAI.JsonConverters.MessageBaseRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.InjectedMessageBaseRole))
                {
                    return new global::RetellAI.JsonConverters.InjectedMessageBaseRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.InjectedMessageBaseRole?))
                {
                    return new global::RetellAI.JsonConverters.InjectedMessageBaseRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsMessageBaseRole))
                {
                    return new global::RetellAI.JsonConverters.SmsMessageBaseRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsMessageBaseRole?))
                {
                    return new global::RetellAI.JsonConverters.SmsMessageBaseRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ModelChoiceCascadingType))
                {
                    return new global::RetellAI.JsonConverters.ModelChoiceCascadingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ModelChoiceCascadingType?))
                {
                    return new global::RetellAI.JsonConverters.ModelChoiceCascadingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.NaturalnessIssue))
                {
                    return new global::RetellAI.JsonConverters.NaturalnessIssueJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.NaturalnessIssue?))
                {
                    return new global::RetellAI.JsonConverters.NaturalnessIssueNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.NodeInstructionPromptType))
                {
                    return new global::RetellAI.JsonConverters.NodeInstructionPromptTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.NodeInstructionPromptType?))
                {
                    return new global::RetellAI.JsonConverters.NodeInstructionPromptTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.NodeInstructionStaticTextType))
                {
                    return new global::RetellAI.JsonConverters.NodeInstructionStaticTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.NodeInstructionStaticTextType?))
                {
                    return new global::RetellAI.JsonConverters.NodeInstructionStaticTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsInstructionTemplateType))
                {
                    return new global::RetellAI.JsonConverters.SmsInstructionTemplateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsInstructionTemplateType?))
                {
                    return new global::RetellAI.JsonConverters.SmsInstructionTemplateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsInstructionTemplateTemplate))
                {
                    return new global::RetellAI.JsonConverters.SmsInstructionTemplateTemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsInstructionTemplateTemplate?))
                {
                    return new global::RetellAI.JsonConverters.SmsInstructionTemplateTemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.NodeTransitionMessageBaseRole))
                {
                    return new global::RetellAI.JsonConverters.NodeTransitionMessageBaseRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.NodeTransitionMessageBaseRole?))
                {
                    return new global::RetellAI.JsonConverters.NodeTransitionMessageBaseRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.NodeTransitionMessageBaseTransitionType))
                {
                    return new global::RetellAI.JsonConverters.NodeTransitionMessageBaseTransitionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.NodeTransitionMessageBaseTransitionType?))
                {
                    return new global::RetellAI.JsonConverters.NodeTransitionMessageBaseTransitionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.NodeTransitionUtteranceRole))
                {
                    return new global::RetellAI.JsonConverters.NodeTransitionUtteranceRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.NodeTransitionUtteranceRole?))
                {
                    return new global::RetellAI.JsonConverters.NodeTransitionUtteranceRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.NodeTransitionUtteranceTransitionType))
                {
                    return new global::RetellAI.JsonConverters.NodeTransitionUtteranceTransitionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.NodeTransitionUtteranceTransitionType?))
                {
                    return new global::RetellAI.JsonConverters.NodeTransitionUtteranceTransitionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.NullableLLMModel))
                {
                    return new global::RetellAI.JsonConverters.NullableLLMModelJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.NullableLLMModel?))
                {
                    return new global::RetellAI.JsonConverters.NullableLLMModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.NumberAnalysisDataType))
                {
                    return new global::RetellAI.JsonConverters.NumberAnalysisDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.NumberAnalysisDataType?))
                {
                    return new global::RetellAI.JsonConverters.NumberAnalysisDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PresetAnalysisDataType))
                {
                    return new global::RetellAI.JsonConverters.PresetAnalysisDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PresetAnalysisDataType?))
                {
                    return new global::RetellAI.JsonConverters.PresetAnalysisDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PresetAnalysisDataName))
                {
                    return new global::RetellAI.JsonConverters.PresetAnalysisDataNameJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PresetAnalysisDataName?))
                {
                    return new global::RetellAI.JsonConverters.PresetAnalysisDataNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CallPresetAnalysisDataType))
                {
                    return new global::RetellAI.JsonConverters.CallPresetAnalysisDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CallPresetAnalysisDataType?))
                {
                    return new global::RetellAI.JsonConverters.CallPresetAnalysisDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CallPresetAnalysisDataName))
                {
                    return new global::RetellAI.JsonConverters.CallPresetAnalysisDataNameJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CallPresetAnalysisDataName?))
                {
                    return new global::RetellAI.JsonConverters.CallPresetAnalysisDataNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatPresetAnalysisDataType))
                {
                    return new global::RetellAI.JsonConverters.ChatPresetAnalysisDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatPresetAnalysisDataType?))
                {
                    return new global::RetellAI.JsonConverters.ChatPresetAnalysisDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatPresetAnalysisDataName))
                {
                    return new global::RetellAI.JsonConverters.ChatPresetAnalysisDataNameJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatPresetAnalysisDataName?))
                {
                    return new global::RetellAI.JsonConverters.ChatPresetAnalysisDataNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.OrganizationResponseVariant2EnterprisePlanStatus))
                {
                    return new global::RetellAI.JsonConverters.OrganizationResponseVariant2EnterprisePlanStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.OrganizationResponseVariant2EnterprisePlanStatus?))
                {
                    return new global::RetellAI.JsonConverters.OrganizationResponseVariant2EnterprisePlanStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PIIConfigMode))
                {
                    return new global::RetellAI.JsonConverters.PIIConfigModeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PIIConfigMode?))
                {
                    return new global::RetellAI.JsonConverters.PIIConfigModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PIIConfigCategorie))
                {
                    return new global::RetellAI.JsonConverters.PIIConfigCategorieJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PIIConfigCategorie?))
                {
                    return new global::RetellAI.JsonConverters.PIIConfigCategorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GuardrailConfigOutputTopic))
                {
                    return new global::RetellAI.JsonConverters.GuardrailConfigOutputTopicJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GuardrailConfigOutputTopic?))
                {
                    return new global::RetellAI.JsonConverters.GuardrailConfigOutputTopicNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GuardrailConfigInputTopic))
                {
                    return new global::RetellAI.JsonConverters.GuardrailConfigInputTopicJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GuardrailConfigInputTopic?))
                {
                    return new global::RetellAI.JsonConverters.GuardrailConfigInputTopicNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PerformanceMetricCriteriaOp))
                {
                    return new global::RetellAI.JsonConverters.PerformanceMetricCriteriaOpJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PerformanceMetricCriteriaOp?))
                {
                    return new global::RetellAI.JsonConverters.PerformanceMetricCriteriaOpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PhoneNumberResponsePhoneNumberType))
                {
                    return new global::RetellAI.JsonConverters.PhoneNumberResponsePhoneNumberTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PhoneNumberResponsePhoneNumberType?))
                {
                    return new global::RetellAI.JsonConverters.PhoneNumberResponsePhoneNumberTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PostCallAnalysisSetting))
                {
                    return new global::RetellAI.JsonConverters.PostCallAnalysisSettingJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PostCallAnalysisSetting?))
                {
                    return new global::RetellAI.JsonConverters.PostCallAnalysisSettingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PressDigitNodeVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.PressDigitNodeVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PressDigitNodeVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.PressDigitNodeVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PressDigitToolType))
                {
                    return new global::RetellAI.JsonConverters.PressDigitToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PressDigitToolType?))
                {
                    return new global::RetellAI.JsonConverters.PressDigitToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PromptConditionType))
                {
                    return new global::RetellAI.JsonConverters.PromptConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PromptConditionType?))
                {
                    return new global::RetellAI.JsonConverters.PromptConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.QaViewFilterScoreRangeType))
                {
                    return new global::RetellAI.JsonConverters.QaViewFilterScoreRangeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.QaViewFilterScoreRangeType?))
                {
                    return new global::RetellAI.JsonConverters.QaViewFilterScoreRangeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.QaViewFilterScoreRangeOp))
                {
                    return new global::RetellAI.JsonConverters.QaViewFilterScoreRangeOpJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.QaViewFilterScoreRangeOp?))
                {
                    return new global::RetellAI.JsonConverters.QaViewFilterScoreRangeOpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CohortQaListArgsSortKey))
                {
                    return new global::RetellAI.JsonConverters.CohortQaListArgsSortKeyJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CohortQaListArgsSortKey?))
                {
                    return new global::RetellAI.JsonConverters.CohortQaListArgsSortKeyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CohortQaListArgsOrder))
                {
                    return new global::RetellAI.JsonConverters.CohortQaListArgsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CohortQaListArgsOrder?))
                {
                    return new global::RetellAI.JsonConverters.CohortQaListArgsOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ResponseEngineConversationFlowType))
                {
                    return new global::RetellAI.JsonConverters.ResponseEngineConversationFlowTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ResponseEngineConversationFlowType?))
                {
                    return new global::RetellAI.JsonConverters.ResponseEngineConversationFlowTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ResponseEngineCustomLmType))
                {
                    return new global::RetellAI.JsonConverters.ResponseEngineCustomLmTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ResponseEngineCustomLmType?))
                {
                    return new global::RetellAI.JsonConverters.ResponseEngineCustomLmTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ResponseEngineRetellLmType))
                {
                    return new global::RetellAI.JsonConverters.ResponseEngineRetellLmTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ResponseEngineRetellLmType?))
                {
                    return new global::RetellAI.JsonConverters.ResponseEngineRetellLmTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RetellLlmOverrideS2sModel))
                {
                    return new global::RetellAI.JsonConverters.RetellLlmOverrideS2sModelJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RetellLlmOverrideS2sModel?))
                {
                    return new global::RetellAI.JsonConverters.RetellLlmOverrideS2sModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RetellLlmOverrideStartSpeaker))
                {
                    return new global::RetellAI.JsonConverters.RetellLlmOverrideStartSpeakerJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RetellLlmOverrideStartSpeaker?))
                {
                    return new global::RetellAI.JsonConverters.RetellLlmOverrideStartSpeakerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SendSMSToolType))
                {
                    return new global::RetellAI.JsonConverters.SendSMSToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SendSMSToolType?))
                {
                    return new global::RetellAI.JsonConverters.SendSMSToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SendSMSToolExecutionMessageType))
                {
                    return new global::RetellAI.JsonConverters.SendSMSToolExecutionMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SendSMSToolExecutionMessageType?))
                {
                    return new global::RetellAI.JsonConverters.SendSMSToolExecutionMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsSenderVariant1Type))
                {
                    return new global::RetellAI.JsonConverters.SmsSenderVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsSenderVariant1Type?))
                {
                    return new global::RetellAI.JsonConverters.SmsSenderVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsSenderVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.SmsSenderVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsSenderVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.SmsSenderVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsDestinationVariant1Type))
                {
                    return new global::RetellAI.JsonConverters.SmsDestinationVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsDestinationVariant1Type?))
                {
                    return new global::RetellAI.JsonConverters.SmsDestinationVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsDestinationVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.SmsDestinationVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsDestinationVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.SmsDestinationVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SentimentAnalysisDetailVariant1Sentiment))
                {
                    return new global::RetellAI.JsonConverters.SentimentAnalysisDetailVariant1SentimentJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SentimentAnalysisDetailVariant1Sentiment?))
                {
                    return new global::RetellAI.JsonConverters.SentimentAnalysisDetailVariant1SentimentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SentimentAnalysisDetailVariant2Sentiment))
                {
                    return new global::RetellAI.JsonConverters.SentimentAnalysisDetailVariant2SentimentJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SentimentAnalysisDetailVariant2Sentiment?))
                {
                    return new global::RetellAI.JsonConverters.SentimentAnalysisDetailVariant2SentimentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SkipResponseEdgeVariant2TransitionConditionType))
                {
                    return new global::RetellAI.JsonConverters.SkipResponseEdgeVariant2TransitionConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SkipResponseEdgeVariant2TransitionConditionType?))
                {
                    return new global::RetellAI.JsonConverters.SkipResponseEdgeVariant2TransitionConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SkipResponseEdgeVariant2TransitionConditionPrompt))
                {
                    return new global::RetellAI.JsonConverters.SkipResponseEdgeVariant2TransitionConditionPromptJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SkipResponseEdgeVariant2TransitionConditionPrompt?))
                {
                    return new global::RetellAI.JsonConverters.SkipResponseEdgeVariant2TransitionConditionPromptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlwaysEdgeVariant2TransitionConditionType))
                {
                    return new global::RetellAI.JsonConverters.AlwaysEdgeVariant2TransitionConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlwaysEdgeVariant2TransitionConditionType?))
                {
                    return new global::RetellAI.JsonConverters.AlwaysEdgeVariant2TransitionConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlwaysEdgeVariant2TransitionConditionPrompt))
                {
                    return new global::RetellAI.JsonConverters.AlwaysEdgeVariant2TransitionConditionPromptJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlwaysEdgeVariant2TransitionConditionPrompt?))
                {
                    return new global::RetellAI.JsonConverters.AlwaysEdgeVariant2TransitionConditionPromptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsContentInferredType))
                {
                    return new global::RetellAI.JsonConverters.SmsContentInferredTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsContentInferredType?))
                {
                    return new global::RetellAI.JsonConverters.SmsContentInferredTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsContentPredefinedType))
                {
                    return new global::RetellAI.JsonConverters.SmsContentPredefinedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsContentPredefinedType?))
                {
                    return new global::RetellAI.JsonConverters.SmsContentPredefinedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsContentTemplateType))
                {
                    return new global::RetellAI.JsonConverters.SmsContentTemplateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsContentTemplateType?))
                {
                    return new global::RetellAI.JsonConverters.SmsContentTemplateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsContentTemplateTemplate))
                {
                    return new global::RetellAI.JsonConverters.SmsContentTemplateTemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsContentTemplateTemplate?))
                {
                    return new global::RetellAI.JsonConverters.SmsContentTemplateTemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsFailedEdgeVariant2TransitionConditionType))
                {
                    return new global::RetellAI.JsonConverters.SmsFailedEdgeVariant2TransitionConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsFailedEdgeVariant2TransitionConditionType?))
                {
                    return new global::RetellAI.JsonConverters.SmsFailedEdgeVariant2TransitionConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsFailedEdgeVariant2TransitionConditionPrompt))
                {
                    return new global::RetellAI.JsonConverters.SmsFailedEdgeVariant2TransitionConditionPromptJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsFailedEdgeVariant2TransitionConditionPrompt?))
                {
                    return new global::RetellAI.JsonConverters.SmsFailedEdgeVariant2TransitionConditionPromptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsNodeVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.SmsNodeVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsNodeVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.SmsNodeVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionType))
                {
                    return new global::RetellAI.JsonConverters.SmsSuccessEdgeVariant2TransitionConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionType?))
                {
                    return new global::RetellAI.JsonConverters.SmsSuccessEdgeVariant2TransitionConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionPrompt))
                {
                    return new global::RetellAI.JsonConverters.SmsSuccessEdgeVariant2TransitionConditionPromptJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionPrompt?))
                {
                    return new global::RetellAI.JsonConverters.SmsSuccessEdgeVariant2TransitionConditionPromptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.StateTransitionMessageBaseRole))
                {
                    return new global::RetellAI.JsonConverters.StateTransitionMessageBaseRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.StateTransitionMessageBaseRole?))
                {
                    return new global::RetellAI.JsonConverters.StateTransitionMessageBaseRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.StringAnalysisDataType))
                {
                    return new global::RetellAI.JsonConverters.StringAnalysisDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.StringAnalysisDataType?))
                {
                    return new global::RetellAI.JsonConverters.StringAnalysisDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCaseBatchJobStatus))
                {
                    return new global::RetellAI.JsonConverters.TestCaseBatchJobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCaseBatchJobStatus?))
                {
                    return new global::RetellAI.JsonConverters.TestCaseBatchJobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCaseDefinitionVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.TestCaseDefinitionVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCaseDefinitionVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.TestCaseDefinitionVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCaseJobStatus))
                {
                    return new global::RetellAI.JsonConverters.TestCaseJobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCaseJobStatus?))
                {
                    return new global::RetellAI.JsonConverters.TestCaseJobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ToolMockInputMatchRuleVariant1Type))
                {
                    return new global::RetellAI.JsonConverters.ToolMockInputMatchRuleVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ToolMockInputMatchRuleVariant1Type?))
                {
                    return new global::RetellAI.JsonConverters.ToolMockInputMatchRuleVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ToolMockInputMatchRuleVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.ToolMockInputMatchRuleVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ToolMockInputMatchRuleVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.ToolMockInputMatchRuleVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ToolCallInvocationMessageBaseRole))
                {
                    return new global::RetellAI.JsonConverters.ToolCallInvocationMessageBaseRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ToolCallInvocationMessageBaseRole?))
                {
                    return new global::RetellAI.JsonConverters.ToolCallInvocationMessageBaseRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ToolCallInvocationUtteranceRole))
                {
                    return new global::RetellAI.JsonConverters.ToolCallInvocationUtteranceRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ToolCallInvocationUtteranceRole?))
                {
                    return new global::RetellAI.JsonConverters.ToolCallInvocationUtteranceRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ToolCallResultMessageBaseRole))
                {
                    return new global::RetellAI.JsonConverters.ToolCallResultMessageBaseRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ToolCallResultMessageBaseRole?))
                {
                    return new global::RetellAI.JsonConverters.ToolCallResultMessageBaseRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ToolCallResultUtteranceRole))
                {
                    return new global::RetellAI.JsonConverters.ToolCallResultUtteranceRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ToolCallResultUtteranceRole?))
                {
                    return new global::RetellAI.JsonConverters.ToolCallResultUtteranceRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ToolParameterType))
                {
                    return new global::RetellAI.JsonConverters.ToolParameterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ToolParameterType?))
                {
                    return new global::RetellAI.JsonConverters.ToolParameterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferCallNodeVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.TransferCallNodeVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferCallNodeVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.TransferCallNodeVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferCallToolType))
                {
                    return new global::RetellAI.JsonConverters.TransferCallToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferCallToolType?))
                {
                    return new global::RetellAI.JsonConverters.TransferCallToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferCallToolExecutionMessageType))
                {
                    return new global::RetellAI.JsonConverters.TransferCallToolExecutionMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferCallToolExecutionMessageType?))
                {
                    return new global::RetellAI.JsonConverters.TransferCallToolExecutionMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferDestinationInferredType))
                {
                    return new global::RetellAI.JsonConverters.TransferDestinationInferredTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferDestinationInferredType?))
                {
                    return new global::RetellAI.JsonConverters.TransferDestinationInferredTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferDestinationPredefinedType))
                {
                    return new global::RetellAI.JsonConverters.TransferDestinationPredefinedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferDestinationPredefinedType?))
                {
                    return new global::RetellAI.JsonConverters.TransferDestinationPredefinedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferFailedEdgeVariant2TransitionConditionType))
                {
                    return new global::RetellAI.JsonConverters.TransferFailedEdgeVariant2TransitionConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferFailedEdgeVariant2TransitionConditionType?))
                {
                    return new global::RetellAI.JsonConverters.TransferFailedEdgeVariant2TransitionConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferFailedEdgeVariant2TransitionConditionPrompt))
                {
                    return new global::RetellAI.JsonConverters.TransferFailedEdgeVariant2TransitionConditionPromptJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferFailedEdgeVariant2TransitionConditionPrompt?))
                {
                    return new global::RetellAI.JsonConverters.TransferFailedEdgeVariant2TransitionConditionPromptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferOptionAgenticWarmTransferType))
                {
                    return new global::RetellAI.JsonConverters.TransferOptionAgenticWarmTransferTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferOptionAgenticWarmTransferType?))
                {
                    return new global::RetellAI.JsonConverters.TransferOptionAgenticWarmTransferTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferOptionAgenticWarmTransferOnHoldMusic))
                {
                    return new global::RetellAI.JsonConverters.TransferOptionAgenticWarmTransferOnHoldMusicJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferOptionAgenticWarmTransferOnHoldMusic?))
                {
                    return new global::RetellAI.JsonConverters.TransferOptionAgenticWarmTransferOnHoldMusicNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeout))
                {
                    return new global::RetellAI.JsonConverters.TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeoutJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeout?))
                {
                    return new global::RetellAI.JsonConverters.TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeoutNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferOptionColdTransferType))
                {
                    return new global::RetellAI.JsonConverters.TransferOptionColdTransferTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferOptionColdTransferType?))
                {
                    return new global::RetellAI.JsonConverters.TransferOptionColdTransferTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferOptionColdTransferColdTransferMode))
                {
                    return new global::RetellAI.JsonConverters.TransferOptionColdTransferColdTransferModeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferOptionColdTransferColdTransferMode?))
                {
                    return new global::RetellAI.JsonConverters.TransferOptionColdTransferColdTransferModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferOptionWarmTransferType))
                {
                    return new global::RetellAI.JsonConverters.TransferOptionWarmTransferTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferOptionWarmTransferType?))
                {
                    return new global::RetellAI.JsonConverters.TransferOptionWarmTransferTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferOptionWarmTransferOnHoldMusic))
                {
                    return new global::RetellAI.JsonConverters.TransferOptionWarmTransferOnHoldMusicJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferOptionWarmTransferOnHoldMusic?))
                {
                    return new global::RetellAI.JsonConverters.TransferOptionWarmTransferOnHoldMusicNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UtteranceHallucinationHallucinationType))
                {
                    return new global::RetellAI.JsonConverters.UtteranceHallucinationHallucinationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UtteranceHallucinationHallucinationType?))
                {
                    return new global::RetellAI.JsonConverters.UtteranceHallucinationHallucinationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UtteranceRole))
                {
                    return new global::RetellAI.JsonConverters.UtteranceRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UtteranceRole?))
                {
                    return new global::RetellAI.JsonConverters.UtteranceRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V2CallBaseCallStatus))
                {
                    return new global::RetellAI.JsonConverters.V2CallBaseCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V2CallBaseCallStatus?))
                {
                    return new global::RetellAI.JsonConverters.V2CallBaseCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V2CallBaseDataStorageSetting))
                {
                    return new global::RetellAI.JsonConverters.V2CallBaseDataStorageSettingJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V2CallBaseDataStorageSetting?))
                {
                    return new global::RetellAI.JsonConverters.V2CallBaseDataStorageSettingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V3CallBaseCallStatus))
                {
                    return new global::RetellAI.JsonConverters.V3CallBaseCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V3CallBaseCallStatus?))
                {
                    return new global::RetellAI.JsonConverters.V3CallBaseCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V3CallBaseDataStorageSetting))
                {
                    return new global::RetellAI.JsonConverters.V3CallBaseDataStorageSettingJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V3CallBaseDataStorageSetting?))
                {
                    return new global::RetellAI.JsonConverters.V3CallBaseDataStorageSettingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V3PhoneCallResponseVariant1CallType))
                {
                    return new global::RetellAI.JsonConverters.V3PhoneCallResponseVariant1CallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V3PhoneCallResponseVariant1CallType?))
                {
                    return new global::RetellAI.JsonConverters.V3PhoneCallResponseVariant1CallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V3PhoneCallResponseVariant1Direction))
                {
                    return new global::RetellAI.JsonConverters.V3PhoneCallResponseVariant1DirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V3PhoneCallResponseVariant1Direction?))
                {
                    return new global::RetellAI.JsonConverters.V3PhoneCallResponseVariant1DirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V3WebCallResponseVariant1CallType))
                {
                    return new global::RetellAI.JsonConverters.V3WebCallResponseVariant1CallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V3WebCallResponseVariant1CallType?))
                {
                    return new global::RetellAI.JsonConverters.V3WebCallResponseVariant1CallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V3ListCallsRequestSortOrder))
                {
                    return new global::RetellAI.JsonConverters.V3ListCallsRequestSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V3ListCallsRequestSortOrder?))
                {
                    return new global::RetellAI.JsonConverters.V3ListCallsRequestSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V2PhoneCallResponseVariant1CallType))
                {
                    return new global::RetellAI.JsonConverters.V2PhoneCallResponseVariant1CallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V2PhoneCallResponseVariant1CallType?))
                {
                    return new global::RetellAI.JsonConverters.V2PhoneCallResponseVariant1CallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V2PhoneCallResponseVariant1Direction))
                {
                    return new global::RetellAI.JsonConverters.V2PhoneCallResponseVariant1DirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V2PhoneCallResponseVariant1Direction?))
                {
                    return new global::RetellAI.JsonConverters.V2PhoneCallResponseVariant1DirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V2WebCallResponseVariant1CallType))
                {
                    return new global::RetellAI.JsonConverters.V2WebCallResponseVariant1CallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V2WebCallResponseVariant1CallType?))
                {
                    return new global::RetellAI.JsonConverters.V2WebCallResponseVariant1CallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.VoiceResponseProvider))
                {
                    return new global::RetellAI.JsonConverters.VoiceResponseProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.VoiceResponseProvider?))
                {
                    return new global::RetellAI.JsonConverters.VoiceResponseProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.VoiceResponseGender))
                {
                    return new global::RetellAI.JsonConverters.VoiceResponseGenderJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.VoiceResponseGender?))
                {
                    return new global::RetellAI.JsonConverters.VoiceResponseGenderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.VoicemailActionBridgeTransferType))
                {
                    return new global::RetellAI.JsonConverters.VoicemailActionBridgeTransferTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.VoicemailActionBridgeTransferType?))
                {
                    return new global::RetellAI.JsonConverters.VoicemailActionBridgeTransferTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.VoicemailActionHangupType))
                {
                    return new global::RetellAI.JsonConverters.VoicemailActionHangupTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.VoicemailActionHangupType?))
                {
                    return new global::RetellAI.JsonConverters.VoicemailActionHangupTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.VoicemailActionPromptType))
                {
                    return new global::RetellAI.JsonConverters.VoicemailActionPromptTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.VoicemailActionPromptType?))
                {
                    return new global::RetellAI.JsonConverters.VoicemailActionPromptTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.VoicemailActionStaticTextType))
                {
                    return new global::RetellAI.JsonConverters.VoicemailActionStaticTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.VoicemailActionStaticTextType?))
                {
                    return new global::RetellAI.JsonConverters.VoicemailActionStaticTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.IvrActionHangupType))
                {
                    return new global::RetellAI.JsonConverters.IvrActionHangupTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.IvrActionHangupType?))
                {
                    return new global::RetellAI.JsonConverters.IvrActionHangupTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.WarmTransferPromptType))
                {
                    return new global::RetellAI.JsonConverters.WarmTransferPromptTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.WarmTransferPromptType?))
                {
                    return new global::RetellAI.JsonConverters.WarmTransferPromptTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.WarmTransferStaticMessageType))
                {
                    return new global::RetellAI.JsonConverters.WarmTransferStaticMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.WarmTransferStaticMessageType?))
                {
                    return new global::RetellAI.JsonConverters.WarmTransferStaticMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorOverageConfigVariant1Mode))
                {
                    return new global::RetellAI.JsonConverters.ConductorOverageConfigVariant1ModeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorOverageConfigVariant1Mode?))
                {
                    return new global::RetellAI.JsonConverters.ConductorOverageConfigVariant1ModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorOverageConfigVariant2Mode))
                {
                    return new global::RetellAI.JsonConverters.ConductorOverageConfigVariant2ModeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorOverageConfigVariant2Mode?))
                {
                    return new global::RetellAI.JsonConverters.ConductorOverageConfigVariant2ModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorOverageConfigVariant3Mode))
                {
                    return new global::RetellAI.JsonConverters.ConductorOverageConfigVariant3ModeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorOverageConfigVariant3Mode?))
                {
                    return new global::RetellAI.JsonConverters.ConductorOverageConfigVariant3ModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ContactCallType))
                {
                    return new global::RetellAI.JsonConverters.ContactCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ContactCallType?))
                {
                    return new global::RetellAI.JsonConverters.ContactCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ContactCallDirection))
                {
                    return new global::RetellAI.JsonConverters.ContactCallDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ContactCallDirection?))
                {
                    return new global::RetellAI.JsonConverters.ContactCallDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ContactCallSentiment))
                {
                    return new global::RetellAI.JsonConverters.ContactCallSentimentJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ContactCallSentiment?))
                {
                    return new global::RetellAI.JsonConverters.ContactCallSentimentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ContactChatType))
                {
                    return new global::RetellAI.JsonConverters.ContactChatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ContactChatType?))
                {
                    return new global::RetellAI.JsonConverters.ContactChatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ContactChatDirection))
                {
                    return new global::RetellAI.JsonConverters.ContactChatDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ContactChatDirection?))
                {
                    return new global::RetellAI.JsonConverters.ContactChatDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ContactChatSentiment))
                {
                    return new global::RetellAI.JsonConverters.ContactChatSentimentJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ContactChatSentiment?))
                {
                    return new global::RetellAI.JsonConverters.ContactChatSentimentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AppType))
                {
                    return new global::RetellAI.JsonConverters.AppTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AppType?))
                {
                    return new global::RetellAI.JsonConverters.AppTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AppConnectionStatus))
                {
                    return new global::RetellAI.JsonConverters.AppConnectionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AppConnectionStatus?))
                {
                    return new global::RetellAI.JsonConverters.AppConnectionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.OAuthConfigRequestType))
                {
                    return new global::RetellAI.JsonConverters.OAuthConfigRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.OAuthConfigRequestType?))
                {
                    return new global::RetellAI.JsonConverters.OAuthConfigRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ApiKeyAuthConfigRequestType))
                {
                    return new global::RetellAI.JsonConverters.ApiKeyAuthConfigRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ApiKeyAuthConfigRequestType?))
                {
                    return new global::RetellAI.JsonConverters.ApiKeyAuthConfigRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AccessTokenAuthConfigRequestType))
                {
                    return new global::RetellAI.JsonConverters.AccessTokenAuthConfigRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AccessTokenAuthConfigRequestType?))
                {
                    return new global::RetellAI.JsonConverters.AccessTokenAuthConfigRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BasicAuthConfigRequestType))
                {
                    return new global::RetellAI.JsonConverters.BasicAuthConfigRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BasicAuthConfigRequestType?))
                {
                    return new global::RetellAI.JsonConverters.BasicAuthConfigRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RefreshTokenAuthConfigRequestType))
                {
                    return new global::RetellAI.JsonConverters.RefreshTokenAuthConfigRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RefreshTokenAuthConfigRequestType?))
                {
                    return new global::RetellAI.JsonConverters.RefreshTokenAuthConfigRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.OAuthConfigResponseType))
                {
                    return new global::RetellAI.JsonConverters.OAuthConfigResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.OAuthConfigResponseType?))
                {
                    return new global::RetellAI.JsonConverters.OAuthConfigResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ApiKeyAuthConfigResponseType))
                {
                    return new global::RetellAI.JsonConverters.ApiKeyAuthConfigResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ApiKeyAuthConfigResponseType?))
                {
                    return new global::RetellAI.JsonConverters.ApiKeyAuthConfigResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AccessTokenAuthConfigResponseType))
                {
                    return new global::RetellAI.JsonConverters.AccessTokenAuthConfigResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AccessTokenAuthConfigResponseType?))
                {
                    return new global::RetellAI.JsonConverters.AccessTokenAuthConfigResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BasicAuthConfigResponseType))
                {
                    return new global::RetellAI.JsonConverters.BasicAuthConfigResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BasicAuthConfigResponseType?))
                {
                    return new global::RetellAI.JsonConverters.BasicAuthConfigResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RefreshTokenAuthConfigResponseType))
                {
                    return new global::RetellAI.JsonConverters.RefreshTokenAuthConfigResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RefreshTokenAuthConfigResponseType?))
                {
                    return new global::RetellAI.JsonConverters.RefreshTokenAuthConfigResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentAppUsageType))
                {
                    return new global::RetellAI.JsonConverters.AgentAppUsageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentAppUsageType?))
                {
                    return new global::RetellAI.JsonConverters.AgentAppUsageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.KnowledgeBaseAppUsageType))
                {
                    return new global::RetellAI.JsonConverters.KnowledgeBaseAppUsageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.KnowledgeBaseAppUsageType?))
                {
                    return new global::RetellAI.JsonConverters.KnowledgeBaseAppUsageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CRMCustomFieldSchemaType))
                {
                    return new global::RetellAI.JsonConverters.CRMCustomFieldSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CRMCustomFieldSchemaType?))
                {
                    return new global::RetellAI.JsonConverters.CRMCustomFieldSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CRMAnalysisDataMappingUpdateMode))
                {
                    return new global::RetellAI.JsonConverters.CRMAnalysisDataMappingUpdateModeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CRMAnalysisDataMappingUpdateMode?))
                {
                    return new global::RetellAI.JsonConverters.CRMAnalysisDataMappingUpdateModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.JobStatusStatus))
                {
                    return new global::RetellAI.JsonConverters.JobStatusStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.JobStatusStatus?))
                {
                    return new global::RetellAI.JsonConverters.JobStatusStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.JobStatusTriggeredBy))
                {
                    return new global::RetellAI.JsonConverters.JobStatusTriggeredByJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.JobStatusTriggeredBy?))
                {
                    return new global::RetellAI.JsonConverters.JobStatusTriggeredByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DashboardSource))
                {
                    return new global::RetellAI.JsonConverters.DashboardSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DashboardSource?))
                {
                    return new global::RetellAI.JsonConverters.DashboardSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartGroupItemVariant1Type))
                {
                    return new global::RetellAI.JsonConverters.ChartGroupItemVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartGroupItemVariant1Type?))
                {
                    return new global::RetellAI.JsonConverters.ChartGroupItemVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartGroupItemVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.ChartGroupItemVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartGroupItemVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.ChartGroupItemVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneNumberRequestNumberProvider))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneNumberRequestNumberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneNumberRequestNumberProvider?))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneNumberRequestNumberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneNumberRequestCountryCode))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneNumberRequestCountryCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneNumberRequestCountryCode?))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneNumberRequestCountryCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CloneVoiceRequestVoiceProvider))
                {
                    return new global::RetellAI.JsonConverters.CloneVoiceRequestVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CloneVoiceRequestVoiceProvider?))
                {
                    return new global::RetellAI.JsonConverters.CloneVoiceRequestVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AddCommunityVoiceRequestVoiceProvider))
                {
                    return new global::RetellAI.JsonConverters.AddCommunityVoiceRequestVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AddCommunityVoiceRequestVoiceProvider?))
                {
                    return new global::RetellAI.JsonConverters.AddCommunityVoiceRequestVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SearchCommunityVoiceRequestVoiceProvider))
                {
                    return new global::RetellAI.JsonConverters.SearchCommunityVoiceRequestVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SearchCommunityVoiceRequestVoiceProvider?))
                {
                    return new global::RetellAI.JsonConverters.SearchCommunityVoiceRequestVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateChatMetadataRequestDataStorageSetting))
                {
                    return new global::RetellAI.JsonConverters.UpdateChatMetadataRequestDataStorageSettingJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateChatMetadataRequestDataStorageSetting?))
                {
                    return new global::RetellAI.JsonConverters.UpdateChatMetadataRequestDataStorageSettingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RegisterPhoneCallRequestDirection))
                {
                    return new global::RetellAI.JsonConverters.RegisterPhoneCallRequestDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RegisterPhoneCallRequestDirection?))
                {
                    return new global::RetellAI.JsonConverters.RegisterPhoneCallRequestDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateCallMetadataRequestDataStorageSetting))
                {
                    return new global::RetellAI.JsonConverters.UpdateCallMetadataRequestDataStorageSettingJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateCallMetadataRequestDataStorageSetting?))
                {
                    return new global::RetellAI.JsonConverters.UpdateCallMetadataRequestDataStorageSettingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateLiveCallRequestFieldsToOverrideDataStorageSetting))
                {
                    return new global::RetellAI.JsonConverters.UpdateLiveCallRequestFieldsToOverrideDataStorageSettingJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateLiveCallRequestFieldsToOverrideDataStorageSetting?))
                {
                    return new global::RetellAI.JsonConverters.UpdateLiveCallRequestFieldsToOverrideDataStorageSettingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListTestCaseDefinitionsType))
                {
                    return new global::RetellAI.JsonConverters.ListTestCaseDefinitionsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListTestCaseDefinitionsType?))
                {
                    return new global::RetellAI.JsonConverters.ListTestCaseDefinitionsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListBatchTestsType))
                {
                    return new global::RetellAI.JsonConverters.ListBatchTestsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListBatchTestsType?))
                {
                    return new global::RetellAI.JsonConverters.ListBatchTestsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentVersionsSortOrder))
                {
                    return new global::RetellAI.JsonConverters.ListAgentVersionsSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentVersionsSortOrder?))
                {
                    return new global::RetellAI.JsonConverters.ListAgentVersionsSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentsSortOrder))
                {
                    return new global::RetellAI.JsonConverters.ListAgentsSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentsSortOrder?))
                {
                    return new global::RetellAI.JsonConverters.ListAgentsSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowComponentsSortOrder))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowComponentsSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowComponentsSortOrder?))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowComponentsSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowsSortOrder))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowsSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowsSortOrder?))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowsSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListPhoneNumbersSortOrder))
                {
                    return new global::RetellAI.JsonConverters.ListPhoneNumbersSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListPhoneNumbersSortOrder?))
                {
                    return new global::RetellAI.JsonConverters.ListPhoneNumbersSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListRetellLLMSortOrder))
                {
                    return new global::RetellAI.JsonConverters.ListRetellLLMSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListRetellLLMSortOrder?))
                {
                    return new global::RetellAI.JsonConverters.ListRetellLLMSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListExportRequestsSortOrder))
                {
                    return new global::RetellAI.JsonConverters.ListExportRequestsSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListExportRequestsSortOrder?))
                {
                    return new global::RetellAI.JsonConverters.ListExportRequestsSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAppsSortOrder))
                {
                    return new global::RetellAI.JsonConverters.ListAppsSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAppsSortOrder?))
                {
                    return new global::RetellAI.JsonConverters.ListAppsSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAppUsagesSortOrder))
                {
                    return new global::RetellAI.JsonConverters.ListAppUsagesSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAppUsagesSortOrder?))
                {
                    return new global::RetellAI.JsonConverters.ListAppUsagesSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAgentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateAgentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAgentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateAgentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAgentResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.CreateAgentResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAgentResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.CreateAgentResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAgentResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.CreateAgentResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAgentResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.CreateAgentResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAgentResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.CreateAgentResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAgentResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.CreateAgentResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateBatchCallResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateBatchCallResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateBatchCallResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateBatchCallResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateBatchCallResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.CreateBatchCallResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateBatchCallResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.CreateBatchCallResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateBatchCallResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.CreateBatchCallResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateBatchCallResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.CreateBatchCallResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateBatchCallResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.CreateBatchCallResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateBatchCallResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.CreateBatchCallResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateBatchTestResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateBatchTestResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateBatchTestResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateBatchTestResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateBatchTestResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.CreateBatchTestResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateBatchTestResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.CreateBatchTestResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateBatchTestResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.CreateBatchTestResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateBatchTestResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.CreateBatchTestResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateBatchTestResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.CreateBatchTestResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateBatchTestResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.CreateBatchTestResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateBatchTestResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.CreateBatchTestResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateBatchTestResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.CreateBatchTestResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetBatchTestResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetBatchTestResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetBatchTestResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetBatchTestResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetBatchTestResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetBatchTestResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetBatchTestResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetBatchTestResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetBatchTestResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.GetBatchTestResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetBatchTestResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.GetBatchTestResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetBatchTestResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.GetBatchTestResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetBatchTestResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.GetBatchTestResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetBatchTestResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.GetBatchTestResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetBatchTestResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.GetBatchTestResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListBatchTestsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListBatchTestsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListBatchTestsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListBatchTestsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListBatchTestsResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.ListBatchTestsResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListBatchTestsResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.ListBatchTestsResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListBatchTestsResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.ListBatchTestsResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListBatchTestsResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.ListBatchTestsResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListBatchTestsResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.ListBatchTestsResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListBatchTestsResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.ListBatchTestsResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetTestRunResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetTestRunResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetTestRunResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetTestRunResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetTestRunResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetTestRunResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetTestRunResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetTestRunResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetTestRunResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.GetTestRunResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetTestRunResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.GetTestRunResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetTestRunResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.GetTestRunResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetTestRunResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.GetTestRunResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetTestRunResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.GetTestRunResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetTestRunResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.GetTestRunResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListTestRunsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListTestRunsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListTestRunsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListTestRunsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListTestRunsResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.ListTestRunsResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListTestRunsResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.ListTestRunsResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListTestRunsResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.ListTestRunsResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListTestRunsResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.ListTestRunsResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListTestRunsResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.ListTestRunsResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListTestRunsResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.ListTestRunsResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListTestRunsResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.ListTestRunsResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListTestRunsResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.ListTestRunsResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatAgentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateChatAgentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatAgentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateChatAgentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatAgentResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.CreateChatAgentResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatAgentResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.CreateChatAgentResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatAgentResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.CreateChatAgentResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatAgentResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.CreateChatAgentResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatAgentResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.CreateChatAgentResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatAgentResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.CreateChatAgentResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus6))
                {
                    return new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus6JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus6?))
                {
                    return new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus6))
                {
                    return new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus6JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus6?))
                {
                    return new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateChatResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateChatResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.CreateChatResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.CreateChatResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.CreateChatResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.CreateChatResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.CreateChatResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.CreateChatResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.CreateChatResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.CreateChatResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus6))
                {
                    return new global::RetellAI.JsonConverters.CreateChatResponseStatus6JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus6?))
                {
                    return new global::RetellAI.JsonConverters.CreateChatResponseStatus6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateConversationFlowResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateConversationFlowResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateConversationFlowResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateConversationFlowResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateConversationFlowResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.CreateConversationFlowResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateConversationFlowResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.CreateConversationFlowResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateConversationFlowResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.CreateConversationFlowResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateConversationFlowResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.CreateConversationFlowResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateConversationFlowResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.CreateConversationFlowResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateConversationFlowResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.CreateConversationFlowResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateConversationFlowResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.CreateConversationFlowResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateConversationFlowResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.CreateConversationFlowResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneNumberResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneNumberResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneNumberResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneNumberResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneNumberResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneNumberResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneNumberResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneNumberResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneNumberResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneNumberResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneNumberResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneNumberResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateRetellLLMResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateRetellLLMResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateRetellLLMResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateRetellLLMResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateRetellLLMResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.CreateRetellLLMResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateRetellLLMResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.CreateRetellLLMResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateRetellLLMResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.CreateRetellLLMResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateRetellLLMResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.CreateRetellLLMResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateSmsChatResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateSmsChatResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.CreateSmsChatResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.CreateSmsChatResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.CreateSmsChatResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.CreateSmsChatResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.CreateSmsChatResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.CreateSmsChatResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.CreateSmsChatResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.CreateSmsChatResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus6))
                {
                    return new global::RetellAI.JsonConverters.CreateSmsChatResponseStatus6JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus6?))
                {
                    return new global::RetellAI.JsonConverters.CreateSmsChatResponseStatus6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAgentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteAgentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAgentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteAgentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAgentResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.DeleteAgentResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAgentResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.DeleteAgentResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAgentResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.DeleteAgentResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAgentResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.DeleteAgentResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAgentResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.DeleteAgentResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAgentResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.DeleteAgentResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteChatResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteChatResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteChatResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteChatResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteChatResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.DeleteChatResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteChatResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.DeleteChatResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteChatResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.DeleteChatResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteChatResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.DeleteChatResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteChatResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.DeleteChatResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteChatResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.DeleteChatResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteChatAgentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteChatAgentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteChatAgentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteChatAgentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteChatAgentResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.DeleteChatAgentResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteChatAgentResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.DeleteChatAgentResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteChatAgentResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.DeleteChatAgentResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteChatAgentResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.DeleteChatAgentResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteChatAgentResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.DeleteChatAgentResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteChatAgentResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.DeleteChatAgentResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteConversationFlowResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteConversationFlowResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteConversationFlowResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteConversationFlowResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteConversationFlowResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteConversationFlowResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteConversationFlowResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteConversationFlowResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteConversationFlowResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteConversationFlowResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeletePhoneNumberResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeletePhoneNumberResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeletePhoneNumberResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeletePhoneNumberResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeletePhoneNumberResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.DeletePhoneNumberResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeletePhoneNumberResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.DeletePhoneNumberResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeletePhoneNumberResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.DeletePhoneNumberResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeletePhoneNumberResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.DeletePhoneNumberResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteRetellLLMResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteRetellLLMResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteRetellLLMResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteRetellLLMResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteRetellLLMResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteRetellLLMResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteRetellLLMResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteRetellLLMResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EndChatResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.EndChatResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EndChatResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.EndChatResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EndChatResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.EndChatResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EndChatResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.EndChatResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EndChatResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.EndChatResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EndChatResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.EndChatResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EndChatResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.EndChatResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EndChatResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.EndChatResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListAgentVersionsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListAgentVersionsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.ListAgentVersionsResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.ListAgentVersionsResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.ListAgentVersionsResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.ListAgentVersionsResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.ListAgentVersionsResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.ListAgentVersionsResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.ListAgentVersionsResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.ListAgentVersionsResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus6))
                {
                    return new global::RetellAI.JsonConverters.ListAgentVersionsResponseStatus6JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus6?))
                {
                    return new global::RetellAI.JsonConverters.ListAgentVersionsResponseStatus6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAgentVersionsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetAgentVersionsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAgentVersionsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetAgentVersionsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAgentVersionsResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetAgentVersionsResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAgentVersionsResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetAgentVersionsResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAgentVersionsResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.GetAgentVersionsResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAgentVersionsResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.GetAgentVersionsResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAgentVersionsResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.GetAgentVersionsResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAgentVersionsResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.GetAgentVersionsResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAgentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetAgentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAgentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetAgentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAgentResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetAgentResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAgentResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetAgentResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAgentResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.GetAgentResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAgentResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.GetAgentResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAgentResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.GetAgentResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAgentResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.GetAgentResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatAgentVersionsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetChatAgentVersionsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatAgentVersionsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetChatAgentVersionsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatAgentVersionsResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetChatAgentVersionsResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatAgentVersionsResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetChatAgentVersionsResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatAgentVersionsResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.GetChatAgentVersionsResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatAgentVersionsResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.GetChatAgentVersionsResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatAgentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetChatAgentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatAgentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetChatAgentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatAgentResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetChatAgentResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatAgentResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetChatAgentResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatAgentResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.GetChatAgentResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatAgentResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.GetChatAgentResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatAgentResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.GetChatAgentResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatAgentResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.GetChatAgentResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetChatResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetChatResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetChatResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetChatResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.GetChatResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.GetChatResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.GetChatResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.GetChatResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConcurrencyResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetConcurrencyResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConcurrencyResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetConcurrencyResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConcurrencyResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetConcurrencyResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConcurrencyResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetConcurrencyResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetApiKeyInfoResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetApiKeyInfoResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetApiKeyInfoResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetApiKeyInfoResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetApiKeyInfoResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetApiKeyInfoResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetApiKeyInfoResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetApiKeyInfoResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConversationFlowComponentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConversationFlowComponentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConversationFlowComponentResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConversationFlowComponentResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConversationFlowComponentResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConversationFlowComponentResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConversationFlowComponentResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConversationFlowComponentResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConversationFlowResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetConversationFlowResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConversationFlowResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetConversationFlowResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConversationFlowResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetConversationFlowResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConversationFlowResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetConversationFlowResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConversationFlowResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.GetConversationFlowResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConversationFlowResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.GetConversationFlowResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConversationFlowResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.GetConversationFlowResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConversationFlowResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.GetConversationFlowResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConversationFlowResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.GetConversationFlowResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConversationFlowResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.GetConversationFlowResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetKnowledgeBaseResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetKnowledgeBaseResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetKnowledgeBaseResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetKnowledgeBaseResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetKnowledgeBaseResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetKnowledgeBaseResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetKnowledgeBaseResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetKnowledgeBaseResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetMCPToolsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetMCPToolsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetMCPToolsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetMCPToolsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetMCPToolsResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetMCPToolsResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetMCPToolsResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetMCPToolsResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetMCPToolsResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.GetMCPToolsResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetMCPToolsResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.GetMCPToolsResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetMCPToolsResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.GetMCPToolsResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetMCPToolsResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.GetMCPToolsResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetPhoneNumberResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetPhoneNumberResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetPhoneNumberResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetPhoneNumberResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetPhoneNumberResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetPhoneNumberResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetPhoneNumberResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetPhoneNumberResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetPhoneNumberResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.GetPhoneNumberResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetPhoneNumberResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.GetPhoneNumberResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetPhoneNumberResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.GetPhoneNumberResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetPhoneNumberResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.GetPhoneNumberResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetRetellLLMResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetRetellLLMResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetRetellLLMResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetRetellLLMResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetRetellLLMResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetRetellLLMResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetRetellLLMResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetRetellLLMResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetRetellLLMResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.GetRetellLLMResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetRetellLLMResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.GetRetellLLMResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetRetellLLMResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.GetRetellLLMResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetRetellLLMResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.GetRetellLLMResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetVoiceResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetVoiceResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetVoiceResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetVoiceResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetVoiceResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetVoiceResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetVoiceResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetVoiceResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetVoiceResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.GetVoiceResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetVoiceResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.GetVoiceResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetVoiceResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.GetVoiceResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetVoiceResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.GetVoiceResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CloneVoiceResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CloneVoiceResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CloneVoiceResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CloneVoiceResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CloneVoiceResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.CloneVoiceResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CloneVoiceResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.CloneVoiceResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CloneVoiceResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.CloneVoiceResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CloneVoiceResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.CloneVoiceResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CloneVoiceResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.CloneVoiceResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CloneVoiceResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.CloneVoiceResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CloneVoiceResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.CloneVoiceResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CloneVoiceResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.CloneVoiceResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AddCommunityVoiceResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AddCommunityVoiceResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AddCommunityVoiceResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AddCommunityVoiceResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AddCommunityVoiceResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AddCommunityVoiceResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AddCommunityVoiceResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AddCommunityVoiceResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SearchCommunityVoiceResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SearchCommunityVoiceResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SearchCommunityVoiceResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SearchCommunityVoiceResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SearchCommunityVoiceResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SearchCommunityVoiceResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SearchCommunityVoiceResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SearchCommunityVoiceResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ImportPhoneNumberResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ImportPhoneNumberResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ImportPhoneNumberResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ImportPhoneNumberResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ImportPhoneNumberResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.ImportPhoneNumberResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ImportPhoneNumberResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.ImportPhoneNumberResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ImportPhoneNumberResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.ImportPhoneNumberResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ImportPhoneNumberResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.ImportPhoneNumberResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListAgentsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListAgentsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentsResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.ListAgentsResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentsResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.ListAgentsResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentsResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.ListAgentsResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentsResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.ListAgentsResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentsResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.ListAgentsResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentsResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.ListAgentsResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListChatsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListChatsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListChatsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListChatsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListChatsResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.ListChatsResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListChatsResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.ListChatsResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListChatsResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.ListChatsResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListChatsResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.ListChatsResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListChatsResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.ListChatsResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListChatsResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.ListChatsResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowsResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowsResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowsResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowsResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowsResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowsResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowsResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowsResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowsResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowsResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowsResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowsResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowsResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowsResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowsResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowsResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListKnowledgeBasesResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListKnowledgeBasesResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListKnowledgeBasesResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListKnowledgeBasesResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListKnowledgeBasesResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.ListKnowledgeBasesResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListKnowledgeBasesResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.ListKnowledgeBasesResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListKnowledgeBasesResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.ListKnowledgeBasesResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListKnowledgeBasesResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.ListKnowledgeBasesResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListPhoneNumbersResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListPhoneNumbersResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListPhoneNumbersResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListPhoneNumbersResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListPhoneNumbersResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.ListPhoneNumbersResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListPhoneNumbersResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.ListPhoneNumbersResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListRetellLLMResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListRetellLLMResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListRetellLLMResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListRetellLLMResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListRetellLLMResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.ListRetellLLMResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListRetellLLMResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.ListRetellLLMResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListRetellLLMResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.ListRetellLLMResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListRetellLLMResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.ListRetellLLMResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListRetellLLMResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.ListRetellLLMResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListRetellLLMResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.ListRetellLLMResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListRetellLLMResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.ListRetellLLMResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListRetellLLMResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.ListRetellLLMResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListVoicesResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListVoicesResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListVoicesResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListVoicesResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListVoicesResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.ListVoicesResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListVoicesResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.ListVoicesResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAgentVersionResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateAgentVersionResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAgentVersionResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateAgentVersionResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAgentVersionResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAgentVersionResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAgentVersionResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAgentVersionResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAgentVersionResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAgentVersionResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAgentVersionResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAgentVersionResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PublishAgentVersionResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.PublishAgentVersionResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PublishAgentVersionResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.PublishAgentVersionResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PublishAgentVersionResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PublishAgentVersionResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PublishAgentVersionResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PublishAgentVersionResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PublishAgentVersionResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PublishAgentVersionResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PublishAgentVersionResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PublishAgentVersionResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAgentVersionResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAgentVersionResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAgentVersionResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAgentVersionResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAgentVersionResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAgentVersionResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAgentVersionResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAgentVersionResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAgentVersionResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAgentVersionResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.RerunCallAnalysisResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.RerunCallAnalysisResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.RerunCallAnalysisResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.RerunCallAnalysisResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.RerunCallAnalysisResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.RerunCallAnalysisResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.RerunCallAnalysisResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.RerunCallAnalysisResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.RerunCallAnalysisResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.RerunCallAnalysisResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus6))
                {
                    return new global::RetellAI.JsonConverters.RerunCallAnalysisResponseStatus6JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus6?))
                {
                    return new global::RetellAI.JsonConverters.RerunCallAnalysisResponseStatus6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus7))
                {
                    return new global::RetellAI.JsonConverters.RerunCallAnalysisResponseStatus7JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus7?))
                {
                    return new global::RetellAI.JsonConverters.RerunCallAnalysisResponseStatus7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.RerunChatAnalysisResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.RerunChatAnalysisResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.RerunChatAnalysisResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.RerunChatAnalysisResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.RerunChatAnalysisResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.RerunChatAnalysisResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.RerunChatAnalysisResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.RerunChatAnalysisResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.RerunChatAnalysisResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.RerunChatAnalysisResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus6))
                {
                    return new global::RetellAI.JsonConverters.RerunChatAnalysisResponseStatus6JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus6?))
                {
                    return new global::RetellAI.JsonConverters.RerunChatAnalysisResponseStatus6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus7))
                {
                    return new global::RetellAI.JsonConverters.RerunChatAnalysisResponseStatus7JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus7?))
                {
                    return new global::RetellAI.JsonConverters.RerunChatAnalysisResponseStatus7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAgentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateAgentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAgentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateAgentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAgentResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.UpdateAgentResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAgentResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.UpdateAgentResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAgentResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.UpdateAgentResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAgentResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.UpdateAgentResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAgentResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.UpdateAgentResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAgentResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.UpdateAgentResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAgentResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.UpdateAgentResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAgentResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.UpdateAgentResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateChatAgentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateChatAgentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateChatAgentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateChatAgentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateChatAgentResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateChatAgentResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateChatAgentResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateChatAgentResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateChatAgentResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateChatAgentResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateChatAgentResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateChatAgentResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateChatMetadataResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateChatMetadataResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateChatMetadataResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateChatMetadataResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateChatMetadataResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateChatMetadataResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateChatMetadataResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateChatMetadataResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus6))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus6JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus6?))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus6))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus6JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus6?))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdatePhoneNumberResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdatePhoneNumberResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdatePhoneNumberResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdatePhoneNumberResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdatePhoneNumberResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdatePhoneNumberResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdatePhoneNumberResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdatePhoneNumberResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateRetellLLMResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateRetellLLMResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateRetellLLMResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateRetellLLMResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateRetellLLMResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateRetellLLMResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateRetellLLMResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateRetellLLMResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateRetellLLMResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateRetellLLMResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus6))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus6JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus6?))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateWebCallResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateWebCallResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.CreateWebCallResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.CreateWebCallResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.CreateWebCallResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.CreateWebCallResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.CreateWebCallResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.CreateWebCallResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.CreateWebCallResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.CreateWebCallResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus6))
                {
                    return new global::RetellAI.JsonConverters.CreateWebCallResponseStatus6JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus6?))
                {
                    return new global::RetellAI.JsonConverters.CreateWebCallResponseStatus6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteCallResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteCallResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteCallResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteCallResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteCallResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.DeleteCallResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteCallResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.DeleteCallResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteCallResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.DeleteCallResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteCallResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.DeleteCallResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteCallResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.DeleteCallResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteCallResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.DeleteCallResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCallResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetCallResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCallResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetCallResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCallResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetCallResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCallResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetCallResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCallResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.GetCallResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCallResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.GetCallResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCallResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.GetCallResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCallResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.GetCallResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListCallsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListCallsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListCallsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListCallsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListCallsResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.ListCallsResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListCallsResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.ListCallsResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListCallsResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.ListCallsResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListCallsResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.ListCallsResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListCallsResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.ListCallsResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListCallsResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.ListCallsResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseItemChannel))
                {
                    return new global::RetellAI.JsonConverters.ListExportRequestsResponseItemChannelJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseItemChannel?))
                {
                    return new global::RetellAI.JsonConverters.ListExportRequestsResponseItemChannelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseItemStatus))
                {
                    return new global::RetellAI.JsonConverters.ListExportRequestsResponseItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseItemStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListExportRequestsResponseItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListExportRequestsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListExportRequestsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.ListExportRequestsResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.ListExportRequestsResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.ListExportRequestsResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.ListExportRequestsResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.ListExportRequestsResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.ListExportRequestsResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus6))
                {
                    return new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus6JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus6?))
                {
                    return new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateCallMetadataResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateCallMetadataResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateCallMetadataResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateCallMetadataResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateCallMetadataResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateCallMetadataResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateCallMetadataResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateCallMetadataResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateLiveCallResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateLiveCallResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateLiveCallResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateLiveCallResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateLiveCallResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.UpdateLiveCallResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateLiveCallResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.UpdateLiveCallResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateLiveCallResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.UpdateLiveCallResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateLiveCallResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.UpdateLiveCallResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateLiveCallResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.UpdateLiveCallResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateLiveCallResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.UpdateLiveCallResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateLiveCallResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.UpdateLiveCallResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateLiveCallResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.UpdateLiveCallResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.StopCallResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.StopCallResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.StopCallResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.StopCallResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.StopCallResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.StopCallResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.StopCallResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.StopCallResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.StopCallResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.StopCallResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.StopCallResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.StopCallResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.StopCallResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.StopCallResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.StopCallResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.StopCallResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateContactResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateContactResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateContactResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateContactResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateContactResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.CreateContactResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateContactResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.CreateContactResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateContactResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.CreateContactResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateContactResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.CreateContactResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateContactResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.CreateContactResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateContactResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.CreateContactResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetContactResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetContactResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetContactResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetContactResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetContactResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetContactResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetContactResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetContactResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetContactResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.GetContactResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetContactResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.GetContactResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetContactResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.GetContactResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetContactResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.GetContactResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetContactByPhoneResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetContactByPhoneResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetContactByPhoneResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetContactByPhoneResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetContactByPhoneResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetContactByPhoneResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetContactByPhoneResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetContactByPhoneResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetContactByPhoneResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.GetContactByPhoneResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetContactByPhoneResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.GetContactByPhoneResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetContactByPhoneResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.GetContactByPhoneResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetContactByPhoneResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.GetContactByPhoneResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetContactByPhoneResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.GetContactByPhoneResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetContactByPhoneResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.GetContactByPhoneResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateContactResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateContactResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateContactResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateContactResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateContactResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.UpdateContactResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateContactResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.UpdateContactResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateContactResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.UpdateContactResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateContactResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.UpdateContactResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateContactResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.UpdateContactResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateContactResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.UpdateContactResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateContactResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.UpdateContactResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateContactResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.UpdateContactResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteContactResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteContactResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteContactResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteContactResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteContactResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.DeleteContactResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteContactResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.DeleteContactResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteContactResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.DeleteContactResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteContactResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.DeleteContactResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteContactResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.DeleteContactResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteContactResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.DeleteContactResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteContactResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.DeleteContactResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteContactResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.DeleteContactResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListContactsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListContactsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListContactsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListContactsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListContactsResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.ListContactsResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListContactsResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.ListContactsResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListContactsResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.ListContactsResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListContactsResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.ListContactsResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListContactsResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.ListContactsResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListContactsResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.ListContactsResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListContactConversationsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListContactConversationsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListContactConversationsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListContactConversationsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListContactConversationsResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.ListContactConversationsResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListContactConversationsResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.ListContactConversationsResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListContactConversationsResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.ListContactConversationsResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListContactConversationsResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.ListContactConversationsResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListContactConversationsResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.ListContactConversationsResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListContactConversationsResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.ListContactConversationsResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAppResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateAppResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAppResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateAppResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAppResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.CreateAppResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAppResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.CreateAppResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAppResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.CreateAppResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAppResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.CreateAppResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAppResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.CreateAppResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAppResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.CreateAppResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAppResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetAppResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAppResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetAppResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAppResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetAppResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAppResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetAppResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAppResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.GetAppResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAppResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.GetAppResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAppResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.GetAppResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAppResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.GetAppResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAppResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateAppResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAppResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateAppResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAppResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.UpdateAppResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAppResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.UpdateAppResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAppResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.UpdateAppResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAppResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.UpdateAppResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAppResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.UpdateAppResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAppResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.UpdateAppResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAppResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.UpdateAppResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAppResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.UpdateAppResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAppResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteAppResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAppResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteAppResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAppResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.DeleteAppResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAppResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.DeleteAppResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAppResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.DeleteAppResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAppResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.DeleteAppResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAppResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.DeleteAppResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAppResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.DeleteAppResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAppResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.DeleteAppResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAppResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.DeleteAppResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAppsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListAppsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAppsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListAppsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAppsResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.ListAppsResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAppsResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.ListAppsResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAppsResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.ListAppsResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAppsResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.ListAppsResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAppUsagesResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListAppUsagesResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAppUsagesResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListAppUsagesResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAppUsagesResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.ListAppUsagesResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAppUsagesResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.ListAppUsagesResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAppUsagesResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.ListAppUsagesResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAppUsagesResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.ListAppUsagesResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAppUsagesResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.ListAppUsagesResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAppUsagesResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.ListAppUsagesResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestAppAuthResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.TestAppAuthResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestAppAuthResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.TestAppAuthResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestAppAuthResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.TestAppAuthResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestAppAuthResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.TestAppAuthResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestAppAuthResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.TestAppAuthResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestAppAuthResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.TestAppAuthResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestAppAuthResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.TestAppAuthResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestAppAuthResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.TestAppAuthResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCrmConfigResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetCrmConfigResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCrmConfigResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetCrmConfigResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCrmConfigResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetCrmConfigResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCrmConfigResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetCrmConfigResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCrmConfigResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.GetCrmConfigResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCrmConfigResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.GetCrmConfigResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateCrmConfigResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateCrmConfigResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateCrmConfigResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateCrmConfigResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateCrmConfigResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.UpdateCrmConfigResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateCrmConfigResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.UpdateCrmConfigResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateCrmConfigResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.UpdateCrmConfigResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateCrmConfigResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.UpdateCrmConfigResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateCrmConfigResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.UpdateCrmConfigResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateCrmConfigResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.UpdateCrmConfigResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateCrmConfigResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.UpdateCrmConfigResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateCrmConfigResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.UpdateCrmConfigResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RunSyncJobResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.RunSyncJobResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RunSyncJobResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.RunSyncJobResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RunSyncJobResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.RunSyncJobResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RunSyncJobResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.RunSyncJobResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RunSyncJobResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.RunSyncJobResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RunSyncJobResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.RunSyncJobResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RunSyncJobResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.RunSyncJobResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RunSyncJobResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.RunSyncJobResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetSyncJobStatusResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetSyncJobStatusResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetSyncJobStatusResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetSyncJobStatusResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetSyncJobStatusResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetSyncJobStatusResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetSyncJobStatusResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetSyncJobStatusResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetSyncJobStatusResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.GetSyncJobStatusResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetSyncJobStatusResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.GetSyncJobStatusResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.BackfillContactAnalysisDataResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.BackfillContactAnalysisDataResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.BackfillContactAnalysisDataResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.BackfillContactAnalysisDataResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.BackfillContactAnalysisDataResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.BackfillContactAnalysisDataResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.BackfillContactAnalysisDataResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.BackfillContactAnalysisDataResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetBackfillContactJobStatusResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetBackfillContactJobStatusResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetBackfillContactJobStatusResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetBackfillContactJobStatusResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetBackfillContactJobStatusResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetBackfillContactJobStatusResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetBackfillContactJobStatusResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetBackfillContactJobStatusResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetBackfillContactJobStatusResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.GetBackfillContactJobStatusResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetBackfillContactJobStatusResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.GetBackfillContactJobStatusResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetCrmSchemaResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetCrmSchemaResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus2))
                {
                    return new global::RetellAI.JsonConverters.GetCrmSchemaResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus2?))
                {
                    return new global::RetellAI.JsonConverters.GetCrmSchemaResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus3))
                {
                    return new global::RetellAI.JsonConverters.GetCrmSchemaResponseStatus3JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus3?))
                {
                    return new global::RetellAI.JsonConverters.GetCrmSchemaResponseStatus3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus4))
                {
                    return new global::RetellAI.JsonConverters.GetCrmSchemaResponseStatus4JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus4?))
                {
                    return new global::RetellAI.JsonConverters.GetCrmSchemaResponseStatus4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus5))
                {
                    return new global::RetellAI.JsonConverters.GetCrmSchemaResponseStatus5JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus5?))
                {
                    return new global::RetellAI.JsonConverters.GetCrmSchemaResponseStatus5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus6))
                {
                    return new global::RetellAI.JsonConverters.GetCrmSchemaResponseStatus6JsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus6?))
                {
                    return new global::RetellAI.JsonConverters.GetCrmSchemaResponseStatus6NullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[6];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new SourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),

                    3 => new SourceGenerationContextChunk3(new global::System.Text.Json.JsonSerializerOptions()),

                    4 => new SourceGenerationContextChunk4(new global::System.Text.Json.JsonSerializerOptions()),

                    5 => new SourceGenerationContextChunk5(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}