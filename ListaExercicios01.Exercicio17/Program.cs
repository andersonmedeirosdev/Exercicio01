namespace ListaExercicios01.Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa para saber se a + b é maior que c.

            int a, b, c, soma;

            Console.WriteLine("Qual o valor de A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o valor de B: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o valor de C: ");
            c = Convert.ToInt32(Console.ReadLine());

            soma = a + b;

            if (soma < c)
            {
                Console.WriteLine("A soma é menor que C, e o resultado é: " + soma);
            }
            else
            {
                Console.WriteLine("O valor da soma é maior do que c.");
            }

            Console.ReadLine();
        }
    }
}