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
  public partial class FrmAltaClientes : Form {

    //Atributos de la clase.
    GestorBD.GestorBD GestorBD;        //Para manejar la BD.
    String cadSql;
    private const int OK = 1;

    //Acciones iniciales.
    public FrmAltaClientes(GestorBD.GestorBD GestorBD ) {
      InitializeComponent();
      this.GestorBD = GestorBD;


    }

    //Construye la instrucción de inserción y la ejecuta usando el GestorBD.
    private void btnAlta_Click(object sender, EventArgs e) {
      cadSql = $"insert into Clientes values('{txtRFC.Text}','{txtContra.Text}'," +
        $"'{txtNom.Text}','{txtDom.Text}','{txtTel.Text}')";
      MessageBox.Show(cadSql);
      if (GestorBD.altaBD(cadSql) == OK)
        MessageBox.Show("Alta exitosa");
      else
        MessageBox.Show("Error en alta");
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }
    }

  }

