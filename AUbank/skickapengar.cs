using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUbank
{
    public partial class skickapengar : Form
    {
        public skickapengar()
        {
            InitializeComponent();

            comboBox1.Items.Add("  Från ungdomskonto  -->  till spårkonto").ToString();
            comboBox1.Items.Add("  Från spårkonto  -->  till ungdomskonto").ToString();

            label2.Text = Program.konto1.saldo.ToString() + ";-";
            label3.Text = Program.konto2.saldo.ToString() + ";-";

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainpage x = new mainpage();
            x.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            char[] co = textBox1.Text.ToCharArray();

            bool has1 = false;

            for (int i = 0; i < co.Length; i++)
            {

                if (co[i] == '-')
                    has1 = true;
               
            }

            
            try
            {
                if (has1 == false && comboBox1.Text == "  Från ungdomskonto  -->  till spårkonto" && double.Parse(textBox1.Text) <= Program.konto1.saldo)
                {
                    Program.konto2.ski(Program.konto1, double.Parse(textBox1.Text));

                    label2.Text = Program.konto1.saldo.ToString() + ";-";
                    label3.Text = Program.konto2.saldo.ToString() + ";-";
                }


                if (has1 == false && comboBox1.Text == "  Från spårkonto  -->  till ungdomskonto" && double.Parse(textBox1.Text) <= Program.konto2.saldo)
                {
                    Program.konto1.ski(Program.konto2, double.Parse(textBox1.Text));

                    label2.Text = Program.konto1.saldo.ToString() + ";-";
                    label3.Text = Program.konto2.saldo.ToString() + ";-";
                }
               
            }
            catch(Exception)
            {
                MessageBox.Show("OBS!!" + Environment.NewLine + "Du har gjort ett fell");
            }


        }
    }
}
