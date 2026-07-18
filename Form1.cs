using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Veterinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModificarMascota_Click(object sender, EventArgs e)
        {
            FormModificar ventanaModificar = new FormModificar();
            ventanaModificar.MdiParent = this; 
            ventanaModificar.Show();
        }

        private void btnEliminarMascota_Click(object sender, EventArgs e)
        {
            FormEliminar ventanaEliminar = new FormEliminar();
            ventanaEliminar.MdiParent = this;
            ventanaEliminar.Show();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            FormServicios ventanaServicios = new FormServicios();
            ventanaServicios.MdiParent = this;
            ventanaServicios.Show();
        }
    }
}
