   M S B A M L   `   `   `  ????F  BLatinPisces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:LatinPisces.ViewsLatinPisces.Views  5   	   #    LatinPisces.Views.InfoMessage   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:LatinPisces.Views     5   	     ? Title$  InfoMessage??5   	   $	??600??6   $	??500??6*    ? WindowStartupLocation$ CenterScreen=?5	   	    ? 
ResizeMode$ NoResize=?5
   	   .??5      ?  ? RowDefinitions 5   
   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   .+?5   
   ?? -   5        $??statusLabel??5      $??0??5      $??Center=?5      $??Center=?5      $??Bahnschrift SemiBold)?5      $??50(?5      ?? 5   
   $??1??5      $??Center=?5      $	??Top=?5       $$??Выбранный ответ:??5!      $??0, -10, 0, 0q?5"      $??Bahnschrift SemiBold)?5#      $??30(?5$      ?? 5&   
   -   5        $??
yourAnswer??5(      $??1??5'      $??Center=?5)      $??Bottom=?5*      $??Bahnschrift SemiBold)?5+      $??30(?5,      $
??Wrap=?5-      ?? 5/   
   $??2??50      $??Center=?51      $	??Top=?52      $??0, -10, 0, 0q?53      $&?? Правильный ответ:??54      $??Bahnschrift SemiBold)?55      $??30(?56      ?? 58   
   -   5        $??rightAnswer??5:      $??2??59      $??Center=?5;      $??Bottom=?5<      $??Bahnschrift SemiBold)?5=      $??30(?5>      $
??Wrap=?5?      ?? 5A   
   $??3??5B      $??Center=?5C      $	??Top=?5D      $??Перевод:??5E      $??0, -10, 0, 0q?5F      $??Bahnschrift SemiBold)?5G      $??30(?5H      ?? 5J   
   -   5        $??translationLabel??5L      $??3??5K      $??Center=?5M      $??Bottom=?5N      $??Bahnschrift SemiBold)?5O      $??30(?5P      $
??Wrap=?5Q      ?? 5S   
   $??4??5T      $??Center=?5U      $	??Top=?5V      $??Транскрипция:??5W      $??0, -10, 0, 0q?5X      $??Bahnschrift SemiBold)?5Y      $??30(?5Z      ?? 5\   
   -   5        $??transcriptionLabel??5^      $??4??5]      $??Center=?5_      $??Bottom=?5`      $??Bahnschrift SemiBold)?5a      $??30(?5b      $
??Wrap=?5c      ?? 5e   
   -   5        $??5??5f      $??100, 10, 100, 10q?5g      $
??ОК??5h      $??Bahnschrift SemiBold)?5i      $??30(?5j      5k      5m      5n      