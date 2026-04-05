using System;
using System.Diagnostics;

class SayaMusicTrack
{
    private int id;
    private string playCount;
    private string title;

    public SayaMusicTrack(string title)
    {
        Debug.Assert(title != null, "Judul track tidak boleh null!");
        Debug.Assert(title.Length <= 100, "Judul track maksimal 100 karakter!");

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = "0";
    }

    public bool IncreasePlayCount(int count)
    {
        Debug.Assert(count <= 10000000, "Penambahan play count maksimal 10.000.000!");

        int current = int.Parse(playCount);

        try
        {
            checked
            {
                current += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Play count melebihi batas maksimum integer!");
            return false;
        }

        playCount = current.ToString();
        return true;
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }
}