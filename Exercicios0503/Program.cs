using Exercicios0503.Nivel1;
using Exercicios0503.Nivel2;
using Exercicios0503.Nivel3;

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

                case 11:
                    AprovadoReprovado.Executar();
                    break;

                case 12:
                    Senha.Executar();
                    break;

                case 13:
                    Idade.Executar();
                    break;

                case 14:
                    IMC.Executar();
                    break;

                case 15:
                    Contagem.Executar();
                    break;

                case 16:
                    TabuadaFor.Executar();
                    break;

                case 17:
                    SomaDeTodos.Executar();
                    break;

                case 18:
                    Fatorial.Executar();
                    break;

                case 19:
                    ParesAte50.Executar();
                    break;

                case 20:
                    Fibonacci.Executar();
                    break;

                case 21:
                    Validacao.Executar();
                    break;
                case 22:
                    ContagemRegressiva.Executar();
                    break;

                case 23:
                    NumeroPrimo.Executar();
                    break;

                case 24:
                    Aleatorio.Executar();
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;

            }
        }
    }
}