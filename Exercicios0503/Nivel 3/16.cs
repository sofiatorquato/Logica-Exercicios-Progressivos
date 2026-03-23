namespace Exercicios0503.Nivel3
{
    internal class TabuadaFor
    {
        public static void Executar()
        {
            Console.WriteLine("Exercicio 16: ");
            Console.WriteLine();

            Console.WriteLine("Peça um número inteiro e exiba a tabuada desse número de 1 a 10.");
            Thread.Sleep(2000);
            Console.WriteLine();

            Console.WriteLine("Informe um número inteiro: ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= 10; i++) {
                
                Console.WriteLine($"{n} X {i} = {n*i}");
            }
        }
    }
}
