namespace Nominas
{
    partial class frmGeneracionQR
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rbtnOrdinario = new System.Windows.Forms.RadioButton();
            this.rbtnExtraordinario = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lstvPeriodos = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolAvance = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolEtapa = new System.Windows.Forms.ToolStripStatusLabel();
            this.workGenerar = new System.ComponentModel.BackgroundWorker();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.nudMes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(126, 420);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 28);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(234, 420);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rbtnOrdinario
            // 
            this.rbtnOrdinario.AutoSize = true;
            this.rbtnOrdinario.Location = new System.Drawing.Point(26, 13);
            this.rbtnOrdinario.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnOrdinario.Name = "rbtnOrdinario";
            this.rbtnOrdinario.Size = new System.Drawing.Size(105, 21);
            this.rbtnOrdinario.TabIndex = 6;
            this.rbtnOrdinario.TabStop = true;
            this.rbtnOrdinario.Text = "P. Ordinario";
            this.rbtnOrdinario.UseVisualStyleBackColor = true;
            this.rbtnOrdinario.CheckedChanged += new System.EventHandler(this.rbtnOrdinario_CheckedChanged);
            // 
            // rbtnExtraordinario
            // 
            this.rbtnExtraordinario.AutoSize = true;
            this.rbtnExtraordinario.Location = new System.Drawing.Point(198, 13);
            this.rbtnExtraordinario.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnExtraordinario.Name = "rbtnExtraordinario";
            this.rbtnExtraordinario.Size = new System.Drawing.Size(134, 21);
            this.rbtnExtraordinario.TabIndex = 7;
            this.rbtnExtraordinario.TabStop = true;
            this.rbtnExtraordinario.Text = "P. Extraordinario";
            this.rbtnExtraordinario.UseVisualStyleBackColor = true;
            this.rbtnExtraordinario.CheckedChanged += new System.EventHandler(this.rbtnExtraordinario_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fechas:";
            // 
            // lstvPeriodos
            // 
            this.lstvPeriodos.CheckBoxes = true;
            this.lstvPeriodos.Location = new System.Drawing.Point(26, 165);
            this.lstvPeriodos.Margin = new System.Windows.Forms.Padding(4);
            this.lstvPeriodos.MultiSelect = false;
            this.lstvPeriodos.Name = "lstvPeriodos";
            this.lstvPeriodos.Size = new System.Drawing.Size(307, 246);
            this.lstvPeriodos.TabIndex = 8;
            this.lstvPeriodos.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Periodo:";
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(115, 95);
            this.cmbPeriodo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(217, 24);
            this.cmbPeriodo.TabIndex = 11;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(233, 129);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(100, 28);
            this.btnMostrar.TabIndex = 12;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolAvance,
            this.toolEtapa});
            this.statusStrip1.Location = new System.Drawing.Point(0, 467);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(352, 25);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(71, 20);
            this.toolStripStatusLabel1.Text = "Progreso:";
            // 
            // toolAvance
            // 
            this.toolAvance.Name = "toolAvance";
            this.toolAvance.Size = new System.Drawing.Size(29, 20);
            this.toolAvance.Text = "0%";
            // 
            // toolEtapa
            // 
            this.toolEtapa.Name = "toolEtapa";
            this.toolEtapa.Size = new System.Drawing.Size(0, 20);
            // 
            // workGenerar
            // 
            this.workGenerar.WorkerReportsProgress = true;
            this.workGenerar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workGenerar_DoWork);
            this.workGenerar.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workGenerar_ProgressChanged);
            this.workGenerar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workGenerar_RunWorkerCompleted);
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(66, 54);
            this.nudAnio.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
            this.nudAnio.Minimum = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(103, 22);
            this.nudAnio.TabIndex = 14;
            this.nudAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAnio.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            // 
            // nudMes
            // 
            this.nudMes.Location = new System.Drawing.Point(229, 54);
            this.nudMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMes.Name = "nudMes";
            this.nudMes.Size = new System.Drawing.Size(103, 22);
            this.nudMes.TabIndex = 15;
            this.nudMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Año:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mes:";
            // 
            // frmGeneracionQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 492);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudMes);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstvPeriodos);
            this.Controls.Add(this.rbtnExtraordinario);
            this.Controls.Add(this.rbtnOrdinario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGenerar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(370, 539);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(370, 539);
            this.Name = "frmGeneracionQR";
            this.Text = "Generar Código QR";
            this.Load += new System.EventHandler(this.frmGeneracionQR_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rbtnOrdinario;
        private System.Windows.Forms.RadioButton rbtnExtraordinario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstvPeriodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolAvance;
        private System.Windows.Forms.ToolStripStatusLabel toolEtapa;
        private System.ComponentModel.BackgroundWorker workGenerar;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.NumericUpDown nudMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}