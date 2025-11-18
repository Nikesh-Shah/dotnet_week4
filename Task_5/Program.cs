namespace Task_5 
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the days(Sunday-Saturday):....... ");
            String day = Console.ReadLine().Trim().ToLower();

            if (day == "friday" || day == "Saturday")
            {
                Console.WriteLine(DayType.Weekend);
            }
            else
            {
                Console.WriteLine(DayType.Weekday);
            }

            Console.WriteLine($"You entered: {day.ToUpper()}");
        }
    }
}
