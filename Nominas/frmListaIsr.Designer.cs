namespace Nominas
{
    partial class frmListaIsr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaIsr));
            this.toolBusqueda = new System.Windows.Forms.ToolStrip();
            this.toolNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolEditar = new System.Windows.Forms.ToolStripButton();
            this.toolBaja = new System.Windows.Forms.ToolStripButton();
            this.dgvIsr = new System.Windows.Forms.DataGridView();
            this.toolBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsr)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBusqueda
            // 
            this.toolBusqueda.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolBusqueda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNuevo,
            this.toolConsultar,
            this.toolEditar,
            this.toolBaja});
            this.toolBusqueda.Location = new System.Drawing.Point(0, 0);
            this.toolBusqueda.Name = "toolBusqueda";
            this.toolBusqueda.Size = new System.Drawing.Size(830, 27);
            this.toolBusqueda.TabIndex = 9;
            this.toolBusqueda.Text = "ToolStrip1";
            // 
            // toolNuevo
            // 
            this.toolNuevo.Image = ((System.Drawing.Image)(resources.GetObject("toolNuevo.Image")));
            this.toolNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNuevo.Name = "toolNuevo";
            this.toolNuevo.Size = new System.Drawing.Size(66, 24);
            this.toolNuevo.Text = "Nuevo";
            this.toolNuevo.Click += new System.EventHandler(this.toolNuevo_Click);
            // 
            // toolConsultar
            // 
            this.toolConsultar.Image = ((System.Drawing.Image)(resources.GetObject("toolConsultar.Image")));
            this.toolConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolConsultar.Name = "toolConsultar";
            this.toolConsultar.Size = new System.Drawing.Size(82, 24);
            this.toolConsultar.Text = "Consultar";
            this.toolConsultar.Click += new System.EventHandler(this.toolConsultar_Click);
            // 
            // toolEditar
            // 
            this.toolEditar.Image = ((System.Drawing.Image)(resources.GetObject("toolEditar.Image")));
            this.toolEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEditar.Name = "toolEditar";
            this.toolEditar.Size = new System.Drawing.Size(61, 24);
            this.toolEditar.Text = "Editar";
            this.toolEditar.Click += new System.EventHandler(this.toolEditar_Click);
            // 
            // toolBaja
            // 
            this.toolBaja.Image = ((System.Drawing.Image)(resources.GetObject("toolBaja.Image")));
            this.toolBaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBaja.Name = "toolBaja";
            this.toolBaja.Size = new System.Drawing.Size(74, 24);
            this.toolBaja.Text = "Eliminar";
            this.toolBaja.Click += new System.EventHandler(this.toolBaja_Click);
            // 
            // dgvIsr
            // 
            this.dgvIsr.AllowUserToAddRows = false;
            this.dgvIsr.AllowUserToDeleteRows = false;
            this.dgvIsr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIsr.Location = new System.Drawing.Point(0, 27);
            this.dgvIsr.Name = "dgvIsr";
            this.dgvIsr.ReadOnly = true;
            this.dgvIsr.Size = new System.Drawing.Size(830, 630);
            this.dgvIsr.TabIndex = 10;
            // 
            // frmListaIsr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 657);
            this.Controls.Add(this.dgvIsr);
            this.Controls.Add(this.toolBusqueda);
            this.Name = "frmListaIsr";
            this.Text = "Tabla del ISR";
            this.Load += new System.EventHandler(this.frmListaIsr_Load);
            this.toolBusqueda.ResumeLayout(false);
            this.toolBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolBusqueda;
        private System.Windows.Forms.ToolStripButton toolNuevo;
        private System.Windows.Forms.ToolStripButton toolConsultar;
        private System.Windows.Forms.ToolStripButton toolEditar;
        private System.Windows.Forms.ToolStripButton toolBaja;
        private System.Windows.Forms.DataGridView dgvIsr;
    }
}