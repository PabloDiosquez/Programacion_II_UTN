using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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

            CargarListaAlmacenada();
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

        private void CargarListaAlmacenada()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string pathDir = $@"{path}\ArchivosSuper";

            // Esta línea revisa si el directorio existe. En caso contrario, lo crea.
            if (!Directory.Exists(pathDir)) Directory.CreateDirectory(pathDir);

            try
            {
                string pathArchivo = Path.Combine(pathDir, "listaSuper.xml");

                if (File.Exists(pathArchivo))
                {
                    using (StreamReader sr = new StreamReader(pathArchivo))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<string>));

                        List<string>? listaSuper = xmlSerializer.Deserialize(sr) as List<string>;

                        if (listaSuper is not null)
                        {
                            this.lbx_ListaSuper.DataSource = listaSuper;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarMensajeError(ex);
            }
        }

        private void GuardarCambios()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string pathDir = Path.Combine(path, "ArchivosSuper");

            try
            {
                string pathArchivo = Path.Combine(pathDir, "listaSuper.xml");

                using (StreamWriter sw = new StreamWriter(pathArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<string>));

                    xmlSerializer.Serialize(sw, this.listaSuper);
                }
            }
            catch (Exception ex)
            {
                MostrarMensajeError(ex);    
            }
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

                GuardarCambios();
            }
        }

        private void EliminarObjeto() 
        {
            string? objeto = lbx_ListaSuper.SelectedItem as string;

            if (!string.IsNullOrEmpty(objeto))
            {
                this.listaSuper.Remove(objeto);

                RefrescarLista();

                GuardarCambios();
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

                GuardarCambios();
            }
            else
            {
                MessageBox.Show("Asegúrese de elegir un elemento de la lista 🤔", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);  ;
            }
        }

        public void MostrarMensajeError(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ocurrió un error al cargar el archivo XML");
            sb.AppendLine(ex.Message);
            sb.AppendLine(ex.StackTrace);

            MessageBox.Show(sb.ToString(), "Error al cargar el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
