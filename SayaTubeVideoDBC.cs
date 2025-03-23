using System;
using System.Diagnostics;

class SayaTubeVideoDBC_103022300081
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideoDBC_103022300081(string title)
    {
        Debug.Assert(title != null, "Title tidak bisa kosong/null");
        Debug.Assert(title.Length <= 100, "Title tidak bisa melebihi 100 kata");

        Random random = new Random();
        this.id = random.Next(10000, 100000);

        this.title = title;

        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        Debug.Assert(count <= 10000000, "Count tidak bisa melebihi 10.000.000");

        try
        {
            checked
            {
                this.playCount += count;
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Error: Play count overflow detected");
            Console.WriteLine(ex.Message);
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }
}