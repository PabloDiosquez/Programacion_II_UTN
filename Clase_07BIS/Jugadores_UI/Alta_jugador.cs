using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Jugadores_UI
{
    public partial class Alta_jugador : Form
    {

        Jugador jugador;
        public Alta_jugador()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = txb_Nombre.Text;

            EPosicion posSeleccionada = (EPosicion)cbx_posicion.SelectedItem;

            int.TryParse(txb_camiseta.Text, out int camiseta);

            int.TryParse(txb_edad.Text, out int edad);

            string nacionalidad = txb_nacionalidad.Text;

            jugador = new Jugador(nombre, posSeleccionada, camiseta, edad, nacionalidad);

            DialogResult = DialogResult.OK;

            MessageBox.Show("Jugador agregado con éxito ⚽");
        }

        public Jugador Jugador
        {
            get { return jugador; }
        }

        private void Alta_jugador_Load(object sender, EventArgs e)
        {
            cbx_posicion.DataSource = Enum.GetValues(typeof(EPosicion));
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            MessageBox.Show("Carga cancelada");
        }
    }
}
