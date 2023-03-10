namespace ListaExercicios01.Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular o IMC de uma pessoa.

            double imc, peso, altura;

            Console.WriteLine("Informe os seguintes dados para calcular o IMC: \n");

            Console.WriteLine("Qual é o seu peso?");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Qual é a sua altura?");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            imc = peso / (altura * altura);

            Console.Write(imc);
            Console.WriteLine();



            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso.");
            } 
            else if (imc >= 18.5 && imc <= 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc > 25 && imc <= 30)
            {
                Console.WriteLine("Acima do peso.");
            } else
            {
                Console.WriteLine("Obeso.");
            }

            Console.ReadLine();
        }
    }
}