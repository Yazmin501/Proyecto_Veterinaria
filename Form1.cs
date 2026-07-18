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
        private FormModificar ventanaModificar = null;
        private FormEliminar ventanaEliminar = null;
        private FormServicios ventanaServicios = null;
        private FormCargarArchivo ventanaCargarArchivo = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModificarMascota_Click(object sender, EventArgs e)
        {
            if(ventanaModificar == null || ventanaModificar.IsDisposed)
            {
                ventanaModificar = new FormModificar();
                ventanaModificar.MdiParent = this;
                ventanaModificar.Show();
            }
            else
            {
                ventanaModificar.BringToFront();
            }
        }

        private void btnEliminarMascota_Click(object sender, EventArgs e)
        {
            if(ventanaEliminar == null || ventanaEliminar.IsDisposed)
            {
                ventanaEliminar = new FormEliminar();
                ventanaEliminar.MdiParent = this;
                ventanaEliminar.Show();
            }
            else
            {
                ventanaEliminar.BringToFront();
            }
           
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
           if(ventanaServicios == null || ventanaServicios.IsDisposed)
            {
                ventanaServicios = new FormServicios();
                ventanaServicios.MdiParent = this;
                ventanaServicios.Show();
            }
            else
            {
                ventanaServicios.BringToFront();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            if (ventanaCargarArchivo == null || ventanaCargarArchivo.IsDisposed)
            {
                ventanaCargarArchivo = new FormCargarArchivo();
                ventanaCargarArchivo.MdiParent = this;
                ventanaCargarArchivo.Show();
            }
            else
            {
                ventanaCargarArchivo.BringToFront();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            agregar ventanaAgregar = null;

            if (ventanaAgregar == null || ventanaAgregar.IsDisposed)
            {
                ventanaAgregar = new agregar(); 
                ventanaAgregar.MdiParent = this;
                ventanaAgregar.Show();
            }
            else
            {
                ventanaAgregar.BringToFront();
            }
        }
    }
}
