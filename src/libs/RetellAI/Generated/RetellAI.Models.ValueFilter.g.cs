#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ValueFilter : global::System.IEquatable<ValueFilter>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.StringFilter? String { get; init; }
#else
        public global::RetellAI.StringFilter? String { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(String))]
#endif
        public bool IsString => String != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.NumberFilter? Number { get; init; }
#else
        public global::RetellAI.NumberFilter? Number { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Number))]
#endif
        public bool IsNumber => Number != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.BooleanFilter? Boolean { get; init; }
#else
        public global::RetellAI.BooleanFilter? Boolean { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Boolean))]
#endif
        public bool IsBoolean => Boolean != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.RangeFilter? Range { get; init; }
#else
        public global::RetellAI.RangeFilter? Range { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Range))]
#endif
        public bool IsRange => Range != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.EnumFilter? Enum { get; init; }
#else
        public global::RetellAI.EnumFilter? Enum { get; }
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
#if NET6_0_OR_GREATER
        public global::RetellAI.PresentFilter? Present { get; init; }
#else
        public global::RetellAI.PresentFilter? Present { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Present))]
#endif
        public bool IsPresent => Present != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ValueFilter(global::RetellAI.StringFilter value) => new ValueFilter((global::RetellAI.StringFilter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.StringFilter?(ValueFilter @this) => @this.String;

        /// <summary>
        /// 
        /// </summary>
        public ValueFilter(global::RetellAI.StringFilter? value)
        {
            String = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ValueFilter(global::RetellAI.NumberFilter value) => new ValueFilter((global::RetellAI.NumberFilter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.NumberFilter?(ValueFilter @this) => @this.Number;

        /// <summary>
        /// 
        /// </summary>
        public ValueFilter(global::RetellAI.NumberFilter? value)
        {
            Number = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ValueFilter(global::RetellAI.BooleanFilter value) => new ValueFilter((global::RetellAI.BooleanFilter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.BooleanFilter?(ValueFilter @this) => @this.Boolean;

        /// <summary>
        /// 
        /// </summary>
        public ValueFilter(global::RetellAI.BooleanFilter? value)
        {
            Boolean = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ValueFilter(global::RetellAI.RangeFilter value) => new ValueFilter((global::RetellAI.RangeFilter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.RangeFilter?(ValueFilter @this) => @this.Range;

        /// <summary>
        /// 
        /// </summary>
        public ValueFilter(global::RetellAI.RangeFilter? value)
        {
            Range = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ValueFilter(global::RetellAI.EnumFilter value) => new ValueFilter((global::RetellAI.EnumFilter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.EnumFilter?(ValueFilter @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public ValueFilter(global::RetellAI.EnumFilter? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ValueFilter(global::RetellAI.PresentFilter value) => new ValueFilter((global::RetellAI.PresentFilter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.PresentFilter?(ValueFilter @this) => @this.Present;

        /// <summary>
        /// 
        /// </summary>
        public ValueFilter(global::RetellAI.PresentFilter? value)
        {
            Present = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ValueFilter(
            global::RetellAI.StringFilter? @string,
            global::RetellAI.NumberFilter? number,
            global::RetellAI.BooleanFilter? boolean,
            global::RetellAI.RangeFilter? range,
            global::RetellAI.EnumFilter? @enum,
            global::RetellAI.PresentFilter? present
            )
        {
            String = @string;
            Number = number;
            Boolean = boolean;
            Range = range;
            Enum = @enum;
            Present = present;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Present as object ??
            Enum as object ??
            Range as object ??
            Boolean as object ??
            Number as object ??
            String as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            String?.ToString() ??
            Number?.ToString() ??
            Boolean?.ToString() ??
            Range?.ToString() ??
            Enum?.ToString() ??
            Present?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsString && !IsNumber && !IsBoolean && !IsRange && !IsEnum && !IsPresent || !IsString && IsNumber && !IsBoolean && !IsRange && !IsEnum && !IsPresent || !IsString && !IsNumber && IsBoolean && !IsRange && !IsEnum && !IsPresent || !IsString && !IsNumber && !IsBoolean && IsRange && !IsEnum && !IsPresent || !IsString && !IsNumber && !IsBoolean && !IsRange && IsEnum && !IsPresent || !IsString && !IsNumber && !IsBoolean && !IsRange && !IsEnum && IsPresent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.StringFilter?, TResult>? @string = null,
            global::System.Func<global::RetellAI.NumberFilter?, TResult>? number = null,
            global::System.Func<global::RetellAI.BooleanFilter?, TResult>? boolean = null,
            global::System.Func<global::RetellAI.RangeFilter?, TResult>? range = null,
            global::System.Func<global::RetellAI.EnumFilter?, TResult>? @enum = null,
            global::System.Func<global::RetellAI.PresentFilter?, TResult>? present = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString && @string != null)
            {
                return @string(String!);
            }
            else if (IsNumber && number != null)
            {
                return number(Number!);
            }
            else if (IsBoolean && boolean != null)
            {
                return boolean(Boolean!);
            }
            else if (IsRange && range != null)
            {
                return range(Range!);
            }
            else if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }
            else if (IsPresent && present != null)
            {
                return present(Present!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.StringFilter?>? @string = null,
            global::System.Action<global::RetellAI.NumberFilter?>? number = null,
            global::System.Action<global::RetellAI.BooleanFilter?>? boolean = null,
            global::System.Action<global::RetellAI.RangeFilter?>? range = null,
            global::System.Action<global::RetellAI.EnumFilter?>? @enum = null,
            global::System.Action<global::RetellAI.PresentFilter?>? present = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString)
            {
                @string?.Invoke(String!);
            }
            else if (IsNumber)
            {
                number?.Invoke(Number!);
            }
            else if (IsBoolean)
            {
                boolean?.Invoke(Boolean!);
            }
            else if (IsRange)
            {
                range?.Invoke(Range!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
            else if (IsPresent)
            {
                present?.Invoke(Present!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                String,
                typeof(global::RetellAI.StringFilter),
                Number,
                typeof(global::RetellAI.NumberFilter),
                Boolean,
                typeof(global::RetellAI.BooleanFilter),
                Range,
                typeof(global::RetellAI.RangeFilter),
                Enum,
                typeof(global::RetellAI.EnumFilter),
                Present,
                typeof(global::RetellAI.PresentFilter),
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
        public bool Equals(ValueFilter other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.StringFilter?>.Default.Equals(String, other.String) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.NumberFilter?>.Default.Equals(Number, other.Number) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.BooleanFilter?>.Default.Equals(Boolean, other.Boolean) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.RangeFilter?>.Default.Equals(Range, other.Range) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.EnumFilter?>.Default.Equals(Enum, other.Enum) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.PresentFilter?>.Default.Equals(Present, other.Present) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ValueFilter obj1, ValueFilter obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ValueFilter>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ValueFilter obj1, ValueFilter obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ValueFilter o && Equals(o);
        }
    }
}
