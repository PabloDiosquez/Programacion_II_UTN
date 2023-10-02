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
    /// Clase para mostrar un formulario de saludo personalizado.
    /// </summary>
    public partial class Saludo : Form
    {
        // Atributos

        private string nombre;

        private string apellido;

        /// <summary>
        /// Constructor predeterminado de la clase Saludo.
        /// Inicializa los componentes del formulario.
        /// </summary>
        public Saludo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor de la clase Saludo que acepta un nombre y un apellido como parámetros.
        /// Inicializa los componentes del formulario y establece el nombre y el apellido.
        /// </summary>
        /// <param name="nombre">El nombre del usuario.</param>
        /// <param name="apellido">El apellido del usuario.</param>
        public Saludo(string nombre, string apellido) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        /// <summary>
        /// Maneja el evento Load del formulario Saludo.
        /// Muestra un mensaje de saludo personalizado en el formulario.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void Saludo_Load(object sender, EventArgs e)
        {
            this.lb_nombre.Text += $"Soy {nombre} {apellido} 🖖🏼";
        }

        /// <summary>
        /// Maneja el evento FormClosing del formulario Saludo.
        /// Cierra la aplicación cuando se cierra este formulario.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void Saludo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
