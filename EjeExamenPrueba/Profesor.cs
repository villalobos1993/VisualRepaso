using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjeExamenPrueba
{
    class Profesor:Persona
    {

        private int sueldo;

        public Profesor (int sueldo,String nombre,String apellidos,int edad) : base(nombre, apellidos, edad)
        {
            this.sueldo = sueldo;
        }



        public int Sueldo
        {
            get
            {
                return sueldo;
            }
        }

        public override void Saludar()
        {
            Console.WriteLine("Buenos dias Alumnos.");
        }

        public void Regañar(String texto)
        {
            Console.WriteLine(texto);
        }

        public String toString()
        {
            return "Nombre " + Nombre + " Apellidos " + Apellidos + " Edad " + edad + " Sueldo " + sueldo;
        }
    
    }
}
