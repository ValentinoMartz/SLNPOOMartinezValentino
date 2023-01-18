using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class AutoElectrico : Vehiculo
    {
        public AutoElectrico(int ruedas, string modelo, int pasajeros, decimal duracionBateria) : base(ruedas, modelo)
        {
            Pasajeros = pasajeros;
            DuracionBateria = duracionBateria;   
        }

        public int Pasajeros { get; set; }
        public decimal DuracionBateria { get; set; }

        public override string Acelera()
        {
            return base.Acelera() + "Auto Electrico";
        }
        public override string Frena()
        {
            return base.Frena() + "Auto Electrico";
        }
        public override string Imprimir()
        {
            return base.Imprimir() + $"Pasajeros: {Pasajeros} \nDuracion de la bateria: {DuracionBateria}";
        }
    }
}
