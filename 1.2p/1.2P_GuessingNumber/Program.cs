class GuessingNumber
{
   static void Main(string[] args){
        int number = 5;
        
        bool loop = true;
        do
        {
            Console.WriteLine("Enter a number between 1 and 10.");
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess == number)
            {
                Console.WriteLine("You got it!");
                loop = false;
            }
            else if (guess <= number)
            {
                Console.WriteLine("Too low.");
            }
            else if (guess >= number)
            {
                Console.WriteLine("Too high.");
            }
        } while (loop == true);
    }
}