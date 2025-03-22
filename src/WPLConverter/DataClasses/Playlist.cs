using System.Collections.Generic;

namespace WPLConverter.DataClasses
{
    public class Playlist(string title, List<Track> tracks, string filePath)
    {
        public List<Track> Tracks { get; } = tracks;
        public string Title { get; } = title;
        public string FilePath { get; } = filePath;
    }
}
