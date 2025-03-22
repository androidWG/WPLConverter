using JetBrains.Annotations;
using WPLConverter.DataClasses;

namespace WPLConverter.IO;

public interface IReaderWriter
{
    [CanBeNull] Playlist ReadFromFile(string filePath);
    void SaveToFile(Playlist playlist, string filePath);
}