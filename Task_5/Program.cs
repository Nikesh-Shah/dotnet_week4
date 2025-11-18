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

            Book book1 = new Book("Atomic Habits","James Clear",1200);
            Book book2 = book1 with { title = "Rich Dad, Poor Dad", price = 1000 };
            Console.WriteLine($"First book: Title:{book1.title}, Auhor:{book1.author}, Price: {book1.price} ");

            var (title, author, price) = book2;

            Console.WriteLine("\nDeconstructed record: ");
            Console.WriteLine($"title:{title}");
            Console.WriteLine($"author:{title}");
            Console.WriteLine($"price:{price}");


        }
    }
}
