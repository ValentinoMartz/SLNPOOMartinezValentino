using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos;
using WindowsEFDatos.Data;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Dac
{
    public static class AbmAvion
    {
        public static WindowsEFDatosContext context = new WindowsEFDatosContext();

        public static List<Avion> Listar()
        {
            return context.Aviones.ToList();
        }
        public static int Insertar(Avion Avion)
        {
            context.Aviones.Add(Avion);

            return context.SaveChanges();
        }
    }
}
