using System;

public class Receptions : Event
{
    private string _emailAddress;

    public Receptions(string eventTitle, string description, int date, int time, string emailAddress) 
        : base(eventTitle, description, date)
    {
        _emailAddress = emailAddress;
    }

    public string GetReceptionEmail()
    {
        return $"Email: {_emailAddress}";
    }
}