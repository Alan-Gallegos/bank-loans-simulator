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
    public partial class FrmConsClientes : Form
    {
        //Atributos de clase 
        GestorBD.GestorBD GestorBD;
        DataSet DsGeneral = new DataSet();
        Comunes mc = new Comunes(); 
        String rfc, cadSql;
        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            cadSql = $"select * from Clientes where Rfc='{this.rfc}'";
            GestorBD.consBD(cadSql, DsGeneral, "Cliente");
            dtgClientes.DataSource = DsGeneral.Tables["Cliente"]; 
        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rfc = cboClientes.Text; 
        }

        private void FrmConsClientes_Load(object sender, EventArgs e)
        {

        }

        public FrmConsClientes(GestorBD.GestorBD GestorBD, string rfc)
        {
            InitializeComponent();
            this.GestorBD = GestorBD;
            this.rfc = rfc; 
            //Si el usuario es el gerente
            if (rfc == "ger")
            {
                label1.Visible = true;
                cboClientes.Visible = true;

                //lee los Rfc de los Clientes
                cadSql = "select rfc from Clientes where Rfc != 'ger'";
                GestorBD.consBD(cadSql, DsGeneral, "Clientes");
                mc.cargaCombo(cboClientes, DsGeneral, "Clientes", "Rfc"); 
            }
            else
            {
                label1.Visible = false; 
            }
        }
    }
}
