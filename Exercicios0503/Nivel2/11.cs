using System.Globalization;

namespace Exercicios0503.Nivel2
{
    internal class AprovadoReprovado
    {
        public static void Executar() {

            Console.WriteLine("Informe a nota final do aluno: ");
            double Nota = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (Nota >= 6)
            {

                Console.WriteLine($"O aluno está aprovado. Nota: {Nota.ToString("F1",CultureInfo.InvariantCulture)}");

            }

            else {

                Console.WriteLine($"O aluno está reprovado. Nota: {Nota.ToString("F1",CultureInfo.InvariantCulture)}");
            
            }
        
        
        }
    }
}
