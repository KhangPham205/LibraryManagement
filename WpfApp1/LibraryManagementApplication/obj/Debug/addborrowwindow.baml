   M S B A M L   `   `   `  ����W  SLibraryManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel5LibraryManagementApplication.ViewModel.ClassViewModel  5   	   2    ,LibraryManagementApplication.addborrowwindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   UlocalCclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel     5   	     � Title$  addborrowwindow��5   	   $	��450��6!   $	��950��6.    � 
ResizeMode$ NoResize=�5	   	    � DataContext 5
      I   CLibraryManagementApplication.ViewModel.ClassViewModel.CTDMViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��2��6    �� CornerRadius$ 	0,0,20,20��5      ���#9acbff._�5      �� $��Thêm đơn mượn��6   $��50(�5      $
��Bold"�5      $��roboto)�5      ���#07209e$��Center=�5!      $��	0,10,0,10q�5"      5#      �� 5$   
   -   5         ��Name$ 	okeButton��5$      $��OK��5%      $��5q�5&      $��3��5'      $��1��5(      $��Right=�5)      $��Bottom=�5*         
button:add#���   5+      ��5,      �� *CreateCommand+5-      �� 5.   
   $��20,20,20,10q�6   ���#07209e$��2q�50      $��1��51      $ 20��52      ._�53      � $��5q�6   $��0��54       55      �� 56      $��10 �6$   �� 57      $
��auto �6$   �� 58      $
��auto �6$   �� 59      $��* �6$    5;      �� 5<      $	��110 �6'   �� 5=      $��2* �6'   .+�5?      �� $��Mã độc giả:��6     textblock:style1#��[ 5@      $��0��5A      $��1��5B      $��5q�5C      $��Right=�5D      �� 5E      -   5         ��Name$ tendg��5E      $��1��5F      $��1��5G      $��4��5H        combobox:style1#��[ 5I      $��5q�5K       �� SelectedItem 5J      �� *MaDG+	 �� Text	 5L      �� *MaDG+� 5M      $��2��6   $��2��6$    5N      �� 5O      $
��auto �6+   �� 5P      $
��auto �6+   �� 5Q      $��* �6+   �� 5R      $��* �6+   5T      5U      5V      �� 5W   
   $��20,20,20,10q�6   ���#07209e$��2q�5Y      $ 20��5Z      $��2��5[      ._�5\      � -   5        
 �Name$
 themsach��5\      $��5q�5]       5^      �� 5_      $��10 �6$   �� 5`      $
��auto �6$   �� 5a      $
��auto �6$   �� 5b      $��* �6$    5d      �� 5e      $	��110 �6'   �� 5f      $��2* �6'   �� 5g      $��* �6'   �� 5h      $��* �6'   .+�5j      �� $��Tên sách:��6   #��[ 5k      $��0��5l      $��1��5m      $��5q�5n      $��Right=�5o      �� 5p      -   5        $ 	tensachtb��5p      $��1��5q      $��1��5r      $��3��5s      #��[ 5t      $��5q�5v      	 5w      �� *
TenDauSach+�� 5x      $��ISBN: ��6   #��[ 5y      $��0��5z      $��2��5{      $��5q�5|      $��Right=�5}      �� 5~      -   5        $
 isbn��5~      $��1��5      $��2��5�      #��[ 5�      $��5q�5�      	 5�      �� *ISBN+�� 5�      -   5        $ addsach��5�      $��Thêm sách��5�      $��5q�5�      $��2��5�      $��2��5�      #���   5�      ��5�      �� *
AddCommand+�� 5�      -   5        $ 
deletesach��5�      $��
Xóa sách��5�      $��5q�5�      $��3��5�      $��2��5�        button:delete#���  5�      ��5�      �� *DeleteCommand+5�      5�      &   System.Windows.Controls.DataGrid  5�   
   -   5          Name$ sachlist��5�      $��1��5�      $��1��5�      $��2��5�      $��5q�5�       5�      �� *SelectedBorrowedBook+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���5�      �� *DanhSachMuon+$ TwoWay=�$ PropertyChanged=�   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Sách��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *
TenDauSach+  5�      $
 ISBN��6%   $ * 63    6=   �� *ISBN+5�      5�      5�      