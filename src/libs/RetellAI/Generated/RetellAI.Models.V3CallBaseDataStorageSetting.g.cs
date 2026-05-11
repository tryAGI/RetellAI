
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Data storage setting for this call's agent. "everything" stores all data, "everything_except_pii" excludes PII when possible, "basic_attributes_only" stores only metadata.<br/>
    /// Example: everything
    /// </summary>
    public enum V3CallBaseDataStorageSetting
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
    public static class V3CallBaseDataStorageSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V3CallBaseDataStorageSetting value)
        {
            return value switch
            {
                V3CallBaseDataStorageSetting.BasicAttributesOnly => "basic_attributes_only",
                V3CallBaseDataStorageSetting.Everything => "everything",
                V3CallBaseDataStorageSetting.EverythingExceptPii => "everything_except_pii",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V3CallBaseDataStorageSetting? ToEnum(string value)
        {
            return value switch
            {
                "basic_attributes_only" => V3CallBaseDataStorageSetting.BasicAttributesOnly,
                "everything" => V3CallBaseDataStorageSetting.Everything,
                "everything_except_pii" => V3CallBaseDataStorageSetting.EverythingExceptPii,
                _ => null,
            };
        }
    }
}