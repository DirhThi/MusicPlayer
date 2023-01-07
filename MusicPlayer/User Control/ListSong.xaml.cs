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
            List<Song> songItems = MainWindow.songItems;
           
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
                     File.Copy(fileName, destinationDirectory + Path.GetFileName(fileName));
                }
            }

        }
    }

  

}
