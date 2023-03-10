namespace ListaExercicios01.Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa para calcular o volume de uma lata de oleo

            double raio, altura, volume;

            Console.WriteLine("Para calcular o volume de uma lata de óleo forneça os seguintes dados:");

            Console.WriteLine();

            Console.Write("Raio: ");
            raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            volume = 3.14 * (raio * raio) * altura;

            Console.Write("O volume da lata de óleo é: " + volume);
            Console.ReadLine();
        }
    }
}