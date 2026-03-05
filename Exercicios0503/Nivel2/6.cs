namespace Exercicios0503.Nivel2
{
    internal class ParImpar
    {
        public static void Executar()
        {
            Console.WriteLine("Exercicio 6: ");
            Console.WriteLine();

            Console.WriteLine("Leia um número inteiro e informe se ele é par ou ímpar.");
            Thread.Sleep(2000);
            Console.WriteLine();

            Console.WriteLine("Informe um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Ímpar!");
            }
        }

    }
}
