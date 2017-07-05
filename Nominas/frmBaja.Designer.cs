namespace Nominas
{
    partial class frmBaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaja));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaBaja = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMotivoBaja = new System.Windows.Forms.ComboBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de baja IMSS:";
            // 
            // dtpFechaBaja
            // 
            this.dtpFechaBaja.Location = new System.Drawing.Point(167, 75);
            this.dtpFechaBaja.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaBaja.Name = "dtpFechaBaja";
            this.dtpFechaBaja.Size = new System.Drawing.Size(298, 22);
            this.dtpFechaBaja.TabIndex = 2;
            this.dtpFechaBaja.Leave += new System.EventHandler(this.dtpFechaBaja_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Motivo de baja:";
            // 
            // cmbMotivoBaja
            // 
            this.cmbMotivoBaja.FormattingEnabled = true;
            this.cmbMotivoBaja.Location = new System.Drawing.Point(167, 42);
            this.cmbMotivoBaja.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMotivoBaja.Name = "cmbMotivoBaja";
            this.cmbMotivoBaja.Size = new System.Drawing.Size(298, 24);
            this.cmbMotivoBaja.TabIndex = 1;
            // 
            // Cancelar
            // 
            this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
            this.Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelar.Location = new System.Drawing.Point(365, 291);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(100, 39);
            this.Cancelar.TabIndex = 5;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(262, 290);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(95, 39);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 343);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Periodo:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.Location = new System.Drawing.Point(167, 107);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(298, 175);
            this.txtObservaciones.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(167, 11);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(298, 22);
            this.txtNombre.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nombre:";
            // 
            // frmBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 343);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.cmbMotivoBaja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaBaja);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(499, 390);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(499, 390);
            this.Name = "frmBaja";
            this.Text = "Baja del trabajador";
            this.Load += new System.EventHandler(this.frmBaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaBaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMotivoBaja;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
    }
}