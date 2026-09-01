#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// A `CallFilter` as persisted on a dashboard or chart. The extra field records how the selection was made, not what to match. Definition-based chart queries use it while merging filters, then query the combined `agent` field.
    /// </summary>
    public readonly partial struct StoredCallFilter : global::System.IEquatable<StoredCallFilter>
    {
        /// <summary>
        /// Filter criteria for calls. All conditions are implicitly connected with AND.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.CallFilter? CallFilter { get; init; }
#else
        public global::RetellAI.CallFilter? CallFilter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CallFilter))]
#endif
        public bool IsCallFilter => CallFilter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCallFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.CallFilter? value)
        {
            value = CallFilter;
            return IsCallFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CallFilter PickCallFilter() => IsCallFilter
            ? CallFilter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CallFilter' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.StoredCallFilterVariant2? StoredCallFilterVariant2 { get; init; }
#else
        public global::RetellAI.StoredCallFilterVariant2? StoredCallFilterVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StoredCallFilterVariant2))]
#endif
        public bool IsStoredCallFilterVariant2 => StoredCallFilterVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStoredCallFilterVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.StoredCallFilterVariant2? value)
        {
            value = StoredCallFilterVariant2;
            return IsStoredCallFilterVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.StoredCallFilterVariant2 PickStoredCallFilterVariant2() => IsStoredCallFilterVariant2
            ? StoredCallFilterVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StoredCallFilterVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StoredCallFilter(global::RetellAI.CallFilter value) => new StoredCallFilter((global::RetellAI.CallFilter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.CallFilter?(StoredCallFilter @this) => @this.CallFilter;

        /// <summary>
        ///
        /// </summary>
        public StoredCallFilter(global::RetellAI.CallFilter? value)
        {
            CallFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StoredCallFilter FromCallFilter(global::RetellAI.CallFilter? value) => new StoredCallFilter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StoredCallFilter(global::RetellAI.StoredCallFilterVariant2 value) => new StoredCallFilter((global::RetellAI.StoredCallFilterVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.StoredCallFilterVariant2?(StoredCallFilter @this) => @this.StoredCallFilterVariant2;

        /// <summary>
        ///
        /// </summary>
        public StoredCallFilter(global::RetellAI.StoredCallFilterVariant2? value)
        {
            StoredCallFilterVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StoredCallFilter FromStoredCallFilterVariant2(global::RetellAI.StoredCallFilterVariant2? value) => new StoredCallFilter(value);

        /// <summary>
        ///
        /// </summary>
        public StoredCallFilter(
            global::RetellAI.CallFilter? callFilter,
            global::RetellAI.StoredCallFilterVariant2? storedCallFilterVariant2
            )
        {
            CallFilter = callFilter;
            StoredCallFilterVariant2 = storedCallFilterVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StoredCallFilterVariant2 as object ??
            CallFilter as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CallFilter?.ToString() ??
            StoredCallFilterVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCallFilter && IsStoredCallFilterVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.CallFilter, TResult>? callFilter = null,
            global::System.Func<global::RetellAI.StoredCallFilterVariant2, TResult>? storedCallFilterVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCallFilter && callFilter != null)
            {
                return callFilter(CallFilter!);
            }
            else if (IsStoredCallFilterVariant2 && storedCallFilterVariant2 != null)
            {
                return storedCallFilterVariant2(StoredCallFilterVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.CallFilter>? callFilter = null,

            global::System.Action<global::RetellAI.StoredCallFilterVariant2>? storedCallFilterVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCallFilter)
            {
                callFilter?.Invoke(CallFilter!);
            }
            else if (IsStoredCallFilterVariant2)
            {
                storedCallFilterVariant2?.Invoke(StoredCallFilterVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.CallFilter>? callFilter = null,
            global::System.Action<global::RetellAI.StoredCallFilterVariant2>? storedCallFilterVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCallFilter)
            {
                callFilter?.Invoke(CallFilter!);
            }
            else if (IsStoredCallFilterVariant2)
            {
                storedCallFilterVariant2?.Invoke(StoredCallFilterVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CallFilter,
                typeof(global::RetellAI.CallFilter),
                StoredCallFilterVariant2,
                typeof(global::RetellAI.StoredCallFilterVariant2),
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
        public bool Equals(StoredCallFilter other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.CallFilter?>.Default.Equals(CallFilter, other.CallFilter) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.StoredCallFilterVariant2?>.Default.Equals(StoredCallFilterVariant2, other.StoredCallFilterVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StoredCallFilter obj1, StoredCallFilter obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StoredCallFilter>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StoredCallFilter obj1, StoredCallFilter obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StoredCallFilter o && Equals(o);
        }
    }
}
