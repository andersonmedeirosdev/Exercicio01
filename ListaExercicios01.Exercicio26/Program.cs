namespace ListaExercicios01.Exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sequencia de valores do calculo de A!
            int a;

            Console.WriteLine("Digite o valor de A para ver a sequêncie do calculo: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = a -1 ; i >= 0; i--)
            {
                a = a * i;
            }

            Console.Write(a);

            Console.ReadLine();
        }
    }
}