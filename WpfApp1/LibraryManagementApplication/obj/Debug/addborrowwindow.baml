   M S B A M L   `   `   `  ����W  SLibraryManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel5LibraryManagementApplication.ViewModel.ClassViewModel  5   	   2    ,LibraryManagementApplication.addborrowwindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   UlocalCclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel     5   	   $
��auto��5   	   $	��950��6     � 
ResizeMode$  NoResize=�5	   	    � Icon$ /Icon/book (1).png��5
   	    � DataContext 5      I   CLibraryManagementApplication.ViewModel.ClassViewModel.CTDMViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��2��6    �� CornerRadius$ 	0,0,20,20��5      ���#9acbff._�5      �� $��Thêm đơn mượn��6   $��50(�5      $
��Bold"�5      $��roboto)�5       ���#07209e$��Center=�5"      $��	0,10,0,10q�5#      5$      �� 5%   
   -   5         ��Name$ 	okeButton��5%      $��OK��5&      $��5q�5'      $��3��5(      $��1��5)      $��Right=�5*      $��Bottom=�5+         
button:add#���   5,      ��5-      �� *CreateCommand+5.      �� 5/   
   $��20,20,20,10q�6   ���#07209e$��2q�51      $��1��52      $ 20��53      ._�54      � $��5q�6   $��0��55       56      �� 57      $��10 �6$   �� 58      $
��auto �6$   �� 59      $
��auto �6$   �� 5:      $��* �6$    5<      �� 5=      $	��110 �6'   �� 5>      $��2* �6'   .+�5@      �� $��Mã độc giả:��6     textblock:style1#��[ 5A      $��0��5B      $��1��5C      $��5q�5D      $��Right=�5E      �� 5F      -   5         ��Name$ tendg��5F      $��1��5G      $��1��5H      $��4��5I        combobox:style1#��[ 5J      $��5q�5L       �� SelectedItem 5K      �� *MaDG+	 �� Text	 5M      �� *MaDG+� 5N      $��2��6   $��2��6$    5O      �� 5P      $
��auto �6+   �� 5Q      $
��auto �6+   �� 5R      $��* �6+   �� 5S      $��* �6+   5U      5V      5W      �� 5X   
   $��20,20,20,10q�6   ���#07209e$��2q�5Z      $ 20��5[      $��2��5\      ._�5]      � -   5        
 �Name$
 themsach��5]      $��5q�5^       5_      �� 5`      $��10 �6$   �� 5a      $
��auto �6$   �� 5b      $
��auto �6$   �� 5c      $��* �6$    5e      �� 5f      $	��110 �6'   �� 5g      $��2* �6'   �� 5h      $��* �6'   �� 5i      $��* �6'   .+�5k      �� $��Tên sách:��6   #��[ 5l      $��0��5m      $��1��5n      $��5q�5o      $��Right=�5p      �� 5q      -   5        $ 	tensachtb��5q      $��1��5r      $��1��5s      $��3��5t      #��[ 5u      $��5q�5w      	 5x      �� *
TenDauSach+�� 5y      $��ISBN: ��6   #��[ 5z      $��0��5{      $��2��5|      $��5q�5}      $��Right=�5~      �� 5      -   5        $
 isbn��5      $��1��5�      $��2��5�      #��[ 5�      $��5q�5�      	 5�      �� *ISBN+�� 5�      -   5        $ addsach��5�      $��Thêm sách��5�      $��5q�5�      $��2��5�      $��2��5�      #���   5�      ��5�      �� *
AddCommand+�� 5�      -   5        $ 
deletesach��5�      $��
Xóa sách��5�      $��5q�5�      $��3��5�      $��2��5�        button:delete#���  5�      ��5�      �� *DeleteCommand+5�      5�      � 5�   
   $��1��6   $��1��5�      $��2��5�      $��5q�5�       5�      �� 5�      $
��auto �6    �� 5�      $��* �6    .+�5�      �� $��Chi tiết đơn mượn��6   #��[ 61   &   System.Windows.Controls.DataGrid  5�      -   5          Name$ sachlist��5�      $��1��5�       5�      �� *SelectedBorrowedBook+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���5�      �� *DanhSachMuon+$ TwoWay=�$ PropertyChanged=�   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Sách��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *
TenDauSach+  5�      $
 ISBN��6)   $ * 67    6A   �� *ISBN+5�      5�      5�      5�      