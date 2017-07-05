namespace Nominas
{
    partial class frmConceptosEmpresa
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
            this.toolAcciones = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dgvConceptos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noconcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolAcciones
            // 
            this.toolAcciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolAcciones.Location = new System.Drawing.Point(0, 0);
            this.toolAcciones.Name = "toolAcciones";
            this.toolAcciones.Size = new System.Drawing.Size(794, 25);
            this.toolAcciones.TabIndex = 8;
            this.toolAcciones.Text = "toolEmpresa";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel1.Text = "Periodo:";
            // 
            // dgvConceptos
            // 
            this.dgvConceptos.AllowUserToAddRows = false;
            this.dgvConceptos.AllowUserToDeleteRows = false;
            this.dgvConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConceptos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.noconcepto,
            this.concepto,
            this.asignacion});
            this.dgvConceptos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConceptos.Location = new System.Drawing.Point(0, 25);
            this.dgvConceptos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConceptos.Name = "dgvConceptos";
            this.dgvConceptos.RowHeadersVisible = false;
            this.dgvConceptos.Size = new System.Drawing.Size(794, 510);
            this.dgvConceptos.TabIndex = 9;
            this.dgvConceptos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConceptos_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // noconcepto
            // 
            this.noconcepto.HeaderText = "No. Concepto";
            this.noconcepto.Name = "noconcepto";
            // 
            // concepto
            // 
            this.concepto.HeaderText = "Concepto";
            this.concepto.Name = "concepto";
            // 
            // asignacion
            // 
            this.asignacion.HeaderText = "Asignar";
            this.asignacion.Name = "asignacion";
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(75, 1);
            this.cmbPeriodo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(160, 24);
            this.cmbPeriodo.TabIndex = 10;
            this.cmbPeriodo.SelectedIndexChanged += new System.EventHandler(this.cmbPeriodo_SelectedIndexChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "No. Concepto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Concepto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // frmConceptosEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 535);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.dgvConceptos);
            this.Controls.Add(this.toolAcciones);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConceptosEmpresa";
            this.Text = "Asignacion de conceptos al trabajador";
            this.Load += new System.EventHandler(this.frmConceptosEmpresa_Load);
            this.toolAcciones.ResumeLayout(false);
            this.toolAcciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolAcciones;
        private System.Windows.Forms.DataGridView dgvConceptos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn noconcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn concepto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn asignacion;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}