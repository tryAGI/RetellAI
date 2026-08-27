
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum TestAppAuthResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestAppAuthResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestAppAuthResponseStatus value)
        {
            return value switch
            {
                TestAppAuthResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestAppAuthResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => TestAppAuthResponseStatus.Error,
                _ => null,
            };
        }
    }
}