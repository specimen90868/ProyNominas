namespace Nominas
{
    partial class frmEmpresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpresas));
            this.toolEmpresa = new System.Windows.Forms.ToolStrip();
            this.toolGuardarNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolCerrar = new System.Windows.Forms.ToolStripButton();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.txtRegistroPatronal = new System.Windows.Forms.MaskedTextBox();
            this.txtDigitoVerificador = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
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
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtCertificado = new System.Windows.Forms.TextBox();
            this.txtLlave = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtNoCertificado = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.dtpVigencia = new System.Windows.Forms.DateTimePicker();
            this.cmbPago = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.tabEmpresas = new System.Windows.Forms.TabControl();
            this.tabEmpresa = new System.Windows.Forms.TabPage();
            this.cmbRegimenFiscal = new System.Windows.Forms.ComboBox();
            this.chkObraCivil = new System.Windows.Forms.CheckBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtRepresentante = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.tabDomicilio = new System.Windows.Forms.TabPage();
            this.tabPeriodo = new System.Windows.Forms.TabPage();
            this.tabTimbrado = new System.Windows.Forms.TabPage();
            this.toolEmpresa.SuspendLayout();
            this.tabEmpresas.SuspendLayout();
            this.tabEmpresa.SuspendLayout();
            this.tabDomicilio.SuspendLayout();
            this.tabPeriodo.SuspendLayout();
            this.tabTimbrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolEmpresa
            // 
            this.toolEmpresa.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolEmpresa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolGuardarNuevo,
            this.toolCerrar});
            this.toolEmpresa.Location = new System.Drawing.Point(0, 0);
            this.toolEmpresa.Name = "toolEmpresa";
            this.toolEmpresa.Size = new System.Drawing.Size(741, 27);
            this.toolEmpresa.TabIndex = 0;
            this.toolEmpresa.Text = "toolEmpresa";
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
            // txtRfc
            // 
            this.txtRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRfc.Location = new System.Drawing.Point(151, 263);
            this.txtRfc.Margin = new System.Windows.Forms.Padding(4);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(128, 22);
            this.txtRfc.TabIndex = 12;
            this.txtRfc.Leave += new System.EventHandler(this.txtRfc_Leave);
            // 
            // txtRegistroPatronal
            // 
            this.txtRegistroPatronal.Location = new System.Drawing.Point(151, 295);
            this.txtRegistroPatronal.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegistroPatronal.Mask = "AAAAAAAAAA";
            this.txtRegistroPatronal.Name = "txtRegistroPatronal";
            this.txtRegistroPatronal.Size = new System.Drawing.Size(127, 22);
            this.txtRegistroPatronal.TabIndex = 13;
            // 
            // txtDigitoVerificador
            // 
            this.txtDigitoVerificador.Location = new System.Drawing.Point(465, 295);
            this.txtDigitoVerificador.Margin = new System.Windows.Forms.Padding(4);
            this.txtDigitoVerificador.Name = "txtDigitoVerificador";
            this.txtDigitoVerificador.Size = new System.Drawing.Size(27, 22);
            this.txtDigitoVerificador.TabIndex = 14;
            this.txtDigitoVerificador.Text = "0";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(16, 299);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(122, 17);
            this.Label9.TabIndex = 120;
            this.Label9.Text = "Registro Patronal:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(84, 267);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(51, 17);
            this.Label8.TabIndex = 115;
            this.Label8.Text = "R.F.C.:";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(337, 299);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(120, 17);
            this.Label11.TabIndex = 124;
            this.Label11.Text = "Digito Verificador:";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(8, 18);
            this.Label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(99, 24);
            this.Label14.TabIndex = 161;
            this.Label14.Text = "Dirección";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMunicipio.Location = new System.Drawing.Point(173, 185);
            this.txtMunicipio.Margin = new System.Windows.Forms.Padding(4);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(172, 22);
            this.txtMunicipio.TabIndex = 8;
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Location = new System.Drawing.Point(173, 217);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(172, 22);
            this.txtEstado.TabIndex = 9;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(393, 188);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(38, 17);
            this.Label10.TabIndex = 158;
            this.Label10.Text = "C.P.:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(120, 64);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(43, 17);
            this.Label2.TabIndex = 147;
            this.Label2.Text = "Calle:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(77, 95);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(86, 17);
            this.Label4.TabIndex = 149;
            this.Label4.Text = "No. Exterior:";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(437, 185);
            this.txtCP.Margin = new System.Windows.Forms.Padding(4);
            this.txtCP.Mask = "00000";
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(64, 22);
            this.txtCP.TabIndex = 11;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(81, 126);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(82, 17);
            this.Label3.TabIndex = 148;
            this.Label3.Text = "No. Interior:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(104, 156);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(59, 17);
            this.Label5.TabIndex = 150;
            this.Label5.Text = "Colonia:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(5, 188);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(156, 17);
            this.Label6.TabIndex = 151;
            this.Label6.Text = "Municipio o delegación:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(107, 220);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(56, 17);
            this.Label7.TabIndex = 152;
            this.Label7.Text = "Estado:";
            // 
            // txtColonia
            // 
            this.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColonia.Location = new System.Drawing.Point(173, 153);
            this.txtColonia.Margin = new System.Windows.Forms.Padding(4);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(567, 22);
            this.txtColonia.TabIndex = 7;
            // 
            // txtInterior
            // 
            this.txtInterior.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInterior.Location = new System.Drawing.Point(173, 122);
            this.txtInterior.Margin = new System.Windows.Forms.Padding(4);
            this.txtInterior.Name = "txtInterior";
            this.txtInterior.Size = new System.Drawing.Size(88, 22);
            this.txtInterior.TabIndex = 6;
            // 
            // txtCalle
            // 
            this.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCalle.Location = new System.Drawing.Point(173, 60);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(567, 22);
            this.txtCalle.TabIndex = 4;
            // 
            // txtExterior
            // 
            this.txtExterior.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExterior.Location = new System.Drawing.Point(173, 91);
            this.txtExterior.Margin = new System.Windows.Forms.Padding(4);
            this.txtExterior.Name = "txtExterior";
            this.txtExterior.Size = new System.Drawing.Size(88, 22);
            this.txtExterior.TabIndex = 5;
            // 
            // txtPais
            // 
            this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPais.Location = new System.Drawing.Point(173, 249);
            this.txtPais.Margin = new System.Windows.Forms.Padding(4);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(172, 22);
            this.txtPais.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(124, 252);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 17);
            this.label13.TabIndex = 163;
            this.label13.Text = "Pais:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(92, 331);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 17);
            this.label17.TabIndex = 164;
            this.label17.Text = "Logo:";
            // 
            // btnVer
            // 
            this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(151, 325);
            this.btnVer.Margin = new System.Windows.Forms.Padding(4);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(89, 43);
            this.btnVer.TabIndex = 15;
            this.btnVer.Text = "Ver";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignar.Image")));
            this.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignar.Location = new System.Drawing.Point(248, 325);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(89, 43);
            this.btnAsignar.TabIndex = 16;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 15);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 24);
            this.label18.TabIndex = 169;
            this.label18.Text = "Timbrado";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(47, 52);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 17);
            this.label19.TabIndex = 170;
            this.label19.Text = "Certificado:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(76, 164);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 17);
            this.label20.TabIndex = 171;
            this.label20.Text = "Llave:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(52, 308);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 17);
            this.label21.TabIndex = 172;
            this.label21.Text = "Password:";
            // 
            // txtCertificado
            // 
            this.txtCertificado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCertificado.Location = new System.Drawing.Point(135, 48);
            this.txtCertificado.Margin = new System.Windows.Forms.Padding(4);
            this.txtCertificado.Multiline = true;
            this.txtCertificado.Name = "txtCertificado";
            this.txtCertificado.Size = new System.Drawing.Size(505, 104);
            this.txtCertificado.TabIndex = 17;
            // 
            // txtLlave
            // 
            this.txtLlave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLlave.Location = new System.Drawing.Point(135, 160);
            this.txtLlave.Margin = new System.Windows.Forms.Padding(4);
            this.txtLlave.Multiline = true;
            this.txtLlave.Name = "txtLlave";
            this.txtLlave.Size = new System.Drawing.Size(505, 104);
            this.txtLlave.TabIndex = 18;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(135, 304);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(505, 22);
            this.txtPassword.TabIndex = 20;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(21, 276);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(105, 17);
            this.label23.TabIndex = 180;
            this.label23.Text = "No. Certificado:";
            // 
            // txtNoCertificado
            // 
            this.txtNoCertificado.Location = new System.Drawing.Point(136, 272);
            this.txtNoCertificado.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoCertificado.Name = "txtNoCertificado";
            this.txtNoCertificado.Size = new System.Drawing.Size(504, 22);
            this.txtNoCertificado.TabIndex = 19;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(59, 343);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(66, 17);
            this.label24.TabIndex = 182;
            this.label24.Text = "Vigencia:";
            // 
            // dtpVigencia
            // 
            this.dtpVigencia.Location = new System.Drawing.Point(135, 338);
            this.dtpVigencia.Margin = new System.Windows.Forms.Padding(4);
            this.dtpVigencia.Name = "dtpVigencia";
            this.dtpVigencia.Size = new System.Drawing.Size(283, 22);
            this.dtpVigencia.TabIndex = 21;
            // 
            // cmbPago
            // 
            this.cmbPago.FormattingEnabled = true;
            this.cmbPago.Items.AddRange(new object[] {
            "SEMANAL",
            "QUINCENAL"});
            this.cmbPago.Location = new System.Drawing.Point(129, 60);
            this.cmbPago.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPago.Name = "cmbPago";
            this.cmbPago.Size = new System.Drawing.Size(132, 24);
            this.cmbPago.TabIndex = 183;
            this.cmbPago.SelectedIndexChanged += new System.EventHandler(this.cmbPago_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(8, 20);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(166, 24);
            this.label25.TabIndex = 187;
            this.label25.Text = "Periodo de pago";
            // 
            // txtDias
            // 
            this.txtDias.Enabled = false;
            this.txtDias.Location = new System.Drawing.Point(129, 94);
            this.txtDias.Margin = new System.Windows.Forms.Padding(4);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(53, 22);
            this.txtDias.TabIndex = 184;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(7, 97);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(115, 17);
            this.label26.TabIndex = 186;
            this.label26.Text = "Dias del periodo:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(75, 65);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(45, 17);
            this.label27.TabIndex = 185;
            this.label27.Text = "Pago:";
            // 
            // tabEmpresas
            // 
            this.tabEmpresas.Controls.Add(this.tabEmpresa);
            this.tabEmpresas.Controls.Add(this.tabDomicilio);
            this.tabEmpresas.Controls.Add(this.tabPeriodo);
            this.tabEmpresas.Controls.Add(this.tabTimbrado);
            this.tabEmpresas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEmpresas.Location = new System.Drawing.Point(0, 27);
            this.tabEmpresas.Margin = new System.Windows.Forms.Padding(4);
            this.tabEmpresas.Name = "tabEmpresas";
            this.tabEmpresas.SelectedIndex = 0;
            this.tabEmpresas.Size = new System.Drawing.Size(741, 431);
            this.tabEmpresas.TabIndex = 188;
            // 
            // tabEmpresa
            // 
            this.tabEmpresa.Controls.Add(this.cmbRegimenFiscal);
            this.tabEmpresa.Controls.Add(this.chkObraCivil);
            this.tabEmpresa.Controls.Add(this.txtObservacion);
            this.tabEmpresa.Controls.Add(this.label28);
            this.tabEmpresa.Controls.Add(this.Label15);
            this.tabEmpresa.Controls.Add(this.Label12);
            this.tabEmpresa.Controls.Add(this.label22);
            this.tabEmpresa.Controls.Add(this.txtRepresentante);
            this.tabEmpresa.Controls.Add(this.Label16);
            this.tabEmpresa.Controls.Add(this.txtNombre);
            this.tabEmpresa.Controls.Add(this.Label1);
            this.tabEmpresa.Controls.Add(this.btnAsignar);
            this.tabEmpresa.Controls.Add(this.Label8);
            this.tabEmpresa.Controls.Add(this.Label9);
            this.tabEmpresa.Controls.Add(this.Label11);
            this.tabEmpresa.Controls.Add(this.txtDigitoVerificador);
            this.tabEmpresa.Controls.Add(this.txtRegistroPatronal);
            this.tabEmpresa.Controls.Add(this.txtRfc);
            this.tabEmpresa.Controls.Add(this.label17);
            this.tabEmpresa.Controls.Add(this.btnVer);
            this.tabEmpresa.Location = new System.Drawing.Point(4, 25);
            this.tabEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.tabEmpresa.Name = "tabEmpresa";
            this.tabEmpresa.Padding = new System.Windows.Forms.Padding(4);
            this.tabEmpresa.Size = new System.Drawing.Size(733, 402);
            this.tabEmpresa.TabIndex = 0;
            this.tabEmpresa.Text = "Empresa";
            this.tabEmpresa.UseVisualStyleBackColor = true;
            // 
            // cmbRegimenFiscal
            // 
            this.cmbRegimenFiscal.FormattingEnabled = true;
            this.cmbRegimenFiscal.Location = new System.Drawing.Point(151, 133);
            this.cmbRegimenFiscal.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRegimenFiscal.Name = "cmbRegimenFiscal";
            this.cmbRegimenFiscal.Size = new System.Drawing.Size(565, 24);
            this.cmbRegimenFiscal.TabIndex = 193;
            // 
            // chkObraCivil
            // 
            this.chkObraCivil.AutoSize = true;
            this.chkObraCivil.Location = new System.Drawing.Point(151, 197);
            this.chkObraCivil.Margin = new System.Windows.Forms.Padding(4);
            this.chkObraCivil.Name = "chkObraCivil";
            this.chkObraCivil.Size = new System.Drawing.Size(91, 21);
            this.chkObraCivil.TabIndex = 192;
            this.chkObraCivil.Text = "Obra Civil";
            this.chkObraCivil.UseVisualStyleBackColor = true;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(151, 165);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(565, 22);
            this.txtObservacion.TabIndex = 191;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(49, 169);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(92, 17);
            this.label28.TabIndex = 190;
            this.label28.Text = "Observación:";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(4, 213);
            this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(97, 24);
            this.Label15.TabIndex = 189;
            this.Label15.Text = "Registros";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(8, 25);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(172, 24);
            this.Label12.TabIndex = 180;
            this.Label12.Text = "Nombre empresa";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(73, 137);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 17);
            this.label22.TabIndex = 179;
            this.label22.Text = "Regimen:";
            // 
            // txtRepresentante
            // 
            this.txtRepresentante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRepresentante.Location = new System.Drawing.Point(151, 101);
            this.txtRepresentante.Margin = new System.Windows.Forms.Padding(4);
            this.txtRepresentante.Name = "txtRepresentante";
            this.txtRepresentante.Size = new System.Drawing.Size(565, 22);
            this.txtRepresentante.TabIndex = 175;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(40, 105);
            this.Label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(106, 17);
            this.Label16.TabIndex = 178;
            this.Label16.Text = "Representante:";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(151, 69);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(567, 22);
            this.txtNombre.TabIndex = 174;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(23, 73);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(123, 17);
            this.Label1.TabIndex = 177;
            this.Label1.Text = "Nombre completo:";
            // 
            // tabDomicilio
            // 
            this.tabDomicilio.Controls.Add(this.Label14);
            this.tabDomicilio.Controls.Add(this.txtExterior);
            this.tabDomicilio.Controls.Add(this.txtCalle);
            this.tabDomicilio.Controls.Add(this.txtInterior);
            this.tabDomicilio.Controls.Add(this.txtColonia);
            this.tabDomicilio.Controls.Add(this.Label7);
            this.tabDomicilio.Controls.Add(this.Label6);
            this.tabDomicilio.Controls.Add(this.Label5);
            this.tabDomicilio.Controls.Add(this.Label3);
            this.tabDomicilio.Controls.Add(this.txtCP);
            this.tabDomicilio.Controls.Add(this.Label4);
            this.tabDomicilio.Controls.Add(this.Label2);
            this.tabDomicilio.Controls.Add(this.Label10);
            this.tabDomicilio.Controls.Add(this.txtEstado);
            this.tabDomicilio.Controls.Add(this.txtMunicipio);
            this.tabDomicilio.Controls.Add(this.txtPais);
            this.tabDomicilio.Controls.Add(this.label13);
            this.tabDomicilio.Location = new System.Drawing.Point(4, 25);
            this.tabDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.tabDomicilio.Name = "tabDomicilio";
            this.tabDomicilio.Padding = new System.Windows.Forms.Padding(4);
            this.tabDomicilio.Size = new System.Drawing.Size(816, 402);
            this.tabDomicilio.TabIndex = 1;
            this.tabDomicilio.Text = "Domicilio";
            this.tabDomicilio.UseVisualStyleBackColor = true;
            // 
            // tabPeriodo
            // 
            this.tabPeriodo.Controls.Add(this.cmbPago);
            this.tabPeriodo.Controls.Add(this.label27);
            this.tabPeriodo.Controls.Add(this.label25);
            this.tabPeriodo.Controls.Add(this.label26);
            this.tabPeriodo.Controls.Add(this.txtDias);
            this.tabPeriodo.Location = new System.Drawing.Point(4, 25);
            this.tabPeriodo.Margin = new System.Windows.Forms.Padding(4);
            this.tabPeriodo.Name = "tabPeriodo";
            this.tabPeriodo.Padding = new System.Windows.Forms.Padding(4);
            this.tabPeriodo.Size = new System.Drawing.Size(816, 402);
            this.tabPeriodo.TabIndex = 2;
            this.tabPeriodo.Text = "Periodo";
            this.tabPeriodo.UseVisualStyleBackColor = true;
            // 
            // tabTimbrado
            // 
            this.tabTimbrado.Controls.Add(this.label18);
            this.tabTimbrado.Controls.Add(this.label19);
            this.tabTimbrado.Controls.Add(this.label20);
            this.tabTimbrado.Controls.Add(this.dtpVigencia);
            this.tabTimbrado.Controls.Add(this.label21);
            this.tabTimbrado.Controls.Add(this.label24);
            this.tabTimbrado.Controls.Add(this.txtCertificado);
            this.tabTimbrado.Controls.Add(this.txtNoCertificado);
            this.tabTimbrado.Controls.Add(this.txtLlave);
            this.tabTimbrado.Controls.Add(this.label23);
            this.tabTimbrado.Controls.Add(this.txtPassword);
            this.tabTimbrado.Location = new System.Drawing.Point(4, 25);
            this.tabTimbrado.Margin = new System.Windows.Forms.Padding(4);
            this.tabTimbrado.Name = "tabTimbrado";
            this.tabTimbrado.Padding = new System.Windows.Forms.Padding(4);
            this.tabTimbrado.Size = new System.Drawing.Size(816, 402);
            this.tabTimbrado.TabIndex = 3;
            this.tabTimbrado.Text = "Timbrado";
            this.tabTimbrado.UseVisualStyleBackColor = true;
            // 
            // frmEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 458);
            this.Controls.Add(this.tabEmpresas);
            this.Controls.Add(this.toolEmpresa);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(759, 505);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(759, 505);
            this.Name = "frmEmpresas";
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.frmEmpresas_Load);
            this.toolEmpresa.ResumeLayout(false);
            this.toolEmpresa.PerformLayout();
            this.tabEmpresas.ResumeLayout(false);
            this.tabEmpresa.ResumeLayout(false);
            this.tabEmpresa.PerformLayout();
            this.tabDomicilio.ResumeLayout(false);
            this.tabDomicilio.PerformLayout();
            this.tabPeriodo.ResumeLayout(false);
            this.tabPeriodo.PerformLayout();
            this.tabTimbrado.ResumeLayout(false);
            this.tabTimbrado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolEmpresa;
        internal System.Windows.Forms.TextBox txtRfc;
        internal System.Windows.Forms.MaskedTextBox txtRegistroPatronal;
        internal System.Windows.Forms.TextBox txtDigitoVerificador;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label14;
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
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnAsignar;
        internal System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtCertificado;
        private System.Windows.Forms.TextBox txtLlave;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtNoCertificado;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dtpVigencia;
        private System.Windows.Forms.ToolStripButton toolGuardarNuevo;
        private System.Windows.Forms.ToolStripButton toolCerrar;
        private System.Windows.Forms.ComboBox cmbPago;
        internal System.Windows.Forms.Label label25;
        internal System.Windows.Forms.TextBox txtDias;
        internal System.Windows.Forms.Label label26;
        internal System.Windows.Forms.Label label27;
        private System.Windows.Forms.TabControl tabEmpresas;
        private System.Windows.Forms.TabPage tabEmpresa;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label12;
        private System.Windows.Forms.Label label22;
        internal System.Windows.Forms.TextBox txtRepresentante;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TabPage tabDomicilio;
        private System.Windows.Forms.TabPage tabPeriodo;
        private System.Windows.Forms.TabPage tabTimbrado;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.CheckBox chkObraCivil;
        private System.Windows.Forms.ComboBox cmbRegimenFiscal;
    }
}