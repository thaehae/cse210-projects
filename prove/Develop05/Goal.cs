using System;

public abstract class Goal

{
    private string _stringName;
    private string _description;
    private string _points;

    public Goal(string stringName, string description, string points)
    {
        _stringName = stringName;
        _description = description;
        _points = points;

    }

    public void RecordEvent()
    {

    }

    public bool IsComplete()
    {

    }

    public string GetDetailsString()
    {

    }

    public abstract string GetStringRepresentation();
    
}