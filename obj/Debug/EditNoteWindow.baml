   M S B A M L   `   `   `  ????@  <WPFII, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFIIWPFII  5   	       WPFII.EditNoteWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:WPFII     5   	     ? Title$  EditNoteWindow??5   	   $	??450??6    $	??800??6-   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $??* ?6   ?? 5      $
??Auto ?6    ? ColumnDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $??* ?6   .+?5   
   ?? $??0??6   $??0??6   $??Title: ??6-   $??Right=?6?   $??Center=?6[   $??10q?6v   ?? 5   
   -   5         ??Name$ TitleTextBox??5   /   $??0??6   $??1??6   $??10q?6E   ??6Q   ?? *Title+?? 5   
   $??1??6   $??0??6   $??	Content: ??6-   $??Right=?6A   $??Center=?6]   $??10q?6x   ?? 5   
   -   5        $ ContentTextBox??5   /   $??1??6   $??1??6   $??10q?6G    ?? AcceptsReturn .  ?? TextWrapping$
 Wrap=?6?   " ?? VerticalScrollBarVisibility$
 Auto=?6?   ??6S   ?? *	Content+6?   ?? 5   
   -   5         ??Name$ 
SaveButton??5   .   $??3??6   $??1??6   $
??Save??6B   $
??Left=?6Q   $??612,10,0,10q?6l   $	??100??6?   6?   ?? 5   
   -   5        $ CancelButton??5   .   $??3??6   $??1??6   $??Cancel??6D   $
??Left=?6U   $??502,10,0,10q?6p   $	??105??6?   6?   5      5      