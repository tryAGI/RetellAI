#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// One check the conversation must pass for the test to pass.
    /// </summary>
    public readonly partial struct TestCaseEvalCriterion : global::System.IEquatable<TestCaseEvalCriterion>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TestCaseEvalCriterionVariant1? TestCaseEvalCriterionVariant1 { get; init; }
#else
        public global::RetellAI.TestCaseEvalCriterionVariant1? TestCaseEvalCriterionVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestCaseEvalCriterionVariant1))]
#endif
        public bool IsTestCaseEvalCriterionVariant1 => TestCaseEvalCriterionVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTestCaseEvalCriterionVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.TestCaseEvalCriterionVariant1? value)
        {
            value = TestCaseEvalCriterionVariant1;
            return IsTestCaseEvalCriterionVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseEvalCriterionVariant1 PickTestCaseEvalCriterionVariant1() => TestCaseEvalCriterionVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TestCaseEvalCriterionVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TestCaseEvalCriterionVariant2? TestCaseEvalCriterionVariant2 { get; init; }
#else
        public global::RetellAI.TestCaseEvalCriterionVariant2? TestCaseEvalCriterionVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestCaseEvalCriterionVariant2))]
#endif
        public bool IsTestCaseEvalCriterionVariant2 => TestCaseEvalCriterionVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTestCaseEvalCriterionVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.TestCaseEvalCriterionVariant2? value)
        {
            value = TestCaseEvalCriterionVariant2;
            return IsTestCaseEvalCriterionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseEvalCriterionVariant2 PickTestCaseEvalCriterionVariant2() => TestCaseEvalCriterionVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TestCaseEvalCriterionVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TestCaseEvalCriterion(global::RetellAI.TestCaseEvalCriterionVariant1 value) => new TestCaseEvalCriterion((global::RetellAI.TestCaseEvalCriterionVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.TestCaseEvalCriterionVariant1?(TestCaseEvalCriterion @this) => @this.TestCaseEvalCriterionVariant1;

        /// <summary>
        ///
        /// </summary>
        public TestCaseEvalCriterion(global::RetellAI.TestCaseEvalCriterionVariant1? value)
        {
            TestCaseEvalCriterionVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TestCaseEvalCriterion FromTestCaseEvalCriterionVariant1(global::RetellAI.TestCaseEvalCriterionVariant1? value) => new TestCaseEvalCriterion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TestCaseEvalCriterion(global::RetellAI.TestCaseEvalCriterionVariant2 value) => new TestCaseEvalCriterion((global::RetellAI.TestCaseEvalCriterionVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.TestCaseEvalCriterionVariant2?(TestCaseEvalCriterion @this) => @this.TestCaseEvalCriterionVariant2;

        /// <summary>
        ///
        /// </summary>
        public TestCaseEvalCriterion(global::RetellAI.TestCaseEvalCriterionVariant2? value)
        {
            TestCaseEvalCriterionVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TestCaseEvalCriterion FromTestCaseEvalCriterionVariant2(global::RetellAI.TestCaseEvalCriterionVariant2? value) => new TestCaseEvalCriterion(value);

        /// <summary>
        ///
        /// </summary>
        public TestCaseEvalCriterion(
            global::RetellAI.TestCaseEvalCriterionVariant1? testCaseEvalCriterionVariant1,
            global::RetellAI.TestCaseEvalCriterionVariant2? testCaseEvalCriterionVariant2
            )
        {
            TestCaseEvalCriterionVariant1 = testCaseEvalCriterionVariant1;
            TestCaseEvalCriterionVariant2 = testCaseEvalCriterionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TestCaseEvalCriterionVariant2 as object ??
            TestCaseEvalCriterionVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            TestCaseEvalCriterionVariant1?.ToString() ??
            TestCaseEvalCriterionVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTestCaseEvalCriterionVariant1 && !IsTestCaseEvalCriterionVariant2 || !IsTestCaseEvalCriterionVariant1 && IsTestCaseEvalCriterionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.TestCaseEvalCriterionVariant1, TResult>? testCaseEvalCriterionVariant1 = null,
            global::System.Func<global::RetellAI.TestCaseEvalCriterionVariant2, TResult>? testCaseEvalCriterionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TestCaseEvalCriterionVariant1 is { } __value0 && testCaseEvalCriterionVariant1 != null)
            {
                return testCaseEvalCriterionVariant1(__value0);
            }
            else if (TestCaseEvalCriterionVariant2 is { } __value1 && testCaseEvalCriterionVariant2 != null)
            {
                return testCaseEvalCriterionVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.TestCaseEvalCriterionVariant1>? testCaseEvalCriterionVariant1 = null,

            global::System.Action<global::RetellAI.TestCaseEvalCriterionVariant2>? testCaseEvalCriterionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TestCaseEvalCriterionVariant1 is { } __value0)
            {
                testCaseEvalCriterionVariant1?.Invoke(__value0);
            }
            else if (TestCaseEvalCriterionVariant2 is { } __value1)
            {
                testCaseEvalCriterionVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.TestCaseEvalCriterionVariant1>? testCaseEvalCriterionVariant1 = null,
            global::System.Action<global::RetellAI.TestCaseEvalCriterionVariant2>? testCaseEvalCriterionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TestCaseEvalCriterionVariant1 is { } __value0)
            {
                testCaseEvalCriterionVariant1?.Invoke(__value0);
            }
            else if (TestCaseEvalCriterionVariant2 is { } __value1)
            {
                testCaseEvalCriterionVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TestCaseEvalCriterionVariant1,
                typeof(global::RetellAI.TestCaseEvalCriterionVariant1),
                TestCaseEvalCriterionVariant2,
                typeof(global::RetellAI.TestCaseEvalCriterionVariant2),
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
        public bool Equals(TestCaseEvalCriterion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TestCaseEvalCriterionVariant1?>.Default.Equals(TestCaseEvalCriterionVariant1, other.TestCaseEvalCriterionVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TestCaseEvalCriterionVariant2?>.Default.Equals(TestCaseEvalCriterionVariant2, other.TestCaseEvalCriterionVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TestCaseEvalCriterion obj1, TestCaseEvalCriterion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TestCaseEvalCriterion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TestCaseEvalCriterion obj1, TestCaseEvalCriterion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TestCaseEvalCriterion o && Equals(o);
        }
    }
}
