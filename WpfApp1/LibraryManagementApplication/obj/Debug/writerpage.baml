   M S B A M L   `   `   `  ����W  SLibraryManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel5LibraryManagementApplication.ViewModel.ClassViewModel  5      -    'LibraryManagementApplication.writerpage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      UlocalCclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel     5        N� Title$  
writerpage��5	      .��5
      � 
������� � DataContext 5   
   K   ELibraryManagementApplication.ViewModel.ClassViewModel.TacGiaViewModel  5       � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���#e6f3ff.+�5      �� $��Quản lý tác giả ��6   $��50(�5      $
��Bold"�5      $��roboto)�5      ���#07209e$��Center=�5      $��Right=�5      5      � 5   
   ���#e6f3ff$��1��5       5       �� 5!      $
��auto �6    �� 5"      $��* �6    .+�5$      �� $��40,40,40,10q�6   ���#07209e$��2q�5&       �� CornerRadius$ 20��5'      ._�5(      � $��10q�6    5)      �� 5*      $��10 �6(   �� 5+      $
��auto �6(   �� 5,      $
��auto �6(   �� 5-      $
��auto �6(   �� 5.      $��10 �6(    � ColumnDefinitions 50      �� 51      $	��110 �6+   �� 52      $��* �6+   �� 53      $	��100 �6+   �� 54      $��* �6+   .+�57      �� $��Tên tác giả:��6       textblock:style1#��[  58      $��0��59      $��1��5:      $��5q�5;      $��Right=�5<      �� 5=      -   5         ��Name$ tentb��5=      $��3��5>      $��1��5?      $��1��5@      $��5q�5A        textbox:style1#��[ 5B      ��5C      �� *DisplayName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�� 5E      $��2��6   $��0��5F      $��4��5G       5H      �� 5I      $
��auto �6/   �� 5J      $��10 �6/   �� 5K      $
��auto �6/   �� 5L      $��10 �6/   �� 5M      $
��auto �6/   �� 5N      $��* �6/   �� 5O      $
��auto �6/   �� 5P      $��10 �6/   �� 5Q      $
��auto �6/   �� 5R      $��10 �6/   �� 5S      $
��auto �6/   .+�5U      �� -   5         ��Name$ addsach��5U   "   $��Thêm TG��5V   #   $��5q�5W   #     
button:add#���  5X   #   ��5Y   #   �� *
AddCommand+�� 5Z      -   5        $ editsach��5Z   "   $��Sửa TG��5[   #   $��2��5\   #   $��5q�5]   #     button:edit#���  5^   #   ��5_   #   �� *EditCommand+�� 5`      -   5        $ 
deletesach��5`   "   $��Xóa TG��5a   #   $��4��5b   #   $��5q�5c   #     button:delete#���  5d   #   ��5e   #   �� *DeleteCommand+�� 5f      -   5        $ findsach��5f   "   $��Tìm TG��5g   #   $��6��5h   #   $��5q�5i   #     button:find#���  5j   #   ��5k   #   �� *SearchCommand+�� 5l      -   5        $ showsach��5l   "   $��Hiển thị��5m   #   $��8��5n   #   $��5q�5o   #     button:show#���  5p   #   ��5q   #   �� *ShowCommand+�� 5r      -   5        $ 
exportsach��5r   "   $��Xuất file��5s   #   $��10��5t   #   $��5q�5u   #     button:export#���  5v   #   5w   #   5x      5y      5z      � 5{      $��5q�6   $��1��5|       5}      �� 5~      $
��auto �6$   �� 5      $��* �6$   .+�5�      �� $��
Tác giả��6   #��[  6+   &   System.Windows.Controls.DataGrid  5�      -   5        	  Name$	 tacgia��5�      $��5q�5�      $��1��5�      
 �� SelectedItem
 5�      �� *SelectedTacGia+$ OneWayToSource=���5�      �� *
TacGiaList+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã tác giả��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6A   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6K   �� *MaTG+  5�      $ Tên tác giả��6-   $ 5* 6B    6M   �� *TenTG+5�      5�      5�      5�      5�      