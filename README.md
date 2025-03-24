# WPLConverter

Convert between M3U(8) and WPL playlist formats - works on any version of Windows starting from Windows XP SP3 (uses .NET Framework v4.0).

I created this tool since Windows Media Player doesn't handle non-ASCII characters very well when opening M3U playlists. If you somehow found yourself in the same position of needing to convert between these formats, congrats because I have the tool for you!

## Usage

On the [Releases page](https://github.com/androidWG/WPLConverter/releases/latest) choose if you want to download the installer or no installer version.


### GUI
On the interface, select File > Open to open a playlist file, then save using File > Save As. The format specified in the save dialog will be used to save the playlist.

A few options can be chosen on the options menu, and explanations are provided with tooltips by hovering over the option.

## Building

You'll need either any version of JetBrains Rider or Visual Studio **2019 or older.** Microsoft doesn't support loading .NET Framework v4.0 projects on Visual Studio 2022 and newer.

Open the solution file and build the project by going to Build > Build Solution (default shortcut: `Ctrl + Shift + B`) or pressing the Build whole solution button in Rider.

### Setup

Inno Setup Compiler v5.5.8 is used for building. Simply build the solution on Release target, then run the `.iss` script located in the root folder with the compiler.