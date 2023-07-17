using System;

public class Lectures : Event
{
    private String _speakerName;

    private int _capacity;

    public Lectures(string eventTitle, string description, int date, int time, string speakerName, int capacity) 
        : base(eventTitle, description, date)
    {
        _speakerName =  speakerName;
        _capacity =     capacity;
    }

    public string GetLectureDetails()
    {
        return $"Speaker: {_speakerName}, Capacity for this function: {_capacity}";
    }
}