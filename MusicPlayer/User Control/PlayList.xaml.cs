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

            PlaylistLoad();
            icPlaylist.ItemsSource = playlistsItems;
            fieldNamePl.Visibility = Visibility.Visible;
            selectSong.Visibility = Visibility.Hidden;
            tb_btn_createPlaylis.Text = "Tiếp tục";
            countPlaylist.Text = playlistsItems.Count + " Playlist";
            lbSelectSong.ItemsSource = songItems;
            gridPlaylist.Visibility = Visibility.Visible;
            gridSongPlaylist.Visibility = Visibility.Hidden;

        }

        public void displayPlaylistLoad()
        {
            PlaylistLoad();
            icPlaylist.ItemsSource = playlistsItems;
        }
        public class Playlist
        {
            public string Title { get; set; }
            public string PlaylistPath { get; set; }      
        }

        public void PlaylistLoad()
        {
            var currentDirectory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            string projectDirectory = currentDirectory.Parent.Parent.Parent.FullName;
            string destinationDirectory = projectDirectory + "\\MusicPlayer\\Playlists\\";
            DirectoryInfo d = new DirectoryInfo(destinationDirectory);       
            foreach (var filePlaylist in d.GetFiles("*.txt"))
            {
                string t = filePlaylist.Name.Replace(".txt", "");
                playlistsItems.Add(new Playlist() { Title=t,PlaylistPath= filePlaylist.ToString() }); 
            }
        }

        private void Contin_Click(object sender, RoutedEventArgs e)
        {
            if(TrangThaiP==0)
            {
                if(namePlaylist.Text.Length==0)
                {
                    Popup.PlacementTarget = namePlaylist;
                    Popup.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
                    Popup.IsOpen = true;
                }    
                else
                {
                    Popup.IsOpen = false;
                    fieldNamePl.Visibility = Visibility.Hidden;
                    selectSong.Visibility = Visibility.Visible;
                    tb_btn_createPlaylis.Text = "Lưu";
                    TrangThaiP = 1;
                }    
                
            }
            else
            {
                var currentDirectory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                string projectDirectory = currentDirectory.Parent.Parent.Parent.FullName;
                string destinationDirectory = projectDirectory + "\\MusicPlayer\\Playlists\\";
                string PlaylistPath = destinationDirectory  + namePlaylist.Text + ".txt";
                //  File.Copy(fileName, destinationDirectory + Path.GetFileName(fileName));
                StreamWriter w = new StreamWriter(PlaylistPath, true);
               
                
                for (int i=0;i<lbSelectSong.SelectedItems.Count;i++)
                {                    
                    int t = lbSelectSong.Items.IndexOf(lbSelectSong.SelectedItems[i]);
                    string s = System.IO.Path.GetFileName(songItems[i].filePath);
                    w.WriteLine(s);
                }
                w.Close();
                Dialog.IsOpen = false;
                

            }
        }

        private void Createpl_Click(object sender, RoutedEventArgs e)
        {
            TrangThaiP = 0;
            fieldNamePl.Visibility = Visibility.Visible;
            selectSong.Visibility = Visibility.Hidden;
            tb_btn_createPlaylis.Text = "Tiếp tục";
        }

        private void Playlist_Click(object sender, RoutedEventArgs e)
        {
            gridPlaylist.Visibility = Visibility.Hidden;
            gridSongPlaylist.Visibility = Visibility.Visible;
        }
    }
}

