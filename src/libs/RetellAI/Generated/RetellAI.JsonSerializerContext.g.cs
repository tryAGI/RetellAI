
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableLLMModel), TypeInfoPropertyName = "NullableLLMModel_RetellAI_NullableLLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double?>), TypeInfoPropertyName = "IListDouble_System_Collections_Generic_IList_double")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>), TypeInfoPropertyName = "IListDouble_System_Collections_Generic_IList_double_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableBackupModelChoice), TypeInfoPropertyName = "NullableBackupModelChoice_RetellAI_NullableBackupModelChoice")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableS2SModel), TypeInfoPropertyName = "NullableS2SModel_RetellAI_NullableS2SModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.LLMModel?), TypeInfoPropertyName = "NullableLLMModel_RetellAI_LLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackupModelChoice?), TypeInfoPropertyName = "NullableBackupModelChoice_RetellAI_BackupModelChoice")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.S2SModel?), TypeInfoPropertyName = "NullableS2SModel_RetellAI_S2SModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double?>), TypeInfoPropertyName = "ListDouble_System_Collections_Generic_List_double")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>), TypeInfoPropertyName = "ListDouble_System_Collections_Generic_List_double_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PrivacyScope), TypeInfoPropertyName = "PrivacyScope2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.DisconnectionReason>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DisconnectionReason), TypeInfoPropertyName = "DisconnectionReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.CustomFieldFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomFieldFilter), TypeInfoPropertyName = "CustomFieldFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.StringFilter, object>), TypeInfoPropertyName = "AllOfStringFilterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StringFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterStatusCode>), TypeInfoPropertyName = "AllOfEnumFilterAlertFilterStatusCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertFilterStatusCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AlertFilterStatusCodeValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertFilterStatusCodeValueItem), TypeInfoPropertyName = "AlertFilterStatusCodeValueItem2")]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AlertFilterErrorCodeItem>))]
    #pragma warning restore CS0618
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRootTagUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRootResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::RetellAI.AgentRootTagState>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentRootRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentRootRequestTags))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.AgentRootTagUpdate, object>), TypeInfoPropertyName = "OneOfAgentRootTagUpdateObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentOverrideRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLlmOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactMemoryConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ResponseEngine), TypeInfoPropertyName = "ResponseEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestVoiceModel), TypeInfoPropertyName = "AgentRequestVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AgentRequestExpressiveEmotionTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestExpressiveEmotionTag), TypeInfoPropertyName = "AgentRequestExpressiveEmotionTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestAmbientSound), TypeInfoPropertyName = "AgentRequestAmbientSound2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.Language?, global::System.Collections.Generic.IList<global::RetellAI.Language>>), TypeInfoPropertyName = "OneOfLanguageIListLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Language), TypeInfoPropertyName = "Language2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.Language>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.PreSessionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PreSessionTool), TypeInfoPropertyName = "PreSessionTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.PostSessionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PostSessionTool), TypeInfoPropertyName = "PostSessionTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentVersionSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentResponse), TypeInfoPropertyName = "AgentResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentListFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.StringFilter, global::RetellAI.AgentListFilterChannel>), TypeInfoPropertyName = "AllOfStringFilterAgentListFilterChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentListFilterChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentListFilterChannelOp), TypeInfoPropertyName = "AgentListFilterChannelOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentListFilterChannelValue), TypeInfoPropertyName = "AgentListFilterChannelValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BooleanFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentListItemResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentListItemResponseChannel), TypeInfoPropertyName = "AgentListItemResponseChannel2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BatchCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallTimeWindow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BatchCallTask))]
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
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortFilterCallDurationFilter))]
    #pragma warning restore CS0618
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortFilterCallDurationFilterOp), TypeInfoPropertyName = "CohortFilterCallDurationFilterOp2")]
    #pragma warning restore CS0618
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EscalateChatNode), TypeInfoPropertyName = "EscalateChatNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferCallNode), TypeInfoPropertyName = "TransferCallNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PressDigitNode), TypeInfoPropertyName = "PressDigitNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsNode), TypeInfoPropertyName = "SmsNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ExtractDynamicVariablesNode), TypeInfoPropertyName = "ExtractDynamicVariablesNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MCPNode), TypeInfoPropertyName = "MCPNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentOverrideConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentOverrideConfigSttMode), TypeInfoPropertyName = "AgentOverrideConfigSttMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentOverrideConfigCustomSttConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ModelConfig), TypeInfoPropertyName = "ModelConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ModelChoice), TypeInfoPropertyName = "ModelChoice2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppToolType), TypeInfoPropertyName = "AppToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ToolParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OutputSelection), TypeInfoPropertyName = "OutputSelection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppToolExecutionMessageType), TypeInfoPropertyName = "AppToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OutputSelectionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OutputSelectionVariant1Mode), TypeInfoPropertyName = "OutputSelectionVariant1Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OutputSelectionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OutputSelectionVariant2Mode), TypeInfoPropertyName = "OutputSelectionVariant2Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool>), TypeInfoPropertyName = "OneOfAppToolCustomToolCodeTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PreSessionToolVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool, global::RetellAI.SendSMSTool>), TypeInfoPropertyName = "OneOfAppToolCustomToolCodeToolSendSMSTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SendSMSTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PostSessionToolVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EquationCondition))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterChatType>), TypeInfoPropertyName = "AllOfEnumFilterChatFilterChatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatFilterChatType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ChatFilterChatTypeValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatFilterChatTypeValueItem), TypeInfoPropertyName = "ChatFilterChatTypeValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterDirection>), TypeInfoPropertyName = "AllOfEnumFilterChatFilterDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatFilterDirection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ChatFilterDirectionValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatFilterDirectionValueItem), TypeInfoPropertyName = "ChatFilterDirectionValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterDataStorageSetting>), TypeInfoPropertyName = "AllOfEnumFilterChatFilterDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatFilterDataStorageSetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ChatFilterDataStorageSettingValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatFilterDataStorageSettingValueItem), TypeInfoPropertyName = "ChatFilterDataStorageSettingValueItem2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EquationConditionType), TypeInfoPropertyName = "EquationConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.Equation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Equation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EquationConditionOperator), TypeInfoPropertyName = "EquationConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EquationPromptCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EquationPromptConditionType), TypeInfoPropertyName = "EquationPromptConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EquationPromptConditionOperator), TypeInfoPropertyName = "EquationPromptConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PromptCondition))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<string, global::RetellAI.PromptCondition, global::RetellAI.EquationCondition, global::RetellAI.EquationPromptCondition>), TypeInfoPropertyName = "OneOfStringPromptConditionEquationConditionEquationPromptCondition2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseResponseRemainingIngestionQuota))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseEffectiveIngestionLimits))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MessageBaseCustomerDefinedMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MessageBaseRole), TypeInfoPropertyName = "MessageBaseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.InjectedMessageBaseRole), TypeInfoPropertyName = "InjectedMessageBaseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsMessageBaseRole), TypeInfoPropertyName = "SmsMessageBaseRole2")]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableLLMModel), TypeInfoPropertyName = "NullableLLMModel_RetellAI_NullableLLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double?>), TypeInfoPropertyName = "IListDouble_System_Collections_Generic_IList_double")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>), TypeInfoPropertyName = "IListDouble_System_Collections_Generic_IList_double_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableBackupModelChoice), TypeInfoPropertyName = "NullableBackupModelChoice_RetellAI_NullableBackupModelChoice")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableS2SModel), TypeInfoPropertyName = "NullableS2SModel_RetellAI_NullableS2SModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.LLMModel?), TypeInfoPropertyName = "NullableLLMModel_RetellAI_LLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackupModelChoice?), TypeInfoPropertyName = "NullableBackupModelChoice_RetellAI_BackupModelChoice")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.S2SModel?), TypeInfoPropertyName = "NullableS2SModel_RetellAI_S2SModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double?>), TypeInfoPropertyName = "ListDouble_System_Collections_Generic_List_double")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>), TypeInfoPropertyName = "ListDouble_System_Collections_Generic_List_double_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.PerformanceMetricCriteria, global::RetellAI.CustomMetricCriteria>), TypeInfoPropertyName = "OneOfPerformanceMetricCriteriaCustomMetricCriteria2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PerformanceMetricCriteria))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<double?, bool?, string>), TypeInfoPropertyName = "OneOfDoubleBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.UtteranceTranscriptionError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceTranscriptionError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Wer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.UtteranceTranscriptionErrorMieDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceTranscriptionErrorMieDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackupModelChoice), TypeInfoPropertyName = "BackupModelChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ModelChoiceCascading))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackupModelChoiceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ModelChoiceCascadingType), TypeInfoPropertyName = "ModelChoiceCascadingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.S2SModel), TypeInfoPropertyName = "S2SModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ModelChoiceS2S))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ModelChoiceS2SType), TypeInfoPropertyName = "ModelChoiceS2SType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ServiceTier), TypeInfoPropertyName = "ServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TextModelRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackupModelRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.S2SModelRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableBackupModelRef), TypeInfoPropertyName = "NullableBackupModelRef2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CascadingModelConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.S2SModelConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DuplexModelConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CascadingModelConfigType), TypeInfoPropertyName = "CascadingModelConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.S2SModelConfigType), TypeInfoPropertyName = "S2SModelConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DuplexModelRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DuplexModelRefModel), TypeInfoPropertyName = "DuplexModelRefModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DuplexModelConfigType), TypeInfoPropertyName = "DuplexModelConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeModelConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableNodeModelConfig), TypeInfoPropertyName = "NullableNodeModelConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NaturalnessIssue), TypeInfoPropertyName = "NaturalnessIssue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeBaseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeBaseCommonDisplayPosition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.PromptCondition, global::RetellAI.EquationCondition>), TypeInfoPropertyName = "OneOfPromptConditionEquationCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeInstructionPromptType), TypeInfoPropertyName = "NodeInstructionPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeInstructionStaticText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeInstructionStaticTextType), TypeInfoPropertyName = "NodeInstructionStaticTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsInstructionTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsInstructionTemplateType), TypeInfoPropertyName = "SmsInstructionTemplateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsInstructionTemplateTemplate), TypeInfoPropertyName = "SmsInstructionTemplateTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.CustomTool, global::RetellAI.AppTool>), TypeInfoPropertyName = "OneOfCustomToolAppTool2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OrganizationResponseVariant2EnterprisePlanStatus), TypeInfoPropertyName = "OrganizationResponseVariant2EnterprisePlanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PIIConfigMode), TypeInfoPropertyName = "PIIConfigMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.PIIConfigCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PIIConfigCategorie), TypeInfoPropertyName = "PIIConfigCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.GuardrailConfigOutputTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GuardrailConfigOutputTopic), TypeInfoPropertyName = "GuardrailConfigOutputTopic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.GuardrailConfigInputTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GuardrailConfigInputTopic), TypeInfoPropertyName = "GuardrailConfigInputTopic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.HandbookEntryConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.HandbookPrompts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.LegacyBooleanOrHandbookEntryConfig), TypeInfoPropertyName = "LegacyBooleanOrHandbookEntryConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PerformanceMetricCriteriaOp), TypeInfoPropertyName = "PerformanceMetricCriteriaOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberSpamStatus), TypeInfoPropertyName = "PhoneNumberSpamStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberListFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterSpamStatus>), TypeInfoPropertyName = "AllOfEnumFilterPhoneNumberListFilterSpamStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberListFilterSpamStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.PhoneNumberSpamStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.BooleanFilter, global::RetellAI.PhoneNumberListFilterSms>), TypeInfoPropertyName = "AllOfBooleanFilterPhoneNumberListFilterSms2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberListFilterSms))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberListFilterSmsValue), TypeInfoPropertyName = "PhoneNumberListFilterSmsValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.BooleanFilter, global::RetellAI.PhoneNumberListFilterVerifiedNumber>), TypeInfoPropertyName = "AllOfBooleanFilterPhoneNumberListFilterVerifiedNumber2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberListFilterVerifiedNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberListFilterVerifiedNumberValue), TypeInfoPropertyName = "PhoneNumberListFilterVerifiedNumberValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.BooleanFilter, global::RetellAI.PhoneNumberListFilterBrandedCall>), TypeInfoPropertyName = "AllOfBooleanFilterPhoneNumberListFilterBrandedCall2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberListFilterBrandedCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberListFilterBrandedCallValue), TypeInfoPropertyName = "PhoneNumberListFilterBrandedCallValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterPhoneNumberType>), TypeInfoPropertyName = "AllOfEnumFilterPhoneNumberListFilterPhoneNumberType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberListFilterPhoneNumberType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.PhoneNumberListFilterPhoneNumberTypeValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberListFilterPhoneNumberTypeValueItem), TypeInfoPropertyName = "PhoneNumberListFilterPhoneNumberTypeValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AllOf<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterInboundAgent>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterInboundAgent>), TypeInfoPropertyName = "AllOfAgentFilterPhoneNumberListFilterInboundAgent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberListFilterInboundAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterInboundAgentTags>), TypeInfoPropertyName = "AllOfEnumFilterPhoneNumberListFilterInboundAgentTags2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberListFilterInboundAgentTags))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AllOf<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterOutboundAgent>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterOutboundAgent>), TypeInfoPropertyName = "AllOfAgentFilterPhoneNumberListFilterOutboundAgent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberListFilterOutboundAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterOutboundAgentTags>), TypeInfoPropertyName = "AllOfEnumFilterPhoneNumberListFilterOutboundAgentTags2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberListFilterOutboundAgentTags))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberResponsePhoneNumberType), TypeInfoPropertyName = "PhoneNumberResponsePhoneNumberType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberResponseSpamStatus), TypeInfoPropertyName = "PhoneNumberResponseSpamStatus2")]
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
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.QaViewFilterScoreRange))]
    #pragma warning restore CS0618
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.QaViewFilterScoreRangeType), TypeInfoPropertyName = "QaViewFilterScoreRangeType2")]
    #pragma warning restore CS0618
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.QaViewFilterScoreRangeOp), TypeInfoPropertyName = "QaViewFilterScoreRangeOp2")]
    #pragma warning restore CS0618
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLlmOverrideStartSpeaker), TypeInfoPropertyName = "RetellLlmOverrideStartSpeaker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLlmRequestVariant2))]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.State>))]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.State))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ScoringCriteriaCustomCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ScoringCriteriaCustomCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.PerformanceMetricCriteria>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SendSMSToolType), TypeInfoPropertyName = "SendSMSToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SendSMSToolExecutionMessageType), TypeInfoPropertyName = "SendSMSToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsContent), TypeInfoPropertyName = "SmsContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AnyOf<global::RetellAI.SmsSender?, object>), TypeInfoPropertyName = "AnyOfSmsSenderObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSender), TypeInfoPropertyName = "SmsSender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AnyOf<global::RetellAI.SmsDestination?, object>), TypeInfoPropertyName = "AnyOfSmsDestinationObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsDestination), TypeInfoPropertyName = "SmsDestination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSenderSenderCurrentNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSenderSenderCurrentNumberType), TypeInfoPropertyName = "SmsSenderSenderCurrentNumberType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSenderSenderRetellLongCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSenderSenderRetellLongCodeType), TypeInfoPropertyName = "SmsSenderSenderRetellLongCodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsDestinationDestinationCustomerNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsDestinationDestinationCustomerNumberType), TypeInfoPropertyName = "SmsDestinationDestinationCustomerNumberType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsDestinationDestinationPhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsDestinationDestinationPhoneNumberType), TypeInfoPropertyName = "SmsDestinationDestinationPhoneNumberType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AllOf<global::RetellAI.TextUtterance, global::RetellAI.TestCaseInputTranscriptItem2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.TextUtterance, global::RetellAI.TestCaseInputTranscriptItem2>), TypeInfoPropertyName = "AllOfTextUtteranceTestCaseInputTranscriptItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TextUtterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseInputTranscriptItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseInputTranscriptItemRole), TypeInfoPropertyName = "TestCaseInputTranscriptItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseCallerInstructions), TypeInfoPropertyName = "TestCaseCallerInstructions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseCallerInstructionsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseCallerInstructionsVariant1Type), TypeInfoPropertyName = "TestCaseCallerInstructionsVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseCallerInstructionsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseCallerInstructionsVariant2Type), TypeInfoPropertyName = "TestCaseCallerInstructionsVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseEvalCriterion), TypeInfoPropertyName = "TestCaseEvalCriterion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseEvalCriterionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseEvalCriterionVariant1Type), TypeInfoPropertyName = "TestCaseEvalCriterionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseEvalCriterionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseEvalCriterionVariant2Type), TypeInfoPropertyName = "TestCaseEvalCriterionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCasePaidPerformanceMetric), TypeInfoPropertyName = "TestCasePaidPerformanceMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TextTestCasePerformanceMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TextTestCasePerformanceMetricsCustomToolError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TextTestCasePerformanceMetricsAgentHallucination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TextTestCasePerformanceMetricsNodeTransitionInaccuracy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TextTestCasePerformanceMetricsRagAccuracy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TextTestCasePerformanceMetricsToolCallInaccuracy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCasePerformanceMetrics), TypeInfoPropertyName = "AudioTestCasePerformanceMetrics2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCasePerformanceMetricsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCasePerformanceMetricsVariant2ToolLatency))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCasePerformanceMetricsVariant2Latency))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCasePerformanceMetricsVariant2Interruption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCasePerformanceMetricsVariant2TalkRatio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCasePerformanceMetricsVariant2Transcription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseAsrAudioSource), TypeInfoPropertyName = "TestCaseAsrAudioSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseAsrAudioSourceVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseAsrAudioSourceVariant1Type), TypeInfoPropertyName = "TestCaseAsrAudioSourceVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseAsrAudioSourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseAsrAudioSourceVariant2Type), TypeInfoPropertyName = "TestCaseAsrAudioSourceVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseDefinitionV3Base))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationTestCaseDefinitionV3Base), TypeInfoPropertyName = "ConversationTestCaseDefinitionV3Base2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationTestCaseDefinitionV3BaseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.TestCaseEvalCriterion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.TestCasePaidPerformanceMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TextTestCaseDefinitionV3Fields), TypeInfoPropertyName = "TextTestCaseDefinitionV3Fields2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TextTestCaseDefinitionV3Input), TypeInfoPropertyName = "TextTestCaseDefinitionV3Input2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TextTestCaseDefinitionV3InputVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TextTestCaseDefinitionV3InputVariant2Type), TypeInfoPropertyName = "TextTestCaseDefinitionV3InputVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCaseDefinitionV3Fields), TypeInfoPropertyName = "AudioTestCaseDefinitionV3Fields2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoise))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound), TypeInfoPropertyName = "AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCaseDefinitionV3Input), TypeInfoPropertyName = "AudioTestCaseDefinitionV3Input2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCaseDefinitionV3InputVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCaseDefinitionV3InputVariant2Type), TypeInfoPropertyName = "AudioTestCaseDefinitionV3InputVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AsrGroundTruthUtterance), TypeInfoPropertyName = "AsrGroundTruthUtterance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AsrGroundTruthUtteranceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AsrGroundTruthUtteranceVariant2Role), TypeInfoPropertyName = "AsrGroundTruthUtteranceVariant2Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AsrTestCaseDefinitionV3Fields), TypeInfoPropertyName = "AsrTestCaseDefinitionV3Fields2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AsrTestCaseDefinitionV3FieldsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AsrGroundTruthUtterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AsrTestCaseDefinitionV3Input), TypeInfoPropertyName = "AsrTestCaseDefinitionV3Input2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AsrTestCaseDefinitionV3InputVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AsrTestCaseDefinitionV3InputVariant2Type), TypeInfoPropertyName = "AsrTestCaseDefinitionV3InputVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseDefinitionV3Input), TypeInfoPropertyName = "TestCaseDefinitionV3Input2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.TextTestCaseDefinitionV3Input?, global::RetellAI.AudioTestCaseDefinitionV3Input?, global::RetellAI.AsrTestCaseDefinitionV3Input?>), TypeInfoPropertyName = "OneOfTextTestCaseDefinitionV3InputAudioTestCaseDefinitionV3InputAsrTestCaseDefinitionV3Input2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseDefinitionV3InputVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseDefinitionV3Metadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseDefinitionV3), TypeInfoPropertyName = "TestCaseDefinitionV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseJobV3Base))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseJobV3BaseStatus), TypeInfoPropertyName = "TestCaseJobV3BaseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationTestCaseJobV3Base), TypeInfoPropertyName = "ConversationTestCaseJobV3Base2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationTestCaseJobV3BaseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatus), TypeInfoPropertyName = "ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TextTestCaseJobV3), TypeInfoPropertyName = "TextTestCaseJobV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TextTestCaseJobV3Variant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TextTestCaseJobV3Variant2Type), TypeInfoPropertyName = "TextTestCaseJobV3Variant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCaseJobV3), TypeInfoPropertyName = "AudioTestCaseJobV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCaseJobV3Variant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCaseJobV3Variant2Type), TypeInfoPropertyName = "AudioTestCaseJobV3Variant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AsrTestCaseJobV3), TypeInfoPropertyName = "AsrTestCaseJobV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AsrTestCaseJobV3Variant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AsrTestCaseJobV3Variant2Type), TypeInfoPropertyName = "AsrTestCaseJobV3Variant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseJobV3), TypeInfoPropertyName = "TestCaseJobV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseBatchJobV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.TestCaseBatchJobV3TestCase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseBatchJobV3TestCase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseBatchJobV3Status), TypeInfoPropertyName = "TestCaseBatchJobV3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseBatchJobV3AiSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.TestCaseBatchJobV3AiSummaryFailureCase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseBatchJobV3AiSummaryFailureCase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.UtteranceToolCallAccuracy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceToolCallAccuracy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallInvocationMessageBaseRole), TypeInfoPropertyName = "ToolCallInvocationMessageBaseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallInvocationUtterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallInvocationUtteranceRole), TypeInfoPropertyName = "ToolCallInvocationUtteranceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallInvocationUtteranceMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackupModelUsed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallResultMessageBaseRole), TypeInfoPropertyName = "ToolCallResultMessageBaseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallResultUtterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallResultUtteranceRole), TypeInfoPropertyName = "ToolCallResultUtteranceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolParameterType), TypeInfoPropertyName = "ToolParameterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EscalateChatTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferCallTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EscalationDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EscalationDestinationType), TypeInfoPropertyName = "EscalationDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EscalationDestinationDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EscalationDestinationDestinationMethod), TypeInfoPropertyName = "EscalationDestinationDestinationMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EscalateChatToolType), TypeInfoPropertyName = "EscalateChatToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EscalationFailedEdge), TypeInfoPropertyName = "EscalationFailedEdge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EscalationFailedEdgeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EscalationFailedEdgeVariant2TransitionCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EscalationFailedEdgeVariant2TransitionConditionType), TypeInfoPropertyName = "EscalationFailedEdgeVariant2TransitionConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EscalationFailedEdgeVariant2TransitionConditionPrompt), TypeInfoPropertyName = "EscalationFailedEdgeVariant2TransitionConditionPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EscalateChatNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EscalateChatNodeVariant2Type), TypeInfoPropertyName = "EscalateChatNodeVariant2Type2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionColdTransferOnHoldMusic), TypeInfoPropertyName = "TransferOptionColdTransferOnHoldMusic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionWarmTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionWarmTransferType), TypeInfoPropertyName = "TransferOptionWarmTransferType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionWarmTransferOnHoldMusic), TypeInfoPropertyName = "TransferOptionWarmTransferOnHoldMusic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SpendBudgetCustomAlertRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateSpendBudgetRequest), TypeInfoPropertyName = "UpdateSpendBudgetRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateSpendBudgetRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateSpendBudgetRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.SpendBudgetCustomAlertRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UserFormRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceHallucinationHallucinationType), TypeInfoPropertyName = "UtteranceHallucinationHallucinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.NaturalnessIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceOrToolCall), TypeInfoPropertyName = "UtteranceOrToolCall2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Utterance), TypeInfoPropertyName = "Utterance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackupModelUsedReason), TypeInfoPropertyName = "BackupModelUsedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TextUtteranceRole), TypeInfoPropertyName = "TextUtteranceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceVariant2Metadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.UtteranceVariant2Word>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceVariant2Word))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallTransport), TypeInfoPropertyName = "CallTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.IceServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListenLiveCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.IceServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3CallResponse), TypeInfoPropertyName = "V3CallResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3WebCallResponse), TypeInfoPropertyName = "V3WebCallResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3PhoneCallResponse), TypeInfoPropertyName = "V3PhoneCallResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3CreateWebCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3CreateWebCallResponseTransport), TypeInfoPropertyName = "V3CreateWebCallResponseTransport2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormItemBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormFieldBase), TypeInfoPropertyName = "ConductorFormFieldBase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormFieldBaseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormTextBlock), TypeInfoPropertyName = "ConductorFormTextBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormTextBlockVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormTextBlockVariant2Kind), TypeInfoPropertyName = "ConductorFormTextBlockVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormChoiceField), TypeInfoPropertyName = "ConductorFormChoiceField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormChoiceFieldVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormChoiceFieldVariant2Kind), TypeInfoPropertyName = "ConductorFormChoiceFieldVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ConductorFormOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormChoiceFieldVariant2DefaultValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormSelectField), TypeInfoPropertyName = "ConductorFormSelectField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormSelectFieldVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormSelectFieldVariant2Kind), TypeInfoPropertyName = "ConductorFormSelectFieldVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormTextField), TypeInfoPropertyName = "ConductorFormTextField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormTextFieldVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormTextFieldVariant2Kind), TypeInfoPropertyName = "ConductorFormTextFieldVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormTextFieldVariant2Format), TypeInfoPropertyName = "ConductorFormTextFieldVariant2Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormTextareaField), TypeInfoPropertyName = "ConductorFormTextareaField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormTextareaFieldVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormTextareaFieldVariant2Kind), TypeInfoPropertyName = "ConductorFormTextareaFieldVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormNumberField), TypeInfoPropertyName = "ConductorFormNumberField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormNumberFieldVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormNumberFieldVariant2Kind), TypeInfoPropertyName = "ConductorFormNumberFieldVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormSwitchField), TypeInfoPropertyName = "ConductorFormSwitchField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormSwitchFieldVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormSwitchFieldVariant2Kind), TypeInfoPropertyName = "ConductorFormSwitchFieldVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormTimeField), TypeInfoPropertyName = "ConductorFormTimeField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormTimeFieldVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormTimeFieldVariant2Kind), TypeInfoPropertyName = "ConductorFormTimeFieldVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormTimeValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormDateRangeField), TypeInfoPropertyName = "ConductorFormDateRangeField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormDateRangeFieldVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormDateRangeFieldVariant2Kind), TypeInfoPropertyName = "ConductorFormDateRangeFieldVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormDateRangeValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormFileField), TypeInfoPropertyName = "ConductorFormFileField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormFileFieldVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormFileFieldVariant2Kind), TypeInfoPropertyName = "ConductorFormFileFieldVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ConductorFormFileFieldVariant2AcceptItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormFileFieldVariant2AcceptItem), TypeInfoPropertyName = "ConductorFormFileFieldVariant2AcceptItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormField), TypeInfoPropertyName = "ConductorFormField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormItem), TypeInfoPropertyName = "ConductorFormItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::RetellAI.ConductorFormItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ConductorFormItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorForm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ConductorFormStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Contact))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableLLMModel), TypeInfoPropertyName = "NullableLLMModel_RetellAI_NullableLLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double?>), TypeInfoPropertyName = "IListDouble_System_Collections_Generic_IList_double")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>), TypeInfoPropertyName = "IListDouble_System_Collections_Generic_IList_double_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableBackupModelChoice), TypeInfoPropertyName = "NullableBackupModelChoice_RetellAI_NullableBackupModelChoice")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableS2SModel), TypeInfoPropertyName = "NullableS2SModel_RetellAI_NullableS2SModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.LLMModel?), TypeInfoPropertyName = "NullableLLMModel_RetellAI_LLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackupModelChoice?), TypeInfoPropertyName = "NullableBackupModelChoice_RetellAI_BackupModelChoice")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.S2SModel?), TypeInfoPropertyName = "NullableS2SModel_RetellAI_S2SModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double?>), TypeInfoPropertyName = "ListDouble_System_Collections_Generic_List_double")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>), TypeInfoPropertyName = "ListDouble_System_Collections_Generic_List_double_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ContactTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactListResponse), TypeInfoPropertyName = "ContactListResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactListResponseVariant2))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactConversationListResponse), TypeInfoPropertyName = "ContactConversationListResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactConversationListResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ContactConversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppType), TypeInfoPropertyName = "AppType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppConnectionStatus), TypeInfoPropertyName = "AppConnectionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OAuthConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OAuthConfigRequestType), TypeInfoPropertyName = "OAuthConfigRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ApiKeyAuthConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ApiKeyAuthConfigRequestType), TypeInfoPropertyName = "ApiKeyAuthConfigRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BasicAuthConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BasicAuthConfigRequestType), TypeInfoPropertyName = "BasicAuthConfigRequestType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppResponseTenantType), TypeInfoPropertyName = "AppResponseTenantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppUsageResponse), TypeInfoPropertyName = "AppUsageResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentAppUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseAppUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleAppUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentAppUsageType), TypeInfoPropertyName = "AgentAppUsageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseAppUsageType), TypeInfoPropertyName = "KnowledgeBaseAppUsageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleAppUsageType), TypeInfoPropertyName = "AlertRuleAppUsageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppToolTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AppToolTemplate>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartGroupType), TypeInfoPropertyName = "ChartGroupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DashboardSource), TypeInfoPropertyName = "DashboardSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartGroupItem), TypeInfoPropertyName = "ChartGroupItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartGroupItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartGroupItemVariant1Type), TypeInfoPropertyName = "ChartGroupItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartGroupItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartGroupItemVariant2Type), TypeInfoPropertyName = "ChartGroupItemVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItem), TypeInfoPropertyName = "ChartShowItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemKeywordSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemKeywordSourceSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemKeywordSourceSourceType), TypeInfoPropertyName = "ChartShowItemKeywordSourceSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemKeywordSourceMeasurement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemKeywordSourceMeasurementType), TypeInfoPropertyName = "ChartShowItemKeywordSourceMeasurementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemNumericSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemNumericSourceSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemNumericSourceSourceType), TypeInfoPropertyName = "ChartShowItemNumericSourceSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemNumericSourceMeasurement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemNumericSourceMeasurementType), TypeInfoPropertyName = "ChartShowItemNumericSourceMeasurementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemCustomFieldSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemCustomFieldSourceSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemCustomFieldSourceSourceType), TypeInfoPropertyName = "ChartShowItemCustomFieldSourceSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemCustomFieldSourceSourceCast), TypeInfoPropertyName = "ChartShowItemCustomFieldSourceSourceCast2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemCustomFieldSourceMeasurement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemCustomFieldSourceMeasurementType), TypeInfoPropertyName = "ChartShowItemCustomFieldSourceMeasurementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemConcurrencySource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemConcurrencySourceSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemConcurrencySourceSourceType), TypeInfoPropertyName = "ChartShowItemConcurrencySourceSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemConcurrencySourceMeasurement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemConcurrencySourceMeasurementType), TypeInfoPropertyName = "ChartShowItemConcurrencySourceMeasurementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemCustomToolSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemCustomToolSourceSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemCustomToolSourceSourceType), TypeInfoPropertyName = "ChartShowItemCustomToolSourceSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemCustomToolSourceMeasurement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemCustomToolSourceMeasurementType), TypeInfoPropertyName = "ChartShowItemCustomToolSourceMeasurementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartTimeRange), TypeInfoPropertyName = "ChartTimeRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartTimeRangeVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartTimeRangeVariant1Type), TypeInfoPropertyName = "ChartTimeRangeVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartTimeRangeVariant1Window))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartTimeRangeVariant1WindowUnit), TypeInfoPropertyName = "ChartTimeRangeVariant1WindowUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartTimeRangeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartTimeRangeVariant2Type), TypeInfoPropertyName = "ChartTimeRangeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartTimeRangeVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartTimeRangeVariant3Type), TypeInfoPropertyName = "ChartTimeRangeVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartTimeRangeVariant3Unit), TypeInfoPropertyName = "ChartTimeRangeVariant3Unit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartTimeRangeVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartTimeRangeVariant4Type), TypeInfoPropertyName = "ChartTimeRangeVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartTimeRangeVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartTimeRangeVariant5Type), TypeInfoPropertyName = "ChartTimeRangeVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartGridSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartConfigType), TypeInfoPropertyName = "ChartConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ChartShowItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ChartGroupItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AnyOf<global::RetellAI.StoredCallFilter?, global::RetellAI.ChatFilter>), TypeInfoPropertyName = "AnyOfStoredCallFilterChatFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartConfigUnit), TypeInfoPropertyName = "ChartConfigUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartDefinition), TypeInfoPropertyName = "ChartDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartConfigWithId), TypeInfoPropertyName = "ChartConfigWithId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartsMap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartUpdate), TypeInfoPropertyName = "ChartUpdate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartUpdateVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartUpdateVariant2Size))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartUpdatesMap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.ChartUpdate?, object>), TypeInfoPropertyName = "OneOfChartUpdateObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DashboardUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.AgentRequest, global::RetellAI.CreateAgentRequest2>), TypeInfoPropertyName = "AllOfAgentRequestCreateAgentRequest22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.BatchCallTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.TestCaseDefinitionInput, object>), TypeInfoPropertyName = "AllOfTestCaseDefinitionInputObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.ChatAgentRequest, object>), TypeInfoPropertyName = "AllOfChatAgentRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ChatMessageInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAssetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberRequestNumberProvider), TypeInfoPropertyName = "CreatePhoneNumberRequestNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberRequestCountryCode), TypeInfoPropertyName = "CreatePhoneNumberRequestCountryCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.RecordChatMessageRequestVariant1, global::RetellAI.RecordChatMessageRequestVariant2>), TypeInfoPropertyName = "OneOfRecordChatMessageRequestVariant1RecordChatMessageRequestVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RecordChatMessageRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RecordChatMessageRequestVariant1Role), TypeInfoPropertyName = "RecordChatMessageRequestVariant1Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RecordChatMessageRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RecordChatMessageRequestVariant2Role), TypeInfoPropertyName = "RecordChatMessageRequestVariant2Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RecordChatMessageRequestVariant2Metadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceRequestVoiceProvider), TypeInfoPropertyName = "CloneVoiceRequestVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceRequestVoiceProvider), TypeInfoPropertyName = "AddCommunityVoiceRequestVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceRequestVoiceProvider), TypeInfoPropertyName = "SearchCommunityVoiceRequestVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ImportPhoneNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchPhoneNumbersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataRequestDataStorageSetting), TypeInfoPropertyName = "UpdateChatMetadataRequestDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TakeOverLiveCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallRequestDirection), TypeInfoPropertyName = "RegisterPhoneCallRequestDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataRequestDataStorageSetting), TypeInfoPropertyName = "UpdateCallMetadataRequestDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallRequestFieldsToOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallRequestFieldsToOverrideDataStorageSetting), TypeInfoPropertyName = "UpdateLiveCallRequestFieldsToOverrideDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallRequestCallControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateContactRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UploadContactImportFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateContactImportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateContactRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAppRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAppRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAppToolSchemaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCrmConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AllOf<global::RetellAI.ContactTag, global::RetellAI.UpdateCrmConfigRequestContactTag>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.ContactTag, global::RetellAI.UpdateCrmConfigRequestContactTag>), TypeInfoPropertyName = "AllOfContactTagUpdateCrmConfigRequestContactTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCrmConfigRequestContactTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackfillContactAnalysisDataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackfillContactAnalysisDataRequestBackfillCallFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsType), TypeInfoPropertyName = "ListTestCaseDefinitionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsType), TypeInfoPropertyName = "ListBatchTestsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsSortOrder), TypeInfoPropertyName = "ListAgentVersionsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsSortOrder), TypeInfoPropertyName = "ListAgentsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsSortOrder), TypeInfoPropertyName = "ListConversationFlowComponentsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsSortOrder), TypeInfoPropertyName = "ListConversationFlowsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersSortOrder), TypeInfoPropertyName = "ListPhoneNumbersSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchPhoneNumbersSortOrder), TypeInfoPropertyName = "SearchPhoneNumbersSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMSortOrder), TypeInfoPropertyName = "ListRetellLLMSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsSortOrder), TypeInfoPropertyName = "ListExportRequestsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppsSortOrder), TypeInfoPropertyName = "ListAppsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppUsagesSortOrder), TypeInfoPropertyName = "ListAppUsagesSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus), TypeInfoPropertyName = "AddKnowledgeBaseSourcesResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentResponseStatus), TypeInfoPropertyName = "CreateAgentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallResponseStatus), TypeInfoPropertyName = "CreateBatchCallResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponseStatus), TypeInfoPropertyName = "CreateBatchTestResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus), TypeInfoPropertyName = "CreateTestCaseDefinitionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus), TypeInfoPropertyName = "DeleteTestCaseDefinitionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus), TypeInfoPropertyName = "GetTestCaseDefinitionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListTestCaseDefinitionsResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListTestCaseDefinitionsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.TestCaseDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus), TypeInfoPropertyName = "ListTestCaseDefinitionsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus), TypeInfoPropertyName = "UpdateTestCaseDefinitionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponseStatus), TypeInfoPropertyName = "GetBatchTestResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListBatchTestsResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListBatchTestsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.TestCaseBatchJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponseStatus), TypeInfoPropertyName = "ListBatchTestsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponseStatus), TypeInfoPropertyName = "GetTestRunResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListTestRunsResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListTestRunsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.TestCaseJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponseStatus), TypeInfoPropertyName = "ListTestRunsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatAgentResponseStatus), TypeInfoPropertyName = "CreateChatAgentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus), TypeInfoPropertyName = "AgentPlaygroundCompletionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponseStatus), TypeInfoPropertyName = "CreateChatCompletionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponseStatus), TypeInfoPropertyName = "CreateChatResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus), TypeInfoPropertyName = "CreateConversationFlowComponentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponseStatus), TypeInfoPropertyName = "CreateConversationFlowResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAssetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAssetResponseStatus), TypeInfoPropertyName = "CreateAssetResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus), TypeInfoPropertyName = "CreateKnowledgeBaseResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberResponseStatus), TypeInfoPropertyName = "CreatePhoneNumberResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateRetellLLMResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateRetellLLMResponseStatus), TypeInfoPropertyName = "CreateRetellLLMResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponseStatus), TypeInfoPropertyName = "CreateSmsChatResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentResponseStatus), TypeInfoPropertyName = "DeleteAgentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatResponseStatus), TypeInfoPropertyName = "DeleteChatResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatAgentResponseStatus), TypeInfoPropertyName = "DeleteChatAgentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowComponentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus), TypeInfoPropertyName = "DeleteConversationFlowComponentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponseStatus), TypeInfoPropertyName = "DeleteConversationFlowResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus), TypeInfoPropertyName = "DeleteKnowledgeBaseSourceResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus), TypeInfoPropertyName = "DeleteKnowledgeBaseResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeletePhoneNumberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeletePhoneNumberResponseStatus), TypeInfoPropertyName = "DeletePhoneNumberResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteRetellLLMResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteRetellLLMResponseStatus), TypeInfoPropertyName = "DeleteRetellLLMResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndChatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndChatResponseStatus), TypeInfoPropertyName = "EndChatResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAgentVersionsResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListAgentVersionsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AgentVersionSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponseStatus), TypeInfoPropertyName = "ListAgentVersionsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentResponseStatus), TypeInfoPropertyName = "GetAgentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetHandbookPresetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetHandbookPresetsResponseStatus), TypeInfoPropertyName = "GetHandbookPresetsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentResponseStatus), TypeInfoPropertyName = "GetChatAgentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RecordChatMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RecordChatMessageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RecordChatMessageResponseStatus), TypeInfoPropertyName = "RecordChatMessageResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RecordChatMessageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RecordChatMessageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatResponseStatus), TypeInfoPropertyName = "GetChatResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConcurrencyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConcurrencyResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConcurrencyResponseStatus), TypeInfoPropertyName = "GetConcurrencyResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConcurrencyResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetApiKeyInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetApiKeyInfoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetApiKeyInfoResponseStatus), TypeInfoPropertyName = "GetApiKeyInfoResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetApiKeyInfoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowComponentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowComponentResponseStatus), TypeInfoPropertyName = "GetConversationFlowComponentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponseStatus), TypeInfoPropertyName = "GetConversationFlowResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetKnowledgeBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetKnowledgeBaseResponseStatus), TypeInfoPropertyName = "GetKnowledgeBaseResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.MCPToolDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetMCPToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetMCPToolsResponseStatus), TypeInfoPropertyName = "GetMCPToolsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetPhoneNumberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetPhoneNumberResponseStatus), TypeInfoPropertyName = "GetPhoneNumberResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetRetellLLMResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetRetellLLMResponseStatus), TypeInfoPropertyName = "GetRetellLLMResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetVoiceResponseStatus), TypeInfoPropertyName = "GetVoiceResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponseStatus), TypeInfoPropertyName = "CloneVoiceResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceResponseStatus), TypeInfoPropertyName = "AddCommunityVoiceResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.SearchCommunityVoiceResponseVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponseVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponseStatus), TypeInfoPropertyName = "SearchCommunityVoiceResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ImportPhoneNumberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ImportPhoneNumberResponseStatus), TypeInfoPropertyName = "ImportPhoneNumberResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAgentsResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListAgentsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AgentListItemResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponseStatus), TypeInfoPropertyName = "ListAgentsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListChatsResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListChatsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.V3ChatResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsResponseStatus), TypeInfoPropertyName = "ListChatsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowComponentsResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListConversationFlowComponentsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ConversationFlowComponentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus), TypeInfoPropertyName = "ListConversationFlowComponentsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowsResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListConversationFlowsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ConversationFlowResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponseStatus), TypeInfoPropertyName = "ListConversationFlowsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.KnowledgeBaseResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListKnowledgeBasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListKnowledgeBasesResponseStatus), TypeInfoPropertyName = "ListKnowledgeBasesResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListPhoneNumbersResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListPhoneNumbersResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.PhoneNumberResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersResponseStatus), TypeInfoPropertyName = "ListPhoneNumbersResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.SearchPhoneNumbersResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseSearchPhoneNumbersResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchPhoneNumbersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchPhoneNumbersResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchPhoneNumbersResponseStatus), TypeInfoPropertyName = "SearchPhoneNumbersResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchPhoneNumbersResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchPhoneNumbersResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchPhoneNumbersResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListRetellLLMResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListRetellLLMResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.RetellLLMResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponseStatus), TypeInfoPropertyName = "ListRetellLLMResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.VoiceResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListVoicesResponseStatus), TypeInfoPropertyName = "ListVoicesResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.AgentResponse?, global::RetellAI.ChatAgentResponse?>), TypeInfoPropertyName = "OneOfAgentResponseChatAgentResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentVersionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentVersionResponseStatus), TypeInfoPropertyName = "CreateAgentVersionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentVersionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentVersionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentVersionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentVersionResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentVersionResponseStatus), TypeInfoPropertyName = "PublishAgentVersionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentVersionResponseStatus), TypeInfoPropertyName = "DeleteAgentVersionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentRootResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentRootResponseStatus), TypeInfoPropertyName = "GetAgentRootResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentRootResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentRootResponseStatus), TypeInfoPropertyName = "UpdateAgentRootResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RefreshKnowledgeBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RefreshKnowledgeBaseResponseStatus), TypeInfoPropertyName = "RefreshKnowledgeBaseResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunCallAnalysisResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunCallAnalysisResponseStatus), TypeInfoPropertyName = "RerunCallAnalysisResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunChatAnalysisResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunChatAnalysisResponseStatus), TypeInfoPropertyName = "RerunChatAnalysisResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponseStatus), TypeInfoPropertyName = "UpdateAgentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RepairAgentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RepairAgentResponseStatus), TypeInfoPropertyName = "RepairAgentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RepairAgentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RepairAgentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RepairAgentResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RepairAgentResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponseStatus), TypeInfoPropertyName = "UpdateChatAgentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataResponseStatus), TypeInfoPropertyName = "UpdateChatMetadataResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus), TypeInfoPropertyName = "UpdateConversationFlowComponentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponseStatus), TypeInfoPropertyName = "UpdateConversationFlowResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberResponseStatus), TypeInfoPropertyName = "UpdatePhoneNumberResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponseStatus), TypeInfoPropertyName = "UpdateRetellLLMResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponseStatus), TypeInfoPropertyName = "CreatePhoneCallResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponseStatus), TypeInfoPropertyName = "CreateWebCallResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteCallResponseStatus), TypeInfoPropertyName = "DeleteCallResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCallResponseStatus), TypeInfoPropertyName = "GetCallResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListenLiveCallResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListenLiveCallResponseStatus), TypeInfoPropertyName = "ListenLiveCallResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListenLiveCallResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListenLiveCallResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListenLiveCallResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListenLiveCallResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TakeOverLiveCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TakeOverLiveCallResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TakeOverLiveCallResponseStatus), TypeInfoPropertyName = "TakeOverLiveCallResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TakeOverLiveCallResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TakeOverLiveCallResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TakeOverLiveCallResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TakeOverLiveCallResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TakeOverLiveCallResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListCallsResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListCallsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.V3CallResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponseStatus), TypeInfoPropertyName = "ListCallsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListExportRequestsResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListExportRequestsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponse2))]
    internal sealed partial class SourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableLLMModel), TypeInfoPropertyName = "NullableLLMModel_RetellAI_NullableLLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double?>), TypeInfoPropertyName = "IListDouble_System_Collections_Generic_IList_double")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>), TypeInfoPropertyName = "IListDouble_System_Collections_Generic_IList_double_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableBackupModelChoice), TypeInfoPropertyName = "NullableBackupModelChoice_RetellAI_NullableBackupModelChoice")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableS2SModel), TypeInfoPropertyName = "NullableS2SModel_RetellAI_NullableS2SModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.LLMModel?), TypeInfoPropertyName = "NullableLLMModel_RetellAI_LLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackupModelChoice?), TypeInfoPropertyName = "NullableBackupModelChoice_RetellAI_BackupModelChoice")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.S2SModel?), TypeInfoPropertyName = "NullableS2SModel_RetellAI_S2SModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double?>), TypeInfoPropertyName = "ListDouble_System_Collections_Generic_List_double")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>), TypeInfoPropertyName = "ListDouble_System_Collections_Generic_List_double_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ListExportRequestsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponseItemChannel), TypeInfoPropertyName = "ListExportRequestsResponseItemChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponseItemStatus), TypeInfoPropertyName = "ListExportRequestsResponseItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponseStatus), TypeInfoPropertyName = "ListExportRequestsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponseStatus), TypeInfoPropertyName = "RegisterPhoneCallResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponseStatus), TypeInfoPropertyName = "UpdateCallMetadataResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallResponseStatus), TypeInfoPropertyName = "UpdateLiveCallResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StopCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StopCallResponseStatus), TypeInfoPropertyName = "StopCallResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateContactResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateContactResponseStatus), TypeInfoPropertyName = "CreateContactResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UploadContactImportFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UploadContactImportFileResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UploadContactImportFileResponseStatus), TypeInfoPropertyName = "UploadContactImportFileResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UploadContactImportFileResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UploadContactImportFileResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UploadContactImportFileResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateContactImportResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateContactImportResponseStatus), TypeInfoPropertyName = "CreateContactImportResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactImportResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactImportResponseStatus), TypeInfoPropertyName = "GetContactImportResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactResponseStatus), TypeInfoPropertyName = "GetContactResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactByPhoneResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactByPhoneResponseStatus), TypeInfoPropertyName = "GetContactByPhoneResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateContactResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateContactResponseStatus), TypeInfoPropertyName = "UpdateContactResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteContactResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteContactResponseStatus), TypeInfoPropertyName = "DeleteContactResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactsResponseStatus), TypeInfoPropertyName = "ListContactsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactConversationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactConversationsResponseStatus), TypeInfoPropertyName = "ListContactConversationsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAppResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAppResponseStatus), TypeInfoPropertyName = "CreateAppResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAppResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAppResponseStatus), TypeInfoPropertyName = "GetAppResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAppResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAppResponseStatus), TypeInfoPropertyName = "UpdateAppResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAppResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAppResponseStatus), TypeInfoPropertyName = "DeleteAppResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppsResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListAppsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AppResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppsResponseStatus), TypeInfoPropertyName = "ListAppsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppUsagesResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListAppUsagesResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppUsagesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AppUsageResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppUsagesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppUsagesResponseStatus), TypeInfoPropertyName = "ListAppUsagesResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppUsagesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppUsagesResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppUsagesResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestAppAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestAppAuthResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestAppAuthResponseStatus), TypeInfoPropertyName = "TestAppAuthResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestAppAuthResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestAppAuthResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestAppAuthResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppTemplatesResponse2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListAppTemplatesResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppTemplatesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AppTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppTemplatesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppTemplatesResponseStatus), TypeInfoPropertyName = "ListAppTemplatesResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppTemplatesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppTemplatesResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAppToolSchemaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAppToolSchemaResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAppToolSchemaResponseStatus), TypeInfoPropertyName = "GetAppToolSchemaResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAppToolSchemaResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAppToolSchemaResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAppToolSchemaResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmConfigResponseStatus), TypeInfoPropertyName = "GetCrmConfigResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCrmConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCrmConfigResponseStatus), TypeInfoPropertyName = "UpdateCrmConfigResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RunSyncJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RunSyncJobResponseStatus), TypeInfoPropertyName = "RunSyncJobResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetSyncJobStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetSyncJobStatusResponseStatus), TypeInfoPropertyName = "GetSyncJobStatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackfillContactAnalysisDataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus), TypeInfoPropertyName = "BackfillContactAnalysisDataResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBackfillContactJobStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBackfillContactJobStatusResponseStatus), TypeInfoPropertyName = "GetBackfillContactJobStatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponseStatus), TypeInfoPropertyName = "GetCrmSchemaResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PrivacyScope?), TypeInfoPropertyName = "NullablePrivacyScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertMetricType?), TypeInfoPropertyName = "NullableAlertMetricType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AsrProvider?), TypeInfoPropertyName = "NullableAsrProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, object>?), TypeInfoPropertyName = "NullableAllOfEnumFilterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterDisconnectionReason>?), TypeInfoPropertyName = "NullableAllOfEnumFilterAlertFilterDisconnectionReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DisconnectionReason?), TypeInfoPropertyName = "NullableDisconnectionReason2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.AgentRootTagUpdate, object>?), TypeInfoPropertyName = "NullableOneOfAgentRootTagUpdateObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ResponseEngine?), TypeInfoPropertyName = "NullableResponseEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestVoiceModel?), TypeInfoPropertyName = "NullableAgentRequestVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestExpressiveEmotionTag?), TypeInfoPropertyName = "NullableAgentRequestExpressiveEmotionTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestAmbientSound?), TypeInfoPropertyName = "NullableAgentRequestAmbientSound2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.Language?, global::System.Collections.Generic.IList<global::RetellAI.Language>>?), TypeInfoPropertyName = "NullableOneOfLanguageIListLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Language?), TypeInfoPropertyName = "NullableLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestWebhookEvent?), TypeInfoPropertyName = "NullableAgentRequestWebhookEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestDataStorageSetting?), TypeInfoPropertyName = "NullableAgentRequestDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestPronunciationDictionaryItemAlphabet?), TypeInfoPropertyName = "NullableAgentRequestPronunciationDictionaryItemAlphabet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoicemailAction?), TypeInfoPropertyName = "NullableVoicemailAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PostCallAnalysisData?), TypeInfoPropertyName = "NullablePostCallAnalysisData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableLLMModel?), TypeInfoPropertyName = "NullableNullableLLMModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestSttMode?), TypeInfoPropertyName = "NullableAgentRequestSttMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestVocabSpecialization?), TypeInfoPropertyName = "NullableAgentRequestVocabSpecialization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestDenoisingMode?), TypeInfoPropertyName = "NullableAgentRequestDenoisingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PreSessionTool?), TypeInfoPropertyName = "NullablePreSessionTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PostSessionTool?), TypeInfoPropertyName = "NullablePostSessionTool2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortAggregatedResultGroupBy?), TypeInfoPropertyName = "NullableCohortAggregatedResultGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.AllOf<global::RetellAI.NumberFilter, global::RetellAI.CohortFilterStartTimestampVariant1>?, global::RetellAI.RangeFilter>?), TypeInfoPropertyName = "NullableOneOfAllOfNumberFilterCohortFilterStartTimestampVariant1RangeFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.NumberFilter, global::RetellAI.CohortFilterStartTimestampVariant1>?), TypeInfoPropertyName = "NullableAllOfNumberFilterCohortFilterStartTimestampVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortFilterStartTimestampVariant1Op?), TypeInfoPropertyName = "NullableCohortFilterStartTimestampVariant1Op2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CohortFilterDisconnectionReason>?), TypeInfoPropertyName = "NullableAllOfEnumFilterCohortFilterDisconnectionReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>?), TypeInfoPropertyName = "NullableOneOfNumberFilterRangeFilter2")]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortFilterCallDurationFilterOp?), TypeInfoPropertyName = "NullableCohortFilterCallDurationFilterOp2")]
    #pragma warning restore CS0618
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EscalateChatNode?), TypeInfoPropertyName = "NullableEscalateChatNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferCallNode?), TypeInfoPropertyName = "NullableTransferCallNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PressDigitNode?), TypeInfoPropertyName = "NullablePressDigitNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsNode?), TypeInfoPropertyName = "NullableSmsNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ExtractDynamicVariablesNode?), TypeInfoPropertyName = "NullableExtractDynamicVariablesNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MCPNode?), TypeInfoPropertyName = "NullableMCPNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentOverrideConfigSttMode?), TypeInfoPropertyName = "NullableAgentOverrideConfigSttMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ModelConfig?), TypeInfoPropertyName = "NullableModelConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableBackupModelChoice?), TypeInfoPropertyName = "NullableNullableBackupModelChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ModelChoice?), TypeInfoPropertyName = "NullableModelChoice2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppToolType?), TypeInfoPropertyName = "NullableAppToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OutputSelection?), TypeInfoPropertyName = "NullableOutputSelection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppToolExecutionMessageType?), TypeInfoPropertyName = "NullableAppToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OutputSelectionVariant1Mode?), TypeInfoPropertyName = "NullableOutputSelectionVariant1Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OutputSelectionVariant2Mode?), TypeInfoPropertyName = "NullableOutputSelectionVariant2Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool>?), TypeInfoPropertyName = "NullableOneOfAppToolCustomToolCodeTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool, global::RetellAI.SendSMSTool>?), TypeInfoPropertyName = "NullableOneOfAppToolCustomToolCodeToolSendSMSTool2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterChatType>?), TypeInfoPropertyName = "NullableAllOfEnumFilterChatFilterChatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatFilterChatTypeValueItem?), TypeInfoPropertyName = "NullableChatFilterChatTypeValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterDirection>?), TypeInfoPropertyName = "NullableAllOfEnumFilterChatFilterDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatFilterDirectionValueItem?), TypeInfoPropertyName = "NullableChatFilterDirectionValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterDataStorageSetting>?), TypeInfoPropertyName = "NullableAllOfEnumFilterChatFilterDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatFilterDataStorageSettingValueItem?), TypeInfoPropertyName = "NullableChatFilterDataStorageSettingValueItem2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EquationPromptConditionType?), TypeInfoPropertyName = "NullableEquationPromptConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EquationPromptConditionOperator?), TypeInfoPropertyName = "NullableEquationPromptConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EquationOperator?), TypeInfoPropertyName = "NullableEquationOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ExtractDynamicVariableToolType?), TypeInfoPropertyName = "NullableExtractDynamicVariableToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ExtractDynamicVariablesNodeVariant2Type?), TypeInfoPropertyName = "NullableExtractDynamicVariablesNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FinetuneExampleUtterance?), TypeInfoPropertyName = "NullableFinetuneExampleUtterance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FinetuneExampleUtteranceVariant1Role?), TypeInfoPropertyName = "NullableFinetuneExampleUtteranceVariant1Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FinetuneExampleUtteranceVariant2Role?), TypeInfoPropertyName = "NullableFinetuneExampleUtteranceVariant2Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FinetuneExampleUtteranceVariant3Role?), TypeInfoPropertyName = "NullableFinetuneExampleUtteranceVariant3Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FunctionNodeVariant2Type?), TypeInfoPropertyName = "NullableFunctionNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FunctionNodeVariant2ToolType?), TypeInfoPropertyName = "NullableFunctionNodeVariant2ToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CodeNodeVariant2Type?), TypeInfoPropertyName = "NullableCodeNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<string, global::RetellAI.PromptCondition, global::RetellAI.EquationCondition, global::RetellAI.EquationPromptCondition>?), TypeInfoPropertyName = "NullableOneOfStringPromptConditionEquationConditionEquationPromptCondition2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ModelChoiceS2SType?), TypeInfoPropertyName = "NullableModelChoiceS2SType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ServiceTier?), TypeInfoPropertyName = "NullableServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableBackupModelRef?), TypeInfoPropertyName = "NullableNullableBackupModelRef2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CascadingModelConfigType?), TypeInfoPropertyName = "NullableCascadingModelConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.S2SModelConfigType?), TypeInfoPropertyName = "NullableS2SModelConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DuplexModelRefModel?), TypeInfoPropertyName = "NullableDuplexModelRefModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DuplexModelConfigType?), TypeInfoPropertyName = "NullableDuplexModelConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableNodeModelConfig?), TypeInfoPropertyName = "NullableNullableNodeModelConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NaturalnessIssue?), TypeInfoPropertyName = "NullableNaturalnessIssue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.PromptCondition, global::RetellAI.EquationCondition>?), TypeInfoPropertyName = "NullableOneOfPromptConditionEquationCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeInstructionPromptType?), TypeInfoPropertyName = "NullableNodeInstructionPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeInstructionStaticTextType?), TypeInfoPropertyName = "NullableNodeInstructionStaticTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsInstructionTemplateType?), TypeInfoPropertyName = "NullableSmsInstructionTemplateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsInstructionTemplateTemplate?), TypeInfoPropertyName = "NullableSmsInstructionTemplateTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.CustomTool, global::RetellAI.AppTool>?), TypeInfoPropertyName = "NullableOneOfCustomToolAppTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionMessageBaseRole?), TypeInfoPropertyName = "NullableNodeTransitionMessageBaseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionMessageBaseTransitionType?), TypeInfoPropertyName = "NullableNodeTransitionMessageBaseTransitionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionUtteranceRole?), TypeInfoPropertyName = "NullableNodeTransitionUtteranceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionUtteranceTransitionType?), TypeInfoPropertyName = "NullableNodeTransitionUtteranceTransitionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableS2SModel?), TypeInfoPropertyName = "NullableNullableS2SModel2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.LegacyBooleanOrHandbookEntryConfig?), TypeInfoPropertyName = "NullableLegacyBooleanOrHandbookEntryConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PerformanceMetricCriteriaOp?), TypeInfoPropertyName = "NullablePerformanceMetricCriteriaOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberSpamStatus?), TypeInfoPropertyName = "NullablePhoneNumberSpamStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterSpamStatus>?), TypeInfoPropertyName = "NullableAllOfEnumFilterPhoneNumberListFilterSpamStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.BooleanFilter, global::RetellAI.PhoneNumberListFilterSms>?), TypeInfoPropertyName = "NullableAllOfBooleanFilterPhoneNumberListFilterSms2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberListFilterSmsValue?), TypeInfoPropertyName = "NullablePhoneNumberListFilterSmsValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.BooleanFilter, global::RetellAI.PhoneNumberListFilterVerifiedNumber>?), TypeInfoPropertyName = "NullableAllOfBooleanFilterPhoneNumberListFilterVerifiedNumber2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberListFilterVerifiedNumberValue?), TypeInfoPropertyName = "NullablePhoneNumberListFilterVerifiedNumberValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.BooleanFilter, global::RetellAI.PhoneNumberListFilterBrandedCall>?), TypeInfoPropertyName = "NullableAllOfBooleanFilterPhoneNumberListFilterBrandedCall2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberListFilterBrandedCallValue?), TypeInfoPropertyName = "NullablePhoneNumberListFilterBrandedCallValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterPhoneNumberType>?), TypeInfoPropertyName = "NullableAllOfEnumFilterPhoneNumberListFilterPhoneNumberType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberListFilterPhoneNumberTypeValueItem?), TypeInfoPropertyName = "NullablePhoneNumberListFilterPhoneNumberTypeValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterInboundAgent>?), TypeInfoPropertyName = "NullableAllOfAgentFilterPhoneNumberListFilterInboundAgent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterInboundAgentTags>?), TypeInfoPropertyName = "NullableAllOfEnumFilterPhoneNumberListFilterInboundAgentTags2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterOutboundAgent>?), TypeInfoPropertyName = "NullableAllOfAgentFilterPhoneNumberListFilterOutboundAgent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterOutboundAgentTags>?), TypeInfoPropertyName = "NullableAllOfEnumFilterPhoneNumberListFilterOutboundAgentTags2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberResponsePhoneNumberType?), TypeInfoPropertyName = "NullablePhoneNumberResponsePhoneNumberType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberResponseSpamStatus?), TypeInfoPropertyName = "NullablePhoneNumberResponseSpamStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PressDigitNodeVariant2Type?), TypeInfoPropertyName = "NullablePressDigitNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PressDigitToolType?), TypeInfoPropertyName = "NullablePressDigitToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PromptConditionType?), TypeInfoPropertyName = "NullablePromptConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.QaViewFilterDisconnectionReason>?), TypeInfoPropertyName = "NullableAllOfEnumFilterQaViewFilterDisconnectionReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<bool?, global::RetellAI.BooleanFilter>?), TypeInfoPropertyName = "NullableOneOfBooleanBooleanFilter2")]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.QaViewFilterScoreRangeType?), TypeInfoPropertyName = "NullableQaViewFilterScoreRangeType2")]
    #pragma warning restore CS0618
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.QaViewFilterScoreRangeOp?), TypeInfoPropertyName = "NullableQaViewFilterScoreRangeOp2")]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortQaListArgsSortKey?), TypeInfoPropertyName = "NullableCohortQaListArgsSortKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortQaListArgsOrder?), TypeInfoPropertyName = "NullableCohortQaListArgsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ResponseEngineConversationFlowType?), TypeInfoPropertyName = "NullableResponseEngineConversationFlowType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ResponseEngineCustomLmType?), TypeInfoPropertyName = "NullableResponseEngineCustomLmType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ResponseEngineRetellLmType?), TypeInfoPropertyName = "NullableResponseEngineRetellLmType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellResponseEngine?), TypeInfoPropertyName = "NullableRetellResponseEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLLMResponse?), TypeInfoPropertyName = "NullableRetellLLMResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLlmRequest?), TypeInfoPropertyName = "NullableRetellLlmRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLlmOverrideStartSpeaker?), TypeInfoPropertyName = "NullableRetellLlmOverrideStartSpeaker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SendSMSToolType?), TypeInfoPropertyName = "NullableSendSMSToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SendSMSToolExecutionMessageType?), TypeInfoPropertyName = "NullableSendSMSToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsContent?), TypeInfoPropertyName = "NullableSmsContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AnyOf<global::RetellAI.SmsSender?, object>?), TypeInfoPropertyName = "NullableAnyOfSmsSenderObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSender?), TypeInfoPropertyName = "NullableSmsSender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AnyOf<global::RetellAI.SmsDestination?, object>?), TypeInfoPropertyName = "NullableAnyOfSmsDestinationObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsDestination?), TypeInfoPropertyName = "NullableSmsDestination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSenderSenderCurrentNumberType?), TypeInfoPropertyName = "NullableSmsSenderSenderCurrentNumberType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSenderSenderRetellLongCodeType?), TypeInfoPropertyName = "NullableSmsSenderSenderRetellLongCodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsDestinationDestinationCustomerNumberType?), TypeInfoPropertyName = "NullableSmsDestinationDestinationCustomerNumberType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsDestinationDestinationPhoneNumberType?), TypeInfoPropertyName = "NullableSmsDestinationDestinationPhoneNumberType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.TextUtterance, global::RetellAI.TestCaseInputTranscriptItem2>?), TypeInfoPropertyName = "NullableAllOfTextUtteranceTestCaseInputTranscriptItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseInputTranscriptItemRole?), TypeInfoPropertyName = "NullableTestCaseInputTranscriptItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseCallerInstructions?), TypeInfoPropertyName = "NullableTestCaseCallerInstructions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseCallerInstructionsVariant1Type?), TypeInfoPropertyName = "NullableTestCaseCallerInstructionsVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseCallerInstructionsVariant2Type?), TypeInfoPropertyName = "NullableTestCaseCallerInstructionsVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseEvalCriterion?), TypeInfoPropertyName = "NullableTestCaseEvalCriterion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseEvalCriterionVariant1Type?), TypeInfoPropertyName = "NullableTestCaseEvalCriterionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseEvalCriterionVariant2Type?), TypeInfoPropertyName = "NullableTestCaseEvalCriterionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCasePaidPerformanceMetric?), TypeInfoPropertyName = "NullableTestCasePaidPerformanceMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCasePerformanceMetrics?), TypeInfoPropertyName = "NullableAudioTestCasePerformanceMetrics2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseAsrAudioSource?), TypeInfoPropertyName = "NullableTestCaseAsrAudioSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseAsrAudioSourceVariant1Type?), TypeInfoPropertyName = "NullableTestCaseAsrAudioSourceVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseAsrAudioSourceVariant2Type?), TypeInfoPropertyName = "NullableTestCaseAsrAudioSourceVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationTestCaseDefinitionV3Base?), TypeInfoPropertyName = "NullableConversationTestCaseDefinitionV3Base2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TextTestCaseDefinitionV3Fields?), TypeInfoPropertyName = "NullableTextTestCaseDefinitionV3Fields2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TextTestCaseDefinitionV3Input?), TypeInfoPropertyName = "NullableTextTestCaseDefinitionV3Input2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TextTestCaseDefinitionV3InputVariant2Type?), TypeInfoPropertyName = "NullableTextTestCaseDefinitionV3InputVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCaseDefinitionV3Fields?), TypeInfoPropertyName = "NullableAudioTestCaseDefinitionV3Fields2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound?), TypeInfoPropertyName = "NullableAudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCaseDefinitionV3Input?), TypeInfoPropertyName = "NullableAudioTestCaseDefinitionV3Input2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCaseDefinitionV3InputVariant2Type?), TypeInfoPropertyName = "NullableAudioTestCaseDefinitionV3InputVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AsrGroundTruthUtterance?), TypeInfoPropertyName = "NullableAsrGroundTruthUtterance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AsrGroundTruthUtteranceVariant2Role?), TypeInfoPropertyName = "NullableAsrGroundTruthUtteranceVariant2Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AsrTestCaseDefinitionV3Fields?), TypeInfoPropertyName = "NullableAsrTestCaseDefinitionV3Fields2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AsrTestCaseDefinitionV3Input?), TypeInfoPropertyName = "NullableAsrTestCaseDefinitionV3Input2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AsrTestCaseDefinitionV3InputVariant2Type?), TypeInfoPropertyName = "NullableAsrTestCaseDefinitionV3InputVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseDefinitionV3Input?), TypeInfoPropertyName = "NullableTestCaseDefinitionV3Input2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.TextTestCaseDefinitionV3Input?, global::RetellAI.AudioTestCaseDefinitionV3Input?, global::RetellAI.AsrTestCaseDefinitionV3Input?>?), TypeInfoPropertyName = "NullableOneOfTextTestCaseDefinitionV3InputAudioTestCaseDefinitionV3InputAsrTestCaseDefinitionV3Input2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseDefinitionV3?), TypeInfoPropertyName = "NullableTestCaseDefinitionV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseJobV3BaseStatus?), TypeInfoPropertyName = "NullableTestCaseJobV3BaseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationTestCaseJobV3Base?), TypeInfoPropertyName = "NullableConversationTestCaseJobV3Base2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatus?), TypeInfoPropertyName = "NullableConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TextTestCaseJobV3?), TypeInfoPropertyName = "NullableTextTestCaseJobV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TextTestCaseJobV3Variant2Type?), TypeInfoPropertyName = "NullableTextTestCaseJobV3Variant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCaseJobV3?), TypeInfoPropertyName = "NullableAudioTestCaseJobV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AudioTestCaseJobV3Variant2Type?), TypeInfoPropertyName = "NullableAudioTestCaseJobV3Variant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AsrTestCaseJobV3?), TypeInfoPropertyName = "NullableAsrTestCaseJobV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AsrTestCaseJobV3Variant2Type?), TypeInfoPropertyName = "NullableAsrTestCaseJobV3Variant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseJobV3?), TypeInfoPropertyName = "NullableTestCaseJobV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseBatchJobV3Status?), TypeInfoPropertyName = "NullableTestCaseBatchJobV3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallInvocationMessageBaseRole?), TypeInfoPropertyName = "NullableToolCallInvocationMessageBaseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallInvocationUtteranceRole?), TypeInfoPropertyName = "NullableToolCallInvocationUtteranceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallResultMessageBaseRole?), TypeInfoPropertyName = "NullableToolCallResultMessageBaseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallResultUtteranceRole?), TypeInfoPropertyName = "NullableToolCallResultUtteranceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolParameterType?), TypeInfoPropertyName = "NullableToolParameterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EscalationDestinationType?), TypeInfoPropertyName = "NullableEscalationDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EscalationDestinationDestinationMethod?), TypeInfoPropertyName = "NullableEscalationDestinationDestinationMethod2")]
    internal sealed partial class SourceGenerationContextChunk3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableLLMModel), TypeInfoPropertyName = "NullableLLMModel_RetellAI_NullableLLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double?>), TypeInfoPropertyName = "IListDouble_System_Collections_Generic_IList_double")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>), TypeInfoPropertyName = "IListDouble_System_Collections_Generic_IList_double_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableBackupModelChoice), TypeInfoPropertyName = "NullableBackupModelChoice_RetellAI_NullableBackupModelChoice")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableS2SModel), TypeInfoPropertyName = "NullableS2SModel_RetellAI_NullableS2SModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.LLMModel?), TypeInfoPropertyName = "NullableLLMModel_RetellAI_LLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackupModelChoice?), TypeInfoPropertyName = "NullableBackupModelChoice_RetellAI_BackupModelChoice")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.S2SModel?), TypeInfoPropertyName = "NullableS2SModel_RetellAI_S2SModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double?>), TypeInfoPropertyName = "ListDouble_System_Collections_Generic_List_double")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>), TypeInfoPropertyName = "ListDouble_System_Collections_Generic_List_double_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EscalateChatToolType?), TypeInfoPropertyName = "NullableEscalateChatToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EscalationFailedEdge?), TypeInfoPropertyName = "NullableEscalationFailedEdge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EscalationFailedEdgeVariant2TransitionConditionType?), TypeInfoPropertyName = "NullableEscalationFailedEdgeVariant2TransitionConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EscalationFailedEdgeVariant2TransitionConditionPrompt?), TypeInfoPropertyName = "NullableEscalationFailedEdgeVariant2TransitionConditionPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EscalateChatNodeVariant2Type?), TypeInfoPropertyName = "NullableEscalateChatNodeVariant2Type2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionColdTransferOnHoldMusic?), TypeInfoPropertyName = "NullableTransferOptionColdTransferOnHoldMusic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionWarmTransferType?), TypeInfoPropertyName = "NullableTransferOptionWarmTransferType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionWarmTransferOnHoldMusic?), TypeInfoPropertyName = "NullableTransferOptionWarmTransferOnHoldMusic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateSpendBudgetRequest?), TypeInfoPropertyName = "NullableUpdateSpendBudgetRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceHallucinationHallucinationType?), TypeInfoPropertyName = "NullableUtteranceHallucinationHallucinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceOrToolCall?), TypeInfoPropertyName = "NullableUtteranceOrToolCall2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Utterance?), TypeInfoPropertyName = "NullableUtterance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackupModelUsedReason?), TypeInfoPropertyName = "NullableBackupModelUsedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TextUtteranceRole?), TypeInfoPropertyName = "NullableTextUtteranceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2CallBaseCallStatus?), TypeInfoPropertyName = "NullableV2CallBaseCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2CallBaseDataStorageSetting?), TypeInfoPropertyName = "NullableV2CallBaseDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2CallResponse?), TypeInfoPropertyName = "NullableV2CallResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2WebCallResponse?), TypeInfoPropertyName = "NullableV2WebCallResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2PhoneCallResponse?), TypeInfoPropertyName = "NullableV2PhoneCallResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallTransport?), TypeInfoPropertyName = "NullableCallTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableOneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3CallResponse?), TypeInfoPropertyName = "NullableV3CallResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3WebCallResponse?), TypeInfoPropertyName = "NullableV3WebCallResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3PhoneCallResponse?), TypeInfoPropertyName = "NullableV3PhoneCallResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V3CreateWebCallResponseTransport?), TypeInfoPropertyName = "NullableV3CreateWebCallResponseTransport2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormFieldBase?), TypeInfoPropertyName = "NullableConductorFormFieldBase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormTextBlock?), TypeInfoPropertyName = "NullableConductorFormTextBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormTextBlockVariant2Kind?), TypeInfoPropertyName = "NullableConductorFormTextBlockVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormChoiceField?), TypeInfoPropertyName = "NullableConductorFormChoiceField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormChoiceFieldVariant2Kind?), TypeInfoPropertyName = "NullableConductorFormChoiceFieldVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormSelectField?), TypeInfoPropertyName = "NullableConductorFormSelectField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormSelectFieldVariant2Kind?), TypeInfoPropertyName = "NullableConductorFormSelectFieldVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormTextField?), TypeInfoPropertyName = "NullableConductorFormTextField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormTextFieldVariant2Kind?), TypeInfoPropertyName = "NullableConductorFormTextFieldVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormTextFieldVariant2Format?), TypeInfoPropertyName = "NullableConductorFormTextFieldVariant2Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormTextareaField?), TypeInfoPropertyName = "NullableConductorFormTextareaField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormTextareaFieldVariant2Kind?), TypeInfoPropertyName = "NullableConductorFormTextareaFieldVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormNumberField?), TypeInfoPropertyName = "NullableConductorFormNumberField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormNumberFieldVariant2Kind?), TypeInfoPropertyName = "NullableConductorFormNumberFieldVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormSwitchField?), TypeInfoPropertyName = "NullableConductorFormSwitchField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormSwitchFieldVariant2Kind?), TypeInfoPropertyName = "NullableConductorFormSwitchFieldVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormTimeField?), TypeInfoPropertyName = "NullableConductorFormTimeField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormTimeFieldVariant2Kind?), TypeInfoPropertyName = "NullableConductorFormTimeFieldVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormDateRangeField?), TypeInfoPropertyName = "NullableConductorFormDateRangeField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormDateRangeFieldVariant2Kind?), TypeInfoPropertyName = "NullableConductorFormDateRangeFieldVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormFileField?), TypeInfoPropertyName = "NullableConductorFormFileField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormFileFieldVariant2Kind?), TypeInfoPropertyName = "NullableConductorFormFileFieldVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormFileFieldVariant2AcceptItem?), TypeInfoPropertyName = "NullableConductorFormFileFieldVariant2AcceptItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormField?), TypeInfoPropertyName = "NullableConductorFormField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConductorFormItem?), TypeInfoPropertyName = "NullableConductorFormItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactListResponse?), TypeInfoPropertyName = "NullableContactListResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactConversation?), TypeInfoPropertyName = "NullableContactConversation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactCallType?), TypeInfoPropertyName = "NullableContactCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactCallDirection?), TypeInfoPropertyName = "NullableContactCallDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactCallSentiment?), TypeInfoPropertyName = "NullableContactCallSentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactChatType?), TypeInfoPropertyName = "NullableContactChatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactChatDirection?), TypeInfoPropertyName = "NullableContactChatDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactChatSentiment?), TypeInfoPropertyName = "NullableContactChatSentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ContactConversationListResponse?), TypeInfoPropertyName = "NullableContactConversationListResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppType?), TypeInfoPropertyName = "NullableAppType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppConnectionStatus?), TypeInfoPropertyName = "NullableAppConnectionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OAuthConfigRequestType?), TypeInfoPropertyName = "NullableOAuthConfigRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ApiKeyAuthConfigRequestType?), TypeInfoPropertyName = "NullableApiKeyAuthConfigRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BasicAuthConfigRequestType?), TypeInfoPropertyName = "NullableBasicAuthConfigRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AuthConfigRequest?), TypeInfoPropertyName = "NullableAuthConfigRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OAuthConfigResponseType?), TypeInfoPropertyName = "NullableOAuthConfigResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ApiKeyAuthConfigResponseType?), TypeInfoPropertyName = "NullableApiKeyAuthConfigResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AccessTokenAuthConfigResponseType?), TypeInfoPropertyName = "NullableAccessTokenAuthConfigResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BasicAuthConfigResponseType?), TypeInfoPropertyName = "NullableBasicAuthConfigResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RefreshTokenAuthConfigResponseType?), TypeInfoPropertyName = "NullableRefreshTokenAuthConfigResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppAuthConfigResponse?), TypeInfoPropertyName = "NullableAppAuthConfigResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppResponseTenantType?), TypeInfoPropertyName = "NullableAppResponseTenantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AppUsageResponse?), TypeInfoPropertyName = "NullableAppUsageResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentAppUsageType?), TypeInfoPropertyName = "NullableAgentAppUsageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseAppUsageType?), TypeInfoPropertyName = "NullableKnowledgeBaseAppUsageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleAppUsageType?), TypeInfoPropertyName = "NullableAlertRuleAppUsageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CRMCustomFieldSchemaType?), TypeInfoPropertyName = "NullableCRMCustomFieldSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CRMAnalysisDataMappingUpdateMode?), TypeInfoPropertyName = "NullableCRMAnalysisDataMappingUpdateMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.JobStatusStatus?), TypeInfoPropertyName = "NullableJobStatusStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.JobStatusTriggeredBy?), TypeInfoPropertyName = "NullableJobStatusTriggeredBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartGroupType?), TypeInfoPropertyName = "NullableChartGroupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DashboardSource?), TypeInfoPropertyName = "NullableDashboardSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartGroupItem?), TypeInfoPropertyName = "NullableChartGroupItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartGroupItemVariant1Type?), TypeInfoPropertyName = "NullableChartGroupItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartGroupItemVariant2Type?), TypeInfoPropertyName = "NullableChartGroupItemVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItem?), TypeInfoPropertyName = "NullableChartShowItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemKeywordSourceSourceType?), TypeInfoPropertyName = "NullableChartShowItemKeywordSourceSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemKeywordSourceMeasurementType?), TypeInfoPropertyName = "NullableChartShowItemKeywordSourceMeasurementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemNumericSourceSourceType?), TypeInfoPropertyName = "NullableChartShowItemNumericSourceSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemNumericSourceMeasurementType?), TypeInfoPropertyName = "NullableChartShowItemNumericSourceMeasurementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemCustomFieldSourceSourceType?), TypeInfoPropertyName = "NullableChartShowItemCustomFieldSourceSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemCustomFieldSourceSourceCast?), TypeInfoPropertyName = "NullableChartShowItemCustomFieldSourceSourceCast2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemCustomFieldSourceMeasurementType?), TypeInfoPropertyName = "NullableChartShowItemCustomFieldSourceMeasurementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemConcurrencySourceSourceType?), TypeInfoPropertyName = "NullableChartShowItemConcurrencySourceSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemConcurrencySourceMeasurementType?), TypeInfoPropertyName = "NullableChartShowItemConcurrencySourceMeasurementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemCustomToolSourceSourceType?), TypeInfoPropertyName = "NullableChartShowItemCustomToolSourceSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartShowItemCustomToolSourceMeasurementType?), TypeInfoPropertyName = "NullableChartShowItemCustomToolSourceMeasurementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartTimeRange?), TypeInfoPropertyName = "NullableChartTimeRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartTimeRangeVariant1Type?), TypeInfoPropertyName = "NullableChartTimeRangeVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartTimeRangeVariant1WindowUnit?), TypeInfoPropertyName = "NullableChartTimeRangeVariant1WindowUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartTimeRangeVariant2Type?), TypeInfoPropertyName = "NullableChartTimeRangeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartTimeRangeVariant3Type?), TypeInfoPropertyName = "NullableChartTimeRangeVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartTimeRangeVariant3Unit?), TypeInfoPropertyName = "NullableChartTimeRangeVariant3Unit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartTimeRangeVariant4Type?), TypeInfoPropertyName = "NullableChartTimeRangeVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartTimeRangeVariant5Type?), TypeInfoPropertyName = "NullableChartTimeRangeVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartConfigType?), TypeInfoPropertyName = "NullableChartConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AnyOf<global::RetellAI.StoredCallFilter?, global::RetellAI.ChatFilter>?), TypeInfoPropertyName = "NullableAnyOfStoredCallFilterChatFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartConfigUnit?), TypeInfoPropertyName = "NullableChartConfigUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartDefinition?), TypeInfoPropertyName = "NullableChartDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartConfigWithId?), TypeInfoPropertyName = "NullableChartConfigWithId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChartUpdate?), TypeInfoPropertyName = "NullableChartUpdate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.ChartUpdate?, object>?), TypeInfoPropertyName = "NullableOneOfChartUpdateObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.AgentRequest, global::RetellAI.CreateAgentRequest2>?), TypeInfoPropertyName = "NullableAllOfAgentRequestCreateAgentRequest22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.TestCaseDefinitionInput, object>?), TypeInfoPropertyName = "NullableAllOfTestCaseDefinitionInputObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.ChatAgentRequest, object>?), TypeInfoPropertyName = "NullableAllOfChatAgentRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberRequestNumberProvider?), TypeInfoPropertyName = "NullableCreatePhoneNumberRequestNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberRequestCountryCode?), TypeInfoPropertyName = "NullableCreatePhoneNumberRequestCountryCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.RecordChatMessageRequestVariant1, global::RetellAI.RecordChatMessageRequestVariant2>?), TypeInfoPropertyName = "NullableOneOfRecordChatMessageRequestVariant1RecordChatMessageRequestVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RecordChatMessageRequestVariant1Role?), TypeInfoPropertyName = "NullableRecordChatMessageRequestVariant1Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RecordChatMessageRequestVariant2Role?), TypeInfoPropertyName = "NullableRecordChatMessageRequestVariant2Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceRequestVoiceProvider?), TypeInfoPropertyName = "NullableCloneVoiceRequestVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceRequestVoiceProvider?), TypeInfoPropertyName = "NullableAddCommunityVoiceRequestVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceRequestVoiceProvider?), TypeInfoPropertyName = "NullableSearchCommunityVoiceRequestVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataRequestDataStorageSetting?), TypeInfoPropertyName = "NullableUpdateChatMetadataRequestDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallRequestDirection?), TypeInfoPropertyName = "NullableRegisterPhoneCallRequestDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataRequestDataStorageSetting?), TypeInfoPropertyName = "NullableUpdateCallMetadataRequestDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallRequestFieldsToOverrideDataStorageSetting?), TypeInfoPropertyName = "NullableUpdateLiveCallRequestFieldsToOverrideDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.ContactTag, global::RetellAI.UpdateCrmConfigRequestContactTag>?), TypeInfoPropertyName = "NullableAllOfContactTagUpdateCrmConfigRequestContactTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsType?), TypeInfoPropertyName = "NullableListTestCaseDefinitionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsType?), TypeInfoPropertyName = "NullableListBatchTestsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsSortOrder?), TypeInfoPropertyName = "NullableListAgentVersionsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsSortOrder?), TypeInfoPropertyName = "NullableListAgentsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsSortOrder?), TypeInfoPropertyName = "NullableListConversationFlowComponentsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsSortOrder?), TypeInfoPropertyName = "NullableListConversationFlowsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersSortOrder?), TypeInfoPropertyName = "NullableListPhoneNumbersSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchPhoneNumbersSortOrder?), TypeInfoPropertyName = "NullableSearchPhoneNumbersSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMSortOrder?), TypeInfoPropertyName = "NullableListRetellLLMSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsSortOrder?), TypeInfoPropertyName = "NullableListExportRequestsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppsSortOrder?), TypeInfoPropertyName = "NullableListAppsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppUsagesSortOrder?), TypeInfoPropertyName = "NullableListAppUsagesSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus?), TypeInfoPropertyName = "NullableAddKnowledgeBaseSourcesResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentResponseStatus?), TypeInfoPropertyName = "NullableCreateAgentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallResponseStatus?), TypeInfoPropertyName = "NullableCreateBatchCallResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponseStatus?), TypeInfoPropertyName = "NullableCreateBatchTestResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus?), TypeInfoPropertyName = "NullableCreateTestCaseDefinitionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus?), TypeInfoPropertyName = "NullableDeleteTestCaseDefinitionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus?), TypeInfoPropertyName = "NullableGetTestCaseDefinitionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListTestCaseDefinitionsResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListTestCaseDefinitionsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus?), TypeInfoPropertyName = "NullableListTestCaseDefinitionsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus?), TypeInfoPropertyName = "NullableUpdateTestCaseDefinitionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponseStatus?), TypeInfoPropertyName = "NullableGetBatchTestResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListBatchTestsResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListBatchTestsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponseStatus?), TypeInfoPropertyName = "NullableListBatchTestsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponseStatus?), TypeInfoPropertyName = "NullableGetTestRunResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListTestRunsResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListTestRunsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponseStatus?), TypeInfoPropertyName = "NullableListTestRunsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatAgentResponseStatus?), TypeInfoPropertyName = "NullableCreateChatAgentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus?), TypeInfoPropertyName = "NullableAgentPlaygroundCompletionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponseStatus?), TypeInfoPropertyName = "NullableCreateChatCompletionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponseStatus?), TypeInfoPropertyName = "NullableCreateChatResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus?), TypeInfoPropertyName = "NullableCreateConversationFlowComponentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponseStatus?), TypeInfoPropertyName = "NullableCreateConversationFlowResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAssetResponseStatus?), TypeInfoPropertyName = "NullableCreateAssetResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus?), TypeInfoPropertyName = "NullableCreateKnowledgeBaseResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberResponseStatus?), TypeInfoPropertyName = "NullableCreatePhoneNumberResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateRetellLLMResponseStatus?), TypeInfoPropertyName = "NullableCreateRetellLLMResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponseStatus?), TypeInfoPropertyName = "NullableCreateSmsChatResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentResponseStatus?), TypeInfoPropertyName = "NullableDeleteAgentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatResponseStatus?), TypeInfoPropertyName = "NullableDeleteChatResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatAgentResponseStatus?), TypeInfoPropertyName = "NullableDeleteChatAgentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus?), TypeInfoPropertyName = "NullableDeleteConversationFlowComponentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponseStatus?), TypeInfoPropertyName = "NullableDeleteConversationFlowResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus?), TypeInfoPropertyName = "NullableDeleteKnowledgeBaseSourceResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus?), TypeInfoPropertyName = "NullableDeleteKnowledgeBaseResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeletePhoneNumberResponseStatus?), TypeInfoPropertyName = "NullableDeletePhoneNumberResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteRetellLLMResponseStatus?), TypeInfoPropertyName = "NullableDeleteRetellLLMResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndChatResponseStatus?), TypeInfoPropertyName = "NullableEndChatResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAgentVersionsResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListAgentVersionsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentVersionsResponseStatus?), TypeInfoPropertyName = "NullableListAgentVersionsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentResponseStatus?), TypeInfoPropertyName = "NullableGetAgentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetHandbookPresetsResponseStatus?), TypeInfoPropertyName = "NullableGetHandbookPresetsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentResponseStatus?), TypeInfoPropertyName = "NullableGetChatAgentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RecordChatMessageResponseStatus?), TypeInfoPropertyName = "NullableRecordChatMessageResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatResponseStatus?), TypeInfoPropertyName = "NullableGetChatResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConcurrencyResponseStatus?), TypeInfoPropertyName = "NullableGetConcurrencyResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetApiKeyInfoResponseStatus?), TypeInfoPropertyName = "NullableGetApiKeyInfoResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowComponentResponseStatus?), TypeInfoPropertyName = "NullableGetConversationFlowComponentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponseStatus?), TypeInfoPropertyName = "NullableGetConversationFlowResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetKnowledgeBaseResponseStatus?), TypeInfoPropertyName = "NullableGetKnowledgeBaseResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetMCPToolsResponseStatus?), TypeInfoPropertyName = "NullableGetMCPToolsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetPhoneNumberResponseStatus?), TypeInfoPropertyName = "NullableGetPhoneNumberResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetRetellLLMResponseStatus?), TypeInfoPropertyName = "NullableGetRetellLLMResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetVoiceResponseStatus?), TypeInfoPropertyName = "NullableGetVoiceResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponseStatus?), TypeInfoPropertyName = "NullableCloneVoiceResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceResponseStatus?), TypeInfoPropertyName = "NullableAddCommunityVoiceResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponseStatus?), TypeInfoPropertyName = "NullableSearchCommunityVoiceResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ImportPhoneNumberResponseStatus?), TypeInfoPropertyName = "NullableImportPhoneNumberResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAgentsResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListAgentsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponseStatus?), TypeInfoPropertyName = "NullableListAgentsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListChatsResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListChatsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsResponseStatus?), TypeInfoPropertyName = "NullableListChatsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowComponentsResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListConversationFlowComponentsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus?), TypeInfoPropertyName = "NullableListConversationFlowComponentsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowsResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListConversationFlowsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponseStatus?), TypeInfoPropertyName = "NullableListConversationFlowsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListKnowledgeBasesResponseStatus?), TypeInfoPropertyName = "NullableListKnowledgeBasesResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListPhoneNumbersResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListPhoneNumbersResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersResponseStatus?), TypeInfoPropertyName = "NullableListPhoneNumbersResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.SearchPhoneNumbersResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseSearchPhoneNumbersResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchPhoneNumbersResponseStatus?), TypeInfoPropertyName = "NullableSearchPhoneNumbersResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListRetellLLMResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListRetellLLMResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponseStatus?), TypeInfoPropertyName = "NullableListRetellLLMResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListVoicesResponseStatus?), TypeInfoPropertyName = "NullableListVoicesResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.AgentResponse?, global::RetellAI.ChatAgentResponse?>?), TypeInfoPropertyName = "NullableOneOfAgentResponseChatAgentResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentVersionResponseStatus?), TypeInfoPropertyName = "NullableCreateAgentVersionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentVersionResponseStatus?), TypeInfoPropertyName = "NullablePublishAgentVersionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentVersionResponseStatus?), TypeInfoPropertyName = "NullableDeleteAgentVersionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentRootResponseStatus?), TypeInfoPropertyName = "NullableGetAgentRootResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentRootResponseStatus?), TypeInfoPropertyName = "NullableUpdateAgentRootResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RefreshKnowledgeBaseResponseStatus?), TypeInfoPropertyName = "NullableRefreshKnowledgeBaseResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunCallAnalysisResponseStatus?), TypeInfoPropertyName = "NullableRerunCallAnalysisResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RerunChatAnalysisResponseStatus?), TypeInfoPropertyName = "NullableRerunChatAnalysisResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponseStatus?), TypeInfoPropertyName = "NullableUpdateAgentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RepairAgentResponseStatus?), TypeInfoPropertyName = "NullableRepairAgentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponseStatus?), TypeInfoPropertyName = "NullableUpdateChatAgentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataResponseStatus?), TypeInfoPropertyName = "NullableUpdateChatMetadataResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus?), TypeInfoPropertyName = "NullableUpdateConversationFlowComponentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponseStatus?), TypeInfoPropertyName = "NullableUpdateConversationFlowResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberResponseStatus?), TypeInfoPropertyName = "NullableUpdatePhoneNumberResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponseStatus?), TypeInfoPropertyName = "NullableUpdateRetellLLMResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponseStatus?), TypeInfoPropertyName = "NullableCreatePhoneCallResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponseStatus?), TypeInfoPropertyName = "NullableCreateWebCallResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteCallResponseStatus?), TypeInfoPropertyName = "NullableDeleteCallResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCallResponseStatus?), TypeInfoPropertyName = "NullableGetCallResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListenLiveCallResponseStatus?), TypeInfoPropertyName = "NullableListenLiveCallResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TakeOverLiveCallResponseStatus?), TypeInfoPropertyName = "NullableTakeOverLiveCallResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListCallsResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListCallsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponseStatus?), TypeInfoPropertyName = "NullableListCallsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListExportRequestsResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListExportRequestsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponseItemChannel?), TypeInfoPropertyName = "NullableListExportRequestsResponseItemChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponseItemStatus?), TypeInfoPropertyName = "NullableListExportRequestsResponseItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsResponseStatus?), TypeInfoPropertyName = "NullableListExportRequestsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponseStatus?), TypeInfoPropertyName = "NullableRegisterPhoneCallResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponseStatus?), TypeInfoPropertyName = "NullableUpdateCallMetadataResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateLiveCallResponseStatus?), TypeInfoPropertyName = "NullableUpdateLiveCallResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StopCallResponseStatus?), TypeInfoPropertyName = "NullableStopCallResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateContactResponseStatus?), TypeInfoPropertyName = "NullableCreateContactResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UploadContactImportFileResponseStatus?), TypeInfoPropertyName = "NullableUploadContactImportFileResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateContactImportResponseStatus?), TypeInfoPropertyName = "NullableCreateContactImportResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactImportResponseStatus?), TypeInfoPropertyName = "NullableGetContactImportResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactResponseStatus?), TypeInfoPropertyName = "NullableGetContactResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetContactByPhoneResponseStatus?), TypeInfoPropertyName = "NullableGetContactByPhoneResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateContactResponseStatus?), TypeInfoPropertyName = "NullableUpdateContactResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteContactResponseStatus?), TypeInfoPropertyName = "NullableDeleteContactResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactsResponseStatus?), TypeInfoPropertyName = "NullableListContactsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListContactConversationsResponseStatus?), TypeInfoPropertyName = "NullableListContactConversationsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAppResponseStatus?), TypeInfoPropertyName = "NullableCreateAppResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAppResponseStatus?), TypeInfoPropertyName = "NullableGetAppResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAppResponseStatus?), TypeInfoPropertyName = "NullableUpdateAppResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAppResponseStatus?), TypeInfoPropertyName = "NullableDeleteAppResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppsResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListAppsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppsResponseStatus?), TypeInfoPropertyName = "NullableListAppsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppUsagesResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListAppUsagesResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppUsagesResponseStatus?), TypeInfoPropertyName = "NullableListAppUsagesResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestAppAuthResponseStatus?), TypeInfoPropertyName = "NullableTestAppAuthResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppTemplatesResponse2>?), TypeInfoPropertyName = "NullableAllOfPaginatedResponseBaseListAppTemplatesResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAppTemplatesResponseStatus?), TypeInfoPropertyName = "NullableListAppTemplatesResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAppToolSchemaResponseStatus?), TypeInfoPropertyName = "NullableGetAppToolSchemaResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmConfigResponseStatus?), TypeInfoPropertyName = "NullableGetCrmConfigResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCrmConfigResponseStatus?), TypeInfoPropertyName = "NullableUpdateCrmConfigResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RunSyncJobResponseStatus?), TypeInfoPropertyName = "NullableRunSyncJobResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetSyncJobStatusResponseStatus?), TypeInfoPropertyName = "NullableGetSyncJobStatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus?), TypeInfoPropertyName = "NullableBackfillContactAnalysisDataResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBackfillContactJobStatusResponseStatus?), TypeInfoPropertyName = "NullableGetBackfillContactJobStatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCrmSchemaResponseStatus?), TypeInfoPropertyName = "NullableGetCrmSchemaResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AsrProviderModeRoutingSplitItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AgentFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.DisconnectionReason>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CustomFieldFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AlertFilterStatusCodeValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AlertFilterErrorCodeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.UtteranceNaturalnessIssues>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AgentRequestExpressiveEmotionTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.Language?, global::System.Collections.Generic.List<global::RetellAI.Language>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.Language>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AgentRequestWebhookEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AgentRequestPronunciationDictionaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.PostCallAnalysisData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.PreSessionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.PostSessionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.NodeEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.NodeFinetuneTransitionExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.Breakdown>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::RetellAI.Breakdown>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.MetricResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.TimeWindow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.DayOfWeek>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ToolParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.SmsMultimediaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CallFilterCallStatusValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CallFilterCallTypeValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CallFilterDirectionValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CallFilterUserSentimentValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CallFilterDataStorageSettingValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ToolCallFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ChatFilterChatTypeValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ChatFilterDirectionValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ChatFilterDataStorageSettingValueItem>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.PhoneNumberSpamStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.PhoneNumberListFilterPhoneNumberTypeValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AllOf<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterInboundAgent>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AllOf<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterOutboundAgent>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AgentWeight>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.RAGAccuracyMissedChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.RAGAccuracy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.State>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ScoringCriteriaCustomCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.PerformanceMetricCriteria>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.OneOf<global::RetellAI.SentimentAnalysisDetailVariant1, global::RetellAI.SentimentAnalysisDetailVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.StateEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ToolMock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AllOf<global::RetellAI.TextUtterance, global::RetellAI.TestCaseInputTranscriptItem2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.TestCaseEvalCriterion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.TestCasePaidPerformanceMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AsrGroundTruthUtterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.TestCaseBatchJobV3TestCase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.TestCaseBatchJobV3AiSummaryFailureCase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.UtteranceToolCallAccuracy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.SpendBudgetCustomAlertRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.NaturalnessIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.UtteranceVariant2Word>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.Utterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.UtteranceOrToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.IceServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ConductorFormOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ConductorFormFileFieldVariant2AcceptItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::RetellAI.ConductorFormItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ConductorFormItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ConductorFormStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ContactTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.Contact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ContactConversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CRMSyncMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AppToolTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CRMCustomFieldSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CRMAnalysisDataMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ChartShowItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ChartGroupItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.BatchCallTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ChatMessageInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AllOf<global::RetellAI.ContactTag, global::RetellAI.UpdateCrmConfigRequestContactTag>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.TestCaseDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.TestCaseBatchJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.TestCaseJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AgentVersionSummary>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AppTemplate>))]
    internal sealed partial class SourceGenerationContextChunk4 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


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

                internal static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
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
            options.Converters.Add(new global::RetellAI.JsonConverters.OutputSelectionJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PreSessionToolJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PostSessionToolJsonConverter());
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
            options.Converters.Add(new global::RetellAI.JsonConverters.BackupModelChoiceJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NullableBackupModelChoiceJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ModelChoiceJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NullableBackupModelRefJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ModelConfigJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NullableNodeModelConfigJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NodeBaseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NodeInstructionJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NodeToolJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NodeTransitionMessageJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.OrganizationResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.LegacyBooleanOrHandbookEntryConfigJsonConverter());
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
            options.Converters.Add(new global::RetellAI.JsonConverters.TestCaseCallerInstructionsJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TestCaseEvalCriterionJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AudioTestCasePerformanceMetricsJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TestCaseAsrAudioSourceJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConversationTestCaseDefinitionV3BaseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TextTestCaseDefinitionV3FieldsJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TextTestCaseDefinitionV3InputJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AudioTestCaseDefinitionV3FieldsJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AudioTestCaseDefinitionV3InputJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AsrGroundTruthUtteranceJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AsrTestCaseDefinitionV3FieldsJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AsrTestCaseDefinitionV3InputJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TestCaseDefinitionV3InputJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TestCaseDefinitionV3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConversationTestCaseJobV3BaseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TextTestCaseJobV3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AudioTestCaseJobV3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AsrTestCaseJobV3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TestCaseJobV3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ToolCallInvocationMessageJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ToolCallResultMessageJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ToolJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EscalationFailedEdgeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EscalateChatNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferCallNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferDestinationJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferFailedEdgeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferOptionJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateSpendBudgetRequestJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UtteranceOrToolCallJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UtteranceJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V2CallResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V3CallResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V3PhoneCallResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V3WebCallResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V2PhoneCallResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V2WebCallResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.VoicemailActionJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.IvrActionJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConductorOverageConfigJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConductorFormFieldBaseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConductorFormTextBlockJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConductorFormChoiceFieldJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConductorFormSelectFieldJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConductorFormTextFieldJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConductorFormTextareaFieldJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConductorFormNumberFieldJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConductorFormSwitchFieldJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConductorFormTimeFieldJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConductorFormDateRangeFieldJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConductorFormFileFieldJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConductorFormFieldJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConductorFormItemJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ContactListResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ContactConversationJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ContactConversationListResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AuthConfigRequestJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AppAuthConfigResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AppUsageResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ChartGroupItemJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ChartShowItemJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ChartTimeRangeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ChartDefinitionJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ChartConfigWithIdJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ChartUpdateJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, object>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterDisconnectionReason>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.StringFilter, object>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterStatusCode>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.AgentRootTagUpdate, object>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.Language?, global::System.Collections.Generic.IList<global::RetellAI.Language>>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.StringFilter, global::RetellAI.AgentListFilterChannel>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.Language?, global::System.Collections.Generic.IList<global::RetellAI.Language>>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.AllOf<global::RetellAI.NumberFilter, global::RetellAI.CohortFilterStartTimestampVariant1>?, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.CohortFilterStartTimestampVariant1>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.CohortFilterDisconnectionReason>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, object>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool, global::RetellAI.SendSMSTool>());
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
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.StringFilter, global::RetellAI.EnumFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterChatType>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterDirection>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterDataStorageSetting>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterChatStatus>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterDisconnectionReason>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterUserSentiment>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.StringFilter, global::RetellAI.PresentFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<string, global::RetellAI.PromptCondition, global::RetellAI.EquationCondition, global::RetellAI.EquationPromptCondition>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.KnowledgeBaseSourceDocument, global::RetellAI.KnowledgeBaseSourceText, global::RetellAI.KnowledgeBaseSourceUrl>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.PerformanceMetricCriteria, global::RetellAI.CustomMetricCriteria>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<double?, bool?, string>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.PromptCondition, global::RetellAI.EquationCondition>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.CustomTool, global::RetellAI.AppTool>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterSpamStatus>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.BooleanFilter, global::RetellAI.PhoneNumberListFilterSms>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.BooleanFilter, global::RetellAI.PhoneNumberListFilterVerifiedNumber>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.BooleanFilter, global::RetellAI.PhoneNumberListFilterBrandedCall>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterPhoneNumberType>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterInboundAgent>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterInboundAgentTags>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterOutboundAgent>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterOutboundAgentTags>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.StringFilter, global::RetellAI.EnumFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.QaViewFilterDisconnectionReason>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, object>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<bool?, global::RetellAI.BooleanFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<bool?, global::RetellAI.BooleanFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AnyOfJsonConverter<global::RetellAI.SmsSender?, object>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AnyOfJsonConverter<global::RetellAI.SmsDestination?, object>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.SentimentAnalysisDetailVariant1, global::RetellAI.SentimentAnalysisDetailVariant2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NodeInstruction?, global::RetellAI.SmsInstructionTemplate>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AnyOfJsonConverter<global::RetellAI.SmsSender?, object>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AnyOfJsonConverter<global::RetellAI.SmsDestination?, object>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.TextUtterance, global::RetellAI.TestCaseInputTranscriptItem2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.TextTestCaseDefinitionV3Input?, global::RetellAI.AudioTestCaseDefinitionV3Input?, global::RetellAI.AsrTestCaseDefinitionV3Input?>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.WarmTransferPrompt, global::RetellAI.WarmTransferStaticMessage>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.WarmTransferPrompt, global::RetellAI.WarmTransferStaticMessage>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.WarmTransferPrompt, global::RetellAI.WarmTransferStaticMessage>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AnyOfJsonConverter<global::RetellAI.StoredCallFilter?, global::RetellAI.ChatFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.ChartUpdate?, object>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AnyOfJsonConverter<global::RetellAI.StoredCallFilter?, global::RetellAI.ChatFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.AgentRequest, global::RetellAI.CreateAgentRequest2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.TestCaseDefinitionInput, object>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.ChatAgentRequest, object>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.RecordChatMessageRequestVariant1, global::RetellAI.RecordChatMessageRequestVariant2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.ContactTag, global::RetellAI.UpdateCrmConfigRequestContactTag>());
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
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.SearchPhoneNumbersResponse2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListRetellLLMResponse2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.AgentResponse?, global::RetellAI.ChatAgentResponse?>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.AgentResponse?, global::RetellAI.ChatAgentResponse?>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListCallsResponse2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListExportRequestsResponse2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppsResponse2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppUsagesResponse2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppTemplatesResponse2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::RetellAI.PrivacyScope)

                    || typeToConvert == typeof(global::RetellAI.PrivacyScope?)

                    || typeToConvert == typeof(global::RetellAI.AlertMetricType)

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

                    || typeToConvert == typeof(global::RetellAI.AgentRequestExpressiveEmotionTag)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestExpressiveEmotionTag?)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestAmbientSound)

                    || typeToConvert == typeof(global::RetellAI.AgentRequestAmbientSound?)

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

                    || typeToConvert == typeof(global::RetellAI.AgentOverrideConfigSttMode)

                    || typeToConvert == typeof(global::RetellAI.AgentOverrideConfigSttMode?)

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

                    || typeToConvert == typeof(global::RetellAI.AppToolType)

                    || typeToConvert == typeof(global::RetellAI.AppToolType?)

                    || typeToConvert == typeof(global::RetellAI.AppToolExecutionMessageType)

                    || typeToConvert == typeof(global::RetellAI.AppToolExecutionMessageType?)

                    || typeToConvert == typeof(global::RetellAI.OutputSelectionVariant1Mode)

                    || typeToConvert == typeof(global::RetellAI.OutputSelectionVariant1Mode?)

                    || typeToConvert == typeof(global::RetellAI.OutputSelectionVariant2Mode)

                    || typeToConvert == typeof(global::RetellAI.OutputSelectionVariant2Mode?)

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

                    || typeToConvert == typeof(global::RetellAI.ChatFilterChatTypeValueItem)

                    || typeToConvert == typeof(global::RetellAI.ChatFilterChatTypeValueItem?)

                    || typeToConvert == typeof(global::RetellAI.ChatFilterDirectionValueItem)

                    || typeToConvert == typeof(global::RetellAI.ChatFilterDirectionValueItem?)

                    || typeToConvert == typeof(global::RetellAI.ChatFilterDataStorageSettingValueItem)

                    || typeToConvert == typeof(global::RetellAI.ChatFilterDataStorageSettingValueItem?)

                    || typeToConvert == typeof(global::RetellAI.ChatFilterChatStatusValueItem)

                    || typeToConvert == typeof(global::RetellAI.ChatFilterChatStatusValueItem?)

                    || typeToConvert == typeof(global::RetellAI.ChatFilterUserSentimentValueItem)

                    || typeToConvert == typeof(global::RetellAI.ChatFilterUserSentimentValueItem?)

                    || typeToConvert == typeof(global::RetellAI.ListContactsRequestSortOrder)

                    || typeToConvert == typeof(global::RetellAI.ListContactsRequestSortOrder?)

                    || typeToConvert == typeof(global::RetellAI.DayOfWeek)

                    || typeToConvert == typeof(global::RetellAI.DayOfWeek?)

                    || typeToConvert == typeof(global::RetellAI.DisconnectionReason)

                    || typeToConvert == typeof(global::RetellAI.DisconnectionReason?)

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

                    || typeToConvert == typeof(global::RetellAI.EquationPromptConditionType)

                    || typeToConvert == typeof(global::RetellAI.EquationPromptConditionType?)

                    || typeToConvert == typeof(global::RetellAI.EquationPromptConditionOperator)

                    || typeToConvert == typeof(global::RetellAI.EquationPromptConditionOperator?)

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

                    || typeToConvert == typeof(global::RetellAI.Language)

                    || typeToConvert == typeof(global::RetellAI.Language?)

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

                    || typeToConvert == typeof(global::RetellAI.S2SModel)

                    || typeToConvert == typeof(global::RetellAI.S2SModel?)

                    || typeToConvert == typeof(global::RetellAI.ModelChoiceS2SType)

                    || typeToConvert == typeof(global::RetellAI.ModelChoiceS2SType?)

                    || typeToConvert == typeof(global::RetellAI.ServiceTier)

                    || typeToConvert == typeof(global::RetellAI.ServiceTier?)

                    || typeToConvert == typeof(global::RetellAI.CascadingModelConfigType)

                    || typeToConvert == typeof(global::RetellAI.CascadingModelConfigType?)

                    || typeToConvert == typeof(global::RetellAI.S2SModelConfigType)

                    || typeToConvert == typeof(global::RetellAI.S2SModelConfigType?)

                    || typeToConvert == typeof(global::RetellAI.DuplexModelRefModel)

                    || typeToConvert == typeof(global::RetellAI.DuplexModelRefModel?)

                    || typeToConvert == typeof(global::RetellAI.DuplexModelConfigType)

                    || typeToConvert == typeof(global::RetellAI.DuplexModelConfigType?)

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

                    || typeToConvert == typeof(global::RetellAI.NullableS2SModel)

                    || typeToConvert == typeof(global::RetellAI.NullableS2SModel?)

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

                    || typeToConvert == typeof(global::RetellAI.PhoneNumberSpamStatus)

                    || typeToConvert == typeof(global::RetellAI.PhoneNumberSpamStatus?)

                    || typeToConvert == typeof(global::RetellAI.PhoneNumberListFilterSmsValue)

                    || typeToConvert == typeof(global::RetellAI.PhoneNumberListFilterSmsValue?)

                    || typeToConvert == typeof(global::RetellAI.PhoneNumberListFilterVerifiedNumberValue)

                    || typeToConvert == typeof(global::RetellAI.PhoneNumberListFilterVerifiedNumberValue?)

                    || typeToConvert == typeof(global::RetellAI.PhoneNumberListFilterBrandedCallValue)

                    || typeToConvert == typeof(global::RetellAI.PhoneNumberListFilterBrandedCallValue?)

                    || typeToConvert == typeof(global::RetellAI.PhoneNumberListFilterPhoneNumberTypeValueItem)

                    || typeToConvert == typeof(global::RetellAI.PhoneNumberListFilterPhoneNumberTypeValueItem?)

                    || typeToConvert == typeof(global::RetellAI.PhoneNumberResponsePhoneNumberType)

                    || typeToConvert == typeof(global::RetellAI.PhoneNumberResponsePhoneNumberType?)

                    || typeToConvert == typeof(global::RetellAI.PhoneNumberResponseSpamStatus)

                    || typeToConvert == typeof(global::RetellAI.PhoneNumberResponseSpamStatus?)

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

                    || typeToConvert == typeof(global::RetellAI.RetellLlmOverrideStartSpeaker)

                    || typeToConvert == typeof(global::RetellAI.RetellLlmOverrideStartSpeaker?)

                    || typeToConvert == typeof(global::RetellAI.SendSMSToolType)

                    || typeToConvert == typeof(global::RetellAI.SendSMSToolType?)

                    || typeToConvert == typeof(global::RetellAI.SendSMSToolExecutionMessageType)

                    || typeToConvert == typeof(global::RetellAI.SendSMSToolExecutionMessageType?)

                    || typeToConvert == typeof(global::RetellAI.SmsSenderSenderCurrentNumberType)

                    || typeToConvert == typeof(global::RetellAI.SmsSenderSenderCurrentNumberType?)

                    || typeToConvert == typeof(global::RetellAI.SmsSenderSenderRetellLongCodeType)

                    || typeToConvert == typeof(global::RetellAI.SmsSenderSenderRetellLongCodeType?)

                    || typeToConvert == typeof(global::RetellAI.SmsDestinationDestinationCustomerNumberType)

                    || typeToConvert == typeof(global::RetellAI.SmsDestinationDestinationCustomerNumberType?)

                    || typeToConvert == typeof(global::RetellAI.SmsDestinationDestinationPhoneNumberType)

                    || typeToConvert == typeof(global::RetellAI.SmsDestinationDestinationPhoneNumberType?)

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

                    || typeToConvert == typeof(global::RetellAI.TestCaseInputTranscriptItemRole)

                    || typeToConvert == typeof(global::RetellAI.TestCaseInputTranscriptItemRole?)

                    || typeToConvert == typeof(global::RetellAI.TestCaseCallerInstructionsVariant1Type)

                    || typeToConvert == typeof(global::RetellAI.TestCaseCallerInstructionsVariant1Type?)

                    || typeToConvert == typeof(global::RetellAI.TestCaseCallerInstructionsVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.TestCaseCallerInstructionsVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.TestCaseEvalCriterionVariant1Type)

                    || typeToConvert == typeof(global::RetellAI.TestCaseEvalCriterionVariant1Type?)

                    || typeToConvert == typeof(global::RetellAI.TestCaseEvalCriterionVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.TestCaseEvalCriterionVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.TestCasePaidPerformanceMetric)

                    || typeToConvert == typeof(global::RetellAI.TestCasePaidPerformanceMetric?)

                    || typeToConvert == typeof(global::RetellAI.TestCaseAsrAudioSourceVariant1Type)

                    || typeToConvert == typeof(global::RetellAI.TestCaseAsrAudioSourceVariant1Type?)

                    || typeToConvert == typeof(global::RetellAI.TestCaseAsrAudioSourceVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.TestCaseAsrAudioSourceVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.TextTestCaseDefinitionV3InputVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.TextTestCaseDefinitionV3InputVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound)

                    || typeToConvert == typeof(global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound?)

                    || typeToConvert == typeof(global::RetellAI.AudioTestCaseDefinitionV3InputVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.AudioTestCaseDefinitionV3InputVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.AsrGroundTruthUtteranceVariant2Role)

                    || typeToConvert == typeof(global::RetellAI.AsrGroundTruthUtteranceVariant2Role?)

                    || typeToConvert == typeof(global::RetellAI.AsrTestCaseDefinitionV3InputVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.AsrTestCaseDefinitionV3InputVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.TestCaseJobV3BaseStatus)

                    || typeToConvert == typeof(global::RetellAI.TestCaseJobV3BaseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatus)

                    || typeToConvert == typeof(global::RetellAI.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatus?)

                    || typeToConvert == typeof(global::RetellAI.TextTestCaseJobV3Variant2Type)

                    || typeToConvert == typeof(global::RetellAI.TextTestCaseJobV3Variant2Type?)

                    || typeToConvert == typeof(global::RetellAI.AudioTestCaseJobV3Variant2Type)

                    || typeToConvert == typeof(global::RetellAI.AudioTestCaseJobV3Variant2Type?)

                    || typeToConvert == typeof(global::RetellAI.AsrTestCaseJobV3Variant2Type)

                    || typeToConvert == typeof(global::RetellAI.AsrTestCaseJobV3Variant2Type?)

                    || typeToConvert == typeof(global::RetellAI.TestCaseBatchJobV3Status)

                    || typeToConvert == typeof(global::RetellAI.TestCaseBatchJobV3Status?)

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

                    || typeToConvert == typeof(global::RetellAI.EscalationDestinationType)

                    || typeToConvert == typeof(global::RetellAI.EscalationDestinationType?)

                    || typeToConvert == typeof(global::RetellAI.EscalationDestinationDestinationMethod)

                    || typeToConvert == typeof(global::RetellAI.EscalationDestinationDestinationMethod?)

                    || typeToConvert == typeof(global::RetellAI.EscalateChatToolType)

                    || typeToConvert == typeof(global::RetellAI.EscalateChatToolType?)

                    || typeToConvert == typeof(global::RetellAI.EscalationFailedEdgeVariant2TransitionConditionType)

                    || typeToConvert == typeof(global::RetellAI.EscalationFailedEdgeVariant2TransitionConditionType?)

                    || typeToConvert == typeof(global::RetellAI.EscalationFailedEdgeVariant2TransitionConditionPrompt)

                    || typeToConvert == typeof(global::RetellAI.EscalationFailedEdgeVariant2TransitionConditionPrompt?)

                    || typeToConvert == typeof(global::RetellAI.EscalateChatNodeVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.EscalateChatNodeVariant2Type?)

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

                    || typeToConvert == typeof(global::RetellAI.TransferOptionColdTransferOnHoldMusic)

                    || typeToConvert == typeof(global::RetellAI.TransferOptionColdTransferOnHoldMusic?)

                    || typeToConvert == typeof(global::RetellAI.TransferOptionWarmTransferType)

                    || typeToConvert == typeof(global::RetellAI.TransferOptionWarmTransferType?)

                    || typeToConvert == typeof(global::RetellAI.TransferOptionWarmTransferOnHoldMusic)

                    || typeToConvert == typeof(global::RetellAI.TransferOptionWarmTransferOnHoldMusic?)

                    || typeToConvert == typeof(global::RetellAI.UtteranceHallucinationHallucinationType)

                    || typeToConvert == typeof(global::RetellAI.UtteranceHallucinationHallucinationType?)

                    || typeToConvert == typeof(global::RetellAI.BackupModelUsedReason)

                    || typeToConvert == typeof(global::RetellAI.BackupModelUsedReason?)

                    || typeToConvert == typeof(global::RetellAI.TextUtteranceRole)

                    || typeToConvert == typeof(global::RetellAI.TextUtteranceRole?)

                    || typeToConvert == typeof(global::RetellAI.V2CallBaseCallStatus)

                    || typeToConvert == typeof(global::RetellAI.V2CallBaseCallStatus?)

                    || typeToConvert == typeof(global::RetellAI.V2CallBaseDataStorageSetting)

                    || typeToConvert == typeof(global::RetellAI.V2CallBaseDataStorageSetting?)

                    || typeToConvert == typeof(global::RetellAI.CallTransport)

                    || typeToConvert == typeof(global::RetellAI.CallTransport?)

                    || typeToConvert == typeof(global::RetellAI.V3CreateWebCallResponseTransport)

                    || typeToConvert == typeof(global::RetellAI.V3CreateWebCallResponseTransport?)

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

                    || typeToConvert == typeof(global::RetellAI.ConductorFormTextBlockVariant2Kind)

                    || typeToConvert == typeof(global::RetellAI.ConductorFormTextBlockVariant2Kind?)

                    || typeToConvert == typeof(global::RetellAI.ConductorFormChoiceFieldVariant2Kind)

                    || typeToConvert == typeof(global::RetellAI.ConductorFormChoiceFieldVariant2Kind?)

                    || typeToConvert == typeof(global::RetellAI.ConductorFormSelectFieldVariant2Kind)

                    || typeToConvert == typeof(global::RetellAI.ConductorFormSelectFieldVariant2Kind?)

                    || typeToConvert == typeof(global::RetellAI.ConductorFormTextFieldVariant2Kind)

                    || typeToConvert == typeof(global::RetellAI.ConductorFormTextFieldVariant2Kind?)

                    || typeToConvert == typeof(global::RetellAI.ConductorFormTextFieldVariant2Format)

                    || typeToConvert == typeof(global::RetellAI.ConductorFormTextFieldVariant2Format?)

                    || typeToConvert == typeof(global::RetellAI.ConductorFormTextareaFieldVariant2Kind)

                    || typeToConvert == typeof(global::RetellAI.ConductorFormTextareaFieldVariant2Kind?)

                    || typeToConvert == typeof(global::RetellAI.ConductorFormNumberFieldVariant2Kind)

                    || typeToConvert == typeof(global::RetellAI.ConductorFormNumberFieldVariant2Kind?)

                    || typeToConvert == typeof(global::RetellAI.ConductorFormSwitchFieldVariant2Kind)

                    || typeToConvert == typeof(global::RetellAI.ConductorFormSwitchFieldVariant2Kind?)

                    || typeToConvert == typeof(global::RetellAI.ConductorFormTimeFieldVariant2Kind)

                    || typeToConvert == typeof(global::RetellAI.ConductorFormTimeFieldVariant2Kind?)

                    || typeToConvert == typeof(global::RetellAI.ConductorFormDateRangeFieldVariant2Kind)

                    || typeToConvert == typeof(global::RetellAI.ConductorFormDateRangeFieldVariant2Kind?)

                    || typeToConvert == typeof(global::RetellAI.ConductorFormFileFieldVariant2Kind)

                    || typeToConvert == typeof(global::RetellAI.ConductorFormFileFieldVariant2Kind?)

                    || typeToConvert == typeof(global::RetellAI.ConductorFormFileFieldVariant2AcceptItem)

                    || typeToConvert == typeof(global::RetellAI.ConductorFormFileFieldVariant2AcceptItem?)

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

                    || typeToConvert == typeof(global::RetellAI.BasicAuthConfigRequestType)

                    || typeToConvert == typeof(global::RetellAI.BasicAuthConfigRequestType?)

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

                    || typeToConvert == typeof(global::RetellAI.AppResponseTenantType)

                    || typeToConvert == typeof(global::RetellAI.AppResponseTenantType?)

                    || typeToConvert == typeof(global::RetellAI.AgentAppUsageType)

                    || typeToConvert == typeof(global::RetellAI.AgentAppUsageType?)

                    || typeToConvert == typeof(global::RetellAI.KnowledgeBaseAppUsageType)

                    || typeToConvert == typeof(global::RetellAI.KnowledgeBaseAppUsageType?)

                    || typeToConvert == typeof(global::RetellAI.AlertRuleAppUsageType)

                    || typeToConvert == typeof(global::RetellAI.AlertRuleAppUsageType?)

                    || typeToConvert == typeof(global::RetellAI.CRMCustomFieldSchemaType)

                    || typeToConvert == typeof(global::RetellAI.CRMCustomFieldSchemaType?)

                    || typeToConvert == typeof(global::RetellAI.CRMAnalysisDataMappingUpdateMode)

                    || typeToConvert == typeof(global::RetellAI.CRMAnalysisDataMappingUpdateMode?)

                    || typeToConvert == typeof(global::RetellAI.JobStatusStatus)

                    || typeToConvert == typeof(global::RetellAI.JobStatusStatus?)

                    || typeToConvert == typeof(global::RetellAI.JobStatusTriggeredBy)

                    || typeToConvert == typeof(global::RetellAI.JobStatusTriggeredBy?)

                    || typeToConvert == typeof(global::RetellAI.ChartGroupType)

                    || typeToConvert == typeof(global::RetellAI.ChartGroupType?)

                    || typeToConvert == typeof(global::RetellAI.DashboardSource)

                    || typeToConvert == typeof(global::RetellAI.DashboardSource?)

                    || typeToConvert == typeof(global::RetellAI.ChartGroupItemVariant1Type)

                    || typeToConvert == typeof(global::RetellAI.ChartGroupItemVariant1Type?)

                    || typeToConvert == typeof(global::RetellAI.ChartGroupItemVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.ChartGroupItemVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.ChartShowItemKeywordSourceSourceType)

                    || typeToConvert == typeof(global::RetellAI.ChartShowItemKeywordSourceSourceType?)

                    || typeToConvert == typeof(global::RetellAI.ChartShowItemKeywordSourceMeasurementType)

                    || typeToConvert == typeof(global::RetellAI.ChartShowItemKeywordSourceMeasurementType?)

                    || typeToConvert == typeof(global::RetellAI.ChartShowItemNumericSourceSourceType)

                    || typeToConvert == typeof(global::RetellAI.ChartShowItemNumericSourceSourceType?)

                    || typeToConvert == typeof(global::RetellAI.ChartShowItemNumericSourceMeasurementType)

                    || typeToConvert == typeof(global::RetellAI.ChartShowItemNumericSourceMeasurementType?)

                    || typeToConvert == typeof(global::RetellAI.ChartShowItemCustomFieldSourceSourceType)

                    || typeToConvert == typeof(global::RetellAI.ChartShowItemCustomFieldSourceSourceType?)

                    || typeToConvert == typeof(global::RetellAI.ChartShowItemCustomFieldSourceSourceCast)

                    || typeToConvert == typeof(global::RetellAI.ChartShowItemCustomFieldSourceSourceCast?)

                    || typeToConvert == typeof(global::RetellAI.ChartShowItemCustomFieldSourceMeasurementType)

                    || typeToConvert == typeof(global::RetellAI.ChartShowItemCustomFieldSourceMeasurementType?)

                    || typeToConvert == typeof(global::RetellAI.ChartShowItemConcurrencySourceSourceType)

                    || typeToConvert == typeof(global::RetellAI.ChartShowItemConcurrencySourceSourceType?)

                    || typeToConvert == typeof(global::RetellAI.ChartShowItemConcurrencySourceMeasurementType)

                    || typeToConvert == typeof(global::RetellAI.ChartShowItemConcurrencySourceMeasurementType?)

                    || typeToConvert == typeof(global::RetellAI.ChartShowItemCustomToolSourceSourceType)

                    || typeToConvert == typeof(global::RetellAI.ChartShowItemCustomToolSourceSourceType?)

                    || typeToConvert == typeof(global::RetellAI.ChartShowItemCustomToolSourceMeasurementType)

                    || typeToConvert == typeof(global::RetellAI.ChartShowItemCustomToolSourceMeasurementType?)

                    || typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant1Type)

                    || typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant1Type?)

                    || typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant1WindowUnit)

                    || typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant1WindowUnit?)

                    || typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant2Type)

                    || typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant2Type?)

                    || typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant3Type)

                    || typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant3Type?)

                    || typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant3Unit)

                    || typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant3Unit?)

                    || typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant4Type)

                    || typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant4Type?)

                    || typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant5Type)

                    || typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant5Type?)

                    || typeToConvert == typeof(global::RetellAI.ChartConfigType)

                    || typeToConvert == typeof(global::RetellAI.ChartConfigType?)

                    || typeToConvert == typeof(global::RetellAI.ChartConfigUnit)

                    || typeToConvert == typeof(global::RetellAI.ChartConfigUnit?)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneNumberRequestNumberProvider)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneNumberRequestNumberProvider?)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneNumberRequestCountryCode)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneNumberRequestCountryCode?)

                    || typeToConvert == typeof(global::RetellAI.RecordChatMessageRequestVariant1Role)

                    || typeToConvert == typeof(global::RetellAI.RecordChatMessageRequestVariant1Role?)

                    || typeToConvert == typeof(global::RetellAI.RecordChatMessageRequestVariant2Role)

                    || typeToConvert == typeof(global::RetellAI.RecordChatMessageRequestVariant2Role?)

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

                    || typeToConvert == typeof(global::RetellAI.SearchPhoneNumbersSortOrder)

                    || typeToConvert == typeof(global::RetellAI.SearchPhoneNumbersSortOrder?)

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

                    || typeToConvert == typeof(global::RetellAI.CreateAgentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateAgentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateBatchCallResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateBatchCallResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateBatchTestResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateBatchTestResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetBatchTestResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetBatchTestResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListBatchTestsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListBatchTestsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetTestRunResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetTestRunResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListTestRunsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListTestRunsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateChatAgentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateChatAgentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateConversationFlowResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateConversationFlowResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateAssetResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateAssetResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneNumberResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneNumberResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateRetellLLMResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateRetellLLMResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteAgentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteAgentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteChatResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteChatResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteChatAgentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteChatAgentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteConversationFlowResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteConversationFlowResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeletePhoneNumberResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeletePhoneNumberResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteRetellLLMResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteRetellLLMResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.EndChatResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.EndChatResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetAgentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetAgentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetHandbookPresetsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetHandbookPresetsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetChatAgentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetChatAgentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.RecordChatMessageResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.RecordChatMessageResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetChatResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetChatResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetConcurrencyResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetConcurrencyResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetApiKeyInfoResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetApiKeyInfoResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetConversationFlowComponentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetConversationFlowComponentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetConversationFlowResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetConversationFlowResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetKnowledgeBaseResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetKnowledgeBaseResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetMCPToolsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetMCPToolsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetPhoneNumberResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetPhoneNumberResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetRetellLLMResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetRetellLLMResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetVoiceResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetVoiceResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CloneVoiceResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CloneVoiceResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.AddCommunityVoiceResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.AddCommunityVoiceResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.SearchCommunityVoiceResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.SearchCommunityVoiceResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ImportPhoneNumberResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ImportPhoneNumberResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListAgentsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListAgentsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListChatsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListChatsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListConversationFlowsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListKnowledgeBasesResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListKnowledgeBasesResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListPhoneNumbersResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListPhoneNumbersResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.SearchPhoneNumbersResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.SearchPhoneNumbersResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListRetellLLMResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListRetellLLMResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListVoicesResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListVoicesResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateAgentVersionResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateAgentVersionResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.PublishAgentVersionResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.PublishAgentVersionResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteAgentVersionResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteAgentVersionResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetAgentRootResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetAgentRootResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateAgentRootResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateAgentRootResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.RefreshKnowledgeBaseResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.RefreshKnowledgeBaseResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateAgentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateAgentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.RepairAgentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.RepairAgentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateChatAgentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateChatAgentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateChatMetadataResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateChatMetadataResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdatePhoneNumberResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdatePhoneNumberResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateRetellLLMResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateRetellLLMResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteCallResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteCallResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetCallResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetCallResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListenLiveCallResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListenLiveCallResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.TakeOverLiveCallResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.TakeOverLiveCallResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListCallsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListCallsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseItemChannel)

                    || typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseItemChannel?)

                    || typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseItemStatus)

                    || typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseItemStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListExportRequestsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateCallMetadataResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateCallMetadataResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateLiveCallResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateLiveCallResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.StopCallResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.StopCallResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateContactResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateContactResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UploadContactImportFileResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UploadContactImportFileResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateContactImportResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateContactImportResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetContactImportResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetContactImportResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetContactResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetContactResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetContactByPhoneResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetContactByPhoneResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateContactResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateContactResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteContactResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteContactResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListContactsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListContactsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListContactConversationsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListContactConversationsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.CreateAppResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.CreateAppResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetAppResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetAppResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateAppResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateAppResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.DeleteAppResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.DeleteAppResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListAppsResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListAppsResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListAppUsagesResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListAppUsagesResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.TestAppAuthResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.TestAppAuthResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.ListAppTemplatesResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.ListAppTemplatesResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetAppToolSchemaResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetAppToolSchemaResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetCrmConfigResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetCrmConfigResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.UpdateCrmConfigResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.UpdateCrmConfigResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.RunSyncJobResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.RunSyncJobResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetSyncJobStatusResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetSyncJobStatusResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetBackfillContactJobStatusResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetBackfillContactJobStatusResponseStatus?)

                    || typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus)

                    || typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::RetellAI.PrivacyScope))
                {
                    return new global::RetellAI.JsonConverters.PrivacyScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PrivacyScope?))
                {
                    return new global::RetellAI.JsonConverters.PrivacyScopeNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::RetellAI.AgentOverrideConfigSttMode))
                {
                    return new global::RetellAI.JsonConverters.AgentOverrideConfigSttModeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentOverrideConfigSttMode?))
                {
                    return new global::RetellAI.JsonConverters.AgentOverrideConfigSttModeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::RetellAI.AppToolType))
                {
                    return new global::RetellAI.JsonConverters.AppToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AppToolType?))
                {
                    return new global::RetellAI.JsonConverters.AppToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AppToolExecutionMessageType))
                {
                    return new global::RetellAI.JsonConverters.AppToolExecutionMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AppToolExecutionMessageType?))
                {
                    return new global::RetellAI.JsonConverters.AppToolExecutionMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.OutputSelectionVariant1Mode))
                {
                    return new global::RetellAI.JsonConverters.OutputSelectionVariant1ModeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.OutputSelectionVariant1Mode?))
                {
                    return new global::RetellAI.JsonConverters.OutputSelectionVariant1ModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.OutputSelectionVariant2Mode))
                {
                    return new global::RetellAI.JsonConverters.OutputSelectionVariant2ModeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.OutputSelectionVariant2Mode?))
                {
                    return new global::RetellAI.JsonConverters.OutputSelectionVariant2ModeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::RetellAI.ChatFilterChatTypeValueItem))
                {
                    return new global::RetellAI.JsonConverters.ChatFilterChatTypeValueItemJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatFilterChatTypeValueItem?))
                {
                    return new global::RetellAI.JsonConverters.ChatFilterChatTypeValueItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatFilterDirectionValueItem))
                {
                    return new global::RetellAI.JsonConverters.ChatFilterDirectionValueItemJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatFilterDirectionValueItem?))
                {
                    return new global::RetellAI.JsonConverters.ChatFilterDirectionValueItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatFilterDataStorageSettingValueItem))
                {
                    return new global::RetellAI.JsonConverters.ChatFilterDataStorageSettingValueItemJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChatFilterDataStorageSettingValueItem?))
                {
                    return new global::RetellAI.JsonConverters.ChatFilterDataStorageSettingValueItemNullableJsonConverter();
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

                if (typeToConvert == typeof(global::RetellAI.DisconnectionReason))
                {
                    return new global::RetellAI.JsonConverters.DisconnectionReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DisconnectionReason?))
                {
                    return new global::RetellAI.JsonConverters.DisconnectionReasonNullableJsonConverter();
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

                if (typeToConvert == typeof(global::RetellAI.EquationPromptConditionType))
                {
                    return new global::RetellAI.JsonConverters.EquationPromptConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EquationPromptConditionType?))
                {
                    return new global::RetellAI.JsonConverters.EquationPromptConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EquationPromptConditionOperator))
                {
                    return new global::RetellAI.JsonConverters.EquationPromptConditionOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EquationPromptConditionOperator?))
                {
                    return new global::RetellAI.JsonConverters.EquationPromptConditionOperatorNullableJsonConverter();
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

                if (typeToConvert == typeof(global::RetellAI.Language))
                {
                    return new global::RetellAI.JsonConverters.LanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.Language?))
                {
                    return new global::RetellAI.JsonConverters.LanguageNullableJsonConverter();
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

                if (typeToConvert == typeof(global::RetellAI.S2SModel))
                {
                    return new global::RetellAI.JsonConverters.S2SModelJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.S2SModel?))
                {
                    return new global::RetellAI.JsonConverters.S2SModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ModelChoiceS2SType))
                {
                    return new global::RetellAI.JsonConverters.ModelChoiceS2STypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ModelChoiceS2SType?))
                {
                    return new global::RetellAI.JsonConverters.ModelChoiceS2STypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ServiceTier))
                {
                    return new global::RetellAI.JsonConverters.ServiceTierJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ServiceTier?))
                {
                    return new global::RetellAI.JsonConverters.ServiceTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CascadingModelConfigType))
                {
                    return new global::RetellAI.JsonConverters.CascadingModelConfigTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CascadingModelConfigType?))
                {
                    return new global::RetellAI.JsonConverters.CascadingModelConfigTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.S2SModelConfigType))
                {
                    return new global::RetellAI.JsonConverters.S2SModelConfigTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.S2SModelConfigType?))
                {
                    return new global::RetellAI.JsonConverters.S2SModelConfigTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DuplexModelRefModel))
                {
                    return new global::RetellAI.JsonConverters.DuplexModelRefModelJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DuplexModelRefModel?))
                {
                    return new global::RetellAI.JsonConverters.DuplexModelRefModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DuplexModelConfigType))
                {
                    return new global::RetellAI.JsonConverters.DuplexModelConfigTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DuplexModelConfigType?))
                {
                    return new global::RetellAI.JsonConverters.DuplexModelConfigTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::RetellAI.NullableS2SModel))
                {
                    return new global::RetellAI.JsonConverters.NullableS2SModelJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.NullableS2SModel?))
                {
                    return new global::RetellAI.JsonConverters.NullableS2SModelNullableJsonConverter();
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

                if (typeToConvert == typeof(global::RetellAI.PhoneNumberSpamStatus))
                {
                    return new global::RetellAI.JsonConverters.PhoneNumberSpamStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PhoneNumberSpamStatus?))
                {
                    return new global::RetellAI.JsonConverters.PhoneNumberSpamStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PhoneNumberListFilterSmsValue))
                {
                    return new global::RetellAI.JsonConverters.PhoneNumberListFilterSmsValueJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PhoneNumberListFilterSmsValue?))
                {
                    return new global::RetellAI.JsonConverters.PhoneNumberListFilterSmsValueNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PhoneNumberListFilterVerifiedNumberValue))
                {
                    return new global::RetellAI.JsonConverters.PhoneNumberListFilterVerifiedNumberValueJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PhoneNumberListFilterVerifiedNumberValue?))
                {
                    return new global::RetellAI.JsonConverters.PhoneNumberListFilterVerifiedNumberValueNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PhoneNumberListFilterBrandedCallValue))
                {
                    return new global::RetellAI.JsonConverters.PhoneNumberListFilterBrandedCallValueJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PhoneNumberListFilterBrandedCallValue?))
                {
                    return new global::RetellAI.JsonConverters.PhoneNumberListFilterBrandedCallValueNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PhoneNumberListFilterPhoneNumberTypeValueItem))
                {
                    return new global::RetellAI.JsonConverters.PhoneNumberListFilterPhoneNumberTypeValueItemJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PhoneNumberListFilterPhoneNumberTypeValueItem?))
                {
                    return new global::RetellAI.JsonConverters.PhoneNumberListFilterPhoneNumberTypeValueItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PhoneNumberResponsePhoneNumberType))
                {
                    return new global::RetellAI.JsonConverters.PhoneNumberResponsePhoneNumberTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PhoneNumberResponsePhoneNumberType?))
                {
                    return new global::RetellAI.JsonConverters.PhoneNumberResponsePhoneNumberTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PhoneNumberResponseSpamStatus))
                {
                    return new global::RetellAI.JsonConverters.PhoneNumberResponseSpamStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PhoneNumberResponseSpamStatus?))
                {
                    return new global::RetellAI.JsonConverters.PhoneNumberResponseSpamStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::RetellAI.SmsSenderSenderCurrentNumberType))
                {
                    return new global::RetellAI.JsonConverters.SmsSenderSenderCurrentNumberTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsSenderSenderCurrentNumberType?))
                {
                    return new global::RetellAI.JsonConverters.SmsSenderSenderCurrentNumberTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsSenderSenderRetellLongCodeType))
                {
                    return new global::RetellAI.JsonConverters.SmsSenderSenderRetellLongCodeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsSenderSenderRetellLongCodeType?))
                {
                    return new global::RetellAI.JsonConverters.SmsSenderSenderRetellLongCodeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsDestinationDestinationCustomerNumberType))
                {
                    return new global::RetellAI.JsonConverters.SmsDestinationDestinationCustomerNumberTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsDestinationDestinationCustomerNumberType?))
                {
                    return new global::RetellAI.JsonConverters.SmsDestinationDestinationCustomerNumberTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsDestinationDestinationPhoneNumberType))
                {
                    return new global::RetellAI.JsonConverters.SmsDestinationDestinationPhoneNumberTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SmsDestinationDestinationPhoneNumberType?))
                {
                    return new global::RetellAI.JsonConverters.SmsDestinationDestinationPhoneNumberTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::RetellAI.TestCaseInputTranscriptItemRole))
                {
                    return new global::RetellAI.JsonConverters.TestCaseInputTranscriptItemRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCaseInputTranscriptItemRole?))
                {
                    return new global::RetellAI.JsonConverters.TestCaseInputTranscriptItemRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCaseCallerInstructionsVariant1Type))
                {
                    return new global::RetellAI.JsonConverters.TestCaseCallerInstructionsVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCaseCallerInstructionsVariant1Type?))
                {
                    return new global::RetellAI.JsonConverters.TestCaseCallerInstructionsVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCaseCallerInstructionsVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.TestCaseCallerInstructionsVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCaseCallerInstructionsVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.TestCaseCallerInstructionsVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCaseEvalCriterionVariant1Type))
                {
                    return new global::RetellAI.JsonConverters.TestCaseEvalCriterionVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCaseEvalCriterionVariant1Type?))
                {
                    return new global::RetellAI.JsonConverters.TestCaseEvalCriterionVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCaseEvalCriterionVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.TestCaseEvalCriterionVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCaseEvalCriterionVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.TestCaseEvalCriterionVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCasePaidPerformanceMetric))
                {
                    return new global::RetellAI.JsonConverters.TestCasePaidPerformanceMetricJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCasePaidPerformanceMetric?))
                {
                    return new global::RetellAI.JsonConverters.TestCasePaidPerformanceMetricNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCaseAsrAudioSourceVariant1Type))
                {
                    return new global::RetellAI.JsonConverters.TestCaseAsrAudioSourceVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCaseAsrAudioSourceVariant1Type?))
                {
                    return new global::RetellAI.JsonConverters.TestCaseAsrAudioSourceVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCaseAsrAudioSourceVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.TestCaseAsrAudioSourceVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCaseAsrAudioSourceVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.TestCaseAsrAudioSourceVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TextTestCaseDefinitionV3InputVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.TextTestCaseDefinitionV3InputVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TextTestCaseDefinitionV3InputVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.TextTestCaseDefinitionV3InputVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound))
                {
                    return new global::RetellAI.JsonConverters.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSoundJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound?))
                {
                    return new global::RetellAI.JsonConverters.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSoundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AudioTestCaseDefinitionV3InputVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.AudioTestCaseDefinitionV3InputVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AudioTestCaseDefinitionV3InputVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.AudioTestCaseDefinitionV3InputVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AsrGroundTruthUtteranceVariant2Role))
                {
                    return new global::RetellAI.JsonConverters.AsrGroundTruthUtteranceVariant2RoleJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AsrGroundTruthUtteranceVariant2Role?))
                {
                    return new global::RetellAI.JsonConverters.AsrGroundTruthUtteranceVariant2RoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AsrTestCaseDefinitionV3InputVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.AsrTestCaseDefinitionV3InputVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AsrTestCaseDefinitionV3InputVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.AsrTestCaseDefinitionV3InputVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCaseJobV3BaseStatus))
                {
                    return new global::RetellAI.JsonConverters.TestCaseJobV3BaseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCaseJobV3BaseStatus?))
                {
                    return new global::RetellAI.JsonConverters.TestCaseJobV3BaseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatus))
                {
                    return new global::RetellAI.JsonConverters.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatus?))
                {
                    return new global::RetellAI.JsonConverters.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TextTestCaseJobV3Variant2Type))
                {
                    return new global::RetellAI.JsonConverters.TextTestCaseJobV3Variant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TextTestCaseJobV3Variant2Type?))
                {
                    return new global::RetellAI.JsonConverters.TextTestCaseJobV3Variant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AudioTestCaseJobV3Variant2Type))
                {
                    return new global::RetellAI.JsonConverters.AudioTestCaseJobV3Variant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AudioTestCaseJobV3Variant2Type?))
                {
                    return new global::RetellAI.JsonConverters.AudioTestCaseJobV3Variant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AsrTestCaseJobV3Variant2Type))
                {
                    return new global::RetellAI.JsonConverters.AsrTestCaseJobV3Variant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AsrTestCaseJobV3Variant2Type?))
                {
                    return new global::RetellAI.JsonConverters.AsrTestCaseJobV3Variant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCaseBatchJobV3Status))
                {
                    return new global::RetellAI.JsonConverters.TestCaseBatchJobV3StatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestCaseBatchJobV3Status?))
                {
                    return new global::RetellAI.JsonConverters.TestCaseBatchJobV3StatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::RetellAI.EscalationDestinationType))
                {
                    return new global::RetellAI.JsonConverters.EscalationDestinationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EscalationDestinationType?))
                {
                    return new global::RetellAI.JsonConverters.EscalationDestinationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EscalationDestinationDestinationMethod))
                {
                    return new global::RetellAI.JsonConverters.EscalationDestinationDestinationMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EscalationDestinationDestinationMethod?))
                {
                    return new global::RetellAI.JsonConverters.EscalationDestinationDestinationMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EscalateChatToolType))
                {
                    return new global::RetellAI.JsonConverters.EscalateChatToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EscalateChatToolType?))
                {
                    return new global::RetellAI.JsonConverters.EscalateChatToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EscalationFailedEdgeVariant2TransitionConditionType))
                {
                    return new global::RetellAI.JsonConverters.EscalationFailedEdgeVariant2TransitionConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EscalationFailedEdgeVariant2TransitionConditionType?))
                {
                    return new global::RetellAI.JsonConverters.EscalationFailedEdgeVariant2TransitionConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EscalationFailedEdgeVariant2TransitionConditionPrompt))
                {
                    return new global::RetellAI.JsonConverters.EscalationFailedEdgeVariant2TransitionConditionPromptJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EscalationFailedEdgeVariant2TransitionConditionPrompt?))
                {
                    return new global::RetellAI.JsonConverters.EscalationFailedEdgeVariant2TransitionConditionPromptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EscalateChatNodeVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.EscalateChatNodeVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EscalateChatNodeVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.EscalateChatNodeVariant2TypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::RetellAI.TransferOptionColdTransferOnHoldMusic))
                {
                    return new global::RetellAI.JsonConverters.TransferOptionColdTransferOnHoldMusicJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TransferOptionColdTransferOnHoldMusic?))
                {
                    return new global::RetellAI.JsonConverters.TransferOptionColdTransferOnHoldMusicNullableJsonConverter();
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

                if (typeToConvert == typeof(global::RetellAI.BackupModelUsedReason))
                {
                    return new global::RetellAI.JsonConverters.BackupModelUsedReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BackupModelUsedReason?))
                {
                    return new global::RetellAI.JsonConverters.BackupModelUsedReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TextUtteranceRole))
                {
                    return new global::RetellAI.JsonConverters.TextUtteranceRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TextUtteranceRole?))
                {
                    return new global::RetellAI.JsonConverters.TextUtteranceRoleNullableJsonConverter();
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

                if (typeToConvert == typeof(global::RetellAI.CallTransport))
                {
                    return new global::RetellAI.JsonConverters.CallTransportJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CallTransport?))
                {
                    return new global::RetellAI.JsonConverters.CallTransportNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V3CreateWebCallResponseTransport))
                {
                    return new global::RetellAI.JsonConverters.V3CreateWebCallResponseTransportJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.V3CreateWebCallResponseTransport?))
                {
                    return new global::RetellAI.JsonConverters.V3CreateWebCallResponseTransportNullableJsonConverter();
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

                if (typeToConvert == typeof(global::RetellAI.ConductorFormTextBlockVariant2Kind))
                {
                    return new global::RetellAI.JsonConverters.ConductorFormTextBlockVariant2KindJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorFormTextBlockVariant2Kind?))
                {
                    return new global::RetellAI.JsonConverters.ConductorFormTextBlockVariant2KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorFormChoiceFieldVariant2Kind))
                {
                    return new global::RetellAI.JsonConverters.ConductorFormChoiceFieldVariant2KindJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorFormChoiceFieldVariant2Kind?))
                {
                    return new global::RetellAI.JsonConverters.ConductorFormChoiceFieldVariant2KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorFormSelectFieldVariant2Kind))
                {
                    return new global::RetellAI.JsonConverters.ConductorFormSelectFieldVariant2KindJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorFormSelectFieldVariant2Kind?))
                {
                    return new global::RetellAI.JsonConverters.ConductorFormSelectFieldVariant2KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorFormTextFieldVariant2Kind))
                {
                    return new global::RetellAI.JsonConverters.ConductorFormTextFieldVariant2KindJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorFormTextFieldVariant2Kind?))
                {
                    return new global::RetellAI.JsonConverters.ConductorFormTextFieldVariant2KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorFormTextFieldVariant2Format))
                {
                    return new global::RetellAI.JsonConverters.ConductorFormTextFieldVariant2FormatJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorFormTextFieldVariant2Format?))
                {
                    return new global::RetellAI.JsonConverters.ConductorFormTextFieldVariant2FormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorFormTextareaFieldVariant2Kind))
                {
                    return new global::RetellAI.JsonConverters.ConductorFormTextareaFieldVariant2KindJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorFormTextareaFieldVariant2Kind?))
                {
                    return new global::RetellAI.JsonConverters.ConductorFormTextareaFieldVariant2KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorFormNumberFieldVariant2Kind))
                {
                    return new global::RetellAI.JsonConverters.ConductorFormNumberFieldVariant2KindJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorFormNumberFieldVariant2Kind?))
                {
                    return new global::RetellAI.JsonConverters.ConductorFormNumberFieldVariant2KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorFormSwitchFieldVariant2Kind))
                {
                    return new global::RetellAI.JsonConverters.ConductorFormSwitchFieldVariant2KindJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorFormSwitchFieldVariant2Kind?))
                {
                    return new global::RetellAI.JsonConverters.ConductorFormSwitchFieldVariant2KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorFormTimeFieldVariant2Kind))
                {
                    return new global::RetellAI.JsonConverters.ConductorFormTimeFieldVariant2KindJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorFormTimeFieldVariant2Kind?))
                {
                    return new global::RetellAI.JsonConverters.ConductorFormTimeFieldVariant2KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorFormDateRangeFieldVariant2Kind))
                {
                    return new global::RetellAI.JsonConverters.ConductorFormDateRangeFieldVariant2KindJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorFormDateRangeFieldVariant2Kind?))
                {
                    return new global::RetellAI.JsonConverters.ConductorFormDateRangeFieldVariant2KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorFormFileFieldVariant2Kind))
                {
                    return new global::RetellAI.JsonConverters.ConductorFormFileFieldVariant2KindJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorFormFileFieldVariant2Kind?))
                {
                    return new global::RetellAI.JsonConverters.ConductorFormFileFieldVariant2KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorFormFileFieldVariant2AcceptItem))
                {
                    return new global::RetellAI.JsonConverters.ConductorFormFileFieldVariant2AcceptItemJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ConductorFormFileFieldVariant2AcceptItem?))
                {
                    return new global::RetellAI.JsonConverters.ConductorFormFileFieldVariant2AcceptItemNullableJsonConverter();
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

                if (typeToConvert == typeof(global::RetellAI.BasicAuthConfigRequestType))
                {
                    return new global::RetellAI.JsonConverters.BasicAuthConfigRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BasicAuthConfigRequestType?))
                {
                    return new global::RetellAI.JsonConverters.BasicAuthConfigRequestTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::RetellAI.AppResponseTenantType))
                {
                    return new global::RetellAI.JsonConverters.AppResponseTenantTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AppResponseTenantType?))
                {
                    return new global::RetellAI.JsonConverters.AppResponseTenantTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::RetellAI.AlertRuleAppUsageType))
                {
                    return new global::RetellAI.JsonConverters.AlertRuleAppUsageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AlertRuleAppUsageType?))
                {
                    return new global::RetellAI.JsonConverters.AlertRuleAppUsageTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::RetellAI.ChartGroupType))
                {
                    return new global::RetellAI.JsonConverters.ChartGroupTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartGroupType?))
                {
                    return new global::RetellAI.JsonConverters.ChartGroupTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::RetellAI.ChartShowItemKeywordSourceSourceType))
                {
                    return new global::RetellAI.JsonConverters.ChartShowItemKeywordSourceSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartShowItemKeywordSourceSourceType?))
                {
                    return new global::RetellAI.JsonConverters.ChartShowItemKeywordSourceSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartShowItemKeywordSourceMeasurementType))
                {
                    return new global::RetellAI.JsonConverters.ChartShowItemKeywordSourceMeasurementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartShowItemKeywordSourceMeasurementType?))
                {
                    return new global::RetellAI.JsonConverters.ChartShowItemKeywordSourceMeasurementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartShowItemNumericSourceSourceType))
                {
                    return new global::RetellAI.JsonConverters.ChartShowItemNumericSourceSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartShowItemNumericSourceSourceType?))
                {
                    return new global::RetellAI.JsonConverters.ChartShowItemNumericSourceSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartShowItemNumericSourceMeasurementType))
                {
                    return new global::RetellAI.JsonConverters.ChartShowItemNumericSourceMeasurementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartShowItemNumericSourceMeasurementType?))
                {
                    return new global::RetellAI.JsonConverters.ChartShowItemNumericSourceMeasurementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartShowItemCustomFieldSourceSourceType))
                {
                    return new global::RetellAI.JsonConverters.ChartShowItemCustomFieldSourceSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartShowItemCustomFieldSourceSourceType?))
                {
                    return new global::RetellAI.JsonConverters.ChartShowItemCustomFieldSourceSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartShowItemCustomFieldSourceSourceCast))
                {
                    return new global::RetellAI.JsonConverters.ChartShowItemCustomFieldSourceSourceCastJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartShowItemCustomFieldSourceSourceCast?))
                {
                    return new global::RetellAI.JsonConverters.ChartShowItemCustomFieldSourceSourceCastNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartShowItemCustomFieldSourceMeasurementType))
                {
                    return new global::RetellAI.JsonConverters.ChartShowItemCustomFieldSourceMeasurementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartShowItemCustomFieldSourceMeasurementType?))
                {
                    return new global::RetellAI.JsonConverters.ChartShowItemCustomFieldSourceMeasurementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartShowItemConcurrencySourceSourceType))
                {
                    return new global::RetellAI.JsonConverters.ChartShowItemConcurrencySourceSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartShowItemConcurrencySourceSourceType?))
                {
                    return new global::RetellAI.JsonConverters.ChartShowItemConcurrencySourceSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartShowItemConcurrencySourceMeasurementType))
                {
                    return new global::RetellAI.JsonConverters.ChartShowItemConcurrencySourceMeasurementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartShowItemConcurrencySourceMeasurementType?))
                {
                    return new global::RetellAI.JsonConverters.ChartShowItemConcurrencySourceMeasurementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartShowItemCustomToolSourceSourceType))
                {
                    return new global::RetellAI.JsonConverters.ChartShowItemCustomToolSourceSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartShowItemCustomToolSourceSourceType?))
                {
                    return new global::RetellAI.JsonConverters.ChartShowItemCustomToolSourceSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartShowItemCustomToolSourceMeasurementType))
                {
                    return new global::RetellAI.JsonConverters.ChartShowItemCustomToolSourceMeasurementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartShowItemCustomToolSourceMeasurementType?))
                {
                    return new global::RetellAI.JsonConverters.ChartShowItemCustomToolSourceMeasurementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant1Type))
                {
                    return new global::RetellAI.JsonConverters.ChartTimeRangeVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant1Type?))
                {
                    return new global::RetellAI.JsonConverters.ChartTimeRangeVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant1WindowUnit))
                {
                    return new global::RetellAI.JsonConverters.ChartTimeRangeVariant1WindowUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant1WindowUnit?))
                {
                    return new global::RetellAI.JsonConverters.ChartTimeRangeVariant1WindowUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant2Type))
                {
                    return new global::RetellAI.JsonConverters.ChartTimeRangeVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant2Type?))
                {
                    return new global::RetellAI.JsonConverters.ChartTimeRangeVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant3Type))
                {
                    return new global::RetellAI.JsonConverters.ChartTimeRangeVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant3Type?))
                {
                    return new global::RetellAI.JsonConverters.ChartTimeRangeVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant3Unit))
                {
                    return new global::RetellAI.JsonConverters.ChartTimeRangeVariant3UnitJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant3Unit?))
                {
                    return new global::RetellAI.JsonConverters.ChartTimeRangeVariant3UnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant4Type))
                {
                    return new global::RetellAI.JsonConverters.ChartTimeRangeVariant4TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant4Type?))
                {
                    return new global::RetellAI.JsonConverters.ChartTimeRangeVariant4TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant5Type))
                {
                    return new global::RetellAI.JsonConverters.ChartTimeRangeVariant5TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartTimeRangeVariant5Type?))
                {
                    return new global::RetellAI.JsonConverters.ChartTimeRangeVariant5TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartConfigType))
                {
                    return new global::RetellAI.JsonConverters.ChartConfigTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartConfigType?))
                {
                    return new global::RetellAI.JsonConverters.ChartConfigTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartConfigUnit))
                {
                    return new global::RetellAI.JsonConverters.ChartConfigUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ChartConfigUnit?))
                {
                    return new global::RetellAI.JsonConverters.ChartConfigUnitNullableJsonConverter();
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

                if (typeToConvert == typeof(global::RetellAI.RecordChatMessageRequestVariant1Role))
                {
                    return new global::RetellAI.JsonConverters.RecordChatMessageRequestVariant1RoleJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RecordChatMessageRequestVariant1Role?))
                {
                    return new global::RetellAI.JsonConverters.RecordChatMessageRequestVariant1RoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RecordChatMessageRequestVariant2Role))
                {
                    return new global::RetellAI.JsonConverters.RecordChatMessageRequestVariant2RoleJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RecordChatMessageRequestVariant2Role?))
                {
                    return new global::RetellAI.JsonConverters.RecordChatMessageRequestVariant2RoleNullableJsonConverter();
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

                if (typeToConvert == typeof(global::RetellAI.SearchPhoneNumbersSortOrder))
                {
                    return new global::RetellAI.JsonConverters.SearchPhoneNumbersSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SearchPhoneNumbersSortOrder?))
                {
                    return new global::RetellAI.JsonConverters.SearchPhoneNumbersSortOrderNullableJsonConverter();
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

                if (typeToConvert == typeof(global::RetellAI.CreateAgentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateAgentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAgentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateAgentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateBatchCallResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateBatchCallResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateBatchCallResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateBatchCallResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateBatchTestResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateBatchTestResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateBatchTestResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateBatchTestResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetBatchTestResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetBatchTestResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetBatchTestResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetBatchTestResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListBatchTestsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListBatchTestsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListBatchTestsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListBatchTestsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetTestRunResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetTestRunResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetTestRunResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetTestRunResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListTestRunsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListTestRunsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListTestRunsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListTestRunsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatAgentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateChatAgentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatAgentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateChatAgentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AgentPlaygroundCompletionResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatCompletionResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateChatResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateChatResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateChatResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateConversationFlowResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateConversationFlowResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateConversationFlowResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateConversationFlowResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAssetResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateAssetResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAssetResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateAssetResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneNumberResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneNumberResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneNumberResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneNumberResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateRetellLLMResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateRetellLLMResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateRetellLLMResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateRetellLLMResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateSmsChatResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateSmsChatResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateSmsChatResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAgentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteAgentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAgentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteAgentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteChatResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteChatResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteChatResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteChatResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteChatAgentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteChatAgentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteChatAgentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteChatAgentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteConversationFlowResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteConversationFlowResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeletePhoneNumberResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeletePhoneNumberResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeletePhoneNumberResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeletePhoneNumberResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteRetellLLMResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteRetellLLMResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EndChatResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.EndChatResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.EndChatResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.EndChatResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListAgentVersionsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentVersionsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListAgentVersionsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAgentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetAgentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAgentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetAgentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetHandbookPresetsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetHandbookPresetsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetHandbookPresetsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetHandbookPresetsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatAgentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetChatAgentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatAgentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetChatAgentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RecordChatMessageResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.RecordChatMessageResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RecordChatMessageResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.RecordChatMessageResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetChatResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetChatResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetChatResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConcurrencyResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetConcurrencyResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConcurrencyResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetConcurrencyResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetApiKeyInfoResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetApiKeyInfoResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetApiKeyInfoResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetApiKeyInfoResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConversationFlowComponentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConversationFlowComponentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConversationFlowResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetConversationFlowResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetConversationFlowResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetConversationFlowResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetKnowledgeBaseResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetKnowledgeBaseResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetMCPToolsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetMCPToolsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetMCPToolsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetMCPToolsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetPhoneNumberResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetPhoneNumberResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetPhoneNumberResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetPhoneNumberResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetRetellLLMResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetRetellLLMResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetRetellLLMResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetRetellLLMResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetVoiceResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetVoiceResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetVoiceResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetVoiceResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CloneVoiceResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CloneVoiceResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CloneVoiceResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CloneVoiceResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AddCommunityVoiceResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.AddCommunityVoiceResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SearchCommunityVoiceResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SearchCommunityVoiceResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ImportPhoneNumberResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ImportPhoneNumberResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ImportPhoneNumberResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ImportPhoneNumberResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListAgentsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAgentsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListAgentsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListChatsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListChatsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListChatsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListChatsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListConversationFlowsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListConversationFlowsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListKnowledgeBasesResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListKnowledgeBasesResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListKnowledgeBasesResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListKnowledgeBasesResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListPhoneNumbersResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListPhoneNumbersResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListPhoneNumbersResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListPhoneNumbersResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SearchPhoneNumbersResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.SearchPhoneNumbersResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.SearchPhoneNumbersResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.SearchPhoneNumbersResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListRetellLLMResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListRetellLLMResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListRetellLLMResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListRetellLLMResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListVoicesResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListVoicesResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListVoicesResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListVoicesResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAgentVersionResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateAgentVersionResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAgentVersionResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateAgentVersionResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PublishAgentVersionResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.PublishAgentVersionResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.PublishAgentVersionResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.PublishAgentVersionResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAgentVersionResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAgentVersionResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAgentRootResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetAgentRootResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAgentRootResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetAgentRootResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAgentRootResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateAgentRootResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAgentRootResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateAgentRootResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RefreshKnowledgeBaseResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.RefreshKnowledgeBaseResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RefreshKnowledgeBaseResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.RefreshKnowledgeBaseResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.RerunCallAnalysisResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunCallAnalysisResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.RerunCallAnalysisResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.RerunChatAnalysisResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RerunChatAnalysisResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.RerunChatAnalysisResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAgentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateAgentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAgentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateAgentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RepairAgentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.RepairAgentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RepairAgentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.RepairAgentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateChatAgentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateChatAgentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateChatAgentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateChatAgentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateChatMetadataResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateChatMetadataResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateConversationFlowResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdatePhoneNumberResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdatePhoneNumberResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateRetellLLMResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateRetellLLMResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreatePhoneCallResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateWebCallResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateWebCallResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateWebCallResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteCallResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteCallResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteCallResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteCallResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCallResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetCallResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCallResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetCallResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListenLiveCallResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListenLiveCallResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListenLiveCallResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListenLiveCallResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TakeOverLiveCallResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.TakeOverLiveCallResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TakeOverLiveCallResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.TakeOverLiveCallResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListCallsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListCallsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListCallsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListCallsResponseStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RegisterPhoneCallResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateCallMetadataResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateCallMetadataResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateLiveCallResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateLiveCallResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateLiveCallResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateLiveCallResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.StopCallResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.StopCallResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.StopCallResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.StopCallResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateContactResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateContactResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateContactResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateContactResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UploadContactImportFileResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UploadContactImportFileResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UploadContactImportFileResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UploadContactImportFileResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateContactImportResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateContactImportResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateContactImportResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateContactImportResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetContactImportResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetContactImportResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetContactImportResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetContactImportResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetContactResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetContactResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetContactResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetContactResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetContactByPhoneResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetContactByPhoneResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetContactByPhoneResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetContactByPhoneResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateContactResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateContactResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateContactResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateContactResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteContactResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteContactResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteContactResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteContactResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListContactsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListContactsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListContactsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListContactsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListContactConversationsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListContactConversationsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListContactConversationsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListContactConversationsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAppResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.CreateAppResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.CreateAppResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.CreateAppResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAppResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetAppResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAppResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetAppResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAppResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateAppResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateAppResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateAppResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAppResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.DeleteAppResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.DeleteAppResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.DeleteAppResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAppsResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListAppsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAppsResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListAppsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAppUsagesResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListAppUsagesResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAppUsagesResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListAppUsagesResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestAppAuthResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.TestAppAuthResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.TestAppAuthResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.TestAppAuthResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAppTemplatesResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.ListAppTemplatesResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.ListAppTemplatesResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.ListAppTemplatesResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAppToolSchemaResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetAppToolSchemaResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetAppToolSchemaResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetAppToolSchemaResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCrmConfigResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetCrmConfigResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCrmConfigResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetCrmConfigResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateCrmConfigResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.UpdateCrmConfigResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.UpdateCrmConfigResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.UpdateCrmConfigResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RunSyncJobResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.RunSyncJobResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.RunSyncJobResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.RunSyncJobResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetSyncJobStatusResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetSyncJobStatusResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetSyncJobStatusResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetSyncJobStatusResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.BackfillContactAnalysisDataResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.BackfillContactAnalysisDataResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.BackfillContactAnalysisDataResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetBackfillContactJobStatusResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetBackfillContactJobStatusResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetBackfillContactJobStatusResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetBackfillContactJobStatusResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus))
                {
                    return new global::RetellAI.JsonConverters.GetCrmSchemaResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::RetellAI.GetCrmSchemaResponseStatus?))
                {
                    return new global::RetellAI.JsonConverters.GetCrmSchemaResponseStatusNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[5];

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
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}