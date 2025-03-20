# WPLConverter

Convert between M3U(8) and WPL playlist formats - works on any version of Windows starting from Windows XP SP0.

I created this tool since Windows Media Player doesn't handle non-ASCII characters very well when opening M3U playlists. If you somehow found yourself in the same position of needing to convert between these formats, congrats because I have the tool for you!

## Usage

Download a release from the Releases page and execute it. On the interface, select File > Open to open a playlist file, then save using File > Save As. The format specified in the save dialog will be used to save the playlist.

## Building

Requires Visual Studio with C# desktop support. Open the solution file and build the project by going to Build > Build Solution (default shortcut: `Ctrl + Shift + B`).

Targets .NET Framework 2.0.