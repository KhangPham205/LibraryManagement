   M S B A M L   `   `   `  ����W  SLibraryManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel5LibraryManagementApplication.ViewModel.ClassViewModel  5      -    'LibraryManagementApplication.SignUpPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      UlocalCclr-namespace:LibraryManagementApplication.ViewModel.ClassViewModel     5      $
��auto��5      $
��auto��6     N� Title$  
SignInPage��5	       � DataContext 5
      M   GLibraryManagementApplication.ViewModel.ClassViewModel.TaiKhoanViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��
Đăng Ký��6   $��50(�5   	   $
��Bold"�5   	   $��roboto)�5   	   ���#07209e$��Center=�5   	   $��	0,10,0,10q�5   	   � 5   
   $��1��5   
   $��	10,0,10,0q�5   
    � ColumnDefinitions 5      �� 5      �� 5      $	��160 �6#   �� 5      $	��300 �6#   �� 5        5"      �� 5#      $��* �6    �� 5$      $��50 �6    �� 5%      $��50 �6    �� 5&      $��50 �6    �� 5'      $��50 �6    �� 5(      $��50 �6    �� 5)      $��40 �6    �� 5*      $��* �6    .+�5,      ��    textblock:style1#��[  6   $��1��5-   
   $��1��5.   
   $��Tên người dùng:��5/   
   $��10q�50   
   $��Right=�51   
   �� 52      #��[  6   $��2��53   
   $��1��54   
   $��Mật khẩu: ��55   
   ���#07209e$��18(�57   
   $��10q�58   
   $��Right=�59   
   �� 5:      #��[  6   $��3��5;   
   $��1��5<   
   $��Email:��5=   
   $��10q�5>   
   $��Right=�5?   
   �� 5@      #��[  6   $��4��5A   
   $��1��5B   
   $��Số điện thoại:��5C   
   $��10q�5D   
   $��Right=�5E   
   �� 5F      #��[  6   $��5��5G   
   $��1��5H   
   $��CCCD:��5I   
   $��10q�5J   
   $��Right=�5K   
   �� 5L      -   5         ��Name$ username��5L        textbox:style1#��[ 5M      $��2��5N      $��1��5O      ��5P      �� *
UserName+�� 5R      -   5        $ password��5R      #��[ 5S      $��2��5T      $��2��5U      ��5V      �� *
Password+�� 5W      -   5        $ email��5W      #��[ 5X      $��2��5Y      $��3��5Z      ��5[      �� *Email+�� 5\      -   5        $	 sdt��5\      #��[ 5]      $��2��5^      $��4��5_      ��5`      �� *SDT+�� 5a      -   5        $
 cccd��5a      #��[ 5b      $��2��5c      $��5��5d      ��5e      �� *CCCD+�� 5g      -   5         ��Name$ signup��5g      $��
Đăng ký��5h        button:style1#��[ 5i      $	��300��5j      $��2��5k      $��6��5l      $��Right=�5m      ��5n      �� *
AddCommand+��5p      ��  �� ElementName$ signUpWindow��5q      5r      5s      5t      