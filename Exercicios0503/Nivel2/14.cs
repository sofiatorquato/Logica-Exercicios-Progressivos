using System.Globalization;

namespace Exercicios0503.Nivel2
{
    internal class IMC
    {

        public static void Executar() {

            Console.WriteLine("Informe o peso em kg: ");
            double Peso = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a altura em metros: ");
            double Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double IMC = Peso / (Altura * Altura);

            if (IMC < 18.5)
            {

                Console.WriteLine($"Seu IMC é: {IMC.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Classificação: Abaixo do peso");

            }

            else if (IMC >= 18.5 && IMC < 25)
            {

                Console.WriteLine($"Seu IMC é: {IMC.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Classificação: Peso Normal");

            }

            else if (IMC >= 25 && IMC < 30)
            {

                Console.WriteLine($"Seu IMC é: {IMC.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Classificação: Sobrepeso");

            }

            else if (IMC >= 30) {

                Console.WriteLine($"Seu IMC é: {IMC.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Classificação: Obesidade");

            }


        }
    }
}
