namespace Task_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("ROhan", 22, "15th Grade");
            Student student2 = new Student("Madan", 24, "15th Grade");
            Console.WriteLine($"School:{Student.SchoolName} Student 1: Name={student1.Name}, Age={student1.Age}, Grade={student1.Grade}");
            Console.WriteLine($"School:{Student.SchoolName}Student 2: Name={student2.Name}, Age={student2.Age}, Grade={student2.Grade}");
        }
    }


}