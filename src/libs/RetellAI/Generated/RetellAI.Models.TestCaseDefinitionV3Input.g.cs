#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct TestCaseDefinitionV3Input : global::System.IEquatable<TestCaseDefinitionV3Input>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.OneOf<global::RetellAI.TextTestCaseDefinitionV3Input?, global::RetellAI.AudioTestCaseDefinitionV3Input?, global::RetellAI.AsrTestCaseDefinitionV3Input?>? TestCaseDefinitionV3InputVariant1 { get; init; }
#else
        public global::RetellAI.OneOf<global::RetellAI.TextTestCaseDefinitionV3Input?, global::RetellAI.AudioTestCaseDefinitionV3Input?, global::RetellAI.AsrTestCaseDefinitionV3Input?>? TestCaseDefinitionV3InputVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestCaseDefinitionV3InputVariant1))]
#endif
        public bool IsTestCaseDefinitionV3InputVariant1 => TestCaseDefinitionV3InputVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTestCaseDefinitionV3InputVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.OneOf<global::RetellAI.TextTestCaseDefinitionV3Input?, global::RetellAI.AudioTestCaseDefinitionV3Input?, global::RetellAI.AsrTestCaseDefinitionV3Input?>? value)
        {
            value = TestCaseDefinitionV3InputVariant1;
            return IsTestCaseDefinitionV3InputVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.OneOf<global::RetellAI.TextTestCaseDefinitionV3Input?, global::RetellAI.AudioTestCaseDefinitionV3Input?, global::RetellAI.AsrTestCaseDefinitionV3Input?> PickTestCaseDefinitionV3InputVariant1() => TestCaseDefinitionV3InputVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TestCaseDefinitionV3InputVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TestCaseDefinitionV3InputVariant2? TestCaseDefinitionV3InputVariant2 { get; init; }
#else
        public global::RetellAI.TestCaseDefinitionV3InputVariant2? TestCaseDefinitionV3InputVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestCaseDefinitionV3InputVariant2))]
