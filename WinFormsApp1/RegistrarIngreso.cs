using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocios;
using Capa_Negocios;

namespace Capa_Presentacion
{
    public partial class RegistrarIngreso : Form
    {
        public RegistrarIngreso()
        {
            InitializeComponent();
            dateTimefecha.MaxDate = DateTime.Today;

            // Fecha mínima: primer día del mes pasado
            DateTime primerDiaMesPasado = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-1);
            dateTimefecha.MinDate = primerDiaMesPasado;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar monto
                if (!decimal.TryParse(textmonto.Text, out decimal monto))
                {
                    MessageBox.Show("El monto ingresado no es válido. Por favor, ingresa un número.");
                    return;
                }

                // Validar fecha
                if (!DateTime.TryParse(dateTimefecha.Text, out DateTime fecha))
                {
                    MessageBox.Show("La fecha ingresada no es válida. Usa un formato correcto (dd/mm/aaaa).");
                    return;
                }

                // Validar motivo (solo letras y espacios)
                string motivo = textmotivo.Text.Trim();
                if (string.IsNullOrEmpty(motivo) || !Regex.IsMatch(motivo, @"^[a-zA-ZáéíóúÁÉÍÓÚüÜñÑ\s]+$"))
                {
                    MessageBox.Show("El motivo solo debe contener letras y espacios. No se permiten números ni símbolos.");
                    return;
                }

                // Crear la transacción (ejemplo: ingreso)
                Transaccion transaccion = new Ingreso(0, monto, fecha, motivo);

                // Obtener el saldo actual desde la clase lógica
                decimal saldoActual = Transaccion.ObtenerSaldoActual();

                if (transaccion.ValidarSaldo(saldoActual))
                {
                    // Insertar en la base de datos
                    TransaccionDatos datos = new TransaccionDatos();
                    datos.InsertarTransaccion(transaccion);

                    MessageBox.Show("Transacción registrada exitosamente.");

            
     
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente para registrar la transacción.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la transacción: " + ex.Message);
            }


            
        }
    }
}
