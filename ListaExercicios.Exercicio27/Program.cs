namespace ListaExercicios.Exercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci

            int primeiron = 0, segundon = 1, qtd;

            Console.WriteLine("Coloque a quantidade de números que você quer imprimir:");
            qtd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write(primeiron + ", " + segundon + ", ");

            for (int i = 2; i < qtd; i++) { 
                int proximonumero = primeiron + segundon;
                Console.Write(proximonumero + ", ");
                primeiron = segundon;
                segundon = proximonumero;
            }

            Console.ReadLine();
        }
    }
}