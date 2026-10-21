#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct NullableBackupModelRef : global::System.IEquatable<NullableBackupModelRef>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.BackupModelRef? BackupModelRef { get; init; }
#else
        public global::RetellAI.BackupModelRef? BackupModelRef { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BackupModelRef))]
#endif
        public bool IsBackupModelRef => BackupModelRef != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBackupModelRef(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.BackupModelRef? value)
        {
            value = BackupModelRef;
            return IsBackupModelRef;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.BackupModelRef PickBackupModelRef() => BackupModelRef is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BackupModelRef' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? NullableBackupModelRefVariant2 { get; init; }
#else
        public object? NullableBackupModelRefVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NullableBackupModelRefVariant2))]
#endif
        public bool IsNullableBackupModelRefVariant2 => NullableBackupModelRefVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNullableBackupModelRefVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = NullableBackupModelRefVariant2;
            return IsNullableBackupModelRefVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickNullableBackupModelRefVariant2() => NullableBackupModelRefVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NullableBackupModelRefVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator NullableBackupModelRef(global::RetellAI.BackupModelRef value) => new NullableBackupModelRef((global::RetellAI.BackupModelRef?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.BackupModelRef?(NullableBackupModelRef @this) => @this.BackupModelRef;

        /// <summary>
        ///
        /// </summary>
        public NullableBackupModelRef(global::RetellAI.BackupModelRef? value)
        {
            BackupModelRef = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NullableBackupModelRef FromBackupModelRef(global::RetellAI.BackupModelRef? value) => new NullableBackupModelRef(value);

        /// <summary>
        ///
        /// </summary>
        public NullableBackupModelRef(
            global::RetellAI.BackupModelRef? backupModelRef,
            object? nullableBackupModelRefVariant2
            )
        {
            BackupModelRef = backupModelRef;
            NullableBackupModelRefVariant2 = nullableBackupModelRefVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            NullableBackupModelRefVariant2 as object ??
            BackupModelRef as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BackupModelRef?.ToString() ??
            NullableBackupModelRefVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBackupModelRef && !IsNullableBackupModelRefVariant2 || !IsBackupModelRef && IsNullableBackupModelRefVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.BackupModelRef, TResult>? backupModelRef = null,
            global::System.Func<object, TResult>? nullableBackupModelRefVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BackupModelRef is { } __value0 && backupModelRef != null)
            {
                return backupModelRef(__value0);
            }
            else if (NullableBackupModelRefVariant2 is { } __value1 && nullableBackupModelRefVariant2 != null)
            {
                return nullableBackupModelRefVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.BackupModelRef>? backupModelRef = null,

            global::System.Action<object>? nullableBackupModelRefVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BackupModelRef is { } __value0)
            {
                backupModelRef?.Invoke(__value0);
            }
            else if (NullableBackupModelRefVariant2 is { } __value1)
            {
                nullableBackupModelRefVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.BackupModelRef>? backupModelRef = null,
            global::System.Action<object>? nullableBackupModelRefVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BackupModelRef is { } __value0)
            {
                backupModelRef?.Invoke(__value0);
            }
            else if (NullableBackupModelRefVariant2 is { } __value1)
            {
                nullableBackupModelRefVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BackupModelRef,
                typeof(global::RetellAI.BackupModelRef),
                NullableBackupModelRefVariant2,
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
        public bool Equals(NullableBackupModelRef other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.BackupModelRef?>.Default.Equals(BackupModelRef, other.BackupModelRef) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(NullableBackupModelRefVariant2, other.NullableBackupModelRefVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(NullableBackupModelRef obj1, NullableBackupModelRef obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NullableBackupModelRef>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(NullableBackupModelRef obj1, NullableBackupModelRef obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NullableBackupModelRef o && Equals(o);
        }
    }
}
