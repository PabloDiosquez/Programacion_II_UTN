using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_I02
{
    public partial class frmCalculador : Form
    {
        public frmCalculador()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si los campos de texto tbx_Kilometros y tbx_Litros están vacíos
                if (string.IsNullOrEmpty(tbx_Kilometros.Text) || string.IsNullOrEmpty(tbx_Litros.Text))
                {
                    // Lanza una excepción personalizada si uno o ambos campos están vacíos
                    string mensajeError = "¡Las casillas de texto no pueden estar vacías! Asegúrese de completarlas con números naturales";
                    throw new ParametrosVaciosException(mensajeError);
                }

                // Variables para almacenar los valores ingresados como kilómetros y litros
                int kilometros;
                int litros;

                // Intenta convertir el texto de los campos en números enteros
                if (!int.TryParse(tbx_Kilometros.Text, out kilometros) || !int.TryParse(tbx_Litros.Text, out litros))
                {
                    // Lanza una excepción de formato si los campos no contienen números válidos
                    throw new FormatException("Asegúrese de ingresar números naturales en los campos de texto!");
                }

                // Verifica si los números ingresados son positivos
                if (kilometros < 0 || litros < 0)
                {
                    // Lanza una excepción personalizada si los números son negativos
                    throw new NumerosNegativosException("¡Los números ingresados en los campos de texto deben ser enteros positivos!");
                }

                // Calcula el cociente y muestra el resultado en un control rtb_Consumo
                float cociente = Calculador.CalcularDivision(litros, kilometros);
                rtb_Consumo.Text = $"El consumo es: {(100 * cociente).ToString("0.00")} litros cada 100 kilómetros";
            }
            catch (DivideByZeroException ex)
            {
                // Captura la excepción DivideByZeroException y muestra un mensaje de error
                MessageBox.Show(ex.Message);
            }
            catch (ParametrosVaciosException ex)
            {
                // Captura la excepción ParametrosVaciosException y muestra un mensaje de error
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                // Captura la excepción FormatException y muestra un mensaje de error
                MessageBox.Show(ex.Message);
            }
            catch (NumerosNegativosException ex)
            {
                // Captura la excepción NumerosNegativosException y muestra un mensaje de error
                MessageBox.Show(ex.Message);
            }
        }
}
