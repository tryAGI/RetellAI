#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CodeNode : global::System.IEquatable<CodeNode>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.NodeBase? Base { get; init; }
#else
        public global::RetellAI.NodeBase? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.CodeNodeVariant2? CodeNodeVariant2 { get; init; }
#else
        public global::RetellAI.CodeNodeVariant2? CodeNodeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeNodeVariant2))]
#endif
        public bool IsCodeNodeVariant2 => CodeNodeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CodeNode(global::RetellAI.NodeBase value) => new CodeNode((global::RetellAI.NodeBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.NodeBase?(CodeNode @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public CodeNode(global::RetellAI.NodeBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CodeNode(global::RetellAI.CodeNodeVariant2 value) => new CodeNode((global::RetellAI.CodeNodeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.CodeNodeVariant2?(CodeNode @this) => @this.CodeNodeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CodeNode(global::RetellAI.CodeNodeVariant2? value)
        {
            CodeNodeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CodeNode(
            global::RetellAI.NodeBase? @base,
            global::RetellAI.CodeNodeVariant2? codeNodeVariant2
            )
        {
            Base = @base;
            CodeNodeVariant2 = codeNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CodeNodeVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CodeNodeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCodeNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.NodeBase?, TResult>? @base = null,
            global::System.Func<global::RetellAI.CodeNodeVariant2?, TResult>? codeNodeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsCodeNodeVariant2 && codeNodeVariant2 != null)
            {
                return codeNodeVariant2(CodeNodeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.NodeBase?>? @base = null,
            global::System.Action<global::RetellAI.CodeNodeVariant2?>? codeNodeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsCodeNodeVariant2)
            {
                codeNodeVariant2?.Invoke(CodeNodeVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::RetellAI.NodeBase),
                CodeNodeVariant2,
                typeof(global::RetellAI.CodeNodeVariant2),
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
        public bool Equals(CodeNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.NodeBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.CodeNodeVariant2?>.Default.Equals(CodeNodeVariant2, other.CodeNodeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CodeNode obj1, CodeNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CodeNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CodeNode obj1, CodeNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CodeNode o && Equals(o);
        }
    }
}
