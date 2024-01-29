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
  public partial class FrmMenúGeneral : Form {
    //Atributos de clase
    GestorBD.GestorBD GestorBD;
    string rfc;

    public FrmMenúGeneral(GestorBD.GestorBD GestorBD, string rfc) {
      InitializeComponent();
      this.GestorBD = GestorBD;
      this.rfc = rfc;
      //Habilita el Alta cliente si el usuario que entro fue gerente
      if (rfc == "ger")
      {
        mnuAlta.Enabled = true;
        mnuAltaPréstamos.Enabled = true;
        mnuAltaPagos.Enabled = true;  
      }
      else
      {
        mnuAlta.Enabled = false;
        mnuAltaPréstamos.Enabled = false;
        mnuAltaPagos.Enabled = false;  
      }

    }

    //Termina la aplicacion
    private void cerrarToolStripMenuItem_Click(object sender, EventArgs e) {
        Application.Exit();
    }

    private void altaToolStripMenuItem_Click(object sender, EventArgs e) {
      FrmAltaClientes fac = new FrmAltaClientes(GestorBD);
      fac.ShowDialog();
    }

   
    //MNU CONSULTA CLIENTES
    //abre la forma de consulta clientes
    private void consultaToolStripMenuItem_Click(object sender, EventArgs e) {
      FrmConsClientes fcc = new FrmConsClientes(GestorBD,rfc);
      fcc.ShowDialog();

    }

    //Abre la forma de alta de préstamos
    private void mnuAltaPréstamos_Click(object sender, EventArgs e) {
      FrmAltaPréstamos fap = new FrmAltaPréstamos(GestorBD);
      fap.ShowDialog();

    }

    private void mnuConsPagos_Click(object sender, EventArgs e)
     {
        FrmConsultaPagos fcpa = new FrmConsultaPagos(GestorBD, rfc);
        fcpa.ShowDialog(); 
     }

     private void mnuConsPréstamos_Click(object sender, EventArgs e)
     {
        FrmConsPréstamos fcpr = new FrmConsPréstamos(GestorBD, rfc);
        fcpr.ShowDialog(); 
     }

        private void mnuAltaPagos_Click(object sender, EventArgs e)
        {
            FrmAltaPagos fap = new FrmAltaPagos(GestorBD);
            fap.ShowDialog(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
