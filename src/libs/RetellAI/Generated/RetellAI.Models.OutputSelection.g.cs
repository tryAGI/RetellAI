#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// What the agent and the transcript see of the tool's response. Omit to send the full response. Does not affect response_variables, which are always extracted from the raw response.
    /// </summary>
    public readonly partial struct OutputSelection : global::System.IEquatable<OutputSelection>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.OutputSelectionVariant1? OutputSelectionVariant1 { get; init; }
#else
        public global::RetellAI.OutputSelectionVariant1? OutputSelectionVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputSelectionVariant1))]
#endif
        public bool IsOutputSelectionVariant1 => OutputSelectionVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputSelectionVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.OutputSelectionVariant1? value)
        {
            value = OutputSelectionVariant1;
            return IsOutputSelectionVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OutputSelectionVariant1 PickOutputSelectionVariant1() => OutputSelectionVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputSelectionVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.OutputSelectionVariant2? OutputSelectionVariant2 { get; init; }
#else
        public global::RetellAI.OutputSelectionVariant2? OutputSelectionVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputSelectionVariant2))]
#endif
        public bool IsOutputSelectionVariant2 => OutputSelectionVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputSelectionVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.OutputSelectionVariant2? value)
        {
            value = OutputSelectionVariant2;
            return IsOutputSelectionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OutputSelectionVariant2 PickOutputSelectionVariant2() => OutputSelectionVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputSelectionVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputSelection(global::RetellAI.OutputSelectionVariant1 value) => new OutputSelection((global::RetellAI.OutputSelectionVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.OutputSelectionVariant1?(OutputSelection @this) => @this.OutputSelectionVariant1;

        /// <summary>
        ///
        /// </summary>
        public OutputSelection(global::RetellAI.OutputSelectionVariant1? value)
        {
            OutputSelectionVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputSelection FromOutputSelectionVariant1(global::RetellAI.OutputSelectionVariant1? value) => new OutputSelection(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputSelection(global::RetellAI.OutputSelectionVariant2 value) => new OutputSelection((global::RetellAI.OutputSelectionVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.OutputSelectionVariant2?(OutputSelection @this) => @this.OutputSelectionVariant2;

        /// <summary>
        ///
        /// </summary>
        public OutputSelection(global::RetellAI.OutputSelectionVariant2? value)
        {
            OutputSelectionVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputSelection FromOutputSelectionVariant2(global::RetellAI.OutputSelectionVariant2? value) => new OutputSelection(value);

        /// <summary>
        ///
        /// </summary>
        public OutputSelection(
            global::RetellAI.OutputSelectionVariant1? outputSelectionVariant1,
            global::RetellAI.OutputSelectionVariant2? outputSelectionVariant2
            )
        {
            OutputSelectionVariant1 = outputSelectionVariant1;
            OutputSelectionVariant2 = outputSelectionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OutputSelectionVariant2 as object ??
            OutputSelectionVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OutputSelectionVariant1?.ToString() ??
            OutputSelectionVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOutputSelectionVariant1 && !IsOutputSelectionVariant2 || !IsOutputSelectionVariant1 && IsOutputSelectionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.OutputSelectionVariant1, TResult>? outputSelectionVariant1 = null,
            global::System.Func<global::RetellAI.OutputSelectionVariant2, TResult>? outputSelectionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputSelectionVariant1 is { } __value0 && outputSelectionVariant1 != null)
            {
                return outputSelectionVariant1(__value0);
            }
            else if (OutputSelectionVariant2 is { } __value1 && outputSelectionVariant2 != null)
            {
                return outputSelectionVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.OutputSelectionVariant1>? outputSelectionVariant1 = null,

            global::System.Action<global::RetellAI.OutputSelectionVariant2>? outputSelectionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputSelectionVariant1 is { } __value0)
            {
                outputSelectionVariant1?.Invoke(__value0);
            }
            else if (OutputSelectionVariant2 is { } __value1)
            {
                outputSelectionVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.OutputSelectionVariant1>? outputSelectionVariant1 = null,
            global::System.Action<global::RetellAI.OutputSelectionVariant2>? outputSelectionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputSelectionVariant1 is { } __value0)
            {
                outputSelectionVariant1?.Invoke(__value0);
            }
            else if (OutputSelectionVariant2 is { } __value1)
            {
                outputSelectionVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputSelectionVariant1,
                typeof(global::RetellAI.OutputSelectionVariant1),
                OutputSelectionVariant2,
                typeof(global::RetellAI.OutputSelectionVariant2),
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
        public bool Equals(OutputSelection other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.OutputSelectionVariant1?>.Default.Equals(OutputSelectionVariant1, other.OutputSelectionVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.OutputSelectionVariant2?>.Default.Equals(OutputSelectionVariant2, other.OutputSelectionVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(OutputSelection obj1, OutputSelection obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputSelection>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputSelection obj1, OutputSelection obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputSelection o && Equals(o);
        }
    }
}
