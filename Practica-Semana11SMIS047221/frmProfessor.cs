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
    public partial class frmProfessor : Form
    {
        private string action = "";

        public frmProfessor()
        {
            InitializeComponent();
        }

        //limpiar dataGridView
        private void clearData()
        {
            dtgProfessor.Columns.Clear();
            dtgProfessor.Rows.Clear();
        }

        public void fillDataGridView()
        {
            Professor professor = new Professor();


            dtgProfessor.Columns.Add("PID", "ID del Profesor");
            dtgProfessor.Columns.Add("nombredelprofesor", "NOMBRE DEL PROFESOR");
            dtgProfessor.Columns.Add("titulodelprofesor", "TITULO DEL PROFESOR");
            dtgProfessor.Columns.Add("grupodelprofesor", "GRUPO DEL PORFESOR");

            MySqlDataReader dataReader = professor.getProfessor();

            while (dataReader.Read())
            {
                dtgProfessor.Rows.Add(
                dataReader.GetValue(0),
                dataReader.GetValue(1),
                dataReader.GetValue(2),
                dataReader.GetValue(3)
                );
            }

        }

        public void clearDataGridView()
        {
            dtgProfessor.Columns.Clear();
            dtgProfessor.Rows.Clear();
        }
        //hola
        private void frmProfessor_Load_1(object sender, EventArgs e)
        {
            fillDataGridView();
            txtNombre.Enabled = false;
            txtGrupo.Enabled = false;
            txtTitulo.Enabled = false;
            txtPID.Enabled = false;
        }

        //deshabilita los controles de formulario
        public void controlsDisable()
        {
            txtPID.Enabled = false;
            txtNombre.Enabled = false;
            txtTitulo.Enabled = false;
            txtGrupo.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
        //habilitar los controles de formulario
        public void controlsEnable()
        {
            txtPID.Enabled = false;
            txtNombre.Enabled = true;
            txtTitulo.Enabled = true;
            txtGrupo.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }
        //limpiar el contenido de los controles
        public void clearControls()
        {
            txtPID.Text = "";
            txtNombre.Text = "";
            txtTitulo.Text = "";
            txtGrupo.Text = "";

        }


        private void dtgProfessor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            action = "edit";
            controlsEnable();

            txtPID.Visible = true;
            txtPID.ReadOnly = true;
            lblPID.Visible = true;

            //cargar datos en controles
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            //mediante este boton se programara para guardar y editar
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguró que desea cancelar?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clearControls();
                controlsDisable();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor(); //instancia de la clase Libro
                                                   //evaluar la accion
            if (action == "edit")
            {
                professor._PID = Convert.ToInt32(txtPID.Text);
            }


            professor._NombredelProfesor = txtNombre.Text;
            professor._TitulodelProfesor = txtTitulo.Text;
            professor._GrupodelProfesor = txtGrupo.Text;


            string mensaje = "Esta seguro que desea guardar el registro?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //LLAMAR AL METODO PARA GUARDAR
                if (professor.EditProfessor(action)) //el action debe definirse debido a que es pasado como argumento 
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos se han guardado exitosamente!",
                        "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillDataGridView();
                    //despues de guardar o actualizar volvemos a cargar los datos en el datagridview
                    clearData();
                    fillDataGridView();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos  no se han guardado!",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                clearControls();
                controlsDisable();
          
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlsEnable();

            txtPID.Visible = true;
            txtPID.ReadOnly = true;
            lblPID.Visible = true;

            //pasar los valores del datagridview hacia los texbox
            txtPID.Text = dtgProfessor.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dtgProfessor.CurrentRow.Cells[1].Value.ToString();
            txtTitulo.Text = dtgProfessor.CurrentRow.Cells[2].Value.ToString();
            txtGrupo.Text = dtgProfessor.CurrentRow.Cells[3].Value.ToString();
           
            //enviar aaccion
            action = "edit";
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensaje = "Esta seguro que desea eliminar el registro?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Professor professor = new Professor();
                professor._PID = Convert.ToInt32(dtgProfessor.CurrentRow.Cells[0].Value);

                //llamado al metodo deleteBook() de la clase Book
                if (professor.deleteProfessor())
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos se han eliminado exitosamente!",
                        "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearDataGridView();
                    fillDataGridView();
                  
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos  no se han podido eliminar",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguró que desea salir?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //habilita los controles para ingresar los datos y define el action
            txtNombre.Enabled = true;
            txtGrupo.Enabled =true;
            txtTitulo.Enabled = true;
            txtPID.Enabled = true;
            txtNombre.Focus(); //enviamos el enfoque al txtNombre

            action = "new";
        }

    }
}
