   M S B A M L   `   `   `  ????F  BMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MusicPlayerMusicPlayer  5      '    !MusicPlayer.User_Control.ListSong   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      h dMahApps.Metro.IconPacks.Fontaudio, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.RemixIcon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah	 dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag
 cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a^ ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.BootstrapIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Codicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.PixelartIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RadixIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.VaadinIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.FileIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Fontisto, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah  dMahApps.Metro.IconPacks.Coolicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai! eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai" eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am# iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag$ cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj% fMahApps.Metro.IconPacks.ForkAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137axIcon-http://metro.mahapps.com/winfx/xaml/iconpacks!     	 
                        ! " # $ % 5      zd2http://schemas.microsoft.com/expression/blend/2008!     	 
                        ! " # $ % 5      ?mc;http://schemas.openxmlformats.org/markup-compatibility/2006!     	 
                        ! " # $ % 5      elocalclr-namespace:MusicPlayer!     	 
                        ! " # $ % 5      _& [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes & 5	      -   5        $??dsBaiHat??5
      $	??540??5      $	??780??6   .??5      ) & #MaterialDesignThemes.Wpf.DialogHost  -   5           Name$  Dialog??5   	      CloseOnClickAway .  $??Center=?5      $??Center=?5         DialogContent 5   
   ? 5      .+?5      ??  ?? CornerRadius$ 10??6   
???????$	??550??6>   $	??400??6J   ._?5      ??  ?? Orientation$ Vertical=?6!   .+?5      ?? $ 
Horizontal=?6%   .+?5      ?? $??Thêm vào playlist??6(    J? Opacity$	 0.9Q?6A   $??15 10q?6P      	menuTitle#??[  6_   ?? 5         CloseDialogCommand#??Z 6%   $??	300 0 0 0q?5   !     favoriteButton#??[ 65   .??5   "   ?? $ 20??6)   
?????? $??30??6U   $??30??6`   $??0q?6l   ._?5   &   .  (MahApps.Metro.IconPacks.PackIconMaterial  
???   ?   Kind$ Close=?6O   $??Center=?6\   $??9q?6w   $??11??6?   $??11??6?   5   #   5      5      ?? 5!      $??1??6'   $??0??64   $
??Auto=?6D   .??5"      ? -   5         ?Name$ panelPlaylist??5"   L   	 ? 
ItemHeight$
	 auto??6)   
 ? 	ItemWidth$

 auto??6;    ? Orientation$ 
Horizontal=?6c   
?????? $??20 15 40 30q?6?   .+?5#   "   ?? -   5        $??
icPlaylist??5#   /   ??5$   &   ?? 5%   *   .R?5&   .   ? 5'   +   ??5)   &   ?? 5*   *   .R?5+   .   ?? $	??120??69   $??
30,0,10,10q?6E   $??Center=?6Y   $ Vertical=?6v   .+?5,   2   ?? -   5        $
??auto??5-   :   $
??auto??6G   $	??0,0q?6U    ? Cursor$
 Hand??6b   $??0??6q   $??1??6~     playlistButton#??[ 6?   .??5.   6   ?? $ 20??6=   $??0,0,0,0q?6O   $	??100??6`   $	??100??6l   ??5/   :   ?? 50   >   .??51   B   ?  ? Color$ Coral??6O    ? Offset$ 0Q?6]   ? 52   B   $ Orange??6O   $ 1Q?6^   53   ?    J? Effect 55   :   3  -System.Windows.Media.Effects.DropShadowEffect  56   >      
