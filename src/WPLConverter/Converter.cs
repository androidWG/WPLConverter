using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WPLConverter.DataClasses;
using WPLConverter.IO;

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
            var type = (FileType)Enum.Parse(typeof(FileType), Path.GetExtension(filePath).Remove(0, 1), true);
            switch (type)
            {
                case FileType.WPL:
                    _playlist = Reader.FromWplPlaylist(filePath);
                    break;
                case FileType.M3U:
                case FileType.M3U8:
                    _playlist = Reader.FromM3UPlaylist(filePath);
                    break;
                default:
                    MessageBox.Show("The file you selected is unsupported. Please try a diffrent file.", "Unsupported file", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
            }

            LoadIntoListView(_playlist);

            Form.ActiveForm.Text = "WPLConverter - " + filePath;
        }


        private void SaveAsTsmi_Click(object sender, EventArgs e)
        {
            if (_playlist == null)
            {
                MessageBox.Show("Please load a playlist using the Open command before saving.", "No data loaded",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filterStr = SaveFileDiag.Filter;
            var filter = new List<string>(filterStr.Split('|'));

            // Remove every other entry from filter 
            var pos = 0;
            for (var i = 0; i < filter.Count; i += 2, pos++)
            {
                filter[pos] = filter[i];
            }
            filter.RemoveRange(pos, filter.Count - pos);

            SaveFileDiag.FileName = _playlist.Title + ".wpl";
            SaveFileDiag.InitialDirectory = Path.GetDirectoryName(_playlist.FilePath);
            
            if (SaveFileDiag.ShowDialog() != DialogResult.OK) return;

            switch (SaveFileDiag.FilterIndex)
            {
                case 1:
                    Writer.WriteToWplPlaylist(_playlist, SaveFileDiag.FileName);
                    break;
                case 2:
                case 3:
                    Writer.WriteToM3UPlaylist(_playlist, SaveFileDiag.FileName);
                    break;
            }
        }

        private void OpenTsmi_Click(object sender, EventArgs e)
        {
            if (OpenFileDiag.ShowDialog() != DialogResult.OK) return;
            LoadFromFile(OpenFileDiag.FileName);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            LoadFromFile(_playlist.FilePath);
        }

        private void FullpathTsmi_CheckedChanged(object sender, EventArgs e)
        {
            Writer.WriteFullPaths = FullpathTsmi.Checked;
        }

        private void FilenameTsmi_CheckedChanged(object sender, EventArgs e)
        {
            Writer.FileNameAsPlaylistName = FilenameTsmi.Checked;
        }

        private void TrackInfoTsmi_CheckedChanged(object sender, EventArgs e)
        {
            Writer.WriteTrackInfo = TrackInfoTsmi.Checked;
        }

        private void EncodingTscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (EncodingTscb.SelectedIndex)
            {
                case 0:
                    Writer.Encoding = Encoding.UTF8;
                    break;
                case 1:
                    Writer.Encoding = Encoding.Unicode;
                    break;
                case 2:
                    Writer.Encoding = Encoding.UTF32;
                    break;
                case 3:
                    Writer.Encoding = Encoding.ASCII;
                    break;

            }
        }

        private void URLEscapeTsmi_CheckedChanged(object sender, EventArgs e)
        {
            Writer.URLEscape = URLEscapeTsmi.Checked;
        }
    }
}
