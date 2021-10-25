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
    public partial class Compu4 : Form
    {
        public Compu4()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnectionString = "";
                if (myConnectionString == "")
                {
                    myConnectionString = "Database=agenda;Data Source=localhost;User Id = root; Password = ";
                }
                MySqlConnection myConnection = new MySqlConnection(myConnectionString);
                string mySelectQuery = "SELECT * From agenda Where id=" + textBox1.Text + "";
                MySqlCommand myCommand = new MySqlCommand(mySelectQuery, myConnection);
                myConnection.Open();
                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();
                if (myReader.Read())
                {
                    textBox1.Text = (myReader.GetString(1));



else
                    {
                        avisos a = new avisos();
                        a.label1.Text = "El Registro No Existe";
                        a.ShowDialog();
                    }
                    myReader.Close();
                    myConnection.Close();
                }
            }

            catch (System.Exception)
            {
                avisos a = new avisos();
                a.label1.Text = "Escribe el ID";
                a.ShowDialog();
            }
        }
    }
}
