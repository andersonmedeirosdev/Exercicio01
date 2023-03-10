namespace ListaExercicios01.Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Programa para saber se um número é primo ou não 

            int numero;
            bool primo = true;

            Console.Write("Digite um número para saber se ele é primo: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (numero < 2)
            {
                primo = false;
            } else
            {
                for (int i = 2; i <= numero / 2; i++)
                {
                    if (numero % i == 0) {
                        primo = false;
                        break;
                    }
                }
            }

            if (primo)
            {
                Console.WriteLine("Este número é primo.");
            }
            else
            {
                Console.WriteLine("Este número não é primo.");
            }
            Console.ReadLine();
        }
    }
}