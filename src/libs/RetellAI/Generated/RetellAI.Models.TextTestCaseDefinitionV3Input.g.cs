#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct TextTestCaseDefinitionV3Input : global::System.IEquatable<TextTestCaseDefinitionV3Input>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TextTestCaseDefinitionV3Fields? Fields { get; init; }
#else
        public global::RetellAI.TextTestCaseDefinitionV3Fields? Fields { get; }
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
            out global::RetellAI.TextTestCaseDefinitionV3Fields? value)
        {
            value = Fields;
            return IsFields;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextTestCaseDefinitionV3Fields PickFields() => Fields is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Fields' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TextTestCaseDefinitionV3InputVariant2? TextTestCaseDefinitionV3InputVariant2 { get; init; }
#else
        public global::RetellAI.TextTestCaseDefinitionV3InputVariant2? TextTestCaseDefinitionV3InputVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextTestCaseDefinitionV3InputVariant2))]
#endif
        public bool IsTextTestCaseDefinitionV3InputVariant2 => TextTestCaseDefinitionV3InputVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextTestCaseDefinitionV3InputVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.TextTestCaseDefinitionV3InputVariant2? value)
        {
            value = TextTestCaseDefinitionV3InputVariant2;
            return IsTextTestCaseDefinitionV3InputVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TextTestCaseDefinitionV3InputVariant2 PickTextTestCaseDefinitionV3InputVariant2() => TextTestCaseDefinitionV3InputVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextTestCaseDefinitionV3InputVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TextTestCaseDefinitionV3Input(global::RetellAI.TextTestCaseDefinitionV3Fields value) => new TextTestCaseDefinitionV3Input((global::RetellAI.TextTestCaseDefinitionV3Fields?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.TextTestCaseDefinitionV3Fields?(TextTestCaseDefinitionV3Input @this) => @this.Fields;

        /// <summary>
        ///
        /// </summary>
        public TextTestCaseDefinitionV3Input(global::RetellAI.TextTestCaseDefinitionV3Fields? value)
        {
            Fields = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TextTestCaseDefinitionV3Input FromFields(global::RetellAI.TextTestCaseDefinitionV3Fields? value) => new TextTestCaseDefinitionV3Input(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TextTestCaseDefinitionV3Input(global::RetellAI.TextTestCaseDefinitionV3InputVariant2 value) => new TextTestCaseDefinitionV3Input((global::RetellAI.TextTestCaseDefinitionV3InputVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.TextTestCaseDefinitionV3InputVariant2?(TextTestCaseDefinitionV3Input @this) => @this.TextTestCaseDefinitionV3InputVariant2;

        /// <summary>
        ///
        /// </summary>
        public TextTestCaseDefinitionV3Input(global::RetellAI.TextTestCaseDefinitionV3InputVariant2? value)
        {
            TextTestCaseDefinitionV3InputVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TextTestCaseDefinitionV3Input FromTextTestCaseDefinitionV3InputVariant2(global::RetellAI.TextTestCaseDefinitionV3InputVariant2? value) => new TextTestCaseDefinitionV3Input(value);

        /// <summary>
        ///
        /// </summary>
        public TextTestCaseDefinitionV3Input(
            global::RetellAI.TextTestCaseDefinitionV3Fields? fields,
            global::RetellAI.TextTestCaseDefinitionV3InputVariant2? textTestCaseDefinitionV3InputVariant2
            )
        {
            Fields = fields;
            TextTestCaseDefinitionV3InputVariant2 = textTestCaseDefinitionV3InputVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TextTestCaseDefinitionV3InputVariant2 as object ??
            Fields as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Fields?.ToString() ??
            TextTestCaseDefinitionV3InputVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFields && IsTextTestCaseDefinitionV3InputVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.TextTestCaseDefinitionV3Fields?, TResult>? fields = null,
            global::System.Func<global::RetellAI.TextTestCaseDefinitionV3InputVariant2, TResult>? textTestCaseDefinitionV3InputVariant2 = null,
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
            else if (TextTestCaseDefinitionV3InputVariant2 is { } __value1 && textTestCaseDefinitionV3InputVariant2 != null)
            {
                return textTestCaseDefinitionV3InputVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.TextTestCaseDefinitionV3Fields?>? fields = null,

            global::System.Action<global::RetellAI.TextTestCaseDefinitionV3InputVariant2>? textTestCaseDefinitionV3InputVariant2 = null,
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
            else if (TextTestCaseDefinitionV3InputVariant2 is { } __value1)
            {
                textTestCaseDefinitionV3InputVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.TextTestCaseDefinitionV3Fields?>? fields = null,
            global::System.Action<global::RetellAI.TextTestCaseDefinitionV3InputVariant2>? textTestCaseDefinitionV3InputVariant2 = null,
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
            else if (TextTestCaseDefinitionV3InputVariant2 is { } __value1)
            {
                textTestCaseDefinitionV3InputVariant2?.Invoke(__value1);
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
                typeof(global::RetellAI.TextTestCaseDefinitionV3Fields),
                TextTestCaseDefinitionV3InputVariant2,
                typeof(global::RetellAI.TextTestCaseDefinitionV3InputVariant2),
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
        public bool Equals(TextTestCaseDefinitionV3Input other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TextTestCaseDefinitionV3Fields?>.Default.Equals(Fields, other.Fields) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TextTestCaseDefinitionV3InputVariant2?>.Default.Equals(TextTestCaseDefinitionV3InputVariant2, other.TextTestCaseDefinitionV3InputVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TextTestCaseDefinitionV3Input obj1, TextTestCaseDefinitionV3Input obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TextTestCaseDefinitionV3Input>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TextTestCaseDefinitionV3Input obj1, TextTestCaseDefinitionV3Input obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextTestCaseDefinitionV3Input o && Equals(o);
        }
    }
}
