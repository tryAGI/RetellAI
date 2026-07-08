
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Data storage setting for this call. Overrides the agent's default setting. "everything" stores all data, "everything_except_pii" excludes PII when possible, "basic_attributes_only" stores only metadata. Cannot be downgraded from more restrictive to less restrictive settings.<br/>
    /// Example: everything_except_pii
    /// </summary>
    public enum UpdateLiveCallRequestFieldsToOverrideDataStorageSetting
    {
        /// <summary>
        /// 
        /// </summary>
        BasicAttributesOnly,
        /// <summary>
        /// 
        /// </summary>
        Everything,
        /// <summary>
        /// 
        /// </summary>
        EverythingExceptPii,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateLiveCallRequestFieldsToOverrideDataStorageSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateLiveCallRequestFieldsToOverrideDataStorageSetting value)
        {
            return value switch
            {
                UpdateLiveCallRequestFieldsToOverrideDataStorageSetting.BasicAttributesOnly => "basic_attributes_only",
                UpdateLiveCallRequestFieldsToOverrideDataStorageSetting.Everything => "everything",
                UpdateLiveCallRequestFieldsToOverrideDataStorageSetting.EverythingExceptPii => "everything_except_pii",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateLiveCallRequestFieldsToOverrideDataStorageSetting? ToEnum(string value)
        {
            return value switch
            {
                "basic_attributes_only" => UpdateLiveCallRequestFieldsToOverrideDataStorageSetting.BasicAttributesOnly,
                "everything" => UpdateLiveCallRequestFieldsToOverrideDataStorageSetting.Everything,
                "everything_except_pii" => UpdateLiveCallRequestFieldsToOverrideDataStorageSetting.EverythingExceptPii,
                _ => null,
            };
        }
    }
}