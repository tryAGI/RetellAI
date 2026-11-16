#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Text only, never answered. A heading (`label`), a paragraph (`description`), or both.
    /// </summary>
    public readonly partial struct ConductorFormTextBlock : global::System.IEquatable<ConductorFormTextBlock>
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
        public global::RetellAI.ConductorFormTextBlockVariant2? ConductorFormTextBlockVariant2 { get; init; }
#else
        public global::RetellAI.ConductorFormTextBlockVariant2? ConductorFormTextBlockVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConductorFormTextBlockVariant2))]
#endif
        public bool IsConductorFormTextBlockVariant2 => ConductorFormTextBlockVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConductorFormTextBlockVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorFormTextBlockVariant2? value)
        {
            value = ConductorFormTextBlockVariant2;
            return IsConductorFormTextBlockVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextBlockVariant2 PickConductorFormTextBlockVariant2() => ConductorFormTextBlockVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConductorFormTextBlockVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormTextBlock(global::RetellAI.ConductorFormItemBase value) => new ConductorFormTextBlock((global::RetellAI.ConductorFormItemBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormItemBase?(ConductorFormTextBlock @this) => @this.ItemBase;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormTextBlock(global::RetellAI.ConductorFormItemBase? value)
        {
            ItemBase = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormTextBlock FromItemBase(global::RetellAI.ConductorFormItemBase? value) => new ConductorFormTextBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormTextBlock(global::RetellAI.ConductorFormTextBlockVariant2 value) => new ConductorFormTextBlock((global::RetellAI.ConductorFormTextBlockVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormTextBlockVariant2?(ConductorFormTextBlock @this) => @this.ConductorFormTextBlockVariant2;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormTextBlock(global::RetellAI.ConductorFormTextBlockVariant2? value)
        {
            ConductorFormTextBlockVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormTextBlock FromConductorFormTextBlockVariant2(global::RetellAI.ConductorFormTextBlockVariant2? value) => new ConductorFormTextBlock(value);

        /// <summary>
        ///
        /// </summary>
        public ConductorFormTextBlock(
            global::RetellAI.ConductorFormItemBase? itemBase,
            global::RetellAI.ConductorFormTextBlockVariant2? conductorFormTextBlockVariant2
            )
        {
            ItemBase = itemBase;
            ConductorFormTextBlockVariant2 = conductorFormTextBlockVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ConductorFormTextBlockVariant2 as object ??
            ItemBase as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ItemBase?.ToString() ??
            ConductorFormTextBlockVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsItemBase && IsConductorFormTextBlockVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ConductorFormItemBase, TResult>? itemBase = null,
            global::System.Func<global::RetellAI.ConductorFormTextBlockVariant2, TResult>? conductorFormTextBlockVariant2 = null,
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
            else if (ConductorFormTextBlockVariant2 is { } __value1 && conductorFormTextBlockVariant2 != null)
            {
                return conductorFormTextBlockVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ConductorFormItemBase>? itemBase = null,

            global::System.Action<global::RetellAI.ConductorFormTextBlockVariant2>? conductorFormTextBlockVariant2 = null,
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
            else if (ConductorFormTextBlockVariant2 is { } __value1)
            {
                conductorFormTextBlockVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ConductorFormItemBase>? itemBase = null,
            global::System.Action<global::RetellAI.ConductorFormTextBlockVariant2>? conductorFormTextBlockVariant2 = null,
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
            else if (ConductorFormTextBlockVariant2 is { } __value1)
            {
                conductorFormTextBlockVariant2?.Invoke(__value1);
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
                ConductorFormTextBlockVariant2,
                typeof(global::RetellAI.ConductorFormTextBlockVariant2),
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
        public bool Equals(ConductorFormTextBlock other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormItemBase?>.Default.Equals(ItemBase, other.ItemBase) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormTextBlockVariant2?>.Default.Equals(ConductorFormTextBlockVariant2, other.ConductorFormTextBlockVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ConductorFormTextBlock obj1, ConductorFormTextBlock obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConductorFormTextBlock>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ConductorFormTextBlock obj1, ConductorFormTextBlock obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConductorFormTextBlock o && Equals(o);
        }
    }
}
