using System;
using System.IO;
using Id3;
using JetBrains.Annotations;

namespace WPLConverter.DataClasses
{
    public class Track(Id3Tag trackInfo, string filePath)
    {
        [CanBeNull]
        public readonly Id3Tag Tag = trackInfo;
        public readonly string FileName = Path.GetFileName(filePath);
        public readonly string FolderPath = Path.GetDirectoryName(filePath);

        public string FullPath
        {
            get
            {
                try
                {
                    return Path.GetFullPath(filePath);
                }
                catch (ArgumentException)
                {
                    return filePath;
                }
            }
        }
    }
}
