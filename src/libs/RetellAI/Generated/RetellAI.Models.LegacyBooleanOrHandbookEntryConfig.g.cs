#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct LegacyBooleanOrHandbookEntryConfig : global::System.IEquatable<LegacyBooleanOrHandbookEntryConfig>
    {
        /// <summary>
        /// Legacy handbook toggle. True enables the Retell-provided prompt; false disables it.
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? LegacyBooleanOrHandbookEntryConfigVariant1 { get; init; }
#else
        public bool? LegacyBooleanOrHandbookEntryConfigVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LegacyBooleanOrHandbookEntryConfigVariant1))]
#endif
        public bool IsLegacyBooleanOrHandbookEntryConfigVariant1 => LegacyBooleanOrHandbookEntryConfigVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLegacyBooleanOrHandbookEntryConfigVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out bool? value)
        {
            value = LegacyBooleanOrHandbookEntryConfigVariant1;
            return IsLegacyBooleanOrHandbookEntryConfigVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public bool PickLegacyBooleanOrHandbookEntryConfigVariant1() => LegacyBooleanOrHandbookEntryConfigVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LegacyBooleanOrHandbookEntryConfigVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for an enabled handbook. Omit custom_prompt or set it to null to use the Retell-provided prompt. An empty string intentionally injects no prompt for this handbook.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.HandbookEntryConfig? HandbookEntryConfig { get; init; }
#else
        public global::RetellAI.HandbookEntryConfig? HandbookEntryConfig { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HandbookEntryConfig))]
#endif
        public bool IsHandbookEntryConfig => HandbookEntryConfig != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHandbookEntryConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.HandbookEntryConfig? value)
        {
            value = HandbookEntryConfig;
            return IsHandbookEntryConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.HandbookEntryConfig PickHandbookEntryConfig() => HandbookEntryConfig is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HandbookEntryConfig' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator LegacyBooleanOrHandbookEntryConfig(bool value) => new LegacyBooleanOrHandbookEntryConfig((bool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator bool?(LegacyBooleanOrHandbookEntryConfig @this) => @this.LegacyBooleanOrHandbookEntryConfigVariant1;

        /// <summary>
        ///
        /// </summary>
        public LegacyBooleanOrHandbookEntryConfig(bool? value)
        {
            LegacyBooleanOrHandbookEntryConfigVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LegacyBooleanOrHandbookEntryConfig FromLegacyBooleanOrHandbookEntryConfigVariant1(bool? value) => new LegacyBooleanOrHandbookEntryConfig(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LegacyBooleanOrHandbookEntryConfig(global::RetellAI.HandbookEntryConfig value) => new LegacyBooleanOrHandbookEntryConfig((global::RetellAI.HandbookEntryConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.HandbookEntryConfig?(LegacyBooleanOrHandbookEntryConfig @this) => @this.HandbookEntryConfig;

        /// <summary>
        ///
        /// </summary>
        public LegacyBooleanOrHandbookEntryConfig(global::RetellAI.HandbookEntryConfig? value)
        {
            HandbookEntryConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LegacyBooleanOrHandbookEntryConfig FromHandbookEntryConfig(global::RetellAI.HandbookEntryConfig? value) => new LegacyBooleanOrHandbookEntryConfig(value);

        /// <summary>
        ///
        /// </summary>
        public LegacyBooleanOrHandbookEntryConfig(
            bool? legacyBooleanOrHandbookEntryConfigVariant1,
            global::RetellAI.HandbookEntryConfig? handbookEntryConfig
            )
        {
            LegacyBooleanOrHandbookEntryConfigVariant1 = legacyBooleanOrHandbookEntryConfigVariant1;
            HandbookEntryConfig = handbookEntryConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            HandbookEntryConfig as object ??
            LegacyBooleanOrHandbookEntryConfigVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            LegacyBooleanOrHandbookEntryConfigVariant1?.ToString().ToLowerInvariant() ??
            HandbookEntryConfig?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsLegacyBooleanOrHandbookEntryConfigVariant1 && !IsHandbookEntryConfig || !IsLegacyBooleanOrHandbookEntryConfigVariant1 && IsHandbookEntryConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<bool?, TResult>? legacyBooleanOrHandbookEntryConfigVariant1 = null,
            global::System.Func<global::RetellAI.HandbookEntryConfig, TResult>? handbookEntryConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (LegacyBooleanOrHandbookEntryConfigVariant1 is { } __value0 && legacyBooleanOrHandbookEntryConfigVariant1 != null)
            {
                return legacyBooleanOrHandbookEntryConfigVariant1(__value0);
            }
            else if (HandbookEntryConfig is { } __value1 && handbookEntryConfig != null)
            {
                return handbookEntryConfig(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<bool?>? legacyBooleanOrHandbookEntryConfigVariant1 = null,

            global::System.Action<global::RetellAI.HandbookEntryConfig>? handbookEntryConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (LegacyBooleanOrHandbookEntryConfigVariant1 is { } __value0)
            {
                legacyBooleanOrHandbookEntryConfigVariant1?.Invoke(__value0);
            }
            else if (HandbookEntryConfig is { } __value1)
            {
                handbookEntryConfig?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<bool?>? legacyBooleanOrHandbookEntryConfigVariant1 = null,
            global::System.Action<global::RetellAI.HandbookEntryConfig>? handbookEntryConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (LegacyBooleanOrHandbookEntryConfigVariant1 is { } __value0)
            {
                legacyBooleanOrHandbookEntryConfigVariant1?.Invoke(__value0);
            }
            else if (HandbookEntryConfig is { } __value1)
            {
                handbookEntryConfig?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                LegacyBooleanOrHandbookEntryConfigVariant1,
                typeof(bool),
                HandbookEntryConfig,
                typeof(global::RetellAI.HandbookEntryConfig),
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
        public bool Equals(LegacyBooleanOrHandbookEntryConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(LegacyBooleanOrHandbookEntryConfigVariant1, other.LegacyBooleanOrHandbookEntryConfigVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.HandbookEntryConfig?>.Default.Equals(HandbookEntryConfig, other.HandbookEntryConfig)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(LegacyBooleanOrHandbookEntryConfig obj1, LegacyBooleanOrHandbookEntryConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LegacyBooleanOrHandbookEntryConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(LegacyBooleanOrHandbookEntryConfig obj1, LegacyBooleanOrHandbookEntryConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LegacyBooleanOrHandbookEntryConfig o && Equals(o);
        }
    }
}
