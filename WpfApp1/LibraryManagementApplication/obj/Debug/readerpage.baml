   M S B A M L   `   `   `  ����W  SLibraryManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel5LibraryManagementApplication.ViewModel.ClassViewModel  5      -    'LibraryManagementApplication.readerpage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      UlocalCclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel     5        N� Title$  
readerpage��5	       � DataContext 5
      K   ELibraryManagementApplication.ViewModel.ClassViewModel.DocGiaViewModel  5   
   .��5      � 
������� � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���#e6f3ff.+�5      �� $��Quản lý độc giả ��6   $��50(�5      $
��Bold"�5      $��roboto)�5      ���#07209e$��Center=�5      $��Right=�5      5      � 5   
   ���#e6f3ff$��1��5       5       �� 5!      $
��auto �6    �� 5"      $��* �6    .+�5$      �� $��40,40,40,10q�6   ���#07209e$��2q�5&       �� CornerRadius$ 20��5'      ._�5(      � $��10q�6    5)      �� 5*      $��10 �6(   �� 5+      $
��auto �6(   �� 5,      $
��auto �6(   �� 5-      $
��auto �6(   �� 5.      $��10 �6(    � ColumnDefinitions 50      �� 51      $	��110 �6+   �� 52      $��* �6+   �� 53      $	��100 �6+   �� 54      $��* �6+   .+�57      �� $��Tên độc giả:��6       textblock:style1#��[  58      $��0��59      $��1��5:      $��5q�5;      $��Right=�5<      �� 5=      -   5         ��Name$ tentb��5=      $��1��5>      $��1��5?      $��5q�5@        textbox:style1#��[ 5A      ��5B      �� *TenDG+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5D      $��Email: ��6    #��[  5E      $��0��5F      $��2��5G      $��5q�5H      $��Right=�5I      �� 5J      -   5        $ emailtb��5J      $��1��5K      $��2��5L      #��[ 5M      $��5q�5N      ��5O      �� *Email+$ TwoWay=�$ PropertyChanged=��� 5P      $��CCCD: ��6    #��[  5Q      $��2��5R      $��1��5S      $��5q�5T      $��Right=�5U      �� 5V      -   5        $ cccdtb��5V      $��3��5W      $��1��5X      #��[ 5Y      $��5q�5Z      ��5[      �� *CCCD+$ TwoWay=�$ PropertyChanged=��� 5\      $��SDT: ��6    #��[  5]      $��2��5^      $��2��5_      $��5q�5`      $��Right=�5a      �� 5b      -   5        $ sdttb��5b      $��3��5c      $��2��5d      #��[ 5e      $��5q�5f      ��5g      �� *SDT+$ TwoWay=�$ PropertyChanged=�� 5h      $��3��6   $��0��5i      $��4��5j       5k      �� 5l      $
��auto �6/   �� 5m      $��10 �6/   �� 5n      $
��auto �6/   �� 5o      $��10 �6/   �� 5p      $
��auto �6/   �� 5q      $��* �6/   �� 5r      $
��auto �6/   �� 5s      $��10 �6/   �� 5t      $
��auto �6/   �� 5u      $��10 �6/   �� 5v      $
��auto �6/   .+�5x      �� -   5         ��Name$ addsach��5x   "   $��Thêm��5y      $��5q�5z        
button:add#���  5{      ��5|      �� *
AddCommand+�� 5}      -   5        $ editsach��5}   "   $��Sửa��5~      $��2��5      $��5q�5�        button:edit#���  5�      ��5�      �� *EditCommand+�� 5�      -   5        $ 
deletesach��5�   "   $
��Xóa��5�      $��4��5�      $��5q�5�        button:delete#���  5�      ��5�      �� *DeleteCommand+�� 5�      -   5        $ findsach��5�   "   $
��Tìm��5�      $��6��5�      $��5q�5�        button:find#���  5�      ��5�      �� *SearchCommand+�� 5�      -	   5        $ showsach��5�   "   $��Hiển thị��5�      $��8��5�      $��5q�5�        button:show#���  5�      ��5�      �� *ShowCommand+�� 5�      -
   5        $ 
exportsach��5�   "   $��Xuất file��5�      $��10��5�      $��5q�5�        button:export#���  5�      5�      5�      5�      5�      &   System.Windows.Controls.DataGrid  5�      -   5        	  Name$	 docgia��5�      
   AutoGenerateColumns
 .     
IsReadOnly . $��5q�5�      $��1��5�       �� SelectedItem 5�      �� *SelectedDocGia+$ OneWayToSource=���5�      �� *
DocGiaList+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã độc giả��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6=   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   �� *MaDG+  5�      $ Tên độc giả��6)   $ 3* 6>    6I   �� *TenDG+  5�      $ Email��6)   $ * 68    6B   �� *Email+  5�      $
 CCCD��6)   $ * 67    6A   �� *CCCD+  5�      $	 SDT��6)   $ * 66    6@   �� *SDT+5�      5�      5�      5�      