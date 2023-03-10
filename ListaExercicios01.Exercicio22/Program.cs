using System.Runtime.Serialization;

namespace ListaExercicios01.Exercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça a soma ou multiplicação entre A e B e atribua em C.

            int a, b;

            Console.Write("Digite o valor de A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite o valor de B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (a == b)
            {
                int soma = a + b;

                int c = soma;

                Console.WriteLine("Atribuindo soma a váriavel C: " + c);
            }
            else
            {
                int multi = a * b;

                int c = multi;

                Console.WriteLine("Atribuindo multiplicação a váriavel C: " + c);
            }


            Console.ReadLine();
        }
    }
}