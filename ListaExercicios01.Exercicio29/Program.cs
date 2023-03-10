using System.ComponentModel.Design.Serialization;

namespace ListaExercicios01.Exercicio29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa para exibir taboada do 1 até o 10.

            Console.WriteLine("Aperte enter para ter acesso as tabuadas:");
            Console.ReadLine();

            for (int i = 1; i <= 10; i++)
            {
                for (int i2 = 1; i2 <= 10; i2++)
                {
                    int multi = i * i2;
                    Console.WriteLine(i + " X " + i2 + " = " + multi);
                    Console.WriteLine();

                }
            }
        }
    }
}