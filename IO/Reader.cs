using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using WPLConverter.DataClasses;
using WPLConverter.Lib;

namespace WPLConverter.IO
{
    internal static class Reader
    {
        public static Playlist FromWplPlaylist(string filePath)
        {
            var lines = File.ReadAllText(filePath);
            var list = new XmlDocument();
            list.LoadXml(lines);

            var title = list.SelectSingleNode("/smil/head/title")?.InnerText;
            var trackList = new List<Track>();
            foreach (XmlNode node in list.SelectNodes("/smil/body/seq/media/@src"))
            {
                Directory.SetCurrentDirectory(Path.GetDirectoryName(filePath) ?? throw new InvalidOperationException());
                var newPath = Path.GetFullPath(node.InnerText);

                trackList.Add(new Track(newPath));
            }

            return new Playlist(title, trackList, filePath);
        }

        public static Playlist FromM3UPlaylist(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            var title = Path.GetFileNameWithoutExtension(filePath);
            var trackList = new List<Track>();

            var invalidTracks = new List<string>();

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
                    Directory.SetCurrentDirectory(Path.GetDirectoryName(filePath) ??
                                                  throw new InvalidOperationException());
                    var newPath = Path.GetFullPath(cleanedLine);
                    trackList.Add(new Track(newPath));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine($"Path has invalid character: " + cleanedLine);
                    invalidTracks.Add(cleanedLine);
                }
            }

            if (invalidTracks.Count > 0)
            {
                var message =
                    "The file contained these invalid paths, most likely from ASCII encoding Unicode characters:\n\n";
                foreach (var path in invalidTracks)
                {
                    message += $"{path}\n";
                }

                message += "\nThese files will not be included.";

                MessageBox.Show(message, "Invalid tracks", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return new Playlist(title, trackList, filePath);
        }
    }
}
