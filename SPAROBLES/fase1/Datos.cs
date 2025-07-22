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
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            string cadena;
            double precioBase = 0;
            string servicio = "";
            double descuento = 0;
            int estrato = 0;


            cadena = "Nombre: " + txtnombre.Text + "\nCedula: " + txtcedula.Text;
            cadena = cadena + "\nEstrato: " + cmbestrato.Text;
            cadena = cadena + "\nServicio: ";
            if (optcyc.Checked)
            {
                servicio = "Corte y cepillado";
                precioBase = 60000; 
            }
            else if (optccyu.Checked)
            {
                servicio = "Corte, cepillado y uñas";
                precioBase = 90000;
            }
            else if (optuac.Checked)
            {
                servicio = "Uñas en acrílico y cejas";
                precioBase = 100000;
            }
            else if (optumyc.Checked)
            {
                servicio = "Uñas en acrílico, maquillaje y cejas";
                precioBase = 140000;
            }

            cadena += servicio;
            cadena += "\nPrecio: $" + precioBase.ToString("N0");

            if (int.TryParse(cmbestrato.Text, out estrato ))
            {
                if(estrato <= 2)
                {
                    descuento = precioBase * 0.15;
                }
                else if (estrato >= 3 && estrato <= 4)
                {
                    descuento = precioBase * 0.10;
                }
                else if (estrato >= 5)
                {
                    descuento = precioBase * 0.05;
                }
            }

            cadena += "\nDescuento: $" + descuento.ToString("N0");
            cadena += "\nTotal a pagar: $" + (precioBase - descuento).ToString("N0");
            MessageBox.Show(cadena);
        }

        

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            Type tipoForm = Type.GetType("Consolidado.frmConsolidado, Consolidado");
            if (tipoForm != null)
            {
                Form formConsol = (Form)Activator.CreateInstance(tipoForm);

                this.Hide();

                formConsol.FormClosed += (s, args) =>
                {
                    this.Show();
                };

                formConsol.Show();
            }

        }
    }
}
