namespace Exercicios0503.Nivel2
{
    internal class CalculadoraSimples
    {
        public static void Executar()
        {
            Console.WriteLine("Exercicio 9: ");
            Console.WriteLine();

            Console.WriteLine(" Leia dois números e um operador matemático (+, -, *, /). Realize a operação indicada e mostre o resultado.");
            Thread.Sleep(2000);
            Console.WriteLine();

            Console.WriteLine("Informe o primeiro número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número inteiro: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o operador matemático (+, -, *, /): ");
            string operador = Console.ReadLine();

            if (operador == "+")
            {

                int soma = n1 + n2;
                Console.WriteLine($"A soma é {soma}");
            }

            else if (operador == "-")
            {

                int sub = n1 - n2;
                Console.WriteLine($"A subtração é {sub}");

            }

            else if (operador == "*")
            {
                int mult = n1 * n2;
                Console.WriteLine($"A multiplicação é {mult}");

            }

            else if (operador == "/")
            {
                double div = n1 / n2;
                Console.WriteLine($"A divisão é {div}");

            }
            else {
                Console.WriteLine("Operador incorreto.");
            }
        }

    }
}
