namespace GuessTheNumber
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int guess = -1;
            Random random = new Random();
            int rightNumber = random.Next(0, 10);

            while (guess != rightNumber)
            {
                Console.WriteLine("Guess the right number! Between 0 - 10.");
                guess = int.Parse(Console.ReadLine());
                if (guess == rightNumber)
                {
                    Console.WriteLine("You guess the right number!");
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
            }
            Console.WriteLine($"{guess} was the right number!");

        }
    }
}