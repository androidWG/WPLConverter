using System.Collections.Generic;
using WPLConverter.Lib;

namespace WPLConverter.DataClasses
{
    internal class Playlist
    {
        public List<Track> Tracks = new List<Track>();
        public string Title;
        public string FilePath;
        
        public Playlist(string title, List<Track> tracks, string filePath) {
            Tracks = tracks;
            Title = title;
            FilePath = filePath;
        }

        public Playlist() { }
    }
}
