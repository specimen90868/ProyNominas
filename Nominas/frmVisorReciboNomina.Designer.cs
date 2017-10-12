namespace Nominas
{
    partial class frmVisorReciboNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisorReciboNomina));
            this.dgvVisorRecibos = new System.Windows.Forms.DataGridView();
            this.idtrabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emitido = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.noempleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechatimbrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodoinicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodofin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnErrores = new System.Windows.Forms.Button();
            this.btnTimbrar = new System.Windows.Forms.Button();
            this.btnTimbrarTodo = new System.Windows.Forms.Button();
            this.btnSellar = new System.Windows.Forms.Button();
            this.btnSellarTodo = new System.Windows.Forms.Button();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.lblTimbrados = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.lblNoRegistros = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkTimbrados = new System.Windows.Forms.CheckBox();
            this.chkNoTimbrados = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbPeriodos = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnExtraordinario = new System.Windows.Forms.RadioButton();
            this.rbtnOrdinaria = new System.Windows.Forms.RadioButton();
            this.tool = new System.Windows.Forms.StatusStrip();
            this.toolLabelProgreso = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolLabelAvance = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolLabelEtapa = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workSellarTodo = new System.ComponentModel.BackgroundWorker();
            this.workTimbrarTodo = new System.ComponentModel.BackgroundWorker();
            this.workSello = new System.ComponentModel.BackgroundWorker();
            this.workTrimbrado = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisorRecibos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tool.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVisorRecibos
            // 
            this.dgvVisorRecibos.AllowUserToAddRows = false;
            this.dgvVisorRecibos.AllowUserToDeleteRows = false;
            this.dgvVisorRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisorRecibos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtrabajador,
            this.emitido,
            this.noempleado,
            this.nombrecompleto,
            this.uuid,
            this.fechatimbrado,
            this.periodoinicio,
            this.periodofin,
            this.folio,
            this.error});
            this.dgvVisorRecibos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVisorRecibos.Location = new System.Drawing.Point(0, 0);
            this.dgvVisorRecibos.Name = "dgvVisorRecibos";
            this.dgvVisorRecibos.ReadOnly = true;
            this.dgvVisorRecibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisorRecibos.Size = new System.Drawing.Size(1180, 526);
            this.dgvVisorRecibos.TabIndex = 0;
            this.dgvVisorRecibos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisorRecibos_CellDoubleClick);
            // 
            // idtrabajador
            // 
            this.idtrabajador.HeaderText = "idtrabajador";
            this.idtrabajador.Name = "idtrabajador";
            this.idtrabajador.ReadOnly = true;
            this.idtrabajador.Visible = false;
            // 
            // emitido
            // 
            this.emitido.HeaderText = "Timbrado";
            this.emitido.Name = "emitido";
            this.emitido.ReadOnly = true;
            this.emitido.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.emitido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // noempleado
            // 
            this.noempleado.HeaderText = "No. Empleado";
            this.noempleado.Name = "noempleado";
            this.noempleado.ReadOnly = true;
            // 
            // nombrecompleto
            // 
            this.nombrecompleto.HeaderText = "Empleado";
            this.nombrecompleto.Name = "nombrecompleto";
            this.nombrecompleto.ReadOnly = true;
            // 
            // uuid
            // 
            this.uuid.HeaderText = "UUID";
            this.uuid.Name = "uuid";
            this.uuid.ReadOnly = true;
            // 
            // fechatimbrado
            // 
            this.fechatimbrado.HeaderText = "Fecha de Timbrado";
            this.fechatimbrado.Name = "fechatimbrado";
            this.fechatimbrado.ReadOnly = true;
            // 
            // periodoinicio
            // 
            this.periodoinicio.HeaderText = "Periodo Inicio";
            this.periodoinicio.Name = "periodoinicio";
            this.periodoinicio.ReadOnly = true;
            // 
            // periodofin
            // 
            this.periodofin.HeaderText = "Periodo Fin";
            this.periodofin.Name = "periodofin";
            this.periodofin.ReadOnly = true;
            // 
            // folio
            // 
            this.folio.HeaderText = "Folio";
            this.folio.Name = "folio";
            this.folio.ReadOnly = true;
            // 
            // error
            // 
            this.error.HeaderText = "Error";
            this.error.Name = "error";
            this.error.ReadOnly = true;
            this.error.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.btnErrores);
            this.splitContainer1.Panel1.Controls.Add(this.btnTimbrar);
            this.splitContainer1.Panel1.Controls.Add(this.btnTimbrarTodo);
            this.splitContainer1.Panel1.Controls.Add(this.btnSellar);
            this.splitContainer1.Panel1.Controls.Add(this.btnSellarTodo);
            this.splitContainer1.Panel1.Controls.Add(this.lblPendientes);
            this.splitContainer1.Panel1.Controls.Add(this.lblTimbrados);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lblRegistros);
            this.splitContainer1.Panel1.Controls.Add(this.lblNoRegistros);
            this.splitContainer1.Panel1.Controls.Add(this.btnVer);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvVisorRecibos);
            this.splitContainer1.Panel2.Controls.Add(this.tool);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 635);
            this.splitContainer1.SplitterDistance = 79;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnErrores
            // 
            this.btnErrores.Image = ((System.Drawing.Image)(resources.GetObject("btnErrores.Image")));
            this.btnErrores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnErrores.Location = new System.Drawing.Point(1102, 11);
            this.btnErrores.Name = "btnErrores";
            this.btnErrores.Size = new System.Drawing.Size(75, 52);
            this.btnErrores.TabIndex = 26;
            this.btnErrores.Text = "Errores";
            this.btnErrores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnErrores.UseVisualStyleBackColor = true;
            this.btnErrores.Click += new System.EventHandler(this.btnErrores_Click);
            // 
            // btnTimbrar
            // 
            this.btnTimbrar.Image = ((System.Drawing.Image)(resources.GetObject("btnTimbrar.Image")));
            this.btnTimbrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimbrar.Location = new System.Drawing.Point(1022, 11);
            this.btnTimbrar.Name = "btnTimbrar";
            this.btnTimbrar.Size = new System.Drawing.Size(77, 52);
            this.btnTimbrar.TabIndex = 25;
            this.btnTimbrar.Text = "Timbrar";
            this.btnTimbrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimbrar.UseVisualStyleBackColor = true;
            this.btnTimbrar.Click += new System.EventHandler(this.btnTimbrar_Click);
            // 
            // btnTimbrarTodo
            // 
            this.btnTimbrarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnTimbrarTodo.Image")));
            this.btnTimbrarTodo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimbrarTodo.Location = new System.Drawing.Point(860, 11);
            this.btnTimbrarTodo.Name = "btnTimbrarTodo";
            this.btnTimbrarTodo.Size = new System.Drawing.Size(77, 52);
            this.btnTimbrarTodo.TabIndex = 24;
            this.btnTimbrarTodo.Text = "Timbrar todo";
            this.btnTimbrarTodo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimbrarTodo.UseVisualStyleBackColor = true;
            this.btnTimbrarTodo.Click += new System.EventHandler(this.btnTimbrarTodo_Click);
            // 
            // btnSellar
            // 
            this.btnSellar.Image = ((System.Drawing.Image)(resources.GetObject("btnSellar.Image")));
            this.btnSellar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSellar.Location = new System.Drawing.Point(944, 11);
            this.btnSellar.Name = "btnSellar";
            this.btnSellar.Size = new System.Drawing.Size(77, 52);
            this.btnSellar.TabIndex = 23;
            this.btnSellar.Text = "Sellar";
            this.btnSellar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSellar.UseVisualStyleBackColor = true;
            this.btnSellar.Click += new System.EventHandler(this.btnSellar_Click);
            // 
            // btnSellarTodo
            // 
            this.btnSellarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnSellarTodo.Image")));
            this.btnSellarTodo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSellarTodo.Location = new System.Drawing.Point(782, 11);
            this.btnSellarTodo.Name = "btnSellarTodo";
            this.btnSellarTodo.Size = new System.Drawing.Size(77, 52);
            this.btnSellarTodo.TabIndex = 22;
            this.btnSellarTodo.Text = "Sellar todo";
            this.btnSellarTodo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSellarTodo.UseVisualStyleBackColor = true;
            this.btnSellarTodo.Click += new System.EventHandler(this.btnSellarTodo_Click);
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPendientes.Location = new System.Drawing.Point(669, 46);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(13, 13);
            this.lblPendientes.TabIndex = 21;
            this.lblPendientes.Text = "0";
            // 
            // lblTimbrados
            // 
            this.lblTimbrados.AutoSize = true;
            this.lblTimbrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimbrados.ForeColor = System.Drawing.Color.Green;
            this.lblTimbrados.Location = new System.Drawing.Point(669, 29);
            this.lblTimbrados.Name = "lblTimbrados";
            this.lblTimbrados.Size = new System.Drawing.Size(13, 13);
            this.lblTimbrados.TabIndex = 20;
            this.lblTimbrados.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Pendientes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Timbrados:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.ForeColor = System.Drawing.Color.Blue;
            this.lblRegistros.Location = new System.Drawing.Point(669, 12);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(13, 13);
            this.lblRegistros.TabIndex = 16;
            this.lblRegistros.Text = "0";
            // 
            // lblNoRegistros
            // 
            this.lblNoRegistros.AutoSize = true;
            this.lblNoRegistros.Location = new System.Drawing.Point(591, 12);
            this.lblNoRegistros.Name = "lblNoRegistros";
            this.lblNoRegistros.Size = new System.Drawing.Size(74, 13);
            this.lblNoRegistros.TabIndex = 15;
            this.lblNoRegistros.Text = "No. Registros:";
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.SystemColors.Control;
            this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVer.Location = new System.Drawing.Point(508, 10);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(77, 52);
            this.btnVer.TabIndex = 10;
            this.btnVer.Text = "Ver recibos";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkTimbrados);
            this.groupBox3.Controls.Add(this.chkNoTimbrados);
            this.groupBox3.Location = new System.Drawing.Point(346, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(156, 60);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estatus";
            // 
            // chkTimbrados
            // 
            this.chkTimbrados.AutoSize = true;
            this.chkTimbrados.Location = new System.Drawing.Point(56, 14);
            this.chkTimbrados.Name = "chkTimbrados";
            this.chkTimbrados.Size = new System.Drawing.Size(75, 17);
            this.chkTimbrados.TabIndex = 0;
            this.chkTimbrados.Text = "Timbrados";
            this.chkTimbrados.UseVisualStyleBackColor = true;
            // 
            // chkNoTimbrados
            // 
            this.chkNoTimbrados.AutoSize = true;
            this.chkNoTimbrados.Location = new System.Drawing.Point(56, 37);
            this.chkNoTimbrados.Name = "chkNoTimbrados";
            this.chkNoTimbrados.Size = new System.Drawing.Size(92, 17);
            this.chkNoTimbrados.TabIndex = 1;
            this.chkNoTimbrados.Text = "No Timbrados";
            this.chkNoTimbrados.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbPeriodos);
            this.groupBox2.Location = new System.Drawing.Point(180, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 60);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fechas";
            // 
            // cmbPeriodos
            // 
            this.cmbPeriodos.FormattingEnabled = true;
            this.cmbPeriodos.Location = new System.Drawing.Point(6, 23);
            this.cmbPeriodos.Name = "cmbPeriodos";
            this.cmbPeriodos.Size = new System.Drawing.Size(148, 21);
            this.cmbPeriodos.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnExtraordinario);
            this.groupBox1.Controls.Add(this.rbtnOrdinaria);
            this.groupBox1.Location = new System.Drawing.Point(10, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 60);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Periodo";
            // 
            // rbtnExtraordinario
            // 
            this.rbtnExtraordinario.AutoSize = true;
            this.rbtnExtraordinario.Location = new System.Drawing.Point(19, 36);
            this.rbtnExtraordinario.Name = "rbtnExtraordinario";
            this.rbtnExtraordinario.Size = new System.Drawing.Size(127, 17);
            this.rbtnExtraordinario.TabIndex = 6;
            this.rbtnExtraordinario.Text = "Periodo extraordinario";
            this.rbtnExtraordinario.UseVisualStyleBackColor = true;
            this.rbtnExtraordinario.CheckedChanged += new System.EventHandler(this.rbtnExtraordinario_CheckedChanged);
            // 
            // rbtnOrdinaria
            // 
            this.rbtnOrdinaria.AutoSize = true;
            this.rbtnOrdinaria.Checked = true;
            this.rbtnOrdinaria.Location = new System.Drawing.Point(19, 15);
            this.rbtnOrdinaria.Name = "rbtnOrdinaria";
            this.rbtnOrdinaria.Size = new System.Drawing.Size(104, 17);
            this.rbtnOrdinaria.TabIndex = 5;
            this.rbtnOrdinaria.TabStop = true;
            this.rbtnOrdinaria.Text = "Periodo ordinario";
            this.rbtnOrdinaria.UseVisualStyleBackColor = true;
            this.rbtnOrdinaria.CheckedChanged += new System.EventHandler(this.rbtnOrdinaria_CheckedChanged);
            // 
            // tool
            // 
            this.tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolLabelProgreso,
            this.toolLabelAvance,
            this.toolLabelEtapa});
            this.tool.Location = new System.Drawing.Point(0, 526);
            this.tool.Name = "tool";
            this.tool.Size = new System.Drawing.Size(1180, 22);
            this.tool.TabIndex = 1;
            this.tool.Text = "statusStrip1";
            // 
            // toolLabelProgreso
            // 
            this.toolLabelProgreso.Name = "toolLabelProgreso";
            this.toolLabelProgreso.Size = new System.Drawing.Size(57, 17);
            this.toolLabelProgreso.Text = "Progreso:";
            // 
            // toolLabelAvance
            // 
            this.toolLabelAvance.Name = "toolLabelAvance";
            this.toolLabelAvance.Size = new System.Drawing.Size(23, 17);
            this.toolLabelAvance.Text = "0%";
            // 
            // toolLabelEtapa
            // 
            this.toolLabelEtapa.Name = "toolLabelEtapa";
            this.toolLabelEtapa.Size = new System.Drawing.Size(0, 17);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "idtrabajador";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Timbrado";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "No. Empleado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Empleado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "UUID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha de Timbrado";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Periodo Inicio";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Periodo Fin";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Error";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // workSellarTodo
            // 
            this.workSellarTodo.WorkerReportsProgress = true;
            this.workSellarTodo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workSellarTodo_DoWork);
            this.workSellarTodo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workSellarTodo_ProgressChanged);
            this.workSellarTodo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workSellarTodo_RunWorkerCompleted);
            // 
            // workTimbrarTodo
            // 
            this.workTimbrarTodo.WorkerReportsProgress = true;
            this.workTimbrarTodo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workTimbrarTodo_DoWork);
            this.workTimbrarTodo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workTimbrarTodo_ProgressChanged);
            this.workTimbrarTodo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workTimbrarTodo_RunWorkerCompleted);
            // 
            // workSello
            // 
            this.workSello.WorkerReportsProgress = true;
            this.workSello.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workSello_DoWork);
            this.workSello.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workSello_ProgressChanged);
            this.workSello.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workSello_RunWorkerCompleted);
            // 
            // workTrimbrado
            // 
            this.workTrimbrado.WorkerReportsProgress = true;
            this.workTrimbrado.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workTrimbrado_DoWork);
            this.workTrimbrado.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workTrimbrado_ProgressChanged);
            this.workTrimbrado.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workTrimbrado_RunWorkerCompleted);
            // 
            // frmVisorReciboNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 635);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 674);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 674);
            this.Name = "frmVisorReciboNomina";
            this.Text = "Visor de recibos de nómina";
            this.Load += new System.EventHandler(this.frmVisorReciboNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisorRecibos)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tool.ResumeLayout(false);
            this.tool.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisorRecibos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox chkNoTimbrados;
        private System.Windows.Forms.CheckBox chkTimbrados;
        private System.Windows.Forms.RadioButton rbtnExtraordinario;
        private System.Windows.Forms.RadioButton rbtnOrdinaria;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.StatusStrip tool;
        private System.Windows.Forms.ToolStripStatusLabel toolLabelProgreso;
        private System.Windows.Forms.ToolStripStatusLabel toolLabelAvance;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtrabajador;
        private System.Windows.Forms.DataGridViewCheckBoxColumn emitido;
        private System.Windows.Forms.DataGridViewTextBoxColumn noempleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn uuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechatimbrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodoinicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodofin;
        private System.Windows.Forms.DataGridViewTextBoxColumn folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn error;
        private System.Windows.Forms.ToolStripStatusLabel toolLabelEtapa;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label lblNoRegistros;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Label lblTimbrados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSellar;
        private System.Windows.Forms.Button btnSellarTodo;
        private System.ComponentModel.BackgroundWorker workSellarTodo;
        private System.Windows.Forms.Button btnTimbrarTodo;
        private System.ComponentModel.BackgroundWorker workTimbrarTodo;
        private System.ComponentModel.BackgroundWorker workSello;
        private System.Windows.Forms.Button btnTimbrar;
        private System.ComponentModel.BackgroundWorker workTrimbrado;
        private System.Windows.Forms.Button btnErrores;
        private System.Windows.Forms.ComboBox cmbPeriodos;
    }
}