namespace Nominas
{
    partial class frmDeptoPuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeptoPuesto));
            this.lblTextoCambios = new System.Windows.Forms.Label();
            this.cmbDeptoPuesto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaAplicacion = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.toolCancelar = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.mtxtNoEmpleado = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTextoCambios
            // 
            this.lblTextoCambios.AutoSize = true;
            this.lblTextoCambios.Location = new System.Drawing.Point(17, 90);
            this.lblTextoCambios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextoCambios.Name = "lblTextoCambios";
            this.lblTextoCambios.Size = new System.Drawing.Size(98, 17);
            this.lblTextoCambios.TabIndex = 0;
            this.lblTextoCambios.Text = "Depto/Puesto:";
            // 
            // cmbDeptoPuesto
            // 
            this.cmbDeptoPuesto.FormattingEnabled = true;
            this.cmbDeptoPuesto.Location = new System.Drawing.Point(167, 86);
            this.cmbDeptoPuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDeptoPuesto.Name = "cmbDeptoPuesto";
            this.cmbDeptoPuesto.Size = new System.Drawing.Size(308, 24);
            this.cmbDeptoPuesto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha de aplicación:";
            // 
            // dtpFechaAplicacion
            // 
            this.dtpFechaAplicacion.Location = new System.Drawing.Point(167, 117);
            this.dtpFechaAplicacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaAplicacion.Name = "dtpFechaAplicacion";
            this.dtpFechaAplicacion.Size = new System.Drawing.Size(308, 22);
            this.dtpFechaAplicacion.TabIndex = 3;
            this.dtpFechaAplicacion.ValueChanged += new System.EventHandler(this.dtpFechaAplicacion_ValueChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(264, 160);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 34);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // toolCancelar
            // 
            this.toolCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolCancelar.Image")));
            this.toolCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolCancelar.Location = new System.Drawing.Point(372, 160);
            this.toolCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toolCancelar.Name = "toolCancelar";
            this.toolCancelar.Size = new System.Drawing.Size(103, 34);
            this.toolCancelar.TabIndex = 5;
            this.toolCancelar.Text = "Cancelar";
            this.toolCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolCancelar.UseVisualStyleBackColor = true;
            this.toolCancelar.Click += new System.EventHandler(this.toolCancelar_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(17, 31);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(114, 17);
            this.label23.TabIndex = 282;
            this.label23.Text = "No. Empleado:";
            // 
            // mtxtNoEmpleado
            // 
            this.mtxtNoEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtNoEmpleado.Location = new System.Drawing.Point(167, 28);
            this.mtxtNoEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtNoEmpleado.Mask = "9999";
            this.mtxtNoEmpleado.Name = "mtxtNoEmpleado";
            this.mtxtNoEmpleado.Size = new System.Drawing.Size(43, 22);
            this.mtxtNoEmpleado.TabIndex = 281;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 59);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 280;
            this.label9.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(167, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(308, 22);
            this.txtNombre.TabIndex = 284;
            // 
            // frmDeptoPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 209);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.mtxtNoEmpleado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.toolCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtpFechaAplicacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDeptoPuesto);
            this.Controls.Add(this.lblTextoCambios);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(515, 256);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(515, 256);
            this.Name = "frmDeptoPuesto";
            this.Text = "Cambio de depto y/o puesto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDeptoPuesto_FormClosed);
            this.Load += new System.EventHandler(this.frmDeptoPuesto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextoCambios;
        private System.Windows.Forms.ComboBox cmbDeptoPuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaAplicacion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button toolCancelar;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.MaskedTextBox mtxtNoEmpleado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombre;
    }
}