using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

public class Alien
{
    public int Strength { get; set; }
    public int Speed { get; set; }
    public int Health { get; set; }

    public Alien(int strength, int speed, int health)
    {
        Strength = strength;
        Speed = speed;
        Health = health;
    }
}

public class TeamData
{
    public List<Alien> TeamA { get; set; }
    public List<Alien> TeamB { get; set; }
}

public class Program
{
    public static void Main()
    {
        string jsonFilePath = "C:/Users/Eigenaar/Desktop/!.NET_Advanced/Oef/ConsoleApp1/JsonToCode/response_1732023162714.json"; // Vervang door het juiste pad naar je JSON-bestand

        // Lees de JSON-data uit het bestand
        string json = File.ReadAllText(jsonFilePath);

        // Deserialiseer de JSON naar een TeamData-object
        TeamData teamData = JsonConvert.DeserializeObject<TeamData>(json);

        var teamA = teamData.TeamA;
        var teamB = teamData.TeamB;
        Console.WriteLine("Team A");
        // Doe iets met de data
        foreach (var alien in teamA)
        {
            Console.WriteLine($"new Alien({alien.Strength}, {alien.Speed}, {alien.Health}),");
        }
        Console.WriteLine("Team B");
        foreach (var alien in teamB)
        {
            Console.WriteLine($"new Alien({alien.Strength}, {alien.Speed}, {alien.Health}),");
        }
    }
}