#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// A filter on a custom field, identified by key.
    /// </summary>
    public readonly partial struct CustomFieldFilter : global::System.IEquatable<CustomFieldFilter>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ValueFilter? Value { get; init; }
#else
        public global::RetellAI.ValueFilter? Value { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value))]
#endif
        public bool IsValue => Value != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.CustomFieldFilterVariant2? CustomFieldFilterVariant2 { get; init; }
#else
        public global::RetellAI.CustomFieldFilterVariant2? CustomFieldFilterVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomFieldFilterVariant2))]
#endif
        public bool IsCustomFieldFilterVariant2 => CustomFieldFilterVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomFieldFilter(global::RetellAI.ValueFilter value) => new CustomFieldFilter((global::RetellAI.ValueFilter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ValueFilter?(CustomFieldFilter @this) => @this.Value;

        /// <summary>
        /// 
        /// </summary>
        public CustomFieldFilter(global::RetellAI.ValueFilter? value)
        {
            Value = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomFieldFilter(global::RetellAI.CustomFieldFilterVariant2 value) => new CustomFieldFilter((global::RetellAI.CustomFieldFilterVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.CustomFieldFilterVariant2?(CustomFieldFilter @this) => @this.CustomFieldFilterVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CustomFieldFilter(global::RetellAI.CustomFieldFilterVariant2? value)
        {
            CustomFieldFilterVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CustomFieldFilter(
            global::RetellAI.ValueFilter? value,
            global::RetellAI.CustomFieldFilterVariant2? customFieldFilterVariant2
            )
        {
            Value = value;
            CustomFieldFilterVariant2 = customFieldFilterVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CustomFieldFilterVariant2 as object ??
            Value as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value?.ToString() ??
            CustomFieldFilterVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue && IsCustomFieldFilterVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ValueFilter?, TResult>? value = null,
            global::System.Func<global::RetellAI.CustomFieldFilterVariant2?, TResult>? customFieldFilterVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue && value != null)
            {
                return value(Value!);
            }
            else if (IsCustomFieldFilterVariant2 && customFieldFilterVariant2 != null)
            {
                return customFieldFilterVariant2(CustomFieldFilterVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ValueFilter?>? value = null,
            global::System.Action<global::RetellAI.CustomFieldFilterVariant2?>? customFieldFilterVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue)
            {
                value?.Invoke(Value!);
            }
            else if (IsCustomFieldFilterVariant2)
            {
                customFieldFilterVariant2?.Invoke(CustomFieldFilterVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value,
                typeof(global::RetellAI.ValueFilter),
                CustomFieldFilterVariant2,
                typeof(global::RetellAI.CustomFieldFilterVariant2),
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
        public bool Equals(CustomFieldFilter other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ValueFilter?>.Default.Equals(Value, other.Value) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.CustomFieldFilterVariant2?>.Default.Equals(CustomFieldFilterVariant2, other.CustomFieldFilterVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CustomFieldFilter obj1, CustomFieldFilter obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CustomFieldFilter>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CustomFieldFilter obj1, CustomFieldFilter obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CustomFieldFilter o && Equals(o);
        }
    }
}
