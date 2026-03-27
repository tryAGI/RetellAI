#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct NodeInstruction : global::System.IEquatable<NodeInstruction>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.NodeInstructionPrompt? Prompt { get; init; }
#else
        public global::RetellAI.NodeInstructionPrompt? Prompt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Prompt))]
#endif
        public bool IsPrompt => Prompt != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.NodeInstructionStaticText? StaticText { get; init; }
#else
        public global::RetellAI.NodeInstructionStaticText? StaticText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StaticText))]
#endif
        public bool IsStaticText => StaticText != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeInstruction(global::RetellAI.NodeInstructionPrompt value) => new NodeInstruction((global::RetellAI.NodeInstructionPrompt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.NodeInstructionPrompt?(NodeInstruction @this) => @this.Prompt;

        /// <summary>
        /// 
        /// </summary>
        public NodeInstruction(global::RetellAI.NodeInstructionPrompt? value)
        {
            Prompt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeInstruction(global::RetellAI.NodeInstructionStaticText value) => new NodeInstruction((global::RetellAI.NodeInstructionStaticText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.NodeInstructionStaticText?(NodeInstruction @this) => @this.StaticText;

        /// <summary>
        /// 
        /// </summary>
        public NodeInstruction(global::RetellAI.NodeInstructionStaticText? value)
        {
            StaticText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public NodeInstruction(
            global::RetellAI.NodeInstructionPrompt? prompt,
            global::RetellAI.NodeInstructionStaticText? staticText
            )
        {
            Prompt = prompt;
            StaticText = staticText;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StaticText as object ??
            Prompt as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Prompt?.ToString() ??
            StaticText?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPrompt && !IsStaticText || !IsPrompt && IsStaticText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.NodeInstructionPrompt?, TResult>? prompt = null,
            global::System.Func<global::RetellAI.NodeInstructionStaticText?, TResult>? staticText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPrompt && prompt != null)
            {
                return prompt(Prompt!);
            }
            else if (IsStaticText && staticText != null)
            {
                return staticText(StaticText!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.NodeInstructionPrompt?>? prompt = null,
            global::System.Action<global::RetellAI.NodeInstructionStaticText?>? staticText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPrompt)
            {
                prompt?.Invoke(Prompt!);
            }
            else if (IsStaticText)
            {
                staticText?.Invoke(StaticText!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Prompt,
                typeof(global::RetellAI.NodeInstructionPrompt),
                StaticText,
                typeof(global::RetellAI.NodeInstructionStaticText),
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
        public bool Equals(NodeInstruction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.NodeInstructionPrompt?>.Default.Equals(Prompt, other.Prompt) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.NodeInstructionStaticText?>.Default.Equals(StaticText, other.StaticText) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(NodeInstruction obj1, NodeInstruction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NodeInstruction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(NodeInstruction obj1, NodeInstruction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NodeInstruction o && Equals(o);
        }
    }
}
