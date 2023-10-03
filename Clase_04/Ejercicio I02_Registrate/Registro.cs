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
        public Registro()
        {
            InitializeComponent();
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
            };

            this.lbx_pais.DataSource = paises;  
        }
    }
}
