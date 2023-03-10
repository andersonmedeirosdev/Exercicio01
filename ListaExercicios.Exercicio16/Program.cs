namespace ListaExercicios.Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular salário de um fúncionario.

            decimal salarioinicial, salarioaumento, salariofinal, impostos = 0.08M, aumento = 0.15M;

            Console.WriteLine("Qual é o salário inicial?");
            salarioinicial = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            salarioaumento = (salarioinicial * aumento) + salarioinicial;

            salariofinal = salarioaumento - (salarioaumento * impostos);

            Console.WriteLine("O salário inicial é: " + salarioinicial + "\n");
            Console.WriteLine("O salário com aumento é: " + salarioaumento + "\n");
            Console.WriteLine("o salário final é: " + Math.Round(salariofinal , 2));

            Console.ReadLine();
        }
    }
}