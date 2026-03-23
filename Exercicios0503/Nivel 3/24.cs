namespace Exercicios0503.Nivel3
{
    internal class Aleatorio
    {
        public static void Executar()
        {

            Console.WriteLine("Exercicio 24: ");
            Console.WriteLine();

            Console.WriteLine("O programa escolhe um número aleatório entre 1 e 100. O usuário deve tentar adivinhar o número, " +
            "e o programa dará dicas se o número é maior ou menor após cada tentativa. O jogo continua até que o usuário acerte.");
            Thread.Sleep(2000);
            Console.WriteLine();

            Console.WriteLine("Adivinhe um número entre 1 e 100: ");
            int n = int.Parse(Console.ReadLine());
            int tentativas = 1;


                while (n != 37)
                {

                     if (n<37) 
                     { 
                     Console.WriteLine($"Muito Baixo. Tente Novamente.");
                     Console.WriteLine("Adivinhe um número entre 1 e 100: ");
                     n = int.Parse(Console.ReadLine());
                     tentativas++;
                     }

                    else if (n > 37)
                    {
                    Console.WriteLine($"Muito Alto. Tente Novamente.");
                    Console.WriteLine("Adivinhe um número entre 1 e 100: ");
                    n = int.Parse(Console.ReadLine());
                    tentativas++;

                    }

                }

                    Console.WriteLine($"Correto! Você acertou em {tentativas} tentativas");
                

            
    }   }
}
