#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Condensed call QA summary with the call duration.
    /// </summary>
    public readonly partial struct PreviewCallQA : global::System.IEquatable<PreviewCallQA>
    {
        /// <summary>
        /// Condensed QA summary returned when listing a cohort's calls.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ChCallQA? Ch { get; init; }
#else
        public global::RetellAI.ChCallQA? Ch { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ch))]
#endif
        public bool IsCh => Ch != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCh(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ChCallQA? value)
        {
            value = Ch;
            return IsCh;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ChCallQA PickCh() => IsCh
            ? Ch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Ch' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.PreviewCallQAVariant2? PreviewCallQAVariant2 { get; init; }
#else
        public global::RetellAI.PreviewCallQAVariant2? PreviewCallQAVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PreviewCallQAVariant2))]
#endif
        public bool IsPreviewCallQAVariant2 => PreviewCallQAVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPreviewCallQAVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.PreviewCallQAVariant2? value)
        {
            value = PreviewCallQAVariant2;
            return IsPreviewCallQAVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.PreviewCallQAVariant2 PickPreviewCallQAVariant2() => IsPreviewCallQAVariant2
            ? PreviewCallQAVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PreviewCallQAVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PreviewCallQA(global::RetellAI.ChCallQA value) => new PreviewCallQA((global::RetellAI.ChCallQA?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ChCallQA?(PreviewCallQA @this) => @this.Ch;

        /// <summary>
        ///
        /// </summary>
        public PreviewCallQA(global::RetellAI.ChCallQA? value)
        {
            Ch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PreviewCallQA FromCh(global::RetellAI.ChCallQA? value) => new PreviewCallQA(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PreviewCallQA(global::RetellAI.PreviewCallQAVariant2 value) => new PreviewCallQA((global::RetellAI.PreviewCallQAVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.PreviewCallQAVariant2?(PreviewCallQA @this) => @this.PreviewCallQAVariant2;

        /// <summary>
        ///
        /// </summary>
        public PreviewCallQA(global::RetellAI.PreviewCallQAVariant2? value)
        {
            PreviewCallQAVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PreviewCallQA FromPreviewCallQAVariant2(global::RetellAI.PreviewCallQAVariant2? value) => new PreviewCallQA(value);

        /// <summary>
        ///
        /// </summary>
        public PreviewCallQA(
            global::RetellAI.ChCallQA? ch,
            global::RetellAI.PreviewCallQAVariant2? previewCallQAVariant2
            )
        {
            Ch = ch;
            PreviewCallQAVariant2 = previewCallQAVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PreviewCallQAVariant2 as object ??
            Ch as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Ch?.ToString() ??
            PreviewCallQAVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCh && IsPreviewCallQAVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ChCallQA, TResult>? ch = null,
            global::System.Func<global::RetellAI.PreviewCallQAVariant2, TResult>? previewCallQAVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCh && ch != null)
            {
                return ch(Ch!);
            }
            else if (IsPreviewCallQAVariant2 && previewCallQAVariant2 != null)
            {
                return previewCallQAVariant2(PreviewCallQAVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ChCallQA>? ch = null,

            global::System.Action<global::RetellAI.PreviewCallQAVariant2>? previewCallQAVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCh)
            {
                ch?.Invoke(Ch!);
            }
            else if (IsPreviewCallQAVariant2)
            {
                previewCallQAVariant2?.Invoke(PreviewCallQAVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ChCallQA>? ch = null,
            global::System.Action<global::RetellAI.PreviewCallQAVariant2>? previewCallQAVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCh)
            {
                ch?.Invoke(Ch!);
            }
            else if (IsPreviewCallQAVariant2)
            {
                previewCallQAVariant2?.Invoke(PreviewCallQAVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Ch,
                typeof(global::RetellAI.ChCallQA),
                PreviewCallQAVariant2,
                typeof(global::RetellAI.PreviewCallQAVariant2),
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
        public bool Equals(PreviewCallQA other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ChCallQA?>.Default.Equals(Ch, other.Ch) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.PreviewCallQAVariant2?>.Default.Equals(PreviewCallQAVariant2, other.PreviewCallQAVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PreviewCallQA obj1, PreviewCallQA obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PreviewCallQA>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PreviewCallQA obj1, PreviewCallQA obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PreviewCallQA o && Equals(o);
        }
    }
}
