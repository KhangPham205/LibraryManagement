   M S B A M L   `   `   `  ����W  SLibraryManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:LibraryManagementApplication.Model.Class(LibraryManagementApplication.Model.Class  5      _4clr-namespace:LibraryManagementApplication.ViewModel&LibraryManagementApplication.ViewModel  5      +    %LibraryManagementApplication.infoxaml   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Hlocal6clr-namespace:LibraryManagementApplication.Model.Class     5      Glogout4clr-namespace:LibraryManagementApplication.ViewModel     5      -   5          N�Name$  
Logoutpage��5       N� Title$ infoxaml��5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���#e6f3ff.+�5      �� $��Thông tin cá nhân ��6   $��50(�5   
   $
��Bold"�5   
   $��roboto)�5   
   ���#07209e$��Center=�5   
   $��Right=�5   
   5      � 5   
   ���#e6f3ff$��1��5   	    5      �� 5       $
��auto �6    �� 5!      $��* �6    .+�5#      �� ���#07209e$��2q�5%       �� CornerRadius$ 20��5&      $��40q�5'      ._�5(      � $��10q�6    5)      �� 5*      $��10 �6(   �� 5+      $
��auto �6(   �� 5,      $
��auto �6(   �� 5-      $
��auto �6(   �� 5.      $
��auto �6(   �� 5/      $
��auto �6(   �� 50      $
��auto �6(   �� 51      $��10 �6(    � ColumnDefinitions 53      �� 54      $	��130 �6+   �� 55      $��* �6+   .+�58      �� $��Tên nhân viên:��6       textblock:style1#��[  59      $��0��5:      $��1��5;      $��5q�5<      $��Right=�5=      �� 5>      -   5         ��Name$ tentb��5>      $��1��5?      $��1��5@      $��5q�5A        textbox:style1#��[ 5B       �� 
IsReadOnly . ��5C      �� *
UserName+5D      �� 5E      $��UserID:��6    #��[  5F      $��0��5G      $��2��5H      $��5q�5I      $��Right=�5J      �� 5K      -   5        $ userid��5K      $��1��5L      $��2��5M      #��[ 5N      $��5q�5P       . ��5O      �� *UserID+5Q      �� 5R      $��Email: ��6    #��[  5S      $��0��5T      $��3��5U      $��5q�5V      $��Right=�5W      �� 5X      -   5        $ emailtb��5X      $��1��5Y      $��3��5Z      #��[ 5[      $��5q�5]       . ��5\      �� *Email+5^      �� 5_      $��CCCD: ��6    #��[  5`      $��0��5a      $��4��5b      $��5q�5c      $��Right=�5d      �� 5e      -   5        $ cccdtb��5e      $��1��5f      $��4��5g      #��[ 5h      $��5q�5i       . ��5k      �� *CCCD+�� 5l      $��SDT: ��6    #��[  5m      $��0��5n      $��5��5o      $��5q�5p      $��Right=�5q      �� 5r      -   5        $ sdttb��5r      $��1��5s      $��5��5t      #��[ 5u      $��5q�5v       . ��5x      �� *SDT+�� 5y      -   5         ��Name$ logout��5y        button:style1#��[ 5z      $��Đăng xuất��5{      $��5q�5|      $��1��5}      $��6��5~      $��Right=�5      ��5�      �� *signoutcommand+��5�      ��  �� ElementName$ 
Logoutpage��	 � DataContext	 5�      :   4LibraryManagementApplication.ViewModel.MainViewModel  5�      5�      5�      5�      5�      5�      5�      