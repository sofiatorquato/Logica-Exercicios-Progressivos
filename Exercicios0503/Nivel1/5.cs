using System.Globalization;

namespace Exercicios0503.Nivel1
{
    internal class PrecoDesconto
    {
        public static void Executar() {

            Console.WriteLine("Exercicio 5: ");
            Console.WriteLine();

            Console.WriteLine("Peça o preço original de um produto e a porcentagem de desconto. Calcule e mostre o preço final após o desconto.");
            Thread.Sleep(2000);
            Console.WriteLine();

            Console.WriteLine("Informe o preço original do produto: ");
            double Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a porcentagem de desconto: ");
            double Porc = double.Parse(Console.ReadLine()) / 100;

            double PrecoFinal = Preco * (1 - Porc);

            Console.WriteLine($"O preço com desconto é: {PrecoFinal}");

        }
    }
}
