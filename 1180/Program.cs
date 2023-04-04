namespace _1180
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] x = new int[n];

            string[] valores = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                x[i] = int.Parse(valores[i]);
            }

            int menor = x[0];
            int posicaoMenor = 0;

            for (int i = 1; i < n; i++)
            {
                if (x[i] < menor)
                {
                    menor = x[i];
                    posicaoMenor = i;
                }
            }

            Console.WriteLine("Menor valor: " + menor);
            Console.WriteLine("Posicao: " + posicaoMenor);
        }
    }
}