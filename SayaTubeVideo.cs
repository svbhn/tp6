using System;

class SayaTubeVideo_103022300081
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo_103022300081(string title)
    {
        Random random = new Random();
        this.id = random.Next(10000, 100000);

        this.title = title;

        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        this.playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }
}