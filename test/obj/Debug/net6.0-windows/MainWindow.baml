   M S B A M L   `   `   `  ?????  ;test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:testtest  5   	   9!clr-namespace:test.MVVM.ViewModeltest.MVVM.ViewModel  6*       test.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   localclr-namespace:test  5   	   1	viewmodel!clr-namespace:test.MVVM.ViewModel  6*     ? Title$  
MainWindow??5	   	   $	??450??6   $	??800??6)    ? DataContext 5      '  !test.MVVM.ViewModel.MainViewModel  5   
   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $	??250 ?6   ?? 5      .+?5   
   ?? ??6   ?? *	Clients+ ?? SelectedItem 5      ?? *
SelectNote+??5      ?? 5      .R?5      ?? .+?5      ?? $
??Wrap=?6:   ??6$   ?? *Name+6:   ?? 5      $
??Wrap=?6=   ??6$   ?? *	Surname+6=   5      5      5      ? 5   
   $??1??6    ? RowDefinitions 5      ?? 5       ?? 5!      $	??100 ?6    .+?5#      ??  6   ?? *
SelectNote+.+?5$      ?? $??Title:??6   ?? 5%      $??0??6   $??Stretch=?6=   $??60??6Y    ?? TextWrapping$
 Wrap=?6e   ??6'   ?? *Name+6e   ?? 5&      $??Text:??6   ?? 5'      $??1??6   $??Stretch=?6@   $	??140??6\   $
 Wrap=?6i   ??6'   ?? *	Surname+6i   5(      A? 5)      $??1??6   $??2q?6'   .+?5*      ?? $	??2 5q?6   $	??Add??6&   ??64   ?? *
AddCommand+?? 5+      $	??2 5q?6   $??Remove??6&   ??67   ?? *RemoveCommand+?? 5,      $	??2 5q?6   $
??Save??6&   ??65   ?? *SaveCommand+?? 5-      $	??2 5q?6   $
??Edit??6&   $?? ??65   5.      5/      50      51      