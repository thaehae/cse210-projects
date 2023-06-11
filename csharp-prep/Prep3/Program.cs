using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");
        //Console.Write("What is the magic number? ");
        //int number = int.Parse(Console.ReadLine());

        //Console.Write("What is your guess? ");
        //int userNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int userNumber = -1;

        do
        {
           Console.Write("What is your guess? ");
           userNumber = int.Parse(Console.ReadLine()); 

            if (number > userNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (number < userNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }   while (userNumber != number);
    }
}