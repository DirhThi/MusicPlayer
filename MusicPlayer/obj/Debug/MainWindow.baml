   M S B A M L   `   `   `  ????F  BMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MusicPlayerMusicPlayer  5   	   C&clr-namespace:MusicPlayer.User_ControlMusicPlayer.User_Control  5   	       MusicPlayer.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   h dMahApps.Metro.IconPacks.Fontaudio, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.RemixIcon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah	 dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag
 cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a^ ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.BootstrapIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Codicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.PixelartIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RadixIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.VaadinIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.FileIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Fontisto, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah  dMahApps.Metro.IconPacks.Coolicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai! eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai" eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am# iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag$ cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj% fMahApps.Metro.IconPacks.ForkAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137axIcon-http://metro.mahapps.com/winfx/xaml/iconpacks!     	 
                        ! " # $ % 5   	   zd2http://schemas.microsoft.com/expression/blend/2008!     	 
                        ! " # $ % 5   	   ?mc;http://schemas.openxmlformats.org/markup-compatibility/2006!     	 
                        ! " # $ % 5   	   elocalclr-namespace:MusicPlayer!     	 
                        ! " # $ % 5   	   ouc&clr-namespace:MusicPlayer.User_Control!     	 
                        ! " # $ % 5   	   _& [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes & 5
   	   -   5        $
??Main??5   6     ? Title$  Music Player??5   	   $	??700??6   $
??1000??6+    ? 
ResizeMode$ CanMinimize=?5   	    ? WindowStartupLocation$ CenterScreen=?6B    ? Icon$ Image/Music.png??6g    ? 	Resources 5      .  (MahApps.Metro.IconPacks.PackIconMaterial   Play   Kind 	 Pause  Mute  HVolume  MVolume  LVolume??%?  &	        &	 ?     &	      &	 ?     &	 	    &	 P      5   
   $??12??6-   $
 Play=?69   $y?Visible=?6E     5   
   $??12??6.   $ Pause=?6:   $y?Visible=?6G     5   
   $??12??6-   $ 
VolumeMute=?69   $y?Visible=?6K     5   
   $??12??60   $ 
VolumeHigh=?6<   $y?Visible=?6N     5   
   $??12??60   $ VolumeMedium=?6<   $y?Visible=?6P     5   
   $??12??60   $ 	VolumeLow=?6<   $y?Visible=?6M   5      .??5      ? ???#F8F4EA ? ColumnDefinitions 5   
   ?? 5      $	??220 ?6   ?? 5      $??* ?6   ?? 5      $??* ?6    ? RowDefinitions 5!   
   ?? 5"      $??* ?6   ?? 5#      $??40 ?6   ?? 5$      $	??120 ?6   .+?5'   
   r? -   5         r?Name$ 	mp3Player??5'   /   	 r? LoadedBehavior$	 Manual=?6   $y?Hidden=?6B   6X   ?? 5*   
   $??20 60 20 60q?6   ???#FFD495
 ?? CornerRadius$
 30??6;   $??0??6M   $??0??6Z   $??3??6j   ._?5+      ?? -   5         ??Name$ 	panelMenu??5+      $??	0 10 0 0 q?6,   .+?5,      ?? $??Thư viện??6     	menuTitle#??[ 6,   ?? 5-      -   5         ??Name$ btnHome??5-      
???P??  
menuButton#??[ 6?    ? Cursor$
 Hand??6v   .??5.      ? .+?5/      ?? $??Trang chủ??6$   $??0 0 0 2q?65     50        menuButtonIcon#??[ 61   51      52      ?? 53      -   5        $ btnSong??53   (   $
 Hand??6   #??[ 69   .??54      ? .+?55      ?? $??	Bài hát??6$   $??0 0 0 2q?63     56      #??[ 61   57      58      ?? 59      -   5        $ btnPlaylist??59   (   $
 Hand??6   #??[ 6=   .??5:      ? .+?5;      ?? $??Playlist??6$   $??0 0 0 2q?64     5<      #??[ 61   5=      5>      ?? 5M      $??	20 20 0 0q?6   ???#22223B60   ? 5N      .+?5O      ?? $??	0 10 25 0q?6   $	??Top=?60   $??Right=?6I   $??25??6e   $??25??6p   ._?5P      ' & !MaterialDesignThemes.Wpf.PackIcon     Kind$ Alarm=?62   ???#243763$??25??6T   $??25??6_   5Q      ?? 5R       ?? Orientation$ Vertical=?6!   .+?5S      9? -   5         9?Name$ expenderAlarm??5S   H    ? ToolTip$+ %Click 2 lần để tắt hẹn giờ??6#   $
??20 0q?6`   
?????? 
?????? ??5U      ?? 5V      -   5         ??Name$ alarmtb??5V   (   $??65??69   ???#243763$??16(?6Z    ?? TextAlignment$ Right=?6h   $??Hẹn giờ??6~   #??[ 6?   $??
00,0,-15,0q?6?   6?   .??5X      ?? $
 10??6%   $	??140??67   $	??230??6C   
???????._?5Y   "   ?? $ Vertical=?6-   .+?5Z   &   ?? -	   5        $??Center=?5Z   .    	 alarmbtn#??[	 6K   .??5[   *   ?? 	5 Phút6=   5\   '   ?? 5]   &   -
   5        $??Center=?5]   -   #??[	 6J   .??5^   *   ?? 
