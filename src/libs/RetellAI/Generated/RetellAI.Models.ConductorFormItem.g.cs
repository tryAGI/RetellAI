#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// One item in a form row.
    /// </summary>
    public readonly partial struct ConductorFormItem : global::System.IEquatable<ConductorFormItem>
    {
        /// <summary>
        /// Text only, never answered. A heading (`label`), a paragraph (`description`), or both.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConductorFormTextBlock? TextBlock { get; init; }
#else
        public global::RetellAI.ConductorFormTextBlock? TextBlock { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextBlock))]
#endif
        public bool IsTextBlock => TextBlock != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextBlock(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorFormTextBlock? value)
        {
            value = TextBlock;
            return IsTextBlock;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextBlock PickTextBlock() => TextBlock is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextBlock' but the value was {ToString()}.");

        /// <summary>
        /// A form item the user answers, discriminated by `kind`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConductorFormField? Field { get; init; }
#else
        public global::RetellAI.ConductorFormField? Field { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Field))]
#endif
        public bool IsField => Field != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickField(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorFormField? value)
        {
            value = Field;
            return IsField;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormField PickField() => Field is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Field' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormItem(global::RetellAI.ConductorFormTextBlock value) => new ConductorFormItem((global::RetellAI.ConductorFormTextBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormTextBlock?(ConductorFormItem @this) => @this.TextBlock;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormItem(global::RetellAI.ConductorFormTextBlock? value)
        {
            TextBlock = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormItem FromTextBlock(global::RetellAI.ConductorFormTextBlock? value) => new ConductorFormItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormItem(global::RetellAI.ConductorFormField value) => new ConductorFormItem((global::RetellAI.ConductorFormField?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormField?(ConductorFormItem @this) => @this.Field;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormItem(global::RetellAI.ConductorFormField? value)
        {
            Field = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormItem FromField(global::RetellAI.ConductorFormField? value) => new ConductorFormItem(value);

        /// <summary>
        ///
        /// </summary>
        public ConductorFormItem(
            global::RetellAI.ConductorFormTextBlock? textBlock,
            global::RetellAI.ConductorFormField? field
            )
        {
            TextBlock = textBlock;
            Field = field;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Field as object ??
            TextBlock as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            TextBlock?.ToString() ??
            Field?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTextBlock && !IsField || !IsTextBlock && IsField;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ConductorFormTextBlock?, TResult>? textBlock = null,
            global::System.Func<global::RetellAI.ConductorFormField?, TResult>? field = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TextBlock is { } __value0 && textBlock != null)
            {
                return textBlock(__value0);
            }
            else if (Field is { } __value1 && field != null)
            {
                return field(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ConductorFormTextBlock?>? textBlock = null,

            global::System.Action<global::RetellAI.ConductorFormField?>? field = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TextBlock is { } __value0)
            {
                textBlock?.Invoke(__value0);
            }
            else if (Field is { } __value1)
            {
                field?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ConductorFormTextBlock?>? textBlock = null,
            global::System.Action<global::RetellAI.ConductorFormField?>? field = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TextBlock is { } __value0)
            {
                textBlock?.Invoke(__value0);
            }
            else if (Field is { } __value1)
            {
                field?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextBlock,
                typeof(global::RetellAI.ConductorFormTextBlock),
                Field,
                typeof(global::RetellAI.ConductorFormField),
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
        public bool Equals(ConductorFormItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormTextBlock?>.Default.Equals(TextBlock, other.TextBlock) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormField?>.Default.Equals(Field, other.Field)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ConductorFormItem obj1, ConductorFormItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConductorFormItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ConductorFormItem obj1, ConductorFormItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConductorFormItem o && Equals(o);
        }
    }
}
