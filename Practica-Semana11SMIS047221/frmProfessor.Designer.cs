
using System;

namespace Practica_Semana11SMIS047221
{
    partial class frmProfessor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblPID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.dtgProfessor = new System.Windows.Forms.DataGridView();
            this.actions = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.htmlToolTip1 = new MetroFramework.Drawing.Html.HtmlToolTip();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfessor)).BeginInit();
            this.actions.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(135, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nombre del Profesor";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 106);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(117, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Titulo del Profesor";
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Location = new System.Drawing.Point(442, 36);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(94, 19);
            this.lblPID.TabIndex = 2;
            this.lblPID.Text = "ID de Profesor";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(442, 105);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(122, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Grupo del Profesor";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(200, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(192, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(600, 38);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(100, 20);
            this.txtPID.TabIndex = 5;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(200, 105);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(192, 20);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(570, 106);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(144, 20);
            this.txtGrupo.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(701, 186);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 52);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtgProfessor
            // 
            this.dtgProfessor.AllowUserToOrderColumns = true;
            this.dtgProfessor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProfessor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgProfessor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProfessor.ContextMenuStrip = this.actions;
            this.dtgProfessor.Location = new System.Drawing.Point(12, 264);
            this.dtgProfessor.Name = "dtgProfessor";
            this.dtgProfessor.Size = new System.Drawing.Size(790, 188);
            this.dtgProfessor.TabIndex = 9;
            this.dtgProfessor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProfessor_CellContentClick);
            // 
            // actions
            // 
            this.actions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.actions.Name = "actions";
            this.actions.Size = new System.Drawing.Size(118, 48);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(608, 186);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 52);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 186);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 52);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // htmlToolTip1
            // 
            this.htmlToolTip1.OwnerDraw = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(515, 186);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(87, 52);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseSelectable = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 464);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dtgProfessor);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtPID);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProfessor";
            this.Load += new System.EventHandler(this.frmProfessor_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfessor)).EndInit();
            this.actions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblPID;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtGrupo;
        private MetroFramework.Controls.MetroButton btnSave;
      
        private MetroFramework.Controls.MetroContextMenu actions;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btnCancel;
        private System.Windows.Forms.DataGridView dtgProfessor;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Drawing.Html.HtmlToolTip htmlToolTip1;
        private MetroFramework.Controls.MetroButton btnNuevo;
    }
}