namespace Consolidado
{
    public partial class frmConsolidado : Form
    {
        
        public frmConsolidado()
        {
            InitializeComponent();

        }

        private void btnspa_Click(object sender, EventArgs e)
        {
            fase1.frmDatos frmDatos = new fase1.frmDatos();
            frmDatos.Show();
        }

        private void btnMelodias_Click(object sender, EventArgs e)
        {
            MelodiasPerfectas.frmDatos frmDatos = new MelodiasPerfectas.frmDatos();
            frmDatos.Show();
        }

        private void btnVidas_Click(object sender, EventArgs e)
        {
            SalvandoVidas.frmEstructuraDatos frmEstructuraDatos = new SalvandoVidas.frmEstructuraDatos();
            frmEstructuraDatos.Show();
        }

        private void btnArbol_Click(object sender, EventArgs e)
        {
            ArborBinario.frmArbolBinario frmArbolBinario = new ArborBinario.frmArbolBinario();
            frmArbolBinario.Show();
        }
    }
}
