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
using MusicPlayer;

namespace MusicPlayer.User_Control
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    /// 
    public partial class Home : UserControl
    {      
        List<Song> songItems = MainWindow.songItems;
        public int currentIndex = MainWindow.currentIndex;
        
        public Home()
        {
            InitializeComponent();
            List<Playlist> items = new List<Playlist>();
            items.Add(new Playlist() { Title = "Thứ 2 tồi tệ" });
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

        }

        private void Home_Load(object sender, RoutedEventArgs e)
        {
        }

      
        public class Playlist
        {

            public string Title { get; set; }

        }
    }
}
