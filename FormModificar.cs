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
        private Veterinaria Veterinaria = DatosGlobales.veterinaria;
        public FormModificar()
        {
            InitializeComponent();
        }
        


        private void FormModificar_Load(object sender, EventArgs e)
        {
            // Llenar ComboBox de especies
            cbNewEspecie.Items.Clear();
            cbNewEspecie.Items.Add("Perro");
            cbNewEspecie.Items.Add("Gato");
            cbNewEspecie.Items.Add("Ave");
            cbNewEspecie.Items.Add("Pez");
            cbNewEspecie.Items.Add("Roedor");

            var mascotas = Veterinaria.ObtenerMascotas();
            if (mascotas == null || mascotas.Length == 0)
            {
                // sin mascotas: configurar UI en estado vacío
                cmdMascotas.DataSource = new Mascota[0];
                return;
            }
            cmdMascotas.DisplayMember = "Nombre";
            cmdMascotas.DataSource = mascotas;
        }

        private void cmdMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mascota seleccionada = (Mascota)cmdMascotas.SelectedItem;

            if (seleccionada != null)
            {
               
                txtNewNombre.Text = seleccionada.Nombre;
                txtNewRaza.Text = seleccionada.Raza;
                txtNewEdad.Text = seleccionada.Edad.ToString();
                txtNewPeso.Text = seleccionada.Peso.ToString();
                cbNewEspecie.SelectedItem = seleccionada.Especie;
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
                        txtNewNombre.Text,
                        txtNewRaza.Text,
                        int.Parse(txtNewEdad.Text),
                        double.Parse(txtNewPeso.Text),
                        cbNewEspecie.SelectedItem.ToString()
                    );

                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refrescar ComboBox con los datos actualizados
                    cmdMascotas.DataSource = null;
                    cmdMascotas.DataSource =Veterinaria.ObtenerMascotas();
                    cmdMascotas.DisplayMember = "Nombre";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cmdMascotas.DataSource = null; // limpiar
            cmdMascotas.DataSource = Veterinaria.ObtenerMascotas(); // volver a cargar
            cmdMascotas.DisplayMember = "Nombre"; // mostrar el nombre
        }
    }
}
