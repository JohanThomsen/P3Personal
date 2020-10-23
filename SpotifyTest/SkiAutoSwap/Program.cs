using System;
using System.Net.Http;

namespace SkiAutoSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //1. Connect to Spotify
            //2. Check if person is Going Upwards
            //3. Figure out how to change to either Chill or banging Music Depending on going up or down
            /*OAUTH Token BQCj3DoV05HORAY7KedCRrAdYmtd8v8VdeZcdJPOJoB2H9BuPSpXl5Ejjk0fVe8VdJ8DE3kVJOTQta9K1
             * Chill playlistID: 77ENCz65prp4SfiZorFaK6
             * Banging Playlist: 392z7ojTQVvPiMxDAG9Kqm
             * Device ID PC : 163dcdf5287087c7842f07b3b77cfef23943de62
             * Device ID Mobile: 4bfabfb5156e9a18c6239c09f9248e8278e3a43c */

            Methods test = new Methods();

            test.Test();

            

        }
    }
}
