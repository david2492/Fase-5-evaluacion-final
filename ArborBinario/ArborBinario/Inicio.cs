using System.Globalization;

namespace ArborBinario
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            MostrarFechaActual();
        }

        private void MostrarFechaActual()
        {
            // Crear label para mostrar la fecha
            Label lblFecha = new Label();
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(5, 8);

            // Formatear la fecha actual
            CultureInfo cultura = new CultureInfo("es-ES");
            string fechaFormateada = DateTime.Now.ToString("dddd, dd 'de' MMMM yyyy", cultura);
            fechaFormateada = char.ToUpper(fechaFormateada[0]) + fechaFormateada.Substring(1);

            lblFecha.Text = fechaFormateada;

            // Agregar label al panel
            pnlFecha.Controls.Add(lblFecha);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "unad")
            {
                MessageBox.Show("¡Bienvenido al Árbol Binario!", "Acceso correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                this.Hide();
                var formularioArbol = new frmArbolBinario(); 
                formularioArbol.FormClosed += (s, args) => this.Close(); 
                formularioArbol.Show();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Clear();
                txtContraseña.Focus();
            }
        }
    }
}
