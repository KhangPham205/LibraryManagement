   M S B A M L   `   `   `  ����W  SLibraryManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel5LibraryManagementApplication.ViewModel.ClassViewModel  5      1    +LibraryManagementApplication.headerbookpage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      UlocalCclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel     5      .��5	      � 
�������  � RowDefinitions  5
   
   �� 5      $��70 �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���#e6f3ff.+�5      �� $��Quản lý đầu sách ��6   $��50(�5      $
��Bold"�5      $��roboto)�5      ���#07209e$��Center=�5      $��Right=�5      5      � 5   
   $��1��6   ���#e6f3ff � DataContext 5      L   FLibraryManagementApplication.ViewModel.ClassViewModel.DauSachViewModel  5        5      �� 5      $
��auto �6    �� 5       $��* �6    .+�5"      �� $��40,40,40,10q�6   ���#07209e$��2q�5$      $��Center=�5%       �� CornerRadius$ 20��5&      ._�5'      � $��10q�6     5(      �� 5)      $��10 �6(   �� 5*      $
��auto �6(   �� 5+      $
��auto �6(   �� 5,      $
��auto �6(   �� 5-      $
��auto �6(   �� 5.      $
��auto �6(   �� 5/      $
��auto �6(   �� 50      $��10 �6(    � ColumnDefinitions 52      �� 53      $	��130 �6+   �� 54      $	��300 �6+   �� 55      $	��110 �6+   �� 56      $	��300 �6+   .+�59      �� $��Tên đầu sách:��6       textblock:style1#��[  5:      $��0��5;      $��1��5<      $��5q�5=      $��Right=�5>      �� 5?      -   5         ��Name$ tentb��5?      $��1��5@      $��1��5A      $��5q�5B        textbox:style1#��[ 5C      ��5D      �� *
TenDauSach+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5F      $��Tác giả: ��6    #��[  5G      $��0��5H      $��3��5I      $��5q�5J      $��Right=�5K      �� 5L      -   5         ��Name$ tacgiatb��5L      $��1��5M      $��3��5N      
�������  combobox:style1#��[ 5P      $��5q�5R       �� Text 5Q      �� *TenTG+$ TwoWay=�$ PropertyChanged=�5R      �� 5S      $��Thể loại: ��6    #��[  5T      $��0��5U      $��2��5V      $��5q�5W      $��Right=�5X      �� 5Y      -   5        $ 	theloaitb��5Y      $��1��5Z      $��2��5[      $��5q�5\      #��[ 5]       5^      �� *TenTL+$ TwoWay=�$ PropertyChanged=��� 5_      $��NXB: ��6    #��[  5`      $��2��5a      $��1��5b      $��5q�5c      $��Right=�5d      �� 5e      -   5        $ nxbtb��5e      $��3��5f      $��1��5g      $��5q�5h      #��[ 5i       5j      �� *TenNXB+$ TwoWay=�$ PropertyChanged=��� 5k      $��Ngôn ngữ: ��6    #��[  5l      $��2��5m      $��2��5n      $��5q�5o      $��Right=�5p      �� 5q      -   5        $ 	ngonngutb��5q      $��3��5r      $��2��5s      $��5q�5t      #��[ 5u      ��5v      �� *	NgonNgu+$ TwoWay=�$ PropertyChanged=�� 5w      $��4��6   $��0��5x      $��4��5y       5z      �� 5{      $
��auto �6/   �� 5|      $��10 �6/   �� 5}      $
��auto �6/   �� 5~      $��10 �6/   �� 5      $
��auto �6/   �� 5�      $��* �6/   �� 5�      $
��auto �6/   �� 5�      $��10 �6/   �� 5�      $
��auto �6/   �� 5�      $��10 �6/   �� 5�      $
��auto �6/   .+�5�      �� -   5        	 ��Name$	 addsach��5�   "   $��Thêm DS��5�   #   $��5q�5�   #     
button:add#���  5�   #   ��5�   #   �� *
AddCommand+�� 5�      -   5        $	 editsach��5�   "   $��Sửa DS��5�   %   $��2��5�   %   $��5q�5�   %     button:edit#���  5�   %   ��5�   %   �� *EditCommand+�� 5�      -   5        $	 
deletesach��5�   "   $��Xóa DS��5�   #   $��4��5�   #   $��5q�5�   #     button:delete#���  5�   #   ��5�   #   �� *DeleteCommand+�� 5�      -	   5        $	 findsach��5�   "   $��Tìm DS��5�   #   $��6��5�   #   $��5q�5�   #     button:find#���  5�   #   ��5�   #   �� *SearchCommand+�� 5�      -
   5        $	 showsach��5�   "   $��Hiển thị��5�   #   $��8��5�   #   $��5q�5�   #     button:show#���  5�   #   ��5�   #   �� *ShowCommand+�� 5�      -   5        $	 
exportsach��5�   "   $��Xuất file��5�   #   $��10��5�   #   $��5q�5�   #     button:export#���  5�   #   5�   #   5�      5�      5�      &   System.Windows.Controls.DataGrid  5�      -   5        
  Name$

 sach��5�      $��5q�5�      $��1��5�       �� SelectedItem 5�      �� *SelectedRow+$ OneWayToSource=���5�      �� *DauSachList+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã đầu sách��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6>   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   �� *	MaDauSach+  5�      $ Tên đầu sách��6)   $ 2* 6?    6J   �� *
TenDauSach+  5�      $ 
Tác giả��6)   $ * 6:    6D   �� *TenTG+  5�      $ Thể loại��6)   $ * 6;    6E   �� *TenTL+  5�      $	 NXB��6)   $
 1.6* 66    6C   �� *TenNXB+  5�      $ Ngôn ngữ��6)   $ * 6;    6E   �� *	NgonNgu+5�      5�      5�      5�      