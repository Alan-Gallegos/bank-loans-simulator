namespace Préstamos {
  partial class FrmAltaPréstamos {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnAlta = new System.Windows.Forms.Button();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculaPago = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(73, 87);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(213, 22);
            this.dtpFecha.TabIndex = 0;
            // 
            // btnAlta
            // 
            this.btnAlta.Enabled = false;
            this.btnAlta.Location = new System.Drawing.Point(339, 145);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(136, 33);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f"});
            this.cboClientes.Location = new System.Drawing.Point(169, 41);
            this.cboClientes.Margin = new System.Windows.Forms.Padding(4);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(117, 24);
            this.cboClientes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliente:";
            // 
            // btnCalculaPago
            // 
            this.btnCalculaPago.Location = new System.Drawing.Point(73, 145);
            this.btnCalculaPago.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculaPago.Name = "btnCalculaPago";
            this.btnCalculaPago.Size = new System.Drawing.Size(165, 33);
            this.btnCalculaPago.TabIndex = 4;
            this.btnCalculaPago.Text = "Calcula pago mensual";
            this.btnCalculaPago.UseVisualStyleBackColor = true;
            this.btnCalculaPago.Click += new System.EventHandler(this.btnCalculaPago_Click);
            // 
            // FrmAltaPréstamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(532, 234);
            this.Controls.Add(this.btnCalculaPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboClientes);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.dtpFecha);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAltaPréstamos";
            this.Text = "Alta de préstamos";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DateTimePicker dtpFecha;
    private System.Windows.Forms.Button btnAlta;
    private System.Windows.Forms.ComboBox cboClientes;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnCalculaPago;
  }
}