
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// How to reconcile the new value with what the contact already holds. `overwrite` always replaces it, `fill_if_empty` writes only when the field is empty, and `merge` combines the existing text with the new value. `merge` is available on string fields only.
    /// </summary>
    public enum CRMAnalysisDataMappingUpdateMode
    {
        /// <summary>
        ///
        /// </summary>
        FillIfEmpty,
        /// <summary>
        ///
        /// </summary>
        Merge,
        /// <summary>
        ///
        /// </summary>
        Overwrite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CRMAnalysisDataMappingUpdateModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CRMAnalysisDataMappingUpdateMode value)
        {
            return value switch
            {
                CRMAnalysisDataMappingUpdateMode.FillIfEmpty => "fill_if_empty",
                CRMAnalysisDataMappingUpdateMode.Merge => "merge",
                CRMAnalysisDataMappingUpdateMode.Overwrite => "overwrite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CRMAnalysisDataMappingUpdateMode? ToEnum(string value)
        {
            return value switch
            {
                "fill_if_empty" => CRMAnalysisDataMappingUpdateMode.FillIfEmpty,
                "merge" => CRMAnalysisDataMappingUpdateMode.Merge,
                "overwrite" => CRMAnalysisDataMappingUpdateMode.Overwrite,
                _ => null,
            };
        }
    }
}