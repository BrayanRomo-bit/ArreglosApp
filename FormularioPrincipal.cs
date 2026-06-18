using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionArreglos
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InicializarComponentes();
        }

        private void btnAnalizar_Click(object remitente, EventArgs e)
        {
            try
            {
                // Subtema 5.1: Arreglo Unidimensional para almacenar el valor numérico del mensaje
                string texto = txtMensaje.Text.ToUpper().Replace(" ", "");
                int[] mensajeNumerico = new int[texto.Length];

                for (int i = 0; i < texto.Length; i++)
                {
                    // Convertir letra a número (Ej: A=1, B=2...)
                    mensajeNumerico[i] = texto[i] - 64;
                }

                // Práctica Obligatoria - Algoritmo de Ordenamiento (Burbuja) para Análisis de Frecuencia
                // BUG 1: Error intencional en el ciclo interno que provoca IndexOutOfRangeException
                for (int i = 0; i < mensajeNumerico.Length - 1; i++)
                {
                    for (int j = 0; j <= mensajeNumerico.Length - 1; j++) // <-- BUG AQUI: debería ser j < mensajeNumerico.Length - 1 - i
                    {
                        if (mensajeNumerico[j] > mensajeNumerico[j + 1])
                        {
                            int temporal = mensajeNumerico[j];
                            mensajeNumerico[j] = mensajeNumerico[j + 1];
                            mensajeNumerico[j + 1] = temporal;
                        }
                    }
                }

                txtAnalisisFrecuencia.Text = string.Join("-", mensajeNumerico);
            }
            catch (Exception excepcion)
            {
                MessageBox.Show("Error en el análisis de frecuencia: " + excepcion.Message);
            }
        }

        private void btnDesencriptar_Click(object remitente, EventArgs e)
        {
            try
            {
                // Subtema 5.2: Arreglo Multidimensional para la Llave de Encriptación 3x3
                int[,] matrizLlave = new int[3, 3];

                matrizLlave[0, 0] = int.Parse(txtLlave11.Text); matrizLlave[0, 1] = int.Parse(txtLlave12.Text); matrizLlave[0, 2] = int.Parse(txtLlave13.Text);
                matrizLlave[1, 0] = int.Parse(txtLlave21.Text); matrizLlave[1, 1] = int.Parse(txtLlave22.Text); matrizLlave[1, 2] = int.Parse(txtLlave23.Text);
                matrizLlave[2, 0] = int.Parse(txtLlave31.Text); matrizLlave[2, 1] = int.Parse(txtLlave32.Text); matrizLlave[2, 2] = int.Parse(txtLlave33.Text);

                // Práctica Obligatoria - Resolución de Determinante
                // BUG 2: Error matemático intencional en el signo del segundo cofactor (es + en lugar de -)
                int determinante = matrizLlave[0, 0] * (matrizLlave[1, 1] * matrizLlave[2, 2] - matrizLlave[1, 2] * matrizLlave[2, 1])
                                 + matrizLlave[0, 1] * (matrizLlave[1, 0] * matrizLlave[2, 2] - matrizLlave[1, 2] * matrizLlave[2, 0]) // <-- BUG: Debería ser -
                                 + matrizLlave[0, 2] * (matrizLlave[1, 0] * matrizLlave[2, 1] - matrizLlave[1, 1] * matrizLlave[2, 0]);

                if (determinante == 0)
                {
                    MessageBox.Show("Error: La matriz llave no tiene inversa (Determinante es 0). Contraseña inválida.");
                }
                else
                {
                    lblResultadoDeterminante.Text = "Determinante: " + determinante.ToString() + " (Válida)";
                }
            }
            catch (Exception excepcion)
            {
                MessageBox.Show("Error en la matriz llave: " + excepcion.Message);
            }
        }
    }
}
