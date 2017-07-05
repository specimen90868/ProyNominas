namespace Nominas
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.toolEmpresa = new System.Windows.Forms.ToolStrip();
            this.toolGuardarNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolCerrar = new System.Windows.Forms.ToolStripButton();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.dgvEmpresas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolEmpresa
            // 
            this.toolEmpresa.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolEmpresa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolGuardarNuevo,
            this.toolCerrar});
            this.toolEmpresa.Location = new System.Drawing.Point(0, 0);
            this.toolEmpresa.Name = "toolEmpresa";
            this.toolEmpresa.Size = new System.Drawing.Size(650, 27);
            this.toolEmpresa.TabIndex = 2;
            this.toolEmpresa.Text = "toolEmpresa";
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
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 117);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 177;
            this.lblPassword.Text = "Password:";
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Location = new System.Drawing.Point(20, 149);
            this.lblPassword2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(138, 17);
            this.lblPassword2.TabIndex = 179;
            this.lblPassword2.Text = "Confirmar Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(177, 114);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(160, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(177, 146);
            this.txtPassword2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(160, 22);
            this.txtPassword2.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(177, 16);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(345, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(20, 19);
            this.Label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(62, 17);
            this.Label16.TabIndex = 176;
            this.Label16.Text = "Nombre:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(177, 82);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(160, 22);
            this.txtUsuario.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(20, 85);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(61, 17);
            this.Label1.TabIndex = 174;
            this.Label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 180;
            this.label2.Text = "Perfil:";
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Location = new System.Drawing.Point(177, 48);
            this.cmbPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(160, 24);
            this.cmbPerfil.TabIndex = 5;
            // 
            // dgvEmpresas
            // 
            this.dgvEmpresas.AllowUserToAddRows = false;
            this.dgvEmpresas.AllowUserToDeleteRows = false;
            this.dgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.seleccion});
            this.dgvEmpresas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpresas.Location = new System.Drawing.Point(0, 0);
            this.dgvEmpresas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmpresas.Name = "dgvEmpresas";
            this.dgvEmpresas.RowHeadersVisible = false;
            this.dgvEmpresas.Size = new System.Drawing.Size(650, 440);
            this.dgvEmpresas.TabIndex = 182;
            this.dgvEmpresas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpresas_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Empresa";
            this.nombre.Name = "nombre";
            // 
            // seleccion
            // 
            this.seleccion.HeaderText = "Seleccion";
            this.seleccion.Name = "seleccion";
            this.seleccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.seleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Seleccion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Empresa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtNombre);
            this.splitContainer1.Panel1.Controls.Add(this.cmbPerfil);
            this.splitContainer1.Panel1.Controls.Add(this.Label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtUsuario);
            this.splitContainer1.Panel1.Controls.Add(this.lblPassword);
            this.splitContainer1.Panel1.Controls.Add(this.Label16);
            this.splitContainer1.Panel1.Controls.Add(this.lblPassword2);
            this.splitContainer1.Panel1.Controls.Add(this.txtPassword2);
            this.splitContainer1.Panel1.Controls.Add(this.txtPassword);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvEmpresas);
            this.splitContainer1.Size = new System.Drawing.Size(650, 626);
            this.splitContainer1.SplitterDistance = 182;
            this.splitContainer1.TabIndex = 183;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 653);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolEmpresa);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(668, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(668, 700);
            this.Name = "frmUsuarios";
            this.Text = "Usuario del sistema";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.toolEmpresa.ResumeLayout(false);
            this.toolEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolEmpresa;
        internal System.Windows.Forms.ToolStripButton toolGuardarNuevo;
        private System.Windows.Forms.ToolStripButton toolCerrar;
        internal System.Windows.Forms.Label lblPassword;
        internal System.Windows.Forms.Label lblPassword2;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.TextBox txtPassword2;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox txtUsuario;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.DataGridView dgvEmpresas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccion;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}