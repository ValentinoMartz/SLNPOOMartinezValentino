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
            CrearLineaArea();
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

        private static void CrearLineaArea()
        {
            LineaArea lineaAerea = new LineaArea()
            {
                Nombre = "American",
                FechaInicioActividades = DateTime.Now
            };
            AbmLinea.Insertar(lineaAerea);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion()
            {
                Capacidad = Convert.ToInt32(txtCapacidad.Text),
                Denominacion = txtDenominacion.Text,
                IdAvion = Convert.ToInt32(txtId.Text)
            };
            int encontrado = AbmAvion.Editar(avion);
            
            if (encontrado > 0)
            {
                MessageBox.Show($"Avion Editado");
                TraerAviones();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            int respuesta = AbmAvion.Delete(id);
            if (respuesta > 0)
            {
                MessageBox.Show($"Avion Eliminado");
                TraerAviones();
            }
        }

        private void btnTraerPorID_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            Avion avionEncontrado = AbmAvion.TraerUno(id);
            if (avionEncontrado != null)
            {
                MessageBox.Show($"Avion Encontrado: {avionEncontrado.Denominacion} - {avionEncontrado.Capacidad}");
                TraerAviones();
            }
        }


    }
}
