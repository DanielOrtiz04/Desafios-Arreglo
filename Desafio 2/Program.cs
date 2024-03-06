using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2
{
    class Calculadora
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public int Restar(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("No se puede dividir entre cero.");
            }
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase Calculadora
            Calculadora calculadora = new Calculadora();

            // Pedir al usuario dos números
            Console.Write("Ingrese el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());


            // Invocar los métodos de la calculadora e imprimir los resultados
            Console.WriteLine($"Suma: {calculadora.Sumar(num1, num2)}");
            Console.WriteLine($"Resta: {calculadora.Restar(num1, num2)}");
            Console.WriteLine($"Multiplicación: {calculadora.Multiplicar(num1, num2)}");
            Console.ReadLine();
            try
            {
                Console.WriteLine($"División: {calculadora.Dividir(num1, num2)}");
                Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.ReadLine();
            }
        }
    }
}
