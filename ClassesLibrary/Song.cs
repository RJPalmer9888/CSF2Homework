using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Song
    {
        //fields

        //properties
        public string Title { get; set; }
        public string Artist { get; set; }
        public int LengthInSeconds { get; set; }

        //ctors
        public Song(string title, string artist, int lengthInSeconds)
        {
            Title = title;
            Artist = artist;
            LengthInSeconds = lengthInSeconds;
        }

        public Song()
        {

        }

        //methods
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("Title: {0}\nArtist: {1}\nLength: {2}\n",
                Title, Artist, LengthInSeconds);
        }
    }
}
