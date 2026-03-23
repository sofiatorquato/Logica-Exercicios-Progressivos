namespace Exercicios0503.Nivel3
{
    internal class ParesAte50
    {
        public static void Executar()
        {
            Console.WriteLine("Exercicio 19: ");
            Console.WriteLine();

            Console.WriteLine("Exiba todos os números pares no intervalo de 1 a 50.");
            Thread.Sleep(2000);
            Console.WriteLine();

            for (int i = 1; i <=50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}");
                }

            }
        }
    }
}
