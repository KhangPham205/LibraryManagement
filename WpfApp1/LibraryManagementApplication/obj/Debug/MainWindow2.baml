   M S B A M L   `   `   `  ����W  SLibraryManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:LibraryManagementApplication.ViewModel&LibraryManagementApplication.ViewModel  5   	   .    (LibraryManagementApplication.MainWindow2   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:LibraryManagementApplication.ViewModel     5   	   X TFontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   -   5          �Name$  
mainwindow��5   	    � Title$ Quản Lý Thư Viện��5
   	   $	��700��6"   $
��1300��6/   $	��700��5   	   $
��1300��6    � Icon$ /Icon/book (1).png��6)    � DataContext 5      :   4LibraryManagementApplication.ViewModel.MainViewModel  5   
   .��5      � ���#e6f3ff � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$
 Menu��5      $��0��5      $��2��6!   ���	#FF36A4ED �� CornerRadius$ 	0,20,20,0��5      
������ $��0q�5      $��
-190,0,0,0q�5       K� ZIndex$ 1��5       � Triggers 5      :� 5       	 :� RoutedEvent$	 
MouseEnter��6   .[�5!      �� .��5"      �� .��5#      t� 
 �� TargetProperty$
 Margin�61   	 t� To$ 
0,0,-190,0X�5$   *    g� Duration$ 0:0:0.2D�5%   *   5&      5'      5(      :� 5+      $	 
MouseLeave��6   .[�5,      �� .��5-      �� .��5.      t� $
 Margin�61   $ 
-190,0,0,0X�5/      $ 0:0:0.5D�50      51      52      53      ._�55      � .+�56      �� -   5         ��Name$ listMainButton��56      .+�57      	�    rbutton:profile#��[  6"   ��58      �� *infopagecommand+��59      ��  �� ElementName$ Mainpage��.��5:      �� .+�5;      �� $��Center=�6%   $��10q�6B   $	��150��6N   $	��150��6[   $ 75��6g   ���#07209e$��2q�5<   ,   ��5=   "   �� 5>   &   -   5        pictureprofile�� j� Stretch$ UniformToFill=�5>   �    �� ImageSource 6I   �� *ProfileImage+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   5@      �� 5A      -   5         ��Name$ profile��5A   (   $��	10,5,10,0q�69    �� TextAlignment$ Center=�6L   $
��Wrap=�6c     textblock:menu#��[ 6w   $��16(�6�   $��Center=�6�   �� 5B      -   5        $ profileemail��5B   (   $��	10,0,10,5q�6>   $ Center=�6Q   $
��Wrap=�6h   #��[ 6|   $��14(�6�   $��Center=�6�   5C      5D      	� 5E      -   5         	�Name$ 
mainbutton��5E   "     rbutton:menu#��[ 5F      ��5G      �� *mainpagecommand+��5H      �� $ Mainpage��.��5I      ��  �� Orientation$ 
Horizontal=�6%   .+�5J      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Home=�6+     	icon:menu#��[ 5K   $   �� 5L      $��Trang chủ��6(   #��[ 5M   !   5N      5P      	� 5Q      -   5        $ 
sachbutton��5Q   "   #��[ 5R      .��5S      �� $ 
Horizontal=�6%   .+�5T        $ BookOpen=�6+   #��[ 5U   $   �� 5V      $��Thông tin sách��6(   #��[ 5W   !   5X      5Y      �� 5Z      ��5[      �� 5\       �� 
TargetType" ��6$    �� Triggers 5]   "   �� 5^   &    �� Binding 62   �� *	IsChecked+$ 
sachbutton�� �� Value True6i   .a�5_   *   ��  �� Property � y� �� Value$ Visible=�6G   5`   '   �� 5a   &    62   �� *	IsChecked+$ 
sachbutton��	 False6i   .a�5b   *   ��  � y�$ 	Collapsed=�6G   5c   '   5e      .+�5g      	�   rbutton:submenu#��[ 6&   ��5h   "   �� *headerbookpagecommand+��5i   "   �� $ Mainpage��.��5j      �� $ 
Horizontal=�6)   .+�5k   "     $ BookOpen=�6/     icon:submenu#��[ 5l   (   �� 5m   "   $��Đầu Sách��6,     textblock:submenu#��[ 5n   %   5o      5p      	� 5q      #��[ 6&   ��5r      �� *bookpagecommand+��5s      �� $ Mainpage��.��5t      �� $ 
Horizontal=�6)   .+�5u   "     $
 Book=�6/   #��[ 5v   (   �� 5w   "   $��Sách��6,   #��[ 5x   %   5y      5z      	� 5{      #��[ 6&   ��5|      �� *writerpagecommand+��5}      �� $ Mainpage��.��5~      �� $ 
Horizontal=�6)   .+�5   "     $ PenNib=�6/   #��[ 5�   *   �� 5�   "   $��
Tác giả��6,   #��[ 5�   &   5�      5�      	� 5�      #��[ 6&   ��5�      �� *typepagecommand+��5�      �� $ Mainpage��.��5�      �� $ 
Horizontal=�6)   .+�5�   "     $ BookBookmark=�6/   #��[ 5�   *   �� 5�   "   $��Thể loại��6,   #��[ 5�   &   5�      5�      	� 5�      #��[ 6&   ��5�      �� *publisherpagecommand+��5�      �� $ Mainpage��.��5�      �� $ 
Horizontal=�6)   .+�5�   "     $ Print=�6/   #��[ 5�   .   �� 5�   "   $	��NXB��6,   #��[ 5�   *   5�      5�      5�      	� 5�      -	   5        $ 
borrowlend��5�   "   #��[ 5�      ��5�      �� *borrowpagecommand+��5�      �� $ Mainpage��.��5�      �� $ 
Horizontal=�6%   .+�5�        $ CalendarDay=�6+   #��[ 5�   &   �� 5�      $��Mượn-Trả��6(   #��[ 5�   "   5�      5�      	� 5�      #��[ 6"   ��5�      �� *readerpagecommand+��5�      �� $ Mainpage��.��5�      �� $ 
Horizontal=�6%   .+�5�        $ BookOpenReader=�6+   #��[ 5�   $   �� 5�      $��Độc giả��6(   #��[ 5�   !   5�      5�      5�      5�      5�       � 5�   
   -
   5          �Name$ Mainpage��5�      $��1��5�        � NavigationUIVisibility$ Hidden=�5�      ��5�      Z� 5�      5�      5�      