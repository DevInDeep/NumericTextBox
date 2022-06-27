using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class NumericTextBox1 : TextBox
    {
        public NumericTextBox1()
        {
            this.KeyPress += NumericTextBox1_KeyPress;
        }

        private void NumericTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if (e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }
    }
}
