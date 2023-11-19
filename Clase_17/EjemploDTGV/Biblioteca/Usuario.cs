using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa un usuario en el sistema.
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// Obtiene el código único del usuario.
        /// </summary>
        public int CodigoUsuario { get; }

        /// <summary>
        /// Obtiene el nombre de usuario.
        /// </summary>
        public string UserName { get; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Usuario.
        /// </summary>
        /// <param name="userName">El nombre de usuario.</param>
        /// <param name="codigoUsuario">El código único del usuario.</param>
        public Usuario(string userName, int codigoUsuario)
        {
            this.UserName = userName;
            this.CodigoUsuario = codigoUsuario;
        }

        /// <summary>
        /// Retorna el nombre de usuario como representación de cadena.
        /// </summary>
        /// <returns>El nombre de usuario.</returns>
        public override string ToString()
        {
            return UserName;
        }
    }
}
