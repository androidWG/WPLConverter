using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using Id3;
using WPLConverter.DataClasses;
using WPLConverter.Lib;

namespace WPLConverter.IO;

public class WPLReaderWriter(Encoding encoding) : IReaderWriter
{
    private Encoding Encoding { get; } = encoding;

    public Playlist ReadFromFile(string filePath)
    {
        var lines = File.ReadAllText(filePath);
        var list = new XmlDocument();
        list.LoadXml(lines);

        try
        {
            var title = list.SelectSingleNode("/smil/head/title")?.InnerText;
            var trackList = new List<Track>();
            XmlNodeList nodes = list.SelectNodes("/smil/body/seq/media/@src");

            if (nodes == null)
                return null;

            foreach (XmlNode node in nodes)
            {
                Directory.SetCurrentDirectory(
                    Path.GetDirectoryName(filePath) ?? throw new InvalidOperationException()
                );
                var newPath = Path.GetFullPath(node.InnerText);
                Id3Tag tag = ReadTag.GetInfo(newPath);
                trackList.Add(new Track(tag, newPath));
            }

            return new Playlist(title, trackList, filePath);
        }
        catch (XPathException e)
        {
            throw new Exceptions.InvalidPlaylistFile(
                "Invalid WPL file or not a valid XML file.",
                e
            );
        }
    }

    [SuppressMessage("ReSharper", "SuggestVarOrType_SimpleTypes")]
    public void SaveToFile(Playlist playlist, string filePath)
    {
        Console.WriteLine(
            $@"Writing playlist '{playlist.Title}' to '{filePath}' with encoding {Encoding}"
        );

        var xml = new XmlDocument();

        var version = xml.CreateProcessingInstruction("wpl", "version=\"1.0\"");
        xml.AppendChild(version);

        var root = xml.CreateElement("smil");
        var head = xml.CreateElement("head");

        var metaGenerator = xml.CreateElement("meta");
        metaGenerator.Attributes.Append(xml.CreateAttribute("Generator")).InnerText =
            "WPLConverter";

        var title = xml.CreateElement("title");
        title.InnerText = Properties.Settings.Default.FileNameAsPlaylistName
            ? Path.GetFileNameWithoutExtension(filePath)
            : playlist.Title;

        head.AppendChild(metaGenerator);
        head.AppendChild(title);

        var body = xml.CreateElement("body");
        var seq = xml.CreateElement("seq");

        foreach (Track track in playlist.Tracks)
        {
            var media = xml.CreateElement("media");
            var src = xml.CreateAttribute("src");
            src.InnerText = Util.GetPath(track.FullPath, Path.GetDirectoryName(filePath));
            media.Attributes.Append(src);
            seq.AppendChild(media);
        }

        body.AppendChild(seq);

        root.AppendChild(head);
        root.AppendChild(body);

        xml.AppendChild(root);

        xml.Save(filePath);
    }
}
