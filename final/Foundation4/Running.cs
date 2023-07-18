using System;

public class Running : Activity
{
    private int _distance;

    public Running(int lengthActivity, int dateInMinutes, int distance) 
        : base(lengthActivity, dateInMinutes)
    {
        _distance = distance;
    }

    public int DisplayDistance()
    {
        return _distance;
    }

    public override void GetSummary()
    {

    }
}