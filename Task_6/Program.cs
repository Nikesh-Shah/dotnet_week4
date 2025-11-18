public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter Marks Obtained: ");
        String marksObtained = Console.ReadLine();


        Console.WriteLine("\n ENter Total marks: ");
        String totalMarks= Console.ReadLine();

        bool marksValid = int.TryParse(marksObtained, out int marks);
        bool totalValid = int.TryParse(totalMarks, out int total);

        if (!marksValid && totalValid)
        {
            Console.WriteLine("Invalid input. Please try again");
            return;
        }
        //This wil
        double percentage = marks / total * 100;

        double percentage1 = (double)marks / total * 100;

        Console.WriteLine($"Percentage: {percentage}");

        Console.WriteLine($" Type Cast Percentage: {percentage1}");




    }
}