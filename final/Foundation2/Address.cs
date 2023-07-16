using System;

public class Address
{

    private string _streetAddress;

    private string _city;

    private string _stateProvince;

    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress =    streetAddress;
        _city=              city;
        _stateProvince =    stateProvince;
        _country =          country;

    }

    public void InCountryOrNo()
    {
        
    }

    public void SetClientAddress()
    {

    }

    public void GetClientAddress()
    {

    }

    public void DisplayAddress()
    {
        Console.WriteLine($"Address: {_streetAddress}, City: {_city}, State?Province {_stateProvince}, Country: {_country}");
    }
}