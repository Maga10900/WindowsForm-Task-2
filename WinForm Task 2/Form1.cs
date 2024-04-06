namespace WinForm_Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            RadioButton cins = new();
            if (!File.Exists(Ad_Text.Text))
            {
                foreach (var item in Cins_Panel.Controls)
                {
                    RadioButton a = item as RadioButton;
                    if (a.Checked)
                    {
                        cins = a;
                    }

                }
                User new_User = new(Ad_Text.Text, Soyad_Text.Text, Telefon_Text.Text, Peshe_Text.Text, Sheher_Text.Text, Olke_Text.Text, Dogum_ili.Value, cins.Text.ToString());
                Functions.WriteUserToJson(new_User);

                Ad_Text.Text = string.Empty;
                Soyad_Text.Text = string.Empty;
                Telefon_Text.Text= string.Empty;
                Peshe_Text.Text=string.Empty;
                Sheher_Text.Text = string.Empty;
                Olke_Text.Text = string.Empty;
                Dogum_ili.Value = DateTime.Now;
                if(radioButton1.Checked == true || radioButton2.Checked)
                {
                    radioButton3.Checked = true;
                }

            }
            else
            {
                Error_Label.Visible = true;
                Ad_Text.Text = string.Empty;
                Soyad_Text.Text = string.Empty;
                Telefon_Text.Text = string.Empty;
                Peshe_Text.Text = string.Empty;
                Sheher_Text.Text = string.Empty;
                Olke_Text.Text = string.Empty;
                Dogum_ili.Value = DateTime.Now;
                if (radioButton1.Checked == true || radioButton2.Checked)
                {
                    radioButton3.Checked = true;
                }
                Error_Label.Visible = false;
            }
        }

        private void Load_Button_Click(object sender, EventArgs e)
        {
            if (File.Exists(Load_Text.Text))
            {
                User Read_Us = Functions.ReadUserToJson(Load_Text.Text);
                Ad_Text.Text = Read_Us._name;
                Soyad_Text.Text = Read_Us._surname;
                Peshe_Text.Text = Read_Us._peshe;
                Olke_Text.Text = Read_Us._country;
                Sheher_Text.Text = Read_Us._city;
                Telefon_Text.Text = Read_Us._phone;
                Dogum_ili.Value = Read_Us.il;

                if (Read_Us._cins == radioButton1.Text)
                {
                    radioButton1.Checked = true;
                }
                else if(Read_Us._cins == radioButton2.Text)
                {
                    radioButton2.Checked = true;
                }
                else if(Read_Us._cins == radioButton3.Text) 
                {
                    radioButton3.Checked = true;
                }

            }
            else
            {
                Error_Label.Visible = true;
                Load_Text.Text = string.Empty;
            }
        }

        private void Load_Text_Click(object sender, EventArgs e)
        {
            Error_Label.Visible = false;
        }

        private void Cins_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
