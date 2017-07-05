namespace Nominas
{
    partial class frmComplementos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComplementos));
            this.toolAcciones = new System.Windows.Forms.ToolStrip();
            this.toolGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolCerrar = new System.Windows.Forms.ToolStripButton();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.MaskedTextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.txtInterior = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtExterior = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbContrato = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbJornada = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbEscolaridad = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtClinica = new System.Windows.Forms.TextBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.mTelEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.mTelPersonal = new System.Windows.Forms.MaskedTextBox();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.mCelEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.mTelEmpresa2 = new System.Windows.Forms.MaskedTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.mTelEmpresa3 = new System.Windows.Forms.MaskedTextBox();
            this.tabComplementos = new System.Windows.Forms.TabControl();
            this.tabDireccion = new System.Windows.Forms.TabPage();
            this.tabOtrosDatos = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.toolAcciones.SuspendLayout();
            this.tabComplementos.SuspendLayout();
            this.tabDireccion.SuspendLayout();
            this.tabOtrosDatos.SuspendLayout();
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
            this.toolAcciones.Size = new System.Drawing.Size(791, 27);
            this.toolAcciones.TabIndex = 3;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 199);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 17);
            this.label13.TabIndex = 225;
            this.label13.Text = "Pais:";
            // 
            // txtPais
            // 
            this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPais.Location = new System.Drawing.Point(176, 196);
            this.txtPais.Margin = new System.Windows.Forms.Padding(4);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(172, 22);
            this.txtPais.TabIndex = 7;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMunicipio.Location = new System.Drawing.Point(176, 132);
            this.txtMunicipio.Margin = new System.Windows.Forms.Padding(4);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(172, 22);
            this.txtMunicipio.TabIndex = 5;
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Location = new System.Drawing.Point(176, 164);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(172, 22);
            this.txtEstado.TabIndex = 6;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(396, 135);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(38, 17);
            this.Label10.TabIndex = 224;
            this.Label10.Text = "C.P.:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(8, 12);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(43, 17);
            this.Label2.TabIndex = 218;
            this.Label2.Text = "Calle:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(8, 41);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(86, 17);
            this.Label4.TabIndex = 220;
            this.Label4.Text = "No. Exterior:";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(440, 132);
            this.txtCP.Margin = new System.Windows.Forms.Padding(4);
            this.txtCP.Mask = "00000";
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(52, 22);
            this.txtCP.TabIndex = 8;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(8, 69);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(82, 17);
            this.Label3.TabIndex = 219;
            this.Label3.Text = "No. Interior:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(8, 103);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(59, 17);
            this.Label5.TabIndex = 221;
            this.Label5.Text = "Colonia:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(8, 135);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(156, 17);
            this.Label6.TabIndex = 222;
            this.Label6.Text = "Municipio o delegación:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(8, 167);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(56, 17);
            this.Label7.TabIndex = 223;
            this.Label7.Text = "Estado:";
            // 
            // txtColonia
            // 
            this.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColonia.Location = new System.Drawing.Point(176, 100);
            this.txtColonia.Margin = new System.Windows.Forms.Padding(4);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(567, 22);
            this.txtColonia.TabIndex = 4;
            // 
            // txtInterior
            // 
            this.txtInterior.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInterior.Location = new System.Drawing.Point(176, 69);
            this.txtInterior.Margin = new System.Windows.Forms.Padding(4);
            this.txtInterior.Name = "txtInterior";
            this.txtInterior.Size = new System.Drawing.Size(88, 22);
            this.txtInterior.TabIndex = 3;
            // 
            // txtCalle
            // 
            this.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCalle.Location = new System.Drawing.Point(176, 7);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(567, 22);
            this.txtCalle.TabIndex = 1;
            // 
            // txtExterior
            // 
            this.txtExterior.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExterior.Location = new System.Drawing.Point(176, 38);
            this.txtExterior.Margin = new System.Windows.Forms.Padding(4);
            this.txtExterior.Name = "txtExterior";
            this.txtExterior.Size = new System.Drawing.Size(88, 22);
            this.txtExterior.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 227;
            this.label8.Text = "Contrato:";
            // 
            // cmbContrato
            // 
            this.cmbContrato.FormattingEnabled = true;
            this.cmbContrato.Location = new System.Drawing.Point(140, 10);
            this.cmbContrato.Margin = new System.Windows.Forms.Padding(4);
            this.cmbContrato.Name = "cmbContrato";
            this.cmbContrato.Size = new System.Drawing.Size(172, 24);
            this.cmbContrato.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 47);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 229;
            this.label9.Text = "Jornada:";
            // 
            // cmbJornada
            // 
            this.cmbJornada.FormattingEnabled = true;
            this.cmbJornada.Location = new System.Drawing.Point(140, 44);
            this.cmbJornada.Margin = new System.Windows.Forms.Padding(4);
            this.cmbJornada.Name = "cmbJornada";
            this.cmbJornada.Size = new System.Drawing.Size(172, 24);
            this.cmbJornada.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(45, 81);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 17);
            this.label14.TabIndex = 235;
            this.label14.Text = "Estado civil:";
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(140, 77);
            this.cmbEstadoCivil.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(172, 24);
            this.cmbEstadoCivil.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(85, 114);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 17);
            this.label15.TabIndex = 237;
            this.label15.Text = "Sexo:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(140, 110);
            this.cmbSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(172, 24);
            this.cmbSexo.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(45, 147);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 17);
            this.label17.TabIndex = 239;
            this.label17.Text = "Escolaridad:";
            // 
            // cmbEscolaridad
            // 
            this.cmbEscolaridad.FormattingEnabled = true;
            this.cmbEscolaridad.Location = new System.Drawing.Point(140, 143);
            this.cmbEscolaridad.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEscolaridad.Name = "cmbEscolaridad";
            this.cmbEscolaridad.Size = new System.Drawing.Size(172, 24);
            this.cmbEscolaridad.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(372, 14);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 17);
            this.label20.TabIndex = 245;
            this.label20.Text = "Clinica:";
            // 
            // txtClinica
            // 
            this.txtClinica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClinica.Location = new System.Drawing.Point(434, 12);
            this.txtClinica.Margin = new System.Windows.Forms.Padding(4);
            this.txtClinica.Name = "txtClinica";
            this.txtClinica.Size = new System.Drawing.Size(55, 22);
            this.txtClinica.TabIndex = 14;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNacionalidad.Location = new System.Drawing.Point(140, 177);
            this.txtNacionalidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(172, 22);
            this.txtNacionalidad.TabIndex = 15;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(34, 180);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 17);
            this.label21.TabIndex = 248;
            this.label21.Text = "Nacionalidad:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(22, 244);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(107, 17);
            this.label22.TabIndex = 249;
            this.label22.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.Location = new System.Drawing.Point(148, 241);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(592, 164);
            this.txtObservaciones.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(318, 46);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 17);
            this.label11.TabIndex = 252;
            this.label11.Text = "Tel. Empresa 1:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(330, 174);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 17);
            this.label12.TabIndex = 253;
            this.label12.Text = "Tel. Personal:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(372, 209);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 17);
            this.label18.TabIndex = 254;
            this.label18.Text = "Correo:";
            // 
            // mTelEmpresa
            // 
            this.mTelEmpresa.Location = new System.Drawing.Point(434, 45);
            this.mTelEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.mTelEmpresa.Mask = "(999)-999-9999";
            this.mTelEmpresa.Name = "mTelEmpresa";
            this.mTelEmpresa.Size = new System.Drawing.Size(107, 22);
            this.mTelEmpresa.TabIndex = 255;
            // 
            // mTelPersonal
            // 
            this.mTelPersonal.Location = new System.Drawing.Point(434, 177);
            this.mTelPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.mTelPersonal.Mask = "(999)-999-9999";
            this.mTelPersonal.Name = "mTelPersonal";
            this.mTelPersonal.Size = new System.Drawing.Size(107, 22);
            this.mTelPersonal.TabIndex = 258;
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(550, 45);
            this.txtExtension.Margin = new System.Windows.Forms.Padding(4);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(56, 22);
            this.txtExtension.TabIndex = 260;
            this.txtExtension.Text = "00000";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(434, 209);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(305, 22);
            this.txtCorreo.TabIndex = 261;
            this.txtCorreo.Text = "user@dominio.com";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(330, 142);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 17);
            this.label19.TabIndex = 262;
            this.label19.Text = "Cel. Empresa:";
            // 
            // mCelEmpresa
            // 
            this.mCelEmpresa.Location = new System.Drawing.Point(434, 143);
            this.mCelEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.mCelEmpresa.Mask = "(999)-999-9999";
            this.mCelEmpresa.Name = "mCelEmpresa";
            this.mCelEmpresa.Size = new System.Drawing.Size(107, 22);
            this.mCelEmpresa.TabIndex = 263;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(318, 78);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(108, 17);
            this.label24.TabIndex = 264;
            this.label24.Text = "Tel. Empresa 2:";
            // 
            // mTelEmpresa2
            // 
            this.mTelEmpresa2.Location = new System.Drawing.Point(434, 78);
            this.mTelEmpresa2.Margin = new System.Windows.Forms.Padding(4);
            this.mTelEmpresa2.Mask = "(999)-000-0000";
            this.mTelEmpresa2.Name = "mTelEmpresa2";
            this.mTelEmpresa2.Size = new System.Drawing.Size(107, 22);
            this.mTelEmpresa2.TabIndex = 265;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(318, 110);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(108, 17);
            this.label25.TabIndex = 266;
            this.label25.Text = "Tel. Empresa 3:";
            // 
            // mTelEmpresa3
            // 
            this.mTelEmpresa3.Location = new System.Drawing.Point(434, 111);
            this.mTelEmpresa3.Margin = new System.Windows.Forms.Padding(4);
            this.mTelEmpresa3.Mask = "(000)-000-0000";
            this.mTelEmpresa3.Name = "mTelEmpresa3";
            this.mTelEmpresa3.Size = new System.Drawing.Size(107, 22);
            this.mTelEmpresa3.TabIndex = 267;
            // 
            // tabComplementos
            // 
            this.tabComplementos.Controls.Add(this.tabDireccion);
            this.tabComplementos.Controls.Add(this.tabOtrosDatos);
            this.tabComplementos.Location = new System.Drawing.Point(18, 66);
            this.tabComplementos.Name = "tabComplementos";
            this.tabComplementos.SelectedIndex = 0;
            this.tabComplementos.Size = new System.Drawing.Size(758, 452);
            this.tabComplementos.TabIndex = 268;
            // 
            // tabDireccion
            // 
            this.tabDireccion.Controls.Add(this.txtCalle);
            this.tabDireccion.Controls.Add(this.txtExterior);
            this.tabDireccion.Controls.Add(this.txtInterior);
            this.tabDireccion.Controls.Add(this.txtColonia);
            this.tabDireccion.Controls.Add(this.Label7);
            this.tabDireccion.Controls.Add(this.Label6);
            this.tabDireccion.Controls.Add(this.Label5);
            this.tabDireccion.Controls.Add(this.Label3);
            this.tabDireccion.Controls.Add(this.txtCP);
            this.tabDireccion.Controls.Add(this.Label4);
            this.tabDireccion.Controls.Add(this.Label2);
            this.tabDireccion.Controls.Add(this.Label10);
            this.tabDireccion.Controls.Add(this.txtEstado);
            this.tabDireccion.Controls.Add(this.txtMunicipio);
            this.tabDireccion.Controls.Add(this.txtPais);
            this.tabDireccion.Controls.Add(this.label13);
            this.tabDireccion.Location = new System.Drawing.Point(4, 25);
            this.tabDireccion.Name = "tabDireccion";
            this.tabDireccion.Padding = new System.Windows.Forms.Padding(3);
            this.tabDireccion.Size = new System.Drawing.Size(750, 423);
            this.tabDireccion.TabIndex = 0;
            this.tabDireccion.Text = "Dirección";
            this.tabDireccion.UseVisualStyleBackColor = true;
            // 
            // tabOtrosDatos
            // 
            this.tabOtrosDatos.Controls.Add(this.cmbJornada);
            this.tabOtrosDatos.Controls.Add(this.mTelEmpresa3);
            this.tabOtrosDatos.Controls.Add(this.label8);
            this.tabOtrosDatos.Controls.Add(this.label25);
            this.tabOtrosDatos.Controls.Add(this.cmbContrato);
            this.tabOtrosDatos.Controls.Add(this.mTelEmpresa2);
            this.tabOtrosDatos.Controls.Add(this.label9);
            this.tabOtrosDatos.Controls.Add(this.label24);
            this.tabOtrosDatos.Controls.Add(this.label14);
            this.tabOtrosDatos.Controls.Add(this.mCelEmpresa);
            this.tabOtrosDatos.Controls.Add(this.cmbEstadoCivil);
            this.tabOtrosDatos.Controls.Add(this.label19);
            this.tabOtrosDatos.Controls.Add(this.label15);
            this.tabOtrosDatos.Controls.Add(this.txtCorreo);
            this.tabOtrosDatos.Controls.Add(this.cmbSexo);
            this.tabOtrosDatos.Controls.Add(this.txtExtension);
            this.tabOtrosDatos.Controls.Add(this.label17);
            this.tabOtrosDatos.Controls.Add(this.mTelPersonal);
            this.tabOtrosDatos.Controls.Add(this.cmbEscolaridad);
            this.tabOtrosDatos.Controls.Add(this.mTelEmpresa);
            this.tabOtrosDatos.Controls.Add(this.label20);
            this.tabOtrosDatos.Controls.Add(this.label18);
            this.tabOtrosDatos.Controls.Add(this.txtClinica);
            this.tabOtrosDatos.Controls.Add(this.label12);
            this.tabOtrosDatos.Controls.Add(this.txtNacionalidad);
            this.tabOtrosDatos.Controls.Add(this.label11);
            this.tabOtrosDatos.Controls.Add(this.label21);
            this.tabOtrosDatos.Controls.Add(this.label22);
            this.tabOtrosDatos.Controls.Add(this.txtObservaciones);
            this.tabOtrosDatos.Location = new System.Drawing.Point(4, 25);
            this.tabOtrosDatos.Name = "tabOtrosDatos";
            this.tabOtrosDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabOtrosDatos.Size = new System.Drawing.Size(750, 423);
            this.tabOtrosDatos.TabIndex = 1;
            this.tabOtrosDatos.Text = "Otros datos";
            this.tabOtrosDatos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 269;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(84, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(688, 22);
            this.txtNombre.TabIndex = 270;
            // 
            // frmComplementos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 530);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabComplementos);
            this.Controls.Add(this.toolAcciones);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(809, 577);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(809, 577);
            this.Name = "frmComplementos";
            this.Text = "Dirección y otros datos";
            this.Load += new System.EventHandler(this.frmComplementos_Load);
            this.toolAcciones.ResumeLayout(false);
            this.toolAcciones.PerformLayout();
            this.tabComplementos.ResumeLayout(false);
            this.tabDireccion.ResumeLayout(false);
            this.tabDireccion.PerformLayout();
            this.tabOtrosDatos.ResumeLayout(false);
            this.tabOtrosDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolAcciones;
        internal System.Windows.Forms.ToolStripButton toolGuardar;
        private System.Windows.Forms.ToolStripButton toolCerrar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPais;
        internal System.Windows.Forms.TextBox txtMunicipio;
        internal System.Windows.Forms.TextBox txtEstado;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.MaskedTextBox txtCP;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtColonia;
        internal System.Windows.Forms.TextBox txtInterior;
        internal System.Windows.Forms.TextBox txtCalle;
        internal System.Windows.Forms.TextBox txtExterior;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbContrato;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbJornada;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbEscolaridad;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtClinica;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox mTelEmpresa;
        private System.Windows.Forms.MaskedTextBox mTelPersonal;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox mCelEmpresa;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.MaskedTextBox mTelEmpresa2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.MaskedTextBox mTelEmpresa3;
        private System.Windows.Forms.TabControl tabComplementos;
        private System.Windows.Forms.TabPage tabDireccion;
        private System.Windows.Forms.TabPage tabOtrosDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
    }
}