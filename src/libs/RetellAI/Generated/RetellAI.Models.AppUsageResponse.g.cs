#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// One agent or knowledge base referencing an app.
    /// </summary>
    public readonly partial struct AppUsageResponse : global::System.IEquatable<AppUsageResponse>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.AgentAppUsage? Agent { get; init; }
#else
        public global::RetellAI.AgentAppUsage? Agent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Agent))]
#endif
        public bool IsAgent => Agent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.AgentAppUsage? value)
        {
            value = Agent;
            return IsAgent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.AgentAppUsage PickAgent() => IsAgent
            ? Agent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Agent' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.KnowledgeBaseAppUsage? KnowledgeBase { get; init; }
#else
        public global::RetellAI.KnowledgeBaseAppUsage? KnowledgeBase { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KnowledgeBase))]
#endif
        public bool IsKnowledgeBase => KnowledgeBase != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKnowledgeBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.KnowledgeBaseAppUsage? value)
        {
            value = KnowledgeBase;
            return IsKnowledgeBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.KnowledgeBaseAppUsage PickKnowledgeBase() => IsKnowledgeBase
            ? KnowledgeBase!
            : throw new global::System.InvalidOperationException($"Expected union variant 'KnowledgeBase' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AppUsageResponse(global::RetellAI.AgentAppUsage value) => new AppUsageResponse((global::RetellAI.AgentAppUsage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.AgentAppUsage?(AppUsageResponse @this) => @this.Agent;

        /// <summary>
        ///
        /// </summary>
        public AppUsageResponse(global::RetellAI.AgentAppUsage? value)
        {
            Agent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AppUsageResponse FromAgent(global::RetellAI.AgentAppUsage? value) => new AppUsageResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AppUsageResponse(global::RetellAI.KnowledgeBaseAppUsage value) => new AppUsageResponse((global::RetellAI.KnowledgeBaseAppUsage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.KnowledgeBaseAppUsage?(AppUsageResponse @this) => @this.KnowledgeBase;

        /// <summary>
        ///
        /// </summary>
        public AppUsageResponse(global::RetellAI.KnowledgeBaseAppUsage? value)
        {
            KnowledgeBase = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AppUsageResponse FromKnowledgeBase(global::RetellAI.KnowledgeBaseAppUsage? value) => new AppUsageResponse(value);

        /// <summary>
        ///
        /// </summary>
        public AppUsageResponse(
            global::RetellAI.AgentAppUsage? agent,
            global::RetellAI.KnowledgeBaseAppUsage? knowledgeBase
            )
        {
            Agent = agent;
            KnowledgeBase = knowledgeBase;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            KnowledgeBase as object ??
            Agent as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Agent?.ToString() ??
            KnowledgeBase?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAgent && !IsKnowledgeBase || !IsAgent && IsKnowledgeBase;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.AgentAppUsage, TResult>? agent = null,
            global::System.Func<global::RetellAI.KnowledgeBaseAppUsage, TResult>? knowledgeBase = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgent && agent != null)
            {
                return agent(Agent!);
            }
            else if (IsKnowledgeBase && knowledgeBase != null)
            {
                return knowledgeBase(KnowledgeBase!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.AgentAppUsage>? agent = null,

            global::System.Action<global::RetellAI.KnowledgeBaseAppUsage>? knowledgeBase = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgent)
            {
                agent?.Invoke(Agent!);
            }
            else if (IsKnowledgeBase)
            {
                knowledgeBase?.Invoke(KnowledgeBase!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.AgentAppUsage>? agent = null,
            global::System.Action<global::RetellAI.KnowledgeBaseAppUsage>? knowledgeBase = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgent)
            {
                agent?.Invoke(Agent!);
            }
            else if (IsKnowledgeBase)
            {
                knowledgeBase?.Invoke(KnowledgeBase!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Agent,
                typeof(global::RetellAI.AgentAppUsage),
                KnowledgeBase,
                typeof(global::RetellAI.KnowledgeBaseAppUsage),
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
        public bool Equals(AppUsageResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AgentAppUsage?>.Default.Equals(Agent, other.Agent) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.KnowledgeBaseAppUsage?>.Default.Equals(KnowledgeBase, other.KnowledgeBase)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AppUsageResponse obj1, AppUsageResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AppUsageResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AppUsageResponse obj1, AppUsageResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AppUsageResponse o && Equals(o);
        }
    }
}
