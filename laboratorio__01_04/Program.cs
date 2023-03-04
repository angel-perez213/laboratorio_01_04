using System;

namespace laboratorio__01_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1: Operaciones arimetricas");

            Console.Write("ingrese un numero: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ingrese otro numero:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int suma = n1 + n2;
            Console.WriteLine(n1 + " + " + n2 + " = " + suma);

            int resta = n1 - n2;
            Console.WriteLine(n1 + " - " + n2 + " = " + resta);

            int multiplicacion = n1 * n2;
            Console.WriteLine(n1 + " * " + n2 + " = " + multiplicacion);

            int division = n1 / n2;
            Console.WriteLine(n1 + " / " + n2 + " = " + division);

            double mod = n1 % n2;
            Console.WriteLine(n1 + " % " + n2 + " = " + mod);

            double n1d = n1;
            double n2d = n2;

            double division = n1d / n2d;
            Console.WriteLine(n1 + " / " + n2 + " = " + division);

        }
    }
}
