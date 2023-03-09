namespace ListaExericios01.Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular o volume de uma caixa retangular

            decimal comprimento, largura, altura, volume;

            Console.WriteLine("Calculo do volume de uma caixa retangular");

            Console.WriteLine("Adicione respectivamente os dados de comprimento, largura e altura para realizar o calculo: ");

            Console.Write("Comprimento: ");
            comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Largura: ");
            largura = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Altura: ");
            altura = Convert.ToDecimal(Console.ReadLine());

            volume = comprimento * altura * largura;

            Console.WriteLine("O volume da caixa retangulo é: " + volume);
            Console.ReadLine();
        }
    }
}