#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AsrTestCaseDefinitionV3Fields : global::System.IEquatable<AsrTestCaseDefinitionV3Fields>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TestCaseDefinitionV3Base? Base { get; init; }
#else
        public global::RetellAI.TestCaseDefinitionV3Base? Base { get; }
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
            out global::RetellAI.TestCaseDefinitionV3Base? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseDefinitionV3Base PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.AsrTestCaseDefinitionV3FieldsVariant2? AsrTestCaseDefinitionV3FieldsVariant2 { get; init; }
#else
        public global::RetellAI.AsrTestCaseDefinitionV3FieldsVariant2? AsrTestCaseDefinitionV3FieldsVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AsrTestCaseDefinitionV3FieldsVariant2))]
#endif
        public bool IsAsrTestCaseDefinitionV3FieldsVariant2 => AsrTestCaseDefinitionV3FieldsVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAsrTestCaseDefinitionV3FieldsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.AsrTestCaseDefinitionV3FieldsVariant2? value)
        {
            value = AsrTestCaseDefinitionV3FieldsVariant2;
            return IsAsrTestCaseDefinitionV3FieldsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AsrTestCaseDefinitionV3FieldsVariant2 PickAsrTestCaseDefinitionV3FieldsVariant2() => AsrTestCaseDefinitionV3FieldsVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AsrTestCaseDefinitionV3FieldsVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AsrTestCaseDefinitionV3Fields(global::RetellAI.TestCaseDefinitionV3Base value) => new AsrTestCaseDefinitionV3Fields((global::RetellAI.TestCaseDefinitionV3Base?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.TestCaseDefinitionV3Base?(AsrTestCaseDefinitionV3Fields @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public AsrTestCaseDefinitionV3Fields(global::RetellAI.TestCaseDefinitionV3Base? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AsrTestCaseDefinitionV3Fields FromBase(global::RetellAI.TestCaseDefinitionV3Base? value) => new AsrTestCaseDefinitionV3Fields(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AsrTestCaseDefinitionV3Fields(global::RetellAI.AsrTestCaseDefinitionV3FieldsVariant2 value) => new AsrTestCaseDefinitionV3Fields((global::RetellAI.AsrTestCaseDefinitionV3FieldsVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.AsrTestCaseDefinitionV3FieldsVariant2?(AsrTestCaseDefinitionV3Fields @this) => @this.AsrTestCaseDefinitionV3FieldsVariant2;

        /// <summary>
        ///
        /// </summary>
        public AsrTestCaseDefinitionV3Fields(global::RetellAI.AsrTestCaseDefinitionV3FieldsVariant2? value)
        {
            AsrTestCaseDefinitionV3FieldsVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AsrTestCaseDefinitionV3Fields FromAsrTestCaseDefinitionV3FieldsVariant2(global::RetellAI.AsrTestCaseDefinitionV3FieldsVariant2? value) => new AsrTestCaseDefinitionV3Fields(value);

        /// <summary>
        ///
        /// </summary>
        public AsrTestCaseDefinitionV3Fields(
            global::RetellAI.TestCaseDefinitionV3Base? @base,
            global::RetellAI.AsrTestCaseDefinitionV3FieldsVariant2? asrTestCaseDefinitionV3FieldsVariant2
            )
        {
            Base = @base;
            AsrTestCaseDefinitionV3FieldsVariant2 = asrTestCaseDefinitionV3FieldsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AsrTestCaseDefinitionV3FieldsVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            AsrTestCaseDefinitionV3FieldsVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsAsrTestCaseDefinitionV3FieldsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.TestCaseDefinitionV3Base, TResult>? @base = null,
            global::System.Func<global::RetellAI.AsrTestCaseDefinitionV3FieldsVariant2, TResult>? asrTestCaseDefinitionV3FieldsVariant2 = null,
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
            else if (AsrTestCaseDefinitionV3FieldsVariant2 is { } __value1 && asrTestCaseDefinitionV3FieldsVariant2 != null)
            {
                return asrTestCaseDefinitionV3FieldsVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.TestCaseDefinitionV3Base>? @base = null,

            global::System.Action<global::RetellAI.AsrTestCaseDefinitionV3FieldsVariant2>? asrTestCaseDefinitionV3FieldsVariant2 = null,
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
            else if (AsrTestCaseDefinitionV3FieldsVariant2 is { } __value1)
            {
                asrTestCaseDefinitionV3FieldsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.TestCaseDefinitionV3Base>? @base = null,
            global::System.Action<global::RetellAI.AsrTestCaseDefinitionV3FieldsVariant2>? asrTestCaseDefinitionV3FieldsVariant2 = null,
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
            else if (AsrTestCaseDefinitionV3FieldsVariant2 is { } __value1)
            {
                asrTestCaseDefinitionV3FieldsVariant2?.Invoke(__value1);
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
                typeof(global::RetellAI.TestCaseDefinitionV3Base),
                AsrTestCaseDefinitionV3FieldsVariant2,
                typeof(global::RetellAI.AsrTestCaseDefinitionV3FieldsVariant2),
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
        public bool Equals(AsrTestCaseDefinitionV3Fields other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TestCaseDefinitionV3Base?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AsrTestCaseDefinitionV3FieldsVariant2?>.Default.Equals(AsrTestCaseDefinitionV3FieldsVariant2, other.AsrTestCaseDefinitionV3FieldsVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AsrTestCaseDefinitionV3Fields obj1, AsrTestCaseDefinitionV3Fields obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AsrTestCaseDefinitionV3Fields>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AsrTestCaseDefinitionV3Fields obj1, AsrTestCaseDefinitionV3Fields obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AsrTestCaseDefinitionV3Fields o && Equals(o);
        }
    }
}
