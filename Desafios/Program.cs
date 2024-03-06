using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1._1
{

    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar ingresos de los últimos 3 meses y el nombre del usuario
            Console.WriteLine("Ingrese su nombre:");
            string nombreUsuario = Console.ReadLine();

            double[] ingresos = new double[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Ingrese ingresos del mes {i + 1}: ");
                ingresos[i] = Convert.ToDouble(Console.ReadLine());
            }

            CalcularSumaYPromedio(ingresos, nombreUsuario);
        }

        static void CalcularSumaYPromedio(double[] ingresos, string nombreUsuario)
        {
            double sumaIngresos = 0;
            foreach (var ingreso in ingresos)
            {
                sumaIngresos += ingreso;
            }

            double promedioIngresos = sumaIngresos / ingresos.Length;

            Console.WriteLine($"Hola {nombreUsuario}, en total ganaste {sumaIngresos} y promediaste {promedioIngresos}");
            Console.ReadLine();
        }
    }
}