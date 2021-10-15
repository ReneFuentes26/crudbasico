using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Practica_Semana11SMIS047221
{
    class Professor
    {
        public int _PID { get; set; }
        public string _NombredelProfesor { get; set; }
        public string _TitulodelProfesor { get; set; }
        public string _GrupodelProfesor { get; set; }

        //Instancias a la clase crud
        private Crud crud = new Crud();

        //metodo para retornar los registros de la tabla book

        public MySqlDataReader getProfessor()
        {
            string query = "SELECT PID,nombredelprofesor,titulodelprofesor,grupodelprofesor FROM professor";

            //llamado al metodo select de la clase crud 
            return crud.select(query);
        }


        //metodo para insertar o editar un registro
        public Boolean EditProfessor(string action)
        {
            if (action == "new")
            {
                string query = "INSERT INTO professor(nombredelprofesor, titulodelprofesor, grupodelprofesor) VALUES ('" + _NombredelProfesor + "', '" + _TitulodelProfesor + "', '" + _GrupodelProfesor + "')";
                crud.executeQuery(query);
                return true;
            }
            else if (action == "edit")
            {
                string query = "UPDATE professor SET"
                    + "nombredelprofesor='" + _NombredelProfesor + "' ,"
                    + "titulodelprofesor='" + _TitulodelProfesor + "' ,"
                    + "grupodelprofesor='" + _GrupodelProfesor + "'"
                    + "WHERE "
                    + "PID='" + _PID + "'";
                crud.executeQuery(query);
                return true;
            }

            return false;

        }

        //metodo para eliminar 
        public Boolean deleteProfessor()
        {
            string query = "DELETE FROM professor WHERE PID='" + _PID + "'";
            crud.executeQuery(query);
            return true;
        }

    }
}
