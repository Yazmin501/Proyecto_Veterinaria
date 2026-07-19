using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Veterinaria;


namespace Proyecto_Veterinaria
{
    public partial class agregar : Form
    {
        private Veterinaria Veterinaria = new Veterinaria();
        public agregar()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                //  Validación 
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtRaza.Text) ||
                    string.IsNullOrWhiteSpace(txtEdad.Text) ||
                    string.IsNullOrWhiteSpace(txtPeso.Text) ||
                    cbEspecie.SelectedIndex == -1)
                {
                    throw new Exception("Error: Todos los campos de datos son obligatorios. No puede dejar campos vacíos.");
                }

                // Validar tipos de datos numéricos
                if (!int.TryParse(txtEdad.Text, out int edad) || !double.TryParse(txtPeso.Text, out double peso))
                {
                    throw new Exception("Error: La edad debe ser un número entero y el peso un valor decimal válido.");
                }

                //  Crear el objeto Mascota 
                Mascota nuevaMascota = new Mascota(
                 txtNombre.Text.Trim(),
                 txtRaza.Text.Trim(),
                 int.Parse(txtEdad.Text),
                 double.Parse(txtPeso.Text),
                  cbEspecie.SelectedItem.ToString());

                string mensaje = DatosGlobales.veterinaria.Agregar_Mascota(nuevaMascota);

                // Mostramos los datos
                MessageBox.Show("¡Mascota creada correctamente!\n\n" +
                                "Datos de la Mascota:\n" + nuevaMascota.ObtenerDatos(),
                                "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEspecie.SelectedIndex != -1)
            {
                string especie = cbEspecie.SelectedItem.ToString().ToLower();

                try
                {
                    if (especie.Contains("perro"))
                    {
                        picMascota.Image = Image.FromFile("imagenes/perro.png");
                    }
                    else if (especie.Contains("gato"))
                    {
                        picMascota.Image = Image.FromFile("imagenes/gato.png");
                    }
                    else
                    {
                        picMascota.Image = Image.FromFile("imagenes/default.png");
                    }

                    picMascota.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch
                {
                    picMascota.Image = null;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtRaza.Clear();
            txtEdad.Clear();
            txtPeso.Clear();
            cbEspecie.SelectedIndex = -1;
            picMascota.Image = null;
            txtNombre.Focus();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtRaza.Clear();
            txtEdad.Clear();
            txtPeso.Clear();
            cbEspecie.SelectedIndex = -1;
            picMascota.Image = null;
            txtNombre.Focus();

        }

        private void btnRegistrarMascota_Click_1(object sender, EventArgs e)
        {
            try
            {
                //  Validación 
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtRaza.Text) ||
                    string.IsNullOrWhiteSpace(txtEdad.Text) ||
                    string.IsNullOrWhiteSpace(txtPeso.Text) ||
                    cbEspecie.SelectedIndex == -1)
                {
                    throw new Exception("Error: Todos los campos de datos son obligatorios. No puede dejar campos vacíos.");
                }

                // Validar tipos de datos numéricos
                if (!int.TryParse(txtEdad.Text, out int edad) || !double.TryParse(txtPeso.Text, out double peso))
                {
                    throw new Exception("Error: La edad debe ser un número entero y el peso un valor decimal válido.");
                }

                //  Crear el objeto Mascota 
                Mascota nuevaMascota = new Mascota(
                 txtNombre.Text.Trim(),
                 txtRaza.Text.Trim(),
                 int.Parse(txtEdad.Text),
                 double.Parse(txtPeso.Text),
                  cbEspecie.SelectedItem.ToString());

                string mensaje = DatosGlobales.veterinaria.Agregar_Mascota(nuevaMascota);

                // Mostramos los datos
                MessageBox.Show("¡Mascota creada correctamente!\n\n" +
                                "Datos de la Mascota:\n" + nuevaMascota.ObtenerDatos(),
                                "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void agregar_Load(object sender, EventArgs e)
        {

            // Llenar el ComboBox con las especies disponibles

            cbEspecie.Items.Clear();

            string rutaArchivo = "Mascotas.txt";
            if (System.IO.File.Exists(rutaArchivo))
            {
                string[] lineas = System.IO.File.ReadAllLines(rutaArchivo);

                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(',');
                    if (datos.Length == 5)
                    {
                        string especie = datos[4].Trim();
                        if (!cbEspecie.Items.Contains(especie))
                        {
                            cbEspecie.Items.Add(especie);
                        }
                    }
                }
            }
        }

        private void picMascota_Click(object sender, EventArgs e)
        {

        }
    }
}
