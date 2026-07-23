
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListExportRequestsResponseItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListExportRequestsResponseItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListExportRequestsResponseItemStatus value)
        {
            return value switch
            {
                ListExportRequestsResponseItemStatus.Completed => "completed",
                ListExportRequestsResponseItemStatus.Created => "created",
                ListExportRequestsResponseItemStatus.Error => "error",
                ListExportRequestsResponseItemStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListExportRequestsResponseItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ListExportRequestsResponseItemStatus.Completed,
                "created" => ListExportRequestsResponseItemStatus.Created,
                "error" => ListExportRequestsResponseItemStatus.Error,
                "processing" => ListExportRequestsResponseItemStatus.Processing,
                _ => null,
            };
        }
    }
}