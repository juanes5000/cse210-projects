using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture1 scripture = new Scripture1();
        Reference reference = new Reference();
        Console.WriteLine("Welcome to scripture memorizer program");
        Console.WriteLine(reference.StringReference()+ " " + scripture.GetRenderedText());
        Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideWords(3);
            Console.WriteLine(reference.StringReference()+ " " + scripture.GetRenderedText());
           

            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        }
    }
}

