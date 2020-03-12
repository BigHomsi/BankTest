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
    public partial class ränta : Form
    {
        public ränta()
        {
            InitializeComponent();
        }

        private void Ränta_Load(object sender, EventArgs e)
        {
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            char[] co = innan.Text.ToCharArray();

            bool x = false;

            for (int i = 0; i < co.Length; i++)
            {

                if (co[i] == '-')
                    x = true;

            }


            if (x == false)
            {

                try
                {
                    if (radioButton1.Checked == true)
                    {

                        efter.Text = Konto.räntaKalk(double.Parse(innan.Text), 1.025);
                        
                            groupBox1.Text = "Hej " + Environment.NewLine + Environment.NewLine +
                             "Våra års ränta :2,5 %" +
                                Environment.NewLine + "Din önskade bellop : " + innan.Text + ";-" +
                                    Environment.NewLine + "Räntan du ska betalla : " + (double.Parse(innan.Text) * 0.025) + ";-" +
                                        Environment.NewLine + Environment.NewLine + "Du ska betalla totalt : " + efter.Text + ";-";

                        
                    }


                    else if (radioButton2.Checked == true)
                    {

                        efter.Text = Konto.räntaKalk(double.Parse(innan.Text), 1.085);
                        
                            groupBox1.Text = "Hej " + Environment.NewLine + Environment.NewLine +
                              "Våra års ränta : 8,5 % " +
                                  Environment.NewLine + "Din önskade bellop : " + innan.Text + ";-" +
                                      Environment.NewLine + "Räntan du ska betalla : " + (double.Parse(innan.Text) * 0.085) + ";-" +
                                          Environment.NewLine + Environment.NewLine + "Du ska betalla totalt : " + efter.Text + ";-";
                        
                    }

                    else
                        MessageBox.Show("Du måste välja en av lånerna");
                }
                catch (Exception)
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("OBS!!" + Environment.NewLine + "Du har skrivet fell format");
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            mainpage x = new mainpage();
            x.Show();
        }

        
    }
}
