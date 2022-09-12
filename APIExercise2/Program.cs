using APIExercise2;
using Newtonsoft.Json.Linq;

var key = File.ReadAllText("mapapp.json");
var APIKey = JObject.Parse(key).GetValue("APIKey"); //ToString();
Console.WriteLine("Enter name of a city");
var cityName = Console.ReadLine();
var apiCall = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&units=imperial&appid={APIKey}";
Console.WriteLine();


Console.WriteLine($"The temperature in {cityName} is {WeatherMap.Temp(apiCall)}");