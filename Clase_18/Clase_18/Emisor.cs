using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
                Console.WriteLine("Notificación emitida!");

                Thread.Sleep(new Random().Next(1000, 3000));

                //delegadoDestinatario.Invoke();

                delegadoDestinatario();
            }
        }
    }
}
