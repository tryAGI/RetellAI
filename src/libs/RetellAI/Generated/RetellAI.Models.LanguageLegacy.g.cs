#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Legacy single-string language format. Accepts any concrete locale from `Language`, plus the special scalar value `multi` for multilingual support. If unset, will use default value `en-US`.<br/>
    /// Example: en-US
    /// </summary>
    public readonly partial struct LanguageLegacy : global::System.IEquatable<LanguageLegacy>
    {
        /// <summary>
        /// Specifies what language (and dialect) the agent will operate in. For instance, selecting `en-GB` optimizes speech recognition for British English and indexes knowledge bases with English. If unset, will use default value `en-US`. This enum does not include the legacy scalar value `multi`.<br/>
        /// Example: en-US
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.Language3? Language3 { get; init; }
#else
        public global::RetellAI.Language3? Language3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Language3))]
#endif
        public bool IsLanguage3 => Language3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.LanguageLegacyEnum? Enum { get; init; }
#else
        public global::RetellAI.LanguageLegacyEnum? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LanguageLegacy(global::RetellAI.Language3 value) => new LanguageLegacy((global::RetellAI.Language3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.Language3?(LanguageLegacy @this) => @this.Language3;

        /// <summary>
        /// 
        /// </summary>
        public LanguageLegacy(global::RetellAI.Language3? value)
        {
            Language3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LanguageLegacy(global::RetellAI.LanguageLegacyEnum value) => new LanguageLegacy((global::RetellAI.LanguageLegacyEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.LanguageLegacyEnum?(LanguageLegacy @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public LanguageLegacy(global::RetellAI.LanguageLegacyEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LanguageLegacy(
            global::RetellAI.Language3? language3,
            global::RetellAI.LanguageLegacyEnum? @enum
            )
        {
            Language3 = language3;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            Language3 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Language3?.ToValueString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLanguage3 && !IsEnum || !IsLanguage3 && IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.Language3?, TResult>? language3 = null,
            global::System.Func<global::RetellAI.LanguageLegacyEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLanguage3 && language3 != null)
            {
                return language3(Language3!);
            }
            else if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.Language3?>? language3 = null,
            global::System.Action<global::RetellAI.LanguageLegacyEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLanguage3)
            {
                language3?.Invoke(Language3!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Language3,
                typeof(global::RetellAI.Language3),
                Enum,
                typeof(global::RetellAI.LanguageLegacyEnum),
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
        public bool Equals(LanguageLegacy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.Language3?>.Default.Equals(Language3, other.Language3) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.LanguageLegacyEnum?>.Default.Equals(Enum, other.Enum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LanguageLegacy obj1, LanguageLegacy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LanguageLegacy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LanguageLegacy obj1, LanguageLegacy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LanguageLegacy o && Equals(o);
        }
    }
}
