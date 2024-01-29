using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic; 

namespace Préstamos {
  class Fórmulas {
    //Método que devuelve el pago mensual de un préstamo
    //Tasa se recibe en porcentaje anual
    //Plazo se recibe en años
    public double mensualidad(double tasa, int plazo, double monto) {
      double tasaMensual, pagoMes;
      int plazoMeses;

      tasaMensual = tasa / 12 / 100;
      plazoMeses = plazo * 12;

      pagoMes = Financial.Pmt(tasaMensual, (double)plazoMeses, -monto);

      return pagoMes;
    }
    public double pagoTotal(double tasa,int plazo,double monto) {
      int plazoMeses = plazo * 12;


      double pagoTotal = plazoMeses * mensualidad( tasa,  plazo, monto) ;

      return pagoTotal;

    }


  }
}
