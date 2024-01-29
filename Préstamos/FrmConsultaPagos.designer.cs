namespace Préstamos
{
    partial class FrmConsultaPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaPagos));
            this.dgvConsultaPagos = new System.Windows.Forms.DataGridView();
            this.lblClientes = new System.Windows.Forms.Label();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.btnConsultaPagos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaPagos
            // 
            this.dgvConsultaPagos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvConsultaPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaPagos.Location = new System.Drawing.Point(152, 184);
            this.dgvConsultaPagos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConsultaPagos.Name = "dgvConsultaPagos";
            this.dgvConsultaPagos.RowHeadersWidth = 51;
            this.dgvConsultaPagos.Size = new System.Drawing.Size(668, 101);
            this.dgvConsultaPagos.TabIndex = 0;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Location = new System.Drawing.Point(149, 109);
            this.lblClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(66, 17);
            this.lblClientes.TabIndex = 1;
            this.lblClientes.Text = "Clientes: ";
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(223, 106);
            this.cboClientes.Margin = new System.Windows.Forms.Padding(4);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(209, 24);
            this.cboClientes.TabIndex = 2;
            this.cboClientes.SelectedIndexChanged += new System.EventHandler(this.cboClientes_SelectedIndexChanged);
            // 
            // btnConsultaPagos
            // 
            this.btnConsultaPagos.Location = new System.Drawing.Point(509, 95);
            this.btnConsultaPagos.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultaPagos.Name = "btnConsultaPagos";
            this.btnConsultaPagos.Size = new System.Drawing.Size(169, 44);
            this.btnConsultaPagos.TabIndex = 3;
            this.btnConsultaPagos.Text = "Consulta";
            this.btnConsultaPagos.UseVisualStyleBackColor = true;
            this.btnConsultaPagos.Click += new System.EventHandler(this.btnConsultaPagos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(780, 316);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmConsultaPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConsultaPagos);
            this.Controls.Add(this.cboClientes);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.dgvConsultaPagos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConsultaPagos";
            this.Text = "FrmConsultaPagos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaPagos;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.Button btnConsultaPagos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}