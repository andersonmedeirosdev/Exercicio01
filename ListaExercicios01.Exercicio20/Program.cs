namespace ListaExercicios01.Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verificar se um número é par ou impar 

            int number;

            Console.Write("Digite um número para saber se é impar ou par: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (number % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            } else
            {
                Console.WriteLine("O número é impar.");
            }

            Console.ReadLine();
        }
    }
}