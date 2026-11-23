
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Status of the test run. `pending` means the run is queued but has not started yet; it becomes `in_progress` once it starts, then resolves to `pass`, `fail`, or `error`. `cancelled` means the batch test was cancelled before the run finished.
    /// </summary>
    public enum TestCaseJobV3BaseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Cancelled,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Fail,
        /// <summary>
        ///
        /// </summary>
        InProgress,
        /// <summary>
        ///
        /// </summary>
        Pass,
        /// <summary>
        ///
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestCaseJobV3BaseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestCaseJobV3BaseStatus value)
        {
            return value switch
            {
                TestCaseJobV3BaseStatus.Cancelled => "cancelled",
                TestCaseJobV3BaseStatus.Error => "error",
                TestCaseJobV3BaseStatus.Fail => "fail",
                TestCaseJobV3BaseStatus.InProgress => "in_progress",
                TestCaseJobV3BaseStatus.Pass => "pass",
                TestCaseJobV3BaseStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestCaseJobV3BaseStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => TestCaseJobV3BaseStatus.Cancelled,
                "error" => TestCaseJobV3BaseStatus.Error,
                "fail" => TestCaseJobV3BaseStatus.Fail,
                "in_progress" => TestCaseJobV3BaseStatus.InProgress,
                "pass" => TestCaseJobV3BaseStatus.Pass,
                "pending" => TestCaseJobV3BaseStatus.Pending,
                _ => null,
            };
        }
    }
}