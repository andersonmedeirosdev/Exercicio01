namespace ListaExercicios01.Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exibir a área do terreno.

            double largura, comprimento, area;

            Console.WriteLine("Forneça as seguintes informações para saber a área do terreno: \n");

            Console.Write("Comprimento: ");
            comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Largura: ");
            largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            area = comprimento * largura;

            Console.WriteLine("A area do terreno da Imobiliária Imóbilis é: " + area + " metros");
            Console.ReadLine();
        }
    }
}