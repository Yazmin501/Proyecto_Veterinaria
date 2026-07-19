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
    public partial class FormCargarArchivo : Form
    {
        private Veterinaria Veterinaria = new Veterinaria();
        public FormCargarArchivo()
        {
            InitializeComponent();
        }
       
        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar al método de Veterinaria que lee el archivo
                string resultado = Veterinaria.ListarArchivo();

                // Mostrar mensaje de confirmación
                MessageBox.Show("Archivo cargado correctamente:\n" + resultado,
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refrescar DataGridView con las mascotas cargadas
                dtViewMascotas.DataSource = null;
                dtViewMascotas.DataSource = Veterinaria.ObtenerMascotas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar archivo: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCargarArchivo_Load(object sender, EventArgs e)
        {

        }
    }
}
