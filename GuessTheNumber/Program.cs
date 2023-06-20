namespace GuessTheNumber
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int guess = -1;
            Random random = new Random();
            int rightNumber = random.Next(0, 100);
            int gissning = 1;

            while (guess != rightNumber)
            {
                Console.WriteLine("Guess the right number! Between 0 - 100.");
                guess = int.Parse(Console.ReadLine());

                if (guess > rightNumber)
                {
                    Console.WriteLine("För högt! Testa lite lägre.");
                    
                }

                else if (guess < rightNumber)
                {
                    Console.WriteLine("För lågt!Testa lite högre!.");
                }

                else if (guess == rightNumber)
                {
                    Console.WriteLine($"{guess} was the right number!");
                    Console.WriteLine($"Det tog dig endast{gissning} försök!");

                }

                else if (guess > 100 || guess < 0)
                {
                    Console.WriteLine("Numret är antigen under/över 100!!");
                }

                gissning++;
            }

        }
    }
}