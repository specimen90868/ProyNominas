﻿namespace Nominas
{
    partial class frmListaEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaEmpleados));
            this.toolBusqueda = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.toolReingreso = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHistorial = new System.Windows.Forms.ToolStripButton();
            this.toolDeptoPuesto = new System.Windows.Forms.ToolStripSplitButton();
            this.toolDepartamento = new System.Windows.Forms.ToolStripMenuItem();
            this.toolPuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCambioPeriodo = new System.Windows.Forms.ToolStripButton();
            this.toolNominaDigital = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolIncrementoSalario = new System.Windows.Forms.ToolStripButton();
            this.toolExportar = new System.Windows.Forms.ToolStripSplitButton();
            this.toolCatNomina = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCatGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAtras = new System.Windows.Forms.ToolStripButton();
            this.toolAdelante = new System.Windows.Forms.ToolStripButton();
            this.toolActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblBuscar = new System.Windows.Forms.ToolStripLabel();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolTitulo = new System.Windows.Forms.ToolStrip();
            this.toolEmpleados = new System.Windows.Forms.ToolStripLabel();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolBusqueda.SuspendLayout();
            this.toolTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBusqueda
            // 
            this.toolBusqueda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolHistorial,
            this.toolDeptoPuesto,
            this.toolCambioPeriodo,
            this.toolNominaDigital,
            this.toolStripSeparator3,
            this.toolEliminar,
            this.toolStripSeparator1,
            this.toolIncrementoSalario,
            this.toolExportar,
            this.toolAtras,
            this.toolAdelante,
            this.toolActualizar,
            this.toolStripSeparator2,
            this.lblBuscar,
            this.txtBuscar,
            this.toolStripSplitButton2});
            this.toolBusqueda.Location = new System.Drawing.Point(0, 27);
            this.toolBusqueda.Name = "toolBusqueda";
            this.toolBusqueda.Size = new System.Drawing.Size(1505, 25);
            this.toolBusqueda.TabIndex = 3;
            this.toolBusqueda.Text = "ToolStrip1";
            this.toolBusqueda.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolBusqueda_ItemClicked);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNuevo,
            this.toolConsultar,
            this.toolEditar,
            this.toolBaja,
            this.toolReingreso});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(105, 22);
            this.toolStripSplitButton1.Text = "Operaciones";
            // 
            // toolNuevo
            // 
            this.toolNuevo.Image = ((System.Drawing.Image)(resources.GetObject("toolNuevo.Image")));
            this.toolNuevo.Name = "toolNuevo";
            this.toolNuevo.Size = new System.Drawing.Size(152, 22);
            this.toolNuevo.Text = "Nuevo";
            this.toolNuevo.Click += new System.EventHandler(this.toolNuevo_Click);
            // 
            // toolConsultar
            // 
            this.toolConsultar.Image = ((System.Drawing.Image)(resources.GetObject("toolConsultar.Image")));
            this.toolConsultar.Name = "toolConsultar";
            this.toolConsultar.Size = new System.Drawing.Size(152, 22);
            this.toolConsultar.Text = "Consultar";
            this.toolConsultar.Click += new System.EventHandler(this.toolConsultar_Click);
            // 
            // toolEditar
            // 
            this.toolEditar.Image = ((System.Drawing.Image)(resources.GetObject("toolEditar.Image")));
            this.toolEditar.Name = "toolEditar";
            this.toolEditar.Size = new System.Drawing.Size(152, 22);
            this.toolEditar.Text = "Editar";
            this.toolEditar.Click += new System.EventHandler(this.toolEditar_Click);
            // 
            // toolBaja
            // 
            this.toolBaja.Image = ((System.Drawing.Image)(resources.GetObject("toolBaja.Image")));
            this.toolBaja.Name = "toolBaja";
            this.toolBaja.Size = new System.Drawing.Size(152, 22);
            this.toolBaja.Text = "Baja";
            this.toolBaja.Click += new System.EventHandler(this.toolBaja_Click);
            // 
            // toolReingreso
            // 
            this.toolReingreso.Image = ((System.Drawing.Image)(resources.GetObject("toolReingreso.Image")));
            this.toolReingreso.Name = "toolReingreso";
            this.toolReingreso.Size = new System.Drawing.Size(152, 22);
            this.toolReingreso.Text = "Reingreso";
            this.toolReingreso.Click += new System.EventHandler(this.toolReingreso_Click);
            // 
            // toolHistorial
            // 
            this.toolHistorial.Image = ((System.Drawing.Image)(resources.GetObject("toolHistorial.Image")));
            this.toolHistorial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolHistorial.Name = "toolHistorial";
            this.toolHistorial.Size = new System.Drawing.Size(71, 22);
            this.toolHistorial.Text = "Historial";
            this.toolHistorial.Click += new System.EventHandler(this.toolHistorial_Click);
            // 
            // toolDeptoPuesto
            // 
            this.toolDeptoPuesto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDepartamento,
            this.toolPuesto});
            this.toolDeptoPuesto.Image = ((System.Drawing.Image)(resources.GetObject("toolDeptoPuesto.Image")));
            this.toolDeptoPuesto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDeptoPuesto.Name = "toolDeptoPuesto";
            this.toolDeptoPuesto.Size = new System.Drawing.Size(118, 22);
            this.toolDeptoPuesto.Text = "Depto / Puesto";
            // 
            // toolDepartamento
            // 
            this.toolDepartamento.Name = "toolDepartamento";
            this.toolDepartamento.Size = new System.Drawing.Size(210, 22);
            this.toolDepartamento.Text = "Cambio de departamento";
            this.toolDepartamento.Click += new System.EventHandler(this.toolDepartamento_Click);
            // 
            // toolPuesto
            // 
            this.toolPuesto.Name = "toolPuesto";
            this.toolPuesto.Size = new System.Drawing.Size(210, 22);
            this.toolPuesto.Text = "Cambio de puesto";
            this.toolPuesto.Click += new System.EventHandler(this.toolPuesto_Click);
            // 
            // toolCambioPeriodo
            // 
            this.toolCambioPeriodo.Image = ((System.Drawing.Image)(resources.GetObject("toolCambioPeriodo.Image")));
            this.toolCambioPeriodo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCambioPeriodo.Name = "toolCambioPeriodo";
            this.toolCambioPeriodo.Size = new System.Drawing.Size(68, 22);
            this.toolCambioPeriodo.Text = "Periodo";
            this.toolCambioPeriodo.Click += new System.EventHandler(this.toolCambioPeriodo_Click);
            // 
            // toolNominaDigital
            // 
            this.toolNominaDigital.Image = ((System.Drawing.Image)(resources.GetObject("toolNominaDigital.Image")));
            this.toolNominaDigital.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNominaDigital.Name = "toolNominaDigital";
            this.toolNominaDigital.Size = new System.Drawing.Size(107, 22);
            this.toolNominaDigital.Text = "Nomina Digital";
            this.toolNominaDigital.Click += new System.EventHandler(this.toolNominaDigital_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolEliminar
            // 
            this.toolEliminar.Image = ((System.Drawing.Image)(resources.GetObject("toolEliminar.Image")));
            this.toolEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEliminar.Name = "toolEliminar";
            this.toolEliminar.Size = new System.Drawing.Size(70, 22);
            this.toolEliminar.Text = "Eliminar";
            this.toolEliminar.Click += new System.EventHandler(this.toolEliminar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolIncrementoSalario
            // 
            this.toolIncrementoSalario.Image = ((System.Drawing.Image)(resources.GetObject("toolIncrementoSalario.Image")));
            this.toolIncrementoSalario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolIncrementoSalario.Name = "toolIncrementoSalario";
            this.toolIncrementoSalario.Size = new System.Drawing.Size(129, 22);
            this.toolIncrementoSalario.Text = "Incrementar Salario";
            this.toolIncrementoSalario.Click += new System.EventHandler(this.toolIncrementoSalario_Click);
            // 
            // toolExportar
            // 
            this.toolExportar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCatNomina,
            this.toolCatGeneral});
            this.toolExportar.Image = ((System.Drawing.Image)(resources.GetObject("toolExportar.Image")));
            this.toolExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExportar.Name = "toolExportar";
            this.toolExportar.Size = new System.Drawing.Size(82, 22);
            this.toolExportar.Text = "Exportar";
            this.toolExportar.Click += new System.EventHandler(this.toolExportar_Click);
            // 
            // toolCatNomina
            // 
            this.toolCatNomina.Name = "toolCatNomina";
            this.toolCatNomina.Size = new System.Drawing.Size(182, 22);
            this.toolCatNomina.Text = "Catálogo de nómina";
            this.toolCatNomina.Click += new System.EventHandler(this.toolCatNomina_Click);
            // 
            // toolCatGeneral
            // 
            this.toolCatGeneral.Name = "toolCatGeneral";
            this.toolCatGeneral.Size = new System.Drawing.Size(182, 22);
            this.toolCatGeneral.Text = "Catálogo general";
            this.toolCatGeneral.Click += new System.EventHandler(this.toolCatGeneral_Click);
            // 
            // toolAtras
            // 
            this.toolAtras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAtras.Image = ((System.Drawing.Image)(resources.GetObject("toolAtras.Image")));
            this.toolAtras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAtras.Name = "toolAtras";
            this.toolAtras.Size = new System.Drawing.Size(23, 22);
            this.toolAtras.Text = "toolStripButton1";
            this.toolAtras.Click += new System.EventHandler(this.toolAtras_Click);
            // 
            // toolAdelante
            // 
            this.toolAdelante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAdelante.Image = ((System.Drawing.Image)(resources.GetObject("toolAdelante.Image")));
            this.toolAdelante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdelante.Name = "toolAdelante";
            this.toolAdelante.Size = new System.Drawing.Size(23, 22);
            this.toolAdelante.Text = "toolStripButton2";
            this.toolAdelante.Click += new System.EventHandler(this.toolAdelante_Click);
            // 
            // toolActualizar
            // 
            this.toolActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolActualizar.Image = ((System.Drawing.Image)(resources.GetObject("toolActualizar.Image")));
            this.toolActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolActualizar.Name = "toolActualizar";
            this.toolActualizar.Size = new System.Drawing.Size(23, 22);
            this.toolActualizar.Text = "Actualizar";
            this.toolActualizar.Click += new System.EventHandler(this.toolActualizar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(45, 22);
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 25);
            this.txtBuscar.Text = "Buscar por no. de empleado...";
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            this.txtBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            // 
            // toolTitulo
            // 
            this.toolTitulo.BackColor = System.Drawing.Color.DarkGray;
            this.toolTitulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolEmpleados});
            this.toolTitulo.Location = new System.Drawing.Point(0, 0);
            this.toolTitulo.Name = "toolTitulo";
            this.toolTitulo.Size = new System.Drawing.Size(1505, 27);
            this.toolTitulo.TabIndex = 4;
            this.toolTitulo.Text = "ToolStrip1";
            // 
            // toolEmpleados
            // 
            this.toolEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.toolEmpleados.Name = "toolEmpleados";
            this.toolEmpleados.Size = new System.Drawing.Size(115, 24);
            this.toolEmpleados.Text = "Empleados";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpleados.Location = new System.Drawing.Point(0, 52);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.Size = new System.Drawing.Size(1505, 672);
            this.dgvEmpleados.TabIndex = 5;
            this.dgvEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellDoubleClick);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // frmListaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 724);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.toolBusqueda);
            this.Controls.Add(this.toolTitulo);
            this.Name = "frmListaEmpleados";
            this.Text = "Empleados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmListaEmpleados_FormClosed);
            this.Load += new System.EventHandler(this.frmListaEmpleados_Load);
            this.toolBusqueda.ResumeLayout(false);
            this.toolBusqueda.PerformLayout();
            this.toolTitulo.ResumeLayout(false);
            this.toolTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolBusqueda;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.ToolStripLabel lblBuscar;
        internal System.Windows.Forms.ToolStripTextBox txtBuscar;
        internal System.Windows.Forms.ToolStrip toolTitulo;
        internal System.Windows.Forms.ToolStripLabel toolEmpleados;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.ToolStripButton toolEliminar;
        private System.Windows.Forms.ToolStripButton toolIncrementoSalario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolHistorial;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolActualizar;
        private System.Windows.Forms.ToolStripSplitButton toolExportar;
        private System.Windows.Forms.ToolStripMenuItem toolCatNomina;
        private System.Windows.Forms.ToolStripMenuItem toolCatGeneral;
        private System.Windows.Forms.ToolStripSplitButton toolDeptoPuesto;
        private System.Windows.Forms.ToolStripMenuItem toolDepartamento;
        private System.Windows.Forms.ToolStripMenuItem toolPuesto;
        private System.Windows.Forms.ToolStripButton toolCambioPeriodo;
        private System.Windows.Forms.ToolStripButton toolNominaDigital;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem toolNuevo;
        private System.Windows.Forms.ToolStripMenuItem toolConsultar;
        private System.Windows.Forms.ToolStripMenuItem toolEditar;
        private System.Windows.Forms.ToolStripMenuItem toolBaja;
        private System.Windows.Forms.ToolStripMenuItem toolReingreso;
        private System.Windows.Forms.ToolStripButton toolAtras;
        private System.Windows.Forms.ToolStripButton toolAdelante;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
    }
}