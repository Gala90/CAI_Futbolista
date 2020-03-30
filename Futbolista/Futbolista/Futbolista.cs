using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbolista
{
    public class Futbolista
    {
        private string nombre;
        private int edad;
        private string posicion;
        private double altura;
        private int fuerza;
        private int goles;
        private int asistencias;



        public Futbolista (string nombre, int edad, string posicion, double altura, int fuerza)          
        {
                this.nombre = nombre;
                this.edad = edad;
                this.posicion = posicion;
                this.altura = altura;
                this.fuerza = fuerza;
                goles = 0;
                asistencias = 0;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set { this.nombre = value; }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
            set { this.edad = value; }
        }

        public string Posicion
        {
            get
            {
                return this.posicion;
            }
            set { this.posicion = value; }
        }

        public double Altura
        {
            get
            {
                return this.altura;
            }
            set { this.altura = value; }
        }

        public int Fuerza
        {
            get
            {
                return this.fuerza;
            }
            set { this.fuerza = value; }
        }

        public void mostrarJugador()
        {
            Console.WriteLine("Nombre: " + Nombre + " Edad: " + Edad + " Posicion: " + Posicion + " Altura: " + Altura + " Fuerza: " + Fuerza);
        }

        public void correr()
        {
            Console.WriteLine("Estoy corriendo");
        }

        public void pasar()
        {
            Console.WriteLine("La estoy pasando");
        }

        public void patear()
        {
            Console.WriteLine("Patee al arco");

            Console.WriteLine("Fue gol?: ");
            string inputString;
            inputString = Console.ReadLine();

            if (inputString.ToLower() == "si")
            {
                goles = goles + 1;
            }
           
        


        }

        public void mostrarCantGoles()
        {
            Console.WriteLine("Cantidad de goles: " + goles);
        }


        public void mostrarCantAsistencias()
        {
            Console.WriteLine("Cantidad de asistencias: " + asistencias);
        }

        public void asistencia()
        {
            Console.WriteLine("Hice una asistencia!");
            asistencias = asistencias + 1;
        }

    }
}

