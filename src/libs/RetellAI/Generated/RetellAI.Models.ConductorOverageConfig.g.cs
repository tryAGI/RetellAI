#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Conductor overage policy applied once the per-user/per-org daily free limits are exhausted. "off" rejects requests past the daily limit; "limited" allows up to `monthly_limit_usd` (USD) of metered overage per month; "unlimited" allows metered overage with no monthly cap.
    /// </summary>
    public readonly partial struct ConductorOverageConfig : global::System.IEquatable<ConductorOverageConfig>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConductorOverageConfigVariant1? ConductorOverageConfigVariant1 { get; init; }
#else
        public global::RetellAI.ConductorOverageConfigVariant1? ConductorOverageConfigVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConductorOverageConfigVariant1))]
#endif
        public bool IsConductorOverageConfigVariant1 => ConductorOverageConfigVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConductorOverageConfigVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorOverageConfigVariant1? value)
        {
            value = ConductorOverageConfigVariant1;
            return IsConductorOverageConfigVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorOverageConfigVariant1 PickConductorOverageConfigVariant1() => IsConductorOverageConfigVariant1
            ? ConductorOverageConfigVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConductorOverageConfigVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConductorOverageConfigVariant2? ConductorOverageConfigVariant2 { get; init; }
#else
        public global::RetellAI.ConductorOverageConfigVariant2? ConductorOverageConfigVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConductorOverageConfigVariant2))]
#endif
        public bool IsConductorOverageConfigVariant2 => ConductorOverageConfigVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConductorOverageConfigVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorOverageConfigVariant2? value)
        {
            value = ConductorOverageConfigVariant2;
            return IsConductorOverageConfigVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorOverageConfigVariant2 PickConductorOverageConfigVariant2() => IsConductorOverageConfigVariant2
            ? ConductorOverageConfigVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConductorOverageConfigVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConductorOverageConfigVariant3? ConductorOverageConfigVariant3 { get; init; }
#else
        public global::RetellAI.ConductorOverageConfigVariant3? ConductorOverageConfigVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConductorOverageConfigVariant3))]
