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
    public partial class mainpage : Form
    {
        public mainpage()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label4.Text =  Konto.namn;
            label5.Text =  Konto.pass ;
            show1.Text =  Program.konto1.saldo.ToString();
            show2.Text = Program.konto2.saldo.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ränta x = new ränta();
            x.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Valutor x = new Valutor();
            x.Show();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            skickapengar x = new skickapengar();
            x.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            sätt x = new sätt();
            x.Show();
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OBS" + Environment.NewLine + "Vi fixar det snart ;)");
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                Environment.Exit(0);
        }
    }
}
