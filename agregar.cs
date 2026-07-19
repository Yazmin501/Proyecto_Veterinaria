using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using Proyecto_Veterinaria;


namespace Proyecto_Veterinaria
{
    public partial class agregar : Form
    {
        public Veterinaria Veterinaria = DatosGlobales.veterinaria;
        public agregar()
        {
            InitializeComponent();
            // El evento SelectedIndexChanged ya está suscrito desde el diseñador a
            // cbEspecie_SelectedIndexChanged_1, evitar suscribir uno distinto aquí.
        }

       

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //private void LimpiarControles()
        //{
        //    txtNombre.Clear();
        //    txtRaza.Clear();
        //    txtEdad.Clear();
        //    txtPeso.Clear();

        //    rdPerro.Checked = false;
        //    rdGato.Checked = false;
        //    rdAve.Checked = false;
        //    rdPez.Checked = false;
        //    rdRoedor.Checked = false;

        //    picPerro.Visible = false;
        //    picGato.Visible = false;
        //    picAve.Visible = false;
        //    picPez.Visible = false;
        //    picRoedor.Visible = false;

        //    txtNombre.Focus();
        //}

        private void btnRegistrarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtRaza.Text) ||
                    string.IsNullOrWhiteSpace(txtEdad.Text) ||
                    string.IsNullOrWhiteSpace(txtPeso.Text) ||
                    (!rdPerro.Checked && !rdGato.Checked && !rdAve.Checked && !rdPez.Checked && !rdRoedor.Checked))
                {
                    throw new Exception("Error: Todos los campos de datos son obligatorios. No puede dejar campos vacíos.");
                }

                // Validar tipos de datos numéricos
                if (!int.TryParse(txtEdad.Text, out int edad) || !double.TryParse(txtPeso.Text, out double peso))
                {
                    throw new Exception("Error: La edad debe ser un número entero y el peso un valor decimal válido.");
                }

                // Determinar especie según RadioButton
                string especie = "";
                if (rdPerro.Checked) especie = "Perro";
                else if (rdGato.Checked) especie = "Gato";
                else if (rdAve.Checked) especie = "Ave";
                else if (rdPez.Checked) especie = "Pez";
                else if (rdRoedor.Checked) especie = "Roedor";

                // Crear objeto Mascota
                Mascota nuevaMascota = new Mascota(
                    txtNombre.Text.Trim(),
                    txtRaza.Text.Trim(),
                    edad,
                    peso,
                    especie
                );

                // ✅ Tu método devuelve string, así que lo guardamos
                string mensaje = Veterinaria.Agregar_Mascota(nuevaMascota);

                // Mostrar datos
                MessageBox.Show(mensaje + "\n\n" +
                                "Datos de la Mascota:\n" + nuevaMascota.ObtenerDatos(),
                                "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            rdPerro.Checked = false;
            rdGato.Checked = false;
            rdAve.Checked = false;
            rdPez.Checked = false;
            rdRoedor.Checked = false;

            picPerro.Visible = false;
            picGato.Visible = false;
            picAve.Visible = false;
            picPez.Visible = false;
            picRoedor.Visible = false;

            txtNombre.Focus();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtRaza.Clear();
            txtEdad.Clear();
            txtPeso.Clear();
           
            if (picPerro != null) picPerro.Image = null;
            if (picGato != null) picGato.Image = null;
            if (picAve != null) picAve.Image = null;
            if (picPez != null) picPez.Image = null;
            if (picRoedor != null) picRoedor.Image = null;
            txtNombre.Focus();

        }

        private void btnRegistrarMascota_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtRaza.Text) ||
                    string.IsNullOrWhiteSpace(txtEdad.Text) ||
                    string.IsNullOrWhiteSpace(txtPeso.Text) ||
                    (!rdPerro.Checked && !rdGato.Checked && !rdAve.Checked && !rdPez.Checked && !rdRoedor.Checked))
                {
                    throw new Exception("Error: Todos los campos de datos son obligatorios. No puede dejar campos vacíos.");
                }

                // Validar tipos de datos numéricos
                if (!int.TryParse(txtEdad.Text, out int edad) || !double.TryParse(txtPeso.Text, out double peso))
                {
                    throw new Exception("Error: La edad debe ser un número entero y el peso un valor decimal válido.");
                }

                // Determinar especie según RadioButton
                string especie = "";
                if (rdPerro.Checked) especie = "Perro";
                else if (rdGato.Checked) especie = "Gato";
                else if (rdAve.Checked) especie = "Ave";
                else if (rdPez.Checked) especie = "Pez";
                else if (rdRoedor.Checked) especie = "Roedor";

                // Crear objeto Mascota
                Mascota nuevaMascota = new Mascota(
                    txtNombre.Text.Trim(),
                    txtRaza.Text.Trim(),
                    edad,
                    peso,
                    especie
                );

                string mensaje =DatosGlobales.veterinaria.Agregar_Mascota(nuevaMascota);

                // Mostrar datos
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
            // Ocultar todas las imágenes al iniciar
            picPerro.Visible = false;
            picGato.Visible = false;
            picAve.Visible = false;
            picPez.Visible = false;
            picRoedor.Visible = false;
        }

      
        private void picRoedor_Click(object sender, EventArgs e)
        {

           
        }

        private void picAve_Click(object sender, EventArgs e)
        {
            
        }

        private void picGato_Click(object sender, EventArgs e)
        {
          
        }

        private void picPez_Click(object sender, EventArgs e)
        {
              
        }

        private void rdPerro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPerro.Checked)
            {
                picPerro.Image = Image.FromFile("perro.png");
                picPerro.Visible = true;

                picGato.Visible = false;
                picAve.Visible = false;
                picPez.Visible = false;
                picRoedor.Visible = false;
            }
        }

        private void rdGato_CheckedChanged(object sender, EventArgs e)
        {
            if (rdGato.Checked)
            {
                picGato.Image = Image.FromFile("gato.png");
                picGato.Visible = true;

                picPerro.Visible = false;
                picAve.Visible = false;
                picPez.Visible = false;
                picRoedor.Visible = false;
            }
        }

        private void rdAve_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAve.Checked)
            {
                picAve.Image = Image.FromFile("ave.png");
                picAve.Visible = true;

                picPerro.Visible = false;
                picGato.Visible = false;
                picPez.Visible = false;
                picRoedor.Visible = false;
            }
        }

        private void rdPez_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPez.Checked)
            {
                picPez.Image = Image.FromFile("pez.png");
                picPez.Visible = true;

                picPerro.Visible = false;
                picGato.Visible = false;
                picAve.Visible = false;
                picRoedor.Visible = false;
            }
        }

        private void rdRoedor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdRoedor.Checked)
            {
                picRoedor.Image = Image.FromFile("roedor.png");
                picRoedor.Visible = true;

                picPerro.Visible = false;
                picGato.Visible = false;
                picAve.Visible = false;
                picPez.Visible = false;
            }
        }
    }
}
