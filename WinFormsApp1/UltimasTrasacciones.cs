using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocios;
using Microsoft.Data.SqlClient;

namespace Capa_Presentacion
{
    public partial class UltimasTrasacciones : Form
    {
        public UltimasTrasacciones()
        {
            InitializeComponent();
            Rellenar();
        }


        private void MostrarSaldoActual()
        {
            try
            {
                decimal saldo = Transaccion.ObtenerSaldoActual(); // o TransaccionDatos.ObtenerSaldoActual()
                textSaldoActual.Text = "Saldo actual: $" + saldo.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el saldo: " + ex.Message);
            }



        }
        public void Rellenar()
        {
            string consulta = "SELECT * FROM transaccion";

            using (SqlConnection Conexion = new SqlConnection("Server=.;Database=Billetera4;Integrated Security=true;TrustServerCertificate=True"))
            {
                Conexion.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, Conexion);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            textSaldoActual.Text = "Saldo actual: $" + Capa_Negocios.Transaccion.ObtenerSaldoActual().ToString("N2");

        }
    }
}
