namespace PW_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter month number: ");
            Month MonthData = (Month)int.Parse(Console.ReadLine());

            int MonthID = (int)MonthData;
            if (MonthID < 1 || MonthID > 12)
                Console.WriteLine("Wrong number");

            else
                Console.WriteLine(MonthData);

            Console.WriteLine("Enter second month number: ");
            Month MonthData2 = (Month)int.Parse(Console.ReadLine());

            int MonthID2 = (int)MonthData2;
            if (MonthID2 < 1 || MonthID2 > 12)
                Console.WriteLine("Wrong number");

            else
                Console.WriteLine(MonthData2);
        }
    }
}
