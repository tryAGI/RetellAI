#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Options listed as radio buttons, or checkboxes with `multi_select`.
    /// </summary>
    public readonly partial struct ConductorFormChoiceField : global::System.IEquatable<ConductorFormChoiceField>
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
        public global::RetellAI.ConductorFormChoiceFieldVariant2? ConductorFormChoiceFieldVariant2 { get; init; }
#else
        public global::RetellAI.ConductorFormChoiceFieldVariant2? ConductorFormChoiceFieldVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConductorFormChoiceFieldVariant2))]
#endif
        public bool IsConductorFormChoiceFieldVariant2 => ConductorFormChoiceFieldVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConductorFormChoiceFieldVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorFormChoiceFieldVariant2? value)
        {
            value = ConductorFormChoiceFieldVariant2;
            return IsConductorFormChoiceFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormChoiceFieldVariant2 PickConductorFormChoiceFieldVariant2() => ConductorFormChoiceFieldVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConductorFormChoiceFieldVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormChoiceField(global::RetellAI.ConductorFormFieldBase value) => new ConductorFormChoiceField((global::RetellAI.ConductorFormFieldBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormFieldBase?(ConductorFormChoiceField @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormChoiceField(global::RetellAI.ConductorFormFieldBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormChoiceField FromBase(global::RetellAI.ConductorFormFieldBase? value) => new ConductorFormChoiceField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormChoiceField(global::RetellAI.ConductorFormChoiceFieldVariant2 value) => new ConductorFormChoiceField((global::RetellAI.ConductorFormChoiceFieldVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormChoiceFieldVariant2?(ConductorFormChoiceField @this) => @this.ConductorFormChoiceFieldVariant2;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormChoiceField(global::RetellAI.ConductorFormChoiceFieldVariant2? value)
        {
            ConductorFormChoiceFieldVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormChoiceField FromConductorFormChoiceFieldVariant2(global::RetellAI.ConductorFormChoiceFieldVariant2? value) => new ConductorFormChoiceField(value);

        /// <summary>
        ///
        /// </summary>
        public ConductorFormChoiceField(
            global::RetellAI.ConductorFormFieldBase? @base,
            global::RetellAI.ConductorFormChoiceFieldVariant2? conductorFormChoiceFieldVariant2
            )
        {
            Base = @base;
            ConductorFormChoiceFieldVariant2 = conductorFormChoiceFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ConductorFormChoiceFieldVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ConductorFormChoiceFieldVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsConductorFormChoiceFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ConductorFormFieldBase?, TResult>? @base = null,
            global::System.Func<global::RetellAI.ConductorFormChoiceFieldVariant2, TResult>? conductorFormChoiceFieldVariant2 = null,
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
            else if (ConductorFormChoiceFieldVariant2 is { } __value1 && conductorFormChoiceFieldVariant2 != null)
            {
                return conductorFormChoiceFieldVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ConductorFormFieldBase?>? @base = null,

            global::System.Action<global::RetellAI.ConductorFormChoiceFieldVariant2>? conductorFormChoiceFieldVariant2 = null,
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
            else if (ConductorFormChoiceFieldVariant2 is { } __value1)
            {
                conductorFormChoiceFieldVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ConductorFormFieldBase?>? @base = null,
            global::System.Action<global::RetellAI.ConductorFormChoiceFieldVariant2>? conductorFormChoiceFieldVariant2 = null,
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
            else if (ConductorFormChoiceFieldVariant2 is { } __value1)
            {
                conductorFormChoiceFieldVariant2?.Invoke(__value1);
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
                ConductorFormChoiceFieldVariant2,
                typeof(global::RetellAI.ConductorFormChoiceFieldVariant2),
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
        public bool Equals(ConductorFormChoiceField other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormFieldBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormChoiceFieldVariant2?>.Default.Equals(ConductorFormChoiceFieldVariant2, other.ConductorFormChoiceFieldVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ConductorFormChoiceField obj1, ConductorFormChoiceField obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConductorFormChoiceField>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ConductorFormChoiceField obj1, ConductorFormChoiceField obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConductorFormChoiceField o && Equals(o);
        }
    }
}
