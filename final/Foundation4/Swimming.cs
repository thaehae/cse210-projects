using System;

public class Swimming : Activity
{
    private int _numberLaps;
    public Swimming(int lengthActivity, int dateInMinutes, int numberLaps) 
        : base(lengthActivity, dateInMinutes)
    {
        _numberLaps = numberLaps;
    }

    public int DisplayNumberLaps()
    {
        _numberLaps = _numberlaps * 50 / 1000;
        return _numberLaps;
    }

    public override void GetSummary()
    {

    }
}