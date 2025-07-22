using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArborBinario
{
    internal class ArbolBinarioBusqueda
    {
        public Nodo Raiz;

        #region Inserción

        public void Insertar(int valor)
        {
            Raiz = InsertarRecursivo(Raiz, valor);
        }

        private Nodo InsertarRecursivo(Nodo nodoActual, int valor)
        {
            if (nodoActual == null)
                return new Nodo(valor);

            if (valor < nodoActual.Valor)
                nodoActual.Izquierdo = InsertarRecursivo(nodoActual.Izquierdo, valor);
            else if (valor > nodoActual.Valor)
                nodoActual.Derecho = InsertarRecursivo(nodoActual.Derecho, valor);

            return nodoActual;
        }

        #endregion

        #region Dibujo del árbol

        public void DibujarArbol(Graphics g, Nodo nodo, int x, int y, int distanciaX, int distanciaY)
        {
            if (nodo == null) return;

            const int radio = 20;
            using Pen pen = new(Color.Black);
            using Brush nodoBrush = new SolidBrush(Color.LightBlue);
            using Brush textoBrush = new SolidBrush(Color.Black);
            using Font fuente = new("Arial", 10);

            // Dibuja nodo
            g.FillEllipse(nodoBrush, x - radio, y - radio, 2 * radio, 2 * radio);
            g.DrawEllipse(pen, x - radio, y - radio, 2 * radio, 2 * radio);
            g.DrawString(nodo.Valor.ToString(), fuente, textoBrush, x - 10, y - 10);

            // Dibuja hijos
            if (nodo.Izquierdo != null)
            {
                g.DrawLine(pen, x, y, x - distanciaX, y + distanciaY);
                DibujarArbol(g, nodo.Izquierdo, x - distanciaX, y + distanciaY, distanciaX / 2, distanciaY);
            }

            if (nodo.Derecho != null)
            {
                g.DrawLine(pen, x, y, x + distanciaX, y + distanciaY);
                DibujarArbol(g, nodo.Derecho, x + distanciaX, y + distanciaY, distanciaX / 2, distanciaY);
            }
        }

        #endregion

        #region Recorridos

        public List<int> ObtenerPreorden(Nodo nodo)
        {
            List<int> resultado = new();
            Preorden(nodo, resultado);
            return resultado;
        }

        private void Preorden(Nodo nodo, List<int> resultado)
        {
            if (nodo == null) return;
            resultado.Add(nodo.Valor);
            Preorden(nodo.Izquierdo, resultado);
            Preorden(nodo.Derecho, resultado);
        }

        public List<int> ObtenerInorden(Nodo nodo)
        {
            List<int> resultado = new();
            Inorden(nodo, resultado);
            return resultado;
        }

        private void Inorden(Nodo nodo, List<int> resultado)
        {
            if (nodo == null) return;
            Inorden(nodo.Izquierdo, resultado);
            resultado.Add(nodo.Valor);
            Inorden(nodo.Derecho, resultado);
        }

        public List<int> ObtenerPosorden(Nodo nodo)
        {
            List<int> resultado = new();
            Posorden(nodo, resultado);
            return resultado;
        }

        private void Posorden(Nodo nodo, List<int> resultado)
        {
            if (nodo == null) return;
            Posorden(nodo.Izquierdo, resultado);
            Posorden(nodo.Derecho, resultado);
            resultado.Add(nodo.Valor);
        }

        #endregion

        #region Dibujo de recorridos

        public void DibujarRecorrido(Graphics g, List<int> recorrido, int x, int y, int distanciaX, int panelWidth)
        {
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.LightBlue);
            Brush fontBrush = new SolidBrush(Color.Black);
            Font font = new Font("Arial", 7);
            int radio = 11;

            if (recorrido.Count == 0)
                return;

            // Ajustar distancia automática para centrar todo el recorrido en el panel
            distanciaX = Math.Min(60, (panelWidth - 2 * radio) / Math.Max(recorrido.Count, 1));

            for (int i = 0; i < recorrido.Count; i++)
            {
                int valor = recorrido[i];
                int posX = x + i * distanciaX + radio;

                g.FillEllipse(brush, posX - radio, y - radio, 2 * radio, 2 * radio);
                g.DrawEllipse(pen, posX - radio, y - radio, 2 * radio, 2 * radio);

                SizeF textoSize = g.MeasureString(valor.ToString(), font);
                g.DrawString(valor.ToString(), font, fontBrush, posX - textoSize.Width / 2, y - textoSize.Height / 2);
            }
        }

        #endregion
    }
}

