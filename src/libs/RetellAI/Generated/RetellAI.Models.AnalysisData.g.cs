#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnalysisData : global::System.IEquatable<AnalysisData>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.StringAnalysisData? String { get; init; }
#else
        public global::RetellAI.StringAnalysisData? String { get; }
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
        public global::RetellAI.EnumAnalysisData? Enum { get; init; }
#else
        public global::RetellAI.EnumAnalysisData? Enum { get; }
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
        public global::RetellAI.BooleanAnalysisData? Boolean { get; init; }
#else
        public global::RetellAI.BooleanAnalysisData? Boolean { get; }
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
        public global::RetellAI.NumberAnalysisData? Number { get; init; }
#else
        public global::RetellAI.NumberAnalysisData? Number { get; }
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
        public static implicit operator AnalysisData(global::RetellAI.StringAnalysisData value) => new AnalysisData((global::RetellAI.StringAnalysisData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.StringAnalysisData?(AnalysisData @this) => @this.String;

        /// <summary>
        /// 
        /// </summary>
        public AnalysisData(global::RetellAI.StringAnalysisData? value)
        {
            String = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnalysisData(global::RetellAI.EnumAnalysisData value) => new AnalysisData((global::RetellAI.EnumAnalysisData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.EnumAnalysisData?(AnalysisData @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public AnalysisData(global::RetellAI.EnumAnalysisData? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnalysisData(global::RetellAI.BooleanAnalysisData value) => new AnalysisData((global::RetellAI.BooleanAnalysisData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.BooleanAnalysisData?(AnalysisData @this) => @this.Boolean;

        /// <summary>
        /// 
        /// </summary>
        public AnalysisData(global::RetellAI.BooleanAnalysisData? value)
        {
            Boolean = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnalysisData(global::RetellAI.NumberAnalysisData value) => new AnalysisData((global::RetellAI.NumberAnalysisData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.NumberAnalysisData?(AnalysisData @this) => @this.Number;

        /// <summary>
        /// 
        /// </summary>
        public AnalysisData(global::RetellAI.NumberAnalysisData? value)
        {
            Number = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnalysisData(
            global::RetellAI.StringAnalysisData? @string,
            global::RetellAI.EnumAnalysisData? @enum,
            global::RetellAI.BooleanAnalysisData? boolean,
            global::RetellAI.NumberAnalysisData? number
            )
        {
            String = @string;
            Enum = @enum;
            Boolean = boolean;
            Number = number;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Number as object ??
            Boolean as object ??
            Enum as object ??
            String as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            String?.ToString() ??
            Enum?.ToString() ??
            Boolean?.ToString() ??
            Number?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsString && !IsEnum && !IsBoolean && !IsNumber || !IsString && IsEnum && !IsBoolean && !IsNumber || !IsString && !IsEnum && IsBoolean && !IsNumber || !IsString && !IsEnum && !IsBoolean && IsNumber;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.StringAnalysisData?, TResult>? @string = null,
            global::System.Func<global::RetellAI.EnumAnalysisData?, TResult>? @enum = null,
            global::System.Func<global::RetellAI.BooleanAnalysisData?, TResult>? boolean = null,
            global::System.Func<global::RetellAI.NumberAnalysisData?, TResult>? number = null,
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
            else if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }
            else if (IsBoolean && boolean != null)
            {
                return boolean(Boolean!);
            }
            else if (IsNumber && number != null)
            {
                return number(Number!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.StringAnalysisData?>? @string = null,
            global::System.Action<global::RetellAI.EnumAnalysisData?>? @enum = null,
            global::System.Action<global::RetellAI.BooleanAnalysisData?>? boolean = null,
            global::System.Action<global::RetellAI.NumberAnalysisData?>? number = null,
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
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
            else if (IsBoolean)
            {
                boolean?.Invoke(Boolean!);
            }
            else if (IsNumber)
            {
                number?.Invoke(Number!);
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
                typeof(global::RetellAI.StringAnalysisData),
                Enum,
                typeof(global::RetellAI.EnumAnalysisData),
                Boolean,
                typeof(global::RetellAI.BooleanAnalysisData),
                Number,
                typeof(global::RetellAI.NumberAnalysisData),
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
        public bool Equals(AnalysisData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.StringAnalysisData?>.Default.Equals(String, other.String) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.EnumAnalysisData?>.Default.Equals(Enum, other.Enum) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.BooleanAnalysisData?>.Default.Equals(Boolean, other.Boolean) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.NumberAnalysisData?>.Default.Equals(Number, other.Number) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnalysisData obj1, AnalysisData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnalysisData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnalysisData obj1, AnalysisData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnalysisData o && Equals(o);
        }
    }
}