10 Phút6>   5_   '   ?? 5`   &   -   5        $??Center=?5`   -   #??[	 6J   .??5a   *   ?? 
15 Phút6?   5b   '   ?? 5c   &   -   5        $??Center=?5c   -   #??[	 6J   .??5d   *   ?? 
20 Phút6=   5e   '   ?? 5f   &   -   5        $??Center=?5f   -   #??[	 6J   .??5g   *   ?? 
30 Phút6>   5h   '   ?? 5i   &   -   5        $??Center=?5i   -   #??[	 6J   .??5j   *   ?? 
45 Phút6>   5k   '   ?? 5l   &   -   5        $??Center=?5l   -   #??[	 6J   .??5m   *   ?? 
60 Phút6>   5n   '   5p   #   5r      5s      5u      5x      ?? 5z       J? Opacity$	 0.9Q?6   ???#243763$??0 20 0 0q?6@   $
??Bold"?6R   $??Music??6d   $??70(?6q   $??Vladimir Script)?6    J? RenderTransformOrigin$ 0.5,0.5&?6?   z?5{      V? 5|      .~?5}      ?? ?? 5~      ?? 5       ?? Angle$	 -45Q?6.   T? 5?      5?      5?      ?? 5?      $	 0.9Q?6   ???#243763$??	-5 10 0 0q?6?   $
??Bold"?6R   $??Player??6d   $??70(?6r   $??Vladimir Script)?6?   $ 0.5,0.5&?6?   z?5?      V? 5?      .~?5?      ?? ?? 5?      ?? 5?      $	 -45Q?6.   T? 5?      5?      5?      5?      5?      ]? 5?   
   -   5         ]?Name$ border??5?      $??0??6%   $??1??62   $??2??6B   .+?5?      ? .+?5?      #   MusicPlayer.User_Control.Home  -   5          Name$ homeUC??5?   /   $y?Visible=?6   6A   '   !MusicPlayer.User_Control.PlayList  5?      -   5          Name$ 
playlistUC??5?   4   $y?Hidden=?6    6J   '   !MusicPlayer.User_Control.ListSong  5?      -   5          Name$ 
listsongUC??5?   3   $y?Hidden=?6   6I   &    MusicPlayer.User_Control.Explore  5?      -   5          Name$
 epUC??5?   1   $y?Hidden=?6   6A   5?      5?      ?? 5?   
   -   5         ??Name$ MainTab??5?      
???????$??0??6;   $??1??6H   $??2??6X   ?? 5?   
   $??50 0 0 0q?6   $??1??6'   $??1??64   $??2??6D   .+?5?      ?? $??Đang phát??6   $	??0 0q?6)   #??[ 67   5?      ?? 5?   
   $??2??6   $??1??6   $??2??6.   $
 50 0 0 0??6B   $??10 0 0 0q?6Z   ??5?      ?? 5?      .??5?      ?  ? Color$ Orange??6#    ? Offset$ 0Q?62   ? 5?      $ Coral??6#   $ 1Q?61   5?       J? Effect 5?      3  -System.Windows.Media.Effects.DropShadowEffect  5?          
