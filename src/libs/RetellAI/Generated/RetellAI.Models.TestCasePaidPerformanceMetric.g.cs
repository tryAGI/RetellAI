
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// A paid performance metric category. `node_transition_inaccuracy` only applies to conversation flow agents, and `transcription` only to audio test cases.
    /// </summary>
    public enum TestCasePaidPerformanceMetric
    {
        /// <summary>
        ///
        /// </summary>
        AgentHallucination,
        /// <summary>
        ///
        /// </summary>
        NodeTransitionInaccuracy,
        /// <summary>
        ///
        /// </summary>
        RagAccuracy,
        /// <summary>
        ///
        /// </summary>
        ToolCallInaccuracy,
        /// <summary>
        ///
        /// </summary>
        Transcription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestCasePaidPerformanceMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestCasePaidPerformanceMetric value)
        {
            return value switch
            {
                TestCasePaidPerformanceMetric.AgentHallucination => "agent_hallucination",
                TestCasePaidPerformanceMetric.NodeTransitionInaccuracy => "node_transition_inaccuracy",
                TestCasePaidPerformanceMetric.RagAccuracy => "rag_accuracy",
                TestCasePaidPerformanceMetric.ToolCallInaccuracy => "tool_call_inaccuracy",
                TestCasePaidPerformanceMetric.Transcription => "transcription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestCasePaidPerformanceMetric? ToEnum(string value)
        {
            return value switch
            {
                "agent_hallucination" => TestCasePaidPerformanceMetric.AgentHallucination,
                "node_transition_inaccuracy" => TestCasePaidPerformanceMetric.NodeTransitionInaccuracy,
                "rag_accuracy" => TestCasePaidPerformanceMetric.RagAccuracy,
                "tool_call_inaccuracy" => TestCasePaidPerformanceMetric.ToolCallInaccuracy,
                "transcription" => TestCasePaidPerformanceMetric.Transcription,
                _ => null,
            };
        }
    }
}