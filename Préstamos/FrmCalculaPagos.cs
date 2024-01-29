using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Préstamos {
  public partial class FrmCalculaPagos : Form {
    // Propiedades de la clase
    // este ejemplo solo es con el monto, habría que hacer algo parecido para tasa, plazo , mensualidad y total.

    private double propMonto,propTasa,propPlazo,propMes,propPagoTot;
    public double Monto {
      get { return Convert.ToDouble(txtMonto.Text); } //obtiene el monto. 
      set { propMonto = Convert.ToDouble(txtMonto.Text); } //guarda el monto


    }
    public double Tasa {
      get { return Convert.ToDouble(cboTasa.Text); }  //obtiene
      set { propTasa = Convert.ToDouble(cboTasa.Text); } //guarda ??
    }
   
    public FrmCalculaPagos() {
      InitializeComponent();
    }
    //Variables de clase.
    int plazo; 
      double pagoMensual,pagoTotal;
    Fórmulas f = new Fórmulas();

   
    //Valores default de monto, tasa y plazo
    private void FrmCalculaPagos_Load(object sender, EventArgs e) {
      txtMonto.Text = "5,000.00";
      cboTasa.Text = "10.0";
      radioButton1.Checked = true; plazo = 1; 
    }


    //Establece el plazo según el botón de radio elegido
    private void RadioButton1_CheckedChanged(object sender, EventArgs e) {
      plazo = 1;
    }
    private void RadioButton2_CheckedChanged(object sender, EventArgs e) {
      plazo = 3;
    }

    private void RadioButton3_CheckedChanged(object sender, EventArgs e) {
      plazo = 5;
    }

    private void RadioButton4_CheckedChanged(object sender, EventArgs e) {
      plazo = 10;
    }
    //Calcula pago mensual del préstamo
    private void BtnMensual_Click(object sender, EventArgs e) {
      pagoMensual = f.mensualidad(Convert.ToDouble(cboTasa.Text),plazo, Convert.ToDouble(txtMonto.Text) );

      MessageBox.Show("Pago Mensual:" + pagoMensual.ToString("c"));

    }

        private void cboTasa_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void BtnTotal_Click(object sender, EventArgs e) {
      pagoTotal = f.pagoTotal(Convert.ToDouble(cboTasa.Text), plazo, Convert.ToDouble(txtMonto.Text));

      MessageBox.Show("Pago Total:" + pagoTotal.ToString("c"));

    }
    public double Mensualidad {
      get { return pagoMensual; } //obtiene, en este caso no lo obtiene de ningun txt o cboBox sino del res del metodo PagoMes
      set { propMes = pagoMensual; }
    }
    public double PagoTotal {
      get { return pagoTotal; } //obtiene igual que con PagoMes
      set { propPagoTot = pagoTotal; }
    }
    public double Plazo {
      get { return plazo; }
      set { propPlazo = plazo; }

    }

  }
}
