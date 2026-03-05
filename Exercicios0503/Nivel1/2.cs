using System.Globalization;

namespace Exercicios0503.Nivel1
{
    internal class ExercicioConversao
    {
        public static void Executar()
        {
            Console.WriteLine("Exercicio 2:");
            Console.WriteLine();
            Console.WriteLine(" Leia uma temperatura em graus Celsius e converta-a para Fahrenheit. A fórmula de conversão é: F = (C × 9/5) + 32");
            Thread.Sleep(2000);
            Console.WriteLine();

            Console.WriteLine("Informe a temperatura em graus Celsius: ");
            double Grau = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double F = (Grau * 9 / 5) + 32;

            Console.WriteLine($"A temperatura em Fahrenheit é de: {F.ToString("F1", CultureInfo.InvariantCulture)}");

        }
    }
}