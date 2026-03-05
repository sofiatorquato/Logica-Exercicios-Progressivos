namespace Exercicios0503.Nivel2
{
    internal class Maior2Numeros
    {
        public static void Executar() {
            Console.WriteLine("Exercicio 7: ");
            Console.WriteLine();

            Console.WriteLine("Peça dois números ao usuário e exiba o maior deles.");
            Thread.Sleep(2000);
            Console.WriteLine();

            Console.WriteLine("Informe o primeiro número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número inteiro: ");
                int n2 = int.Parse(Console.ReadLine());

            if (n1 == n2)
            {
                Console.WriteLine("Iguais");
            }
            else if (n1 > n2)
            {
                Console.WriteLine($"O maior número é {n1}");
            }
            else {
                Console.WriteLine($"O número maior é {n2}");
            }
        }
    }
}
