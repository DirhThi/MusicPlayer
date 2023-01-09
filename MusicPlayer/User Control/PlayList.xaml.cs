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
using System.Windows.Shapes;

namespace MusicPlayer.User_Control
{
    /// <summary>
    /// Interaction logic for PlayList.xaml
    /// </summary>
    public partial class PlayList : UserControl
    {
        List<Song> songItems = MainWindow.songItems;
        public PlayList()
        {
          
            InitializeComponent();

            List<Playlist> items = new List<Playlist>();
            items.Add(new Playlist() { Title = "Thứ 2 tồi tệ"  });
            items.Add(new Playlist() { Title = "Nhạc vui vẻ " });
            items.Add(new Playlist() { Title = "Nhạc buồn xĩu" });
            items.Add(new Playlist() { Title = "Nhạc thất tình" });
            items.Add(new Playlist() { Title = "Thứ 2 tồi tệ" });
            items.Add(new Playlist() { Title = "Nhạc vui vẻ " });
            items.Add(new Playlist() { Title = "Nhạc buồn xĩu" });
            items.Add(new Playlist() { Title = "Nhạc thất tình" });
            items.Add(new Playlist() { Title = "Learn C#" });
            items.Add(new Playlist() { Title = "Wash the car" }); 
            items.Add(new Playlist() { Title = "Learn C#" });
            
            icPlaylist.ItemsSource = items;
            fieldNamePl.Visibility = Visibility.Visible;
            selectSong.Visibility = Visibility.Hidden;
            tb_btn_createPlaylis.Text = "Tiếp tục";

            countPlaylist.Text = items.Count + " Playlist";

            lbSelectSong.ItemsSource = songItems;

        }

        public class Playlist
        {
            
            public string Title { get; set; }
           
        }

        private void CreatePl_Click(object sender, RoutedEventArgs e)
        {
            fieldNamePl.Visibility = Visibility.Hidden;
            selectSong.Visibility = Visibility.Visible;
            tb_btn_createPlaylis.Text = "Lưu";
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            fieldNamePl.Visibility = Visibility.Visible;
            selectSong.Visibility = Visibility.Hidden;
            tb_btn_createPlaylis.Text = "Tiếp tục";
        }
    }
}

