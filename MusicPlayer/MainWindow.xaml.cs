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
using MusicPlayer.User_Control;
using MusicPlayer.Properties;



namespace MusicPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl uc)
        {
            border.Children.Clear();           
            border.Children.Add(uc);
        }



        private void BtnChoose(Button btn)
        {
            
        }


        private void Form_Load(object sender, RoutedEventArgs e)
        {
            UserControl uc = new Home();
            border.Children.Add(uc);
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            UserControl uc = new Home();
            addUserControl(uc);
        }


        private void Song_Click(object sender, RoutedEventArgs e)
        {
            UserControl uc = new ListSong();
            addUserControl(uc);
        }

        private void Playlist_Click(object sender, RoutedEventArgs e)
        {
            UserControl uc = new PlayList();
            addUserControl(uc);
        }

        private void Explore_Click(object sender, RoutedEventArgs e)
        {
            UserControl uc = new Explore();
            addUserControl(uc);
        }
    }
}
