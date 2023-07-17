using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation3 World!");

        Console.WriteLine("Standard message - Receptions");
        Event r1 = new Event("High Tea at Grand Hotel", "For elite hair stylists awards", 2023);
        Console.WriteLine(r1.GetEventDetails());
        Console.WriteLine(r1.GetReceptionAddress());

        Console.WriteLine("Full message - Lectures");
        Event l1 = new Event("Environmental Symposium 2023", "Statistics & Geology report on Hawaii volcanos", 2024);
        Console.WriteLine(l1.GetEventDetails());
        Console.WriteLine(l1.GetLectureAddress());
        Console.WriteLine(l1.GetLectureDetails());

        Console.WriteLine("Short message - Outdoor Gathering");
        Event o1 = new Event("Mad Hatters Luncheon", "Lawn games with finger foods and mocktails", 2024);
        Console.WriteLine(o1.GetEventDetails());
    }
}