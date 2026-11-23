#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AsrTestCaseDefinitionV3Input : global::System.IEquatable<AsrTestCaseDefinitionV3Input>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.AsrTestCaseDefinitionV3Fields? Fields { get; init; }
#else
        public global::RetellAI.AsrTestCaseDefinitionV3Fields? Fields { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Fields))]
#endif
        public bool IsFields => Fields != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFields(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.AsrTestCaseDefinitionV3Fields? value)
        {
            value = Fields;
            return IsFields;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AsrTestCaseDefinitionV3Fields PickFields() => Fields is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Fields' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.AsrTestCaseDefinitionV3InputVariant2? AsrTestCaseDefinitionV3InputVariant2 { get; init; }
#else
        public global::RetellAI.AsrTestCaseDefinitionV3InputVariant2? AsrTestCaseDefinitionV3InputVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AsrTestCaseDefinitionV3InputVariant2))]
#endif
        public bool IsAsrTestCaseDefinitionV3InputVariant2 => AsrTestCaseDefinitionV3InputVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAsrTestCaseDefinitionV3InputVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.AsrTestCaseDefinitionV3InputVariant2? value)
        {
            value = AsrTestCaseDefinitionV3InputVariant2;
            return IsAsrTestCaseDefinitionV3InputVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AsrTestCaseDefinitionV3InputVariant2 PickAsrTestCaseDefinitionV3InputVariant2() => AsrTestCaseDefinitionV3InputVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AsrTestCaseDefinitionV3InputVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AsrTestCaseDefinitionV3Input(global::RetellAI.AsrTestCaseDefinitionV3Fields value) => new AsrTestCaseDefinitionV3Input((global::RetellAI.AsrTestCaseDefinitionV3Fields?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.AsrTestCaseDefinitionV3Fields?(AsrTestCaseDefinitionV3Input @this) => @this.Fields;

        /// <summary>
        ///
        /// </summary>
        public AsrTestCaseDefinitionV3Input(global::RetellAI.AsrTestCaseDefinitionV3Fields? value)
        {
            Fields = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AsrTestCaseDefinitionV3Input FromFields(global::RetellAI.AsrTestCaseDefinitionV3Fields? value) => new AsrTestCaseDefinitionV3Input(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AsrTestCaseDefinitionV3Input(global::RetellAI.AsrTestCaseDefinitionV3InputVariant2 value) => new AsrTestCaseDefinitionV3Input((global::RetellAI.AsrTestCaseDefinitionV3InputVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.AsrTestCaseDefinitionV3InputVariant2?(AsrTestCaseDefinitionV3Input @this) => @this.AsrTestCaseDefinitionV3InputVariant2;

        /// <summary>
        ///
        /// </summary>
        public AsrTestCaseDefinitionV3Input(global::RetellAI.AsrTestCaseDefinitionV3InputVariant2? value)
        {
            AsrTestCaseDefinitionV3InputVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AsrTestCaseDefinitionV3Input FromAsrTestCaseDefinitionV3InputVariant2(global::RetellAI.AsrTestCaseDefinitionV3InputVariant2? value) => new AsrTestCaseDefinitionV3Input(value);

        /// <summary>
        ///
        /// </summary>
        public AsrTestCaseDefinitionV3Input(
            global::RetellAI.AsrTestCaseDefinitionV3Fields? fields,
            global::RetellAI.AsrTestCaseDefinitionV3InputVariant2? asrTestCaseDefinitionV3InputVariant2
            )
        {
            Fields = fields;
            AsrTestCaseDefinitionV3InputVariant2 = asrTestCaseDefinitionV3InputVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AsrTestCaseDefinitionV3InputVariant2 as object ??
            Fields as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Fields?.ToString() ??
            AsrTestCaseDefinitionV3InputVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFields && IsAsrTestCaseDefinitionV3InputVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.AsrTestCaseDefinitionV3Fields?, TResult>? fields = null,
            global::System.Func<global::RetellAI.AsrTestCaseDefinitionV3InputVariant2, TResult>? asrTestCaseDefinitionV3InputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Fields is { } __value0 && fields != null)
            {
                return fields(__value0);
            }
            else if (AsrTestCaseDefinitionV3InputVariant2 is { } __value1 && asrTestCaseDefinitionV3InputVariant2 != null)
            {
                return asrTestCaseDefinitionV3InputVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.AsrTestCaseDefinitionV3Fields?>? fields = null,

            global::System.Action<global::RetellAI.AsrTestCaseDefinitionV3InputVariant2>? asrTestCaseDefinitionV3InputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Fields is { } __value0)
            {
                fields?.Invoke(__value0);
            }
            else if (AsrTestCaseDefinitionV3InputVariant2 is { } __value1)
            {
                asrTestCaseDefinitionV3InputVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.AsrTestCaseDefinitionV3Fields?>? fields = null,
            global::System.Action<global::RetellAI.AsrTestCaseDefinitionV3InputVariant2>? asrTestCaseDefinitionV3InputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Fields is { } __value0)
            {
                fields?.Invoke(__value0);
            }
            else if (AsrTestCaseDefinitionV3InputVariant2 is { } __value1)
            {
                asrTestCaseDefinitionV3InputVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Fields,
                typeof(global::RetellAI.AsrTestCaseDefinitionV3Fields),
                AsrTestCaseDefinitionV3InputVariant2,
                typeof(global::RetellAI.AsrTestCaseDefinitionV3InputVariant2),
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
        public bool Equals(AsrTestCaseDefinitionV3Input other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AsrTestCaseDefinitionV3Fields?>.Default.Equals(Fields, other.Fields) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AsrTestCaseDefinitionV3InputVariant2?>.Default.Equals(AsrTestCaseDefinitionV3InputVariant2, other.AsrTestCaseDefinitionV3InputVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AsrTestCaseDefinitionV3Input obj1, AsrTestCaseDefinitionV3Input obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AsrTestCaseDefinitionV3Input>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AsrTestCaseDefinitionV3Input obj1, AsrTestCaseDefinitionV3Input obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AsrTestCaseDefinitionV3Input o && Equals(o);
        }
    }
}
