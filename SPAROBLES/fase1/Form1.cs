using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fase1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            if(txtclave.Text == "")
            {
                MessageBox.Show("Digite la Clave");
            }
            else
            {
                if (txtclave.Text == "123")
                {
                    //se activa el siguiente formulario
                    MessageBox.Show("Contraseña Correcta");
                    frmDatos MiDatos = new frmDatos();
                    MiDatos.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Clave invalida");
                    txtclave.Clear();
                }
            }
            txtclave.Focus();
        }
    }
}
