namespace ListaExercicios.Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mostrar números em ordem decrescente

            int n1, n2, n3;

            Console.WriteLine("Insira os números para aparecer em ordem decrescente: \n");

            Console.Write("Numero 1: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Numero 2: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Numero 3: ");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (n1 >= n2 && n1 >= n2)
            {
                if (n2 >= n3)
                {
                    Console.WriteLine("A ordem é: ");
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                } else
                {
                    Console.WriteLine("A ordem é: ");
                    Console.WriteLine(n1);
                    Console.WriteLine(n3);
                    Console.WriteLine(n2);
                }
            }

            if (n2 >= n1 && n2 >= n3)
            {
                if (n1 >= n3)
                {
                    Console.WriteLine("A ordem é: ");
                    Console.WriteLine(n2);
                    Console.WriteLine(n1);
                    Console.WriteLine(n3);
                }
                else
                {
                    Console.WriteLine("A ordem é: ");
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                    Console.WriteLine(n1);
                }
            }

            if (n3 >= n1 && n3 >= n2)
            {
                if (n1 >= n2)
                {
                    Console.WriteLine("A ordem é: ");
                    Console.WriteLine(n3);
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                }
                else
                {
                    Console.WriteLine("A ordem é: ");
                    Console.WriteLine(n3);
                    Console.WriteLine(n2);
                    Console.WriteLine(n1);
                }
            }

            Console.ReadLine();
        }
    }
}