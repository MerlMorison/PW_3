namespace PW_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter the first number: ");
            var value1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the second number: ");
            var value2 = int.Parse(Console.ReadLine());

            var result = value1 < value2 ? ($"{value2} is bigger") : ($"{value1} is bigger");

            Console.WriteLine(result);
        }
    }
}
