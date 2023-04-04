namespace _1064;
internal class Program
{
    static void Main(string[] args)
    {
        double Num = 0;
        double x = 0;
        double media = 0;
        double cont = 0;
        double y = 0.0;

        for (int i = 0; i < 6; i++)
        {
            Num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (Num > y)
            {
                x = x + Num;
                cont++;
                media = (double)x / cont;
            }

        }

        Console.WriteLine($"{cont} valores positivos");
        Console.WriteLine($"{media:f1}");

    }
}
