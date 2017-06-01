using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjeExamenPrueba
{
    class Alumno : Persona
    {
        private String NMatricula;
        private float Nota;

        public Alumno(String nombre,String apellidos,int edad,String NMatricula,float Nota) : base(nombre, apellidos, edad)
        {
            this.NMatricula = Matricula;
            this.Nota = Nota;
        }


        public String Matricula
        {
            get
            {
                return NMatricula;
            }
            set
            {
                if (NMatricula.Equals("")) {

                    throw new Exception("Debes introducir un numero de matricula");
                }
                else
                {
                    NMatricula = value;
                }
               
            }
        }

        public float Notas
        {
            get
            {
                return Nota;
            }

            set
            {
                if (Nota >= 0 && Nota <= 10)
                {
                    Nota = value;
                }
                else
                {
                   throw new Exception("La nota debe estar entre 0 y 10");
                }
            }
        }

        public override void Saludar()
        {
            Console.WriteLine("Buenas dias profesor.");
        }

        public void Quejarse(String Texto)
        {

        }
    }


}
