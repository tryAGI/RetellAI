#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TestCaseDefinition : global::System.IEquatable<TestCaseDefinition>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TestCaseDefinitionInput? Input { get; init; }
#else
        public global::RetellAI.TestCaseDefinitionInput? Input { get; }
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
#if NET6_0_OR_GREATER
        public global::RetellAI.TestCaseDefinitionVariant2? TestCaseDefinitionVariant2 { get; init; }
#else
        public global::RetellAI.TestCaseDefinitionVariant2? TestCaseDefinitionVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestCaseDefinitionVariant2))]
#endif
        public bool IsTestCaseDefinitionVariant2 => TestCaseDefinitionVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestCaseDefinition(global::RetellAI.TestCaseDefinitionInput value) => new TestCaseDefinition((global::RetellAI.TestCaseDefinitionInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.TestCaseDefinitionInput?(TestCaseDefinition @this) => @this.Input;

        /// <summary>
        /// 
        /// </summary>
        public TestCaseDefinition(global::RetellAI.TestCaseDefinitionInput? value)
        {
            Input = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestCaseDefinition(global::RetellAI.TestCaseDefinitionVariant2 value) => new TestCaseDefinition((global::RetellAI.TestCaseDefinitionVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.TestCaseDefinitionVariant2?(TestCaseDefinition @this) => @this.TestCaseDefinitionVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TestCaseDefinition(global::RetellAI.TestCaseDefinitionVariant2? value)
        {
            TestCaseDefinitionVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TestCaseDefinition(
            global::RetellAI.TestCaseDefinitionInput? input,
            global::RetellAI.TestCaseDefinitionVariant2? testCaseDefinitionVariant2
            )
        {
            Input = input;
            TestCaseDefinitionVariant2 = testCaseDefinitionVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TestCaseDefinitionVariant2 as object ??
            Input as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Input?.ToString() ??
            TestCaseDefinitionVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInput && IsTestCaseDefinitionVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.TestCaseDefinitionInput?, TResult>? input = null,
            global::System.Func<global::RetellAI.TestCaseDefinitionVariant2?, TResult>? testCaseDefinitionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInput && input != null)
            {
                return input(Input!);
            }
            else if (IsTestCaseDefinitionVariant2 && testCaseDefinitionVariant2 != null)
            {
                return testCaseDefinitionVariant2(TestCaseDefinitionVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.TestCaseDefinitionInput?>? input = null,
            global::System.Action<global::RetellAI.TestCaseDefinitionVariant2?>? testCaseDefinitionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInput)
            {
                input?.Invoke(Input!);
            }
            else if (IsTestCaseDefinitionVariant2)
            {
                testCaseDefinitionVariant2?.Invoke(TestCaseDefinitionVariant2!);
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
                typeof(global::RetellAI.TestCaseDefinitionInput),
                TestCaseDefinitionVariant2,
                typeof(global::RetellAI.TestCaseDefinitionVariant2),
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
        public bool Equals(TestCaseDefinition other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TestCaseDefinitionInput?>.Default.Equals(Input, other.Input) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TestCaseDefinitionVariant2?>.Default.Equals(TestCaseDefinitionVariant2, other.TestCaseDefinitionVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TestCaseDefinition obj1, TestCaseDefinition obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TestCaseDefinition>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TestCaseDefinition obj1, TestCaseDefinition obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TestCaseDefinition o && Equals(o);
        }
    }
}
