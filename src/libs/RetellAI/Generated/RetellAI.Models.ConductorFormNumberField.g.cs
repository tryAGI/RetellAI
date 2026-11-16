#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// A number.
    /// </summary>
    public readonly partial struct ConductorFormNumberField : global::System.IEquatable<ConductorFormNumberField>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConductorFormFieldBase? Base { get; init; }
#else
        public global::RetellAI.ConductorFormFieldBase? Base { get; }
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
            out global::RetellAI.ConductorFormFieldBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormFieldBase PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConductorFormNumberFieldVariant2? ConductorFormNumberFieldVariant2 { get; init; }
#else
        public global::RetellAI.ConductorFormNumberFieldVariant2? ConductorFormNumberFieldVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConductorFormNumberFieldVariant2))]
#endif
        public bool IsConductorFormNumberFieldVariant2 => ConductorFormNumberFieldVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConductorFormNumberFieldVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorFormNumberFieldVariant2? value)
        {
            value = ConductorFormNumberFieldVariant2;
            return IsConductorFormNumberFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormNumberFieldVariant2 PickConductorFormNumberFieldVariant2() => ConductorFormNumberFieldVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConductorFormNumberFieldVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormNumberField(global::RetellAI.ConductorFormFieldBase value) => new ConductorFormNumberField((global::RetellAI.ConductorFormFieldBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormFieldBase?(ConductorFormNumberField @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormNumberField(global::RetellAI.ConductorFormFieldBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormNumberField FromBase(global::RetellAI.ConductorFormFieldBase? value) => new ConductorFormNumberField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormNumberField(global::RetellAI.ConductorFormNumberFieldVariant2 value) => new ConductorFormNumberField((global::RetellAI.ConductorFormNumberFieldVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormNumberFieldVariant2?(ConductorFormNumberField @this) => @this.ConductorFormNumberFieldVariant2;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormNumberField(global::RetellAI.ConductorFormNumberFieldVariant2? value)
        {
            ConductorFormNumberFieldVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormNumberField FromConductorFormNumberFieldVariant2(global::RetellAI.ConductorFormNumberFieldVariant2? value) => new ConductorFormNumberField(value);

        /// <summary>
        ///
        /// </summary>
        public ConductorFormNumberField(
            global::RetellAI.ConductorFormFieldBase? @base,
            global::RetellAI.ConductorFormNumberFieldVariant2? conductorFormNumberFieldVariant2
            )
        {
            Base = @base;
            ConductorFormNumberFieldVariant2 = conductorFormNumberFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ConductorFormNumberFieldVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ConductorFormNumberFieldVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsConductorFormNumberFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ConductorFormFieldBase?, TResult>? @base = null,
            global::System.Func<global::RetellAI.ConductorFormNumberFieldVariant2, TResult>? conductorFormNumberFieldVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0 && @base != null)
            {
                return @base(__value0);
            }
            else if (ConductorFormNumberFieldVariant2 is { } __value1 && conductorFormNumberFieldVariant2 != null)
            {
                return conductorFormNumberFieldVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ConductorFormFieldBase?>? @base = null,

            global::System.Action<global::RetellAI.ConductorFormNumberFieldVariant2>? conductorFormNumberFieldVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (ConductorFormNumberFieldVariant2 is { } __value1)
            {
                conductorFormNumberFieldVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ConductorFormFieldBase?>? @base = null,
            global::System.Action<global::RetellAI.ConductorFormNumberFieldVariant2>? conductorFormNumberFieldVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (ConductorFormNumberFieldVariant2 is { } __value1)
            {
                conductorFormNumberFieldVariant2?.Invoke(__value1);
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
                typeof(global::RetellAI.ConductorFormFieldBase),
                ConductorFormNumberFieldVariant2,
                typeof(global::RetellAI.ConductorFormNumberFieldVariant2),
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
        public bool Equals(ConductorFormNumberField other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormFieldBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormNumberFieldVariant2?>.Default.Equals(ConductorFormNumberFieldVariant2, other.ConductorFormNumberFieldVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ConductorFormNumberField obj1, ConductorFormNumberField obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConductorFormNumberField>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ConductorFormNumberField obj1, ConductorFormNumberField obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConductorFormNumberField o && Equals(o);
        }
    }
}
