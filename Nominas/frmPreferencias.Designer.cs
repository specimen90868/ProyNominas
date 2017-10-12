namespace Nominas
{
    partial class frmPreferencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreferencias));
            this.tabCorreoElectronico = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCorreoEmisor = new System.Windows.Forms.TextBox();
            this.txtServidorEnvio = new System.Windows.Forms.TextBox();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSsl = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabConfiguracion = new System.Windows.Forms.TabControl();
            this.tabTimbrado = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDirectorioKeys = new System.Windows.Forms.Button();
            this.txtRutaKeys = new System.Windows.Forms.TextBox();
            this.btnDirectorioXslt = new System.Windows.Forms.Button();
            this.txtNombreArchivoXslt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRutaXslt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDirectorio = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabSalarioMinimoSeguro = new System.Windows.Forms.TabPage();
            this.txtVsmdf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDirectorioCancelados = new System.Windows.Forms.TextBox();
            this.txtDirectorioSsl = new System.Windows.Forms.TextBox();
            this.txtDirectorioPem = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRutaCancelados = new System.Windows.Forms.Button();
            this.btnRutaSSL = new System.Windows.Forms.Button();
            this.btnRutaPem = new System.Windows.Forms.Button();
            this.tabCorreoElectronico.SuspendLayout();
            this.tabConfiguracion.SuspendLayout();
            this.tabTimbrado.SuspendLayout();
            this.tabSalarioMinimoSeguro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCorreoElectronico
            // 
            this.tabCorreoElectronico.BackColor = System.Drawing.SystemColors.Control;
            this.tabCorreoElectronico.Controls.Add(this.txtCorreoEmisor);
            this.tabCorreoElectronico.Controls.Add(this.txtServidorEnvio);
            this.tabCorreoElectronico.Controls.Add(this.txtPuerto);
            this.tabCorreoElectronico.Controls.Add(this.txtPassword);
            this.tabCorreoElectronico.Controls.Add(this.label4);
            this.tabCorreoElectronico.Controls.Add(this.chkSsl);
            this.tabCorreoElectronico.Controls.Add(this.label3);
            this.tabCorreoElectronico.Controls.Add(this.label2);
            this.tabCorreoElectronico.Controls.Add(this.label1);
            this.tabCorreoElectronico.Location = new System.Drawing.Point(4, 22);
            this.tabCorreoElectronico.Name = "tabCorreoElectronico";
            this.tabCorreoElectronico.Padding = new System.Windows.Forms.Padding(3);
            this.tabCorreoElectronico.Size = new System.Drawing.Size(453, 146);
            this.tabCorreoElectronico.TabIndex = 0;
            this.tabCorreoElectronico.Text = "Servidor de correo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(382, 274);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 27);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(301, 274);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 27);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtCorreoEmisor
            // 
            this.txtCorreoEmisor.Location = new System.Drawing.Point(125, 28);
            this.txtCorreoEmisor.Name = "txtCorreoEmisor";
            this.txtCorreoEmisor.Size = new System.Drawing.Size(280, 20);
            this.txtCorreoEmisor.TabIndex = 6;
            // 
            // txtServidorEnvio
            // 
            this.txtServidorEnvio.Location = new System.Drawing.Point(125, 106);
            this.txtServidorEnvio.Name = "txtServidorEnvio";
            this.txtServidorEnvio.Size = new System.Drawing.Size(120, 20);
            this.txtServidorEnvio.TabIndex = 9;
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(125, 80);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(120, 20);
            this.txtPuerto.TabIndex = 8;
            this.txtPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(125, 54);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(120, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Servidor de envío:";
            // 
            // chkSsl
            // 
            this.chkSsl.AutoSize = true;
            this.chkSsl.Location = new System.Drawing.Point(251, 109);
            this.chkSsl.Name = "chkSsl";
            this.chkSsl.Size = new System.Drawing.Size(40, 17);
            this.chkSsl.TabIndex = 3;
            this.chkSsl.Text = "Ssl";
            this.chkSsl.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Puerto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo emisor:";
            // 
            // tabConfiguracion
            // 
            this.tabConfiguracion.Controls.Add(this.tabCorreoElectronico);
            this.tabConfiguracion.Controls.Add(this.tabTimbrado);
            this.tabConfiguracion.Controls.Add(this.tabSalarioMinimoSeguro);
            this.tabConfiguracion.Location = new System.Drawing.Point(0, 0);
            this.tabConfiguracion.Name = "tabConfiguracion";
            this.tabConfiguracion.SelectedIndex = 0;
            this.tabConfiguracion.Size = new System.Drawing.Size(461, 268);
            this.tabConfiguracion.TabIndex = 0;
            // 
            // tabTimbrado
            // 
            this.tabTimbrado.Controls.Add(this.btnRutaPem);
            this.tabTimbrado.Controls.Add(this.btnRutaSSL);
            this.tabTimbrado.Controls.Add(this.btnRutaCancelados);
            this.tabTimbrado.Controls.Add(this.label12);
            this.tabTimbrado.Controls.Add(this.label11);
            this.tabTimbrado.Controls.Add(this.label10);
            this.tabTimbrado.Controls.Add(this.txtDirectorioPem);
            this.tabTimbrado.Controls.Add(this.txtDirectorioSsl);
            this.tabTimbrado.Controls.Add(this.txtDirectorioCancelados);
            this.tabTimbrado.Controls.Add(this.label9);
            this.tabTimbrado.Controls.Add(this.btnDirectorioKeys);
            this.tabTimbrado.Controls.Add(this.txtRutaKeys);
            this.tabTimbrado.Controls.Add(this.btnDirectorioXslt);
            this.tabTimbrado.Controls.Add(this.txtNombreArchivoXslt);
            this.tabTimbrado.Controls.Add(this.label7);
            this.tabTimbrado.Controls.Add(this.txtRutaXslt);
            this.tabTimbrado.Controls.Add(this.label6);
            this.tabTimbrado.Controls.Add(this.btnDirectorio);
            this.tabTimbrado.Controls.Add(this.txtRuta);
            this.tabTimbrado.Controls.Add(this.label5);
            this.tabTimbrado.Location = new System.Drawing.Point(4, 22);
            this.tabTimbrado.Name = "tabTimbrado";
            this.tabTimbrado.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimbrado.Size = new System.Drawing.Size(453, 242);
            this.tabTimbrado.TabIndex = 1;
            this.tabTimbrado.Text = "Timbrado";
            this.tabTimbrado.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Ruta archivos key:";
            // 
            // btnDirectorioKeys
            // 
            this.btnDirectorioKeys.Location = new System.Drawing.Point(408, 65);
            this.btnDirectorioKeys.Name = "btnDirectorioKeys";
            this.btnDirectorioKeys.Size = new System.Drawing.Size(30, 20);
            this.btnDirectorioKeys.TabIndex = 33;
            this.btnDirectorioKeys.Text = "...";
            this.btnDirectorioKeys.UseVisualStyleBackColor = true;
            this.btnDirectorioKeys.Click += new System.EventHandler(this.btnDirectorioKeys_Click_1);
            // 
            // txtRutaKeys
            // 
            this.txtRutaKeys.Location = new System.Drawing.Point(122, 64);
            this.txtRutaKeys.Name = "txtRutaKeys";
            this.txtRutaKeys.Size = new System.Drawing.Size(280, 20);
            this.txtRutaKeys.TabIndex = 32;
            // 
            // btnDirectorioXslt
            // 
            this.btnDirectorioXslt.Location = new System.Drawing.Point(408, 92);
            this.btnDirectorioXslt.Name = "btnDirectorioXslt";
            this.btnDirectorioXslt.Size = new System.Drawing.Size(30, 20);
            this.btnDirectorioXslt.TabIndex = 31;
            this.btnDirectorioXslt.Text = "...";
            this.btnDirectorioXslt.UseVisualStyleBackColor = true;
            this.btnDirectorioXslt.Click += new System.EventHandler(this.btnDirectorioXslt_Click_1);
            // 
            // txtNombreArchivoXslt
            // 
            this.txtNombreArchivoXslt.Location = new System.Drawing.Point(122, 117);
            this.txtNombreArchivoXslt.Name = "txtNombreArchivoXslt";
            this.txtNombreArchivoXslt.Size = new System.Drawing.Size(120, 20);
            this.txtNombreArchivoXslt.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Nombre archivo xslt:";
            // 
            // txtRutaXslt
            // 
            this.txtRutaXslt.Location = new System.Drawing.Point(122, 91);
            this.txtRutaXslt.Name = "txtRutaXslt";
            this.txtRutaXslt.Size = new System.Drawing.Size(280, 20);
            this.txtRutaXslt.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ruta xslt:";
            // 
            // btnDirectorio
            // 
            this.btnDirectorio.Location = new System.Drawing.Point(408, 38);
            this.btnDirectorio.Name = "btnDirectorio";
            this.btnDirectorio.Size = new System.Drawing.Size(30, 20);
            this.btnDirectorio.TabIndex = 26;
            this.btnDirectorio.Text = "...";
            this.btnDirectorio.UseVisualStyleBackColor = true;
            this.btnDirectorio.Click += new System.EventHandler(this.btnDirectorio_Click_1);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(122, 38);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(280, 20);
            this.txtRuta.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ruta de recibos:";
            // 
            // tabSalarioMinimoSeguro
            // 
            this.tabSalarioMinimoSeguro.Controls.Add(this.txtVsmdf);
            this.tabSalarioMinimoSeguro.Controls.Add(this.label8);
            this.tabSalarioMinimoSeguro.Location = new System.Drawing.Point(4, 22);
            this.tabSalarioMinimoSeguro.Name = "tabSalarioMinimoSeguro";
            this.tabSalarioMinimoSeguro.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalarioMinimoSeguro.Size = new System.Drawing.Size(453, 163);
            this.tabSalarioMinimoSeguro.TabIndex = 2;
            this.tabSalarioMinimoSeguro.Text = "Seguro Social";
            this.tabSalarioMinimoSeguro.UseVisualStyleBackColor = true;
            // 
            // txtVsmdf
            // 
            this.txtVsmdf.Location = new System.Drawing.Point(71, 16);
            this.txtVsmdf.Name = "txtVsmdf";
            this.txtVsmdf.Size = new System.Drawing.Size(120, 20);
            this.txtVsmdf.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "VSMDF:";
            // 
            // txtDirectorioCancelados
            // 
            this.txtDirectorioCancelados.Location = new System.Drawing.Point(122, 144);
            this.txtDirectorioCancelados.Name = "txtDirectorioCancelados";
            this.txtDirectorioCancelados.Size = new System.Drawing.Size(280, 20);
            this.txtDirectorioCancelados.TabIndex = 35;
            // 
            // txtDirectorioSsl
            // 
            this.txtDirectorioSsl.Location = new System.Drawing.Point(122, 171);
            this.txtDirectorioSsl.Name = "txtDirectorioSsl";
            this.txtDirectorioSsl.Size = new System.Drawing.Size(280, 20);
            this.txtDirectorioSsl.TabIndex = 36;
            // 
            // txtDirectorioPem
            // 
            this.txtDirectorioPem.Location = new System.Drawing.Point(122, 198);
            this.txtDirectorioPem.Name = "txtDirectorioPem";
            this.txtDirectorioPem.Size = new System.Drawing.Size(280, 20);
            this.txtDirectorioPem.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Ruta de cancelados:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Ruta Open-SSL:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Ruta archivos pem:";
            // 
            // btnRutaCancelados
            // 
            this.btnRutaCancelados.Location = new System.Drawing.Point(408, 143);
            this.btnRutaCancelados.Name = "btnRutaCancelados";
            this.btnRutaCancelados.Size = new System.Drawing.Size(30, 20);
            this.btnRutaCancelados.TabIndex = 41;
            this.btnRutaCancelados.Text = "...";
            this.btnRutaCancelados.UseVisualStyleBackColor = true;
            this.btnRutaCancelados.Click += new System.EventHandler(this.btnRutaCancelados_Click);
            // 
            // btnRutaSSL
            // 
            this.btnRutaSSL.Location = new System.Drawing.Point(408, 172);
            this.btnRutaSSL.Name = "btnRutaSSL";
            this.btnRutaSSL.Size = new System.Drawing.Size(30, 20);
            this.btnRutaSSL.TabIndex = 42;
            this.btnRutaSSL.Text = "...";
            this.btnRutaSSL.UseVisualStyleBackColor = true;
            this.btnRutaSSL.Click += new System.EventHandler(this.btnRutaSSL_Click);
            // 
            // btnRutaPem
            // 
            this.btnRutaPem.Location = new System.Drawing.Point(408, 198);
            this.btnRutaPem.Name = "btnRutaPem";
            this.btnRutaPem.Size = new System.Drawing.Size(30, 20);
            this.btnRutaPem.TabIndex = 43;
            this.btnRutaPem.Text = "...";
            this.btnRutaPem.UseVisualStyleBackColor = true;
            this.btnRutaPem.Click += new System.EventHandler(this.btnRutaPem_Click);
            // 
            // frmPreferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 311);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tabConfiguracion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPreferencias";
            this.Text = "Preferencias del sistema";
            this.Load += new System.EventHandler(this.frmPreferencias_Load);
            this.tabCorreoElectronico.ResumeLayout(false);
            this.tabCorreoElectronico.PerformLayout();
            this.tabConfiguracion.ResumeLayout(false);
            this.tabTimbrado.ResumeLayout(false);
            this.tabTimbrado.PerformLayout();
            this.tabSalarioMinimoSeguro.ResumeLayout(false);
            this.tabSalarioMinimoSeguro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabCorreoElectronico;
        private System.Windows.Forms.TabControl tabConfiguracion;
        private System.Windows.Forms.TextBox txtServidorEnvio;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCorreoEmisor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkSsl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TabPage tabTimbrado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDirectorioKeys;
        private System.Windows.Forms.TextBox txtRutaKeys;
        private System.Windows.Forms.Button btnDirectorioXslt;
        private System.Windows.Forms.TextBox txtNombreArchivoXslt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRutaXslt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDirectorio;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabSalarioMinimoSeguro;
        private System.Windows.Forms.TextBox txtVsmdf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDirectorioPem;
        private System.Windows.Forms.TextBox txtDirectorioSsl;
        private System.Windows.Forms.TextBox txtDirectorioCancelados;
        private System.Windows.Forms.Button btnRutaPem;
        private System.Windows.Forms.Button btnRutaSSL;
        private System.Windows.Forms.Button btnRutaCancelados;
    }
}