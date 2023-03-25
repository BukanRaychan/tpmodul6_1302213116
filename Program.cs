// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics.Contracts;

internal class Program
{
    static void Main(String[] args)
    {
        SayaTubeVideo obj = new SayaTubeVideo("Tutorial Design By Contract – Fasya Raihan Maulana");
        obj.IncreasePlayCount(4);
        obj.PrintVideoDetails();   
    }
}

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random ran = new Random();
        this.title = title;
        id = ran.Next(10000, 99999);
        playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {
        this.playCount = playCount;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID\t\t: {id}\nTitle\t\t: {title}\nPlay Count\t: {playCount}\n");
    }
}
