using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu nombre: ");
            var name = Console.ReadLine();
            Console.WriteLine("Ingresa una ciudad: ");
            var city = Console.ReadLine();
            Console.WriteLine("Hola " + name + " bienvenido a " + city);


        }
    }
}
