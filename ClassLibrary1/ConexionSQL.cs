using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using billetera3;
using Capa_Negocios;
using Microsoft.Data.SqlClient;

namespace Capa_Negocios
{
    public class TransaccionDatos
    {

        public void InsertarTransaccion(Transaccion transaccion)
        {
            using (SqlConnection conn = new SqlConnection(new ConexionDatos().Conexion))
            {
                string query = "INSERT INTO transaccion (Monto, Fecha, Motivo, Tipo) VALUES (@Monto, @Fecha, @Motivo, @Tipo)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Monto", transaccion.Monto);
                cmd.Parameters.AddWithValue("@Fecha", transaccion.Fecha);
                cmd.Parameters.AddWithValue("@Motivo", transaccion.Motivo);
                cmd.Parameters.AddWithValue("@Tipo", transaccion is Ingreso ? "Ingreso" : "Gasto");

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
