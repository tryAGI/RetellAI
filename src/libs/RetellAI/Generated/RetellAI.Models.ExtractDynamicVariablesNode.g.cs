#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ExtractDynamicVariablesNode : global::System.IEquatable<ExtractDynamicVariablesNode>
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
        public global::RetellAI.ExtractDynamicVariablesNodeVariant2? ExtractDynamicVariablesNodeVariant2 { get; init; }
#else
        public global::RetellAI.ExtractDynamicVariablesNodeVariant2? ExtractDynamicVariablesNodeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExtractDynamicVariablesNodeVariant2))]
#endif
        public bool IsExtractDynamicVariablesNodeVariant2 => ExtractDynamicVariablesNodeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExtractDynamicVariablesNode(global::RetellAI.NodeBase value) => new ExtractDynamicVariablesNode((global::RetellAI.NodeBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.NodeBase?(ExtractDynamicVariablesNode @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ExtractDynamicVariablesNode(global::RetellAI.NodeBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExtractDynamicVariablesNode(global::RetellAI.ExtractDynamicVariablesNodeVariant2 value) => new ExtractDynamicVariablesNode((global::RetellAI.ExtractDynamicVariablesNodeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ExtractDynamicVariablesNodeVariant2?(ExtractDynamicVariablesNode @this) => @this.ExtractDynamicVariablesNodeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ExtractDynamicVariablesNode(global::RetellAI.ExtractDynamicVariablesNodeVariant2? value)
        {
            ExtractDynamicVariablesNodeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ExtractDynamicVariablesNode(
            global::RetellAI.NodeBase? @base,
            global::RetellAI.ExtractDynamicVariablesNodeVariant2? extractDynamicVariablesNodeVariant2
            )
        {
            Base = @base;
            ExtractDynamicVariablesNodeVariant2 = extractDynamicVariablesNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ExtractDynamicVariablesNodeVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ExtractDynamicVariablesNodeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsExtractDynamicVariablesNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.NodeBase?, TResult>? @base = null,
            global::System.Func<global::RetellAI.ExtractDynamicVariablesNodeVariant2?, TResult>? extractDynamicVariablesNodeVariant2 = null,
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
            else if (IsExtractDynamicVariablesNodeVariant2 && extractDynamicVariablesNodeVariant2 != null)
            {
                return extractDynamicVariablesNodeVariant2(ExtractDynamicVariablesNodeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.NodeBase?>? @base = null,
            global::System.Action<global::RetellAI.ExtractDynamicVariablesNodeVariant2?>? extractDynamicVariablesNodeVariant2 = null,
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
            else if (IsExtractDynamicVariablesNodeVariant2)
            {
                extractDynamicVariablesNodeVariant2?.Invoke(ExtractDynamicVariablesNodeVariant2!);
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
                ExtractDynamicVariablesNodeVariant2,
                typeof(global::RetellAI.ExtractDynamicVariablesNodeVariant2),
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
        public bool Equals(ExtractDynamicVariablesNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.NodeBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ExtractDynamicVariablesNodeVariant2?>.Default.Equals(ExtractDynamicVariablesNodeVariant2, other.ExtractDynamicVariablesNodeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ExtractDynamicVariablesNode obj1, ExtractDynamicVariablesNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ExtractDynamicVariablesNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ExtractDynamicVariablesNode obj1, ExtractDynamicVariablesNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExtractDynamicVariablesNode o && Equals(o);
        }
    }
}
