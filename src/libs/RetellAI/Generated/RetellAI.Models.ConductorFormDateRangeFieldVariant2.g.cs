
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConductorFormDateRangeFieldVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ConductorFormDateRangeFieldVariant2KindJsonConverter))]
        public global::RetellAI.ConductorFormDateRangeFieldVariant2Kind Kind { get; set; }

        /// <summary>
        /// When true, the user also picks times, and dates are ISO datetimes with an offset (`2026-10-21T09:00:00-07:00`). Otherwise dates are ISO dates (`2026-10-21`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includes_time")]
        public bool? IncludesTime { get; set; }

        /// <summary>
        /// Earliest allowed date, in the same format as the answer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        public string? Min { get; set; }

        /// <summary>
        /// Latest allowed date, in the same format as the answer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        public string? Max { get; set; }

        /// <summary>
        /// ISO dates (`2026-10-21`), or ISO datetimes with an offset (`2026-10-21T09:00:00-07:00`) when the field `includes_time`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_value")]
        public global::RetellAI.ConductorFormDateRangeValue? DefaultValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormDateRangeFieldVariant2" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="includesTime">
        /// When true, the user also picks times, and dates are ISO datetimes with an offset (`2026-10-21T09:00:00-07:00`). Otherwise dates are ISO dates (`2026-10-21`).
        /// </param>
        /// <param name="min">
        /// Earliest allowed date, in the same format as the answer.
        /// </param>
        /// <param name="max">
        /// Latest allowed date, in the same format as the answer.
        /// </param>
        /// <param name="defaultValue">
        /// ISO dates (`2026-10-21`), or ISO datetimes with an offset (`2026-10-21T09:00:00-07:00`) when the field `includes_time`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConductorFormDateRangeFieldVariant2(
            global::RetellAI.ConductorFormDateRangeFieldVariant2Kind kind,
            bool? includesTime,
            string? min,
            string? max,
            global::RetellAI.ConductorFormDateRangeValue? defaultValue)
        {
            this.Kind = kind;
            this.IncludesTime = includesTime;
            this.Min = min;
            this.Max = max;
            this.DefaultValue = defaultValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormDateRangeFieldVariant2" /> class.
        /// </summary>
        public ConductorFormDateRangeFieldVariant2()
        {
        }

    }
}