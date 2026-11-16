#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// A start and end date.
    /// </summary>
    public readonly partial struct ConductorFormDateRangeField : global::System.IEquatable<ConductorFormDateRangeField>
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
        public global::RetellAI.ConductorFormDateRangeFieldVariant2? ConductorFormDateRangeFieldVariant2 { get; init; }
#else
        public global::RetellAI.ConductorFormDateRangeFieldVariant2? ConductorFormDateRangeFieldVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConductorFormDateRangeFieldVariant2))]
#endif
        public bool IsConductorFormDateRangeFieldVariant2 => ConductorFormDateRangeFieldVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConductorFormDateRangeFieldVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorFormDateRangeFieldVariant2? value)
        {
            value = ConductorFormDateRangeFieldVariant2;
            return IsConductorFormDateRangeFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormDateRangeFieldVariant2 PickConductorFormDateRangeFieldVariant2() => ConductorFormDateRangeFieldVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConductorFormDateRangeFieldVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormDateRangeField(global::RetellAI.ConductorFormFieldBase value) => new ConductorFormDateRangeField((global::RetellAI.ConductorFormFieldBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormFieldBase?(ConductorFormDateRangeField @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormDateRangeField(global::RetellAI.ConductorFormFieldBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormDateRangeField FromBase(global::RetellAI.ConductorFormFieldBase? value) => new ConductorFormDateRangeField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormDateRangeField(global::RetellAI.ConductorFormDateRangeFieldVariant2 value) => new ConductorFormDateRangeField((global::RetellAI.ConductorFormDateRangeFieldVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormDateRangeFieldVariant2?(ConductorFormDateRangeField @this) => @this.ConductorFormDateRangeFieldVariant2;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormDateRangeField(global::RetellAI.ConductorFormDateRangeFieldVariant2? value)
        {
            ConductorFormDateRangeFieldVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormDateRangeField FromConductorFormDateRangeFieldVariant2(global::RetellAI.ConductorFormDateRangeFieldVariant2? value) => new ConductorFormDateRangeField(value);

        /// <summary>
        ///
        /// </summary>
        public ConductorFormDateRangeField(
            global::RetellAI.ConductorFormFieldBase? @base,
            global::RetellAI.ConductorFormDateRangeFieldVariant2? conductorFormDateRangeFieldVariant2
            )
        {
            Base = @base;
            ConductorFormDateRangeFieldVariant2 = conductorFormDateRangeFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ConductorFormDateRangeFieldVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ConductorFormDateRangeFieldVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsConductorFormDateRangeFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ConductorFormFieldBase?, TResult>? @base = null,
            global::System.Func<global::RetellAI.ConductorFormDateRangeFieldVariant2, TResult>? conductorFormDateRangeFieldVariant2 = null,
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
            else if (ConductorFormDateRangeFieldVariant2 is { } __value1 && conductorFormDateRangeFieldVariant2 != null)
            {
                return conductorFormDateRangeFieldVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ConductorFormFieldBase?>? @base = null,

            global::System.Action<global::RetellAI.ConductorFormDateRangeFieldVariant2>? conductorFormDateRangeFieldVariant2 = null,
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
            else if (ConductorFormDateRangeFieldVariant2 is { } __value1)
            {
                conductorFormDateRangeFieldVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ConductorFormFieldBase?>? @base = null,
            global::System.Action<global::RetellAI.ConductorFormDateRangeFieldVariant2>? conductorFormDateRangeFieldVariant2 = null,
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
            else if (ConductorFormDateRangeFieldVariant2 is { } __value1)
            {
                conductorFormDateRangeFieldVariant2?.Invoke(__value1);
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
                ConductorFormDateRangeFieldVariant2,
                typeof(global::RetellAI.ConductorFormDateRangeFieldVariant2),
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
        public bool Equals(ConductorFormDateRangeField other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormFieldBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormDateRangeFieldVariant2?>.Default.Equals(ConductorFormDateRangeFieldVariant2, other.ConductorFormDateRangeFieldVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ConductorFormDateRangeField obj1, ConductorFormDateRangeField obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConductorFormDateRangeField>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ConductorFormDateRangeField obj1, ConductorFormDateRangeField obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConductorFormDateRangeField o && Equals(o);
        }
    }
}
