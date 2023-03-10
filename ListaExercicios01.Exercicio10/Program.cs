namespace ListaExercicios01.Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa para calcular a media ponderada de um aluno

            double peso1, nota1, nota2, peso2, mediap;

            Console.WriteLine("Forneça os seguintes dados para saber a média ponderada entre duas notas: ");

            Console.Write("Nota 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Peso 1: ");
            peso1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Nota 2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Peso 2: ");
            peso2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            mediap = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

            Console.WriteLine("A média ponderada do aluno é: " + mediap);
            Console.ReadLine();
        }
    }
}