namespace Nominas
{
    partial class frmListaBitacora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaBitacora));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolBuscar = new System.Windows.Forms.ToolStripButton();
            this.dgvBitacora = new System.Windows.Forms.DataGridView();
            this.toolAtras = new System.Windows.Forms.ToolStripButton();
            this.toolAdelante = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAtras,
            this.toolAdelante,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txtBuscar,
            this.toolBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1050, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(108, 22);
            this.toolStripLabel1.Text = "Buscar por usuario:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 25);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // toolBuscar
            // 
            this.toolBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBuscar.Image = ((System.Drawing.Image)(resources.GetObject("toolBuscar.Image")));
            this.toolBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBuscar.Name = "toolBuscar";
            this.toolBuscar.Size = new System.Drawing.Size(23, 22);
            this.toolBuscar.Text = "toolStripButton1";
            this.toolBuscar.Click += new System.EventHandler(this.toolBuscar_Click);
            // 
            // dgvBitacora
            // 
            this.dgvBitacora.AllowUserToAddRows = false;
            this.dgvBitacora.AllowUserToDeleteRows = false;
            this.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBitacora.Location = new System.Drawing.Point(0, 25);
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.ReadOnly = true;
            this.dgvBitacora.Size = new System.Drawing.Size(1050, 604);
            this.dgvBitacora.TabIndex = 1;
            // 
            // toolAtras
            // 
            this.toolAtras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAtras.Image = ((System.Drawing.Image)(resources.GetObject("toolAtras.Image")));
            this.toolAtras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAtras.Name = "toolAtras";
            this.toolAtras.Size = new System.Drawing.Size(23, 22);
            this.toolAtras.Text = "toolStripButton1";
            this.toolAtras.Click += new System.EventHandler(this.toolAtras_Click);
            // 
            // toolAdelante
            // 
            this.toolAdelante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAdelante.Image = ((System.Drawing.Image)(resources.GetObject("toolAdelante.Image")));
            this.toolAdelante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdelante.Name = "toolAdelante";
            this.toolAdelante.Size = new System.Drawing.Size(23, 22);
            this.toolAdelante.Text = "toolStripButton2";
            this.toolAdelante.Click += new System.EventHandler(this.toolAdelante_Click);
            // 
            // frmListaBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 629);
            this.Controls.Add(this.dgvBitacora);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmListaBitacora";
            this.Text = "Bitácora del sistema";
            this.Load += new System.EventHandler(this.frmListaBitacora_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgvBitacora;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolBuscar;
        private System.Windows.Forms.ToolStripButton toolAtras;
        private System.Windows.Forms.ToolStripButton toolAdelante;
    }
}