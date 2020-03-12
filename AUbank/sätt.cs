using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUbank
{
    public partial class sätt : Form
    {
        public sätt()
        {
            InitializeComponent();

            label6.Text = Program.konto1.saldo.ToString() + ";-";
           
        }

        private void Button2_Click(object sender, EventArgs e)
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

                if (has1 == false)
                {
                    double pengin = double.Parse(textBox1.Text);

                    Program.konto1.saldo = pengin + Program.konto1.saldo;

                    label6.Text = Program.konto1.saldo.ToString() + ";-";
                }

            }
            catch(Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("OBS!!" + Environment.NewLine + "Du har skrivet fell format");
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainpage x = new mainpage();
            x.Show();
        }

      
    }
}
