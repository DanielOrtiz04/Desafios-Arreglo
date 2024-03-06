using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_3
{


    class Program
    {
        static void Main(string[] args)
        {
            // Invocar los 4 métodos para realizar operaciones básicas
            int numero1 = 10;
            int numero2 = 5;

            Console.WriteLine($"Suma: {Sumar(numero1, numero2)}");

            // Invocar el método que pide dos valores y los suma
            PedirYSumar();
        }

        static int Sumar(int a, int b)
        {
            return a + b;
        }

        static void PedirYSumar()
        {
            try
            {
                Console.WriteLine("Ingrese el primer número:");
                string input1 = Console.ReadLine();
                int numero1 = Convert.ToInt32(input1);

                Console.WriteLine("Ingrese el segundo número:");
                string input2 = Console.ReadLine();
                int numero2 = Convert.ToInt32(input2);

                int resultado = Sumar(numero1, numero2);
                Console.WriteLine($"La suma de {numero1} y {numero2} es: {resultado}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Se esperaba un número entero.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: El número ingresado es demasiado grande o demasiado pequeño.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("El bloque Try-Catch ha finalizado.");
                Console.ReadLine();
            }
        }
    }
}
