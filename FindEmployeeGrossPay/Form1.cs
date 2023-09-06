using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FindEmployeeGrossPay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hourlyRate = double.Parse(textBox1.Text);
            double hoursWorked = double.Parse(textBox2.Text);

            double GrossPay = hourlyRate * hoursWorked;

            textBox3.Text = GrossPay.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}