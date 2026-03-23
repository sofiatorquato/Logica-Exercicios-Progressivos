namespace Exercicios0503.Nivel3
{
    internal class Fibonacci
    {

        public static void Executar()
        {
            Console.WriteLine("Exercicio 20: ");
            Console.WriteLine();

            Console.WriteLine("Peça um número N e exiba os N primeiros termos da sequência de Fibonacci.");
            Thread.Sleep(2000);
            Console.WriteLine();

            Console.WriteLine("Informe o número de termos: ");
            int t = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int prox;

            Console.WriteLine($"{a}");
            Console.WriteLine($"{b}");

            for (int i = 3; i <=t; i++)
            {
                prox = a + b;
                a = b;
                b= prox;

                Console.WriteLine($"{prox}");
               
            }
           
        }
    }
}
