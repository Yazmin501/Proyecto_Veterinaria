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
    public partial class FormServicios : Form
    {
        public FormServicios()
        {
            InitializeComponent();
        }

        private void lblRecibo_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Servicio Servicio = new Servicio();

            //  Arreglo de tipo CheckBox agrupa los controles visuales de la pantalla para poder acceder a ellos mas facil.
            CheckBox[] listaCheckBoxes = { chkConsulta, chkVacuna, chkDesparasitación, chkEstetica, chkHospedaje, chkCirugia };
            // Arreglo con los precios de cada servicio
            double[] listaPrecios = { Servicio.precioConsulta, Servicio.precioVacuna, Servicio.precioDesparasitacion, Servicio.precioEstetica, Servicio.precioHospedaje, Servicio.precioCirugia };
            // Arreglo con los nombres de los servicios
            string[] listaNombres = { "Consulta General", "Vacunación", "Desparasitación", "Estética / Baño", "Hospedaje", "Cirugía Menor" };

            double total = 0;
            int contadorServicios = 0;

            string listaDeServiciosComprados = "";

            for (int i = 0; i < 6; i++)
            {
                // Revisa que algun cuadrito este selleccionado
                if (listaCheckBoxes[i].Checked)
                {
                    //Suma el precio del servicio al dinero total
                    total += listaPrecios[i];
                    //Agrega el nombre y precio del servicio a la lista del recibo
                    listaDeServiciosComprados += $" • {listaNombres[i]}: ${listaPrecios[i]}\n";
                    contadorServicios++;
                }
            }

            // Validación por si no marcaron nada
            if (contadorServicios == 0)
            {
                lblRecibo.Text = " NO HAS SELLECCIONADO NINGUN SERVICIO ";
                MessageBox.Show("Por favor, seleccione al menos un servicio.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double dineroDescontado = Servicio.CalcularDescuento(contadorServicios, total);
            double totalAPagar = total - dineroDescontado;

            lblRecibo.Text =$"-----------------------------------------------------\n  RECIBO SERVICIOS  \n -----------------------------------------------------\n {listaDeServiciosComprados} -----------------------------------------------------\n Subtotal: {total} \n Descuento aplicado: {dineroDescontado} \n-----------------------------------------------------\n TOTAL A PAGAR: {totalAPagar} \n-----------------------------------------------------";
        }

        private void chkDesparasitación_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
