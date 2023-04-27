using System;

class Program
{
    static void Main(string[] args)
    {
        double guess = 0;

        Console.Write("What is the magic number? ");
        String response = Console.ReadLine();
        double number = double.Parse(response);

        while (number != guess)
        {
            Console.Write("What is your guess? ");
            String responseGuess = Console.ReadLine();
            guess = double.Parse(responseGuess);
            if (guess < number)
            {
                Console.Write(" ");
                Console.Write("Higher");
            }
            else if (guess > number)
            {
                Console.Write(" ");
                Console.Write("Lower");
            }
        }
        Console.Write("You guessed it!");
    }
}