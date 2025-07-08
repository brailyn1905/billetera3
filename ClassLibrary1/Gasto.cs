using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Negocios;

namespace Capa_Negocios
{
    public class Gasto : Transaccion
    {
        public override string Tipo => "Gasto";

        public Gasto(int id, decimal monto, DateTime fecha, string motivo)
            : base(id, monto, fecha, motivo) { }

        public override bool ValidarSaldo(decimal saldoActual)
        {
            if (saldoActual < Monto)
            {
                Console.WriteLine("Saldo insuficiente. No se puede registrar el gasto.");
                return false;
            }
            return true;
        }

        public override void RegistrarOperacion()
        {
            Console.WriteLine($"Gasto registrado: {Monto} - {Motivo} - {Fecha.ToShortDateString()}");
        }
    }
}
