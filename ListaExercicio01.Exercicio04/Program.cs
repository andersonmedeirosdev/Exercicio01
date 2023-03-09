namespace ListaExercicio01.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa para calcular o consumo de combustível

            double kminicial, kmfinal, kmtotal, consumo, litrosgastos;

            Console.WriteLine("Consumo de Combustível");

            do
            {
                Console.Clear();

                Console.WriteLine("Qual foi a kilometragem inicial do veículo?");
                kminicial = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Qual foi a kilometragem final do veículo?");
                kmfinal = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("A kilometragem final deve ser maior que a inicial, por favor, tente novamente");
                continue;


            } while (kminicial > kmfinal);

            kmtotal = kmfinal - kminicial;

            Console.WriteLine("Quantos litros foram gastos?");
            litrosgastos = Convert.ToDouble(Console.ReadLine());

            consumo = kmtotal / litrosgastos;

            Console.WriteLine("Minha média de consumo foi: " + consumo + " km/l");
            Console.ReadLine();
        }
    }
}