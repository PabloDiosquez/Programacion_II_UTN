using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atrapame_si_puedes_entidades;

namespace Atrapame_si_puedes
{
    public partial class frm_calculador : Form
    {
        public frm_calculador()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbx_kilometros.Text) || string.IsNullOrEmpty(tbx_litros.Text))
                {
                    throw new ParametrosVaciosException("Alguno de los campos está vacío");
                }

                int kilometros = int.Parse(tbx_kilometros.Text);

                int litros = int.Parse(tbx_litros.Text);

                rtb_contenedor.Text = $"km / litros = {Calculador.Calcular(kilometros, litros)}";

            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El formato de entrada no es el correcto");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por cero");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal 😢");
            }
        }
    }
}
