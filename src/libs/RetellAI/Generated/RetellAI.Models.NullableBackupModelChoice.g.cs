#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct NullableBackupModelChoice : global::System.IEquatable<NullableBackupModelChoice>
    {
        /// <summary>
        /// Backup models are supported only for call agents. Response engines with a backup model cannot be used by chat agents.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.BackupModelChoice? BackupModelChoice { get; init; }
#else
        public global::RetellAI.BackupModelChoice? BackupModelChoice { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BackupModelChoice))]
#endif
        public bool IsBackupModelChoice => BackupModelChoice != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBackupModelChoice(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.BackupModelChoice? value)
        {
            value = BackupModelChoice;
            return IsBackupModelChoice;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackupModelChoice PickBackupModelChoice() => BackupModelChoice is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BackupModelChoice' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? NullableBackupModelChoiceVariant2 { get; init; }
#else
        public object? NullableBackupModelChoiceVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NullableBackupModelChoiceVariant2))]
#endif
        public bool IsNullableBackupModelChoiceVariant2 => NullableBackupModelChoiceVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNullableBackupModelChoiceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = NullableBackupModelChoiceVariant2;
            return IsNullableBackupModelChoiceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickNullableBackupModelChoiceVariant2() => NullableBackupModelChoiceVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NullableBackupModelChoiceVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator NullableBackupModelChoice(global::RetellAI.BackupModelChoice value) => new NullableBackupModelChoice((global::RetellAI.BackupModelChoice?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.BackupModelChoice?(NullableBackupModelChoice @this) => @this.BackupModelChoice;

        /// <summary>
        ///
        /// </summary>
        public NullableBackupModelChoice(global::RetellAI.BackupModelChoice? value)
        {
            BackupModelChoice = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NullableBackupModelChoice FromBackupModelChoice(global::RetellAI.BackupModelChoice? value) => new NullableBackupModelChoice(value);

        /// <summary>
        ///
        /// </summary>
        public NullableBackupModelChoice(
            global::RetellAI.BackupModelChoice? backupModelChoice,
            object? nullableBackupModelChoiceVariant2
            )
        {
            BackupModelChoice = backupModelChoice;
            NullableBackupModelChoiceVariant2 = nullableBackupModelChoiceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            NullableBackupModelChoiceVariant2 as object ??
            BackupModelChoice as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BackupModelChoice?.ToString() ??
            NullableBackupModelChoiceVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBackupModelChoice && !IsNullableBackupModelChoiceVariant2 || !IsBackupModelChoice && IsNullableBackupModelChoiceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.BackupModelChoice?, TResult>? backupModelChoice = null,
            global::System.Func<object, TResult>? nullableBackupModelChoiceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BackupModelChoice is { } __value0 && backupModelChoice != null)
            {
                return backupModelChoice(__value0);
            }
            else if (NullableBackupModelChoiceVariant2 is { } __value1 && nullableBackupModelChoiceVariant2 != null)
            {
                return nullableBackupModelChoiceVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.BackupModelChoice?>? backupModelChoice = null,

            global::System.Action<object>? nullableBackupModelChoiceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BackupModelChoice is { } __value0)
            {
                backupModelChoice?.Invoke(__value0);
            }
            else if (NullableBackupModelChoiceVariant2 is { } __value1)
            {
                nullableBackupModelChoiceVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.BackupModelChoice?>? backupModelChoice = null,
            global::System.Action<object>? nullableBackupModelChoiceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BackupModelChoice is { } __value0)
            {
                backupModelChoice?.Invoke(__value0);
            }
            else if (NullableBackupModelChoiceVariant2 is { } __value1)
            {
                nullableBackupModelChoiceVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BackupModelChoice,
                typeof(global::RetellAI.BackupModelChoice),
                NullableBackupModelChoiceVariant2,
                typeof(object),
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
        public bool Equals(NullableBackupModelChoice other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.BackupModelChoice?>.Default.Equals(BackupModelChoice, other.BackupModelChoice) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(NullableBackupModelChoiceVariant2, other.NullableBackupModelChoiceVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(NullableBackupModelChoice obj1, NullableBackupModelChoice obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NullableBackupModelChoice>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(NullableBackupModelChoice obj1, NullableBackupModelChoice obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NullableBackupModelChoice o && Equals(o);
        }
    }
}
