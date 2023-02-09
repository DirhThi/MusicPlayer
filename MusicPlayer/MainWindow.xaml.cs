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
using Microsoft.Win32;
using System.IO;
using System.ComponentModel;
using System.Windows.Media.Animation;

using WMPLib;




namespace MusicPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        private Button[] menuButton;
        private Button[] favButton;
        int TrangThaiP = 0;//0 Khoi tao , 1 chon bai hat
        List<Playlist> playlistsItems = new List<Playlist>();
        private UserControl[] Uc;
        public static Song songPlaying;
        public static Song pathSongPlaying = new Song();
        public static  List<Song> songItems = new List<Song>();
        public static List<Song> currentPlaylist = new List<Song>();
        public static int currentIndex = 0;
        int baitieptheo = 0;//0:shuffledisable 1:shuffle 2:repeatonce
        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer alarm = new DispatcherTimer();
        int count = 0;
        int Position = 0;
      
        



        public MainWindow()
        {
            InitializeComponent();
            
            btnHome.Style = (Style)Application.Current.Resources["menuButtonChoose"];
            homeUC.ShuffleDisabledbtn.Style = (Style)Application.Current.Resources["favoriteButtonChoose"];
            songLoad();
            currentPlaylist = songItems;
            songPlaying = songItems.ElementAt(currentIndex);
            displaySongPlaying(songPlaying);
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromTicks(1);
            timer.Tick += Timer_Tick;
            timer.Start();
            alarm.Interval = TimeSpan.FromMilliseconds(1000);
            alarm.Tick += Alarm_Tick;
            sdvolume.Value = 100;
            mp3Player.Volume = 1;
            homeUC.lsbTopSongs.SelectionChanged += LsbTopSongs_SelectionChanged;
            homeUC.ShuffleDisabledbtn.Click += ShuffleDisabledbtn_Click;
            homeUC.Shufflebtn.Click += Shufflebtn_Click;
            homeUC.RepeatOncebtn.Click += RepeatOncebtn_Click;
            epUC.playep.Click += Playep_Click;
            listsongUC.addsongbtn.Click += Addsongbtn_Click;
            listsongUC.gridSong.SelectionChanged += GridSong_SelectionChanged;
            playlistUC.contbtn.Click += Contbtn_Click;
            playlistUC.createplbtn.Click += Createplbtn_Click;
            playlistUC.cancelDialog.Click += CancelDialog_Click;
            listsongUC.deleteSongbtn.Click += DeleteSongbtn_Click;
            homeUC.panelPlaylist.SelectionChanged += PanelPlaylist_SelectionChanged;
            listsongUC.playAllsongbtn.Click += PlayAllsongbtn_Click;
            playlistUC.playPlaylistbtn.Click += PlayPlaylistbtn_Click;
            playlistUC.datagridSongPlaylist.SelectionChanged += DatagridSongPlaylist_SelectionChanged;
            playlistUC.deleteSongbtn.Click += DeleteSongbtn_Click1;
            playlistUC.deletePlbtn.Click += DeletePlbtn_Click;
            listSong_Load();
            home_Load();
            playlistUC_Load();

            
        }

        private void Alarm_Tick(object sender, EventArgs e)
        {
            if (count > 0)
            {
                alarmtb.Text = (count / 60).ToString("00") + ":" + (count % 60).ToString("00");
                count--;

            }
            else
            {
                alarmtb.Text = "Hẹn giờ";
                alarm.Stop();
                mp3Player.Pause();
                btnPlay.IsChecked = false;

            }
        }
        private void DeletePlbtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa Playlist đã chọn ? ", "Question", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Playlist P = new Playlist();
                for (int i = 0; i < playlistsItems.Count; i++)
                {
                    if (playlistsItems[i].Title == playlistUC.namePlaylistSong.Text)
                    {
                        P = playlistsItems[i];
                    }                  
                }
                playlistsItems.RemoveAt(playlistsItems.IndexOf(P));     
                playlistUC.countPlaylist.Text = playlistsItems.Count + " Playlist";
                playlistUC.icPlaylist.Items.Refresh();
                homeUC.panelPlaylist.SelectedIndex = -1;
                homeUC.panelPlaylist.Items.Refresh();
                listsongUC.icPlaylist.Items.Refresh();
                playlistUC.gridPlaylist.Visibility = Visibility.Visible;
                playlistUC.gridSongPlaylist.Visibility = Visibility.Hidden;
                File.Delete(P.PlaylistPath);
                MessageBox.Show("Xóa thành công !");
            }
             
        }

        private void DeleteSongbtn_Click1(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa tất cả bài hát đã chọn khỏi Playlist ? ", "Question", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Playlist P = new Playlist();
                for (int i = 0; i < playlistsItems.Count; i++)
                {
                    if (playlistsItems[i].Title == playlistUC.namePlaylistSong.Text)
                    {
                        P = playlistsItems[i];
                    }
                }
                List<string> songPlaylisttoString = File.ReadAllLines(P.PlaylistPath).ToList();
                for (int i = 0; i < playlistUC.datagridSongPlaylist.SelectedItems.Count; i++)
                {
                    
                    int t = playlistUC.datagridSongPlaylist.Items.IndexOf(playlistUC.datagridSongPlaylist.SelectedItems[i]);
                    songPlaylisttoString.RemoveAt(t);
                }
                File.WriteAllLines(P.PlaylistPath, songPlaylisttoString.ToArray());

                //load song again
                List<Song> songPlaylist = new List<Song>();
                foreach (string line in File.ReadLines(P.PlaylistPath))
                {
                    for (int i = 0; i < songItems.Count; i++)
                    {
                        if (System.IO.Path.GetFileName(songItems[i].filePath) == line)
                        {
                            songPlaylist.Add(songItems[i]);
                        }
                    }
                }

                //sap xep stt
                {
                    int t = 1;
                    for (int i = 0; i < songPlaylist.Count; i++)
                    {
                        songPlaylist[i].Number = t;
                        t++;
                    }
                }
                playlistUC.datagridSongPlaylist.ItemsSource = songPlaylist;
                playlistUC.UpdateLayout();
                playlistUC.datagridSongPlaylist.UpdateLayout();
                playlistUC.datagridSongPlaylist.Items.Refresh();
                playlistUC.countSong.Text = songPlaylist.Count + " Bài hát";
                MessageBox.Show("Xóa thành công !");

            }

        }

        private void DatagridSongPlaylist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           if(playlistUC.datagridSongPlaylist.SelectedItems.Count>=1)
            {
                playlistUC.deletePlnplayPlbtn.Visibility = Visibility.Hidden;
                playlistUC.deleteSong.Visibility = Visibility.Visible;
            }
           else
            {
                playlistUC.deletePlnplayPlbtn.Visibility = Visibility.Visible;
                playlistUC.deleteSong.Visibility = Visibility.Hidden;
            }
        }

        private void PlayPlaylistbtn_Click(object sender, RoutedEventArgs e)
        {
            int indexPlaylist = -1;
            for(int i=0;i<playlistsItems.Count;i++)
            {
                if(playlistsItems[i].Title==playlistUC.namePlaylistSong.Text)
                {
                    indexPlaylist = i;
                }
            }
            homeUC.panelPlaylist.SelectedIndex = indexPlaylist;
        }

        private void PlayAllsongbtn_Click(object sender, RoutedEventArgs e)
        {
            currentPlaylist.Clear();
            currentPlaylist = songItems;
            homeUC.lsbTopSongs.ItemsSource = currentPlaylist;
            homeUC.UpdateLayout();
            homeUC.lsbTopSongs.UpdateLayout();
            homeUC.lsbTopSongs.Items.Refresh();
            homeUC.lsbTopSongs.SelectedIndex = 0;

        }

        private void PanelPlaylist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (ListBox)sender;
            if(item.SelectedIndex>=0)
            {
                Playlist Playlist = playlistsItems.ElementAt(item.SelectedIndex);
                List<Song> songPlaylist = new List<Song>();
                foreach (string line in File.ReadLines(Playlist.PlaylistPath))
                {
                    for (int i = 0; i < songItems.Count; i++)
                    {
                        if (System.IO.Path.GetFileName(songItems[i].filePath) == line)
                        {
                            songPlaylist.Add(songItems[i]);
                        }
                    }
                }
                currentPlaylist.Clear();
                currentPlaylist = songPlaylist;
                //sap xep stt
                {
                    int t = 1;
                    for (int i = 0; i < songPlaylist.Count; i++)
                    {
                        songPlaylist[i].Number = t;
                        t++;
                    }
                }
                homeUC.lsbTopSongs.ItemsSource = currentPlaylist;
                homeUC.UpdateLayout();
                homeUC.lsbTopSongs.UpdateLayout();
                homeUC.lsbTopSongs.Items.Refresh();
                homeUC.lsbTopSongs.SelectedIndex = 0;
            }
            
        }

        private void DeleteSongbtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa tất cả bài hát đã chọn ? " , "Question", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                for(int i=0; i<listsongUC.gridSong.SelectedItems.Count;i++)
                {
                    int t = listsongUC.gridSong.Items.IndexOf(listsongUC.gridSong.SelectedItems[i]);
                    File.Delete(songItems[t].filePath);

                }
                checkSong();
                songItems.Clear();
                songLoad();
                listSong_Load();
                listsongUC.UpdateLayout();
                listsongUC.gridSong.UpdateLayout();
                listsongUC.gridSong.Items.Refresh();
                homeUC.UpdateLayout();
                homeUC.lsbTopSongs.UpdateLayout();
                homeUC.lsbTopSongs.Items.Refresh();
                autoorder();
                MessageBox.Show("Xóa thành công !");

            }



        }

        private void GridSong_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listsongUC.gridSong.SelectedItems.Count >= 1)
            {
                listsongUC.addnplay.Visibility = Visibility.Hidden;
                listsongUC.delnaddpl.Visibility = Visibility.Visible;
            }
            else
            {
                listsongUC.addnplay.Visibility = Visibility.Visible;
                listsongUC.delnaddpl.Visibility = Visibility.Hidden;
            }
        }

        private void CancelDialog_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Createplbtn_Click(object sender, RoutedEventArgs e)
        {
            TrangThaiP = 0;
            playlistUC.fieldNamePl.Visibility = Visibility.Visible;
            playlistUC.selectSong.Visibility = Visibility.Hidden;
            playlistUC.tb_btn_createPlaylis.Text = "Tiếp tục";
            playlistUC.namePlaylist.Clear();
        }

        private void Contbtn_Click(object sender, RoutedEventArgs e)
        {
            if (TrangThaiP == 0)
            {
                if (playlistUC.namePlaylist.Text.Length == 0)
                {
                    playlistUC.Popup.PlacementTarget = playlistUC.namePlaylist;
                    playlistUC.Popup.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
                    playlistUC.Popup.IsOpen = true;
                }
                else
                {
                    int check = 0;
                    var currentDirectory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                    string projectDirectory = currentDirectory.Parent.Parent.Parent.FullName;
                    string destinationDirectory = projectDirectory + "\\MusicPlayer\\Playlists\\";
                    DirectoryInfo d = new DirectoryInfo(destinationDirectory);
                    foreach (var filePlaylist in d.GetFiles("*.txt"))
                    {
                        string t = filePlaylist.Name.Replace(".txt", "");
                        if(t==playlistUC.namePlaylist.Text)
                        {
                            MessageBox.Show("Tên Playlist đã tồn tại ! ");
                             check = 1;
                        }
                    }
                    if(check==0)
                    {
                        playlistUC.Popup.IsOpen = false;
                        playlistUC.fieldNamePl.Visibility = Visibility.Hidden;
                        playlistUC.selectSong.Visibility = Visibility.Visible;
                        playlistUC.tb_btn_createPlaylis.Text = "Lưu";
                        TrangThaiP = 1;
                    }
                    
                }

            }
            else
            {
                if(playlistUC.lbSelectSong.SelectedItems.Count<1)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất 1 bài hát !");
                }
                else
                {
                    var currentDirectory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                    string projectDirectory = currentDirectory.Parent.Parent.Parent.FullName;
                    string destinationDirectory = projectDirectory + "\\MusicPlayer\\Playlists\\";
                    string PlaylistPath = destinationDirectory + playlistUC.namePlaylist.Text + ".txt";
                    //  File.Copy(fileName, destinationDirectory + Path.GetFileName(fileName));
                    StreamWriter w = new StreamWriter(PlaylistPath, true);


                    for (int i = 0; i < playlistUC.lbSelectSong.SelectedItems.Count; i++)
                    {
                        int t = playlistUC.lbSelectSong.Items.IndexOf(playlistUC.lbSelectSong.SelectedItems[i]);
                        string s = System.IO.Path.GetFileName(songItems[i].filePath);
                        w.WriteLine(s);
                    }
                    w.Close();
                    playlistUC.Dialog.IsOpen = false;
                    playlistsItems.Clear();
                    PlaylistLoad();
                    playlistUC.countPlaylist.Text = playlistsItems.Count + " Playlist";
                    playlistUC.icPlaylist.Items.Refresh();
                    homeUC.panelPlaylist.Items.Refresh();
                    listsongUC.icPlaylist.Items.Refresh();
                    MessageBox.Show("Thêm thành công !");


                }





            }
        }

        public void playlistUC_Load()
        {
            PlaylistLoad();
            
            playlistUC.icPlaylist.ItemsSource = playlistsItems;
            playlistUC.fieldNamePl.Visibility = Visibility.Visible;
            playlistUC.selectSong.Visibility = Visibility.Hidden;
            playlistUC.tb_btn_createPlaylis.Text = "Tiếp tục";
            playlistUC.countPlaylist.Text = playlistsItems.Count + " Playlist";
            playlistUC.lbSelectSong.ItemsSource = songItems;
            playlistUC.gridPlaylist.Visibility = Visibility.Visible;
            playlistUC.gridSongPlaylist.Visibility = Visibility.Hidden;
            playlistUC.Dialog.IsOpen = false;


        }

        public void PlaylistLoad()
        {
            var currentDirectory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            string projectDirectory = currentDirectory.Parent.Parent.Parent.FullName;
            string destinationDirectory = projectDirectory + "\\MusicPlayer\\Playlists\\";
            DirectoryInfo d = new DirectoryInfo(destinationDirectory);
            foreach (var filePlaylist in d.GetFiles("*.txt"))
            {
                string t = filePlaylist.Name.Replace(".txt", "");
                playlistsItems.Add(new Playlist() { Title = t, PlaylistPath = d.ToString() + filePlaylist.Name });
            }
        }

        private void checkSong()
        {
            for(int i=currentPlaylist.Count-1;i>=0;i--)
            {
                
                if(File.Exists(currentPlaylist[i].filePath)==false)
                {
                    currentPlaylist.RemoveAt(i);
                }    

            }    

        }

        private void RepeatOncebtn_Click(object sender, RoutedEventArgs e)
        {
            BtnChoose(homeUC.RepeatOncebtn);
            baitieptheo = 2;
        }

        private void Shufflebtn_Click(object sender, RoutedEventArgs e)
        {
            BtnChoose(homeUC.Shufflebtn);
            baitieptheo = 1;

        }

        private void ShuffleDisabledbtn_Click(object sender, RoutedEventArgs e)
        {
            BtnChoose(homeUC.ShuffleDisabledbtn);
            baitieptheo = 0;

        }

        private void Playep_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("2222222");
        }
        private void home_Load()
        {
            homeUC.lsbTopSongs.ItemsSource = currentPlaylist;
            homeUC.panelPlaylist.ItemsSource = playlistsItems;

        }
        private void  listSong_Load()
        {

            listsongUC.gridSong.ItemsSource = songItems;
            listsongUC.countSong.Text = listsongUC.gridSong.Items.Count + " Bài hát";
            listsongUC.icPlaylist.ItemsSource = playlistsItems;    
            
        }
        private void Addsongbtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Media Files|*.mp3;*.mp4";
            dlg.Multiselect = true;
            if (dlg.ShowDialog() == true)
            {
                foreach (String fileName in dlg.FileNames)
                {

                    var currentDirectory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                    string projectDirectory = currentDirectory.Parent.Parent.Parent.FullName;
                    string destinationDirectory = projectDirectory + "\\MusicPlayer\\AllSongs\\";
                    if (File.Exists(destinationDirectory + Path.GetFileName(fileName)) == false)
                    {
                        File.Copy(fileName, destinationDirectory + Path.GetFileName(fileName));
                    }
                    else
                    {
                        MessageBox.Show("Bài hát " + Path.GetFileName(fileName) + " đã tồn tại .");
                    }
                }
                songItems.Clear();
                songLoad();
                listSong_Load();
                listsongUC.UpdateLayout();
                listsongUC.gridSong.UpdateLayout();
                listsongUC.gridSong.Items.Refresh();

                autoorder();

                MessageBox.Show("Thêm hoàn thành");
                // home_Load();            
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            
                Position = Convert.ToInt32(mp3Player.Position.TotalSeconds);
                slider.Value = Position;
                tbPosition.Text =  (Position / 60).ToString("00") + ":" + (Position % 60).ToString("00");
                if (Position == slider.Maximum)
                {
                    if (baitieptheo == 0)
                    {
                        if (currentIndex == currentPlaylist.Count)
                            currentIndex = 0;
                        else
                            currentIndex = currentIndex + 1;
                        homeUC.lsbTopSongs.SelectedIndex = currentIndex;
                    }
                    else if (baitieptheo == 1)
                    {
                        int number = currentIndex;
                        Random r = new Random();
                        do
                        {
                            number = r.Next(0, currentPlaylist.Count() + 1);
                        } while (number == currentIndex);
                        currentIndex = number;
                        homeUC.lsbTopSongs.SelectedIndex = currentIndex;
                    }
                    else
                    {
                    mp3Player.Position = new TimeSpan(0, 0, 0);


                }
            }
           
        }

        private void LsbTopSongs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            var item = (ListBox)sender;
            int indexSong = item.SelectedIndex;
            if( indexSong >=0 )
            {
                currentIndex = indexSong;
                songPlaying = currentPlaylist.ElementAt(currentIndex);
                displaySongPlaying(songPlaying);
                mp3Player.Source = new Uri(songPlaying.filePath);
                mp3Player.Play();  
                Mp3Lib.Mp3File Song = new Mp3Lib.Mp3File(songPlaying.filePath);
                slider.Maximum = Convert.ToInt32(Song.Audio.Duration);
                btnPlay.IsChecked = true;
            }
           
        }

       
        private void Form_Load(object sender, RoutedEventArgs e)
        {
            
        }
        
        public  void displaySongPlaying(Song s)
        {
            tbBaiHat.Text = s.nameSong;
            tbCaSi.Text = s.nameArtis;
            tbTime.Text = s.Time;
            var bitmap = new System.Drawing.Bitmap(s.imageSong);
            var bitmapSource = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(bitmap.GetHbitmap(),
                                                                            IntPtr.Zero,
                                                                            Int32Rect.Empty,
                                                                            BitmapSizeOptions.FromEmptyOptions()
            );
            bitmap.Dispose();
            var brush = new ImageBrush(bitmapSource);
            songPictureDisplay.Fill = brush;
            homeUC.RTBlyrics.Document.Blocks.Clear();
            homeUC.RTBlyrics.Document.Blocks.Add(new Paragraph(new Run(songPlaying.lyrics)));
        }

        private static void songLoad()
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
                songItems.Add(new Song() { Number = i, nameSong = Song.TagHandler.Title, nameArtis = Song.TagHandler.Artist, Time = t,filePath=(destinationDirectory + fileSong.Name),imageSong=Song.TagHandler.Picture,lyrics=Song.TagHandler.Lyrics });
                
                i++;
               
            }
        }
        private void addUserControl(UserControl uc)
        {
            border.Children.Clear();           
            border.Children.Add(uc);
        }        

        private void MenuBtnChoose(Button bt)
        {
            menuButton = new Button[] { btnHome, btnSong, btnPlaylist/*, btnFavorite, btnExplore*/ };
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

        private void BtnChoose(Button bt)
        {
            favButton = new Button[] { homeUC.ShuffleDisabledbtn, homeUC.Shufflebtn, homeUC.RepeatOncebtn };
            foreach (Button btn in favButton)
            {
                if (btn == bt)
                {
                    
                    btn.Style = (Style)Application.Current.Resources["favoriteButtonChoose"];
                }
                else
                {
                    
                    btn.Style = (Style)Application.Current.Resources["favoriteButton"];
                }
            }

        }


        private void UCChoose(UserControl uc)
        {
            Uc = new UserControl[] { homeUC, listsongUC, playlistUC,epUC };
            foreach (UserControl U in Uc)
            {
                if (U == uc)
                {
                    U.Visibility = Visibility.Visible;
                }
                else
                {
                   U.Visibility = Visibility.Hidden;
                }
            }

        }
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            songItems = new List<Song>();
            songLoad();
            MenuBtnChoose(btnHome);           
            UCChoose(homeUC);
        }

        private void Song_Click(object sender, RoutedEventArgs e)
        {
            songItems = new List<Song>();
            songLoad();
            MenuBtnChoose(btnSong);
            UCChoose(listsongUC);
            listSong_Load();
            listsongUC.UpdateLayout();
            listsongUC.gridSong.UpdateLayout();
            listsongUC.gridSong.Items.Refresh();
            

        }

        private void Playlist_Click(object sender, RoutedEventArgs e)
        {
            
            MenuBtnChoose(btnPlaylist);
            UCChoose(playlistUC);

            playlistUC.icPlaylist.ItemsSource = playlistsItems;
            playlistUC.fieldNamePl.Visibility = Visibility.Visible;
            playlistUC.selectSong.Visibility = Visibility.Hidden;
            playlistUC.tb_btn_createPlaylis.Text = "Tiếp tục";
            playlistUC.countPlaylist.Text = playlistsItems.Count + " Playlist";
            playlistUC.lbSelectSong.ItemsSource = songItems;
            playlistUC.lbSelectSong.Items.Refresh();
            playlistUC.gridPlaylist.Visibility = Visibility.Visible;
            playlistUC.gridSongPlaylist.Visibility = Visibility.Hidden;
            playlistUC.Dialog.IsOpen = false;
        }

       /* private void Explore_Click(object sender, RoutedEventArgs e)
        {
            MenuBtnChoose(btnExplore);
            UCChoose(epUC);
        }*/

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            if (mp3Player.Source == null)
            {
                mp3Player.Source = new Uri(songPlaying.filePath);
                mp3Player.Play();
                Mp3Lib.Mp3File Song = new Mp3Lib.Mp3File(songPlaying.filePath);
                slider.Maximum = Convert.ToInt32(Song.Audio.Duration);
            }
            else
            {
                if(btnPlay.IsChecked==false)
                {
                    mp3Player.Pause();
                    
                  //  rotate.Stop();
                    
                }
                else
                {
                    mp3Player.Play();
                //    rotate.Resume();

                }
            }


        }

        private void forward_click(object sender, RoutedEventArgs e)
        {
            if(baitieptheo==0)
            {
                if (currentIndex == 0)
                    currentIndex = currentPlaylist.Count();
                else
                    currentIndex = currentIndex - 1;
                homeUC.lsbTopSongs.SelectedIndex = currentIndex;
            }
            else if(baitieptheo==1)
            {
                int number = currentIndex;
                Random r = new Random();
                do
                {
                    number = r.Next(0, currentPlaylist.Count() + 1);
                } while (number == currentIndex);
                currentIndex = number;
                homeUC.lsbTopSongs.SelectedIndex = currentIndex;
            }
            else
            {

            }
                  
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            if (baitieptheo == 0)
            {
                if (currentIndex == currentPlaylist.Count)
                    currentIndex = 0;
                else
                    currentIndex = currentIndex + 1;
                homeUC.lsbTopSongs.SelectedIndex = currentIndex;
            }
            else if (baitieptheo == 1)
            {
                int number = currentIndex;
                Random r = new Random();
                do
                {
                    number = r.Next(0, currentPlaylist.Count() + 1);
                } while (number == currentIndex);
                currentIndex = number;
                homeUC.lsbTopSongs.SelectedIndex = currentIndex;
            }
            else
            {

            }
            
            
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
            mp3Player.Volume = sdvolume.Value/100;
            if(sdvolume.Value==0)
                btnVolume.Content=FindResource("Mute");
            else if(sdvolume.Value <30)
                btnVolume.Content = FindResource("LVolume");
            else if (sdvolume.Value <= 60)
                btnVolume.Content = FindResource("MVolume");
            else if (sdvolume.Value <= 100)
                btnVolume.Content = FindResource("HVolume");

        }

        private void speedplaybtn(object sender, RoutedEventArgs e)
        {
            if(speedbtn.IsChecked==true)
            {
                mp3Player.SpeedRatio = 1.7;
            }
            else if(speedbtn.IsChecked==false)
            {
                mp3Player.SpeedRatio = 1.0;
            }
        }

        private void alarm5(object sender, RoutedEventArgs e)
        {
            count = 5*60;
            alarm.Start();
            expenderAlarm.IsExpanded = false;
        }

        private void alarm10(object sender, RoutedEventArgs e)
        {
            count = 10 * 60;
            alarm.Start();
            expenderAlarm.IsExpanded = false;
        }

       private void alarm15(object sender, RoutedEventArgs e)
        {
            count = 15 * 60;
            alarm.Start();
            expenderAlarm.IsExpanded = false;
        }
        
        private void alarm20(object sender, RoutedEventArgs e)
        {
            count = 20 * 60;
            alarm.Start();
            expenderAlarm.IsExpanded = false;
        }
        private void alarm30(object sender, RoutedEventArgs e)
        {
            count = 30 * 60;
            alarm.Start();
            expenderAlarm.IsExpanded = false;
        }
        private void alarm45(object sender, RoutedEventArgs e)
        {
            count = 45 * 60;
            alarm.Start();
            expenderAlarm.IsExpanded = false;
        }
        private void alarm60(object sender, RoutedEventArgs e)
        {
            count = 60 * 60;
            alarm.Start();
            expenderAlarm.IsExpanded = false;
        }
    }
    public class Song
    {
        public int Number { get; set; }

        public String nameSong { get; set; }

        public String nameArtis { get; set; }

        public String Time { get; set; }

        public String filePath { get; set; }

        public System.Drawing.Image imageSong { get; set; }

        public string lyrics { get; set; }
    }

    public class Playlist
    {
        public string Title { get; set; }
        public string PlaylistPath { get; set; }

    }
}
