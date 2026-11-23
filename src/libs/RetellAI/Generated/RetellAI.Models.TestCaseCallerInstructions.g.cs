#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// How the simulated caller behaves during the test.
    /// </summary>
    public readonly partial struct TestCaseCallerInstructions : global::System.IEquatable<TestCaseCallerInstructions>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TestCaseCallerInstructionsVariant1? TestCaseCallerInstructionsVariant1 { get; init; }
#else
        public global::RetellAI.TestCaseCallerInstructionsVariant1? TestCaseCallerInstructionsVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestCaseCallerInstructionsVariant1))]
#endif
        public bool IsTestCaseCallerInstructionsVariant1 => TestCaseCallerInstructionsVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTestCaseCallerInstructionsVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.TestCaseCallerInstructionsVariant1? value)
        {
            value = TestCaseCallerInstructionsVariant1;
            return IsTestCaseCallerInstructionsVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseCallerInstructionsVariant1 PickTestCaseCallerInstructionsVariant1() => TestCaseCallerInstructionsVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TestCaseCallerInstructionsVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TestCaseCallerInstructionsVariant2? TestCaseCallerInstructionsVariant2 { get; init; }
#else
        public global::RetellAI.TestCaseCallerInstructionsVariant2? TestCaseCallerInstructionsVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestCaseCallerInstructionsVariant2))]
#endif
        public bool IsTestCaseCallerInstructionsVariant2 => TestCaseCallerInstructionsVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTestCaseCallerInstructionsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.TestCaseCallerInstructionsVariant2? value)
        {
            value = TestCaseCallerInstructionsVariant2;
            return IsTestCaseCallerInstructionsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseCallerInstructionsVariant2 PickTestCaseCallerInstructionsVariant2() => TestCaseCallerInstructionsVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TestCaseCallerInstructionsVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TestCaseCallerInstructions(global::RetellAI.TestCaseCallerInstructionsVariant1 value) => new TestCaseCallerInstructions((global::RetellAI.TestCaseCallerInstructionsVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.TestCaseCallerInstructionsVariant1?(TestCaseCallerInstructions @this) => @this.TestCaseCallerInstructionsVariant1;

        /// <summary>
        ///
        /// </summary>
        public TestCaseCallerInstructions(global::RetellAI.TestCaseCallerInstructionsVariant1? value)
        {
            TestCaseCallerInstructionsVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TestCaseCallerInstructions FromTestCaseCallerInstructionsVariant1(global::RetellAI.TestCaseCallerInstructionsVariant1? value) => new TestCaseCallerInstructions(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TestCaseCallerInstructions(global::RetellAI.TestCaseCallerInstructionsVariant2 value) => new TestCaseCallerInstructions((global::RetellAI.TestCaseCallerInstructionsVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.TestCaseCallerInstructionsVariant2?(TestCaseCallerInstructions @this) => @this.TestCaseCallerInstructionsVariant2;

        /// <summary>
        ///
        /// </summary>
        public TestCaseCallerInstructions(global::RetellAI.TestCaseCallerInstructionsVariant2? value)
        {
            TestCaseCallerInstructionsVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TestCaseCallerInstructions FromTestCaseCallerInstructionsVariant2(global::RetellAI.TestCaseCallerInstructionsVariant2? value) => new TestCaseCallerInstructions(value);

        /// <summary>
        ///
        /// </summary>
        public TestCaseCallerInstructions(
            global::RetellAI.TestCaseCallerInstructionsVariant1? testCaseCallerInstructionsVariant1,
            global::RetellAI.TestCaseCallerInstructionsVariant2? testCaseCallerInstructionsVariant2
            )
        {
            TestCaseCallerInstructionsVariant1 = testCaseCallerInstructionsVariant1;
            TestCaseCallerInstructionsVariant2 = testCaseCallerInstructionsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TestCaseCallerInstructionsVariant2 as object ??
            TestCaseCallerInstructionsVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            TestCaseCallerInstructionsVariant1?.ToString() ??
            TestCaseCallerInstructionsVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTestCaseCallerInstructionsVariant1 && !IsTestCaseCallerInstructionsVariant2 || !IsTestCaseCallerInstructionsVariant1 && IsTestCaseCallerInstructionsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.TestCaseCallerInstructionsVariant1, TResult>? testCaseCallerInstructionsVariant1 = null,
            global::System.Func<global::RetellAI.TestCaseCallerInstructionsVariant2, TResult>? testCaseCallerInstructionsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TestCaseCallerInstructionsVariant1 is { } __value0 && testCaseCallerInstructionsVariant1 != null)
            {
                return testCaseCallerInstructionsVariant1(__value0);
            }
            else if (TestCaseCallerInstructionsVariant2 is { } __value1 && testCaseCallerInstructionsVariant2 != null)
            {
                return testCaseCallerInstructionsVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.TestCaseCallerInstructionsVariant1>? testCaseCallerInstructionsVariant1 = null,

            global::System.Action<global::RetellAI.TestCaseCallerInstructionsVariant2>? testCaseCallerInstructionsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TestCaseCallerInstructionsVariant1 is { } __value0)
            {
                testCaseCallerInstructionsVariant1?.Invoke(__value0);
            }
            else if (TestCaseCallerInstructionsVariant2 is { } __value1)
            {
                testCaseCallerInstructionsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.TestCaseCallerInstructionsVariant1>? testCaseCallerInstructionsVariant1 = null,
            global::System.Action<global::RetellAI.TestCaseCallerInstructionsVariant2>? testCaseCallerInstructionsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TestCaseCallerInstructionsVariant1 is { } __value0)
            {
                testCaseCallerInstructionsVariant1?.Invoke(__value0);
            }
            else if (TestCaseCallerInstructionsVariant2 is { } __value1)
            {
                testCaseCallerInstructionsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TestCaseCallerInstructionsVariant1,
                typeof(global::RetellAI.TestCaseCallerInstructionsVariant1),
                TestCaseCallerInstructionsVariant2,
                typeof(global::RetellAI.TestCaseCallerInstructionsVariant2),
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
        public bool Equals(TestCaseCallerInstructions other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TestCaseCallerInstructionsVariant1?>.Default.Equals(TestCaseCallerInstructionsVariant1, other.TestCaseCallerInstructionsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TestCaseCallerInstructionsVariant2?>.Default.Equals(TestCaseCallerInstructionsVariant2, other.TestCaseCallerInstructionsVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TestCaseCallerInstructions obj1, TestCaseCallerInstructions obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TestCaseCallerInstructions>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TestCaseCallerInstructions obj1, TestCaseCallerInstructions obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TestCaseCallerInstructions o && Equals(o);
        }
    }
}
