using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");
        List <int> numbers = new List<int>();
        int userNumber = -1;

        do
        {
            Console.WriteLine("Enter a series of numbers. Stop at 0. ");

            string userInput = Console.ReadLine();
            userNumber =  int.Parse(userInput);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        }   while (userNumber != 0);
        //find sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}. ");
        //find average
        float average =((float) sum) / numbers.Count;
        Console.WriteLine($"The average is {average}. ");
        
        //find the maximum

        int max = numbers [0];
        foreach (int number in numbers)
        {
           if (number > max)
           {
            max = number;
           }
        }
        Console.WriteLine($"The max is {max}. ");
    }
}