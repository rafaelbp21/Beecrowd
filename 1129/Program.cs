namespace _1129
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                int casos = int.Parse(Console.ReadLine());
                if (casos == 0)
                       break;

                    for (int i = 0; i < casos; i++)
                    {

                        string[] numb = Console.ReadLine().Split(' ');
                        int a = int.Parse(numb[0]);
                        int b = int.Parse(numb[1]);
                        int c = int.Parse(numb[2]);
                        int d = int.Parse(numb[3]);
                        int e = int.Parse(numb[4]);
                        if (a <= 127 && b > 127 && c > 127 && d > 127 && e > 127)
                        {

                            Console.WriteLine("A");
                        }
                        else if (a > 127 && b <= 127 && c > 127 && d > 127 && e > 127)
                        {
                            Console.WriteLine("B");
                        }
                        else if (a > 127 && b > 127 && c <= 127 && d > 127 && e > 127)
                        {
                            Console.WriteLine("C");
                        }
                        else if (a > 127 && b > 127 && c > 127 && d <= 127 && e > 127)
                        {
                            Console.WriteLine("D");
                        }
                        else if (a > 127 && b > 127 && c > 127 && d > 127 && e <= 127)
                        {
                            Console.WriteLine("E");
                        }
                        else
                        {
                            Console.WriteLine("*");
                        }
                    }
            }
        }
    }
}