   M S B A M L   `   `   `  ����W  SLibraryManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel5LibraryManagementApplication.ViewModel.ClassViewModel  5      1    +LibraryManagementApplication.headerbookpage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      UlocalCclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel     5      .��5	      � 
�������  � RowDefinitions  5
   
   �� 5      $��70 �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���#e6f3ff.+�5      �� $��Quản lý đầu sách ��6   $��50(�5      $
��Bold"�5      $��roboto)�5      ���#07209e$��Center=�5      $��Right=�5      5      � 5   
   $��1��6   ���#e6f3ff � DataContext 5      L   FLibraryManagementApplication.ViewModel.ClassViewModel.DauSachViewModel  5        5      �� 5      $
��auto �6    �� 5       $��* �6    .+�5"      �� $��40,40,40,10q�6   ���#07209e$��2q�5$       �� CornerRadius$ 20��5%      ._�5&      � $��10q�6     5'      �� 5(      $��10 �6(   �� 5)      $
��auto �6(   �� 5*      $
��auto �6(   �� 5+      $
��auto �6(   �� 5,      $
��auto �6(   �� 5-      $
��auto �6(   �� 5.      $
��auto �6(   �� 5/      $��10 �6(    � ColumnDefinitions 51      �� 52      $	��130 �6+   �� 53      $��* �6+   �� 54      $	��110 �6+   �� 55      $��* �6+   .+�58      �� $��Tên đầu sách:��6       textblock:style1#��[  59      $��0��5:      $��1��5;      $��5q�5<      $��Right=�5=      �� 5>      -   5         ��Name$ tentb��5>      $��1��5?      $��1��5@      $��5q�5A        textbox:style1#��[ 5B      ��5C      �� *
TenDauSach+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5E      $��Tác giả: ��6    #��[  5F      $��0��5G      $��3��5H      $��5q�5I      $��Right=�5J      �� 5K      -   5         ��Name$ tacgiatb��5K      $��1��5L      $��3��5M      
�������  combobox:style1#��[ 5O      $��5q�5Q       �� Text 5P      �� *TenTG+$ TwoWay=�$ PropertyChanged=�5Q      �� 5R      $��Thể loại: ��6    #��[  5S      $��0��5T      $��2��5U      $��5q�5V      $��Right=�5W      �� 5X      -   5        $ 	theloaitb��5X      $��1��5Y      $��2��5Z      $��5q�5[      #��[ 5\       5]      �� *TenTL+$ TwoWay=�$ PropertyChanged=��� 5^      $��NXB: ��6    #��[  5_      $��2��5`      $��1��5a      $��5q�5b      $��Right=�5c      �� 5d      -   5        $ nxbtb��5d      $��3��5e      $��1��5f      $��5q�5g      #��[ 5h       5i      �� *TenNXB+$ TwoWay=�$ PropertyChanged=��� 5j      $��Ngôn ngữ: ��6    #��[  5k      $��2��5l      $��2��5m      $��5q�5n      $��Right=�5o      �� 5p      -   5        $ 	ngonngutb��5p      $��3��5q      $��2��5r      $��5q�5s      #��[ 5t      ��5u      �� *	NgonNgu+$ TwoWay=�$ PropertyChanged=�� 5v      $��4��6   $��0��5w      $��4��5x       5y      �� 5z      $
��auto �6/   �� 5{      $��10 �6/   �� 5|      $
��auto �6/   �� 5}      $��10 �6/   �� 5~      $
��auto �6/   �� 5      $��* �6/   �� 5�      $
��auto �6/   �� 5�      $��10 �6/   �� 5�      $
��auto �6/   �� 5�      $��10 �6/   �� 5�      $
��auto �6/   .+�5�      �� -   5        	 ��Name$	 addsach��5�   "   $��Thêm��5�   #   $��5q�5�   #     
button:add#���  5�   #   ��5�   #   �� *
AddCommand+�� 5�      -   5        $	 editsach��5�   "   $��Sửa��5�   %   $��2��5�   %   $��5q�5�   %     button:edit#���  5�   %   ��5�   %   �� *EditCommand+�� 5�      -   5        $	 
deletesach��5�   "   $
��Xóa��5�   #   $��4��5�   #   $��5q�5�   #     button:delete#���  5�   #   ��5�   #   �� *DeleteCommand+�� 5�      -	   5        $	 findsach��5�   "   $
��Tìm��5�   #   $��6��5�   #   $��5q�5�   #     button:find#���  5�   #   ��5�   #   �� *SearchCommand+�� 5�      -
   5        $	 showsach��5�   "   $��Hiển thị��5�   #   $��8��5�   #   $��5q�5�   #     button:show#���  5�   #   ��5�   #   �� *ShowCommand+�� 5�      -   5        $	 
exportsach��5�   "   $��Xuất file��5�   #   $��10��5�   #   $��5q�5�   #     button:export#���  5�   #   5�   #   5�      5�      5�      &   System.Windows.Controls.DataGrid  5�      -   5        
  Name$

 sach��5�      $��5q�5�      $��1��5�       �� SelectedItem 5�      �� *SelectedRow+$ OneWayToSource=���5�      �� *DauSachList+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã đầu sách��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6>   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   �� *	MaDauSach+  5�      $ Tên đầu sách��6)   $ 2* 6?    6J   �� *
TenDauSach+  5�      $ 
Tác giả��6)   $ * 6:    6D   �� *TenTG+  5�      $ Thể loại��6)   $ * 6;    6E   �� *TenTL+  5�      $	 NXB��6)   $
 1.6* 66    6C   �� *TenNXB+  5�      $ Ngôn ngữ��6)   $ * 6;    6E   �� *	NgonNgu+5�      5�      5�      5�      