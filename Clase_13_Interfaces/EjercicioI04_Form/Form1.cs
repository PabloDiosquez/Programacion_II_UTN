using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjercicioI04_Biblioteca;

namespace EjercicioI04_Form
{
    public partial class frm_Volador : Form
    {
        public frm_Volador()
        {
            InitializeComponent();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            TorreDeControl torreDeControl = new TorreDeControl();

            torreDeControl.AgregarVolador(new Pato());
            torreDeControl.AgregarVolador(new Boing747());
            torreDeControl.AgregarVolador(new BuzzLightyear());

            this.rtb_voladores.Text = torreDeControl.VuelenTodos();
        }
    }
}
