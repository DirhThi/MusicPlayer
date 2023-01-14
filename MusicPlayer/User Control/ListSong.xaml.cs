using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using System.IO;




namespace MusicPlayer.User_Control
{
    /// <summary>
    /// Interaction logic for ListSong.xaml
    /// </summary>
    public partial class ListSong : UserControl
    {

        List<Song> songItems = MainWindow.songItems;
        public ListSong()
        {
            InitializeComponent();
            
           
            gridSong.ItemsSource = songItems;

            countSong.Text = gridSong.Items.Count + " Bài hát";
            
           

        }

        private void AddSong_Click(object sender, RoutedEventArgs e)
        {

           OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Media Files|*.mp3;*.mp4";
            dlg.Multiselect = true;
            if (dlg.ShowDialog()== true)
            {
                foreach (String fileName in dlg.FileNames)
                {
                    
                    var currentDirectory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                    string projectDirectory = currentDirectory.Parent.Parent.Parent.FullName;
                    string destinationDirectory = projectDirectory+"\\MusicPlayer\\AllSongs\\";
                    if(File.Exists(destinationDirectory + Path.GetFileName(fileName)) ==false)
                    {
                        File.Copy(fileName, destinationDirectory + Path.GetFileName(fileName));
                        Mp3Lib.Mp3File Song = new Mp3Lib.Mp3File(destinationDirectory + Path.GetFileName(fileName));
                        int durationSong = Convert.ToInt32(Song.Audio.Duration);
                        string t = (durationSong / 60).ToString("00") + ":" + (durationSong % 60).ToString("00");
                        songItems.Add(new Song() { Number = 1, nameSong = Song.TagHandler.Title, nameArtis = Song.TagHandler.Artist, Time = t, filePath = (destinationDirectory + Path.GetFileName(fileName)) });

                    }
                }
            }

        }

        private void autoorder()
        {
            int t = 1;
            for (int i = 0; i < songItems.Count; i++)
            {
                songItems[i].Number = t;
                t++;
            }
        }

        private void Delete_Song_Click(object sender, RoutedEventArgs e)
        {
            Song S = (sender as Button).DataContext as Song;

            if (MessageBox.Show("Bạn có chắc muốn xóa bài hát : "+S.nameSong, "Question", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                File.Delete(S.filePath);
                MainWindow.songItems.RemoveAt(gridSong.Items.IndexOf(gridSong.SelectedItem));
                songItems = MainWindow.songItems;
            }
            else
            {
            }
            autoorder();
        }
    }

  

}
