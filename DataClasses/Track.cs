using System.IO;

namespace WPLConverter.DataClasses
{
    internal struct Track
    {
        public string FileName;
        public string FolderPath;
        public string FullPath;

        public Track(string filePath)
        {
            FileName = Path.GetFileName(filePath);
            FolderPath = Path.GetDirectoryName(filePath);

            FullPath = Path.GetFullPath(filePath);
        }
    }
}
