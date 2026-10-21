
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Capacity tier for a model. standard is always available. fast draws from dedicated capacity for lower, steadier latency, and ultrafast is faster still on voice agents; faster tiers cost more. Each model offers its own set of tiers, and a tier the model does not offer is rejected.
    /// </summary>
    public enum ServiceTier
    {
        /// <summary>
        ///
        /// </summary>
        Fast,
        /// <summary>
        ///
        /// </summary>
        Standard,
        /// <summary>
        ///
        /// </summary>
        Ultrafast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServiceTier value)
        {
            return value switch
            {
                ServiceTier.Fast => "fast",
                ServiceTier.Standard => "standard",
                ServiceTier.Ultrafast => "ultrafast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "fast" => ServiceTier.Fast,
                "standard" => ServiceTier.Standard,
                "ultrafast" => ServiceTier.Ultrafast,
                _ => null,
            };
        }
    }
}