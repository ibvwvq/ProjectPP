   M S B A M L   `   `   `  ?????  ;test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:testtest  5   	   9!clr-namespace:test.MVVM.ViewModeltest.MVVM.ViewModel  6*       test.EditWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:test     5   	   7	viewmodel!clr-namespace:test.MVVM.ViewModel     6*     ? Title$  
EditWindow??5   	   $	??450??6   $	??800??6)    ? DataContext 5	      '  !test.MVVM.ViewModel.MainViewModel  5
   
   .??5      ?  ? RowDefinitions 5   
   ?? 5      $
??131* ?6   ?? 5      $	??86* ?6   .+?5   
   ?? $??0??68    6   ?? *
SelectNote+.+?5      ?? $??Name:??6   ?? 5      $??0??6   $??Stretch=?69   $??60??6U    ?? TextWrapping$
 Wrap=?6a   ??6#   ?? *Name+6a   ?? 5      $??Surname:??6   ?? 5      $??1??6   $??Stretch=?6<   $	??140??6X   $
 Wrap=?6e   ??6#   ?? *	Surname+6e   5      ?? 5   
   $??1??6   $??0,61,0,0q?6"   .+?5      ?? $	??Add??6   ??6#   ?? *
AddCommand+?? 5      -   5        $
??Back??5      6$   5      5      5      