#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct StateTransitionMessage : global::System.IEquatable<StateTransitionMessage>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.StateTransitionMessageBase? Base { get; init; }
#else
        public global::RetellAI.StateTransitionMessageBase? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.StateTransitionMessageBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? StateTransitionMessageVariant2 { get; init; }
#else
        public object? StateTransitionMessageVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StateTransitionMessageVariant2))]
#endif
        public bool IsStateTransitionMessageVariant2 => StateTransitionMessageVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStateTransitionMessageVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = StateTransitionMessageVariant2;
            return IsStateTransitionMessageVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StateTransitionMessage(global::RetellAI.StateTransitionMessageBase value) => new StateTransitionMessage((global::RetellAI.StateTransitionMessageBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.StateTransitionMessageBase?(StateTransitionMessage @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public StateTransitionMessage(global::RetellAI.StateTransitionMessageBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StateTransitionMessage FromBase(global::RetellAI.StateTransitionMessageBase? value) => new StateTransitionMessage(value);

        /// <summary>
        /// 
        /// </summary>
        public StateTransitionMessage(
            global::RetellAI.StateTransitionMessageBase? @base,
            object? stateTransitionMessageVariant2
            )
        {
            Base = @base;
            StateTransitionMessageVariant2 = stateTransitionMessageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StateTransitionMessageVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            StateTransitionMessageVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsStateTransitionMessageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.StateTransitionMessageBase, TResult>? @base = null,
            global::System.Func<object, TResult>? stateTransitionMessageVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsStateTransitionMessageVariant2 && stateTransitionMessageVariant2 != null)
            {
                return stateTransitionMessageVariant2(StateTransitionMessageVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.StateTransitionMessageBase>? @base = null,

            global::System.Action<object>? stateTransitionMessageVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsStateTransitionMessageVariant2)
            {
                stateTransitionMessageVariant2?.Invoke(StateTransitionMessageVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.StateTransitionMessageBase>? @base = null,
            global::System.Action<object>? stateTransitionMessageVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsStateTransitionMessageVariant2)
            {
                stateTransitionMessageVariant2?.Invoke(StateTransitionMessageVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::RetellAI.StateTransitionMessageBase),
                StateTransitionMessageVariant2,
                typeof(object),
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
        public bool Equals(StateTransitionMessage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.StateTransitionMessageBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(StateTransitionMessageVariant2, other.StateTransitionMessageVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StateTransitionMessage obj1, StateTransitionMessage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StateTransitionMessage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StateTransitionMessage obj1, StateTransitionMessage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StateTransitionMessage o && Equals(o);
        }
    }
}