#endif
        public bool IsConductorOverageConfigVariant3 => ConductorOverageConfigVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConductorOverageConfigVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorOverageConfigVariant3? value)
        {
            value = ConductorOverageConfigVariant3;
            return IsConductorOverageConfigVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorOverageConfigVariant3 PickConductorOverageConfigVariant3() => IsConductorOverageConfigVariant3
            ? ConductorOverageConfigVariant3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConductorOverageConfigVariant3' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorOverageConfig(global::RetellAI.ConductorOverageConfigVariant1 value) => new ConductorOverageConfig((global::RetellAI.ConductorOverageConfigVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorOverageConfigVariant1?(ConductorOverageConfig @this) => @this.ConductorOverageConfigVariant1;

        /// <summary>
        ///
        /// </summary>
        public ConductorOverageConfig(global::RetellAI.ConductorOverageConfigVariant1? value)
        {
            ConductorOverageConfigVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorOverageConfig FromConductorOverageConfigVariant1(global::RetellAI.ConductorOverageConfigVariant1? value) => new ConductorOverageConfig(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorOverageConfig(global::RetellAI.ConductorOverageConfigVariant2 value) => new ConductorOverageConfig((global::RetellAI.ConductorOverageConfigVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorOverageConfigVariant2?(ConductorOverageConfig @this) => @this.ConductorOverageConfigVariant2;

        /// <summary>
        ///
        /// </summary>
        public ConductorOverageConfig(global::RetellAI.ConductorOverageConfigVariant2? value)
        {
            ConductorOverageConfigVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorOverageConfig FromConductorOverageConfigVariant2(global::RetellAI.ConductorOverageConfigVariant2? value) => new ConductorOverageConfig(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorOverageConfig(global::RetellAI.ConductorOverageConfigVariant3 value) => new ConductorOverageConfig((global::RetellAI.ConductorOverageConfigVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorOverageConfigVariant3?(ConductorOverageConfig @this) => @this.ConductorOverageConfigVariant3;

        /// <summary>
        ///
        /// </summary>
        public ConductorOverageConfig(global::RetellAI.ConductorOverageConfigVariant3? value)
        {
            ConductorOverageConfigVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorOverageConfig FromConductorOverageConfigVariant3(global::RetellAI.ConductorOverageConfigVariant3? value) => new ConductorOverageConfig(value);

        /// <summary>
        ///
        /// </summary>
        public ConductorOverageConfig(
            global::RetellAI.ConductorOverageConfigVariant1? conductorOverageConfigVariant1,
            global::RetellAI.ConductorOverageConfigVariant2? conductorOverageConfigVariant2,
            global::RetellAI.ConductorOverageConfigVariant3? conductorOverageConfigVariant3
            )
        {
            ConductorOverageConfigVariant1 = conductorOverageConfigVariant1;
            ConductorOverageConfigVariant2 = conductorOverageConfigVariant2;
            ConductorOverageConfigVariant3 = conductorOverageConfigVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ConductorOverageConfigVariant3 as object ??
            ConductorOverageConfigVariant2 as object ??
            ConductorOverageConfigVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ConductorOverageConfigVariant1?.ToString() ??
            ConductorOverageConfigVariant2?.ToString() ??
            ConductorOverageConfigVariant3?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsConductorOverageConfigVariant1 && !IsConductorOverageConfigVariant2 && !IsConductorOverageConfigVariant3 || !IsConductorOverageConfigVariant1 && IsConductorOverageConfigVariant2 && !IsConductorOverageConfigVariant3 || !IsConductorOverageConfigVariant1 && !IsConductorOverageConfigVariant2 && IsConductorOverageConfigVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ConductorOverageConfigVariant1, TResult>? conductorOverageConfigVariant1 = null,
            global::System.Func<global::RetellAI.ConductorOverageConfigVariant2, TResult>? conductorOverageConfigVariant2 = null,
            global::System.Func<global::RetellAI.ConductorOverageConfigVariant3, TResult>? conductorOverageConfigVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConductorOverageConfigVariant1 && conductorOverageConfigVariant1 != null)
            {
                return conductorOverageConfigVariant1(ConductorOverageConfigVariant1!);
            }
            else if (IsConductorOverageConfigVariant2 && conductorOverageConfigVariant2 != null)
            {
                return conductorOverageConfigVariant2(ConductorOverageConfigVariant2!);
            }
            else if (IsConductorOverageConfigVariant3 && conductorOverageConfigVariant3 != null)
            {
                return conductorOverageConfigVariant3(ConductorOverageConfigVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ConductorOverageConfigVariant1>? conductorOverageConfigVariant1 = null,

            global::System.Action<global::RetellAI.ConductorOverageConfigVariant2>? conductorOverageConfigVariant2 = null,

            global::System.Action<global::RetellAI.ConductorOverageConfigVariant3>? conductorOverageConfigVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConductorOverageConfigVariant1)
            {
                conductorOverageConfigVariant1?.Invoke(ConductorOverageConfigVariant1!);
            }
            else if (IsConductorOverageConfigVariant2)
            {
                conductorOverageConfigVariant2?.Invoke(ConductorOverageConfigVariant2!);
            }
            else if (IsConductorOverageConfigVariant3)
            {
                conductorOverageConfigVariant3?.Invoke(ConductorOverageConfigVariant3!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ConductorOverageConfigVariant1>? conductorOverageConfigVariant1 = null,
            global::System.Action<global::RetellAI.ConductorOverageConfigVariant2>? conductorOverageConfigVariant2 = null,
            global::System.Action<global::RetellAI.ConductorOverageConfigVariant3>? conductorOverageConfigVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConductorOverageConfigVariant1)
            {
                conductorOverageConfigVariant1?.Invoke(ConductorOverageConfigVariant1!);
            }
            else if (IsConductorOverageConfigVariant2)
            {
                conductorOverageConfigVariant2?.Invoke(ConductorOverageConfigVariant2!);
            }
            else if (IsConductorOverageConfigVariant3)
            {
                conductorOverageConfigVariant3?.Invoke(ConductorOverageConfigVariant3!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ConductorOverageConfigVariant1,
                typeof(global::RetellAI.ConductorOverageConfigVariant1),
                ConductorOverageConfigVariant2,
                typeof(global::RetellAI.ConductorOverageConfigVariant2),
                ConductorOverageConfigVariant3,
                typeof(global::RetellAI.ConductorOverageConfigVariant3),
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
        public bool Equals(ConductorOverageConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorOverageConfigVariant1?>.Default.Equals(ConductorOverageConfigVariant1, other.ConductorOverageConfigVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorOverageConfigVariant2?>.Default.Equals(ConductorOverageConfigVariant2, other.ConductorOverageConfigVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorOverageConfigVariant3?>.Default.Equals(ConductorOverageConfigVariant3, other.ConductorOverageConfigVariant3)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ConductorOverageConfig obj1, ConductorOverageConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConductorOverageConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ConductorOverageConfig obj1, ConductorOverageConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConductorOverageConfig o && Equals(o);
        }
    }
}
