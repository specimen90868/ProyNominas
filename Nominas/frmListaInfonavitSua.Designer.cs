namespace Nominas
{
    partial class frmListaInfonavitSua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaInfonavitSua));
            this.toolBusqueda = new System.Windows.Forms.ToolStrip();
            this.toolFiltrar = new System.Windows.Forms.ToolStripButton();
            this.toolExportar = new System.Windows.Forms.ToolStripButton();
            this.dgvInfSua = new System.Windows.Forms.DataGridView();
            this.workInf = new System.ComponentModel.BackgroundWorker();
            this.toolBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfSua)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBusqueda
            // 
            this.toolBusqueda.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolBusqueda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFiltrar,
            this.toolExportar});
            this.toolBusqueda.Location = new System.Drawing.Point(0, 0);
            this.toolBusqueda.Name = "toolBusqueda";
            this.toolBusqueda.Size = new System.Drawing.Size(1077, 27);
            this.toolBusqueda.TabIndex = 11;
            this.toolBusqueda.Text = "ToolStrip1";
            // 
            // toolFiltrar
            // 
            this.toolFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("toolFiltrar.Image")));
            this.toolFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFiltrar.Name = "toolFiltrar";
            this.toolFiltrar.Size = new System.Drawing.Size(71, 24);
            this.toolFiltrar.Text = "Filtrar";
            this.toolFiltrar.Click += new System.EventHandler(this.toolFiltrar_Click);
            // 
            // toolExportar
            // 
            this.toolExportar.Image = ((System.Drawing.Image)(resources.GetObject("toolExportar.Image")));
            this.toolExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExportar.Name = "toolExportar";
            this.toolExportar.Size = new System.Drawing.Size(89, 24);
            this.toolExportar.Text = "Exportar";
            this.toolExportar.Click += new System.EventHandler(this.toolExportar_Click);
            // 
            // dgvInfSua
            // 
            this.dgvInfSua.AllowUserToAddRows = false;
            this.dgvInfSua.AllowUserToDeleteRows = false;
            this.dgvInfSua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInfSua.Location = new System.Drawing.Point(0, 27);
            this.dgvInfSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvInfSua.Name = "dgvInfSua";
            this.dgvInfSua.ReadOnly = true;
            this.dgvInfSua.Size = new System.Drawing.Size(1077, 649);
            this.dgvInfSua.TabIndex = 12;
            // 
            // workInf
            // 
            this.workInf.WorkerReportsProgress = true;
            this.workInf.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workInf_DoWork);
            this.workInf.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workInf_RunWorkerCompleted);
            // 
            // frmListaInfonavitSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 676);
            this.Controls.Add(this.dgvInfSua);
            this.Controls.Add(this.toolBusqueda);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListaInfonavitSua";
            this.Text = "Infonavit sua";
            this.Load += new System.EventHandler(this.frmListaInfonavitSua_Load);
            this.toolBusqueda.ResumeLayout(false);
            this.toolBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfSua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolBusqueda;
        private System.Windows.Forms.ToolStripButton toolFiltrar;
        private System.Windows.Forms.ToolStripButton toolExportar;
        private System.Windows.Forms.DataGridView dgvInfSua;
        private System.ComponentModel.BackgroundWorker workInf;
    }
}