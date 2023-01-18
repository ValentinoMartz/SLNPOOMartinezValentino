using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Data
{
    public class WindowsEFDatosContext : DbContext
    {
        public WindowsEFDatosContext() : base("KeyDB") { }
        public DbSet<Avion> Aviones { get; set; }
        public DbSet<LineaArea> LineasAreas { get; set; }
    }
}
