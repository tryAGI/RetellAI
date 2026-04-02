#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Post-chat analysis item (custom data or chat preset). Use for chat agent post_chat_analysis_data; validates only chat presets (chat_summary, chat_successful, user_sentiment).
    /// </summary>
    public readonly partial struct PostChatAnalysisData : global::System.IEquatable<PostChatAnalysisData>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.AnalysisData? AnalysisData { get; init; }
#else
        public global::RetellAI.AnalysisData? AnalysisData { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnalysisData))]
#endif
        public bool IsAnalysisData => AnalysisData != null;

        /// <summary>
        /// System preset for post-chat analysis (chat agents). Use in post_chat_analysis_data to override prompts or mark fields optional.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ChatPresetAnalysisData? Preset { get; init; }
#else
        public global::RetellAI.ChatPresetAnalysisData? Preset { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Preset))]
#endif
        public bool IsPreset => Preset != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PostChatAnalysisData(global::RetellAI.AnalysisData value) => new PostChatAnalysisData((global::RetellAI.AnalysisData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.AnalysisData?(PostChatAnalysisData @this) => @this.AnalysisData;

        /// <summary>
        /// 
        /// </summary>
        public PostChatAnalysisData(global::RetellAI.AnalysisData? value)
        {
            AnalysisData = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PostChatAnalysisData(global::RetellAI.ChatPresetAnalysisData value) => new PostChatAnalysisData((global::RetellAI.ChatPresetAnalysisData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ChatPresetAnalysisData?(PostChatAnalysisData @this) => @this.Preset;

        /// <summary>
        /// 
        /// </summary>
        public PostChatAnalysisData(global::RetellAI.ChatPresetAnalysisData? value)
        {
            Preset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PostChatAnalysisData(
            global::RetellAI.AnalysisData? analysisData,
            global::RetellAI.ChatPresetAnalysisData? preset
            )
        {
            AnalysisData = analysisData;
            Preset = preset;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Preset as object ??
            AnalysisData as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnalysisData?.ToString() ??
            Preset?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnalysisData && !IsPreset || !IsAnalysisData && IsPreset;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.AnalysisData?, TResult>? analysisData = null,
            global::System.Func<global::RetellAI.ChatPresetAnalysisData?, TResult>? preset = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnalysisData && analysisData != null)
            {
                return analysisData(AnalysisData!);
            }
            else if (IsPreset && preset != null)
            {
                return preset(Preset!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.AnalysisData?>? analysisData = null,
            global::System.Action<global::RetellAI.ChatPresetAnalysisData?>? preset = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnalysisData)
            {
                analysisData?.Invoke(AnalysisData!);
            }
            else if (IsPreset)
            {
                preset?.Invoke(Preset!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnalysisData,
                typeof(global::RetellAI.AnalysisData),
                Preset,
                typeof(global::RetellAI.ChatPresetAnalysisData),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(PostChatAnalysisData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AnalysisData?>.Default.Equals(AnalysisData, other.AnalysisData) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ChatPresetAnalysisData?>.Default.Equals(Preset, other.Preset) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PostChatAnalysisData obj1, PostChatAnalysisData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PostChatAnalysisData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PostChatAnalysisData obj1, PostChatAnalysisData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PostChatAnalysisData o && Equals(o);
        }
    }
}
