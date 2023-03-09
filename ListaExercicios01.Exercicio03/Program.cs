namespace ListaExercicios01.Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa para calcular o volume de um cilindro 

            double raio, altura, volume;

            Console.WriteLine("Para calcular o volume de um cilindro forceça os seguintes dados:");

            Console.WriteLine();

            Console.Write("Raio: ");
            raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            volume = 3.14 * (raio * raio) * altura;

            Console.Write("O volume do cilindro é: " + volume);
            Console.ReadLine();
        }
    }
}