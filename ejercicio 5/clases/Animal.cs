using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5.clases
{
    public abstract class Animal
    {
        private string Nombre;

        public Animal()
        {

        }

        public Animal(string nombre)
        {
            this.Nombre = nombre;
        }
        //--------------------metodos------------------
        public void SetNombre(string nombre)
        {
            this.Nombre = nombre;
        }

        public string GetNombre()
        {
            return this.Nombre;
        }

        public abstract void Comer();


    }
}
