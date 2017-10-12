namespace Nominas
{
    partial class frmVisorRecibosCancelados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisorRecibosCancelados));
            this.dgvVisorRecibos = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnFolioFiscal = new System.Windows.Forms.RadioButton();
            this.rbtnFechas = new System.Windows.Forms.RadioButton();
            this.gbxFolios = new System.Windows.Forms.GroupBox();
            this.mtxtFolioFiscal = new System.Windows.Forms.MaskedTextBox();
            this.btnAcuse = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbxFechas = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.workCancelarTodo = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisorRecibos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbxFolios.SuspendLayout();
            this.gbxFechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVisorRecibos
            // 
            this.dgvVisorRecibos.AllowUserToAddRows = false;
            this.dgvVisorRecibos.AllowUserToDeleteRows = false;
            this.dgvVisorRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisorRecibos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uuid,
            this.fecha,
            this.respuesta,
            this.folio});
            this.dgvVisorRecibos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVisorRecibos.Location = new System.Drawing.Point(0, 0);
            this.dgvVisorRecibos.Name = "dgvVisorRecibos";
            this.dgvVisorRecibos.ReadOnly = true;
            this.dgvVisorRecibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisorRecibos.Size = new System.Drawing.Size(868, 550);
            this.dgvVisorRecibos.TabIndex = 0;
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.gbxFolios);
            this.splitContainer1.Panel1.Controls.Add(this.btnAcuse);
            this.splitContainer1.Panel1.Controls.Add(this.btnBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.gbxFechas);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvVisorRecibos);
            this.splitContainer1.Size = new System.Drawing.Size(872, 635);
            this.splitContainer1.SplitterDistance = 77;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnFolioFiscal);
            this.groupBox3.Controls.Add(this.rbtnFechas);
            this.groupBox3.Location = new System.Drawing.Point(10, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(127, 65);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de busqueda";
            // 
            // rbtnFolioFiscal
            // 
            this.rbtnFolioFiscal.AutoSize = true;
            this.rbtnFolioFiscal.Location = new System.Drawing.Point(6, 38);
            this.rbtnFolioFiscal.Name = "rbtnFolioFiscal";
            this.rbtnFolioFiscal.Size = new System.Drawing.Size(90, 17);
            this.rbtnFolioFiscal.TabIndex = 1;
            this.rbtnFolioFiscal.TabStop = true;
            this.rbtnFolioFiscal.Text = "Por folio fiscal";
            this.rbtnFolioFiscal.UseVisualStyleBackColor = true;
            this.rbtnFolioFiscal.CheckedChanged += new System.EventHandler(this.rbtnFolioFiscal_CheckedChanged);
            // 
            // rbtnFechas
            // 
            this.rbtnFechas.AutoSize = true;
            this.rbtnFechas.Location = new System.Drawing.Point(6, 16);
            this.rbtnFechas.Name = "rbtnFechas";
            this.rbtnFechas.Size = new System.Drawing.Size(76, 17);
            this.rbtnFechas.TabIndex = 0;
            this.rbtnFechas.TabStop = true;
            this.rbtnFechas.Text = "Por fechas";
            this.rbtnFechas.UseVisualStyleBackColor = true;
            this.rbtnFechas.CheckedChanged += new System.EventHandler(this.rbtnFechas_CheckedChanged);
            // 
            // gbxFolios
            // 
            this.gbxFolios.Controls.Add(this.mtxtFolioFiscal);
            this.gbxFolios.Location = new System.Drawing.Point(425, 5);
            this.gbxFolios.Name = "gbxFolios";
            this.gbxFolios.Size = new System.Drawing.Size(231, 65);
            this.gbxFolios.TabIndex = 23;
            this.gbxFolios.TabStop = false;
            this.gbxFolios.Text = "Folio Fiscal";
            // 
            // mtxtFolioFiscal
            // 
            this.mtxtFolioFiscal.AsciiOnly = true;
            this.mtxtFolioFiscal.Location = new System.Drawing.Point(6, 25);
            this.mtxtFolioFiscal.Mask = "AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA";
            this.mtxtFolioFiscal.Name = "mtxtFolioFiscal";
            this.mtxtFolioFiscal.Size = new System.Drawing.Size(215, 20);
            this.mtxtFolioFiscal.TabIndex = 0;
            // 
            // btnAcuse
            // 
            this.btnAcuse.Image = ((System.Drawing.Image)(resources.GetObject("btnAcuse.Image")));
            this.btnAcuse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAcuse.Location = new System.Drawing.Point(775, 13);
            this.btnAcuse.Name = "btnAcuse";
            this.btnAcuse.Size = new System.Drawing.Size(82, 52);
            this.btnAcuse.TabIndex = 22;
            this.btnAcuse.Text = "Acuse";
            this.btnAcuse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAcuse.UseVisualStyleBackColor = true;
            this.btnAcuse.Click += new System.EventHandler(this.btnAcuse_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(662, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(77, 52);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbxFechas
            // 
            this.gbxFechas.Controls.Add(this.label2);
            this.gbxFechas.Controls.Add(this.dtpHasta);
            this.gbxFechas.Controls.Add(this.label1);
            this.gbxFechas.Controls.Add(this.dtpDe);
            this.gbxFechas.Location = new System.Drawing.Point(143, 5);
            this.gbxFechas.Name = "gbxFechas";
            this.gbxFechas.Size = new System.Drawing.Size(276, 65);
            this.gbxFechas.TabIndex = 8;
            this.gbxFechas.TabStop = false;
            this.gbxFechas.Text = "Fechas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(62, 37);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "De:";
            // 
            // dtpDe
            // 
            this.dtpDe.Location = new System.Drawing.Point(62, 12);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(200, 20);
            this.dtpDe.TabIndex = 24;
            // 
            // workCancelarTodo
            // 
            this.workCancelarTodo.WorkerReportsProgress = true;
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
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "UUID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Error";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Periodo Fin";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
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
            // uuid
            // 
            this.uuid.HeaderText = "UUID";
            this.uuid.Name = "uuid";
            this.uuid.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha de Cancelación";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // respuesta
            // 
            this.respuesta.HeaderText = "Estatus";
            this.respuesta.Name = "respuesta";
            this.respuesta.ReadOnly = true;
            // 
            // folio
            // 
            this.folio.HeaderText = "Folio";
            this.folio.Name = "folio";
            this.folio.ReadOnly = true;
            // 
            // frmVisorRecibosCancelados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 635);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVisorRecibosCancelados";
            this.Text = "Visor de recibos cancelados";
            this.Load += new System.EventHandler(this.frmVisorRecibosCancelados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisorRecibos)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbxFolios.ResumeLayout(false);
            this.gbxFolios.PerformLayout();
            this.gbxFechas.ResumeLayout(false);
            this.gbxFechas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisorRecibos;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAcuse;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbxFechas;
        private System.ComponentModel.BackgroundWorker workCancelarTodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.GroupBox gbxFolios;
        private System.Windows.Forms.MaskedTextBox mtxtFolioFiscal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnFolioFiscal;
        private System.Windows.Forms.RadioButton rbtnFechas;
        private System.Windows.Forms.DataGridViewTextBoxColumn uuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn respuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn folio;
    }
}