
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Status of the batch test. `cancelling` means cancellation was requested and runs are still stopping; it becomes `cancelled` once they have stopped.
    /// </summary>
    public enum TestCaseBatchJobV3Status
    {
        /// <summary>
        ///
        /// </summary>
        Cancelled,
        /// <summary>
        ///
        /// </summary>
        Cancelling,
        /// <summary>
        ///
        /// </summary>
        Complete,
        /// <summary>
        ///
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestCaseBatchJobV3StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestCaseBatchJobV3Status value)
        {
            return value switch
            {
                TestCaseBatchJobV3Status.Cancelled => "cancelled",
                TestCaseBatchJobV3Status.Cancelling => "cancelling",
                TestCaseBatchJobV3Status.Complete => "complete",
                TestCaseBatchJobV3Status.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestCaseBatchJobV3Status? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => TestCaseBatchJobV3Status.Cancelled,
                "cancelling" => TestCaseBatchJobV3Status.Cancelling,
                "complete" => TestCaseBatchJobV3Status.Complete,
                "in_progress" => TestCaseBatchJobV3Status.InProgress,
                _ => null,
            };
        }
    }
}