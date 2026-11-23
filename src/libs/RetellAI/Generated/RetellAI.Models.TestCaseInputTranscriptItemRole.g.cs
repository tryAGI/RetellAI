
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum TestCaseInputTranscriptItemRole
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestCaseInputTranscriptItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestCaseInputTranscriptItemRole value)
        {
            return value switch
            {
                TestCaseInputTranscriptItemRole.Agent => "agent",
                TestCaseInputTranscriptItemRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestCaseInputTranscriptItemRole? ToEnum(string value)
        {
            return value switch
            {
                "agent" => TestCaseInputTranscriptItemRole.Agent,
                "user" => TestCaseInputTranscriptItemRole.User,
                _ => null,
            };
        }
    }
}