namespace Nominas
{
    partial class frmListaCargaMovimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaCargaMovimientos));
            this.toolBusqueda = new System.Windows.Forms.ToolStrip();
            this.toolCargar = new System.Windows.Forms.ToolStripButton();
            this.toolLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolAplicar = new System.Windows.Forms.ToolStripButton();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.noempleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workMovimientos = new System.ComponentModel.BackgroundWorker();
            this.toolBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBusqueda
            // 
            this.toolBusqueda.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolBusqueda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCargar,
            this.toolLimpiar,
            this.toolAplicar});
            this.toolBusqueda.Location = new System.Drawing.Point(0, 0);
            this.toolBusqueda.Name = "toolBusqueda";
            this.toolBusqueda.Size = new System.Drawing.Size(1025, 27);
            this.toolBusqueda.TabIndex = 12;
            this.toolBusqueda.Text = "ToolStrip1";
            // 
            // toolCargar
            // 
            this.toolCargar.Image = ((System.Drawing.Image)(resources.GetObject("toolCargar.Image")));
            this.toolCargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCargar.Name = "toolCargar";
            this.toolCargar.Size = new System.Drawing.Size(77, 24);
            this.toolCargar.Text = "Cargar";
            this.toolCargar.Click += new System.EventHandler(this.toolCargar_Click);
            // 
            // toolLimpiar
            // 
            this.toolLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("toolLimpiar.Image")));
            this.toolLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLimpiar.Name = "toolLimpiar";
            this.toolLimpiar.Size = new System.Drawing.Size(83, 24);
            this.toolLimpiar.Text = "Limpiar";
            this.toolLimpiar.Click += new System.EventHandler(this.toolLimpiar_Click);
            // 
            // toolAplicar
            // 
            this.toolAplicar.Image = ((System.Drawing.Image)(resources.GetObject("toolAplicar.Image")));
            this.toolAplicar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAplicar.Name = "toolAplicar";
            this.toolAplicar.Size = new System.Drawing.Size(80, 24);
            this.toolAplicar.Text = "Aplicar";
            this.toolAplicar.Click += new System.EventHandler(this.toolAplicar_Click);
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.AllowUserToAddRows = false;
            this.dgvMovimientos.AllowUserToDeleteRows = false;
            this.dgvMovimientos.AllowUserToOrderColumns = true;
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noempleado,
            this.cantidad,
            this.concepto,
            this.inicio,
            this.fin});
            this.dgvMovimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovimientos.Location = new System.Drawing.Point(0, 27);
            this.dgvMovimientos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.ReadOnly = true;
            this.dgvMovimientos.Size = new System.Drawing.Size(1025, 586);
            this.dgvMovimientos.TabIndex = 13;
            // 
            // noempleado
            // 
            this.noempleado.HeaderText = "No. Empleado";
            this.noempleado.Name = "noempleado";
            this.noempleado.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // concepto
            // 
            this.concepto.HeaderText = "Concepto";
            this.concepto.Name = "concepto";
            this.concepto.ReadOnly = true;
            // 
            // inicio
            // 
            this.inicio.HeaderText = "Fecha Inicio";
            this.inicio.Name = "inicio";
            this.inicio.ReadOnly = true;
            // 
            // fin
            // 
            this.fin.HeaderText = "Fecha Fin";
            this.fin.Name = "fin";
            this.fin.ReadOnly = true;
            // 
            // workMovimientos
            // 
            this.workMovimientos.WorkerReportsProgress = true;
            this.workMovimientos.WorkerSupportsCancellation = true;
            this.workMovimientos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workMovimientos_DoWork);
            this.workMovimientos.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workMovimientos_ProgressChanged);
            this.workMovimientos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workMovimientos_RunWorkerCompleted);
            // 
            // frmListaCargaMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 613);
            this.Controls.Add(this.dgvMovimientos);
            this.Controls.Add(this.toolBusqueda);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListaCargaMovimientos";
            this.Text = "Carga de movimientos";
            this.Load += new System.EventHandler(this.frmListaCargaMovimientos_Load);
            this.toolBusqueda.ResumeLayout(false);
            this.toolBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolBusqueda;
        private System.Windows.Forms.ToolStripButton toolCargar;
        private System.Windows.Forms.ToolStripButton toolLimpiar;
        private System.Windows.Forms.ToolStripButton toolAplicar;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn noempleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin;
        private System.ComponentModel.BackgroundWorker workMovimientos;
    }
}