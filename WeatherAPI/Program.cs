using Newtonsoft.Json.Linq;

//var client = new HttpClient();

//var APIkey = "9c8e7b682ff697f406da2117299f305c";
//Console.Write("What city are you in? ");
//var cityName = Console.ReadLine();

//var server = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={APIkey}&units=imperial";

//var serverResponse = client.GetStringAsync(server).GetAwaiter().GetResult();
//var serverObject = JObject.Parse(serverResponse);

//Console.WriteLine($"The current weather at {cityName} is: {serverObject["main"]["temp"]}");


var client = new HttpClient();

Console.WriteLine("What is your zip code? ");
var zipCode = Console.ReadLine();
var APIkey = "9c8e7b682ff697f406da2117299f305c";
var server1 = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={APIkey}&units=imperial";
var server2 = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={APIkey}&units=metric";

var serverResponse1 = client.GetStringAsync(server1).Result;
var serverResponse2 = client.GetStringAsync(server2).Result;
var serverObject1 = JObject.Parse(serverResponse1);
var serverObject2 = JObject.Parse(serverResponse2);

Console.WriteLine($"Current weather for {zipCode} is: {serverObject1["main"]["temp"]} Fahrenheit");
Console.WriteLine($"Current weather for {zipCode} is: {serverObject2["main"]["temp"]} Celcius");


