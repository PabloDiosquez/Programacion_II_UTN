using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_I02_Registrate
{

    public partial class Registro : Form
    {
        // Atributos

        Ingresante ingresante; // Almacena la información del ingresante

        // Constructor
        public Registro()
        {
            InitializeComponent();
        }

        // Método para obtener el objeto Ingresante
        public Ingresante GetIngresante()
        {
            return ingresante;
        }

        // Evento Load del formulario
        private void Registro_Load(object sender, EventArgs e)
        {
            // Carga de listBox con países
            List<string> paises = new List<string>
        {
            "Argentina",
            "Colombia",
            "Brasil",
            "Uruguay",
            "Venezuela",
        };

            this.lbx_pais.DataSource = paises;

            // Opción por defecto del radioButton
            rbt_masculino.Checked = true;
        }

        // Evento click del botón "Ingresar"
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string nombre = this.tbx_nombre.Text;
            string apellido = this.tbx_apellido.Text;
            int edad = (int)nud_edad.Value;
            string genero;

            // Determinar el género seleccionado en los RadioButtons
            if (rbt_masculino.Checked)
            {
                genero = rbt_masculino.Text;
            }
            else if (rbt_femenino.Checked)
            {
                genero = rbt_femenino.Text;
            }
            else if (rbt_no_binario.Checked)
            {
                genero = rbt_no_binario.Text;
            }
            else
            {
                genero = string.Empty;
            }

            string pais = lbx_pais.Text;
            string direccion = this.tbx_direccion.Text;
            List<string> cursos = new List<string>();

            // Comprobar y agregar cursos seleccionados
            if (cbx_csharp.Checked)
            {
                cursos.Add(cbx_csharp.Text);
            }
            if (cbx_python.Checked)
            {
                cursos.Add(cbx_python.Text);
            }
            if (cbx_javascript.Checked)
            {
                cursos.Add(cbx_javascript.Text);
            }

            // Validar que los campos obligatorios no estén vacíos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(direccion))
            {
                string error = "Error";

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Debe completar los siguientes campos solicitados:\n");

                if (string.IsNullOrEmpty(nombre))
                {
                    sb.AppendLine("Nombre");
                }

                if (string.IsNullOrEmpty(apellido))
                {
                    sb.AppendLine("Apellido");
                }

                if (string.IsNullOrEmpty(direccion))
                {
                    sb.AppendLine("Dirección");
                }

                // Mostrar mensaje de error
                MessageBox.Show(sb.ToString(), error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Crear un objeto Ingresante con la información
                ingresante = new Ingresante(nombre, apellido, edad, genero, pais, direccion, cursos);

                // Mostrar la información del ingresante en un MessageBox
                MessageBox.Show(this.GetIngresante().MostrarInfo());

                // Cerrar el formulario
                this.Close();
            }
        }
    }
}
