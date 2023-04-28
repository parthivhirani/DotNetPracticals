class ExceptionHandling
{
    public static int[] myArr = new int[5];

    static void Main(string[] args)
    {
        Console.WriteLine("--Enter 5 array elements--");
        for(int i = 0; i < 5; i++)
        {
            Console.Write($"Enter {i + 1} element: ");
            myArr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("-------------------");
        try
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"{i} : {myArr[i]}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            Console.WriteLine("This is finally block.");
        } 
    }
}
