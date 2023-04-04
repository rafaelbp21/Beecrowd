namespace _1397
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int casos = int.Parse(Console.ReadLine());
                if (casos == 0)
                    break;
                int jogador1 = 0;
                int jogador2 = 0;
                for (int i = 0; i < casos; i++)
                {

                    string[] numb = Console.ReadLine().Split(' ');
                    int a = int.Parse(numb[0]);
                    int b = int.Parse(numb[1]);
                    if (a > b)
                    {
                        ++jogador1;
                    }
                    else if (b > a)
                    {
                        ++jogador2;
                    }
                }
                Console.WriteLine($"{jogador1} {jogador2}");
            }
        }
    }
}