   M S B A M L   `   `   `  ����F  BCNPMProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CNPMProjectCNPMProject  5   	       CNPMProject.MainWindow   5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CNPMProject     5   	   -   5        $��
mainWindow��5   	      MaterialDesignBody#���   5
   	   $��Regular"�5      $��18(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5       � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ Trang Chủ��5   	   $	��600��6   $	��800��6(   ���#AFBFAE.��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $��80 �6   �� 5      .+�5   
   � $��0��6   .+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryLight=�6'   ���#EB6D4A.��5      ]� .+�5      �� $��Right=�6!   
������  �� Orientation$ 
Horizontal=�6R   	 � 	Resources	 5       
 �� 
TargetType �� Property �� Value��%�   '��       �� 5!      "
 ��6$   .�5"   "   ��  � ��$ 2 4 2 4q�6;   6M   �� 5#   "    � ��$ 40��6:   6G   5$      5%      .+�5&      �� -   5        $��button_closewindow��5&   !    c� OverflowMode$ AsNeeded=�5'      
��� E����5&   ;   �� *CloseWindowCommand+.��5(      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ WindowClose=�66   5)      5*      �� 5,      $
��Left=�6!   $ 
Horizontal=�67   .+�5-      �� $��Center=�6$   $��16 0 0 0q�6?   ��6Q   �� *Tag+ �� ElementName$ ucControlBar��6�   5.      d� 5/       ' #MaterialDesignHamburgerToggleButton#���  50      �� 51      $��Center=�52      $��16 0 0 0q�53      $
��Bold"�6   Màn hình chính55      56      57      58      � 59   
   $��1��6    � ColumnDefinitions 5:      �� 5;      �� 5<      �� 5=      �� 5>      �� 5?      �� 5@      .+�5B      �� -   5        $��button_DaiLy��5C      $��0��5D      $
��auto��5E      $��70��5F      ���#609194
�������$��18(�5I      
���   �$��1q�5K       # MaterialDesignRaisedLightButton#��[ 5L      .��5M   !   
Đại lý5O      �� 5P      -   5        $��button_hanghoa��5Q      $��1��5R      $
��auto��5S      $��70��5T      ���#609194
�������$��18(�5W      
���   �$��1q�5Y      #��[ 5Z      .��5[   #   
Hàng hóa5]      �� 5^      -   5        $��button_hoadon��5_      $��2��5`      $
��auto��5a      $��70��5b      ���#609194
�������$��18(�5e      
���   �$��1q�5g      #��[ 5h      .��5i   #   
Hóa đơn5k      �� 5l      -   5        $��button_uudai��5m      $��3��5n      $
��auto��5o      $��70��5p      ���#609194
�������$��18(�5s      
���   �$��1q�5u      #��[ 5v      .��5w   "   	Ưu đãi5y      �� 5z      -   5        $��button_phieuthu��5{      $��4��5|      $
��auto��5}      $��70��5~      ���#609194
�������$��18(�5�      
���   �$��1q�5�      #��[ 5�      .��5�   %   Phiếu thu5�      �� 5�      -   5        $��button_donhang��5�      $��5��5�      $
��auto��5�      $��70��5�      ���#609194
�������$��18(�5�      
���   �$��1q�5�      #��[ 5�      .��5�   $   Đơn hàng5�      5�      �� 5�   
   
��� E��$��2��6+   $
��Bold"�5�       # MaterialDesignDisplay2TextBlock#��[ 5�      $��Center=�5�      $��Bottom=�61   Quản lý các đại lý5�      #  MaterialDesignThemes.Wpf.Card  5�   
   $��3��6   $	��330��6+   $	��500��68   $��Center=�6D   .��5�      � $��2��6   $��	0,0,0.4,0q�6    .+�5�      �� $O��Ihinh\cach-de-1-nguoi-ban-hang-online-tren-mang-cuc-ky-hot-bytuong-com.png��6   $	��289��6k   $	��343��6x   $��Center=�6�   $��Center=�6�   6�   �� 5�      $
��Bold"�5�      
���  �� # MaterialDesignHeadlineTextBlock#��[ 5�      $��Center=�5�      $��Bottom=�62   Admin5�      5�      5�      5�      5�      