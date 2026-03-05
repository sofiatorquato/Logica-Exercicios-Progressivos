namespace Exercicios0503.Nivel2
{
    internal class VerificarIdade
    {
        public static void Executar()
        {

            Console.WriteLine("Exercicio 10: ");
            Console.WriteLine();

            Console.WriteLine("Solicite a idade do usuário e informe se ele é menor ou maior de 18.");
            Thread.Sleep(2000);
            Console.WriteLine();

            Console.WriteLine("Informe a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Maior de idade");
            }

            else if (idade < 18)
            {

                Console.WriteLine("Menor de idade");
            }
            
        }

    }
}
