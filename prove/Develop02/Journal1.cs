using System;
using System.Collections.Generic;
using System.IO;
public class Journal1
{
    public DateTime _dt = DateTime.Now;
    public String filename = "";
    public String _text  = "";
    public List<string> _entrys = new List<string>();
    PromtGenerator promtGenerator = new PromtGenerator();
    public void AddingEntry()
    {
        String _promt = promtGenerator.DisplayPromt();
        Console.WriteLine("Please write: ");
        _text = Console.ReadLine();

        String _dateTime = _dt.ToString();
        _entrys.Add($"{_dateTime},{_promt},{_text}");
        
    } 
    public List<string> DisplayingAllEntries()
    {
        Console.WriteLine("Diesplaying from file");
        List<string> _displayEntrys = new List<string>();
        filename = "journal.txt";

        string[] lines =System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");    
            
            Console.WriteLine($"{parts[0]} - Promt: {parts[1]}");
            Console.WriteLine($"{parts[2]}");
        }
        return _displayEntrys;
    }
    public void SaveToFile(List<string> _entrys)
    {
        Console.WriteLine("What is the name of the file to save it?");
        filename = Console.ReadLine();
        
        using (StreamWriter outputFile = File.AppendText(filename))
        {
            foreach (String _entry in _entrys)
            {
                outputFile.WriteLine(_entry);
            }

        }

    }
    public String LoadingFromFile(string filename)
    {
        return filename;
    }

}