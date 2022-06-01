
    internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            do
            {
                Console.WriteLine("Введите первое дробное:");
                double first = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе дробное:");
                double second = double.Parse(Console.ReadLine());
                Console.WriteLine("Ответ " + Math.Pow(first, second));
                while (true) ;
            }
            while (true);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}
