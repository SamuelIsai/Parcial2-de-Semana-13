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
    public partial class Compu : Form
    {
        public Compu()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btncompu1_Click(object sender, EventArgs e)
        {
            Form fm = new Compu1();
            fm.Show();
        }

        private void btncompu2_Click(object sender, EventArgs e)
        {
            Form fm = new Compu2();
            fm.Show();
        }

        private void btncompu3_Click(object sender, EventArgs e)
        {
            Form fm = new Compu3();
            fm.Show();
        }

        private void btncompu4_Click(object sender, EventArgs e)
        {
            Form fm = new Compu4();
            fm.Show();
        }

        private void b4ncompu5_Click(object sender, EventArgs e)
        {
            Form fm = new Compu5();
            fm.Show();
        }
    }
}
