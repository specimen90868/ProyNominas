namespace Nominas
{
    partial class frmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            this.toolEmpleado = new System.Windows.Forms.ToolStrip();
            this.toolHistorial = new System.Windows.Forms.ToolStripButton();
            this.toolGuardarNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolCerrar = new System.Windows.Forms.ToolStripButton();
            this.lblSalario = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNSS = new System.Windows.Forms.MaskedTextBox();
            this.txtCURP = new System.Windows.Forms.TextBox();
            this.Label27 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.cmbTipoSalario = new System.Windows.Forms.ComboBox();
            this.lblTipoSalario = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtSD = new System.Windows.Forms.TextBox();
            this.lblSD = new System.Windows.Forms.Label();
            this.txtSDI = new System.Windows.Forms.TextBox();
            this.lblSDI = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.Label11 = new System.Windows.Forms.Label();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.rbtnHombre = new System.Windows.Forms.RadioButton();
            this.rbtnMujer = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.btnObtenerCurp = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.mtxtCuentaBancaria = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCuentaClabe = new System.Windows.Forms.MaskedTextBox();
            this.mtxtIdBancario = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNoEmpleado = new System.Windows.Forms.MaskedTextBox();
            this.chkObraCivil = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaBaja = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.toolEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolEmpleado
            // 
            this.toolEmpleado.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolEmpleado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolHistorial,
            this.toolGuardarNuevo,
            this.toolCerrar});
            this.toolEmpleado.Location = new System.Drawing.Point(0, 0);
            this.toolEmpleado.Name = "toolEmpleado";
            this.toolEmpleado.Size = new System.Drawing.Size(862, 27);
            this.toolEmpleado.TabIndex = 2;
            this.toolEmpleado.Text = "toolEmpresa";
            // 
            // toolHistorial
            // 
            this.toolHistorial.Image = ((System.Drawing.Image)(resources.GetObject("toolHistorial.Image")));
            this.toolHistorial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolHistorial.Name = "toolHistorial";
            this.toolHistorial.Size = new System.Drawing.Size(89, 24);
            this.toolHistorial.Text = "Historial";
            this.toolHistorial.Click += new System.EventHandler(this.toolHistorial_Click);
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
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.SystemColors.Control;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblSalario.Location = new System.Drawing.Point(17, 408);
            this.lblSalario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(74, 24);
            this.lblSalario.TabIndex = 209;
            this.lblSalario.Text = "Salario";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.BackColor = System.Drawing.SystemColors.Control;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.Label16.Location = new System.Drawing.Point(19, 43);
            this.Label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(170, 24);
            this.Label16.TabIndex = 208;
            this.Label16.Text = "Datos principales";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(379, 542);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(72, 25);
            this.btnCalcular.TabIndex = 27;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNSS
            // 
            this.txtNSS.Location = new System.Drawing.Point(553, 165);
            this.txtNSS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNSS.Mask = "99999999999";
            this.txtNSS.Name = "txtNSS";
            this.txtNSS.Size = new System.Drawing.Size(200, 22);
            this.txtNSS.TabIndex = 15;
            // 
            // txtCURP
            // 
            this.txtCURP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCURP.Location = new System.Drawing.Point(553, 133);
            this.txtCURP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCURP.Name = "txtCURP";
            this.txtCURP.Size = new System.Drawing.Size(200, 22);
            this.txtCURP.TabIndex = 13;
            this.txtCURP.Leave += new System.EventHandler(this.txtCURP_Leave);
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(476, 137);
            this.Label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(66, 17);
            this.Label27.TabIndex = 195;
            this.Label27.Text = "C.U.R.P.:";
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(491, 169);
            this.Label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(52, 17);
            this.Label26.TabIndex = 196;
            this.Label26.Text = "N.S.S.:";
            // 
            // cmbTipoSalario
            // 
            this.cmbTipoSalario.Enabled = false;
            this.cmbTipoSalario.FormattingEnabled = true;
            this.cmbTipoSalario.Location = new System.Drawing.Point(168, 444);
            this.cmbTipoSalario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoSalario.Name = "cmbTipoSalario";
            this.cmbTipoSalario.Size = new System.Drawing.Size(201, 24);
            this.cmbTipoSalario.TabIndex = 23;
            // 
            // lblTipoSalario
            // 
            this.lblTipoSalario.AutoSize = true;
            this.lblTipoSalario.Location = new System.Drawing.Point(56, 448);
            this.lblTipoSalario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoSalario.Name = "lblTipoSalario";
            this.lblTipoSalario.Size = new System.Drawing.Size(106, 17);
            this.lblTipoSalario.TabIndex = 193;
            this.lblTipoSalario.Text = "Tipo de salario:";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Enabled = false;
            this.txtSueldo.Location = new System.Drawing.Point(169, 478);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.ReadOnly = true;
            this.txtSueldo.Size = new System.Drawing.Size(201, 22);
            this.txtSueldo.TabIndex = 24;
            this.txtSueldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(31, 483);
            this.lblSueldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(131, 17);
            this.lblSueldo.TabIndex = 192;
            this.lblSueldo.Text = "Sueldo del periodo:";
            // 
            // txtSD
            // 
            this.txtSD.Location = new System.Drawing.Point(168, 510);
            this.txtSD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSD.Name = "txtSD";
            this.txtSD.ReadOnly = true;
            this.txtSD.Size = new System.Drawing.Size(201, 22);
            this.txtSD.TabIndex = 25;
            this.txtSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSD
            // 
            this.lblSD.AutoSize = true;
            this.lblSD.Location = new System.Drawing.Point(68, 513);
            this.lblSD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSD.Name = "lblSD";
            this.lblSD.Size = new System.Drawing.Size(95, 17);
            this.lblSD.TabIndex = 190;
            this.lblSD.Text = "Salario diario:";
            // 
            // txtSDI
            // 
            this.txtSDI.Location = new System.Drawing.Point(168, 542);
            this.txtSDI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDI.Name = "txtSDI";
            this.txtSDI.Size = new System.Drawing.Size(201, 22);
            this.txtSDI.TabIndex = 26;
            this.txtSDI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSDI
            // 
            this.lblSDI.AutoSize = true;
            this.lblSDI.Location = new System.Drawing.Point(5, 545);
            this.lblSDI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDI.Name = "lblSDI";
            this.lblSDI.Size = new System.Drawing.Size(159, 17);
            this.lblSDI.TabIndex = 187;
            this.lblSDI.Text = "Salario diario integrado:";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(169, 229);
            this.dtpFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFechaIngreso.Size = new System.Drawing.Size(201, 22);
            this.dtpFechaIngreso.TabIndex = 5;
            this.dtpFechaIngreso.Leave += new System.EventHandler(this.dtpFechaIngreso_Leave);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(39, 233);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(122, 17);
            this.Label11.TabIndex = 184;
            this.Label11.Text = "Fecha de ingreso:";
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(553, 264);
            this.cmbPeriodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(200, 24);
            this.cmbPeriodo.TabIndex = 18;
            this.cmbPeriodo.SelectedIndexChanged += new System.EventHandler(this.cmbPeriodo_SelectedIndexChanged);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(484, 267);
            this.lblPeriodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(61, 17);
            this.lblPeriodo.TabIndex = 183;
            this.lblPeriodo.Text = "Periodo:";
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApMaterno.Location = new System.Drawing.Point(169, 165);
            this.txtApMaterno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(201, 22);
            this.txtApMaterno.TabIndex = 3;
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApPaterno.Location = new System.Drawing.Point(169, 133);
            this.txtApPaterno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(201, 22);
            this.txtApPaterno.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(169, 101);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(201, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(43, 169);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(118, 17);
            this.Label3.TabIndex = 179;
            this.Label3.Text = "Apellido Materno:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(45, 137);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(116, 17);
            this.Label2.TabIndex = 177;
            this.Label2.Text = "Apellido Paterno:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(84, 105);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(79, 17);
            this.Label7.TabIndex = 175;
            this.Label7.Text = "Nombre(s):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 210;
            this.label1.Text = "R.F.C.:";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(553, 101);
            this.txtRFC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(200, 22);
            this.txtRFC.TabIndex = 12;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(169, 261);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(201, 22);
            this.dtpFechaNacimiento.TabIndex = 7;
            this.dtpFechaNacimiento.Leave += new System.EventHandler(this.dtpFechaNacimiento_Leave);
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(379, 261);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(39, 22);
            this.txtEdad.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 216;
            this.label6.Text = "No. de Empleado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(443, 201);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 218;
            this.label8.Text = "Departamento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(488, 234);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 219;
            this.label9.Text = "Puesto:";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(553, 197);
            this.cmbDepartamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(200, 24);
            this.cmbDepartamento.TabIndex = 16;
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(553, 230);
            this.cmbPuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(200, 24);
            this.cmbPuesto.TabIndex = 17;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(104, 328);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 17);
            this.lblEstado.TabIndex = 224;
            this.lblEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.ItemHeight = 16;
            this.cmbEstado.Location = new System.Drawing.Point(169, 324);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(200, 24);
            this.cmbEstado.TabIndex = 9;
            // 
            // rbtnHombre
            // 
            this.rbtnHombre.AutoSize = true;
            this.rbtnHombre.Location = new System.Drawing.Point(171, 357);
            this.rbtnHombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnHombre.Name = "rbtnHombre";
            this.rbtnHombre.Size = new System.Drawing.Size(79, 21);
            this.rbtnHombre.TabIndex = 10;
            this.rbtnHombre.TabStop = true;
            this.rbtnHombre.Text = "Hombre";
            this.rbtnHombre.UseVisualStyleBackColor = true;
            // 
            // rbtnMujer
            // 
            this.rbtnMujer.AutoSize = true;
            this.rbtnMujer.Location = new System.Drawing.Point(275, 357);
            this.rbtnMujer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnMujer.Name = "rbtnMujer";
            this.rbtnMujer.Size = new System.Drawing.Size(64, 21);
            this.rbtnMujer.TabIndex = 11;
            this.rbtnMujer.TabStop = true;
            this.rbtnMujer.Text = "Mujer";
            this.rbtnMujer.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(115, 360);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 17);
            this.label12.TabIndex = 230;
            this.label12.Text = "Sexo:";
            // 
            // btnObtenerCurp
            // 
            this.btnObtenerCurp.Location = new System.Drawing.Point(763, 133);
            this.btnObtenerCurp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObtenerCurp.Name = "btnObtenerCurp";
            this.btnObtenerCurp.Size = new System.Drawing.Size(84, 28);
            this.btnObtenerCurp.TabIndex = 14;
            this.btnObtenerCurp.Text = "Obtener";
            this.btnObtenerCurp.UseVisualStyleBackColor = true;
            this.btnObtenerCurp.Click += new System.EventHandler(this.btnObtenerCurp_Click);
            // 
            // btnVer
            // 
            this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(553, 298);
            this.btnVer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(89, 43);
            this.btnVer.TabIndex = 21;
            this.btnVer.Text = "Ver";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignar.Image")));
            this.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignar.Location = new System.Drawing.Point(665, 298);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(89, 43);
            this.btnAsignar.TabIndex = 22;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(504, 312);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 17);
            this.label13.TabIndex = 234;
            this.label13.Text = "Foto:";
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Enabled = false;
            this.txtAntiguedad.Location = new System.Drawing.Point(379, 230);
            this.txtAntiguedad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(39, 22);
            this.txtAntiguedad.TabIndex = 235;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(413, 398);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 24);
            this.label15.TabIndex = 238;
            this.label15.Text = "Datos bancarios";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(437, 447);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 17);
            this.label17.TabIndex = 239;
            this.label17.Text = "Cuenta bancaria:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(457, 479);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 17);
            this.label18.TabIndex = 240;
            this.label18.Text = "Cuenta clabe:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(467, 511);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 17);
            this.label19.TabIndex = 241;
            this.label19.Text = "ID bancario:";
            // 
            // mtxtCuentaBancaria
            // 
            this.mtxtCuentaBancaria.Location = new System.Drawing.Point(562, 443);
            this.mtxtCuentaBancaria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtCuentaBancaria.Mask = "9999999999";
            this.mtxtCuentaBancaria.Name = "mtxtCuentaBancaria";
            this.mtxtCuentaBancaria.Size = new System.Drawing.Size(201, 22);
            this.mtxtCuentaBancaria.TabIndex = 28;
            this.mtxtCuentaBancaria.Text = "0000000000";
            // 
            // mtxtCuentaClabe
            // 
            this.mtxtCuentaClabe.Location = new System.Drawing.Point(562, 475);
            this.mtxtCuentaClabe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtCuentaClabe.Mask = "999 999 99999999999 9";
            this.mtxtCuentaClabe.Name = "mtxtCuentaClabe";
            this.mtxtCuentaClabe.Size = new System.Drawing.Size(201, 22);
            this.mtxtCuentaClabe.TabIndex = 29;
            this.mtxtCuentaClabe.Text = "000000000000000000";
            // 
            // mtxtIdBancario
            // 
            this.mtxtIdBancario.Location = new System.Drawing.Point(562, 507);
            this.mtxtIdBancario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtIdBancario.Mask = "9999";
            this.mtxtIdBancario.Name = "mtxtIdBancario";
            this.mtxtIdBancario.Size = new System.Drawing.Size(201, 22);
            this.mtxtIdBancario.TabIndex = 30;
            this.mtxtIdBancario.Text = "0000";
            // 
            // mtxtNoEmpleado
            // 
            this.mtxtNoEmpleado.Location = new System.Drawing.Point(168, 197);
            this.mtxtNoEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtNoEmpleado.Mask = "9999";
            this.mtxtNoEmpleado.Name = "mtxtNoEmpleado";
            this.mtxtNoEmpleado.Size = new System.Drawing.Size(201, 22);
            this.mtxtNoEmpleado.TabIndex = 4;
            this.mtxtNoEmpleado.Text = "0000";
            this.mtxtNoEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtNoEmpleado.Leave += new System.EventHandler(this.mtxtNoEmpleado_Leave);
            // 
            // chkObraCivil
            // 
            this.chkObraCivil.AutoSize = true;
            this.chkObraCivil.Location = new System.Drawing.Point(168, 73);
            this.chkObraCivil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkObraCivil.Name = "chkObraCivil";
            this.chkObraCivil.Size = new System.Drawing.Size(111, 21);
            this.chkObraCivil.TabIndex = 32;
            this.chkObraCivil.Text = "Es Obra Civil";
            this.chkObraCivil.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 214;
            this.label5.Text = "Fecha de nacimiento:";
            // 
            // dtpFechaBaja
            // 
            this.dtpFechaBaja.Enabled = false;
            this.dtpFechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaBaja.Location = new System.Drawing.Point(171, 293);
            this.dtpFechaBaja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaBaja.Name = "dtpFechaBaja";
            this.dtpFechaBaja.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaBaja.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 296);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 252;
            this.label4.Text = "Fecha de baja:";
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 593);
            this.Controls.Add(this.dtpFechaBaja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkObraCivil);
            this.Controls.Add(this.mtxtNoEmpleado);
            this.Controls.Add(this.mtxtIdBancario);
            this.Controls.Add(this.mtxtCuentaClabe);
            this.Controls.Add(this.mtxtCuentaBancaria);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtAntiguedad);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnObtenerCurp);
            this.Controls.Add(this.rbtnMujer);
            this.Controls.Add(this.rbtnHombre);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cmbPuesto);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNSS);
            this.Controls.Add(this.txtCURP);
            this.Controls.Add(this.Label27);
            this.Controls.Add(this.Label26);
            this.Controls.Add(this.cmbTipoSalario);
            this.Controls.Add(this.lblTipoSalario);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.txtSD);
            this.Controls.Add(this.lblSD);
            this.Controls.Add(this.txtSDI);
            this.Controls.Add(this.lblSDI);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.txtApMaterno);
            this.Controls.Add(this.txtApPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.toolEmpleado);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(880, 640);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(880, 640);
            this.Name = "frmEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.toolEmpleado.ResumeLayout(false);
            this.toolEmpleado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolEmpleado;
        internal System.Windows.Forms.ToolStripButton toolGuardarNuevo;
        private System.Windows.Forms.ToolStripButton toolCerrar;
        internal System.Windows.Forms.Label lblSalario;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Button btnCalcular;
        internal System.Windows.Forms.MaskedTextBox txtNSS;
        internal System.Windows.Forms.TextBox txtCURP;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.ComboBox cmbTipoSalario;
        internal System.Windows.Forms.Label lblTipoSalario;
        internal System.Windows.Forms.TextBox txtSueldo;
        internal System.Windows.Forms.Label lblSueldo;
        internal System.Windows.Forms.TextBox txtSD;
        internal System.Windows.Forms.Label lblSD;
        internal System.Windows.Forms.TextBox txtSDI;
        internal System.Windows.Forms.Label lblSDI;
        internal System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.ComboBox cmbPeriodo;
        internal System.Windows.Forms.Label lblPeriodo;
        internal System.Windows.Forms.TextBox txtApMaterno;
        internal System.Windows.Forms.TextBox txtApPaterno;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.RadioButton rbtnHombre;
        private System.Windows.Forms.RadioButton rbtnMujer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnObtenerCurp;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.ToolStripButton toolHistorial;
        internal System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox mtxtCuentaBancaria;
        private System.Windows.Forms.MaskedTextBox mtxtCuentaClabe;
        private System.Windows.Forms.MaskedTextBox mtxtIdBancario;
        private System.Windows.Forms.MaskedTextBox mtxtNoEmpleado;
        private System.Windows.Forms.CheckBox chkObraCivil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaBaja;
        private System.Windows.Forms.Label label4;
    }
}