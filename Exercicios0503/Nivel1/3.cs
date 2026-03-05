using System.Globalization;

namespace Exercicios0503.Nivel1
{
    internal class CalculoArea
    {
        public static void Executar()
        {
            Console.WriteLine("Exercicio 3: ");
            Console.WriteLine();

            Console.WriteLine("Solicite o raio de um círculo e calcule a área. Use a fórmula: Área = π × raio². Considere π = 3.14159.");
            Thread.Sleep(2000);
            Console.WriteLine();

            Console.WriteLine("Informe o raio do círculo: ");
            double r = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double pi = 3.14159;
            double a = pi * (Math.Pow(r, 2.0));

            Console.WriteLine($"A área do circulo é de: {a}");
        }
    }
}
