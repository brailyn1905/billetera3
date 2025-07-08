using System;
using Microsoft.Data.SqlClient;


namespace billetera3

{
    public class ConexionDatos
    {
        // cadena de conexion a SQL SERVER 
        public string Conexion = "Server=.;Database= Billetera4;Integrated Security=true" + " ;TrustServerCertificate=True;";
    }
}
