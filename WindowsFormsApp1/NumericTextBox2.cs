using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class NumericTextBox2 : TextBox
    {
        public NumericTextBox2()
        {
            this.KeyPress += NumericTextBox2_KeyPress;
        }

        private void NumericTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!decimal.TryParse((sender as TextBox).Text + e.KeyChar, out decimal value))
                e.Handled = true;
        }
    }
}
