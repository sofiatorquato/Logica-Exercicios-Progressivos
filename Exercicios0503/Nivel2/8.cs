namespace Exercicios0503.Nivel2
{
    internal class Maior3Numeros
    {
        public static void Executar()
        {
            Console.WriteLine("Exercicio 8: ");
            Console.WriteLine();

            Console.WriteLine("Peça três números ao usuário e exiba o maior deles.");
            Thread.Sleep(2000);
            Console.WriteLine();

            Console.WriteLine("Informe o primeiro número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número inteiro: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o terceiro número inteiro: ");
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine($"Maior número é {n1}");
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine($"Maior número é {n2}");

            }
            else if (n3 > n1 && n3 > n2)
            {
                Console.WriteLine($"Maior número é {n3}");

            }
        }
    }
}
