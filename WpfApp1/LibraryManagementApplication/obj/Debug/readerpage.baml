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
��auto �6(   �� 5.      $��10 �6(    � ColumnDefinitions 50      �� 51      $	��110 �6+   �� 52      $��* �6+   �� 53      $	��100 �6+   �� 54      $��* �6+   .+�57      �� $��Tên độc giả:��6       textblock:style1#��[  58      $��0��59      $��1��5:      $��5q�5;      $��Right=�5<      �� 5=      -   5         ��Name$ tentb��5=      $��1��5>      $��1��5?      $��5q�5@        textbox:style1#��[ 5A      �� 5C      $��Email: ��6    #��[  5D      $��0��5E      $��2��5F      $��5q�5G      $��Right=�5H      �� 5I      -   5        $ emailtb��5I      $��1��5J      $��2��5K      #��[ 5L      $��5q�5M      �� 5N      $��CCCD: ��6    #��[  5O      $��2��5P      $��1��5Q      $��5q�5R      $��Right=�5S      �� 5T      -   5        $ cccdtb��5T      $��3��5U      $��1��5V      #��[ 5W      $��5q�5X      �� 5Y      $��SDT: ��6    #��[  5Z      $��2��5[      $��2��5\      $��5q�5]      $��Right=�5^      �� 5_      -   5        $ sdttb��5_      $��3��5`      $��2��5a      #��[ 5b      $��5q�5c      � 5d      $��3��6   $��0��5e      $��4��5f       5g      �� 5h      $
��auto �6/   �� 5i      $��10 �6/   �� 5j      $
��auto �6/   �� 5k      $��10 �6/   �� 5l      $
��auto �6/   �� 5m      $��* �6/   �� 5n      $
��auto �6/   �� 5o      $��10 �6/   �� 5p      $
��auto �6/   .+�5r      �� -   5         ��Name$ adddg��5r   "   $��Thêm��5s   "   $��5q�5t   "     
button:add#���  5u   "   ��5v   "   �� *
AddCommand+�� 5w      -   5        $ editdg��5w   "   $��Sửa��5x   "   $��2��5y   "   $��5q�5z   "     button:edit#���  5{   "   ��5|   "   �� *EditCommand+��5}   "   ��  �� ElementName$ tentb���� 5~      -   5        $ deletedg��5~   "   $
��Xóa��5   "   $��4��5�   "   $��5q�5�   "     button:delete#���  5�   "   ��5�   "   �� *DeleteCommand+�� 5�      -   5        $ finddg��5�   "   $
��Tìm��5�   "   $��6��5�   "   $��5q�5�   "     button:find#���  5�   "   ��5�   "   �� *SearchCommand+�� 5�      -	   5        $ showdg��5�   "   $��Hiển thị��5�   "   $��8��5�   "   $��5q�5�   "     button:show#���  5�   "   ��5�   "   �� *ShowCommand+5�      5�      5�      &   System.Windows.Controls.DataGrid  5�      -
   5          Name$
 sach��5�      	   AutoGenerateColumns	 .  
   
IsReadOnly
 . $��5q�5�      $��1��5�      ��5�      �� *
DocGiaList+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã độc giả��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6=   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   �� *MaDG+  5�      $ Tên độc giả��6)   $ 3* 6>    6I   �� *TenDG+  5�      $ Email��6)   $ * 68    6B   �� *Email+  5�      $
 CCCD��6)   $ * 67    6A   �� *CCCD+  5�      $	 SDT��6)   $ * 66    6@   �� *SDT+5�      5�      5�      5�      