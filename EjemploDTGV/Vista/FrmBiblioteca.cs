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
    public partial class FrmBiblioteca : Form
    {
        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefrescarBiblioteca();
        }

        private void RefrescarBiblioteca()
        {
            dtgvBiblioteca.DataSource = JuegoDAO.Leer();

            dtgvBiblioteca.Refresh();

            dtgvBiblioteca.Update();

        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FrmAlta alta = new FrmAlta();

            if (alta.ShowDialog() == DialogResult.OK)
            {
                RefrescarBiblioteca();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           
        }

    }
}
