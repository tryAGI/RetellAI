
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum AlertRuleAppUsageType
    {
        /// <summary>
        ///
        /// </summary>
        AlertRule,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertRuleAppUsageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertRuleAppUsageType value)
        {
            return value switch
            {
                AlertRuleAppUsageType.AlertRule => "alert_rule",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertRuleAppUsageType? ToEnum(string value)
        {
            return value switch
            {
                "alert_rule" => AlertRuleAppUsageType.AlertRule,
                _ => null,
            };
        }
    }
}