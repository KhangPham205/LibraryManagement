   M S B A M L   `   `   `  ����W  SLibraryManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel5LibraryManagementApplication.ViewModel.ClassViewModel  5      +    %LibraryManagementApplication.bookpage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      UlocalCclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel     5        N� Title$  bookpage��5	      .��5
      � 
������� � DataContext 5   
   I   CLibraryManagementApplication.ViewModel.ClassViewModel.SachViewModel  5       � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���#e6f3ff.+�5      �� $��Quản lý sách ��6   $��50(�5      $
��Bold"�5      $��roboto)�5      ���#07209e$��Center=�5      $��Right=�5      5      � 5   
   $��1��6   ���#e6f3ff 5      �� 5       $
��auto �6    �� 5!      $��* �6    .+�5#      �� $��40,40,40,10q�6   ���#07209e$��2q�5%       �� CornerRadius$ 20��5&      ._�5'      � $��10q�6    5(      �� 5)      $��10 �6(   �� 5*      $
��auto �6(   �� 5+      $
��auto �6(   �� 5,      $
��auto �6(   �� 5-      $
��auto �6(   �� 5.      $
��auto �6(   �� 5/      $
��auto �6(   �� 50      $��10 �6(    � ColumnDefinitions 52      �� 53      $	��130 �6+   �� 54      $��* �6+   �� 55      $	��110 �6+   �� 56      $��* �6+   .+�59      �� $��Tên đầu sách:��6       textblock:style1#��[  5:       $��0��5;       $��1��5<       $��5q�5=       $��Right=�5>       �� 5?      -   5         ��Name$ tentb��5?      $��1��5@      $��1��5A      $��5q�5B        combobox:style1#��[ 5C       �� Text 5D      �� *
TenDauSach+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5E      $��ISBN: ��6    #��[  5F       $��0��5G       $��2��5H       $��5q�5I       $��Right=�5J       �� 5K      -   5        	 ��Name$
	 isbn��5K      $��1��5L      $��2��5M      $��5q�5N        textbox:style1#��[ 5O      ��5P      �� *ISBN+$ TwoWay=�$ PropertyChanged=��� 5Q      $��	Năm XB: ��6    #��[  5R       $��0��5S       $��3��5T       $��5q�5U       $��Right=�5V       �� 5W      -   5        $	 namxbtb��5W      $��1��5X      $��3��5Y      #��[ 5Z      $��5q�5[      ��5\      �� *NamXB+$ TwoWay=�$ PropertyChanged=��� 5]      $��Vị trí: ��6    #��[  5^       $��2��5_       $��1��5`       $��5q�5a       $��Right=�5b       �� 5c      -   5        $	 vitritb��5c      $��3��5d      $��1��5e      $��5q�5f      #��[ 5g      ��5h      �� *ViTri+$ TwoWay=�$ PropertyChanged=��� 5i      $��Trạng thái: ��6    #��[  5j       $��2��5k       $��2��5l       $��5q�5m       $��Right=�5n       �� 5o      -   5        $ trangthaitb��5o      $��3��5p      $��2��5q      $��5q�5r      #��[ 5s      
 �� SelectedItem
 5t      �� *	TrangThai+$ TwoWay=�$ PropertyChanged=�5u      � 5v      $��4��6   $��0��5w      $��4��5x       5y      �� 5z      $
��auto �6/   �� 5{      $��10 �6/   �� 5|      $
��auto �6/   �� 5}      $��10 �6/   �� 5~      $
��auto �6/   �� 5      $��* �6/   �� 5�      $
��auto �6/   �� 5�      $��10 �6/   �� 5�      $
��auto �6/   �� 5�      $��10 �6/   �� 5�      $
��auto �6/   .+�5�      �� -   5         ��Name$ addsach��5�   "   $��Thêm��5�   #   $��5q�5�   #     
button:add#���  5�   #   ��5�   #   �� *
AddCommand+�� 5�      -   5        $ editsach��5�   "   $��Sửa��5�   #   $��2��5�   #   $��5q�5�   #     button:edit#���  5�   #   ��5�   #   �� *EditCommand+�� 5�      -   5        $ 
deletesach��5�   "   $
��Xóa��5�   #   $��4��5�   #   $��5q�5�   #     button:delete#���  5�   #   ��5�   #   �� *DeleteCommand+�� 5�      -	   5        $ findsach��5�   "   $
��Tìm��5�   #   $��6��5�   #   $��5q�5�   #     button:find#���  5�   #   ��5�   #   �� *SearchCommand+�� 5�      -
   5        $ showsach��5�   "   $��Hiển thị��5�   #   $��8��5�   #   $��5q�5�   #     button:show#���  5�   #   ��5�   #   �� *ShowCommand+�� 5�      -   5        $ 
exportsach��5�   "   $��Xuất file��5�   #   $��10��5�   #   $��5q�5�   #     button:export#���  5�   #   5�   #   5�      5�      5�      &   System.Windows.Controls.DataGrid  5�      -   5          Name$
 sach��5�      $��5q�5�      $��1��5�      
 5�      �� *SelectedSach+$ OneWayToSource=���5�      �� *
SachList+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã đầu sách��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6>   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   �� *	MaDauSach+  5�      $ Tên đầu sách��6)   $ 2* 6?    6J   �� *
TenDauSach+  5�      $
 ISBN��6)   $ * 67    6A   �� *ISBN+  5�      $ Năm xuất bản��6)   $ * 6?    6I   �� *NamXB+  5�      $ 	Vị trí��6)   $ * 69    6C   �� *ViTri+  5�      $ Trạng thái��6)   $ * 6=    6G   �� *	TrangThai+5�      5�      5�      5�      