#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// A post-session tool with an optional condition. Parameter inference uses the agent prompt, dynamic variables, and conversation. Same tools as PreSessionTool plus send_sms, which is only supported on phone calls — the session is over, so the speak settings are ignored and an inferred sms_content is written by the LLM from the transcript at teardown.
    /// </summary>
    public readonly partial struct PostSessionTool : global::System.IEquatable<PostSessionTool>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool, global::RetellAI.SendSMSTool>? PostSessionToolVariant1 { get; init; }
#else
        public global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool, global::RetellAI.SendSMSTool>? PostSessionToolVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PostSessionToolVariant1))]
#endif
        public bool IsPostSessionToolVariant1 => PostSessionToolVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPostSessionToolVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool, global::RetellAI.SendSMSTool>? value)
        {
            value = PostSessionToolVariant1;
            return IsPostSessionToolVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool, global::RetellAI.SendSMSTool> PickPostSessionToolVariant1() => PostSessionToolVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PostSessionToolVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.PostSessionToolVariant2? PostSessionToolVariant2 { get; init; }
#else
        public global::RetellAI.PostSessionToolVariant2? PostSessionToolVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PostSessionToolVariant2))]
#endif
        public bool IsPostSessionToolVariant2 => PostSessionToolVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPostSessionToolVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.PostSessionToolVariant2? value)
        {
            value = PostSessionToolVariant2;
            return IsPostSessionToolVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PostSessionToolVariant2 PickPostSessionToolVariant2() => PostSessionToolVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PostSessionToolVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PostSessionTool(global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool, global::RetellAI.SendSMSTool> value) => new PostSessionTool((global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool, global::RetellAI.SendSMSTool>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool, global::RetellAI.SendSMSTool>?(PostSessionTool @this) => @this.PostSessionToolVariant1;

        /// <summary>
        ///
        /// </summary>
        public PostSessionTool(global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool, global::RetellAI.SendSMSTool>? value)
        {
            PostSessionToolVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PostSessionTool FromPostSessionToolVariant1(global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool, global::RetellAI.SendSMSTool>? value) => new PostSessionTool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PostSessionTool(global::RetellAI.PostSessionToolVariant2 value) => new PostSessionTool((global::RetellAI.PostSessionToolVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.PostSessionToolVariant2?(PostSessionTool @this) => @this.PostSessionToolVariant2;

        /// <summary>
        ///
        /// </summary>
        public PostSessionTool(global::RetellAI.PostSessionToolVariant2? value)
        {
            PostSessionToolVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PostSessionTool FromPostSessionToolVariant2(global::RetellAI.PostSessionToolVariant2? value) => new PostSessionTool(value);

        /// <summary>
        ///
        /// </summary>
        public PostSessionTool(
            global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool, global::RetellAI.SendSMSTool>? postSessionToolVariant1,
            global::RetellAI.PostSessionToolVariant2? postSessionToolVariant2
            )
        {
            PostSessionToolVariant1 = postSessionToolVariant1;
            PostSessionToolVariant2 = postSessionToolVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PostSessionToolVariant2 as object ??
            PostSessionToolVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PostSessionToolVariant1?.ToString() ??
            PostSessionToolVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPostSessionToolVariant1 && IsPostSessionToolVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool, global::RetellAI.SendSMSTool>?, TResult>? postSessionToolVariant1 = null,
            global::System.Func<global::RetellAI.PostSessionToolVariant2, TResult>? postSessionToolVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PostSessionToolVariant1 is { } __value0 && postSessionToolVariant1 != null)
            {
                return postSessionToolVariant1(__value0);
            }
            else if (PostSessionToolVariant2 is { } __value1 && postSessionToolVariant2 != null)
            {
                return postSessionToolVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool, global::RetellAI.SendSMSTool>?>? postSessionToolVariant1 = null,

            global::System.Action<global::RetellAI.PostSessionToolVariant2>? postSessionToolVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PostSessionToolVariant1 is { } __value0)
            {
                postSessionToolVariant1?.Invoke(__value0);
            }
            else if (PostSessionToolVariant2 is { } __value1)
            {
                postSessionToolVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool, global::RetellAI.SendSMSTool>?>? postSessionToolVariant1 = null,
            global::System.Action<global::RetellAI.PostSessionToolVariant2>? postSessionToolVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PostSessionToolVariant1 is { } __value0)
            {
                postSessionToolVariant1?.Invoke(__value0);
            }
            else if (PostSessionToolVariant2 is { } __value1)
            {
                postSessionToolVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PostSessionToolVariant1,
                typeof(global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool, global::RetellAI.SendSMSTool>),
                PostSessionToolVariant2,
                typeof(global::RetellAI.PostSessionToolVariant2),
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
        public bool Equals(PostSessionTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool, global::RetellAI.SendSMSTool>?>.Default.Equals(PostSessionToolVariant1, other.PostSessionToolVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.PostSessionToolVariant2?>.Default.Equals(PostSessionToolVariant2, other.PostSessionToolVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PostSessionTool obj1, PostSessionTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PostSessionTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PostSessionTool obj1, PostSessionTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PostSessionTool o && Equals(o);
        }
    }
}
