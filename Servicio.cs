using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Veterinaria
{
    public class Servicio
    {
        // Declarando variables mediante la asignación directa
        public double precioConsulta = 300.00;
        public double precioVacuna = 150.00;
        public double precioDesparasitacion = 100.00;
        public double precioEstetica = 250.00;
        public double precioHospedaje = 400.00;
        public double precioCirugia = 1200.00;

        // Método para calcular el descuento
        public double CalcularDescuento(int cantidadServicios, double total)
        {
            // EXCEPCIÓN: Si no se seleccionó nada, se mostrará un error
            if (cantidadServicios == 0)
            {
                throw new ArgumentException("¡Error! Debes seleccionar al menos un servicio de la lista.");
            }

            // Si son 3 servicios, aplica 10%
            if (cantidadServicios == 3)
            {
                return total * 0.10;
            }
            // Si son más de 4 servicios, aplica 50%
            else if (cantidadServicios > 4)
            {
                return total * 0.50;
            }
            // En cualquier otro caso no hay descuento
            else
            {
                return 0.0;
            }
        }
    }
}
