using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Préstamos
{
    public partial class FrmConsultaPagos : Form
    {
        //Atributos de la clase
        GestorBD.GestorBD GestorBD;
        DataSet DsGeneral = new DataSet();
        Comunes mc = new Comunes();
        String rfc, cadSql;

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rfc = cboClientes.Text; 
        }

        private void btnConsultaPagos_Click(object sender, EventArgs e)
        {
            cadSql = $"select * from Pagos where Folio in " +
                $"(select p.Folio from Préstamos pr, Pagos p where pr.Folio = p.Folio" +
                $" and pr.RFC = '{this.rfc}')";  
            GestorBD.consBD(cadSql, DsGeneral, "Pagos");
            dgvConsultaPagos.DataSource = DsGeneral.Tables["Pagos"];
        }

        public FrmConsultaPagos(GestorBD.GestorBD GestorBD, string rfc)
        {
            InitializeComponent();
            this.GestorBD = GestorBD;
            this.rfc = rfc; 
            if (rfc == "ger")
            {
                cboClientes.Enabled = true;
                lblClientes.Visible = true;
                //lee los Rfc de los Clientes
                cadSql = "select rfc from Clientes where Rfc != 'ger'";
                GestorBD.consBD(cadSql, DsGeneral, "Clientes");
                mc.cargaCombo(cboClientes, DsGeneral, "Clientes", "Rfc");
            }
            else
            {
                cboClientes.Enabled = false; 
                cboClientes.Visible = false;
                lblClientes.Visible = false; 
            }
        }
    }
}
