namespace Exercicios0503.Nivel3
{
    internal class Contagem
    {
        public static void Executar()
        {
            Console.WriteLine("Exercicio 15: ");
            Console.WriteLine();

            Console.WriteLine("Utilize um loop para exibir os números de 1 a 10.");
            Thread.Sleep(2000);
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}");
            }
        }
    }
}
