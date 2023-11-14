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

            AgregarObjeto(frmAlta);   
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            EliminarObjeto();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion frmAlta = new FrmAltaModificacion("Modificar objeto", string.Empty, "Modicar");

            ModificarObjeto(frmAlta);
        }

        // Métodos auxiliares 

        private void SetToolTip()
        {
            this.toolTip.SetToolTip(this.btn_Agregar, "Agregar objeto");

            this.toolTip.SetToolTip(this.btn_Eliminar, "Eliminar objeto");

            this.toolTip.SetToolTip(this.btn_Modificar, "Modificar objeto");
        }

        // TODO 1: Empezar por acá... 
        private void CargarListaAlmacenada()
        {
             
        }

        private void RefrescarLista()
        {
            this.lbx_ListaSuper.DataSource = null;

            this.lbx_ListaSuper.DataSource = listaSuper;
        }

        private void AgregarObjeto(FrmAltaModificacion frmAlta)
        {
            frmAlta.ShowDialog();

            if (frmAlta.DialogResult == DialogResult.OK)
            {
                this.listaSuper.Add(frmAlta.Objeto);

                RefrescarLista();
            }
        }

        private void EliminarObjeto() 
        {
            string? objeto = lbx_ListaSuper.SelectedItem as string;

            if (!string.IsNullOrEmpty(objeto))
            {
                this.listaSuper.Remove(objeto);

                RefrescarLista();
            }
            else 
            {
                MessageBox.Show("Asegúrese de elegir un elemento de la lista", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ModificarObjeto(FrmAltaModificacion frmAlta) 
        {
            frmAlta.ShowDialog();

            string? objeto = lbx_ListaSuper.SelectedItem as string;

            if (!string.IsNullOrEmpty(objeto))
            {
                int indice = listaSuper.IndexOf(objeto);    

                this.listaSuper[indice] = frmAlta.Objeto;

                RefrescarLista();
            }
            else
            {
                MessageBox.Show("Asegúrese de elegir un elemento de la lista 🤔", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);  ;
            }
        }
    }
}
