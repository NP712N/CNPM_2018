   M S B A M L   `   `   `  ����F  BCNPMProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CNPMProjectCNPMProject  5   	   1clr-namespace:CNPMProject.VMLCNPMProject.VML  5   	       CNPMProject.Phieuthu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CNPMProject     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   'vmlclr-namespace:CNPMProject.VML  5   	      MaterialDesignBody#���   5	      $��Regular"�5
      $��18(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5       � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � Title$ Quản lý phiếu thu��5   	   $	��600��6#   $	��800��60   ���#AFBFAE.��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryLight=�6'   ���#EB6D4A.��5      ]� .+�5      �� $��Right=�6!   
������  �� Orientation$ 
Horizontal=�6R    � 	Resources 5      	 �� 
TargetType
 �� Property �� Value��%�   '��       �� 5       "	 ��6$   .�5!   "   �� 
 � ��$ 2 4 2 4q�6;   6M   �� 5"   "   
 � ��$ 40��6:   6G   5#      5$      .+�5%      �� -   5        $��button_closewindow��5%   !    c� OverflowMode$ AsNeeded=�5&      
��� E����5%   ;   �� *CloseWindowCommand+.��5'      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ WindowClose=�66   5(      5)      �� 5+      $
��Left=�6!   $ 
Horizontal=�67   .+�5,      �� $��Center=�6$   $��16 0 0 0q�6?   ��6Q   �� *Tag+ �� ElementName$ ucControlBar��6�   5-      d� 5.       ' #MaterialDesignHamburgerToggleButton#���  5/      �� 50      $��Center=�51      $��16 0 0 0q�52      $
��Bold"�6   Quản lý phiếu thu54      55      56      57      � 58   
   $��1��6   .+�59      �  5:      �� 5;      �� 5<      $
��auto �6$   �� 5=      $	��250 �6$   .+�5?      � $��0��6   .+�5@      �� $��Phiếu thu��5A        MaterialDesignGroupBox#���  5B      .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$
 Dark=�5C      $	��230��5D      $	��780��6&   $	��Top=�5E       � UseLayoutRounding .  J� SnapsToDevicePixels . $��
10,10,10,0q�5G       .��5H      #  MaterialDesignThemes.Wpf.Card  $	��180��6.   .��5I      �  5J   "   �� 5K   &   �� 5L   &   �� 5M   &    � ColumnDefinitions 5O   "   �� 5P   &   �� 5Q   &   .+�5T   "   �� -   5        $��txt_maphieuthu��5U   !   $	��Top=�5V      $��Center=�5W      $	��120��5X      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã phiếu thu��5Y       % !MaterialDesignFloatingHintTextBox#��[ 5Z      $��0��6>   $��0��6N   �� 5[   "   -   5        $��cb_mahoadon��5\   !   $	��Top=�5]      $��Center=�5^      $	��120��5_      $ Mã hóa đơn��5`       & "MaterialDesignFloatingHintComboBox#��[ 5a      $��0��6?   $��1��6O   �� 5b   "   -   5        $��txt_tienphaitra��5c   !   $	��Top=�5d      $
��Left=�5e      $	��120��5f      $ Tiền phải trả��5g      #��[ 5h      $��1��6>   $��1��6N   (  "System.Windows.Controls.DatePicker  5j   "   -   5        $��
dp_ngaylap��5k   %   {�.  $	��Top=�5m   !   $
��Left=�5n      $	��120��5o      $ Ngày lập��5p       ( $MaterialDesignFloatingHintDatePicker#��[ 5q      $��1��6A   � 5r   "   $��1��6'   .+�5s   &   �� $	��Top=�5t      $��Center=�6   $	��145��5u   %   $ Tiền nợ��5w      #��[ 5x      $��
96,0,321,0q�6>   5y   #   5z      5|      5      5�      � 5�      $��1��6    5�      �� 5�      $	��400 �6+   �� 5�      .+�5�        $��0��6/   $��Bottom=�5�   /   $��70��5�      ���#AFBFAE.��5�      ]� .+�5�      �� $ 
Horizontal=�5�      +	  %MaterialDesignThemes.Wpf.RippleAssist 	  
IsCentered . .+�5�   "     $��Center=�5�   	   $��8 4 8 4q�5�   	      CornerRadius$ 2��5�   	    K� ZIndex$ 1��5�   	   $��16 0 0 0q�5�   	   +
  %MaterialDesignThemes.Wpf.ShadowAssist 
  ShadowDepth$ Depth1=�5�   	   .��5�   &   �  5�   *   �� 5�   .   $
��Auto �5�      �� 5�   .   $��* �5�      �� 5�   .   $
��Auto �5�      .+�5�   *   �� -   5        $��button_search��5�   -     MaterialDesignToolButton#���  5�      .��5�   .     $ Magnify=�5�      5�   +   �� 5�   *   -   5        $��
txt_search��5�   -   $��1��5�      $��8 0 0 0q�5�      $��16(�5�   -   $ Search��5�      .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5�      $��0q�5�      $	��200��5�      $��Center=�5�      �� 5�   *   -   5        $��button_refresh��5�   -   #���  5�   -   $
��Auto��6`   $��Right=�6n   $��Center=�6�   $��1��6�   .��5�   .     $ Reload=�5�   1   5�   +   5�   '   5�   #   5�      5�      5�      � 5�      $��1��6    5�      �� 5�      �� 5�      �� 5�      .+�5�      �� -	   5        $��
button_add��5�      $��0��5�      $��1��6-   ���#609194
�������$��18(�5�      
������� # MaterialDesignRaisedLightButton#��[ 5�      $��40��5�      $	��100��5�      $��Center=�5�      .��6Q   Thêm5�      �� 5�      -
   5        $��button_update��5�      $��1��5�      $��1��6-   ���#609194
�������$��18(�5�      
�������#��[ 5�      $��40��5�      $	��100��5�      $��Center=�5�      .��6T   Sửa5�      �� 5�      -   5        $��button_delete��5�      $��2��5�      $��1��6-   ���#609194
�������$��18(�5�      
�������#��[ 5�      $��40��5�      $	��100��5�      $��Center=�5�      .��6T   Xóa5�      5�      5�        5�      $��2��6&   $	��240��63   $	��770��6@   .��5�      &   System.Windows.Controls.DataGrid  -   5        $��ds_phieuthu��5�         CanUserDeleteRows .     CanUserSortColumns .    CanUserAddRows .     AutoGenerateColumns .  $
��auto��5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã phiếu thu��5�       0	 ,MaterialDesignDataGridTextColumnEditingStyle1  +System.Windows.Controls.DataGridBoundColumn   EditingElementStyle# [	 5�          Binding  5�      �� *
MaPhieuThu+5�      9  3MaterialDesignThemes.Wpf.MaterialDataGridTextColumn  5�      $ Mã hóa đơn��5�       5
 1MaterialDesignDataGridTextColumnPopupEditingStyle# [
 5�        5�      �� *
MaHoaDon+5�        5     $ Ngày lập��5     # [
 5       5     �� *NgayLapPhieu+5       5     $ 
Tiền thu��5     # [
 5	       5     �� *SoTienDaThu+5
     5     5     5     5     5     5     