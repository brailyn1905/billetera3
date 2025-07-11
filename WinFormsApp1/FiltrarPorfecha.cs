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

namespace Capa_Presentacion
{
    public partial class FiltrarPorfecha : Form
    {
        public FiltrarPorfecha()
        {
            InitializeComponent();
            InicializarControles();
        }

        private void InicializarControles()
        {
            comboBoxFiltro.Items.Clear();
            comboBoxFiltro.Items.Add("Todos");
            comboBoxFiltro.Items.Add("Ingreso");
            comboBoxFiltro.Items.Add("Gasto");
            comboBoxFiltro.SelectedIndex = 0;
            // Calcular el primer día del mes pasado
            DateTime primerDiaMesPasado = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-1);

            // Calcular el último día del mes pasado
            DateTime ultimoDiaMesPasado = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddDays(-1);

            // Establecer límites para dateTimePickerDesde
            dateTimePickerDesde.MinDate = primerDiaMesPasado;
            dateTimePickerDesde.MaxDate = DateTime.Today;
            dateTimePickerDesde.Value = primerDiaMesPasado;


            // Establecer límites para dateTimePickerHasta
            dateTimePickerHasta.MinDate = primerDiaMesPasado;
            dateTimePickerHasta.MaxDate = DateTime.Today;
            dateTimePickerHasta.Value = DateTime.Today;

            
        }

        private void CargarTransacciones()
        {
            List<Transaccion> lista;

            string tipo = comboBoxFiltro.SelectedItem.ToString();
            DateTime fechaDesde = dateTimePickerDesde.Value.Date;
            DateTime fechaHasta = dateTimePickerHasta.Value.Date;
            


            try
            {
                if (tipo == "Todos")
                {
                    
                    lista = Transaccion.FiltrarPorFechas(fechaDesde, fechaHasta);
                }
                else
                {
                    lista = Transaccion.FiltrarPorTipoYFechas(tipo, fechaDesde, fechaHasta);
                }

                // Preparar tabla para DataGridView
                var dt = new System.Data.DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Monto", typeof(decimal));
                dt.Columns.Add("Fecha", typeof(DateTime));
                dt.Columns.Add("Motivo", typeof(string));
                dt.Columns.Add("Tipo", typeof(string));

                foreach (var t in lista)
                {
                    dt.Rows.Add(t.Id, t.Monto, t.Fecha, t.Motivo, t.Tipo);
                }
                //se presenta los valores de la tabla en el datagridview para que en usuario lo vea 
                dataGridViewTransacciones.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar transacciones: " + ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarTransacciones();
        }
        
    }
}
