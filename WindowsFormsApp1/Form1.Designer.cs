namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericTextBox21 = new WindowsFormsApp1.NumericTextBox2();
            this.numericTextBox11 = new WindowsFormsApp1.NumericTextBox1();
            this.numericTextBox31 = new WindowsFormsApp1.NumericTextBox3();
            this.SuspendLayout();
            // 
            // numericTextBox21
            // 
            this.numericTextBox21.Location = new System.Drawing.Point(51, 120);
            this.numericTextBox21.Name = "numericTextBox21";
            this.numericTextBox21.Size = new System.Drawing.Size(389, 38);
            this.numericTextBox21.TabIndex = 1;
            // 
            // numericTextBox11
            // 
            this.numericTextBox11.Location = new System.Drawing.Point(51, 50);
            this.numericTextBox11.Name = "numericTextBox11";
            this.numericTextBox11.Size = new System.Drawing.Size(389, 38);
            this.numericTextBox11.TabIndex = 0;
            // 
            // numericTextBox31
            // 
            this.numericTextBox31.Location = new System.Drawing.Point(51, 200);
            this.numericTextBox31.Name = "numericTextBox31";
            this.numericTextBox31.Size = new System.Drawing.Size(389, 38);
            this.numericTextBox31.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 342);
            this.Controls.Add(this.numericTextBox31);
            this.Controls.Add(this.numericTextBox21);
            this.Controls.Add(this.numericTextBox11);
            this.Name = "Form1";
            this.Text = "Numeric TextBox Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericTextBox1 numericTextBox11;
        private NumericTextBox2 numericTextBox21;
        private NumericTextBox3 numericTextBox31;
    }
}

