using System.ComponentModel.Design.Serialization;

namespace ListaExercicios01.Exercicio29
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Programa para exibiar taboada do 1 até o 10.

            for (int i = 1; i <= 10; i++)
            {
                int multi = i * i;

                Console.WriteLine(multi);
            }
        }
    }
}