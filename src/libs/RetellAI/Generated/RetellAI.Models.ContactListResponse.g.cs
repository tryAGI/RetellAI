#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ContactListResponse : global::System.IEquatable<ContactListResponse>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.PaginatedResponseBase? PaginatedBase { get; init; }
#else
        public global::RetellAI.PaginatedResponseBase? PaginatedBase { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PaginatedBase))]
#endif
        public bool IsPaginatedBase => PaginatedBase != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPaginatedBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.PaginatedResponseBase? value)
        {
            value = PaginatedBase;
            return IsPaginatedBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PaginatedResponseBase PickPaginatedBase() => IsPaginatedBase
            ? PaginatedBase!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PaginatedBase' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ContactListResponseVariant2? ContactListResponseVariant2 { get; init; }
#else
        public global::RetellAI.ContactListResponseVariant2? ContactListResponseVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContactListResponseVariant2))]
#endif
        public bool IsContactListResponseVariant2 => ContactListResponseVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContactListResponseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ContactListResponseVariant2? value)
        {
            value = ContactListResponseVariant2;
            return IsContactListResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactListResponseVariant2 PickContactListResponseVariant2() => IsContactListResponseVariant2
            ? ContactListResponseVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContactListResponseVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContactListResponse(global::RetellAI.PaginatedResponseBase value) => new ContactListResponse((global::RetellAI.PaginatedResponseBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.PaginatedResponseBase?(ContactListResponse @this) => @this.PaginatedBase;

        /// <summary>
        ///
        /// </summary>
        public ContactListResponse(global::RetellAI.PaginatedResponseBase? value)
        {
            PaginatedBase = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContactListResponse FromPaginatedBase(global::RetellAI.PaginatedResponseBase? value) => new ContactListResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContactListResponse(global::RetellAI.ContactListResponseVariant2 value) => new ContactListResponse((global::RetellAI.ContactListResponseVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ContactListResponseVariant2?(ContactListResponse @this) => @this.ContactListResponseVariant2;

        /// <summary>
        ///
        /// </summary>
        public ContactListResponse(global::RetellAI.ContactListResponseVariant2? value)
        {
            ContactListResponseVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContactListResponse FromContactListResponseVariant2(global::RetellAI.ContactListResponseVariant2? value) => new ContactListResponse(value);

        /// <summary>
        ///
        /// </summary>
        public ContactListResponse(
            global::RetellAI.PaginatedResponseBase? paginatedBase,
            global::RetellAI.ContactListResponseVariant2? contactListResponseVariant2
            )
        {
            PaginatedBase = paginatedBase;
            ContactListResponseVariant2 = contactListResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ContactListResponseVariant2 as object ??
            PaginatedBase as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PaginatedBase?.ToString() ??
            ContactListResponseVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPaginatedBase && IsContactListResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.PaginatedResponseBase, TResult>? paginatedBase = null,
            global::System.Func<global::RetellAI.ContactListResponseVariant2, TResult>? contactListResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPaginatedBase && paginatedBase != null)
            {
                return paginatedBase(PaginatedBase!);
            }
            else if (IsContactListResponseVariant2 && contactListResponseVariant2 != null)
            {
                return contactListResponseVariant2(ContactListResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.PaginatedResponseBase>? paginatedBase = null,

            global::System.Action<global::RetellAI.ContactListResponseVariant2>? contactListResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPaginatedBase)
            {
                paginatedBase?.Invoke(PaginatedBase!);
            }
            else if (IsContactListResponseVariant2)
            {
                contactListResponseVariant2?.Invoke(ContactListResponseVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.PaginatedResponseBase>? paginatedBase = null,
            global::System.Action<global::RetellAI.ContactListResponseVariant2>? contactListResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPaginatedBase)
            {
                paginatedBase?.Invoke(PaginatedBase!);
            }
            else if (IsContactListResponseVariant2)
            {
                contactListResponseVariant2?.Invoke(ContactListResponseVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PaginatedBase,
                typeof(global::RetellAI.PaginatedResponseBase),
                ContactListResponseVariant2,
                typeof(global::RetellAI.ContactListResponseVariant2),
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
        public bool Equals(ContactListResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.PaginatedResponseBase?>.Default.Equals(PaginatedBase, other.PaginatedBase) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ContactListResponseVariant2?>.Default.Equals(ContactListResponseVariant2, other.ContactListResponseVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ContactListResponse obj1, ContactListResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContactListResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ContactListResponse obj1, ContactListResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContactListResponse o && Equals(o);
        }
    }
}