BlurRadius$  20Q?6#   !   ShadowDepth$! 5Q?63   "   Color$	" Red??6D   ._?5?      ?? $??20 0 0 0q?6   $??Center=?6,   $ Vertical=?6H   .+?5?      ?? -   5        $ playingPanel??5?      $??Center=?64   $ 
Horizontal=?6P   .+?5?      A? -   5        # A?Name$# songPictureDisplay??5?      $??80??6:   $??80??6E   $??5 0 0 0q?6Q   $ 0.0,0.0&?6b   ??5?      ?? 5?      .??5?   "   ? $ DarkBlue??6/   $ 0Q?6@   ? 5?   "   $ Wheat??6/   $ 1Q?6=   5?      z?5?      ?? 5?      $ ?? CenterX$$ 40Q?6/   % ?? CenterY$% 40Q?6<   -   5        pictureRotate??5?   I   & ? Triggers& 5?      :? 5?      ' :? RoutedEvent$' Loaded??6+   .[?5?   "   ?? -   5        ( ??Name$( rotate??5?   3   .??5?   &   ?? .??5?   *   W? ) g? RepeatBehavior$) Forever??6:   * ?? TargetProperty$7* 1(Ellipse.RenderTransform).(RotateTransform.Angle)?5?      	+ W? To$	+ 360X?5?      , g? Duration$, 0:0:10D?6   5?   '   5?   #   5?      5?      ?? 5?      $	??220??6!   $??20 0 0 0q?6.   $??Center=?6@   $ Vertical=?6\   .+?5?      ?? -   5        $ tbBaiHat??5?   $   $??16(?68   $	??0 0q?6F   #??[ 6T   ?? 5?      -   5        $ tbCaSi??5?   $   $??14(?66   $	??0 0q?6D   5?      ?? 5?      $??5 40 0 0q?6"   $??Center=?64   $ Vertical=?6P   .+?5?      ?? -   5        - ??Name$- slider??5?      $??	10 0 10 0q?5?      . ?? IsSelectionRangeEnabled. . $??Center=?5?      / ? Value$/ 5Q?5?      $	??320??6#   $
 Hand??5?   P   0 ?? SelectionEnd0 6   ?? 1 ?? ElementName$1 slider??2 ?? Path$2 Value?6P   ?? 5?      $??Center=?6%   $??0 0 0 0q?6C   $??Center=?6T   $ 
Horizontal=?6p   .+?5?      ?? -   5        $ 
tbPosition??5?   (   $??00:00??6<   $??14(?6I   $??	0 0 140 0q?6W   ?? 5?      -   5        $ tbTime??5?   (   $??14(?69   $??	140 0 0 0q?6G   5?      ?? 5?      $??Center=?6%   $??
40 -20 0 0q?6C   $??Center=?6W   $ 
Horizontal=?6s   .+?5?      ?? -   5        $??	20,0,15,0q?5?   %   $??0??69   $??1??6F    
 favoriteButton#??[
 6V   $
 Hand??6~   .??5?   "     $??12??68   $ SkipPrevious=?6D   $y?Visible=?6X   $
 Hand??6m   5?      d? 5?      -    5        3 d?Name$3 btnPlay??5?   ,   ???#22223B
??????  $  MaterialDesignActionToggleButton#??[ 5?   #   ??5?   "     5?   &   $??12??6<   $
 Play=?6H   1 & +MaterialDesignThemes.Wpf.ToggleButtonAssist4   	OnContent4 5?   "     5?   &   $??12??6<   $ Pause=?6H   5?      ?? 5?      -!   5        $??	15,0,15,0q?5?   &   $??0??69   $??1??6F   #??[
 6V   $
 Hand??6~   .??5?   "     $??12??68   $ SkipNext=?6D   $y?Visible=?6T   5?      d? 5?      -"   5        $3 speedbtn??5?   +   ???#22223B
?????? #??[ 5?   #   ??5  "   ?? 5  &   $??Regular"?61   $??1X??6F   $??14(?6P   6`   4 5  "   ?? 5  &   $??Regular"?60   $??2X??6E   $??14(?6O   6_   5     5     5	     ?? 5     $ Horizontal =?6!   $??	15,0,15,0q?6;   .+?5     ?? -#   5        $ 	btnVolume??5  !   $??0??65   $??1??6B   #??[
 6R   $
 Hand??6z   .??5       $??12??64   $ 
VolumeHigh=?6@   $y?Visible=?6R   5     ?? 5     -$   5        $- sdvolume??5     $
 Hand??6/   $??5 0 0 45q?5     5 ? Minimum$5 0Q?5     6 ? Maximum$	6 100Q?5     7 ?? Orientation$7 Vertical=?5        MaterialDesignDiscreteSlider#??[ 5     $y?Hidden=?5     $/ 50Q?5     $??65??5     6+   5     5     5     5      5#     5$     