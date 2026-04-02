#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AgentResponse : global::System.IEquatable<AgentResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.AgentResponseVariant1? AgentResponseVariant1 { get; init; }
#else
        public global::RetellAI.AgentResponseVariant1? AgentResponseVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentResponseVariant1))]
#endif
        public bool IsAgentResponseVariant1 => AgentResponseVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.AgentRequest? Request { get; init; }
#else
        public global::RetellAI.AgentRequest? Request { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Request))]
#endif
        public bool IsRequest => Request != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.AgentResponseVariant3? AgentResponseVariant3 { get; init; }
#else
        public global::RetellAI.AgentResponseVariant3? AgentResponseVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentResponseVariant3))]
#endif
        public bool IsAgentResponseVariant3 => AgentResponseVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentResponse(global::RetellAI.AgentResponseVariant1 value) => new AgentResponse((global::RetellAI.AgentResponseVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.AgentResponseVariant1?(AgentResponse @this) => @this.AgentResponseVariant1;

        /// <summary>
        /// 
        /// </summary>
        public AgentResponse(global::RetellAI.AgentResponseVariant1? value)
        {
            AgentResponseVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentResponse(global::RetellAI.AgentRequest value) => new AgentResponse((global::RetellAI.AgentRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.AgentRequest?(AgentResponse @this) => @this.Request;

        /// <summary>
        /// 
        /// </summary>
        public AgentResponse(global::RetellAI.AgentRequest? value)
        {
            Request = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentResponse(global::RetellAI.AgentResponseVariant3 value) => new AgentResponse((global::RetellAI.AgentResponseVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.AgentResponseVariant3?(AgentResponse @this) => @this.AgentResponseVariant3;

        /// <summary>
        /// 
        /// </summary>
        public AgentResponse(global::RetellAI.AgentResponseVariant3? value)
        {
            AgentResponseVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentResponse(
            global::RetellAI.AgentResponseVariant1? agentResponseVariant1,
            global::RetellAI.AgentRequest? request,
            global::RetellAI.AgentResponseVariant3? agentResponseVariant3
            )
        {
            AgentResponseVariant1 = agentResponseVariant1;
            Request = request;
            AgentResponseVariant3 = agentResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AgentResponseVariant3 as object ??
            Request as object ??
            AgentResponseVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentResponseVariant1?.ToString() ??
            Request?.ToString() ??
            AgentResponseVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentResponseVariant1 && IsRequest && IsAgentResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.AgentResponseVariant1?, TResult>? agentResponseVariant1 = null,
            global::System.Func<global::RetellAI.AgentRequest?, TResult>? request = null,
            global::System.Func<global::RetellAI.AgentResponseVariant3?, TResult>? agentResponseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentResponseVariant1 && agentResponseVariant1 != null)
            {
                return agentResponseVariant1(AgentResponseVariant1!);
            }
            else if (IsRequest && request != null)
            {
                return request(Request!);
            }
            else if (IsAgentResponseVariant3 && agentResponseVariant3 != null)
            {
                return agentResponseVariant3(AgentResponseVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.AgentResponseVariant1?>? agentResponseVariant1 = null,
            global::System.Action<global::RetellAI.AgentRequest?>? request = null,
            global::System.Action<global::RetellAI.AgentResponseVariant3?>? agentResponseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentResponseVariant1)
            {
                agentResponseVariant1?.Invoke(AgentResponseVariant1!);
            }
            else if (IsRequest)
            {
                request?.Invoke(Request!);
            }
            else if (IsAgentResponseVariant3)
            {
                agentResponseVariant3?.Invoke(AgentResponseVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AgentResponseVariant1,
                typeof(global::RetellAI.AgentResponseVariant1),
                Request,
                typeof(global::RetellAI.AgentRequest),
                AgentResponseVariant3,
                typeof(global::RetellAI.AgentResponseVariant3),
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
        public bool Equals(AgentResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AgentResponseVariant1?>.Default.Equals(AgentResponseVariant1, other.AgentResponseVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AgentRequest?>.Default.Equals(Request, other.Request) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AgentResponseVariant3?>.Default.Equals(AgentResponseVariant3, other.AgentResponseVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentResponse obj1, AgentResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentResponse obj1, AgentResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentResponse o && Equals(o);
        }
    }
}
