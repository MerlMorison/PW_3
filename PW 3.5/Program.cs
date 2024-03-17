namespace PW_3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.Створіть перелічення для днів тижня з вказанням числових значень для кожного дня.
            //Напишіть програму, яка приймає від користувача день тижня(у вигляді числа) і
            //виводить відповідний до нього день у текстовому форматі.

            // ^ Повністю повторює завдання 4, просто з днями тижня (або я щось не зрозуміла).
            // Я написала календарик)))

            Console.WriteLine("Enter month number: ");
            Month MonthData = (Month)int.Parse(Console.ReadLine());

            int MonthID = (int)MonthData;
            if (MonthID < 1 || MonthID > 12)
                Console.WriteLine("Wrong number");

            else
                Console.WriteLine($"This is {MonthData}");

            Console.WriteLine("Enter day number:");
            int DayID = int.Parse(Console.ReadLine());

            if (DayID < 1 || DayID > 31)
                Console.WriteLine("Wrong number");

            else
            {
                DateTime date = new DateTime(DateTime.Now.Year, MonthID, DayID);
                string dayOfWeek = date.ToString("dddd");
                Console.WriteLine($"It is {dayOfWeek}."); // нажаль, чомусь виводить тільки російською. Сорі(
            }
        }
    }
}