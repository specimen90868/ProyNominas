namespace Nominas
{
    partial class frmEnvioRecibos
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
            this.lstvDepartamentos = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstvPeriodos = new System.Windows.Forms.ListView();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.Visor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BarraEstado = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEtapa = new System.Windows.Forms.ToolStripStatusLabel();
            this.workerEnvio = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.btnPeriodos = new System.Windows.Forms.Button();
            this.nudMes = new System.Windows.Forms.NumericUpDown();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.BarraEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // lstvDepartamentos
            // 
            this.lstvDepartamentos.Location = new System.Drawing.Point(329, 76);
            this.lstvDepartamentos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstvDepartamentos.Name = "lstvDepartamentos";
            this.lstvDepartamentos.Size = new System.Drawing.Size(307, 198);
            this.lstvDepartamentos.TabIndex = 8;
            this.lstvDepartamentos.UseCompatibleStateImageBehavior = false;
            this.lstvDepartamentos.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstvDepartamentos_ItemChecked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Departamentos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Periodos:";
            // 
            // lstvPeriodos
            // 
            this.lstvPeriodos.CheckBoxes = true;
            this.lstvPeriodos.Location = new System.Drawing.Point(13, 76);
            this.lstvPeriodos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstvPeriodos.MultiSelect = false;
            this.lstvPeriodos.Name = "lstvPeriodos";
            this.lstvPeriodos.Size = new System.Drawing.Size(307, 198);
            this.lstvPeriodos.TabIndex = 5;
            this.lstvPeriodos.UseCompatibleStateImageBehavior = false;
            this.lstvPeriodos.SelectedIndexChanged += new System.EventHandler(this.lstvPeriodos_SelectedIndexChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(429, 577);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(100, 28);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Emitir";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(537, 577);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.ColumnHeadersVisible = false;
            this.dgvEmpleados.Location = new System.Drawing.Point(13, 299);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvEmpleados.Size = new System.Drawing.Size(621, 271);
            this.dgvEmpleados.TabIndex = 18;
            // 
            // Visor
            // 
            this.Visor.Location = new System.Drawing.Point(219, 553);
            this.Visor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Visor.Name = "Visor";
            this.Visor.Size = new System.Drawing.Size(177, 51);
            this.Visor.TabIndex = 19;
            this.Visor.Visible = false;
            // 
            // BarraEstado
            // 
            this.BarraEstado.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblEtapa});
            this.BarraEstado.Location = new System.Drawing.Point(0, 625);
            this.BarraEstado.Name = "BarraEstado";
            this.BarraEstado.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.BarraEstado.Size = new System.Drawing.Size(648, 25);
            this.BarraEstado.TabIndex = 20;
            this.BarraEstado.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(153, 20);
            this.toolStripStatusLabel1.Text = "Proceso de emisión:....";
            // 
            // lblEtapa
            // 
            this.lblEtapa.Name = "lblEtapa";
            this.lblEtapa.Size = new System.Drawing.Size(47, 20);
            this.lblEtapa.Text = "Etapa";
            // 
            // workerEnvio
            // 
            this.workerEnvio.WorkerReportsProgress = true;
            this.workerEnvio.WorkerSupportsCancellation = true;
            this.workerEnvio.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerEnvio_DoWork);
            this.workerEnvio.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerEnvio_ProgressChanged);
            this.workerEnvio.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerEnvio_RunWorkerCompleted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 279);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Empleados:";
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(443, 47);
            this.chkTodos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(143, 21);
            this.chkTodos.TabIndex = 24;
            this.chkTodos.Text = "Seleccionar todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // btnPeriodos
            // 
            this.btnPeriodos.Location = new System.Drawing.Point(384, 9);
            this.btnPeriodos.Name = "btnPeriodos";
            this.btnPeriodos.Size = new System.Drawing.Size(75, 26);
            this.btnPeriodos.TabIndex = 29;
            this.btnPeriodos.Text = "Mostrar";
            this.btnPeriodos.UseVisualStyleBackColor = true;
            this.btnPeriodos.Click += new System.EventHandler(this.btnPeriodos_Click);
            // 
            // nudMes
            // 
            this.nudMes.Location = new System.Drawing.Point(244, 11);
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
            this.nudMes.Size = new System.Drawing.Size(120, 22);
            this.nudMes.TabIndex = 28;
            this.nudMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(55, 11);
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
            this.nudAnio.Size = new System.Drawing.Size(120, 22);
            this.nudAnio.TabIndex = 27;
            this.nudAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAnio.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Mes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Año:";
            // 
            // frmEnvioRecibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 650);
            this.Controls.Add(this.btnPeriodos);
            this.Controls.Add(this.nudMes);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BarraEstado);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lstvDepartamentos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstvPeriodos);
            this.Controls.Add(this.Visor);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEnvioRecibos";
            this.Text = "Emisión de recibos";
            this.Load += new System.EventHandler(this.frmEnvioRecibos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.BarraEstado.ResumeLayout(false);
            this.BarraEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvDepartamentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstvPeriodos;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private Microsoft.Reporting.WinForms.ReportViewer Visor;
        private System.Windows.Forms.StatusStrip BarraEstado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblEtapa;
        private System.ComponentModel.BackgroundWorker workerEnvio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Button btnPeriodos;
        private System.Windows.Forms.NumericUpDown nudMes;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}