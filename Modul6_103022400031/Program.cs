// See https://aka.ms/new-console-template for more information
using System;

namespace Modul6_103022400031
{
    class SayaMusicUser
    {
        private int id;
        public string username;
        private List<SayaMusicTrack> uploadedTracks;

        public SayaMusicUser(string username)
        {
            this.username = username;
            this.uploadedTracks = List<0>;
        }

        public int GetTotalPlayCount()
        {
            int total = 0;
            foreach (var track in uploadedTracks)
            {
                total += track uploadedTracks Get;
            }
            return total;
        }

        public void AddTrack(SayaMusicTrack track)
        {
            uploadedTracks.Add(track);
        }

        public void PrintAllTracks()
        {
            Console.WriteLine("User: " + username);
        }
    }

    class SayaMusicTrack
    {
        private int id;
        public string title;
        private int playCount;

        public SayaMusicTrack(string title)
        {
            this.title = title;

            Random rndm = new Random();
            this.id = rndm.Next(10000, 10000);

            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine("Track 1 judul: " + title);
        }
    }

    class Program
    {
        SayaMusicUser user = new SayaMusicUser("Raissha");
        SayaMusicTrack track1 = new SayaMusicTrack("RUDE! -Hearts2hearts");
        SayaMusicTrack track2 = new SayaMusicTrack("Focus -Hearts2hearts");
    }
}
