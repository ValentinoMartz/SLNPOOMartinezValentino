using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibTransportes;
using LibTransportes.Models;

namespace PresentacionVehiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCamion_Click(object sender, EventArgs e)
        {
            ///int ruedas, string modelo, bool trailer, decimal largo
            Camion camion = new Camion(8,"Mercedes Benz", true, 350);
            MessageBox.Show($"Camion creado!\n {camion.Imprimir()}");
        }

        private void btnRemolque_Click(object sender, EventArgs e)
        {
            Remolque remolque = new Remolque();
            MessageBox.Show("Remolque creado");
        }
    }
}
