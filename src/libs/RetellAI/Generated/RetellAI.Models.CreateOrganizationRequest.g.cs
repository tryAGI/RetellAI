#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateOrganizationRequest : global::System.IEquatable<CreateOrganizationRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.CreateOrganizationRequestNew? New { get; init; }
#else
        public global::RetellAI.CreateOrganizationRequestNew? New { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(New))]
#endif
        public bool IsNew => New != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.CreateOrganizationRequestOld? Old { get; init; }
#else
        public global::RetellAI.CreateOrganizationRequestOld? Old { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Old))]
#endif
        public bool IsOld => Old != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateOrganizationRequest(global::RetellAI.CreateOrganizationRequestNew value) => new CreateOrganizationRequest((global::RetellAI.CreateOrganizationRequestNew?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.CreateOrganizationRequestNew?(CreateOrganizationRequest @this) => @this.New;

        /// <summary>
        /// 
        /// </summary>
        public CreateOrganizationRequest(global::RetellAI.CreateOrganizationRequestNew? value)
        {
            New = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateOrganizationRequest(global::RetellAI.CreateOrganizationRequestOld value) => new CreateOrganizationRequest((global::RetellAI.CreateOrganizationRequestOld?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.CreateOrganizationRequestOld?(CreateOrganizationRequest @this) => @this.Old;

        /// <summary>
        /// 
        /// </summary>
        public CreateOrganizationRequest(global::RetellAI.CreateOrganizationRequestOld? value)
        {
            Old = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateOrganizationRequest(
            global::RetellAI.CreateOrganizationRequestNew? @new,
            global::RetellAI.CreateOrganizationRequestOld? old
            )
        {
            New = @new;
            Old = old;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Old as object ??
            New as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            New?.ToString() ??
            Old?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNew && !IsOld || !IsNew && IsOld;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.CreateOrganizationRequestNew?, TResult>? @new = null,
            global::System.Func<global::RetellAI.CreateOrganizationRequestOld?, TResult>? old = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNew && @new != null)
            {
                return @new(New!);
            }
            else if (IsOld && old != null)
            {
                return old(Old!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.CreateOrganizationRequestNew?>? @new = null,
            global::System.Action<global::RetellAI.CreateOrganizationRequestOld?>? old = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNew)
            {
                @new?.Invoke(New!);
            }
            else if (IsOld)
            {
                old?.Invoke(Old!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                New,
                typeof(global::RetellAI.CreateOrganizationRequestNew),
                Old,
                typeof(global::RetellAI.CreateOrganizationRequestOld),
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
        public bool Equals(CreateOrganizationRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.CreateOrganizationRequestNew?>.Default.Equals(New, other.New) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.CreateOrganizationRequestOld?>.Default.Equals(Old, other.Old) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateOrganizationRequest obj1, CreateOrganizationRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateOrganizationRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateOrganizationRequest obj1, CreateOrganizationRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateOrganizationRequest o && Equals(o);
        }
    }
}
