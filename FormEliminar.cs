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
    public partial class FormEliminar : Form
    {
        Veterinaria veterinaria=new Veterinaria();
        public FormEliminar()
        {
            InitializeComponent();
        }

        private void cmdMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mascota seleccionada = (Mascota)cmdMascotas.SelectedItem;

            if (seleccionada != null)
            {
                lbRaza.Text = "Raza: " + seleccionada.Raza;
                lbEdad.Text = "Edad: " + seleccionada.Edad.ToString() + " años";
                lbPeso.Text = "Peso: " + seleccionada.Peso.ToString() + " kg";
                lbEspecie.Text = "Especie: " + seleccionada.Especie;
            }
        }

        private void FormEliminar_Load(object sender, EventArgs e)
        {
            // Llenar ComboBox con nombres de mascotas
            cmdMascotas.DataSource = veterinaria.ObtenerMascotas();
            cmdMascotas.DisplayMember = "Nombre"; // mostrar solo el nombre
        }

        private void btnEliminarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                Mascota seleccionada = (Mascota)cmdMascotas.SelectedItem;

                if (seleccionada != null)
                {
                    //preguntar al usuario si está seguro de eliminar la mascota
                    DialogResult respuesta = MessageBox.Show(
                   "¿Desea eliminar la mascota seleccionada?",
                   "Confirmar eliminación",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question
               );
                    if (respuesta == DialogResult.No)
                    {
                        return; // Salir del método si el usuario cancela
                    }
                    if (seleccionada == null)
                    {
                        MessageBox.Show("Por favor, seleccione una mascota para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (respuesta == DialogResult.Yes)
                    {
                        // Eliminar la mascota
                        string mensaje = veterinaria.Eliminar_Mascota(
                        seleccionada.Nombre,
                        seleccionada.Raza,
                        seleccionada.Edad,
                        seleccionada.Peso,
                        seleccionada.Especie
                    );

                        MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refrescar ComboBox después de eliminar
                        cmdMascotas.DataSource = null;
                        cmdMascotas.DataSource = veterinaria.ObtenerMascotas();
                        cmdMascotas.DisplayMember = "Nombre";
                        // Limpiar los TextBox
                        lbNombre.Text = "";
                        lbRaza.Text = "";
                        lbEdad.Text = "";
                        lbPeso.Text = "";
                        lbEspecie.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione una mascota para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gpEliminar_Enter(object sender, EventArgs e)
        {

        }
    }
}
