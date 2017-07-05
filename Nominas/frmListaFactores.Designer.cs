namespace Nominas
{
    partial class frmListaFactores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaFactores));
            this.toolBusqueda = new System.Windows.Forms.ToolStrip();
            this.toolNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolEditar = new System.Windows.Forms.ToolStripButton();
            this.toolBaja = new System.Windows.Forms.ToolStripButton();
            this.dgvFactores = new System.Windows.Forms.DataGridView();
            this.toolBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactores)).BeginInit();
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
            this.toolBusqueda.Size = new System.Drawing.Size(928, 27);
            this.toolBusqueda.TabIndex = 8;
            this.toolBusqueda.Text = "ToolStrip1";
            // 
            // toolNuevo
            // 
            this.toolNuevo.Image = ((System.Drawing.Image)(resources.GetObject("toolNuevo.Image")));
            this.toolNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNuevo.Name = "toolNuevo";
            this.toolNuevo.Size = new System.Drawing.Size(76, 24);
            this.toolNuevo.Text = "Nuevo";
            this.toolNuevo.Click += new System.EventHandler(this.toolNuevo_Click);
            // 
            // toolConsultar
            // 
            this.toolConsultar.Image = ((System.Drawing.Image)(resources.GetObject("toolConsultar.Image")));
            this.toolConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolConsultar.Name = "toolConsultar";
            this.toolConsultar.Size = new System.Drawing.Size(95, 24);
            this.toolConsultar.Text = "Consultar";
            this.toolConsultar.Click += new System.EventHandler(this.toolConsultar_Click);
            // 
            // toolEditar
            // 
            this.toolEditar.Image = ((System.Drawing.Image)(resources.GetObject("toolEditar.Image")));
            this.toolEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEditar.Name = "toolEditar";
            this.toolEditar.Size = new System.Drawing.Size(72, 24);
            this.toolEditar.Text = "Editar";
            this.toolEditar.Click += new System.EventHandler(this.toolEditar_Click);
            // 
            // toolBaja
            // 
            this.toolBaja.Image = ((System.Drawing.Image)(resources.GetObject("toolBaja.Image")));
            this.toolBaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBaja.Name = "toolBaja";
            this.toolBaja.Size = new System.Drawing.Size(87, 24);
            this.toolBaja.Text = "Eliminar";
            this.toolBaja.Click += new System.EventHandler(this.toolBaja_Click);
            // 
            // dgvFactores
            // 
            this.dgvFactores.AllowUserToAddRows = false;
            this.dgvFactores.AllowUserToDeleteRows = false;
            this.dgvFactores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFactores.Location = new System.Drawing.Point(0, 27);
            this.dgvFactores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFactores.MultiSelect = false;
            this.dgvFactores.Name = "dgvFactores";
            this.dgvFactores.ReadOnly = true;
            this.dgvFactores.Size = new System.Drawing.Size(928, 654);
            this.dgvFactores.TabIndex = 9;
            // 
            // frmListaFactores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 681);
            this.Controls.Add(this.dgvFactores);
            this.Controls.Add(this.toolBusqueda);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListaFactores";
            this.Text = "Factores de integración";
            this.Load += new System.EventHandler(this.frmListaFactores_Load);
            this.toolBusqueda.ResumeLayout(false);
            this.toolBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolBusqueda;
        private System.Windows.Forms.ToolStripButton toolNuevo;
        private System.Windows.Forms.ToolStripButton toolConsultar;
        private System.Windows.Forms.ToolStripButton toolEditar;
        private System.Windows.Forms.ToolStripButton toolBaja;
        private System.Windows.Forms.DataGridView dgvFactores;
    }
}