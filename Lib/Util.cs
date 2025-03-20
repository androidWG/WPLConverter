using System;
using System.Collections.Generic;
using System.Text;

namespace WPLConverter.Lib
{
    internal static class Util
    {
        public static string MakeRelativePath(string workingDirectory, string fullPath)
        {
            var result = string.Empty;
            int offset;

            // this is the easy case.  The file is inside of the working directory.
            if (fullPath.StartsWith(workingDirectory))
            {
                return fullPath.Substring(workingDirectory.Length + 1);
            }

            // the hard case has to back out of the working directory
            var baseDirs = workingDirectory.Split(new char[] { ':', '\\', '/' });
            var fileDirs = fullPath.Split(new char[] { ':', '\\', '/' });

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
    }
}
