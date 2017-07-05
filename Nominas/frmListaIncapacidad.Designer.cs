namespace Nominas
{
    partial class frmListaIncapacidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaIncapacidad));
            this.toolBusqueda = new System.Windows.Forms.ToolStrip();
            this.toolNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblBuscar = new System.Windows.Forms.ToolStripLabel();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.dgvIncapacidad = new System.Windows.Forms.DataGridView();
            this.toolBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBusqueda
            // 
            this.toolBusqueda.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolBusqueda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNuevo,
            this.toolEliminar,
            this.toolStripSeparator1,
            this.lblBuscar,
            this.txtBuscar});
            this.toolBusqueda.Location = new System.Drawing.Point(0, 0);
            this.toolBusqueda.Name = "toolBusqueda";
            this.toolBusqueda.Size = new System.Drawing.Size(947, 27);
            this.toolBusqueda.TabIndex = 9;
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
            // lblBuscar
            // 
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(55, 24);
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(399, 27);
            this.txtBuscar.Text = "Buscar empleado...";
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            this.txtBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            // 
            // dgvIncapacidad
            // 
            this.dgvIncapacidad.AllowUserToAddRows = false;
            this.dgvIncapacidad.AllowUserToDeleteRows = false;
            this.dgvIncapacidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncapacidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIncapacidad.Location = new System.Drawing.Point(0, 27);
            this.dgvIncapacidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvIncapacidad.Name = "dgvIncapacidad";
            this.dgvIncapacidad.ReadOnly = true;
            this.dgvIncapacidad.Size = new System.Drawing.Size(947, 827);
            this.dgvIncapacidad.TabIndex = 10;
            // 
            // frmListaIncapacidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 854);
            this.Controls.Add(this.dgvIncapacidad);
            this.Controls.Add(this.toolBusqueda);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListaIncapacidad";
            this.Text = "Incapacidades del trabajador";
            this.Load += new System.EventHandler(this.frmListaIncapacidad_Load);
            this.toolBusqueda.ResumeLayout(false);
            this.toolBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncapacidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolBusqueda;
        private System.Windows.Forms.ToolStripButton toolNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.ToolStripLabel lblBuscar;
        internal System.Windows.Forms.ToolStripTextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvIncapacidad;
        private System.Windows.Forms.ToolStripButton toolEliminar;
    }
}