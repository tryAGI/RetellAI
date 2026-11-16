#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Single-line text.
    /// </summary>
    public readonly partial struct ConductorFormTextField : global::System.IEquatable<ConductorFormTextField>
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
        public global::RetellAI.ConductorFormTextFieldVariant2? ConductorFormTextFieldVariant2 { get; init; }
#else
        public global::RetellAI.ConductorFormTextFieldVariant2? ConductorFormTextFieldVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConductorFormTextFieldVariant2))]
#endif
        public bool IsConductorFormTextFieldVariant2 => ConductorFormTextFieldVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConductorFormTextFieldVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorFormTextFieldVariant2? value)
        {
            value = ConductorFormTextFieldVariant2;
            return IsConductorFormTextFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextFieldVariant2 PickConductorFormTextFieldVariant2() => ConductorFormTextFieldVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConductorFormTextFieldVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormTextField(global::RetellAI.ConductorFormFieldBase value) => new ConductorFormTextField((global::RetellAI.ConductorFormFieldBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormFieldBase?(ConductorFormTextField @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormTextField(global::RetellAI.ConductorFormFieldBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormTextField FromBase(global::RetellAI.ConductorFormFieldBase? value) => new ConductorFormTextField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormTextField(global::RetellAI.ConductorFormTextFieldVariant2 value) => new ConductorFormTextField((global::RetellAI.ConductorFormTextFieldVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormTextFieldVariant2?(ConductorFormTextField @this) => @this.ConductorFormTextFieldVariant2;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormTextField(global::RetellAI.ConductorFormTextFieldVariant2? value)
        {
            ConductorFormTextFieldVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormTextField FromConductorFormTextFieldVariant2(global::RetellAI.ConductorFormTextFieldVariant2? value) => new ConductorFormTextField(value);

        /// <summary>
        ///
        /// </summary>
        public ConductorFormTextField(
            global::RetellAI.ConductorFormFieldBase? @base,
            global::RetellAI.ConductorFormTextFieldVariant2? conductorFormTextFieldVariant2
            )
        {
            Base = @base;
            ConductorFormTextFieldVariant2 = conductorFormTextFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ConductorFormTextFieldVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ConductorFormTextFieldVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsConductorFormTextFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ConductorFormFieldBase?, TResult>? @base = null,
            global::System.Func<global::RetellAI.ConductorFormTextFieldVariant2, TResult>? conductorFormTextFieldVariant2 = null,
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
            else if (ConductorFormTextFieldVariant2 is { } __value1 && conductorFormTextFieldVariant2 != null)
            {
                return conductorFormTextFieldVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ConductorFormFieldBase?>? @base = null,

            global::System.Action<global::RetellAI.ConductorFormTextFieldVariant2>? conductorFormTextFieldVariant2 = null,
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
            else if (ConductorFormTextFieldVariant2 is { } __value1)
            {
                conductorFormTextFieldVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ConductorFormFieldBase?>? @base = null,
            global::System.Action<global::RetellAI.ConductorFormTextFieldVariant2>? conductorFormTextFieldVariant2 = null,
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
            else if (ConductorFormTextFieldVariant2 is { } __value1)
            {
                conductorFormTextFieldVariant2?.Invoke(__value1);
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
                ConductorFormTextFieldVariant2,
                typeof(global::RetellAI.ConductorFormTextFieldVariant2),
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
        public bool Equals(ConductorFormTextField other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormFieldBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormTextFieldVariant2?>.Default.Equals(ConductorFormTextFieldVariant2, other.ConductorFormTextFieldVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ConductorFormTextField obj1, ConductorFormTextField obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConductorFormTextField>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ConductorFormTextField obj1, ConductorFormTextField obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConductorFormTextField o && Equals(o);
        }
    }
}
