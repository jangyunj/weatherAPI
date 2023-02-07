using Newtonsoft.Json.Linq;

var client = new HttpClient();

var APIkey = "9c8e7b682ff697f406da2117299f305c";
Console.Write("What city are you in? ");
var cityName = Console.ReadLine();

var server = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={APIkey}&units=imperial";

var serverResponse = client.GetStringAsync(server).GetAwaiter().GetResult();
var serverObject = JObject.Parse(serverResponse);

Console.WriteLine($"The current weather at {cityName} is: {serverObject["main"]["temp"]}");


