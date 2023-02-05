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

        public ListSong()
        {
            InitializeComponent();      
          
           

        }

        private void playlistbtn(object sender, RoutedEventArgs e)
        {
            Playlist P = (sender as Button).DataContext as Playlist;
            if (MessageBox.Show("Thêm các bài hát đã chọn vào Playlist : " + P.Title, "Question", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
               
                    for (int i = 0; i < gridSong.SelectedItems.Count; i++)
                    {
                        int check = 0;
                        int t = gridSong.Items.IndexOf(gridSong.SelectedItems[i]);
                        foreach (string line in File.ReadLines(P.PlaylistPath))
                        {
                            if (System.IO.Path.GetFileName(MainWindow.songItems[t].filePath) == line)
                            {
                            check = 1;
                            }

                        }
                        if(check==0)
                        {
                            StreamWriter w = new StreamWriter(P.PlaylistPath, true);
                            string s = System.IO.Path.GetFileName(MainWindow.songItems[t].filePath);
                            w.WriteLine(s);
                            w.Close();
                        }

                    }
               
                Dialog.IsOpen = false;
                MessageBox.Show("Thêm thành công !");
            }
        }   
    }

  

}
