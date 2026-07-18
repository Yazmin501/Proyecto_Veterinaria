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
    public partial class FormModificar : Form
    {
        public FormModificar()
        {
            InitializeComponent();
        }

      

        private void FormModificar_Load(object sender, EventArgs e)
        {
            cmdMascotas.DataSource = Veterinaria.ObtenerMascotas();
            cmdMascotas.DisplayMember = "Nombre"; // mostrar solo el nombre
        }

        private void cmdMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mascota seleccionada = (Mascota)cmdMascotas.SelectedItem;

            if (seleccionada != null)
            {
               
                txtNombreNuevo.Text = seleccionada.Nombre;
                txtRazaNueva.Text = seleccionada.Raza;
                txtEdadNueva.Text = seleccionada.Edad.ToString();
                txtPesoNuevo.Text = seleccionada.Peso.ToString();
                txtEspecieNueva.Text = seleccionada.Especie;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Mascota seleccionada = (Mascota)cmdMascotas.SelectedItem;

                if (seleccionada != null)
                {
                    string mensaje = Veterinaria.Modificar_Mascota(
                        seleccionada.Nombre,
                        seleccionada.Raza,
                        seleccionada.Edad,
                        seleccionada.Peso,
                        seleccionada.Especie,
                        txtNombre.Text,
                        txtRaza.Text,
                        int.Parse(txtEdad.Text),
                        double.Parse(txtPeso.Text),
                        txtEspecie.Text
                    );

                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refrescar ComboBox con los datos actualizados
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
    }
}
