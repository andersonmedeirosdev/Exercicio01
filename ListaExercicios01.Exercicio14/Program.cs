namespace ListaExercicios01.Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular quantos dias de vida uma pessoa tem.

            string nome;
            int anos, diasdevida;

            Console.WriteLine("Qual é o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Adicione quantos anos você tem para saber quantos dias você tem de vida: ");
            anos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            diasdevida = 365 * anos;

            Console.WriteLine(nome + "você tem " + diasdevida + " dias de vida");
            Console.ReadLine();
        }
    }
}