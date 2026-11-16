#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// A form item the user answers, discriminated by `kind`.
    /// </summary>
    public readonly partial struct ConductorFormField : global::System.IEquatable<ConductorFormField>
    {
        /// <summary>
        /// Options listed as radio buttons, or checkboxes with `multi_select`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConductorFormChoiceField? Choice { get; init; }
#else
        public global::RetellAI.ConductorFormChoiceField? Choice { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Choice))]
#endif
        public bool IsChoice => Choice != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChoice(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorFormChoiceField? value)
        {
            value = Choice;
            return IsChoice;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormChoiceField PickChoice() => Choice is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Choice' but the value was {ToString()}.");

        /// <summary>
        /// Dropdown with one answer.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConductorFormSelectField? Select { get; init; }
#else
        public global::RetellAI.ConductorFormSelectField? Select { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Select))]
#endif
        public bool IsSelect => Select != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSelect(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorFormSelectField? value)
        {
            value = Select;
            return IsSelect;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormSelectField PickSelect() => Select is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Select' but the value was {ToString()}.");

        /// <summary>
        /// Single-line text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConductorFormTextField? Text { get; init; }
#else
        public global::RetellAI.ConductorFormTextField? Text { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorFormTextField? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextField PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// Multi-line text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConductorFormTextareaField? Textarea { get; init; }
#else
        public global::RetellAI.ConductorFormTextareaField? Textarea { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Textarea))]
#endif
        public bool IsTextarea => Textarea != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextarea(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorFormTextareaField? value)
        {
            value = Textarea;
            return IsTextarea;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTextareaField PickTextarea() => Textarea is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Textarea' but the value was {ToString()}.");

        /// <summary>
        /// A number.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConductorFormNumberField? Number { get; init; }
#else
        public global::RetellAI.ConductorFormNumberField? Number { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Number))]
#endif
        public bool IsNumber => Number != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNumber(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorFormNumberField? value)
        {
            value = Number;
            return IsNumber;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormNumberField PickNumber() => Number is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Number' but the value was {ToString()}.");

        /// <summary>
        /// On/off toggle. Always answered, so it has no `required`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConductorFormSwitchField? SwitchValue { get; init; }
#else
        public global::RetellAI.ConductorFormSwitchField? SwitchValue { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SwitchValue))]
#endif
        public bool IsSwitchValue => SwitchValue != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSwitchValue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorFormSwitchField? value)
        {
            value = SwitchValue;
            return IsSwitchValue;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormSwitchField PickSwitchValue() => SwitchValue is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SwitchValue' but the value was {ToString()}.");

        /// <summary>
        /// A time of day. The answer includes the time zone the user picked.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConductorFormTimeField? Time { get; init; }
#else
        public global::RetellAI.ConductorFormTimeField? Time { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Time))]
#endif
        public bool IsTime => Time != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTime(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorFormTimeField? value)
        {
            value = Time;
            return IsTime;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormTimeField PickTime() => Time is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Time' but the value was {ToString()}.");

        /// <summary>
        /// A start and end date.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConductorFormDateRangeField? DateRange { get; init; }
#else
        public global::RetellAI.ConductorFormDateRangeField? DateRange { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DateRange))]
