using System;
using System.Windows.Forms;

namespace SalvandoVidas
{
    public partial class Inicio : Form
    {
        private const string CLAVE_CORRECTA = "unad";
        private ErrorProvider error;

        public Inicio()
        {
            InitializeComponent();
            error = new ErrorProvider();

            // Eventos
            this.Load += Inicio_Load;
            btnSalir.Click += btnSalir_Click;
            tsmInicio.Click += tsmInicio_Click;
            tsmAcerca.Click += tsmAcerca_Click;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            txtContrase�a.Enabled = false;
            btnIngresar.Enabled = false;
            txtContrase�a.PasswordChar = '*';
        }

        private void tsmInicio_Click(object sender, EventArgs e)
        {
            txtContrase�a.Enabled = true;
            btnIngresar.Enabled = true;
            txtContrase�a.Focus();
        }

        private void tsmAcerca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estructuras de Datos \nJonathan David Rodriguez Tejada\nGrupo 301305A_2032", "Acerca de");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string clave = txtContrase�a.Text.Trim();

            if (clave == "")
            {
                error.SetError(txtContrase�a, "Se debe ingresar una contrase�a.");
            }
            else if (clave != CLAVE_CORRECTA)
            {
                error.SetError(txtContrase�a, "La contrase�a ingresada no es v�lida.");
            }
            else
            {
                error.SetError(txtContrase�a, null);
                frmEstructuraDatos formulario = new frmEstructuraDatos(); 
                formulario.Show();
                this.Hide();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
