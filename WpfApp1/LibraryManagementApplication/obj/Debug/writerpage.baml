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
��auto �6/   .+�5S      �� -   5         ��Name$ addtg��5S   "   $��Thêm��5T      $��5q�5U        
button:add#���  5V      ��5W      �� *
AddCommand+�� 5X      -   5        $ edittg��5X   "   $��Sửa��5Y      $��2��5Z      $��5q�5[        button:edit#���  5\      ��5]      �� *EditCommand+��5^      �� 	 �� ElementName$	 tentb���� 5_      -   5        $ deletetg��5_   "   $
��Xóa��5`      $��4��5a      $��5q�5b        button:delete#���  5c      ��5d      �� *DeleteCommand+�� 5e      -   5        $ findtg��5e   "   $
��Tìm��5f      $��6��5g      $��5q�5h        button:find#���  5i      ��5j      �� *SearchCommand+�� 5k      -   5        $ showtg��5k   "   $��Hiển thị��5l      $��8��5m      $��5q�5n        button:show#���  5o      ��5p      �� *ShowCommand+5q      5r      5s      &   System.Windows.Controls.DataGrid  5t      -   5        
  Name$
 tacgia��5t      $��5q�5u      $��1��5v       �� SelectedItem 5w      �� *SelectedTacGia+$ OneWayToSource=���5x      �� *
TacGiaList+   Columns 5y      0  *System.Windows.Controls.DataGridTextColumn  5z      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã tác giả��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6=   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   �� *MaTG+  5{      $ Tên tác giả��6)   $ 5* 6>    6I   �� *TenTG+5}      5~      5      5�      