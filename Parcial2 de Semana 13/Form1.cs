using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial2_de_Semana_13.Properties;

namespace Parcial2_de_Semana_13
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        String datos = Settings.Default.pass;

        private void btnacceder_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==datos)
            {
                newpass fm = new newpass();
                fm.Show();
            }
            else
            {
                MessageBox.Show("datos incorrectos");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
