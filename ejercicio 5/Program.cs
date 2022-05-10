using ejercicio_5.clases;
using System;


namespace ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro firulais = new Perro();
            Console.Write("Ingresar Nombre al perro: ");
            firulais.SetNombre(Console.ReadLine());
            firulais.Comer();

        }
    }
}
