﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Framework.WinForm.Controls.CustomControls
{
    public partial class NumericTextBox : RadTextBox
    {
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_PASTE = 0x0302;
        private int decimalNumbers;
        private bool hasNegatives;
        private string format;

        public delegate void D(NumericTextBox sender);
        /// <summary>
        /// Fired when Text changes
        /// </summary>
        public event D Changed = delegate { };

        /// <summary>
        /// Constructor of a NumericTextBox, with negative number and 2 decimals.
        /// </summary>
        public NumericTextBox()
            : this(2, true)
        {
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="decimalNumbers">number of decimals</param>
        /// <param name="hasNegatives">has negatives</param>
        public NumericTextBox(int decimalNumbers, bool hasNegatives)
            : base()
        {
            InitializeComponent();
            DecimalNumbers = decimalNumbers;
            HasNegatives = hasNegatives;
            Format = Format;
        }

        /// <summary>
        /// Property of decimalNumbers
        /// </summary>
        public int DecimalNumbers
        {
            get
            {
                return decimalNumbers;
            }
            set
            {
                decimalNumbers = value > 0 ? value : 0;
            }
        }

        /// <summary>
        /// Bindable Decimal Text
        /// </summary>
        public decimal DecimalText
        {
            get
            {
                if (string.IsNullOrEmpty(Text))
                    return 0;

                return Convert.ToDecimal(Text);
            }
            set { Text = value.ToString(); }
        }

        /// <summary>
        /// The string text value of the numeric text, use DecimalText to get the numeric value.
        /// </summary>
        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                Changed(this);
            }
        }

        /// <summary>
        /// Property of hasNegatives
        /// </summary>
        public bool HasNegatives
        {
            get
            {
                return hasNegatives;
            }
            set
            {
                hasNegatives = value;
            }
        }

        /// <summary>
        /// Property of format
        /// </summary>
        public string Format
        {
            get
            {
                return format;
            }
            set
            {
                format = "^";
                format += HasNegatives ? "(\\" + getNegativeSign() + "?)" : "";
                format += "(\\d*)";
                if (DecimalNumbers > 0)
                {
                    format += "(\\" + getDecimalSeparator() + "?)";
                    for (int i = 1; i <= DecimalNumbers; i++)
                    {
                        format += "(\\d?)";
                    }
                }
                format += "$";
            }
        }

        /// <summary>
        /// Method PreProcessMessage
        /// </summary>
        /// <param name="msg">ref Message</param>
        /// <returns>bool</returns>
        public override bool PreProcessMessage(ref Message msg)
        {
            if (msg.Msg == WM_KEYDOWN)
            {
                Keys keys = (Keys)msg.WParam.ToInt32();

                bool numbers = ModifierKeys != Keys.Shift
                                && (keys >= Keys.D0 && keys <= Keys.D9
                                    || (keys >= Keys.NumPad0 && keys <= Keys.NumPad9));


                bool dec = ModifierKeys != Keys.Shift
                            && (keys == Keys.Decimal
                                || keys == Keys.Oemcomma
                                || keys == Keys.OemPeriod);

                bool negativeSign = (keys == Keys.OemMinus && ModifierKeys != Keys.Shift)
                                    || keys == Keys.Subtract;

                bool home = keys == Keys.Home;
                bool end = keys == Keys.End;

                bool ctrlZ = keys == Keys.Z && ModifierKeys == Keys.Control;
                bool ctrlX = keys == Keys.X && ModifierKeys == Keys.Control;
                bool ctrlC = keys == Keys.C && ModifierKeys == Keys.Control;
                bool ctrlV = keys == Keys.V && ModifierKeys == Keys.Control;

                bool del = keys == Keys.Delete;
                bool bksp = keys == Keys.Back;

                bool tab = keys == Keys.Tab;

                bool arrows = keys == Keys.Up
                              || keys == Keys.Down
                              || keys == Keys.Left
                              || keys == Keys.Right;

                if (numbers || del || bksp || arrows || home || end
                    || ctrlC || ctrlX || ctrlV || ctrlZ)
                {
                    return false;
                }
                else
                {
                    if (dec)
                    {
                        return DecimalNumbers <= 0;
                    }
                    else
                    {
                        if (negativeSign)
                        {
                            return !HasNegatives;
                        }
                        else
                        {
                            if (tab)
                            {
                                return base.PreProcessMessage(ref msg);
                            }
                            else
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            else
            {
                return base.PreProcessMessage(ref msg);
            }
        }

        /// <summary>
        /// Method WndProc
        /// </summary>
        /// <param name="m">ref Message</param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_PASTE)
            {
                IDataObject obj = Clipboard.GetDataObject();
                string input = (string)obj.GetData(typeof(string));
                string pasteText = getPosibleText(input);

                if (!isValidadFormat(pasteText))
                {
                    m.Result = (IntPtr)0;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        /// <summary>
        /// Method OnKeyPress
        /// </summary>
        /// <param name="e">KeyPressEventArgs</param>
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            string keyInput = e.KeyChar.ToString();
            string inputText = getPosibleText(keyInput);

            if (Char.IsDigit(e.KeyChar)
                || keyInput.Equals(getDecimalSeparator())
                || keyInput.Equals(getNegativeSign()))
            {
                e.Handled = !isValidadFormat(inputText);
            }
            else if (e.KeyChar == '\b'
                    || e.KeyChar == '\t'
                    || keyInput.Equals(Keys.Delete.ToString())
                    || keyInput.Equals(Keys.Home.ToString())
                    || keyInput.Equals(Keys.End.ToString()))
            {
                //Allow backspace, tab, delete, home, end
            }
            else if (e.KeyChar == 26
                     || e.KeyChar == 24
                     || e.KeyChar == 3
                     || e.KeyChar == 22)
            {
                // 26 : Allow Ctrl+Z | 24 : Allow Ctrl+X
                //  3 : Allow Ctrl+C | 22 : Allow Ctrl+V
            }
            else
            {
                //Disallow
                e.Handled = true;
            }
        }

        /// <summary>
        /// Method OnTextChanged
        /// </summary>
        /// <param name="e">System.EventArgs</param>
        protected override void OnTextChanged(System.EventArgs e)
        {
            if (getFloatValue() < 0)
            {
                this.ForeColor = Color.Red;
            }
            else
            {
                this.ForeColor = Color.Black;
            }

            //If the decimal point is preceded by a no number is added zero
            if (this.Text.StartsWith(getNegativeSign() + getDecimalSeparator()))
            {
                this.Text = getNegativeSign() + "0" + this.Text.Substring(1);
                this.Select(3, 0);
            }
            else
            {
                if (this.Text.StartsWith(getDecimalSeparator()))
                {
                    this.Text = "0" + this.Text;
                    this.Select(2, 0);
                }
            }
            base.OnTextChanged(e);
        }

        /// <summary>
        /// Method for validate text with format
        /// </summary>
        /// <param name="text">text</param>
        /// <returns>is valid format</returns>
        private bool isValidadFormat(string text)
        {
            return Regex.IsMatch(text, Format);
        }

        /// <summary>
        /// Method for get deciamal separator
        /// </summary>
        /// <returns>Decimal Separator of current culture</returns>
        private string getDecimalSeparator()
        {
            return System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        }

        /// <summary>
        /// Method for get negative sign
        /// </summary>
        /// <returns>Negative Sign of current culture</returns>
        private string getNegativeSign()
        {
            return System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NegativeSign;
        }

        /// <summary>
        /// Method for get posible resulting text for input text
        /// </summary>
        /// <param name="text">string with input text</param>
        /// <returns>posible text</returns>
        private string getPosibleText(string text)
        {
            string rText;
            rText = this.Text.Substring(0, SelectionStart);
            rText += text;
            rText += this.Text.Substring(SelectionStart + SelectionLength);
            return rText;
        }

        /// <summary>
        /// Method for get int value of text
        /// </summary>
        /// <returns>int value</returns>
        public int getIntValue()
        {
            try
            {
                return (int)getFloatValue();
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Method for get round int value of text
        /// </summary>
        /// <returns>round int value</returns>
        public int getIntRoundValue()
        {
            try
            {
                return (int)Math.Round(getFloatValue());
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Method for get float value of text
        /// </summary>
        /// <returns>float value</returns>
        public float getFloatValue()
        {
            try
            {
                return float.Parse(this.Text);
            }
            catch
            {
                return 0;
            }
        }
    }
}
