namespace Task_2
{
    public class  Program { 
    public static void Main(String[] args)
        {

            Calculator calculator = new Calculator();
            int sum = calculator.Add(5, 10);
            int product = calculator.multiply(5);
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Multiply: {product}");
        }
    }
    
}