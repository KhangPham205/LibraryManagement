   M S B A M L   `   `   `  ����W  SLibraryManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:LibraryManagementApplication.ViewModel&LibraryManagementApplication.ViewModel  5   	   .    (LibraryManagementApplication.MainWindow1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:LibraryManagementApplication.ViewModel     5   	   X TFontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   -   5          �Name$  
mainwindow��5   	    � Title$ Quản Lý Thư Viện��5
   	   $	��700��6"   $
��1200��6/   $	��700��5   	   $
��1200��6    � Icon$ /Icon/book (1).png��6)    � DataContext 5      :   4LibraryManagementApplication.ViewModel.MainViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��2��6!   ���	#FF0867A6 �� CornerRadius$ 0,0,20,0��5      
������ $��0q�5      $��0q�5      ._�5      � .+�5      �� -   5         ��Name$ listMainButton��5      .+�5      �� $	��100��6   $	��100��6)   $��	0 15 0 15q�66      RoundButton#��[  5      ��5      �� *infopagecommand+��5      ��  �� ElementName$ Mainpage��.��5!      �� $��/Icon/user.png��6    5"      	� 5#        rbutton:menu#��[ 6"   ��5$   !   �� *mainpagecommand+��5%   !   �� $ Mainpage��.��5&      ��  �� Orientation$ 
Horizontal=�6%   .+�5'      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]	   Icon$
	 Home=�6+     	icon:menu#��[ 5(   1   �� 5)      $��Trang chủ��6(     textblock:menu#��[ 5*   -   5+      5-      	� 5.      -   5        
 	�Name$
 
sachbutton��5.   "   #��[ 5/      .��50      �� $ 
Horizontal=�6%   .+�51        $	 BookOpen=�6+   #��[ 52   -   �� 53      $��Thông tin sách��6(   #��[ 54   )   55      56      �� 57      ��58      �� 59       �� 
TargetType" ��6$    �� Triggers 5:   "   �� 5;   &    �� Binding 62   �� *	IsChecked+$ 
sachbutton�� �� Value True6i   .a�5<   *   ��  �� Property � y� �� Value$ Visible=�6G   5=   '   �� 5>   &    62   �� *	IsChecked+$ 
sachbutton��	 False6i   .a�5?   *   ��  � y�$ 	Collapsed=�6G   5@   '   5B      .+�5D      	�   rbutton:submenu#��[ 6&   ��5E   )   �� *headerbookpagecommand+��5F   )   �� $ Mainpage��.��5G      �� $ 
Horizontal=�6)   .+�5H   "     $	 BookOpen=�6/     icon:submenu#��[ 5I   1   �� 5J   "   $��Đầu Sách��6,     textblock:submenu#��[ 5K   -   5L      5M      	� 5N      #��[ 6&   ��5O   &   �� *bookpagecommand+��5P   &   �� $ Mainpage��.��5Q      �� $ 
Horizontal=�6)   .+�5R   "     $
	 Book=�6/   #��[ 5S   /   �� 5T   "   $��Sách��6,   #��[ 5U   ,   5V      5W      	� 5X      #��[ 6&   ��5Y   &   �� *writerpagecommand+��5Z   &   �� $ Mainpage��.��5[      �� $ 
Horizontal=�6)   .+�5\   "     $	 PenNib=�6/   #��[ 5]   1   �� 5^   "   $��
Tác giả��6,   #��[ 5_   -   5`      5a      	� 5b      #��[ 6&   ��5c   &   �� *typepagecommand+��5d   &   �� $ Mainpage��.��5e      �� $ 
Horizontal=�6)   .+�5f   "     $	 BookBookmark=�6/   #��[ 5g   1   �� 5h   "   $��Thể loại��6,   #��[ 5i   -   5j      5k      	� 5l      #��[ 6&   ��5m   &   �� *publisherpagecommand+��5n   &   �� $ Mainpage��.��5o      �� $ 
Horizontal=�6)   .+�5p   "     $	 Print=�6/   #��[ 5q   5   �� 5r   "   $	��NXB��6,   #��[ 5s   1   5t      5u      5v      	� 5w      -   5        $
 
borrowlend��5w   "   #��[ 5x   "   ��5y   "   �� *borrowpagecommand+��5z   "   �� $ Mainpage��.��5{      �� $ 
Horizontal=�6%   .+�5|        $	 CalendarDay=�6+   #��[ 5}   -   �� 5~      $��Mượn-Trả��6(   #��[ 5   )   5�      5�      	� 5�      #��[ 6"   ��5�   "   �� *readerpagecommand+��5�   "   �� $ Mainpage��.��5�      �� $ 
Horizontal=�6%   .+�5�        $	 BookOpenReader=�6+   #��[ 5�   +   �� 5�      $��Độc giả��6(   #��[ 5�   (   5�      5�      	� 5�      #��[ 6"   ��5�   "   �� *employeepagecommand+��5�   "   �� $ Mainpage��.��5�      �� $ 
Horizontal=�6%   .+�5�        $	 UserAlt=�6+   #��[ 5�   +   �� 5�      $��Nhân viên��6(   #��[ 5�   (   5�      5�      5�      5�      5�       � 5�   
   -   5          �Name$ Mainpage��5�      $��1��5�        � NavigationUIVisibility$ Hidden=�5�      5�      5�      5�      