   M S B A M L   `   `   `  ����W  SLibraryManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel5LibraryManagementApplication.ViewModel.ClassViewModel  5      ,    &LibraryManagementApplication.addborrow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      UlocalCclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel     5      $
��auto��5	      $
��auto��6     N� Title$  	addborrow��5
       � DataContext 5      L   FLibraryManagementApplication.ViewModel.ClassViewModel.DonMuonViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��20,20,20,10q�6   ���#07209e$��2q�5       �� CornerRadius$ 20��5      ._�5      � $��5q�6   $��0��5       5      �� 5      $��10 �6$   �� 5       $
��auto �6$   �� 5!      $
��auto �6$   �� 5"      $��* �6$    5$      �� 5%      $	��110 �6'   �� 5&      $��2* �6'   .+�5(      �� $��Mã độc giả:��6      textblock:style1#��[  5)      $��0��5*      $��1��5+      $��5q�5,      $��Right=�5-      �� 5.      -   5         ��Name$ tentb��5.      $��1��5/      $��1��50      $��4��51        combobox:style1#��[ 52      $��5q�53      � 54      $��2��6   $��2��6$    55      �� 56      $��* �6+   �� 57      $��* �6+   �� 58      $��* �6+   �� 59      $��* �6+   .+�5;      �� -   5         ��Name$ adddon��5;      $��Tạo��5<      $��5q�5=      $��0��5>        
button:add#���  5?      	� 5@      -   5         	�Name$ addSach��5@   #   $��Thêm��5A      $��5q�5B      $��1��5C        rbutton:edit#���  5D      �� 5E      -   5        $ 	deletedon��5E      $
��Xóa��5F      $��5q�5G      $��3��5H        button:delete#���  5I      5J      5K      5L      �� 5M   
   $��20,20,20,10q�6   ���#07209e$��2q�5O      $ 20��5P      $��1��5Q      ��5R      �� 5S       �� 
TargetType" ��6   	 �� Triggers	 5T      �� 5U      
 �� Binding
 6&   �� *	IsChecked+ �� ElementName$ addSach�� �� Value True6Z   .a�5V      ��  �� Property � y� �� Value$ Visible=�6;   5W      �� 5X      
 6&   �� *	IsChecked+$ addSach��	 False6Z   .a�5Y      ��  � y�$ 	Collapsed=�6;   5Z      5\      ._�5^      � -   5         �Name$ themsach��5^      $��5q�5_       5`      �� 5a      $��10 �6$   �� 5b      $
��auto �6$   �� 5c      $
��auto �6$   �� 5d      $��* �6$    5f      �� 5g      $	��110 �6'   �� 5h      $��2* �6'   �� 5i      $��* �6'   �� 5j      $��* �6'   .+�5l      �� $��Tên sách:��6   #��[  5m      $��0��5n      $��1��5o      $��5q�5p      $��Right=�5q      �� 5r      -   5        $ 	tensachtb��5r      $��1��5s      $��1��5t      $��3��5u      #��[ 5v      $��5q�5w      �� 5x      $��ISBN: ��6   #��[  5y      $��0��5z      $��2��5{      $��5q�5|      $��Right=�5}      �� 5~      -   5        $
 isbn��5~      $��1��5      $��2��5�      #��[ 5�      $��5q�5�      �� 5�      -   5        $ addsach��5�      $��Thêm��5�      $��5q�5�      $��2��5�      $��2��5�      #���  5�      �� 5�      -	   5        $ 
deletesach��5�      $
��Xóa��5�      $��5q�5�      $��3��5�      $��2��5�      #���  5�      5�      5�      &   System.Windows.Controls.DataGrid  5�   
   -
   5          Name$
 sach��5�      $��1��5�      $��2��5�      $��5q�5�      ��5�      �� 5�      "  6   	 5�      �� 5�      
 6&   �� *	IsChecked+$ addSach�� True6Z   .a�5�      ��  � y�$ Visible=�6;   5�      �� 5�      
 6&   �� *	IsChecked+$ addSach��	 False6Z   .a�5�      ��  � y�$ 	Collapsed=�6;   5�      5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Sách��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *
TenDSach+  5�      $
 IBSN��6%   $ * 63    6=   �� *IBSN+5�      5�      5�      