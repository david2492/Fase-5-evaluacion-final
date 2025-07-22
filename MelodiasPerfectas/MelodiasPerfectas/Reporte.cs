using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelodiasPerfectas
{
    public partial class Reporte : Form
    {
        public Reporte(GestionEstudiantes estudiante)
        {
            InitializeComponent();

            // Asignar los datos del estudiante a los TextBox del formulario Reporte
            txtFecha.Text = estudiante.FechaRegistro.ToString("dd/MM/yyyy");
            txtEstudiante.Text = estudiante.Nombre;
            txtCedula.Text = estudiante.Id.ToString();
            txtGenero.Text = estudiante.Genero;
            txtInstrumento.Text = estudiante.Instrumento;
            txtDias.Text = estudiante.NumeroClases.ToString();
            txtCosto.Text = estudiante.CostoClase.ToString("C");
            txtTotal.Text = estudiante.TotalPagar.ToString("C");
        }

        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Datos"].Show();

            // Cerrar el formulario Reporte
            this.Close();
        }
    }
}
