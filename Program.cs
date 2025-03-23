class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideoDBC_103022300081 video = new SayaTubeVideoDBC_103022300081("Tutorial Design By Contract - [Subhan Maulana Ahmad]");

        video.PrintVideoDetails();
        video.IncreasePlayCount(100);
        video.PrintVideoDetails();

        for (int i = 0; i < 10; i++)
        {
            video.IncreasePlayCount(10000000);
        }

        video.PrintVideoDetails();

        Console.ReadLine();
    }
}