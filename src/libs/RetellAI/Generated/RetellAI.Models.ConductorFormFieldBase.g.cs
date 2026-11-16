#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ConductorFormFieldBase : global::System.IEquatable<ConductorFormFieldBase>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConductorFormItemBase? Item { get; init; }
#else
        public global::RetellAI.ConductorFormItemBase? Item { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Item))]
#endif
        public bool IsItem => Item != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorFormItemBase? value)
        {
            value = Item;
            return IsItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormItemBase PickItem() => Item is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Item' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConductorFormFieldBaseVariant2? ConductorFormFieldBaseVariant2 { get; init; }
#else
        public global::RetellAI.ConductorFormFieldBaseVariant2? ConductorFormFieldBaseVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConductorFormFieldBaseVariant2))]
#endif
        public bool IsConductorFormFieldBaseVariant2 => ConductorFormFieldBaseVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConductorFormFieldBaseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorFormFieldBaseVariant2? value)
        {
            value = ConductorFormFieldBaseVariant2;
            return IsConductorFormFieldBaseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormFieldBaseVariant2 PickConductorFormFieldBaseVariant2() => ConductorFormFieldBaseVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConductorFormFieldBaseVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormFieldBase(global::RetellAI.ConductorFormItemBase value) => new ConductorFormFieldBase((global::RetellAI.ConductorFormItemBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormItemBase?(ConductorFormFieldBase @this) => @this.Item;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormFieldBase(global::RetellAI.ConductorFormItemBase? value)
        {
            Item = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormFieldBase FromItem(global::RetellAI.ConductorFormItemBase? value) => new ConductorFormFieldBase(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormFieldBase(global::RetellAI.ConductorFormFieldBaseVariant2 value) => new ConductorFormFieldBase((global::RetellAI.ConductorFormFieldBaseVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormFieldBaseVariant2?(ConductorFormFieldBase @this) => @this.ConductorFormFieldBaseVariant2;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormFieldBase(global::RetellAI.ConductorFormFieldBaseVariant2? value)
        {
            ConductorFormFieldBaseVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormFieldBase FromConductorFormFieldBaseVariant2(global::RetellAI.ConductorFormFieldBaseVariant2? value) => new ConductorFormFieldBase(value);

        /// <summary>
        ///
        /// </summary>
        public ConductorFormFieldBase(
            global::RetellAI.ConductorFormItemBase? item,
            global::RetellAI.ConductorFormFieldBaseVariant2? conductorFormFieldBaseVariant2
            )
        {
            Item = item;
            ConductorFormFieldBaseVariant2 = conductorFormFieldBaseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ConductorFormFieldBaseVariant2 as object ??
            Item as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Item?.ToString() ??
            ConductorFormFieldBaseVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsItem && IsConductorFormFieldBaseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ConductorFormItemBase, TResult>? item = null,
            global::System.Func<global::RetellAI.ConductorFormFieldBaseVariant2, TResult>? conductorFormFieldBaseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Item is { } __value0 && item != null)
            {
                return item(__value0);
            }
            else if (ConductorFormFieldBaseVariant2 is { } __value1 && conductorFormFieldBaseVariant2 != null)
            {
                return conductorFormFieldBaseVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ConductorFormItemBase>? item = null,

            global::System.Action<global::RetellAI.ConductorFormFieldBaseVariant2>? conductorFormFieldBaseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Item is { } __value0)
            {
                item?.Invoke(__value0);
            }
            else if (ConductorFormFieldBaseVariant2 is { } __value1)
            {
                conductorFormFieldBaseVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ConductorFormItemBase>? item = null,
            global::System.Action<global::RetellAI.ConductorFormFieldBaseVariant2>? conductorFormFieldBaseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Item is { } __value0)
            {
                item?.Invoke(__value0);
            }
            else if (ConductorFormFieldBaseVariant2 is { } __value1)
            {
                conductorFormFieldBaseVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Item,
                typeof(global::RetellAI.ConductorFormItemBase),
                ConductorFormFieldBaseVariant2,
                typeof(global::RetellAI.ConductorFormFieldBaseVariant2),
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
        public bool Equals(ConductorFormFieldBase other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormItemBase?>.Default.Equals(Item, other.Item) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormFieldBaseVariant2?>.Default.Equals(ConductorFormFieldBaseVariant2, other.ConductorFormFieldBaseVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ConductorFormFieldBase obj1, ConductorFormFieldBase obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConductorFormFieldBase>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ConductorFormFieldBase obj1, ConductorFormFieldBase obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConductorFormFieldBase o && Equals(o);
        }
    }
}
