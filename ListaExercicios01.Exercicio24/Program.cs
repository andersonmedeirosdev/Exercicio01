namespace ListaExercicios01.Exercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ver todos os números impares de 0 a 500

            Console.WriteLine("Aperte enter para saber a soma dos números impares de 0 a 500 que são multiplos de 3: \n");

            int soma = 0;
            for (int i = 3; i <= 500; i += 3)
            {
                soma+= i;
            }

            Console.ReadLine();

            Console.WriteLine("A soma dos números impares de 0 a 500 que são multiplos de 3: " + soma);

        }
    }
}