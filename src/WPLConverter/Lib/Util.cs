using System.Text;
using WPLConverter.DataClasses;
using WPLConverter.Properties;

namespace WPLConverter.Lib
{
    internal static class Util
    {
        public static Encoding GetEncoding()
        {
            var encoding = Settings.Default.Encoding;

            return encoding switch
            {
                "UTF8" => Encoding.UTF8,
                "UTF16" => Encoding.Unicode,
                "UTF32" => Encoding.UTF32,
                "ASCII" => Encoding.ASCII,
                _ => Encoding.UTF8,
            };
        }

        public static FileType? GetFileType(string filePath)
        {
            var extension = System.IO.Path.GetExtension(filePath).ToLower();

            return extension switch
            {
                ".wpl" => FileType.WPL,
                ".m3u" => FileType.M3U,
                ".m3u8" => FileType.M3U8,
                _ => null,
            };
        }

        public static string MakeRelativePath(string workingDirectory, string fullPath)
        {
            var result = string.Empty;
            int offset;

            // this is the easy case.  The file is inside the working directory.
            if (fullPath.StartsWith(workingDirectory))
            {
                return fullPath.Substring(workingDirectory.Length + 1);
            }

            // the hard case has to back out of the working directory
            var baseDirs = workingDirectory.Split(':', '\\', '/');
            var fileDirs = fullPath.Split(':', '\\', '/');

            // if we failed to split (empty strings?) or the drive letter does not match
            if (baseDirs.Length <= 0 || fileDirs.Length <= 0 || baseDirs[0] != fileDirs[0])
            {
                // can't create a relative path between separate harddrives/partitions.
                return fullPath;
            }

            // skip all leading directories that match
            for (offset = 1; offset < baseDirs.Length; offset++)
            {
                if (baseDirs[offset] != fileDirs[offset])
                    break;
            }

            // back out of the working directory
            for (var i = 0; i < (baseDirs.Length - offset); i++)
            {
                result += "..\\";
            }

            // step into the file path
            for (var i = offset; i < fileDirs.Length - 1; i++)
            {
                result += fileDirs[i] + "\\";
            }

            // append the file
            result += fileDirs[fileDirs.Length - 1];

            return result;
        }

        public static string GetPath(string path, string directory = "")
        {
            return Settings.Default.WriteFullPaths ? path : MakeRelativePath(directory, path);
        }

        public static string CleanUpString(string input)
        {
            return input.TrimEnd('\0');
        }
    }
}
