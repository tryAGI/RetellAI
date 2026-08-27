
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CRMCustomFieldSchemaType
    {
        /// <summary>
        ///
        /// </summary>
        Boolean,
        /// <summary>
        ///
        /// </summary>
        Date,
        /// <summary>
        ///
        /// </summary>
        Datetime,
        /// <summary>
        ///
        /// </summary>
        Enum,
        /// <summary>
        ///
        /// </summary>
        Number,
        /// <summary>
        ///
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CRMCustomFieldSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CRMCustomFieldSchemaType value)
        {
            return value switch
            {
                CRMCustomFieldSchemaType.Boolean => "boolean",
                CRMCustomFieldSchemaType.Date => "date",
                CRMCustomFieldSchemaType.Datetime => "datetime",
                CRMCustomFieldSchemaType.Enum => "enum",
                CRMCustomFieldSchemaType.Number => "number",
                CRMCustomFieldSchemaType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CRMCustomFieldSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => CRMCustomFieldSchemaType.Boolean,
                "date" => CRMCustomFieldSchemaType.Date,
                "datetime" => CRMCustomFieldSchemaType.Datetime,
                "enum" => CRMCustomFieldSchemaType.Enum,
                "number" => CRMCustomFieldSchemaType.Number,
                "string" => CRMCustomFieldSchemaType.String,
                _ => null,
            };
        }
    }
}