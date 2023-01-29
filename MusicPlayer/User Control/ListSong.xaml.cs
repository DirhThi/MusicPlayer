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
          
           

        }

        private void AddSong_Click(object sender, RoutedEventArgs e)
        {

        
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
                gridSong.ItemsSource = songItems;
            }
            else
            {
            }
            autoorder();
            MessageBox.Show(MainWindow.songItems.Count().ToString());
            
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.currentPlaylist = songItems;
            Song S = (sender as Button).DataContext as Song;
            MainWindow.songPlaying = S;
            
        }
    }

  

}
