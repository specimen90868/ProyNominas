namespace Nominas
{
    partial class frmIncapacidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncapacidad));
            this.toolAcciones = new System.Windows.Forms.ToolStrip();
            this.toolGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolCerrar = new System.Windows.Forms.ToolStripButton();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFinPeriodo = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioPeriodo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiasIncapacidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoIncapacidad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoCaso = new System.Windows.Forms.ComboBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxtNoEmpleado = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCertificado = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.toolAcciones.Size = new System.Drawing.Size(511, 27);
            this.toolAcciones.TabIndex = 7;
            this.toolAcciones.Text = "toolEmpresa";
            // 
            // toolGuardar
            // 
            this.toolGuardar.Image = ((System.Drawing.Image)(resources.GetObject("toolGuardar.Image")));
            this.toolGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGuardar.Name = "toolGuardar";
            this.toolGuardar.Size = new System.Drawing.Size(73, 24);
            this.toolGuardar.Text = "Guardar";
            this.toolGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(128, 78);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaInicio.TabIndex = 1;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 259;
            this.label1.Text = "Fecha de inicio:";
            // 
            // dtpFinPeriodo
            // 
            this.dtpFinPeriodo.Enabled = false;
            this.dtpFinPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinPeriodo.Location = new System.Drawing.Point(359, 158);
            this.dtpFinPeriodo.Name = "dtpFinPeriodo";
            this.dtpFinPeriodo.Size = new System.Drawing.Size(141, 20);
            this.dtpFinPeriodo.TabIndex = 4;
            this.dtpFinPeriodo.Visible = false;
            // 
            // dtpInicioPeriodo
            // 
            this.dtpInicioPeriodo.Enabled = false;
            this.dtpInicioPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioPeriodo.Location = new System.Drawing.Point(359, 132);
            this.dtpInicioPeriodo.Name = "dtpInicioPeriodo";
            this.dtpInicioPeriodo.Size = new System.Drawing.Size(141, 20);
            this.dtpInicioPeriodo.TabIndex = 3;
            this.dtpInicioPeriodo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 260;
            this.label3.Text = "Periodo:";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 263;
            this.label2.Text = "Dias de incapacidad:";
            // 
            // txtDiasIncapacidad
            // 
            this.txtDiasIncapacidad.Location = new System.Drawing.Point(128, 104);
            this.txtDiasIncapacidad.Name = "txtDiasIncapacidad";
            this.txtDiasIncapacidad.Size = new System.Drawing.Size(100, 20);
            this.txtDiasIncapacidad.TabIndex = 2;
            this.txtDiasIncapacidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 264;
            this.label4.Text = "Certificado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 266;
            this.label5.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(128, 184);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(372, 199);
            this.txtDescripcion.TabIndex = 267;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 268;
            this.label6.Text = "Tipo de incapacidad:";
            // 
            // cmbTipoIncapacidad
            // 
            this.cmbTipoIncapacidad.FormattingEnabled = true;
            this.cmbTipoIncapacidad.Location = new System.Drawing.Point(359, 78);
            this.cmbTipoIncapacidad.Name = "cmbTipoIncapacidad";
            this.cmbTipoIncapacidad.Size = new System.Drawing.Size(141, 21);
            this.cmbTipoIncapacidad.TabIndex = 269;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 270;
            this.label7.Text = "Tipo de Caso:";
            // 
            // cmbTipoCaso
            // 
            this.cmbTipoCaso.FormattingEnabled = true;
            this.cmbTipoCaso.Location = new System.Drawing.Point(359, 105);
            this.cmbTipoCaso.Name = "cmbTipoCaso";
            this.cmbTipoCaso.Size = new System.Drawing.Size(141, 21);
            this.cmbTipoCaso.TabIndex = 271;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.BackColor = System.Drawing.SystemColors.Control;
            this.txtDepartamento.Location = new System.Drawing.Point(253, 50);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(164, 20);
            this.txtDepartamento.TabIndex = 277;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(160, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 276;
            this.label8.Text = "Departamento:";
            // 
            // mtxtNoEmpleado
            // 
            this.mtxtNoEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtNoEmpleado.Location = new System.Drawing.Point(106, 50);
            this.mtxtNoEmpleado.Mask = "9999";
            this.mtxtNoEmpleado.Name = "mtxtNoEmpleado";
            this.mtxtNoEmpleado.Size = new System.Drawing.Size(33, 20);
            this.mtxtNoEmpleado.TabIndex = 274;
            this.mtxtNoEmpleado.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtNoEmpleado_MaskInputRejected);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 273;
            this.label9.Text = "No. Empleado:";
            // 
            // txtCertificado
            // 
            this.txtCertificado.BeepOnError = true;
            this.txtCertificado.Location = new System.Drawing.Point(128, 130);
            this.txtCertificado.Mask = "AAAAAAAA";
            this.txtCertificado.Name = "txtCertificado";
            this.txtCertificado.Size = new System.Drawing.Size(100, 20);
            this.txtCertificado.TabIndex = 280;
            this.txtCertificado.Leave += new System.EventHandler(this.txtCertificado_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 281;
            this.label10.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(106, 27);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(310, 20);
            this.txtNombre.TabIndex = 282;
            // 
            // frmIncapacidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 402);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCertificado);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mtxtNoEmpleado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbTipoCaso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbTipoIncapacidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiasIncapacidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFinPeriodo);
            this.Controls.Add(this.dtpInicioPeriodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.toolAcciones);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(527, 441);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(527, 441);
            this.Name = "frmIncapacidad";
            this.Text = "Incapacidad del trabajador";
            this.Load += new System.EventHandler(this.frmIncapacidad_Load);
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
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFinPeriodo;
        private System.Windows.Forms.DateTimePicker dtpInicioPeriodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiasIncapacidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipoIncapacidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoCaso;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtxtNoEmpleado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtCertificado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombre;
    }
}