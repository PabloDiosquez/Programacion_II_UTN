using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Ejericicio_I01
{
    /// <summary>
    /// Clase que hereda de la clase base Sobrescrito y proporciona implementaciones concretas para los miembros abstractos.
    /// </summary>
    public class SobreSobrescrito : Sobrescrito
    {
        /// <summary>
        /// Obtiene el valor del atributo miAtributo a través de la propiedad abstracta MiPropiedad.
        /// </summary>
        public override string MiPropiedad
        {
            get { return miAtributo; }
        }

        /// <summary>
        /// Implementación concreta del método abstracto MiMetodo.
        /// </summary>
        /// <returns>Un valor de tipo string que se obtiene a través de la propiedad MiPropiedad.</returns>
        public override string MiMetodo()
        {
            return MiPropiedad;
        }
    }
}
