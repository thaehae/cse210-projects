using System;

public class Cycling : Activity
{
    private int _speed;
    public Cycling(int lengthActivity, int dateInMinutes, int speed) 
        : base(lengthActivity, dateInMinutes)
    {
        _speed = speed;
    }

    public int DisplaySpeed()
    {
        _speed = (distance / minutes) * 60;
        return _speed;
    }

    public override void GetSummary()
    {

    }
}