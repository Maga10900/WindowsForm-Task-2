using System.Data;
using System.Globalization;
using System.Linq.Expressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public string Rqm_Text = "";
        public string Copy = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rqm_Text += "1";
            Calculate_TextBox.Text = Rqm_Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rqm_Text += "2";
            Calculate_TextBox.Text = Rqm_Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rqm_Text += "3";
            Calculate_TextBox.Text = Rqm_Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rqm_Text += "4";
            Calculate_TextBox.Text = Rqm_Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rqm_Text += "5";
            Calculate_TextBox.Text = Rqm_Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Rqm_Text += "6";
            Calculate_TextBox.Text = Rqm_Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Rqm_Text += "7";
            Calculate_TextBox.Text = Rqm_Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Rqm_Text += "8";
            Calculate_TextBox.Text = Rqm_Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Rqm_Text += "9";
            Calculate_TextBox.Text = Rqm_Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Rqm_Text += "0";
            Calculate_TextBox.Text = Rqm_Text;
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Rqm_Text = string.Empty;
            Calculate_TextBox.Text = Rqm_Text;
        }

        private void Toplama_Button_Click(object sender, EventArgs e)
        {
            if (!((Rqm_Text == string.Empty) || (Rqm_Text.Last() == '+') || (Rqm_Text.Last() == '-') || (Rqm_Text.Last() == '*') || (Rqm_Text.Last() == '/') || (Rqm_Text.Last() == '√') || (Rqm_Text.Last() == '%') || (Rqm_Text.Last() == '.')))
            {
                Rqm_Text += "+";
                Copy += Rqm_Text;
                Rqm_Text = string.Empty;
                Calculate_TextBox.Text = Rqm_Text;
            }
            else
            {
                Calculate_TextBox.Text = "Ugursuz Emeliyyat";
                Rqm_Text = string.Empty;
                Copy = string.Empty;
            }
        }
        private void Cixma_Button_Click(object sender, EventArgs e)
        {
            if (!((Rqm_Text == string.Empty) || (Rqm_Text.Last() == '+') || (Rqm_Text.Last() == '-') || (Rqm_Text.Last() == '*') || (Rqm_Text.Last() == '/') || (Rqm_Text.Last() == '√') || (Rqm_Text.Last() == '%') || (Rqm_Text.Last() == '.')))
            {
                Rqm_Text += "-";
                Copy += Rqm_Text;
                Rqm_Text = string.Empty;
                Calculate_TextBox.Text = Rqm_Text;
            }
            else
            {
                Calculate_TextBox.Text = "Ugursuz Emeliyyat";
                Rqm_Text = string.Empty;
                Copy = string.Empty;
            }
        }
        private void Vurma_Button_Click(object sender, EventArgs e)
        {
            if (!((Rqm_Text == string.Empty) || (Rqm_Text.Last() == '+') || (Rqm_Text.Last() == '-') || (Rqm_Text.Last() == '*') || (Rqm_Text.Last() == '/') || (Rqm_Text.Last() == '√') || (Rqm_Text.Last() == '%') || (Rqm_Text.Last() == '.')))
            {
                Rqm_Text += "*";
                Copy += Rqm_Text;
                Rqm_Text = string.Empty;
                Calculate_TextBox.Text = Rqm_Text;
            }
            else
            {
                Calculate_TextBox.Text = "Ugursuz Emeliyyat";
                Rqm_Text = string.Empty;
                Copy = string.Empty;
            }
        }
        private void Bolme_Button_Click(object sender, EventArgs e)
        {
            if (!((Rqm_Text == string.Empty) || (Rqm_Text.Last() == '+') || (Rqm_Text.Last() == '-') || (Rqm_Text.Last() == '*') || (Rqm_Text.Last() == '/') || (Rqm_Text.Last() == '√') || (Rqm_Text.Last() == '%') || (Rqm_Text.Last() == '.')))
            {
                Rqm_Text += "/";
                Copy += Rqm_Text;
                Rqm_Text = string.Empty;
                Calculate_TextBox.Text = Rqm_Text;
            }
            else
            {
                Calculate_TextBox.Text = "Ugursuz Emeliyyat";
                Rqm_Text = string.Empty;
                Copy = string.Empty;
            }
        }
        private void Beraber_Button_Click(object sender, EventArgs e)
        {
            if (!((Rqm_Text == string.Empty) || (Rqm_Text.Last() == '+') || (Rqm_Text.Last() == '-') || (Rqm_Text.Last() == '*') || (Rqm_Text.Last() == '/') || (Rqm_Text.Last() == '√') || (Rqm_Text.Last() == '%') || (Rqm_Text.Last() == '.')))
            {
                Copy += Rqm_Text;
                DataTable table = new DataTable();
                double result = Convert.ToDouble(table.Compute(Copy, ""));
                Calculate_TextBox.Text = result.ToString();

                Rqm_Text = string.Empty;
                Copy = string.Empty;


            }
            else
            {
                Calculate_TextBox.Text = "Ugursuz Emeliyyat";
                Rqm_Text = string.Empty;
                Copy = string.Empty;
            }
        }
        private void BackSpace_Button_Click(object sender, EventArgs e)
        {
            if (!((Rqm_Text == string.Empty) || (Rqm_Text.Last() == '+') || (Rqm_Text.Last() == '-') || (Rqm_Text.Last() == '*') || (Rqm_Text.Last() == '/') || (Rqm_Text.Last() == '√') || (Rqm_Text.Last() == '%') || (Rqm_Text.Last() == '.')))
            {
                Rqm_Text = Rqm_Text.Substring(0, Rqm_Text.Length - 1);
                Calculate_TextBox.Text = Rqm_Text;
            }
            else
            {
                Calculate_TextBox.Text = string.Empty;
            }

        }

        private void Kvadrat_Button_Click(object sender, EventArgs e)
        {
            if (!((Rqm_Text == string.Empty) || (Rqm_Text.Last() == '+') || (Rqm_Text.Last() == '-') || (Rqm_Text.Last() == '*') || (Rqm_Text.Last() == '/') || (Rqm_Text.Last() == '√') || (Rqm_Text.Last() == '%') || (Rqm_Text.Last() == '.')))
            {
                var a = int.Parse(Rqm_Text);
                var b = a * a;
                Rqm_Text = b.ToString();
                Copy += Rqm_Text;
                DataTable table = new DataTable();
                int result = Convert.ToInt32(table.Compute(Copy, ""));
                Calculate_TextBox.Text = result.ToString();
                Copy = string.Empty;

            }
            else
            {
                Calculate_TextBox.Text = "Ugursuz Emeliyyat";
            }
        }

        private void KokAlti_Button_Click(object sender, EventArgs e)
        {
            if (!((Rqm_Text == string.Empty) || (Rqm_Text.Last() == '+') || (Rqm_Text.Last() == '-') || (Rqm_Text.Last() == '*') || (Rqm_Text.Last() == '/') || (Rqm_Text.Last() == '√') || (Rqm_Text.Last() == '%') || (Rqm_Text.Last() == '.')))
            {
                var a = Math.Sqrt(double.Parse(Rqm_Text));
                Rqm_Text = a.ToString();
                Copy += Rqm_Text;
                DataTable table = new DataTable();
                int result = Convert.ToInt32(table.Compute(Copy, ""));
                Calculate_TextBox.Text = result.ToString();

                Rqm_Text = string.Empty;
                Copy = string.Empty;
            }
            else
            {
                Calculate_TextBox.Text = "Ugursuz Emeliyyat";
            }

        }



        private void Faiz_Button_Click(object sender, EventArgs e)
        {
            if (!((Rqm_Text == string.Empty) || (Rqm_Text.Last() == '+') || (Rqm_Text.Last() == '-') || (Rqm_Text.Last() == '*') || (Rqm_Text.Last() == '/') || (Rqm_Text.Last() == '√') || (Rqm_Text.Last() == '%') || (Rqm_Text.Last() == '.')))
            {

                Rqm_Text += "/100";
                Calculate_TextBox.Text = Rqm_Text;
            }
            else
            {
                Calculate_TextBox.Text = "Ugursuz Emeliyyat";
                Rqm_Text = string.Empty;
                Copy = string.Empty;
            }
        }

        private void Noqte_Button_Click(object sender, EventArgs e)
        {
            if (!((Rqm_Text == string.Empty) || (Rqm_Text.Last() == '+') || (Rqm_Text.Last() == '-') || (Rqm_Text.Last() == '*') || (Rqm_Text.Last() == '/') || (Rqm_Text.Last() == '√') || (Rqm_Text.Last() == '%') || (Rqm_Text.Last() == '.')))
            {
                Rqm_Text += ".";
                Copy += Rqm_Text;
                Rqm_Text = string.Empty;
                Calculate_TextBox.Text = Rqm_Text;
            }
            else
            {
                Calculate_TextBox.Text = "Ugursuz Emeliyyat";
                Rqm_Text = string.Empty;
                Copy = string.Empty;
            }
        }
    }
}
