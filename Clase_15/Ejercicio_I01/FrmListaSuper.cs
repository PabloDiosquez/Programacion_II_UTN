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
            listaSuper = new List<string>();

            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion frmAlta = new FrmAltaModificacion("Agregar objeto", "Agregar");

            frmAlta.ShowDialog();

            if (frmAlta.DialogResult == DialogResult.OK) 
            {
                this.listaSuper.Add(frmAlta.Objeto);

                this.lbx_ListaSuper.Items.Add(frmAlta.Objeto);
            }

            this.lbx_ListaSuper.DataSource = listaSuper;    
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (this.lbx_ListaSuper.SelectedValue is not null)
            {
                listaSuper.Remove(this.lbx_ListaSuper.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Debe elegir un elemento a eliminar");
            }
        }

        private void FrmListaSuper_Load(object sender, EventArgs e)
        {
            
        }
    }
}
