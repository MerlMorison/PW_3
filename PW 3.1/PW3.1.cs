namespace PW_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter the number: ");
            int value = int.Parse(Console.ReadLine());
            if (value > 0)
                Console.WriteLine($"Number {value} is positive");
            else if (value < 0)
                Console.WriteLine($"Number {value} is negative");
            else
                Console.WriteLine($"Number {value} is 0");
        }
    }
}
