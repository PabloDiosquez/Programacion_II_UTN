using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_Ejercicio_I01;

namespace Vista_Ejercicio_I01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // TODO: Agregar validaciones a los métodos y ver cómo actualizar la lista de manera automática

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lbx_Personas.DataSource = PersonaDAO.Leer();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nud_Id.Text);

            string nombre = tbx_Nombre.Text;

            string apellido = tbx_Apellido.Text;

            PersonaDAO.Guardar(new Persona(id, nombre, apellido));

            MessageBox.Show("Persona agregada 💪🏼", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Leer_Click(object sender, EventArgs e)
        {
            this.lbx_Personas.DataSource = PersonaDAO.Leer();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Persona personaAntigua = (Persona)lbx_Personas.SelectedItem;

            int idNuevo = Convert.ToInt32(nud_Id.Text);

            string nombreNuevo = tbx_Nombre.Text;

            string apellidoNuevo = tbx_Apellido.Text;

            Persona personaNueva = new Persona(idNuevo, nombreNuevo, apellidoNuevo);

            PersonaDAO.Modificar(personaAntigua, personaNueva);

            MessageBox.Show("Persona modificada 🥴", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (this.lbx_Personas is not null)
            {
                PersonaDAO.Borrar((Persona)lbx_Personas.SelectedItem);

                MessageBox.Show("Persona eliminada 💥", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe elegir una persona de la lista!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
