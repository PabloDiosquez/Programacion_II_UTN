using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jugadores_UI
{
    public partial class Alta_jugador : Form
    {
        Jugador jugador;
        public Alta_jugador()
        {
            InitializeComponent();
        }

        private void Alta_jugador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            int.TryParse(txb_dni.Text, out int dni);

            string nombre = txb_nombre.Text;

            int.TryParse(txb_partidos_jugados.Text, out int partidosJugados);

            int.TryParse(txb_goles.Text, out int goles);

            if (partidosJugados == 0)
            {
                jugador = new Jugador(dni, nombre);
            }
            else
            {
                jugador = new Jugador(dni, nombre, partidosJugados, goles);
            }

            DialogResult = DialogResult.OK;
        }
    }
}
