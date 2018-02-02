namespace Nominas
{
    partial class frmInfonavit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfonavit));
            this.toolAcciones = new System.Windows.Forms.ToolStrip();
            this.toolGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolCerrar = new System.Windows.Forms.ToolStripButton();
            this.Label16 = new System.Windows.Forms.Label();
            this.rbtnPesos = new System.Windows.Forms.RadioButton();
            this.rbtnVsmdf = new System.Windows.Forms.RadioButton();
            this.Label52 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.rbtnPorcentaje = new System.Windows.Forms.RadioButton();
            this.Label50 = new System.Windows.Forms.Label();
            this.Label51 = new System.Windows.Forms.Label();
            this.chkInactivo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dtpFechaAplicacion = new System.Windows.Forms.DateTimePicker();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtNoEmpleado = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroCredito = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.toolAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolAcciones
            // 
            this.toolAcciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolGuardar,
            this.toolBuscar,
            this.toolCerrar});
            this.toolAcciones.Location = new System.Drawing.Point(0, 0);
            this.toolAcciones.Name = "toolAcciones";
            this.toolAcciones.Size = new System.Drawing.Size(420, 27);
            this.toolAcciones.TabIndex = 5;
            this.toolAcciones.Text = "toolEmpresa";
            // 
            // toolGuardar
            // 
            this.toolGuardar.Image = ((System.Drawing.Image)(resources.GetObject("toolGuardar.Image")));
            this.toolGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGuardar.Name = "toolGuardar";
            this.toolGuardar.Size = new System.Drawing.Size(73, 24);
            this.toolGuardar.Text = "Guardar";
            this.toolGuardar.Click += new System.EventHandler(this.toolGuardar_Click);
            // 
            // toolBuscar
            // 
            this.toolBuscar.Image = ((System.Drawing.Image)(resources.GetObject("toolBuscar.Image")));
            this.toolBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBuscar.Name = "toolBuscar";
            this.toolBuscar.Size = new System.Drawing.Size(66, 24);
            this.toolBuscar.Text = "Buscar";
            this.toolBuscar.Click += new System.EventHandler(this.toolBuscar_Click);
            // 
            // toolCerrar
            // 
            this.toolCerrar.Image = ((System.Drawing.Image)(resources.GetObject("toolCerrar.Image")));
            this.toolCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCerrar.Name = "toolCerrar";
            this.toolCerrar.Size = new System.Drawing.Size(63, 24);
            this.toolCerrar.Text = "Cerrar";
            this.toolCerrar.Click += new System.EventHandler(this.toolCerrar_Click);
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.BackColor = System.Drawing.SystemColors.Control;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.Label16.Location = new System.Drawing.Point(7, 88);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(137, 18);
            this.Label16.TabIndex = 257;
            this.Label16.Text = "Datos del crédito";
            // 
            // rbtnPesos
            // 
            this.rbtnPesos.AutoSize = true;
            this.rbtnPesos.Location = new System.Drawing.Point(117, 255);
            this.rbtnPesos.Name = "rbtnPesos";
            this.rbtnPesos.Size = new System.Drawing.Size(54, 17);
            this.rbtnPesos.TabIndex = 265;
            this.rbtnPesos.TabStop = true;
            this.rbtnPesos.Text = "Pesos";
            this.rbtnPesos.UseVisualStyleBackColor = true;
            this.rbtnPesos.CheckedChanged += new System.EventHandler(this.rbtnPesos_CheckedChanged);
            // 
            // rbtnVsmdf
            // 
            this.rbtnVsmdf.AutoSize = true;
            this.rbtnVsmdf.Location = new System.Drawing.Point(117, 221);
            this.rbtnVsmdf.Name = "rbtnVsmdf";
            this.rbtnVsmdf.Size = new System.Drawing.Size(123, 17);
            this.rbtnVsmdf.TabIndex = 260;
            this.rbtnVsmdf.TabStop = true;
            this.rbtnVsmdf.Text = "Factor de descuento";
            this.rbtnVsmdf.UseVisualStyleBackColor = true;
            this.rbtnVsmdf.CheckedChanged += new System.EventHandler(this.rbtnVsmdf_CheckedChanged);
            // 
            // Label52
            // 
            this.Label52.AutoSize = true;
            this.Label52.Location = new System.Drawing.Point(7, 132);
            this.Label52.Name = "Label52";
            this.Label52.Size = new System.Drawing.Size(97, 13);
            this.Label52.TabIndex = 258;
            this.Label52.Text = "Número de crédito:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(117, 155);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(76, 20);
            this.txtValor.TabIndex = 264;
            // 
            // rbtnPorcentaje
            // 
            this.rbtnPorcentaje.AutoSize = true;
            this.rbtnPorcentaje.Location = new System.Drawing.Point(117, 187);
            this.rbtnPorcentaje.Name = "rbtnPorcentaje";
            this.rbtnPorcentaje.Size = new System.Drawing.Size(76, 17);
            this.rbtnPorcentaje.TabIndex = 259;
            this.rbtnPorcentaje.TabStop = true;
            this.rbtnPorcentaje.Text = "Porcentaje";
            this.rbtnPorcentaje.UseVisualStyleBackColor = true;
            this.rbtnPorcentaje.CheckedChanged += new System.EventHandler(this.rbtnPorcentaje_CheckedChanged);
            // 
            // Label50
            // 
            this.Label50.AutoSize = true;
            this.Label50.Location = new System.Drawing.Point(7, 158);
            this.Label50.Name = "Label50";
            this.Label50.Size = new System.Drawing.Size(104, 13);
            this.Label50.TabIndex = 263;
            this.Label50.Text = "Valor del descuento:";
            // 
            // Label51
            // 
            this.Label51.AutoSize = true;
            this.Label51.Location = new System.Drawing.Point(7, 187);
            this.Label51.Name = "Label51";
            this.Label51.Size = new System.Drawing.Size(80, 13);
            this.Label51.TabIndex = 262;
            this.Label51.Text = "Descuento por:";
            // 
            // chkInactivo
            // 
            this.chkInactivo.AutoSize = true;
            this.chkInactivo.Location = new System.Drawing.Point(150, 91);
            this.chkInactivo.Name = "chkInactivo";
            this.chkInactivo.Size = new System.Drawing.Size(80, 17);
            this.chkInactivo.TabIndex = 266;
            this.chkInactivo.Text = "No calcular";
            this.chkInactivo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 268;
            this.label2.Text = "Aplicación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 269;
            this.label3.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(10, 296);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(397, 20);
            this.txtDescripcion.TabIndex = 270;
            // 
            // dtpFechaAplicacion
            // 
            this.dtpFechaAplicacion.Location = new System.Drawing.Point(259, 129);
            this.dtpFechaAplicacion.Name = "dtpFechaAplicacion";
            this.dtpFechaAplicacion.Size = new System.Drawing.Size(148, 20);
            this.dtpFechaAplicacion.TabIndex = 271;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.BackColor = System.Drawing.SystemColors.Control;
            this.txtDepartamento.Location = new System.Drawing.Point(243, 58);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(164, 20);
            this.txtDepartamento.TabIndex = 278;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 277;
            this.label1.Text = "Departamento:";
            // 
            // mtxtNoEmpleado
            // 
            this.mtxtNoEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtNoEmpleado.Location = new System.Drawing.Point(103, 58);
            this.mtxtNoEmpleado.Mask = "9999";
            this.mtxtNoEmpleado.Name = "mtxtNoEmpleado";
            this.mtxtNoEmpleado.Size = new System.Drawing.Size(33, 20);
            this.mtxtNoEmpleado.TabIndex = 276;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 275;
            this.label4.Text = "No. Empleado:";
            // 
            // txtNumeroCredito
            // 
            this.txtNumeroCredito.Location = new System.Drawing.Point(117, 130);
            this.txtNumeroCredito.Mask = "9999999999";
            this.txtNumeroCredito.Name = "txtNumeroCredito";
            this.txtNumeroCredito.Size = new System.Drawing.Size(76, 20);
            this.txtNumeroCredito.TabIndex = 279;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 282;
            this.label6.Text = "Empleado:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(103, 35);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(304, 19);
            this.txtNombre.TabIndex = 283;
            // 
            // frmInfonavit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 337);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumeroCredito);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxtNoEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFechaAplicacion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkInactivo);
            this.Controls.Add(this.rbtnPesos);
            this.Controls.Add(this.rbtnVsmdf);
            this.Controls.Add(this.Label52);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.rbtnPorcentaje);
            this.Controls.Add(this.Label50);
            this.Controls.Add(this.Label51);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.toolAcciones);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(436, 376);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(436, 376);
            this.Name = "frmInfonavit";
            this.Text = "Infonavit del trabajador";
            this.Load += new System.EventHandler(this.frmInfonavit_Load);
            this.toolAcciones.ResumeLayout(false);
            this.toolAcciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolAcciones;
        internal System.Windows.Forms.ToolStripButton toolGuardar;
        private System.Windows.Forms.ToolStripButton toolBuscar;
        private System.Windows.Forms.ToolStripButton toolCerrar;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.RadioButton rbtnPesos;
        internal System.Windows.Forms.RadioButton rbtnVsmdf;
        internal System.Windows.Forms.Label Label52;
        internal System.Windows.Forms.TextBox txtValor;
        internal System.Windows.Forms.RadioButton rbtnPorcentaje;
        internal System.Windows.Forms.Label Label50;
        internal System.Windows.Forms.Label Label51;
        private System.Windows.Forms.CheckBox chkInactivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DateTimePicker dtpFechaAplicacion;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtNoEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtNumeroCredito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
    }
}