using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class NumericTextBox3 : TextBox
    {
        public NumericTextBox3()
        {
            this.KeyPress += NumericTextBox3_KeyPress;
        }

        private void NumericTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch((sender as TextBox).Text + e.KeyChar, @"^[1-9]\d*[.]?(\d)?$"))
                e.Handled = true;
        }
    }
}
