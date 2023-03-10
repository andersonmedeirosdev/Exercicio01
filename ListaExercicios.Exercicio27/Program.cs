namespace ListaExercicios.Exercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci

            int primeiron = 0, segundon = 1, qtd = 20;

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