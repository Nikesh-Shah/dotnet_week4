namespace Task_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = 5;
            string name="Nikesh";
            ParameterDemo parameterDemo = new ParameterDemo();
            Console.WriteLine(parameterDemo.Increase(ref number));
            Console.WriteLine(parameterDemo.GetFullName(out name));
            Console.WriteLine(parameterDemo.SumAll(1, 2, 3, 4, 25));
        }
    }
}