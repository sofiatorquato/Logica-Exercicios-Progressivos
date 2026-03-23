namespace Exercicios0503.Nivel3
{
    internal class NumeroPrimo
    {
        public static void Executar()
        {

            Console.WriteLine("Exercicio 23: ");
            Console.WriteLine();

            Console.WriteLine("Peça um número inteiro e determine se ele é primo.");
            Thread.Sleep(2000);
            Console.WriteLine();

            Console.WriteLine("Informe um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 1 && n % 1 == 0 && n % n == 0)
            {
                Console.WriteLine($"O número {n} é primo");
            }

            else
            {
                Console.WriteLine($"O número {n} não é primo");
            }

        }

    }
}
