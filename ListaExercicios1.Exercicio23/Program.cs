namespace ListaExercicios1.Exercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ver todos os números impares de 0 a 100

            Console.WriteLine("Aperte enter para ver todos os números impares entre 100 e 200:");
            Console.ReadLine();

            for (int i = 101; i >= 100 && i <= 200; i+=2)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}