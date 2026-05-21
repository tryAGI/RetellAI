
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

            typeof(global::RetellAI.JsonConverters.AsrProviderJsonConverter),

            typeof(global::RetellAI.JsonConverters.AsrProviderNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.AgentRequestWebhookEventJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestWebhookEventNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestDataStorageSettingJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestDataStorageSettingNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestPronunciationDictionaryItemAlphabetJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestPronunciationDictionaryItemAlphabetNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestSttModeJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestSttModeNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.SubagentNodeVariant3TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SubagentNodeVariant3TypeNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.SmsUtteranceRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsUtteranceRoleNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.LanguageLegacyEnumJsonConverter),

            typeof(global::RetellAI.JsonConverters.LanguageLegacyEnumNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.Language3JsonConverter),

            typeof(global::RetellAI.JsonConverters.Language3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.LLMModelJsonConverter),

            typeof(global::RetellAI.JsonConverters.LLMModelNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPNodeVariant2TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPNodeVariant2TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPToolTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPToolTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPToolExecutionMessageTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPToolExecutionMessageTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.MessageBaseRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.MessageBaseRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ModelChoiceCascadingTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ModelChoiceCascadingTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NaturalnessIssueJsonConverter),

            typeof(global::RetellAI.JsonConverters.NaturalnessIssueNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionPromptTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionPromptTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionStaticTextTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionStaticTextTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsInstructionTemplateTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsInstructionTemplateTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsInstructionTemplateTemplateJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsInstructionTemplateTemplateNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionMessageBaseRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionMessageBaseRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionMessageBaseTransitionTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionMessageBaseTransitionTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionUtteranceRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionUtteranceRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionUtteranceTransitionTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionUtteranceTransitionTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NullableLLMModelJsonConverter),

            typeof(global::RetellAI.JsonConverters.NullableLLMModelNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NumberAnalysisDataTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.NumberAnalysisDataTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PresetAnalysisDataTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.PresetAnalysisDataTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PresetAnalysisDataNameJsonConverter),

            typeof(global::RetellAI.JsonConverters.PresetAnalysisDataNameNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallPresetAnalysisDataTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallPresetAnalysisDataTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallPresetAnalysisDataNameJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallPresetAnalysisDataNameNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatPresetAnalysisDataTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatPresetAnalysisDataTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatPresetAnalysisDataNameJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatPresetAnalysisDataNameNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.SendSMSToolExecutionMessageTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SendSMSToolExecutionMessageTypeNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.SmsContentTemplateTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsContentTemplateTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsContentTemplateTemplateJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsContentTemplateTemplateNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.StateTransitionMessageBaseRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.StateTransitionMessageBaseRoleNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ToolCallInvocationMessageBaseRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallInvocationMessageBaseRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallInvocationUtteranceRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallInvocationUtteranceRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallResultMessageBaseRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallResultMessageBaseRoleNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.V3CallBaseCallStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3CallBaseCallStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3CallBaseDataStorageSettingJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3CallBaseDataStorageSettingNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3PhoneCallResponseVariant1CallTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3PhoneCallResponseVariant1CallTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3PhoneCallResponseVariant1DirectionJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3PhoneCallResponseVariant1DirectionNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3WebCallResponseVariant1CallTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3WebCallResponseVariant1CallTypeNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListChatsV3RequestSortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3RequestSortOrderNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListCallsV3RequestSortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3RequestSortOrderNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2SortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2SortOrderNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListPhoneNumbersV2SortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListPhoneNumbersV2SortOrderNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2SortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2SortOrderNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus6JsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus6NullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatus4NullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatus4NullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus5NullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListVoicesResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListVoicesResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListVoicesResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListVoicesResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus5NullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatus4NullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentVersionReferenceJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentSwapNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.AnalysisDataJsonConverter),

            typeof(global::RetellAI.JsonConverters.PostCallAnalysisDataJsonConverter),

            typeof(global::RetellAI.JsonConverters.PostChatAnalysisDataJsonConverter),

            typeof(global::RetellAI.JsonConverters.BranchNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.BridgeTransferNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.CancelTransferNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatAgentResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3ChatResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.ComponentNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationFlowComponentResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationFlowNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationFlowResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationFlowJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SubagentNodeJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.LanguageLegacyJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.MessageOrToolCallJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatMessageInputJsonConverter),

            typeof(global::RetellAI.JsonConverters.MessageJsonConverter),

            typeof(global::RetellAI.JsonConverters.ModelChoiceJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeBaseJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeToolJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionMessageJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.StateTransitionMessageJsonConverter),

            typeof(global::RetellAI.JsonConverters.TestCaseDefinitionJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolMockInputMatchRuleJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallInvocationMessageJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallResultMessageJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferCallNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferDestinationJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferFailedEdgeJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferOptionJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateOrganizationRequestJsonConverter),

            typeof(global::RetellAI.JsonConverters.UtteranceOrToolCallJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2CallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3CallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3PhoneCallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3WebCallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2PhoneCallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2WebCallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.VoicemailActionJsonConverter),

            typeof(global::RetellAI.JsonConverters.IvrActionJsonConverter),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterDisconnectionReason>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.StringFilter, object>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterStatusCode>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.LanguageLegacy?, global::System.Collections.Generic.IList<global::RetellAI.Language3>>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<double?, string>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.LanguageLegacy?, global::System.Collections.Generic.IList<global::RetellAI.Language3>>),

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

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NodeInstruction?, global::RetellAI.SmsInstructionTemplate>),

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

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListChatsV3Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowComponentsV2Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowsV2Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListPhoneNumbersV2Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListRetellLLMV2Response2>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.AgentResponse?, global::RetellAI.ChatAgentResponse?>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListCallsV3Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListExportRequestsV2Response2>),

            typeof(global::RetellAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableLLMModel), TypeInfoPropertyName = "NullableLLMModel_RetellAI_NullableLLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatResponse), TypeInfoPropertyName = "ListChatResponse_RetellAI_ListChatResponse")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponse), TypeInfoPropertyName = "ListRetellLLMResponse_RetellAI_ListRetellLLMResponse")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.LLMModel?), TypeInfoPropertyName = "NullableLLMModel_RetellAI_LLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ChatResponse>), TypeInfoPropertyName = "ListChatResponse_System_Collections_Generic_List_global_RetellAI_ChatResponse")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.RetellLLMResponse>), TypeInfoPropertyName = "ListRetellLLMResponse_System_Collections_Generic_List_global_RetellAI_RetellLLMResponse")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertMetricType), TypeInfoPropertyName = "AlertMetricType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AsrProvider), TypeInfoPropertyName = "AsrProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PaginatedResponseBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AgentFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterDisconnectionReason>), TypeInfoPropertyName = "AllOfEnumFilterAlertFilterDisconnectionReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.EnumFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertFilterDisconnectionReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.DisconnectionReason4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DisconnectionReason4), TypeInfoPropertyName = "DisconnectionReason42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.CustomFieldFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomFieldFilter), TypeInfoPropertyName = "CustomFieldFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.StringFilter, object>), TypeInfoPropertyName = "AllOfStringFilterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StringFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterStatusCode>), TypeInfoPropertyName = "AllOfEnumFilterAlertFilterStatusCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertFilterStatusCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AlertFilterStatusCodeValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertFilterStatusCodeValueItem), TypeInfoPropertyName = "AlertFilterStatusCodeValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AlertFilterErrorCodeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertFilterErrorCodeItem), TypeInfoPropertyName = "AlertFilterErrorCodeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertIncidentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AlertIncidentResponseThresholdType), TypeInfoPropertyName = "AlertIncidentResponseThresholdType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateAgentVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PublishAgentVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentOverrideRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RetellLlmOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ConversationFlowOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ResponseEngine), TypeInfoPropertyName = "ResponseEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestVoiceModel), TypeInfoPropertyName = "AgentRequestVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestVoiceEmotion), TypeInfoPropertyName = "AgentRequestVoiceEmotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentRequestAmbientSound), TypeInfoPropertyName = "AgentRequestAmbientSound2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.LanguageLegacy?, global::System.Collections.Generic.IList<global::RetellAI.Language3>>), TypeInfoPropertyName = "OneOfLanguageLegacyIListLanguage32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.LanguageLegacy), TypeInfoPropertyName = "LanguageLegacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.Language3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Language3), TypeInfoPropertyName = "Language32")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentResponse), TypeInfoPropertyName = "AgentResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AgentResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DayOfWeek), TypeInfoPropertyName = "DayOfWeek2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CancelTransferNode), TypeInfoPropertyName = "CancelTransferNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CancelTransferNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CancelTransferNodeVariant2Type), TypeInfoPropertyName = "CancelTransferNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CancelTransferTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CancelTransferToolType), TypeInfoPropertyName = "CancelTransferToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CancelTransferToolExecutionMessageType), TypeInfoPropertyName = "CancelTransferToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChCallQA))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CheckAvailabilityCalTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CheckAvailabilityCalToolType), TypeInfoPropertyName = "CheckAvailabilityCalToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortAggregatedResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortAggregatedResultGroupBy), TypeInfoPropertyName = "CohortAggregatedResultGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.CohortAggregatedResultTopQuestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortAggregatedResultTopQuestion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.CohortAggregatedResultTopRecommendation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CohortAggregatedResultTopRecommendation))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomMetricCriteria))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomToolType), TypeInfoPropertyName = "CustomToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomToolMethod), TypeInfoPropertyName = "CustomToolMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CustomToolExecutionMessageType), TypeInfoPropertyName = "CustomToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CodeTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CodeToolType), TypeInfoPropertyName = "CodeToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CodeToolExecutionMessageType), TypeInfoPropertyName = "CodeToolExecutionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DTMFUtterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.DTMFUtteranceRole), TypeInfoPropertyName = "DTMFUtteranceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsUtterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsUtteranceRole), TypeInfoPropertyName = "SmsUtteranceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.SmsMultimediaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.SmsMultimediaItem))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.AllOf<global::RetellAI.StringFilter, global::RetellAI.CallFilterDynamicVariable>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.StringFilter, global::RetellAI.CallFilterDynamicVariable>), TypeInfoPropertyName = "AllOfStringFilterCallFilterDynamicVariable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CallFilterDynamicVariable))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.Hallucination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.HallucinationType), TypeInfoPropertyName = "HallucinationType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.LanguageLegacyEnum), TypeInfoPropertyName = "LanguageLegacyEnum2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ChatMessageInput), TypeInfoPropertyName = "ChatMessageInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MessageBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallInvocationMessageBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ToolCallResultMessageBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NodeTransitionMessageBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StateTransitionMessageBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.MessageBaseRole), TypeInfoPropertyName = "MessageBaseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.PerformanceMetricCriteria, global::RetellAI.CustomMetricCriteria>), TypeInfoPropertyName = "OneOfPerformanceMetricCriteriaCustomMetricCriteria2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.PerformanceMetricCriteria))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<double?, bool?, string>), TypeInfoPropertyName = "OneOfDoubleBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.UtteranceMistranscribedImportantEntities>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceMistranscribedImportantEntities))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OrganizationResponse), TypeInfoPropertyName = "OrganizationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OrganizationResponseVariant2))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RAGAccuracy))]
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
            typeof(global::RetellAI.JsonConverters.AlertMetricTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertMetricTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AsrProviderJsonConverter),

            typeof(global::RetellAI.JsonConverters.AsrProviderNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.AgentRequestWebhookEventJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestWebhookEventNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestDataStorageSettingJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestDataStorageSettingNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestPronunciationDictionaryItemAlphabetJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestPronunciationDictionaryItemAlphabetNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestSttModeJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestSttModeNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.SubagentNodeVariant3TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SubagentNodeVariant3TypeNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.SmsUtteranceRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsUtteranceRoleNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.LanguageLegacyEnumJsonConverter),

            typeof(global::RetellAI.JsonConverters.LanguageLegacyEnumNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.Language3JsonConverter),

            typeof(global::RetellAI.JsonConverters.Language3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.LLMModelJsonConverter),

            typeof(global::RetellAI.JsonConverters.LLMModelNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPNodeVariant2TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPNodeVariant2TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPToolTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPToolTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPToolExecutionMessageTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPToolExecutionMessageTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.MessageBaseRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.MessageBaseRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ModelChoiceCascadingTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ModelChoiceCascadingTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NaturalnessIssueJsonConverter),

            typeof(global::RetellAI.JsonConverters.NaturalnessIssueNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionPromptTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionPromptTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionStaticTextTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionStaticTextTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsInstructionTemplateTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsInstructionTemplateTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsInstructionTemplateTemplateJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsInstructionTemplateTemplateNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionMessageBaseRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionMessageBaseRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionMessageBaseTransitionTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionMessageBaseTransitionTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionUtteranceRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionUtteranceRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionUtteranceTransitionTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionUtteranceTransitionTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NullableLLMModelJsonConverter),

            typeof(global::RetellAI.JsonConverters.NullableLLMModelNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NumberAnalysisDataTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.NumberAnalysisDataTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PresetAnalysisDataTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.PresetAnalysisDataTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PresetAnalysisDataNameJsonConverter),

            typeof(global::RetellAI.JsonConverters.PresetAnalysisDataNameNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallPresetAnalysisDataTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallPresetAnalysisDataTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallPresetAnalysisDataNameJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallPresetAnalysisDataNameNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatPresetAnalysisDataTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatPresetAnalysisDataTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatPresetAnalysisDataNameJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatPresetAnalysisDataNameNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.SendSMSToolExecutionMessageTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SendSMSToolExecutionMessageTypeNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.SmsContentTemplateTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsContentTemplateTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsContentTemplateTemplateJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsContentTemplateTemplateNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.StateTransitionMessageBaseRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.StateTransitionMessageBaseRoleNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ToolCallInvocationMessageBaseRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallInvocationMessageBaseRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallInvocationUtteranceRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallInvocationUtteranceRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallResultMessageBaseRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallResultMessageBaseRoleNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.V3CallBaseCallStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3CallBaseCallStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3CallBaseDataStorageSettingJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3CallBaseDataStorageSettingNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3PhoneCallResponseVariant1CallTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3PhoneCallResponseVariant1CallTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3PhoneCallResponseVariant1DirectionJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3PhoneCallResponseVariant1DirectionNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3WebCallResponseVariant1CallTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3WebCallResponseVariant1CallTypeNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListChatsV3RequestSortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3RequestSortOrderNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListCallsV3RequestSortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3RequestSortOrderNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2SortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2SortOrderNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListPhoneNumbersV2SortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListPhoneNumbersV2SortOrderNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2SortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2SortOrderNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus6JsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus6NullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatus4NullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatus4NullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus5NullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListVoicesResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListVoicesResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListVoicesResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListVoicesResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus5NullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatus4NullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentVersionReferenceJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentSwapNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.AnalysisDataJsonConverter),

            typeof(global::RetellAI.JsonConverters.PostCallAnalysisDataJsonConverter),

            typeof(global::RetellAI.JsonConverters.PostChatAnalysisDataJsonConverter),

            typeof(global::RetellAI.JsonConverters.BranchNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.BridgeTransferNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.CancelTransferNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatAgentResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3ChatResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.ComponentNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationFlowComponentResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationFlowNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationFlowResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationFlowJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SubagentNodeJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.LanguageLegacyJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.MessageOrToolCallJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatMessageInputJsonConverter),

            typeof(global::RetellAI.JsonConverters.MessageJsonConverter),

            typeof(global::RetellAI.JsonConverters.ModelChoiceJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeBaseJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeToolJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionMessageJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.StateTransitionMessageJsonConverter),

            typeof(global::RetellAI.JsonConverters.TestCaseDefinitionJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolMockInputMatchRuleJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallInvocationMessageJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallResultMessageJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferCallNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferDestinationJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferFailedEdgeJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferOptionJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateOrganizationRequestJsonConverter),

            typeof(global::RetellAI.JsonConverters.UtteranceOrToolCallJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2CallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3CallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3PhoneCallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3WebCallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2PhoneCallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2WebCallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.VoicemailActionJsonConverter),

            typeof(global::RetellAI.JsonConverters.IvrActionJsonConverter),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterDisconnectionReason>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.StringFilter, object>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterStatusCode>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.LanguageLegacy?, global::System.Collections.Generic.IList<global::RetellAI.Language3>>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<double?, string>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.LanguageLegacy?, global::System.Collections.Generic.IList<global::RetellAI.Language3>>),

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

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NodeInstruction?, global::RetellAI.SmsInstructionTemplate>),

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

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListChatsV3Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowComponentsV2Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowsV2Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListPhoneNumbersV2Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListRetellLLMV2Response2>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.AgentResponse?, global::RetellAI.ChatAgentResponse?>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListCallsV3Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListExportRequestsV2Response2>),

            typeof(global::RetellAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableLLMModel), TypeInfoPropertyName = "NullableLLMModel_RetellAI_NullableLLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatResponse), TypeInfoPropertyName = "ListChatResponse_RetellAI_ListChatResponse")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponse), TypeInfoPropertyName = "ListRetellLLMResponse_RetellAI_ListRetellLLMResponse")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.LLMModel?), TypeInfoPropertyName = "NullableLLMModel_RetellAI_LLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ChatResponse>), TypeInfoPropertyName = "ListChatResponse_System_Collections_Generic_List_global_RetellAI_ChatResponse")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.RetellLLMResponse>), TypeInfoPropertyName = "ListRetellLLMResponse_System_Collections_Generic_List_global_RetellAI_RetellLLMResponse")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateOrganizationRequest), TypeInfoPropertyName = "UpdateOrganizationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateOrganizationRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UserFormRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.Hallucination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.UtteranceMistranscribedImportantEntitiesDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UtteranceMistranscribedImportantEntitiesDetail))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsV3RequestSortOrder), TypeInfoPropertyName = "ListChatsV3RequestSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateChatMetadataRequestDataStorageSetting), TypeInfoPropertyName = "UpdateChatMetadataRequestDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdatePhoneNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreatePhoneCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.CreateWebCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsRequestFilterCriteria))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ListCallsRequestFilterCriteriaCallStatu>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsRequestFilterCriteriaCallStatu), TypeInfoPropertyName = "ListCallsRequestFilterCriteriaCallStatu2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ListCallsRequestFilterCriteriaCallTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsRequestFilterCriteriaCallTypeItem), TypeInfoPropertyName = "ListCallsRequestFilterCriteriaCallTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ListCallsRequestFilterCriteriaDirectionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsRequestFilterCriteriaDirectionItem), TypeInfoPropertyName = "ListCallsRequestFilterCriteriaDirectionItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ListCallsRequestFilterCriteriaUserSentimentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsRequestFilterCriteriaUserSentimentItem), TypeInfoPropertyName = "ListCallsRequestFilterCriteriaUserSentimentItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsRequestFilterCriteriaStartTimestamp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsRequestFilterCriteriaEndTimestamp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsRequestFilterCriteriaDurationMs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsRequestFilterCriteriaE2eLatencyP50))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsRequestSortOrder), TypeInfoPropertyName = "ListCallsRequestSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsV3RequestSortOrder), TypeInfoPropertyName = "ListCallsV3RequestSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.RegisterPhoneCallRequestDirection), TypeInfoPropertyName = "RegisterPhoneCallRequestDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataRequestDataStorageSetting), TypeInfoPropertyName = "UpdateCallMetadataRequestDataStorageSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsType), TypeInfoPropertyName = "ListTestCaseDefinitionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsV2Type), TypeInfoPropertyName = "ListTestCaseDefinitionsV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsType), TypeInfoPropertyName = "ListBatchTestsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsV2Type), TypeInfoPropertyName = "ListBatchTestsV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatSortOrder), TypeInfoPropertyName = "ListChatSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsV2SortOrder), TypeInfoPropertyName = "ListConversationFlowComponentsV2SortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsV2SortOrder), TypeInfoPropertyName = "ListConversationFlowsV2SortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersV2SortOrder), TypeInfoPropertyName = "ListPhoneNumbersV2SortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMV2SortOrder), TypeInfoPropertyName = "ListRetellLLMV2SortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2SortOrder), TypeInfoPropertyName = "ListExportRequestsV2SortOrder2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.TestCaseDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus), TypeInfoPropertyName = "ListTestCaseDefinitionsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus2), TypeInfoPropertyName = "ListTestCaseDefinitionsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus3), TypeInfoPropertyName = "ListTestCaseDefinitionsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsResponseStatus4), TypeInfoPropertyName = "ListTestCaseDefinitionsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListTestCaseDefinitionsV2Response2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListTestCaseDefinitionsV2Response22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsV2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsV2Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsV2ResponseStatus), TypeInfoPropertyName = "ListTestCaseDefinitionsV2ResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsV2Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsV2ResponseStatus2), TypeInfoPropertyName = "ListTestCaseDefinitionsV2ResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsV2Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsV2ResponseStatus3), TypeInfoPropertyName = "ListTestCaseDefinitionsV2ResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsV2Response6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestCaseDefinitionsV2ResponseStatus4), TypeInfoPropertyName = "ListTestCaseDefinitionsV2ResponseStatus42")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.TestCaseBatchJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponseStatus), TypeInfoPropertyName = "ListBatchTestsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponseStatus2), TypeInfoPropertyName = "ListBatchTestsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponseStatus3), TypeInfoPropertyName = "ListBatchTestsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsResponseStatus4), TypeInfoPropertyName = "ListBatchTestsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListBatchTestsV2Response2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListBatchTestsV2Response22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsV2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsV2Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsV2ResponseStatus), TypeInfoPropertyName = "ListBatchTestsV2ResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsV2Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsV2ResponseStatus2), TypeInfoPropertyName = "ListBatchTestsV2ResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsV2Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsV2ResponseStatus3), TypeInfoPropertyName = "ListBatchTestsV2ResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsV2Response6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListBatchTestsV2ResponseStatus4), TypeInfoPropertyName = "ListBatchTestsV2ResponseStatus42")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.TestCaseJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponseStatus), TypeInfoPropertyName = "ListTestRunsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponseStatus2), TypeInfoPropertyName = "ListTestRunsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponseStatus3), TypeInfoPropertyName = "ListTestRunsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponseStatus4), TypeInfoPropertyName = "ListTestRunsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsResponseStatus5), TypeInfoPropertyName = "ListTestRunsResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListTestRunsV2Response2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListTestRunsV2Response22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsV2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsV2Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsV2ResponseStatus), TypeInfoPropertyName = "ListTestRunsV2ResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsV2Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsV2ResponseStatus2), TypeInfoPropertyName = "ListTestRunsV2ResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsV2Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsV2ResponseStatus3), TypeInfoPropertyName = "ListTestRunsV2ResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsV2Response6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsV2ResponseStatus4), TypeInfoPropertyName = "ListTestRunsV2ResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsV2Response7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListTestRunsV2ResponseStatus5), TypeInfoPropertyName = "ListTestRunsV2ResponseStatus52")]
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
            typeof(global::RetellAI.JsonConverters.AlertMetricTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertMetricTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AsrProviderJsonConverter),

            typeof(global::RetellAI.JsonConverters.AsrProviderNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.AgentRequestWebhookEventJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestWebhookEventNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestDataStorageSettingJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestDataStorageSettingNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestPronunciationDictionaryItemAlphabetJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestPronunciationDictionaryItemAlphabetNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestSttModeJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestSttModeNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.SubagentNodeVariant3TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SubagentNodeVariant3TypeNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.SmsUtteranceRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsUtteranceRoleNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.LanguageLegacyEnumJsonConverter),

            typeof(global::RetellAI.JsonConverters.LanguageLegacyEnumNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.Language3JsonConverter),

            typeof(global::RetellAI.JsonConverters.Language3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.LLMModelJsonConverter),

            typeof(global::RetellAI.JsonConverters.LLMModelNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPNodeVariant2TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPNodeVariant2TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPToolTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPToolTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPToolExecutionMessageTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPToolExecutionMessageTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.MessageBaseRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.MessageBaseRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ModelChoiceCascadingTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ModelChoiceCascadingTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NaturalnessIssueJsonConverter),

            typeof(global::RetellAI.JsonConverters.NaturalnessIssueNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionPromptTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionPromptTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionStaticTextTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionStaticTextTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsInstructionTemplateTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsInstructionTemplateTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsInstructionTemplateTemplateJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsInstructionTemplateTemplateNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionMessageBaseRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionMessageBaseRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionMessageBaseTransitionTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionMessageBaseTransitionTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionUtteranceRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionUtteranceRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionUtteranceTransitionTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionUtteranceTransitionTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NullableLLMModelJsonConverter),

            typeof(global::RetellAI.JsonConverters.NullableLLMModelNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NumberAnalysisDataTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.NumberAnalysisDataTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PresetAnalysisDataTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.PresetAnalysisDataTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PresetAnalysisDataNameJsonConverter),

            typeof(global::RetellAI.JsonConverters.PresetAnalysisDataNameNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallPresetAnalysisDataTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallPresetAnalysisDataTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallPresetAnalysisDataNameJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallPresetAnalysisDataNameNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatPresetAnalysisDataTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatPresetAnalysisDataTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatPresetAnalysisDataNameJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatPresetAnalysisDataNameNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.SendSMSToolExecutionMessageTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SendSMSToolExecutionMessageTypeNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.SmsContentTemplateTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsContentTemplateTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsContentTemplateTemplateJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsContentTemplateTemplateNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.StateTransitionMessageBaseRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.StateTransitionMessageBaseRoleNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ToolCallInvocationMessageBaseRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallInvocationMessageBaseRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallInvocationUtteranceRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallInvocationUtteranceRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallResultMessageBaseRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallResultMessageBaseRoleNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.V3CallBaseCallStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3CallBaseCallStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3CallBaseDataStorageSettingJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3CallBaseDataStorageSettingNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3PhoneCallResponseVariant1CallTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3PhoneCallResponseVariant1CallTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3PhoneCallResponseVariant1DirectionJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3PhoneCallResponseVariant1DirectionNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3WebCallResponseVariant1CallTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3WebCallResponseVariant1CallTypeNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListChatsV3RequestSortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3RequestSortOrderNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListCallsV3RequestSortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3RequestSortOrderNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2SortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2SortOrderNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListPhoneNumbersV2SortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListPhoneNumbersV2SortOrderNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2SortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2SortOrderNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus6JsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus6NullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatus4NullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatus4NullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus5NullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListVoicesResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListVoicesResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListVoicesResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListVoicesResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus5NullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatus4NullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentVersionReferenceJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentSwapNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.AnalysisDataJsonConverter),

            typeof(global::RetellAI.JsonConverters.PostCallAnalysisDataJsonConverter),

            typeof(global::RetellAI.JsonConverters.PostChatAnalysisDataJsonConverter),

            typeof(global::RetellAI.JsonConverters.BranchNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.BridgeTransferNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.CancelTransferNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatAgentResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3ChatResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.ComponentNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationFlowComponentResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationFlowNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationFlowResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationFlowJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SubagentNodeJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.LanguageLegacyJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.MessageOrToolCallJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatMessageInputJsonConverter),

            typeof(global::RetellAI.JsonConverters.MessageJsonConverter),

            typeof(global::RetellAI.JsonConverters.ModelChoiceJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeBaseJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeToolJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionMessageJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.StateTransitionMessageJsonConverter),

            typeof(global::RetellAI.JsonConverters.TestCaseDefinitionJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolMockInputMatchRuleJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallInvocationMessageJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallResultMessageJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferCallNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferDestinationJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferFailedEdgeJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferOptionJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateOrganizationRequestJsonConverter),

            typeof(global::RetellAI.JsonConverters.UtteranceOrToolCallJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2CallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3CallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3PhoneCallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3WebCallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2PhoneCallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2WebCallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.VoicemailActionJsonConverter),

            typeof(global::RetellAI.JsonConverters.IvrActionJsonConverter),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterDisconnectionReason>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.StringFilter, object>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterStatusCode>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.LanguageLegacy?, global::System.Collections.Generic.IList<global::RetellAI.Language3>>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<double?, string>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.LanguageLegacy?, global::System.Collections.Generic.IList<global::RetellAI.Language3>>),

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

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NodeInstruction?, global::RetellAI.SmsInstructionTemplate>),

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

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListChatsV3Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowComponentsV2Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowsV2Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListPhoneNumbersV2Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListRetellLLMV2Response2>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.AgentResponse?, global::RetellAI.ChatAgentResponse?>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListCallsV3Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListExportRequestsV2Response2>),

            typeof(global::RetellAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableLLMModel), TypeInfoPropertyName = "NullableLLMModel_RetellAI_NullableLLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatResponse), TypeInfoPropertyName = "ListChatResponse_RetellAI_ListChatResponse")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponse), TypeInfoPropertyName = "ListRetellLLMResponse_RetellAI_ListRetellLLMResponse")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.LLMModel?), TypeInfoPropertyName = "NullableLLMModel_RetellAI_LLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ChatResponse>), TypeInfoPropertyName = "ListChatResponse_System_Collections_Generic_List_global_RetellAI_ChatResponse")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.RetellLLMResponse>), TypeInfoPropertyName = "ListRetellLLMResponse_System_Collections_Generic_List_global_RetellAI_RetellLLMResponse")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponseStatus), TypeInfoPropertyName = "ListAgentsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListAgentsResponseStatus2), TypeInfoPropertyName = "ListAgentsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatAgentsResponseStatus), TypeInfoPropertyName = "ListChatAgentsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatAgentsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatAgentsResponseStatus2), TypeInfoPropertyName = "ListChatAgentsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ChatResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatResponseStatus), TypeInfoPropertyName = "ListChatResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatResponseStatus2), TypeInfoPropertyName = "ListChatResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListChatsV3Response2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListChatsV3Response22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsV3Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.V3ChatResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsV3Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsV3ResponseStatus), TypeInfoPropertyName = "ListChatsV3ResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsV3Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsV3ResponseStatus2), TypeInfoPropertyName = "ListChatsV3ResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsV3Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsV3ResponseStatus3), TypeInfoPropertyName = "ListChatsV3ResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsV3Response6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatsV3ResponseStatus4), TypeInfoPropertyName = "ListChatsV3ResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowComponentsV2Response2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListConversationFlowComponentsV2Response22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsV2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ConversationFlowComponentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsV2Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsV2ResponseStatus), TypeInfoPropertyName = "ListConversationFlowComponentsV2ResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsV2Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsV2ResponseStatus2), TypeInfoPropertyName = "ListConversationFlowComponentsV2ResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsV2Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsV2ResponseStatus3), TypeInfoPropertyName = "ListConversationFlowComponentsV2ResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsV2Response6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsV2ResponseStatus4), TypeInfoPropertyName = "ListConversationFlowComponentsV2ResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus), TypeInfoPropertyName = "ListConversationFlowComponentsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus2), TypeInfoPropertyName = "ListConversationFlowComponentsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus3), TypeInfoPropertyName = "ListConversationFlowComponentsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowComponentsResponseStatus4), TypeInfoPropertyName = "ListConversationFlowComponentsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowsV2Response2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListConversationFlowsV2Response22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsV2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ConversationFlowResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsV2Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsV2ResponseStatus), TypeInfoPropertyName = "ListConversationFlowsV2ResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsV2Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsV2ResponseStatus2), TypeInfoPropertyName = "ListConversationFlowsV2ResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsV2Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsV2ResponseStatus3), TypeInfoPropertyName = "ListConversationFlowsV2ResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsV2Response6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsV2ResponseStatus4), TypeInfoPropertyName = "ListConversationFlowsV2ResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsV2Response7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsV2ResponseStatus5), TypeInfoPropertyName = "ListConversationFlowsV2ResponseStatus52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponseStatus), TypeInfoPropertyName = "ListConversationFlowsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponseStatus2), TypeInfoPropertyName = "ListConversationFlowsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponseStatus3), TypeInfoPropertyName = "ListConversationFlowsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListConversationFlowsResponseStatus4), TypeInfoPropertyName = "ListConversationFlowsResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.KnowledgeBaseResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListKnowledgeBasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListKnowledgeBasesResponseStatus), TypeInfoPropertyName = "ListKnowledgeBasesResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListKnowledgeBasesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListKnowledgeBasesResponseStatus2), TypeInfoPropertyName = "ListKnowledgeBasesResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListKnowledgeBasesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListKnowledgeBasesResponseStatus3), TypeInfoPropertyName = "ListKnowledgeBasesResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListPhoneNumbersV2Response2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListPhoneNumbersV2Response22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersV2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.PhoneNumberResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersV2Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersV2ResponseStatus), TypeInfoPropertyName = "ListPhoneNumbersV2ResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersV2Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersV2ResponseStatus2), TypeInfoPropertyName = "ListPhoneNumbersV2ResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersResponseStatus), TypeInfoPropertyName = "ListPhoneNumbersResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListPhoneNumbersResponseStatus2), TypeInfoPropertyName = "ListPhoneNumbersResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.RetellLLMResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponseStatus), TypeInfoPropertyName = "ListRetellLLMResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponseStatus2), TypeInfoPropertyName = "ListRetellLLMResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListRetellLLMV2Response2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListRetellLLMV2Response22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMV2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMV2Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMV2ResponseStatus), TypeInfoPropertyName = "ListRetellLLMV2ResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMV2Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMV2ResponseStatus2), TypeInfoPropertyName = "ListRetellLLMV2ResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMV2Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMV2ResponseStatus3), TypeInfoPropertyName = "ListRetellLLMV2ResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMV2Response6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMV2ResponseStatus4), TypeInfoPropertyName = "ListRetellLLMV2ResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMV2Response7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMV2ResponseStatus5), TypeInfoPropertyName = "ListRetellLLMV2ResponseStatus52")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponseStatus), TypeInfoPropertyName = "UpdateConversationFlowResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponseStatus2), TypeInfoPropertyName = "UpdateConversationFlowResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponseStatus3), TypeInfoPropertyName = "UpdateConversationFlowResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponseStatus4), TypeInfoPropertyName = "UpdateConversationFlowResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateConversationFlowResponseStatus5), TypeInfoPropertyName = "UpdateConversationFlowResponseStatus52")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.V2CallResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponseStatus), TypeInfoPropertyName = "ListCallsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponseStatus2), TypeInfoPropertyName = "ListCallsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsResponseStatus3), TypeInfoPropertyName = "ListCallsResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListCallsV3Response2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListCallsV3Response22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsV3Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.V3CallResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsV3Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsV3ResponseStatus), TypeInfoPropertyName = "ListCallsV3ResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsV3Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsV3ResponseStatus2), TypeInfoPropertyName = "ListCallsV3ResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsV3Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsV3ResponseStatus3), TypeInfoPropertyName = "ListCallsV3ResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsV3Response6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListCallsV3ResponseStatus4), TypeInfoPropertyName = "ListCallsV3ResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListExportRequestsV2Response2>), TypeInfoPropertyName = "AllOfPaginatedResponseBaseListExportRequestsV2Response22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::RetellAI.ListExportRequestsV2ResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2ResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2ResponseItemChannel), TypeInfoPropertyName = "ListExportRequestsV2ResponseItemChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2ResponseItemStatus), TypeInfoPropertyName = "ListExportRequestsV2ResponseItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2ResponseStatus), TypeInfoPropertyName = "ListExportRequestsV2ResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2ResponseStatus2), TypeInfoPropertyName = "ListExportRequestsV2ResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2ResponseStatus3), TypeInfoPropertyName = "ListExportRequestsV2ResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2Response6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListExportRequestsV2ResponseStatus4), TypeInfoPropertyName = "ListExportRequestsV2ResponseStatus42")]
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
            typeof(global::RetellAI.JsonConverters.AlertMetricTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.AlertMetricTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AsrProviderJsonConverter),

            typeof(global::RetellAI.JsonConverters.AsrProviderNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.AgentRequestWebhookEventJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestWebhookEventNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestDataStorageSettingJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestDataStorageSettingNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestPronunciationDictionaryItemAlphabetJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestPronunciationDictionaryItemAlphabetNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestSttModeJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentRequestSttModeNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.SubagentNodeVariant3TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SubagentNodeVariant3TypeNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.SmsUtteranceRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsUtteranceRoleNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.LanguageLegacyEnumJsonConverter),

            typeof(global::RetellAI.JsonConverters.LanguageLegacyEnumNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.Language3JsonConverter),

            typeof(global::RetellAI.JsonConverters.Language3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.LLMModelJsonConverter),

            typeof(global::RetellAI.JsonConverters.LLMModelNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPNodeVariant2TypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPNodeVariant2TypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPToolTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPToolTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPToolExecutionMessageTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPToolExecutionMessageTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.MessageBaseRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.MessageBaseRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ModelChoiceCascadingTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ModelChoiceCascadingTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NaturalnessIssueJsonConverter),

            typeof(global::RetellAI.JsonConverters.NaturalnessIssueNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionPromptTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionPromptTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionStaticTextTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionStaticTextTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsInstructionTemplateTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsInstructionTemplateTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsInstructionTemplateTemplateJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsInstructionTemplateTemplateNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionMessageBaseRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionMessageBaseRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionMessageBaseTransitionTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionMessageBaseTransitionTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionUtteranceRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionUtteranceRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionUtteranceTransitionTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionUtteranceTransitionTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NullableLLMModelJsonConverter),

            typeof(global::RetellAI.JsonConverters.NullableLLMModelNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.NumberAnalysisDataTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.NumberAnalysisDataTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PresetAnalysisDataTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.PresetAnalysisDataTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PresetAnalysisDataNameJsonConverter),

            typeof(global::RetellAI.JsonConverters.PresetAnalysisDataNameNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallPresetAnalysisDataTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallPresetAnalysisDataTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallPresetAnalysisDataNameJsonConverter),

            typeof(global::RetellAI.JsonConverters.CallPresetAnalysisDataNameNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatPresetAnalysisDataTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatPresetAnalysisDataTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatPresetAnalysisDataNameJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatPresetAnalysisDataNameNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.SendSMSToolExecutionMessageTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SendSMSToolExecutionMessageTypeNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.SmsContentTemplateTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsContentTemplateTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsContentTemplateTemplateJsonConverter),

            typeof(global::RetellAI.JsonConverters.SmsContentTemplateTemplateNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.StateTransitionMessageBaseRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.StateTransitionMessageBaseRoleNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ToolCallInvocationMessageBaseRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallInvocationMessageBaseRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallInvocationUtteranceRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallInvocationUtteranceRoleNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallResultMessageBaseRoleJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallResultMessageBaseRoleNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.V3CallBaseCallStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3CallBaseCallStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3CallBaseDataStorageSettingJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3CallBaseDataStorageSettingNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3PhoneCallResponseVariant1CallTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3PhoneCallResponseVariant1CallTypeNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3PhoneCallResponseVariant1DirectionJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3PhoneCallResponseVariant1DirectionNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3WebCallResponseVariant1CallTypeJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3WebCallResponseVariant1CallTypeNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListChatsV3RequestSortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3RequestSortOrderNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListCallsV3RequestSortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3RequestSortOrderNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2SortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2SortOrderNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListPhoneNumbersV2SortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListPhoneNumbersV2SortOrderNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2SortOrderJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2SortOrderNullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus6JsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus6NullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteChatResponseStatus4NullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListChatsV3ResponseStatus4NullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus5NullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListVoicesResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListVoicesResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListVoicesResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListVoicesResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateAgentResponseStatus5NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus5JsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus5NullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.ListCallsV3ResponseStatus4NullableJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatusJsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatusNullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatus2JsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatus2NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatus3JsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatus3NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatus4JsonConverter),

            typeof(global::RetellAI.JsonConverters.StopCallResponseStatus4NullableJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentVersionReferenceJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.AgentSwapNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.AnalysisDataJsonConverter),

            typeof(global::RetellAI.JsonConverters.PostCallAnalysisDataJsonConverter),

            typeof(global::RetellAI.JsonConverters.PostChatAnalysisDataJsonConverter),

            typeof(global::RetellAI.JsonConverters.BranchNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.BridgeTransferNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.CancelTransferNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatAgentResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3ChatResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.ComponentNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationFlowComponentResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationFlowNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationFlowResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationFlowJsonConverter),

            typeof(global::RetellAI.JsonConverters.ConversationNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.SubagentNodeJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.LanguageLegacyJsonConverter),

            typeof(global::RetellAI.JsonConverters.MCPNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.MessageOrToolCallJsonConverter),

            typeof(global::RetellAI.JsonConverters.ChatMessageInputJsonConverter),

            typeof(global::RetellAI.JsonConverters.MessageJsonConverter),

            typeof(global::RetellAI.JsonConverters.ModelChoiceJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeBaseJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeInstructionJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeToolJsonConverter),

            typeof(global::RetellAI.JsonConverters.NodeTransitionMessageJsonConverter),

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

            typeof(global::RetellAI.JsonConverters.StateTransitionMessageJsonConverter),

            typeof(global::RetellAI.JsonConverters.TestCaseDefinitionJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolMockInputMatchRuleJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallInvocationMessageJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolCallResultMessageJsonConverter),

            typeof(global::RetellAI.JsonConverters.ToolJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferCallNodeJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferDestinationJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferFailedEdgeJsonConverter),

            typeof(global::RetellAI.JsonConverters.TransferOptionJsonConverter),

            typeof(global::RetellAI.JsonConverters.UpdateOrganizationRequestJsonConverter),

            typeof(global::RetellAI.JsonConverters.UtteranceOrToolCallJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2CallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3CallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3PhoneCallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V3WebCallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2PhoneCallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.V2WebCallResponseJsonConverter),

            typeof(global::RetellAI.JsonConverters.VoicemailActionJsonConverter),

            typeof(global::RetellAI.JsonConverters.IvrActionJsonConverter),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterDisconnectionReason>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.StringFilter, object>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterStatusCode>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.LanguageLegacy?, global::System.Collections.Generic.IList<global::RetellAI.Language3>>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<double?, string>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.LanguageLegacy?, global::System.Collections.Generic.IList<global::RetellAI.Language3>>),

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

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NodeInstruction?, global::RetellAI.SmsInstructionTemplate>),

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

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListChatsV3Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowComponentsV2Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowsV2Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListPhoneNumbersV2Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListRetellLLMV2Response2>),

            typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.AgentResponse?, global::RetellAI.ChatAgentResponse?>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListCallsV3Response2>),

            typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListExportRequestsV2Response2>),

            typeof(global::RetellAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.NullableLLMModel), TypeInfoPropertyName = "NullableLLMModel_RetellAI_NullableLLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListChatResponse), TypeInfoPropertyName = "ListChatResponse_RetellAI_ListChatResponse")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.ListRetellLLMResponse), TypeInfoPropertyName = "ListRetellLLMResponse_RetellAI_ListRetellLLMResponse")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.LLMModel?), TypeInfoPropertyName = "NullableLLMModel_RetellAI_LLMModel")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ChatResponse>), TypeInfoPropertyName = "ListChatResponse_System_Collections_Generic_List_global_RetellAI_ChatResponse")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.RetellLLMResponse>), TypeInfoPropertyName = "ListRetellLLMResponse_System_Collections_Generic_List_global_RetellAI_RetellLLMResponse")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponseStatus3), TypeInfoPropertyName = "UpdateCallMetadataResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.UpdateCallMetadataResponseStatus4), TypeInfoPropertyName = "UpdateCallMetadataResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StopCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StopCallResponseStatus), TypeInfoPropertyName = "StopCallResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StopCallResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StopCallResponseStatus2), TypeInfoPropertyName = "StopCallResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StopCallResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StopCallResponseStatus3), TypeInfoPropertyName = "StopCallResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StopCallResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.StopCallResponseStatus4), TypeInfoPropertyName = "StopCallResponseStatus42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AgentFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.DisconnectionReason4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CustomFieldFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AlertFilterStatusCodeValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AlertFilterErrorCodeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.UtteranceNaturalnessIssues>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::RetellAI.OneOf<global::RetellAI.LanguageLegacy?, global::System.Collections.Generic.List<global::RetellAI.Language3>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.Language3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AgentRequestWebhookEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AgentRequestPronunciationDictionaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.PostCallAnalysisData>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.PostChatAnalysisData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.MessageOrToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ProductCost>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CohortAggregatedResultTopQuestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.CohortAggregatedResultTopRecommendation>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.AllOf<global::RetellAI.StringFilter, global::RetellAI.CallFilterDynamicVariable>>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ChatMessageInput>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.V3ChatResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ConversationFlowComponentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ConversationFlowResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.KnowledgeBaseResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.PhoneNumberResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.VoiceResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.V2CallResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.V3CallResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::RetellAI.ListExportRequestsV2ResponseItem>))]
    internal sealed partial class SourceGenerationContextChunk3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = global::System.Text.Json.Serialization.Metadata.JsonTypeInfoResolver.Combine(
            SourceGenerationContextChunk0.Default,

            SourceGenerationContextChunk1.Default,

            SourceGenerationContextChunk2.Default,

            SourceGenerationContextChunk3.Default
            );

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
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertMetricTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertMetricTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AsrProviderJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AsrProviderNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertFilterStatusCodeValueItemJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertFilterStatusCodeValueItemNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertFilterErrorCodeItemJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertFilterErrorCodeItemNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertIncidentResponseThresholdTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertIncidentResponseThresholdTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertIncidentResponseComparatorJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertIncidentResponseComparatorNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertIncidentResponseFrequencyJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertIncidentResponseFrequencyNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertIncidentResponseWindowJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertIncidentResponseWindowNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertRuleRequestThresholdTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertRuleRequestThresholdTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertRuleRequestComparatorJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertRuleRequestComparatorNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertRuleRequestFrequencyJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertRuleRequestFrequencyNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertRuleRequestWindowJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertRuleRequestWindowNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertRuleResponseThresholdTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertRuleResponseThresholdTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertRuleResponseComparatorJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertRuleResponseComparatorNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertRuleResponseFrequencyJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertRuleResponseFrequencyNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertRuleResponseWindowJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlertRuleResponseWindowNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentRequestVoiceModelJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentRequestVoiceModelNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentRequestVoiceEmotionJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentRequestVoiceEmotionNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentRequestAmbientSoundJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentRequestAmbientSoundNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentRequestWebhookEventJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentRequestWebhookEventNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentRequestDataStorageSettingJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentRequestDataStorageSettingNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentRequestPronunciationDictionaryItemAlphabetJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentRequestPronunciationDictionaryItemAlphabetNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentRequestSttModeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentRequestSttModeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentRequestVocabSpecializationJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentRequestVocabSpecializationNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentRequestDenoisingModeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentRequestDenoisingModeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentSwapNodeVariant2TypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentSwapNodeVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentSwapToolTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentSwapToolTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentSwapToolExecutionMessageTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentSwapToolExecutionMessageTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentSwapWebhookSettingJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentSwapWebhookSettingNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.BookAppointmentCalToolTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.BookAppointmentCalToolTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.BooleanAnalysisDataTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.BooleanAnalysisDataTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.BranchNodeVariant2TypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.BranchNodeVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.BridgeTransferNodeVariant2TypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.BridgeTransferNodeVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.BridgeTransferToolTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.BridgeTransferToolTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.BridgeTransferToolExecutionMessageTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.BridgeTransferToolExecutionMessageTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CallAnalysisUserSentimentJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CallAnalysisUserSentimentNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CancelTransferNodeVariant2TypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CancelTransferNodeVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CancelTransferToolTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CancelTransferToolTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CancelTransferToolExecutionMessageTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CancelTransferToolExecutionMessageTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ChatAgentRequestWebhookEventJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ChatAgentRequestWebhookEventNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ChatAgentRequestDataStorageSettingJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ChatAgentRequestDataStorageSettingNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ChatAnalysisUserSentimentJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ChatAnalysisUserSentimentNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ChatResponseChatStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ChatResponseChatStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ChatResponseChatTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ChatResponseChatTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CheckAvailabilityCalToolTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CheckAvailabilityCalToolTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CohortAggregatedResultGroupByJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CohortAggregatedResultGroupByNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CohortFilterStartTimestampVariant1OpJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CohortFilterStartTimestampVariant1OpNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CohortFilterCallDurationFilterOpJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CohortFilterCallDurationFilterOpNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CohortSuccessfulCriteriaTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CohortSuccessfulCriteriaTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CohortSuccessfulCriteriaOpJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CohortSuccessfulCriteriaOpNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ComponentNodeVariant2TypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ComponentNodeVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ComponentNodeVariant2ComponentTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ComponentNodeVariant2ComponentTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConversationFlowOverrideStartSpeakerJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConversationFlowOverrideStartSpeakerNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConversationNodeVariant3TypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ConversationNodeVariant3TypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SubagentNodeVariant3TypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SubagentNodeVariant3TypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CustomToolTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CustomToolTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CustomToolMethodJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CustomToolMethodNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CustomToolExecutionMessageTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CustomToolExecutionMessageTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CodeToolTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CodeToolTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CodeToolExecutionMessageTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CodeToolExecutionMessageTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DTMFUtteranceRoleJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DTMFUtteranceRoleNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsUtteranceRoleJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsUtteranceRoleNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.StringFilterTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.StringFilterTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.StringFilterOpJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.StringFilterOpNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NumberFilterTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NumberFilterTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NumberFilterOpJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NumberFilterOpNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.BooleanFilterTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.BooleanFilterTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.BooleanFilterOpJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.BooleanFilterOpNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RangeFilterTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RangeFilterTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RangeFilterOpJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RangeFilterOpNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EnumFilterTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EnumFilterTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EnumFilterOpJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EnumFilterOpNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PresentFilterTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PresentFilterTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PresentFilterOpJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PresentFilterOpNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CallFilterCallStatusValueItemJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CallFilterCallStatusValueItemNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CallFilterCallTypeValueItemJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CallFilterCallTypeValueItemNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CallFilterDirectionValueItemJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CallFilterDirectionValueItemNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CallFilterUserSentimentValueItemJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CallFilterUserSentimentValueItemNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CallFilterDataStorageSettingValueItemJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CallFilterDataStorageSettingValueItemNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DayOfWeekJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DayOfWeekNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DisconnectionReason4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DisconnectionReason4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ElseEdgeVariant2TransitionConditionTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ElseEdgeVariant2TransitionConditionTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ElseEdgeVariant2TransitionConditionPromptJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ElseEdgeVariant2TransitionConditionPromptNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EndCallToolTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EndCallToolTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EndCallToolExecutionMessageTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EndCallToolExecutionMessageTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EndNodeVariant2TypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EndNodeVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EnumAnalysisDataTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EnumAnalysisDataTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EquationConditionTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EquationConditionTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EquationConditionOperatorJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EquationConditionOperatorNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EquationOperatorJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EquationOperatorNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ExtractDynamicVariableToolTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ExtractDynamicVariableToolTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ExtractDynamicVariablesNodeVariant2TypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ExtractDynamicVariablesNodeVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.FinetuneExampleUtteranceVariant1RoleJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.FinetuneExampleUtteranceVariant1RoleNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.FinetuneExampleUtteranceVariant2RoleJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.FinetuneExampleUtteranceVariant2RoleNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.FinetuneExampleUtteranceVariant3RoleJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.FinetuneExampleUtteranceVariant3RoleNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.FunctionNodeVariant2TypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.FunctionNodeVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.FunctionNodeVariant2ToolTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.FunctionNodeVariant2ToolTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CodeNodeVariant2TypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CodeNodeVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.HallucinationTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.HallucinationTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.KnowledgeBaseResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.KnowledgeBaseResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.KnowledgeBaseSourceDocumentTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.KnowledgeBaseSourceDocumentTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.KnowledgeBaseSourceTextTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.KnowledgeBaseSourceTextTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.KnowledgeBaseSourceUrlTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.KnowledgeBaseSourceUrlTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.LanguageLegacyEnumJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.LanguageLegacyEnumNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.Language3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.Language3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.LLMModelJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.LLMModelNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.MCPNodeVariant2TypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.MCPNodeVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.MCPToolTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.MCPToolTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.MCPToolExecutionMessageTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.MCPToolExecutionMessageTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.MessageBaseRoleJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.MessageBaseRoleNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ModelChoiceCascadingTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ModelChoiceCascadingTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NaturalnessIssueJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NaturalnessIssueNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NodeInstructionPromptTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NodeInstructionPromptTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NodeInstructionStaticTextTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NodeInstructionStaticTextTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsInstructionTemplateTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsInstructionTemplateTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsInstructionTemplateTemplateJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsInstructionTemplateTemplateNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NodeTransitionMessageBaseRoleJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NodeTransitionMessageBaseRoleNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NodeTransitionMessageBaseTransitionTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NodeTransitionMessageBaseTransitionTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NodeTransitionUtteranceRoleJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NodeTransitionUtteranceRoleNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NodeTransitionUtteranceTransitionTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NodeTransitionUtteranceTransitionTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NullableLLMModelJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NullableLLMModelNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NumberAnalysisDataTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.NumberAnalysisDataTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PresetAnalysisDataTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PresetAnalysisDataTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PresetAnalysisDataNameJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PresetAnalysisDataNameNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CallPresetAnalysisDataTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CallPresetAnalysisDataTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CallPresetAnalysisDataNameJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CallPresetAnalysisDataNameNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ChatPresetAnalysisDataTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ChatPresetAnalysisDataTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ChatPresetAnalysisDataNameJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ChatPresetAnalysisDataNameNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PIIConfigModeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PIIConfigModeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PIIConfigCategorieJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PIIConfigCategorieNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GuardrailConfigOutputTopicJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GuardrailConfigOutputTopicNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GuardrailConfigInputTopicJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GuardrailConfigInputTopicNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PerformanceMetricCriteriaOpJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PerformanceMetricCriteriaOpNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PhoneNumberResponsePhoneNumberTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PhoneNumberResponsePhoneNumberTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PostCallAnalysisSettingJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PostCallAnalysisSettingNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PressDigitNodeVariant2TypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PressDigitNodeVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PressDigitToolTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PressDigitToolTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PromptConditionTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PromptConditionTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.QaViewFilterScoreRangeTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.QaViewFilterScoreRangeTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.QaViewFilterScoreRangeOpJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.QaViewFilterScoreRangeOpNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ResponseEngineConversationFlowTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ResponseEngineConversationFlowTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ResponseEngineCustomLmTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ResponseEngineCustomLmTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ResponseEngineRetellLmTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ResponseEngineRetellLmTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RetellLlmOverrideS2sModelJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RetellLlmOverrideS2sModelNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RetellLlmOverrideStartSpeakerJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RetellLlmOverrideStartSpeakerNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SendSMSToolTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SendSMSToolTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SendSMSToolExecutionMessageTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SendSMSToolExecutionMessageTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsSenderVariant1TypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsSenderVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsSenderVariant2TypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsSenderVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsDestinationVariant1TypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsDestinationVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsDestinationVariant2TypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsDestinationVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SentimentAnalysisDetailVariant1SentimentJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SentimentAnalysisDetailVariant1SentimentNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SentimentAnalysisDetailVariant2SentimentJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SentimentAnalysisDetailVariant2SentimentNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SkipResponseEdgeVariant2TransitionConditionTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SkipResponseEdgeVariant2TransitionConditionTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SkipResponseEdgeVariant2TransitionConditionPromptJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SkipResponseEdgeVariant2TransitionConditionPromptNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlwaysEdgeVariant2TransitionConditionTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlwaysEdgeVariant2TransitionConditionTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlwaysEdgeVariant2TransitionConditionPromptJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AlwaysEdgeVariant2TransitionConditionPromptNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsContentInferredTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsContentInferredTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsContentPredefinedTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsContentPredefinedTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsContentTemplateTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsContentTemplateTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsContentTemplateTemplateJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsContentTemplateTemplateNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsFailedEdgeVariant2TransitionConditionTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsFailedEdgeVariant2TransitionConditionTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsFailedEdgeVariant2TransitionConditionPromptJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsFailedEdgeVariant2TransitionConditionPromptNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsNodeVariant2TypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsNodeVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsSuccessEdgeVariant2TransitionConditionTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsSuccessEdgeVariant2TransitionConditionTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsSuccessEdgeVariant2TransitionConditionPromptJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SmsSuccessEdgeVariant2TransitionConditionPromptNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.StateTransitionMessageBaseRoleJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.StateTransitionMessageBaseRoleNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.StringAnalysisDataTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.StringAnalysisDataTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TestCaseBatchJobStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TestCaseBatchJobStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TestCaseDefinitionVariant2TypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TestCaseDefinitionVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TestCaseJobStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TestCaseJobStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ToolMockInputMatchRuleVariant1TypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ToolMockInputMatchRuleVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ToolMockInputMatchRuleVariant2TypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ToolMockInputMatchRuleVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ToolCallInvocationMessageBaseRoleJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ToolCallInvocationMessageBaseRoleNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ToolCallInvocationUtteranceRoleJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ToolCallInvocationUtteranceRoleNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ToolCallResultMessageBaseRoleJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ToolCallResultMessageBaseRoleNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ToolCallResultUtteranceRoleJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ToolCallResultUtteranceRoleNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ToolParameterTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ToolParameterTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferCallNodeVariant2TypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferCallNodeVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferCallToolTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferCallToolTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferCallToolExecutionMessageTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferCallToolExecutionMessageTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferDestinationInferredTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferDestinationInferredTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferDestinationPredefinedTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferDestinationPredefinedTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferFailedEdgeVariant2TransitionConditionTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferFailedEdgeVariant2TransitionConditionTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferFailedEdgeVariant2TransitionConditionPromptJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferFailedEdgeVariant2TransitionConditionPromptNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferOptionAgenticWarmTransferTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferOptionAgenticWarmTransferTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferOptionAgenticWarmTransferOnHoldMusicJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferOptionAgenticWarmTransferOnHoldMusicNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeoutJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeoutNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferOptionColdTransferTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferOptionColdTransferTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferOptionColdTransferColdTransferModeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferOptionColdTransferColdTransferModeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferOptionWarmTransferTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferOptionWarmTransferTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferOptionWarmTransferOnHoldMusicJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.TransferOptionWarmTransferOnHoldMusicNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UtteranceRoleJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UtteranceRoleNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V2CallBaseCallStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V2CallBaseCallStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V2CallBaseDataStorageSettingJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V2CallBaseDataStorageSettingNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V3CallBaseCallStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V3CallBaseCallStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V3CallBaseDataStorageSettingJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V3CallBaseDataStorageSettingNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V3PhoneCallResponseVariant1CallTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V3PhoneCallResponseVariant1CallTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V3PhoneCallResponseVariant1DirectionJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V3PhoneCallResponseVariant1DirectionNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V3WebCallResponseVariant1CallTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V3WebCallResponseVariant1CallTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V2PhoneCallResponseVariant1CallTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V2PhoneCallResponseVariant1CallTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V2PhoneCallResponseVariant1DirectionJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V2PhoneCallResponseVariant1DirectionNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V2WebCallResponseVariant1CallTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V2WebCallResponseVariant1CallTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.VoiceResponseProviderJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.VoiceResponseProviderNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.VoiceResponseGenderJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.VoiceResponseGenderNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.VoicemailActionBridgeTransferTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.VoicemailActionBridgeTransferTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.VoicemailActionHangupTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.VoicemailActionHangupTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.VoicemailActionPromptTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.VoicemailActionPromptTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.VoicemailActionStaticTextTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.VoicemailActionStaticTextTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.IvrActionHangupTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.IvrActionHangupTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.WarmTransferPromptTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.WarmTransferPromptTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.WarmTransferStaticMessageTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.WarmTransferStaticMessageTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreatePhoneNumberRequestNumberProviderJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreatePhoneNumberRequestNumberProviderNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreatePhoneNumberRequestCountryCodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreatePhoneNumberRequestCountryCodeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CloneVoiceRequestVoiceProviderJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CloneVoiceRequestVoiceProviderNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AddCommunityVoiceRequestVoiceProviderJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AddCommunityVoiceRequestVoiceProviderNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SearchCommunityVoiceRequestVoiceProviderJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SearchCommunityVoiceRequestVoiceProviderNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListChatsV3RequestSortOrderJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListChatsV3RequestSortOrderNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateChatMetadataRequestDataStorageSettingJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateChatMetadataRequestDataStorageSettingNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsRequestFilterCriteriaCallStatuJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsRequestFilterCriteriaCallStatuNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsRequestFilterCriteriaCallTypeItemJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsRequestFilterCriteriaCallTypeItemNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsRequestFilterCriteriaDirectionItemJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsRequestFilterCriteriaDirectionItemNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsRequestFilterCriteriaUserSentimentItemJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsRequestFilterCriteriaUserSentimentItemNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsRequestSortOrderJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsRequestSortOrderNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsV3RequestSortOrderJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsV3RequestSortOrderNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RegisterPhoneCallRequestDirectionJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RegisterPhoneCallRequestDirectionNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateCallMetadataRequestDataStorageSettingJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateCallMetadataRequestDataStorageSettingNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestCaseDefinitionsTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestCaseDefinitionsTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestCaseDefinitionsV2TypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestCaseDefinitionsV2TypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListBatchTestsTypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListBatchTestsTypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListBatchTestsV2TypeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListBatchTestsV2TypeNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListChatSortOrderJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListChatSortOrderNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowComponentsV2SortOrderJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowComponentsV2SortOrderNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowsV2SortOrderJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowsV2SortOrderNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListPhoneNumbersV2SortOrderJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListPhoneNumbersV2SortOrderNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListRetellLLMV2SortOrderJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListRetellLLMV2SortOrderNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListExportRequestsV2SortOrderJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListExportRequestsV2SortOrderNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AddKnowledgeBaseSourcesResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateAgentResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateAgentResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateAgentResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateAgentResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateAgentResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateAgentResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateAgentResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateAgentResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateBatchCallResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateBatchCallResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateBatchCallResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateBatchCallResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateBatchCallResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateBatchCallResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateBatchCallResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateBatchCallResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateBatchTestResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateBatchTestResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateBatchTestResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateBatchTestResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateBatchTestResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateBatchTestResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateBatchTestResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateBatchTestResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateBatchTestResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateBatchTestResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateTestCaseDefinitionResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteTestCaseDefinitionResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetTestCaseDefinitionResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestCaseDefinitionsResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestCaseDefinitionsV2ResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestCaseDefinitionsV2ResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestCaseDefinitionsV2ResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestCaseDefinitionsV2ResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestCaseDefinitionsV2ResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestCaseDefinitionsV2ResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestCaseDefinitionsV2ResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestCaseDefinitionsV2ResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateTestCaseDefinitionResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetBatchTestResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetBatchTestResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetBatchTestResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetBatchTestResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetBatchTestResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetBatchTestResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetBatchTestResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetBatchTestResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetBatchTestResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetBatchTestResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListBatchTestsResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListBatchTestsResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListBatchTestsResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListBatchTestsResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListBatchTestsResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListBatchTestsResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListBatchTestsResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListBatchTestsResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListBatchTestsV2ResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListBatchTestsV2ResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListBatchTestsV2ResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListBatchTestsV2ResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListBatchTestsV2ResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListBatchTestsV2ResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListBatchTestsV2ResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListBatchTestsV2ResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetTestRunResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetTestRunResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetTestRunResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetTestRunResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetTestRunResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetTestRunResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetTestRunResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetTestRunResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetTestRunResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetTestRunResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestRunsResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestRunsResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestRunsResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestRunsResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestRunsResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestRunsResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestRunsResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestRunsResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestRunsResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestRunsResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestRunsV2ResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestRunsV2ResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestRunsV2ResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestRunsV2ResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestRunsV2ResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestRunsV2ResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestRunsV2ResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestRunsV2ResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestRunsV2ResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListTestRunsV2ResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatAgentResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatAgentResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatAgentResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatAgentResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatAgentResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatAgentResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatAgentResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatAgentResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus6JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentPlaygroundCompletionResponseStatus6NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus6JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatCompletionResponseStatus6NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatResponseStatus6JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateChatResponseStatus6NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateConversationFlowComponentResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateConversationFlowResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateConversationFlowResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateConversationFlowResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateConversationFlowResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateConversationFlowResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateConversationFlowResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateConversationFlowResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateConversationFlowResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateConversationFlowResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateConversationFlowResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateKnowledgeBaseResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreatePhoneNumberResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreatePhoneNumberResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreatePhoneNumberResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreatePhoneNumberResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreatePhoneNumberResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreatePhoneNumberResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateRetellLLMResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateRetellLLMResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateRetellLLMResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateRetellLLMResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateRetellLLMResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateRetellLLMResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateSmsChatResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateSmsChatResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateSmsChatResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateSmsChatResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateSmsChatResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateSmsChatResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateSmsChatResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateSmsChatResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateSmsChatResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateSmsChatResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateSmsChatResponseStatus6JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateSmsChatResponseStatus6NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteAgentResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteAgentResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteAgentResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteAgentResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteAgentResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteAgentResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteAgentResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteAgentResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteChatResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteChatResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteChatResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteChatResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteChatResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteChatResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteChatResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteChatResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteChatAgentResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteChatAgentResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteChatAgentResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteChatAgentResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteChatAgentResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteChatAgentResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteChatAgentResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteChatAgentResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteConversationFlowComponentResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteConversationFlowResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteKnowledgeBaseSourceResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteKnowledgeBaseResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeletePhoneNumberResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeletePhoneNumberResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeletePhoneNumberResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeletePhoneNumberResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeletePhoneNumberResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeletePhoneNumberResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteRetellLLMResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EndChatResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EndChatResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EndChatResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EndChatResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EndChatResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EndChatResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EndChatResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EndChatResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetAgentVersionsResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetAgentVersionsResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetAgentVersionsResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetAgentVersionsResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetAgentVersionsResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetAgentVersionsResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetAgentVersionsResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetAgentVersionsResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetAgentResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetAgentResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetAgentResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetAgentResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetAgentResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetAgentResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetAgentResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetAgentResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetChatAgentVersionsResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetChatAgentVersionsResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetChatAgentVersionsResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetChatAgentVersionsResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetChatAgentVersionsResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetChatAgentVersionsResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetChatAgentResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetChatAgentResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetChatAgentResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetChatAgentResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetChatAgentResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetChatAgentResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetChatAgentResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetChatAgentResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetChatResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetChatResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetChatResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetChatResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetChatResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetChatResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetChatResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetChatResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetConcurrencyResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetConcurrencyResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetConcurrencyResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetConcurrencyResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetConversationFlowComponentResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetConversationFlowResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetConversationFlowResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetConversationFlowResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetConversationFlowResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetConversationFlowResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetConversationFlowResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetConversationFlowResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetConversationFlowResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetConversationFlowResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetConversationFlowResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetKnowledgeBaseResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetMCPToolsResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetMCPToolsResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetMCPToolsResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetMCPToolsResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetMCPToolsResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetMCPToolsResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetMCPToolsResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetMCPToolsResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetPhoneNumberResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetPhoneNumberResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetPhoneNumberResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetPhoneNumberResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetPhoneNumberResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetPhoneNumberResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetPhoneNumberResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetPhoneNumberResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetRetellLLMResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetRetellLLMResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetRetellLLMResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetRetellLLMResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetRetellLLMResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetRetellLLMResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetRetellLLMResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetRetellLLMResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetVoiceResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetVoiceResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetVoiceResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetVoiceResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetVoiceResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetVoiceResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetVoiceResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetVoiceResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CloneVoiceResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CloneVoiceResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CloneVoiceResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CloneVoiceResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CloneVoiceResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CloneVoiceResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CloneVoiceResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CloneVoiceResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CloneVoiceResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CloneVoiceResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AddCommunityVoiceResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.SearchCommunityVoiceResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ImportPhoneNumberResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ImportPhoneNumberResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ImportPhoneNumberResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ImportPhoneNumberResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ImportPhoneNumberResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ImportPhoneNumberResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListAgentsResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListAgentsResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListAgentsResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListAgentsResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListChatAgentsResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListChatAgentsResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListChatAgentsResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListChatAgentsResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListChatResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListChatResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListChatResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListChatResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListChatsV3ResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListChatsV3ResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListChatsV3ResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListChatsV3ResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListChatsV3ResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListChatsV3ResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListChatsV3ResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListChatsV3ResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowComponentsV2ResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowComponentsV2ResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowComponentsV2ResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowComponentsV2ResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowComponentsV2ResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowComponentsV2ResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowComponentsV2ResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowComponentsV2ResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowComponentsResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowsResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowsResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowsResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowsResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowsResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowsResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowsResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListConversationFlowsResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListKnowledgeBasesResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListKnowledgeBasesResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListKnowledgeBasesResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListKnowledgeBasesResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListKnowledgeBasesResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListKnowledgeBasesResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListPhoneNumbersV2ResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListPhoneNumbersV2ResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListPhoneNumbersV2ResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListPhoneNumbersV2ResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListPhoneNumbersResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListPhoneNumbersResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListPhoneNumbersResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListPhoneNumbersResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListRetellLLMResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListRetellLLMResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListRetellLLMResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListRetellLLMResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListRetellLLMV2ResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListVoicesResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListVoicesResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListVoicesResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListVoicesResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateAgentVersionResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateAgentVersionResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateAgentVersionResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PublishAgentVersionResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PublishAgentVersionResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PublishAgentVersionResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteAgentVersionResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateAgentResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateAgentResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateAgentResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateAgentResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateAgentResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateAgentResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateAgentResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateAgentResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateAgentResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateAgentResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateChatAgentResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateChatAgentResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateChatAgentResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateChatMetadataResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateConversationFlowComponentResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdatePhoneNumberResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateRetellLLMResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus6JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreatePhoneCallResponseStatus6NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateWebCallResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateWebCallResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateWebCallResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateWebCallResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateWebCallResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateWebCallResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateWebCallResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateWebCallResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateWebCallResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateWebCallResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateWebCallResponseStatus6JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CreateWebCallResponseStatus6NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteCallResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteCallResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteCallResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteCallResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteCallResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteCallResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteCallResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.DeleteCallResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetCallResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetCallResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetCallResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetCallResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetCallResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetCallResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetCallResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.GetCallResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsV3ResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsV3ResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsV3ResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsV3ResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsV3ResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsV3ResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsV3ResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListCallsV3ResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListExportRequestsV2ResponseItemChannelJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListExportRequestsV2ResponseItemChannelNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListExportRequestsV2ResponseItemStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListExportRequestsV2ResponseItemStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListExportRequestsV2ResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListExportRequestsV2ResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListExportRequestsV2ResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListExportRequestsV2ResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListExportRequestsV2ResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListExportRequestsV2ResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListExportRequestsV2ResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ListExportRequestsV2ResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus5JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus5NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus6JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.RegisterPhoneCallResponseStatus6NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateCallMetadataResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.StopCallResponseStatusJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.StopCallResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.StopCallResponseStatus2JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.StopCallResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.StopCallResponseStatus3JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.StopCallResponseStatus3NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.StopCallResponseStatus4JsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.StopCallResponseStatus4NullableJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentVersionReferenceJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AgentSwapNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AnalysisDataJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PostCallAnalysisDataJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.PostChatAnalysisDataJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.BranchNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.BridgeTransferNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CancelTransferNodeJsonConverter());
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
            options.Converters.Add(new global::RetellAI.JsonConverters.ElseEdgeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.EndNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ExtractDynamicVariablesNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.FinetuneExampleUtteranceJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.FunctionNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.CodeNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.LanguageLegacyJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.MCPNodeJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.MessageOrToolCallJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.ChatMessageInputJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.MessageJsonConverter());
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
            options.Converters.Add(new global::RetellAI.JsonConverters.UpdateOrganizationRequestJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.UtteranceOrToolCallJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V2CallResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V3CallResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V3PhoneCallResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V3WebCallResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V2PhoneCallResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.V2WebCallResponseJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.VoicemailActionJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.IvrActionJsonConverter());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterDisconnectionReason>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.StringFilter, object>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.AlertFilterStatusCode>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.LanguageLegacy?, global::System.Collections.Generic.IList<global::RetellAI.Language3>>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.LanguageLegacy?, global::System.Collections.Generic.IList<global::RetellAI.Language3>>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.AllOf<global::RetellAI.NumberFilter, global::RetellAI.CohortFilterStartTimestampVariant1>?, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.CohortFilterStartTimestampVariant1>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.CohortFilterDisconnectionReason>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>());
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
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.StringFilter, global::RetellAI.CallFilterDynamicVariable>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.KnowledgeBaseSourceDocument, global::RetellAI.KnowledgeBaseSourceText, global::RetellAI.KnowledgeBaseSourceUrl>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.PerformanceMetricCriteria, global::RetellAI.CustomMetricCriteria>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<double?, bool?, string>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.PromptCondition, global::RetellAI.EquationCondition>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.CustomTool, global::RetellAI.CheckAvailabilityCalTool, global::RetellAI.BookAppointmentCalTool>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.QaViewFilterDisconnectionReason>());
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
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListTestCaseDefinitionsV2Response2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListBatchTestsV2Response2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListTestRunsV2Response2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListChatsV3Response2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowComponentsV2Response2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListConversationFlowsV2Response2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListPhoneNumbersV2Response2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListRetellLLMV2Response2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.AgentResponse?, global::RetellAI.ChatAgentResponse?>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListCallsV3Response2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListExportRequestsV2Response2>());
            options.Converters.Add(new global::RetellAI.JsonConverters.UnixTimestampJsonConverter());

            return options;
        }
    }
}