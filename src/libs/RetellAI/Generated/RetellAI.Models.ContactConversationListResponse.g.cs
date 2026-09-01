#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ContactConversationListResponse : global::System.IEquatable<ContactConversationListResponse>
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
        public global::RetellAI.ContactConversationListResponseVariant2? ContactConversationListResponseVariant2 { get; init; }
#else
        public global::RetellAI.ContactConversationListResponseVariant2? ContactConversationListResponseVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContactConversationListResponseVariant2))]
#endif
        public bool IsContactConversationListResponseVariant2 => ContactConversationListResponseVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContactConversationListResponseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ContactConversationListResponseVariant2? value)
        {
            value = ContactConversationListResponseVariant2;
            return IsContactConversationListResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ContactConversationListResponseVariant2 PickContactConversationListResponseVariant2() => IsContactConversationListResponseVariant2
            ? ContactConversationListResponseVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContactConversationListResponseVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContactConversationListResponse(global::RetellAI.PaginatedResponseBase value) => new ContactConversationListResponse((global::RetellAI.PaginatedResponseBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.PaginatedResponseBase?(ContactConversationListResponse @this) => @this.PaginatedBase;

        /// <summary>
        ///
        /// </summary>
        public ContactConversationListResponse(global::RetellAI.PaginatedResponseBase? value)
        {
            PaginatedBase = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContactConversationListResponse FromPaginatedBase(global::RetellAI.PaginatedResponseBase? value) => new ContactConversationListResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContactConversationListResponse(global::RetellAI.ContactConversationListResponseVariant2 value) => new ContactConversationListResponse((global::RetellAI.ContactConversationListResponseVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ContactConversationListResponseVariant2?(ContactConversationListResponse @this) => @this.ContactConversationListResponseVariant2;

        /// <summary>
        ///
        /// </summary>
        public ContactConversationListResponse(global::RetellAI.ContactConversationListResponseVariant2? value)
        {
            ContactConversationListResponseVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContactConversationListResponse FromContactConversationListResponseVariant2(global::RetellAI.ContactConversationListResponseVariant2? value) => new ContactConversationListResponse(value);

        /// <summary>
        ///
        /// </summary>
        public ContactConversationListResponse(
            global::RetellAI.PaginatedResponseBase? paginatedBase,
            global::RetellAI.ContactConversationListResponseVariant2? contactConversationListResponseVariant2
            )
        {
            PaginatedBase = paginatedBase;
            ContactConversationListResponseVariant2 = contactConversationListResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ContactConversationListResponseVariant2 as object ??
            PaginatedBase as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PaginatedBase?.ToString() ??
            ContactConversationListResponseVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPaginatedBase && IsContactConversationListResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.PaginatedResponseBase, TResult>? paginatedBase = null,
            global::System.Func<global::RetellAI.ContactConversationListResponseVariant2, TResult>? contactConversationListResponseVariant2 = null,
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
            else if (IsContactConversationListResponseVariant2 && contactConversationListResponseVariant2 != null)
            {
                return contactConversationListResponseVariant2(ContactConversationListResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.PaginatedResponseBase>? paginatedBase = null,

            global::System.Action<global::RetellAI.ContactConversationListResponseVariant2>? contactConversationListResponseVariant2 = null,
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
            else if (IsContactConversationListResponseVariant2)
            {
                contactConversationListResponseVariant2?.Invoke(ContactConversationListResponseVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.PaginatedResponseBase>? paginatedBase = null,
            global::System.Action<global::RetellAI.ContactConversationListResponseVariant2>? contactConversationListResponseVariant2 = null,
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
            else if (IsContactConversationListResponseVariant2)
            {
                contactConversationListResponseVariant2?.Invoke(ContactConversationListResponseVariant2!);
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
                ContactConversationListResponseVariant2,
                typeof(global::RetellAI.ContactConversationListResponseVariant2),
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
        public bool Equals(ContactConversationListResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.PaginatedResponseBase?>.Default.Equals(PaginatedBase, other.PaginatedBase) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ContactConversationListResponseVariant2?>.Default.Equals(ContactConversationListResponseVariant2, other.ContactConversationListResponseVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ContactConversationListResponse obj1, ContactConversationListResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContactConversationListResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ContactConversationListResponse obj1, ContactConversationListResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContactConversationListResponse o && Equals(o);
        }
    }
}
