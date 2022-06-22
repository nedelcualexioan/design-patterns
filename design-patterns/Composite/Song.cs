using System;

namespace design_patterns.Composite
{
    public class Song : SongComponent
    {
        private String songName;
        private int releaseYear;

        public String SongName
        {
            get => songName;
        }

        public int ReleaseYear
        {
            get => releaseYear;
        }

        public Song(String songName, int releaseYear)
        {
            this.songName = songName;
            this.releaseYear = releaseYear;
        }

        public override void displayInfo()
        {
            Console.WriteLine(songName + " was released in " + releaseYear);
        }
    }
}