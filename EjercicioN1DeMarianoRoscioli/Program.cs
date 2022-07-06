using System;

namespace EjercicioN1DeMarianoRoscioli
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Desarrollar un programa para informar la cantidad de dólares que puedo comprar con una determinada
            //cantidad de pesos que se ingresa por teclado, sabiendo que cada dólar vale 230 pesos. Convertir y mostrar
            //luego la cantidad de euros, sabiendo que 1 euro equivale a 1.17 dólares

            double pesos, dolares, euros;

            Console.WriteLine("Ingrese la cantidad de pesos a invertir: ");
            pesos = double.Parse(Console.ReadLine());

            dolares = pesos / 230;

            Console.WriteLine($"Con { pesos} pesos puede comprar US { dolares} dolares");

            euros = dolares * 1.17;

            Console.WriteLine($"Con { pesos} pesos puede comprar E { euros} euros");

            Console.WriteLine();
        }
    }
}
