using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Veterinaria
{
     public class Mascota
    {
        //Atributos
        private string nombre;
        private string raza;
        private int edad;
        private double peso;
        private string especie;

        // Constructor
        public Mascota(string nombre, string raza, int edad, double peso, string especie)
        {
            this.Nombre = nombre;
            this.Raza = raza;
            this.Edad = edad;
            this.Peso = peso;
            this.Especie = especie;
        }
        // Propiedades 
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }

       
        public string ObtenerDatos()
        {
            return "Nombre: " + nombre + ", Raza: " + raza + ", Edad: " + edad + " años, Peso: " + peso + "kg, Especie: " + especie;
        }
    }
}
