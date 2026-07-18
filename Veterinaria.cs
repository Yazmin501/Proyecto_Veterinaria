using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Veterinaria
{
    internal class Veterinaria
    {
        //arreglo de objeto , almacena las mascotas
        private Mascota[] Arr_Mascotas = new Mascota[6]; // máximo 6 mascotas
                                                         //variable para el indice del arreglo
        private int indice = 0;

        public int Indice
        {
            get { return indice; }
            set { indice = value; }
        }

        //constructor
        public Veterinaria()
        {
            Indice = 0;
        }

        // metodo para agregar una mascota al arreglo y listar
        public string Agregar_Mascota(Mascota MASCOTA)
        {
            string mensaje = "";
            if (Indice < Arr_Mascotas.Length)
            {
                Arr_Mascotas[indice] = MASCOTA;
                indice++;
                mensaje = "Mascota agregada correctamente " + indice.ToString() + " de 6";
            }
            else
            {
                mensaje = "No se puede agregar más mascotas";
            }
            return mensaje;
        }

        // metodo para listar las mascotas
        public string Listar_Mascotas()
        {
            string lista = "";
            for (int i = 0; i < indice; i++)
            {
                lista += Arr_Mascotas[i].ToString() + "\n";
            }
            return lista;
        }

        // metodo para buscar, y modificar una mascota
        public string Modificar_Mascota(string nombre, string raza, int edad, double peso, string especie,
                                        string nombreNuevo, string razaNueva, int edadNueva, double pesoNuevo, string especieNueva)
        {
            string mensaje = "Mascota no encontrada";
            bool encontrado = false;

            for (int i = 0; i < indice; i++)
            {
                if (Arr_Mascotas[i].Nombre == nombre &&
                    Arr_Mascotas[i].Raza == raza &&
                    Arr_Mascotas[i].Edad == edad &&
                    Arr_Mascotas[i].Peso == peso &&
                    Arr_Mascotas[i].Especie == especie)

                    encontrado = true;
                Arr_Mascotas[i].Nombre = nombreNuevo;
                Arr_Mascotas[i].Raza = razaNueva;
                Arr_Mascotas[i].Edad = edadNueva;
                Arr_Mascotas[i].Peso = pesoNuevo;
                Arr_Mascotas[i].Especie = especieNueva;
                mensaje = "Mascota modificada correctamente";
                break; // salir del ciclo
            }
        }
                return mensaje;
            }

           // metodo para eliminar una mascota
            public string Eliminar_Mascota(string nombre, string raza, int edad, double peso, string especie)
        {
            string mensaje = "Mascota no encontrada";
            bool encontrado = false;
            int posicion = -1;

            for (int i = 0; i < indice; i++)
            {
                if (Arr_Mascotas[i].Nombre == nombre &&
                    Arr_Mascotas[i].Raza == raza &&
                    Arr_Mascotas[i].Edad == edad &&
                    Arr_Mascotas[i].Peso == peso &&
                    Arr_Mascotas[i].Especie == especie)
                {
                    encontrado = true;
                    posicion = i;

                    //recorrer el arreglo para eliminar
                    for (int j = posicion; j < indice - 1; j++)
                    {
                        Arr_Mascotas[j] = Arr_Mascotas[j + 1];
                    }

                    Arr_Mascotas[indice - 1] = null;
                    indice--;
                    mensaje = "Mascota eliminada correctamente";
                    break;
                }
            }
            return mensaje;
        }

        // metodo para listar mascotas desde archivo
        public string ListarArchivo()
        {
            string resultado = "";
            try
            {
                //Leer todas las líneas del archivo
                string rutaArchivo = "Mascotas.txt";
                string[] lineas = System.IO.File.ReadAllLines(rutaArchivo);

                //Recorrer cada línea y armar el listado
                for (int i = 0; i < lineas.Length && i < Arr_Mascotas.Length; i++)
                {
                    string[] datos = lineas[i].Split(',');

                    // Crear objeto Mascota
                    Mascota nueva = new Mascota();
                    nueva.Nombre = datos[0];
                    nueva.Raza = datos[1];
                    nueva.Edad = int.Parse(datos[2]);
                    nueva.Peso = double.Parse(datos[3]);
                    nueva.Especie = datos[4];

                    // Guardar en el arreglo
                    Arr_Mascotas[i] = nueva;
                    Indice++;

                    // Agregar al texto resultado
                    resultado += "Mascota " + (i + 1) + ": " +
                                 nueva.Nombre + ", " +
                                 nueva.Raza + ", " +
                                 nueva.Edad + " años, " +
                                 nueva.Peso + " kg, " +
                                 nueva.Especie + "\n";
                }
            }
            catch (Exception ex)
            {
                resultado = "Error al listar archivo: " + ex.Message;
            }

            return resultado;
        }



    }
}
