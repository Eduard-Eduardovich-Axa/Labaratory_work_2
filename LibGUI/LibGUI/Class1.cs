using System;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace LibGUI
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
}
