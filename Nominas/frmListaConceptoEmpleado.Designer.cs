namespace Nominas
{
    partial class frmListaConceptoEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaConceptoEmpleado));
            this.toolBusqueda = new System.Windows.Forms.ToolStrip();
            this.toolConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblBuscar = new System.Windows.Forms.ToolStripLabel();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.toolBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBusqueda
            // 
            this.toolBusqueda.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolBusqueda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolConsultar,
            this.toolStripSeparator1,
            this.lblBuscar,
            this.txtBuscar});
            this.toolBusqueda.Location = new System.Drawing.Point(0, 0);
            this.toolBusqueda.Name = "toolBusqueda";
            this.toolBusqueda.Size = new System.Drawing.Size(925, 27);
            this.toolBusqueda.TabIndex = 7;
            this.toolBusqueda.Text = "ToolStrip1";
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
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpleados.Location = new System.Drawing.Point(0, 27);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.Size = new System.Drawing.Size(925, 800);
            this.dgvEmpleados.TabIndex = 8;
            // 
            // frmListaConceptoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 827);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.toolBusqueda);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListaConceptoEmpleado";
            this.Text = "Conceptos del trabajador";
            this.Load += new System.EventHandler(this.frmListaConceptoEmpleado_Load);
            this.toolBusqueda.ResumeLayout(false);
            this.toolBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolBusqueda;
        private System.Windows.Forms.ToolStripButton toolConsultar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.ToolStripLabel lblBuscar;
        internal System.Windows.Forms.ToolStripTextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvEmpleados;
    }
}