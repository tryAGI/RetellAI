#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ConversationTestCaseJobV3Base : global::System.IEquatable<ConversationTestCaseJobV3Base>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TestCaseJobV3Base? TestCaseJobV3Base { get; init; }
#else
        public global::RetellAI.TestCaseJobV3Base? TestCaseJobV3Base { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestCaseJobV3Base))]
#endif
        public bool IsTestCaseJobV3Base => TestCaseJobV3Base != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTestCaseJobV3Base(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.TestCaseJobV3Base? value)
        {
            value = TestCaseJobV3Base;
            return IsTestCaseJobV3Base;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseJobV3Base PickTestCaseJobV3Base() => TestCaseJobV3Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TestCaseJobV3Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConversationTestCaseJobV3BaseVariant2? ConversationTestCaseJobV3BaseVariant2 { get; init; }
#else
        public global::RetellAI.ConversationTestCaseJobV3BaseVariant2? ConversationTestCaseJobV3BaseVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationTestCaseJobV3BaseVariant2))]
#endif
        public bool IsConversationTestCaseJobV3BaseVariant2 => ConversationTestCaseJobV3BaseVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConversationTestCaseJobV3BaseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConversationTestCaseJobV3BaseVariant2? value)
        {
            value = ConversationTestCaseJobV3BaseVariant2;
            return IsConversationTestCaseJobV3BaseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationTestCaseJobV3BaseVariant2 PickConversationTestCaseJobV3BaseVariant2() => ConversationTestCaseJobV3BaseVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationTestCaseJobV3BaseVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConversationTestCaseJobV3Base(global::RetellAI.TestCaseJobV3Base value) => new ConversationTestCaseJobV3Base((global::RetellAI.TestCaseJobV3Base?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.TestCaseJobV3Base?(ConversationTestCaseJobV3Base @this) => @this.TestCaseJobV3Base;

        /// <summary>
        ///
        /// </summary>
        public ConversationTestCaseJobV3Base(global::RetellAI.TestCaseJobV3Base? value)
        {
            TestCaseJobV3Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConversationTestCaseJobV3Base FromTestCaseJobV3Base(global::RetellAI.TestCaseJobV3Base? value) => new ConversationTestCaseJobV3Base(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConversationTestCaseJobV3Base(global::RetellAI.ConversationTestCaseJobV3BaseVariant2 value) => new ConversationTestCaseJobV3Base((global::RetellAI.ConversationTestCaseJobV3BaseVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConversationTestCaseJobV3BaseVariant2?(ConversationTestCaseJobV3Base @this) => @this.ConversationTestCaseJobV3BaseVariant2;

        /// <summary>
        ///
        /// </summary>
        public ConversationTestCaseJobV3Base(global::RetellAI.ConversationTestCaseJobV3BaseVariant2? value)
        {
            ConversationTestCaseJobV3BaseVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConversationTestCaseJobV3Base FromConversationTestCaseJobV3BaseVariant2(global::RetellAI.ConversationTestCaseJobV3BaseVariant2? value) => new ConversationTestCaseJobV3Base(value);

        /// <summary>
        ///
        /// </summary>
        public ConversationTestCaseJobV3Base(
            global::RetellAI.TestCaseJobV3Base? testCaseJobV3Base,
            global::RetellAI.ConversationTestCaseJobV3BaseVariant2? conversationTestCaseJobV3BaseVariant2
            )
        {
            TestCaseJobV3Base = testCaseJobV3Base;
            ConversationTestCaseJobV3BaseVariant2 = conversationTestCaseJobV3BaseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ConversationTestCaseJobV3BaseVariant2 as object ??
            TestCaseJobV3Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            TestCaseJobV3Base?.ToString() ??
            ConversationTestCaseJobV3BaseVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTestCaseJobV3Base && IsConversationTestCaseJobV3BaseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.TestCaseJobV3Base, TResult>? testCaseJobV3Base = null,
            global::System.Func<global::RetellAI.ConversationTestCaseJobV3BaseVariant2, TResult>? conversationTestCaseJobV3BaseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TestCaseJobV3Base is { } __value0 && testCaseJobV3Base != null)
            {
                return testCaseJobV3Base(__value0);
            }
            else if (ConversationTestCaseJobV3BaseVariant2 is { } __value1 && conversationTestCaseJobV3BaseVariant2 != null)
            {
                return conversationTestCaseJobV3BaseVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.TestCaseJobV3Base>? testCaseJobV3Base = null,

            global::System.Action<global::RetellAI.ConversationTestCaseJobV3BaseVariant2>? conversationTestCaseJobV3BaseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TestCaseJobV3Base is { } __value0)
            {
                testCaseJobV3Base?.Invoke(__value0);
            }
            else if (ConversationTestCaseJobV3BaseVariant2 is { } __value1)
            {
                conversationTestCaseJobV3BaseVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.TestCaseJobV3Base>? testCaseJobV3Base = null,
            global::System.Action<global::RetellAI.ConversationTestCaseJobV3BaseVariant2>? conversationTestCaseJobV3BaseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TestCaseJobV3Base is { } __value0)
            {
                testCaseJobV3Base?.Invoke(__value0);
            }
            else if (ConversationTestCaseJobV3BaseVariant2 is { } __value1)
            {
                conversationTestCaseJobV3BaseVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TestCaseJobV3Base,
                typeof(global::RetellAI.TestCaseJobV3Base),
                ConversationTestCaseJobV3BaseVariant2,
                typeof(global::RetellAI.ConversationTestCaseJobV3BaseVariant2),
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
        public bool Equals(ConversationTestCaseJobV3Base other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TestCaseJobV3Base?>.Default.Equals(TestCaseJobV3Base, other.TestCaseJobV3Base) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConversationTestCaseJobV3BaseVariant2?>.Default.Equals(ConversationTestCaseJobV3BaseVariant2, other.ConversationTestCaseJobV3BaseVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ConversationTestCaseJobV3Base obj1, ConversationTestCaseJobV3Base obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConversationTestCaseJobV3Base>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ConversationTestCaseJobV3Base obj1, ConversationTestCaseJobV3Base obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConversationTestCaseJobV3Base o && Equals(o);
        }
    }
}
