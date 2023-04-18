namespace DotNetPracticals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // creating instance of ArithmeticOperations class to access methods of that class
            var result = new ArithmeticOpearions();

            // taking inputs from the user
            Console.WriteLine("Practical-01: Basic Arithmetic Operations");
            Console.Write("Enter first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // showing user inputs to the console
            Console.WriteLine("Your inputs");
            Console.WriteLine($"Number 1: {num1}");
            Console.WriteLine($"Number 2: {num2}");

            // performing basic arithmetic operations
            Console.WriteLine("Output");
            try
            {
                Console.WriteLine($"Addition: {result.addition(num1, num2)}");
                Console.WriteLine($"Subtraction: {result.subtraction(num1, num2)}");
                Console.WriteLine($"Multiplication: {result.multiplication(num1, num2)}");
                Console.WriteLine($"Division: {result.division(num1, num2)}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
