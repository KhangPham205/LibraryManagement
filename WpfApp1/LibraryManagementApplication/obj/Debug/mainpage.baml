   M S B A M L   `   `   `  ����W  SLibraryManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:LibraryManagementApplicationLibraryManagementApplication  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5      +    %LibraryManagementApplication.mainpage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:LibraryManagementApplication     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5      .��5
      � 
�������  � RowDefinitions  5   
   �� 5      $��70 �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���#e6f3ff.+�5      �� $��Trang chủ ��6   $��50(�5      $
��Bold"�5      $��roboto)�5      ���#07209e$��Center=�5      $��Right=�5      5      � 5   
   $��1��6   ���#e6f3ff  5      �� 5      $
��auto �6    �� 5      $	��300 �6    �� 5      $��* �6     � ColumnDefinitions 5!      �� 5"      $��* �6#   �� 5#      $	��400 �6#   .+�5%      � $��5q�6    5&      �� 5'      $
��auto �6'   �� 5(      $��10 �6'   �� 5)      $
��auto �6'   �� 5*      $��* �6'   �� 5+      $
��auto �6'   .+�5-      �� $��5q�6    �� Orientation$ 
Horizontal=�6(   .+�5.      �� $��Ngày bắt đầu: ��6       textblock:style1#��[  5/       (  "System.Windows.Controls.DatePicker  50      -   5          Name$ 	startdate��50   !     datepick:style1#��[ 51   !      SelectedDate 52   !   �� *start+53      �� 54      $��2��6   $��5q�6-   $ 
Horizontal=�68   .+�55      �� $��Ngày kết thúc: ��6    #��[  56        57      -   5        $ enddate��57   !   #��[ 58       59      �� *start+5:      �� 5;      -   5         ��Name$
 show��5;      $��4��5<      $��Hiển thị��5=        button:find#��[ 5>      ��5?      �� *ShowCommand+5@      �� 5A      $��1��6   $��2��5B       �� CornerRadius$ 30��5C      ���#9acbff J� Opacity$	 0.3Q�5E      $��10q�5F      � 5H       K� ZIndex$ 1��6   $��1��5I      $��2��5J      $��10q�5K        5M      �� 5N      $
��auto �6(   �� 5O      $��* �6(   .+�5Q      �� $%��Thống kê tình trạng sách��6    $��5q�5R       $��Center=�5S       #��[  5T         LiveCharts.Wpf.PieChart  5U      &   LiveCharts.Wpf.Charts.Base.Chart	   LegendLocation$	 Bottom=�6#   $��0q�5V   %   $��1��5W   #   
   Series
 5Y        LiveCharts.Wpf.PieSeries    LiveCharts.Wpf.Series   Title$ 	Có sẵn��6,      Values;  5LiveCharts.Wpf.Converters.NumericChartValuesConverter$ 6 5Z          FontSize$ 14Q�5[          Fill �#9acbff   
DataLabels .    
LabelPoint 5^       �� *
PointLabel+  5_      $ Đang mượn��6,   $ 1 5`       $ 14Q�5a        �	#FF36A4ED .  5d       �� *
PointLabel+  5e      $ Thất lạc��6,   $ 3 5f   !   $ 14Q�5g   !    �#07209e .  5j   !   �� *
PointLabel+   ChartLegend 5l      "  LiveCharts.Wpf.DefaultLegend  5m      ���#07209e$��18(�6E      
BulletSize$ 18Q�6S   5o      5p      �� 5q      $��1��6   $��2��5r      $ 30��5s      ���#9acbff$	 0.3Q�5u      $��10q�5v      � 5x      $��1��6   $��2��5y      $��10q�5z      $ 1��5{        5|      �� 5}      $
��auto �6$   �� 5~      $��* �6$   .+�5�      �� $2��,Top 5 thể loại sách phổ biến nhất��6   $��5q�5�      $��Center=�5�      #��[  5�      #  LiveCharts.Wpf.CartesianChart  5�      $��5q�6%   $��1��60   $	��500��6=   
 6I   �� *Series+   AxisX 5�      	  LiveCharts.Wpf.Axis	   	  
Foreground �#07209e 	  FontSize$ 18Q�68    	  LabelFormatter 6F   �� *	Formatter+   AxisY 5�      	   �#07209e$ 18Q�68    	  Labels 6F   �� *Labels+   DataTooltip 5�      #
  LiveCharts.Wpf.DefaultTooltip
  5�       
  SelectionMode$ SharedYValuesX�6-   5�      5�      &   System.Windows.Controls.DataGrid  5�      -   5          Name$
 muon��5�      $��1��5�      $��5q�5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã đơn mượn��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6>   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   �� *MaMuon+  5�      $ Tên độc giả��6)   $ * 6>    6H   �� *TenDG+  5�      $ Tên nhân viên��6)   $ * 6@    6J   �� *TenNV+  5�      $ Ngày mượn��6)   $ * 6<    6F   �� *
NgayMuon+  5�      $ Ngày trả dự kiến��6)   $ * 6C    6M   �� *	NgayTraDK+  5�      $ Ngày trả thực tế��6)   $ * 6C    6M   �� *	NgayTraTT+  5�      $ Phí phạt (VND)��6)   $ * 6A    6K   �� *	PhiPhat+5�      �� 5�      $��0��6   $��2��5�      $ 30��5�      ���#9acbff$	 0.3Q�5�      $��10q�5�      � 5�      $��0��6   $��2��5�      $��10q�5�      $ 1��5�        5�      �� 5�      $
��auto �6$   �� 5�      $��* �6$   .+�5�      �� $>��8Thống kê số độc giả mượn sách hàng tháng��6   $��5q�5�      $��Center=�5�      #��[  5�        5�      $��5q�6%   $��1��60   $	��500��6=   
 6I   �� *
lineSeries+ 5�      	   �#07209e$ 18Q�68    6F   �� *Months+ 5�      	   �#07209e$ 18Q�68    6F   �� *	Formatter+ 5�      
  5�      $ SharedXValuesX�6-   5�      5�      5�      5�      5�      