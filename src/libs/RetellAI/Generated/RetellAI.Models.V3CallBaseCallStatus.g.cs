
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Status of call.<br/>
    /// - `registered`: Call id issued, starting to make a call using this id.<br/>
    /// - `ongoing`: Call connected and ongoing.<br/>
    /// - `ended`: The underlying websocket has ended for the call. Either user or agent hung up, or call transferred.<br/>
    /// - `error`: Call encountered error.<br/>
    /// Example: registered
    /// </summary>
    public enum V3CallBaseCallStatus
    {
        /// <summary>
        /// The underlying websocket has ended for the call. Either user or agent hung up, or call transferred.
        /// </summary>
        Ended,
        /// <summary>
        /// Call encountered error.
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        NotConnected,
        /// <summary>
        /// Call connected and ongoing.
        /// </summary>
        Ongoing,
        /// <summary>
        /// Call id issued, starting to make a call using this id.
        /// </summary>
        Registered,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V3CallBaseCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V3CallBaseCallStatus value)
        {
            return value switch
            {
                V3CallBaseCallStatus.Ended => "ended",
                V3CallBaseCallStatus.Error => "error",
                V3CallBaseCallStatus.NotConnected => "not_connected",
                V3CallBaseCallStatus.Ongoing => "ongoing",
                V3CallBaseCallStatus.Registered => "registered",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V3CallBaseCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "ended" => V3CallBaseCallStatus.Ended,
                "error" => V3CallBaseCallStatus.Error,
                "not_connected" => V3CallBaseCallStatus.NotConnected,
                "ongoing" => V3CallBaseCallStatus.Ongoing,
                "registered" => V3CallBaseCallStatus.Registered,
                _ => null,
            };
        }
    }
}