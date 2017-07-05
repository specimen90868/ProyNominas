namespace Nominas
{
    partial class frmImss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImss));
            this.toolAcciones = new System.Windows.Forms.ToolStrip();
            this.toolGuardarNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolCerrar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrestacion = new System.Windows.Forms.TextBox();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.chkSeCalcula = new System.Windows.Forms.CheckBox();
            this.toolAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolAcciones
            // 
            this.toolAcciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolGuardarNuevo,
            this.toolCerrar});
            this.toolAcciones.Location = new System.Drawing.Point(0, 0);
            this.toolAcciones.Name = "toolAcciones";
            this.toolAcciones.Size = new System.Drawing.Size(532, 27);
            this.toolAcciones.TabIndex = 7;
            this.toolAcciones.Text = "toolEmpresa";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 109;
            this.label1.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 110;
            this.label3.Text = "Porcentaje:";
            // 
            // txtPrestacion
            // 
            this.txtPrestacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrestacion.Location = new System.Drawing.Point(109, 38);
            this.txtPrestacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrestacion.Name = "txtPrestacion";
            this.txtPrestacion.Size = new System.Drawing.Size(409, 22);
            this.txtPrestacion.TabIndex = 111;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(109, 70);
            this.txtPorcentaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(80, 22);
            this.txtPorcentaje.TabIndex = 112;
            this.txtPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkSeCalcula
            // 
            this.chkSeCalcula.AutoSize = true;
            this.chkSeCalcula.Location = new System.Drawing.Point(208, 71);
            this.chkSeCalcula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSeCalcula.Name = "chkSeCalcula";
            this.chkSeCalcula.Size = new System.Drawing.Size(97, 21);
            this.chkSeCalcula.TabIndex = 113;
            this.chkSeCalcula.Text = "Se Calcula";
            this.chkSeCalcula.UseVisualStyleBackColor = true;
            // 
            // frmImss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 113);
            this.Controls.Add(this.chkSeCalcula);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.txtPrestacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolAcciones);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 160);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 160);
            this.Name = "frmImss";
            this.Text = "Prestación del IMSS";
            this.Load += new System.EventHandler(this.frmImss_Load);
            this.toolAcciones.ResumeLayout(false);
            this.toolAcciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolAcciones;
        internal System.Windows.Forms.ToolStripButton toolGuardarNuevo;
        private System.Windows.Forms.ToolStripButton toolCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrestacion;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.CheckBox chkSeCalcula;
    }
}