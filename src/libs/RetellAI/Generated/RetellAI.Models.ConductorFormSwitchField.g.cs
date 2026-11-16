#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// On/off toggle. Always answered, so it has no `required`.
    /// </summary>
    public readonly partial struct ConductorFormSwitchField : global::System.IEquatable<ConductorFormSwitchField>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConductorFormItemBase? ItemBase { get; init; }
#else
        public global::RetellAI.ConductorFormItemBase? ItemBase { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ItemBase))]
#endif
        public bool IsItemBase => ItemBase != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickItemBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorFormItemBase? value)
        {
            value = ItemBase;
            return IsItemBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormItemBase PickItemBase() => ItemBase is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ItemBase' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConductorFormSwitchFieldVariant2? ConductorFormSwitchFieldVariant2 { get; init; }
#else
        public global::RetellAI.ConductorFormSwitchFieldVariant2? ConductorFormSwitchFieldVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConductorFormSwitchFieldVariant2))]
#endif
        public bool IsConductorFormSwitchFieldVariant2 => ConductorFormSwitchFieldVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConductorFormSwitchFieldVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorFormSwitchFieldVariant2? value)
        {
            value = ConductorFormSwitchFieldVariant2;
            return IsConductorFormSwitchFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormSwitchFieldVariant2 PickConductorFormSwitchFieldVariant2() => ConductorFormSwitchFieldVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConductorFormSwitchFieldVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormSwitchField(global::RetellAI.ConductorFormItemBase value) => new ConductorFormSwitchField((global::RetellAI.ConductorFormItemBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormItemBase?(ConductorFormSwitchField @this) => @this.ItemBase;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormSwitchField(global::RetellAI.ConductorFormItemBase? value)
        {
            ItemBase = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormSwitchField FromItemBase(global::RetellAI.ConductorFormItemBase? value) => new ConductorFormSwitchField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormSwitchField(global::RetellAI.ConductorFormSwitchFieldVariant2 value) => new ConductorFormSwitchField((global::RetellAI.ConductorFormSwitchFieldVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormSwitchFieldVariant2?(ConductorFormSwitchField @this) => @this.ConductorFormSwitchFieldVariant2;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormSwitchField(global::RetellAI.ConductorFormSwitchFieldVariant2? value)
        {
            ConductorFormSwitchFieldVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormSwitchField FromConductorFormSwitchFieldVariant2(global::RetellAI.ConductorFormSwitchFieldVariant2? value) => new ConductorFormSwitchField(value);

        /// <summary>
        ///
        /// </summary>
        public ConductorFormSwitchField(
            global::RetellAI.ConductorFormItemBase? itemBase,
            global::RetellAI.ConductorFormSwitchFieldVariant2? conductorFormSwitchFieldVariant2
            )
        {
            ItemBase = itemBase;
            ConductorFormSwitchFieldVariant2 = conductorFormSwitchFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ConductorFormSwitchFieldVariant2 as object ??
            ItemBase as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ItemBase?.ToString() ??
            ConductorFormSwitchFieldVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsItemBase && IsConductorFormSwitchFieldVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ConductorFormItemBase, TResult>? itemBase = null,
            global::System.Func<global::RetellAI.ConductorFormSwitchFieldVariant2, TResult>? conductorFormSwitchFieldVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ItemBase is { } __value0 && itemBase != null)
            {
                return itemBase(__value0);
            }
            else if (ConductorFormSwitchFieldVariant2 is { } __value1 && conductorFormSwitchFieldVariant2 != null)
            {
                return conductorFormSwitchFieldVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ConductorFormItemBase>? itemBase = null,

            global::System.Action<global::RetellAI.ConductorFormSwitchFieldVariant2>? conductorFormSwitchFieldVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ItemBase is { } __value0)
            {
                itemBase?.Invoke(__value0);
            }
            else if (ConductorFormSwitchFieldVariant2 is { } __value1)
            {
                conductorFormSwitchFieldVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ConductorFormItemBase>? itemBase = null,
            global::System.Action<global::RetellAI.ConductorFormSwitchFieldVariant2>? conductorFormSwitchFieldVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ItemBase is { } __value0)
            {
                itemBase?.Invoke(__value0);
            }
            else if (ConductorFormSwitchFieldVariant2 is { } __value1)
            {
                conductorFormSwitchFieldVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ItemBase,
                typeof(global::RetellAI.ConductorFormItemBase),
                ConductorFormSwitchFieldVariant2,
                typeof(global::RetellAI.ConductorFormSwitchFieldVariant2),
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
        public bool Equals(ConductorFormSwitchField other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormItemBase?>.Default.Equals(ItemBase, other.ItemBase) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormSwitchFieldVariant2?>.Default.Equals(ConductorFormSwitchFieldVariant2, other.ConductorFormSwitchFieldVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ConductorFormSwitchField obj1, ConductorFormSwitchField obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConductorFormSwitchField>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ConductorFormSwitchField obj1, ConductorFormSwitchField obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConductorFormSwitchField o && Equals(o);
        }
    }
}
