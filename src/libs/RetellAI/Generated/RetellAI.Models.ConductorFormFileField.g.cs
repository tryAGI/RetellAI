#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// File upload. The user can attach several files, and Conductor receives them to read.
    /// </summary>
    public readonly partial struct ConductorFormFileField : global::System.IEquatable<ConductorFormFileField>
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
        public global::RetellAI.ConductorFormFileFieldVariant2? ConductorFormFileFieldVariant2 { get; init; }
#else
        public global::RetellAI.ConductorFormFileFieldVariant2? ConductorFormFileFieldVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConductorFormFileFieldVariant2))]
#endif
        public bool IsConductorFormFileFieldVariant2 => ConductorFormFileFieldVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConductorFormFileFieldVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorFormFileFieldVariant2? value)
        {
            value = ConductorFormFileFieldVariant2;
            return IsConductorFormFileFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormFileFieldVariant2 PickConductorFormFileFieldVariant2() => ConductorFormFileFieldVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConductorFormFileFieldVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormFileField(global::RetellAI.ConductorFormFieldBase value) => new ConductorFormFileField((global::RetellAI.ConductorFormFieldBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormFieldBase?(ConductorFormFileField @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormFileField(global::RetellAI.ConductorFormFieldBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormFileField FromBase(global::RetellAI.ConductorFormFieldBase? value) => new ConductorFormFileField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormFileField(global::RetellAI.ConductorFormFileFieldVariant2 value) => new ConductorFormFileField((global::RetellAI.ConductorFormFileFieldVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormFileFieldVariant2?(ConductorFormFileField @this) => @this.ConductorFormFileFieldVariant2;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormFileField(global::RetellAI.ConductorFormFileFieldVariant2? value)
        {
            ConductorFormFileFieldVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormFileField FromConductorFormFileFieldVariant2(global::RetellAI.ConductorFormFileFieldVariant2? value) => new ConductorFormFileField(value);

        /// <summary>
        ///
        /// </summary>
        public ConductorFormFileField(
            global::RetellAI.ConductorFormFieldBase? @base,
            global::RetellAI.ConductorFormFileFieldVariant2? conductorFormFileFieldVariant2
            )
        {
            Base = @base;
            ConductorFormFileFieldVariant2 = conductorFormFileFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ConductorFormFileFieldVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ConductorFormFileFieldVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsConductorFormFileFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ConductorFormFieldBase?, TResult>? @base = null,
            global::System.Func<global::RetellAI.ConductorFormFileFieldVariant2, TResult>? conductorFormFileFieldVariant2 = null,
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
            else if (ConductorFormFileFieldVariant2 is { } __value1 && conductorFormFileFieldVariant2 != null)
            {
                return conductorFormFileFieldVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ConductorFormFieldBase?>? @base = null,

            global::System.Action<global::RetellAI.ConductorFormFileFieldVariant2>? conductorFormFileFieldVariant2 = null,
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
            else if (ConductorFormFileFieldVariant2 is { } __value1)
            {
                conductorFormFileFieldVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ConductorFormFieldBase?>? @base = null,
            global::System.Action<global::RetellAI.ConductorFormFileFieldVariant2>? conductorFormFileFieldVariant2 = null,
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
            else if (ConductorFormFileFieldVariant2 is { } __value1)
            {
                conductorFormFileFieldVariant2?.Invoke(__value1);
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
                ConductorFormFileFieldVariant2,
                typeof(global::RetellAI.ConductorFormFileFieldVariant2),
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
        public bool Equals(ConductorFormFileField other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormFieldBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormFileFieldVariant2?>.Default.Equals(ConductorFormFileFieldVariant2, other.ConductorFormFileFieldVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ConductorFormFileField obj1, ConductorFormFileField obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConductorFormFileField>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ConductorFormFileField obj1, ConductorFormFileField obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConductorFormFileField o && Equals(o);
        }
    }
}
