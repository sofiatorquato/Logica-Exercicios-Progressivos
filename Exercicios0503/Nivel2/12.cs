namespace Exercicios0503.Nivel2
{
    internal class Senha
    {

        public static void Executar()
        {

            Console.WriteLine("Informe a senha: ");
            string Senha = Console.ReadLine();



            if (Senha != "Senha123")
            {

                Console.WriteLine("Acesso negado");

            }

            else
            {

                Console.WriteLine("Acesso permitido");
            }


        }
    }
}
