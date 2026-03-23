namespace Exercicios0503.Nivel3
{
    internal class Fatorial
    {
        public static void Executar()
        {
            Console.WriteLine("Exercicio 18: ");
            Console.WriteLine();

            Console.WriteLine("Leia um número inteiro não negativo e calcule seu fatorial.");
            Thread.Sleep(2000);
            Console.WriteLine();


            Console.WriteLine("Informe um número inteiro positivo: ");
            int n = int.Parse(Console.ReadLine());
            int soma = 1;
            for (int i = 1; i <= n; i++) 
            {
               soma *= i;
                Console.WriteLine($"{soma}");

            }
            
        }
    }
}
