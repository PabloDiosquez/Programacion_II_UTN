using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Clase_7
{
    public partial class AltaJugador : Form
    {
        // Atributos
        private Jugador jugador;

        // Constructor
        public AltaJugador()
        {
            // Propósito: Inicializa una nueva instancia de la ventana de alta de jugador.
            // Precondiciones: Ninguna.
            InitializeComponent();
        }

        // Propiedades
        public Jugador Jugador
        {
            // Propósito: Obtener el objeto Jugador ingresado o modificado en la ventana de alta.
            // Precondiciones: La ventana de alta debe haberse completado y cerrado correctamente.
            get { return jugador; }
        }

        // Manejador de eventos para el botón "Agregar"
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            // Propósito: Manejar el evento de clic en el botón "Agregar" para crear un nuevo objeto Jugador.
            // Precondiciones: Ninguna.

            if (string.IsNullOrEmpty(tbx_apellido.Text) || string.IsNullOrEmpty(tbx_nombre.Text) || string.IsNullOrEmpty(tbx_equipo.Text))
            {
                string mensajeError = "Debe completar todos los campos solicitados.\nCampos a completar:\n";

                if (string.IsNullOrEmpty(tbx_apellido.Text))
                {
                    mensajeError += "Apellido\n";
                }

                if (string.IsNullOrEmpty(tbx_nombre.Text))
                {
                    mensajeError += "Nombre\n";
                }

                if (string.IsNullOrEmpty(tbx_equipo.Text))
                {
                    mensajeError += "Equipo\n";
                }

                // Propósito: Mostrar un mensaje de error si no se han completado los campos requeridos.
                // Precondiciones: Ninguna.
                MessageBox.Show(mensajeError, "Error 🥴", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Recopilar información del formulario
                string apellido = tbx_apellido.Text;
                string nombre = tbx_nombre.Text;
                Posicion posicion = (Posicion)cbx_posicion.SelectedItem;
                string equipo = tbx_equipo.Text;
                int numeroCamiseta = Convert.ToInt16(nud_camiseta.Value);

                // Crear un nuevo objeto Jugador con los datos proporcionados
                jugador = new Jugador(apellido, nombre);
                jugador.Posicion = posicion;
                jugador.Equipo = equipo;
                jugador.Camiseta = (short)numeroCamiseta;

                // Establecer el resultado de la ventana como "OK" para indicar que se completó con éxito.
                DialogResult = DialogResult.OK;
            }
        }

        // Manejador de eventos que se ejecuta cuando se carga la ventana de alta
        private void AltaJugador_Load(object sender, EventArgs e)
        {
            // Propósito: Inicializar la ventana de alta de jugador al cargarla.
            // Precondiciones: Ninguna.

            // Configurar la fuente de datos para el ComboBox de Posición a partir del enum "Posicion"
            cbx_posicion.DataSource = Enum.GetValues(typeof(Posicion));
        }

        // Manejador de eventos para el botón "Cancelar"
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            // Propósito: Manejar el evento de clic en el botón "Cancelar" para cerrar la ventana de alta sin guardar cambios.
            // Precondiciones: Ninguna.

            this.Close();
        }
    }
}
