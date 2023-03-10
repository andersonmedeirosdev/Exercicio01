using System.Runtime.Serialization;

namespace ListaExercicios01.Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça a soma ou multiplicação entre A e B.

            int a, b;

            Console.Write("Digite o valor de A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite o valor de B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if ( a == b)
            {
                int soma = a + b;
                Console.Write("Somando pois os números são iguais: " + soma);
            } else
            {
                int multi = a * b;
                Console.Write("Multiplicando pois os números são diferentes: " + multi);
            }

            Console.ReadLine();
        }
    }
}