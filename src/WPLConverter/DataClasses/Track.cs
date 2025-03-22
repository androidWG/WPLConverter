using System.IO;

namespace WPLConverter.DataClasses
{
    public struct Track(string filePath)
    {
        public readonly string FileName = Path.GetFileName(filePath);
        public readonly string FolderPath = Path.GetDirectoryName(filePath);
        public readonly string FullPath = Path.GetFullPath(filePath);
    }
}
