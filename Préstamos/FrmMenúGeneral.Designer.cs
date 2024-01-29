namespace Préstamos {
  partial class FrmMenúGeneral {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
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
    private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenúGeneral));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultaClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAltaPréstamos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsPréstamos = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAltaPagos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsPagos = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.préstamosToolStripMenuItem,
            this.pagosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(121, 26);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAlta,
            this.mnuConsultaClientes});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // mnuAlta
            // 
            this.mnuAlta.Enabled = false;
            this.mnuAlta.Name = "mnuAlta";
            this.mnuAlta.Size = new System.Drawing.Size(153, 26);
            this.mnuAlta.Text = "Alta";
            this.mnuAlta.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // mnuConsultaClientes
            // 
            this.mnuConsultaClientes.Name = "mnuConsultaClientes";
            this.mnuConsultaClientes.Size = new System.Drawing.Size(153, 26);
            this.mnuConsultaClientes.Text = "Consulta ";
            this.mnuConsultaClientes.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // préstamosToolStripMenuItem
            // 
            this.préstamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAltaPréstamos,
            this.mnuConsPréstamos});
            this.préstamosToolStripMenuItem.Name = "préstamosToolStripMenuItem";
            this.préstamosToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.préstamosToolStripMenuItem.Text = "Préstamos";
            // 
            // mnuAltaPréstamos
            // 
            this.mnuAltaPréstamos.Name = "mnuAltaPréstamos";
            this.mnuAltaPréstamos.Size = new System.Drawing.Size(149, 26);
            this.mnuAltaPréstamos.Text = "Alta";
            this.mnuAltaPréstamos.Click += new System.EventHandler(this.mnuAltaPréstamos_Click);
            // 
            // mnuConsPréstamos
            // 
            this.mnuConsPréstamos.Name = "mnuConsPréstamos";
            this.mnuConsPréstamos.Size = new System.Drawing.Size(149, 26);
            this.mnuConsPréstamos.Text = "Consulta";
            this.mnuConsPréstamos.Click += new System.EventHandler(this.mnuConsPréstamos_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAltaPagos,
            this.mnuConsPagos});
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.pagosToolStripMenuItem.Text = "Pagos";
            // 
            // mnuAltaPagos
            // 
            this.mnuAltaPagos.Name = "mnuAltaPagos";
            this.mnuAltaPagos.Size = new System.Drawing.Size(149, 26);
            this.mnuAltaPagos.Text = "Alta";
            this.mnuAltaPagos.Click += new System.EventHandler(this.mnuAltaPagos_Click);
            // 
            // mnuConsPagos
            // 
            this.mnuConsPagos.Name = "mnuConsPagos";
            this.mnuConsPagos.Size = new System.Drawing.Size(149, 26);
            this.mnuConsPagos.Text = "Consulta";
            this.mnuConsPagos.Click += new System.EventHandler(this.mnuConsPagos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 425);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmMenúGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMenúGeneral";
            this.Text = "Menú General";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAlta;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaClientes;
        private System.Windows.Forms.ToolStripMenuItem préstamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAltaPréstamos;
        private System.Windows.Forms.ToolStripMenuItem mnuAltaPagos;
        private System.Windows.Forms.ToolStripMenuItem mnuConsPagos;
        private System.Windows.Forms.ToolStripMenuItem mnuConsPréstamos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}