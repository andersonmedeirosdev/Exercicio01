namespace ListaExercicio01.Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa para mudar de celsius para Fahrenheit

            double fahrenheit, celsius;

            Console.WriteLine("Digite a temperatura em C° para saber a temperatura em F°\n");

            Console.WriteLine("Quantos C° está fazendo neste momento?");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = (celsius * 1.8) + 32;

            Console.WriteLine();

            Console.WriteLine("Está fazendo " + fahrenheit + "°F neste momento");
            Console.ReadLine();
        }
    }
}