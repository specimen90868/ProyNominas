namespace Nominas
{
    partial class frmImpresionRecibos
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
            this.lstvPeriodos = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstvDepartamentos = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.lstvEmpleados = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.chkImprimirTodos = new System.Windows.Forms.CheckBox();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.nudMes = new System.Windows.Forms.NumericUpDown();
            this.btnPeriodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).BeginInit();
            this.SuspendLayout();
            // 
            // lstvPeriodos
            // 
            this.lstvPeriodos.CheckBoxes = true;
            this.lstvPeriodos.Location = new System.Drawing.Point(20, 67);
            this.lstvPeriodos.Margin = new System.Windows.Forms.Padding(4);
            this.lstvPeriodos.MultiSelect = false;
            this.lstvPeriodos.Name = "lstvPeriodos";
            this.lstvPeriodos.Size = new System.Drawing.Size(307, 212);
            this.lstvPeriodos.TabIndex = 0;
            this.lstvPeriodos.UseCompatibleStateImageBehavior = false;
            this.lstvPeriodos.SelectedIndexChanged += new System.EventHandler(this.lstvPeriodos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Periodos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Departamentos:";
            // 
            // lstvDepartamentos
            // 
            this.lstvDepartamentos.Location = new System.Drawing.Point(336, 67);
            this.lstvDepartamentos.Margin = new System.Windows.Forms.Padding(4);
            this.lstvDepartamentos.Name = "lstvDepartamentos";
            this.lstvDepartamentos.Size = new System.Drawing.Size(307, 212);
            this.lstvDepartamentos.TabIndex = 4;
            this.lstvDepartamentos.UseCompatibleStateImageBehavior = false;
            this.lstvDepartamentos.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstvDepartamentos_ItemChecked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 291);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Empleados:";
            // 
            // lstvEmpleados
            // 
            this.lstvEmpleados.Location = new System.Drawing.Point(20, 336);
            this.lstvEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.lstvEmpleados.Name = "lstvEmpleados";
            this.lstvEmpleados.Size = new System.Drawing.Size(623, 285);
            this.lstvEmpleados.TabIndex = 6;
            this.lstvEmpleados.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 312);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscar.Location = new System.Drawing.Point(240, 308);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(131, 23);
            this.txtBuscar.TabIndex = 10;
            this.txtBuscar.Text = "No. de empleado";
            this.txtBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(544, 629);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(436, 629);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // chkImprimirTodos
            // 
            this.chkImprimirTodos.AutoSize = true;
            this.chkImprimirTodos.Location = new System.Drawing.Point(336, 282);
            this.chkImprimirTodos.Margin = new System.Windows.Forms.Padding(4);
            this.chkImprimirTodos.Name = "chkImprimirTodos";
            this.chkImprimirTodos.Size = new System.Drawing.Size(118, 21);
            this.chkImprimirTodos.TabIndex = 15;
            this.chkImprimirTodos.Text = "Imprimir todos";
            this.chkImprimirTodos.UseVisualStyleBackColor = true;
            this.chkImprimirTodos.CheckedChanged += new System.EventHandler(this.chkImprimirTodos_CheckedChanged);
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(20, 310);
            this.chkTodos.Margin = new System.Windows.Forms.Padding(4);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(143, 21);
            this.chkTodos.TabIndex = 16;
            this.chkTodos.Text = "Seleccionar todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Año:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Mes:";
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(60, 10);
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
            this.nudAnio.TabIndex = 19;
            this.nudAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAnio.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            // 
            // nudMes
            // 
            this.nudMes.Location = new System.Drawing.Point(249, 10);
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
            this.nudMes.TabIndex = 20;
            this.nudMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnPeriodos
            // 
            this.btnPeriodos.Location = new System.Drawing.Point(389, 7);
            this.btnPeriodos.Name = "btnPeriodos";
            this.btnPeriodos.Size = new System.Drawing.Size(75, 26);
            this.btnPeriodos.TabIndex = 21;
            this.btnPeriodos.Text = "Mostrar";
            this.btnPeriodos.UseVisualStyleBackColor = true;
            this.btnPeriodos.Click += new System.EventHandler(this.btnPeriodos_Click);
            // 
            // frmImpresionRecibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 679);
            this.Controls.Add(this.btnPeriodos);
            this.Controls.Add(this.nudMes);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.chkImprimirTodos);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstvEmpleados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstvDepartamentos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstvPeriodos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImpresionRecibos";
            this.Text = "Impresión de recibos";
            this.Load += new System.EventHandler(this.frmImpresionRecibos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvPeriodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstvDepartamentos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstvEmpleados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox chkImprimirTodos;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.NumericUpDown nudMes;
        private System.Windows.Forms.Button btnPeriodos;
    }
}