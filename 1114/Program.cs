namespace _1114
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int A = int.Parse(Console.ReadLine());
                if (A == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                }

            }
        }
    }
}