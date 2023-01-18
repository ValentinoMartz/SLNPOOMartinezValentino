using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Data;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Dac
{
    public static class AbmLinea
    {
        public static WindowsEFDatosContext context = new WindowsEFDatosContext();

        public static int Insertar(LineaArea LineaArea)
        {
            context.LineasAreas.Add(LineaArea);

            return context.SaveChanges();
        }
    }
}
