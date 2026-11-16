#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// A time of day. The answer includes the time zone the user picked.
    /// </summary>
    public readonly partial struct ConductorFormTimeField : global::System.IEquatable<ConductorFormTimeField>
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
        public global::RetellAI.ConductorFormTimeFieldVariant2? ConductorFormTimeFieldVariant2 { get; init; }
#else
        public global::RetellAI.ConductorFormTimeFieldVariant2? ConductorFormTimeFieldVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConductorFormTimeFieldVariant2))]
#endif
        public bool IsConductorFormTimeFieldVariant2 => ConductorFormTimeFieldVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConductorFormTimeFieldVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorFormTimeFieldVariant2? value)
        {
            value = ConductorFormTimeFieldVariant2;
            return IsConductorFormTimeFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTimeFieldVariant2 PickConductorFormTimeFieldVariant2() => ConductorFormTimeFieldVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConductorFormTimeFieldVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormTimeField(global::RetellAI.ConductorFormFieldBase value) => new ConductorFormTimeField((global::RetellAI.ConductorFormFieldBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormFieldBase?(ConductorFormTimeField @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormTimeField(global::RetellAI.ConductorFormFieldBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormTimeField FromBase(global::RetellAI.ConductorFormFieldBase? value) => new ConductorFormTimeField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormTimeField(global::RetellAI.ConductorFormTimeFieldVariant2 value) => new ConductorFormTimeField((global::RetellAI.ConductorFormTimeFieldVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormTimeFieldVariant2?(ConductorFormTimeField @this) => @this.ConductorFormTimeFieldVariant2;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormTimeField(global::RetellAI.ConductorFormTimeFieldVariant2? value)
        {
            ConductorFormTimeFieldVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormTimeField FromConductorFormTimeFieldVariant2(global::RetellAI.ConductorFormTimeFieldVariant2? value) => new ConductorFormTimeField(value);

        /// <summary>
        ///
        /// </summary>
        public ConductorFormTimeField(
            global::RetellAI.ConductorFormFieldBase? @base,
            global::RetellAI.ConductorFormTimeFieldVariant2? conductorFormTimeFieldVariant2
            )
        {
            Base = @base;
            ConductorFormTimeFieldVariant2 = conductorFormTimeFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ConductorFormTimeFieldVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ConductorFormTimeFieldVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsConductorFormTimeFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ConductorFormFieldBase?, TResult>? @base = null,
            global::System.Func<global::RetellAI.ConductorFormTimeFieldVariant2, TResult>? conductorFormTimeFieldVariant2 = null,
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
            else if (ConductorFormTimeFieldVariant2 is { } __value1 && conductorFormTimeFieldVariant2 != null)
            {
                return conductorFormTimeFieldVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ConductorFormFieldBase?>? @base = null,

            global::System.Action<global::RetellAI.ConductorFormTimeFieldVariant2>? conductorFormTimeFieldVariant2 = null,
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
            else if (ConductorFormTimeFieldVariant2 is { } __value1)
            {
                conductorFormTimeFieldVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ConductorFormFieldBase?>? @base = null,
            global::System.Action<global::RetellAI.ConductorFormTimeFieldVariant2>? conductorFormTimeFieldVariant2 = null,
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
            else if (ConductorFormTimeFieldVariant2 is { } __value1)
            {
                conductorFormTimeFieldVariant2?.Invoke(__value1);
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
                ConductorFormTimeFieldVariant2,
                typeof(global::RetellAI.ConductorFormTimeFieldVariant2),
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
        public bool Equals(ConductorFormTimeField other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormFieldBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormTimeFieldVariant2?>.Default.Equals(ConductorFormTimeFieldVariant2, other.ConductorFormTimeFieldVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ConductorFormTimeField obj1, ConductorFormTimeField obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConductorFormTimeField>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ConductorFormTimeField obj1, ConductorFormTimeField obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConductorFormTimeField o && Equals(o);
        }
    }
}
