namespace Nominas
{
    partial class frmIncrementoSalarial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncrementoSalarial));
            this.toolAcciones = new System.Windows.Forms.ToolStrip();
            this.toolGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolCerrar = new System.Windows.Forms.ToolStripButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtSDI = new System.Windows.Forms.TextBox();
            this.txtSD = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtNoEmpleado = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.chkCambioDeptoPto = new System.Windows.Forms.CheckBox();
            this.chkModificaPuesto = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.toolAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolAcciones
            // 
            this.toolAcciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolGuardar,
            this.toolCerrar});
            this.toolAcciones.Location = new System.Drawing.Point(0, 0);
            this.toolAcciones.Name = "toolAcciones";
            this.toolAcciones.Size = new System.Drawing.Size(572, 27);
            this.toolAcciones.TabIndex = 4;
            this.toolAcciones.Text = "toolEmpresa";
            // 
            // toolGuardar
            // 
            this.toolGuardar.Image = ((System.Drawing.Image)(resources.GetObject("toolGuardar.Image")));
            this.toolGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGuardar.Name = "toolGuardar";
            this.toolGuardar.Size = new System.Drawing.Size(86, 24);
            this.toolGuardar.Text = "Guardar";
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
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(118, 280);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(51, 17);
            this.Label2.TabIndex = 261;
            this.Label2.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(179, 278);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 22);
            this.dtpFecha.TabIndex = 260;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(41, 246);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(131, 17);
            this.Label9.TabIndex = 259;
            this.Label9.Text = "Sueldo del periodo:";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(179, 242);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(121, 22);
            this.txtSueldo.TabIndex = 258;
            this.txtSueldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSueldo.Leave += new System.EventHandler(this.txtSueldo_Leave);
            // 
            // txtSDI
            // 
            this.txtSDI.Location = new System.Drawing.Point(179, 173);
            this.txtSDI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDI.Name = "txtSDI";
            this.txtSDI.Size = new System.Drawing.Size(121, 22);
            this.txtSDI.TabIndex = 255;
            this.txtSDI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSDI.Leave += new System.EventHandler(this.txtSDI_Leave);
            // 
            // txtSD
            // 
            this.txtSD.Location = new System.Drawing.Point(179, 208);
            this.txtSD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSD.Name = "txtSD";
            this.txtSD.ReadOnly = true;
            this.txtSD.Size = new System.Drawing.Size(121, 22);
            this.txtSD.TabIndex = 256;
            this.txtSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(15, 177);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(159, 17);
            this.Label10.TabIndex = 254;
            this.Label10.Text = "Salario diario integrado:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(78, 211);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(95, 17);
            this.Label8.TabIndex = 257;
            this.Label8.Text = "Salario diario:";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.BackColor = System.Drawing.SystemColors.Control;
            this.txtDepartamento.Location = new System.Drawing.Point(322, 76);
            this.txtDepartamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(217, 22);
            this.txtDepartamento.TabIndex = 282;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 281;
            this.label1.Text = "Departamento:";
            // 
            // mtxtNoEmpleado
            // 
            this.mtxtNoEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtNoEmpleado.Location = new System.Drawing.Point(142, 76);
            this.mtxtNoEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtNoEmpleado.Mask = "9999";
            this.mtxtNoEmpleado.Name = "mtxtNoEmpleado";
            this.mtxtNoEmpleado.Size = new System.Drawing.Size(43, 22);
            this.mtxtNoEmpleado.TabIndex = 280;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 279;
            this.label4.Text = "No. Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 283;
            this.label3.Text = "Puesto:";
            // 
            // txtPuesto
            // 
            this.txtPuesto.BackColor = System.Drawing.SystemColors.Control;
            this.txtPuesto.Location = new System.Drawing.Point(322, 118);
            this.txtPuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(217, 22);
            this.txtPuesto.TabIndex = 284;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 316);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 285;
            this.label5.Text = "Departamento:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 352);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 286;
            this.label6.Text = "Puesto:";
            this.label6.Visible = false;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(179, 312);
            this.cmbDepartamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(217, 24);
            this.cmbDepartamento.TabIndex = 287;
            this.cmbDepartamento.Visible = false;
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(179, 348);
            this.cmbPuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(217, 24);
            this.cmbPuesto.TabIndex = 288;
            this.cmbPuesto.Visible = false;
            // 
            // chkCambioDeptoPto
            // 
            this.chkCambioDeptoPto.AutoSize = true;
            this.chkCambioDeptoPto.Location = new System.Drawing.Point(406, 315);
            this.chkCambioDeptoPto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkCambioDeptoPto.Name = "chkCambioDeptoPto";
            this.chkCambioDeptoPto.Size = new System.Drawing.Size(129, 21);
            this.chkCambioDeptoPto.TabIndex = 289;
            this.chkCambioDeptoPto.Text = "Modificar Depto";
            this.chkCambioDeptoPto.UseVisualStyleBackColor = true;
            this.chkCambioDeptoPto.Visible = false;
            this.chkCambioDeptoPto.CheckedChanged += new System.EventHandler(this.chkCambioDeptoPto_CheckedChanged);
            // 
            // chkModificaPuesto
            // 
            this.chkModificaPuesto.AutoSize = true;
            this.chkModificaPuesto.Location = new System.Drawing.Point(406, 351);
            this.chkModificaPuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkModificaPuesto.Name = "chkModificaPuesto";
            this.chkModificaPuesto.Size = new System.Drawing.Size(135, 21);
            this.chkModificaPuesto.TabIndex = 290;
            this.chkModificaPuesto.Text = "Modificar Puesto";
            this.chkModificaPuesto.UseVisualStyleBackColor = true;
            this.chkModificaPuesto.Visible = false;
            this.chkModificaPuesto.CheckedChanged += new System.EventHandler(this.chkModificaPuesto_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 291;
            this.label7.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(142, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(393, 22);
            this.txtNombre.TabIndex = 292;
            // 
            // frmIncrementoSalarial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 394);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkModificaPuesto);
            this.Controls.Add(this.chkCambioDeptoPto);
            this.Controls.Add(this.cmbPuesto);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxtNoEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtSDI);
            this.Controls.Add(this.txtSD);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.toolAcciones);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(590, 441);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(590, 441);
            this.Name = "frmIncrementoSalarial";
            this.Text = "Incremento salarial del trabajador";
            this.Load += new System.EventHandler(this.frmIncrementoSalarial_Load);
            this.toolAcciones.ResumeLayout(false);
            this.toolAcciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolAcciones;
        internal System.Windows.Forms.ToolStripButton toolGuardar;
        private System.Windows.Forms.ToolStripButton toolCerrar;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DateTimePicker dtpFecha;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtSueldo;
        internal System.Windows.Forms.TextBox txtSDI;
        internal System.Windows.Forms.TextBox txtSD;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label8;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtNoEmpleado;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.CheckBox chkCambioDeptoPto;
        private System.Windows.Forms.CheckBox chkModificaPuesto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;

    }
}