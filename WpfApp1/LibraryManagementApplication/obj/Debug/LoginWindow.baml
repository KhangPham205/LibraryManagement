   M S B A M L   `   `   `  ����W  SLibraryManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:LibraryManagementApplication.ViewModel&LibraryManagementApplication.ViewModel  5   	   .    (LibraryManagementApplication.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:LibraryManagementApplication.ViewModel     5   	   X TFontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   $	��500��5	   	   $	��800��6   $	��500��5
   	   $	��800��6     � WindowStartupLocation$  CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	    � Icon$ /Icon/book (1).png��5   	    � DataContext 5      ;   5LibraryManagementApplication.ViewModel.LoginViewModel  5   
   .��5      � ���#e6f3ff � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6   .+�5   
   ��  �� CornerRadius$ 	0,20,20,0��5      ���#9acbff._�5      �� $��10q�6   $��Center=�6%   .+�5      �� $��/Icon/book (1).png��6   $��10q�64   �� 5      $)��#Ứng dụng quản lý thư viện��6   $
��Wrap=�5       �� TextAlignment$ Center=�5      $��30(�5      $
��Bold"�5         textblock:style1#��[  5       5!      5"      �� 5#   
   $��/icon/bannerbook.jpg��6   $��1��5$   	   $��Uniform=�5%   	   $��Bottom=�5&   	   $��Center=�5'   	    J� Opacity$	 0.3Q�5(   	    K� ZIndex$ -1��5)   	   � 5*   
   $��1��6   $
��auto��6   $��Center=�6-    5+      �� 5,      $��* �6#   �� 5-      $��* �6#   �� 5.      $��* �6#   	 � RowDefinitions	 50      �� 51      $��* �6    �� 52      $
��auto �6    .+�54       � -   5        
  �Name$
 
loginframe��54      $��10q�6(   $��3��55        � NavigationUIVisibility$ Hidden=�56      �� 57      -   5         ��Name$ forgot��57      ���#07209e
������ $��Medium"�5:      $��1��5;      $��1��5<      $��Center=�5=      $��13(�5>      $��10q�5?      �� 5@      -   5         � Cursor$
 Hand��5B       �� Command 5@      �� *RecoverCommand+ �� CommandParameter 5A      ��  �� ElementName$ 
loginframe��.�5C   4   Quên mật khẩu?5E      5F      �� 5G      -   5        $ singin��5G      ���#07209e
������ $��Medium"�5J      $��1��5K      $��1��5L      $y�	Collapsed=�5M      $��Center=�5N      $��13(�5O      $��10q�5P      �� 5Q      -   5        $
 Hand��5S       5Q      �� *LoginPageCommand+ 5R      �� $ 
loginframe��.�5T   *   Đăng nhập5V      5W      5X      5Y      5Z      