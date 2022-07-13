class IfStatement
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number (as an integer): ");
        try
        {
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 1)
            {
                Console.WriteLine("ONE");
            }
            else if (number == 2)
            {
                Console.WriteLine("TWO");
            }
            else if (number == 3)
            {
                Console.WriteLine("THREE");
            }
            else if (number == 4)
            {
                Console.WriteLine("FOUR");
            }
            else if (number == 5)
            {
                Console.WriteLine("FIVE");
            }
            else if (number == 6)
            {
                Console.WriteLine("SIX");
            }
            else if (number == 7)
            {
                Console.WriteLine("SEVEN");
            }
            else if (number == 8)
            {
                Console.WriteLine("EIGHT");
            }
            else if (number == 9)
            {
                Console.WriteLine("NINE");
            }
            else
            {
                Console.WriteLine("You did not input an integer between 1 and 9.");
            }
        }
        catch
        {
            Console.WriteLine("Error!");
        };
    }
}