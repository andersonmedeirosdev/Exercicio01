using System.Runtime.Intrinsics.X86;

namespace ListaExercicios01.Exercicio28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa para verificar o multiplos de 3 e 5.

            Console.WriteLine("Aperte enter para verificar os multiplos de 3 e de 5.");
            Console.WriteLine("Se aparecer FizBuzz é multiplo de 3 e 5. Fizz é multiplo de 3. Buzz é multiplo de 5.");
            Console.ReadLine();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");   
                } else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                } else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                } else
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}