using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI04_Biblioteca
{
    public class TorreDeControl
    {
        // Atributos 

        private List<IVolador> voladores;

        // Constructor

        public TorreDeControl() 
        {
            voladores = new List<IVolador>();   
        }

        // Métodos de instancia 

        public string VuelenTodos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("*** Lista de voladores ***");
            foreach (IVolador volador in voladores)
            {
                sb.AppendLine(volador.Volador());
            }
            return sb.ToString();
        }

        public bool AgregarVolador(IVolador volador)
        {
            if (volador is null) return false;

            this.voladores.Add(volador);    

            return true;
        }
    }
}
