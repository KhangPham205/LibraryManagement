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
��auto �6/   .+�5T      �� -   5         ��Name$ addnxb��5T   "   $��Thêm��5U      $��5q�5V        
button:add#���  5W      ��5X      �� *
AddCommand+�� 5Y      -   5        $ editnxb��5Y   "   $��Sửa��5Z      $��2��5[      $��5q�5\        button:edit#���  5]      ��5^      �� *EditCommand+��5_      �� 	 �� ElementName$	 tentb���� 5`      -   5        $ 	deletenxb��5`   "   $
��Xóa��5a      $��4��5b      $��5q�5c        button:delete#���  5d      ��5e      �� *DeleteCommand+�� 5f      -   5        $ findnxb��5f   "   $
��Tìm��5g      $��6��5h      $��5q�5i        button:find#���  5j      ��5k      �� *SearchCommand+�� 5l      -   5        $ shownxb��5l   "   $��Hiển thị��5m      $��8��5n      $��5q�5o        button:show#���  5p      ��5q      �� *ShowCommand+5r      5s      5t      &   System.Windows.Controls.DataGrid  5u      -   5        
  Name$	
 nxb��5u      $��5q�5v      $��1��5w       �� SelectedItem 5x      �� *SelectedNhaXuatBan+$ OneWayToSource=���5y      �� *NhaXuatBanList+   Columns 5z      0  *System.Windows.Controls.DataGridTextColumn  5{      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã NXB��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 69   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *MaNXB+  5|      $ Tên NXB��6)   $ 5* 6:    6E   �� *TenNXB+5~      5      5�      5�      