#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Multi-line text.
    /// </summary>
    public readonly partial struct ConductorFormTextareaField : global::System.IEquatable<ConductorFormTextareaField>
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
        public global::RetellAI.ConductorFormTextareaFieldVariant2? ConductorFormTextareaFieldVariant2 { get; init; }
#else
        public global::RetellAI.ConductorFormTextareaFieldVariant2? ConductorFormTextareaFieldVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConductorFormTextareaFieldVariant2))]
#endif
        public bool IsConductorFormTextareaFieldVariant2 => ConductorFormTextareaFieldVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConductorFormTextareaFieldVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorFormTextareaFieldVariant2? value)
        {
            value = ConductorFormTextareaFieldVariant2;
            return IsConductorFormTextareaFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextareaFieldVariant2 PickConductorFormTextareaFieldVariant2() => ConductorFormTextareaFieldVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConductorFormTextareaFieldVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormTextareaField(global::RetellAI.ConductorFormFieldBase value) => new ConductorFormTextareaField((global::RetellAI.ConductorFormFieldBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormFieldBase?(ConductorFormTextareaField @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormTextareaField(global::RetellAI.ConductorFormFieldBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormTextareaField FromBase(global::RetellAI.ConductorFormFieldBase? value) => new ConductorFormTextareaField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormTextareaField(global::RetellAI.ConductorFormTextareaFieldVariant2 value) => new ConductorFormTextareaField((global::RetellAI.ConductorFormTextareaFieldVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormTextareaFieldVariant2?(ConductorFormTextareaField @this) => @this.ConductorFormTextareaFieldVariant2;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormTextareaField(global::RetellAI.ConductorFormTextareaFieldVariant2? value)
        {
            ConductorFormTextareaFieldVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormTextareaField FromConductorFormTextareaFieldVariant2(global::RetellAI.ConductorFormTextareaFieldVariant2? value) => new ConductorFormTextareaField(value);

        /// <summary>
        ///
        /// </summary>
        public ConductorFormTextareaField(
            global::RetellAI.ConductorFormFieldBase? @base,
            global::RetellAI.ConductorFormTextareaFieldVariant2? conductorFormTextareaFieldVariant2
            )
        {
            Base = @base;
            ConductorFormTextareaFieldVariant2 = conductorFormTextareaFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ConductorFormTextareaFieldVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ConductorFormTextareaFieldVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsConductorFormTextareaFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ConductorFormFieldBase?, TResult>? @base = null,
            global::System.Func<global::RetellAI.ConductorFormTextareaFieldVariant2, TResult>? conductorFormTextareaFieldVariant2 = null,
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
            else if (ConductorFormTextareaFieldVariant2 is { } __value1 && conductorFormTextareaFieldVariant2 != null)
            {
                return conductorFormTextareaFieldVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ConductorFormFieldBase?>? @base = null,

            global::System.Action<global::RetellAI.ConductorFormTextareaFieldVariant2>? conductorFormTextareaFieldVariant2 = null,
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
            else if (ConductorFormTextareaFieldVariant2 is { } __value1)
            {
                conductorFormTextareaFieldVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ConductorFormFieldBase?>? @base = null,
            global::System.Action<global::RetellAI.ConductorFormTextareaFieldVariant2>? conductorFormTextareaFieldVariant2 = null,
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
            else if (ConductorFormTextareaFieldVariant2 is { } __value1)
            {
                conductorFormTextareaFieldVariant2?.Invoke(__value1);
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
                ConductorFormTextareaFieldVariant2,
                typeof(global::RetellAI.ConductorFormTextareaFieldVariant2),
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
        public bool Equals(ConductorFormTextareaField other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormFieldBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormTextareaFieldVariant2?>.Default.Equals(ConductorFormTextareaFieldVariant2, other.ConductorFormTextareaFieldVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ConductorFormTextareaField obj1, ConductorFormTextareaField obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConductorFormTextareaField>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ConductorFormTextareaField obj1, ConductorFormTextareaField obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConductorFormTextareaField o && Equals(o);
        }
    }
}
