namespace Nominas
{
    partial class frmIsr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIsr));
            this.toolAcciones = new System.Windows.Forms.ToolStrip();
            this.toolGuardarNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolCerrar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInferior = new System.Windows.Forms.TextBox();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
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
            this.toolAcciones.Size = new System.Drawing.Size(279, 27);
            this.toolAcciones.TabIndex = 6;
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
            this.label1.Location = new System.Drawing.Point(29, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 108;
            this.label1.Text = "Inferior:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 109;
            this.label3.Text = "Cuota:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 110;
            this.label4.Text = "Porcentaje:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 111;
            this.label5.Text = "Periodo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 112;
            this.label6.Text = "Año:";
            // 
            // txtInferior
            // 
            this.txtInferior.Location = new System.Drawing.Point(124, 44);
            this.txtInferior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInferior.Name = "txtInferior";
            this.txtInferior.Size = new System.Drawing.Size(132, 22);
            this.txtInferior.TabIndex = 113;
            // 
            // txtCuota
            // 
            this.txtCuota.Location = new System.Drawing.Point(124, 82);
            this.txtCuota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(132, 22);
            this.txtCuota.TabIndex = 114;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(124, 121);
            this.txtPorcentaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(132, 22);
            this.txtPorcentaje.TabIndex = 115;
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(124, 159);
            this.txtDias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(132, 22);
            this.txtDias.TabIndex = 118;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(124, 197);
            this.txtAnio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(132, 22);
            this.txtAnio.TabIndex = 119;
            this.txtAnio.Text = "Valor de ISR";
            // 
            // frmIsr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 250);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.txtCuota);
            this.Controls.Add(this.txtInferior);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolAcciones);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(297, 297);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(297, 297);
            this.Name = "frmIsr";
            this.Text = "Valor del ISR";
            this.Load += new System.EventHandler(this.frmIsr_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInferior;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtAnio;
    }
}