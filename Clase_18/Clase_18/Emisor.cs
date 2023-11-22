using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_18
{
    public class Emisor
    {
        private List<Action> destinatarios = new List<Action>();

        public void AgregarDestinatario(Action destinatarioNuevo) 
        {
            if (destinatarioNuevo is not null) destinatarios.Add(destinatarioNuevo);
        }

        public void EmitirNotificacion()
        {
            foreach (Action delegadoDestinatario in destinatarios)
            {
                //delegadoDestinatario.Invoke();

                delegadoDestinatario();
            }
        }
    }
}
