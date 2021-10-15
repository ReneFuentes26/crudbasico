using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Practica_Semana11SMIS047221
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "";
            MySqlConnection conn;

            try
            {
                connectionString = @"Server=localhost;Database=smis047221;
                                    Uid=root;Pwd=usbw; SSL Mode=None";
                conn = new MySqlConnection(connectionString);
                MetroFramework.MetroMessageBox.Show(this,
                    "SE ESTABLECION LA CONEXION CON LA BASE DE DATOS", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
                conn.Open();

                conn.Close();
            }
            catch (Exception Ex)
            {
                MetroFramework.MetroMessageBox.Show(this,
                    Ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
            }
        }
    }
}
