﻿namespace Nominas
{
    partial class frmPerfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfiles));
            this.toolPerfil = new System.Windows.Forms.ToolStrip();
            this.toolGuardarNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolCerrar = new System.Windows.Forms.ToolStripButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkRecursosHumanos = new System.Windows.Forms.CheckBox();
            this.chkSeguroSocial = new System.Windows.Forms.CheckBox();
            this.chkNominas = new System.Windows.Forms.CheckBox();
            this.chkCatalogos = new System.Windows.Forms.CheckBox();
            this.chkConfiguracion = new System.Windows.Forms.CheckBox();
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idperfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolPerfil
            // 
            this.toolPerfil.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolPerfil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolGuardarNuevo,
            this.toolCerrar});
            this.toolPerfil.Location = new System.Drawing.Point(0, 0);
            this.toolPerfil.Name = "toolPerfil";
            this.toolPerfil.Size = new System.Drawing.Size(767, 27);
            this.toolPerfil.TabIndex = 4;
            this.toolPerfil.Text = "toolEmpresa";
            // 
            // toolGuardarNuevo
            // 
            this.toolGuardarNuevo.Image = ((System.Drawing.Image)(resources.GetObject("toolGuardarNuevo.Image")));
            this.toolGuardarNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGuardarNuevo.Name = "toolGuardarNuevo";
            this.toolGuardarNuevo.Size = new System.Drawing.Size(86, 24);
            this.toolGuardarNuevo.Text = "Guardar";
            this.toolGuardarNuevo.Click += new System.EventHandler(this.toolGuardarNuevo_Click);
            // 
            // toolCerrar
            // 
            this.toolCerrar.Image = ((System.Drawing.Image)(resources.GetObject("toolCerrar.Image")));
            this.toolCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCerrar.Name = "toolCerrar";
            this.toolCerrar.Size = new System.Drawing.Size(73, 24);
            this.toolCerrar.Text = "Cerrar";
            this.toolCerrar.Click += new System.EventHandler(this.toolCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 46);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(172, 24);
            this.lblTitulo.TabIndex = 101;
            this.lblTitulo.Text = "Nombre del perfil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 102;
            this.label1.Text = "Perfil:";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(73, 93);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(172, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 103;
            this.label2.Text = "Módulos";
            // 
            // chkRecursosHumanos
            // 
            this.chkRecursosHumanos.AutoSize = true;
            this.chkRecursosHumanos.Location = new System.Drawing.Point(25, 187);
            this.chkRecursosHumanos.Margin = new System.Windows.Forms.Padding(4);
            this.chkRecursosHumanos.Name = "chkRecursosHumanos";
            this.chkRecursosHumanos.Size = new System.Drawing.Size(154, 21);
            this.chkRecursosHumanos.TabIndex = 104;
            this.chkRecursosHumanos.Text = "Recursos Humanos";
            this.chkRecursosHumanos.UseVisualStyleBackColor = true;
            // 
            // chkSeguroSocial
            // 
            this.chkSeguroSocial.AutoSize = true;
            this.chkSeguroSocial.Location = new System.Drawing.Point(201, 187);
            this.chkSeguroSocial.Margin = new System.Windows.Forms.Padding(4);
            this.chkSeguroSocial.Name = "chkSeguroSocial";
            this.chkSeguroSocial.Size = new System.Drawing.Size(118, 21);
            this.chkSeguroSocial.TabIndex = 105;
            this.chkSeguroSocial.Text = "Seguro Social";
            this.chkSeguroSocial.UseVisualStyleBackColor = true;
            // 
            // chkNominas
            // 
            this.chkNominas.AutoSize = true;
            this.chkNominas.Location = new System.Drawing.Point(368, 187);
            this.chkNominas.Margin = new System.Windows.Forms.Padding(4);
            this.chkNominas.Name = "chkNominas";
            this.chkNominas.Size = new System.Drawing.Size(85, 21);
            this.chkNominas.TabIndex = 107;
            this.chkNominas.Text = "Nominas";
            this.chkNominas.UseVisualStyleBackColor = true;
            // 
            // chkCatalogos
            // 
            this.chkCatalogos.AutoSize = true;
            this.chkCatalogos.Location = new System.Drawing.Point(489, 187);
            this.chkCatalogos.Margin = new System.Windows.Forms.Padding(4);
            this.chkCatalogos.Name = "chkCatalogos";
            this.chkCatalogos.Size = new System.Drawing.Size(93, 21);
            this.chkCatalogos.TabIndex = 108;
            this.chkCatalogos.Text = "Catálogos";
            this.chkCatalogos.UseVisualStyleBackColor = true;
            // 
            // chkConfiguracion
            // 
            this.chkConfiguracion.AutoSize = true;
            this.chkConfiguracion.Location = new System.Drawing.Point(617, 187);
            this.chkConfiguracion.Margin = new System.Windows.Forms.Padding(4);
            this.chkConfiguracion.Name = "chkConfiguracion";
            this.chkConfiguracion.Size = new System.Drawing.Size(117, 21);
            this.chkConfiguracion.TabIndex = 109;
            this.chkConfiguracion.Text = "Configuración";
            this.chkConfiguracion.UseVisualStyleBackColor = true;
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.AllowUserToAddRows = false;
            this.dgvPermisos.AllowUserToDeleteRows = false;
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idperfil,
            this.nombre,
            this.permiso,
            this.accion});
            this.dgvPermisos.Location = new System.Drawing.Point(13, 229);
            this.dgvPermisos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.Size = new System.Drawing.Size(741, 446);
            this.dgvPermisos.TabIndex = 118;
            this.dgvPermisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermisos_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "idperfil";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Menu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Permiso";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // idperfil
            // 
            this.idperfil.HeaderText = "idperfil";
            this.idperfil.Name = "idperfil";
            this.idperfil.ReadOnly = true;
            this.idperfil.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Menu";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // permiso
            // 
            this.permiso.HeaderText = "Permiso";
            this.permiso.Name = "permiso";
            this.permiso.ReadOnly = true;
            // 
            // accion
            // 
            this.accion.HeaderText = "Accion";
            this.accion.Name = "accion";
            // 
            // frmPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 699);
            this.Controls.Add(this.dgvPermisos);
            this.Controls.Add(this.chkConfiguracion);
            this.Controls.Add(this.chkCatalogos);
            this.Controls.Add(this.chkNominas);
            this.Controls.Add(this.chkSeguroSocial);
            this.Controls.Add(this.chkRecursosHumanos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.toolPerfil);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPerfiles";
            this.Text = "Perfiles del sistema";
            this.Load += new System.EventHandler(this.frmPerfiles_Load);
            this.toolPerfil.ResumeLayout(false);
            this.toolPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolPerfil;
        internal System.Windows.Forms.ToolStripButton toolGuardarNuevo;
        private System.Windows.Forms.ToolStripButton toolCerrar;
        internal System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkRecursosHumanos;
        private System.Windows.Forms.CheckBox chkSeguroSocial;
        private System.Windows.Forms.CheckBox chkNominas;
        private System.Windows.Forms.CheckBox chkCatalogos;
        private System.Windows.Forms.CheckBox chkConfiguracion;
        private System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idperfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn permiso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn accion;
    }
}