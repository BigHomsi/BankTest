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
    public partial class Valutor : Form
    {
        public Valutor()
        {
            InitializeComponent();
            
        }

        private void Valutor_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainpage x = new mainpage();
            x.Show();
        }
    }
}
