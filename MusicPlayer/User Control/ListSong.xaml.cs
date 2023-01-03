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
using System.Collections.ObjectModel;

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
            List<Song> items = new List<Song>();
            items.Add(new Song() { Number = 1, nameSong = "Chuyện tình con mèo", nameArtis = "Con mèo con", Time = "03:00" });
            items.Add(new Song() { Number = 2, nameSong = "Chuyện tình con mèo", nameArtis = "Con mèo con", Time = "03:00" });
            items.Add(new Song() { Number = 3, nameSong = "Chuyện tình con mèo", nameArtis = "Con mèo con", Time = "03:00" });
            items.Add(new Song() { Number = 4, nameSong = "Chuyện tình con mèo", nameArtis = "Con mèo con", Time = "03:00" });
            items.Add(new Song() { Number = 5, nameSong = "Chuyện tình con mèo", nameArtis = "Con mèo con", Time = "03:00" });
            items.Add(new Song() { Number = 6, nameSong = "Chuyện tình con mèo", nameArtis = "Con mèo con", Time = "03:00" });
            items.Add(new Song() { Number = 7, nameSong = "Chuyện tình con mèo", nameArtis = "Con mèo con", Time = "03:00" });
            items.Add(new Song() { Number = 8, nameSong = "Chuyện tình con mèo", nameArtis = "Con mèo con", Time = "03:00" });
            items.Add(new Song() { Number = 9, nameSong = "Chuyện tình con mèo", nameArtis = "Con mèo con", Time = "03:00" });
            items.Add(new Song() { Number = 10, nameSong = "Chuyện tình con mèo", nameArtis = "Con mèo con", Time = "03:00" });
            items.Add(new Song() { Number = 11, nameSong = "Chuyện tình con mèo", nameArtis = "Con mèo con", Time = "03:00" });
            items.Add(new Song() { Number = 12, nameSong = "Chuyện tình con mèo", nameArtis = "Con mèo con", Time = "03:00" });
            items.Add(new Song() { Number = 13, nameSong = "Chuyện tình con mèo", nameArtis = "Con mèo con", Time = "03:00" });
            items.Add(new Song() { Number = 14, nameSong = "Chuyện tình con mèo", nameArtis = "Con mèo con", Time = "03:00" });
            items.Add(new Song() { Number = 15, nameSong = "Chuyện tình con mèo", nameArtis = "Con mèo con", Time = "03:00" });

            gridSong.ItemsSource = items;



        }

    }

    public class Song
    {
        public int Number { get; set; }

        public String nameSong { get; set; }

        public String nameArtis { get; set; }

        public String Time { get; set; }


    }

}
