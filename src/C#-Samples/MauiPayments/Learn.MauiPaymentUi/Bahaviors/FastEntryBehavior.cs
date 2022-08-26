namespace Learn.MauiPaymentUi.Bahaviors
{
    /// <summary>
    ///   Fast Entry Behavior
    ///   Ref: https://github.com/shiwankaswe/XamarinFastEntry
    /// </summary>
    public class FastEntryBehavior : Behavior<Entry>
    {
        ////public bool? IsAmount { get; set; }
        ////public bool? IsNumeric { get; set; }
        ////public bool? IsNumericWithSpace { get; set; }

        public string Mask { get; set; }

        public int? MaxLength { get; set; }

        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(bindable);
        }

        private void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            var entry = (Entry)sender;
            var oldString = args.OldTextValue;
            var newString = args.NewTextValue;
            string entryText = entry.Text;

            if (MaxLength is not null && MaxLength >= 0 &&
                entryText is not null && entryText.Length > 0)
            {
                var output = ProcessLength(entryText, oldString, newString, MaxLength);
                if (output != entryText)
                {
                    entryText = output;
                    entry.Text = entryText;
                    return;
                }
            }

            if (Mask is not null && Mask.Length > 0 &&
                entryText is not null && entryText.Length > 0)
            {
                var output = ProcessMask(entryText, oldString, newString, Mask);
                if (output != entryText)
                {
                    entryText = output;
                    entry.Text = entryText;
                    return;
                }
            }

            ////if (IsNumeric != null && IsNumeric == true && entryText.Length > 0)
            ////{
            ////  var output = xamarinIsNumeric.ProcessIsNumeric(entryText, oldString, newString);
            ////  if (output != entryText)
            ////  {
            ////    entryText = output;
            ////    entry.Text = entryText;
            ////    return;
            ////  }
            ////}

            ////if (IsAmount != null && IsAmount == true && entryText.Length > 0)
            ////{
            ////  var output = xamarinIsAmount.ProcessIsAmount(entryText, oldString, newString);
            ////  if (output != entryText)
            ////  {
            ////    entryText = output;
            ////    entry.Text = entryText;
            ////    return;
            ////  }
            ////}

            ////if (IsNumericWithSpace != null && IsNumericWithSpace == true && entryText.Length > 0)
            ////{
            ////  var output = _xamarinIsNumericWithSpace.ProcessIsNumericWithSpace(entryText, oldString, newString);
            ////  if (output != entryText)
            ////  {
            ////    entryText = output;
            ////    entry.Text = entryText;
            ////    return;
            ////  }
            ////}

            entry.Text = entryText;
        }

        private string ProcessLength(string entryText, string oldString, string newString, int? maxLength)
        {
            string output = entryText;

            if (oldString != null)
            {
                if (newString.Length > oldString.Length)
                {
                    string hil = "";
                    if (oldString.Length > 0)
                        hil = entryText.Remove(0, entryText.Length - 1);
                    else
                        hil = newString;

                    // if Entry text is longer then valid length
                    if (entryText.Length > maxLength)
                    {
                        entryText = entryText.Remove(entryText.Length - 1); // remove last char

                        output = entryText;
                    }
                }
            }

            return output;
        }

        private string ProcessMask(string entryText, string oldString, string newString, string mask)
        {
            string output = entryText;

            if (oldString != null)
            {
                if (ReturnCheck(oldString, mask))
                {
                    if (newString.Length > oldString.Length)
                    {
                        if (mask.Length >= newString.Length)
                        {
                            var ln = entryText.Length - 1;
                            var st = mask.Substring(ln, 1);

                            string newstr;

                            if (oldString.Length > 0)
                                newstr = newString.Substring(newString.Length - 1);
                            else
                                newstr = newString;

                            if (output.Length > 1)
                                output = output.Remove(output.Length - 1, 1);
                            else
                                output = "";

                            if (st == "#")
                            {
                                output += newstr;
                            }
                            else
                            {
                                foreach (var s in mask.Substring(ln))
                                {
                                    if (s == '#')
                                    {
                                        output += newstr;
                                        break;
                                    }
                                    else
                                    {
                                        output += s;
                                    }
                                }
                            }
                        }
                        else
                        {
                            output = oldString;
                        }
                    }
                }
            }

            return output;
        }

        private bool ReturnCheck(string oldValue, string mask)
        {
            int i = 0;
            if (mask.Length < oldValue.Length)
                return false;

            foreach (var s in mask.Substring(0, oldValue.Length))
            {
                if (s.ToString() != "#" &&
                    s.ToString() != oldValue.Substring(i, 1))
                    return false;

                i++;
            }

            return true;
        }
    }
}
