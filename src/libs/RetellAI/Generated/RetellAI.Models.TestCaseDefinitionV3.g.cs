#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct TestCaseDefinitionV3 : global::System.IEquatable<TestCaseDefinitionV3>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TestCaseDefinitionV3Input? Input { get; init; }
#else
        public global::RetellAI.TestCaseDefinitionV3Input? Input { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Input))]
#endif
        public bool IsInput => Input != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.TestCaseDefinitionV3Input? value)
        {
            value = Input;
            return IsInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseDefinitionV3Input PickInput() => Input is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Input' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TestCaseDefinitionV3Metadata? Metadata { get; init; }
#else
        public global::RetellAI.TestCaseDefinitionV3Metadata? Metadata { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Metadata))]
#endif
        public bool IsMetadata => Metadata != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMetadata(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.TestCaseDefinitionV3Metadata? value)
        {
            value = Metadata;
            return IsMetadata;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseDefinitionV3Metadata PickMetadata() => Metadata is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Metadata' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TestCaseDefinitionV3(global::RetellAI.TestCaseDefinitionV3Input value) => new TestCaseDefinitionV3((global::RetellAI.TestCaseDefinitionV3Input?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.TestCaseDefinitionV3Input?(TestCaseDefinitionV3 @this) => @this.Input;

        /// <summary>
        ///
        /// </summary>
        public TestCaseDefinitionV3(global::RetellAI.TestCaseDefinitionV3Input? value)
        {
            Input = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TestCaseDefinitionV3 FromInput(global::RetellAI.TestCaseDefinitionV3Input? value) => new TestCaseDefinitionV3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TestCaseDefinitionV3(global::RetellAI.TestCaseDefinitionV3Metadata value) => new TestCaseDefinitionV3((global::RetellAI.TestCaseDefinitionV3Metadata?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.TestCaseDefinitionV3Metadata?(TestCaseDefinitionV3 @this) => @this.Metadata;

        /// <summary>
        ///
        /// </summary>
        public TestCaseDefinitionV3(global::RetellAI.TestCaseDefinitionV3Metadata? value)
        {
            Metadata = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TestCaseDefinitionV3 FromMetadata(global::RetellAI.TestCaseDefinitionV3Metadata? value) => new TestCaseDefinitionV3(value);

        /// <summary>
        ///
        /// </summary>
        public TestCaseDefinitionV3(
            global::RetellAI.TestCaseDefinitionV3Input? input,
            global::RetellAI.TestCaseDefinitionV3Metadata? metadata
            )
        {
            Input = input;
            Metadata = metadata;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Metadata as object ??
            Input as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Input?.ToString() ??
            Metadata?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInput && IsMetadata;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.TestCaseDefinitionV3Input?, TResult>? input = null,
            global::System.Func<global::RetellAI.TestCaseDefinitionV3Metadata, TResult>? metadata = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Input is { } __value0 && input != null)
            {
                return input(__value0);
            }
            else if (Metadata is { } __value1 && metadata != null)
            {
                return metadata(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.TestCaseDefinitionV3Input?>? input = null,

            global::System.Action<global::RetellAI.TestCaseDefinitionV3Metadata>? metadata = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Input is { } __value0)
            {
                input?.Invoke(__value0);
            }
            else if (Metadata is { } __value1)
            {
                metadata?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.TestCaseDefinitionV3Input?>? input = null,
            global::System.Action<global::RetellAI.TestCaseDefinitionV3Metadata>? metadata = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Input is { } __value0)
            {
                input?.Invoke(__value0);
            }
            else if (Metadata is { } __value1)
            {
                metadata?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Input,
                typeof(global::RetellAI.TestCaseDefinitionV3Input),
                Metadata,
                typeof(global::RetellAI.TestCaseDefinitionV3Metadata),
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
        public bool Equals(TestCaseDefinitionV3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TestCaseDefinitionV3Input?>.Default.Equals(Input, other.Input) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TestCaseDefinitionV3Metadata?>.Default.Equals(Metadata, other.Metadata)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TestCaseDefinitionV3 obj1, TestCaseDefinitionV3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TestCaseDefinitionV3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TestCaseDefinitionV3 obj1, TestCaseDefinitionV3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TestCaseDefinitionV3 o && Equals(o);
        }
    }
}
