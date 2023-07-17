using System;

public class OutdoorGatherings : Event
{
   private string _weatherForecast;

   public OutdoorGatherings(string eventTitle, string description, int date, int time, string weatherForecast) 
    : base(eventTitle, description, date)
   {
      _weatherForecast = weatherForecast;
   }

   public string GetOutdoorGatheringDetails()
   {
      
      return $"Weather Forecast for Outdoor Gatherings: {_weatherForecast}";
   }
}