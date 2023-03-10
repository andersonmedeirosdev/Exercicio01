namespace ListaExercicios.Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa para padaria.

            decimal paesvendidos, broasvendidas, valorpaes, valorbroas, total, poupar;

            Console.WriteLine("Quantidade de pães vendidos? ");
            paesvendidos = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Quantidade de broas vendidas? ");
            broasvendidas = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            valorpaes = paesvendidos * 0.12M;
            valorbroas = broasvendidas * 1.50M;

            total = valorpaes + valorbroas;

            Console.WriteLine("O valor arrecado foi: " + total);

            poupar = total * 0.1M;

            Console.WriteLine("O valor que deve ser poupado é: " + poupar);

            Console.ReadLine();
        }
    }
}