using System;

public abstract class Activity
{
    private int _lengthActivity;

    private int _dateInMinutes;

    public Activity(int lengthActivity, int dateInMinutes)
    {
        _lengthActivity = lengthActivity;
        _dateInMinutes = dateInMinutes;
    }

    public void GetDistance()
    {

    }

    public void GetSpeed()
    {

    }

    public void GetPace()
    {

    }

    public void GetActivityDetails()
    {

    }

    public abstract void GetSummary()
    {
        
    }
}