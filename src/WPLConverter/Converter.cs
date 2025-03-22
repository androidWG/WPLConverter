using System;
using System.IO;
using System.Windows.Forms;
using WPLConverter.DataClasses;
using WPLConverter.IO;
using WPLConverter.Lib;
using WPLConverter.Properties;

namespace WPLConverter
{
    public partial class Converter : Form
    {
        private Playlist _playlist;

        public Converter()
        {
            InitializeComponent();
        }

        private void LoadIntoListView(Playlist playlist)
        {
            TrackLst.Items.Clear();

            foreach (Track track in playlist.Tracks)
            {
                var isValid = File.Exists(track.FullPath);

                var item = new ListViewItem(track.FileName);
                item.SubItems.Add(track.FolderPath);
                item.SubItems.Add(isValid ? "\u221a" : "X");

                TrackLst.Items.Add(item);
            }

            FilenameLbl.Text = Path.GetFileName(playlist.FilePath);
        }

        private void LoadFromFile(string filePath)
        {
            var type = Util.GetFileType(filePath);

            IReaderWriter io;
            switch (type)
            {
                case FileType.WPL:
                    io = new WPLReaderWriter(Util.GetEncoding());
                    break;
                case FileType.M3U:
                case FileType.M3U8:
                    io = new M3UReaderWriter(Util.GetEncoding());
                    break;
                default:
                    MessageBox.Show(
                        LocalizationHelper.GetString("MessageBox.FileUnsupported"),
                        LocalizationHelper.GetString("MessageBox.FileUnsupported.Title"),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
            }

            _playlist = io.ReadFromFile(filePath);
            LoadIntoListView(_playlist);

            ActiveForm!.Text = @"WPLConverter - " + filePath;
        }

        #region Save and Open Files

        private void SaveAsTsmi_Click(object sender, EventArgs e)
        {
            if (_playlist == null)
            {
                MessageBox.Show(
                    LocalizationHelper.GetString("MessageBox.LoadPlaylistToSave"),
                    LocalizationHelper.GetString("MessageBox.LoadPlaylistToSave.Title"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            SaveFileDiag.FileName = _playlist.Title + ".wpl";
            SaveFileDiag.InitialDirectory = Path.GetDirectoryName(_playlist.FilePath);

            if (SaveFileDiag.ShowDialog() != DialogResult.OK)
                return;

            IReaderWriter io = SaveFileDiag.FilterIndex switch
            {
                1 => new WPLReaderWriter(Util.GetEncoding()),
                2 or 3 => new M3UReaderWriter(Util.GetEncoding()),
                _ => throw new ArgumentOutOfRangeException("SaveFileDialog.FilterIndex"),
            };

            io.SaveToFile(_playlist, SaveFileDiag.FileName);
        }

        private void OpenTsmi_Click(object sender, EventArgs e)
        {
            if (OpenFileDiag.ShowDialog() != DialogResult.OK)
                return;
            LoadFromFile(OpenFileDiag.FileName);
        }

        #endregion

        #region Other UI bindings

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            LoadFromFile(_playlist.FilePath);
        }

        private void FullpathTsmi_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.WriteFullPaths = FullpathTsmi.Checked;
        }

        private void FilenameTsmi_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.FileNameAsPlaylistName = FilenameTsmi.Checked;
        }

        private void TrackInfoTsmi_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.WriteFakeTrackInfo = TrackInfoTsmi.Checked;
        }

        private void EncodingTscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.Encoding = EncodingTscb.SelectedIndex switch
            {
                0 => "UTF8",
                1 => "UTF16",
                2 => "UTF32",
                3 => "ASCII",
                _ => Settings.Default.Encoding,
            };
        }

        private void URLEscapeTsmi_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.URLEscape = URLEscapeTsmi.Checked;
        }

        #endregion
    }
}
