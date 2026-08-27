#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct VoicemailAction : global::System.IEquatable<VoicemailAction>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.VoicemailActionPrompt? Prompt { get; init; }
#else
        public global::RetellAI.VoicemailActionPrompt? Prompt { get; }
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
        public bool TryPickPrompt(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.VoicemailActionPrompt? value)
        {
            value = Prompt;
            return IsPrompt;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionPrompt PickPrompt() => IsPrompt
            ? Prompt!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Prompt' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.VoicemailActionStaticText? StaticText { get; init; }
#else
        public global::RetellAI.VoicemailActionStaticText? StaticText { get; }
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
        public bool TryPickStaticText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.VoicemailActionStaticText? value)
        {
            value = StaticText;
            return IsStaticText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionStaticText PickStaticText() => IsStaticText
            ? StaticText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StaticText' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.VoicemailActionHangup? Hangup { get; init; }
#else
        public global::RetellAI.VoicemailActionHangup? Hangup { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Hangup))]
#endif
        public bool IsHangup => Hangup != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHangup(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.VoicemailActionHangup? value)
        {
            value = Hangup;
            return IsHangup;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionHangup PickHangup() => IsHangup
            ? Hangup!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Hangup' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.VoicemailActionBridgeTransfer? BridgeTransfer { get; init; }
#else
        public global::RetellAI.VoicemailActionBridgeTransfer? BridgeTransfer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BridgeTransfer))]
#endif
        public bool IsBridgeTransfer => BridgeTransfer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBridgeTransfer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.VoicemailActionBridgeTransfer? value)
        {
            value = BridgeTransfer;
            return IsBridgeTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.VoicemailActionBridgeTransfer PickBridgeTransfer() => IsBridgeTransfer
            ? BridgeTransfer!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BridgeTransfer' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator VoicemailAction(global::RetellAI.VoicemailActionPrompt value) => new VoicemailAction((global::RetellAI.VoicemailActionPrompt?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.VoicemailActionPrompt?(VoicemailAction @this) => @this.Prompt;

        /// <summary>
        ///
        /// </summary>
        public VoicemailAction(global::RetellAI.VoicemailActionPrompt? value)
        {
            Prompt = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VoicemailAction FromPrompt(global::RetellAI.VoicemailActionPrompt? value) => new VoicemailAction(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VoicemailAction(global::RetellAI.VoicemailActionStaticText value) => new VoicemailAction((global::RetellAI.VoicemailActionStaticText?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.VoicemailActionStaticText?(VoicemailAction @this) => @this.StaticText;

        /// <summary>
        ///
        /// </summary>
        public VoicemailAction(global::RetellAI.VoicemailActionStaticText? value)
        {
            StaticText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VoicemailAction FromStaticText(global::RetellAI.VoicemailActionStaticText? value) => new VoicemailAction(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VoicemailAction(global::RetellAI.VoicemailActionHangup value) => new VoicemailAction((global::RetellAI.VoicemailActionHangup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.VoicemailActionHangup?(VoicemailAction @this) => @this.Hangup;

        /// <summary>
        ///
        /// </summary>
        public VoicemailAction(global::RetellAI.VoicemailActionHangup? value)
        {
            Hangup = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VoicemailAction FromHangup(global::RetellAI.VoicemailActionHangup? value) => new VoicemailAction(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VoicemailAction(global::RetellAI.VoicemailActionBridgeTransfer value) => new VoicemailAction((global::RetellAI.VoicemailActionBridgeTransfer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.VoicemailActionBridgeTransfer?(VoicemailAction @this) => @this.BridgeTransfer;

        /// <summary>
        ///
        /// </summary>
        public VoicemailAction(global::RetellAI.VoicemailActionBridgeTransfer? value)
        {
            BridgeTransfer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VoicemailAction FromBridgeTransfer(global::RetellAI.VoicemailActionBridgeTransfer? value) => new VoicemailAction(value);

        /// <summary>
        ///
        /// </summary>
        public VoicemailAction(
            global::RetellAI.VoicemailActionPrompt? prompt,
            global::RetellAI.VoicemailActionStaticText? staticText,
            global::RetellAI.VoicemailActionHangup? hangup,
            global::RetellAI.VoicemailActionBridgeTransfer? bridgeTransfer
            )
        {
            Prompt = prompt;
            StaticText = staticText;
            Hangup = hangup;
            BridgeTransfer = bridgeTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BridgeTransfer as object ??
            Hangup as object ??
            StaticText as object ??
            Prompt as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Prompt?.ToString() ??
            StaticText?.ToString() ??
            Hangup?.ToString() ??
            BridgeTransfer?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPrompt && !IsStaticText && !IsHangup && !IsBridgeTransfer || !IsPrompt && IsStaticText && !IsHangup && !IsBridgeTransfer || !IsPrompt && !IsStaticText && IsHangup && !IsBridgeTransfer || !IsPrompt && !IsStaticText && !IsHangup && IsBridgeTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.VoicemailActionPrompt, TResult>? prompt = null,
            global::System.Func<global::RetellAI.VoicemailActionStaticText, TResult>? staticText = null,
            global::System.Func<global::RetellAI.VoicemailActionHangup, TResult>? hangup = null,
            global::System.Func<global::RetellAI.VoicemailActionBridgeTransfer, TResult>? bridgeTransfer = null,
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
            else if (IsHangup && hangup != null)
            {
                return hangup(Hangup!);
            }
            else if (IsBridgeTransfer && bridgeTransfer != null)
            {
                return bridgeTransfer(BridgeTransfer!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.VoicemailActionPrompt>? prompt = null,

            global::System.Action<global::RetellAI.VoicemailActionStaticText>? staticText = null,

            global::System.Action<global::RetellAI.VoicemailActionHangup>? hangup = null,

            global::System.Action<global::RetellAI.VoicemailActionBridgeTransfer>? bridgeTransfer = null,
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
            else if (IsHangup)
            {
                hangup?.Invoke(Hangup!);
            }
            else if (IsBridgeTransfer)
            {
                bridgeTransfer?.Invoke(BridgeTransfer!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.VoicemailActionPrompt>? prompt = null,
            global::System.Action<global::RetellAI.VoicemailActionStaticText>? staticText = null,
            global::System.Action<global::RetellAI.VoicemailActionHangup>? hangup = null,
            global::System.Action<global::RetellAI.VoicemailActionBridgeTransfer>? bridgeTransfer = null,
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
            else if (IsHangup)
            {
                hangup?.Invoke(Hangup!);
            }
            else if (IsBridgeTransfer)
            {
                bridgeTransfer?.Invoke(BridgeTransfer!);
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
                typeof(global::RetellAI.VoicemailActionPrompt),
                StaticText,
                typeof(global::RetellAI.VoicemailActionStaticText),
                Hangup,
                typeof(global::RetellAI.VoicemailActionHangup),
                BridgeTransfer,
                typeof(global::RetellAI.VoicemailActionBridgeTransfer),
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
        public bool Equals(VoicemailAction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.VoicemailActionPrompt?>.Default.Equals(Prompt, other.Prompt) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.VoicemailActionStaticText?>.Default.Equals(StaticText, other.StaticText) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.VoicemailActionHangup?>.Default.Equals(Hangup, other.Hangup) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.VoicemailActionBridgeTransfer?>.Default.Equals(BridgeTransfer, other.BridgeTransfer)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(VoicemailAction obj1, VoicemailAction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VoicemailAction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(VoicemailAction obj1, VoicemailAction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VoicemailAction o && Equals(o);
        }
    }
}
