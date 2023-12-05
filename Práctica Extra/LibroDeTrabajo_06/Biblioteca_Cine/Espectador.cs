using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum MetodoPago 
{
    Efectivo,
    Tarjeta,
    Cheque,
}

namespace Biblioteca_Cine
{
    public class Espectador : Persona
    {
        // Atributos 

        private MetodoPago metodoPago;

        // Constructores 

        public Espectador(string nombre, string apellido, MetodoPago metodoPago)
            : base(nombre, apellido)
        {
            this.metodoPago = metodoPago;
        }

        public Espectador(Espectador espectador)
            : this(espectador.Nombre, espectador.Apellido, espectador.MetodoPago)
        { }

        // Propiedades 

        public MetodoPago MetodoPago { get => this.metodoPago; set => this.metodoPago = value; }

        // Sobrescritura: método ToString()

        public override string ToString()
        {
            return $"[Nombre: {this.Nombre}, Apellido: {this.Apellido}, Método de pago: {this.MetodoPago}]";
        }
    }
}
