namespace Nominas
{
    partial class frmConceptoEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConceptoEmpleado));
            this.toolBusqueda = new System.Windows.Forms.ToolStrip();
            this.toolNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolBaja = new System.Windows.Forms.ToolStripButton();
            this.dgvConceptosEmpleado = new System.Windows.Forms.DataGridView();
            this.toolBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptosEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBusqueda
            // 
            this.toolBusqueda.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolBusqueda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNuevo,
            this.toolBaja});
            this.toolBusqueda.Location = new System.Drawing.Point(0, 0);
            this.toolBusqueda.Name = "toolBusqueda";
            this.toolBusqueda.Size = new System.Drawing.Size(769, 27);
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
            // toolBaja
            // 
            this.toolBaja.Image = ((System.Drawing.Image)(resources.GetObject("toolBaja.Image")));
            this.toolBaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBaja.Name = "toolBaja";
            this.toolBaja.Size = new System.Drawing.Size(62, 24);
            this.toolBaja.Text = "Baja";
            this.toolBaja.Click += new System.EventHandler(this.toolBaja_Click);
            // 
            // dgvConceptosEmpleado
            // 
            this.dgvConceptosEmpleado.AllowUserToAddRows = false;
            this.dgvConceptosEmpleado.AllowUserToDeleteRows = false;
            this.dgvConceptosEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConceptosEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConceptosEmpleado.Location = new System.Drawing.Point(0, 27);
            this.dgvConceptosEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvConceptosEmpleado.Name = "dgvConceptosEmpleado";
            this.dgvConceptosEmpleado.ReadOnly = true;
            this.dgvConceptosEmpleado.Size = new System.Drawing.Size(769, 703);
            this.dgvConceptosEmpleado.TabIndex = 9;
            // 
            // frmConceptoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 730);
            this.Controls.Add(this.dgvConceptosEmpleado);
            this.Controls.Add(this.toolBusqueda);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConceptoEmpleado";
            this.Text = "Conceptos del empleado";
            this.Load += new System.EventHandler(this.frmConceptoEmpleado_Load);
            this.toolBusqueda.ResumeLayout(false);
            this.toolBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptosEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolBusqueda;
        private System.Windows.Forms.ToolStripButton toolNuevo;
        private System.Windows.Forms.ToolStripButton toolBaja;
        private System.Windows.Forms.DataGridView dgvConceptosEmpleado;
    }
}