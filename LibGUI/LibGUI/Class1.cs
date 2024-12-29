using System;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace LibGUI //test commit
{
    public class CustomButton : Button
    {
        public CustomButton()
        {
            this.Font = new Font("Arial", 12);
            this.Text = "кнопка";
            this.BackColor = Color.FromArgb(175, 238, 238);
        }
    }
    public class CustomTextBox : TextBox{
        public CustomTextBox(){
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Font = new Font("Arial", 12);
        }
    }

    public class CustomNumericUpDown : NumericUpDown
    {
        public CustomNumericUpDown()
        {
            this.BackColor = Color.FromArgb(175, 238, 238);
            this.Maximum = 10000;
            this.Minimum = 2;
        }
    }

    public class CustomLabel : Label
    {
        public CustomLabel()
        {
            this.Font = new Font("Arial", 10);
            this.AutoSize = true;
            this.ForeColor = Color.DarkBlue;
        }
    }
}
