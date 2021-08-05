using System;

namespace EjercicioCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcesarTexto procesadorTexto = new ProcesarTexto();
            Console.WriteLine("Por Favor Ingrese el texto: ");
            string texto = Console.ReadLine();
            string resultado = procesadorTexto.teclas(texto);
            Console.WriteLine("La Combinación Ingresada es: "+resultado);
        }
    }
}
