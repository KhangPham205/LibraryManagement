   M S B A M L   `   `   `  ����W  SLibraryManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:LibraryManagementApplicationLibraryManagementApplication  5   	   /    )LibraryManagementApplication.EXMessagebox   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:LibraryManagementApplication     5   	   X TFontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   $	��200��5	   	   $	��400��6     � 
ResizeMode$  NoResize=�5
   	    � SizeToContent$ WidthAndHeight=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�6.    � AllowsTransparency .  � ShowInTaskbar .  
������ .��5      ��  �� CornerRadius$ 20��6   ���#e6f3ff._�5   
   �  � RowDefinitions 5      �� 5      $��* �6    �� 5      $��50 �6    .+�5      � .+�5      �� $
��auto��6   $
��auto��6+   $��Center=�68   $��Center=�6S    �� Orientation$ 
Horizontal=�6p   .+�5      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]	   Icon$	 Warning=�6#   $��50��62   $��50��6>   $��5q�6I   
   
Foreground
 �#07209e6T   �� 5      -   5         ��Name$ MessageText��5       $��Your message here��65   $
��Wrap=�5       $	��300��5          textblock:style1#��[  5       5      5      �� 5      $��1��6   
�������$ 	0,0,20,20��65   ._�5      � .+�5       �� $ 
Horizontal=�6!   $��Center=�6:   $	��Top=�6W   .+�5!      �� -   5         ��Name$ OkButton��5!   !   $��OK��63     button:message#��[ 5"      $��10q�5$      �� 5%      -   5        $ CancelButton��5%   !   $��Cancel��67   #��[ 5&      $��10q�5(      5)      5*      5+      5,      5-      5.      