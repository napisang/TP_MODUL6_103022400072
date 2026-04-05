SayaMusicTrack track = new SayaMusicTrack("daniel caesar");
track.PrintTrackDetails();

track.IncreasePlayCount(100);
track.PrintTrackDetails();

track.IncreasePlayCount(500);
track.PrintTrackDetails();

Console.WriteLine("\nTesting overflow...");
for (int i = 0; i < 300; i++)
{
    bool success = track.IncreasePlayCount(10000000);
    if (!success) break;
}

track.PrintTrackDetails();