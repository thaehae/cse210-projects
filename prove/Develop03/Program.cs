using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        string userInput = "";

        Reference reference = new Reference("2 Timothy", 1, 7);
        Scripture scripture = new Scripture(reference, "For God hath not given us the spirit of fear; but of power, and of love, and of a sound mind.");

        while (userInput != "quit")
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            userInput = Console.ReadLine();
            //scripture.HideRandomWords();
            //Console.Clear();
        }
        
    }
}