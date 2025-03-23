using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Id3;
using WPLConverter.DataClasses;
using WPLConverter.Lib;

namespace WPLConverter.IO;

public class M3UReaderWriter(Encoding encoding) : IReaderWriter
{
    private Encoding Encoding { get; } = encoding;

    public Playlist ReadFromFile(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        var title = Path.GetFileNameWithoutExtension(filePath);
        var trackList = new List<Track>();

        foreach (var line in lines)
        {
            if (line.StartsWith("#EXT"))
            {
                continue;
            }

            var cleanedLine = line;

            var regex = new Regex(@"^(?:%[0-9A-F]{2}|[^ %])+\.\w{2,6}");
            var urlEncoded = regex.Match(line).Success;
            if (urlEncoded)
            {
                cleanedLine = Uri.UnescapeDataString(line);
            }

            try
            {
                Directory.SetCurrentDirectory(
                    Path.GetDirectoryName(filePath) ?? throw new InvalidOperationException()
                );
                var newPath = Path.GetFullPath(cleanedLine);
                Id3Tag tag = ReadTag.GetInfo(newPath);
                trackList.Add(new Track(tag, newPath));
            }
            catch (ArgumentException)
            {
                Console.WriteLine($@"Path has invalid character: " + cleanedLine);
                trackList.Add(new Track(null, cleanedLine));
            }
        }

        return new Playlist(title, trackList, filePath);
    }

    public void SaveToFile(Playlist playlist, string filePath)
    {
        Console.WriteLine(
            $@"Writing playlist '{playlist.Title}' to '{filePath}' with encoding {Encoding}"
        );

        using var output = new StreamWriter(filePath, false, Encoding);
        output.WriteLine("#EXTM3U");

        foreach (Track track in playlist.Tracks)
        {
            if (Properties.Settings.Default.WriteFakeTrackInfo && track.Tag == null)
            {
                output.WriteLine($"#EXTINF:0,{Path.GetFileNameWithoutExtension(track.FileName)}");
            }
            else if (track.Tag != null)
            {
                var displayTitle = $"{track.Tag.Artists.ToString().TrimEnd('\0')} - {track.Tag.Title.ToString().TrimEnd('\0')}";
                output.WriteLine($"#EXTINF:0,{displayTitle}");
            }

            var path = Util.GetPath(track.FullPath, Path.GetDirectoryName(filePath));
            if (Properties.Settings.Default.URLEscape)
            {
                path = Uri.EscapeDataString(path);
            }
            output.WriteLine(path);
        }
    }
}
