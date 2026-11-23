#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// The audio to transcribe.
    /// </summary>
    public readonly partial struct TestCaseAsrAudioSource : global::System.IEquatable<TestCaseAsrAudioSource>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TestCaseAsrAudioSourceVariant1? TestCaseAsrAudioSourceVariant1 { get; init; }
#else
        public global::RetellAI.TestCaseAsrAudioSourceVariant1? TestCaseAsrAudioSourceVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestCaseAsrAudioSourceVariant1))]
#endif
        public bool IsTestCaseAsrAudioSourceVariant1 => TestCaseAsrAudioSourceVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTestCaseAsrAudioSourceVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.TestCaseAsrAudioSourceVariant1? value)
        {
            value = TestCaseAsrAudioSourceVariant1;
            return IsTestCaseAsrAudioSourceVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseAsrAudioSourceVariant1 PickTestCaseAsrAudioSourceVariant1() => TestCaseAsrAudioSourceVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TestCaseAsrAudioSourceVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TestCaseAsrAudioSourceVariant2? TestCaseAsrAudioSourceVariant2 { get; init; }
#else
        public global::RetellAI.TestCaseAsrAudioSourceVariant2? TestCaseAsrAudioSourceVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestCaseAsrAudioSourceVariant2))]
#endif
        public bool IsTestCaseAsrAudioSourceVariant2 => TestCaseAsrAudioSourceVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTestCaseAsrAudioSourceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.TestCaseAsrAudioSourceVariant2? value)
        {
            value = TestCaseAsrAudioSourceVariant2;
            return IsTestCaseAsrAudioSourceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseAsrAudioSourceVariant2 PickTestCaseAsrAudioSourceVariant2() => TestCaseAsrAudioSourceVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TestCaseAsrAudioSourceVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TestCaseAsrAudioSource(global::RetellAI.TestCaseAsrAudioSourceVariant1 value) => new TestCaseAsrAudioSource((global::RetellAI.TestCaseAsrAudioSourceVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.TestCaseAsrAudioSourceVariant1?(TestCaseAsrAudioSource @this) => @this.TestCaseAsrAudioSourceVariant1;

        /// <summary>
        ///
        /// </summary>
        public TestCaseAsrAudioSource(global::RetellAI.TestCaseAsrAudioSourceVariant1? value)
        {
            TestCaseAsrAudioSourceVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TestCaseAsrAudioSource FromTestCaseAsrAudioSourceVariant1(global::RetellAI.TestCaseAsrAudioSourceVariant1? value) => new TestCaseAsrAudioSource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TestCaseAsrAudioSource(global::RetellAI.TestCaseAsrAudioSourceVariant2 value) => new TestCaseAsrAudioSource((global::RetellAI.TestCaseAsrAudioSourceVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.TestCaseAsrAudioSourceVariant2?(TestCaseAsrAudioSource @this) => @this.TestCaseAsrAudioSourceVariant2;

        /// <summary>
        ///
        /// </summary>
        public TestCaseAsrAudioSource(global::RetellAI.TestCaseAsrAudioSourceVariant2? value)
        {
            TestCaseAsrAudioSourceVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TestCaseAsrAudioSource FromTestCaseAsrAudioSourceVariant2(global::RetellAI.TestCaseAsrAudioSourceVariant2? value) => new TestCaseAsrAudioSource(value);

        /// <summary>
        ///
        /// </summary>
        public TestCaseAsrAudioSource(
            global::RetellAI.TestCaseAsrAudioSourceVariant1? testCaseAsrAudioSourceVariant1,
            global::RetellAI.TestCaseAsrAudioSourceVariant2? testCaseAsrAudioSourceVariant2
            )
        {
            TestCaseAsrAudioSourceVariant1 = testCaseAsrAudioSourceVariant1;
            TestCaseAsrAudioSourceVariant2 = testCaseAsrAudioSourceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TestCaseAsrAudioSourceVariant2 as object ??
            TestCaseAsrAudioSourceVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            TestCaseAsrAudioSourceVariant1?.ToString() ??
            TestCaseAsrAudioSourceVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTestCaseAsrAudioSourceVariant1 && !IsTestCaseAsrAudioSourceVariant2 || !IsTestCaseAsrAudioSourceVariant1 && IsTestCaseAsrAudioSourceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.TestCaseAsrAudioSourceVariant1, TResult>? testCaseAsrAudioSourceVariant1 = null,
            global::System.Func<global::RetellAI.TestCaseAsrAudioSourceVariant2, TResult>? testCaseAsrAudioSourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TestCaseAsrAudioSourceVariant1 is { } __value0 && testCaseAsrAudioSourceVariant1 != null)
            {
                return testCaseAsrAudioSourceVariant1(__value0);
            }
            else if (TestCaseAsrAudioSourceVariant2 is { } __value1 && testCaseAsrAudioSourceVariant2 != null)
            {
                return testCaseAsrAudioSourceVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.TestCaseAsrAudioSourceVariant1>? testCaseAsrAudioSourceVariant1 = null,

            global::System.Action<global::RetellAI.TestCaseAsrAudioSourceVariant2>? testCaseAsrAudioSourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TestCaseAsrAudioSourceVariant1 is { } __value0)
            {
                testCaseAsrAudioSourceVariant1?.Invoke(__value0);
            }
            else if (TestCaseAsrAudioSourceVariant2 is { } __value1)
            {
                testCaseAsrAudioSourceVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.TestCaseAsrAudioSourceVariant1>? testCaseAsrAudioSourceVariant1 = null,
            global::System.Action<global::RetellAI.TestCaseAsrAudioSourceVariant2>? testCaseAsrAudioSourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TestCaseAsrAudioSourceVariant1 is { } __value0)
            {
                testCaseAsrAudioSourceVariant1?.Invoke(__value0);
            }
            else if (TestCaseAsrAudioSourceVariant2 is { } __value1)
            {
                testCaseAsrAudioSourceVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TestCaseAsrAudioSourceVariant1,
                typeof(global::RetellAI.TestCaseAsrAudioSourceVariant1),
                TestCaseAsrAudioSourceVariant2,
                typeof(global::RetellAI.TestCaseAsrAudioSourceVariant2),
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
        public bool Equals(TestCaseAsrAudioSource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TestCaseAsrAudioSourceVariant1?>.Default.Equals(TestCaseAsrAudioSourceVariant1, other.TestCaseAsrAudioSourceVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TestCaseAsrAudioSourceVariant2?>.Default.Equals(TestCaseAsrAudioSourceVariant2, other.TestCaseAsrAudioSourceVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TestCaseAsrAudioSource obj1, TestCaseAsrAudioSource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TestCaseAsrAudioSource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TestCaseAsrAudioSource obj1, TestCaseAsrAudioSource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TestCaseAsrAudioSource o && Equals(o);
        }
    }
}
