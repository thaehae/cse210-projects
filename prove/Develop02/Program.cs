using System;

class Program
{
    static void Main(string[] args)
    {
        PromptMenu promptMenu = new PromptMenu();
        Journal journal =       new Journal();
        int                     menuUserInput = 0;
        List<string>            menu = new List<string>
        {
            "Please choose one of the following: ",
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Exit",
            "What do you choose? "
        };
        Console.WriteLine("Welcome to the Journal program");

        while(menuUserInput != 5)
        {
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
         
            menuUserInput = int.Parse(Console.ReadLine());

            switch(menuUserInput)
            {
                case 1:
                    string prompt = promptMenu.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write(">");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.Date.ToString("MMM, dd, yyyy");
                    Entry entry = new Entry(date, prompt, response);
                    journal.AddEntry(entry);
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine("Name for file to load? ");
                    string fileNameLoad = Console.ReadLine();
                    journal.LoadFromFile(fileNameLoad);
                    break;
                case 4:
                    Console.WriteLine("Name of file to save? ");
                    string fileNameSave = Console.ReadLine();
                    journal.SaveToFile(fileNameSave);
                    break;
            }
        }
    }
}