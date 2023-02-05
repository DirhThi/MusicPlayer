using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Windows.Shapes;

namespace MusicPlayer.User_Control
{
    /// <summary>
    /// Interaction logic for PlayList.xaml
    /// </summary>
    public partial class PlayList : UserControl
    {
        public PlayList()
        {

            InitializeComponent();
           
        }

        private void Playlist_Click(object sender, RoutedEventArgs e)
        {
            gridPlaylist.Visibility = Visibility.Hidden;
            gridSongPlaylist.Visibility = Visibility.Visible;
            Playlist Playlist = (sender as Button).DataContext as Playlist;
            List<Song> songPlaylist = new List<Song>();

            foreach (string line in File.ReadLines(Playlist.PlaylistPath))
            {
                for(int i=0;i < MainWindow.songItems.Count;i++)
                {
                    if(System.IO.Path.GetFileName(MainWindow.songItems[i].filePath)==line)
                    {
                        songPlaylist.Add(MainWindow.songItems[i]);
                    }
                }
            }
            datagridSongPlaylist.ItemsSource = songPlaylist;
            namePlaylistSong.Text = Playlist.Title;
            countSong.Text = songPlaylist.Count + " Bài hát";
        }
    }
}

