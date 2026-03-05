namespace Exercicios0503.Nivel1
{
    internal class ExercicioConta
    {
        public static void Executar()
        {
            Console.WriteLine("Exercicio 1: Escreva um programa que leia dois números inteiros fornecidos pelo usuário e exiba a soma deles");
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("Digite o primeiro número inteiro: ");
            int n1=int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro: ");
            int n2=int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine($"A soma é: {soma}");

            

            
        }
    }
}