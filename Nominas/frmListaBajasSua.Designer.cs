namespace Nominas
{
    partial class frmListaBajasSua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaBajasSua));
            this.toolBusqueda = new System.Windows.Forms.ToolStrip();
            this.toolFiltrar = new System.Windows.Forms.ToolStripButton();
            this.toolExportar = new System.Windows.Forms.ToolStripButton();
            this.toolEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.dgvBajasSua = new System.Windows.Forms.DataGridView();
            this.workBajas = new System.ComponentModel.BackgroundWorker();
            this.toolBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajasSua)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBusqueda
            // 
            this.toolBusqueda.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolBusqueda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFiltrar,
            this.toolExportar,
            this.toolEliminar,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txtBuscar});
            this.toolBusqueda.Location = new System.Drawing.Point(0, 0);
            this.toolBusqueda.Name = "toolBusqueda";
            this.toolBusqueda.Size = new System.Drawing.Size(907, 27);
            this.toolBusqueda.TabIndex = 8;
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
            // toolEliminar
            // 
            this.toolEliminar.Image = ((System.Drawing.Image)(resources.GetObject("toolEliminar.Image")));
            this.toolEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEliminar.Name = "toolEliminar";
            this.toolEliminar.Size = new System.Drawing.Size(87, 24);
            this.toolEliminar.Text = "Eliminar";
            this.toolEliminar.Click += new System.EventHandler(this.toolEliminar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 24);
            this.toolStripLabel1.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.AutoSize = false;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(265, 27);
            this.txtBuscar.Text = "Buscar empleado...";
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            this.txtBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            // 
            // dgvBajasSua
            // 
            this.dgvBajasSua.AllowUserToAddRows = false;
            this.dgvBajasSua.AllowUserToDeleteRows = false;
            this.dgvBajasSua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBajasSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBajasSua.Location = new System.Drawing.Point(0, 27);
            this.dgvBajasSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBajasSua.Name = "dgvBajasSua";
            this.dgvBajasSua.ReadOnly = true;
            this.dgvBajasSua.Size = new System.Drawing.Size(907, 682);
            this.dgvBajasSua.TabIndex = 9;
            this.dgvBajasSua.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBajasSua_CellDoubleClick);
            // 
            // workBajas
            // 
            this.workBajas.WorkerReportsProgress = true;
            this.workBajas.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workBajas_DoWork);
            this.workBajas.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workBajas_RunWorkerCompleted);
            // 
            // frmListaBajasSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 709);
            this.Controls.Add(this.dgvBajasSua);
            this.Controls.Add(this.toolBusqueda);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListaBajasSua";
            this.Text = "Bajas Sua";
            this.Load += new System.EventHandler(this.frmListaBajasSua_Load);
            this.toolBusqueda.ResumeLayout(false);
            this.toolBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajasSua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolBusqueda;
        private System.Windows.Forms.ToolStripButton toolFiltrar;
        private System.Windows.Forms.ToolStripButton toolExportar;
        private System.Windows.Forms.DataGridView dgvBajasSua;
        private System.ComponentModel.BackgroundWorker workBajas;
        private System.Windows.Forms.ToolStripButton toolEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtBuscar;
    }
}