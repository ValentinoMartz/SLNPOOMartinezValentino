using LibTransportes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class Camion : Vehiculo
    {
        public Camion(int ruedas, string modelo, bool trailer, decimal largo) : base(ruedas, modelo)
        {
            Trailer= trailer;
            Largo= largo;   
        }

        public bool Trailer { get; set; }
        public decimal Largo { get; set; }
        public Remolque Remolque { get; set; }

        public Remolque QuitarRemolque() {
           return this.Remolque = null;
        }

        public override string Acelera()
        {
            return base.Acelera() + "Camion";
        }
        public override string Frena()
        {
            return base.Frena() + "Camion";
        }
        public override string Imprimir()
        {
            return base.Imprimir() + $"Trailer: {(Trailer? "Si" : "No")} \nLargo: {Largo}";
        }
    }
}
