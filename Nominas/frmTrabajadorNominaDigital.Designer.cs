namespace Nominas
{
    partial class frmTrabajadorNominaDigital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrabajadorNominaDigital));
            this.toolEmpleado = new System.Windows.Forms.ToolStrip();
            this.toolGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolCerrar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoRegimen = new System.Windows.Forms.ComboBox();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.cmbTipoContrato = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbRiesgoPuesto = new System.Windows.Forms.ComboBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxtNoEmpleado = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.toolEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolEmpleado
            // 
            this.toolEmpleado.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolEmpleado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolGuardar,
            this.toolCerrar});
            this.toolEmpleado.Location = new System.Drawing.Point(0, 0);
            this.toolEmpleado.Name = "toolEmpleado";
            this.toolEmpleado.Size = new System.Drawing.Size(579, 27);
            this.toolEmpleado.TabIndex = 3;
            this.toolEmpleado.Text = "toolEmpresa";
            // 
            // toolGuardar
            // 
            this.toolGuardar.Image = ((System.Drawing.Image)(resources.GetObject("toolGuardar.Image")));
            this.toolGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGuardar.Name = "toolGuardar";
            this.toolGuardar.Size = new System.Drawing.Size(86, 24);
            this.toolGuardar.Text = "Guardar";
            this.toolGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolGuardar.Click += new System.EventHandler(this.toolGuardar_Click);
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
            this.label1.Location = new System.Drawing.Point(21, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de regimen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Metodo de pago:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de contrato:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Edo. prestación del servicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 243);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Riesgo del puesto:";
            // 
            // cmbTipoRegimen
            // 
            this.cmbTipoRegimen.FormattingEnabled = true;
            this.cmbTipoRegimen.Location = new System.Drawing.Point(268, 106);
            this.cmbTipoRegimen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoRegimen.Name = "cmbTipoRegimen";
            this.cmbTipoRegimen.Size = new System.Drawing.Size(285, 24);
            this.cmbTipoRegimen.TabIndex = 9;
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.FormattingEnabled = true;
            this.cmbMetodoPago.Location = new System.Drawing.Point(268, 139);
            this.cmbMetodoPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(285, 24);
            this.cmbMetodoPago.TabIndex = 10;
            // 
            // cmbTipoContrato
            // 
            this.cmbTipoContrato.FormattingEnabled = true;
            this.cmbTipoContrato.Location = new System.Drawing.Point(268, 172);
            this.cmbTipoContrato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoContrato.Name = "cmbTipoContrato";
            this.cmbTipoContrato.Size = new System.Drawing.Size(285, 24);
            this.cmbTipoContrato.TabIndex = 11;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(268, 206);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(285, 24);
            this.cmbEstado.TabIndex = 12;
            // 
            // cmbRiesgoPuesto
            // 
            this.cmbRiesgoPuesto.FormattingEnabled = true;
            this.cmbRiesgoPuesto.Location = new System.Drawing.Point(268, 239);
            this.cmbRiesgoPuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRiesgoPuesto.Name = "cmbRiesgoPuesto";
            this.cmbRiesgoPuesto.Size = new System.Drawing.Size(285, 24);
            this.cmbRiesgoPuesto.TabIndex = 13;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.BackColor = System.Drawing.SystemColors.Control;
            this.txtDepartamento.Location = new System.Drawing.Point(336, 64);
            this.txtDepartamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(217, 22);
            this.txtDepartamento.TabIndex = 284;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 283;
            this.label6.Text = "Departamento:";
            // 
            // mtxtNoEmpleado
            // 
            this.mtxtNoEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtNoEmpleado.Location = new System.Drawing.Point(149, 64);
            this.mtxtNoEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtNoEmpleado.Mask = "9999";
            this.mtxtNoEmpleado.Name = "mtxtNoEmpleado";
            this.mtxtNoEmpleado.Size = new System.Drawing.Size(43, 22);
            this.mtxtNoEmpleado.TabIndex = 282;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 281;
            this.label7.Text = "No. Empleado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 285;
            this.label8.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(149, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(404, 22);
            this.txtNombre.TabIndex = 286;
            // 
            // frmTrabajadorNominaDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 278);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtxtNoEmpleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbRiesgoPuesto);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbTipoContrato);
            this.Controls.Add(this.cmbMetodoPago);
            this.Controls.Add(this.cmbTipoRegimen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolEmpleado);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(597, 325);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(597, 325);
            this.Name = "frmTrabajadorNominaDigital";
            this.Text = "Nomina digital del trabajador";
            this.Load += new System.EventHandler(this.frmTrabajadorNominaDigital_Load);
            this.toolEmpleado.ResumeLayout(false);
            this.toolEmpleado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolEmpleado;
        internal System.Windows.Forms.ToolStripButton toolGuardar;
        private System.Windows.Forms.ToolStripButton toolCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoRegimen;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.ComboBox cmbTipoContrato;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbRiesgoPuesto;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtxtNoEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombre;
    }
}