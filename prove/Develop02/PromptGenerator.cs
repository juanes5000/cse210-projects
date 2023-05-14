using System;
using System.Collections.Generic;
using System.IO;
public class PromtGenerator
{
    Random rd = new Random();
    public List<string> _prompts= new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    public String DisplayPromt()
    {
        int rand_num = rd.Next(4);
        String _promt = _prompts[rand_num];
        Console.WriteLine(_promt);
        return _promt;

    }
    
}