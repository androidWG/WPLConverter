using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;
using System.Xml;
using WPLConverter.DataClasses;
using WPLConverter.Lib;
using Track = WPLConverter.DataClasses.Track;

namespace WPLConverter.IO
{
    internal static class Writer
    {
        public static bool WriteFullPaths = false;
        public static bool FileNameAsPlaylistName = false;
        public static bool WriteTrackInfo = false;
        public static bool URLEscape = false;

        public static Encoding Encoding = Encoding.UTF8;


        private static string GetPath(string path, string directory = "")
        {
            return WriteFullPaths ? path : Util.MakeRelativePath(directory, path);
        }

        [SuppressMessage("ReSharper", "SuggestVarOrType_SimpleTypes")]
        public static void WriteToWplPlaylist(Playlist playlist, string filePath)
        {
            Console.WriteLine($"Writing playlist '{playlist.Title}' to '{filePath}' with encoding {Encoding}");

            var xml = new XmlDocument();

            var version = xml.CreateProcessingInstruction("wpl", "version=\"1.0\"");
            xml.AppendChild(version);

            var root = xml.CreateElement("smil");
            var head = xml.CreateElement("head");

            var metaGenerator = xml.CreateElement("meta");
            metaGenerator.Attributes.Append(xml.CreateAttribute("Generator")).InnerText = "WPLConverter";

            var title = xml.CreateElement("title");
            title.InnerText = FileNameAsPlaylistName ? Path.GetFileNameWithoutExtension(filePath) : playlist.Title;

            head.AppendChild(metaGenerator);
            head.AppendChild(title);

            var body = xml.CreateElement("body");
            var seq = xml.CreateElement("seq");

            foreach (Track track in playlist.Tracks)
            {
                var media = xml.CreateElement("media");
                var src = xml.CreateAttribute("src");
                src.InnerText = GetPath(track.FullPath, Path.GetDirectoryName(filePath));
                media.Attributes.Append(src);
                seq.AppendChild(media);
            }

            body.AppendChild(seq);

            root.AppendChild(head);
            root.AppendChild(body);

            xml.AppendChild(root);

            xml.Save(filePath);
        }

        public static void WriteToM3UPlaylist(Playlist playlist, string filePath)
        {
            Console.WriteLine($"Writing playlist '{playlist.Title}' to '{filePath}' with encoding {Encoding}");

            using (var output = new StreamWriter(filePath, false, Encoding))
            {
                output.WriteLine("#EXTM3U");

                foreach (Track track in playlist.Tracks)
                {
                    if (WriteTrackInfo)
                    {
                        output.WriteLine($"#EXTINF:0,{Path.GetFileNameWithoutExtension(track.FileName)}");
                    }
                    
                    var path = GetPath(track.FullPath, Path.GetDirectoryName(filePath));
                    if (URLEscape)
                    {
                        path = Uri.EscapeDataString(path);
                    }
                    output.WriteLine(path);
                }
            }
        }
    }
}
