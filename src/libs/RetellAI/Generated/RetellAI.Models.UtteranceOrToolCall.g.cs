#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UtteranceOrToolCall : global::System.IEquatable<UtteranceOrToolCall>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.Utterance? Utterance { get; init; }
#else
        public global::RetellAI.Utterance? Utterance { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Utterance))]
#endif
        public bool IsUtterance => Utterance != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ToolCallInvocationUtterance? Invocation { get; init; }
#else
        public global::RetellAI.ToolCallInvocationUtterance? Invocation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Invocation))]
#endif
        public bool IsInvocation => Invocation != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ToolCallResultUtterance? Result { get; init; }
#else
        public global::RetellAI.ToolCallResultUtterance? Result { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Result))]
#endif
        public bool IsResult => Result != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.NodeTransitionUtterance? NodeTransition { get; init; }
#else
        public global::RetellAI.NodeTransitionUtterance? NodeTransition { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeTransition))]
#endif
        public bool IsNodeTransition => NodeTransition != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.DTMFUtterance? Dtmf { get; init; }
#else
        public global::RetellAI.DTMFUtterance? Dtmf { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dtmf))]
#endif
        public bool IsDtmf => Dtmf != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UtteranceOrToolCall(global::RetellAI.Utterance value) => new UtteranceOrToolCall((global::RetellAI.Utterance?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.Utterance?(UtteranceOrToolCall @this) => @this.Utterance;

        /// <summary>
        /// 
        /// </summary>
        public UtteranceOrToolCall(global::RetellAI.Utterance? value)
        {
            Utterance = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UtteranceOrToolCall(global::RetellAI.ToolCallInvocationUtterance value) => new UtteranceOrToolCall((global::RetellAI.ToolCallInvocationUtterance?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ToolCallInvocationUtterance?(UtteranceOrToolCall @this) => @this.Invocation;

        /// <summary>
        /// 
        /// </summary>
        public UtteranceOrToolCall(global::RetellAI.ToolCallInvocationUtterance? value)
        {
            Invocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UtteranceOrToolCall(global::RetellAI.ToolCallResultUtterance value) => new UtteranceOrToolCall((global::RetellAI.ToolCallResultUtterance?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ToolCallResultUtterance?(UtteranceOrToolCall @this) => @this.Result;

        /// <summary>
        /// 
        /// </summary>
        public UtteranceOrToolCall(global::RetellAI.ToolCallResultUtterance? value)
        {
            Result = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UtteranceOrToolCall(global::RetellAI.NodeTransitionUtterance value) => new UtteranceOrToolCall((global::RetellAI.NodeTransitionUtterance?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.NodeTransitionUtterance?(UtteranceOrToolCall @this) => @this.NodeTransition;

        /// <summary>
        /// 
        /// </summary>
        public UtteranceOrToolCall(global::RetellAI.NodeTransitionUtterance? value)
        {
            NodeTransition = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UtteranceOrToolCall(global::RetellAI.DTMFUtterance value) => new UtteranceOrToolCall((global::RetellAI.DTMFUtterance?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.DTMFUtterance?(UtteranceOrToolCall @this) => @this.Dtmf;

        /// <summary>
        /// 
        /// </summary>
        public UtteranceOrToolCall(global::RetellAI.DTMFUtterance? value)
        {
            Dtmf = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UtteranceOrToolCall(
            global::RetellAI.Utterance? utterance,
            global::RetellAI.ToolCallInvocationUtterance? invocation,
            global::RetellAI.ToolCallResultUtterance? result,
            global::RetellAI.NodeTransitionUtterance? nodeTransition,
            global::RetellAI.DTMFUtterance? dtmf
            )
        {
            Utterance = utterance;
            Invocation = invocation;
            Result = result;
            NodeTransition = nodeTransition;
            Dtmf = dtmf;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Dtmf as object ??
            NodeTransition as object ??
            Result as object ??
            Invocation as object ??
            Utterance as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Utterance?.ToString() ??
            Invocation?.ToString() ??
            Result?.ToString() ??
            NodeTransition?.ToString() ??
            Dtmf?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUtterance && !IsInvocation && !IsResult && !IsNodeTransition && !IsDtmf || !IsUtterance && IsInvocation && !IsResult && !IsNodeTransition && !IsDtmf || !IsUtterance && !IsInvocation && IsResult && !IsNodeTransition && !IsDtmf || !IsUtterance && !IsInvocation && !IsResult && IsNodeTransition && !IsDtmf || !IsUtterance && !IsInvocation && !IsResult && !IsNodeTransition && IsDtmf;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.Utterance?, TResult>? utterance = null,
            global::System.Func<global::RetellAI.ToolCallInvocationUtterance?, TResult>? invocation = null,
            global::System.Func<global::RetellAI.ToolCallResultUtterance?, TResult>? result = null,
            global::System.Func<global::RetellAI.NodeTransitionUtterance?, TResult>? nodeTransition = null,
            global::System.Func<global::RetellAI.DTMFUtterance?, TResult>? dtmf = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUtterance && utterance != null)
            {
                return utterance(Utterance!);
            }
            else if (IsInvocation && invocation != null)
            {
                return invocation(Invocation!);
            }
            else if (IsResult && result != null)
            {
                return result(Result!);
            }
            else if (IsNodeTransition && nodeTransition != null)
            {
                return nodeTransition(NodeTransition!);
            }
            else if (IsDtmf && dtmf != null)
            {
                return dtmf(Dtmf!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.Utterance?>? utterance = null,
            global::System.Action<global::RetellAI.ToolCallInvocationUtterance?>? invocation = null,
            global::System.Action<global::RetellAI.ToolCallResultUtterance?>? result = null,
            global::System.Action<global::RetellAI.NodeTransitionUtterance?>? nodeTransition = null,
            global::System.Action<global::RetellAI.DTMFUtterance?>? dtmf = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUtterance)
            {
                utterance?.Invoke(Utterance!);
            }
            else if (IsInvocation)
            {
                invocation?.Invoke(Invocation!);
            }
            else if (IsResult)
            {
                result?.Invoke(Result!);
            }
            else if (IsNodeTransition)
            {
                nodeTransition?.Invoke(NodeTransition!);
            }
            else if (IsDtmf)
            {
                dtmf?.Invoke(Dtmf!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Utterance,
                typeof(global::RetellAI.Utterance),
                Invocation,
                typeof(global::RetellAI.ToolCallInvocationUtterance),
                Result,
                typeof(global::RetellAI.ToolCallResultUtterance),
                NodeTransition,
                typeof(global::RetellAI.NodeTransitionUtterance),
                Dtmf,
                typeof(global::RetellAI.DTMFUtterance),
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
        public bool Equals(UtteranceOrToolCall other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.Utterance?>.Default.Equals(Utterance, other.Utterance) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ToolCallInvocationUtterance?>.Default.Equals(Invocation, other.Invocation) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ToolCallResultUtterance?>.Default.Equals(Result, other.Result) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.NodeTransitionUtterance?>.Default.Equals(NodeTransition, other.NodeTransition) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.DTMFUtterance?>.Default.Equals(Dtmf, other.Dtmf) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UtteranceOrToolCall obj1, UtteranceOrToolCall obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UtteranceOrToolCall>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UtteranceOrToolCall obj1, UtteranceOrToolCall obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UtteranceOrToolCall o && Equals(o);
        }
    }
}
