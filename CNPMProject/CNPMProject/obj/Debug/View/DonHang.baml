   M S B A M L   `   `   `  ����F  BCNPMProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CNPMProjectCNPMProject  5   	       CNPMProject.DonHang   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CNPMProject     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	      $��Regular"�5
      $��18(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5       � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � Title$ Quản lý đơn hàng��5   	   $	��600��6"   $	��800��6/   ���#AFBFAE.��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryLight=�6'   ���#EB6D4A.��5      ]� .+�5      �� $��Right=�6!   
������  �� Orientation$ 
Horizontal=�6R    � 	Resources 5      	 �� 
TargetType
 �� Property �� Value��%�   '��       �� 5      "	 ��6$   .�5   "   �� 
 � ��$ 2 4 2 4q�6;   6M   �� 5    "   
 � ��$ 40��6:   6G   5!      5"      .+�5#      �� -   5        $��button_closewindow��5#   !    c� OverflowMode$ AsNeeded=�5$      
��� E����5#   ;   �� *CloseWindowCommand+.��5%      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ WindowClose=�66   5&      5'      �� 5)      $
��Left=�6!   $ 
Horizontal=�67   .+�5*      �� $��Center=�6$   $��16 0 0 0q�6?   ��6Q   �� *Tag+ �� ElementName$ ucControlBar��6�   5+      d� 5,       ' #MaterialDesignHamburgerToggleButton#���  5-      �� 5.      $��Center=�5/      $��16 0 0 0q�50      $
��Bold"�6   Quản lý đơn hàng52      53      54      55      � 56   
   $��1��6   .+�58      �  59      �� 5:      �� 5;      $
��auto �6$   �� 5<      $	��250 �6$   .+�5>      � $��0��6   .+�5?      �� $��Đơn hàng��5@        MaterialDesignGroupBox#���  5A      .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$
 Dark=�5B      $	��230��5C      $	��780��6&   $	��Top=�5D       � UseLayoutRounding .  J� SnapsToDevicePixels . $��
10,10,10,0q�5F       .��5G      #  MaterialDesignThemes.Wpf.Card  $	��180��6.   .��5H      � .+�5I   "   � $��0��6'    � ColumnDefinitions 5J   &   �� 5K   *   �� 5L   *   .+�5N   &   � $��0��6+    5O   *   �� 5P   .   �� 5Q   .   �� 5R   .   .+�5T   *   �� -   5        $��txt_madonhang��5V   !   $��Center=�5W      $��Center=�5X      $	��120��5Y      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã đơn hàng��5Z       % !MaterialDesignFloatingHintTextBox#��[ 5[      $��0��6>   �� 5\   *   -   5        $��
cb_madaily��5]   !   $��Center=�5^      $��Center=�5_      $	��120��5`      $ Mã đại lý��5a       & "MaterialDesignFloatingHintComboBox#��[ 5b      $��1��6?   5c   '   � 5d   &   $��1��6+    5e   *   �� 5f   .   �� 5g   .   �� 5h   .   .+�5m   *   (  "System.Windows.Controls.DatePicker  -   5        $��dp_ngaydangky��5o   -   {�.  $��Center=�5p   !   $
��Left=�5q      $	��150��5r      $ Ngày đăng ký��5s       ( $MaterialDesignFloatingHintDatePicker#��[ 5t      5u   '   5v   #   5�      5�      5�      5�      � 5�      $��1��6    5�      �� 5�      $	��400 �6+   �� 5�      .+�5�        $��0��6/   $��Bottom=�5�   /   $��70��5�      ���#AFBFAE.��5�      ]� .+�5�      �� $ 
Horizontal=�5�      +	  %MaterialDesignThemes.Wpf.RippleAssist 	  
IsCentered . .+�5�   "     $��Center=�5�   	   $��8 4 8 4q�5�   	      CornerRadius$ 2��5�   	    K� ZIndex$ 1��5�   	   $��16 0 0 0q�5�   	   +
  %MaterialDesignThemes.Wpf.ShadowAssist 
  ShadowDepth$ Depth1=�5�   	   .��5�   &   �  5�   *   �� 5�   .   $
��Auto �5�      �� 5�   .   $��* �5�      �� 5�   .   $
��Auto �5�      .+�5�   *   �� -   5        $��button_search��5�   -     MaterialDesignToolButton#���  5�      $
��Auto��6@   .��5�   .     $ Magnify=�5�       J� Opacity$	 .56Q�5�      5�   +   �� 5�   *   -   5        $��
txt_search��5�   -   $��1��5�      $��8 0 0 0q�5�      $��16(�5�   -   $ Search��5�      .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5�      $��0q�5�      $	��200��5�      $��Center=�5�      �� 5�   *   -   5        $��button_refresh��5�   -   #���  5�   -   $
��Auto��6`   $��Right=�6n   $��Center=�6�   $��1��6�   .��5�   .     $ Reload=�5�   1   5�   +   5�   '   5�   #   5�      5�      5�      � 5�      $��1��6    5�      �� 5�      �� 5�      �� 5�      .+�5�      �� -   5        $��
button_add��5�      $��0��5�      $��1��6-   ���#609194
�������$��18(�5�      
������� # MaterialDesignRaisedLightButton#��[ 5�      $��40��5�      $	��100��5�      $��Center=�5�      .��6Q   Thêm5�      �� 5�      -	   5        $��button_update��5�      $��1��5�      $��1��6-   ���#609194
�������$��18(�5�      
�������#��[ 5     $��40��5     $	��100��5     $��Center=�5     .��6T   Sửa5     �� 5     -
   5        $��button_delete��5     $��2��5	     $��1��6-   ���#609194
�������$��18(�5     
�������#��[ 5     $��40��5     $	��100��5     $��Center=�5     .��6T   Xóa5     5     5       5     $��2��6&   $	��240��63   $	��770��6@   .��5     &   System.Windows.Controls.DataGrid  -   5        $��
ds_donhang��5        CanUserSortColumns .    CanUserDeleteRows .     CanUserAddRows .     AutoGenerateColumns .  $
��auto��5        Columns 5     0  *System.Windows.Controls.DataGridTextColumn  5     ,  &System.Windows.Controls.DataGridColumn   Header$ Mã đơn hàng��5!      0	 ,MaterialDesignDataGridTextColumnEditingStyle1  +System.Windows.Controls.DataGridBoundColumn    EditingElementStyle#  [	 5"     !   Binding! 5      �� *	MaDonHang+5"     9  3MaterialDesignThemes.Wpf.MaterialDataGridTextColumn  5#     $ Mã đại lý��5%      5
 1MaterialDesignDataGridTextColumnPopupEditingStyle#  [
 5&     ! 5$     �� *	MaDaiLy+5&       5(     $ Ngày đăng ký��5*     #  [
 5+     ! 5)     �� *
NgayDangKy+5+     5.     5/     51     52     5E     5F     