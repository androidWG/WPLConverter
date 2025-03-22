using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WPLConverter.Lib;

public abstract class Exceptions
{
    public class InvalidPlaylistFile : Exception
    {
        public InvalidPlaylistFile() { }

        public InvalidPlaylistFile(string message)
            : base(message) { }

        public InvalidPlaylistFile(string message, Exception inner)
            : base(message, inner) { }
    }

    public class InvalidFileName : Exception, ISerializable
    {
        public List<string> InvalidTracks;

        public InvalidFileName() { }

        public InvalidFileName(string message)
            : base(message) { }

        public InvalidFileName(string message, Exception inner)
            : base(message, inner) { }

        public InvalidFileName(string message, List<string> invalidTracks)
            : base(message)
        {
            InvalidTracks = invalidTracks;
        }
    }
}
