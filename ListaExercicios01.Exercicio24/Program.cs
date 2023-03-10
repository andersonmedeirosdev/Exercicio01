namespace ListaExercicios01.Exercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ver todos os números impares de 0 a 100

            Console.WriteLine("Aperte enter para saber a soma dos números impares de 0 a 500: \n");

            int soma = 0;
            for (int i = 1; i <= 500; i += 2)
            {
                soma += i;
            }

            Console.ReadLine();

            Console.WriteLine("A soma dos números impares de 0 a 500 é: " + soma);

        }
    }
}