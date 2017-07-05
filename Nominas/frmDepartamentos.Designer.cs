namespace Nominas
{
    partial class frmDepartamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartamentos));
            this.toolDepartamento = new System.Windows.Forms.ToolStrip();
            this.toolGuardarNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolCerrar = new System.Windows.Forms.ToolStripButton();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDeptoPuesto = new System.Windows.Forms.Label();
            this.toolDepartamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolDepartamento
            // 
            this.toolDepartamento.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolDepartamento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolGuardarNuevo,
            this.toolCerrar});
            this.toolDepartamento.Location = new System.Drawing.Point(0, 0);
            this.toolDepartamento.Name = "toolDepartamento";
            this.toolDepartamento.Size = new System.Drawing.Size(517, 27);
            this.toolDepartamento.TabIndex = 3;
            this.toolDepartamento.Text = "toolEmpresa";
            // 
            // toolGuardarNuevo
            // 
            this.toolGuardarNuevo.Image = ((System.Drawing.Image)(resources.GetObject("toolGuardarNuevo.Image")));
            this.toolGuardarNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGuardarNuevo.Name = "toolGuardarNuevo";
            this.toolGuardarNuevo.Size = new System.Drawing.Size(86, 24);
            this.toolGuardarNuevo.Text = "Guardar";
            this.toolGuardarNuevo.Click += new System.EventHandler(this.toolGuardarNuevo_Click);
            // 
            // toolCerrar
            // 
            this.toolCerrar.Image = ((System.Drawing.Image)(resources.GetObject("toolCerrar.Image")));
            this.toolCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCerrar.Name = "toolCerrar";
            this.toolCerrar.Size = new System.Drawing.Size(73, 24);
            this.toolCerrar.Text = "Cerrar";
            this.toolCerrar.Click += new System.EventHandler(this.toolCerrar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(121, 31);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(384, 22);
            this.txtDescripcion.TabIndex = 96;
            // 
            // lblDeptoPuesto
            // 
            this.lblDeptoPuesto.AutoSize = true;
            this.lblDeptoPuesto.Location = new System.Drawing.Point(11, 31);
            this.lblDeptoPuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeptoPuesto.Name = "lblDeptoPuesto";
            this.lblDeptoPuesto.Size = new System.Drawing.Size(102, 17);
            this.lblDeptoPuesto.TabIndex = 95;
            this.lblDeptoPuesto.Text = "Departamento:";
            // 
            // frmDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 74);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDeptoPuesto);
            this.Controls.Add(this.toolDepartamento);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(535, 121);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(535, 121);
            this.Name = "frmDepartamentos";
            this.Text = "Departamento de la empresa";
            this.Load += new System.EventHandler(this.frmDepartamentos_Load);
            this.toolDepartamento.ResumeLayout(false);
            this.toolDepartamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolDepartamento;
        internal System.Windows.Forms.ToolStripButton toolGuardarNuevo;
        private System.Windows.Forms.ToolStripButton toolCerrar;
        internal System.Windows.Forms.TextBox txtDescripcion;
        internal System.Windows.Forms.Label lblDeptoPuesto;
    }
}