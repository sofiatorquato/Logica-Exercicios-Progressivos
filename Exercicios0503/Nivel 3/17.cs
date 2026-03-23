namespace Exercicios0503.Nivel3
{
    internal class SomaDeTodos
    {
        public static void Executar()
        {
            Console.WriteLine("Exercicio 17: ");
            Console.WriteLine();

            Console.WriteLine("Solicite um número inteiro positivo N e calcule a soma de todos os números de 1 até N.");
            Thread.Sleep(2000);
            Console.WriteLine();

            Console.WriteLine("Informe um número inteiro positivo: ");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i <= n; i++)
            {
                soma += i;
            }

            Console.WriteLine($"A soma de 1 a {n} é: {soma}");
        }
    }
}
