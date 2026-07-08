#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InjectedMessage : global::System.IEquatable<InjectedMessage>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.InjectedMessageBase? Base { get; init; }
#else
        public global::RetellAI.InjectedMessageBase? Base { get; }
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
            out global::RetellAI.InjectedMessageBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.InjectedMessageBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? InjectedMessageVariant2 { get; init; }
#else
        public object? InjectedMessageVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InjectedMessageVariant2))]
#endif
        public bool IsInjectedMessageVariant2 => InjectedMessageVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInjectedMessageVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = InjectedMessageVariant2;
            return IsInjectedMessageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickInjectedMessageVariant2() => IsInjectedMessageVariant2
            ? InjectedMessageVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InjectedMessageVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InjectedMessage(global::RetellAI.InjectedMessageBase value) => new InjectedMessage((global::RetellAI.InjectedMessageBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.InjectedMessageBase?(InjectedMessage @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public InjectedMessage(global::RetellAI.InjectedMessageBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InjectedMessage FromBase(global::RetellAI.InjectedMessageBase? value) => new InjectedMessage(value);

        /// <summary>
        /// 
        /// </summary>
        public InjectedMessage(
            global::RetellAI.InjectedMessageBase? @base,
            object? injectedMessageVariant2
            )
        {
            Base = @base;
            InjectedMessageVariant2 = injectedMessageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InjectedMessageVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            InjectedMessageVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsInjectedMessageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.InjectedMessageBase, TResult>? @base = null,
            global::System.Func<object, TResult>? injectedMessageVariant2 = null,
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
            else if (IsInjectedMessageVariant2 && injectedMessageVariant2 != null)
            {
                return injectedMessageVariant2(InjectedMessageVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.InjectedMessageBase>? @base = null,

            global::System.Action<object>? injectedMessageVariant2 = null,
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
            else if (IsInjectedMessageVariant2)
            {
                injectedMessageVariant2?.Invoke(InjectedMessageVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.InjectedMessageBase>? @base = null,
            global::System.Action<object>? injectedMessageVariant2 = null,
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
            else if (IsInjectedMessageVariant2)
            {
                injectedMessageVariant2?.Invoke(InjectedMessageVariant2!);
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
                typeof(global::RetellAI.InjectedMessageBase),
                InjectedMessageVariant2,
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
        public bool Equals(InjectedMessage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.InjectedMessageBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(InjectedMessageVariant2, other.InjectedMessageVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InjectedMessage obj1, InjectedMessage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InjectedMessage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InjectedMessage obj1, InjectedMessage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InjectedMessage o && Equals(o);
        }
    }
}
