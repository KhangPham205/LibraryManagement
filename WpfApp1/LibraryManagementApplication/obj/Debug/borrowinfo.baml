   M S B A M L   `   `   `  ����W  SLibraryManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel5LibraryManagementApplication.ViewModel.ClassViewModel  5      -    'LibraryManagementApplication.borrowinfo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      UlocalCclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel     5      $
��auto��5	      $
��auto��6     N� Title$  
borrowinfo��5
       � DataContext 5      L   FLibraryManagementApplication.ViewModel.ClassViewModel.DonMuonViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$
 sach��5      $��1��5      $��5q�5      ��5      �� 5       �� 
TargetType"  6    �� Triggers 5      �� 5       �� Binding 6&   �� *	IsChecked+ �� ElementName$ addSach�� �� Value True6Z   .a�5      �� 	 �� Property	 � y�
 �� Value$
 Visible=�6;   5      �� 5       6&   �� *	IsChecked+$ addSach��	 False6Z   .a�5      �� 	 � y�$
 	Collapsed=�6;   5      5          Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ Sách��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *
TenDSach+  5$      $
 IBSN��6%   $ * 63    6=   �� *IBSN+5&      �� 5'   
   $��20,20,20,10q�6   ���#07209e$��2q�5)   
    �� CornerRadius$ 20��5*   
   ._�5+      � $��5q�6   $��0��5,       � RowDefinitions 5-      �� 5.      $��10 �6$   �� 5/      $
��auto �6$   �� 50      $
��auto �6$   �� 51      $
��auto �6$   �� 52      $
��auto �6$   �� 53      $
��auto �6$   �� 54      $
��auto �6$   �� 55      $
��auto �6$   �� 56      $
��auto �6$   �� 57      $
��auto �6$   �� 58      $��* �6$    5:      �� 5;      $	��110 �6'   �� 5<      $��50 �6'   �� 5=      $��2* �6'   .+�5?      �� $��Mã độc giả:��6      textblock:style1#��[  5@      $��0��5A      $��1��5B      $��5q�5C      $��Right=�5D      �� 5E      -   5         ��Name$
 matb��5E      $��1��5F      $��1��5G      $��2��5H        textbox:style1#��[ 5I      $��5q�5J       �� 
IsReadOnly . 5K      �� 5L      $��Tên độc giả:��6   #��[  5M      $��0��5N      $��2��5O      $��5q�5P      $��Right=�5Q      �� 5R      -   5        $ tentb��5R      $��1��5S      $��2��5T      $��2��5U      #��[ 5V      $��5q�5W       . 5X      �� 5Y      $��Tên nhân viên:��6   #��[  5Z      $��0��5[      $��3��5\      $��2��5]      $��5q�5^      $��Right=�5_      �� 5`      -   5        $ tennvtb��5`      $��2��5a      $��3��5b      #��[ 5c      $��5q�5d       . 5e      �� 5f      $��Ngày mượn:��6   #��[  5g      $��0��5h      $��4��5i      $��2��5j      $��5q�5k      $��Right=�5l      �� 5m      -   5        $ 
ngaymuontb��5m      $��2��5n      $��4��5o      #��[ 5p      $��5q�5q       . 5r      �� 5s      $��Ngày trả dự kiến:��6   #��[  5t      $��0��5u      $��5��5v      $��2��5w      $��5q�5x      $��Right=�5y      �� 5z      -   5        $ ngaytradktb��5z      $��2��5{      $��5��5|      #��[ 5}      $��5q�5~       . 5      �� 5�      $��Ngày trả thực tế:��6   #��[  5�      $��0��5�      $��6��5�      $��2��5�      $��5q�5�      $��Right=�5�      �� 5�      -   5        $ ngaytratttb��5�      $��2��5�      $��6��5�      #��[ 5�      $��5q�5�       . 5�      �� 5�      $��Phí phạt:��6   #��[  5�      $��0��5�      $��7��5�      $��5q�5�      $��Right=�5�      �� 5�      -   5        $ 	phiphattb��5�      $��1��5�      $��7��5�      $��2��5�      #��[ 5�      $��5q�5�       . 5�      �� 5�      -	   5         ��Name$ trabt��5�      $��Trả��5�        
button:add#��[ 5�      $��5q�5�      $��3��5�      $��8��5�      $��Right=�5�      5�      5�      5�      5�      