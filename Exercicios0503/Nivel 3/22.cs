namespace Exercicios0503.Nivel3
{
    internal class ContagemRegressiva
    {
        public static void Executar()
        {
            Console.WriteLine("Exercicio 22: ");
            Console.WriteLine();

            Console.WriteLine("Implemente uma contagem regressiva de 10 a 0 e exiba \"Lançar!\" ao final.");
            Thread.Sleep(2000);
            Console.WriteLine();

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Lançar!");
        }
    }
}
