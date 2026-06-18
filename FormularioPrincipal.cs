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
            
            // Pre-llenar la matriz con una llave válida por defecto para guiar al usuario
            txtLlave11.Text = "1"; txtLlave12.Text = "2"; txtLlave13.Text = "3";
            txtLlave21.Text = "0"; txtLlave22.Text = "1"; txtLlave23.Text = "4";
            txtLlave31.Text = "5"; txtLlave32.Text = "6"; txtLlave33.Text = "0";
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
                // CORRECCIÓN: El límite del ciclo interno fue corregido para evitar IndexOutOfRangeException y ser más eficiente
                for (int i = 0; i < mensajeNumerico.Length - 1; i++)
                {
                    for (int j = 0; j < mensajeNumerico.Length - 1 - i; j++) // <-- CORREGIDO
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
                // CORRECCIÓN: Se corrigió la fórmula matemática (signo del cofactor central es negativo)
                int determinante = matrizLlave[0, 0] * (matrizLlave[1, 1] * matrizLlave[2, 2] - matrizLlave[1, 2] * matrizLlave[2, 1])
                                 - matrizLlave[0, 1] * (matrizLlave[1, 0] * matrizLlave[2, 2] - matrizLlave[1, 2] * matrizLlave[2, 0]) // <-- CORREGIDO
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
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa ÚNICAMENTE números enteros en todas las casillas de la matriz. Las letras o símbolos no son válidos.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception excepcion)
            {
                MessageBox.Show("Error inesperado en la matriz llave: " + excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
