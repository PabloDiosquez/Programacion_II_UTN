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
    public partial class frm_menu_principal : Form
    {
        List<Jugador> jugadores;
        public frm_menu_principal()
        {
            jugadores = new List<Jugador>();

            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Alta_jugador frm_alta_jugador = new Alta_jugador();

            frm_alta_jugador.ShowDialog();

            if (frm_alta_jugador.DialogResult == DialogResult.OK)
            {
                jugadores.Add(frm_alta_jugador.ObtenerJugador());

                rtb_datos.Text += $"{jugadores[jugadores.Count() - 1].MostrarDatos()}\n";

                MessageBox.Show("Jugador agregado con éxito!");
            }
            else if (frm_alta_jugador.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("Carga cancelada");
            }
        }

    }
}
