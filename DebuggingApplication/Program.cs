namespace DotNetPracticals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter anything: ");
            string userResponse = Console.ReadLine();

            if (Convert.ToBoolean(int.Parse(userResponse)))
            {
                Console.WriteLine("The entered value is a integer");
            }
            else
            {
                Console.WriteLine("Entered value is not an integer!");
            }
        }
    }
}