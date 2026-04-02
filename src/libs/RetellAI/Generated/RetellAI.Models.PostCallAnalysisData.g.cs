#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Post-call analysis item (custom data or voice preset). Use for voice agent post_call_analysis_data; validates only call presets (call_summary, call_successful, user_sentiment).
    /// </summary>
    public readonly partial struct PostCallAnalysisData : global::System.IEquatable<PostCallAnalysisData>
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
        /// System preset for post-call analysis (voice agents). Use in post_call_analysis_data to override prompts or mark fields optional.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.CallPresetAnalysisData? Preset { get; init; }
#else
        public global::RetellAI.CallPresetAnalysisData? Preset { get; }
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
        public static implicit operator PostCallAnalysisData(global::RetellAI.AnalysisData value) => new PostCallAnalysisData((global::RetellAI.AnalysisData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.AnalysisData?(PostCallAnalysisData @this) => @this.AnalysisData;

        /// <summary>
        /// 
        /// </summary>
        public PostCallAnalysisData(global::RetellAI.AnalysisData? value)
        {
            AnalysisData = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PostCallAnalysisData(global::RetellAI.CallPresetAnalysisData value) => new PostCallAnalysisData((global::RetellAI.CallPresetAnalysisData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.CallPresetAnalysisData?(PostCallAnalysisData @this) => @this.Preset;

        /// <summary>
        /// 
        /// </summary>
        public PostCallAnalysisData(global::RetellAI.CallPresetAnalysisData? value)
        {
            Preset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PostCallAnalysisData(
            global::RetellAI.AnalysisData? analysisData,
            global::RetellAI.CallPresetAnalysisData? preset
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
            global::System.Func<global::RetellAI.CallPresetAnalysisData?, TResult>? preset = null,
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
            global::System.Action<global::RetellAI.CallPresetAnalysisData?>? preset = null,
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
                typeof(global::RetellAI.CallPresetAnalysisData),
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
        public bool Equals(PostCallAnalysisData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AnalysisData?>.Default.Equals(AnalysisData, other.AnalysisData) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.CallPresetAnalysisData?>.Default.Equals(Preset, other.Preset) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PostCallAnalysisData obj1, PostCallAnalysisData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PostCallAnalysisData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PostCallAnalysisData obj1, PostCallAnalysisData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PostCallAnalysisData o && Equals(o);
        }
    }
}
