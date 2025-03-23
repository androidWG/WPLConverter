using System;
using Id3;
using JetBrains.Annotations;

namespace WPLConverter.IO;

public static class ReadTag
{
    [CanBeNull]
    public static Id3Tag GetInfo(string filePath)
    {
        if (!filePath.EndsWith(".mp3"))
            return null;

        try
        {
            try
            {
                return new Mp3(filePath).GetTag(Id3TagFamily.Version2X);
            }
            catch (IndexOutOfRangeException)
            {
                return new Mp3(filePath).GetTag(Id3TagFamily.Version1X);
            }
        }
        catch (IndexOutOfRangeException)
        {
            return null;
        }
    }
}
