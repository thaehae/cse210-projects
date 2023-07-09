using System;

class Program
{
    static void Main(string[] args)
    {
        int             menuUserInput = 0;

        List<string>    menu = new List<string>
        {
            "Menu Options: ",
            "1. Create new goal",
            "2. List goals",
            "3. Save goals",
            "4. Load goals",
            "5. Record event",
            "6. Quit"
        };

        while(menuUserInput != 6)
        {
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.WriteLine("Select a choice from the menu: ");
            menuUserInput = int.Parse(Console.ReadLine());

            switch(menuUserInput)
            {
                case 1:
                    
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                case 4:
                    
                    break;
                case 5:
                    
                    break;
            }
        }
    }
}