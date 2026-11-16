#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Dropdown with one answer.
    /// </summary>
    public readonly partial struct ConductorFormSelectField : global::System.IEquatable<ConductorFormSelectField>
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
        public global::RetellAI.ConductorFormSelectFieldVariant2? ConductorFormSelectFieldVariant2 { get; init; }
#else
        public global::RetellAI.ConductorFormSelectFieldVariant2? ConductorFormSelectFieldVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConductorFormSelectFieldVariant2))]
#endif
        public bool IsConductorFormSelectFieldVariant2 => ConductorFormSelectFieldVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConductorFormSelectFieldVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorFormSelectFieldVariant2? value)
        {
            value = ConductorFormSelectFieldVariant2;
            return IsConductorFormSelectFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormSelectFieldVariant2 PickConductorFormSelectFieldVariant2() => ConductorFormSelectFieldVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConductorFormSelectFieldVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormSelectField(global::RetellAI.ConductorFormFieldBase value) => new ConductorFormSelectField((global::RetellAI.ConductorFormFieldBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormFieldBase?(ConductorFormSelectField @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormSelectField(global::RetellAI.ConductorFormFieldBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormSelectField FromBase(global::RetellAI.ConductorFormFieldBase? value) => new ConductorFormSelectField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormSelectField(global::RetellAI.ConductorFormSelectFieldVariant2 value) => new ConductorFormSelectField((global::RetellAI.ConductorFormSelectFieldVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormSelectFieldVariant2?(ConductorFormSelectField @this) => @this.ConductorFormSelectFieldVariant2;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormSelectField(global::RetellAI.ConductorFormSelectFieldVariant2? value)
        {
            ConductorFormSelectFieldVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormSelectField FromConductorFormSelectFieldVariant2(global::RetellAI.ConductorFormSelectFieldVariant2? value) => new ConductorFormSelectField(value);

        /// <summary>
        ///
        /// </summary>
        public ConductorFormSelectField(
            global::RetellAI.ConductorFormFieldBase? @base,
            global::RetellAI.ConductorFormSelectFieldVariant2? conductorFormSelectFieldVariant2
            )
        {
            Base = @base;
            ConductorFormSelectFieldVariant2 = conductorFormSelectFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ConductorFormSelectFieldVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ConductorFormSelectFieldVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsConductorFormSelectFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ConductorFormFieldBase?, TResult>? @base = null,
            global::System.Func<global::RetellAI.ConductorFormSelectFieldVariant2, TResult>? conductorFormSelectFieldVariant2 = null,
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
            else if (ConductorFormSelectFieldVariant2 is { } __value1 && conductorFormSelectFieldVariant2 != null)
            {
                return conductorFormSelectFieldVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ConductorFormFieldBase?>? @base = null,

            global::System.Action<global::RetellAI.ConductorFormSelectFieldVariant2>? conductorFormSelectFieldVariant2 = null,
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
            else if (ConductorFormSelectFieldVariant2 is { } __value1)
            {
                conductorFormSelectFieldVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ConductorFormFieldBase?>? @base = null,
            global::System.Action<global::RetellAI.ConductorFormSelectFieldVariant2>? conductorFormSelectFieldVariant2 = null,
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
            else if (ConductorFormSelectFieldVariant2 is { } __value1)
            {
                conductorFormSelectFieldVariant2?.Invoke(__value1);
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
                ConductorFormSelectFieldVariant2,
                typeof(global::RetellAI.ConductorFormSelectFieldVariant2),
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
        public bool Equals(ConductorFormSelectField other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormFieldBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormSelectFieldVariant2?>.Default.Equals(ConductorFormSelectFieldVariant2, other.ConductorFormSelectFieldVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ConductorFormSelectField obj1, ConductorFormSelectField obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConductorFormSelectField>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ConductorFormSelectField obj1, ConductorFormSelectField obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConductorFormSelectField o && Equals(o);
        }
    }
}
