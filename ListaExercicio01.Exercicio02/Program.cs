namespace ListaExercicio01.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mudar a temperatura de fahrenheit para celsius

            double fahrenheit, celsius;

            Console.WriteLine("Digite a temperatura em F° para saber a temperatura em C°");

            Console.WriteLine("Quantos F° está fazendo neste momento?");
            fahrenheit = Convert.ToDouble(Console.ReadLine());

            celsius = (fahrenheit - 32.0) / 1.8;
            celsius = Math.Round(celsius, 2);

            Console.WriteLine("Hoje fazendo " + celsius + "°C neste momento");
            Console.ReadLine();
        }
    }
}