namespace ListaExercicio01.Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa para calcular salário total de um vendedor

            double salariototal, salariobase, totalvendas, comissao, porcentagemcomissao;

            Console.WriteLine("Para calcular o salário total, preencha os seguintes dados: \n");


            Console.Write("Salário base: ");
            salariobase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Total de vendas: ");
            totalvendas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Comissão: ");
            comissao = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            porcentagemcomissao = (comissao / 100) * totalvendas;

            salariototal = salariobase + porcentagemcomissao;

            Console.WriteLine("O salário total do vendedor é: " + salariototal);
            Console.ReadLine();
        }
    }
}