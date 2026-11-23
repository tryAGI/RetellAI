#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AsrTestCaseJobV3 : global::System.IEquatable<AsrTestCaseJobV3>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TestCaseJobV3Base? Base { get; init; }
#else
        public global::RetellAI.TestCaseJobV3Base? Base { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.TestCaseJobV3Base? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseJobV3Base PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.AsrTestCaseJobV3Variant2? AsrTestCaseJobV3Variant2 { get; init; }
#else
        public global::RetellAI.AsrTestCaseJobV3Variant2? AsrTestCaseJobV3Variant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AsrTestCaseJobV3Variant2))]
#endif
        public bool IsAsrTestCaseJobV3Variant2 => AsrTestCaseJobV3Variant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAsrTestCaseJobV3Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.AsrTestCaseJobV3Variant2? value)
        {
            value = AsrTestCaseJobV3Variant2;
            return IsAsrTestCaseJobV3Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AsrTestCaseJobV3Variant2 PickAsrTestCaseJobV3Variant2() => AsrTestCaseJobV3Variant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AsrTestCaseJobV3Variant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AsrTestCaseJobV3(global::RetellAI.TestCaseJobV3Base value) => new AsrTestCaseJobV3((global::RetellAI.TestCaseJobV3Base?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.TestCaseJobV3Base?(AsrTestCaseJobV3 @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public AsrTestCaseJobV3(global::RetellAI.TestCaseJobV3Base? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AsrTestCaseJobV3 FromBase(global::RetellAI.TestCaseJobV3Base? value) => new AsrTestCaseJobV3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AsrTestCaseJobV3(global::RetellAI.AsrTestCaseJobV3Variant2 value) => new AsrTestCaseJobV3((global::RetellAI.AsrTestCaseJobV3Variant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.AsrTestCaseJobV3Variant2?(AsrTestCaseJobV3 @this) => @this.AsrTestCaseJobV3Variant2;

        /// <summary>
        ///
        /// </summary>
        public AsrTestCaseJobV3(global::RetellAI.AsrTestCaseJobV3Variant2? value)
        {
            AsrTestCaseJobV3Variant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AsrTestCaseJobV3 FromAsrTestCaseJobV3Variant2(global::RetellAI.AsrTestCaseJobV3Variant2? value) => new AsrTestCaseJobV3(value);

        /// <summary>
        ///
        /// </summary>
        public AsrTestCaseJobV3(
            global::RetellAI.TestCaseJobV3Base? @base,
            global::RetellAI.AsrTestCaseJobV3Variant2? asrTestCaseJobV3Variant2
            )
        {
            Base = @base;
            AsrTestCaseJobV3Variant2 = asrTestCaseJobV3Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AsrTestCaseJobV3Variant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            AsrTestCaseJobV3Variant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsAsrTestCaseJobV3Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.TestCaseJobV3Base, TResult>? @base = null,
            global::System.Func<global::RetellAI.AsrTestCaseJobV3Variant2, TResult>? asrTestCaseJobV3Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0 && @base != null)
            {
                return @base(__value0);
            }
            else if (AsrTestCaseJobV3Variant2 is { } __value1 && asrTestCaseJobV3Variant2 != null)
            {
                return asrTestCaseJobV3Variant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.TestCaseJobV3Base>? @base = null,

            global::System.Action<global::RetellAI.AsrTestCaseJobV3Variant2>? asrTestCaseJobV3Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (AsrTestCaseJobV3Variant2 is { } __value1)
            {
                asrTestCaseJobV3Variant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.TestCaseJobV3Base>? @base = null,
            global::System.Action<global::RetellAI.AsrTestCaseJobV3Variant2>? asrTestCaseJobV3Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (AsrTestCaseJobV3Variant2 is { } __value1)
            {
                asrTestCaseJobV3Variant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::RetellAI.TestCaseJobV3Base),
                AsrTestCaseJobV3Variant2,
                typeof(global::RetellAI.AsrTestCaseJobV3Variant2),
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
        public bool Equals(AsrTestCaseJobV3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TestCaseJobV3Base?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AsrTestCaseJobV3Variant2?>.Default.Equals(AsrTestCaseJobV3Variant2, other.AsrTestCaseJobV3Variant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AsrTestCaseJobV3 obj1, AsrTestCaseJobV3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AsrTestCaseJobV3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AsrTestCaseJobV3 obj1, AsrTestCaseJobV3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AsrTestCaseJobV3 o && Equals(o);
        }
    }
}
