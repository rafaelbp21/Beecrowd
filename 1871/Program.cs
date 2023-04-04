using System.Text.RegularExpressions;

namespace _1871
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] lista = Console.ReadLine().Split(' ');
                int A = int.Parse(lista[0]);
                int B = int.Parse(lista[1]);

                if (A == 0 && B == 0)
                    break;
                int soma = A + B;
                string resultado = Convert.ToString(soma);
                resultado = Regex.Replace(resultado, "0", "");
                Console.WriteLine($"{resultado}");

            }
        }
    }
}