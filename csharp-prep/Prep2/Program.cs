using System;

class Program
{
    static void Main(string[] args)
    {
        String letter = "";
        Console.WriteLine("What is you grade percentage? ");
        String grade = Console.ReadLine();
        int number = int.Parse(grade);

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"your letter grade is: {letter}");
    }
}