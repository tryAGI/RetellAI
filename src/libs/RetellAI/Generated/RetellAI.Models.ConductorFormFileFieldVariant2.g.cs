
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConductorFormFileFieldVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ConductorFormFileFieldVariant2KindJsonConverter))]
        public global::RetellAI.ConductorFormFileFieldVariant2Kind Kind { get; set; }

        /// <summary>
        /// Most files the user can attach to this field. The max_files of all file fields in a form must add up to 10 or less.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxFiles { get; set; }

        /// <summary>
        /// Allowed extensions without the dot. Leave out to allow every supported type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accept")]
        public global::System.Collections.Generic.IList<global::RetellAI.ConductorFormFileFieldVariant2AcceptItem>? Accept { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormFileFieldVariant2" /> class.
        /// </summary>
        /// <param name="maxFiles">
        /// Most files the user can attach to this field. The max_files of all file fields in a form must add up to 10 or less.
        /// </param>
        /// <param name="kind"></param>
        /// <param name="accept">
        /// Allowed extensions without the dot. Leave out to allow every supported type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConductorFormFileFieldVariant2(
            int maxFiles,
            global::RetellAI.ConductorFormFileFieldVariant2Kind kind,
            global::System.Collections.Generic.IList<global::RetellAI.ConductorFormFileFieldVariant2AcceptItem>? accept)
        {
            this.Kind = kind;
            this.MaxFiles = maxFiles;
            this.Accept = accept;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormFileFieldVariant2" /> class.
        /// </summary>
        public ConductorFormFileFieldVariant2()
        {
        }

    }
}