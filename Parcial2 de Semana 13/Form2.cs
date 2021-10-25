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
    public partial class newpass : Form
    {
        public newpass()
        {
            InitializeComponent();
        }

        string pass = Settings.Default.pass;

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==pass)
            {
                Settings.Default.pass = textBox2.Text;
                Settings.Default.Save();
                MessageBox.Show("Todo bien, te has registrado");

                Form fm = new Form3();
                fm.Show();
            }
            else
            {
                MessageBox.Show("Todo mal, no te registraste");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
