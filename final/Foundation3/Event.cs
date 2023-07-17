using System;

public class Event
{
    private string _eventTitle;

    private string _description;

    private int _date; //it originally had time but I ran out of time and it kept bugging out using DateTime.Now


    public Event(string eventTitle, string description, int date)
    {
        _eventTitle =       eventTitle;
        _description =      description;
        _date =             date;

    }

    public string GetEventTitle()
    {
        return _eventTitle;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int SetDateTime()
    {
        return _date;
    }

    public string GetEventDetails()
    {
        return $"Event: {_eventTitle}, Description: {_description}, Date: {_date}";
    }


    public void SetStandardDetailsMessage()
    {
        
    }

    public void SetFullDetailsMessage()
    {

    }

    public void SetShortDescriptionMessage()
    {

    }

}