   M S B A M L   `   `   `  ����W  SLibraryManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:LibraryManagementApplication.ViewModel&LibraryManagementApplication.ViewModel  5   	   .    (LibraryManagementApplication.MainWindow1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:LibraryManagementApplication.ViewModel     5   	   X TFontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   -   5          �Name$  
mainwindow��5   	    � Title$ Quản Lý Thư Viện��5
   	   $	��700��6"   $
��1200��6/   $	��700��5   	   $
��1200��6    � Icon$ /Icon/book (1).png��6)    � DataContext 5      :   4LibraryManagementApplication.ViewModel.MainViewModel  5   
   .��5      � ���#e6f3ff � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$
 Menu��5      $��0��5   	   $��2��6   ���	#FF36A4ED �� CornerRadius$ 	0,20,20,0��5   	   
������ $��0q�5   	   $��
-190,0,0,0q�5   	    K� ZIndex$ 1��5   	    � Triggers 5      :� 5      	 :� RoutedEvent$	 
MouseEnter��6   .[�5       �� .��5!      �� .��5"      t� 
 �� TargetProperty$
 Margin�61   	 t� To$ 
0,0,-190,0X�5#   !    g� Duration$ 0:0:0.2D�5$   !   5%      5&      5'      :� 5*      $	 
MouseLeave��6   .[�5+      �� .��5,      �� .��5-      t� $
 Margin�61   $ 
-190,0,0,0X�5.   !   $ 0:0:0.5D�5/   !   50      51      52      ._�54      � .+�55      �� -   5         ��Name$ listMainButton��55      .+�56      �� $	��100��6   $	��100��6)   $��	0 15 0 15q�66      RoundButton#��[  57      ��58      �� *infopagecommand+��59      ��  �� ElementName$ Mainpage��.��5;      �� $��/Icon/user.png��6    5<      	� 5=      -   5         	�Name$ 
mainbutton��5=   "     rbutton:menu#��[ 5>   "   ��5?   !   �� *mainpagecommand+��5@   !   �� $ Mainpage��.��5A      ��  �� Orientation$ 
Horizontal=�6%   .+�5B      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Home=�6+     	icon:menu#��[ 5C   1   �� 5D      $��Trang chủ��6(     textblock:menu#��[ 5E   -   5F      5H      	� 5I      -   5        $ 
sachbutton��5I   "   #��[ 5J      .��5K      �� $ 
Horizontal=�6%   .+�5L        $ BookOpen=�6+   #��[ 5M   -   �� 5N      $��Thông tin sách��6(   #��[ 5O   )   5P      5Q      �� 5R      ��5S      �� 5T       �� 
TargetType" ��6$    �� Triggers 5U   "   �� 5V   &    �� Binding 62   �� *	IsChecked+$ 
sachbutton�� �� Value True6i   .a�5W   *   ��  �� Property � y� �� Value$ Visible=�6G   5X   '   �� 5Y   &    62   �� *	IsChecked+$ 
sachbutton��	 False6i   .a�5Z   *   ��  � y�$ 	Collapsed=�6G   5[   '   5]      .+�5_      	�   rbutton:submenu#��[ 6&   ��5`   )   �� *headerbookpagecommand+��5a   )   �� $ Mainpage��.��5b      �� $ 
Horizontal=�6)   .+�5c   "     $ BookOpen=�6/     icon:submenu#��[ 5d   1   �� 5e   "   $��Đầu Sách��6,     textblock:submenu#��[ 5f   -   5g      5h      	� 5i      #��[ 6&   ��5j   &   �� *bookpagecommand+��5k   &   �� $ Mainpage��.��5l      �� $ 
Horizontal=�6)   .+�5m   "     $
 Book=�6/   #��[ 5n   /   �� 5o   "   $��Sách��6,   #��[ 5p   ,   5q      5r      	� 5s      #��[ 6&   ��5t   &   �� *writerpagecommand+��5u   &   �� $ Mainpage��.��5v      �� $ 
Horizontal=�6)   .+�5w   "     $ PenNib=�6/   #��[ 5x   1   �� 5y   "   $��
Tác giả��6,   #��[ 5z   -   5{      5|      	� 5}      #��[ 6&   ��5~   &   �� *typepagecommand+��5   &   �� $ Mainpage��.��5�      �� $ 
Horizontal=�6)   .+�5�   "     $ BookBookmark=�6/   #��[ 5�   1   �� 5�   "   $��Thể loại��6,   #��[ 5�   -   5�      5�      	� 5�      #��[ 6&   ��5�   &   �� *publisherpagecommand+��5�   &   �� $ Mainpage��.��5�      �� $ 
Horizontal=�6)   .+�5�   "     $ Print=�6/   #��[ 5�   5   �� 5�   "   $	��NXB��6,   #��[ 5�   1   5�      5�      5�      	� 5�      -   5        $ 
borrowlend��5�   "   #��[ 5�   "   ��5�   "   �� *borrowpagecommand+��5�   "   �� $ Mainpage��.��5�      �� $ 
Horizontal=�6%   .+�5�        $ CalendarDay=�6+   #��[ 5�   -   �� 5�      $��Mượn-Trả��6(   #��[ 5�   )   5�      5�      	� 5�      #��[ 6"   ��5�   "   �� *readerpagecommand+��5�   "   �� $ Mainpage��.��5�      �� $ 
Horizontal=�6%   .+�5�        $ BookOpenReader=�6+   #��[ 5�   +   �� 5�      $��Độc giả��6(   #��[ 5�   (   5�      5�      	� 5�      #��[ 6"   ��5�   "   �� *employeepagecommand+��5�   "   �� $ Mainpage��.��5�      �� $ 
Horizontal=�6%   .+�5�        $ UserAlt=�6+   #��[ 5�   +   �� 5�      $��Nhân viên��6(   #��[ 5�   (   5�      5�      5�      5�      5�       � 5�   
   -   5          �Name$ Mainpage��5�      $��1��5�        � NavigationUIVisibility$ Hidden=�5�      5�      5�      5�      