namespace Nominas
{
    partial class frmExpediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExpediente));
            this.toolAcciones = new System.Windows.Forms.ToolStrip();
            this.toolGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolCerrar = new System.Windows.Forms.ToolStripButton();
            this.chkAutorizacion = new System.Windows.Forms.CheckBox();
            this.chkFotografias = new System.Windows.Forms.CheckBox();
            this.chkAfore = new System.Windows.Forms.CheckBox();
            this.chkInfonavit = new System.Windows.Forms.CheckBox();
            this.chkRfc = new System.Windows.Forms.CheckBox();
            this.chkNss = new System.Windows.Forms.CheckBox();
            this.chkCDomicilio = new System.Windows.Forms.CheckBox();
            this.chkCurp = new System.Windows.Forms.CheckBox();
            this.chkIFE = new System.Windows.Forms.CheckBox();
            this.chkActa = new System.Windows.Forms.CheckBox();
            this.chkCredencial = new System.Windows.Forms.CheckBox();
            this.chkImss = new System.Windows.Forms.CheckBox();
            this.chkSolicitud = new System.Windows.Forms.CheckBox();
            this.chkContrato = new System.Windows.Forms.CheckBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.toolAcciones.Size = new System.Drawing.Size(464, 27);
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
            // toolBuscar
            // 
            this.toolBuscar.Image = ((System.Drawing.Image)(resources.GetObject("toolBuscar.Image")));
            this.toolBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBuscar.Name = "toolBuscar";
            this.toolBuscar.Size = new System.Drawing.Size(76, 24);
            this.toolBuscar.Text = "Buscar";
            this.toolBuscar.Click += new System.EventHandler(this.toolBuscar_Click);
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
            // chkAutorizacion
            // 
            this.chkAutorizacion.AutoSize = true;
            this.chkAutorizacion.Location = new System.Drawing.Point(251, 376);
            this.chkAutorizacion.Margin = new System.Windows.Forms.Padding(4);
            this.chkAutorizacion.Name = "chkAutorizacion";
            this.chkAutorizacion.Size = new System.Drawing.Size(188, 21);
            this.chkAutorizacion.TabIndex = 268;
            this.chkAutorizacion.Text = "Autorización permanente";
            this.chkAutorizacion.UseVisualStyleBackColor = true;
            // 
            // chkFotografias
            // 
            this.chkFotografias.AutoSize = true;
            this.chkFotografias.Location = new System.Drawing.Point(251, 328);
            this.chkFotografias.Margin = new System.Windows.Forms.Padding(4);
            this.chkFotografias.Name = "chkFotografias";
            this.chkFotografias.Size = new System.Drawing.Size(101, 21);
            this.chkFotografias.TabIndex = 267;
            this.chkFotografias.Text = "Fotografias";
            this.chkFotografias.UseVisualStyleBackColor = true;
            // 
            // chkAfore
            // 
            this.chkAfore.AutoSize = true;
            this.chkAfore.Location = new System.Drawing.Point(251, 280);
            this.chkAfore.Margin = new System.Windows.Forms.Padding(4);
            this.chkAfore.Name = "chkAfore";
            this.chkAfore.Size = new System.Drawing.Size(64, 21);
            this.chkAfore.TabIndex = 266;
            this.chkAfore.Text = "Afore";
            this.chkAfore.UseVisualStyleBackColor = true;
            // 
            // chkInfonavit
            // 
            this.chkInfonavit.AutoSize = true;
            this.chkInfonavit.Location = new System.Drawing.Point(251, 232);
            this.chkInfonavit.Margin = new System.Windows.Forms.Padding(4);
            this.chkInfonavit.Name = "chkInfonavit";
            this.chkInfonavit.Size = new System.Drawing.Size(83, 21);
            this.chkInfonavit.TabIndex = 265;
            this.chkInfonavit.Text = "Infonavit";
            this.chkInfonavit.UseVisualStyleBackColor = true;
            // 
            // chkRfc
            // 
            this.chkRfc.AutoSize = true;
            this.chkRfc.Location = new System.Drawing.Point(251, 184);
            this.chkRfc.Margin = new System.Windows.Forms.Padding(4);
            this.chkRfc.Name = "chkRfc";
            this.chkRfc.Size = new System.Drawing.Size(57, 21);
            this.chkRfc.TabIndex = 264;
            this.chkRfc.Text = "RFC";
            this.chkRfc.UseVisualStyleBackColor = true;
            // 
            // chkNss
            // 
            this.chkNss.AutoSize = true;
            this.chkNss.Location = new System.Drawing.Point(251, 136);
            this.chkNss.Margin = new System.Windows.Forms.Padding(4);
            this.chkNss.Name = "chkNss";
            this.chkNss.Size = new System.Drawing.Size(70, 21);
            this.chkNss.TabIndex = 263;
            this.chkNss.Text = "N.S.S.";
            this.chkNss.UseVisualStyleBackColor = true;
            // 
            // chkCDomicilio
            // 
            this.chkCDomicilio.AutoSize = true;
            this.chkCDomicilio.Location = new System.Drawing.Point(251, 88);
            this.chkCDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.chkCDomicilio.Name = "chkCDomicilio";
            this.chkCDomicilio.Size = new System.Drawing.Size(193, 21);
            this.chkCDomicilio.TabIndex = 262;
            this.chkCDomicilio.Text = "Comprobante de domicilio";
            this.chkCDomicilio.UseVisualStyleBackColor = true;
            // 
            // chkCurp
            // 
            this.chkCurp.AutoSize = true;
            this.chkCurp.Location = new System.Drawing.Point(30, 376);
            this.chkCurp.Margin = new System.Windows.Forms.Padding(4);
            this.chkCurp.Name = "chkCurp";
            this.chkCurp.Size = new System.Drawing.Size(68, 21);
            this.chkCurp.TabIndex = 261;
            this.chkCurp.Text = "CURP";
            this.chkCurp.UseVisualStyleBackColor = true;
            // 
            // chkIFE
            // 
            this.chkIFE.AutoSize = true;
            this.chkIFE.Location = new System.Drawing.Point(30, 328);
            this.chkIFE.Margin = new System.Windows.Forms.Padding(4);
            this.chkIFE.Name = "chkIFE";
            this.chkIFE.Size = new System.Drawing.Size(164, 21);
            this.chkIFE.TabIndex = 260;
            this.chkIFE.Text = "Credencial de elector";
            this.chkIFE.UseVisualStyleBackColor = true;
            // 
            // chkActa
            // 
            this.chkActa.AutoSize = true;
            this.chkActa.Location = new System.Drawing.Point(30, 280);
            this.chkActa.Margin = new System.Windows.Forms.Padding(4);
            this.chkActa.Name = "chkActa";
            this.chkActa.Size = new System.Drawing.Size(150, 21);
            this.chkActa.TabIndex = 259;
            this.chkActa.Text = "Acta de nacimiento";
            this.chkActa.UseVisualStyleBackColor = true;
            // 
            // chkCredencial
            // 
            this.chkCredencial.AutoSize = true;
            this.chkCredencial.Location = new System.Drawing.Point(30, 232);
            this.chkCredencial.Margin = new System.Windows.Forms.Padding(4);
            this.chkCredencial.Name = "chkCredencial";
            this.chkCredencial.Size = new System.Drawing.Size(145, 21);
            this.chkCredencial.TabIndex = 258;
            this.chkCredencial.Text = "Credencial interna";
            this.chkCredencial.UseVisualStyleBackColor = true;
            // 
            // chkImss
            // 
            this.chkImss.AutoSize = true;
            this.chkImss.Location = new System.Drawing.Point(30, 184);
            this.chkImss.Margin = new System.Windows.Forms.Padding(4);
            this.chkImss.Name = "chkImss";
            this.chkImss.Size = new System.Drawing.Size(113, 21);
            this.chkImss.TabIndex = 257;
            this.chkImss.Text = "Alta del IMSS";
            this.chkImss.UseVisualStyleBackColor = true;
            // 
            // chkSolicitud
            // 
            this.chkSolicitud.AutoSize = true;
            this.chkSolicitud.Location = new System.Drawing.Point(30, 136);
            this.chkSolicitud.Margin = new System.Windows.Forms.Padding(4);
            this.chkSolicitud.Name = "chkSolicitud";
            this.chkSolicitud.Size = new System.Drawing.Size(83, 21);
            this.chkSolicitud.TabIndex = 256;
            this.chkSolicitud.Text = "Solicitud";
            this.chkSolicitud.UseVisualStyleBackColor = true;
            // 
            // chkContrato
            // 
            this.chkContrato.AutoSize = true;
            this.chkContrato.Location = new System.Drawing.Point(30, 88);
            this.chkContrato.Margin = new System.Windows.Forms.Padding(4);
            this.chkContrato.Name = "chkContrato";
            this.chkContrato.Size = new System.Drawing.Size(84, 21);
            this.chkContrato.TabIndex = 255;
            this.chkContrato.Text = "Contrato";
            this.chkContrato.UseVisualStyleBackColor = true;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(30, 449);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(416, 170);
            this.txtObservaciones.TabIndex = 270;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(26, 419);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(103, 17);
            this.Label3.TabIndex = 269;
            this.Label3.Text = "Observaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 271;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(95, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(351, 22);
            this.txtNombre.TabIndex = 272;
            // 
            // frmExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 632);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.chkAutorizacion);
            this.Controls.Add(this.chkFotografias);
            this.Controls.Add(this.chkAfore);
            this.Controls.Add(this.chkInfonavit);
            this.Controls.Add(this.chkRfc);
            this.Controls.Add(this.chkNss);
            this.Controls.Add(this.chkCDomicilio);
            this.Controls.Add(this.chkCurp);
            this.Controls.Add(this.chkIFE);
            this.Controls.Add(this.chkActa);
            this.Controls.Add(this.chkCredencial);
            this.Controls.Add(this.chkImss);
            this.Controls.Add(this.chkSolicitud);
            this.Controls.Add(this.chkContrato);
            this.Controls.Add(this.toolAcciones);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(482, 679);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(482, 679);
            this.Name = "frmExpediente";
            this.Text = "Expediente del trabajador";
            this.Load += new System.EventHandler(this.frmExpediente_Load);
            this.toolAcciones.ResumeLayout(false);
            this.toolAcciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolAcciones;
        internal System.Windows.Forms.ToolStripButton toolGuardar;
        private System.Windows.Forms.ToolStripButton toolCerrar;
        internal System.Windows.Forms.CheckBox chkAutorizacion;
        internal System.Windows.Forms.CheckBox chkFotografias;
        internal System.Windows.Forms.CheckBox chkAfore;
        internal System.Windows.Forms.CheckBox chkInfonavit;
        internal System.Windows.Forms.CheckBox chkRfc;
        internal System.Windows.Forms.CheckBox chkNss;
        internal System.Windows.Forms.CheckBox chkCDomicilio;
        internal System.Windows.Forms.CheckBox chkCurp;
        internal System.Windows.Forms.CheckBox chkIFE;
        internal System.Windows.Forms.CheckBox chkActa;
        internal System.Windows.Forms.CheckBox chkCredencial;
        internal System.Windows.Forms.CheckBox chkImss;
        internal System.Windows.Forms.CheckBox chkSolicitud;
        internal System.Windows.Forms.CheckBox chkContrato;
        internal System.Windows.Forms.TextBox txtObservaciones;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.ToolStripButton toolBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
    }
}