using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_I01
{
    /// <summary>
    /// Esta es la clase principal para el formulario de ingreso de datos.
    /// Permite al usuario ingresar su nombre y apellido para saludar.
    /// </summary>
    public partial class Ingreso_Datos : Form
    {
        /// <summary>
        /// Constructor de la clase Ingreso_Datos.
        /// Inicializa los componentes del formulario.
        /// </summary>
        public Ingreso_Datos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Maneja el evento click en el botón "Saludar".
        /// Crea una instancia del formulario de saludo y muestra un saludo personalizado si se ingresan valores válidos.
        /// Oculta este formulario si se muestra el saludo.
        /// Muestra un mensaje de error si no se ingresan valores válidos.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void btn_saludar_Click(object sender, EventArgs e)
        {
            string nombre = this.tbx_nombre.Text;
            string apellido = this.tbx_apellido.Text;
            string materiaFavorita = cb_materias.SelectedItem.ToString();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                string mensajeError = "Se deben completar los siguientes campos solicitados\n\n";

                if (string.IsNullOrEmpty(nombre)) 
                {
                    mensajeError += "Nombre\n";
                }

                if (string.IsNullOrEmpty(apellido)) 
                {
                    mensajeError += "Apellido\n";
                }

                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Saludo frm_saludo = new Saludo(nombre, apellido, materiaFavorita);
                frm_saludo.Show();
                this.Hide();
            }
        }

        /// <summary>
        /// Maneja el evento de carga del formulario Ingreso_Datos.
        /// Carga las materias disponibles en un ComboBox y selecciona la primera por defecto.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento de carga.</param>
        private void Ingreso_Datos_Load(object sender, EventArgs e)
        {
            // Agregar las materias al ComboBox
            this.cb_materias.Items.Add("Programación II");
            this.cb_materias.Items.Add("Matemática I");
            this.cb_materias.Items.Add("Bases de Datos");
            this.cb_materias.Items.Add("Estadística");

            // Seleccionar la primera materia por defecto
            this.cb_materias.SelectedItem = this.cb_materias.Items[0];
        }
    }
}
