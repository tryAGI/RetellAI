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
        /// System preset for post-chat analysis (chat agents). Use in post_chat_analysis_data to override prompts or mark fields optional.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ChatPresetAnalysisData? Value2 { get; init; }
#else
        public global::RetellAI.ChatPresetAnalysisData? Value2 { get; }
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
        public static implicit operator PostChatAnalysisData(global::RetellAI.AnalysisData value) => new PostChatAnalysisData((global::RetellAI.AnalysisData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.AnalysisData?(PostChatAnalysisData @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public PostChatAnalysisData(global::RetellAI.AnalysisData? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PostChatAnalysisData(global::RetellAI.ChatPresetAnalysisData value) => new PostChatAnalysisData((global::RetellAI.ChatPresetAnalysisData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ChatPresetAnalysisData?(PostChatAnalysisData @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public PostChatAnalysisData(global::RetellAI.ChatPresetAnalysisData? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PostChatAnalysisData(
            global::RetellAI.AnalysisData? value1,
            global::RetellAI.ChatPresetAnalysisData? value2
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
            global::System.Func<global::RetellAI.ChatPresetAnalysisData?, TResult>? value2 = null,
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
            global::System.Action<global::RetellAI.ChatPresetAnalysisData?>? value2 = null,
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
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AnalysisData?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ChatPresetAnalysisData?>.Default.Equals(Value2, other.Value2) 
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
