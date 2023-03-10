namespace ListaExercicios.Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa para mudar de celsius para Fahrenheit

            double fahrenheit, celsius;

            Console.WriteLine("Para saber a temperatura em F°, digite os dados requeridos: ");

            Console.WriteLine("Qual a temperatura em C°");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = (celsius * 1.8) + 32;

            Console.WriteLine();

            Console.WriteLine(fahrenheit + "°F");
            Console.ReadLine();
        }
    }
}