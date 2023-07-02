public class BreathingActivity : Activity

{
    public BreathingActivity() //string name, string description, int duration) 
        //: base(name, description, duration)
    {
        this.SetActivityName("Breathing Activity");
        this.SetDescription("This activity will help you relax by walking you " +
            "through breathing in and out slowly. " +
            "Clear your mind and focus on your breathing");
    }

    public void Run()
    {
        DisplayStartMessage();
        int interval = GetDuration() / 6;
        for (int i = 0; i <= 2; i++)
        {
            Console.WriteLine();
            Console.Write("Breath in ...");
            ShowCountdown(interval);
            Console.WriteLine();
            Console.Write("Breath out ...");
            ShowCountdown(interval);
            Console.WriteLine();
        }
        DisplayEndMessage();
    }

    

}


