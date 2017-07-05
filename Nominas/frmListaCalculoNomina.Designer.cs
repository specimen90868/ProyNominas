﻿namespace Nominas
{
    partial class frmListaCalculoNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaCalculoNomina));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTitulo = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSeparadorGuardar = new System.Windows.Forms.ToolStripSeparator();
            this.toolAutorizar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSeparadorAutorizar = new System.Windows.Forms.ToolStripSeparator();
            this.toolReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCaratula = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolReporteDepto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTabular = new System.Windows.Forms.ToolStripMenuItem();
            this.toolReciboNomina = new System.Windows.Forms.ToolStripMenuItem();
            this.toolGravadosExentos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolPeriodo = new System.Windows.Forms.ToolStripLabel();
            this.toolCambiaPeriodo = new System.Windows.Forms.ToolStripButton();
            this.toolBusqueda = new System.Windows.Forms.ToolStrip();
            this.toolFiltro = new System.Windows.Forms.ToolStripSplitButton();
            this.toolTodos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDepartamento = new System.Windows.Forms.ToolStripMenuItem();
            this.toolPuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolNoEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOrdenar = new System.Windows.Forms.ToolStripSplitButton();
            this.toolOrdenEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOrdenNombre = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOrdenPaterno = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOrdenMaterno = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSobreRecibo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolCalcular = new System.Windows.Forms.ToolStripButton();
            this.toolMostrarDatos = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolCargar = new System.Windows.Forms.ToolStripButton();
            this.toolCargaVacaciones = new System.Windows.Forms.ToolStripButton();
            this.toolCargaFaltas = new System.Windows.Forms.ToolStripButton();
            this.toolActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolCerrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.idtrabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noempleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.despensa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntualidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerCalculo = new System.ComponentModel.BackgroundWorker();
            this.BarraEstado = new System.Windows.Forms.StatusStrip();
            this.toolEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolPorcentaje = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolEtapa = new System.Windows.Forms.ToolStripStatusLabel();
            this.PanelBarra = new System.Windows.Forms.Panel();
            this.PanelGrid = new System.Windows.Forms.Panel();
            this.tabGrid = new System.Windows.Forms.TabControl();
            this.tabCalculoNomina = new System.Windows.Forms.TabPage();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtBitacora = new System.Windows.Forms.TextBox();
            this.tabFaltas = new System.Windows.Forms.TabPage();
            this.dgvFaltas = new System.Windows.Forms.DataGridView();
            this.workExcel = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerGravadosExentos = new System.ComponentModel.BackgroundWorker();
            this.toolTitulo.SuspendLayout();
            this.toolBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.BarraEstado.SuspendLayout();
            this.PanelBarra.SuspendLayout();
            this.PanelGrid.SuspendLayout();
            this.tabGrid.SuspendLayout();
            this.tabCalculoNomina.SuspendLayout();
            this.tabFaltas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaltas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTitulo
            // 
            this.toolTitulo.BackColor = System.Drawing.Color.DarkGray;
            this.toolTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolTitulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolPeriodo,
            this.toolCambiaPeriodo});
            this.toolTitulo.Location = new System.Drawing.Point(0, 0);
            this.toolTitulo.Name = "toolTitulo";
            this.toolTitulo.Size = new System.Drawing.Size(1420, 39);
            this.toolTitulo.TabIndex = 9;
            this.toolTitulo.Text = "ToolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolGuardar,
            this.toolSeparadorGuardar,
            this.toolAutorizar,
            this.toolSeparadorAutorizar,
            this.toolReportes});
            this.toolStripSplitButton1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(125, 36);
            this.toolStripSplitButton1.Text = "Nómina";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // toolGuardar
            // 
            this.toolGuardar.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.toolGuardar.Name = "toolGuardar";
            this.toolGuardar.Size = new System.Drawing.Size(149, 26);
            this.toolGuardar.Text = "Guardar";
            this.toolGuardar.Click += new System.EventHandler(this.toolGuardar_Click);
            // 
            // toolSeparadorGuardar
            // 
            this.toolSeparadorGuardar.Name = "toolSeparadorGuardar";
            this.toolSeparadorGuardar.Size = new System.Drawing.Size(146, 6);
            // 
            // toolAutorizar
            // 
            this.toolAutorizar.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.toolAutorizar.Name = "toolAutorizar";
            this.toolAutorizar.Size = new System.Drawing.Size(149, 26);
            this.toolAutorizar.Text = "Autorizar";
            this.toolAutorizar.Click += new System.EventHandler(this.toolAutorizar_Click);
            // 
            // toolSeparadorAutorizar
            // 
            this.toolSeparadorAutorizar.Name = "toolSeparadorAutorizar";
            this.toolSeparadorAutorizar.Size = new System.Drawing.Size(146, 6);
            // 
            // toolReportes
            // 
            this.toolReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCaratula,
            this.empleadosToolStripMenuItem,
            this.toolReporteDepto,
            this.toolTabular,
            this.toolReciboNomina,
            this.toolGravadosExentos});
            this.toolReportes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolReportes.Name = "toolReportes";
            this.toolReportes.Size = new System.Drawing.Size(149, 26);
            this.toolReportes.Text = "Reportes";
            this.toolReportes.Click += new System.EventHandler(this.toolReportes_Click);
            // 
            // toolCaratula
            // 
            this.toolCaratula.Name = "toolCaratula";
            this.toolCaratula.Size = new System.Drawing.Size(212, 26);
            this.toolCaratula.Text = "Caratula";
            this.toolCaratula.Click += new System.EventHandler(this.toolCaratula_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // toolReporteDepto
            // 
            this.toolReporteDepto.Name = "toolReporteDepto";
            this.toolReporteDepto.Size = new System.Drawing.Size(212, 26);
            this.toolReporteDepto.Text = "Departamentos";
            this.toolReporteDepto.Click += new System.EventHandler(this.toolReporteDepto_Click);
            // 
            // toolTabular
            // 
            this.toolTabular.Name = "toolTabular";
            this.toolTabular.Size = new System.Drawing.Size(212, 26);
            this.toolTabular.Text = "Tabular";
            this.toolTabular.Click += new System.EventHandler(this.toolTabular_Click);
            // 
            // toolReciboNomina
            // 
            this.toolReciboNomina.Name = "toolReciboNomina";
            this.toolReciboNomina.Size = new System.Drawing.Size(212, 26);
            this.toolReciboNomina.Text = "Recibo de nomina";
            this.toolReciboNomina.Click += new System.EventHandler(this.toolReciboNomina_Click);
            // 
            // toolGravadosExentos
            // 
            this.toolGravadosExentos.Name = "toolGravadosExentos";
            this.toolGravadosExentos.Size = new System.Drawing.Size(212, 26);
            this.toolGravadosExentos.Text = "Gravados y exentos";
            this.toolGravadosExentos.Click += new System.EventHandler(this.toolGravadosExentos_Click);
            // 
            // toolPeriodo
            // 
            this.toolPeriodo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.toolPeriodo.Name = "toolPeriodo";
            this.toolPeriodo.Size = new System.Drawing.Size(170, 36);
            this.toolPeriodo.Text = "Fecha del periodo";
            // 
            // toolCambiaPeriodo
            // 
            this.toolCambiaPeriodo.Image = ((System.Drawing.Image)(resources.GetObject("toolCambiaPeriodo.Image")));
            this.toolCambiaPeriodo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCambiaPeriodo.Name = "toolCambiaPeriodo";
            this.toolCambiaPeriodo.Size = new System.Drawing.Size(89, 36);
            this.toolCambiaPeriodo.Text = "Cambiar";
            this.toolCambiaPeriodo.Click += new System.EventHandler(this.toolCambiaPeriodo_Click);
            // 
            // toolBusqueda
            // 
            this.toolBusqueda.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolBusqueda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFiltro,
            this.toolOrdenar,
            this.toolStripSeparator6,
            this.toolSobreRecibo,
            this.toolStripSeparator7,
            this.toolCalcular,
            this.toolMostrarDatos,
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.toolCargar,
            this.toolCargaVacaciones,
            this.toolCargaFaltas,
            this.toolActualizar,
            this.toolStripSeparator1,
            this.toolCerrar,
            this.toolStripSeparator4});
            this.toolBusqueda.Location = new System.Drawing.Point(0, 39);
            this.toolBusqueda.Name = "toolBusqueda";
            this.toolBusqueda.Size = new System.Drawing.Size(1420, 27);
            this.toolBusqueda.TabIndex = 10;
            this.toolBusqueda.Text = "ToolStrip1";
            this.toolBusqueda.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolBusqueda_ItemClicked);
            // 
            // toolFiltro
            // 
            this.toolFiltro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolTodos,
            this.toolDepartamento,
            this.toolPuesto,
            this.toolNoEmpleado});
            this.toolFiltro.Image = ((System.Drawing.Image)(resources.GetObject("toolFiltro.Image")));
            this.toolFiltro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFiltro.Name = "toolFiltro";
            this.toolFiltro.Size = new System.Drawing.Size(82, 24);
            this.toolFiltro.Text = "Filtro";
            // 
            // toolTodos
            // 
            this.toolTodos.Name = "toolTodos";
            this.toolTodos.Size = new System.Drawing.Size(181, 26);
            this.toolTodos.Text = "Todos";
            this.toolTodos.Click += new System.EventHandler(this.toolTodos_Click);
            // 
            // toolDepartamento
            // 
            this.toolDepartamento.Name = "toolDepartamento";
            this.toolDepartamento.Size = new System.Drawing.Size(181, 26);
            this.toolDepartamento.Text = "Departamento";
            this.toolDepartamento.Click += new System.EventHandler(this.toolDepartamento_Click);
            // 
            // toolPuesto
            // 
            this.toolPuesto.Name = "toolPuesto";
            this.toolPuesto.Size = new System.Drawing.Size(181, 26);
            this.toolPuesto.Text = "Puesto";
            this.toolPuesto.Click += new System.EventHandler(this.toolPuesto_Click);
            // 
            // toolNoEmpleado
            // 
            this.toolNoEmpleado.Name = "toolNoEmpleado";
            this.toolNoEmpleado.Size = new System.Drawing.Size(181, 26);
            this.toolNoEmpleado.Text = "No. Empleado";
            this.toolNoEmpleado.Click += new System.EventHandler(this.toolNoEmpleado_Click);
            // 
            // toolOrdenar
            // 
            this.toolOrdenar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolOrdenEmpleado,
            this.toolOrdenNombre,
            this.toolOrdenPaterno,
            this.toolOrdenMaterno});
            this.toolOrdenar.Image = ((System.Drawing.Image)(resources.GetObject("toolOrdenar.Image")));
            this.toolOrdenar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOrdenar.Name = "toolOrdenar";
            this.toolOrdenar.Size = new System.Drawing.Size(102, 24);
            this.toolOrdenar.Text = "Ordenar";
            // 
            // toolOrdenEmpleado
            // 
            this.toolOrdenEmpleado.Name = "toolOrdenEmpleado";
            this.toolOrdenEmpleado.Size = new System.Drawing.Size(200, 26);
            this.toolOrdenEmpleado.Text = "No. de Empleado";
            this.toolOrdenEmpleado.Click += new System.EventHandler(this.toolOrdenEmpleado_Click);
            // 
            // toolOrdenNombre
            // 
            this.toolOrdenNombre.Name = "toolOrdenNombre";
            this.toolOrdenNombre.Size = new System.Drawing.Size(200, 26);
            this.toolOrdenNombre.Text = "Nombre(s)";
            this.toolOrdenNombre.Click += new System.EventHandler(this.toolOrdenNombre_Click);
            // 
            // toolOrdenPaterno
            // 
            this.toolOrdenPaterno.Name = "toolOrdenPaterno";
            this.toolOrdenPaterno.Size = new System.Drawing.Size(200, 26);
            this.toolOrdenPaterno.Text = "Ap. Paterno";
            this.toolOrdenPaterno.Click += new System.EventHandler(this.toolOrdenPaterno_Click);
            // 
            // toolOrdenMaterno
            // 
            this.toolOrdenMaterno.Name = "toolOrdenMaterno";
            this.toolOrdenMaterno.Size = new System.Drawing.Size(200, 26);
            this.toolOrdenMaterno.Text = "Ap. Materno";
            this.toolOrdenMaterno.Click += new System.EventHandler(this.toolOrdenMaterno_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // toolSobreRecibo
            // 
            this.toolSobreRecibo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSobreRecibo.Image = ((System.Drawing.Image)(resources.GetObject("toolSobreRecibo.Image")));
            this.toolSobreRecibo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSobreRecibo.Name = "toolSobreRecibo";
            this.toolSobreRecibo.Size = new System.Drawing.Size(112, 24);
            this.toolSobreRecibo.Text = "Sobre - Recibo";
            this.toolSobreRecibo.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // toolCalcular
            // 
            this.toolCalcular.Image = ((System.Drawing.Image)(resources.GetObject("toolCalcular.Image")));
            this.toolCalcular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCalcular.Name = "toolCalcular";
            this.toolCalcular.Size = new System.Drawing.Size(86, 24);
            this.toolCalcular.Text = "Calcular";
            this.toolCalcular.Click += new System.EventHandler(this.toolCalcular_Click);
            // 
            // toolMostrarDatos
            // 
            this.toolMostrarDatos.Image = ((System.Drawing.Image)(resources.GetObject("toolMostrarDatos.Image")));
            this.toolMostrarDatos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMostrarDatos.Name = "toolMostrarDatos";
            this.toolMostrarDatos.Size = new System.Drawing.Size(125, 24);
            this.toolMostrarDatos.Text = "Mostrar datos";
            this.toolMostrarDatos.Click += new System.EventHandler(this.toolMostrarDatos_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(95, 24);
            this.toolStripButton1.Text = "Ver Faltas";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolCargar
            // 
            this.toolCargar.Image = ((System.Drawing.Image)(resources.GetObject("toolCargar.Image")));
            this.toolCargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCargar.Name = "toolCargar";
            this.toolCargar.Size = new System.Drawing.Size(181, 24);
            this.toolCargar.Text = "Importar Movimientos";
            this.toolCargar.Click += new System.EventHandler(this.toolCargar_Click);
            // 
            // toolCargaVacaciones
            // 
            this.toolCargaVacaciones.Image = ((System.Drawing.Image)(resources.GetObject("toolCargaVacaciones.Image")));
            this.toolCargaVacaciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCargaVacaciones.Name = "toolCargaVacaciones";
            this.toolCargaVacaciones.Size = new System.Drawing.Size(168, 24);
            this.toolCargaVacaciones.Text = "Importar Vacaciones";
            this.toolCargaVacaciones.Click += new System.EventHandler(this.toolCargaVacaciones_Click);
            // 
            // toolCargaFaltas
            // 
            this.toolCargaFaltas.Image = ((System.Drawing.Image)(resources.GetObject("toolCargaFaltas.Image")));
            this.toolCargaFaltas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCargaFaltas.Name = "toolCargaFaltas";
            this.toolCargaFaltas.Size = new System.Drawing.Size(132, 24);
            this.toolCargaFaltas.Text = "Importar Faltas";
            this.toolCargaFaltas.Click += new System.EventHandler(this.toolCargaFaltas_Click);
            // 
            // toolActualizar
            // 
            this.toolActualizar.Image = ((System.Drawing.Image)(resources.GetObject("toolActualizar.Image")));
            this.toolActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolActualizar.Name = "toolActualizar";
            this.toolActualizar.Size = new System.Drawing.Size(99, 24);
            this.toolActualizar.Text = "Actualizar";
            this.toolActualizar.Visible = false;
            this.toolActualizar.Click += new System.EventHandler(this.toolActualizar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtrabajador,
            this.iddepartamento,
            this.idpuesto,
            this.noempleado,
            this.nombres,
            this.paterno,
            this.materno,
            this.sueldo,
            this.despensa,
            this.asistencia,
            this.puntualidad,
            this.horas});
            this.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpleados.Location = new System.Drawing.Point(4, 4);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(1404, 521);
            this.dgvEmpleados.TabIndex = 11;
            this.dgvEmpleados.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellValueChanged);
            // 
            // idtrabajador
            // 
            this.idtrabajador.HeaderText = "Id";
            this.idtrabajador.Name = "idtrabajador";
            this.idtrabajador.ReadOnly = true;
            this.idtrabajador.Visible = false;
            // 
            // iddepartamento
            // 
            this.iddepartamento.HeaderText = "iddepartamento";
            this.iddepartamento.Name = "iddepartamento";
            this.iddepartamento.ReadOnly = true;
            this.iddepartamento.Visible = false;
            // 
            // idpuesto
            // 
            this.idpuesto.HeaderText = "idpuesto";
            this.idpuesto.Name = "idpuesto";
            this.idpuesto.ReadOnly = true;
            this.idpuesto.Visible = false;
            // 
            // noempleado
            // 
            this.noempleado.HeaderText = "No. Empleado";
            this.noempleado.Name = "noempleado";
            this.noempleado.ReadOnly = true;
            this.noempleado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nombres
            // 
            this.nombres.HeaderText = "Nombre";
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            // 
            // paterno
            // 
            this.paterno.HeaderText = "Paterno";
            this.paterno.Name = "paterno";
            this.paterno.ReadOnly = true;
            // 
            // materno
            // 
            this.materno.HeaderText = "Materno";
            this.materno.Name = "materno";
            this.materno.ReadOnly = true;
            // 
            // sueldo
            // 
            dataGridViewCellStyle1.Format = "C6";
            dataGridViewCellStyle1.NullValue = null;
            this.sueldo.DefaultCellStyle = dataGridViewCellStyle1;
            this.sueldo.HeaderText = "Sueldo";
            this.sueldo.Name = "sueldo";
            this.sueldo.ReadOnly = true;
            // 
            // despensa
            // 
            dataGridViewCellStyle2.Format = "C6";
            this.despensa.DefaultCellStyle = dataGridViewCellStyle2;
            this.despensa.HeaderText = "Despensa";
            this.despensa.Name = "despensa";
            this.despensa.ReadOnly = true;
            // 
            // asistencia
            // 
            dataGridViewCellStyle3.Format = "C6";
            this.asistencia.DefaultCellStyle = dataGridViewCellStyle3;
            this.asistencia.HeaderText = "Asistencia";
            this.asistencia.Name = "asistencia";
            this.asistencia.ReadOnly = true;
            // 
            // puntualidad
            // 
            dataGridViewCellStyle4.Format = "C6";
            this.puntualidad.DefaultCellStyle = dataGridViewCellStyle4;
            this.puntualidad.HeaderText = "Puntualidad";
            this.puntualidad.Name = "puntualidad";
            this.puntualidad.ReadOnly = true;
            // 
            // horas
            // 
            dataGridViewCellStyle5.Format = "C6";
            this.horas.DefaultCellStyle = dataGridViewCellStyle5;
            this.horas.HeaderText = "H. Extras Dobles";
            this.horas.Name = "horas";
            this.horas.ReadOnly = true;
            // 
            // workerCalculo
            // 
            this.workerCalculo.WorkerReportsProgress = true;
            this.workerCalculo.WorkerSupportsCancellation = true;
            this.workerCalculo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerCalculo_DoWork);
            this.workerCalculo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerCalculo_ProgressChanged);
            this.workerCalculo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerCalculo_RunWorkerCompleted);
            // 
            // BarraEstado
            // 
            this.BarraEstado.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolEstado,
            this.toolPorcentaje,
            this.toolEtapa});
            this.BarraEstado.Location = new System.Drawing.Point(0, 2);
            this.BarraEstado.Name = "BarraEstado";
            this.BarraEstado.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.BarraEstado.Size = new System.Drawing.Size(1420, 25);
            this.BarraEstado.TabIndex = 16;
            this.BarraEstado.Text = "statusStrip1";
            // 
            // toolEstado
            // 
            this.toolEstado.Name = "toolEstado";
            this.toolEstado.Size = new System.Drawing.Size(128, 20);
            this.toolEstado.Text = "Procesando:.............";
            // 
            // toolPorcentaje
            // 
            this.toolPorcentaje.Name = "toolPorcentaje";
            this.toolPorcentaje.Size = new System.Drawing.Size(29, 20);
            this.toolPorcentaje.Text = "0%";
            // 
            // toolEtapa
            // 
            this.toolEtapa.Name = "toolEtapa";
            this.toolEtapa.Size = new System.Drawing.Size(47, 20);
            this.toolEtapa.Text = "Etapa";
            // 
            // PanelBarra
            // 
            this.PanelBarra.Controls.Add(this.BarraEstado);
            this.PanelBarra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBarra.Location = new System.Drawing.Point(0, 624);
            this.PanelBarra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelBarra.Name = "PanelBarra";
            this.PanelBarra.Size = new System.Drawing.Size(1420, 27);
            this.PanelBarra.TabIndex = 17;
            // 
            // PanelGrid
            // 
            this.PanelGrid.Controls.Add(this.tabGrid);
            this.PanelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGrid.Location = new System.Drawing.Point(0, 66);
            this.PanelGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelGrid.Name = "PanelGrid";
            this.PanelGrid.Size = new System.Drawing.Size(1420, 558);
            this.PanelGrid.TabIndex = 18;
            // 
            // tabGrid
            // 
            this.tabGrid.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabGrid.Controls.Add(this.tabCalculoNomina);
            this.tabGrid.Controls.Add(this.tabFaltas);
            this.tabGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGrid.Location = new System.Drawing.Point(0, 0);
            this.tabGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabGrid.Name = "tabGrid";
            this.tabGrid.SelectedIndex = 0;
            this.tabGrid.Size = new System.Drawing.Size(1420, 558);
            this.tabGrid.TabIndex = 12;
            // 
            // tabCalculoNomina
            // 
            this.tabCalculoNomina.Controls.Add(this.btnCerrar);
            this.tabCalculoNomina.Controls.Add(this.txtBitacora);
            this.tabCalculoNomina.Controls.Add(this.dgvEmpleados);
            this.tabCalculoNomina.Location = new System.Drawing.Point(4, 4);
            this.tabCalculoNomina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCalculoNomina.Name = "tabCalculoNomina";
            this.tabCalculoNomina.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCalculoNomina.Size = new System.Drawing.Size(1412, 529);
            this.tabCalculoNomina.TabIndex = 0;
            this.tabCalculoNomina.Text = "Percepciones y Deducciones";
            this.tabCalculoNomina.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(297, 326);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 28);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Visible = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtBitacora
            // 
            this.txtBitacora.Location = new System.Drawing.Point(8, 49);
            this.txtBitacora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBitacora.Multiline = true;
            this.txtBitacora.Name = "txtBitacora";
            this.txtBitacora.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBitacora.Size = new System.Drawing.Size(388, 269);
            this.txtBitacora.TabIndex = 12;
            this.txtBitacora.Visible = false;
            // 
            // tabFaltas
            // 
            this.tabFaltas.Controls.Add(this.dgvFaltas);
            this.tabFaltas.Location = new System.Drawing.Point(4, 4);
            this.tabFaltas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabFaltas.Name = "tabFaltas";
            this.tabFaltas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabFaltas.Size = new System.Drawing.Size(1412, 525);
            this.tabFaltas.TabIndex = 1;
            this.tabFaltas.Text = "Faltas";
            this.tabFaltas.UseVisualStyleBackColor = true;
            // 
            // dgvFaltas
            // 
            this.dgvFaltas.AllowUserToAddRows = false;
            this.dgvFaltas.AllowUserToDeleteRows = false;
            this.dgvFaltas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaltas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFaltas.Location = new System.Drawing.Point(4, 4);
            this.dgvFaltas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFaltas.Name = "dgvFaltas";
            this.dgvFaltas.Size = new System.Drawing.Size(1404, 517);
            this.dgvFaltas.TabIndex = 0;
            this.dgvFaltas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaltas_CellValueChanged);
            this.dgvFaltas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvFaltas_KeyDown);
            // 
            // workExcel
            // 
            this.workExcel.WorkerReportsProgress = true;
            this.workExcel.WorkerSupportsCancellation = true;
            this.workExcel.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workExcel_DoWork);
            this.workExcel.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workExcel_ProgressChanged);
            this.workExcel.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workExcel_RunWorkerCompleted);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "No. Empleado";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Paterno";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Materno";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Sueldo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Despensa";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "P. Asist.";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewCellStyle6.Format = "C6";
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn8.HeaderText = "P. Puntualidad";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewCellStyle7.Format = "C6";
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn9.HeaderText = "H. Extras Dobles";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewCellStyle8.Format = "C6";
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn10.HeaderText = "Inicio";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewCellStyle9.Format = "C6";
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn11.HeaderText = "Fin";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewCellStyle10.Format = "C6";
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn12.HeaderText = "H. Extras Dobles";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "ID";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "No. Empleado";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Ap. Paterno";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Ap. Materno";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "Falta";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "Incapacidad";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "Falta";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.HeaderText = "Incapacidad";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // workerGravadosExentos
            // 
            this.workerGravadosExentos.WorkerReportsProgress = true;
            this.workerGravadosExentos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerGravadosExentos_DoWork);
            this.workerGravadosExentos.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerGravadosExentos_ProgressChanged);
            this.workerGravadosExentos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerGravadosExentos_RunWorkerCompleted);
            // 
            // frmListaCalculoNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 651);
            this.Controls.Add(this.PanelGrid);
            this.Controls.Add(this.PanelBarra);
            this.Controls.Add(this.toolBusqueda);
            this.Controls.Add(this.toolTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListaCalculoNomina";
            this.Text = "Nomina";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmListaCalculoNomina_FormClosed);
            this.Load += new System.EventHandler(this.frmListaCalculoNomina_Load);
            this.toolTitulo.ResumeLayout(false);
            this.toolTitulo.PerformLayout();
            this.toolBusqueda.ResumeLayout(false);
            this.toolBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.BarraEstado.ResumeLayout(false);
            this.BarraEstado.PerformLayout();
            this.PanelBarra.ResumeLayout(false);
            this.PanelBarra.PerformLayout();
            this.PanelGrid.ResumeLayout(false);
            this.tabGrid.ResumeLayout(false);
            this.tabCalculoNomina.ResumeLayout(false);
            this.tabCalculoNomina.PerformLayout();
            this.tabFaltas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaltas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolTitulo;
        internal System.Windows.Forms.ToolStrip toolBusqueda;
        private System.Windows.Forms.ToolStripButton toolCargar;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.ToolStripButton toolCalcular;
        private System.Windows.Forms.ToolStripSplitButton toolFiltro;
        private System.Windows.Forms.ToolStripMenuItem toolDepartamento;
        private System.Windows.Forms.ToolStripMenuItem toolPuesto;
        private System.Windows.Forms.ToolStripMenuItem toolTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.ComponentModel.BackgroundWorker workerCalculo;
        private System.Windows.Forms.StatusStrip BarraEstado;
        private System.Windows.Forms.Panel PanelBarra;
        private System.Windows.Forms.Panel PanelGrid;
        private System.Windows.Forms.ToolStripStatusLabel toolEstado;
        private System.Windows.Forms.ToolStripStatusLabel toolPorcentaje;
        private System.Windows.Forms.ToolStripStatusLabel toolEtapa;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSeparator toolSeparadorAutorizar;
        private System.Windows.Forms.ToolStripButton toolCerrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolAutorizar;
        private System.Windows.Forms.ToolStripMenuItem toolNoEmpleado;
        private System.Windows.Forms.ToolStripMenuItem toolReportes;
        private System.Windows.Forms.ToolStripMenuItem toolCaratula;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolReporteDepto;
        private System.Windows.Forms.TabControl tabGrid;
        private System.Windows.Forms.TabPage tabCalculoNomina;
        private System.Windows.Forms.TabPage tabFaltas;
        private System.Windows.Forms.DataGridView dgvFaltas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.ToolStripMenuItem toolTabular;
        private System.ComponentModel.BackgroundWorker workExcel;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSplitButton toolOrdenar;
        private System.Windows.Forms.ToolStripMenuItem toolOrdenEmpleado;
        private System.Windows.Forms.ToolStripMenuItem toolOrdenNombre;
        private System.Windows.Forms.ToolStripMenuItem toolOrdenPaterno;
        private System.Windows.Forms.ToolStripMenuItem toolOrdenMaterno;
        private System.Windows.Forms.ToolStripButton toolSobreRecibo;
        private System.Windows.Forms.ToolStripButton toolMostrarDatos;
        private System.Windows.Forms.ToolStripLabel toolPeriodo;
        private System.Windows.Forms.ToolStripButton toolCambiaPeriodo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolCargaVacaciones;
        private System.Windows.Forms.ToolStripButton toolCargaFaltas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtrabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn noempleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn despensa;
        private System.Windows.Forms.DataGridViewTextBoxColumn asistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntualidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas;
        private System.Windows.Forms.ToolStripMenuItem toolReciboNomina;
        private System.Windows.Forms.ToolStripMenuItem toolGuardar;
        private System.Windows.Forms.ToolStripSeparator toolSeparadorGuardar;
        private System.Windows.Forms.ToolStripMenuItem toolGravadosExentos;
        private System.ComponentModel.BackgroundWorker workerGravadosExentos;
        private System.Windows.Forms.TextBox txtBitacora;
        private System.Windows.Forms.Button btnCerrar;
    }
}