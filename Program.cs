// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

internal class Program
{
    static void Main(String[] args)
    {
        SayaTubeVideo obj1 = new SayaTubeVideo("Tutorial Design By Contract – Fasya Raihan Maulana");
        obj1.IncreasePlayCount(4);
        obj1.PrintVideoDetails();
        
        SayaTubeVideo obj2 = new SayaTubeVideo("Ini Judul");
        for (int i = 0; i < 220; i++)
        {
            obj2.IncreasePlayCount(9999999);
        }
        obj2.PrintVideoDetails();
    }
}

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Debug.Assert(title != null && title.Length <= 100, "judul lebih dari 100 karakter atau kosong");


        Random ran = new Random();
        try
        {
            this.title = checked(title);
        } catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        id = ran.Next(10000, 99999);
        playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {
        Debug.Assert(playCount <= 10000000);

        try
        {
            this.playCount = checked(this.playCount + playCount);
        } catch(System.OverflowException ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID\t\t: {id}\nTitle\t\t: {title}\nPlay Count\t: {playCount}\n");
    }
}
