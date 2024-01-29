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
  public partial class FrmIngreso : Form {
    // Atributos de la clase.
    GestorBD.GestorBD GestorBD;
    DataSet DsGeneral = new DataSet();
    string cadSql;

    public FrmIngreso() {
      InitializeComponent();
    }

    // Accion inicial, conexión base de datos  
    private void FrmIngreso_Load(object sender, EventArgs e) {

      GestorBD = new GestorBD.GestorBD("SQLNCLI11", "DESKTOP-PCR9L3S", "sa",
        "sqladmin","Préstamos");

        }

    //Verifica que coincidan el usuario y la contraseña dados.
    private void btnIngresar_Click(object sender, EventArgs e) {
      //Construye la consulta correspondiente
      cadSql = $"select * from Clientes where Rfc='{txtUsuario.Text}' " +
        $"and Contraseña='{txtContra.Text}'";

      //Ejecuta la consulta y verifica el resultado
      GestorBD.consBD(cadSql, DsGeneral, "cliente");
      if(DsGeneral.Tables["cliente"].Rows.Count == 1) {
        FrmMenúGeneral fmg= new FrmMenúGeneral(GestorBD, txtUsuario.Text); //El usuario sí existe
        fmg.ShowDialog();
      }
      else {
        MessageBox.Show("Usuario y contraseña no coinciden");
        txtUsuario.Focus();
      }

    }

    private string propRfcU;
    public string RfcU {
      get { return txtUsuario.Text; } //obtiene el rfc. 
      set { propRfcU = txtUsuario.Text; } //guarda el rfc
    }
  }
}
