
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Current processing state of the knowledge base:<br/>
    /// - `in_progress`: Initial indexing is running. Source metadata may be<br/>
    ///   incomplete until indexing finishes.<br/>
    /// - `complete`: Initial indexing or the latest update or refresh<br/>
    ///   finished. Individual source failures may still be reported in<br/>
    ///   `error_messages`.<br/>
    /// - `error`: Initial indexing failed. Source metadata may be incomplete.<br/>
    /// - `refreshing_in_progress`: An existing knowledge base is being<br/>
    ///   updated. This includes indexing newly added sources or running a<br/>
    ///   manual or automatic refresh that re-indexes URLs, Google Drive<br/>
    ///   files, and pages from auto-crawling paths. Previously indexed<br/>
    ///   sources remain available during the update, and the source list<br/>
    ///   may change when it finishes.<br/>
    /// Example: in_progress
    /// </summary>
    public enum KnowledgeBaseResponseStatus
    {
        /// <summary>
        /// Initial indexing or the latest update or refresh
        /// </summary>
        Complete,
        /// <summary>
        /// Initial indexing failed. Source metadata may be incomplete.
        /// </summary>
        Error,
        /// <summary>
        /// Initial indexing is running. Source metadata may be
        /// </summary>
        InProgress,
        /// <summary>
        /// An existing knowledge base is being
        /// </summary>
        RefreshingInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeBaseResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeBaseResponseStatus value)
        {
            return value switch
            {
                KnowledgeBaseResponseStatus.Complete => "complete",
                KnowledgeBaseResponseStatus.Error => "error",
                KnowledgeBaseResponseStatus.InProgress => "in_progress",
                KnowledgeBaseResponseStatus.RefreshingInProgress => "refreshing_in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeBaseResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "complete" => KnowledgeBaseResponseStatus.Complete,
                "error" => KnowledgeBaseResponseStatus.Error,
                "in_progress" => KnowledgeBaseResponseStatus.InProgress,
                "refreshing_in_progress" => KnowledgeBaseResponseStatus.RefreshingInProgress,
                _ => null,
            };
        }
    }
}