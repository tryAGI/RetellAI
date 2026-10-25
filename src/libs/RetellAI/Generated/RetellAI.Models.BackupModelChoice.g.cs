#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Backup models are supported only for call agents. Response engines with a backup model cannot be used by chat agents.
    /// </summary>
    public readonly partial struct BackupModelChoice : global::System.IEquatable<BackupModelChoice>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ModelChoiceCascading? Cascading { get; init; }
#else
        public global::RetellAI.ModelChoiceCascading? Cascading { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Cascading))]
#endif
        public bool IsCascading => Cascading != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCascading(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ModelChoiceCascading? value)
        {
            value = Cascading;
            return IsCascading;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ModelChoiceCascading PickCascading() => Cascading is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Cascading' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.BackupModelChoiceVariant2? BackupModelChoiceVariant2 { get; init; }
#else
        public global::RetellAI.BackupModelChoiceVariant2? BackupModelChoiceVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BackupModelChoiceVariant2))]
#endif
        public bool IsBackupModelChoiceVariant2 => BackupModelChoiceVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBackupModelChoiceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.BackupModelChoiceVariant2? value)
        {
            value = BackupModelChoiceVariant2;
            return IsBackupModelChoiceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackupModelChoiceVariant2 PickBackupModelChoiceVariant2() => BackupModelChoiceVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BackupModelChoiceVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BackupModelChoice(global::RetellAI.ModelChoiceCascading value) => new BackupModelChoice((global::RetellAI.ModelChoiceCascading?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ModelChoiceCascading?(BackupModelChoice @this) => @this.Cascading;

        /// <summary>
        ///
        /// </summary>
        public BackupModelChoice(global::RetellAI.ModelChoiceCascading? value)
        {
            Cascading = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BackupModelChoice FromCascading(global::RetellAI.ModelChoiceCascading? value) => new BackupModelChoice(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BackupModelChoice(global::RetellAI.BackupModelChoiceVariant2 value) => new BackupModelChoice((global::RetellAI.BackupModelChoiceVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.BackupModelChoiceVariant2?(BackupModelChoice @this) => @this.BackupModelChoiceVariant2;

        /// <summary>
        ///
        /// </summary>
        public BackupModelChoice(global::RetellAI.BackupModelChoiceVariant2? value)
        {
            BackupModelChoiceVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BackupModelChoice FromBackupModelChoiceVariant2(global::RetellAI.BackupModelChoiceVariant2? value) => new BackupModelChoice(value);

        /// <summary>
        ///
        /// </summary>
        public BackupModelChoice(
            global::RetellAI.ModelChoiceCascading? cascading,
            global::RetellAI.BackupModelChoiceVariant2? backupModelChoiceVariant2
            )
        {
            Cascading = cascading;
            BackupModelChoiceVariant2 = backupModelChoiceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BackupModelChoiceVariant2 as object ??
            Cascading as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Cascading?.ToString() ??
            BackupModelChoiceVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCascading && IsBackupModelChoiceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ModelChoiceCascading, TResult>? cascading = null,
            global::System.Func<global::RetellAI.BackupModelChoiceVariant2, TResult>? backupModelChoiceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Cascading is { } __value0 && cascading != null)
            {
                return cascading(__value0);
            }
            else if (BackupModelChoiceVariant2 is { } __value1 && backupModelChoiceVariant2 != null)
            {
                return backupModelChoiceVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ModelChoiceCascading>? cascading = null,

            global::System.Action<global::RetellAI.BackupModelChoiceVariant2>? backupModelChoiceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Cascading is { } __value0)
            {
                cascading?.Invoke(__value0);
            }
            else if (BackupModelChoiceVariant2 is { } __value1)
            {
                backupModelChoiceVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ModelChoiceCascading>? cascading = null,
            global::System.Action<global::RetellAI.BackupModelChoiceVariant2>? backupModelChoiceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Cascading is { } __value0)
            {
                cascading?.Invoke(__value0);
            }
            else if (BackupModelChoiceVariant2 is { } __value1)
            {
                backupModelChoiceVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Cascading,
                typeof(global::RetellAI.ModelChoiceCascading),
                BackupModelChoiceVariant2,
                typeof(global::RetellAI.BackupModelChoiceVariant2),
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
        public bool Equals(BackupModelChoice other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ModelChoiceCascading?>.Default.Equals(Cascading, other.Cascading) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.BackupModelChoiceVariant2?>.Default.Equals(BackupModelChoiceVariant2, other.BackupModelChoiceVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BackupModelChoice obj1, BackupModelChoice obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BackupModelChoice>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BackupModelChoice obj1, BackupModelChoice obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BackupModelChoice o && Equals(o);
        }
    }
}
