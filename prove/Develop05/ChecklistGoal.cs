using System;

public class ChecklistGoal : Goal

{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string stringName, string description, string points, int amountCompleted, int target, int bonus)
        : base(stringName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public void RecordEvent()
    {

    }

    public bool isComplete()
    {

    }

    public string GetDetailsString()
    {
        
    }

    public override string GetStringRepresentation()
    {
        
    }


}