namespace Nominas
{
    partial class frmSalario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalario));
            this.toolAcciones = new System.Windows.Forms.ToolStrip();
            this.toolGuardarNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolCerrar = new System.Windows.Forms.ToolStripButton();
            this.dtpPeriodo = new System.Windows.Forms.DateTimePicker();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbZona = new System.Windows.Forms.ComboBox();
            this.toolAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolAcciones
            // 
            this.toolAcciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolGuardarNuevo,
            this.toolCerrar});
            this.toolAcciones.Location = new System.Drawing.Point(0, 0);
            this.toolAcciones.Name = "toolAcciones";
            this.toolAcciones.Size = new System.Drawing.Size(267, 27);
            this.toolAcciones.TabIndex = 5;
            this.toolAcciones.Text = "toolEmpresa";
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
            // dtpPeriodo
            // 
            this.dtpPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPeriodo.Location = new System.Drawing.Point(102, 38);
            this.dtpPeriodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpPeriodo.Name = "dtpPeriodo";
            this.dtpPeriodo.Size = new System.Drawing.Size(120, 22);
            this.dtpPeriodo.TabIndex = 1;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(37, 41);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(61, 17);
            this.Label5.TabIndex = 113;
            this.Label5.Text = "Periodo:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(102, 75);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(120, 22);
            this.txtValor.TabIndex = 2;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(37, 79);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(45, 17);
            this.Label4.TabIndex = 111;
            this.Label4.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 116;
            this.label2.Text = "Zona:";
            // 
            // cmbZona
            // 
            this.cmbZona.FormattingEnabled = true;
            this.cmbZona.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbZona.Location = new System.Drawing.Point(102, 113);
            this.cmbZona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.Size = new System.Drawing.Size(120, 24);
            this.cmbZona.TabIndex = 117;
            // 
            // frmSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 152);
            this.Controls.Add(this.cmbZona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpPeriodo);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.toolAcciones);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(285, 199);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(285, 199);
            this.Name = "frmSalario";
            this.Text = "Salario mínimo del sistema";
            this.Load += new System.EventHandler(this.frmSalario_Load);
            this.toolAcciones.ResumeLayout(false);
            this.toolAcciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolAcciones;
        internal System.Windows.Forms.ToolStripButton toolGuardarNuevo;
        private System.Windows.Forms.ToolStripButton toolCerrar;
        internal System.Windows.Forms.DateTimePicker dtpPeriodo;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtValor;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbZona;
    }
}