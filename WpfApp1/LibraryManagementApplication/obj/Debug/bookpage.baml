   M S B A M L   `   `   `  ����W  SLibraryManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel5LibraryManagementApplication.ViewModel.ClassViewModel  5      +    %LibraryManagementApplication.bookpage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      UlocalCclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel     5        N� Title$  bookpage��5	      .��5
      � 
������� � DataContext 5   
   I   CLibraryManagementApplication.ViewModel.ClassViewModel.SachViewModel  5       � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���#e6f3ff.+�5      �� $��Quản lý sách ��6   $��50(�5      $
��Bold"�5      $��roboto)�5      ���#07209e$��Center=�5      $��Right=�5      5      � 5   
   $��1��6   ���#e6f3ff 5      �� 5       $
��auto �6    �� 5!      $��* �6    .+�5#      �� $��40,20,40,10q�6   ���#07209e$��2q�5%      $��Center=�5&       �� CornerRadius$ 20��5'      ._�5(      � $��10q�6    5)      �� 5*      $��10 �6(   �� 5+      $
��auto �6(   �� 5,      $
��auto �6(   �� 5-      $
��auto �6(   �� 5.      $
��auto �6(   �� 5/      $
��auto �6(   �� 50      $
��auto �6(   �� 51      $��10 �6(    � ColumnDefinitions 53      �� 54      $	��130 �6+   �� 55      $	��300 �6+   �� 56      $	��110 �6+   �� 57      $	��300 �6+   .+�5:      �� $��Tên đầu sách:��6       textblock:style1#��[  5;       $��0��5<       $��1��5=       $��5q�5>       $��Right=�5?       �� 5@      -   5         ��Name$ tentb��5@      $��1��5A      $��1��5B      $��5q�5C        combobox:style1#��[ 5D       �� Text 5E      �� *
TenDauSach+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5F      $��ISBN: ��6    #��[  5G       $��0��5H       $��2��5I       $��5q�5J       $��Right=�5K       �� 5L      -   5        	 ��Name$
	 isbn��5L      $��1��5M      $��2��5N      $��5q�5O        textbox:style1#��[ 5P      ��5Q      �� *ISBN+$ TwoWay=�$ PropertyChanged=��� 5R      $��	Năm XB: ��6    #��[  5S       $��0��5T       $��3��5U       $��5q�5V       $��Right=�5W       �� 5X      -   5        $	 namxbtb��5X      $��1��5Y      $��3��5Z      #��[ 5[      $��5q�5\      ��5]      �� *NamXB+$ TwoWay=�$ PropertyChanged=��� 5^      $��Vị trí: ��6    #��[  5_       $��2��5`       $��1��5a       $��5q�5b       $��Right=�5c       �� 5d      -   5        $	 vitritb��5d      $��3��5e      $��1��5f      $��5q�5g      #��[ 5h      ��5i      �� *ViTri+$ TwoWay=�$ PropertyChanged=��� 5j      $��Trạng thái: ��6    #��[  5k       $��2��5l       $��2��5m       $��5q�5n       $��Right=�5o       �� 5p      -   5        $ trangthaitb��5p      $��3��5q      $��2��5r      $��5q�5s      #��[ 5t      
 �� SelectedItem
 5u      �� *	TrangThai+$ TwoWay=�$ PropertyChanged=�5v      � 5w      $��4��6   $��0��5x      $��4��5y       5z      �� 5{      $
��auto �6/   �� 5|      $��10 �6/   �� 5}      $
��auto �6/   �� 5~      $��10 �6/   �� 5      $
��auto �6/   �� 5�      $��* �6/   �� 5�      $
��auto �6/   �� 5�      $��10 �6/   �� 5�      $
��auto �6/   �� 5�      $��10 �6/   �� 5�      $
��auto �6/   .+�5�      �� -   5         ��Name$ addsach��5�   "   $��Thêm sách��5�   #   $��5q�5�   #     
button:add#���  5�   #   ��5�   #   �� *
AddCommand+�� 5�      -   5        $ editsach��5�   "   $��Sửa sách��5�   #   $��2��5�   #   $��5q�5�   #     button:edit#���  5�   #   ��5�   #   �� *EditCommand+�� 5�      -   5        $ 
deletesach��5�   "   $��
Xóa sách��5�   #   $��4��5�   #   $��5q�5�   #     button:delete#���  5�   #   ��5�   #   �� *DeleteCommand+�� 5�      -	   5        $ findsach��5�   "   $��
Tìm sách��5�   #   $��6��5�   #   $��5q�5�   #     button:find#���  5�   #   ��5�   #   �� *SearchCommand+�� 5�      -
   5        $ showsach��5�   "   $��Hiển thị��5�   #   $��8��5�   #   $��5q�5�   #     button:show#���  5�   #   ��5�   #   �� *ShowCommand+�� 5�      -   5        $ 
exportsach��5�   "   $��Xuất file��5�   #   $��10��5�   #   $��5q�5�   #     button:export#���  5�   #   5�   #   5�      5�      5�      � 5�      $��5q�6   $��1��5�       5�      �� 5�      $
��auto �6$   �� 5�      $��* �6$   .+�5�      �� $��Sách��6   #��[  6(   &   System.Windows.Controls.DataGrid  5�      -   5          Name$
 sach��5�      $��1��5�      
 5�      �� *SelectedSach+$ OneWayToSource=���5�      �� *
SachList+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã đầu sách��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6B   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6L   �� *	MaDauSach+  5�      $ Tên đầu sách��6-   $ 2* 6C    6N   �� *
TenDauSach+  5�      $
 ISBN��6-   $ * 6;    6E   �� *ISBN+  5�      $ Năm xuất bản��6-   $ * 6C    6M   �� *NamXB+  5�      $ 	Vị trí��6-   $ * 6=    6G   �� *ViTri+  5�      $ Trạng thái��6-   $ * 6A    6K   �� *	TrangThai+5�      5�      5�      5�      5�      