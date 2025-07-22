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
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

                

        GestionEstudiantes estudiante;
        private void cmbInstrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string instrumento = cmbInstrumento.SelectedItem.ToString().Trim();

            if (instrumento.Equals("Piano", StringComparison.OrdinalIgnoreCase))
                txbClase.Text = "100000";
            else if (instrumento.Equals("Guitarra", StringComparison.OrdinalIgnoreCase))
                txbClase.Text = "80000";
            else if (instrumento.Equals("Violín", StringComparison.OrdinalIgnoreCase)) // Asegúrate de que tenga tilde en el ComboBox
                txbClase.Text = "90000";
            else if (instrumento.Equals("Batería", StringComparison.OrdinalIgnoreCase))
                txbClase.Text = "85000";
            else if (instrumento.Equals("Canto", StringComparison.OrdinalIgnoreCase))
                txbClase.Text = "95000";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbId.Text) ||
                string.IsNullOrWhiteSpace(txbNombre.Text) ||
                cmbInstrumento.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txbNClase.Text))
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios.");
                return;
            }

            if (!ckbMasculino.Checked && !ckbFemenino.Checked)
            {
                MessageBox.Show("Por favor seleccione un género.");
                return;
            }

            // Obtener género
            string genero = ckbMasculino.Checked ? "Masculino" : "Femenino";

            // Crear instancia y guardar los datos
            estudiante = new GestionEstudiantes
            {
                Id = int.Parse(txbId.Text),
                Nombre = txbNombre.Text,
                Instrumento = cmbInstrumento.SelectedItem.ToString(),
                Genero = genero,
                CostoClase = decimal.Parse(txbClase.Text),
                NumeroClases = int.Parse(txbNClase.Text)
            };

            MessageBox.Show("Registro guardado correctamente.");
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (estudiante == null)
            {
                MessageBox.Show("Primero debe guardar los datos del estudiante.");
                return;
            }

            // Mostrar formulario Reporte con los datos
            Reporte ventanaReporte = new Reporte(estudiante);
            ventanaReporte.Show();
            this.Hide(); // Oculta la ventana actual si es necesario
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void ckbMasculino_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ckbMasculino.Checked)
                ckbFemenino.Checked = false;
        }

        private void ckbFemenino_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFemenino.Checked)
                ckbMasculino.Checked = false;
        }

        private void btnAtras_Click(object sender, EventArgs e)
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
