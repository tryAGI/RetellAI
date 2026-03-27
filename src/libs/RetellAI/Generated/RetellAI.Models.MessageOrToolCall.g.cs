#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessageOrToolCall : global::System.IEquatable<MessageOrToolCall>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.Message? Value1 { get; init; }
#else
        public global::RetellAI.Message? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ToolCallInvocationMessage? Value2 { get; init; }
#else
        public global::RetellAI.ToolCallInvocationMessage? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ToolCallResultMessage? Value3 { get; init; }
#else
        public global::RetellAI.ToolCallResultMessage? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.NodeTransitionMessage? Value4 { get; init; }
#else
        public global::RetellAI.NodeTransitionMessage? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.StateTransitionMessage? Value5 { get; init; }
#else
        public global::RetellAI.StateTransitionMessage? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageOrToolCall(global::RetellAI.Message value) => new MessageOrToolCall((global::RetellAI.Message?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.Message?(MessageOrToolCall @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(global::RetellAI.Message? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageOrToolCall(global::RetellAI.ToolCallInvocationMessage value) => new MessageOrToolCall((global::RetellAI.ToolCallInvocationMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ToolCallInvocationMessage?(MessageOrToolCall @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(global::RetellAI.ToolCallInvocationMessage? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageOrToolCall(global::RetellAI.ToolCallResultMessage value) => new MessageOrToolCall((global::RetellAI.ToolCallResultMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ToolCallResultMessage?(MessageOrToolCall @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(global::RetellAI.ToolCallResultMessage? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageOrToolCall(global::RetellAI.NodeTransitionMessage value) => new MessageOrToolCall((global::RetellAI.NodeTransitionMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.NodeTransitionMessage?(MessageOrToolCall @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(global::RetellAI.NodeTransitionMessage? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageOrToolCall(global::RetellAI.StateTransitionMessage value) => new MessageOrToolCall((global::RetellAI.StateTransitionMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.StateTransitionMessage?(MessageOrToolCall @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(global::RetellAI.StateTransitionMessage? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(
            global::RetellAI.Message? value1,
            global::RetellAI.ToolCallInvocationMessage? value2,
            global::RetellAI.ToolCallResultMessage? value3,
            global::RetellAI.NodeTransitionMessage? value4,
            global::RetellAI.StateTransitionMessage? value5
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() ??
            Value4?.ToString() ??
            Value5?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 && !IsValue5 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4 && !IsValue5 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && IsValue5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.Message?, TResult>? value1 = null,
            global::System.Func<global::RetellAI.ToolCallInvocationMessage?, TResult>? value2 = null,
            global::System.Func<global::RetellAI.ToolCallResultMessage?, TResult>? value3 = null,
            global::System.Func<global::RetellAI.NodeTransitionMessage?, TResult>? value4 = null,
            global::System.Func<global::RetellAI.StateTransitionMessage?, TResult>? value5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }
            else if (IsValue5 && value5 != null)
            {
                return value5(Value5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.Message?>? value1 = null,
            global::System.Action<global::RetellAI.ToolCallInvocationMessage?>? value2 = null,
            global::System.Action<global::RetellAI.ToolCallResultMessage?>? value3 = null,
            global::System.Action<global::RetellAI.NodeTransitionMessage?>? value4 = null,
            global::System.Action<global::RetellAI.StateTransitionMessage?>? value5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::RetellAI.Message),
                Value2,
                typeof(global::RetellAI.ToolCallInvocationMessage),
                Value3,
                typeof(global::RetellAI.ToolCallResultMessage),
                Value4,
                typeof(global::RetellAI.NodeTransitionMessage),
                Value5,
                typeof(global::RetellAI.StateTransitionMessage),
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
        public bool Equals(MessageOrToolCall other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.Message?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ToolCallInvocationMessage?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ToolCallResultMessage?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.NodeTransitionMessage?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.StateTransitionMessage?>.Default.Equals(Value5, other.Value5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessageOrToolCall obj1, MessageOrToolCall obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessageOrToolCall>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessageOrToolCall obj1, MessageOrToolCall obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessageOrToolCall o && Equals(o);
        }
    }
}
