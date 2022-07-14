class DivisibleFour
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Please input an integer value (n):");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 4 == 0 && i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        catch (System.Exception)
        {
            Console.WriteLine("An Error Occurred");
        }
    }
}