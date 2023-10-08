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
    public partial class Bienvenida : Form
    {
        // Atributos 

        private List<Jugador> jugadores;

        public Bienvenida()
        {
            InitializeComponent();

            jugadores = new List<Jugador>();
        }

        // Getters 

        public List<Jugador> GetJugadores() 
        {
            return jugadores;
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AltaJugador frm_AltaJugador = new AltaJugador();
            
            frm_AltaJugador.ShowDialog();

            if (frm_AltaJugador.DialogResult is DialogResult.OK)
            {
                jugadores.Add(frm_AltaJugador.GetJugador());
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por usar la App! Vuelva pronto! ⚽");

            Application.Exit(); 
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("*** Jugadores ***");
            foreach (Jugador jugador in this.GetJugadores())
            {
                sb.AppendLine(jugador.ToString());
            }

            MessageBox.Show(sb.ToString()); 
        }
    }
}
