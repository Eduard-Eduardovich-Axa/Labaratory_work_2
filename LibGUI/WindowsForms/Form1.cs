using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Lib1;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CustomButton button1 = new CustomButton();
            button1.Location = new Point(10, 50);
            button1.Text = "сюда тыкай";
            button1.AutoSize = true;
            this.Controls.Add(button1);

            CustomNumericUpDown textBox1 = new CustomNumericUpDown();
            textBox1.Location = new Point(10, 90);
            textBox1.Text = "adsd";
            this.Controls.Add(textBox1);

            CustomListBox ListBox1 = new CustomListBox();
            ListBox1.Location = new Point(10, 130);
            ListBox1.Items.Add(123);
            this.Controls.Add(ListBox1);

            button1.Click += (sender, e) => {
                int upperBound = (int)textBox1.Value;
                bool[] isPrime = new bool[upperBound + 1];
                for (int i = 2; i <= upperBound; i++) isPrime[i] = true;
                for (int p = 2; p * p <= upperBound; p++)
                    if (isPrime[p])
                        for (int i = p * p; i <= upperBound; i += p)
                            isPrime[i] = false;
                int[] primes = isPrime.Select((v, i) => new { v, i }).Where(x => x.v).Select(x => x.i).ToArray();
                ListBox1.Items.Clear();
                foreach (int i in primes)
                    ListBox1.Items.Add(i);
            };
        }
    }
}
