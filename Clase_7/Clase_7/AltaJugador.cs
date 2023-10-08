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
        public AltaJugador()
        {
            InitializeComponent();
        }

        // Properties 
        public Jugador GetJugador() 
        {
            return jugador;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
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

                MessageBox.Show(mensajeError, "Error 🥴", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string apellido = tbx_apellido.Text;

                string nombre = tbx_nombre.Text;

                Posicion posicion = (Posicion)cbx_posicion.SelectedItem;

                string equipo = tbx_equipo.Text;

                int numeroCamiseta = Convert.ToInt16(nud_camiseta.Value);

                jugador = new Jugador(apellido, nombre);

                jugador.Posicion = posicion;

                jugador.Equipo = equipo;

                jugador.Camiseta = (short)numeroCamiseta;

                DialogResult = DialogResult.OK;
            }
        }

        private void AltaJugador_Load(object sender, EventArgs e)
        {
            List<Posicion> posiciones = new List<Posicion>() 
            {
                Posicion.Arquero,
                Posicion.Defensor,
                Posicion.Mediocampista,
                Posicion.Delantero
            };

            cbx_posicion.DataSource = posiciones;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
