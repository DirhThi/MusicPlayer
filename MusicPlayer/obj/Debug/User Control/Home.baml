   M S B A M L   `   `   `  ????F  BMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MusicPlayerMusicPlayer  5      #    MusicPlayer.User_Control.Home   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      h dMahApps.Metro.IconPacks.Fontaudio, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.RemixIcon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah	 dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag
 cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a^ ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.BootstrapIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Codicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.PixelartIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RadixIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.VaadinIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.FileIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Fontisto, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah  dMahApps.Metro.IconPacks.Coolicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai! eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai" eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am# iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag$ cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj% fMahApps.Metro.IconPacks.ForkAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137axIcon-http://metro.mahapps.com/winfx/xaml/iconpacks!     	 
                        ! " # $ % 5      zd2http://schemas.microsoft.com/expression/blend/2008!     	 
                        ! " # $ % 5      ?mc;http://schemas.openxmlformats.org/markup-compatibility/2006!     	 
                        ! " # $ % 5      elocalclr-namespace:MusicPlayer!     	 
                        ! " # $ % 5      _& [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes & 5	      -   5        $??Trangchu??5
      $	??540??5      $	??780??6   .??5      ? -   5        ???#F8F4EA  ? ColumnDefinitions  5   
   ?? 5      $??* ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $??* ?6   .+?5   
   ?? $??0??6   
?????? $??20 20 10 10q?6>   .+?5      ?? $??Trang chủ??6   $	??5 0q?6)   $??30(?66      	menuTitle#??[  6D   ?? 5       ?? CornerRadius$ 20??6   $??0,20,0,0q?6'   $	??400??69   ??5      ?? 5      .??5      ?  ? Color$ Coral??6'    ? Offset$ 0Q?65   ? 5       $ Orange??6'   $ 1Q?66   5!       J? Effect 5#      3  -System.Windows.Media.Effects.DropShadowEffect  5$         
BlurRadius$ 20Q?6'      ShadowDepth$ 5Q?67      Color$	 Red??6H   ._?5&      ?   5'      ?? 5(      $
??auto ?6+   ?? 5)      $??* ?6+    5+      ?? 5,      $
??auto ?6(   ?? 5-      $??* ?6(   .+?5/      ?? $??0??6    $??0??6-   $??Danh sách bài hát??6=   	 J? Opacity$		 0.9Q?6W   $??30 10q?6e   #??[  6u   ?? 50      $??5 0 0 0q?6!   $??1??62   
 ?? Orientation$
 
Horizontal=?6B   .+?51      ?? -   5         ??Name$ ShuffleDisabledbtn??51   !   $??0,0,0,0q?6=   $??30??6N   $??30??6Z    ? Cursor$
 Hand??6e   $??0??6s     favoriteButton#??[ 6?   .??52      .  (MahApps.Metro.IconPacks.PackIconMaterial  $??12??65      Kind$ ShuffleDisabled=?6A   $y?Visible=?6X   53      ?? 54      -   5        $ 
Shufflebtn??54   !   $??0,0,0,0q?65   $??30??6F   $??30??6R   $
 Hand??6]   $??0??6k   #??[ 6y   .??55        $??12??65   $ Shuffle=?6A   $y?Visible=?6P   56      ?? 57      -   5        $ RepeatOncebtn??57   !   $??0,0,0,0q?68   $??30??6J   $??30??6V   $
 Hand??6a   $??0??6p   #??[ 6}   .??58        $ 
RepeatOnce=?65   $y?Visible=?6G   59      5;      ? 5=      $??
15 0 15 20q?6   $??1??6/   $??0??6<   $??3??6L   .+?5>      ?? -   5         ??Name$ lsbTopSongs??5>   U   $??Hidden=?6#   $??Stretch=?6j   ??5?      ?? 5@   "    ?? 
TargetType" ??6(   .?5A   &   ??  ?? Property ? |? ?? Value . 6B   5C   #   ??5F      ?? 5G   "   .R?5H   &   ??  ??Name$ btnSong??6;   $
 Hand??6-   $??30,0,5,0q?6L   $??0??6^   $??1??6k   ._?5I   *   ?? $??Center=?66   $??Stretch=?6Q   $
 
Horizontal=?6p   .+?5J   .   ??  ??Name$ number??6?   $??Center=?68   $??Center=?6S   $??12(?6?   $??Medium"?6?   $		 0.9Q?6?   $
??0 10q?6?   ??6p   ?? *Number+6?   ?? 5K   .   $	??200??69   $
??20 0q?6E   $??Center=?6T   $
??Left=?6o   $
 Vertical=?6?   .+?5L   2   ?? $??Center=?6<   $
??Left=?6W   $		 0.9Q?6r   $??DemiBold"?6?   $
??0 -1q?6?   $??14(?6?   ??6?   ?? *
nameSong+6?   ?? 5M   2   $??Center=?6<   $
??Left=?6W   $		 0.9Q?6r   $
??5 -1q?6?   $??SemiBold"?6?   $??12(?6?   ??6?   ?? *	nameArtis+6?   5N   /   ?? 5O   .   $??Center=?68   $??Right=?6S   $??12(?6?   $??Medium"?6?   $		 0.9Q?6?   $
??0 10q?6?   ??6o   ?? *Time+6?   5Q   +   5R   '   5U   #   5W      5X      5Y      5]      5^      ?? 5a   
   $??Center=?6   $??1??62   
?????? $??9.6,35,10,10q?6[   $	??370??6q   .+?5d      9? $??10,55,20,20q?6   $??Playlist??6.     playlistExpander#??[ 6A   
?????? $
??Left=?5e      $??Center=?6(   $
 Hand??6C   .??5f      ?? .+?5g      ?? $ 20??6   
?????? $	??360??6I   $	??320??6V   ._?5j      ?? -   5        $ panelPlaylist??5j   d   $	??300??6"   $??Hidden=?61   $??Stretch=?6|    ?? SelectionMode$ Single=?6?   ??5k      ?? 5l   "   " ??6(   .?5m   &   ??  ? |? . 6B   5o   #   ??5r      ?? 5s   "   .R?5t   &   ?? $
??auto??61   $??Center=?6?   $
 Vertical=?6\   .+?5u   *   ?? $
??auto??62   $
??auto??6?   $	??0,0q?6M   $
 Hand??6Z   $??0??6i   $??1??6v     playlistBorder#??[ 6?   ._?5v   .   ?? $
 abcd??65   $ 20??6D   $??15,15,12,15q?6V   $	??250??6k   $??80??6w   ??5w   2   ?? 5x   6   .??5y   :   ? $ Coral??6G   $ 0Q?6U   ? 5z   :   $ Orange??6G   $ 1Q?6V   5{   7    5}   2     5~   6   $ 20Q?6G   $ 5Q?6W   $	 Red??6h   ._?5?   2   ?? $
 
Horizontal=?6?   $
??Left=?6X   $??0q?6s    J? RenderTransformOrigin$ 0.5,0.5&?6~   .+?5?   6   ?? $
??Left=?6A   $
 Vertical=?6]   .+?5?   :   ?? $??70??6@   $??70??6K   $??15 5 0 5q?6W   $,??&/MusicPlayer;component/Image/Music.png??6i   6?   5?   7   ?? 5?   6   $
??Left=?6A   $??20 20q?6\   $
 Vertical=?6l   .+?5?   :   ? $??Center=?6D   .+?5?   >   ?? $	??150??6J   $y?Visible=?6Y   $
??Wrap=?6n    ?? TextAlignment$ Center=?6?   $??14(?6?   $??Medium"?6?   ??6?   ?? *Title+5?   ;   ?? 5?   :   $ Playyyyy??6D   
???????$??12(?6k   $??Regular"?6y   $??Nhấn để phát??6?   6?   5?   7   5?   3   5?   /   5?   +   5?   '   5?   #   5?      5?      5?      5?      ?? 5?      $ 20??6   $??
10,55,20,0q?6'   $	??280??6;   ??5?      ?? 5?      .??5?      ? $ Coral??6'   $ 0Q?65   ? 5?      $ Orange??6'   $ 1Q?66   5?       5?        5?      $ 20Q?6'   $ 5Q?67   $	 Red??6H   ._?5?      ?? $??5q?6   $
 Vertical=?5?      .+?5?      ?? $
 
Horizontal=?6!   .+?5?      ?? $
??Left=?6$   $??0??6?   $??0??6L   $??Lời bài hát??6\   $		 0.8Q?6p   $??20 10q?6~   #??[  6?   5?      ?? 5?      
?????? $ 10??66   $	??320??6H   $	??215??6T   ._?5?      ? .+?5?      ?? -   5         ??Name$ 	RTBlyrics??5?   ?   ???#22223B ?? SelectionBrush
 ????  ?? 
IsReadOnly . $		 0.9Q?6o   $??Italic$?6}   $??Arial)?6?   $??Center=?6?   
?????? $	??320??6?   $	??220??6?   $??14(?6  . ?5?   "   /?  /? 
LineHeight$ 20??6/    /? TextAlignment$ Center=?6?   5?   #   5?      5?      5?      5?      5?      5?      5?      5?      