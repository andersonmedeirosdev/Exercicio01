namespace ListaExercicios01.Exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fazer a taboada de 10

            Console.WriteLine("Digite enter pra ver a tábuada de 10: \n");
            Console.ReadLine();

        for (int i = 0; i <= 10; i++)
            {
                int tabuada = i * 10;

                Console.WriteLine(i + "X" + i + "=" + tabuada);
            }
        }
    }
}