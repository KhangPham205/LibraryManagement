   M S B A M L   `   `   `  ����W  SLibraryManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel5LibraryManagementApplication.ViewModel.ClassViewModel  5      0    *LibraryManagementApplication.publisherpage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      UlocalCclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel     5        N� Title$  publisherpage��5	       � DataContext 5
      O   ILibraryManagementApplication.ViewModel.ClassViewModel.NhaXuatBanViewModel  5   
   .��5      � 
������� � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���#e6f3ff.+�5      �� $#��Quản lý nhà xuất bản ��6   $��50(�5      $
��Bold"�5      $��roboto)�5      ���#07209e$��Center=�5      $��Right=�5      5      � 5   
   ���#e6f3ff$��1��5        5!      �� 5"      $
��auto �6    �� 5#      $��* �6    .+�5%      �� $��40,40,40,10q�6   ���#07209e$��2q�5'       �� CornerRadius$ 20��5(      ._�5)      � $��10q�6    5*      �� 5+      $��10 �6(   �� 5,      $
��auto �6(   �� 5-      $
��auto �6(   �� 5.      $
��auto �6(   �� 5/      $��10 �6(    � ColumnDefinitions 51      �� 52      $
��auto �6+   �� 53      $��* �6+   �� 54      $	��100 �6+   �� 55      $��* �6+   .+�58      �� $��Tên nhà xuất bản:��6       textblock:style1#��[  59      $��0��5:      $��1��5;      $��5q�5<      $��Right=�5=      �� 5>      -   5         ��Name$ tentb��5>      $��3��5?      $��1��5@      $��1��5A      $��5q�5B        textbox:style1#��[ 5C      ��5D      �� *DisplayName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�� 5F      $��3��6   $��0��5G      $��4��5H       5I      �� 5J      $
��auto �6/   �� 5K      $��10 �6/   �� 5L      $
��auto �6/   �� 5M      $��10 �6/   �� 5N      $
��auto �6/   �� 5O      $��* �6/   �� 5P      $
��auto �6/   �� 5Q      $��10 �6/   �� 5R      $
��auto �6/   �� 5S      $��10 �6/   �� 5T      $
��auto �6/   .+�5V      �� -   5         ��Name$ addsach��5V   "   $��	Thêm NXB��5W   !   $��5q�5X   !     
button:add#���  5Y   !   ��5Z   !   �� *
AddCommand+�� 5[      -   5        $ editsach��5[   "   $��	Sửa NXB��5\      $��2��5]      $��5q�5^        button:edit#���  5_      ��5`      �� *EditCommand+�� 5a      -   5        $ 
deletesach��5a   "   $��Xóa NXB��5b      $��4��5c      $��5q�5d        button:delete#���  5e      ��5f      �� *DeleteCommand+�� 5g      -   5        $ findsach��5g   "   $��Tìm NXB��5h      $��6��5i      $��5q�5j        button:find#���  5k      ��5l      �� *SearchCommand+�� 5m      -   5        $ showsach��5m   "   $��Hiển thị��5n      $��8��5o      $��5q�5p        button:show#���  5q      ��5r      �� *ShowCommand+�� 5s      -   5        $ 
exportsach��5s   "   $��Xuất file��5t      $��10��5u      $��5q�5v        button:export#���  5w      5x      5y      5z      5{      � 5|      $��5q�6   $��1��5}       5~      �� 5      $
��auto �6$   �� 5�      $��* �6$   .+�5�      �� $��Nhà xuất bản��6   #��[  60   &   System.Windows.Controls.DataGrid  5�      -   5        	  Name$		 nxb��5�      $��1��5�      
 �� SelectedItem
 5�      �� *SelectedNhaXuatBan+$ OneWayToSource=���5�      �� *NhaXuatBanList+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã NXB��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6=   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   �� *MaNXB+  5�      $ Tên NXB��6-   $ 5* 6>    6I   �� *TenNXB+5�      5�      5�      5�      5�      