using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFDatos.Dac;
using WindowsEFDatos.Models;

namespace WindowsEFDatos
{
    public partial class FrmAvion : Form
    {
        public FrmAvion()
        {
            InitializeComponent();
        }

        private void FrmAvion_Load(object sender, EventArgs e)
        {
            TraerAviones();
        }



        private void btnCrearAvion_Click(object sender, EventArgs e)
        {
            //se harcodea la linea area desde SQL server para que no tire errores
            Avion avion = new Avion()
            {
                Capacidad = 250,
                Denominacion = "Comercial",
                IdLinea = 1
            };
            int creado = AbmAvion.Insertar(avion);
            if (creado > 0)
            {
                MessageBox.Show($"Avion creado");
                TraerAviones();
            }
        }
        private void TraerAviones()
        {
            gridAviones.DataSource = AbmAvion.Listar();
        }
    }
}
