   M S B A M L   `   `   `  ����W  SLibraryManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel5LibraryManagementApplication.ViewModel.ClassViewModel  5      +    %LibraryManagementApplication.bookpage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      UlocalCclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel     5        N� Title$  bookpage��5	       � 	Resources 5
      P   JLibraryManagementApplication.ViewModel.ClassViewModel.IntToStringConverter   IntToStringConverter��%   &	          5   
   6%   5      .��5      � 
������� � DataContext 5   
   I   CLibraryManagementApplication.ViewModel.ClassViewModel.SachViewModel  5       � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���#e6f3ff.+�5      �� $��Quản lý sách ��6   $��50(�5      $
��Bold"�5      $��roboto)�5      ���#07209e$��Center=�5      $��Right=�5      5      � 5    
   $��1��6   ���#e6f3ff 5"      �� 5#      $
��auto �6    �� 5$      $��* �6    .+�5&      �� $��40,40,40,10q�6   ���#07209e$��2q�5(       �� CornerRadius$ 20��5)      ._�5*      � $��10q�6    5+      �� 5,      $��10 �6(   �� 5-      $
��auto �6(   �� 5.      $
��auto �6(   �� 5/      $
��auto �6(   �� 50      $
��auto �6(   �� 51      $
��auto �6(   �� 52      $
��auto �6(   �� 53      $��10 �6(    � ColumnDefinitions 55      �� 56      $	��130 �6+   �� 57      $��* �6+   �� 58      $	��110 �6+   �� 59      $��* �6+   .+�5<      �� $��Tên đầu sách:��6      textblock:style1#��[ 5=       $��0��5>       $��1��5?       $��5q�5@       $��Right=�5A       �� 5B      -   5         ��Name$ tentb��5B      $��1��5C      $��1��5D      $��5q�5E        combobox:style1#��[ 5F       �� Text 5G      �� *
TenDauSach+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=��� 5H      $��ISBN: ��6    #��[ 5I       $��0��5J       $��2��5K       $��5q�5L       $��Right=�5M       �� 5N      -   5        
 ��Name$

 isbn��5N      $��1��5O      $��2��5P      $��5q�5Q        textbox:style1#��[ 5R      ��5S      �� *ISBN+$ TwoWay=�$	 PropertyChanged=��� 5T      $��	Năm XB: ��6    #��[ 5U       $��0��5V       $��3��5W       $��5q�5X       $��Right=�5Y       �� 5Z      -   5        $
 namxbtb��5Z      $��1��5[      $��3��5\      #��[ 5]      $��5q�5^      ��5_      �� *NamXB+$ TwoWay=�$	 PropertyChanged=��� 5`      $��Vị trí: ��6    #��[ 5a       $��2��5b       $��1��5c       $��5q�5d       $��Right=�5e       �� 5f      -   5        $
 vitritb��5f      $��3��5g      $��1��5h      $��5q�5i      #��[ 5j      ��5k      �� *ViTri+$ TwoWay=�$	 PropertyChanged=��� 5l      $��Trạng thái: ��6    #��[ 5m       $��2��5n       $��2��5o       $��5q�5p       $��Right=�5q       �� 5r      -   5        $ trangthaitb��5r      $��3��5s      $��2��5t      $��5q�5u      #��[ 5v       �� SelectedItem 5w      �� *	TrangThai+$ TwoWay=�$	 PropertyChanged=�5x      � 5y      $��4��6   $��0��5z      $��4��5{       5|      �� 5}      $
��auto �6/   �� 5~      $��10 �6/   �� 5      $
��auto �6/   �� 5�      $��10 �6/   �� 5�      $
��auto �6/   �� 5�      $��* �6/   �� 5�      $
��auto �6/   �� 5�      $��10 �6/   �� 5�      $
��auto �6/   .+�5�      �� -   5         ��Name$ addsach��5�   "   $��Thêm��5�   #   $��5q�5�   #     
button:add#���  5�   #   ��5�   #   �� *
AddCommand+�� 5�      -   5        $ editsach��5�   "   $��Sửa��5�   #   $��2��5�   #   $��5q�5�   #     button:edit#���  5�   #   ��5�   #   �� *EditCommand+�� 5�      -   5        $ 
deletesach��5�   "   $
��Xóa��5�   #   $��4��5�   #   $��5q�5�   #     button:delete#���  5�   #   ��5�   #   �� *DeleteCommand+�� 5�      -	   5        $ findsach��5�   "   $
��Tìm��5�   #   $��6��5�   #   $��5q�5�   #     button:find#���  5�   #   ��5�   #   �� *SearchCommand+�� 5�      -
   5        $ showsach��5�   "   $��Hiển thị��5�   #   $��8��5�   #   $��5q�5�   #     button:show#���  5�   #   ��5�   #   �� *ShowCommand+5�      5�      5�      &   System.Windows.Controls.DataGrid  5�      -   5          Name$
 sach��5�      $��5q�5�      $��1��5�       5�      �� *SelectedSach+$ OneWayToSource=���5�      �� *
SachList+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã đầu sách��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6>   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   �� *	MaDauSach+  5�      $ Tên đầu sách��6)   $ 2* 6?    6J   �� *
TenDauSach+  5�      $
 ISBN��6)   $ * 67    6A   �� *ISBN+  5�      $ Năm xuất bản��6)   $ * 6?    6I   �� *NamXB+  5�      $ 	Vị trí��6)   $ * 69    6C   �� *ViTri+  5�      $ Trạng thái��6)   $ * 6=    6G   �� *	TrangThai+5�      5�      5�      5�      