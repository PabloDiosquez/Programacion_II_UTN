using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_I01
{
    public partial class FrmListaSuper : Form
    {
        List<string> listaSuper;
        public FrmListaSuper()
        {
            InitializeComponent();

            listaSuper = new List<string>();
        }

        private void FrmListaSuper_Load(object sender, EventArgs e)
        {
            SetToolTip();
            //CargarListaAlmacenada();
            //RefrescarLista();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion frmAlta = new FrmAltaModificacion("Agregar objeto", string.Empty, "Agregar");

            frmAlta.ShowDialog();

            if (frmAlta.DialogResult == DialogResult.OK) 
            {
                this.listaSuper.Add(frmAlta.Objeto);

                RefrescarLista();
            }   
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            string? objetoSeleccionado = this.lbx_ListaSuper.SelectedItem as string;

            if (objetoSeleccionado is not null)
            {
                this.listaSuper.Remove(objetoSeleccionado);

                RefrescarLista();
            }
            else
            {
                MessageBox.Show("Debe elegir un elemento de la lista", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Métodos auxiliares 

        private void SetToolTip()
        {
            this.toolTip.SetToolTip(this.btn_Agregar, "Agregar objeto");

            this.toolTip.SetToolTip(this.btn_Eliminar, "Eliminar objeto");

            this.toolTip.SetToolTip(this.btn_Modificar, "Modificar objeto");
        }

        private void CargarListaAlmacenada()
        {
             
        }

        private void RefrescarLista()
        {
            this.lbx_ListaSuper.DataSource = null;

            this.lbx_ListaSuper.DataSource = listaSuper;
        }
    }
}
