
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
            typeof(global::RetellAI.JsonConverters.AlertMetricTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertMetricTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertFilterStatusCodeValueItemJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertFilterStatusCodeValueItemNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertFilterErrorCodeItemJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertFilterErrorCodeItemNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertIncidentResponseThresholdTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertIncidentResponseThresholdTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertIncidentResponseComparatorJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertIncidentResponseComparatorNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertIncidentResponseFrequencyJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertIncidentResponseFrequencyNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertIncidentResponseWindowJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertIncidentResponseWindowNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertRuleRequestThresholdTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertRuleRequestThresholdTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertRuleRequestComparatorJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertRuleRequestComparatorNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertRuleRequestFrequencyJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertRuleRequestFrequencyNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertRuleRequestWindowJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertRuleRequestWindowNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertRuleResponseThresholdTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertRuleResponseThresholdTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertRuleResponseComparatorJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertRuleResponseComparatorNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertRuleResponseFrequencyJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertRuleResponseFrequencyNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertRuleResponseWindowJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertRuleResponseWindowNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestVoiceModelJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestVoiceModelNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestVoiceEmotionJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestVoiceEmotionNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestAmbientSoundJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestAmbientSoundNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestLanguageJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestLanguageNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestWebhookEventJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestWebhookEventNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestDataStorageSettingJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestDataStorageSettingNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestPronunciationDictionaryItemAlphabetJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestPronunciationDictionaryItemAlphabetNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestSttModeJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestSttModeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestCustomSttConfigProviderJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestCustomSttConfigProviderNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestVocabSpecializationJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestVocabSpecializationNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestDenoisingModeJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestDenoisingModeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentSwapNodeVariant2TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentSwapNodeVariant2TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentSwapToolTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentSwapToolTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentSwapToolExecutionMessageTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentSwapToolExecutionMessageTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentSwapWebhookSettingJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentSwapWebhookSettingNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.BookAppointmentCalToolTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.BookAppointmentCalToolTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.BooleanAnalysisDataTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.BooleanAnalysisDataTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.BranchNodeVariant2TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.BranchNodeVariant2TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.BridgeTransferNodeVariant2TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.BridgeTransferNodeVariant2TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.BridgeTransferToolTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.BridgeTransferToolTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.BridgeTransferToolExecutionMessageTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.BridgeTransferToolExecutionMessageTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallAnalysisUserSentimentJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallAnalysisUserSentimentNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CancelTransferNodeVariant2TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.CancelTransferNodeVariant2TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CancelTransferToolTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.CancelTransferToolTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CancelTransferToolExecutionMessageTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.CancelTransferToolExecutionMessageTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatAgentRequestLanguageJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatAgentRequestLanguageNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatAgentRequestWebhookEventJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatAgentRequestWebhookEventNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatAgentRequestDataStorageSettingJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatAgentRequestDataStorageSettingNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatAnalysisUserSentimentJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatAnalysisUserSentimentNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatResponseChatStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatResponseChatStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatResponseChatTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatResponseChatTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CheckAvailabilityCalToolTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.CheckAvailabilityCalToolTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CohortAggregatedResultGroupByJsonConverter),

            typeof(global::RetellAI.JsonConverters.CohortAggregatedResultGroupByNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CohortFilterStartTimestampVariant1OpJsonConverter),

            typeof(global::RetellAI.JsonConverters.CohortFilterStartTimestampVariant1OpNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CohortFilterCallDurationFilterOpJsonConverter),

            typeof(global::RetellAI.JsonConverters.CohortFilterCallDurationFilterOpNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CohortSuccessfulCriteriaTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.CohortSuccessfulCriteriaTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CohortSuccessfulCriteriaOpJsonConverter),

            typeof(global::RetellAI.JsonConverters.CohortSuccessfulCriteriaOpNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ComponentNodeVariant2TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ComponentNodeVariant2TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ComponentNodeVariant2ComponentTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ComponentNodeVariant2ComponentTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationFlowOverrideStartSpeakerJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationFlowOverrideStartSpeakerNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationNodeVariant3TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationNodeVariant3TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CustomToolTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.CustomToolTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CustomToolMethodJsonConverter),

            typeof(global::RetellAI.JsonConverters.CustomToolMethodNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CustomToolExecutionMessageTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.CustomToolExecutionMessageTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CodeToolTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.CodeToolTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CodeToolExecutionMessageTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.CodeToolExecutionMessageTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DTMFUtteranceRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.DTMFUtteranceRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.StringFilterTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.StringFilterTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.StringFilterOpJsonConverter),

            typeof(global::RetellAI.JsonConverters.StringFilterOpNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NumberFilterTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.NumberFilterTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NumberFilterOpJsonConverter),

            typeof(global::RetellAI.JsonConverters.NumberFilterOpNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.BooleanFilterTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.BooleanFilterTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.BooleanFilterOpJsonConverter),

            typeof(global::RetellAI.JsonConverters.BooleanFilterOpNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.RangeFilterTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.RangeFilterTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.RangeFilterOpJsonConverter),

            typeof(global::RetellAI.JsonConverters.RangeFilterOpNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.EnumFilterTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.EnumFilterTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.EnumFilterOpJsonConverter),

            typeof(global::RetellAI.JsonConverters.EnumFilterOpNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PresentFilterTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.PresentFilterTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PresentFilterOpJsonConverter),

            typeof(global::RetellAI.JsonConverters.PresentFilterOpNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallFilterCallStatusValueItemJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallFilterCallStatusValueItemNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallFilterCallTypeValueItemJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallFilterCallTypeValueItemNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallFilterDirectionValueItemJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallFilterDirectionValueItemNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallFilterUserSentimentValueItemJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallFilterUserSentimentValueItemNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallFilterDataStorageSettingValueItemJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallFilterDataStorageSettingValueItemNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DayOfWeekJsonConverter),

            typeof(global::RetellAI.JsonConverters.DayOfWeekNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DisconnectionReason4JsonConverter),

            typeof(global::RetellAI.JsonConverters.DisconnectionReason4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ElseEdgeVariant2TransitionConditionTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ElseEdgeVariant2TransitionConditionTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ElseEdgeVariant2TransitionConditionPromptJsonConverter),

            typeof(global::RetellAI.JsonConverters.ElseEdgeVariant2TransitionConditionPromptNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.EndCallToolTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.EndCallToolTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.EndCallToolExecutionMessageTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.EndCallToolExecutionMessageTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.EndNodeVariant2TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.EndNodeVariant2TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.EnumAnalysisDataTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.EnumAnalysisDataTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.EquationConditionTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.EquationConditionTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.EquationConditionOperatorJsonConverter),

            typeof(global::RetellAI.JsonConverters.EquationConditionOperatorNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.EquationOperatorJsonConverter),

            typeof(global::RetellAI.JsonConverters.EquationOperatorNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ExtractDynamicVariableToolTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ExtractDynamicVariableToolTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ExtractDynamicVariablesNodeVariant2TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ExtractDynamicVariablesNodeVariant2TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.FinetuneExampleUtteranceVariant1RoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.FinetuneExampleUtteranceVariant1RoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.FinetuneExampleUtteranceVariant2RoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.FinetuneExampleUtteranceVariant2RoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.FinetuneExampleUtteranceVariant3RoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.FinetuneExampleUtteranceVariant3RoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.FunctionNodeVariant2TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.FunctionNodeVariant2TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.FunctionNodeVariant2ToolTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.FunctionNodeVariant2ToolTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CodeNodeVariant2TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.CodeNodeVariant2TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.HallucinationTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.HallucinationTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.KnowledgeBaseResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.KnowledgeBaseResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.KnowledgeBaseSourceDocumentTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.KnowledgeBaseSourceDocumentTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.KnowledgeBaseSourceTextTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.KnowledgeBaseSourceTextTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.KnowledgeBaseSourceUrlTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.KnowledgeBaseSourceUrlTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.LLMModelJsonConverter),

            typeof(global::RetellAI.JsonConverters.LLMModelNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPNodeVariant2TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPNodeVariant2TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPToolTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPToolTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPToolExecutionMessageTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPToolExecutionMessageTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.MessageRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.MessageRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ModelChoiceCascadingTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ModelChoiceCascadingTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NaturalnessIssueJsonConverter),

            typeof(global::RetellAI.JsonConverters.NaturalnessIssueNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionPromptTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionPromptTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionStaticTextTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionStaticTextTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionMessageRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionMessageRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionUtteranceRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionUtteranceRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NullableLLMModelJsonConverter),

            typeof(global::RetellAI.JsonConverters.NullableLLMModelNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NumberAnalysisDataTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.NumberAnalysisDataTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PIIConfigModeJsonConverter),

            typeof(global::RetellAI.JsonConverters.PIIConfigModeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PIIConfigCategorieJsonConverter),

            typeof(global::RetellAI.JsonConverters.PIIConfigCategorieNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GuardrailConfigOutputTopicJsonConverter),

            typeof(global::RetellAI.JsonConverters.GuardrailConfigOutputTopicNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GuardrailConfigInputTopicJsonConverter),

            typeof(global::RetellAI.JsonConverters.GuardrailConfigInputTopicNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PerformanceMetricCriteriaOpJsonConverter),

            typeof(global::RetellAI.JsonConverters.PerformanceMetricCriteriaOpNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PhoneNumberResponsePhoneNumberTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.PhoneNumberResponsePhoneNumberTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PostCallAnalysisSettingJsonConverter),

            typeof(global::RetellAI.JsonConverters.PostCallAnalysisSettingNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PressDigitNodeVariant2TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.PressDigitNodeVariant2TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PressDigitToolTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.PressDigitToolTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PromptConditionTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.PromptConditionTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.QaViewFilterScoreRangeTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.QaViewFilterScoreRangeTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.QaViewFilterScoreRangeOpJsonConverter),

            typeof(global::RetellAI.JsonConverters.QaViewFilterScoreRangeOpNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ResponseEngineConversationFlowTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ResponseEngineConversationFlowTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ResponseEngineCustomLmTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ResponseEngineCustomLmTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ResponseEngineRetellLmTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ResponseEngineRetellLmTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.RetellLlmOverrideS2sModelJsonConverter),

            typeof(global::RetellAI.JsonConverters.RetellLlmOverrideS2sModelNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.RetellLlmOverrideStartSpeakerJsonConverter),

            typeof(global::RetellAI.JsonConverters.RetellLlmOverrideStartSpeakerNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SendSMSToolTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SendSMSToolTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsSenderVariant1TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsSenderVariant1TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsSenderVariant2TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsSenderVariant2TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsDestinationVariant1TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsDestinationVariant1TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsDestinationVariant2TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsDestinationVariant2TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SentimentAnalysisDetailVariant1SentimentJsonConverter),

            typeof(global::RetellAI.JsonConverters.SentimentAnalysisDetailVariant1SentimentNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SentimentAnalysisDetailVariant2SentimentJsonConverter),

            typeof(global::RetellAI.JsonConverters.SentimentAnalysisDetailVariant2SentimentNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SkipResponseEdgeVariant2TransitionConditionTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SkipResponseEdgeVariant2TransitionConditionTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SkipResponseEdgeVariant2TransitionConditionPromptJsonConverter),

            typeof(global::RetellAI.JsonConverters.SkipResponseEdgeVariant2TransitionConditionPromptNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlwaysEdgeVariant2TransitionConditionTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlwaysEdgeVariant2TransitionConditionTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlwaysEdgeVariant2TransitionConditionPromptJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlwaysEdgeVariant2TransitionConditionPromptNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsContentInferredTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsContentInferredTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsContentPredefinedTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsContentPredefinedTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsFailedEdgeVariant2TransitionConditionTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsFailedEdgeVariant2TransitionConditionTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsFailedEdgeVariant2TransitionConditionPromptJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsFailedEdgeVariant2TransitionConditionPromptNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsNodeVariant2TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsNodeVariant2TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsSuccessEdgeVariant2TransitionConditionTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsSuccessEdgeVariant2TransitionConditionTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsSuccessEdgeVariant2TransitionConditionPromptJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsSuccessEdgeVariant2TransitionConditionPromptNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.StateTransitionMessageRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.StateTransitionMessageRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.StringAnalysisDataTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.StringAnalysisDataTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.TestCaseBatchJobStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.TestCaseBatchJobStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.TestCaseDefinitionVariant2TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.TestCaseDefinitionVariant2TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.TestCaseJobStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.TestCaseJobStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolMockInputMatchRuleVariant1TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolMockInputMatchRuleVariant1TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolMockInputMatchRuleVariant2TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolMockInputMatchRuleVariant2TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallInvocationMessageRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallInvocationMessageRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallInvocationUtteranceRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallInvocationUtteranceRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallResultMessageRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallResultMessageRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallResultUtteranceRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallResultUtteranceRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolParameterTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolParameterTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferCallNodeVariant2TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferCallNodeVariant2TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferCallToolTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferCallToolTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferCallToolExecutionMessageTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferCallToolExecutionMessageTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferDestinationInferredTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferDestinationInferredTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferDestinationPredefinedTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferDestinationPredefinedTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferFailedEdgeVariant2TransitionConditionTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferFailedEdgeVariant2TransitionConditionTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferFailedEdgeVariant2TransitionConditionPromptJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferFailedEdgeVariant2TransitionConditionPromptNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferOptionAgenticWarmTransferTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferOptionAgenticWarmTransferTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferOptionAgenticWarmTransferOnHoldMusicJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferOptionAgenticWarmTransferOnHoldMusicNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeoutJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeoutNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferOptionColdTransferTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferOptionColdTransferTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferOptionColdTransferColdTransferModeJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferOptionColdTransferColdTransferModeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferOptionWarmTransferTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferOptionWarmTransferTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferOptionWarmTransferOnHoldMusicJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferOptionWarmTransferOnHoldMusicNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UtteranceRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.UtteranceRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2CallBaseCallStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2CallBaseCallStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2CallBaseDataStorageSettingJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2CallBaseDataStorageSettingNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2PhoneCallResponseVariant1CallTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2PhoneCallResponseVariant1CallTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2PhoneCallResponseVariant1DirectionJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2PhoneCallResponseVariant1DirectionNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2WebCallResponseVariant1CallTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2WebCallResponseVariant1CallTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.VoiceResponseProviderJsonConverter),

            typeof(global::RetellAI.JsonConverters.VoiceResponseProviderNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.VoiceResponseGenderJsonConverter),

            typeof(global::RetellAI.JsonConverters.VoiceResponseGenderNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.VoicemailActionBridgeTransferTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.VoicemailActionBridgeTransferTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.VoicemailActionHangupTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.VoicemailActionHangupTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.VoicemailActionPromptTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.VoicemailActionPromptTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.VoicemailActionStaticTextTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.VoicemailActionStaticTextTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.IvrActionHangupTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.IvrActionHangupTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.WarmTransferPromptTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.WarmTransferPromptTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.WarmTransferStaticMessageTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.WarmTransferStaticMessageTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreatePhoneNumberRequestNumberProviderJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreatePhoneNumberRequestNumberProviderNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreatePhoneNumberRequestCountryCodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreatePhoneNumberRequestCountryCodeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CloneVoiceRequestVoiceProviderJsonConverter),

            typeof(global::RetellAI.JsonConverters.CloneVoiceRequestVoiceProviderNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AddCommunityVoiceRequestVoiceProviderJsonConverter),

            typeof(global::RetellAI.JsonConverters.AddCommunityVoiceRequestVoiceProviderNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SearchCommunityVoiceRequestVoiceProviderJsonConverter),

            typeof(global::RetellAI.JsonConverters.SearchCommunityVoiceRequestVoiceProviderNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatMetadataRequestDataStorageSettingJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatMetadataRequestDataStorageSettingNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsRequestFilterCriteriaCallStatuJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsRequestFilterCriteriaCallStatuNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsRequestFilterCriteriaCallTypeItemJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsRequestFilterCriteriaCallTypeItemNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsRequestFilterCriteriaDirectionItemJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsRequestFilterCriteriaDirectionItemNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsRequestFilterCriteriaUserSentimentItemJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsRequestFilterCriteriaUserSentimentItemNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsRequestSortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsRequestSortOrderNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.RegisterPhoneCallRequestDirectionJsonConverter),

            typeof(global::RetellAI.JsonConverters.RegisterPhoneCallRequestDirectionNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateCallMetadataRequestDataStorageSettingJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateCallMetadataRequestDataStorageSettingNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestCaseDefinitionsTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestCaseDefinitionsTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestCaseDefinitionsV2TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestCaseDefinitionsV2TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListBatchTestsTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListBatchTestsTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListBatchTestsV2TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListBatchTestsV2TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatSortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatSortOrderNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowComponentsV2SortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowComponentsV2SortOrderNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListPhoneNumbersV2SortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListPhoneNumbersV2SortOrderNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListExportRequestsV2SortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListExportRequestsV2SortOrderNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateBatchCallResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateBatchCallResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateBatchCallResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateBatchCallResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateBatchCallResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateBatchCallResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateBatchCallResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateBatchCallResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateBatchTestResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateBatchTestResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateBatchTestResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateBatchTestResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateBatchTestResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateBatchTestResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateBatchTestResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateBatchTestResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateBatchTestResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateBatchTestResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestCaseDefinitionsV2ResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestCaseDefinitionsV2ResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestCaseDefinitionsV2ResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestCaseDefinitionsV2ResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestCaseDefinitionsV2ResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestCaseDefinitionsV2ResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestCaseDefinitionsV2ResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestCaseDefinitionsV2ResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetBatchTestResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetBatchTestResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetBatchTestResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetBatchTestResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetBatchTestResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetBatchTestResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetBatchTestResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetBatchTestResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetBatchTestResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetBatchTestResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListBatchTestsResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListBatchTestsResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListBatchTestsResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListBatchTestsResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListBatchTestsResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListBatchTestsResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListBatchTestsResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListBatchTestsResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListBatchTestsV2ResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListBatchTestsV2ResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListBatchTestsV2ResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListBatchTestsV2ResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListBatchTestsV2ResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListBatchTestsV2ResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListBatchTestsV2ResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListBatchTestsV2ResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetTestRunResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetTestRunResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetTestRunResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetTestRunResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetTestRunResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetTestRunResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetTestRunResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetTestRunResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetTestRunResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetTestRunResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestRunsResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestRunsResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestRunsResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestRunsResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestRunsResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestRunsResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestRunsResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestRunsResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestRunsResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestRunsResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestRunsV2ResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestRunsV2ResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestRunsV2ResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestRunsV2ResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestRunsV2ResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestRunsV2ResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestRunsV2ResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestRunsV2ResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestRunsV2ResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListTestRunsV2ResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatAgentResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatAgentResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatAgentResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatAgentResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatAgentResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatAgentResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatAgentResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatAgentResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatCompletionResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatCompletionResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus6JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus6NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatResponseStatus6JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateChatResponseStatus6NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateConversationFlowResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateConversationFlowResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateConversationFlowResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateConversationFlowResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateConversationFlowResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateConversationFlowResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateConversationFlowResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateConversationFlowResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateConversationFlowResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateConversationFlowResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreatePhoneNumberResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreatePhoneNumberResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreatePhoneNumberResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreatePhoneNumberResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreatePhoneNumberResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreatePhoneNumberResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateRetellLLMResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateRetellLLMResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateRetellLLMResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateRetellLLMResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateRetellLLMResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateRetellLLMResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateSmsChatResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateSmsChatResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateSmsChatResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateSmsChatResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateSmsChatResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateSmsChatResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateSmsChatResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateSmsChatResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateSmsChatResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateSmsChatResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateSmsChatResponseStatus6JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateSmsChatResponseStatus6NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatAgentResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatAgentResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatAgentResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatAgentResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatAgentResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatAgentResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatAgentResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatAgentResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeletePhoneNumberResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeletePhoneNumberResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeletePhoneNumberResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeletePhoneNumberResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeletePhoneNumberResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeletePhoneNumberResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.EndChatResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.EndChatResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.EndChatResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.EndChatResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.EndChatResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.EndChatResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.EndChatResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.EndChatResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetAgentVersionsResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetAgentVersionsResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetAgentVersionsResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetAgentVersionsResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetAgentVersionsResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetAgentVersionsResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetAgentVersionsResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetAgentVersionsResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetAgentResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetAgentResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetAgentResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetAgentResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetAgentResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetAgentResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetAgentResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetAgentResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetChatAgentVersionsResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetChatAgentVersionsResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetChatAgentVersionsResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetChatAgentVersionsResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetChatAgentVersionsResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetChatAgentVersionsResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetChatAgentResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetChatAgentResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetChatAgentResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetChatAgentResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetChatAgentResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetChatAgentResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetChatAgentResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetChatAgentResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetChatResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetChatResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetChatResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetChatResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetChatResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetChatResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetChatResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetChatResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetConcurrencyResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetConcurrencyResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetConcurrencyResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetConcurrencyResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetConversationFlowResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetConversationFlowResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetConversationFlowResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetConversationFlowResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetConversationFlowResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetConversationFlowResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetConversationFlowResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetConversationFlowResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetConversationFlowResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetConversationFlowResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetMCPToolsResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetMCPToolsResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetMCPToolsResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetMCPToolsResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetMCPToolsResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetMCPToolsResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetMCPToolsResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetMCPToolsResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetPhoneNumberResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetPhoneNumberResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetPhoneNumberResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetPhoneNumberResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetPhoneNumberResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetPhoneNumberResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetPhoneNumberResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetPhoneNumberResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetRetellLLMResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetRetellLLMResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetRetellLLMResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetRetellLLMResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetRetellLLMResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetRetellLLMResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetRetellLLMResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetRetellLLMResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetVoiceResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetVoiceResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetVoiceResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetVoiceResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetVoiceResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetVoiceResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetVoiceResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetVoiceResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CloneVoiceResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.CloneVoiceResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CloneVoiceResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.CloneVoiceResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CloneVoiceResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.CloneVoiceResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CloneVoiceResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.CloneVoiceResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CloneVoiceResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.CloneVoiceResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ImportPhoneNumberResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ImportPhoneNumberResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ImportPhoneNumberResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ImportPhoneNumberResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ImportPhoneNumberResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ImportPhoneNumberResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListAgentsResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListAgentsResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListAgentsResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListAgentsResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatAgentsResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatAgentsResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatAgentsResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatAgentsResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowComponentsV2ResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowComponentsV2ResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowComponentsV2ResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowComponentsV2ResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowComponentsV2ResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowComponentsV2ResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowComponentsV2ResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowComponentsV2ResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListKnowledgeBasesResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListKnowledgeBasesResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListKnowledgeBasesResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListKnowledgeBasesResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListKnowledgeBasesResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListKnowledgeBasesResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListPhoneNumbersV2ResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListPhoneNumbersV2ResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListPhoneNumbersV2ResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListPhoneNumbersV2ResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListPhoneNumbersResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListPhoneNumbersResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListPhoneNumbersResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListPhoneNumbersResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListVoicesResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListVoicesResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListVoicesResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListVoicesResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishChatAgentResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishChatAgentResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishChatAgentResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishChatAgentResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishChatAgentResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishChatAgentResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishChatAgentResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishChatAgentResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishChatAgentResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishChatAgentResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreatePhoneCallResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreatePhoneCallResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus6JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus6NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateWebCallResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateWebCallResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateWebCallResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateWebCallResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateWebCallResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateWebCallResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateWebCallResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateWebCallResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateWebCallResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateWebCallResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateWebCallResponseStatus6JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateWebCallResponseStatus6NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteCallResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteCallResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteCallResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteCallResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteCallResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteCallResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteCallResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteCallResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetCallResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetCallResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetCallResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetCallResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetCallResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetCallResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.GetCallResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.GetCallResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListExportRequestsV2ResponseItemChannelJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListExportRequestsV2ResponseItemChannelNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListExportRequestsV2ResponseItemStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListExportRequestsV2ResponseItemStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListExportRequestsV2ResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListExportRequestsV2ResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListExportRequestsV2ResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListExportRequestsV2ResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListExportRequestsV2ResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListExportRequestsV2ResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListExportRequestsV2ResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListExportRequestsV2ResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus6JsonConverter),

            typeof(global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus6NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentSwapNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.AnalysisDataJsonConverter),

            typeof(global::RetellAI.JsonConverters.BranchNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.BridgeTransferNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.CancelTransferNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatAgentResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.ComponentNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationFlowComponentResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationFlowNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationFlowResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationFlowJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateConversationFlowComponentRequestJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateConversationFlowRequestJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateOrganizationRequestJsonConverter),

            typeof(global::RetellAI.JsonConverters.ValueFilterJsonConverter),

            typeof(global::RetellAI.JsonConverters.CustomFieldFilterJsonConverter),

            typeof(global::RetellAI.JsonConverters.ElseEdgeJsonConverter),

            typeof(global::RetellAI.JsonConverters.EndNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ExtractDynamicVariablesNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.FinetuneExampleUtteranceJsonConverter),

            typeof(global::RetellAI.JsonConverters.FunctionNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.CodeNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.MessageOrToolCallJsonConverter),

            typeof(global::RetellAI.JsonConverters.ModelChoiceJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeBaseJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeToolJsonConverter),

            typeof(global::RetellAI.JsonConverters.OrganizationResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.PressDigitNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ResponseEngineJsonConverter),

            typeof(global::RetellAI.JsonConverters.RetellResponseEngineJsonConverter),

            typeof(global::RetellAI.JsonConverters.RetellLLMResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.RetellLlmRequestJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsSenderJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsDestinationJsonConverter),

            typeof(global::RetellAI.JsonConverters.SkipResponseEdgeJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlwaysEdgeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsContentJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsFailedEdgeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsSuccessEdgeJsonConverter),

            typeof(global::RetellAI.JsonConverters.TestCaseDefinitionJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolMockInputMatchRuleJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferCallNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferDestinationJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferFailedEdgeJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferOptionJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateOrganizationRequestJsonConverter),

            typeof(global::RetellAI.JsonConverters.UtteranceOrToolCallJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2CallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2PhoneCallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2WebCallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.VoicemailActionJsonConverter),

            typeof(global::RetellAI.JsonConverters.IvrActionJsonConverter),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterDisconnectionReason>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.StringFilter, object>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterStatusCode>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<double?, string>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<double?, string>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.AllOf<global::RetellAI.NumberFilter, global::RetellAI.CohortFilterStartTimestampVariant1>?, global::RetellAI.RangeFilter>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.CohortFilterStartTimestampVariant1>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.CohortFilterDisconnectionReason>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.CallFilterCallStatus>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDisconnectionReason>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.CallFilterCallType>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDirection>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.CallFilterUserSentiment>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDataStorageSetting>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.StringFilter, global::RetellAI.CallFilterDynamicVariable>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.KnowledgeBaseSourceDocument, global::RetellAI.KnowledgeBaseSourceText, global::RetellAI.KnowledgeBaseSourceUrl>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.PerformanceMetricCriteria, global::RetellAI.CustomMetricCriteria>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<double?, bool?, string>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.PromptCondition, global::RetellAI.EquationCondition>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.CustomTool, global::RetellAI.CheckAvailabilityCalTool, global::RetellAI.BookAppointmentCalTool>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.QaViewFilterDisconnectionReason>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<bool?, global::RetellAI.BooleanFilter>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<bool?, global::RetellAI.BooleanFilter>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.SentimentAnalysisDetailVariant1, global::RetellAI.SentimentAnalysisDetailVariant2>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.WarmTransferPrompt, global::RetellAI.WarmTransferStaticMessage>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.WarmTransferPrompt, global::RetellAI.WarmTransferStaticMessage>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.WarmTransferPrompt, global::RetellAI.WarmTransferStaticMessage>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.AgentRequest, object>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.TestCaseDefinitionInput, object>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.ChatAgentRequest, object>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListTestCaseDefinitionsV2Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListBatchTestsV2Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListTestRunsV2Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowComponentsV2Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListPhoneNumbersV2Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListExportRequestsV2Response2>),

            typeof(global::RetellAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertMetricType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PaginatedResponseBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AgentFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterDisconnectionReason>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EnumFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertFilterDisconnectionReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.DisconnectionReason4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DisconnectionReason4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.CustomFieldFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomFieldFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.StringFilter, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StringFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterStatusCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertFilterStatusCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AlertFilterStatusCodeValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertFilterStatusCodeValueItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AlertFilterErrorCodeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertFilterErrorCodeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertIncidentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertIncidentResponseThresholdType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertIncidentResponseComparator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertIncidentResponseFrequency))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertIncidentResponseWindow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleRequestThresholdType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleRequestComparator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleRequestFrequency))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleRequestWindow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleResponseThresholdType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleResponseComparator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleResponseFrequency))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertRuleResponseWindow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentNaturalnessAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.UtteranceNaturalnessIssues>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceNaturalnessIssues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentWeight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentOverrideRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLlmOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ResponseEngine))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestVoiceEmotion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestAmbientSound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AgentRequestWebhookEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestWebhookEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestDataStorageSetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AgentRequestPronunciationDictionaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestPronunciationDictionaryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestPronunciationDictionaryItemAlphabet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestVoicemailOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoicemailAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestIvrOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AnalysisData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AnalysisData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableLLMModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestSttMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestCustomSttConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestCustomSttConfigProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestVocabSpecialization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestUserDtmfOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestDenoisingMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PIIConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GuardrailConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentSwapNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentSwapNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentSwapNodeVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PostCallAnalysisSetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentSwapWebhookSetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferFailedEdge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeInstruction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentSwapTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentSwapToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentSwapToolExecutionMessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StringAnalysisData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EnumAnalysisData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BooleanAnalysisData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NumberAnalysisData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AverageMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BatchCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallTimeWindow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BatchCallTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BookAppointmentCalTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BookAppointmentCalToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<double?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BooleanAnalysisDataType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BranchNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BranchNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BranchNodeVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.NodeEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeEdge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ElseEdge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.NodeFinetuneTransitionExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeFinetuneTransitionExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BreakdownMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.Breakdown>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Breakdown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::RetellAI.Breakdown>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BridgeTransferNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BridgeTransferNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BridgeTransferNodeVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BridgeTransferTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BridgeTransferToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BridgeTransferToolExecutionMessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallAnalysisUserSentiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallLatency))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallQA))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Wer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.InterruptionAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SentimentAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MistranscribedImportantEntitiesAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RAGAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallInvocationAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallAccuracyAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.HallucinationAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallQATransferCallAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.MetricResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MetricResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.TimeWindow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TimeWindow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.DayOfWeek>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DayOfWeek))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CancelTransferNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CancelTransferNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CancelTransferNodeVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CancelTransferTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CancelTransferToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CancelTransferToolExecutionMessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChCallQA))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatAgentRequestLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ChatAgentRequestWebhookEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatAgentRequestWebhookEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatAgentRequestDataStorageSetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatAgentResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatAgentResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatAnalysisUserSentiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatResponseChatStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatResponseChatType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<string, double?, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.MessageOrToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MessageOrToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatResponseChatCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ProductCost>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ProductCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CheckAvailabilityCalTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CheckAvailabilityCalToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortAggregatedResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortAggregatedResultGroupBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.CohortAggregatedResultTopQuestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortAggregatedResultTopQuestion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.CohortAggregatedResultTopRecommendation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortAggregatedResultTopRecommendation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.AllOf<global::RetellAI.NumberFilter, global::RetellAI.CohortFilterStartTimestampVariant1>?, global::RetellAI.RangeFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.NumberFilter, global::RetellAI.CohortFilterStartTimestampVariant1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NumberFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortFilterStartTimestampVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortFilterStartTimestampVariant1Op))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RangeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CohortFilterDisconnectionReason>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortFilterDisconnectionReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DateRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortFilterCallDurationFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortFilterCallDurationFilterOp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Cohort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ScoringCriteria))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortSuccessfulCriteria))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortSuccessfulCriteriaType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortSuccessfulCriteriaOp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ComponentNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeBaseCommon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ComponentNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ComponentNodeVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ComponentNodeVariant2ComponentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowComponentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowComponentResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowComponent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.NodeTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.Mcp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Mcp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ConversationFlowNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowComponentBeginTagDisplayPosition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FunctionNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CodeNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferCallNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PressDigitNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ExtractDynamicVariablesNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MCPNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentOverrideConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KBConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowOverrideStartSpeaker))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.CreateConversationFlowComponentRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowVariant2BeginTagDisplayPosition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationNodeVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationNodeVariant3Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SkipResponseEdge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlwaysEdge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.NodeFinetuneConversationExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeFinetuneConversationExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CpsConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateOrganizationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateOrganizationRequestNew))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateOrganizationRequestOld))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomMetricCriteria))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomToolMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomToolExecutionMessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CodeTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CodeToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CodeToolExecutionMessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DTMFUtterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DTMFUtteranceRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StringFilterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StringFilterOp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NumberFilterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NumberFilterOp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BooleanFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BooleanFilterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.BooleanFilterOp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RangeFilterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RangeFilterOp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EnumFilterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EnumFilterOp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PresentFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PresentFilterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PresentFilterOp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ValueFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomFieldFilterVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterCallStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterCallStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.CallFilterCallStatusValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterCallStatusValueItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDisconnectionReason>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterDisconnectionReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterCallType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.CallFilterCallTypeValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterCallTypeValueItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDirection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterDirection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.CallFilterDirectionValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterDirectionValueItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterUserSentiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterUserSentiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.CallFilterUserSentimentValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterUserSentimentValueItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDataStorageSetting>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterDataStorageSetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.CallFilterDataStorageSettingValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterDataStorageSettingValueItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ToolCallFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AllOf<global::RetellAI.StringFilter, global::RetellAI.CallFilterDynamicVariable>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.StringFilter, global::RetellAI.CallFilterDynamicVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterDynamicVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Duration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ElseEdgeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ElseEdgeVariant2TransitionCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ElseEdgeVariant2TransitionConditionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ElseEdgeVariant2TransitionConditionPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndCallTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndCallToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndCallToolExecutionMessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndNodeVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EnumAnalysisDataType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EquationCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EquationConditionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.Equation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Equation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EquationConditionOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EquationOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ExtractDynamicVariableTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ExtractDynamicVariableToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ExtractDynamicVariablesNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ExtractDynamicVariablesNodeVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FinetuneExampleUtterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FinetuneExampleUtteranceVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FinetuneExampleUtteranceVariant1Role))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FinetuneExampleUtteranceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FinetuneExampleUtteranceVariant2Role))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FinetuneExampleUtteranceVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FinetuneExampleUtteranceVariant3Role))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FunctionNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FunctionNodeVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.FunctionNodeVariant2ToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CodeNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CodeNodeVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GlobalNodeFinetuneTransitionExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.FinetuneExampleUtterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GlobalNodeSetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.GlobalNodeFinetuneTransitionExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.UtteranceHallucination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceHallucination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Hallucination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.HallucinationType))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.OneOf<global::RetellAI.KnowledgeBaseSourceDocument, global::RetellAI.KnowledgeBaseSourceText, global::RetellAI.KnowledgeBaseSourceUrl>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.KnowledgeBaseSourceDocument, global::RetellAI.KnowledgeBaseSourceText, global::RetellAI.KnowledgeBaseSourceUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseSourceDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseSourceText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseSourceUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseSourceDocumentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseSourceTextType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.KnowledgeBaseSourceUrlType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.LLMModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MCPNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MCPNodeVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MCPToolDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MCPTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MCPToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MCPToolExecutionMessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallInvocationMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallResultMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StateTransitionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.PerformanceMetricCriteria, global::RetellAI.CustomMetricCriteria>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PerformanceMetricCriteria))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<double?, bool?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.UtteranceMistranscribedImportantEntities>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceMistranscribedImportantEntities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ModelChoiceCascading))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ModelChoiceCascadingType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ModelChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NaturalnessIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeBaseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeBaseCommonDisplayPosition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.PromptCondition, global::RetellAI.EquationCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PromptCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeInstructionPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeInstructionPromptType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeInstructionStaticText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeInstructionStaticTextType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.CustomTool, global::RetellAI.CheckAvailabilityCalTool, global::RetellAI.BookAppointmentCalTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeToolVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.NodeTransitionAnalysisDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionAnalysisDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionUtterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionUtteranceRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NumberAnalysisDataType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Organization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.OrganizationWebhookUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OrganizationWebhookUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OrganizationCpsConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OrganizationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OrganizationResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PIIConfigMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.PIIConfigCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PIIConfigCategorie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.GuardrailConfigOutputTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GuardrailConfigOutputTopic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.GuardrailConfigInputTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GuardrailConfigInputTopic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PerformanceMetricCriteriaOp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberResponsePhoneNumberType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AgentWeight>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PhoneNumberResponseSipOutboundTrunkConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PressDigitNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PressDigitNodeVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PressDigitTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PressDigitToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PromptConditionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.QaViewFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.QaViewFilterDisconnectionReason>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.QaViewFilterDisconnectionReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<bool?, global::RetellAI.BooleanFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.QaViewFilterScoreRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.QaViewFilterScoreRangeType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.QaViewFilterScoreRangeOp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RAGAccuracy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.RAGAccuracy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ResponseEngineConversationFlow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ResponseEngineConversationFlowType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ResponseEngineCustomLm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ResponseEngineCustomLmType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ResponseEngineRetellLm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ResponseEngineRetellLmType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellResponseEngine))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLLMResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLLMResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLlmRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLLMResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLlmOverrideS2sModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLlmOverrideStartSpeaker))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLlmRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.State>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.State))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ScoringCriteriaCustomCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ScoringCriteriaCustomCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.PerformanceMetricCriteria>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SendSMSTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SendSMSToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSender))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSenderVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSenderVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSenderVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSenderVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsDestinationVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsDestinationVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsDestinationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsDestinationVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.OneOf<global::RetellAI.SentimentAnalysisDetailVariant1, global::RetellAI.SentimentAnalysisDetailVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.SentimentAnalysisDetailVariant1, global::RetellAI.SentimentAnalysisDetailVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SentimentAnalysisDetailVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SentimentAnalysisDetailVariant1Sentiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SentimentAnalysisDetailVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SentimentAnalysisDetailVariant2Sentiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SkipResponseEdgeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SkipResponseEdgeVariant2TransitionCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SkipResponseEdgeVariant2TransitionConditionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SkipResponseEdgeVariant2TransitionConditionPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlwaysEdgeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlwaysEdgeVariant2TransitionCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlwaysEdgeVariant2TransitionConditionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlwaysEdgeVariant2TransitionConditionPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsContentInferred))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsContentInferredType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsContentPredefined))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsContentPredefinedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsFailedEdge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsFailedEdgeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsFailedEdgeVariant2TransitionCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsFailedEdgeVariant2TransitionConditionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsFailedEdgeVariant2TransitionConditionPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsNodeVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSuccessEdge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSuccessEdgeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSuccessEdgeVariant2TransitionCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StateEdge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StateTransitionMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.StateEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StringAnalysisDataType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseBatchJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseBatchJobStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseDefinitionInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ToolMock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolMock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseDefinitionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseDefinitionVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TestCaseJobStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolMockInputMatchRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolMockInputMatchRuleVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolMockInputMatchRuleVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolMockInputMatchRuleVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolMockInputMatchRuleVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.UtteranceToolCallAccuracy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceToolCallAccuracy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallInvocationMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallInvocationUtterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallInvocationUtteranceRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallResultMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallResultUtterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallResultUtteranceRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolParameterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferCallTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferCallNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferCallNodeVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferCallToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferCallToolExecutionMessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferDestinationInferred))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferDestinationInferredType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferDestinationPredefined))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferDestinationPredefinedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferFailedEdgeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferFailedEdgeVariant2TransitionCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferFailedEdgeVariant2TransitionConditionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferFailedEdgeVariant2TransitionConditionPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionAgenticWarmTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionAgenticWarmTransferType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionAgenticWarmTransferOnHoldMusic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.WarmTransferPrompt, global::RetellAI.WarmTransferStaticMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.WarmTransferPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.WarmTransferStaticMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionAgenticWarmTransferAgenticTransferConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionAgenticWarmTransferAgenticTransferConfigTransferAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeout))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionColdTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionColdTransferType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionColdTransferColdTransferMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionWarmTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionWarmTransferType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.TransferOptionWarmTransferOnHoldMusic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateOrganizationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateOrganizationRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UserFormRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.Hallucination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.UtteranceMistranscribedImportantEntitiesDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceMistranscribedImportantEntitiesDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.NaturalnessIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceOrToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Utterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.UtteranceWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2CallBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2CallBaseCallStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2CallBaseDataStorageSetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.Utterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.UtteranceOrToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2CallBaseLatency))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2CallBaseCallCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2CallBaseLlmTokenUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2CallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2WebCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2PhoneCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2PhoneCallResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2PhoneCallResponseVariant1CallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2PhoneCallResponseVariant1Direction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2PhoneCallResponseVariant1TelephonyIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2WebCallResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.V2WebCallResponseVariant1CallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoiceResponseProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoiceResponseGender))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoicemailActionBridgeTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoicemailActionBridgeTransferType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoicemailActionHangup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoicemailActionHangupType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoicemailActionPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoicemailActionPromptType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoicemailActionStaticText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.VoicemailActionStaticTextType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.IvrActionHangup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.IvrActionHangupType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.IvrAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.WarmTransferPromptType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.WarmTransferStaticMessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.AgentRequest, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.BatchCallTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.TestCaseDefinitionInput, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.ChatAgentRequest, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberRequestNumberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberRequestCountryCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceRequestVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceRequestVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceRequestVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ImportPhoneNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataRequestDataStorageSetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsRequestFilterCriteria))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ListCallsRequestFilterCriteriaCallStatu>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsRequestFilterCriteriaCallStatu))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ListCallsRequestFilterCriteriaCallTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsRequestFilterCriteriaCallTypeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ListCallsRequestFilterCriteriaDirectionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsRequestFilterCriteriaDirectionItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ListCallsRequestFilterCriteriaUserSentimentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsRequestFilterCriteriaUserSentimentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsRequestFilterCriteriaStartTimestamp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsRequestFilterCriteriaEndTimestamp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsRequestFilterCriteriaDurationMs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsRequestFilterCriteriaE2eLatencyP50))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsRequestSortOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallRequestDirection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataRequestDataStorageSetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsV2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsV2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatSortOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsV2SortOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersV2SortOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2SortOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddKnowledgeBaseSourcesResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchCallResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateBatchTestResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateTestCaseDefinitionResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteTestCaseDefinitionResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestCaseDefinitionResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.TestCaseDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListTestCaseDefinitionsV2Response2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsV2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsV2Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsV2ResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsV2Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsV2ResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsV2Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsV2ResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsV2Response6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsV2ResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateTestCaseDefinitionResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetBatchTestResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.TestCaseBatchJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListBatchTestsV2Response2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsV2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsV2Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsV2ResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsV2Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsV2ResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsV2Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsV2ResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsV2Response6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsV2ResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetTestRunResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.TestCaseJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListTestRunsV2Response2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsV2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsV2Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsV2ResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsV2Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsV2ResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsV2Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsV2ResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsV2Response6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsV2ResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsV2Response7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsV2ResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatAgentResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatAgentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatAgentResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatAgentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatAgentResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatAgentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatAgentResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatCompletionResponseStatus6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateChatResponseStatus6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowComponentResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateConversationFlowResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateKnowledgeBaseResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneNumberResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateRetellLLMResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateRetellLLMResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateRetellLLMResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateRetellLLMResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateRetellLLMResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateRetellLLMResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateSmsChatResponseStatus6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteAgentResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatAgentResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatAgentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatAgentResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatAgentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatAgentResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatAgentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteChatAgentResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowComponentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowComponentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowComponentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowComponentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowComponentResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteConversationFlowResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseSourceResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteKnowledgeBaseResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeletePhoneNumberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeletePhoneNumberResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeletePhoneNumberResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeletePhoneNumberResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeletePhoneNumberResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeletePhoneNumberResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteRetellLLMResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteRetellLLMResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteRetellLLMResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteRetellLLMResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteRetellLLMResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteRetellLLMResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteRetellLLMResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteRetellLLMResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndChatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndChatResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndChatResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndChatResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndChatResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndChatResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndChatResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EndChatResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AgentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentVersionsResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentVersionsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentVersionsResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentVersionsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentVersionsResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentVersionsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentVersionsResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetAgentResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ChatAgentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentVersionsResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentVersionsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentVersionsResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentVersionsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentVersionsResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatAgentResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetChatResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConcurrencyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConcurrencyResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConcurrencyResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConcurrencyResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConcurrencyResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowComponentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowComponentResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowComponentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowComponentResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowComponentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowComponentResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowComponentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowComponentResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetConversationFlowResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetKnowledgeBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetKnowledgeBaseResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetKnowledgeBaseResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetKnowledgeBaseResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetKnowledgeBaseResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetKnowledgeBaseResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetKnowledgeBaseResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetKnowledgeBaseResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.MCPToolDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetMCPToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetMCPToolsResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetMCPToolsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetMCPToolsResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetMCPToolsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetMCPToolsResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetMCPToolsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetMCPToolsResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetPhoneNumberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetPhoneNumberResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetPhoneNumberResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetPhoneNumberResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetPhoneNumberResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetPhoneNumberResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetPhoneNumberResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetPhoneNumberResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetRetellLLMResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetRetellLLMResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetRetellLLMResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetRetellLLMResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetRetellLLMResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetRetellLLMResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetRetellLLMResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetRetellLLMResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetVoiceResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetVoiceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetVoiceResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetVoiceResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetVoiceResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetVoiceResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetVoiceResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CloneVoiceResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AddCommunityVoiceResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.SearchCommunityVoiceResponseVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponseVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SearchCommunityVoiceResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ImportPhoneNumberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ImportPhoneNumberResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ImportPhoneNumberResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ImportPhoneNumberResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ImportPhoneNumberResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ImportPhoneNumberResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatAgentsResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatAgentsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatAgentsResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ChatResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowComponentsV2Response2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsV2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ConversationFlowComponentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsV2Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsV2ResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsV2Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsV2ResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsV2Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsV2ResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsV2Response6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsV2ResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ConversationFlowResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.KnowledgeBaseResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListKnowledgeBasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListKnowledgeBasesResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListKnowledgeBasesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListKnowledgeBasesResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListKnowledgeBasesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListKnowledgeBasesResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListPhoneNumbersV2Response2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersV2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.PhoneNumberResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersV2Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersV2ResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersV2Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersV2ResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.RetellLLMResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.VoiceResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListVoicesResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListVoicesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListVoicesResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishChatAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishChatAgentResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishChatAgentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishChatAgentResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishChatAgentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishChatAgentResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishChatAgentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishChatAgentResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishChatAgentResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishChatAgentResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateAgentResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatAgentResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowComponentResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateRetellLLMResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallResponseStatus6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallResponseStatus6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteCallResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteCallResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteCallResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteCallResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteCallResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteCallResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DeleteCallResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCallResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCallResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCallResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCallResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCallResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCallResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.GetCallResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.V2CallResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListExportRequestsV2Response2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ListExportRequestsV2ResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2ResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2ResponseItemChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2ResponseItemStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2ResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2ResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2ResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2Response6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2ResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponseStatus5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallResponseStatus6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponseStatus3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponseStatus4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AgentFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.DisconnectionReason4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CustomFieldFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AlertFilterStatusCodeValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AlertFilterErrorCodeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.UtteranceNaturalnessIssues>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AgentRequestWebhookEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AgentRequestPronunciationDictionaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AnalysisData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.NodeEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.NodeFinetuneTransitionExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.Breakdown>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::RetellAI.Breakdown>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.MetricResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.TimeWindow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.DayOfWeek>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ChatAgentRequestWebhookEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.MessageOrToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ProductCost>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CohortAggregatedResultTopQuestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CohortAggregatedResultTopRecommendation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.NodeTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.Mcp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ConversationFlowNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CreateConversationFlowComponentRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.NodeFinetuneConversationExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CallFilterCallStatusValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CallFilterCallTypeValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CallFilterDirectionValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CallFilterUserSentimentValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CallFilterDataStorageSettingValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ToolCallFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AllOf<global::RetellAI.StringFilter, global::RetellAI.CallFilterDynamicVariable>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.Equation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.FinetuneExampleUtterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.GlobalNodeFinetuneTransitionExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.UtteranceHallucination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.Duration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.KnowledgeBaseAddSourcesRequestKnowledgeBaseText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.KnowledgeBaseRequestKnowledgeBaseText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.OneOf<global::RetellAI.KnowledgeBaseSourceDocument, global::RetellAI.KnowledgeBaseSourceText, global::RetellAI.KnowledgeBaseSourceUrl>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.UtteranceMistranscribedImportantEntities>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.NodeTransitionAnalysisDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.OrganizationWebhookUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.PIIConfigCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.GuardrailConfigOutputTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.GuardrailConfigInputTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AgentWeight>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.RAGAccuracy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.State>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ScoringCriteriaCustomCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.PerformanceMetricCriteria>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.OneOf<global::RetellAI.SentimentAnalysisDetailVariant1, global::RetellAI.SentimentAnalysisDetailVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.StateEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ToolMock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.UtteranceToolCallAccuracy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.Hallucination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.UtteranceMistranscribedImportantEntitiesDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.NaturalnessIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.UtteranceWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.Utterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.UtteranceOrToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.BatchCallTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ListCallsRequestFilterCriteriaCallStatu>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ListCallsRequestFilterCriteriaCallTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ListCallsRequestFilterCriteriaDirectionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ListCallsRequestFilterCriteriaUserSentimentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.TestCaseDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.TestCaseBatchJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.TestCaseJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AgentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ChatAgentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.MCPToolDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.SearchCommunityVoiceResponseVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ChatResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ConversationFlowComponentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ConversationFlowResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.KnowledgeBaseResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.PhoneNumberResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.RetellLLMResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.VoiceResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.V2CallResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ListExportRequestsV2ResponseItem>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}