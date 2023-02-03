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
        List<Song> songItems = MainWindow.songItems;
        int TrangThaiP = 0;//0 Khoi tao , 1 chon bai hat
        List<Playlist> playlistsItems= new List<Playlist>();
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
                for(int i=0;i<songItems.Count;i++)
                {
                    if(System.IO.Path.GetFileName(songItems[i].filePath)==line)
                    {
                        songPlaylist.Add(songItems[i]);
                    }
                }
            }
            datagridSongPlaylist.ItemsSource = songPlaylist;
            namePlaylistSong.Text = Playlist.Title;
            countSong.Text = songPlaylist.Count + " Bài hát";
        }
    }
}

