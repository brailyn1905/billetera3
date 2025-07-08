using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Negocios;

namespace Capa_Negocios
{
    public class Ingreso : Transaccion
    {
        public override string Tipo => "Ingreso";

        public Ingreso(int id, decimal monto, DateTime fecha, string motivo)
            : base(id, monto, fecha, motivo) { }

        public override bool ValidarSaldo(decimal saldoActual) => true;
    }
}
