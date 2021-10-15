using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Practica_Semana11SMIS047221
{
    class Crud
    {
        private Connection conn = new Connection();

        //metodo para seleccionar los registros de la tabla de la base de datos

        public MySqlDataReader select(string query)
        {
            MySqlDataReader dataReader;

            //utiliazar command de la clase connection
            conn.command = new MySqlCommand(query, conn.openConnection());
            dataReader = conn.command.ExecuteReader();
            return dataReader;
        }

        //metodo que permitira ejetucar las consultas para insertar, editar y eliminar 

        public void executeQuery(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            conn.command = new MySqlCommand(query, conn.openConnection());
            adapter.InsertCommand = conn.command;
            adapter.InsertCommand.ExecuteNonQuery(); //ejecutamos la consulta
            conn.command.Dispose();
            conn.closeConnection();
        }
    }
}
