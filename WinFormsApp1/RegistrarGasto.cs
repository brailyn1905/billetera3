using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocios;

namespace Capa_Presentacion
{
    public partial class RegistrarGasto : Form
    {
        public RegistrarGasto()
        {
            InitializeComponent();
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

                // Crear la transacción de tipo Gasto
                Transaccion transaccion = new Gasto(0, monto, fecha, motivo); // Usa 0 si el ID lo genera la base de datos

                // Obtener el saldo actual desde la lógica
                decimal saldoActual = Transaccion.ObtenerSaldoActual();

                if (transaccion.ValidarSaldo(saldoActual))
                {
                    // Insertar la transacción en la base de datos
                    TransaccionDatos datos = new TransaccionDatos();
                    datos.InsertarTransaccion(transaccion);

                    MessageBox.Show("Gasto registrado exitosamente.");

                    
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente para registrar este gasto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el gasto: " + ex.Message);
            }

        }
    }
}
