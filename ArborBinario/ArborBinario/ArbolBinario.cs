using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArborBinario;
using Consolidado;

namespace ArborBinario
{
    public partial class frmArbolBinario : Form
    {
        private ArbolBinarioBusqueda arbol = new ArbolBinarioBusqueda();

        public frmArbolBinario()
        {
            InitializeComponent();
            btnAgregar.Click += btnAgregar_Click;
            AsociarEventosPaint();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string texto = txtEntero.Text.Trim();

            // Si el campo está vacío, simplemente salimos sin hacer nada
            if (string.IsNullOrEmpty(texto))
            {
                txtEntero.Focus();
                return;
            }

            // Intentar convertir el texto a número
            if (int.TryParse(texto, out int valor))
            {
                arbol.Insertar(valor);

                // Redibujar paneles
                pnlArbol.Invalidate();
                pnlPreorden.Invalidate();
                PnlInorden.Invalidate();
                pnlPosorden.Invalidate();

                txtEntero.Clear();
                txtEntero.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEntero.SelectAll();
                txtEntero.Focus();
            }
        }

        private void pnlArbol_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            if (arbol.Raiz != null)
                arbol.DibujarArbol(e.Graphics, arbol.Raiz, pnlArbol.Width / 2, 20, 80, 50);
        }

        private void pnlPreorden_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            var preorden = arbol.ObtenerPreorden(arbol.Raiz);
            arbol.DibujarRecorrido(e.Graphics, preorden, 0, 15, 0, pnlPreorden.Width);
        }

        private void PnlInorden_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            var inorden = arbol.ObtenerInorden(arbol.Raiz);
            arbol.DibujarRecorrido(e.Graphics, inorden, 0, 15, 0, PnlInorden.Width);
        }

        private void pnlPosorden_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            var posorden = arbol.ObtenerPosorden(arbol.Raiz);
            arbol.DibujarRecorrido(e.Graphics, posorden, 0, 15, 0, pnlPosorden.Width);
        }

        private void AsociarEventosPaint()
        {
            pnlArbol.Paint += pnlArbol_Paint;
            pnlPreorden.Paint += pnlPreorden_Paint;
            PnlInorden.Paint += PnlInorden_Paint;
            pnlPosorden.Paint += pnlPosorden_Paint;
        }


        private void btnAtras_Click(object sender, EventArgs e)
        {
            Consolidado.frmConsolidado frmConsolidado = new Consolidado.frmConsolidado();
            frmConsolidado.Show();
        }
    }
}
