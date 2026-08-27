
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum TestAppAuthResponseStatus4
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestAppAuthResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestAppAuthResponseStatus4 value)
        {
            return value switch
            {
                TestAppAuthResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestAppAuthResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => TestAppAuthResponseStatus4.Error,
                _ => null,
            };
        }
    }
}