namespace Exercicios0503.Nivel3
{
    internal class Validacao
    {

        public static void Executar()
        {
            Console.WriteLine("Exercicio 21: ");
            Console.WriteLine();

            Console.WriteLine("Continue solicitando ao usuário um número entre 1 e 10 até que ele forneça um valor nesse intervalo..");
            Thread.Sleep(2000);
            Console.WriteLine();

            Console.WriteLine("Informe um número entre 1 e 10: ");
            int n = int.Parse(Console.ReadLine());

            while (n < 1 || n > 10)
            {     
                    Console.WriteLine("Valor Inválido!");
                    Console.WriteLine("Informe um número entre 1 e 10: ");
                    n = int.Parse(Console.ReadLine());
  
            }

            Console.WriteLine($"O número digitado foi {n}");
        }
    }
}
