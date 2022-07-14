class Repitition
{
    static void Main(string[] args)
    {
        int sum = 0;
        double average;
        int upperbound = 100;

        //for (int number = 1; number <= upperbound; number++)
        //{
        //    sum += number;
        //}

        //int number = 1;
        //while (number <= upperbound)
        //{
        //    sum += number;
        //    number++;
        //}

        int number = 1;
        do
        {
            sum += number;
            number++;
        } while (number <= 100);

        average = (double)sum / upperbound;
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Sum: {sum}");
    }
}