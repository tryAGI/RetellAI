
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Lifecycle status of the org's enterprise plan, if it belongs to one.
    /// </summary>
    public enum OrganizationResponseVariant2EnterprisePlanStatus
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Expired,
        /// <summary>
        ///
        /// </summary>
        Terminated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationResponseVariant2EnterprisePlanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationResponseVariant2EnterprisePlanStatus value)
        {
            return value switch
            {
                OrganizationResponseVariant2EnterprisePlanStatus.Active => "active",
                OrganizationResponseVariant2EnterprisePlanStatus.Expired => "expired",
                OrganizationResponseVariant2EnterprisePlanStatus.Terminated => "terminated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationResponseVariant2EnterprisePlanStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => OrganizationResponseVariant2EnterprisePlanStatus.Active,
                "expired" => OrganizationResponseVariant2EnterprisePlanStatus.Expired,
                "terminated" => OrganizationResponseVariant2EnterprisePlanStatus.Terminated,
                _ => null,
            };
        }
    }
}