﻿namespace Nominas
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
            this.btnDirectorio = new System.Windows.Forms.Button();
            this.txtCorreoEmisor = new System.Windows.Forms.TextBox();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.txtServidorEnvio = new System.Windows.Forms.TextBox();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSsl = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPreferencias = new System.Windows.Forms.TabControl();
            this.tabCorreoElectronico.SuspendLayout();
            this.tabPreferencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCorreoElectronico
            // 
            this.tabCorreoElectronico.BackColor = System.Drawing.SystemColors.Control;
            this.tabCorreoElectronico.Controls.Add(this.btnCancelar);
            this.tabCorreoElectronico.Controls.Add(this.btnAceptar);
            this.tabCorreoElectronico.Controls.Add(this.btnDirectorio);
            this.tabCorreoElectronico.Controls.Add(this.txtCorreoEmisor);
            this.tabCorreoElectronico.Controls.Add(this.txtRuta);
            this.tabCorreoElectronico.Controls.Add(this.txtServidorEnvio);
            this.tabCorreoElectronico.Controls.Add(this.txtPuerto);
            this.tabCorreoElectronico.Controls.Add(this.txtPassword);
            this.tabCorreoElectronico.Controls.Add(this.label5);
            this.tabCorreoElectronico.Controls.Add(this.label4);
            this.tabCorreoElectronico.Controls.Add(this.chkSsl);
            this.tabCorreoElectronico.Controls.Add(this.label3);
            this.tabCorreoElectronico.Controls.Add(this.label2);
            this.tabCorreoElectronico.Controls.Add(this.label1);
            this.tabCorreoElectronico.Location = new System.Drawing.Point(4, 25);
            this.tabCorreoElectronico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCorreoElectronico.Name = "tabCorreoElectronico";
            this.tabCorreoElectronico.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCorreoElectronico.Size = new System.Drawing.Size(605, 345);
            this.tabCorreoElectronico.TabIndex = 0;
            this.tabCorreoElectronico.Text = "Correo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(488, 300);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
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
            this.btnAceptar.Location = new System.Drawing.Point(380, 300);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnDirectorio
            // 
            this.btnDirectorio.Location = new System.Drawing.Point(548, 256);
            this.btnDirectorio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDirectorio.Name = "btnDirectorio";
            this.btnDirectorio.Size = new System.Drawing.Size(40, 25);
            this.btnDirectorio.TabIndex = 11;
            this.btnDirectorio.Text = "...";
            this.btnDirectorio.UseVisualStyleBackColor = true;
            this.btnDirectorio.Click += new System.EventHandler(this.btnDirectorio_Click);
            // 
            // txtCorreoEmisor
            // 
            this.txtCorreoEmisor.Location = new System.Drawing.Point(167, 34);
            this.txtCorreoEmisor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreoEmisor.Name = "txtCorreoEmisor";
            this.txtCorreoEmisor.Size = new System.Drawing.Size(372, 22);
            this.txtCorreoEmisor.TabIndex = 6;
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(167, 256);
            this.txtRuta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(372, 22);
            this.txtRuta.TabIndex = 10;
            // 
            // txtServidorEnvio
            // 
            this.txtServidorEnvio.Location = new System.Drawing.Point(167, 201);
            this.txtServidorEnvio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServidorEnvio.Name = "txtServidorEnvio";
            this.txtServidorEnvio.Size = new System.Drawing.Size(159, 22);
            this.txtServidorEnvio.TabIndex = 9;
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(167, 145);
            this.txtPuerto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(159, 22);
            this.txtPuerto.TabIndex = 8;
            this.txtPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(167, 90);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(159, 22);
            this.txtPassword.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 260);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ruta de recibos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Servidor de envío:";
            // 
            // chkSsl
            // 
            this.chkSsl.AutoSize = true;
            this.chkSsl.Location = new System.Drawing.Point(339, 148);
            this.chkSsl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSsl.Name = "chkSsl";
            this.chkSsl.Size = new System.Drawing.Size(49, 21);
            this.chkSsl.TabIndex = 3;
            this.chkSsl.Text = "Ssl";
            this.chkSsl.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Puerto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo emisor:";
            // 
            // tabPreferencias
            // 
            this.tabPreferencias.Controls.Add(this.tabCorreoElectronico);
            this.tabPreferencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPreferencias.Location = new System.Drawing.Point(0, 0);
            this.tabPreferencias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPreferencias.Name = "tabPreferencias";
            this.tabPreferencias.SelectedIndex = 0;
            this.tabPreferencias.Size = new System.Drawing.Size(613, 374);
            this.tabPreferencias.TabIndex = 0;
            // 
            // frmPreferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 374);
            this.Controls.Add(this.tabPreferencias);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(631, 421);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(631, 421);
            this.Name = "frmPreferencias";
            this.Text = "Preferencias del sistema";
            this.Load += new System.EventHandler(this.frmPreferencias_Load);
            this.tabCorreoElectronico.ResumeLayout(false);
            this.tabCorreoElectronico.PerformLayout();
            this.tabPreferencias.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabCorreoElectronico;
        private System.Windows.Forms.TabControl tabPreferencias;
        private System.Windows.Forms.Button btnDirectorio;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.TextBox txtServidorEnvio;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCorreoEmisor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkSsl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}