namespace Nominas
{
    partial class frmCancelacionRecibosNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelacionRecibosNomina));
            this.rbtnExtraordinario = new System.Windows.Forms.RadioButton();
            this.tool = new System.Windows.Forms.StatusStrip();
            this.toolLabelProgreso = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolLabelAvance = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolLabelEtapa = new System.Windows.Forms.ToolStripStatusLabel();
            this.rbtnOrdinaria = new System.Windows.Forms.RadioButton();
            this.btnErrores = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelarTodo = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVer = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbPeriodos = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.workCancelarTodo = new System.ComponentModel.BackgroundWorker();
            this.tool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisorRecibos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // tool
            // 
            this.tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolLabelProgreso,
            this.toolLabelAvance,
            this.toolLabelEtapa});
            this.tool.Location = new System.Drawing.Point(0, 528);
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
            // btnErrores
            // 
            this.btnErrores.Image = ((System.Drawing.Image)(resources.GetObject("btnErrores.Image")));
            this.btnErrores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnErrores.Location = new System.Drawing.Point(1099, 12);
            this.btnErrores.Name = "btnErrores";
            this.btnErrores.Size = new System.Drawing.Size(82, 52);
            this.btnErrores.TabIndex = 26;
            this.btnErrores.Text = "Errores";
            this.btnErrores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnErrores.UseVisualStyleBackColor = true;
            this.btnErrores.Click += new System.EventHandler(this.btnErrores_Click);
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
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Error";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // btnCancelarTodo
            // 
            this.btnCancelarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarTodo.Image")));
            this.btnCancelarTodo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarTodo.Location = new System.Drawing.Point(923, 12);
            this.btnCancelarTodo.Name = "btnCancelarTodo";
            this.btnCancelarTodo.Size = new System.Drawing.Size(82, 52);
            this.btnCancelarTodo.TabIndex = 22;
            this.btnCancelarTodo.Text = "Cancelar todo";
            this.btnCancelarTodo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarTodo.UseVisualStyleBackColor = true;
            this.btnCancelarTodo.Click += new System.EventHandler(this.btnCancelarTodo_Click);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Periodo Fin";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.SystemColors.Control;
            this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVer.Location = new System.Drawing.Point(358, 11);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(77, 52);
            this.btnVer.TabIndex = 10;
            this.btnVer.Text = "Ver recibos";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "No. Empleado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Periodo Inicio";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha de Timbrado";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "UUID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Empleado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
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
            this.dgvVisorRecibos.Size = new System.Drawing.Size(1180, 528);
            this.dgvVisorRecibos.TabIndex = 0;
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
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel1.Controls.Add(this.btnErrores);
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelarTodo);
            this.splitContainer1.Panel1.Controls.Add(this.btnVer);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvVisorRecibos);
            this.splitContainer1.Panel2.Controls.Add(this.tool);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 635);
            this.splitContainer1.SplitterDistance = 77;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(1011, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 52);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbPeriodos);
            this.groupBox2.Location = new System.Drawing.Point(180, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 60);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fechas";
            // 
            // cmbPeriodos
            // 
            this.cmbPeriodos.FormattingEnabled = true;
            this.cmbPeriodos.Location = new System.Drawing.Point(6, 23);
            this.cmbPeriodos.Name = "cmbPeriodos";
            this.cmbPeriodos.Size = new System.Drawing.Size(160, 21);
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
            // workCancelarTodo
            // 
            this.workCancelarTodo.WorkerReportsProgress = true;
            this.workCancelarTodo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workCancelarTodo_DoWork);
            this.workCancelarTodo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workCancelarTodo_ProgressChanged);
            this.workCancelarTodo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workCancelarTodo_RunWorkerCompleted);
            // 
            // frmCancelacionRecibosNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 635);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 674);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 674);
            this.Name = "frmCancelacionRecibosNomina";
            this.Text = "Cancelacion de recibos de nómina";
            this.Load += new System.EventHandler(this.frmCancelacionRecibosNomina_Load);
            this.tool.ResumeLayout(false);
            this.tool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisorRecibos)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnExtraordinario;
        private System.Windows.Forms.StatusStrip tool;
        private System.Windows.Forms.ToolStripStatusLabel toolLabelProgreso;
        private System.Windows.Forms.ToolStripStatusLabel toolLabelAvance;
        private System.Windows.Forms.ToolStripStatusLabel toolLabelEtapa;
        private System.Windows.Forms.RadioButton rbtnOrdinaria;
        private System.Windows.Forms.Button btnErrores;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btnCancelarTodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dgvVisorRecibos;
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbPeriodos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.ComponentModel.BackgroundWorker workCancelarTodo;
    }
}