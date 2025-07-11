using System;
using billetera3;
using Capa_Negocios;
using Microsoft.Data.SqlClient;





namespace Capa_Negocios
{
    public abstract class Transaccion
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; }

        public abstract string Tipo { get; }

        // Constructor; el protecte significa que Solo puede ser usado desde clases hijas (no desde fuera).
        protected Transaccion(int id, decimal monto, DateTime fecha, string motivo)
        {
            Id = id;
            Monto = monto;
            Fecha = fecha;
            Motivo = motivo;
        }

        // Método virtual para validar saldo
        public virtual bool ValidarSaldo(decimal saldoActual)
        {
            return saldoActual >= Monto;
        }

        // Método normal para registrar operación
        public virtual void RegistrarOperacion()
        {
            Console.WriteLine($"Transacción registrada: {Monto} - {Motivo} - {Fecha.ToShortDateString()}");
        }


        public static decimal ObtenerSaldoActual()
        {
            decimal saldo = 0;

            using (SqlConnection conexion = new SqlConnection(new ConexionDatos().Conexion))
            {
                string consulta = "SELECT Tipo, Monto FROM Transaccion";
                SqlCommand comando = new SqlCommand(consulta, conexion);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        string tipo = reader["Tipo"].ToString();
                        decimal monto = Convert.ToDecimal(reader["Monto"]);

                        if (tipo == "Ingreso")
                            saldo += monto;
                        else if (tipo == "Gasto")
                            saldo -= monto;
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    //Usar throw para enviar el error al formulario
                    throw new Exception("Error al obtener el saldo actual: " + ex.Message);
                }
            }

            return saldo;
        }



       


        public static List<Transaccion> FiltrarPorTipoYFechas(string tipo, DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Transaccion> lista = new List<Transaccion>();
            ConexionDatos conexionClase = new ConexionDatos();

            using (SqlConnection conexion = new SqlConnection(conexionClase.Conexion))
            {
                // Consulta SQL con parámetros para tipo y rango de fechas
                string consulta = @"
            SELECT Id, Monto, Fecha, Motivo, Tipo 
            FROM Transaccion
            WHERE Tipo = @Tipo
              AND Fecha BETWEEN @FechaDesde AND @FechaHasta
            ORDER BY Fecha";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Tipo", tipo);
                comando.Parameters.AddWithValue("@FechaDesde", fechaDesde.Date);
                comando.Parameters.AddWithValue("@FechaHasta", fechaHasta.Date);

                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["Id"]);
                    decimal monto = Convert.ToDecimal(reader["Monto"]);
                    DateTime fecha = Convert.ToDateTime(reader["Fecha"]);
                    string motivo = reader["Motivo"].ToString();

                    Transaccion transaccion = tipo == "Ingreso"
                        ? new Ingreso(id, monto, fecha, motivo)
                        : new Gasto(id, monto, fecha, motivo);

                    lista.Add(transaccion);
                }
            }

            return lista;
        }


        public static List<Transaccion> FiltrarPorFechas(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Transaccion> lista = new List<Transaccion>();
            ConexionDatos conexionClase = new ConexionDatos();

            using (SqlConnection conexion = new SqlConnection(conexionClase.Conexion))
            {
                string consulta = @"
            SELECT Id, Monto, Fecha, Motivo, Tipo
            FROM Transaccion
            WHERE Fecha BETWEEN @FechaDesde AND @FechaHasta
            ORDER BY Fecha";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@FechaDesde", fechaDesde.Date);
                comando.Parameters.AddWithValue("@FechaHasta", fechaHasta.Date);

                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["Id"]);
                    decimal monto = Convert.ToDecimal(reader["Monto"]);
                    DateTime fecha = Convert.ToDateTime(reader["Fecha"]);
                    string motivo = reader["Motivo"].ToString();
                    string tipo = reader["Tipo"].ToString();

                    Transaccion transaccion = tipo == "Ingreso"
                        ? new Ingreso(id, monto, fecha, motivo)
                        : new Gasto(id, monto, fecha, motivo);

                    lista.Add(transaccion);
                }
            }

            return lista;
        }
    }
}
