namespace Nominas
{
    partial class frmReingresoEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReingresoEmpleado));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaReingreso = new System.Windows.Forms.DateTimePicker();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtSalarioDiario = new System.Windows.Forms.TextBox();
            this.txtSDI = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.mtxtIdBancario = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCuentaClabe = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCuentaBancaria = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.mtxtNoEmpleado = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chkObraCivil = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha reingreso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Departamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Puesto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 216);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sueldo del periodo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 248);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Salario diario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 280);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Salario diario integrado:";
            // 
            // dtpFechaReingreso
            // 
            this.dtpFechaReingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaReingreso.Location = new System.Drawing.Point(169, 84);
            this.dtpFechaReingreso.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaReingreso.Name = "dtpFechaReingreso";
            this.dtpFechaReingreso.Size = new System.Drawing.Size(169, 22);
            this.dtpFechaReingreso.TabIndex = 9;
            this.dtpFechaReingreso.Leave += new System.EventHandler(this.dtpFechaReingreso_Leave);
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(169, 113);
            this.cmbDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(169, 24);
            this.cmbDepartamento.TabIndex = 11;
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(169, 146);
            this.cmbPuesto.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(169, 24);
            this.cmbPuesto.TabIndex = 12;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Enabled = false;
            this.txtSueldo.Location = new System.Drawing.Point(169, 212);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(169, 22);
            this.txtSueldo.TabIndex = 13;
            // 
            // txtSalarioDiario
            // 
            this.txtSalarioDiario.Enabled = false;
            this.txtSalarioDiario.Location = new System.Drawing.Point(169, 244);
            this.txtSalarioDiario.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalarioDiario.Name = "txtSalarioDiario";
            this.txtSalarioDiario.Size = new System.Drawing.Size(169, 22);
            this.txtSalarioDiario.TabIndex = 14;
            // 
            // txtSDI
            // 
            this.txtSDI.Location = new System.Drawing.Point(169, 276);
            this.txtSDI.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDI.Name = "txtSDI";
            this.txtSDI.Size = new System.Drawing.Size(169, 22);
            this.txtSDI.TabIndex = 15;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(397, 369);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 34);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(505, 369);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 34);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(346, 273);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(83, 28);
            this.btnCalcular.TabIndex = 18;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Enabled = false;
            this.txtAntiguedad.Location = new System.Drawing.Point(348, 84);
            this.txtAntiguedad.Margin = new System.Windows.Forms.Padding(4);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(35, 22);
            this.txtAntiguedad.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(100, 183);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Periodo:";
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(169, 179);
            this.cmbPeriodo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(169, 24);
            this.cmbPeriodo.TabIndex = 23;
            // 
            // mtxtIdBancario
            // 
            this.mtxtIdBancario.Location = new System.Drawing.Point(169, 375);
            this.mtxtIdBancario.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtIdBancario.Mask = "9999";
            this.mtxtIdBancario.Name = "mtxtIdBancario";
            this.mtxtIdBancario.Size = new System.Drawing.Size(171, 22);
            this.mtxtIdBancario.TabIndex = 250;
            this.mtxtIdBancario.Text = "0000";
            // 
            // mtxtCuentaClabe
            // 
            this.mtxtCuentaClabe.Location = new System.Drawing.Point(169, 343);
            this.mtxtCuentaClabe.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtCuentaClabe.Mask = "999 999 99999999999 9";
            this.mtxtCuentaClabe.Name = "mtxtCuentaClabe";
            this.mtxtCuentaClabe.Size = new System.Drawing.Size(171, 22);
            this.mtxtCuentaClabe.TabIndex = 249;
            this.mtxtCuentaClabe.Text = "000000000000000000";
            // 
            // mtxtCuentaBancaria
            // 
            this.mtxtCuentaBancaria.Location = new System.Drawing.Point(169, 311);
            this.mtxtCuentaBancaria.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtCuentaBancaria.Mask = "9999999999";
            this.mtxtCuentaBancaria.Name = "mtxtCuentaBancaria";
            this.mtxtCuentaBancaria.Size = new System.Drawing.Size(169, 22);
            this.mtxtCuentaBancaria.TabIndex = 248;
            this.mtxtCuentaBancaria.Text = "0000000000";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(75, 379);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 17);
            this.label19.TabIndex = 247;
            this.label19.Text = "ID bancario:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(64, 347);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 17);
            this.label18.TabIndex = 246;
            this.label18.Text = "Cuenta clabe:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(44, 315);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 17);
            this.label17.TabIndex = 245;
            this.label17.Text = "Cuenta bancaria:";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombreCompleto.Location = new System.Drawing.Point(169, 52);
            this.txtNombreCompleto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(260, 22);
            this.txtNombreCompleto.TabIndex = 255;
            // 
            // mtxtNoEmpleado
            // 
            this.mtxtNoEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtNoEmpleado.Location = new System.Drawing.Point(168, 20);
            this.mtxtNoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtNoEmpleado.Mask = "9999";
            this.mtxtNoEmpleado.Name = "mtxtNoEmpleado";
            this.mtxtNoEmpleado.Size = new System.Drawing.Size(43, 22);
            this.mtxtNoEmpleado.TabIndex = 254;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(71, 23);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 17);
            this.label11.TabIndex = 253;
            this.label11.Text = "Empleado:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(87, 55);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 17);
            this.label13.TabIndex = 256;
            this.label13.Text = "Nombre:";
            // 
            // chkObraCivil
            // 
            this.chkObraCivil.AutoSize = true;
            this.chkObraCivil.Location = new System.Drawing.Point(227, 23);
            this.chkObraCivil.Margin = new System.Windows.Forms.Padding(4);
            this.chkObraCivil.Name = "chkObraCivil";
            this.chkObraCivil.Size = new System.Drawing.Size(111, 21);
            this.chkObraCivil.TabIndex = 257;
            this.chkObraCivil.Text = "Es Obra Civil";
            this.chkObraCivil.UseVisualStyleBackColor = true;
            // 
            // frmReingresoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 413);
            this.Controls.Add(this.chkObraCivil);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.mtxtNoEmpleado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mtxtIdBancario);
            this.Controls.Add(this.mtxtCuentaClabe);
            this.Controls.Add(this.mtxtCuentaBancaria);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAntiguedad);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtSDI);
            this.Controls.Add(this.txtSalarioDiario);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.cmbPuesto);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.dtpFechaReingreso);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(634, 460);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(634, 460);
            this.Name = "frmReingresoEmpleado";
            this.Text = "Reingreso del empleado";
            this.Load += new System.EventHandler(this.frmReingresoEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaReingreso;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtSalarioDiario;
        private System.Windows.Forms.TextBox txtSDI;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.MaskedTextBox mtxtIdBancario;
        private System.Windows.Forms.MaskedTextBox mtxtCuentaClabe;
        private System.Windows.Forms.MaskedTextBox mtxtCuentaBancaria;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.MaskedTextBox mtxtNoEmpleado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkObraCivil;
    }
}