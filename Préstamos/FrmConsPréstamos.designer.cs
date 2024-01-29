namespace Préstamos
{
    partial class FrmConsPréstamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsPréstamos));
            this.btnConsultaPréstamo = new System.Windows.Forms.Button();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvConsultaPréstamos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPréstamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultaPréstamo
            // 
            this.btnConsultaPréstamo.Location = new System.Drawing.Point(515, 94);
            this.btnConsultaPréstamo.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultaPréstamo.Name = "btnConsultaPréstamo";
            this.btnConsultaPréstamo.Size = new System.Drawing.Size(139, 37);
            this.btnConsultaPréstamo.TabIndex = 0;
            this.btnConsultaPréstamo.Text = "Consulta";
            this.btnConsultaPréstamo.UseVisualStyleBackColor = true;
            this.btnConsultaPréstamo.Click += new System.EventHandler(this.btnConsultaPréstamo_Click);
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(205, 101);
            this.cboClientes.Margin = new System.Windows.Forms.Padding(4);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(161, 24);
            this.cboClientes.TabIndex = 1;
            this.cboClientes.SelectedIndexChanged += new System.EventHandler(this.cboClientes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Clientes";
            // 
            // dgvConsultaPréstamos
            // 
            this.dgvConsultaPréstamos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvConsultaPréstamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaPréstamos.Location = new System.Drawing.Point(122, 159);
            this.dgvConsultaPréstamos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConsultaPréstamos.Name = "dgvConsultaPréstamos";
            this.dgvConsultaPréstamos.RowHeadersWidth = 51;
            this.dgvConsultaPréstamos.Size = new System.Drawing.Size(633, 116);
            this.dgvConsultaPréstamos.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(735, 299);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FrmConsPréstamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 436);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvConsultaPréstamos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboClientes);
            this.Controls.Add(this.btnConsultaPréstamo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConsPréstamos";
            this.Text = "FrmConsPréstamos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPréstamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultaPréstamo;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvConsultaPréstamos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}