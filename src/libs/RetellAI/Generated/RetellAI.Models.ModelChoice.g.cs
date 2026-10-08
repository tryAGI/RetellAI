#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ModelChoice : global::System.IEquatable<ModelChoice>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ModelChoiceCascading? Cascading { get; init; }
#else
        public global::RetellAI.ModelChoiceCascading? Cascading { get; }
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
            out global::RetellAI.ModelChoiceCascading? value)
        {
            value = Cascading;
            return IsCascading;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ModelChoiceCascading PickCascading() => Cascading is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Cascading' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ModelChoiceS2S? S2s { get; init; }
#else
        public global::RetellAI.ModelChoiceS2S? S2s { get; }
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
            out global::RetellAI.ModelChoiceS2S? value)
        {
            value = S2s;
            return IsS2s;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ModelChoiceS2S PickS2s() => S2s is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'S2s' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ModelChoice(global::RetellAI.ModelChoiceCascading value) => new ModelChoice((global::RetellAI.ModelChoiceCascading?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ModelChoiceCascading?(ModelChoice @this) => @this.Cascading;

        /// <summary>
        ///
        /// </summary>
        public ModelChoice(global::RetellAI.ModelChoiceCascading? value)
        {
            Cascading = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ModelChoice FromCascading(global::RetellAI.ModelChoiceCascading? value) => new ModelChoice(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ModelChoice(global::RetellAI.ModelChoiceS2S value) => new ModelChoice((global::RetellAI.ModelChoiceS2S?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ModelChoiceS2S?(ModelChoice @this) => @this.S2s;

        /// <summary>
        ///
        /// </summary>
        public ModelChoice(global::RetellAI.ModelChoiceS2S? value)
        {
            S2s = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ModelChoice FromS2s(global::RetellAI.ModelChoiceS2S? value) => new ModelChoice(value);

        /// <summary>
        ///
        /// </summary>
        public ModelChoice(
            global::RetellAI.ModelChoiceCascading? cascading,
            global::RetellAI.ModelChoiceS2S? s2s
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
            return IsCascading && !IsS2s || !IsCascading && IsS2s;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ModelChoiceCascading, TResult>? cascading = null,
            global::System.Func<global::RetellAI.ModelChoiceS2S, TResult>? s2s = null,
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
            global::System.Action<global::RetellAI.ModelChoiceCascading>? cascading = null,

            global::System.Action<global::RetellAI.ModelChoiceS2S>? s2s = null,
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
            global::System.Action<global::RetellAI.ModelChoiceCascading>? cascading = null,
            global::System.Action<global::RetellAI.ModelChoiceS2S>? s2s = null,
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
                typeof(global::RetellAI.ModelChoiceCascading),
                S2s,
                typeof(global::RetellAI.ModelChoiceS2S),
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
        public bool Equals(ModelChoice other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ModelChoiceCascading?>.Default.Equals(Cascading, other.Cascading) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ModelChoiceS2S?>.Default.Equals(S2s, other.S2s)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ModelChoice obj1, ModelChoice obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ModelChoice>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ModelChoice obj1, ModelChoice obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelChoice o && Equals(o);
        }
    }
}
