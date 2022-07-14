class Microwave
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("How many items are you microwaving?");
            uint number = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("How long does it take to microwave a single item?");
            // We can have half minutes, hence (double)
            double time = Convert.ToDouble(Console.ReadLine());

            if (number == 1)
            {
                Console.WriteLine($"Microwave time: {time}");
            }
            else if (number == 2)
            {
                Console.WriteLine($"Microwave time: {time * 1.5}");
            }
            else if (number == 3)
            {
                Console.WriteLine($"Microwave time: {time * 2}");
            }
            else if (number > 3)
            {
                Console.WriteLine($"We do not recommend you microwave {number} items.");
            }
            else if (number == 0)
            {
                Console.WriteLine("You can't microwave nothing...");
            }
        }
        catch (System.Exception)
        {
            Console.WriteLine("Error");
        }
    }
}