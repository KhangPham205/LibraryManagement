   M S B A M L   `   `   `  ����W  SLibraryManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel5LibraryManagementApplication.ViewModel.ClassViewModel  5   	   5    /LibraryManagementApplication.employeeinfowindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   UlocalCclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel     5   	   $	��700��5   	   $
��1000��6     � WindowStartupLocation$  CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � Icon$ /Icon/book (1).png��5   	    � DataContext 5      M   GLibraryManagementApplication.ViewModel.ClassViewModel.TaiKhoanViewModel  5   
   .��5      � ���#e6f3ff � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   ��  �� CornerRadius$ 	0,0,20,20��6   ���#9acbff._�5      �� $��Thông tin nhân viên��6   $��50(�5      $
��Bold"�5      $��roboto)�5      ���#07209e$��Center=�5      $��	0,10,0,10q�5      5      � 5   
   $��1��6    5      �� 5       $
��auto �6    �� 5!      $��* �6     � ColumnDefinitions 5#      �� 5$      $��6* �6#   �� 5%      $��5* �6#   .+�5'      �� $��40,20,40,10q�6   ���#07209e$��2q�5)      $��Center=�5*      $ 20��5+      ._�5,      � $��10q�6    5-      �� 5.      $��10 �6(   �� 5/      $
��auto �6(   �� 50      $
��auto �6(   �� 51      $
��auto �6(   �� 52      $
��auto �6(   �� 53      $
��auto �6(   �� 54      $
��auto �6(   �� 55      $��10 �6(    57      �� 58      $	��130 �6+   �� 59      $	��300 �6+   .+�5<      �� $��Tên nhân viên:��6       textblock:style1#��[  5=       $��0��5>       $��1��5?       $��5q�5@       $��Right=�5A       �� 5B      -   5         ��Name$ tentb��5B      $��1��5C      $��1��5D      $��5q�5E        textbox:style1#��[ 5F      ��5G      �� *
UserName+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=��� 5H      $��Email: ��6    #��[  5I       $��0��5J       $��2��5K       $��5q�5L       $��Right=�5M       �� 5N      -   5        $ emailtb��5N      $��1��5O      $��2��5P      #��[ 5Q      $��5q�5R      ��5S      �� *Email+$ TwoWay=�$	 PropertyChanged=��� 5T      $��CCCD: ��6    #��[  5U       $��0��5V       $��3��5W       $��5q�5X       $��Right=�5Y       �� 5Z      -   5        $ cccdtb��5Z      $��1��5[      $��3��5\      #��[ 5]      $��5q�5^      ��5_      �� *CCCD+$ TwoWay=�$	 PropertyChanged=��� 5`      $��SDT: ��6    #��[  5a       $��0��5b       $��4��5c       $��5q�5d       $��Right=�5e       �� 5f      -   5        $ sdttb��5f      $��1��5g      $��4��5h      #��[ 5i      $��5q�5j      ��5k      �� *SDT+$ TwoWay=�$	 PropertyChanged=�� 5l      $��5��6   $��0��5m      $��2��5n       5o      �� 5p      $
��auto �6/   �� 5q      $��10 �6/   �� 5r      $
��auto �6/   �� 5s      $��10 �6/   �� 5t      $
��auto �6/   �� 5u      $��* �6/   �� 5v      $
��auto �6/   �� 5w      $��10 �6/   �� 5x      $
��auto �6/   �� 5y      $��10 �6/   �� 5z      $
��auto �6/   .+�5|      �� -   5        
 ��Name$
 editsach��5|   !   $��Sửa��5}   !   $��2��5~   !   $��5q�5   !     button:edit#���  5�   !   ��5�   !   �� *EditCommand+�� 5�      -   5        $
 
deletesach��5�   !   $
��Xóa��5�   !   $��4��5�   !   $��5q�5�   !     button:delete#���  5�   !   ��5�   !   �� *DeleteCommand+5�      5�      5�      � 5�      -   5         �Name$ donmuongrid��5�      $��5q�6(   $��2��5�      $��1��5�       5�      �� 5�      $
��auto �6$   �� 5�      $��* �6$   .+�5�      �� $,��&Lịch sử phụ trách đơn mượn��6   #��[  6>   &   System.Windows.Controls.DataGrid  5�      -   5          Name$ datagridMuon��5�      $��1��5�       �� SelectedItem 5�      �� *SelectedDonMuon+$ TwoWay=�$	 PropertyChanged=���5�      �� *DonMuonList+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã đơn mượn��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6B   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6L   �� *MaMuon+  5�      $ Mã độc giả��6-   $ * 6A    6K   �� *MaDG+  5�      $ Ngày mượn��6-   $ * 6@    6J   �� *
NgayMuon+ �� StringFormat$ 
dd/MM/yyyy��  5�      $ Ngày trả dự kiến��6-   $ * 6G    6Q   �� *	NgayTraDK+$ 
dd/MM/yyyy��  5�      $ Ngày trả thực tế��6-   $ * 6G    6Q   �� *	NgayTraTT+$ 
dd/MM/yyyy��  5�      $ Phí phạt (VND)��6-   $ * 6E    6O   �� *	PhiPhat+5�      5�      � 5�      -	   5        $ ctdmgrid��5�      $��0��6%   $��1��5�      $��5q�5�       5�      �� 5�      $
��auto �6$   �� 5�      $��* �6$   .+�5�      �� $��Chi tiết đơn mượn��6   #��[  65     5�      -
   5        $
 sach��5�      $��1��5�      ��5�      �� *DanhSachMuon+$ TwoWay=�$	 PropertyChanged=� 5�        5�      $ Sách��6-   $ * 6;    6E   �� *
TenDauSach+  5�      $
 IBSN��6-   $ * 6;    6E   �� *ISBN+5�      5�      5�      5�      5�      