namespace Nominas
{
    partial class frmListaReingresosSua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaReingresosSua));
            this.toolBusqueda = new System.Windows.Forms.ToolStrip();
            this.toolFiltrar = new System.Windows.Forms.ToolStripButton();
            this.toolExportar = new System.Windows.Forms.ToolStripButton();
            this.dgvReingresoSua = new System.Windows.Forms.DataGridView();
            this.workReingreso = new System.ComponentModel.BackgroundWorker();
            this.toolBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReingresoSua)).BeginInit();
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
            this.toolBusqueda.Size = new System.Drawing.Size(965, 27);
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
            // dgvReingresoSua
            // 
            this.dgvReingresoSua.AllowUserToAddRows = false;
            this.dgvReingresoSua.AllowUserToDeleteRows = false;
            this.dgvReingresoSua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReingresoSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReingresoSua.Location = new System.Drawing.Point(0, 27);
            this.dgvReingresoSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvReingresoSua.Name = "dgvReingresoSua";
            this.dgvReingresoSua.ReadOnly = true;
            this.dgvReingresoSua.Size = new System.Drawing.Size(965, 800);
            this.dgvReingresoSua.TabIndex = 12;
            // 
            // workReingreso
            // 
            this.workReingreso.WorkerReportsProgress = true;
            this.workReingreso.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workReingreso_DoWork);
            this.workReingreso.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workReingreso_RunWorkerCompleted);
            // 
            // frmListaReingresosSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 827);
            this.Controls.Add(this.dgvReingresoSua);
            this.Controls.Add(this.toolBusqueda);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListaReingresosSua";
            this.Text = "Reingresos sua";
            this.Load += new System.EventHandler(this.frmListaReingresosSua_Load);
            this.toolBusqueda.ResumeLayout(false);
            this.toolBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReingresoSua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolBusqueda;
        private System.Windows.Forms.ToolStripButton toolFiltrar;
        private System.Windows.Forms.ToolStripButton toolExportar;
        private System.Windows.Forms.DataGridView dgvReingresoSua;
        private System.ComponentModel.BackgroundWorker workReingreso;
    }
}