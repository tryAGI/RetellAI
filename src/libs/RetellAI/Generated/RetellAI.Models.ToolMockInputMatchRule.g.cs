#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolMockInputMatchRule : global::System.IEquatable<ToolMockInputMatchRule>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ToolMockInputMatchRuleVariant1? ToolMockInputMatchRuleVariant1 { get; init; }
#else
        public global::RetellAI.ToolMockInputMatchRuleVariant1? ToolMockInputMatchRuleVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolMockInputMatchRuleVariant1))]
#endif
        public bool IsToolMockInputMatchRuleVariant1 => ToolMockInputMatchRuleVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ToolMockInputMatchRuleVariant2? ToolMockInputMatchRuleVariant2 { get; init; }
#else
        public global::RetellAI.ToolMockInputMatchRuleVariant2? ToolMockInputMatchRuleVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolMockInputMatchRuleVariant2))]
#endif
        public bool IsToolMockInputMatchRuleVariant2 => ToolMockInputMatchRuleVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolMockInputMatchRule(global::RetellAI.ToolMockInputMatchRuleVariant1 value) => new ToolMockInputMatchRule((global::RetellAI.ToolMockInputMatchRuleVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ToolMockInputMatchRuleVariant1?(ToolMockInputMatchRule @this) => @this.ToolMockInputMatchRuleVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ToolMockInputMatchRule(global::RetellAI.ToolMockInputMatchRuleVariant1? value)
        {
            ToolMockInputMatchRuleVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolMockInputMatchRule(global::RetellAI.ToolMockInputMatchRuleVariant2 value) => new ToolMockInputMatchRule((global::RetellAI.ToolMockInputMatchRuleVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ToolMockInputMatchRuleVariant2?(ToolMockInputMatchRule @this) => @this.ToolMockInputMatchRuleVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ToolMockInputMatchRule(global::RetellAI.ToolMockInputMatchRuleVariant2? value)
        {
            ToolMockInputMatchRuleVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolMockInputMatchRule(
            global::RetellAI.ToolMockInputMatchRuleVariant1? toolMockInputMatchRuleVariant1,
            global::RetellAI.ToolMockInputMatchRuleVariant2? toolMockInputMatchRuleVariant2
            )
        {
            ToolMockInputMatchRuleVariant1 = toolMockInputMatchRuleVariant1;
            ToolMockInputMatchRuleVariant2 = toolMockInputMatchRuleVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolMockInputMatchRuleVariant2 as object ??
            ToolMockInputMatchRuleVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ToolMockInputMatchRuleVariant1?.ToString() ??
            ToolMockInputMatchRuleVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsToolMockInputMatchRuleVariant1 && !IsToolMockInputMatchRuleVariant2 || !IsToolMockInputMatchRuleVariant1 && IsToolMockInputMatchRuleVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ToolMockInputMatchRuleVariant1?, TResult>? toolMockInputMatchRuleVariant1 = null,
            global::System.Func<global::RetellAI.ToolMockInputMatchRuleVariant2?, TResult>? toolMockInputMatchRuleVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolMockInputMatchRuleVariant1 && toolMockInputMatchRuleVariant1 != null)
            {
                return toolMockInputMatchRuleVariant1(ToolMockInputMatchRuleVariant1!);
            }
            else if (IsToolMockInputMatchRuleVariant2 && toolMockInputMatchRuleVariant2 != null)
            {
                return toolMockInputMatchRuleVariant2(ToolMockInputMatchRuleVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ToolMockInputMatchRuleVariant1?>? toolMockInputMatchRuleVariant1 = null,
            global::System.Action<global::RetellAI.ToolMockInputMatchRuleVariant2?>? toolMockInputMatchRuleVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolMockInputMatchRuleVariant1)
            {
                toolMockInputMatchRuleVariant1?.Invoke(ToolMockInputMatchRuleVariant1!);
            }
            else if (IsToolMockInputMatchRuleVariant2)
            {
                toolMockInputMatchRuleVariant2?.Invoke(ToolMockInputMatchRuleVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ToolMockInputMatchRuleVariant1,
                typeof(global::RetellAI.ToolMockInputMatchRuleVariant1),
                ToolMockInputMatchRuleVariant2,
                typeof(global::RetellAI.ToolMockInputMatchRuleVariant2),
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
        public bool Equals(ToolMockInputMatchRule other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ToolMockInputMatchRuleVariant1?>.Default.Equals(ToolMockInputMatchRuleVariant1, other.ToolMockInputMatchRuleVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ToolMockInputMatchRuleVariant2?>.Default.Equals(ToolMockInputMatchRuleVariant2, other.ToolMockInputMatchRuleVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolMockInputMatchRule obj1, ToolMockInputMatchRule obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolMockInputMatchRule>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolMockInputMatchRule obj1, ToolMockInputMatchRule obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolMockInputMatchRule o && Equals(o);
        }
    }
}
