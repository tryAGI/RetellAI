#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UpdateOrganizationRequest : global::System.IEquatable<UpdateOrganizationRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.CreateOrganizationRequest? Create { get; init; }
#else
        public global::RetellAI.CreateOrganizationRequest? Create { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Create))]
#endif
        public bool IsCreate => Create != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.UpdateOrganizationRequestVariant2? UpdateOrganizationRequestVariant2 { get; init; }
#else
        public global::RetellAI.UpdateOrganizationRequestVariant2? UpdateOrganizationRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateOrganizationRequestVariant2))]
#endif
        public bool IsUpdateOrganizationRequestVariant2 => UpdateOrganizationRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateOrganizationRequest(global::RetellAI.CreateOrganizationRequest value) => new UpdateOrganizationRequest((global::RetellAI.CreateOrganizationRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.CreateOrganizationRequest?(UpdateOrganizationRequest @this) => @this.Create;

        /// <summary>
        /// 
        /// </summary>
        public UpdateOrganizationRequest(global::RetellAI.CreateOrganizationRequest? value)
        {
            Create = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateOrganizationRequest(global::RetellAI.UpdateOrganizationRequestVariant2 value) => new UpdateOrganizationRequest((global::RetellAI.UpdateOrganizationRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.UpdateOrganizationRequestVariant2?(UpdateOrganizationRequest @this) => @this.UpdateOrganizationRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public UpdateOrganizationRequest(global::RetellAI.UpdateOrganizationRequestVariant2? value)
        {
            UpdateOrganizationRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UpdateOrganizationRequest(
            global::RetellAI.CreateOrganizationRequest? create,
            global::RetellAI.UpdateOrganizationRequestVariant2? updateOrganizationRequestVariant2
            )
        {
            Create = create;
            UpdateOrganizationRequestVariant2 = updateOrganizationRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UpdateOrganizationRequestVariant2 as object ??
            Create as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Create?.ToString() ??
            UpdateOrganizationRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreate && IsUpdateOrganizationRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.CreateOrganizationRequest?, TResult>? create = null,
            global::System.Func<global::RetellAI.UpdateOrganizationRequestVariant2?, TResult>? updateOrganizationRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreate && create != null)
            {
                return create(Create!);
            }
            else if (IsUpdateOrganizationRequestVariant2 && updateOrganizationRequestVariant2 != null)
            {
                return updateOrganizationRequestVariant2(UpdateOrganizationRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.CreateOrganizationRequest?>? create = null,
            global::System.Action<global::RetellAI.UpdateOrganizationRequestVariant2?>? updateOrganizationRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreate)
            {
                create?.Invoke(Create!);
            }
            else if (IsUpdateOrganizationRequestVariant2)
            {
                updateOrganizationRequestVariant2?.Invoke(UpdateOrganizationRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Create,
                typeof(global::RetellAI.CreateOrganizationRequest),
                UpdateOrganizationRequestVariant2,
                typeof(global::RetellAI.UpdateOrganizationRequestVariant2),
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
        public bool Equals(UpdateOrganizationRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.CreateOrganizationRequest?>.Default.Equals(Create, other.Create) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.UpdateOrganizationRequestVariant2?>.Default.Equals(UpdateOrganizationRequestVariant2, other.UpdateOrganizationRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateOrganizationRequest obj1, UpdateOrganizationRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateOrganizationRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateOrganizationRequest obj1, UpdateOrganizationRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateOrganizationRequest o && Equals(o);
        }
    }
}
