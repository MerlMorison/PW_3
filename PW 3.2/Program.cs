namespace PW_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter the number: ");
            var value = int.Parse(Console.ReadLine());

            if (value >= 10 && value <= 20)
            {
                Console.WriteLine("value >= 10 and value <= 20");
            }
            else if (value >= 30 && value <= 40)
            {
                Console.WriteLine("value >= 30 and value <= 40");
            }
            else
            {
                Console.WriteLine($"Enother value");
            }
        }
    }
}