BlurRadius$ 20Q?6O      ShadowDepth$ 5Q?6_      Color$	 Red??6p   ._?58   :   ?? $,??&/MusicPlayer;component/Image/Music.png??6@   $??20q?6p   59   ;   5:   7   5;   3   ?? 5=   2   $ 
Horizontal=?6=   $??Center=?6V   $??	0 10 0 10q?6s    J? RenderTransformOrigin$ 0.5,0.5&?6?   .+?5>   6   ?? $??90??6A   $
??Left=?6O   $??14(?6k   $??Medium"?6y   ??6?   ?? *Title+5@   3   5A   /   5B   +   5D   #   5E      5F      5H      5I      5J      .??5L   
   ? ???#F8F4EA ? ColumnDefinitions 5M   
    ? RowDefinitions 5Q   
   ?? 5R      $
??auto ?6   ?? 5T      $??* ?6   .+?5Z   
   ?? $??0??6   
?????? $??20 20 10 10q?6>   .+?5[      ?? $??	Bài hát??6   $	??5 0q?6'   $??30(?64   #??[  6B   ?? 5\      $ 
Horizontal=?6   $??0??62   
?????? $??	40 30 0 0q?6[   .+?5]      ?? $ Vertical=?6   $??0??64   
?????? .+?5^      ?? $??Tất cả bài hát??6    $	 0.9Q?66   $	??0 0q?6E   #??[  6R   ?? 5_      -   5         ??Name$ 	countSong??5_       $??00 Bài hát??63   $??12(?6E   $??Italic$?6S   $??Regular"?6f   $	 0.9Q?6{   5`      ? 5a      .+?5b      ?? -   5         ??Name$ addnplay??5b   !   $ 
Horizontal=?63   .+?5c      ?? -   5         ??Name$ playAllsongbtn??5c      $
 Hand??65   $??	200 0 0 0q?6D   $??Right=?6W     
menuButton#??[ 6t   .??5d      ?? $ 
Horizontal=?6%   .+?5e        $
 Play=?64   $??Center=?6@   $??0 1 8 0q?6[   $??11??6l   $??11??6w   ?? 5f      $??Phát tất cả??6(   5g      5h      ?? 5i      -	   5        $ 
addsongbtn??5i      $
 Hand??62   $	??0 0q?6@   $??Right=?6M   #??[ 6k   .??5j      ?? $ 
Horizontal=?6%   .+?5k        $
 Plus=?64   $??Center=?6@   $??0 1 8 0q?6[   $??11??6l   $??11??6w   ?? 5l      $??Thêm bài hát??6(   5m      5n      5o      ?? 5q      -
   5        $ 	delnaddpl??5q   1   $y?Hidden=?6   $ 
Horizontal=?6E   .+?5r      ?? -   5        $ deleteSongbtn??5r      $
 Hand??64   $??	200 0 0 0q?6C   $??Right=?6V   #??[ 6s   .??5s      ?? $ 
Horizontal=?6%   .+?5t        $ Delete=?64   $??Center=?6B   $??0 1 8 0q?6]   $??11??6n   $??11??6y   ?? 5u      $??Xóa đã chọn??6(   5v      5w      ?? 5x      -   5        $ addsongtoplbtn??5z         OpenDialogCommand#??Z 5y      $
 Hand??5z   1   $	??0 0q?6?   $??Right=?6L   #??[ 6j   .??5{      ?? $ 
Horizontal=?6%   .+?5|        $ PlaylistPlus=?64   $??Center=?6H   $??0 1 8 0q?6c   $??11??6t   $??11??6   ?? 5}      $??Thêm vào playlist??6(   5~      5      5?      5?      5?      5?      ?? 5?   
   $??1??6   $ Vertical=?6$   .+?5?      &   System.Windows.Controls.DataGrid  -   5          Name$ gridSong??5?      $	??300??5?         MinRowHeight$ 41Q?6$      SelectionMode$ Extended=?67     DataGridRowStyle1   RowStyle# ?  6P     DataGridColumnHeaderStyle1   ColumnHeaderStyle# ?  6     DataGridCellStyle1   	CellStyle# ?  6?     DataGridStyle1#???  6?   $??	20 0 40 0q?5?      ???#22223B    Columns  5?      0  *System.Windows.Controls.DataGridTextColumn  5?      ,  &System.Windows.Controls.DataGridColumn!   Header$!  ??6*   "   
IsReadOnly" . #   CanUserResize# .  $   Width5  /System.Windows.Controls.DataGridLengthConverter$
$ auto 6\   1  +System.Windows.Controls.DataGridBoundColumn%   Binding% 6i   ?? *Number+  5?      &   MinWidth$	& 150Q?6)   $! Tên bài hát??69   " . $$ * 6}   % 6N   ?? *
nameSong+6}     5?      $	& 150Q?6)   $! Tên ca sĩ??69   " . $$ * 6|   % 6L   ?? *	nameArtis+6|     5?      $	$ 100 6)   $! Thời gian??67   " . % 6J   ?? *Time+6c   5?      ?? 5?      $??11(?6   $	 0.7Q?6&   $??Italic$?64   $??Right=?6G   $
??50 0q?6c   $C??=Nhấn giữ CTRL để chọn/bỏ chọn nhiều bài hát ??6q   6?   5?      5?      5?      5?      