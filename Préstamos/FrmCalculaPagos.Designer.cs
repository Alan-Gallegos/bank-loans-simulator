namespace Préstamos {
  partial class FrmCalculaPagos {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculaPagos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cboTasa = new System.Windows.Forms.ComboBox();
            this.grbPlazo = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.btnMensual = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbPlazo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto del préstamo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tasa de interés";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(233, 39);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(160, 22);
            this.txtMonto.TabIndex = 1;
            // 
            // cboTasa
            // 
            this.cboTasa.FormattingEnabled = true;
            this.cboTasa.Items.AddRange(new object[] {
            "10.0",
            "12.0",
            "15.0",
            "20.0"});
            this.cboTasa.Location = new System.Drawing.Point(233, 103);
            this.cboTasa.Margin = new System.Windows.Forms.Padding(4);
            this.cboTasa.Name = "cboTasa";
            this.cboTasa.Size = new System.Drawing.Size(160, 24);
            this.cboTasa.TabIndex = 3;
            this.cboTasa.SelectedIndexChanged += new System.EventHandler(this.cboTasa_SelectedIndexChanged);
            // 
            // grbPlazo
            // 
            this.grbPlazo.Controls.Add(this.radioButton1);
            this.grbPlazo.Controls.Add(this.radioButton2);
            this.grbPlazo.Controls.Add(this.radioButton3);
            this.grbPlazo.Controls.Add(this.radioButton4);
            this.grbPlazo.Location = new System.Drawing.Point(44, 160);
            this.grbPlazo.Margin = new System.Windows.Forms.Padding(4);
            this.grbPlazo.Name = "grbPlazo";
            this.grbPlazo.Padding = new System.Windows.Forms.Padding(4);
            this.grbPlazo.Size = new System.Drawing.Size(159, 155);
            this.grbPlazo.TabIndex = 4;
            this.grbPlazo.TabStop = false;
            this.grbPlazo.Text = "Plazo del préstamo";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 34);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 21);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1 año";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 63);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 21);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "3 años";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(15, 91);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 21);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "5 años";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(15, 119);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(80, 21);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "10 años";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.RadioButton4_CheckedChanged);
            // 
            // btnMensual
            // 
            this.btnMensual.Location = new System.Drawing.Point(460, 110);
            this.btnMensual.Margin = new System.Windows.Forms.Padding(4);
            this.btnMensual.Name = "btnMensual";
            this.btnMensual.Size = new System.Drawing.Size(147, 60);
            this.btnMensual.TabIndex = 5;
            this.btnMensual.Text = "Mensualidad";
            this.btnMensual.UseVisualStyleBackColor = true;
            this.btnMensual.Click += new System.EventHandler(this.BtnMensual_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(460, 251);
            this.btnTotal.Margin = new System.Windows.Forms.Padding(4);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(147, 57);
            this.btnTotal.TabIndex = 6;
            this.btnTotal.Text = "Total a pagar";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.BtnTotal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(233, 176);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCalculaPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(649, 364);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnMensual);
            this.Controls.Add(this.grbPlazo);
            this.Controls.Add(this.cboTasa);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCalculaPagos";
            this.Text = "Estimación de pagos de un préstamo";
            this.Load += new System.EventHandler(this.FrmCalculaPagos_Load);
            this.grbPlazo.ResumeLayout(false);
            this.grbPlazo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtMonto;
    private System.Windows.Forms.ComboBox cboTasa;
    private System.Windows.Forms.GroupBox grbPlazo;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.RadioButton radioButton3;
    private System.Windows.Forms.RadioButton radioButton4;
    private System.Windows.Forms.Button btnMensual;
    private System.Windows.Forms.Button btnTotal;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}

