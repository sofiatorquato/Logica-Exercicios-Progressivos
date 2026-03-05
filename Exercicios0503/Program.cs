using Exercicios0503.Nivel1;
using Exercicios0503.Nivel2;

namespace Exercicios0503
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero do exercicio: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    ExercicioConta.Executar();
                    break;

                case 2:
                    ExercicioConversao.Executar();
                    break;

                case 3:
                    CalculoArea.Executar();
                    break;

                case 4:
                    TempoMinutos.Executar();
                    break;

                case 5:
                    PrecoDesconto.Executar();
                    break;

                case 6:
                    ParImpar.Executar();
                    break;

                case 7:
                    Maior2Numeros.Executar();
                    break;

                case 8:
                    Maior3Numeros.Executar();
                    break;

                    case 9:
                        CalculadoraSimples.Executar();
                    break;

                case 10:
                    VerificarIdade.Executar();  
                    break;  /*exercicio 3 - nivel 2 - https://github.com/lucasfugisawa/logica-programacao-exercicios-progressivos*/

                default:
                    Console.WriteLine("Opção inválida.");
                    break;

            }
        }
    }
}