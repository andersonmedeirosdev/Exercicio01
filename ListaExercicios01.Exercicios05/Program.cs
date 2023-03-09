namespace ListaExercicios01.Exercicios05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programar para medir é o volume de uma esfera 

            double volume, diametro, raio;

            Console.WriteLine("Insira o valor do diametro para que o programa calcule o volume da esfera:\n");

            Console.Write("Diametro: ");
            diametro = Convert.ToDouble(Console.ReadLine());

           raio  = diametro / 2;

            volume = (4/3) * 3.14 * (raio * raio * raio);

            volume = Math.Round(volume, 2);

            Console.WriteLine("O volume da esfera é: " + volume);
            Console.ReadLine();
        }
    }
}