using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");

        DisplayWelcomeMessage();

        string useMyName = PromptUserName();
        int useMyNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(useMyNumber);
        DisplayAnswer(useMyName, squaredNumber);    
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Enter your favourite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayAnswer(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}. ");
    }
}