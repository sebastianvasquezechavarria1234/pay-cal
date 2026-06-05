using System;

namespace PayCal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double SALARIO_MINIMO = 1300000;  // Salario mínimo en COP
            const double SUBSIDIO_TRANSPORTE = 162000;

            // Pedir datos al usuario
            Console.WriteLine("Ingrese el nombre del empleado:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el código del empleado (entero):");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de horas laboradas:");
            double horas = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de cada hora:");
            double valorHora = double.Parse(Console.ReadLine());

            // Calcular salario básico
            double salario = horas * valorHora;

            // Mostrar salario sin formato
            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine("Salario sin formato: " + salario);

            // Mostrar salario con formato de pesos y redondeado hacia arriba
            double redondeadoArriba = Math.Ceiling(salario * 100) / 100;
            Console.WriteLine("Salario redondeado hacia arriba (2 decimales): " + redondeadoArriba.ToString("C2"));

            // Mostrar salario redondeado al número más cercano
            double redondeadoNormal = Math.Round(salario, 2);
            Console.WriteLine("Salario redondeado al número más cercano (2 decimales): " + redondeadoNormal.ToString("C2"));

            // Otra vez redondeado hacia arriba (repetido por requerimiento)
            Console.WriteLine("Salario redondeado hacia arriba (2 decimales): " + redondeadoArriba.ToString("C2"));

            // Verificar si tiene derecho a subsidio
            double salarioConSubsidio = salario;
            if (salario < 2 * SALARIO_MINIMO)
            {
                salarioConSubsidio += SUBSIDIO_TRANSPORTE;
                Console.WriteLine("\nTiene derecho al subsidio de transporte.");
            }
            else
            {
                Console.WriteLine("\nNo tiene derecho al subsidio de transporte.");
            }

            // Mostrar salario total con subsidio si aplica
            Console.WriteLine("Salario total con subsidio (si aplica): " + salarioConSubsidio.ToString("C2"));

            // Final
            Console.WriteLine("\nPresiona cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
