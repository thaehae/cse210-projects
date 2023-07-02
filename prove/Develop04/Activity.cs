public class Activity

{
    private string _activityName;
    private string _description;
    static int spinnerCounter, _duration;

    public Activity()
    {
        spinnerCounter = _duration = 0;
    }

    public void SetActivityName(string _activityName)

    {
        name = _activityName;
        
    }

    public void SetDescription(string _description)
    {
        description = _description;
    }

    public int GetDuration(int duration)
    {
        return duration;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {name}");
        Console.WriteLine();
        Console.WriteLine(description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {duration} seconds of the {name}.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int numSecondsToRun)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        while (stopwatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            spinnerCounter++;
            switch (spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200)Position(Console.CursorLeft - 1, Console.CursorTop);
        }   Thread.Sleep(200);
        Console.Write(" ");
    }
    public void ShowCountdown(int numSecondsToRun)
    {
        for (int i = numSecondsToRun; i >= 1; i--)
        
        {   Console.Write(string.Format("{0}", i));
            Console.WriteLine(string.Format("{0}", i));
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }   Thread.Sleep(1000);
        Console.Write(" ");
    }
}