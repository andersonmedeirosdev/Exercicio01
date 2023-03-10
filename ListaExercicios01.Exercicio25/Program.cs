namespace ListaExercicios01.Exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fazer a taboada de 10

            Console.WriteLine("Digite um número para ver a tábuada de 10: \n");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

        for (int i = 0; i <= 10; i++)
            {   

                int tabuada = i * number;

                Console.WriteLine(i + "X" + number + "=" + tabuada);
            }
        }
    }
}