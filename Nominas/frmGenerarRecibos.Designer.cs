namespace Nominas
{
    partial class frmGenerarRecibos
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstvPeriodos = new System.Windows.Forms.ListView();
            this.rbtnExtraordinario = new System.Windows.Forms.RadioButton();
            this.rbtnOrdinario = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolEtapa = new System.Windows.Forms.ToolStripStatusLabel();
            this.workGenerar = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(167, 75);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 21;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(79, 47);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(164, 21);
            this.cmbPeriodo.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Periodo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fechas:";
            // 
            // lstvPeriodos
            // 
            this.lstvPeriodos.CheckBoxes = true;
            this.lstvPeriodos.Location = new System.Drawing.Point(12, 104);
            this.lstvPeriodos.MultiSelect = false;
            this.lstvPeriodos.Name = "lstvPeriodos";
            this.lstvPeriodos.Size = new System.Drawing.Size(231, 201);
            this.lstvPeriodos.TabIndex = 17;
            this.lstvPeriodos.UseCompatibleStateImageBehavior = false;
            // 
            // rbtnExtraordinario
            // 
            this.rbtnExtraordinario.AutoSize = true;
            this.rbtnExtraordinario.Location = new System.Drawing.Point(98, 12);
            this.rbtnExtraordinario.Name = "rbtnExtraordinario";
            this.rbtnExtraordinario.Size = new System.Drawing.Size(102, 17);
            this.rbtnExtraordinario.TabIndex = 16;
            this.rbtnExtraordinario.TabStop = true;
            this.rbtnExtraordinario.Text = "P. Extraordinario";
            this.rbtnExtraordinario.UseVisualStyleBackColor = true;
            this.rbtnExtraordinario.CheckedChanged += new System.EventHandler(this.rbtnExtraordinario_CheckedChanged);
            // 
            // rbtnOrdinario
            // 
            this.rbtnOrdinario.AutoSize = true;
            this.rbtnOrdinario.Location = new System.Drawing.Point(12, 12);
            this.rbtnOrdinario.Name = "rbtnOrdinario";
            this.rbtnOrdinario.Size = new System.Drawing.Size(80, 17);
            this.rbtnOrdinario.TabIndex = 15;
            this.rbtnOrdinario.TabStop = true;
            this.rbtnOrdinario.Text = "P. Ordinario";
            this.rbtnOrdinario.UseVisualStyleBackColor = true;
            this.rbtnOrdinario.CheckedChanged += new System.EventHandler(this.rbtnOrdinario_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(168, 311);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(87, 311);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 13;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolEtapa});
            this.statusStrip1.Location = new System.Drawing.Point(0, 347);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(258, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusLabel1.Text = "Progreso:";
            // 
            // toolEtapa
            // 
            this.toolEtapa.Name = "toolEtapa";
            this.toolEtapa.Size = new System.Drawing.Size(0, 17);
            // 
            // workGenerar
            // 
            this.workGenerar.WorkerReportsProgress = true;
            this.workGenerar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workGenerar_DoWork);
            this.workGenerar.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workGenerar_ProgressChanged);
            this.workGenerar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workGenerar_RunWorkerCompleted);
            // 
            // frmGenerarRecibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 369);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGenerarRecibos";
            this.Text = "Generar recibos de nómina";
            this.Load += new System.EventHandler(this.frmGenerarRecibos_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstvPeriodos;
        private System.Windows.Forms.RadioButton rbtnExtraordinario;
        private System.Windows.Forms.RadioButton rbtnOrdinario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolEtapa;
        private System.ComponentModel.BackgroundWorker workGenerar;
    }
}