   M S B A M L   `   `   `  ����W  SLibraryManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel5LibraryManagementApplication.ViewModel.ClassViewModel  5      -    'LibraryManagementApplication.borrowinfo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      UlocalCclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel     5      $
��auto��5	      $
��auto��6     N� Title$  
borrowinfo��5
       � DataContext 5      L   FLibraryManagementApplication.ViewModel.ClassViewModel.DonMuonViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$
 sach��5      $��1��5      $��5q�5      ��5      �� 5       �� 
TargetType"  6    �� Triggers 5      �� 5       �� Binding 6&   �� *	IsChecked+ �� ElementName$ addSach�� �� Value True6Z   .a�5      �� 	 �� Property	 � y�
 �� Value$
 Visible=�6;   5      �� 5       6&   �� *	IsChecked+$ addSach��	 False6Z   .a�5      �� 	 � y�$
 	Collapsed=�6;   5      5          Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ Sách��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *
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
 matb��5E      $��1��5F      $��1��5G      $��2��5H        textbox:style1#��[ 5I      $��5q�5J      �� 5L      $��Mã nhân viên:��6   #��[  5M      $��0��5N      $��3��5O      $��2��5P      $
��Left=�5Q      $��8,0,0,0q�67   �� 5R      -   5        $ tennvtb��5R      $��2��5S      $��3��5T      #��[ 5U      $��5q�5V      �� 5W      $��Ngày mượn:��6   #��[  5X      $��0��5Y      $��4��5Z      $
��Left=�5[      $��9,0,0,0q�67   �� 5\      -   5        $ 
ngaymuontb��5\      $��2��5]      $��4��5^      #��[ 5_      $��5q�5`      �� 5b      $��Ngày trả dự kiến:��6   #��[  5c      $��0��5d      $��5��5e      $��2��5f      $��Center=�5g      �� 5h      -   5        $ ngaytradktb��5h      $��2��5i      $��5��5j      #��[ 5k      $��5q�5l      �� 5n      $��Ngày trả thực tế:��6   #��[  5o      $��0��5p      $��6��5q      $��2��5r      $
��Left=�5s      $��9,0,0,0q�67   �� 5t      -   5        $ ngaytratttb��5t      $��2��5u      $��6��5v      #��[ 5w      $��5q�5x      �� 5z      $��Phí phạt:��6   #��[  5{      $��7��5|      $
��Left=�5}      $��9,0,0,0q�67   �� 5~      -   5        $ 	phiphattb��5~      $��1��5      $��7��5�      $��2��5�      #��[ 5�      $��5q�5�      � 5�      $��8��6   $��0��5�      $��4��5�       5�      �� 5�      $
��auto �6+   �� 5�      $
��auto �6+   �� 5�      $
��auto �6+   �� 5�      $��10 �6+   �� 5�      $��* �6+   �� 5�      $
��auto �6+   �� 5�      $��10 �6+   �� 5�      $
��auto �6+   .+�5�      �� -   5         ��Name$ lenddon��5�      $��Trả��5�      $��2��5�      $��5q�5�        button:delete#���  5�      �� 5�      -	   5        $ finddon��5�      $
��Tìm��5�      $��5��5�      $��5q�5�        button:find#���  5�      ��5�      �� *SearchCommand+�� 5�      -
   5        $ showdon��5�      $��Hiển thị��5�      $��7��5�      $��5q�5�        button:show#���  5�      ��5�      �� *ShowCommand+5�      5�      5�      5�      5�      