using System;

public class Address : Event
{
    private string _lecturesAddress;
    private string _outdoorGatheringsAddress;

    private string _receptionsAddress;

    public Address(string eventTitle, string description, int date, string lecturesAddress, string outdoorGatheringsAddress, string receptionsAddress) 
        : base (eventTitle, description, date)
    {
        _lecturesAddress =             lecturesAddress;
        _outdoorGatheringsAddress =    outdoorGatheringsAddress;
        _receptionsAddress =           receptionsAddress;

    }

    public string GetLecturesAddress()
    {
        return _lecturesAddress;       
    }

    public string GetReceptionsAddress()
    {
        return _receptionsAddress;       
    }

    public string GetOutdoorGatheringsAddress()
    {
        return _outdoorGatheringsAddress;       
    }
}