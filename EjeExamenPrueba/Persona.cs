using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjeExamenPrueba
{
    abstract class Persona
    {

        protected string nombre;
        protected string apellidos;
        protected int edad;

    public Persona(String nombre, String apellidos, int edad)
    {
        this.nombre = Nombre;
        this.apellidos = Apellidos;
        this.edad = Edad;
    }

        public abstract void Saludar();
      

         public String Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre =value;
            }
        }

        public String Apellidos
        {
            get
            {
                return apellidos;
            }
            set
            {
                apellidos = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                if (edad < 18)
                {
                    edad = value;
                }
                else
                {
                   throw new Exception("La edad no puede suparar los 18 años");
                }
                
            }
        }


    }

}
