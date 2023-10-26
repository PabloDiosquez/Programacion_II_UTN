using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI02_Biblioteca
{
    public class GestionImpuestos
    {
        // Atributos 

        private List<IAduana> impuestosAduana;

        private List<IAfip> impuestosAfip;

        // Constructor 

        public GestionImpuestos()
        {
            impuestosAduana = new List<IAduana>();

            impuestosAfip = new List<IAfip>();  
        }

        // Métodos de instancia 

        public decimal CalcularTotalImpuestosAduana() 
        {
            if (this.impuestosAduana is null) throw new NullReferenceException();

            decimal totalImpuestosAduana = 0;   

            foreach (IAduana paqueteAduana in this.impuestosAduana)
            {
                totalImpuestosAduana += paqueteAduana.Impuestos;
            }
            return totalImpuestosAduana;
        }

        public decimal CalcularTotalImpuestosAfip() 
        {
            if(this.impuestosAfip is null) throw new NullReferenceException();

            decimal totalImpuestosAfip = 0;

            foreach (IAfip paqueteAfip in this.impuestosAfip)
            {
                totalImpuestosAfip += paqueteAfip.Impuestos;
            }
            return totalImpuestosAfip;
        }

        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes) 
        {
            foreach (Paquete paquete in paquetes)
            {
                this.impuestosAduana.Add(paquete);

                if (paquete is IAfip) this.impuestosAfip.Add(paquete as IAfip);
            }
        }

        public void RegistrarImpuestos(Paquete paquete)
        {
            this.impuestosAduana.Add(paquete);

            if(paquete is IAfip) this.impuestosAfip.Add(paquete as IAfip);
        }
    }
}