#endif
        public bool IsDateRange => DateRange != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDateRange(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorFormDateRangeField? value)
        {
            value = DateRange;
            return IsDateRange;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormDateRangeField PickDateRange() => DateRange is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DateRange' but the value was {ToString()}.");

        /// <summary>
        /// File upload. The user can attach several files, and Conductor receives them to read.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ConductorFormFileField? File { get; init; }
#else
        public global::RetellAI.ConductorFormFileField? File { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ConductorFormFileField? value)
        {
            value = File;
            return IsFile;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.ConductorFormFileField PickFile() => File is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'File' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormField(global::RetellAI.ConductorFormChoiceField value) => new ConductorFormField((global::RetellAI.ConductorFormChoiceField?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormChoiceField?(ConductorFormField @this) => @this.Choice;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormField(global::RetellAI.ConductorFormChoiceField? value)
        {
            Choice = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormField FromChoice(global::RetellAI.ConductorFormChoiceField? value) => new ConductorFormField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormField(global::RetellAI.ConductorFormSelectField value) => new ConductorFormField((global::RetellAI.ConductorFormSelectField?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormSelectField?(ConductorFormField @this) => @this.Select;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormField(global::RetellAI.ConductorFormSelectField? value)
        {
            Select = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormField FromSelect(global::RetellAI.ConductorFormSelectField? value) => new ConductorFormField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormField(global::RetellAI.ConductorFormTextField value) => new ConductorFormField((global::RetellAI.ConductorFormTextField?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormTextField?(ConductorFormField @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormField(global::RetellAI.ConductorFormTextField? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormField FromText(global::RetellAI.ConductorFormTextField? value) => new ConductorFormField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormField(global::RetellAI.ConductorFormTextareaField value) => new ConductorFormField((global::RetellAI.ConductorFormTextareaField?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormTextareaField?(ConductorFormField @this) => @this.Textarea;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormField(global::RetellAI.ConductorFormTextareaField? value)
        {
            Textarea = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormField FromTextarea(global::RetellAI.ConductorFormTextareaField? value) => new ConductorFormField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormField(global::RetellAI.ConductorFormNumberField value) => new ConductorFormField((global::RetellAI.ConductorFormNumberField?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormNumberField?(ConductorFormField @this) => @this.Number;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormField(global::RetellAI.ConductorFormNumberField? value)
        {
            Number = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormField FromNumber(global::RetellAI.ConductorFormNumberField? value) => new ConductorFormField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormField(global::RetellAI.ConductorFormSwitchField value) => new ConductorFormField((global::RetellAI.ConductorFormSwitchField?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormSwitchField?(ConductorFormField @this) => @this.SwitchValue;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormField(global::RetellAI.ConductorFormSwitchField? value)
        {
            SwitchValue = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormField FromSwitchValue(global::RetellAI.ConductorFormSwitchField? value) => new ConductorFormField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormField(global::RetellAI.ConductorFormTimeField value) => new ConductorFormField((global::RetellAI.ConductorFormTimeField?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormTimeField?(ConductorFormField @this) => @this.Time;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormField(global::RetellAI.ConductorFormTimeField? value)
        {
            Time = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormField FromTime(global::RetellAI.ConductorFormTimeField? value) => new ConductorFormField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormField(global::RetellAI.ConductorFormDateRangeField value) => new ConductorFormField((global::RetellAI.ConductorFormDateRangeField?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormDateRangeField?(ConductorFormField @this) => @this.DateRange;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormField(global::RetellAI.ConductorFormDateRangeField? value)
        {
            DateRange = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormField FromDateRange(global::RetellAI.ConductorFormDateRangeField? value) => new ConductorFormField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConductorFormField(global::RetellAI.ConductorFormFileField value) => new ConductorFormField((global::RetellAI.ConductorFormFileField?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.ConductorFormFileField?(ConductorFormField @this) => @this.File;

        /// <summary>
        ///
        /// </summary>
        public ConductorFormField(global::RetellAI.ConductorFormFileField? value)
        {
            File = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConductorFormField FromFile(global::RetellAI.ConductorFormFileField? value) => new ConductorFormField(value);

        /// <summary>
        ///
        /// </summary>
        public ConductorFormField(
            global::RetellAI.ConductorFormChoiceField? choice,
            global::RetellAI.ConductorFormSelectField? select,
            global::RetellAI.ConductorFormTextField? text,
            global::RetellAI.ConductorFormTextareaField? textarea,
            global::RetellAI.ConductorFormNumberField? number,
            global::RetellAI.ConductorFormSwitchField? switchValue,
            global::RetellAI.ConductorFormTimeField? time,
            global::RetellAI.ConductorFormDateRangeField? dateRange,
            global::RetellAI.ConductorFormFileField? file
            )
        {
            Choice = choice;
            Select = select;
            Text = text;
            Textarea = textarea;
            Number = number;
            SwitchValue = switchValue;
            Time = time;
            DateRange = dateRange;
            File = file;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            File as object ??
            DateRange as object ??
            Time as object ??
            SwitchValue as object ??
            Number as object ??
            Textarea as object ??
            Text as object ??
            Select as object ??
            Choice as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Choice?.ToString() ??
            Select?.ToString() ??
            Text?.ToString() ??
            Textarea?.ToString() ??
            Number?.ToString() ??
            SwitchValue?.ToString() ??
            Time?.ToString() ??
            DateRange?.ToString() ??
            File?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsChoice && !IsSelect && !IsText && !IsTextarea && !IsNumber && !IsSwitchValue && !IsTime && !IsDateRange && !IsFile || !IsChoice && IsSelect && !IsText && !IsTextarea && !IsNumber && !IsSwitchValue && !IsTime && !IsDateRange && !IsFile || !IsChoice && !IsSelect && IsText && !IsTextarea && !IsNumber && !IsSwitchValue && !IsTime && !IsDateRange && !IsFile || !IsChoice && !IsSelect && !IsText && IsTextarea && !IsNumber && !IsSwitchValue && !IsTime && !IsDateRange && !IsFile || !IsChoice && !IsSelect && !IsText && !IsTextarea && IsNumber && !IsSwitchValue && !IsTime && !IsDateRange && !IsFile || !IsChoice && !IsSelect && !IsText && !IsTextarea && !IsNumber && IsSwitchValue && !IsTime && !IsDateRange && !IsFile || !IsChoice && !IsSelect && !IsText && !IsTextarea && !IsNumber && !IsSwitchValue && IsTime && !IsDateRange && !IsFile || !IsChoice && !IsSelect && !IsText && !IsTextarea && !IsNumber && !IsSwitchValue && !IsTime && IsDateRange && !IsFile || !IsChoice && !IsSelect && !IsText && !IsTextarea && !IsNumber && !IsSwitchValue && !IsTime && !IsDateRange && IsFile;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.ConductorFormChoiceField?, TResult>? choice = null,
            global::System.Func<global::RetellAI.ConductorFormSelectField?, TResult>? select = null,
            global::System.Func<global::RetellAI.ConductorFormTextField?, TResult>? text = null,
            global::System.Func<global::RetellAI.ConductorFormTextareaField?, TResult>? textarea = null,
            global::System.Func<global::RetellAI.ConductorFormNumberField?, TResult>? number = null,
            global::System.Func<global::RetellAI.ConductorFormSwitchField?, TResult>? switchValue = null,
            global::System.Func<global::RetellAI.ConductorFormTimeField?, TResult>? time = null,
            global::System.Func<global::RetellAI.ConductorFormDateRangeField?, TResult>? dateRange = null,
            global::System.Func<global::RetellAI.ConductorFormFileField?, TResult>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Choice is { } __value0 && choice != null)
            {
                return choice(__value0);
            }
            else if (Select is { } __value1 && select != null)
            {
                return select(__value1);
            }
            else if (Text is { } __value2 && text != null)
            {
                return text(__value2);
            }
            else if (Textarea is { } __value3 && textarea != null)
            {
                return textarea(__value3);
            }
            else if (Number is { } __value4 && number != null)
            {
                return number(__value4);
            }
            else if (SwitchValue is { } __value5 && switchValue != null)
            {
                return switchValue(__value5);
            }
            else if (Time is { } __value6 && time != null)
            {
                return time(__value6);
            }
            else if (DateRange is { } __value7 && dateRange != null)
            {
                return dateRange(__value7);
            }
            else if (File is { } __value8 && file != null)
            {
                return file(__value8);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.ConductorFormChoiceField?>? choice = null,

            global::System.Action<global::RetellAI.ConductorFormSelectField?>? select = null,

            global::System.Action<global::RetellAI.ConductorFormTextField?>? text = null,

            global::System.Action<global::RetellAI.ConductorFormTextareaField?>? textarea = null,

            global::System.Action<global::RetellAI.ConductorFormNumberField?>? number = null,

            global::System.Action<global::RetellAI.ConductorFormSwitchField?>? switchValue = null,

            global::System.Action<global::RetellAI.ConductorFormTimeField?>? time = null,

            global::System.Action<global::RetellAI.ConductorFormDateRangeField?>? dateRange = null,

            global::System.Action<global::RetellAI.ConductorFormFileField?>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Choice is { } __value0)
            {
                choice?.Invoke(__value0);
            }
            else if (Select is { } __value1)
            {
                select?.Invoke(__value1);
            }
            else if (Text is { } __value2)
            {
                text?.Invoke(__value2);
            }
            else if (Textarea is { } __value3)
            {
                textarea?.Invoke(__value3);
            }
            else if (Number is { } __value4)
            {
                number?.Invoke(__value4);
            }
            else if (SwitchValue is { } __value5)
            {
                switchValue?.Invoke(__value5);
            }
            else if (Time is { } __value6)
            {
                time?.Invoke(__value6);
            }
            else if (DateRange is { } __value7)
            {
                dateRange?.Invoke(__value7);
            }
            else if (File is { } __value8)
            {
                file?.Invoke(__value8);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.ConductorFormChoiceField?>? choice = null,
            global::System.Action<global::RetellAI.ConductorFormSelectField?>? select = null,
            global::System.Action<global::RetellAI.ConductorFormTextField?>? text = null,
            global::System.Action<global::RetellAI.ConductorFormTextareaField?>? textarea = null,
            global::System.Action<global::RetellAI.ConductorFormNumberField?>? number = null,
            global::System.Action<global::RetellAI.ConductorFormSwitchField?>? switchValue = null,
            global::System.Action<global::RetellAI.ConductorFormTimeField?>? time = null,
            global::System.Action<global::RetellAI.ConductorFormDateRangeField?>? dateRange = null,
            global::System.Action<global::RetellAI.ConductorFormFileField?>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Choice is { } __value0)
            {
                choice?.Invoke(__value0);
            }
            else if (Select is { } __value1)
            {
                select?.Invoke(__value1);
            }
            else if (Text is { } __value2)
            {
                text?.Invoke(__value2);
            }
            else if (Textarea is { } __value3)
            {
                textarea?.Invoke(__value3);
            }
            else if (Number is { } __value4)
            {
                number?.Invoke(__value4);
            }
            else if (SwitchValue is { } __value5)
            {
                switchValue?.Invoke(__value5);
            }
            else if (Time is { } __value6)
            {
                time?.Invoke(__value6);
            }
            else if (DateRange is { } __value7)
            {
                dateRange?.Invoke(__value7);
            }
            else if (File is { } __value8)
            {
                file?.Invoke(__value8);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Choice,
                typeof(global::RetellAI.ConductorFormChoiceField),
                Select,
                typeof(global::RetellAI.ConductorFormSelectField),
                Text,
                typeof(global::RetellAI.ConductorFormTextField),
                Textarea,
                typeof(global::RetellAI.ConductorFormTextareaField),
                Number,
                typeof(global::RetellAI.ConductorFormNumberField),
                SwitchValue,
                typeof(global::RetellAI.ConductorFormSwitchField),
                Time,
                typeof(global::RetellAI.ConductorFormTimeField),
                DateRange,
                typeof(global::RetellAI.ConductorFormDateRangeField),
                File,
                typeof(global::RetellAI.ConductorFormFileField),
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
        public bool Equals(ConductorFormField other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormChoiceField?>.Default.Equals(Choice, other.Choice) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormSelectField?>.Default.Equals(Select, other.Select) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormTextField?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormTextareaField?>.Default.Equals(Textarea, other.Textarea) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormNumberField?>.Default.Equals(Number, other.Number) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormSwitchField?>.Default.Equals(SwitchValue, other.SwitchValue) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormTimeField?>.Default.Equals(Time, other.Time) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormDateRangeField?>.Default.Equals(DateRange, other.DateRange) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ConductorFormFileField?>.Default.Equals(File, other.File)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ConductorFormField obj1, ConductorFormField obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConductorFormField>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ConductorFormField obj1, ConductorFormField obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConductorFormField o && Equals(o);
        }
    }
}
