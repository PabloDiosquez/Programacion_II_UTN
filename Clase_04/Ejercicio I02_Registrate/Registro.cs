using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_I02_Registrate
{
    public partial class Registro : Form
    {
        // Atributos

        Ingresante ingresante; 
        public Registro()
        {
            InitializeComponent();
        }

        public Ingresante GetIngresante()
        {
            return ingresante;
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            // Carga de listBox
            List<string> paises = new List<string> 
            {
                "Argentina",
                "Colombia", 
                "Brasil",
                "Uruguay",
                "Venezuela",
            };

            this.lbx_pais.DataSource = paises;  
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string nombre   = this.tbx_nombre.Text;

            string apellido = this.tbx_apellido.Text;

            int edad         = (int)nud_edad.Value;

            string genero;

            if (rbt_masculino.Checked)
            {
                genero = rbt_masculino.Text;
            }
            else if (rbt_femenino.Checked)
            {
                genero = rbt_femenino.Text;
            }
            else if (rbt_no_binario.Checked)
            {
                genero = rbt_no_binario.Text;
            }
            else
            {
                genero = "";
            }

            string pais = lbx_pais.Text;    

            string direccion = this.tbx_direccion.Text;

            List<string> cursos = new List<string>();

            if (cbx_csharp.Checked)
            {
                cursos.Add(cbx_csharp.Text);
            }
            else if (cbx_python.Checked)
            {
                cursos.Add(cbx_python.Text);
            }
            else if (cbx_javascript.Checked)
            {
                cursos.Add(cbx_javascript.Text);
            }

            ingresante = new Ingresante(nombre, apellido, edad, genero, pais, direccion, cursos);

            MessageBox.Show(this.GetIngresante().MostrarInfo());

        }
    }
}
