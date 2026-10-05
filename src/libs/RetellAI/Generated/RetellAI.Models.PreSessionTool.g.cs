#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// A pre-session tool (app / custom / code, discriminated by type) plus its dependency edges. The tool's name is the depends_on handle and must be unique across the agent's session tools. Parameters may set a constant value or a description for the LLM to infer the value. Pre-session inference uses the agent prompt and dynamic variables.
    /// </summary>
    public readonly partial struct PreSessionTool : global::System.IEquatable<PreSessionTool>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool>? PreSessionToolVariant1 { get; init; }
#else
        public global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool>? PreSessionToolVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PreSessionToolVariant1))]
#endif
        public bool IsPreSessionToolVariant1 => PreSessionToolVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPreSessionToolVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool>? value)
        {
            value = PreSessionToolVariant1;
            return IsPreSessionToolVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool> PickPreSessionToolVariant1() => PreSessionToolVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PreSessionToolVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.PreSessionToolVariant2? PreSessionToolVariant2 { get; init; }
#else
        public global::RetellAI.PreSessionToolVariant2? PreSessionToolVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PreSessionToolVariant2))]
#endif
        public bool IsPreSessionToolVariant2 => PreSessionToolVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPreSessionToolVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.PreSessionToolVariant2? value)
        {
            value = PreSessionToolVariant2;
            return IsPreSessionToolVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PreSessionToolVariant2 PickPreSessionToolVariant2() => PreSessionToolVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PreSessionToolVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PreSessionTool(global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool> value) => new PreSessionTool((global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool>?(PreSessionTool @this) => @this.PreSessionToolVariant1;

        /// <summary>
        ///
        /// </summary>
        public PreSessionTool(global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool>? value)
        {
            PreSessionToolVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PreSessionTool FromPreSessionToolVariant1(global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool>? value) => new PreSessionTool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PreSessionTool(global::RetellAI.PreSessionToolVariant2 value) => new PreSessionTool((global::RetellAI.PreSessionToolVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.PreSessionToolVariant2?(PreSessionTool @this) => @this.PreSessionToolVariant2;

        /// <summary>
        ///
        /// </summary>
        public PreSessionTool(global::RetellAI.PreSessionToolVariant2? value)
        {
            PreSessionToolVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PreSessionTool FromPreSessionToolVariant2(global::RetellAI.PreSessionToolVariant2? value) => new PreSessionTool(value);

        /// <summary>
        ///
        /// </summary>
        public PreSessionTool(
            global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool>? preSessionToolVariant1,
            global::RetellAI.PreSessionToolVariant2? preSessionToolVariant2
            )
        {
            PreSessionToolVariant1 = preSessionToolVariant1;
            PreSessionToolVariant2 = preSessionToolVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PreSessionToolVariant2 as object ??
            PreSessionToolVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PreSessionToolVariant1?.ToString() ??
            PreSessionToolVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPreSessionToolVariant1 && IsPreSessionToolVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool>?, TResult>? preSessionToolVariant1 = null,
            global::System.Func<global::RetellAI.PreSessionToolVariant2, TResult>? preSessionToolVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PreSessionToolVariant1 is { } __value0 && preSessionToolVariant1 != null)
            {
                return preSessionToolVariant1(__value0);
            }
            else if (PreSessionToolVariant2 is { } __value1 && preSessionToolVariant2 != null)
            {
                return preSessionToolVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool>?>? preSessionToolVariant1 = null,

            global::System.Action<global::RetellAI.PreSessionToolVariant2>? preSessionToolVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PreSessionToolVariant1 is { } __value0)
            {
                preSessionToolVariant1?.Invoke(__value0);
            }
            else if (PreSessionToolVariant2 is { } __value1)
            {
                preSessionToolVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool>?>? preSessionToolVariant1 = null,
            global::System.Action<global::RetellAI.PreSessionToolVariant2>? preSessionToolVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PreSessionToolVariant1 is { } __value0)
            {
                preSessionToolVariant1?.Invoke(__value0);
            }
            else if (PreSessionToolVariant2 is { } __value1)
            {
                preSessionToolVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PreSessionToolVariant1,
                typeof(global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool>),
                PreSessionToolVariant2,
                typeof(global::RetellAI.PreSessionToolVariant2),
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
        public bool Equals(PreSessionTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.OneOf<global::RetellAI.AppTool, global::RetellAI.CustomTool, global::RetellAI.CodeTool>?>.Default.Equals(PreSessionToolVariant1, other.PreSessionToolVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.PreSessionToolVariant2?>.Default.Equals(PreSessionToolVariant2, other.PreSessionToolVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PreSessionTool obj1, PreSessionTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PreSessionTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PreSessionTool obj1, PreSessionTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PreSessionTool o && Equals(o);
        }
    }
}
