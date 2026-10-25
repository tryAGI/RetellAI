#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Model settings for the response engine. type decides which models primary and backup accept. On update, each top-level key replaces the current one and omitted keys are kept; set backup to null to remove it. Changing type requires primary and clears backup, while temperature carries over. In agent_override, type is required whenever primary is set; setting backup to null disables it for that call only.
    /// </summary>
    public readonly partial struct ModelConfig : global::System.IEquatable<ModelConfig>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.CascadingModelConfig? Cascading { get; init; }
#else
        public global::RetellAI.CascadingModelConfig? Cascading { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Cascading))]
#endif
        public bool IsCascading => Cascading != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCascading(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.CascadingModelConfig? value)
        {
            value = Cascading;
            return IsCascading;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CascadingModelConfig PickCascading() => Cascading is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Cascading' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.S2SModelConfig? S2s { get; init; }
#else
        public global::RetellAI.S2SModelConfig? S2s { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(S2s))]
#endif
        public bool IsS2s => S2s != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickS2s(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.S2SModelConfig? value)
        {
            value = S2s;
            return IsS2s;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.S2SModelConfig PickS2s() => S2s is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'S2s' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ModelConfig(global::RetellAI.CascadingModelConfig value) => new ModelConfig((global::RetellAI.CascadingModelConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.CascadingModelConfig?(ModelConfig @this) => @this.Cascading;

        /// <summary>
        ///
        /// </summary>
        public ModelConfig(global::RetellAI.CascadingModelConfig? value)
        {
            Cascading = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ModelConfig FromCascading(global::RetellAI.CascadingModelConfig? value) => new ModelConfig(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ModelConfig(global::RetellAI.S2SModelConfig value) => new ModelConfig((global::RetellAI.S2SModelConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.S2SModelConfig?(ModelConfig @this) => @this.S2s;

        /// <summary>
        ///
        /// </summary>
        public ModelConfig(global::RetellAI.S2SModelConfig? value)
        {
            S2s = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ModelConfig FromS2s(global::RetellAI.S2SModelConfig? value) => new ModelConfig(value);

        /// <summary>
        ///
        /// </summary>
        public ModelConfig(
            global::RetellAI.CascadingModelConfig? cascading,
            global::RetellAI.S2SModelConfig? s2s
            )
        {
            Cascading = cascading;
            S2s = s2s;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            S2s as object ??
            Cascading as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Cascading?.ToString() ??
            S2s?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCascading || IsS2s;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.CascadingModelConfig, TResult>? cascading = null,
            global::System.Func<global::RetellAI.S2SModelConfig, TResult>? s2s = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Cascading is { } __value0 && cascading != null)
            {
                return cascading(__value0);
            }
            else if (S2s is { } __value1 && s2s != null)
            {
                return s2s(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.CascadingModelConfig>? cascading = null,

            global::System.Action<global::RetellAI.S2SModelConfig>? s2s = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Cascading is { } __value0)
            {
                cascading?.Invoke(__value0);
            }
            else if (S2s is { } __value1)
            {
                s2s?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.CascadingModelConfig>? cascading = null,
            global::System.Action<global::RetellAI.S2SModelConfig>? s2s = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Cascading is { } __value0)
            {
                cascading?.Invoke(__value0);
            }
            else if (S2s is { } __value1)
            {
                s2s?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Cascading,
                typeof(global::RetellAI.CascadingModelConfig),
                S2s,
                typeof(global::RetellAI.S2SModelConfig),
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
        public bool Equals(ModelConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.CascadingModelConfig?>.Default.Equals(Cascading, other.Cascading) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.S2SModelConfig?>.Default.Equals(S2s, other.S2s)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ModelConfig obj1, ModelConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ModelConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ModelConfig obj1, ModelConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelConfig o && Equals(o);
        }
    }
}
