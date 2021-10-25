using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_de_Semana_13
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fm = new Compu();
            fm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form fm = new Accesorios();
            fm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form fm = new Repuestos();
            fm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form fm = new BuscarProducto();
            fm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
