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

        private Button[] menuButton;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl uc)
        {
            border.Children.Clear();           
            border.Children.Add(uc);
        }

        private void Form_Load(object sender, RoutedEventArgs e)
        {
            UserControl uc = new Home();
            border.Children.Add(uc);
            btnHome.Style = (Style)Application.Current.Resources["menuButtonChoose"];
        }

        private void BtnChoose(Button bt)
        {
            menuButton = new Button[] { btnHome, btnSong, btnPlaylist, btnFavorite, btnExplore };
            foreach( Button btn in menuButton )
            {
                if(btn==bt)
                {
                    Brush b = Brushes.Coral;
                    btn.Background = b;
                    btn.Style = (Style)Application.Current.Resources["menuButtonChoose"];
                }
                else
                {
                    Brush b = Brushes.Transparent;
                    btn.Background = b;
                    btn.Style = (Style)Application.Current.Resources["menuButton"];
                }
            }
        }


       

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            BtnChoose(btnHome);
             UserControl uc = new Home();
            addUserControl(uc);
        }


        private void Song_Click(object sender, RoutedEventArgs e)
        {
            BtnChoose(btnSong);
            UserControl uc = new ListSong();
            addUserControl(uc);
        }

        private void Playlist_Click(object sender, RoutedEventArgs e)
        {
            BtnChoose(btnPlaylist);
            UserControl uc = new PlayList();
            addUserControl(uc);
        }

        private void Explore_Click(object sender, RoutedEventArgs e)
        {
            BtnChoose(btnExplore);
            UserControl uc = new Explore();
            addUserControl(uc);
        }
    }
}
