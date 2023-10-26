using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjercicioI03_Biblioteca;

namespace FormPrincipal
{
    /// <summary>
    /// Formulario principal de la aplicación.
    /// </summary>
    public partial class frm_Principal : Form
    {
        Imprimible contrato;
        Imprimible foto;
        Imprimible documento;
        Impresora impresora;

        /// <summary>
        /// Constructor del formulario principal.
        /// </summary>
        public frm_Principal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Imprimir".
        /// Crea objetos imprimibles, los agrega a la impresora y muestra el resultado en el cuadro de texto.
        /// </summary>
        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            // Crear objetos imprimibles
            contrato = new Contrato();
            foto = new Foto();
            documento = new Documento();

            // Inicializar la impresora
            impresora = new Impresora();

            // Agregar objetos imprimibles a la cola de impresión
            impresora.AgregarImprimible(contrato);
            impresora.AgregarImprimible(foto);
            impresora.AgregarImprimible(documento);

            // Imprimir todo y mostrar el resultado en el cuadro de texto
            rtx_Imprimir.Text = impresora.ImprimirTodo();
        }
    }
}
