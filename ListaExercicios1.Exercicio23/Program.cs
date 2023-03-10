namespace ListaExercicios1.Exercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ver todos os números impares de 0 a 100

            Console.WriteLine("Aperte enter para ver todos os números impares de 0 a 100:");

            for (int i = 1; i <= 100; i+=2)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}