   M S B A M L   `   `   `  ????F  BMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MusicPlayerMusicPlayer  5      '    !MusicPlayer.User_Control.PlayList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      h dMahApps.Metro.IconPacks.Fontaudio, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.RemixIcon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah	 dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag
 cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a^ ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.BootstrapIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Codicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.PixelartIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RadixIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.VaadinIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.FileIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Fontisto, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah  dMahApps.Metro.IconPacks.Coolicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai! eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai" eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am# iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag$ cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj% fMahApps.Metro.IconPacks.ForkAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137axIcon-http://metro.mahapps.com/winfx/xaml/iconpacks!     	 
                        ! " # $ % 5      zd2http://schemas.microsoft.com/expression/blend/2008!     	 
                        ! " # $ % 5      ?mc;http://schemas.openxmlformats.org/markup-compatibility/2006!     	 
                        ! " # $ % 5      elocalclr-namespace:MusicPlayer!     	 
                        ! " # $ % 5      _& [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes & 5	      -   5        $??dsPhat??5
      $	??540??5      $	??780??6   .??5      ) & #MaterialDesignThemes.Wpf.DialogHost  -   5           Name$  Dialog??5   	      CloseOnClickAway .  $??Center=?5      $??Center=?5         DialogContent 5   
   ? 5      .+?5      ? -   5         ?Name$ Popup??5       ? AllowsTransparency .  ? HorizontalOffset$ 0??6C    ? VerticalOffset$ 10??6X   .??5      ?? -   5         ??Name$ HeaderPopup??5       $3??-Tên Playlist Không được để trống .??65   6b   5      ?? 5      
???????$	??550??6,   $	??400??68   ._?5      ?  ? RowDefinitions 5      ?? 5      $
??auto ?6,   ?? 5      $??* ?6,   ?? 5      $
??auto ?6,   .+?5      ?? $??Thêm Playlist??6$   	 J? Opacity$		 0.9Q?69   $??	20 20 0 0q?6H      	menuTitle#??[  6[   ?? 5       -   5        
 ??Name$
 fieldNamePl??5    3   $??1??6&   $y?Visible=?6H   .+?5!      ?? -   5         ??Name$ namePlaylist??5!   &   $??Center=?6<   $??Center=?6W   $
??0 40q?6t   $	??300??6?   $??16(?6?   ) & #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nhập tên Playlist (*)??5"       % !MaterialDesignFloatingHintTextBox#??[ 5#      5$      ?? 5%      -   5        $
 
selectSong??5%   J    ?? Orientation$ Vertical=?6%   $??1??6=   $y?Visible=?6^   .+?5&      ?? $??Chọn bài hát??6(   $		 0.9Q?6<   $??DemiBold"?6J   $??18(?6`   $??
50 10 0 10q?6n   #??[  6?   ?? 5'      
??????? ?? CornerRadius$ 10??69   $	??400??6K   $	??220??6W   ._?5(   "   ?? -   5         ??Name$ lbSelectSong??5(   k   $	??300??6*   $??Hidden=?69   $??Stretch=?6?    ?? SelectionMode$ Multiple=?6?   ??5)   &   ?? 5*   *    ?? 
TargetType" ??60   .?5+   .   ??  ?? Property ? |? ?? Value . 6J   5-   +   ??50   &   ?? 51   *   .R?52   .   ??  ??Name$ btnSong??6D    ? Cursor$
 Hand??66   $	??0 2q?6U   $??0??6b   $??1??6o   ._?53   2   ?? $??Center=?6>   $??Stretch=?6Y   $ 
Horizontal=?6x   .+?54   6   ?? $ number??6?   $??Center=?6@   $??Center=?6[   $??12(?6?   $??Medium"?6?   $		 0.9Q?6?   $
??0 10q?6?   ??6x   ?? *Number+6?   ?? 55   6   $	??200??6A   $
??20 0q?6M   $??Center=?6\   $
??Left=?6w   $ Vertical=?6?   .+?56   :   ?? $??Center=?6D   $
??Left=?6_   $		 0.9Q?6z   $??DemiBold"?6?   $
??0 -1q?6?   $??14(?6?   ??6?   ?? *
nameSong+6?   ?? 57   :   $??Center=?6D   $
??Left=?6_   $		 0.9Q?6z   $
??5 -1q?6?   $??SemiBold"?6?   $??12(?6?   ??6?   ?? *	nameArtis+6?   58   7   ?? 59   6   $??Center=?6@   $??Right=?6[   $??12(?6?   $??Medium"?6?   $		 0.9Q?6?   $
??0 10q?6?   ??6w   ?? *Time+6?   5;   3   5=   /   5@   +   5B   #   5D      5E      ?? 5F      $??2??6%   $??Right=?62   $??0 0 0 20q?6N   $ 
Horizontal=?6`   .+?5G      ?? -	   5         ??Name$ cancelDialog??5H          CloseDialogCommand#??Z 5I        favoriteButton#???  5J      $??0q?5K      
?????? + & %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth2=?5M      .??5O   "   ?? $??16(?6,   $??Hủy??6:   5Q   #   5R      ?? 5S      -
   5        $ contbtn??5S   %   $
??40 0q?67     MaterialDesignRaisedButton#???  5T      $??0q?5U      
???P??$ Depth2=?5W      .??5Y   "   ?? -   5        $ tb_btn_createPlaylis??5Y   ,   $??16(?6J   $??Tiếp tục??6X   5[   #   5\      5]      5^      5`      5a      .??5c   
   ? .+?5e      ? -   5         ?Name$ gridSongPlaylist??5e       $??0??6   $y?Visible=?6:    5f      ?? 5g      $
??auto ?6    60   ?? 5h      $??* ?6    6-   .+?5k      ?? $??0??6   
?????? $??20 20 20 10q?6F   .+?5l      ?? $??Playlist??6    $	??5 0q?60   $??30(?6=   #??[  6K   ?? 5m      $ 
Horizontal=?6!   $??0??6:   
?????? $??	40 30 0 0q?6c   .+?5n      ?? $	??350??6%   $ Vertical=?62   $??0??6I   .+?5o      ?? -   5        $ namePlaylistSong??5o   (   $??Playlist??6B   $		 0.9Q?6R   $	??0 0q?6a   #??[  6n   ?? 5p      -   5        $ 	countSong??5p   (   $??00 Playlist??6;   $??12(?6N   $??Italic$?6\   $??Regular"?6o   $		 0.9Q?6?   5q      ? 5r      .+?5s      ?? -   5        $
 deletePlnplayPlbtn??5s   )   $ 
Horizontal=?6E   .+?5t      ?? -   5        $ deletePlbtn??5t   %   $
 Hand??5u      $	??0 0q?6+   $??Right=?68     
menuButton#??[ 6U   .??5v      ?? $ 
Horizontal=?6)   .+?5w   "   .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ Delete=?68   $??Center=?6F   $??0 1 8 0q?6a   $??11??6r   $??11??6}   ?? 5x   "   $??Xóa Playlist??6,   5y      5z      ?? 5|      -   5        $ playPlaylistbtn??5|   !   $
 Hand??5}      $	??0 0q?6+   $??Right=?68   #??[ 6U   .??5~      ?? $ 
Horizontal=?6)   .+?5   "     $
 Play=?68   $??Center=?6D   $??0 1 8 0q?6_   $??11??6p   $??11??6{   ?? 5?   "   $??Phát toàn bộ??6,   5?      5?      5?      ?? 5?      -   5        $
 
deleteSong??5?   %   $y?Hidden=?69   $ 
Horizontal=?6M   .+?5?      ?? -   5        $ deleteSongbtn??5?   %   $
 Hand??5?      $??100 0q?6+   $??Right=?6:   #??[ 6W   .??5?   "   ?? $ 
Horizontal=?6-   .+?5?   &     $ Delete=?6<   $??Center=?6J   $??0 1 8 0q?6e   $??11??6v   $??11??6?   ?? 5?   &   $??Xóa bài hát??60   5?   #   5?      5?      5?      5?      5?      ?? 5?      $??1??6   $ Vertical=?6,   .+?5?      &   System.Windows.Controls.DataGrid  -   5          Name$ datagridSongPlaylist??5?      $	??300??5?         MinRowHeight$ 41Q?6/   $??1??6A     DataGridRowStyle1   RowStyle# ?  6S     DataGridColumnHeaderStyle1   ColumnHeaderStyle# ?  6?     DataGridCellStyle1   	CellStyle# ?  6?     DataGridStyle1#???  6?   $??
20 0 40 00q?5?          SelectionMode$  Extended=?5?      ???#22223B!   Columns! 5?      0  *System.Windows.Controls.DataGridTextColumn  5?      ,  &System.Windows.Controls.DataGridColumn"   Header$"  ??62   #   
IsReadOnly# . $   CanUserResize$ .  %   Width5  /System.Windows.Controls.DataGridLengthConverter$
% auto 6d   1	  +System.Windows.Controls.DataGridBoundColumn& 	  Binding& 6q   ?? *Number+  5?      '   MinWidth$	' 150Q?61   $" Tên bài hát??6A   # . $% * 6?   & 6V   ?? *
nameSong+6?     5?      $	' 150Q?61   $" Tên ca sĩ??6A   # . $% * 6?   & 6T   ?? *	nameArtis+6?     5?      $	% 100 61   $" Thời gian??6>   # . & 6Q   ?? *Time+6j   5?      ?? 5?      $??11(?6    $		 0.7Q?6.   $??Italic$?6<   $??Right=?6O   $
??50 0q?6k   $C??=Nhấn giữ CTRL để chọn/bỏ chọn nhiều bài hát ??6y   6?   5?      5?      ? 5?      -   5        $ gridPlaylist??5?      $y?Hidden=?6)   ???#F8F4EA( ? ColumnDefinitions( 5?       5?      ?? 5?      $
??auto ?6$   ?? 5?      $??* ?6$   .+?5?      ?? $??0??6   
?????? $??20 20 10 10q?6F   .+?5?      ?? $??Playlist??6    $	??5 0q?60   $??30(?6=   #??[  6K   ?? 5?      $ 
Horizontal=?6!   $??0??6:   
?????? $??	40 30 0 0q?6c   .+?5?      ?? $ Vertical=?6%   $??0??6<   
?????? .+?5?      ?? $??Tất cả Playlist??6(   $		 0.9Q?6?   $	??0 0q?6N   #??[  6[   ?? 5?      -   5        $ countPlaylist??5?   (   $??00 Playlist??6?   $??12(?6R   $??Italic$?6`   $??Regular"?6s   $		 0.9Q?6?   5?      ?? 5?      -   5        $ createplbtn??5?   !   )   OpenDialogCommand#??Z) 5?      $
 Hand??5?      $??350 0q?6+   $??Right=?6:   #??[ 6W   .??5?      ?? $ 
Horizontal=?6)   .+?5?   "     $
 Plus=?68   $??Center=?6D   $??0 1 8 0q?6_   $??11??6p   $??11??6{   ?? 5?   "   $??Thêm Playlist??6,   5?      5?      5?      5?      ?? 5?      $??1??6   $??0??6,   $
??Auto=?6<   .??5?      ? -   5        * ?Name$* panelPlaylist??5?   D   + ? 
ItemHeight$
+ auto??6!   , ? 	ItemWidth$
, auto??63   - ? Orientation$- 
Horizontal=?6[   
?????? $??20 15 40 30q?6?   .+?5?      ?? -   5        $??
icPlaylist??5?   '   ??5?      ?? 5?   "   .R?5?   &   ? 5?   #   ??5?      ?? 5?   "   .R?5?   &   ?? $	??120??61   $??
40,0,10,10q?6=   $??Center=?6Q   $ Vertical=?6n   .+?5?   *   ?? -   5        $
??auto??5?   1   $
??auto??6>   $	??0,0q?6L   $
 Hand??6Y   $??0??6h   $??1??6u    	 playlistButton#??[	 6?   .??5?   .   ?? $ 20??65   $??0,0,0,0q?6G   $	??120??6X   $	??120??6d   ??5?   2   ?? 5?   6   .??5?   :   ? . ? Color$. Coral??6G   / ? Offset$/ 0Q?6U   ? 5?   :   $. Orange??6G   $/ 1Q?6V   5?   7   0 J? Effect0 5?   2   3
  -System.Windows.Media.Effects.DropShadowEffect
  5?   6   1 
  
BlurRadius$1 20Q?6G   2 
  ShadowDepth$2 5Q?6W   3 
  Color$	3 Red??6h   ._?5?   2   ?? $,??&/MusicPlayer;component/Image/Music.png??68   $??20q?6h   5?   3   5?   /   5?   +   ?? 5?   *   $ 
Horizontal=?65   $??Center=?6N   $??	0 10 0 10q?6k   4 J? RenderTransformOrigin$4 0.5,0.5&?6~   .+?5?   .   ? $??Center=?68   .+?5?   2   ?? $	??100??6<   $
??Wrap=?6L   5 ?? TextAlignment$5 Center=?6a   $??14(?6y   $??Medium"?6?   ??6?   ?? *Title+5?   /   5?   +   5?   '   5?   #   5?      5?      5?      5?      5?      5?      5?      