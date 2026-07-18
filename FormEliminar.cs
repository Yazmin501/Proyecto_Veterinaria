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
            cmdMascotas.DataSource = Veterinaria.ObtenerMascotas();
            cmdMascotas.DisplayMember = "Nombre"; // mostrar solo el nombre
        }

        private void btnEliminarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                Mascota seleccionada = (Mascota)cmdMascotas.SelectedItem;

                if (seleccionada != null)
                {
                    string mensaje =Veterinaria.Eliminar_Mascota(
                        seleccionada.Nombre,
                        seleccionada.Raza,
                        seleccionada.Edad,
                        seleccionada.Peso,
                        seleccionada.Especie
                    );

                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refrescar ComboBox después de eliminar
                    cmdMascotas.DataSource = null;
                    cmdMascotas.DataSource = Veterinaria.ObtenerMascotas();
                    cmdMascotas.DisplayMember = "Nombre";
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
