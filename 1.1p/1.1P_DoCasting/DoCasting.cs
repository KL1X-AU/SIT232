class DoCasting
{
    static void Main(string[] args)
    {
        int sum = 17;
        int count = 5;

        int intAverage;
        intAverage = sum / count;
        Console.WriteLine(intAverage);

        double doubleAverage;
        doubleAverage = sum / count;
        Console.WriteLine(doubleAverage);

        Console.WriteLine((double)sum / count);
    }
}