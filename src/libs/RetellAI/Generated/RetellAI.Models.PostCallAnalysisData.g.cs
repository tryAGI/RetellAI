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
        public global::RetellAI.AnalysisData? Value1 { get; init; }
#else
        public global::RetellAI.AnalysisData? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// System preset for post-call analysis (voice agents). Use in post_call_analysis_data to override prompts or mark fields optional.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.CallPresetAnalysisData? Value2 { get; init; }
#else
        public global::RetellAI.CallPresetAnalysisData? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PostCallAnalysisData(global::RetellAI.AnalysisData value) => new PostCallAnalysisData((global::RetellAI.AnalysisData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.AnalysisData?(PostCallAnalysisData @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public PostCallAnalysisData(global::RetellAI.AnalysisData? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PostCallAnalysisData(global::RetellAI.CallPresetAnalysisData value) => new PostCallAnalysisData((global::RetellAI.CallPresetAnalysisData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.CallPresetAnalysisData?(PostCallAnalysisData @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public PostCallAnalysisData(global::RetellAI.CallPresetAnalysisData? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PostCallAnalysisData(
            global::RetellAI.AnalysisData? value1,
            global::RetellAI.CallPresetAnalysisData? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 || !IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.AnalysisData?, TResult>? value1 = null,
            global::System.Func<global::RetellAI.CallPresetAnalysisData?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.AnalysisData?>? value1 = null,
            global::System.Action<global::RetellAI.CallPresetAnalysisData?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::RetellAI.AnalysisData),
                Value2,
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
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AnalysisData?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.CallPresetAnalysisData?>.Default.Equals(Value2, other.Value2) 
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
