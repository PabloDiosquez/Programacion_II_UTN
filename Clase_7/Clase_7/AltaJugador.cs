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
        public Jugador Jugador { get; }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

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
    }
}
