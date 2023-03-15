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

namespace Vista
{
    public partial class FrmAlta : Form
    {
        int codigoJuego;
        public FrmAlta(int codigoJuego) : this()
        {
            btnGuardar.Text = "Modificar";
            cmbUsuarios.Hide();
            lblUsuarios.Text = string.Empty;
            this.codigoJuego = codigoJuego; 
            nupPrecio.Maximum = 10000;
            PintarForm();
        }

        private void PintarForm()
        {
            Juego juego = JuegoDAO.LeerPorId(codigoJuego);

            txtNombre.Text = juego.Nombre;

            txtGenero.Text = juego.Genero;

            nupPrecio.Value = (decimal)juego.Precio;
        }
        public FrmAlta()
        {
            InitializeComponent();
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            cmbUsuarios.DataSource = UsuarioDAO.Leer();
        }

        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {
            if (btnGuardar.Text != "Modificar")
            {
                Juego juego = new Juego(txtNombre.Text, (float)nupPrecio.Value, txtGenero.Text,
                    ((Usuario)cmbUsuarios.SelectedItem).CodigoUsuario);

                JuegoDAO.Guardar(juego);
            }
            else
            {
                Juego juego = new Juego(txtNombre.Text, (float)nupPrecio.Value, txtGenero.Text,
                    ((Usuario)cmbUsuarios.SelectedItem).CodigoUsuario,codigoJuego);

                JuegoDAO.Modificar(juego);
            }
            
            DialogResult = DialogResult.OK;
        }
    }
}
