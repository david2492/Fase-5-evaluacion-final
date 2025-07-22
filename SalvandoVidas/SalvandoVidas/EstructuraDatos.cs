using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace SalvandoVidas
{
    public partial class frmEstructuraDatos : Form
    {
        // Data structures
        private Stack<EstructuraDatosUsuario> pilaUsuario = new Stack<EstructuraDatosUsuario>();
        private Queue<EstructuraDatosUsuario> colaUsuario = new Queue<EstructuraDatosUsuario>();
        private List<EstructuraDatosUsuario> listaUsuario = new List<EstructuraDatosUsuario>();

        // Report variables
        private int totalCopagosPila = 0;
        private int totalRegistrosCola = 0;
        private int sumaEdadesLista = 0;
        private int intReporteDatosPila = 0;
        private int intReporteDatosLista = 0;
        private int intReporteDatosCola = 0;

        public frmEstructuraDatos()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Initialize combo boxes
            cbITipoIdentificacion.Items.AddRange(new string[] { "CC", "CE", "NUIP", "PAS" });
            cbEstrato.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6" });
            cbTipoEstructura.Items.AddRange(new string[] { "Pila", "Cola", "Lista" });

            // Set default date
            dtFechaRegistro.Value = DateTime.Now;

            // Configure events
            cbEstrato.SelectedIndexChanged += (s, e) => CalcularCopago();
            rdMedicina.CheckedChanged += (s, e) => CalcularCopago();
            rdExamenes.CheckedChanged += (s, e) => CalcularCopago();

            // Disable buttons initially
            UpdateButtonStates();
        }

        private void UpdateButtonStates()
        {
            btnReportePila.Enabled = pilaUsuario.Count > 0;
            btnEliminarPila.Enabled = pilaUsuario.Count > 0;
            btnReporteCola.Enabled = colaUsuario.Count > 0;
            btnEliminarCola.Enabled = colaUsuario.Count > 0;
            btnReporteLista.Enabled = listaUsuario.Count > 0;
            btnEliminarLista.Enabled = listaUsuario.Count > 0;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                EstructuraDatosUsuario usuario = CrearUsuarioDesdeFormulario();

                switch (cbTipoEstructura.Text)
                {
                    case "Pila":
                        pilaUsuario.Push(usuario);
                        totalCopagosPila += int.Parse(usuario.strValorCopago);
                        dgPila.DataSource = null;
                        dgPila.DataSource = pilaUsuario.ToArray();
                        tabDatos.SelectedTab = tabPage1;
                        MessageBox.Show("Registro agregado a la pila!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Cola":
                        colaUsuario.Enqueue(usuario);
                        totalRegistrosCola++;
                        dgCola.DataSource = null;
                        dgCola.DataSource = colaUsuario.ToArray();
                        tabDatos.SelectedTab = tabPage2;
                        MessageBox.Show("Registro agregado a la cola!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Lista":
                        listaUsuario.Add(usuario);
                        sumaEdadesLista += int.Parse(usuario.strEdad);
                        dgLista.DataSource = null;
                        dgLista.DataSource = listaUsuario.ToArray();
                        tabDatos.SelectedTab = tabPage3;
                        MessageBox.Show("Registro agregado a la lista!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }

                UpdateButtonStates();
                LimpiarFormulario();
            }
        }

        private EstructuraDatosUsuario CrearUsuarioDesdeFormulario()
        {
            return new EstructuraDatosUsuario
            {
                strTipoId = cbITipoIdentificacion.Text,
                strNroId = txtIdentificacion.Text,
                strNombre = txtNombre.Text,
                strEdad = txtEdad.Text,
                strEstrato = cbEstrato.Text,
                strTipoAtencion = rdMedicina.Checked ? "Medicina general" : "Examen de laboratorio",
                strValorCopago = txtCopago.Text,
                strFechaRegistro = dtFechaRegistro.Value.ToString("yyyy-MM-dd")
            };
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrEmpty(cbITipoIdentificacion.Text))
            {
                MostrarError("Seleccione el tipo de identificación");
                return false;
            }

            if (string.IsNullOrEmpty(txtIdentificacion.Text))
            {
                MostrarError("Ingrese el número de identificación");
                return false;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MostrarError("Ingrese el nombre completo");
                return false;
            }

            if (string.IsNullOrEmpty(txtEdad.Text) || !int.TryParse(txtEdad.Text, out _))
            {
                MostrarError("Ingrese una edad válida");
                return false;
            }

            if (string.IsNullOrEmpty(cbEstrato.Text))
            {
                MostrarError("Seleccione el estrato socioeconómico");
                return false;
            }

            if (!rdMedicina.Checked && !rdExamenes.Checked)
            {
                MostrarError("Seleccione el tipo de atención");
                return false;
            }

            if (string.IsNullOrEmpty(cbTipoEstructura.Text))
            {
                MostrarError("Seleccione el tipo de estructura");
                return false;
            }

            return true;
        }

        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtCopago.Clear();
            rdMedicina.Checked = false;
            rdExamenes.Checked = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnReportePila_Click(object sender, EventArgs e)
        {
            txtReporteDatos.Text = $"Total copagos: ${totalCopagosPila}";
        }

        private void btnReporteCola_Click(object sender, EventArgs e)
        {
            txtReporteDatos.Text = $"Total registros: {totalRegistrosCola}";
        }

        private void btnReporteLista_Click(object sender, EventArgs e)
        {
            double promedio = listaUsuario.Count > 0 ? (double)sumaEdadesLista / listaUsuario.Count : 0;
            txtReporteDatos.Text = $"Edad promedio: {promedio:F1} años";
        }

        private void btnEliminarPila_Click(object sender, EventArgs e)
        {
            if (pilaUsuario.Count == 0)
            {
                MessageBox.Show("No hay registros en la pila", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Eliminar último registro de la pila?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var usuario = pilaUsuario.Pop();
                totalCopagosPila -= int.Parse(usuario.strValorCopago);
                dgPila.DataSource = pilaUsuario.ToArray();
                txtReporteDatos.Text = $"Total copagos: ${totalCopagosPila}";
                UpdateButtonStates();
            }
        }

        private void btnEliminarCola_Click(object sender, EventArgs e)
        {
            if (colaUsuario.Count == 0)
            {
                MessageBox.Show("No hay registros en la cola", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Eliminar primer registro de la cola?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var usuario = colaUsuario.Dequeue();
                totalRegistrosCola--;
                dgCola.DataSource = colaUsuario.ToArray();
                txtReporteDatos.Text = $"Total registros: {totalRegistrosCola}";
                UpdateButtonStates();
            }
        }

        private void btnEliminarLista_Click(object sender, EventArgs e)
        {
            if (listaUsuario.Count == 0)
            {
                MessageBox.Show("No hay registros en la lista", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string id = txtIdentificacion.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Ingrese una identificación para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var usuario = listaUsuario.Find(u => u.strNroId == id);
            if (usuario == null)
            {
                MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Eliminar este registro de la lista?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listaUsuario.Remove(usuario);
                sumaEdadesLista -= int.Parse(usuario.strEdad);
                dgLista.DataSource = listaUsuario.ToArray();

                if (listaUsuario.Count > 0)
                {
                    double promedio = (double)sumaEdadesLista / listaUsuario.Count;
                    txtReporteDatos.Text = $"Edad promedio: {promedio:F1} años";
                }
                else
                {
                    txtReporteDatos.Text = "0 años";
                }

                UpdateButtonStates();
            }
        }

        private void CalcularCopago()
        {
            if (string.IsNullOrEmpty(cbEstrato.Text) || (!rdMedicina.Checked && !rdExamenes.Checked))
            {
                txtCopago.Text = "0";
                return;
            }

            int estrato = int.Parse(cbEstrato.Text);
            int copago = 0;

            if (rdMedicina.Checked)
            {
                copago = estrato switch
                {
                    1 or 2 => 0,
                    3 => 10000,
                    4 => 15000,
                    5 => 20000,
                    6 => 30000,
                    _ => 0
                };
            }
            else if (rdExamenes.Checked)
            {
                copago = estrato switch
                {
                    1 or 2 or 3 => 0,
                    4 => 5000,
                    5 => 10000,
                    6 => 20000,
                    _ => 0
                };
            }

            txtCopago.Text = copago.ToString();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }



        private void btnReportePila_Click_1(object sender, EventArgs e)
        {
            if (pilaUsuario.Count == 0)
            {
                MessageBox.Show("No hay registros en la pila para generar reporte", "Información",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostrar el total de copagos con formato de moneda
            txtReporteDatos.Text = $"${totalCopagosPila:N0}";

            // Opcional: Seleccionar la pestaña de pila
            tabDatos.SelectedTab = tabPage1;
        }

        private void btnLimpiar_Click_2(object sender, EventArgs e)
        {
            cbITipoIdentificacion.Text = "";
            txtIdentificacion.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            cbEstrato.Text = "";
            rdMedicina.Checked = false;
            rdExamenes.Checked = false;
            txtCopago.Text = "";
            dtFechaRegistro.Value = DateTime.Now;
            cbTipoEstructura.Text = "";
            txtReporteDatos.Text = "";

            // Cargar valores en los campos de listas
            cbITipoIdentificacion.Items.Clear();
            cbEstrato.Items.Clear();
            cbTipoEstructura.Items.Clear();

            cbITipoIdentificacion.Items.Add("CC");
            cbITipoIdentificacion.Items.Add("CE");
            cbITipoIdentificacion.Items.Add("NUIP");
            cbITipoIdentificacion.Items.Add("PAS");

            cbEstrato.Items.Add("1");
            cbEstrato.Items.Add("2");
            cbEstrato.Items.Add("3");
            cbEstrato.Items.Add("4");
            cbEstrato.Items.Add("5");
            cbEstrato.Items.Add("6");

            cbTipoEstructura.Items.Add("Pila");
            cbTipoEstructura.Items.Add("Cola");
            cbTipoEstructura.Items.Add("Lista");

            cbITipoIdentificacion.Focus();
            ActiveControl = cbITipoIdentificacion;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnEliminarPila_Click_1(object sender, EventArgs e)
        {
            if (pilaUsuario.Count > 0)
            {
                if (MessageBox.Show("¿Desea eliminar el último registro de la pila?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    EstructuraDatosUsuario miEstructura = new EstructuraDatosUsuario();
                    miEstructura = pilaUsuario.Pop();
                    this.intReporteDatosPila = this.intReporteDatosPila - int.Parse(miEstructura.strValorCopago);
                    this.txtReporteDatos.Text = "$" + this.intReporteDatosPila.ToString();
                    dgPila.DataSource = pilaUsuario.ToArray();
                    MessageBox.Show("El último registro fue eliminado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Actualmente no hay registros en la pila", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.btnReportePila.Enabled = false;
                this.btnEliminarPila.Enabled = false;
            }
        }

        private void btnEliminarCola_Click_1(object sender, EventArgs e)
        {
            if (colaUsuario.Count > 0)
            {
                if (MessageBox.Show("¿Desea eliminar el primer registro de la cola?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    EstructuraDatosUsuario miEstructura = new EstructuraDatosUsuario();
                    miEstructura = colaUsuario.Dequeue();
                    this.intReporteDatosCola = this.intReporteDatosCola - 1;
                    this.txtReporteDatos.Text = this.intReporteDatosCola.ToString() + " registros";
                    dgCola.DataSource = colaUsuario.ToArray();
                    MessageBox.Show("El primer registro fue eliminado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Actualmente no hay registros en la cola", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.btnReporteCola.Enabled = false;
                this.btnEliminarCola.Enabled = false;
            }
        }

        private void btnEliminarLista_Click_1(object sender, EventArgs e)
        {
            if (listaUsuario.Count > 0)
            {

                string strIdUsuario = this.txtIdentificacion.Text.Trim();

                if (strIdUsuario.Equals(""))
                {
                    MessageBox.Show("La identificación del usuario no puede estar vacío para la eliminación", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtIdentificacion.Focus();
                }
                else
                {
                    EstructuraDatosUsuario miEstructura = obtenerUsuario(strIdUsuario);
                    if (miEstructura != null)
                    {
                        if (MessageBox.Show("¿Desea eliminar el registro de la lista?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {

                            this.listaUsuario.Remove(miEstructura);
                            this.intReporteDatosLista = this.intReporteDatosLista - int.Parse(miEstructura.strEdad);

                            if (listaUsuario.Count > 0)
                            {
                                this.txtReporteDatos.Text = (this.intReporteDatosLista / this.listaUsuario.Count).ToString() + " años";
                            }
                            else
                            {
                                this.txtReporteDatos.Text = "0 años";
                            }

                            dgLista.DataSource = this.listaUsuario.ToArray();
                            MessageBox.Show("El último registro fue eliminado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario con identificación " + strIdUsuario + " no existe en la lista", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.txtIdentificacion.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Actualmente no hay registros en la lista", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.btnReporteLista.Enabled = false;
                this.btnEliminarLista.Enabled = false;
            }
        }
        private EstructuraDatosUsuario obtenerUsuario(String strIdUsuario)
        {

            foreach (EstructuraDatosUsuario miEstructura in this.listaUsuario)
            {
                if (miEstructura.strNroId.Equals(strIdUsuario))
                {
                    return miEstructura;
                }
            }

            return null;
        }
    }
}