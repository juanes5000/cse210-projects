using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {

        Journal1 journal = new Journal1();
        int n;
        
        do
        {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select on of the following choices: ");
        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");
        n=int.Parse(Console.ReadLine());
        
        if(n==1)
        { 
            journal.AddingEntry();
        }
        else if(n==2)
        {
            journal.DisplayingAllEntries();
        }
        else if(n==3)
        {
            Console.WriteLine("What is the name of the file?");
            string filename = Console.ReadLine();
            journal.LoadingFromFile(filename);
        }
        else if(n==4)
        {
            journal.SaveToFile(journal._entrys);
        }

        }while(n != 5);
    }
}
