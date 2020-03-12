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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Konto.namn = username.Text;
            Konto.pass = password.Text;


            char[] co = Konto.namn.ToCharArray();


            bool has1 = false;
            bool has2 = false;
            int alf = 0;


            for (int i = 0; i < co.Length; i++)
            {

                if (co[i] == '@')
                    has1 = true;

                if (co[i] == '.')
                    has2 = true;
                 alf = alf + i;

            }
            if (has1 == true && has2 == true && Konto.pass != "" && alf >=10)
            {
                this.Hide();
                mainpage x = new mainpage();
                x.Show();
            } 
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("kontrollera din e-mail" + Environment.NewLine + "kontrollera din password"+ Environment.NewLine + "Din e-mail måste inhålla minst 10 st string");
            }



        }
    }
}
