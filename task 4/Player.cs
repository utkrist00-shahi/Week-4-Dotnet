using System;

public class Player
{
    string playerName;
    int level;
    int health;

    public Player()
    {
        Console.WriteLine("Default constructor");
    }

    public Player(string name, int lvl, int hp)
    {
        playerName = name;
        level = lvl;
        health = hp;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {playerName}, Level: {level}, Health: {health}");
    }
}