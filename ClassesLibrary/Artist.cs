using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Artist
    {
        //fields

        //properties
        public List<Song> Tracks { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        //ctors
        public Artist(List<Song> tracks, string title, string genre)
        {
            Tracks = tracks;
            Title = title;
            Genre = genre;
        }

        //methods
        public override string ToString()
        {
            string songs = "";

            foreach (Song track in Tracks)
            {
                songs += track.Title + "\n";
            }

            //return base.ToString();
            return string.Format("{0}\nGenre: {1}\n\nTracks:\n{2}\n",
                Title, Genre, songs);
        }
    }
}
