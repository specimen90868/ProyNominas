namespace Nominas
{
    partial class frmEditorFormulas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditorFormulas));
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("(");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode(")");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("+");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("-");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("*");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("/");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Operadores", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            this.toolAcciones = new System.Windows.Forms.ToolStrip();
            this.toolAsignar = new System.Windows.Forms.ToolStripButton();
            this.toolCerrar = new System.Windows.Forms.ToolStripButton();
            this.treeFormulas = new System.Windows.Forms.TreeView();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.treeOperadores = new System.Windows.Forms.TreeView();
            this.ContenedorTreeView = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.toolAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContenedorTreeView)).BeginInit();
            this.ContenedorTreeView.Panel1.SuspendLayout();
            this.ContenedorTreeView.Panel2.SuspendLayout();
            this.ContenedorTreeView.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolAcciones
            // 
            this.toolAcciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAsignar,
            this.toolCerrar});
            this.toolAcciones.Location = new System.Drawing.Point(0, 0);
            this.toolAcciones.Name = "toolAcciones";
            this.toolAcciones.Size = new System.Drawing.Size(643, 27);
            this.toolAcciones.TabIndex = 6;
            this.toolAcciones.Text = "toolEmpresa";
            // 
            // toolAsignar
            // 
            this.toolAsignar.Image = ((System.Drawing.Image)(resources.GetObject("toolAsignar.Image")));
            this.toolAsignar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAsignar.Name = "toolAsignar";
            this.toolAsignar.Size = new System.Drawing.Size(83, 24);
            this.toolAsignar.Text = "Asignar";
            this.toolAsignar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolAsignar.Click += new System.EventHandler(this.toolAsignar_Click);
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
            // treeFormulas
            // 
            this.treeFormulas.AllowDrop = true;
            this.treeFormulas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeFormulas.Location = new System.Drawing.Point(0, 0);
            this.treeFormulas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeFormulas.Name = "treeFormulas";
            this.treeFormulas.Size = new System.Drawing.Size(290, 282);
            this.treeFormulas.TabIndex = 7;
            this.treeFormulas.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeFormulas_ItemDrag);
            // 
            // txtFormula
            // 
            this.txtFormula.AllowDrop = true;
            this.txtFormula.Location = new System.Drawing.Point(100, 317);
            this.txtFormula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFormula.Multiline = true;
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Size = new System.Drawing.Size(543, 52);
            this.txtFormula.TabIndex = 8;
            this.txtFormula.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtFormula_DragDrop);
            this.txtFormula.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFormula_DragEnter);
            // 
            // treeOperadores
            // 
            this.treeOperadores.AllowDrop = true;
            this.treeOperadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeOperadores.Location = new System.Drawing.Point(0, 0);
            this.treeOperadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeOperadores.Name = "treeOperadores";
            treeNode8.Name = "(";
            treeNode8.Text = "(";
            treeNode9.Name = ")";
            treeNode9.Text = ")";
            treeNode10.Name = "+";
            treeNode10.Text = "+";
            treeNode11.Name = "-";
            treeNode11.Text = "-";
            treeNode12.Name = "*";
            treeNode12.Text = "*";
            treeNode13.Name = "/";
            treeNode13.Text = "/";
            treeNode14.Name = "Operadores";
            treeNode14.Text = "Operadores";
            this.treeOperadores.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14});
            this.treeOperadores.Size = new System.Drawing.Size(348, 282);
            this.treeOperadores.TabIndex = 9;
            this.treeOperadores.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeOperadores_ItemDrag);
            // 
            // ContenedorTreeView
            // 
            this.ContenedorTreeView.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContenedorTreeView.Location = new System.Drawing.Point(0, 27);
            this.ContenedorTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContenedorTreeView.Name = "ContenedorTreeView";
            // 
            // ContenedorTreeView.Panel1
            // 
            this.ContenedorTreeView.Panel1.Controls.Add(this.treeFormulas);
            // 
            // ContenedorTreeView.Panel2
            // 
            this.ContenedorTreeView.Panel2.Controls.Add(this.treeOperadores);
            this.ContenedorTreeView.Size = new System.Drawing.Size(643, 282);
            this.ContenedorTreeView.SplitterDistance = 290;
            this.ContenedorTreeView.SplitterWidth = 5;
            this.ContenedorTreeView.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 320);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fórmula:";
            // 
            // frmEditorFormulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContenedorTreeView);
            this.Controls.Add(this.txtFormula);
            this.Controls.Add(this.toolAcciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(661, 430);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(661, 430);
            this.Name = "frmEditorFormulas";
            this.Text = "Editor de fórmulas";
            this.Load += new System.EventHandler(this.frmEditorFormulas_Load);
            this.toolAcciones.ResumeLayout(false);
            this.toolAcciones.PerformLayout();
            this.ContenedorTreeView.Panel1.ResumeLayout(false);
            this.ContenedorTreeView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContenedorTreeView)).EndInit();
            this.ContenedorTreeView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolAcciones;
        internal System.Windows.Forms.ToolStripButton toolAsignar;
        private System.Windows.Forms.ToolStripButton toolCerrar;
        private System.Windows.Forms.TreeView treeFormulas;
        private System.Windows.Forms.TextBox txtFormula;
        private System.Windows.Forms.TreeView treeOperadores;
        private System.Windows.Forms.SplitContainer ContenedorTreeView;
        private System.Windows.Forms.Label label1;
    }
}