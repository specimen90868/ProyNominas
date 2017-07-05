namespace Nominas
{
    partial class frmFiltro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiltro));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolAceptar = new System.Windows.Forms.Button();
            this.toolCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpHasta);
            this.groupBox1.Controls.Add(this.dtpDesde);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(391, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fechas:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(92, 78);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(265, 22);
            this.dtpHasta.TabIndex = 3;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(92, 38);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(265, 22);
            this.dtpDesde.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desde:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta:";
            // 
            // toolAceptar
            // 
            this.toolAceptar.Image = ((System.Drawing.Image)(resources.GetObject("toolAceptar.Image")));
            this.toolAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolAceptar.Location = new System.Drawing.Point(199, 158);
            this.toolAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toolAceptar.Name = "toolAceptar";
            this.toolAceptar.Size = new System.Drawing.Size(100, 41);
            this.toolAceptar.TabIndex = 1;
            this.toolAceptar.Text = "Aceptar";
            this.toolAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolAceptar.UseVisualStyleBackColor = true;
            this.toolAceptar.Click += new System.EventHandler(this.toolAceptar_Click);
            // 
            // toolCancelar
            // 
            this.toolCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolCancelar.Image")));
            this.toolCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolCancelar.Location = new System.Drawing.Point(307, 158);
            this.toolCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toolCancelar.Name = "toolCancelar";
            this.toolCancelar.Size = new System.Drawing.Size(100, 41);
            this.toolCancelar.TabIndex = 2;
            this.toolCancelar.Text = "Cancelar";
            this.toolCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolCancelar.UseVisualStyleBackColor = true;
            this.toolCancelar.Click += new System.EventHandler(this.toolCancelar_Click);
            // 
            // frmFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 203);
            this.Controls.Add(this.toolCancelar);
            this.Controls.Add(this.toolAceptar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(445, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(445, 250);
            this.Name = "frmFiltro";
            this.Text = "Range de fechas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button toolAceptar;
        private System.Windows.Forms.Button toolCancelar;
    }
}