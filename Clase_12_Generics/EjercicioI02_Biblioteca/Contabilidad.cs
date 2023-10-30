using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI02_Biblioteca
{
    /// <summary>
    /// Clase genérica que representa el registro contable de una empresa. Maneja dos listas de documentos: egresos y ingresos.
    /// </summary>
    /// <typeparam name="T">El tipo de documentos para los egresos.</typeparam>
    /// <typeparam name="V">El tipo de documentos para los ingresos.</typeparam>
    public class Contabilidad<T, V>
        where T : Documento
        where V : Documento, new()
    {
        // Atributos

        /// <summary>
        /// Lista de documentos de egresos.
        /// </summary>
        private List<T> egresos;

        /// <summary>
        /// Lista de documentos de ingresos.
        /// </summary>
        private List<V> ingresos;

        // Constructor

        /// <summary>
        /// Inicializa una nueva instancia de la clase Contabilidad.
        /// </summary>
        public Contabilidad()
        {
            egresos = new List<T>();
            ingresos = new List<V>();
        }

        // Sobrecarga de operadores

        /// <summary>
        /// Agrega un documento de egreso a la contabilidad.
        /// </summary>
        /// <param name="contabilidad">La contabilidad a la que se agregará el documento de egreso.</param>
        /// <param name="egreso">El documento de egreso que se agregará.</param>
        /// <returns>True si el documento se agregó con éxito, de lo contrario, false.</returns>
        public static bool operator +(Contabilidad<T, V> contabilidad, T egreso)
        {
            if (contabilidad is null || egreso is null) return false;
            contabilidad.egresos.Add(egreso);
            return true;
        }

        /// <summary>
        /// Agrega un documento de ingreso a la contabilidad.
        /// </summary>
        /// <param name="contabilidad">La contabilidad a la que se agregará el documento de ingreso.</param>
        /// <param name="ingreso">El documento de ingreso que se agregará.</param>
        /// <returns>True si el documento se agregó con éxito, de lo contrario, false.</returns>
        public static bool operator +(Contabilidad<T, V> contabilidad, V ingreso)
        {
            if (contabilidad is null || ingreso is null) return false;
            contabilidad.ingresos.Add(ingreso);
            return true;
        }
    }
}
