using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public abstract class Vehiculo
    {
        public Vehiculo(int ruedas, string modelo)
        {
            Ruedas = ruedas;
            Modelo = modelo;
        }
        public int Ruedas { get; set; }
        public string Modelo { get; set; }

        public virtual string Acelera()
        {
            return "Acelerando...";
        }

        public virtual string Frena()
        {
            return "Frenando...";
        }
        public virtual string Imprimir()
        {
            return $"Propiedades: \nRuedas: {Ruedas} \nModelo: {Modelo}\n";
        }
    }
}
