namespace ListaExercicios01.Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa para calcular a média das notas de um aluno.

            double media, n1, n2, n3, n4;

            Console.WriteLine("Preencha os seguintes dados para calcular a média: ");

            Console.Write("Nota 1: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Nota 2: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Nota 3: ");
            n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Nota 4: ");
            n4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            media = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine("A média do aluno é: " + media);
            Console.ReadLine();
        }
    }
}