namespace Exercicios0503.Nivel1
{
    internal class TempoMinutos
    {
        public static void Executar()
        {
            Console.WriteLine("Exercicio 4: ");
            Console.WriteLine();

            Console.WriteLine("Leia uma quantidade de dias e converta esse valor para o total de minutos.");
            Thread.Sleep(2000);
            Console.WriteLine();

            Console.WriteLine("Digite a quantidade de dias: ");
            int Dia = int.Parse(Console.ReadLine());

            int Min = 1440;

            int m = Dia * Min;

            Console.WriteLine($"O total em minutos é: {m}");
        }
    }
}
