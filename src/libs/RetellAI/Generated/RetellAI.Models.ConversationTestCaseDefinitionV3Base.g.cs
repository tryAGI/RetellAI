#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ConversationTestCaseDefinitionV3Base : global::System.IEquatable<ConversationTestCaseDefinitionV3Base>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.TestCaseDefinitionV3Base? TestCaseDefinitionV3Base { get; init; }
#else
        public global::RetellAI.TestCaseDefinitionV3Base? TestCaseDefinitionV3Base { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestCaseDefinitionV3Base))]
#endif
        public bool IsTestCaseDefinitionV3Base => TestCaseDefinitionV3Base != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTestCaseDefinitionV3Base(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.TestCaseDefinitionV3Base? value)
        {
            value = TestCaseDefinitionV3Base;
            return IsTestCaseDefinitionV3Base;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.TestCaseDefinitionV3Base PickTestCaseDefinitionV3Base() => TestCaseDefinitionV3Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TestCaseDefinitionV3Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConversationTestCaseDefinitionV3BaseVariant2? ConversationTestCaseDefinitionV3BaseVariant2 { get; init; }
#else
        public global::RetellAI.ConversationTestCaseDefinitionV3BaseVariant2? ConversationTestCaseDefinitionV3BaseVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationTestCaseDefinitionV3BaseVariant2))]
#endif
        public bool IsConversationTestCaseDefinitionV3BaseVariant2 => ConversationTestCaseDefinitionV3BaseVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConversationTestCaseDefinitionV3BaseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConversationTestCaseDefinitionV3BaseVariant2? value)
        {
            value = ConversationTestCaseDefinitionV3BaseVariant2;
            return IsConversationTestCaseDefinitionV3BaseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConversationTestCaseDefinitionV3BaseVariant2 PickConversationTestCaseDefinitionV3BaseVariant2() => ConversationTestCaseDefinitionV3BaseVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationTestCaseDefinitionV3BaseVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConversationTestCaseDefinitionV3Base(global::RetellAI.TestCaseDefinitionV3Base value) => new ConversationTestCaseDefinitionV3Base((global::RetellAI.TestCaseDefinitionV3Base?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.TestCaseDefinitionV3Base?(ConversationTestCaseDefinitionV3Base @this) => @this.TestCaseDefinitionV3Base;

        /// <summary>
        ///
        /// </summary>
        public ConversationTestCaseDefinitionV3Base(global::RetellAI.TestCaseDefinitionV3Base? value)
        {
            TestCaseDefinitionV3Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConversationTestCaseDefinitionV3Base FromTestCaseDefinitionV3Base(global::RetellAI.TestCaseDefinitionV3Base? value) => new ConversationTestCaseDefinitionV3Base(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConversationTestCaseDefinitionV3Base(global::RetellAI.ConversationTestCaseDefinitionV3BaseVariant2 value) => new ConversationTestCaseDefinitionV3Base((global::RetellAI.ConversationTestCaseDefinitionV3BaseVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConversationTestCaseDefinitionV3BaseVariant2?(ConversationTestCaseDefinitionV3Base @this) => @this.ConversationTestCaseDefinitionV3BaseVariant2;

        /// <summary>
        ///
        /// </summary>
        public ConversationTestCaseDefinitionV3Base(global::RetellAI.ConversationTestCaseDefinitionV3BaseVariant2? value)
        {
            ConversationTestCaseDefinitionV3BaseVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConversationTestCaseDefinitionV3Base FromConversationTestCaseDefinitionV3BaseVariant2(global::RetellAI.ConversationTestCaseDefinitionV3BaseVariant2? value) => new ConversationTestCaseDefinitionV3Base(value);

        /// <summary>
        ///
        /// </summary>
        public ConversationTestCaseDefinitionV3Base(
            global::RetellAI.TestCaseDefinitionV3Base? testCaseDefinitionV3Base,
            global::RetellAI.ConversationTestCaseDefinitionV3BaseVariant2? conversationTestCaseDefinitionV3BaseVariant2
            )
        {
            TestCaseDefinitionV3Base = testCaseDefinitionV3Base;
            ConversationTestCaseDefinitionV3BaseVariant2 = conversationTestCaseDefinitionV3BaseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ConversationTestCaseDefinitionV3BaseVariant2 as object ??
            TestCaseDefinitionV3Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            TestCaseDefinitionV3Base?.ToString() ??
            ConversationTestCaseDefinitionV3BaseVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTestCaseDefinitionV3Base && IsConversationTestCaseDefinitionV3BaseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.TestCaseDefinitionV3Base, TResult>? testCaseDefinitionV3Base = null,
            global::System.Func<global::RetellAI.ConversationTestCaseDefinitionV3BaseVariant2, TResult>? conversationTestCaseDefinitionV3BaseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TestCaseDefinitionV3Base is { } __value0 && testCaseDefinitionV3Base != null)
            {
                return testCaseDefinitionV3Base(__value0);
            }
            else if (ConversationTestCaseDefinitionV3BaseVariant2 is { } __value1 && conversationTestCaseDefinitionV3BaseVariant2 != null)
            {
                return conversationTestCaseDefinitionV3BaseVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.TestCaseDefinitionV3Base>? testCaseDefinitionV3Base = null,

            global::System.Action<global::RetellAI.ConversationTestCaseDefinitionV3BaseVariant2>? conversationTestCaseDefinitionV3BaseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TestCaseDefinitionV3Base is { } __value0)
            {
                testCaseDefinitionV3Base?.Invoke(__value0);
            }
            else if (ConversationTestCaseDefinitionV3BaseVariant2 is { } __value1)
            {
                conversationTestCaseDefinitionV3BaseVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.TestCaseDefinitionV3Base>? testCaseDefinitionV3Base = null,
            global::System.Action<global::RetellAI.ConversationTestCaseDefinitionV3BaseVariant2>? conversationTestCaseDefinitionV3BaseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TestCaseDefinitionV3Base is { } __value0)
            {
                testCaseDefinitionV3Base?.Invoke(__value0);
            }
            else if (ConversationTestCaseDefinitionV3BaseVariant2 is { } __value1)
            {
                conversationTestCaseDefinitionV3BaseVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TestCaseDefinitionV3Base,
                typeof(global::RetellAI.TestCaseDefinitionV3Base),
                ConversationTestCaseDefinitionV3BaseVariant2,
                typeof(global::RetellAI.ConversationTestCaseDefinitionV3BaseVariant2),
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
        public bool Equals(ConversationTestCaseDefinitionV3Base other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TestCaseDefinitionV3Base?>.Default.Equals(TestCaseDefinitionV3Base, other.TestCaseDefinitionV3Base) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConversationTestCaseDefinitionV3BaseVariant2?>.Default.Equals(ConversationTestCaseDefinitionV3BaseVariant2, other.ConversationTestCaseDefinitionV3BaseVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ConversationTestCaseDefinitionV3Base obj1, ConversationTestCaseDefinitionV3Base obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConversationTestCaseDefinitionV3Base>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ConversationTestCaseDefinitionV3Base obj1, ConversationTestCaseDefinitionV3Base obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConversationTestCaseDefinitionV3Base o && Equals(o);
        }
    }
}
