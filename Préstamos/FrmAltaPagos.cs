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
    public partial class FrmAltaPagos : Form
    {
        //Atributos de clase 
        GestorBD.GestorBD GestorBD;
        DataSet DsGeneral = new DataSet();
        Comunes mc = new Comunes();
        private const int OK = 1;
        private string rfc, cadSqlP, cadSqlC; //folio;
        int folio; 

        //private string folio; 
        public FrmAltaPagos(GestorBD.GestorBD GestorBD)
        {
            InitializeComponent();
            this.GestorBD = GestorBD;
            //lee los Rfc de los Clientes
            cadSqlC = "select rfc from Clientes where Rfc != 'ger'";
            GestorBD.consBD(cadSqlC, DsGeneral, "Clientes");
            mc.cargaCombo(cboClientes, DsGeneral, "Clientes", "Rfc");
            
        }

        private void btnAltaPago_Click(object sender, EventArgs e)
        {
            String fecha = dtpFecha.Value.ToShortDateString().ToString();     //Recupera la fecha.
            String folio = cboFolio.Text;
            String monto = txtbMonto.Text;
            String rfc = cboClientes.Text;
            String cadSqlIdP, cadSqlAlta, cadSqlMod;
            DataRow fila;
            //MessageBox.Show("Folio:" +folio);
            int idP;
            cadSqlIdP = $"select top 1 IdP  from Pagos p, Préstamos pr where p.Folio = {folio} and " +
                $"pr.rfc = '{rfc}' group by p.Folio, p.IdP order by IdP desc";
            GestorBD.consBD(cadSqlIdP, DsGeneral, "IdP");
            if (DsGeneral.Tables["IdP"].Rows.Count != 0)
            {
                fila = DsGeneral.Tables["IdP"].Rows[0];   //Si sí, recupera el máximo idP.
                idP = (int)fila["IdP"] + 1;              //Genera el nuevo idPago.
            }
            else idP = 1; //Genera el primer pago 
            cadSqlAlta = $"insert into Pagos values ('{folio}', {idP}, '{fecha}', {monto})";
            MessageBox.Show(cadSqlAlta);

            if (GestorBD.altaBD(cadSqlAlta) == OK)
            {  //Envía a ejecución la cadena.
                MessageBox.Show("Alta de pago exitosa");
                cadSqlMod = $"update Préstamos set saldo = saldo-{monto} where Folio = '{folio}' and rfc = '{rfc}' ";
                GestorBD.cambiaBD(cadSqlMod);
            }
            else
            {
                MessageBox.Show("Alta de pago incorrecta");
            }
            btnAltaPago.Enabled = false;
        }

        private void cboFolio_SelectedIndexChanged(object sender, EventArgs e)
        { 
            this.folio = int.Parse(cboFolio.Text);
        }

        private void FrmAltaPagos_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rfc = cboClientes.Text;
            
            //lee los Folios de los Prestamos
            cadSqlP = $"select Folio from Préstamos p where p.RFC = '{cboClientes.Text}' group by Folio";
            GestorBD.consBD(cadSqlP, DsGeneral, "Préstamos");
            mc.cargaCombo(cboFolio, DsGeneral, "Préstamos", "Folio");
            
        }
    }
}
