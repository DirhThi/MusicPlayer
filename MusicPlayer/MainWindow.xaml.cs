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
using MusicPlayer.User_Control;
using System.Windows.Threading;
using MusicPlayer.Properties;
using System.IO;
using System.ComponentModel;




namespace MusicPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window, INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(newName));
            }
        }


        private Button[] menuButton;
        public static Song songPlaying;
        public static Song pathSongPlaying = new Song();
        public static  List<Song> songItems = new List<Song>();
        public static List<Song> currentPlaylist = new List<Song>();
        public static int currentIndex = 0;
        int trangthai = 0;//0:pause 1:playing
        DispatcherTimer timer = new DispatcherTimer();
        int Position = 0;
      
        



        public MainWindow()
        {
            InitializeComponent();
            UserControl uc = new Home();
            border.Children.Add(uc);
            btnHome.Style = (Style)Application.Current.Resources["menuButtonChoose"];
            songLoad();
            currentPlaylist = songItems;
            songPlaying = songItems.ElementAt(currentIndex);
            displaySongPlaying(songPlaying);
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromTicks(1);
            timer.Tick += Timer_Tick;
            timer.Start();
            homeUC.lsbTopSongs.SelectionChanged += LsbTopSongs_SelectionChanged;
            sdvolume.Value = 100;
        }


        private void displayposition()
        {
           



        }

        
        private void Timer_Tick(object sender, EventArgs e)
        {
            
                Position = Convert.ToInt32(mp3Player.Position.TotalSeconds);
                slider.Value = Position;
                tbPosition.Text =  (Position / 60).ToString("00") + ":" + (Position % 60).ToString("00");
                if (Position == slider.Maximum)
                {
                    currentIndex++;
                    homeUC.lsbTopSongs.SelectedIndex = currentIndex;
                }
           
        }

        private void LsbTopSongs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (ListBox)sender;
            int indexSong = item.SelectedIndex;
            currentIndex = indexSong;
            songPlaying = songItems.ElementAt(currentIndex);
            displaySongPlaying(songPlaying);
            mp3Player.Source = new Uri(songPlaying.filePath);
            mp3Player.Play();  
            trangthai = 1;
            Mp3Lib.Mp3File Song = new Mp3Lib.Mp3File(songPlaying.filePath);
            slider.Maximum = Convert.ToInt32(Song.Audio.Duration);
        }

       
        private void Form_Load(object sender, RoutedEventArgs e)
        {
            
        }
        
        public  void displaySongPlaying(Song s)
        {
            tbBaiHat.Text = s.nameSong;
            tbCaSi.Text = s.nameArtis;
            tbTime.Text = s.Time;
            
        }

        private void songLoad()
        {
            var currentDirectory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            string projectDirectory = currentDirectory.Parent.Parent.Parent.FullName;
            string destinationDirectory = projectDirectory + "\\MusicPlayer\\AllSongs\\";
            DirectoryInfo d = new DirectoryInfo(destinationDirectory);
            int i = 1;
            foreach (var fileSong in d.GetFiles("*.mp3"))
            { 
                
                Mp3Lib.Mp3File Song = new Mp3Lib.Mp3File(destinationDirectory + fileSong.Name);
                int durationSong = Convert.ToInt32(Song.Audio.Duration);
                string t = (durationSong / 60).ToString("00") + ":"+ (durationSong % 60).ToString("00");
                

                songItems.Add(new Song() { Number = i, nameSong = Song.TagHandler.Title, nameArtis = Song.TagHandler.Artist, Time = t,filePath=(destinationDirectory + fileSong.Name) });
                
                i++;
            }
        }
        private void addUserControl(UserControl uc)
        {
            border.Children.Clear();           
            border.Children.Add(uc);
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

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            if(mp3Player.Source==null)
            {
                mp3Player.Source = new Uri(songPlaying.filePath);
                mp3Player.Play();
                trangthai = 1;
                Mp3Lib.Mp3File Song = new Mp3Lib.Mp3File(songPlaying.filePath);
                slider.Maximum = Convert.ToInt32(Song.Audio.Duration);
            }
            else
            {
                if (trangthai==1)
                {
                    mp3Player.Pause();
                    trangthai = 0;
                }
                else if(trangthai==0)
                {
                    mp3Player.Play();
                    trangthai = 1;
                }
            }
            if (trangthai == 1)
            {
                btnPlay.Content = FindResource("Pause");
            }
            else
            {
                btnPlay.Content = FindResource("Play");
            }


        }

        private void forward_click(object sender, RoutedEventArgs e)
        {
            if (currentIndex == 0)
                currentIndex = currentPlaylist.Count();
            else
                currentIndex = currentIndex - 1;
            homeUC.lsbTopSongs.SelectedIndex = currentIndex;         
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex == currentPlaylist.Count)
                currentIndex = 0;
            else
                currentIndex = currentIndex + 1;
            homeUC.lsbTopSongs.SelectedIndex = currentIndex;
            
        }

        bool isDraging = false;

        private void sdDuration_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (isDraging)
            {
                Position = Convert.ToInt32(slider.Value);
                mp3Player.Position = new TimeSpan(0, 0, (int)Position);
            }
            
        }

        private void sdDuration_MouseDown(object sender, MouseButtonEventArgs e)
        {
            isDraging = true;
        }

        private void sdDuration_MouseUp(object sender, MouseButtonEventArgs e)
        {
            isDraging = false;
        }

        private void volumebtn_Enter(object sender, MouseEventArgs e)
        {
            sdvolume.Visibility=  Visibility.Visible;
        }

       

        

        private void volumebtn_Click(object sender, RoutedEventArgs e)
        {
            if(sdvolume.Value == 0)
                sdvolume.Value = 100;
            else
                sdvolume.Value=0;
            sdvolume.Visibility = Visibility.Hidden;
        }

        private void sdVolume_Leave(object sender, MouseEventArgs e)
        {
            sdvolume.Visibility = Visibility.Hidden;
        }

        private void sdvolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mp3Player.Volume = sdvolume.Value;
            if(sdvolume.Value==0)
                btnVolume.Content=FindResource("Mute");
            else if(sdvolume.Value <30)
                btnVolume.Content = FindResource("LVolume");
            else if (sdvolume.Value <= 60)
                btnVolume.Content = FindResource("MVolume");
            else if (sdvolume.Value <= 100)
                btnVolume.Content = FindResource("HVolume");

        }
    }
    public class Song
    {
        public int Number { get; set; }

        public String nameSong { get; set; }

        public String nameArtis { get; set; }

        public String Time { get; set; }

        public String filePath { get; set; }
    }
}
