class ExceptionHandling
{
    // creating array of 5 integer elements
    public static int[] myArr = new int[5];

    static void Main(string[] args)
    {
        // taking 5 integer from user and storing it into array
        Console.WriteLine("--Enter 5 array elements--");
        for(int i = 0; i < 5; i++)
        {
            Console.Write($"Enter {i + 1} element: ");
            myArr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("-------------------");
        try
        {
            // iterating loop multiple times to generate exception
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"{i} : {myArr[i]}");
            }
        }
        catch (Exception ex)
        {
            // catch block will be executed when exception occurs and prints appropriate message
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            // finally block will executed regardless of the occurrence of exception
            Console.WriteLine("This is finally block.");
        } 
    }
}
