
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentRequestExpressiveEmotionTag
    {
        /// <summary>
        /// 
        /// </summary>
        ClearThroat,
        /// <summary>
        /// 
        /// </summary>
        Curious,
        /// <summary>
        /// 
        /// </summary>
        Empathetic,
        /// <summary>
        /// 
        /// </summary>
        Emphasis,
        /// <summary>
        /// 
        /// </summary>
        Excited,
        /// <summary>
        /// 
        /// </summary>
        Happy,
        /// <summary>
        /// 
        /// </summary>
        LongPause,
        /// <summary>
        /// 
        /// </summary>
        Pause,
        /// <summary>
        /// 
        /// </summary>
        Sigh,
        /// <summary>
        /// 
        /// </summary>
        Surprised,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRequestExpressiveEmotionTagExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRequestExpressiveEmotionTag value)
        {
            return value switch
            {
                AgentRequestExpressiveEmotionTag.ClearThroat => "clear throat",
                AgentRequestExpressiveEmotionTag.Curious => "curious",
                AgentRequestExpressiveEmotionTag.Empathetic => "empathetic",
                AgentRequestExpressiveEmotionTag.Emphasis => "emphasis",
                AgentRequestExpressiveEmotionTag.Excited => "excited",
                AgentRequestExpressiveEmotionTag.Happy => "happy",
                AgentRequestExpressiveEmotionTag.LongPause => "long pause",
                AgentRequestExpressiveEmotionTag.Pause => "pause",
                AgentRequestExpressiveEmotionTag.Sigh => "sigh",
                AgentRequestExpressiveEmotionTag.Surprised => "surprised",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRequestExpressiveEmotionTag? ToEnum(string value)
        {
            return value switch
            {
                "clear throat" => AgentRequestExpressiveEmotionTag.ClearThroat,
                "curious" => AgentRequestExpressiveEmotionTag.Curious,
                "empathetic" => AgentRequestExpressiveEmotionTag.Empathetic,
                "emphasis" => AgentRequestExpressiveEmotionTag.Emphasis,
                "excited" => AgentRequestExpressiveEmotionTag.Excited,
                "happy" => AgentRequestExpressiveEmotionTag.Happy,
                "long pause" => AgentRequestExpressiveEmotionTag.LongPause,
                "pause" => AgentRequestExpressiveEmotionTag.Pause,
                "sigh" => AgentRequestExpressiveEmotionTag.Sigh,
                "surprised" => AgentRequestExpressiveEmotionTag.Surprised,
                _ => null,
            };
        }
    }
}