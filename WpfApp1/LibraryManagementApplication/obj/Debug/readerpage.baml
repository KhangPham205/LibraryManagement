   M S B A M L   `   `   `  ����W  SLibraryManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel5LibraryManagementApplication.ViewModel.ClassViewModel  5      -    'LibraryManagementApplication.readerpage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      UlocalCclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel     5        N� Title$  
readerpage��5	       � DataContext 5
      K   ELibraryManagementApplication.ViewModel.ClassViewModel.DocGiaViewModel  5   
   .��5      � 
������� � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���#e6f3ff.+�5      �� $��Quản lý độc giả ��6   $��50(�5      $
��Bold"�5      $��roboto)�5      ���#07209e$��Center=�5      $��Right=�5      5      � 5   
   ���#e6f3ff$��1��5       5      �� 5      $
��auto �6    �� 5       $
��auto �6    $	��150��6.   �� 5!      $��* �6     � ColumnDefinitions 5#      �� 5$      $��3* �6#   �� 5%      $��* �6#   .+�5'      �� $��40,20,40,10q�6   ���#07209e$��2q�5)      $��Center=�5*       �� CornerRadius$ 20��5+      $��2��5,      ._�5-      � $��10q�6    5.      �� 5/      $��10 �6(   �� 50      $
��auto �6(   �� 51      $
��auto �6(   �� 52      $
��auto �6(   �� 53      $��10 �6(    55      �� 56      $	��110 �6+   �� 57      $	��300 �6+   �� 58      $	��100 �6+   �� 59      $	��300 �6+   .+�5<      �� $��Tên độc giả:��6       textblock:style1#��[  5=       $��0��5>       $��1��5?       $��5q�5@       $��Right=�5A       �� 5B      -   5         ��Name$ tentb��5B      $��1��5C      $��1��5D      $��5q�5E        textbox:style1#��[ 5F      ��5G      �� *TenDG+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5H      $��Email: ��6    #��[  5I       $��0��5J       $��2��5K       $��5q�5L       $��Right=�5M       �� 5N      -   5        $ emailtb��5N      $��1��5O      $��2��5P      #��[ 5Q      $��5q�5R      ��5S      �� *Email+$ TwoWay=�$ PropertyChanged=��� 5T      $��CCCD: ��6    #��[  5U       $��2��5V       $��1��5W       $��5q�5X       $��Right=�5Y       �� 5Z      -   5        $ cccdtb��5Z      $��3��5[      $��1��5\      #��[ 5]      $��5q�5^      ��5_      �� *CCCD+$ TwoWay=�$ PropertyChanged=��� 5`      $��SDT: ��6    #��[  5a       $��2��5b       $��2��5c       $��5q�5d       $��Right=�5e       �� 5f      -   5        $ sdttb��5f      $��3��5g      $��2��5h      #��[ 5i      $��5q�5j      ��5k      �� *SDT+$ TwoWay=�$ PropertyChanged=�� 5l      $��3��6   $��0��5m      $��4��5n       5o      �� 5p      $
��auto �6/   �� 5q      $��10 �6/   �� 5r      $
��auto �6/   �� 5s      $��10 �6/   �� 5t      $
��auto �6/   �� 5u      $��* �6/   �� 5v      $
��auto �6/   �� 5w      $��10 �6/   �� 5x      $
��auto �6/   �� 5y      $��10 �6/   �� 5z      $
��auto �6/   .+�5|      �� -   5         ��Name$ addtaikhoan��5|   "   $��Thêm DG��5}   "   $��5q�5~   "     
button:add#���  5   "   ��5�   "   �� *
AddCommand+�� 5�      -   5        $ history��5�   !   $��Lịch sử��5�   !   $��2��5�   !     button:history#��[ 5�   !   $y�	Collapsed=�5�   !   5�   !   �� 5�      -   5        $ findsach��5�   !   $��Tìm DG��5�   !   $��6��5�   !   $��5q�5�   !     button:find#���  5�   !   ��5�   !   �� *SearchCommand+�� 5�      -   5        $ showsach��5�   !   $��Hiển thị��5�   !   $��8��5�   !   $��5q�5�   !     button:show#���  5�   !   ��5�   !   �� *ShowCommand+5�   !   �� 5�      -	   5        $ 
exportsach��5�   !   $��Xuất file��5�   !   $��10��5�   !   $��5q�5�   !     button:export#���  5�   !   5�   !   5�      5�      5�      � 5�      -
   5        	 �Name$	 donmuongrid��5�      $��5q�6(   $��1��5�      $y�	Collapsed=�5�       5�      �� 5�      $
��auto �6$   �� 5�      $��* �6$   .+�5�      �� $��Sách��6   #��[  6(   &   System.Windows.Controls.DataGrid  5�      -   5        
  Name$
 datagridMuon��5�      $��1��5�       �� SelectedItem 5�      �� *SelectedDonMuon+$ TwoWay=�$ PropertyChanged=���5�      �� *DonMuonList+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã đơn mượn��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6B   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6L   �� *MaMuon+  5�      $ Mã độc giả��6-   $ * 6A    6K   �� *MaDG+  5�      $ Ngày mượn��6-   $ * 6@    6J   �� *
NgayMuon+ �� StringFormat$ 
dd/MM/yyyy��  5�      $ Ngày trả dự kiến��6-   $ * 6G    6Q   �� *	NgayTraDK+$ 
dd/MM/yyyy��  5�      $ Ngày trả thực tế��6-   $ * 6G    6Q   �� *	NgayTraTT+$ 
dd/MM/yyyy��  5�      $ Phí phạt (VND)��6-   $ * 6E    6O   �� *	PhiPhat+5�      5�      � 5�      -   5        $	 ctdmgrid��5�      $��1��6%   $��1��5�      $��5q�5�      $y�	Collapsed=�5�       5�      �� 5�      $
��auto �6$   �� 5�      $��* �6$   .+�5�      �� $��Chi tiết đơn mượn��6   #��[  65     5�      -   5        $

 sach��5�      $��1��5�      ��5�      �� *DanhSachMuon+$ TwoWay=�$ PropertyChanged=� 5�        5�      $ Sách��6-   $ * 6;    6E   �� *
TenDauSach+  5�      $
 IBSN��6-   $ * 6;    6E   �� *ISBN+5�      5�      � 5�      $��5q�6   $��2��5�      $��2��5�       5�      �� 5�      $
��auto �6$   �� 5�      $��* �6$   .+�5�      �� $��Độc giả��6   #��[  6+     5�      -   5        $
 docgia��5�         AutoGenerateColumns .     
IsReadOnly . $��1��5�       5�      �� *SelectedDocGia+$ OneWayToSource=���5�      �� *
DocGiaList+ 5�        5�      $ Mã độc giả��6-   $ * 6A    6K   �� *MaDG+  5�      $ Tên độc giả��6-   $ 3* 6B    6M   �� *TenDG+  5�      $ Email��6-   $ * 6<    6F   �� *Email+  5�      $
 CCCD��6-   $ * 6;    6E   �� *CCCD+  5�      $	 SDT��6-   $ * 6:    6D   �� *SDT+5�      5�      5�      5�      5�      