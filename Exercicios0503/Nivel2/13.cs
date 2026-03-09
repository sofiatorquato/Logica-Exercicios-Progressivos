namespace Exercicios0503.Nivel2
{
    internal class Idade
    {

        public static void Executar() {


            Console.WriteLine("Informe a idade do nadador: ");
            int Idade = int.Parse(Console.ReadLine());

            if (Idade <= 10)
            {

                Console.WriteLine("Categoria Infantil");
            }

            else if (Idade >= 11 && Idade <= 17)
            {

                Console.WriteLine("Categoria Juvenil");

            }

            else if (Idade >= 18) {

                Console.WriteLine("Categoria Adulto");
            }
        
        }
    }
}
