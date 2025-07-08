using Capa_Presentacion;

namespace WinFormsApp1
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //funcion para que los demas form se abran en el panel central
        private void AbrirformHija(object FormHija)
        {
            if (this.PanelCentral.Controls.Count > 0)
                this.PanelCentral.Controls.RemoveAt(0);

            Form fh = FormHija as Form;
            if (fh != null)
            {
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.PanelCentral.Controls.Add(fh);
                this.PanelCentral.Tag = fh;
                fh.Show();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirformHija(new UltimasTrasacciones());
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            AbrirformHija(new RegistrarIngreso());
        }

        private void btnGasto_Click(object sender, EventArgs e)
        {
            AbrirformHija(new RegistrarGasto());
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            AbrirformHija (new FiltrarPorfecha());
        }

        
    }
}
