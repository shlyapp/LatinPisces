   M S B A M L   `   `   `  ????F  BLatinPisces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:LatinPisces.ViewsLatinPisces.Views  5   	   $    LatinPisces.Views.ResultWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:LatinPisces.Views     5   	     ? WindowStartupLocation$  CenterScreen=?5   	    ? Title$ ResultWindow??5	   	   $	??400??6   $	??500??6+    ? 
ResizeMode$ NoResize=?67   .??5
      ?  ? RowDefinitions 5   
   ?? 5      6   ?? 5      6   ?? 5      6   .+?5   
   ?? $??0??5      $??Ваш результат??5      $??Center=?5      $??Center=?5      $??Bahnschrift SemiBold)?5      $??50(?5      ?? 5   
   $??1??5      $0??*Количество правильных:??5      $
??Left=?5      $	??Top=?5      $??Bahnschrift SemiBold)?5      $??30(?5      
??? ? ?5      ?? 5!   
   $??1??5"      $4??.Количество неправильных:??5#      $
??Left=?5$      $??Center=?5%      $??Bahnschrift SemiBold)?5&      $??30(?5'      
???  ??5(      ?? 5*   
   -   5        $??rightAnswers??5,      $??1??5+      $??Right=?5-      $	??Top=?5.      $??0, 0, 50, 0q?5/      $??Bahnschrift SemiBold)?50      $??30(?51      
??? ? ?52      ?? 54   
   -   5        $??notRightAnswers??56      $??1??55      $??Right=?57      $??Center=?58      $??0, 0, 50, 0q?59      $??Bahnschrift SemiBold)?5:      $??30(?5;      
???  ??5<      ?? 5>   
   -   5        $??2??5?      $??70, 30, 70, 30q?5@      $
??ОК??5A      $??Bahnschrift SemiBold)?5B      $??30(?5C      6   5F      5G      