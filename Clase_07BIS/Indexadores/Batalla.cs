using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    internal class Batalla
    {
        List<Personaje> personajes;
        public Batalla()
        {
            personajes = new List<Personaje>();
           
        }
        public void AgregarPersonaje(Personaje personaje) 
        {
            personajes.Add(personaje);
        }

        // Propiedad indexada

        public Personaje this[int indice]
        {
            get
            {
                if (indice >= 0 && indice < personajes.Count())
                {
                    return personajes[indice];
                }

                return null;
            }

            set 
            {
                personajes[indice] = value;
            }
        }

        public Personaje this[string nombre] 
        {
            get 
            {
                foreach (Personaje personaje in personajes) 
                {
                    if (personaje.Nombre == nombre)
                    {
                        return personaje;
                    }
                }

                return null;
            }
        }

    }
}
