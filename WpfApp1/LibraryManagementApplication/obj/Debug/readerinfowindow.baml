   M S B A M L   `   `   `  ����W  SLibraryManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel5LibraryManagementApplication.ViewModel.ClassViewModel  5   	   3    -LibraryManagementApplication.readerinfowindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   UlocalCclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel     5   	   $	��700��5   	   $
��1000��6     � WindowStartupLocation$  CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � Icon$ /Icon/book (1).png��5   	    � DataContext 5      K   ELibraryManagementApplication.ViewModel.ClassViewModel.DocGiaViewModel  5   
   .��5      � ���#e6f3ff � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   ��  �� CornerRadius$ 	0,0,20,20��6   ���#9acbff._�5      �� $��Thông tin độc giả��6   $��50(�5      $
��Bold"�5      $��roboto)�5      ���#07209e$��Center=�5      $��	0,10,0,10q�5      5      � 5   
   $��1��6    5      �� 5       $
��auto �6    �� 5!      $��* �6     � ColumnDefinitions 5#      �� 5$      $��6* �6#   �� 5%      $��5* �6#   .+�5'      �� $��40,20,40,10q�6   ���#07209e$��2q�5)      $��Center=�5*      $ 20��5+      ._�5,      � $��10q�6    5-      �� 5.      $��10 �6(   �� 5/      $
��auto �6(   �� 50      $
��auto �6(   �� 51      $
��auto �6(   �� 52      $
��auto �6(   �� 53      $
��auto �6(   �� 54      $��10 �6(    56      �� 57      $	��110 �6+   �� 58      $	��300 �6+   .+�5;      �� $��Tên độc giả:��6       textblock:style1#��[  5<       $��0��5=       $��1��5>       $��5q�5?       $��Right=�5@       �� 5A      -   5         ��Name$ tentb��5A      $��1��5B      $��1��5C      $��5q�5D        textbox:style1#��[ 5E      ��5F      �� *TenDG+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=��� 5G      $��Email: ��6    #��[  5H       $��0��5I       $��2��5J       $��5q�5K       $��Right=�5L       �� 5M      -   5        $ emailtb��5M      $��1��5N      $��2��5O      #��[ 5P      $��5q�5Q      ��5R      �� *Email+$ TwoWay=�$	 PropertyChanged=��� 5S      $��CCCD: ��6    #��[  5T       $��0��5U       $��3��5V       $��5q�5W       $��Right=�5X       �� 5Y      -   5        $ cccdtb��5Y      $��1��5Z      $��3��5[      #��[ 5\      $��5q�5]      ��5^      �� *CCCD+$ TwoWay=�$	 PropertyChanged=��� 5_      $��SDT: ��6    #��[  5`       $��0��5a       $��4��5b       $��5q�5c       $��Right=�5d       �� 5e      -   5        $ sdttb��5e      $��1��5f      $��4��5g      #��[ 5h      $��5q�5i      ��5j      �� *SDT+$ TwoWay=�$	 PropertyChanged=�� 5k      $��5��6   $��0��5l      $��2��5m       5n      �� 5o      $
��auto �6/   �� 5p      $��10 �6/   �� 5q      $
��auto �6/   �� 5r      $��10 �6/   �� 5s      $
��auto �6/   �� 5t      $��* �6/   �� 5u      $
��auto �6/   �� 5v      $��10 �6/   �� 5w      $
��auto �6/   �� 5x      $��10 �6/   �� 5y      $
��auto �6/   .+�5{      �� -   5        
 ��Name$
 editsach��5{   !   $��Sửa DG��5|   !   $��2��5}   !   $��5q�5~   !     button:edit#���  5   !   ��5�   !   �� *EditCommand+�� 5�      -   5        $
 
deletesach��5�   !   $��Xóa DG��5�   !   $��4��5�   !   $��5q�5�   !     button:delete#���  5�   !   ��5�   !   �� *DeleteCommand+5�      5�      5�      � 5�      -   5         �Name$ donmuongrid��5�      $��5q�6(   $��2��5�      $��1��5�       5�      �� 5�      $
��auto �6$   �� 5�      $��* �6$   .+�5�      �� $��Lịch sử đơn mượn��6   #��[  64   &   System.Windows.Controls.DataGrid  5�      -   5          Name$ datagridMuon��5�      $��1��5�       �� SelectedItem 5�      �� *SelectedDonMuon+$ TwoWay=�$	 PropertyChanged=���5�      �� *DonMuonList+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã đơn mượn��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6B   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6L   �� *MaMuon+  5�      $ Mã độc giả��6-   $ * 6A    6K   �� *MaDG+  5�      $ Ngày mượn��6-   $ * 6@    6J   �� *
NgayMuon+ �� StringFormat$ 
dd/MM/yyyy��  5�      $ Ngày trả dự kiến��6-   $ * 6G    6Q   �� *	NgayTraDK+$ 
dd/MM/yyyy��  5�      $ Ngày trả thực tế��6-   $ * 6G    6Q   �� *	NgayTraTT+$ 
dd/MM/yyyy��  5�      $ Phí phạt (VND)��6-   $ * 6E    6O   �� *	PhiPhat+5�      5�      � 5�      -	   5        $ ctdmgrid��5�      $��0��6%   $��1��5�      $��5q�5�       5�      �� 5�      $
��auto �6$   �� 5�      $��* �6$   .+�5�      �� $��Chi tiết đơn mượn��6   #��[  65     5�      -
   5        $
 sach��5�      $��1��5�      ��5�      �� *DanhSachMuon+$ TwoWay=�$	 PropertyChanged=� 5�        5�      $ Sách��6-   $ * 6;    6E   �� *
TenDauSach+  5�      $
 IBSN��6-   $ * 6;    6E   �� *ISBN+5�      5�      5�      5�      5�      