#endif
        public bool IsTestCaseDefinitionV3InputVariant2 => TestCaseDefinitionV3InputVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTestCaseDefinitionV3InputVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.TestCaseDefinitionV3InputVariant2? value)
        {
            value = TestCaseDefinitionV3InputVariant2;
            return IsTestCaseDefinitionV3InputVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseDefinitionV3InputVariant2 PickTestCaseDefinitionV3InputVariant2() => TestCaseDefinitionV3InputVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TestCaseDefinitionV3InputVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TestCaseDefinitionV3Input(global::RetellAI.OneOf<global::RetellAI.TextTestCaseDefinitionV3Input?, global::RetellAI.AudioTestCaseDefinitionV3Input?, global::RetellAI.AsrTestCaseDefinitionV3Input?> value) => new TestCaseDefinitionV3Input((global::RetellAI.OneOf<global::RetellAI.TextTestCaseDefinitionV3Input?, global::RetellAI.AudioTestCaseDefinitionV3Input?, global::RetellAI.AsrTestCaseDefinitionV3Input?>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.OneOf<global::RetellAI.TextTestCaseDefinitionV3Input?, global::RetellAI.AudioTestCaseDefinitionV3Input?, global::RetellAI.AsrTestCaseDefinitionV3Input?>?(TestCaseDefinitionV3Input @this) => @this.TestCaseDefinitionV3InputVariant1;

        /// <summary>
        ///
        /// </summary>
        public TestCaseDefinitionV3Input(global::RetellAI.OneOf<global::RetellAI.TextTestCaseDefinitionV3Input?, global::RetellAI.AudioTestCaseDefinitionV3Input?, global::RetellAI.AsrTestCaseDefinitionV3Input?>? value)
        {
            TestCaseDefinitionV3InputVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TestCaseDefinitionV3Input FromTestCaseDefinitionV3InputVariant1(global::RetellAI.OneOf<global::RetellAI.TextTestCaseDefinitionV3Input?, global::RetellAI.AudioTestCaseDefinitionV3Input?, global::RetellAI.AsrTestCaseDefinitionV3Input?>? value) => new TestCaseDefinitionV3Input(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TestCaseDefinitionV3Input(global::RetellAI.TestCaseDefinitionV3InputVariant2 value) => new TestCaseDefinitionV3Input((global::RetellAI.TestCaseDefinitionV3InputVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.TestCaseDefinitionV3InputVariant2?(TestCaseDefinitionV3Input @this) => @this.TestCaseDefinitionV3InputVariant2;

        /// <summary>
        ///
        /// </summary>
        public TestCaseDefinitionV3Input(global::RetellAI.TestCaseDefinitionV3InputVariant2? value)
        {
            TestCaseDefinitionV3InputVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TestCaseDefinitionV3Input FromTestCaseDefinitionV3InputVariant2(global::RetellAI.TestCaseDefinitionV3InputVariant2? value) => new TestCaseDefinitionV3Input(value);

        /// <summary>
        ///
        /// </summary>
        public TestCaseDefinitionV3Input(
            global::RetellAI.OneOf<global::RetellAI.TextTestCaseDefinitionV3Input?, global::RetellAI.AudioTestCaseDefinitionV3Input?, global::RetellAI.AsrTestCaseDefinitionV3Input?>? testCaseDefinitionV3InputVariant1,
            global::RetellAI.TestCaseDefinitionV3InputVariant2? testCaseDefinitionV3InputVariant2
            )
        {
            TestCaseDefinitionV3InputVariant1 = testCaseDefinitionV3InputVariant1;
            TestCaseDefinitionV3InputVariant2 = testCaseDefinitionV3InputVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TestCaseDefinitionV3InputVariant2 as object ??
            TestCaseDefinitionV3InputVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            TestCaseDefinitionV3InputVariant1?.ToString() ??
            TestCaseDefinitionV3InputVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTestCaseDefinitionV3InputVariant1 && IsTestCaseDefinitionV3InputVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.OneOf<global::RetellAI.TextTestCaseDefinitionV3Input?, global::RetellAI.AudioTestCaseDefinitionV3Input?, global::RetellAI.AsrTestCaseDefinitionV3Input?>?, TResult>? testCaseDefinitionV3InputVariant1 = null,
            global::System.Func<global::RetellAI.TestCaseDefinitionV3InputVariant2, TResult>? testCaseDefinitionV3InputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TestCaseDefinitionV3InputVariant1 is { } __value0 && testCaseDefinitionV3InputVariant1 != null)
            {
                return testCaseDefinitionV3InputVariant1(__value0);
            }
            else if (TestCaseDefinitionV3InputVariant2 is { } __value1 && testCaseDefinitionV3InputVariant2 != null)
            {
                return testCaseDefinitionV3InputVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.OneOf<global::RetellAI.TextTestCaseDefinitionV3Input?, global::RetellAI.AudioTestCaseDefinitionV3Input?, global::RetellAI.AsrTestCaseDefinitionV3Input?>?>? testCaseDefinitionV3InputVariant1 = null,

            global::System.Action<global::RetellAI.TestCaseDefinitionV3InputVariant2>? testCaseDefinitionV3InputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TestCaseDefinitionV3InputVariant1 is { } __value0)
            {
                testCaseDefinitionV3InputVariant1?.Invoke(__value0);
            }
            else if (TestCaseDefinitionV3InputVariant2 is { } __value1)
            {
                testCaseDefinitionV3InputVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.OneOf<global::RetellAI.TextTestCaseDefinitionV3Input?, global::RetellAI.AudioTestCaseDefinitionV3Input?, global::RetellAI.AsrTestCaseDefinitionV3Input?>?>? testCaseDefinitionV3InputVariant1 = null,
            global::System.Action<global::RetellAI.TestCaseDefinitionV3InputVariant2>? testCaseDefinitionV3InputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TestCaseDefinitionV3InputVariant1 is { } __value0)
            {
                testCaseDefinitionV3InputVariant1?.Invoke(__value0);
            }
            else if (TestCaseDefinitionV3InputVariant2 is { } __value1)
            {
                testCaseDefinitionV3InputVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TestCaseDefinitionV3InputVariant1,
                typeof(global::RetellAI.OneOf<global::RetellAI.TextTestCaseDefinitionV3Input?, global::RetellAI.AudioTestCaseDefinitionV3Input?, global::RetellAI.AsrTestCaseDefinitionV3Input?>),
                TestCaseDefinitionV3InputVariant2,
                typeof(global::RetellAI.TestCaseDefinitionV3InputVariant2),
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
        public bool Equals(TestCaseDefinitionV3Input other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.OneOf<global::RetellAI.TextTestCaseDefinitionV3Input?, global::RetellAI.AudioTestCaseDefinitionV3Input?, global::RetellAI.AsrTestCaseDefinitionV3Input?>?>.Default.Equals(TestCaseDefinitionV3InputVariant1, other.TestCaseDefinitionV3InputVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TestCaseDefinitionV3InputVariant2?>.Default.Equals(TestCaseDefinitionV3InputVariant2, other.TestCaseDefinitionV3InputVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TestCaseDefinitionV3Input obj1, TestCaseDefinitionV3Input obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TestCaseDefinitionV3Input>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TestCaseDefinitionV3Input obj1, TestCaseDefinitionV3Input obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TestCaseDefinitionV3Input o && Equals(o);
        }
    }
}
